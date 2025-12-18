using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using HG_Vision.UIHome.RightForm;
using HG_Vision.UILogin;
using HG_Vision.UISetting;
using HG_Vision.UIVision;
using Model.DataModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Contol.Control_Sql;
using Microsoft.Win32;
using System.Linq;
using HG_Vision.Contol.Control_Vision;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIHome
{
    public partial class FrmHome : Form
    {
        #region 变量
        DateTime starttime = DateTime.Now;
        internal FrmMainVision FrmMainVision;
        internal FrmRightMain FrmRightMain;
        private volatile bool _isRunningFlag = false;//程序运行标志位

        private bool _isRightShowPageOpen = false;//右面板是否展开

        // PLC交互业务       
        private Task[] _taskPLCArray = new Task[Project.Instance.PLCManagerInstance.PLCNum];
        #endregion

        private FrmHome()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static readonly Lazy<FrmHome> _lazyInstance =
  new Lazy<FrmHome>(() => new FrmHome(), isThreadSafe: true);
        public static FrmHome Instance => _lazyInstance.Value;


        /// <summary>
        /// 禁止回车键触发了上次点击按钮的事件
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.Space)
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        /// <summary>
        /// 初始化加载右侧窗口集
        /// </summary>
        private void FrmRightFormInitial()
        {
            FrmRightMain = FrmRightMain.Instance;
            PanelRightMain.Controls.Add(FrmRightMain);
            FrmRightMain.ShowForm();
        }
        /// <summary>
        /// 刷新时间定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefreshDate_Tick(object sender, EventArgs e)
        {
            //获取当前系统时间-软件开启时间 = 运行时间
            DateTime _time = DateTime.Now;
            TimeSpan _runtimespan = (_time - starttime);
            // 计算总小时数（小时累加，不重置）
            int totalHours = (_runtimespan.Days * 24) + _runtimespan.Hours; // 将天数转换为小时并加上剩余小时
            int minutes = _runtimespan.Minutes; // 分钟部分（0-59）
            int seconds = _runtimespan.Seconds; // 秒部分（0-59）

            // 格式化时间为"小时:分钟:秒"，消除毫秒
            string _runtimespanstr = $"{totalHours}:{minutes:D2}:{seconds:D2}";
            StripStatusLabelTime.Text = "软件运行时间：" + _runtimespanstr;
        }

        /// <summary>
        /// 右侧面板向左向右变化
        /// </summary>
        /// <param name=""></param>
        private void OpenRightShowPage(bool bopen)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    try
                    {
                        if (bopen)
                        {
                            this.SplitContainer2.Panel2.Show();
                            this.SplitContainer1.SplitterDistance = this.SplitContainer1.Width - Project.Instance.GlobalManagerInstance.GlobalParamModel.PanelRightWidth - 1;
                            // ButtonShrinkPage.BackgroundImage = Resources.;
                        }
                        else
                        {
                            this.SplitContainer2.Panel2.Hide();
                            this.SplitContainer1.SplitterDistance = this.SplitContainer1.Width - this.ButtonShrinkPage.Width - 1;
                            //ButtonShrinkPage.BackgroundImage = Resources.向左_1;
                        }
                        _isRightShowPageOpen = bopen;

                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("右侧面板窗体展开出现异常", ex);
                    }
                }));
            }
        }

        /// <summary>
        /// 窗体最小化
        /// </summary>
        private void ChanggeWindowMin()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    this.NotifyIcon1.Visible = true;
            //    this.Visible = false;
            //    this.ShowInTaskbar = true;
            //}
        }


        /// <summary>
        /// 窗体控件值更改
        /// </summary>
        private void UpdateRunStateShow()
        {
            if (this.IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {
                    if (!_isRunningFlag)
                    {
                        StripStatusLabelStatus.Text = "暂停中";
                        StripStatusLabelStatus.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        StripStatusLabelStatus.Text = "运行中";
                        StripStatusLabelStatus.ForeColor = Color.LimeGreen;
                    }
                }));
            }
        }


        /// <summary>
        /// 登录权限更新事件
        /// </summary>
        private void AfterChangeUserLevel(string oldRoleName)
        {
            OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance.UserManagerInstance.CurrentUser.UserRoleName, OperationLogParamModel.LogCTypes[0], null, null, null, string.Format("{0}", "用户登录")));
            StripStatusLabelUser.Text = "当前角色：" + Project.Instance.UserManagerInstance.CurrentUser.UserRoleName;
            LogHelper.Info($"开启当前角色【{Project.Instance.UserManagerInstance.CurrentUser.UserRoleName}】登录计时");
            TimerLogout.Start();
            if (oldRoleName != Project.Instance.UserManagerInstance.CurrentUser.UserRoleName)
            {
                UserLevelControlEnabled();
            }
            this.ButtonLogin.BackgroundImage = Properties.Resources.切换用户;
        }

        private void SetSplitDistance()
        {
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer2.SplitterDistance = 16;
            this.SplitContainer2.SplitterWidth = 1;
        }

        /// <summary>
        /// 初始化默认加载视觉窗口
        /// </summary>
        private void FrmMainVisionInitial()
        {
            PanelVisionMain.Controls.Clear();
            FrmMainVision = FrmMainVision.Instance;
            FrmMainVision.Size = PanelVisionMain.Size;
            //加载视觉窗口          
            PanelVisionMain.Controls.Add(FrmMainVision);
            FrmMainVision.Show();
        }

        /// <summary>
        /// 启动定时任务
        /// </summary>
        private void StartScheduledTask()
        {
            Project.Instance.ScheduledTaskManagerInstance.OnRefreshHardWareStateDisplay = FrmHardWareState.Instance.RefreshHardWareStateDisplay;
            Project.Instance.ScheduledTaskManagerInstance.StartTask();
        }

        /// <summary>
        /// 启动存图线程
        /// </summary>
        private void StartSaveImage()
        {
            if (Project.Instance.VisionManagerInstance.CameraNum > 0)
            {
                //初始化保存图片线程
                Project.Instance.VisionManagerInstance.InitSaveImageThreads();
            }
        }

        /// <summary>
        /// 启动存储log4日志线程
        /// </summary>
        private void StartSaveLog4Log()
        {
            LogHelper.Instance().InitThread();
        }

        /// <summary>
        /// 启动操作日志记录线程
        /// </summary>
        private void StartSaveOperationLog()
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.saveOperationLogsByDB)
            {
                OperationLogDataBll.GetInstance().InitThread();
            }
        }

        /// <summary>
        /// 加载PLC
        /// </summary>
        private void LoadPLC()
        {
            //Project.Instance.PLCManagerInstance.plc1Service = new PLC1Service(this.components);
            //Project.Instance.PLCManagerInstance.plc2Service = new PLC2Service();
            //Project.Instance.PLCManagerInstance.plc4Service = new PLC4Service();
            //Project.Instance.PLCManagerInstance.();
            //Project.Instance.PLCManagerInstance.L_basePLCObjects.AddRange(new BasePLC[] { Project.Instance.PLCManagerInstance.plc1Service,
            //Project.Instance.PLCManagerInstance.plc2Service,    Project.Instance.PLCManagerInstance.plc4Service });
        }


        /// <summary>
        /// 开启PLC交互线程
        /// </summary>
        /// <param name="flag"></param>
        private void StartPLCThread(bool flag)
        {
            //foreach (CancellationTokenSource item in Project.Instance.PLCManagerInstance.L_PLCCtsServices)
            //{
            //    if (item != null)
            //        item.Cancel();
            //}
            //Project.Instance.PLCManagerInstance.cts1Service = new CancellationTokenSource();
            //Project.Instance.PLCManagerInstance.cts2Service = new CancellationTokenSource();
            //Project.Instance.PLCManagerInstance.L_PLCCtsServices.Clear();
            //Project.Instance.PLCManagerInstance.L_PLCCtsServices.AddRange(new CancellationTokenSource[] { Project.Instance.PLCManagerInstance.cts1Service, Project.Instance.PLCManagerInstance.cts2Service });
            ////(_taskPLCArray[0] = new Task(() => { Project.Instance.PLCManagerInstance.plc1Service.CommunicatingWithPlc(Project.Instance.PLCManagerInstance.L_PLCCtsServices[0].Token, flag, _isRunningFlag); })).Start();
            //(_taskPLCArray[1] = new Task(() => { Project.Instance.PLCManagerInstance.plc2Service.CommunicatingWithPlc(Project.Instance.PLCManagerInstance.L_PLCCtsServices[1].Token, flag, _isRunningFlag); })).Start();

        }

        /// <summary>
        /// 登录权限控件
        /// </summary>
        private void UserLevelControlEnabled()
        {
            //设置 相机参数设置 图像菜单栏 扫码菜单栏
            switch (Project.Instance.UserManagerInstance.CurrentUser.UserRoleName)
            {
                case "操作者":
                    {
                        ButtonSetting.Enabled = false;
                        ButtonVisionTool.Enabled = false;
                        ButtonPictureSetting.Enabled = false;

                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = false;
                        }
                    }
                    break;
                case "管理员":
                    {
                        //不允许
                        ButtonSetting.Enabled = !_isRunningFlag;
                        ButtonVisionTool.Enabled = !_isRunningFlag;
                        ButtonPictureSetting.Enabled = !_isRunningFlag;

                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = !_isRunningFlag;
                        }
                    }
                    break;
                case "工程师":
                    {
                        ButtonSetting.Enabled = !_isRunningFlag;
                        ButtonVisionTool.Enabled = !_isRunningFlag;
                        ButtonPictureSetting.Enabled = !_isRunningFlag;

                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = !_isRunningFlag;
                        }
                    }
                    break;
            }
        }
        #region 控件事件

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ProgramGerneral.FrmSplashScreen.CloseForm();

            //渲染各子窗体及控件
            OpenRightShowPage(!_isRightShowPageOpen);
            SetSplitDistance(); //定义好界面分割距离
            FrmMainVisionInitial(); //初始化默认加载视觉显示窗口       
            FrmRightFormInitial(); //初始化加载右侧窗口集
            UpdateRunStateShow();
            //设置程序标题
            LabelProgramTitle.Text = Project.Instance.GlobalManagerInstance.GlobalParamModel.programTitle + (Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel ? "  产品型号：" + Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel : "");
            NotifyIcon1.Text = LabelProgramTitle.Text;
            StartScheduledTask();//实例化定时器类         
            TimerRefreshDate.Start();//刷新时间显示
            StartSaveImage();//启动存图线程        
            StartSaveLog4Log();//启动log4net日志处理线程           
            StartSaveOperationLog();//判断启动操作日志记录线程
            //指示灯面板
            PanelTipLigthLoad();
            UserLevelControlEnabled(); //登录权限控件初始化
            NoticeHelper.OutputMessageSend("欢迎使用本软件！", OutputLevelModel.INFO);
        }

        /// <summary>
        /// 启动按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private delegate void tsbStartClickEventHandler(object sender, EventArgs e);

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new tsbStartClickEventHandler(ButtonStart_Click), new object[] { sender, e });
                return;
            }

            if (ToolTip1.GetToolTip(ButtonStart) == "启动")
            {
                try
                {
                    //检测PLC与数据库是否全部连接上
                    bool isRun = true;
                    //for (int i = 0; i < Project.Instance.PLCManagerInstance.L_basePLCObjects.Count; i++)
                    //{
                    //    isRun = isRun && Project.Instance.PLCManagerInstance.L_basePLCObjects[i].PLCConnectState;
                    //}
                    //for (int i = 0; i < Project.Instance.HardWareStateManagerInstance.L_sqlState.Count; i++)
                    //{
                    //    isRun = isRun && Project.Instance.HardWareStateManagerInstance.L_sqlState[i];
                    //}
                    for (int i = 0; i < Project.Instance.HardWareStateManagerInstance.L_robotState.Count; i++)
                    {
                        isRun = isRun && Project.Instance.ServerManagerInstance.GetAllDevice()[i].IsConnected;
                    }
                    if (isRun)
                    {
                        //关闭实时取向
                        FrmMainVision.stopLiveDisplay();
                        ToolTip1.SetToolTip(ButtonStart, "暂停");
                        //ButtonStart.Image = Resources.功能栏_程序开启56;
                        _isRunningFlag = true;
                        //登录权限控件初始化
                        UpdateRunStateShow();
                        UserLevelControlEnabled();
                        this.ButtonStart.BackgroundImage = Properties.Resources.暂停;
                        //开启线程
                        //StartPLCThread(true);
                    }
                    else
                    {
                        _isRunningFlag = false;
                        //this.ConfirmErrorDialog("PLC或数据库未连接，程序无法启动，请检查！");
                        this.ConfirmErrorDialog("机器人未连接，程序无法启动，请检查！");
                    }
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend(string.Format("错误：启动程序异常，原因：{0}", ex.Message), OutputLevelModel.ERROR);
                    LogHelper.Error(string.Format("错误：启动程序异常，原因：{0}", ex));
                }
            }
            else
            {
                try
                {
                    ToolTip1.SetToolTip(ButtonStart, "启动");
                    //ButtonStart.Image = Resources.功能栏_程序暂停56;
                    _isRunningFlag = false;
                    UpdateRunStateShow();
                    UserLevelControlEnabled();
                    this.ButtonStart.BackgroundImage = Properties.Resources.开始;
                    //开启线程
                    //StartPLCThread(false);
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend(string.Format("错误：停止程序异常，原因：{0}", ex.Message), OutputLevelModel.ERROR);
                    LogHelper.Error(string.Format("错误：停止程序异常，原因：{0}", ex));
                }
            }

        }

        private void ButtonVision_Click(object sender, EventArgs e)
        {
            if (!FrmMainVision.Visible)//如果没显示
            {
                //ButtonVision.Image = Resources.功能栏_相机界面64;
                FrmMainVision.Show();//视觉显示
            }
            else//如果显示了
            {
                FrmMainVision.Hide();//视觉隐藏
                //ButtonVision.Image = Resources.功能栏_数采界面57;
            }
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            FrmSetting.Instance.ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FrmLogin.Instance.OnAfterChangeUserRole += AfterChangeUserLevel;//登录窗体注册事件
            FrmLogin.Instance.ShowDialog();
        }
        private void ButtonMin_Click(object sender, EventArgs e)
        {
            ChanggeWindowMin();
        }


        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (this.QuestionInfoDialog("确定要退出程序？", "退出程序") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ButtonShrinkPage_Click(object sender, EventArgs e)
        {
            OpenRightShowPage(!_isRightShowPageOpen);
        }

        private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                this.Visible = true;
                this.NotifyIcon1.Visible = false;
            }
        }

        /// <summary>
        /// 指示灯面板
        /// </summary>
        private void PanelTipLigthLoad()
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(FrmHardWareState.Instance);
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //1.保存退出程序操作记录
                {
                    OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance.UserManagerInstance.CurrentUser.UserRoleName, OperationLogParamModel.LogCTypes[1], null, null, null, string.Format("{0}", "退出系统")));
                }
                //2.
                {
                    //清除定时器
                    Project.Instance.ScheduledTaskManagerInstance.ScheduledTaskDispose();
                    //关闭存图队列
                    Project.Instance.VisionManagerInstance.CloseSaveImageQueue();
                    //退出PLC业务类占用的资源
                    Project.Instance.PLCManagerInstance.Dispose();
                    //关闭相机
                    FrmHome.Instance.FrmMainVision.stopLiveDisplay();
                    FrmHome.Instance.FrmMainVision.Exit();
                    //关闭Visionpro资源
                    
                    //取消PLC业务逻辑线程token
                    //foreach (CancellationTokenSource item in Project.Instance.PLCManagerInstance.L_PLCCtsServices)
                    //{
                    //    if (item != null)
                    //    {
                    //        item.Cancel();
                    //        item.Dispose();
                    //    }
                    //}
                }
                //3.
                {
                    //停止时间显示定时器
                    if (null != TimerRefreshDate)
                        TimerRefreshDate.Dispose();
                    //停止日志消费队列
                    OperationLogDataBll.GetInstance().CloseQueue();
                }

                //释放服务器
                Project.Instance.ServerManagerInstance.StopAllDevices();
            }
            finally
            {
                //3.最后退出系统资源
                {
                    this.Dispose();//放此类占有的资源
                    this.Close();
                    System.GC.Collect();
                    Application.Exit();
                    System.Environment.Exit(System.Environment.ExitCode);
                }
            }
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            // 退出当前线程上的消息循环，并关闭该线程上的所有窗口。如果有线程正在运行，则无法正常退出
            Application.ExitThread();
            // 终止此进程，并将退出代码返回到操作系统。将强制退出所有正在运行的线程，彻底退出。
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 用于最小化后还原界面时界面控件显示卡顿
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHome_Resize(object sender, EventArgs e)
        {
            this.Refresh();
            this.Refresh();
            this.Refresh();
        }
        #endregion

        private void TimerLogout_Tick(object sender, EventArgs e)
        {
            TimerLogout.Stop();
            Project.Instance.UserManagerInstance.CurrentUser = Project.Instance.UserManagerInstance.DefultUser;
            StripStatusLabelUser.Text = "当前角色：" + Project.Instance.UserManagerInstance.CurrentUser.UserRoleName;
            UserLevelControlEnabled();
            this.ButtonLogin.BackgroundImage = Properties.Resources.未登录;
        }
        private void FrmHome_Activated(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser != Project.Instance.UserManagerInstance.DefultUser)
                TimerLogout.Start();
        }

        private void FrmHome_Deactivate(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser != Project.Instance.UserManagerInstance.DefultUser)
                TimerLogout.Stop();
        }

        private void ButtonVisionTool_Click(object sender, EventArgs e)
        {
            FrmVpVisionControl _form = FrmMainVision.FrmVpVisionControl1;
            if (_form.CurWorkFlow.SettingBlock != null)
            {
                FrmVppSetting VisionToolSettingForm = new FrmVppSetting(_form.CurWorkFlow, _form.VppName);
                VisionToolSettingForm.AfterSaveTool += _form.AfterSaveTool;
                VisionToolSettingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("SettingBlock！", "异常信息");
            }
        }

        private void ButtonPictureSetting_Click(object sender, EventArgs e)
        {
            FrmVpVisionControl _form = FrmMainVision.FrmVpVisionControl1;
            FrmImageStoreSettings FrmImageStoreSettings = new FrmImageStoreSettings(_form.VppName);

            FrmImageStoreSettings.ShowDialog();
        }
    }
}
