using BaseSocket;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Model.EnumModel;
using Obj.Obj_File;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

/****************************************************************

*****************************************************************/
namespace HG_Vision
{
    public partial class FrmVppSetting : Form // 内含旋转标定相关代码暂未实现
    {
        #region 字段
        //1个服务器-2个机器人-1个VPP
        private IniHelper _iniRotation;//配置文件
        private WorkFlow1 cur_WorkFlow;
        CogAcqFifoTool acq;//取相
        Cognex.VisionPro.ToolBlock.CogToolBlock _linear_UnCalibrate_block;//线性标定块
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool;//线性标定工具1
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool1;//线性标定工具2
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool2;//线性标定工具3
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool3;//线性标定工具4
        CogFitCircleTool _rotation_calib_tool;//拟合圆
        CogFitCircleTool _rotation_calib_tool1;//拟合圆
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_caculate_block;//旋转中心标定块
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_UnCalibrated_block;//旋转中心标定工具
        CogGraphicLabel cogGraphicLabel1, cogGraphicLabel2;//绘制轨迹
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_caculate_block1;//旋转中心标定块
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_UnCalibrated_block1;//旋转中心标定工具
        CogGraphicLabel cogGraphicLabel11, cogGraphicLabel21;//绘制轨迹
        CogImageFileTool mImageFile = new CogImageFileTool();        //图片工具

        int vppindex;//当前相机索引
        int nozzleIndex;//当前吸嘴索引
        ICogImage img;//图像
        /// <summary>
        /// 工具保存之后发生的事件
        /// </summary>
        public delegate void AfterSaveToolEventHandler();
        public event AfterSaveToolEventHandler AfterSaveTool;
        delegate void RefleshTextMsgBoxCallback(string str);
        delegate void RefleshDataGridViewCallback();


        bool _b_Auto_Linear = false;//线性标定状态
        bool _b_Auto_Rotation = false;//旋转中心标定状态
        bool _inAuto = false; //是否处于自动九点标定状态中

        int _laserIndex = 0;//激光九点标定时标记当前圆位置
        private string module_X = "";//当前机构实际坐标X
        public string Model_X
        {
            get { return module_X; }
        }
        private string module_Y = "";//当前机构实际坐标Y
        public string Model_Y
        {
            get { return module_Y; }
        }
        private double RotationCenter_X;//旋转中心X
        private double RotationCenter_Y;//旋转中心Y
        private double Linear_RMS;//九点误差
        private double Rotation_RMS;//旋转中心误差
        private bool _Linear_State = false;//九点标定状态
        private bool _Rotation_State = false;//旋转中心标定状态
        private static System.Threading.Timer timer1 = null;//刷新实时监测信息
        private static System.Threading.Timer timer2 = null;//刷新实时监测信息
        SynchronizationContext sync_context = null;   //采用同步上下文方式更改UI线程中属性

        private CancellationTokenSource cts1;                                       //设置取消操作
        private CancellationTokenSource cts2;                                      //设置取消操作

        #endregion

        #region 窗体
        public FrmVppSetting(WorkFlow1 wf, string vpp_name)
        {
            InitializeComponent();
            cur_WorkFlow = wf;
            this.Text = "CCD" + vpp_name + "工具设置";
            sync_context = SynchronizationContext.Current;
            vppindex = Convert.ToInt32(vpp_name) - 1;
        }
        private void FrmVppSetting_Load(object sender, EventArgs e)
        {
            this.cogToolBlockEditV21.Subject = cur_WorkFlow.SettingBlock;
            acq = cur_WorkFlow.AcquireBlock.Tools["相机取像工具*"] as CogAcqFifoTool;
            _linear_UnCalibrate_block = cur_WorkFlow.LinearCalibBlock.Tools["将未标定点位坐标算上畸变校正*"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
            _linear_calib_tool = cur_WorkFlow.LinearCalibBlock.Tools["机械手1标定工具*"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool1 = cur_WorkFlow.LinearCalibBlock.Tools["机械手2标定工具*"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool2 = cur_WorkFlow.LinearCalibBlock.Tools["激光1标定工具*"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool3 = cur_WorkFlow.LinearCalibBlock.Tools["激光2标定工具*"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            cogGraphicLabel1 = new CogGraphicLabel();
            cogGraphicLabel1.SelectedSpaceName = "#";
            cogGraphicLabel1.Alignment = CogGraphicLabelAlignmentConstants.BaselineLeft;
            cogGraphicLabel1.Color = CogColorConstants.Blue;
            cogGraphicLabel1.Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);

            cogGraphicLabel2 = new CogGraphicLabel();
            cogGraphicLabel2.SelectedSpaceName = "#";
            cogGraphicLabel2.Alignment = CogGraphicLabelAlignmentConstants.BaselineLeft;
            cogGraphicLabel2.Color = CogColorConstants.Blue;
            cogGraphicLabel2.Font = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            //默认PLC标定、默认单帧
            rdo_Li_Snap.Checked = true;
            rdo_Ro_Snap.Checked = true;
            rdo_Li_Robot1.Checked = true;
            rdo_Ro_Robot1.Checked = true;
            //默认标定模式为手动
            SetLinearCalibMode(0);
            SetRotationCalibMode(false);
            //当前吸嘴Index
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                this.cbb_Ro_Nozzle.Items.Add(i + 1);
            }
            this.cbb_Ro_Nozzle.SelectedIndex = 0;

            nozzleIndex = Convert.ToInt32(this.cbb_Ro_Nozzle.Text) - 1;
            ////激光九点标定触发点位初始化
            //RobotSignalsModel.Laser1NinePointStr =
            //    "_OK;" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX0[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY0[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX1[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY1[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX2[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY2[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX3[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY3[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX4[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY4[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX5[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY5[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX6[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY6[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX7[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY7[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX8[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY8[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibX9[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L1CalibY9[0].ToString() + "#";
            //RobotSignalsModel.Laser2NinePointStr =
            //    "_OK;" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX0[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY0[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX1[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY1[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX2[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY2[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX3[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY3[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX4[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY4[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX5[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY5[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX6[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY6[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX7[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY7[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX8[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY8[0].ToString() + "#"
            //        + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibX9[0].ToString() + "%" + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L2CalibY9[0].ToString() + "#";

            //开启服务器接收事件
            RobotSignalsModel.CCDProcess = 1;
            Project.Instance.RobotManagerInstance.L_Robot[0].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
            Project.Instance.RobotManagerInstance.L_Robot[1].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
            Project.Instance.RobotManagerInstance.L_Robot[2].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);
            //九点标定结果刷新
            //Rotation标定结果刷新
            //Rotation标定结果刷新
            if (vppindex == 0)
            {
                //RotationCenter_X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[nozzleIndex];
                //RotationCenter_Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[nozzleIndex];
                //Rotation_RMS = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[nozzleIndex];
            }
            else if (vppindex == 1)
            {
                //后续多相机扩展
            }
            //....

            RefleshLinearDataGridView();
            RefleshRotationDataGridView();
            //刷新UI控件Timer_Task1定时器开启    
            if (timer1 == null)
            {
                timer1 = new System.Threading.Timer(ControlFlush1, null, 0, Timeout.Infinite);
            }
            Project.Instance.RobotManagerInstance.SetStop(false);
        }
        private void FrmVppSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult _result = MessageBox.Show("退出之前是否保存设置", "提示", MessageBoxButtons.YesNoCancel);
            if (_result == DialogResult.Yes)
            {
                //关闭服务器接收事件
                RobotSignalsModel.CCDProcess = 0;
                Project.Instance.RobotManagerInstance.L_Robot[0].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
                Project.Instance.RobotManagerInstance.L_Robot[1].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
                Project.Instance.RobotManagerInstance.L_Robot[2].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);

                if (cur_WorkFlow.SaveTools())
                {
                    cogToolBlockEditV21.Subject = null;
                    AfterSaveTool?.Invoke();
                }
                if (cts1 != null)
                {
                    cts1.Cancel();
                    cts1.Dispose();
                    cts1 = null;
                }
                if (cts2 != null)
                {
                    cts2.Cancel();
                    cts2.Dispose();
                    cts2 = null;
                }
                if (timer1 != null)
                {
                    timer1.Dispose();
                    timer1 = null;
                }
                if (timer2 != null)
                {
                    timer2.Dispose();
                    timer2 = null;
                }
            }
            else if (_result == DialogResult.No)
            {
                //关闭服务器接收事件
                RobotSignalsModel.CCDProcess = 0;
                Project.Instance.RobotManagerInstance.L_Robot[0].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
                Project.Instance.RobotManagerInstance.L_Robot[1].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
                Project.Instance.RobotManagerInstance.L_Robot[2].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);


                if (cts1 != null)
                {
                    cts1.Cancel();
                    cts1.Dispose();
                    cts1 = null;
                }
                if (cts2 != null)
                {
                    cts2.Cancel();
                    cts2.Dispose();
                    cts2 = null;
                }
                if (timer1 != null)
                {
                    timer1.Dispose();
                    timer1 = null;
                }
                if (timer2 != null)
                {
                    timer2.Dispose();
                    timer2 = null;
                }
                //e.Cancel = true;
            }
            else if (_result == DialogResult.Cancel)
            {
                // 取消关闭操作，窗体保持打开
                e.Cancel = true;
                return; // 直接返回，无需执行资源清理
            }
        }
        /// <summary>
        /// 重写窗体参数，防止闪烁(无需显式调用)
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }
        #endregion
        #region 控件刷新
        /// <summary>
        /// UI线程控件刷新1
        /// </summary>
        /// <param name="obj"></param>
        private void ControlFlush1(object obj)
        {
            //控件变色显示状态
            SendOrPostCallback callback1 = o =>
            {
                if (tab_C_VisionTool.SelectedTab == tab_VisionLinear)
                {
                    //当前相机对应机器人是否连接成功
                    if (rdo_Li_Robot1.Checked)
                    {
                        if (!Project.Instance.RobotManagerInstance.L_Robot[0].IsConnected)
                            rdo_Li_Robot1.BackColor = Color.Red;
                        else
                            rdo_Li_Robot1.BackColor = Color.LimeGreen;
                    }
                    else
                        rdo_Li_Robot1.BackColor = Color.Transparent;

                    if (rdo_Li_Robot2.Checked)
                    {
                        if (!Project.Instance.RobotManagerInstance.L_Robot[1].IsConnected)
                            rdo_Li_Robot2.BackColor = Color.Red;
                        else
                            rdo_Li_Robot2.BackColor = Color.LimeGreen;
                    }
                    else
                        rdo_Li_Robot2.BackColor = Color.Transparent;

                    //注意此处Laser1和Laser2只有振镜偏移位置作区分，实际只有一个激光器
                    if (rdo_Li_Laser1.Checked || rdo_Li_Laser2.Checked)
                    {
                        if (!Project.Instance.LaserManagerInstance.L_Laser[0].IsConnectedLaser)
                        {
                            rdo_Li_Laser1.BackColor = Color.Red;
                            rdo_Li_Laser2.BackColor = Color.Red;
                        }
                        else
                        {
                            rdo_Li_Laser1.BackColor = Color.LimeGreen;
                            rdo_Li_Laser2.BackColor = Color.LimeGreen;
                        }
                    }
                    else
                    {
                        rdo_Li_Laser1.BackColor = Color.Transparent;
                        rdo_Li_Laser2.BackColor = Color.Transparent;
                    }

                    //在TextBox中更新显示坐标
                    //标定
                    if (rdo_Li_Auto.Checked || rdo_Li_Manual.Checked)
                    {
                        tb_Li_X.Text = module_X;
                        tb_Li_Y.Text = module_Y;
                    }
                    //验证
                    else if (rdo_Li_Verificate.Checked)
                    {
                        tb_Li_X.Text = currunt_CenterX.ToString();
                        tb_Li_Y.Text = currunt_CenterX.ToString();
                    }
                    //更新标定误差与标定偏移量
                    if (rdo_Li_Robot1.Checked)
                    {
                        tb_Li_RMS.Text = _linear_calib_tool.Calibration.ComputedRMSError.ToString("f3");
                        tb_Li_Step.Text = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep.ToString("f3");
                    }
                    else if (rdo_Li_Robot2.Checked)
                    {
                        tb_Li_RMS.Text = _linear_calib_tool1.Calibration.ComputedRMSError.ToString("f3");
                        tb_Li_Step.Text = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep.ToString("f3");
                    }
                    else if (rdo_Li_Laser1.Checked)
                    {
                        tb_Li_RMS.Text = _linear_calib_tool2.Calibration.ComputedRMSError.ToString("f1");
                        tb_Li_Step.Text = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep.ToString("f3");
                    }
                    else if (rdo_Li_Laser2.Checked)
                    {
                        tb_Li_RMS.Text = _linear_calib_tool3.Calibration.ComputedRMSError.ToString("f1");
                        tb_Li_Step.Text = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep.ToString("f3");
                    }
                }
                else if (tab_C_VisionTool.SelectedTab == tab_VisionRotation)
                {
                    //当前相机对应机器人是否连接成功
                    if (rdo_Ro_Robot1.Checked)
                    {
                        if (!Project.Instance.RobotManagerInstance.L_Robot[0].IsConnected)
                            rdo_Ro_Robot1.BackColor = Color.Red;
                        else
                            rdo_Ro_Robot1.BackColor = Color.LimeGreen;
                    }
                    else
                        rdo_Ro_Robot1.BackColor = Color.Transparent;

                    if (rdo_Ro_Robot2.Checked)
                    {
                        if (!Project.Instance.RobotManagerInstance.L_Robot[1].IsConnected)
                            rdo_Ro_Robot2.BackColor = Color.Red;
                        else
                            rdo_Ro_Robot2.BackColor = Color.LimeGreen;
                    }
                    else
                        rdo_Ro_Robot2.BackColor = Color.Transparent;

                    //更新旋转中心坐标
                    tb_Ro_X.Text = RotationCenter_X.ToString("f4");
                    tb_Ro_Y.Text = RotationCenter_Y.ToString("f4");
                    //更新旋转中心误差
                    tb_Ro_RMS.Text = Rotation_RMS.ToString("f4");
                }
            };
            sync_context.Post(callback1, null);
            if (timer1 != null)
            {
                //手动重新设定计时器，使线程回归线程池
                timer1.Change(350, Timeout.Infinite);
            }
        }
        #endregion
        #region 窗体控件事件处理方法
        #region 畸变校正
        /// <summary>
        /// 相机采图(畸变)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Di_Acq_Click(object sender, EventArgs e)
        {
            //运行采图；
            cur_WorkFlow.RunAcquireBlock(out img);
            cogRecordDisplayDistortion.Image = null;
            cogRecordDisplayDistortion.Image = img;
            cogRecordDisplayDistortion.Fit(true);
        }
        /// <summary>
        /// 文件取图(畸变)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Di_FileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:/";
            ofd.Filter = ".BMP(*.MBP)|*BMP";
            ofd.FileName = ".BMP";
            //打开相机图片
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mImageFile.Operator.Open(ofd.FileName, CogImageFileModeConstants.Read);
                mImageFile.Run();
                img = mImageFile.OutputImage;
                cogRecordDisplayDistortion.Image = null;
                cogRecordDisplayDistortion.Image = img;
                cogRecordDisplayDistortion.Fit(true);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 畸变矫正
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Di_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("是否进行畸变矫正", "提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                bool dc = cur_WorkFlow.RunDistortionCalibBlock(ref img);
                if (cogRecordDisplayDistortion.Image != null)
                {
                    cogRecordDisplayDistortion.StaticGraphics.Clear();
                    cogRecordDisplayDistortion.InteractiveGraphics.Clear();
                }
                cogRecordDisplayDistortion.Image = img;
                bool st = cur_WorkFlow.SaveTools();
                if (dc && st)
                {
                    MessageBox.Show("畸变矫正成功,保存结果成功！");
                }
            }
            catch
            {
                MessageBox.Show("畸变矫正失败，请重新标定！");
            }
        }
        #endregion
        #region 线性标定
        //连接对象枚举
        private void rdo_Li_Robot1_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：ROBOT1");
            this.rdo_Li_Robot2.BackColor = Color.Transparent;
            this.rdo_Li_Laser1.BackColor = Color.Transparent;
            this.rdo_Li_Laser2.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }
        private void rdo_Li_Robot2_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：ROBOT2");
            this.rdo_Li_Laser1.BackColor = Color.Transparent;
            this.rdo_Li_Laser2.BackColor = Color.Transparent;
            this.rdo_Li_Robot1.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }
        private void rdo_Li_Laser1_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：LASER振镜角度1");
            this.rdo_Li_Robot2.BackColor = Color.Transparent;
            this.rdo_Li_Laser2.BackColor = Color.Transparent;
            this.rdo_Li_Robot1.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }
        private void rdo_Li_Laser2_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：LASER振镜角度2");
            this.rdo_Li_Laser1.BackColor = Color.Transparent;
            this.rdo_Li_Robot2.BackColor = Color.Transparent;
            this.rdo_Li_Robot1.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }
        /// <summary>
        /// 选中手动九点标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Li_Manual_Click(object sender, EventArgs e)
        {
            SetLinearCalibMode(0);
        }
        /// <summary>
        /// 选中自动九点标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Li_Auto_Click(object sender, EventArgs e)
        {
            SetLinearCalibMode(1);
        }
        /// <summary>
        /// 选中标定验证模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Li_Verificate_Click(object sender, EventArgs e)
        {
            SetLinearCalibMode(2);
        }
        /// <summary>
        /// 单帧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Li_Snap_CheckedChanged(object sender, EventArgs e)
        {
            btn_Li_Acq.Text = "采集图像";
            btn_Li_Acq.BackColor = Color.FromArgb(80, 160, 255);
        }
        /// <summary>
        /// 实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Li_Live_CheckedChanged(object sender, EventArgs e)
        {
            btn_Li_Acq.Text = "实时采集";
            btn_Li_Acq.BackColor = Color.FromArgb(220, 155, 40);
        }
        /// <summary>
        /// 开始自动标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                if (_b_Auto_Linear)
                {
                    return;
                }
                if (!Project.Instance.HardWareStateManagerInstance.L_ccdState[vppindex])
                {
                    MessageBox.Show("CCD未链接!");
                    return;
                }

                if (rdo_Li_Robot1.Checked)
                {
                    bool bIsConnected = Project.Instance.RobotManagerInstance.L_Robot[0].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + 1 + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    try
                    {
                        //Project.Instance.RobotManagerInstance.L_Robot[0].SendText(RobotSignalsModel.CCDRobotCalStart, 0);
                        RefleshLinearTextMsgBox("rob1九点标定开启......");
                    }
                    catch
                    {
                        RefleshLinearTextMsgBox("CCD自动九点标定模式catch......");
                    }
                    #endregion
                    if (rdo_Li_Auto.Checked)
                    {
                        if (!Clear_Linear(eLinearCalib_Link.Robot1))
                        {
                            return;
                        }
                    }
                }
                else if (rdo_Li_Robot2.Checked)
                {
                    bool bIsConnected = Project.Instance.RobotManagerInstance.L_Robot[1].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + 2 + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    try
                    {
                        //Project.Instance.RobotManagerInstance.L_Robot[1].SendText(RobotSignalsModel.CCDRobotCalStart, 0);
                        RefleshLinearTextMsgBox("rob2九点标定开启......");
                    }
                    catch
                    {
                        RefleshLinearTextMsgBox("CCD自动九点标定模式catch......");
                    }
                    #endregion

                    if (rdo_Li_Auto.Checked)
                    {
                        if (!Clear_Linear(eLinearCalib_Link.Robot2))
                        {
                            return;
                        }
                    }

                }
                else if (rdo_Li_Laser1.Checked)
                {
                    bool bIsConnected = Project.Instance.RobotManagerInstance.L_Robot[2].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("LASER" + ":未链接!");
                        return;
                    }
                    if (!Clear_Linear(eLinearCalib_Link.Laser1))
                    {
                        return;
                    }
                }
                else if (rdo_Li_Laser2.Checked)
                {
                    bool bIsConnected = Project.Instance.RobotManagerInstance.L_Robot[2].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("LASER" + ":未链接!");
                        return;
                    }
                    if (!Clear_Linear(eLinearCalib_Link.Laser2))
                    {
                        return;
                    }

                }

                _b_Auto_Linear = true;
                RobotSignalsModel.CCDRobotCal = "0";


                RefleshLinearTextMsgBox("CCD自动九点线性标定模式开启......");
            }
            catch (Exception ex)
            {
                RefleshLinearTextMsgBox(ex.ToString());
            }
        }
        /// <summary>
        /// 采集图像(九点)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Acq_Click(object sender, EventArgs e)
        {
            Acq_Linear();
        }
        /// <summary>
        /// 清除九点标定点数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Clear_Click(object sender, EventArgs e)
        {
            if (rdo_Li_Robot1.Checked)
            {
                Clear_Linear(eLinearCalib_Link.Robot1);
            }
            else if (rdo_Li_Robot2.Checked)
            {
                Clear_Linear(eLinearCalib_Link.Robot2);
            }
            else if (rdo_Li_Laser1.Checked)
            {
                Clear_Linear(eLinearCalib_Link.Laser1);
            }
            else if (rdo_Li_Laser2.Checked)
            {
                Clear_Linear(eLinearCalib_Link.Laser2);
            }
        }
        /// <summary>
        /// 手动运行标定块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Run_Click(object sender, EventArgs e)
        {
            if (rdo_Li_Robot1.Checked)
            {
                _Linear_State = Rbt_FindCircle();
            }
            else if (rdo_Li_Robot2.Checked)
            {
                _Linear_State = Rbt_FindCircle();
            }
            else if (rdo_Li_Laser1.Checked)
            {
                //_laserIndex = _laserIndex % 9;
                //if (_laserIndex==0)
                //{
                //    _laserIndex = _laserIndex + 1;
                //}
                // _Linear_State = laserRunLinearL(_laserIndex);

            }
            else if (rdo_Li_Laser2.Checked)
            {
                //_laserIndex = _laserIndex % 9;
                //if (_laserIndex == 0)
                //{
                //    _laserIndex = _laserIndex + 1;
                //}
                //_Linear_State = laserRunLinearR(_laserIndex);
            }
        }
        /// <summary>
        /// 添加标定点对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_AddMark_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (rdo_Li_Robot1.Checked)
            {
                addMark_Linear(eLinearCalib_Link.Robot1);
            }
            else if (rdo_Li_Robot2.Checked)
            {
                addMark_Linear(eLinearCalib_Link.Robot1);
            }
            else if (rdo_Li_Laser1.Checked)
            {
                for (int i = 0; i < 9; i++)
                {

                    if (Lsr_FindCircle(0, i) && addMark_Linear(eLinearCalib_Link.Robot1))
                    {

                        RefleshLinearTextMsgBox("Laser1结果：添加点对成功 ......");
                    }
                    else
                    {
                        RefleshLinearTextMsgBox("结果：添加点对失败 ......");
                        i = 10;
                        flag = 10;
                    }

                    Thread.Sleep(1000);
                }
            }
            else if (rdo_Li_Laser2.Checked)
            {
                for (int i = 0; i < 9; i++)
                {


                    if (Lsr_FindCircle(1, i) && addMark_Linear(eLinearCalib_Link.Robot2))
                    {

                        RefleshLinearTextMsgBox("Laser1结果：添加点对成功 ......");
                    }
                    else
                    {
                        RefleshLinearTextMsgBox("结果：添加点对失败 ......");
                        i = 10;
                        flag = 10;
                    }
                    Thread.Sleep(1000);
                }
            }
        }
        /// <summary>
        /// 开始标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Start_Click(object sender, EventArgs e)
        {
            if (rdo_Li_Robot1.Checked)
            {
                linear(eLinearCalib_Link.Robot1);
            }
            else if (rdo_Li_Robot2.Checked)
            {
                linear(eLinearCalib_Link.Robot2);
            }
            else if (rdo_Li_Laser1.Checked)
            {
                linear(eLinearCalib_Link.Laser1);
            }
            else if (rdo_Li_Laser2.Checked)
            {
                linear(eLinearCalib_Link.Laser2);
            }
        }
        /// <summary>
        /// 九点标定保存结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_Save_Click(object sender, EventArgs e)
        {
            saveResult_Linear();
        }
        /// <summary>
        /// 测试按钮(不可见)，供开发人员代码调试使用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Li_test_Click(object sender, EventArgs e)
        {
            //double[][] testData = new double[2][];
            //testData[0] = new double[9] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            //testData[1] = new double[9] { 9.9, 8.8, 7.7, 6.6, 5.5, 4.4, 3.3, 2.2, 1.1 };
            //CsvExcelHelper.GenerateAndOpenCsv(testData);
            Acq_Linear();
            runVerificate(eLinearCalib_Link.Robot1);
        }
        /// <summary>
        /// datagridview显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewLinear_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        #endregion
        #region 旋转中心标定
        //连接对象枚举
        private void rdo_Ro_Robot1_Click(object sender, EventArgs e)
        {
            RefleshRotationTextMsgBox("连接模式：ROBOT1");
            this.rdo_Ro_Robot2.BackColor = Color.Transparent;
            RefleshRotationDataGridView();
            //this.rdo_PLC_Con_R.BackColor = Color.Transparent;
        }
        private void rdo_Ro_Robot2_Click(object sender, EventArgs e)
        {
            RefleshRotationTextMsgBox("连接模式：ROBOT1");
            this.rdo_Ro_Robot1.BackColor = Color.Transparent;
            RefleshRotationDataGridView();
        }
        /// <summary>
        /// 选中自动旋转中心标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Ro_Auto_Click(object sender, EventArgs e)
        {
            SetRotationCalibMode(true);
        }
        /// <summary>
        /// 选中手动旋转中心标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Ro_Manual_Click(object sender, EventArgs e)
        {
            SetRotationCalibMode(false);
        }
        /// <summary>
        /// 单帧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Ro_Snap_CheckedChanged(object sender, EventArgs e)
        {
            btn_Ro_Acq.Text = "采集图像";
            btn_Ro_Acq.BackColor = Color.FromArgb(80, 160, 255);
        }
        /// <summary>
        /// 实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Ro_Live_CheckedChanged(object sender, EventArgs e)
        {
            btn_Ro_Acq.Text = "实时采集";
            btn_Ro_Acq.BackColor = Color.FromArgb(220, 155, 40);
        }
        /// <summary>
        /// Rotation自动标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Auto_Click(object sender, EventArgs e)
        {
            try
            {
                if (_b_Auto_Rotation)
                {
                    return;
                }
                if (!Project.Instance.HardWareStateManagerInstance.L_ccdState[vppindex])
                {
                    MessageBox.Show("CCD未链接!");
                    return;
                }

                if (rdo_Ro_Robot1.Checked)
                {
                    //通知ROBOT开始一键标定.
                    if (!Project.Instance.RobotManagerInstance.L_Robot[0].IsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + vppindex + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    //通知ROBOT开始一键标定.
                    try
                    {
                        Project.Instance.RobotManagerInstance.L_Robot[0].SendText(RobotSignalsModel.CCDRobotRCalStart, 0);
                    }
                    catch (Exception)
                    {
                        RefleshRotationTextMsgBox("CCD自动旋转中心标定模式catch......");
                    }
                    #endregion
                }
                else if (rdo_Ro_Robot2.Checked)
                {
                    //通知ROBOT开始一键标定.
                    if (!Project.Instance.RobotManagerInstance.L_Robot[1].IsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT2" + ":未链接!");
                        return;
                    }

                    //通知ROBOT开始一键标定.
                    try
                    {
                        Project.Instance.RobotManagerInstance.L_Robot[1].SendText(RobotSignalsModel.CCDRobotRCalStart, 0);
                    }
                    catch (Exception)
                    {
                        RefleshRotationTextMsgBox("CCD自动旋转中心标定模式catch......");
                    }

                }
                if (!Clear_Rotation())
                {
                    return;
                }
                _b_Auto_Rotation = true;
                RobotSignalsModel.CCDRobotCal = "1";
                RefleshRotationTextMsgBox("CCD自动旋转中心标定模式开启......");
            }
            catch (Exception ex)
            {
                RefleshRotationTextMsgBox(ex.ToString());
            }
        }
        /// <summary>
        /// Rotation采集图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Acq_Click(object sender, EventArgs e)
        {
            Acq_Rotation();
        }
        /// <summary>
        /// Rotation清除MARK点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Clear_Click(object sender, EventArgs e)
        {
            Clear_Rotation();
        }
        /// <summary>
        /// Rotation运行标定块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Run_Click(object sender, EventArgs e)
        {
            _Rotation_State = runRotation();
        }
        /// <summary>
        /// Rotation添加标定点对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_AddMark_Click(object sender, EventArgs e)
        {
            addMark_Rotation();
        }
        /// <summary>
        /// Rotation开始标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Start_Click(object sender, EventArgs e)
        {
            rotation();
        }
        /// <summary>
        /// Rotation保存结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_Save_Click(object sender, EventArgs e)
        {
            saveResult_Rotation();
        }
        /// <summary>
        /// Rotation文件取图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Ro_FileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "D:/";
            ofd.Filter = ".BMP(*.MBP)|*BMP";
            ofd.FileName = ".BMP";
            //打开相机图片
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mImageFile.Operator.Open(ofd.FileName, CogImageFileModeConstants.Read);
                mImageFile.Run();
                img = mImageFile.OutputImage;
                cogRecordDisplayRotation.Image = null;
                cogRecordDisplayRotation.Image = img;
                cogRecordDisplayRotation.Fit(true);
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// 当前吸嘴对应Rotation坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Nozzle_Rotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nozzleIndex = Convert.ToInt32(cbb_Ro_Nozzle.Text) - 1;
            switch (nozzleIndex)
            {
                case 0:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["FitCircle"] as CogFitCircleTool;
                    _rotation_UnCalibrated_block1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                case 1:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                case 2:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                case 3:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                case 4:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                case 5:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["FitCircle"] as CogFitCircleTool;
                    break;
                default:
                    break;
            }
            //显示
            if (vppindex == 0)
            {
                if (rdo_Ro_Robot1.Checked)
                {
                    //RotationCenter_X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[0];
                    //RotationCenter_Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[0];
                    //Rotation_RMS = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[0];
                }
                else
                {
                    //RotationCenter_X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[1];
                    //RotationCenter_Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[1];
                    //Rotation_RMS = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[1];
                }

            }
            else if (vppindex == 1)
            {
                //RotationCenter_X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_X[nozzleIndex];
                //RotationCenter_Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_Y[nozzleIndex];
                //Rotation_RMS = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_RMS[nozzleIndex];
            }
            //刷新界面
            RefleshRotationDataGridView();
        }
        /// <summary>
        /// datagridview2显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewRotation_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();
            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            var headerBounds = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
        #endregion
        #endregion
        #region 线性标定
        /// <summary>
        /// 更改九点标定模式
        /// 0为手动，1为自动,2为验证
        /// </summary>
        private void SetLinearCalibMode(uint mode)
        {
            // 0: 手动, 1: 自动, 2: 验证
            rdo_Li_Manual.Checked = (mode == 0);
            rdo_Li_Auto.Checked = (mode == 1);
            rdo_Li_Verificate.Checked = (mode == 2);

            gb_LinearCon.Enabled = (mode == 0);
            btn_Li_Auto.Enabled = (mode == 1 || mode == 2);
            gb_Li_operation.Enabled = (mode == 0);

            // 停止实时采集
            if (mode == 0)// 手动
            {
                btn_Li_Auto.Text = "自动标定";
                _b_Auto_Linear = false;
                gb_LinearVision.Enabled = true;
                btn_Li_Run.Enabled = true;
                btn_Li_AddMark.Enabled = true;
                btn_Li_Start.Enabled = true;
                btn_Li_Clear.Enabled = true;
                btn_Li_Save.Enabled = true;
                Project.Instance.RobotManagerInstance.SetStop(false);
                RefleshLinearTextMsgBox("当前模式为手动模式");
            }
            else if (mode == 1) // 自动
            {
                btn_Li_Auto.Text = "自动标定";
                if (cogRecordDisplayLinear.LiveDisplayRunning)
                    cogRecordDisplayLinear.StopLiveDisplay();
                rdo_Li_Snap.Checked = true;
                rdo_Li_Live.Checked = false;
                gb_LinearVision.Enabled = false;
                Project.Instance.RobotManagerInstance.SetStop(false);
                RefleshLinearTextMsgBox("当前模式为自动模式，机器人触发将自动标定");
            }
            else if (mode == 2) // 验证
            {
                btn_Li_Auto.Text = "自动验证";
                if (cogRecordDisplayLinear.LiveDisplayRunning)
                    cogRecordDisplayLinear.StopLiveDisplay();
                rdo_Li_Snap.Checked = true;
                rdo_Li_Live.Checked = false;
                gb_LinearVision.Enabled = false;
                Project.Instance.RobotManagerInstance.SetStop(false);
                RefleshLinearTextMsgBox("当前模式为验证模式，机器人触发将验证标定");
            }
        }

        ///// <summary>
        ///// 连接模式PLC
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void rdo_PLC_Con_L_Click(object sender, EventArgs e)
        //{
        //    RefleshLinearTextMsgBox("连接模式：PLC");
        //    this.rdo_Robot_Con_L.BackColor = Color.Transparent;
        //}
        #region 线性标定手动标定

        private bool Acq_Linear()
        {
            try
            {
                if (cogRecordDisplayLinear.Image != null)
                {
                    cogRecordDisplayLinear.StaticGraphics.Clear();
                    cogRecordDisplayLinear.InteractiveGraphics.Clear();
                }
                if (btn_Li_Acq.Text == "采集图像")
                {
                    #region 采集图像
                    //_e.bAcquire = true;
                    bool test = cur_WorkFlow.RunAcquireBlock(out img);
                    if (!test)
                    {
                        return false;
                    }
                    else
                    {
                        cogGraphicLabel1.SetXYText(100, 100, DateTime.Now.ToString("HH:mm:ss"));
                        cogRecordDisplayLinear.Image = img;
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel1, "");
                        cogRecordDisplayLinear.Fit(true);
                    }
                    #endregion
                }
                else if (btn_Li_Acq.Text == "实时采集")
                {
                    #region 实时采集
                    if (null == acq.Operator.FrameGrabber)
                    {
                        MessageBox.Show("没有相机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    btn_Li_Acq.Text = "停止实时";
                    btn_Li_Acq.BackColor = Color.FromArgb(230, 80, 80);
                    gb_LinearVision.Enabled = false;
                    btn_Li_Run.Enabled = false;
                    btn_Li_AddMark.Enabled = false;
                    btn_Li_Start.Enabled = false;
                    btn_Li_Clear.Enabled = false;
                    btn_Li_Save.Enabled = false;
                    if ((null != acq.Operator) && (null != acq.Operator.FrameGrabber))
                    {
                        if (cogRecordDisplayLinear.LiveDisplayRunning)
                            cogRecordDisplayLinear.StopLiveDisplay();
                        cogRecordDisplayLinear.StaticGraphics.Clear();
                        cogRecordDisplayLinear.StartLiveDisplay(acq.Operator, true);
                    }
                    #endregion
                }
                else if (btn_Li_Acq.Text == "停止实时")
                {
                    #region 实时采集
                    btn_Li_Acq.Text = "实时采集";
                    btn_Li_Acq.BackColor = Color.FromArgb(220, 155, 40);
                    gb_LinearVision.Enabled = true;
                    btn_Li_Run.Enabled = true;
                    btn_Li_AddMark.Enabled = true;
                    btn_Li_Start.Enabled = true;
                    btn_Li_Clear.Enabled = true;
                    btn_Li_Save.Enabled = true;
                    if (cogRecordDisplayLinear.LiveDisplayRunning)
                        cogRecordDisplayLinear.StopLiveDisplay();
                    #endregion
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("图像采集(九点线性标定时)出现异常", ex);
                return false;
            }
            return true;
        }
        public string module_X1 = "";
        public string module_Y1 = "";
        /// <summary>
        /// 服务器接收事件（机器人1标定）
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnRead_Cal1(Socket soc)
        {
            if (RobotSignalsModel.CCDProcess == 1)
            {
                string receive_string = Project.Instance.RobotManagerInstance.L_Robot[0].ReceivedText.Trim().Replace("\r\n", "").Replace("\0", "");
                RefleshLinearTextMsgBox("接收数据：" + receive_string);
                Project.Instance.RobotManagerInstance.m_strRobot1Receive = receive_string;
                string[] str = receive_string.Split(';');
                int nCountNum = str.Length;
                try
                {
                    if (nCountNum == 4)
                    {
                        module_X1 = str[2];
                        module_Y1 = str[3];
                    }
                    double Step = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep;
                    _inAuto = true;
                    //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                    if (nCountNum == 4 && str[0] == "CBS")
                    {
                        #region //解析当前ROBOT实时坐标，添加九点标定点对
                        module_X = module_X1;
                        module_Y = module_Y1;

                        if (_b_Auto_Linear)
                        {
                            Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                            RefleshLinearTextMsgBox("CCD发送1号标定点字符：" + "CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                        }
                        #endregion
                    }
                    else if (str[2] == "01" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {
                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送2号标定点字符：" + "CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送2号标定点字符：" + "CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }
                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "02" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送3号标定点字符：" + "CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送3号标定点字符：" + "CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "03" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送4号标定点字符：" + "CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送4号标定点字符：" + "CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "04" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送5号标定点字符：" + "CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送5号标定点字符：" + "CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "05" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送6号标定点字符：" + "CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送6号标定点字符：" + "CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "06" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送7号标定点字符：" + "CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送7号标定点字符：" + "CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "07" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送8号标定点字符：" + "CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送8号标定点字符：" + "CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "08" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送9号标定点字符：" + "CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送9号标定点字符：" + "CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "09")
                    {
                        if (Acq_Linear())
                        {

                            RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                            if (rdo_Li_Auto.Checked)
                            {
                                if (Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot1))
                                {
                                    RefleshLinearTextMsgBox("添加点对成功");
                                }

                                if (linear(eLinearCalib_Link.Robot1))
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                }
                                else
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                            else if (rdo_Li_Verificate.Checked)
                            {
                                if (runVerificate(eLinearCalib_Link.Robot1))
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                    RefleshLinearTextMsgBox("开始生成验证结果：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                    enterExcel();
                                }
                                else
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                        }
                    }
                    else
                    {
                        RefleshLinearTextMsgBox("未识别机器人1发送内容 ......" + receive_string);
                        _inAuto = false;
                    }
                }
                catch (Exception)
                {

                    RefleshLinearTextMsgBox("请核对机器人发送内容是否符合标准" + receive_string);

                }
            }
            else
            {
                RefleshLinearTextMsgBox("CCD未开启自动 ......");
                _inAuto = false;
            }

        }
        /// <summary>
        /// 服务器接收事件（机器人2标定）
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnRead_Cal2(Socket soc)
        {
            if (RobotSignalsModel.CCDProcess == 1)
            {
                string receive_string = Project.Instance.RobotManagerInstance.L_Robot[1].ReceivedText.Trim().Replace("\r\n", "").Replace("\0", "");
                RefleshLinearTextMsgBox("接收数据：" + receive_string);
                Project.Instance.RobotManagerInstance.m_strRobot1Receive = receive_string;
                string[] str = receive_string.Split(';');
                int nCountNum = str.Length;
                try
                {
                    if (nCountNum == 4)
                    {
                        module_X1 = str[2];
                        module_Y1 = str[3];
                    }
                    double Step = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep;
                    _inAuto = true;
                    //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                    if (nCountNum == 4 && str[0] == "CBS")
                    {
                        #region //解析当前ROBOT实时坐标，添加九点标定点对
                        module_X = module_X1;
                        module_Y = module_Y1;

                        if (_b_Auto_Linear)
                        {
                            Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                            RefleshLinearTextMsgBox("CCD发送1号标定点字符：" + "CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                        }

                        #endregion
                    }
                    else if (str[2] == "01" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送2号标定点字符：" + "CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送2号标定点字符：" + "CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "02" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送3号标定点字符：" + "CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送3号标定点字符：" + "CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "03" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送4号标定点字符：" + "CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送4号标定点字符：" + "CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }
                    }
                    else if (str[2] == "04" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送5号标定点字符：" + "CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送5号标定点字符：" + "CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "05" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送6号标定点字符：" + "CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送6号标定点字符：" + "CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "06" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送7号标定点字符：" + "CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送7号标定点字符：" + "CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "07" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送8号标定点字符：" + "CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送8号标定点字符：" + "CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "08" && str[0] == "CBA")
                    {

                        if (_b_Auto_Linear)
                        {

                            if (Acq_Linear())
                            {

                                RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                                if (rdo_Li_Auto.Checked && Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送9号标定点字符：" + "CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else if (rdo_Li_Verificate.Checked && runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送9号标定点字符：" + "CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD处理结果：添加点对失败 ......");
                                }

                            }
                            else
                            {
                                RefleshLinearTextMsgBox("CCD采集图像失败 ......");
                            }
                        }

                    }
                    else if (str[2] == "09")
                    {
                        if (Acq_Linear())
                        {
                            RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                            if (rdo_Li_Auto.Checked)
                            {
                                if (Rbt_FindCircle() && addMark_Linear(eLinearCalib_Link.Robot2))
                                {
                                    RefleshLinearTextMsgBox("添加点对成功");
                                }

                                if (linear(eLinearCalib_Link.Robot2))
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                }
                                else
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                            else if (rdo_Li_Verificate.Checked)
                            {
                                if (runVerificate(eLinearCalib_Link.Robot2))
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                    RefleshLinearTextMsgBox("开始生成验证结果：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                                    enterExcel();
                                }
                                else
                                {
                                    Project.Instance.RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                        }
                    }
                    else
                    {
                        RefleshLinearTextMsgBox("未识别机器人1发送内容 ......" + receive_string);
                        _inAuto = false;
                    }
                }
                catch (Exception)
                {

                    RefleshLinearTextMsgBox("请核对机器人发送内容是否符合标准" + receive_string);
                }
            }
            else
            {
                RefleshLinearTextMsgBox("CCD未开启自动 ......");
                _inAuto = false;
            }
        }

        /// <summary>
        /// useless：功能未完善，待确认与激光的标定交互
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnRead_Cal3(Socket soc)
        {
            if (RobotSignalsModel.CCDProcess == 1)
            {
                string receive_string = Project.Instance.RobotManagerInstance.L_Robot[2].ReceivedText;
                Project.Instance.RobotManagerInstance.m_strRobot2Receive = receive_string;
                string[] str = receive_string.Split(',');
                int nCountNum = str.Length;
                int flag = 0;
                //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                if (nCountNum == 3)
                {
                    if (str[0] == "T1")
                    {
                        //Project.Instance.RobotManagerInstance.L_Robot[2].SendText(RobotSignalsModel.Laser1NinePointStr, 0);
                    }
                    else
                    {
                        //Project.Instance.RobotManagerInstance.L_Robot[2].SendText(RobotSignalsModel.Laser2NinePointStr, 0);
                    }

                    MessageBox.Show("激光此时正在出光，等待出光完成继续流程");
                    if (Acq_Linear())
                    {
                        RefleshLinearTextMsgBox("CCD采集图像成功 ......");

                        for (int i = 0; i < 9; i++)
                        {
                            if (str[0] == "T1")
                            {
                                if (Lsr_FindCircle(0, i) && addMark_Linear(eLinearCalib_Link.Laser1) && str[0] == "T1")
                                {

                                    RefleshLinearTextMsgBox("Laser1结果：添加点对成功 ......");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("结果：添加点对失败 ......");
                                    i = 10;
                                    flag = 10;
                                }
                            }
                            else
                            {
                                if (Lsr_FindCircle(1, i) && addMark_Linear(eLinearCalib_Link.Laser2) && str[0] == "T2")
                                {

                                    RefleshLinearTextMsgBox("Laser1结果：添加点对成功 ......");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("结果：添加点对失败 ......");
                                    i = 10;
                                    flag = 10;
                                }
                            }


                            Thread.Sleep(1000);
                        }
                        if (flag < 10)
                        {
                            if (str[0] == "T1")
                            {
                                if (linear(eLinearCalib_Link.Laser1))
                                {
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定成功 ......");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                            else
                            {
                                if (linear(eLinearCalib_Link.Laser2))
                                {
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定成功 ......");
                                }
                                else
                                {
                                    RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                                }
                            }
                        }

                        _b_Auto_Linear = false;

                        Action action = () => { SetLinearCalibMode(0); };
                        this.Invoke(action);

                    }
                    else
                    {
                        RefleshLinearTextMsgBox("CCD采集图像失败：标定失败 ......");

                    }
                }

            }


        }

        /// <summary>
        /// 清除标定数据
        /// </summary>
        /// <param name="type">关于标定对象类型的枚举</param>
        /// <returns>返回清除结果</returns>
        private bool Clear_Linear(eLinearCalib_Link type)
        {
            if (cur_WorkFlow.RunLinearCalibBlock(eLinearCalib_Step.clear, type))
            {
                RefleshLinearDataGridView();
                Linear_RMS = 0;
                RefleshLinearTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }

        /// <summary>
        /// 运行找圆工具块——机械手标定 NIndex需为-1才能正确运行相关工具块
        /// </summary>
        /// <returns>结果</returns>
        private bool Rbt_FindCircle()
        {
            try
            {
                if (img != null)
                {
                    cur_WorkFlow.LinearCalibBlock.Inputs["NIndex"].Value = -1;
                    if (cur_WorkFlow.RunLinearCalibBlock(eLinearCalib_Step.FindCircle, img: img))
                    {
                        cogRecordDisplayLinear.Record = cur_WorkFlow.LinearCalibBlock.CreateLastRunRecord();
                        cogGraphicLabel2.Color = CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_linear_UnCalibrate_block.Outputs["X"].Value).ToString("F3"), ((double)_linear_UnCalibrate_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = CogColorConstants.Red;
                        cogGraphicLabel2.SetXYText(100, 200, "视觉模板运行错误!");
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        RefleshLinearTextMsgBox("视觉模板运行错误!");
                        return false;
                    }
                }
                else
                {
                    RefleshLinearTextMsgBox("采集图像为空!");
                    return false;
                }
            }
            catch
            {
                RefleshLinearTextMsgBox("标定视觉运行错误!");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 运行找圆工具块——激光标定
        /// </summary>
        /// <param name="LaserIdx">激光标定位置序号 0~1</param>
        /// <param name="CircleIndex">找圆工具序号0~8</param>
        /// <returns></returns>
        private bool Lsr_FindCircle(int LaserIdx, int CircleIdx)
        {
            try
            {
                PointAxis midPose = new PointAxis();
                switch (vppindex)
                {
                    case 0:
                        if (LaserIdx == 0)
                            midPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis;
                        else
                            midPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis;
                        break;
                }
                if (img != null)
                {
                    cur_WorkFlow.LinearCalibBlock.Inputs["NIndex"].Value = CircleIdx;
                    if (cur_WorkFlow.RunLinearCalibBlock(eLinearCalib_Step.FindCircle, img: img))
                    {
                        cogRecordDisplayLinear.Record = cur_WorkFlow.LinearCalibBlock.CreateLastRunRecord();
                        cogGraphicLabel2.Color = CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_linear_UnCalibrate_block.Outputs["X"].Value).ToString("F3"), ((double)_linear_UnCalibrate_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = CogColorConstants.Red;
                        cogGraphicLabel2.SetXYText(100, 200, "视觉模板运行错误!");
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        RefleshLinearTextMsgBox("视觉模板运行错误!");
                        return false;
                    }
                }
                else
                {
                    RefleshLinearTextMsgBox("采集图像为空!");
                    return false;
                }
                double Step = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep;
                if (CircleIdx == 0)
                {
                    module_X = ( - Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y + Step).ToString();
                }
                if (CircleIdx == 1)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y + Step).ToString();
                }
                if (CircleIdx == 2)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X + Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y + Step).ToString();
                }
                if (CircleIdx == 3)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X + Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y).ToString();
                }
                if (CircleIdx == 4)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y).ToString();
                }
                if (CircleIdx == 5)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X - Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y).ToString();
                }
                if (CircleIdx == 6)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X - Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y - Step).ToString();
                }
                if (CircleIdx == 7)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y - Step).ToString();
                }
                if (CircleIdx == 8)
                {
                    module_X = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y + Step).ToString();
                    module_Y = (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X - Step).ToString();
                }
            }
            catch
            {
                RefleshLinearTextMsgBox("标定视觉运行错误!");
                return false;
            }
            return true;
        }
        private bool addMark_Linear(eLinearCalib_Link type)
        {
            if (!_Linear_State)
            {
                return false;
            }
            module_X = tb_Li_X.Text;
            module_Y = tb_Li_Y.Text;
            if ((!string.IsNullOrEmpty(module_X)) && (!string.IsNullOrEmpty(module_Y)))
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["R_X"].Value = double.Parse(module_X);
                cur_WorkFlow.LinearCalibBlock.Inputs["R_Y"].Value = double.Parse(module_Y);
                cur_WorkFlow.RunLinearCalibBlock(eLinearCalib_Step.insert, type);
                RefleshLinearDataGridView();
            }
            else
            {
                _Linear_State = false;
                RefleshLinearTextMsgBox("XY轴坐标为空或非数字!");
                return false;
            }
            return true;
        }

        private bool linear(eLinearCalib_Link type)
        {
            try
            {
                if (!_Linear_State)
                {
                    return false;
                }
                cur_WorkFlow.RunLinearCalibBlock(eLinearCalib_Step.calculate, type);

                //标定结果刷新
                Linear_RMS = _linear_calib_tool.Calibration.ComputedRMSError;
                saveResult_Linear();
            }
            catch (Exception e)
            {
                _Linear_State = false;
                RefleshLinearTextMsgBox(e.ToString());
                return false;
            }
            return true;
        }
        /// <summary>
        /// 保存标定结果
        /// </summary>
        private void saveResult_Linear()
        {
            cur_WorkFlow.SaveTools();
            module_X = "";
            module_Y = "";
            RefleshLinearTextMsgBox("标定结果保存成功！");
        }
        #endregion
        #region 标定验证
        private double currunt_CenterX = 0;
        private double currunt_CenterY = 0;
        private List<double> arr_CenterX = new List<double>();
        private List<double> arr_CenterY = new List<double>();
        double[][] testData = new double[2][];
        private bool runVerificate(eLinearCalib_Link type)
        {
            try
            {
                if (img != null)
                {
                    //根据当前选择的机器人redio按钮，设置标定块的Index值
                    cur_WorkFlow.RunVerificatecalibBlock(ref img, type);
                    if (cur_WorkFlow.VerificatecalibBlock.RunStatus.Result == CogToolResultConstants.Accept)
                    {
                        currunt_CenterX = Convert.ToDouble(cur_WorkFlow.VerificatecalibBlock.Outputs["OutputX"].Value);
                        currunt_CenterY = Convert.ToDouble(cur_WorkFlow.VerificatecalibBlock.Outputs["OutputY"].Value);
                        cogRecordDisplayLinear.Record = cur_WorkFlow.VerificatecalibBlock.CreateLastRunRecord();
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                        arr_CenterX.Add(currunt_CenterX);
                        arr_CenterY.Add(currunt_CenterY);
                    }
                    else
                    {
                        cogRecordDisplayLinear.Fit(true);
                        RefleshLinearTextMsgBox("视觉模板运行错误!");
                        arr_CenterX = new List<double>();
                        arr_CenterY = new List<double>();
                        return false;
                    }
                }
                else
                {
                    RefleshLinearTextMsgBox("采集图像为空!");
                    arr_CenterX = new List<double>();
                    arr_CenterY = new List<double>();
                    return false;
                }
            }
            catch
            {
                RefleshLinearTextMsgBox("标定视觉运行错误!");
                arr_CenterX = new List<double>();
                arr_CenterY = new List<double>();
                return false;
            }
            return true;
        }
        private void enterExcel()
        {
            testData[0] = arr_CenterX.ToArray();
            testData[1] = arr_CenterY.ToArray();
            File_CSV.ExportAndOpenXYData(testData);
            arr_CenterX = new List<double>();
            arr_CenterY = new List<double>();
            module_X = "";
            module_Y = "";
        }
        #endregion
        
        private void RefleshLinearDataGridView()
        {
            try
            {
                if (rdo_Li_Robot1.Checked)
                {
                    if (!this.dataGridViewLinear.IsDisposed)
                    {
                        if (this.dataGridViewLinear.InvokeRequired)
                        {
                            RefleshDataGridViewCallback d = new RefleshDataGridViewCallback(RefleshLinearDataGridView);
                            this.Invoke(d, new object[] { });
                        }
                        else
                        {
                            this.dataGridViewLinear.Rows.Clear();

                            if (_linear_calib_tool != null)
                            {
                                int num = _linear_calib_tool.Calibration.NumPoints;
                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _linear_calib_tool.Calibration.GetUncalibratedPointX(i);
                                    double UncalibratedPointY = _linear_calib_tool.Calibration.GetUncalibratedPointY(i);
                                    double RawCalibratedPointX = _linear_calib_tool.Calibration.GetRawCalibratedPointX(i);
                                    double RawCalibratedPointY = _linear_calib_tool.Calibration.GetRawCalibratedPointY(i);
                                    this.dataGridViewLinear.Rows.Add();
                                    this.dataGridViewLinear.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[2].Value = Math.Round(RawCalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[3].Value = Math.Round(RawCalibratedPointY, 3);

                                }
                                this.dataGridViewLinear.FirstDisplayedScrollingRowIndex = this.dataGridViewLinear.Rows.Count - 1;
                                int bb = this.dataGridViewLinear.Rows.Count;
                                this.dataGridViewLinear.Rows[this.dataGridViewLinear.Rows.Count - 1].Selected = true;
                            }
                        }
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
                else if (rdo_Li_Robot2.Checked)
                {
                    if (!this.dataGridViewLinear.IsDisposed)
                    {
                        if (this.dataGridViewLinear.InvokeRequired)
                        {
                            RefleshDataGridViewCallback d = new RefleshDataGridViewCallback(RefleshLinearDataGridView);
                            this.Invoke(d, new object[] { });
                        }
                        else
                        {
                            this.dataGridViewLinear.Rows.Clear();

                            if (_linear_calib_tool1 != null)
                            {
                                int num = _linear_calib_tool1.Calibration.NumPoints;
                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _linear_calib_tool1.Calibration.GetUncalibratedPointX(i);
                                    double UncalibratedPointY = _linear_calib_tool1.Calibration.GetUncalibratedPointY(i);
                                    double RawCalibratedPointX = _linear_calib_tool1.Calibration.GetRawCalibratedPointX(i);
                                    double RawCalibratedPointY = _linear_calib_tool1.Calibration.GetRawCalibratedPointY(i);
                                    this.dataGridViewLinear.Rows.Add();
                                    this.dataGridViewLinear.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[2].Value = Math.Round(RawCalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[3].Value = Math.Round(RawCalibratedPointY, 3);

                                }
                                this.dataGridViewLinear.FirstDisplayedScrollingRowIndex = this.dataGridViewLinear.Rows.Count - 1;
                                int bb = this.dataGridViewLinear.Rows.Count;
                                this.dataGridViewLinear.Rows[this.dataGridViewLinear.Rows.Count - 1].Selected = true;
                            }
                        }
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
                else if (rdo_Li_Laser1.Checked)
                {
                    if (!this.dataGridViewLinear.IsDisposed)
                    {
                        if (this.dataGridViewLinear.InvokeRequired)
                        {
                            RefleshDataGridViewCallback d = new RefleshDataGridViewCallback(RefleshLinearDataGridView);
                            this.Invoke(d, new object[] { });
                        }
                        else
                        {
                            this.dataGridViewLinear.Rows.Clear();

                            if (_linear_calib_tool2 != null)
                            {
                                int num = _linear_calib_tool2.Calibration.NumPoints;
                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _linear_calib_tool2.Calibration.GetUncalibratedPointX(i);
                                    double UncalibratedPointY = _linear_calib_tool2.Calibration.GetUncalibratedPointY(i);
                                    double RawCalibratedPointX = _linear_calib_tool2.Calibration.GetRawCalibratedPointX(i);
                                    double RawCalibratedPointY = _linear_calib_tool2.Calibration.GetRawCalibratedPointY(i);
                                    this.dataGridViewLinear.Rows.Add();
                                    this.dataGridViewLinear.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[2].Value = Math.Round(RawCalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[3].Value = Math.Round(RawCalibratedPointY, 3);

                                }
                                this.dataGridViewLinear.FirstDisplayedScrollingRowIndex = this.dataGridViewLinear.Rows.Count - 1;
                                int bb = this.dataGridViewLinear.Rows.Count;
                                this.dataGridViewLinear.Rows[this.dataGridViewLinear.Rows.Count - 1].Selected = true;
                            }
                        }
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }
                else if (rdo_Li_Laser2.Checked)
                {
                    if (!this.dataGridViewLinear.IsDisposed)
                    {
                        if (this.dataGridViewLinear.InvokeRequired)
                        {
                            RefleshDataGridViewCallback d = new RefleshDataGridViewCallback(RefleshLinearDataGridView);
                            this.Invoke(d, new object[] { });
                        }
                        else
                        {
                            this.dataGridViewLinear.Rows.Clear();

                            if (_linear_calib_tool3 != null)
                            {
                                int num = _linear_calib_tool3.Calibration.NumPoints;
                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _linear_calib_tool3.Calibration.GetUncalibratedPointX(i);
                                    double UncalibratedPointY = _linear_calib_tool3.Calibration.GetUncalibratedPointY(i);
                                    double RawCalibratedPointX = _linear_calib_tool3.Calibration.GetRawCalibratedPointX(i);
                                    double RawCalibratedPointY = _linear_calib_tool3.Calibration.GetRawCalibratedPointY(i);
                                    this.dataGridViewLinear.Rows.Add();
                                    this.dataGridViewLinear.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[2].Value = Math.Round(RawCalibratedPointX, 3);
                                    this.dataGridViewLinear.Rows[i].Cells[3].Value = Math.Round(RawCalibratedPointY, 3);

                                }
                                this.dataGridViewLinear.FirstDisplayedScrollingRowIndex = this.dataGridViewLinear.Rows.Count - 1;
                                int bb = this.dataGridViewLinear.Rows.Count;
                                this.dataGridViewLinear.Rows[this.dataGridViewLinear.Rows.Count - 1].Selected = true;
                            }
                        }
                    }
                    else
                    {
                        Thread.CurrentThread.Abort();
                    }
                }


            }
            catch
            {
            }
        }

        /// <summary>
        /// 刷新TextBox
        /// </summary>
        /// <param name="str"></param>
        private void RefleshLinearTextMsgBox(string str)
        {
            try
            {
                if (!this.tb_Li_msg.IsDisposed)
                {
                    if (this.tb_Li_msg.InvokeRequired)
                    {
                        RefleshTextMsgBoxCallback d = new RefleshTextMsgBoxCallback(RefleshLinearTextMsgBox);
                        this.Invoke(d, new object[] { str });
                    }
                    else
                    {
                        this.tb_Li_msg.AppendText(System.Environment.NewLine);
                        str += DateTime.Now.ToString("  yyyy.MM.dd HH:mm:ss  ");
                        this.tb_Li_msg.Text += str;
                        this.tb_Li_msg.Select(this.tb_Li_msg.TextLength, 0);
                        this.tb_Li_msg.ScrollToCaret();
                    }
                }
                else
                {
                    Thread.CurrentThread.Abort();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region 畸变矫正

        #endregion

        #region 旋转中心矫正
        #region Rotation标定信号
        private volatile int Rotation_TRG_1 = 0;                                         //1号相机触发
        private volatile int Old_Rotation_TRG_1 = 1;
        private volatile int Rotation_Move_END_TRG_1 = 0;                                         //PLC运行完毕
        private volatile int Old_Rotation_Move_END_TRG_1 = 1;
        #endregion
        /// <summary>
        /// PLC与PC信号交互线程
        /// </summary>
        /// <param name="token">取消CancellationToken</param>
        /// <param name="SelectSignalExchange">信号交互选择(True交互全部地址，False只交互脉冲地址和屏蔽地址)</param>
        private void PC_PLC_SignalExchange_Rotation(CancellationToken token, bool SelectSignalExchange)
        {
            while (!token.IsCancellationRequested)
            {
                //Thread.Sleep(1);
                ////1.掉线
                //if (!Project.Instance.PLCManagerInstance.plc4Service.PLCConnectState)        //判断PLC是否连接
                //{
                //    RefleshRotationTextMsgBox("PLC掉线......");
                //    Thread.Sleep(3000);
                //}
                ////SelectSignalExchange为False只与PLC交互脉冲信号
                //if (SelectSignalExchange)
                //{
                //    #region CCD信号交互
                //    //触发开始CCD拍照信号（(上升沿0→1时,拍照处理图片)）
                //    try
                //    {
                //        if (Project.Instance.PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Mode_CCD) == 2)
                //        {
                //            string sobjR1 = "";
                //            int Cam_Get1;
                //            sobjR1 = Project.Instance.PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.TrigSignal_CCD).ToString();
                //            Cam_Get1 = Convert.ToInt32(sobjR1);
                //            Rotation_TRG_1 = Cam_Get1;
                //            if (Rotation_TRG_1 != 1)
                //            {
                //                Old_Rotation_TRG_1 = 0;
                //                Project.Instance.PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 0);
                //            }
                //            else
                //            {
                //                if (Rotation_TRG_1 - Old_Rotation_TRG_1 > 0)
                //                {
                //                    RefleshRotationTextMsgBox("接收到CCD触发信号......");
                //                    //取向
                //                    if (Acq_Rotation() && runRotation() && addMark_Rotation())
                //                    {
                //                        //发处理结果ok=1
                //                        Project.Instance.PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 1);
                //                        RefleshRotationTextMsgBox("CCD发送PLC结果：添加点对成功 ......");
                //                    }
                //                    else
                //                    {
                //                        //发处理结果NG=2
                //                        Project.Instance.PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 2);
                //                        RefleshRotationTextMsgBox("CCD发送PLC结果：添加点对失败 ......");
                //                    }
                //                }
                //                Old_Rotation_TRG_1 = 1;
                //            }

                //            //PLC运动结束信号
                //            sobjR1 = Project.Instance.PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Rotation_Move_End_CCD).ToString();
                //            int PLC_Get1 = Convert.ToInt32(sobjR1);
                //            Rotation_Move_END_TRG_1 = PLC_Get1;
                //            if (Rotation_Move_END_TRG_1 != 1)
                //            {
                //                Old_Rotation_Move_END_TRG_1 = 0;
                //            }
                //            else
                //            {
                //                if (Rotation_Move_END_TRG_1 - Old_Rotation_Move_END_TRG_1 > 0)
                //                {
                //                    RefleshRotationTextMsgBox("CCD接收到PLC运动结束信号......");
                //                    //标定
                //                    if (rotation())
                //                    {
                //                        //发标定结果
                //                        RefleshRotationTextMsgBox("CCD发送标定结束信号：标定成功 ......");
                //                    }
                //                    else
                //                    {
                //                        RefleshRotationTextMsgBox("CCD发送标定结束信号：标定失败 ......");
                //                    }
                //                    _b_Auto_Rotation = false;
                //                    SetRotationCalibMode(false);
                //                }

                //                Old_Rotation_Move_END_TRG_1 = 1;
                //            }
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        LogHelper.Error("CCD信号交互(旋转中心标定)出现异常", ex);
                //        RefleshRotationTextMsgBox(ex.ToString());
                //    }
                //    #endregion
                //}
            }
        }
        /// <summary>
        /// 更改旋转中心标定模式
        /// false为手动，true为自动
        /// </summary>
        private void SetRotationCalibMode(bool bAutoRotation)
        {
            //更改标定模式
            rdo_Ro_Manual.Checked = !bAutoRotation;
            rdo_Ro_Auto.Checked = bAutoRotation;
            btn_Ro_Auto.Enabled = bAutoRotation;
            gb_Rotation.Enabled = !bAutoRotation;
            gb_RotationCon.Enabled = !bAutoRotation;

            //停止实时采集
            if (bAutoRotation)
            {
                if (cogRecordDisplayRotation.LiveDisplayRunning)
                    cogRecordDisplayRotation.StopLiveDisplay();

                rdo_Ro_Snap.Checked = bAutoRotation;
                rdo_Ro_Live.Checked = !bAutoRotation;
                gb_RotationVision.Enabled = !bAutoRotation;
            }
            else
            {
                //手动模式
                _b_Auto_Rotation = false;
                gb_RotationVision.Enabled = !bAutoRotation;
                gb_RotationVision.Enabled = true;
                btn_Ro_Run.Enabled = true;
                btn_Ro_AddMark.Enabled = true;
                btn_Ro_Start.Enabled = true;
                btn_Ro_Clear.Enabled = true;
                btn_Ro_Save.Enabled = true;
                btn_Ro_FileImage.Enabled = true;
                //if (rdo_PLC_Con_R.Checked)
                //{
                //    if (Project.Instance.PLCManagerInstance.plc4Service.PLCConnectState)
                //    {
                //        //通知PLC停止一键标定.
                //        Project.Instance.PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.Rotation_Request_CCD, 0);
                //    }
                //    //停止接收PLC
                //    if (cts2 != null)
                //    {
                //        cts2.Cancel();
                //        cts2.Dispose();
                //        cts2 = null;
                //    }
                //    //cts2 = new CancellationTokenSource();
                //    //new Task(() => PC_PLC_SignalExchange_Rotation(cts2.Token, false)).Start();
                //}
                //if (rdo_Robot_Con_R.Checked)
                //{
                //    //通知ROBOT停止一键标定.
                //    if (Project.Instance.RobotManagerInstance.RobotObj.IsConnectedRobot[vppindex])
                //    {
                //        Project.Instance.RobotManagerInstance.RobotObj.SendText(RobotSignalsModel.CCDRobotRCalStop, 0);
                //    }
                //}
                RefleshRotationTextMsgBox("CCD手动旋转中心标定模式开启......");
            }
        }

        #region 旋转中心手动标定

        private bool Acq_Rotation()
        {
            try
            {
                if (cogRecordDisplayRotation.Image != null)
                {
                    cogRecordDisplayRotation.StaticGraphics.Clear();
                    cogRecordDisplayRotation.InteractiveGraphics.Clear();
                }
                if (btn_Ro_Acq.Text == "采集图像")
                {
                    #region 采集图像
                    //_e.bAcquire = true;
                    bool test = cur_WorkFlow.RunAcquireBlock(out img);
                    if (!test)
                    {
                        return false;
                    }
                    else
                    {
                        cogGraphicLabel1.SetXYText(100, 100, DateTime.Now.ToString("HH:mm:ss"));
                        cogRecordDisplayRotation.Image = img;
                        cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel1, "");
                        cogRecordDisplayRotation.Fit(true);
                    }
                    #endregion
                }
                else if (btn_Ro_Acq.Text == "实时采集")
                {
                    #region 实时采集
                    if (null == acq.Operator.FrameGrabber)
                    {
                        MessageBox.Show("没有相机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    btn_Ro_Acq.Text = "停止实时";
                    btn_Ro_Acq.BackColor = Color.FromArgb(230, 80, 80);
                    gb_RotationVision.Enabled = false;
                    btn_Ro_Run.Enabled = false;
                    btn_Ro_AddMark.Enabled = false;
                    btn_Ro_Start.Enabled = false;
                    btn_Ro_Clear.Enabled = false;
                    btn_Ro_Save.Enabled = false;
                    btn_Ro_FileImage.Enabled = false;
                    if ((null != acq.Operator) && (null != acq.Operator.FrameGrabber))
                    {
                        if (cogRecordDisplayRotation.LiveDisplayRunning)
                            cogRecordDisplayRotation.StopLiveDisplay();
                        cogRecordDisplayRotation.StaticGraphics.Clear();
                        cogRecordDisplayRotation.StartLiveDisplay(acq.Operator, true);
                        //cogRecordDisplayRotation.Fit(true);
                    }
                    #endregion
                }
                else if (btn_Ro_Acq.Text == "停止实时")
                {
                    #region 停止实时
                    btn_Ro_Acq.Text = "实时采集";
                    btn_Ro_Acq.BackColor = Color.FromArgb(220, 155, 40);
                    gb_RotationVision.Enabled = true;
                    btn_Ro_Run.Enabled = true;
                    btn_Ro_AddMark.Enabled = true;
                    btn_Ro_Start.Enabled = true;
                    btn_Ro_Clear.Enabled = true;
                    btn_Ro_Save.Enabled = true;
                    btn_Ro_FileImage.Enabled = true;
                    if (cogRecordDisplayRotation.LiveDisplayRunning)
                        cogRecordDisplayRotation.StopLiveDisplay();
                    //cogRecordDisplayRotation.Fit(true);
                    #endregion
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("图像采集(旋转中心标定)出现异常", ex);
                return false;
            }
            return true;
        }
        private bool Clear_Rotation()
        {
            if (MessageBox.Show("将要清楚旧标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 0;
                if (rdo_Ro_Robot1.Checked)
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = nozzleIndex;
                }
                else
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 1;
                }

                cur_WorkFlow.RotationCalibBlock.Run();
                RotationCenter_X = 0.0;
                RotationCenter_Y = 0.0;
                Rotation_RMS = 0;
                RefleshRotationDataGridView();
                RefleshRotationTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }
        private bool runRotation()
        {
            try
            {
                if (img != null)
                {
                    if (rdo_Ro_Robot1.Checked)
                    {
                        cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 1;
                        cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 0;
                        cur_WorkFlow.RunRotationCalibBlock(ref img);
                        if (cur_WorkFlow.RotationCalibBlock.RunStatus.Result == CogToolResultConstants.Accept)
                        {

                            cogRecordDisplayRotation.Record = cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"].CreateLastRunRecord();
                            cogGraphicLabel2.Color = CogColorConstants.Blue;
                            cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_rotation_UnCalibrated_block.Outputs["X"].Value).ToString("F3"), ((double)_rotation_UnCalibrated_block.Outputs["Y"].Value).ToString("F3")));
                            cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                            cogRecordDisplayRotation.Fit(true);
                            _Rotation_State = true;
                        }
                        else
                        {
                            cogGraphicLabel2.Color = CogColorConstants.Red;
                            cogGraphicLabel2.SetXYText(100, 200, "视觉模板运行错误!");
                            cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                            cogRecordDisplayRotation.Fit(true);
                            RefleshRotationTextMsgBox("视觉模板运行错误!");
                            return false;
                        }
                    }
                    else
                    {
                        cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 1;
                        cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 1;
                        cur_WorkFlow.RunRotationCalibBlock(ref img);
                        if (cur_WorkFlow.RotationCalibBlock.RunStatus.Result == CogToolResultConstants.Accept)
                        {
                            cogRecordDisplayRotation.Record = cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"].CreateLastRunRecord();
                            cogGraphicLabel2.Color = CogColorConstants.Blue;
                            cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_rotation_UnCalibrated_block.Outputs["X"].Value).ToString("F3"), ((double)_rotation_UnCalibrated_block.Outputs["Y"].Value).ToString("F3")));
                            cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                            cogRecordDisplayRotation.Fit(true);
                            _Rotation_State = true;
                        }
                        else
                        {
                            cogGraphicLabel2.Color = CogColorConstants.Red;
                            cogGraphicLabel2.SetXYText(100, 200, "视觉模板运行错误!");
                            cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                            cogRecordDisplayRotation.Fit(true);
                            RefleshRotationTextMsgBox("视觉模板运行错误!");
                            return false;
                        }
                    }
                }
                else
                {
                    RefleshRotationTextMsgBox("采集图像为空!");
                    return false;
                }
            }
            catch
            {
                RefleshRotationTextMsgBox("标定视觉运行错误!");
                return false;
            }
            return true;
        }

        private bool addMark_Rotation()
        {
            if (!_Rotation_State)
            {
                return false;
            }
            cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 2;
            if (rdo_Ro_Robot1.Checked)
            {
                cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 0;
            }
            else
            {
                cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 1;
            }

            cur_WorkFlow.RotationCalibBlock.Run();
            RefleshRotationDataGridView();
            RefleshRotationTextMsgBox("添加点位成功!");
            return true;
        }

        private bool rotation()
        {
            try
            {
                if (!_Rotation_State)
                {
                    return false;
                }
                cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 3;
                if (rdo_Ro_Robot1.Checked)
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 0;
                }
                else
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 1;
                }
                cur_WorkFlow.RotationCalibBlock.Run();
                //标定结果刷新

                if (rdo_Ro_Robot1.Checked)
                {
                    RotationCenter_X = (double)_rotation_caculate_block.Outputs["RC_X"].Value;
                    RotationCenter_Y = (double)_rotation_caculate_block.Outputs["RC_Y"].Value;
                    Rotation_RMS = _rotation_calib_tool.Result.RMSError;
                    saveResult_Rotation();
                }
                else
                {
                    RotationCenter_X = (double)_rotation_caculate_block1.Outputs["RC_X"].Value;
                    RotationCenter_Y = (double)_rotation_caculate_block1.Outputs["RC_Y"].Value;
                    Rotation_RMS = _rotation_calib_tool1.Result.RMSError;
                    saveResult_Rotation();
                }

            }
            catch (Exception e)
            {
                _Rotation_State = false;
                RefleshRotationTextMsgBox(e.ToString());
                return false;
            }
            return true;
        }


        /// <summary>
        /// Rotation保存结果
        /// </summary>
        private void saveResult_Rotation()
        {
            //     nozzleIndex = Convert.ToInt32(this.cbo_Nozzle_Rotation.Text) - 1;
            if (_Rotation_State)
            {
                if (vppindex == 0)
                {
                    if (rdo_Ro_Robot1.Checked)
                    {
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[0] = RotationCenter_X;
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[0] = RotationCenter_Y;
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[0] = Rotation_RMS;
                    }
                    else
                    {
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[1] = RotationCenter_X;
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[1] = RotationCenter_Y;
                        //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[1] = Rotation_RMS;
                    }

                }
                else if (vppindex == 1)
                {
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_X[nozzleIndex] = RotationCenter_X;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_RMS[nozzleIndex] = Rotation_RMS;
                }
                else if (vppindex == 2)
                {
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_X[nozzleIndex] = RotationCenter_X;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_RMS[nozzleIndex] = Rotation_RMS;
                }
                else if (vppindex == 3)
                {
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_X[nozzleIndex] = RotationCenter_X;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_RMS[nozzleIndex] = Rotation_RMS;
                }
                SaveRotationCenter(vppindex, nozzleIndex);
                cur_WorkFlow.SaveTools();
                RefleshRotationTextMsgBox("旋转中心标定结果保存成功！");
            }
        }
        /// <summary>
        /// 保存Rotation旋转中心坐标
        /// </summary>
        /// <param name="ccdIndex">相机index</param>
        /// <param name="nozzleIndex">吸嘴index</param>
        private void SaveRotationCenter(int ccdIndex, int nozzleIndex)
        {
            try
            {
                string ssss = Project.Instance.VisionManagerInstance._visionParamPath;
                _iniRotation = new IniHelper(Project.Instance.VisionManagerInstance._visionParamPath + @"\\Config" + "\\ParamsC1.ini");
                if (ccdIndex == 0)
                {
                    if (rdo_Ro_Robot1.Checked)
                    {
                        //_iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[0].ToString());
                        //_iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[0].ToString());
                        //_iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[0].ToString());

                    }
                    else
                    {
                        //_iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[1].ToString());
                        //_iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[1].ToString());
                        //_iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[1].ToString());

                    }
                    //_iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_X[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_Y[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam1Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 1)
                {
                    //_iniRotation.WriteIniKey("camera2", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_X[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera2", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_Y[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera2", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam2Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 2)
                {
                    //_iniRotation.WriteIniKey("camera3", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_X[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera3", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_Y[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera3", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam3Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 3)
                {
                    //_iniRotation.WriteIniKey("camera4", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_X[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera4", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_Y[nozzleIndex].ToString());
                    //_iniRotation.WriteIniKey("camera4", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.L_cam4Rotation_RMS[nozzleIndex].ToString());
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("保存当前相机吸嘴旋转中心参数异常", ex);
            }
        }

        #endregion
        /// <summary>
        /// 读取Rotation标定MARK点
        /// </summary>
        private void RefleshRotationDataGridView()
        {
            try
            {
                if (!this.dataGridViewRotation.IsDisposed)
                {
                    if (this.dataGridViewRotation.InvokeRequired)
                    {
                        RefleshDataGridViewCallback dd = new RefleshDataGridViewCallback(RefleshRotationDataGridView);
                        this.Invoke(dd, new object[] { });
                    }
                    else
                    {
                        this.dataGridViewRotation.Rows.Clear();

                        if (rdo_Ro_Robot1.Checked)
                        {
                            if (_rotation_calib_tool != null)
                            {
                                int num = _rotation_calib_tool.RunParams.NumPoints;

                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _rotation_calib_tool.RunParams.GetX(i);
                                    double UncalibratedPointY = _rotation_calib_tool.RunParams.GetY(i);
                                    this.dataGridViewRotation.Rows.Add();
                                    this.dataGridViewRotation.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewRotation.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                }
                                this.dataGridViewRotation.FirstDisplayedScrollingRowIndex = this.dataGridViewRotation.Rows.Count - 1;
                                int bb = this.dataGridViewRotation.Rows.Count;
                                this.dataGridViewRotation.Rows[this.dataGridViewRotation.Rows.Count - 1].Selected = true;
                            }
                        }
                        else
                        {
                            if (_rotation_calib_tool1 != null)
                            {
                                int num = _rotation_calib_tool1.RunParams.NumPoints;

                                for (int i = 0; i < num; i++)
                                {
                                    double UncalibratedPointX = _rotation_calib_tool1.RunParams.GetX(i);
                                    double UncalibratedPointY = _rotation_calib_tool1.RunParams.GetY(i);
                                    this.dataGridViewRotation.Rows.Add();
                                    this.dataGridViewRotation.Rows[i].Cells[0].Value = Math.Round(UncalibratedPointX, 3);
                                    this.dataGridViewRotation.Rows[i].Cells[1].Value = Math.Round(UncalibratedPointY, 3);
                                }
                                this.dataGridViewRotation.FirstDisplayedScrollingRowIndex = this.dataGridViewRotation.Rows.Count - 1;
                                int bb = this.dataGridViewRotation.Rows.Count;
                                this.dataGridViewRotation.Rows[this.dataGridViewRotation.Rows.Count - 1].Selected = true;
                            }
                        }


                    }
                }
                else
                {
                    Thread.CurrentThread.Abort();
                }
            }
            catch
            {
            }
        }


        /// <summary>
        /// Rotation刷新  TextBox
        /// </summary>
        /// <param name="str"></param>
        private void RefleshRotationTextMsgBox(string str)
        {
            try
            {
                if (!this.tb_msg_Rotation.IsDisposed)
                {
                    if (this.tb_msg_Rotation.InvokeRequired)
                    {
                        RefleshTextMsgBoxCallback dd = new RefleshTextMsgBoxCallback(RefleshRotationTextMsgBox);
                        this.Invoke(dd, new object[] { str });
                    }
                    else
                    {
                        this.tb_msg_Rotation.AppendText(System.Environment.NewLine);
                        str += DateTime.Now.ToString("  yyyy.MM.dd HH:mm:ss  ");
                        this.tb_msg_Rotation.Text += str;
                        this.tb_msg_Rotation.Select(this.tb_msg_Rotation.TextLength, 0);
                        this.tb_msg_Rotation.ScrollToCaret();
                    }
                }
                else
                {
                    Thread.CurrentThread.Abort();
                }
            }
            catch
            {
            }
        }
        #endregion
    }
}
