using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.BLL;
using VisionProgram.Main.ProjectClass.PLC;

using VisionProgram.Main.ProjectClass;
using VisionProgram.Models.DModels;
using VisionProgram.Models.VModels;
using VisionProgram.UI.Properties;
using VisionProgram.UI.UIDC;
using VisionProgram.UI.UIHome.RightForm;
using VisionProgram.UI.UILogin;

using VisionProgram.UI.UISetting;
using VisionProgram.UI.UIVision;
using VisionProgram.Main.ProjectClass.Vision.Global;

/****************************************************************

*****************************************************************/
namespace VisionProgram.UI.UIHome
{
    public partial class FrmHome : Form
    {
        #region 变量
        internal FrmMainVision FrmMainVision;
        internal FrmMainDC FrmMainDC;
        internal FrmRightMain FrmRightMain;
        private volatile bool _isRunningFlag = false;//程序运行标志位

        private bool _isRightShowPageOpen = false;//右面板是否展开

        // PLC交互业务       
        private Task[] _taskPLCArray = new Task[Project.Instance().PLCManagerInstance.PLCNum];

        #endregion

        private FrmHome()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            this.WindowState = FormWindowState.Maximized;


            //判断操作日志是否打印在数据库，若不是，则操作日志查询功能按钮动态消失，并其后面的按钮位置往前移动
            //框架中默认数据库是有的，所以操作日志查询按钮默认是在窗体上在的。        
            if (!Project.Instance().GlobalManagerInstance.GlobalParamModel.saveOperationLogsByDB)
            {
                //若图标栏上还要在最后追加功能按钮，则需要将新增的Button的tag进行赋值（值是在图标栏中按钮的顺序索引），则添加之后，请把添加的button再添加到下面的集合中。
                //Button[] arrayIconBarButton = new Button[Panel2.Controls.Count];
                //for (int i = 0; i < Panel2.Controls.Count; i++)
                //{
                //    Button button = (Button)(Panel2.Controls[i]);
                //    arrayIconBarButton[Convert.ToInt32(button.Tag)] = button;
                //}
                //List<Button> listButton = new List<Button>();
                //listButton.AddRange(arrayIconBarButton);
                //int index = listButton.IndexOf(ButtonSearchOpLog);
                //Panel2.Controls.Remove(ButtonSearchOpLog);
                //for (int i = listButton.Count - 1; i > index; i--)
                //    listButton[i].Location = listButton[i - 1].Location;
            }
        }


        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmHome _instance;
        public static FrmHome Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmHome();
                return _instance;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

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


        #region  方法
        private void FrmLoginSetEvent()
        {
            FrmLogin.Instance.OnAfterChangeUserRole += FrmLogin_AfterChangeUserLevel;
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
            //刷新时间显示
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            ToolStripStatusLabelDate.Text = date;
            ToolStripStatusLabelTime.Text = time;
            ToolStripStatusLabelWeek.Text = "";


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
                            this.SplitContainer1.SplitterDistance = this.SplitContainer1.Width - Project.Instance().GlobalManagerInstance.GlobalParamModel.PanelRightWidth - 1;
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
                        ToolStripStatusLabelRunMode.Text = "暂停";
                        ToolStripStatusLabelRunMode.ForeColor = Color.OrangeRed;
                    }
                    else
                    {
                        ToolStripStatusLabelRunMode.Text = "启动";
                        ToolStripStatusLabelRunMode.ForeColor = Color.LimeGreen;
                    }
                }));
            }
        }


        /// <summary>
        /// 登录权限更新事件
        /// </summary>
        private void FrmLogin_AfterChangeUserLevel(string oldRoleName)
        {
            OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName, OperationLogParamModel.LogCTypes[0], null, null, null, string.Format("{0}", "用户登录")));
            ToolStripStatusLabelUserRole.Text = Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName;

            if (oldRoleName != Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName)
            {
                UserLevelControlEnabled();
            }
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
            FrmMainDC = FrmMainDC.Instance;
            PanelVisionMain.Controls.Add(FrmMainDC);
        }

        /// <summary>
        /// 启动定时任务
        /// </summary>
        private void StartScheduledTask()
        {
            Project.Instance().ScheduledTaskManagerInstance.OnRefreshHardWareStateDisplay = FrmHardWareState.Instance.RefreshHardWareStateDisplay;
            Project.Instance().ScheduledTaskManagerInstance.StartTask();
        }

        /// <summary>
        /// 启动存图线程
        /// </summary>
        private void StartSaveImage()
        {
            if (Project.Instance().VisionManagerInstance.CameraNum > 0)
            {
                //初始化保存图片线程
                Project.Instance().VisionManagerInstance.InitSaveImageThreads();
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
            if (Project.Instance().GlobalManagerInstance.GlobalParamModel.saveOperationLogsByDB)
            {
                OperationLogDataBll.GetInstance().InitThread();
            }
        }

        /// <summary>
        /// 加载PLC
        /// </summary>
        private void LoadPLC()
        {
            //Project.Instance().PLCManagerInstance.plc1Service = new PLC1Service(this.components);
            //Project.Instance().PLCManagerInstance.plc2Service = new PLC2Service();
            //Project.Instance().PLCManagerInstance.plc4Service = new PLC4Service();
            //Project.Instance().PLCManagerInstance.();
            //Project.Instance().PLCManagerInstance.L_basePLCObjects.AddRange(new BasePLC[] { Project.Instance().PLCManagerInstance.plc1Service,
            //Project.Instance().PLCManagerInstance.plc2Service,    Project.Instance().PLCManagerInstance.plc4Service });
        }


        /// <summary>
        /// 开启PLC交互线程
        /// </summary>
        /// <param name="flag"></param>
        private void StartPLCThread(bool flag)
        {
            //foreach (CancellationTokenSource item in Project.Instance().PLCManagerInstance.L_PLCCtsServices)
            //{
            //    if (item != null)
            //        item.Cancel();
            //}
            //Project.Instance().PLCManagerInstance.cts1Service = new CancellationTokenSource();
            //Project.Instance().PLCManagerInstance.cts2Service = new CancellationTokenSource();
            //Project.Instance().PLCManagerInstance.L_PLCCtsServices.Clear();
            //Project.Instance().PLCManagerInstance.L_PLCCtsServices.AddRange(new CancellationTokenSource[] { Project.Instance().PLCManagerInstance.cts1Service, Project.Instance().PLCManagerInstance.cts2Service });
            ////(_taskPLCArray[0] = new Task(() => { Project.Instance().PLCManagerInstance.plc1Service.CommunicatingWithPlc(Project.Instance().PLCManagerInstance.L_PLCCtsServices[0].Token, flag, _isRunningFlag); })).Start();
            //(_taskPLCArray[1] = new Task(() => { Project.Instance().PLCManagerInstance.plc2Service.CommunicatingWithPlc(Project.Instance().PLCManagerInstance.L_PLCCtsServices[1].Token, flag, _isRunningFlag); })).Start();

        }

        /// <summary>
        /// 登录权限控件
        /// </summary>
        private void UserLevelControlEnabled()
        {
            //设置 相机参数设置 图像菜单栏 扫码菜单栏
            switch (Project.Instance().UserInfoManagerInstance.LoginUser.UserRole)
            {
                case "A-Operator":
                    {
                        controlFrmVisionControl(false);
                        ButtonSetting.Enabled = false;
                        //ButtonPlcTest.Enabled = false;
                        //ButtonPlcMonitor.Enabled = false;
                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = false;
                        }
                    }
                    break;
                case "B-Admin":
                    {
                        //不允许
                        controlFrmVisionControl(false);
                        ButtonSetting.Enabled = !_isRunningFlag;
                        //ButtonPlcTest.Enabled = false;
                        //ButtonPlcMonitor.Enabled = _isRunningFlag;
                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = !_isRunningFlag;
                        }
                    }
                    break;
                case "C-Technician":
                    {
                        controlFrmVisionControl(!_isRunningFlag);
                        ButtonSetting.Enabled = !_isRunningFlag;
                        //ButtonPlcTest.Enabled = !_isRunningFlag;
                        //ButtonPlcMonitor.Enabled = _isRunningFlag;
                        for (int i = 0; i < GlobalCameraParams.toolStripMenuItem.Count; i++)
                        {
                            GlobalCameraParams.toolStripMenuItem[i].Enabled = !_isRunningFlag;
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// 视觉图像菜单栏按钮权限控制
        /// </summary>
        /// <param name="isEnabled"></param>
        public void controlFrmVisionControl(bool isEnabled)
        {

        }

        #endregion

        #region 控件事件

        private void FrmHome_Load(object sender, EventArgs e)
        {
            ProgramGerneral.SplashScreen.CloseForm();

            //渲染各子窗体及控件
            OpenRightShowPage(!_isRightShowPageOpen);
            SetSplitDistance(); //定义好界面分割距离
            FrmMainVisionInitial(); //初始化默认加载视觉显示窗口       
            FrmRightFormInitial(); //初始化加载右侧窗口集
            UpdateRunStateShow();
            //设置程序标题
            LabelProgramTitle.Text = Project.Instance().GlobalManagerInstance.GlobalParamModel.programTitle + (Project.Instance().GlobalManagerInstance.GlobalParamModel.useProductModel ? "  产品型号：" + Project.Instance().GlobalManagerInstance.GlobalParamModel.curProductModel : "");
            NotifyIcon1.Text = LabelProgramTitle.Text;
            //刷新软件开启时间
            ToolStripStatusLabelStartTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            StartScheduledTask();//实例化定时器类         
            TimerRefreshDate.Start();//刷新时间显示         
            FrmLoginSetEvent();//登录窗体注册事件            
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
                    //for (int i = 0; i < Project.Instance().PLCManagerInstance.L_basePLCObjects.Count; i++)
                    //{
                    //    isRun = isRun && Project.Instance().PLCManagerInstance.L_basePLCObjects[i].PLCConnectState;
                    //}
                    //for (int i = 0; i < Project.Instance().HardWareStateManagerInstance.L_sqlState.Count; i++)
                    //{
                    //    isRun = isRun && Project.Instance().HardWareStateManagerInstance.L_sqlState[i];
                    //}
                    for (int i = 0; i < Project.Instance().HardWareStateManagerInstance.L_robotState.Count; i++)
                    {
                        isRun = isRun && Project.Instance().RobotManagerInstance.L_Robot[i].IsConnectedRobot[0];
                    }
                    if (isRun)
                    {
                        //关闭实时取向
                        FrmMainVision.stopLiveDisplay();
                        ToolTip1.SetToolTip(ButtonStart, "暂停");
                        //ButtonStart.Image = Resources.功能栏_程序开启56;
                        _isRunningFlag = true;
                        //登录权限控件初始化
                        UserLevelControlEnabled();
                        UpdateRunStateShow();
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
                    UserLevelControlEnabled();
                    UpdateRunStateShow();
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
                FrmMainDC.Hide();//数采隐藏
                //ButtonVision.Image = Resources.功能栏_相机界面64;
                FrmMainVision.Show();//视觉显示
            }
            else//如果显示了
            {
                FrmMainVision.Hide();//视觉隐藏
                //ButtonVision.Image = Resources.功能栏_数采界面57;
                FrmMainDC.Show();//数采显示
            }
        }

        private void ButtonSetting_Click(object sender, EventArgs e)
        {
            FrmSetting.Instance.ShowDialog();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            FrmLogin.Instance.ShowDialog();
        }

        private void ButtonPlcTest_Click(object sender, EventArgs e)
        {
            if (FrmPlcCommTest.Instance.IsFormOpen)
            {
                this.ConfirmErrorDialog("PLC读写测试窗体已打开！");
                return;
            }
            FrmPlcCommTest.Instance.Show();
        }

        private void ButtonPlcMonitor_Click(object sender, EventArgs e)
        {
            if (FrmPlcCommMonitor.Instance.IsFormOpen)
            {
                this.ConfirmErrorDialog("PLC实时监控窗体已打开！");
                return;
            }
            FrmPlcCommMonitor.Instance.Show();
        }

        //private void ButtonSearchOpLog_Click(object sender, EventArgs e)
        //{
        //    if (FrmOperationLogQuery.Instance.IsFormOpen)
        //    {
        //        this.ConfirmErrorDialog("操作日志查询窗体已打开！");
        //        return;
        //    }
        //    FrmOperationLogQuery.Instance.Show();
        //}

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
                    OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName, OperationLogParamModel.LogCTypes[1], null, null, null, string.Format("{0}", "退出系统")));
                }
                //2.
                {
                    //清除定时器
                    Project.Instance().ScheduledTaskManagerInstance.ScheduledTaskDispose();
                    //关闭存图队列
                    Project.Instance().VisionManagerInstance.CloseSaveImageQueue();
                    //退出PLC业务类占用的资源
                    Project.Instance().PLCManagerInstance.Dispose();
                    //关闭相机
                    FrmHome.Instance.FrmMainVision.stopLiveDisplay();
                    FrmHome.Instance.FrmMainVision.Exit();
                    //取消PLC业务逻辑线程token
                    //foreach (CancellationTokenSource item in Project.Instance().PLCManagerInstance.L_PLCCtsServices)
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

                //释放机器人
                int nRobotNum = Project.Instance().RobotManagerInstance.L_Robot.Count;
                for (int i = 0; i < nRobotNum; i++)
                {
                    if (Project.Instance().RobotManagerInstance.L_Robot[i] != null)
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[i].StopServer();

                    }
                }
                Project.Instance().RobotManagerInstance.L_Robot.Clear();
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
    }
}
