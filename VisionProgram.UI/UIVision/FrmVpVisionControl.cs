using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using VisionProgram.Common;
using VisionProgram.Models.VModels;
using VisionProgram.Vision.VP;
using VisionProgram.ProjectClass;
using VisionProgram.Models.DModels;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Main.ProjectClass.PLC;
using VisionProgram.Main;
using VisionProgram.Main.ProjectClass.Vision.Global;
using System.Diagnostics;
using VisionProgram.Main.ProjectClass.Robot;
using System.Threading;

namespace VisionProgram.UI.UIVision
{
    public partial class FrmVpVisionControl : Form
    {
        #region 变量
        /// <summary>
        /// 特征码，区分不同的流程
        /// </summary>
        private string _vppName;
        /// <summary>
        ///  根据特征码得到工具索引 
        /// </summary>
        private int _workFlowIndex;

        public string VppName
        {
            get { return _vppName; }
        }
        /// <summary>
        /// 是否在实时取像
        /// </summary>
        private bool _isLive = false;
        /// <summary>
        /// 实时状态标志
        /// </summary>
        public bool IsLive
        {
            get { return _isLive; }
            set
            {
                if (_isLive != value)
                {
                    _isLive = value;
                }
            }
        }
        /// <summary>
        /// 当前运行工具
        /// </summary>
        private WorkFlow _curWorkFlow;
        public WorkFlow CurWorkFlow
        {
            get { return _curWorkFlow; }
        }
        /// <summary>
        /// 手动运行的获取图片方式
        /// </summary>
        public enum LoadStyle { Image = 0, Folder = 1 }
        public LoadStyle ImageLoadStyle
        {
            set;
            get;
        }
        /// <summary>
        /// 手动运行的图片名称
        /// </summary>
        public string ImageName
        {
            set;
            get;
        }
        /// <summary>
        /// 手动运行的图片所在文件夹
        /// </summary>
        public string DirectoryName
        {
            set;
            get;
        }
        /// <summary>
        /// 手动运行的图片集合
        /// </summary>
        public string[] ImageInfoNames
        {
            set;
            get;
        }
        /// <summary>
        /// 将要运行的图片
        /// </summary>
        private ICogImage _image2BRun;


        /// <summary>
        /// VisionPRO图片显示窗口
        /// </summary>
        public CogRecordsDisplay RecordDisplay
        {
            get
            {
                return this.cogRecordDisplay1;
            }
        }
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p"></param>
        public FrmVpVisionControl(string p)
        {

            System.Diagnostics.Stopwatch watch1 = new Stopwatch();//计算程序耗时
            System.Diagnostics.Stopwatch watch2 = new Stopwatch();//计算程序耗时
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            _vppName = p;
            //当前窗体对应的vpp索引
            _workFlowIndex = Convert.ToInt16(_vppName) - 1;

            try
            {
                _curWorkFlow = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            GlobalCameraParams.toolStripMenuItem.Add(工具设置ToolStripMenuItem);
            GlobalCameraParams.toolStripMenuItem.Add(图片保存ToolStripMenuItem);
            cogRecordDisplay1.Display.BackColor = Color.Black;
            cogRecordDisplay1.Display.GridColor = Color.Black;
        }

        /// <summary>
        /// 退出
        /// </summary>
        public void Exit()
        {
            try
            {
                //停止实时
                stopLiveDisplay();
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].disconnect();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 在界面显示实时图像
        /// </summary>
        public bool CameraLive()
        {
            double relExpose = 0;
            ICogAcqFifo CamOperator = _curWorkFlow.AcquireTool.Operator;
            try
            {
                if (tbExposeReal.Text != null&& tbExposeReal.Text != "")
                {
                    relExpose = Convert.ToDouble(tbExposeReal.Text);
                }
                else
                {
                    relExpose = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[0];
                }
            }
            catch 
            { 
                relExpose = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[0]; 
            }
            if (CamOperator != null && CamOperator.FrameGrabber != null)
            {

                CamOperator.OwnedExposureParams.Exposure = relExpose;
                if (CamOperator.CameraPort >= 0)
                {
                    this.cogRecordDisplay1.Display.StaticGraphics.Clear();
                    this.cogRecordDisplay1.Subject = null;
                    cogRecordDisplay1.Display.BackColor = Color.Black;
                    cogRecordDisplay1.Display.GridColor = Color.Black;
                    CogLine lineX = new CogLine();
                    CogLine lineY = new CogLine();
                    int x, y, width, height;
                    CamOperator.OwnedROIParams.GetROIXYWidthHeight(out x, out y, out width, out height);
                    lineX.SetXYRotation(width / 2, height / 2, 0);
                    lineX.Interactive = false;
                    lineX.Selected = false;
                    lineX.Color = CogColorConstants.Red;

                    lineY.SetXYRotation(width / 2, height / 2, Math.PI / 2);
                    lineY.Interactive = false;
                    lineY.Selected = false;
                    lineY.Color = CogColorConstants.Red;

                    this.cogRecordDisplay1.Display.StaticGraphics.Add(lineX, "");
                    this.cogRecordDisplay1.Display.StaticGraphics.Add(lineY, "");
                    this.cogRecordDisplay1.Display.StaticGraphics.Add(new CogGraphicLabel { Text = "实时显示中...", Color = CogColorConstants.Red, X = 200, Y = 50, Font = new Font("宋体", 12, FontStyle.Bold) }, "");
                    this.cogRecordDisplay1.Display.StartLiveDisplay(CamOperator, true);
                    _isLive = true;
                    return true;
                }
                else
                {
                    MessageBox.Show("相机已丢失！");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("控件CamOperator属性未赋值！");
                return false;
            }
        }

        /// <summary>
        /// 工具保存之后处理事件
        /// </summary>
        public void AfterSaveTool()
        {
            //更改序列号标题
            showTitle();
            //曝光写到config                 
            ICogAcqFifo CamOperator = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].AcquireTool.Operator;
            if (CamOperator != null && CamOperator.FrameGrabber != null)
            {
                if (CamOperator.CameraPort >= 0)
                {
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[_workFlowIndex] = CamOperator.OwnedExposureParams.Exposure;
                    //写入config
                    string varName = "camera" + (_workFlowIndex + 1).ToString();
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams(varName, "Exprosure", Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[_workFlowIndex].ToString());
                    //刷新CCD链接状态
                    Project.Instance().HardWareStateManagerInstance.L_ccdState[_workFlowIndex] = true;
                }
            }
        }

        /// <summary>
        /// 显示窗体标题
        /// </summary>
        public void showTitle()
        {
            lbImageName.Text = Project.Instance().VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[_workFlowIndex].ImageWindowName;
            if (_curWorkFlow.AcquireTool.Operator != null && _curWorkFlow.AcquireTool.Operator.FrameGrabber != null)
            {
                lbSerialNum.Text = "SN " + _curWorkFlow.AcquireTool.Operator.FrameGrabber.SerialNumber;
            }
            else
            {
                lbSerialNum.Text = "SN 未连接";
            }
        }

        private void FrmVisionControl_Load(object sender, EventArgs e)
        {
            showTitle();
            menuStrip.CanOverflow = true;//允许菜单栏溢出
        }

        /// <summary>
        /// 单帧取相
        /// </summary>
        public void GrabImage()
        {

          

            this.cogRecordDisplay1.Display.StaticGraphics.Clear();
            this.cogRecordDisplay1.Subject = null;
            cogRecordDisplay1.Display.BackColor = Color.Black;
            cogRecordDisplay1.Display.GridColor = Color.Black;
            _curWorkFlow.RunAcquireBlock(out _image2BRun);
            this.cogRecordDisplay1.Display.Image = _image2BRun;
            this.cogRecordDisplay1.Display.Fit(true);

            //模拟人工点击处理按钮
            this.处理ToolStripMenuItem.PerformClick();
        }

        /// <summary>
        /// 单帧取相
        /// </summary>
        public void GrabImage1()
        {
            this.cogRecordDisplay1.Display.StaticGraphics.Clear();
            this.cogRecordDisplay1.Subject = null;
            cogRecordDisplay1.Display.BackColor = Color.Black;
            cogRecordDisplay1.Display.GridColor = Color.Black;
            _curWorkFlow.RunAcquireBlock(out _image2BRun);
            this.cogRecordDisplay1.Display.Image = _image2BRun;
            this.cogRecordDisplay1.Display.Fit(true);
            //模拟人工点击处理按钮
            this.处理2工位ToolStripMenuItem.PerformClick();
        }

        /// <summary>
        /// 在图像上显示字符串
        /// </summary>
        /// <param name="text">要显示的字符串文本</param>
        /// <param name="x">显示位置的X坐标</param>
        /// <param name="y">显示位置的Y坐标</param>
        /// <param name="color">要显示字符串的前景色</param>
        /// <param name="textSize">要显示的字符串的字体大小</param>
        /// <param name="beforeClear">添加字符串之前是否清除以前添加的所有图形（包括字符串）</param>
        public void AddTextOnImage(string text, int x, int y, CogColorConstants color, float textSize, bool beforeClear = true)
        {
            if (beforeClear)
            {
                this.RecordDisplay.Display.StaticGraphics.Clear();
            }
            CogGraphicLabel label = new CogGraphicLabel();
            label.SetXYText(x, y, text);
            label.Font = new Font("宋体", textSize, FontStyle.Bold);
            label.Color = color;
            this.RecordDisplay.Display.StaticGraphics.Add(label, "");
        }

       
        private void 实时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //开始实时
            if (实时ToolStripMenuItem.Text == "开始实时")
            {
                if (CameraLive())
                {
                    实时ToolStripMenuItem.Text = "停止实时";
                    _isLive = true;
                    return;
                }
            }
            if (实时ToolStripMenuItem.Text == "停止实时")
            {
                stopLiveDisplay();
                return;
            }
        }

        /// <summary>
        /// 停止实时取向
        /// </summary>
        public void stopLiveDisplay()
        {
            if (_isLive)
            {
                实时ToolStripMenuItem.Text = "开始实时";
                _isLive = false;
                this.cogRecordDisplay1.Display.StaticGraphics.Clear();
                this.cogRecordDisplay1.Subject = null;
                cogRecordDisplay1.Display.BackColor = Color.Black;
                cogRecordDisplay1.Display.GridColor = Color.Black;
                this.cogRecordDisplay1.Display.StopLiveDisplay();
            }
        }

        private void 单帧ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isLive)
            {
                实时ToolStripMenuItem.Text = "开始实时";
                _isLive = false;
                this.cogRecordDisplay1.Display.StaticGraphics.Clear();
                this.cogRecordDisplay1.Subject = null;
                cogRecordDisplay1.Display.BackColor = Color.Black;
                cogRecordDisplay1.Display.GridColor = Color.Black;
                this.cogRecordDisplay1.Display.StopLiveDisplay();
            }


            try
            {
                string lasermove = "_PDMoveAbs(0," + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[0].ToString() + "," + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[0].ToString() + ",500);";
                Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser = Project.Instance().LaserManagerInstance.L_Laser[0].SendText(lasermove);
                if (!Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser)
                {
                    Project.Instance().LaserManagerInstance.L_Laser[0].Connect();
                    Thread.Sleep(50);
                    Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser = Project.Instance().LaserManagerInstance.L_Laser[0].SendText(lasermove);
                }
                Thread.Sleep(100);
            }
            catch (Exception)
            {
                if (null != Project.Instance().LaserManagerInstance.L_Laser[0]) Project.Instance().LaserManagerInstance.L_Laser[0].Close();
                Project.Instance().LaserManagerInstance.L_Laser[0].Connect();
            }
           
            GrabImage();
        }

        public double Cam2offsetX = 0.0;
        public double Cam2offsetY = 0.0;
        public double Cam2offsetR = 0.0;

        public double Cam1posXRob1 = 0.0;
        public double Cam1posYRob1 = 0.0;
        public double Cam1posRRob1 = 0.0;
        public double Cam1posXRob2 = 0.0;
        public double Cam1posYRob2 = 0.0;
        public double Cam1posRRob2 = 0.0;
        public double Cam1posXLas1 = 0.0;
        public double Cam1posYLas1 = 0.0;
        public double Cam1posRLas1 = 0.0;
        public double Cam1posXLas2 = 0.0;
        public double Cam1posYLas2 = 0.0;
        public double Cam1posRLas2 = 0.0;

        public double Cam2posX = 0.0;
        public double Cam2posY = 0.0;
        public double Cam2posR = 0.0;

        public double Cam4offsetX = 0.0;
        public double Cam4offsetY = 0.0;
        public double Cam4offsetR = 0.0;

        public double Cam3posX = 0.0;
        public double Cam3posY = 0.0;
        public double Cam3posR = 0.0;

        public double Cam4posX = 0.0;
        public double Cam4posY = 0.0;
        public double Cam4posR = 0.0;

        public double WeldLength = 0.0;

        private volatile bool[] _camComplete = new bool[Project.Instance().VisionManagerInstance.CameraNum]; //相机完成标识
        private volatile int[] _camResult = new int[Project.Instance().VisionManagerInstance.CameraNum];//相机结果标识

        private void 处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_image2BRun == null)
                {
                    MessageBox.Show("未提供图片！");
                    return;
                }
                
                #region 参数初始化
                //当前吸嘴个数
                int NozzleNum = 1;//1个
                //基准 1             
                double[] stdX1 = new double[NozzleNum];
                double[] stdY1 = new double[NozzleNum];
                double[] stdT1 = new double[NozzleNum];
                //补偿   1           
                double[] addX1 = new double[NozzleNum];
                double[] addY1 = new double[NozzleNum];
                double[] addT1 = new double[NozzleNum];
                //临时位置1
                double[] stdX_temp1 = new double[NozzleNum];
                double[] stdY_temp1 = new double[NozzleNum];
                //基准 2             
                double[] stdX2 = new double[NozzleNum];
                double[] stdY2 = new double[NozzleNum];
                double[] stdT2 = new double[NozzleNum];
                //补偿   2           
                double[] addX2 = new double[NozzleNum];
                double[] addY2 = new double[NozzleNum];
                double[] addT2 = new double[NozzleNum];
                //临时位置2
                double[] stdX_temp2 = new double[NozzleNum];
                double[] stdY_temp2 = new double[NozzleNum];
                //基准 3             
                double[] stdX3 = new double[NozzleNum];
                double[] stdY3 = new double[NozzleNum];
                double[] stdT3 = new double[NozzleNum];
                //补偿  3           
                double[] addX3 = new double[NozzleNum];
                double[] addY3 = new double[NozzleNum];
                double[] addT3 = new double[NozzleNum];
                //临时位置3
                double[] stdX_temp3 = new double[NozzleNum];
                double[] stdY_temp3 = new double[NozzleNum];
                //基准 4             
                double[] stdX4 = new double[NozzleNum];
                double[] stdY4 = new double[NozzleNum];
                double[] stdT4 = new double[NozzleNum];
                //补偿  4           
                double[] addX4 = new double[NozzleNum];
                double[] addY4 = new double[NozzleNum];
                double[] addT4 = new double[NozzleNum];
                //临时位置4
                double[] stdX_temp4 = new double[NozzleNum];
                double[] stdY_temp4 = new double[NozzleNum];
                //当前
                double[] posX = new double[NozzleNum];
                double[] posY = new double[NozzleNum];
                double[] posT = new double[NozzleNum];
                double[] posXROB1 = new double[NozzleNum];
                double[] posYROB1 = new double[NozzleNum];
                double[] posTROB1 = new double[NozzleNum];
                double[] posXROB2 = new double[NozzleNum];
                double[] posYROB2 = new double[NozzleNum];
                double[] posTROB2 = new double[NozzleNum];
                double[] posXLAS1 = new double[NozzleNum];
                double[] posYLAS1 = new double[NozzleNum];
                double[] posTLAS1 = new double[NozzleNum];
                double[] posXLAS2 = new double[NozzleNum];
                double[] posYLAS2 = new double[NozzleNum];
                double[] posTLAS2 = new double[NozzleNum];
                //偏差 1
                double[] dX1 = new double[NozzleNum];
                double[] dY1 = new double[NozzleNum];
                double[] dT1 = new double[NozzleNum];
                //偏差 2
                double[] dX2 = new double[NozzleNum];
                double[] dY2 = new double[NozzleNum];
                double[] dT2 = new double[NozzleNum];
                //偏差 3
                double[] dX3 = new double[NozzleNum];
                double[] dY3 = new double[NozzleNum];
                double[] dT3 = new double[NozzleNum];
                //偏差 4
                double[] dX4 = new double[NozzleNum];
                double[] dY4 = new double[NozzleNum];
                double[] dT4 = new double[NozzleNum];
                //旋转中心
                double[] Rotation_X = new double[NozzleNum];
                double[] Rotation_Y = new double[NozzleNum];
                //钢片角度按范围补偿
                double[] angleAdd_1 = new double[NozzleNum];
                double[] angleAdd_2 = new double[NozzleNum];
                double[] angleAdd_3 = new double[NozzleNum];
                double[] angleAdd1 = new double[NozzleNum];
                double[] angleAdd2 = new double[NozzleNum];
                double[] angleAdd3 = new double[NozzleNum];
                #endregion

                #region 
                for (int i = 0; i < NozzleNum; i++)
                {
                    //基准1
                    stdX1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[i];
                    stdY1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[i];
                    stdT1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[i];
                    //补偿1
                    addX1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[i];
                    addY1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[i];
                    addT1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[i];
                    //基准2
                    stdX2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[i];
                    stdY2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[i];
                    stdT2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[i];
                    //补偿2
                    addX2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[i];
                    addY2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[i];
                    addT2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[i];
                    //基准3
                    stdX3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[i];
                    stdY3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[i];
                    stdT3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[i];
                    //补偿3
                    addX3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[i];
                    addY3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[i];
                    addT3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[i];
                    //基准4
                    stdX4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[i];
                    stdY4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[i];
                    stdT4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[i];
                    //补偿4
                    addX4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[i];
                    addY4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[i];
                    addT4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[i];
                    //钢片角度补偿
                    angleAdd_1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_1[i];
                    angleAdd_2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_2[i];
                    angleAdd_3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_3[i];
                    angleAdd1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd1[i];
                    angleAdd2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd2[i];
                    angleAdd3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd3[i];

                }




                #endregion

                #region 额外补偿
                double AddR1J1X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[0];
                double AddR1J1Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[0];
                double AddR2J1X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[0];
                double AddR2J1Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[0];
                double AddL1J1X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[0];
                double AddL1J1Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[0];
                double AddL1J1X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[0];
                double AddL1J1Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[0];
                double AddL1J1X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[0];
                double AddL1J1Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[0];
                double AddL1J1X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[0];
                double AddL1J1Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[0];
                double AddL2J1X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[0];
                double AddL2J1Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[0];
                double AddL2J1X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[0];
                double AddL2J1Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[0];
                double AddL2J1X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[0];
                double AddL2J1Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[0];
                double AddL2J1X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[0];
                double AddL2J1Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[0];

                double AddR1J2X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[0];
                double AddR1J2Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[0];
                double AddR2J2X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[0];
                double AddR2J2Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[0];
                double AddL1J2X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[0];
                double AddL1J2Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[0];
                double AddL1J2X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[0];
                double AddL1J2Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[0];
                double AddL1J2X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[0];
                double AddL1J2Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[0];
                double AddL1J2X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[0];
                double AddL1J2Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[0];
                double AddL2J2X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[0];
                double AddL2J2Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[0];
                double AddL2J2X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[0];
                double AddL2J2Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[0];
                double AddL2J2X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[0];
                double AddL2J2Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[0];
                double AddL2J2X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[0];
                double AddL2J2Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[0];

                double AddR1J3X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[0];
                double AddR1J3Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[0];
                double AddR2J3X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[0];
                double AddR2J3Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[0];
                double AddL1J3X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[0];
                double AddL1J3Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[0];
                double AddL1J3X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[0];
                double AddL1J3Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[0];
                double AddL1J3X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[0];
                double AddL1J3Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[0];
                double AddL1J3X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[0];
                double AddL1J3Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[0];
                double AddL2J3X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[0];
                double AddL2J3Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[0];
                double AddL2J3X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[0];
                double AddL2J3Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[0];
                double AddL2J3X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[0];
                double AddL2J3Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[0];
                double AddL2J3X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[0];
                double AddL2J3Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[0];

                double AddR1J4X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[0];
                double AddR1J4Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[0];
                double AddR2J4X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[0];
                double AddR2J4Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[0];
                double AddL1J4X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[0];
                double AddL1J4Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[0];
                double AddL1J4X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[0];
                double AddL1J4Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[0];
                double AddL1J4X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[0];
                double AddL1J4Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[0];
                double AddL1J4X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[0];
                double AddL1J4Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[0];
                double AddL2J4X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[0];
                double AddL2J4Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[0];
                double AddL2J4X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[0];
                double AddL2J4Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[0];
                double AddL2J4X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[0];
                double AddL2J4Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[0];
                double AddL2J4X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[0];
                double AddL2J4Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[0];

                double AddR1J5X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[0];
                double AddR1J5Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[0];
                double AddR2J5X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[0];
                double AddR2J5Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[0];
                double AddL1J5X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[0];
                double AddL1J5Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[0];
                double AddL1J5X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[0];
                double AddL1J5Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[0];
                double AddL1J5X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[0];
                double AddL1J5Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[0];
                double AddL1J5X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[0];
                double AddL1J5Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[0];
                double AddL2J5X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[0];
                double AddL2J5Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[0];
                double AddL2J5X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[0];
                double AddL2J5Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[0];
                double AddL2J5X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[0];
                double AddL2J5Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[0];
                double AddL2J5X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[0];
                double AddL2J5Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[0];

                double AddR1J6X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[0];
                double AddR1J6Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[0];
                double AddR2J6X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[0];
                double AddR2J6Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[0];
                double AddL1J6X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[0];
                double AddL1J6Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[0];
                double AddL1J6X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[0];
                double AddL1J6Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[0];
                double AddL1J6X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[0];
                double AddL1J6Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[0];
                double AddL1J6X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[0];
                double AddL1J6Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[0];
                double AddL2J6X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[0];
                double AddL2J6Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[0];
                double AddL2J6X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[0];
                double AddL2J6Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[0];
                double AddL2J6X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[0];
                double AddL2J6Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[0];
                double AddL2J6X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[0];
                double AddL2J6Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[0];

                double AddR1J7X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[0];
                double AddR1J7Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[0];
                double AddR2J7X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[0];
                double AddR2J7Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[0];
                double AddL1J7X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[0];
                double AddL1J7Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[0];
                double AddL1J7X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[0];
                double AddL1J7Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[0];
                double AddL1J7X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[0];
                double AddL1J7Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[0];
                double AddL1J7X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[0];
                double AddL1J7Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[0];
                double AddL2J7X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[0];
                double AddL2J7Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[0];
                double AddL2J7X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[0];
                double AddL2J7Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[0];
                double AddL2J7X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[0];
                double AddL2J7Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[0];
                double AddL2J7X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[0];
                double AddL2J7Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[0];

                double AddR1J8X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[0];
                double AddR1J8Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[0];
                double AddR2J8X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[0];
                double AddR2J8Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[0];
                double AddL1J8X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[0];
                double AddL1J8Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[0];
                double AddL1J8X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[0];
                double AddL1J8Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[0];
                double AddL1J8X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[0];
                double AddL1J8Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[0];
                double AddL1J8X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[0];
                double AddL1J8Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[0];
                double AddL2J8X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[0];
                double AddL2J8Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[0];
                double AddL2J8X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[0];
                double AddL2J8Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[0];
                double AddL2J8X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[0];
                double AddL2J8Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[0];
                double AddL2J8X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[0];
                double AddL2J8Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[0];

                double AddR1J9X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[0];
                double AddR1J9Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[0];
                double AddR2J9X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[0];
                double AddR2J9Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[0];
                double AddL1J9X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[0];
                double AddL1J9Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[0];
                double AddL1J9X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[0];
                double AddL1J9Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[0];
                double AddL1J9X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[0];
                double AddL1J9Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[0];
                double AddL1J9X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[0];
                double AddL1J9Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[0];
                double AddL2J9X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[0];
                double AddL2J9Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[0];
                double AddL2J9X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[0];
                double AddL2J9Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[0];
                double AddL2J9X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[0];
                double AddL2J9Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[0];
                double AddL2J9X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[0];
                double AddL2J9Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[0];


                double AddR1X = 0;
                double AddR1Y = 0;
                double AddR2X = 0;
                double AddR2Y = 0;
                double AddL1X1 = 0;
                double AddL1Y1 = 0;
                double AddL1X2 = 0;
                double AddL1Y2 = 0;
                double AddL1X3 = 0;
                double AddL1Y3 = 0;
                double AddL1X4 = 0;
                double AddL1Y4 = 0;
                double AddL2X1 = 0;
                double AddL2Y1 = 0;
                double AddL2X2 = 0;
                double AddL2Y2 = 0;
                double AddL2X3 = 0;
                double AddL2Y3 = 0;
                double AddL2X4 = 0;
                double AddL2Y4 = 0;

                double LengthC = 0;




                #endregion
                //运行取相＋处理时间
                string FinalResult = "";
                Int32 offSetX = Convert.ToInt32((Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[_workFlowIndex]) / 0.005116);
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMin"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMax"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMin"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMax"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductGrayValue"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["OffsetX"].Value = offSetX;
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunProcessBlock(ref _image2BRun);
                if (!Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].UpdateGraphicResult(GlobalCameraParams.cameraVisionControlList[_workFlowIndex]))
                {
                    //相机掉线
                    LogHelper.Error($"{_workFlowIndex + 1}相机掉线");  //写日志
                    //WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[e.Index], CogColorConstants.Red, 0, 0, "相机掉线", 60);
                    //_camResult[_workFlowIndex] = 0;

                    if ((Project.Instance().RobotManagerInstance.WaitStringN(RobotSignals.RobotNGetResult1, 30)))
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    else
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    Project.Instance().ProductionDataManagerInstance.L_ProductionStationNGCount[0]++;
                 //   _camComplete[e.Index] = false;
                    return;
                }



                Project.Instance().ProductionDataManagerInstance.L_productionCCDSumCountList[0][_workFlowIndex]++;
                bool isOk = false;
                Int16 FontSize = 15;
                bool bAccept = (bool)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["bAccept"].Value;
                string sError = (string)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["sError"].Value;
                double Pangle = (double)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["Angle"].Value;
                string _code1 = "";
                string _code2 = "";
                int _jiajuhao = 0;
                double _spacing = 0.0;
                if (Project.Instance().PLCManagerInstance._isPLCConnect)
                {
                    byte[] _plcdataD100 = new byte[90];
                    _plcdataD100 = Project.Instance().PLCManagerInstance.Read("D100", 45);
                    _code1 = Encoding.ASCII.GetString(Remove_zero(ReverseBytes(_plcdataD100, 2, 40))).Replace(":", "-");
                    _code2 = Encoding.ASCII.GetString(Remove_zero(ReverseBytes(_plcdataD100, 42, 40))).Replace(":", "-");
                    _jiajuhao = BitConverter.ToInt16(ReverseBytes(_plcdataD100, 0, 2), 0);
                    _spacing = BitConverter.ToSingle(ReverseBytes(_plcdataD100, 82, 4), 0);
                }

                if (bAccept)
                {
                    #region 读取vpp上的ResultList
                    isOk = true;
                    List<double[]> ListResult1 = new List<double[]>();
                    List<double[]> ListResult2 = new List<double[]>();
                    List<double[]> ListResult3 = new List<double[]>();
                    List<double[]> ListResult4 = new List<double[]>();

                    ListResult1 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList1"].Value;
                    ListResult2 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList2"].Value;
                    ListResult3 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList3"].Value;
                    ListResult4 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList4"].Value;
                    #endregion
                    #region 当前pos
                    for (int i = 0; i < ListResult1.Count; i++)
                    {
                        posXROB1[i] = ListResult1[i][0];
                        posYROB1[i] = ListResult1[i][1];
                        posTROB1[i] = ListResult1[i][2];
                        posXROB2[i] = ListResult2[i][0];
                        posYROB2[i] = ListResult2[i][1];
                        posTROB2[i] = ListResult2[i][2];
                        posXLAS1[i] = ListResult3[i][0];
                        posYLAS1[i] = ListResult3[i][1];
                        posTLAS1[i] = ListResult3[i][2];
                        posXLAS2[i] = ListResult4[i][0];
                        posYLAS2[i] = ListResult4[i][1];
                        posTLAS2[i] = ListResult4[i][2];
                    }
                    Cam1posXRob1 = posXROB1[0];
                    Cam1posYRob1 = posYROB1[0];
                    Cam1posRRob1 = posTROB1[0];
                    Cam1posXRob2 = posXROB2[0];
                    Cam1posYRob2 = posYROB2[0];
                    Cam1posRRob2 = posTROB2[0];
                    Cam1posXLas1 = posXLAS1[0];
                    Cam1posYLas1 = posYLAS1[0];
                    Cam1posRLas1 = posTLAS1[0];
                    Cam1posXLas2 = posXLAS2[0];
                    Cam1posYLas2 = posYLAS2[0];
                    Cam1posRLas2 = posTLAS2[0];


                    dT1[0] = 0;//stdT1[0] - Cam1posRRob1 + addT1[0];
                    double rc_angle1 = dT1[0] * (Math.PI / 180);
                    dT2[0] = 0;// stdT2[0] - Cam1posRRob2 + addT2[0];
                    double rc_angle2 = dT2[0] * (Math.PI / 180);
                    dT3[0] = 0;//stdT3[0] - Cam1posRLas1 + addT3[0];
                    double rc_angle3 = dT3[0] * (Math.PI / 180);
                    dT4[0] = 0;//stdT4[0] - Cam1posRLas2 + addT4[0];
                    double rc_angle4 = dT4[0] * (Math.PI / 180);          //相机角度偏移
                                                                          //当钢片角度落入某区间时给予Y固定补偿
                    if (Cam1posRRob1 > -1.5 && Cam1posRRob1 <= -0.5)
                    {
                        dY1[0] = angleAdd_1[0];
                    }
                    else if (Cam1posRRob1 > -2.5 && Cam1posRRob1 <= -1.5)
                    {
                        dY1[0] = angleAdd_2[0];
                    }
                    else if (Cam1posRRob1 > -3.5 && Cam1posRRob1 <= -2.5)
                    {
                        dY1[0] = angleAdd_3[0];
                    }
                    else if (Cam1posRRob1 >= 0.5 && Cam1posRRob1 < 1.5)
                    {
                        dY1[0] = angleAdd1[0];
                    }
                    else if (Cam1posRRob1 >= 1.5 && Cam1posRRob1 < 2.5)
                    {
                        dY1[0] = angleAdd2[0];
                    }
                    else if (Cam1posRRob1 >= 2.5 && Cam1posRRob1 < 3.5)
                    {
                        dY1[0] = angleAdd3[0];
                    }
                    else
                    {
                        dY1[0] = 0.0;
                        dY2[0] = 0.0;
                    }
                    if (Cam1posRRob2 > -1.5 && Cam1posRRob2 <= -0.5)
                    {
                        dY2[0] = angleAdd_1[0];
                    }
                    else if (Cam1posRRob2 > -2.5 && Cam1posRRob2 <= -1.5)
                    {
                        dY2[0] = angleAdd_2[0];
                    }
                    else if (Cam1posRRob2 > -3.5 && Cam1posRRob2 <= -2.5)
                    {
                        dY2[0] = angleAdd_3[0];
                    }
                    else if (Cam1posRRob2 >= 0.5 && Cam1posRRob2 < 1.5)
                    {
                        dY2[0] = angleAdd1[0];
                    }
                    else if (Cam1posRRob2 >= 1.5 && Cam1posRRob2 < 2.5)
                    {
                        dY2[0] = angleAdd2[0];
                    }
                    else if (Cam1posRRob2 >= 2.5 && Cam1posRRob2 < 3.5)
                    {
                        dY2[0] = angleAdd3[0];
                    }
                    else
                    {
                        dY2[0] = 0.0;
                    }
                    dX1[0] = -(stdX1[0] - Cam1posXRob1) + addX1[0];
                    dX2[0] = -(stdX2[0] - Cam1posXRob2) + addX2[0];
                    dX3[0] = -(stdX3[0] - Cam1posXLas1) + addX3[0];
                    dX4[0] = -(stdX4[0] - Cam1posXLas2) + addX4[0];          //相机X偏移

                    dY1[0] += -(stdY1[0] - Cam1posYRob1) + addY1[0];
                    dY2[0] += -(stdY2[0] - Cam1posYRob2) + addY2[0];
                    dY3[0] = -(stdY3[0] - Cam1posYLas1) + addY3[0];
                    dY4[0] = -(stdY4[0] - Cam1posYLas2) + addY4[0];          //相机y偏移


                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXRob1 = posXROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYRob1 = posYROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRRob1 = posTROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXRob2 = posXROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYRob2 = posYROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRRob2 = posTROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXLas1 = posXLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYLas1 = posYLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRLas1 = posTLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXLas2 = posXLAS2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYLas2 = posYLAS2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRLas2 = posTLAS2[0];

                    #endregion

                    #region 根据夹具号来分别额外补偿，若无夹具号
                    if (_jiajuhao == 1)
                    {
                        AddR1X = AddR1J1X + dX1[0];
                        AddR1Y = AddR1J1Y + dY1[0];
                        AddR2X = AddR2J1X + dX2[0];
                        AddR2Y = AddR2J1Y + dY2[0];
                        AddL1X1 = AddL1J1X1 + dX3[0];
                        AddL1Y1 = AddL1J1Y1 / 2 + AddL1J1Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J1X2 + dX3[0];
                        AddL1Y2 = AddL1J1Y2 / 2 + AddL1J1Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J1X3 + dX3[0];
                        AddL1Y3 = AddL1J1Y3 + dY3[0];
                        AddL1X4 = AddL1J1X4 + dX3[0];
                        AddL1Y4 = AddL1J1Y4 + dY3[0];
                        AddL2X1 = AddL2J1X1 + dX4[0];
                        AddL2Y1 = AddL2J1Y1 + dY4[0];
                        AddL2X2 = AddL2J1X2 + dX4[0];
                        AddL2Y2 = AddL2J1Y2 + dY4[0];
                        AddL2X3 = AddL2J1X3 + dX4[0];
                        AddL2Y3 = AddL2J1Y3 + dY4[0];
                        AddL2X4 = AddL2J1X4 + dX4[0];
                        AddL2Y4 = AddL2J1Y4 + dY4[0];
                        LengthC = AddL1J1X2 - AddL1J1X1;
                    }
                    else if (_jiajuhao == 2)
                    {
                        AddR1X = AddR1J2X + dX1[0];
                        AddR1Y = AddR1J2Y + dY1[0];
                        AddR2X = AddR2J2X + dX2[0];
                        AddR2Y = AddR2J2Y + dY2[0];
                        AddL1X1 = AddL1J2X1 + dX3[0];
                        AddL1Y1 = AddL1J2Y1 / 2 + AddL1J2Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J2X2 + dX3[0];
                        AddL1Y2 = AddL1J2Y2 / 2 + AddL1J2Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J2X3 + dX3[0];
                        AddL1Y3 = AddL1J2Y3 + dY3[0];
                        AddL1X4 = AddL1J2X4 + dX3[0];
                        AddL1Y4 = AddL1J2Y4 + dY3[0];
                        AddL2X1 = AddL2J2X1 + dX4[0];
                        AddL2Y1 = AddL2J2Y1 + dY4[0];
                        AddL2X2 = AddL2J2X2 + dX4[0];
                        AddL2Y2 = AddL2J2Y2 + dY4[0];
                        AddL2X3 = AddL2J2X3 + dX4[0];
                        AddL2Y3 = AddL2J2Y3 + dY4[0];
                        AddL2X4 = AddL2J2X4 + dX4[0];
                        AddL2Y4 = AddL2J2Y4 + dY4[0];
                        LengthC = AddL1J2X2 - AddL1J2X1;

                    }
                    else if (_jiajuhao == 3)
                    {
                        AddR1X = AddR1J3X + dX1[0];
                        AddR1Y = AddR1J3Y + dY1[0];
                        AddR2X = AddR2J3X + dX2[0];
                        AddR2Y = AddR2J3Y + dY2[0];
                        AddL1X1 = AddL1J3X1 + dX3[0];
                        AddL1Y1 = AddL1J3Y1 / 2 + AddL1J3Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J3X2 + dX3[0];
                        AddL1Y2 = AddL1J3Y2 / 2 + AddL1J3Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J3X3 + dX3[0];
                        AddL1Y3 = AddL1J3Y3 + dY3[0];
                        AddL1X4 = AddL1J3X4 + dX3[0];
                        AddL1Y4 = AddL1J3Y4 + dY3[0];
                        AddL2X1 = AddL2J3X1 + dX4[0];
                        AddL2Y1 = AddL2J3Y1 + dY4[0];
                        AddL2X2 = AddL2J3X2 + dX4[0];
                        AddL2Y2 = AddL2J3Y2 + dY4[0];
                        AddL2X3 = AddL2J3X3 + dX4[0];
                        AddL2Y3 = AddL2J3Y3 + dY4[0];
                        AddL2X4 = AddL2J3X4 + dX4[0];
                        AddL2Y4 = AddL2J3Y4 + dY4[0];
                        LengthC = AddL1J3X2 - AddL1J3X1;

                    }
                    else if (_jiajuhao == 4)
                    {
                        AddR1X = AddR1J4X + dX1[0];
                        AddR1Y = AddR1J4Y + dY1[0];
                        AddR2X = AddR2J4X + dX2[0];
                        AddR2Y = AddR2J4Y + dY2[0];
                        AddL1X1 = AddL1J4X1 + dX3[0];
                        AddL1Y1 = AddL1J4Y1 / 2 + AddL1J4Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J4X2 + dX3[0];
                        AddL1Y2 = AddL1J4Y2 / 2 + AddL1J4Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J4X3 + dX3[0];
                        AddL1Y3 = AddL1J4Y3 + dY3[0];
                        AddL1X4 = AddL1J4X4 + dX3[0];
                        AddL1Y4 = AddL1J4Y4 + dY3[0];
                        AddL2X1 = AddL2J4X1 + dX4[0];
                        AddL2Y1 = AddL2J4Y1 + dY4[0];
                        AddL2X2 = AddL2J4X2 + dX4[0];
                        AddL2Y2 = AddL2J4Y2 + dY4[0];
                        AddL2X3 = AddL2J4X3 + dX4[0];
                        AddL2Y3 = AddL2J4Y3 + dY4[0];
                        AddL2X4 = AddL2J4X4 + dX4[0];
                        AddL2Y4 = AddL2J4Y4 + dY4[0];
                        LengthC = AddL1J4X2 - AddL1J4X1;

                    }
                    else if (_jiajuhao == 5)
                    {
                        AddR1X = AddR1J5X + dX1[0];
                        AddR1Y = AddR1J5Y + dY1[0];
                        AddR2X = AddR2J5X + dX2[0];
                        AddR2Y = AddR2J5Y + dY2[0];
                        AddL1X1 = AddL1J5X1 + dX3[0];
                        AddL1Y1 = AddL1J5Y1 / 2 + AddL1J5Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J5X2 + dX3[0];
                        AddL1Y2 = AddL1J5Y2 / 2 + AddL1J5Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J5X3 + dX3[0];
                        AddL1Y3 = AddL1J5Y3 + dY3[0];
                        AddL1X4 = AddL1J5X4 + dX3[0];
                        AddL1Y4 = AddL1J5Y4 + dY3[0];
                        AddL2X1 = AddL2J5X1 + dX4[0];
                        AddL2Y1 = AddL2J5Y1 + dY4[0];
                        AddL2X2 = AddL2J5X2 + dX4[0];
                        AddL2Y2 = AddL2J5Y2 + dY4[0];
                        AddL2X3 = AddL2J5X3 + dX4[0];
                        AddL2Y3 = AddL2J5Y3 + dY4[0];
                        AddL2X4 = AddL2J5X4 + dX4[0];
                        AddL2Y4 = AddL2J5Y4 + dY4[0];
                        LengthC = AddL1J5X2 - AddL1J5X1;

                    }
                    else if (_jiajuhao == 6)
                    {
                        AddR1X = AddR1J6X + dX1[0];
                        AddR1Y = AddR1J6Y + dY1[0];
                        AddR2X = AddR2J6X + dX2[0];
                        AddR2Y = AddR2J6Y + dY2[0];
                        AddL1X1 = AddL1J6X1 + dX3[0];
                        AddL1Y1 = AddL1J6Y1 / 2 + AddL1J6Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J6X2 + dX3[0];
                        AddL1Y2 = AddL1J6Y2 / 2 + AddL1J6Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J6X3 + dX3[0];
                        AddL1Y3 = AddL1J6Y3 + dY3[0];
                        AddL1X4 = AddL1J6X4 + dX3[0];
                        AddL1Y4 = AddL1J6Y4 + dY3[0];
                        AddL2X1 = AddL2J6X1 + dX4[0];
                        AddL2Y1 = AddL2J6Y1 + dY4[0];
                        AddL2X2 = AddL2J6X2 + dX4[0];
                        AddL2Y2 = AddL2J6Y2 + dY4[0];
                        AddL2X3 = AddL2J6X3 + dX4[0];
                        AddL2Y3 = AddL2J6Y3 + dY4[0];
                        AddL2X4 = AddL2J6X4 + dX4[0];
                        AddL2Y4 = AddL2J6Y4 + dY4[0];
                        LengthC = AddL1J6X2 - AddL1J6X1;

                    }
                    else if (_jiajuhao == 7)
                    {
                        AddR1X = AddR1J7X + dX1[0];
                        AddR1Y = AddR1J7Y + dY1[0];
                        AddR2X = AddR2J7X + dX2[0];
                        AddR2Y = AddR2J7Y + dY2[0];
                        AddL1X1 = AddL1J7X1 + dX3[0];
                        AddL1Y1 = AddL1J7Y1 / 2 + AddL1J7Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J7X2 + dX3[0];
                        AddL1Y2 = AddL1J7Y2 / 2 + AddL1J7Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J7X3 + dX3[0];
                        AddL1Y3 = AddL1J7Y3 + dY3[0];
                        AddL1X4 = AddL1J7X4 + dX3[0];
                        AddL1Y4 = AddL1J7Y4 + dY3[0];
                        AddL2X1 = AddL2J7X1 + dX4[0];
                        AddL2Y1 = AddL2J7Y1 + dY4[0];
                        AddL2X2 = AddL2J7X2 + dX4[0];
                        AddL2Y2 = AddL2J7Y2 + dY4[0];
                        AddL2X3 = AddL2J7X3 + dX4[0];
                        AddL2Y3 = AddL2J7Y3 + dY4[0];
                        AddL2X4 = AddL2J7X4 + dX4[0];
                        AddL2Y4 = AddL2J7Y4 + dY4[0];
                        LengthC = AddL1J7X2 - AddL1J7X1;

                    }
                    else if (_jiajuhao == 8)
                    {
                        AddR1X = AddR1J8X + dX1[0];
                        AddR1Y = AddR1J8Y + dY1[0];
                        AddR2X = AddR2J8X + dX2[0];
                        AddR2Y = AddR2J8Y + dY2[0];
                        AddL1X1 = AddL1J8X1 + dX3[0];
                        AddL1Y1 = AddL1J8Y1 / 2 + AddL1J8Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J8X2 + dX3[0];
                        AddL1Y2 = AddL1J8Y2 / 2 + AddL1J8Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J8X3 + dX3[0];
                        AddL1Y3 = AddL1J8Y3 + dY3[0];
                        AddL1X4 = AddL1J8X4 + dX3[0];
                        AddL1Y4 = AddL1J8Y4 + dY3[0];
                        AddL2X1 = AddL2J8X1 + dX4[0];
                        AddL2Y1 = AddL2J8Y1 + dY4[0];
                        AddL2X2 = AddL2J8X2 + dX4[0];
                        AddL2Y2 = AddL2J8Y2 + dY4[0];
                        AddL2X3 = AddL2J8X3 + dX4[0];
                        AddL2Y3 = AddL2J8Y3 + dY4[0];
                        AddL2X4 = AddL2J8X4 + dX4[0];
                        AddL2Y4 = AddL2J8Y4 + dY4[0];
                        LengthC = AddL1J8X2 - AddL1J8X1;

                    }
                    else if (_jiajuhao == 9)
                    {
                        AddR1X = AddR1J9X + dX1[0];
                        AddR1Y = AddR1J9Y + dY1[0];
                        AddR2X = AddR2J9X + dX2[0];
                        AddR2Y = AddR2J9Y + dY2[0];
                        AddL1X1 = AddL1J9X1 + dX3[0];
                        AddL1Y1 = AddL1J9Y1 / 2 + AddL1J9Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J9X2 + dX3[0];
                        AddL1Y2 = AddL1J9Y2 / 2 + AddL1J9Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J9X3 + dX3[0];
                        AddL1Y3 = AddL1J9Y3 + dY3[0];
                        AddL1X4 = AddL1J9X4 + dX3[0];
                        AddL1Y4 = AddL1J9Y4 + dY3[0];
                        AddL2X1 = AddL2J9X1 + dX4[0];
                        AddL2Y1 = AddL2J9Y1 + dY4[0];
                        AddL2X2 = AddL2J9X2 + dX4[0];
                        AddL2Y2 = AddL2J9Y2 + dY4[0];
                        AddL2X3 = AddL2J9X3 + dX4[0];
                        AddL2Y3 = AddL2J9Y3 + dY4[0];
                        AddL2X4 = AddL2J9X4 + dX4[0];
                        AddL2Y4 = AddL2J9Y4 + dY4[0];
                        LengthC = AddL1J9X2 - AddL1J9X1;

                    }
                    else
                    {
                        AddR1X = dX1[0];
                        AddR1Y = dY1[0];
                        AddR2X = dX2[0];
                        AddR2Y = dY2[0];
                        AddL1X1 = dX3[0];
                        AddL1Y1 = dY3[0];
                        AddL1X2 = dX3[0];
                        AddL1Y2 = dY3[0];
                        AddL1X3 = dX3[0];
                        AddL1Y3 = dY3[0];
                        AddL1X4 = dX3[0];
                        AddL1Y4 = dY3[0];
                        AddL2X1 = dX4[0];
                        AddL2Y1 = dY4[0];
                        AddL2X2 = dX4[0];
                        AddL2Y2 = dY4[0];
                        AddL2X3 = dX4[0];
                        AddL2Y3 = dY4[0];
                        AddL2X4 = dX4[0];
                        AddL2Y4 = dY4[0];
                    }

                    #endregion
                   
                    if (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[_workFlowIndex] == 1.0)
                    {
                        double SpecingX = Math.Round((Convert.ToDouble(_spacing.ToString("f3")) - Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[_workFlowIndex]), 3);

                        AddL1X3 = dX3[0] + SpecingX;
                        AddL1X4 = dX3[0] + SpecingX;
                        AddL2X3 = dX4[0] + SpecingX;
                        AddL2X4 = dX4[0] + SpecingX;
                    }


                    Project.Instance().ProductionDataManagerInstance.L_productionCCDOKCountList[0][_workFlowIndex]++;
                    FinalResult = "OK";

                }
                else
                {
                    isOk = false;
                    Project.Instance().ProductionDataManagerInstance.L_productionCCDNGCountList[0][_workFlowIndex]++;
                    FinalResult = "NG";
                }
                _camResult[_workFlowIndex] = isOk ? 1 : 2;

                
                    double limitMIN = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[_workFlowIndex];
                    double limitMAX = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[_workFlowIndex];
                    bool OutLimit = false;
                    if (dX1[0] < limitMIN || dX1[0] > limitMAX || dX3[0] < limitMIN || dX3[0] > limitMAX || dY1[0] < limitMIN || dY1[0] > limitMAX || dY3[0] < limitMIN || dY3[0] > limitMAX)
                    {
                        isOk = false;
                        OutLimit = true;
                        FinalResult = "NG";
                    }
                  
                 
                    ///显示界面:
                    CogColorConstants Color = isOk ? CogColorConstants.Green : CogColorConstants.Red;
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], Color, 0, 0, string.Format("{0}", FinalResult), FontSize);
                    //WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 2, "取像时间：" + mSeconds1.ToString() + "ms", FontSize);
                    //WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 4, "处理时间：" + mSeconds2.ToString() + "ms", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 6, "机械手1偏移X：" + dX1[0].ToString("f3") + "Y：" + dY1[0].ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 8, "焊点1偏移 X：" + (AddL1X1).ToString("f3") + "Y：" + (AddL1Y1).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 10, "焊点2偏移 X：" + (AddL1X2).ToString("f3") + "Y：" + (AddL1Y2).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 12, "焊点3偏移 X：" + (AddL1X3).ToString("f3") + "Y：" + (AddL1Y3).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 14, "焊点4偏移 X：" + (AddL1X4).ToString("f3") + "Y：" + (AddL1Y4).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 16, "焊点偏移X：" + dX3[0].ToString("f3") + "Y：" + dY3[0].ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 18, "弹夹角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 20, "胶片角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 22, "极耳间距：" + _spacing.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 24, "工位号：" + "1(面朝屏幕右手端)", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 26, "夹具号：" + _jiajuhao, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 28, "电池条码：" + _code1, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 30, DateTime.Now.ToString("HH:mm:ss"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 36, sError, FontSize);//YBR
                if (OutLimit == true)
                    {
                        WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 32, "偏移值超限NG", FontSize);

                    }
                TriggerEventArgs triggerEventArgs = new TriggerEventArgs();
                //VP或者Halcon存图
                triggerEventArgs.resultImage = GlobalCameraParams.cameraVisionControlList[_workFlowIndex];
                triggerEventArgs.rawImage = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                triggerEventArgs.imageName = (_workFlowIndex + 1).ToString();
                triggerEventArgs.results = isOk;
                triggerEventArgs.Index = _workFlowIndex;
                Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageSave.mSaveImageQueue[_workFlowIndex].Enqueue(triggerEventArgs);

            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
        }

        private void 工具设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_curWorkFlow.SettingBlock != null)
            {
                FrmVppSetting VisionToolSettingForm = new FrmVppSetting(_curWorkFlow, _vppName);
                VisionToolSettingForm.AfterSaveTool += AfterSaveTool;
                VisionToolSettingForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("SettingBlock！", "异常信息");
            }
        }


        /// <summary>
        /// 打开图像
        /// </summary>
        public int index = 0;
        private void 打开图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVPChooseImage f = new FrmVPChooseImage(this);
            f.OnChooseSure += ChooseSure;
            f.Show();
        }

        /// <summary>
        /// 选择完图片的成功回调
        /// </summary>
        private void ChooseSure()
        {
            try
            {
                if (ImageLoadStyle == LoadStyle.Image)
                {
                    CogImageFileTool cif = new CogImageFileTool();
                    cif.Operator.Open(ImageName, CogImageFileModeConstants.Read);
                    cif.Run();
                    this.cogRecordDisplay1.Subject = null;
                    this.cogRecordDisplay1.Display.Image = cif.OutputImage;
                    this.cogRecordDisplay1.Display.Fit(true);
                    cogRecordDisplay1.Display.BackColor = Color.Black;
                    cogRecordDisplay1.Display.GridColor = Color.Black;
                    _image2BRun = this.cogRecordDisplay1.Display.Image;
               
                }
                else if (ImageLoadStyle == LoadStyle.Folder)
                {
                    index = 0;

                    if (ImageInfoNames.Length > 0)
                    {
                        CogImageFileTool cif = new CogImageFileTool();
                        cif.Operator.Open(ImageInfoNames[index], CogImageFileModeConstants.Read);

                        cif.Run();
                        this.cogRecordDisplay1.Subject = null;
                        this.cogRecordDisplay1.Display.Image = cif.OutputImage;
                        cogRecordDisplay1.Display.BackColor = Color.Black;
                        cogRecordDisplay1.Display.GridColor = Color.Black;
                        _image2BRun = cif.OutputImage;
                        this.cogRecordDisplay1.Display.Fit(true);

                        this.ImageName = ImageInfoNames[0];
                        if (index == 0)
                        {
                         
                        }
                    }
                }
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].AcquireBlock.Outputs["bAccept"].Value = true;
            }
            catch  
            {
                MessageBox.Show("读取图像异常");
            }
        }

        /// <summary>
        /// 读上一张图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 上一张ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cogRecordDisplay1.Display.StaticGraphics.Clear();
            this.cogRecordDisplay1.Subject = null;
            try
            {
                index--;
                if (index >= 0)
                {
                    CogImageFileTool cif = new CogImageFileTool();
                    cif.Operator.Open(ImageInfoNames[index], CogImageFileModeConstants.Read);
                    cif.Run();
                    this.cogRecordDisplay1.Subject = null;
                    this.cogRecordDisplay1.Display.Image = cif.OutputImage;
                    this.cogRecordDisplay1.Display.Fit(true);
                    cogRecordDisplay1.Display.BackColor = Color.Black;
                    cogRecordDisplay1.Display.GridColor = Color.Black;
                    _image2BRun = cif.OutputImage;
                    if (index < ImageInfoNames.Length)
                    {
                    }
                    if (index == 0)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("读取图像出现异常", ex);
                MessageBox.Show("读取图像异常");
            }
        }

        /// <summary>
        /// 读下一张图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 下一张ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.cogRecordDisplay1.Display.StaticGraphics.Clear();
            this.cogRecordDisplay1.Subject = null;
            try
            {
                index++;
                if (index < ImageInfoNames.Length)
                {
                    CogImageFileTool cif = new CogImageFileTool();
                    cif.Operator.Open(ImageInfoNames[index], CogImageFileModeConstants.Read);
                    cif.Run();
                    this.cogRecordDisplay1.Subject = null;
                    this.cogRecordDisplay1.Display.Image = cif.OutputImage;
                    this.cogRecordDisplay1.Display.Fit(true);
                    cogRecordDisplay1.Display.BackColor = Color.Black;
                    cogRecordDisplay1.Display.GridColor = Color.Black;
                    _image2BRun = cif.OutputImage;

                    if (index < ImageInfoNames.Length)
                    {
                    }

                    if (index == ImageInfoNames.Length - 1)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("读取图像出现异常", ex);
                MessageBox.Show("读取图像异常");
            }
        }

        private void 图片保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImageStoreSettings FrmImageStoreSettings = new FrmImageStoreSettings(_vppName);

            FrmImageStoreSettings.ShowDialog();
        }

        private void 查看图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string path = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[_workFlowIndex].ResultImagePosition + @"\" + DateTime.Now.ToString("yyyy-MM-dd") + @"\" + "CCD";
            if (Directory.Exists(path))
            {
                Process.Start(path);
            }
            else
            {
                MessageBox.Show("目标文件夹不存在");
            }
        }

        private void 处理2工位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_image2BRun == null)
                {
                    MessageBox.Show("未提供图片！");
                    return;
                }

                #region 参数初始化
                //当前吸嘴个数
                int NozzleNum = 1;//1个
                //基准 1             
                double[] stdX1 = new double[NozzleNum];
                double[] stdY1 = new double[NozzleNum];
                double[] stdT1 = new double[NozzleNum];
                //补偿   1           
                double[] addX1 = new double[NozzleNum];
                double[] addY1 = new double[NozzleNum];
                double[] addT1 = new double[NozzleNum];
                //临时位置1
                double[] stdX_temp1 = new double[NozzleNum];
                double[] stdY_temp1 = new double[NozzleNum];
                //基准 2             
                double[] stdX2 = new double[NozzleNum];
                double[] stdY2 = new double[NozzleNum];
                double[] stdT2 = new double[NozzleNum];
                //补偿   2           
                double[] addX2 = new double[NozzleNum];
                double[] addY2 = new double[NozzleNum];
                double[] addT2 = new double[NozzleNum];
                //临时位置2
                double[] stdX_temp2 = new double[NozzleNum];
                double[] stdY_temp2 = new double[NozzleNum];
                //基准 3             
                double[] stdX3 = new double[NozzleNum];
                double[] stdY3 = new double[NozzleNum];
                double[] stdT3 = new double[NozzleNum];
                //补偿  3           
                double[] addX3 = new double[NozzleNum];
                double[] addY3 = new double[NozzleNum];
                double[] addT3 = new double[NozzleNum];
                //临时位置3
                double[] stdX_temp3 = new double[NozzleNum];
                double[] stdY_temp3 = new double[NozzleNum];
                //基准 4             
                double[] stdX4 = new double[NozzleNum];
                double[] stdY4 = new double[NozzleNum];
                double[] stdT4 = new double[NozzleNum];
                //补偿  4           
                double[] addX4 = new double[NozzleNum];
                double[] addY4 = new double[NozzleNum];
                double[] addT4 = new double[NozzleNum];
                //临时位置4
                double[] stdX_temp4 = new double[NozzleNum];
                double[] stdY_temp4 = new double[NozzleNum];
                //当前
                double[] posX = new double[NozzleNum];
                double[] posY = new double[NozzleNum];
                double[] posT = new double[NozzleNum];
                double[] posXROB1 = new double[NozzleNum];
                double[] posYROB1 = new double[NozzleNum];
                double[] posTROB1 = new double[NozzleNum];
                double[] posXROB2 = new double[NozzleNum];
                double[] posYROB2 = new double[NozzleNum];
                double[] posTROB2 = new double[NozzleNum];
                double[] posXLAS1 = new double[NozzleNum];
                double[] posYLAS1 = new double[NozzleNum];
                double[] posTLAS1 = new double[NozzleNum];
                double[] posXLAS2 = new double[NozzleNum];
                double[] posYLAS2 = new double[NozzleNum];
                double[] posTLAS2 = new double[NozzleNum];
                //偏差 1
                double[] dX1 = new double[NozzleNum];
                double[] dY1 = new double[NozzleNum];
                double[] dT1 = new double[NozzleNum];
                //偏差 2
                double[] dX2 = new double[NozzleNum];
                double[] dY2 = new double[NozzleNum];
                double[] dT2 = new double[NozzleNum];
                //偏差 3
                double[] dX3 = new double[NozzleNum];
                double[] dY3 = new double[NozzleNum];
                double[] dT3 = new double[NozzleNum];
                //偏差 4
                double[] dX4 = new double[NozzleNum];
                double[] dY4 = new double[NozzleNum];
                double[] dT4 = new double[NozzleNum];
                //旋转中心
                double[] Rotation_X = new double[NozzleNum];
                double[] Rotation_Y = new double[NozzleNum];
                //钢片角度按范围补偿
                double[] angleAdd_1 = new double[NozzleNum];
                double[] angleAdd_2 = new double[NozzleNum];
                double[] angleAdd_3 = new double[NozzleNum];
                double[] angleAdd1 = new double[NozzleNum];
                double[] angleAdd2 = new double[NozzleNum];
                double[] angleAdd3 = new double[NozzleNum];
                #endregion

                #region 
                for (int i = 0; i < NozzleNum; i++)
                {
                    //基准1
                    stdX1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[i];
                    stdY1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[i];
                    stdT1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[i];
                    //补偿1
                    addX1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[i];
                    addY1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[i];
                    addT1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[i];
                    //基准2
                    stdX2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[i];
                    stdY2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[i];
                    stdT2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[i];
                    //补偿2
                    addX2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[i];
                    addY2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[i];
                    addT2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[i];
                    //基准3
                    stdX3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[i];
                    stdY3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[i];
                    stdT3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[i];
                    //补偿3
                    addX3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[i];
                    addY3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[i];
                    addT3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[i];
                    //基准4
                    stdX4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[i];
                    stdY4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[i];
                    stdT4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[i];
                    //补偿4
                    addX4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[i];
                    addY4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[i];
                    addT4[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[i];
                    //钢片角度补偿
                    angleAdd_1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_1[i];
                    angleAdd_2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_2[i];
                    angleAdd_3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd_3[i];
                    angleAdd1[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd1[i];
                    angleAdd2[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd2[i];
                    angleAdd3[i] = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AngleAdd3[i];

                }




                #endregion

                #region 额外补偿
                double AddR1J1X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[0];
                double AddR1J1Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[0];
                double AddR2J1X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[0];
                double AddR2J1Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[0];
                double AddL1J1X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[0];
                double AddL1J1Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[0];
                double AddL1J1X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[0];
                double AddL1J1Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[0];
                double AddL1J1X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[0];
                double AddL1J1Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[0];
                double AddL1J1X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[0];
                double AddL1J1Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[0];
                double AddL2J1X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[0];
                double AddL2J1Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[0];
                double AddL2J1X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[0];
                double AddL2J1Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[0];
                double AddL2J1X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[0];
                double AddL2J1Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[0];
                double AddL2J1X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[0];
                double AddL2J1Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[0];

                double AddR1J2X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[0];
                double AddR1J2Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[0];
                double AddR2J2X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[0];
                double AddR2J2Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[0];
                double AddL1J2X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[0];
                double AddL1J2Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[0];
                double AddL1J2X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[0];
                double AddL1J2Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[0];
                double AddL1J2X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[0];
                double AddL1J2Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[0];
                double AddL1J2X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[0];
                double AddL1J2Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[0];
                double AddL2J2X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[0];
                double AddL2J2Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[0];
                double AddL2J2X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[0];
                double AddL2J2Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[0];
                double AddL2J2X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[0];
                double AddL2J2Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[0];
                double AddL2J2X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[0];
                double AddL2J2Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[0];

                double AddR1J3X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[0];
                double AddR1J3Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[0];
                double AddR2J3X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[0];
                double AddR2J3Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[0];
                double AddL1J3X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[0];
                double AddL1J3Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[0];
                double AddL1J3X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[0];
                double AddL1J3Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[0];
                double AddL1J3X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[0];
                double AddL1J3Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[0];
                double AddL1J3X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[0];
                double AddL1J3Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[0];
                double AddL2J3X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[0];
                double AddL2J3Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[0];
                double AddL2J3X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[0];
                double AddL2J3Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[0];
                double AddL2J3X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[0];
                double AddL2J3Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[0];
                double AddL2J3X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[0];
                double AddL2J3Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[0];

                double AddR1J4X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[0];
                double AddR1J4Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[0];
                double AddR2J4X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[0];
                double AddR2J4Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[0];
                double AddL1J4X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[0];
                double AddL1J4Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[0];
                double AddL1J4X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[0];
                double AddL1J4Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[0];
                double AddL1J4X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[0];
                double AddL1J4Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[0];
                double AddL1J4X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[0];
                double AddL1J4Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[0];
                double AddL2J4X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[0];
                double AddL2J4Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[0];
                double AddL2J4X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[0];
                double AddL2J4Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[0];
                double AddL2J4X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[0];
                double AddL2J4Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[0];
                double AddL2J4X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[0];
                double AddL2J4Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[0];

                double AddR1J5X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[0];
                double AddR1J5Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[0];
                double AddR2J5X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[0];
                double AddR2J5Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[0];
                double AddL1J5X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[0];
                double AddL1J5Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[0];
                double AddL1J5X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[0];
                double AddL1J5Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[0];
                double AddL1J5X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[0];
                double AddL1J5Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[0];
                double AddL1J5X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[0];
                double AddL1J5Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[0];
                double AddL2J5X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[0];
                double AddL2J5Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[0];
                double AddL2J5X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[0];
                double AddL2J5Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[0];
                double AddL2J5X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[0];
                double AddL2J5Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[0];
                double AddL2J5X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[0];
                double AddL2J5Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[0];

                double AddR1J6X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[0];
                double AddR1J6Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[0];
                double AddR2J6X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[0];
                double AddR2J6Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[0];
                double AddL1J6X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[0];
                double AddL1J6Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[0];
                double AddL1J6X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[0];
                double AddL1J6Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[0];
                double AddL1J6X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[0];
                double AddL1J6Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[0];
                double AddL1J6X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[0];
                double AddL1J6Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[0];
                double AddL2J6X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[0];
                double AddL2J6Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[0];
                double AddL2J6X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[0];
                double AddL2J6Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[0];
                double AddL2J6X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[0];
                double AddL2J6Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[0];
                double AddL2J6X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[0];
                double AddL2J6Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[0];

                double AddR1J7X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[0];
                double AddR1J7Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[0];
                double AddR2J7X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[0];
                double AddR2J7Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[0];
                double AddL1J7X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[0];
                double AddL1J7Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[0];
                double AddL1J7X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[0];
                double AddL1J7Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[0];
                double AddL1J7X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[0];
                double AddL1J7Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[0];
                double AddL1J7X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[0];
                double AddL1J7Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[0];
                double AddL2J7X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[0];
                double AddL2J7Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[0];
                double AddL2J7X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[0];
                double AddL2J7Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[0];
                double AddL2J7X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[0];
                double AddL2J7Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[0];
                double AddL2J7X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[0];
                double AddL2J7Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[0];

                double AddR1J8X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[0];
                double AddR1J8Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[0];
                double AddR2J8X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[0];
                double AddR2J8Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[0];
                double AddL1J8X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[0];
                double AddL1J8Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[0];
                double AddL1J8X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[0];
                double AddL1J8Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[0];
                double AddL1J8X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[0];
                double AddL1J8Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[0];
                double AddL1J8X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[0];
                double AddL1J8Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[0];
                double AddL2J8X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[0];
                double AddL2J8Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[0];
                double AddL2J8X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[0];
                double AddL2J8Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[0];
                double AddL2J8X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[0];
                double AddL2J8Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[0];
                double AddL2J8X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[0];
                double AddL2J8Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[0];

                double AddR1J9X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[0];
                double AddR1J9Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[0];
                double AddR2J9X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[0];
                double AddR2J9Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[0];
                double AddL1J9X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[0];
                double AddL1J9Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[0];
                double AddL1J9X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[0];
                double AddL1J9Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[0];
                double AddL1J9X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[0];
                double AddL1J9Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[0];
                double AddL1J9X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[0];
                double AddL1J9Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[0];
                double AddL2J9X1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[0];
                double AddL2J9Y1 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[0];
                double AddL2J9X2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[0];
                double AddL2J9Y2 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[0];
                double AddL2J9X3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[0];
                double AddL2J9Y3 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[0];
                double AddL2J9X4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[0];
                double AddL2J9Y4 = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[0];


                double AddR1X = 0;
                double AddR1Y = 0;
                double AddR2X = 0;
                double AddR2Y = 0;
                double AddL1X1 = 0;
                double AddL1Y1 = 0;
                double AddL1X2 = 0;
                double AddL1Y2 = 0;
                double AddL1X3 = 0;
                double AddL1Y3 = 0;
                double AddL1X4 = 0;
                double AddL1Y4 = 0;
                double AddL2X1 = 0;
                double AddL2Y1 = 0;
                double AddL2X2 = 0;
                double AddL2Y2 = 0;
                double AddL2X3 = 0;
                double AddL2Y3 = 0;
                double AddL2X4 = 0;
                double AddL2Y4 = 0;

                double LengthC = 0;




                #endregion
                //运行取相＋处理时间
                string FinalResult = "";
                Int32 offSetX = Convert.ToInt32((Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[_workFlowIndex]) / 0.005116);
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMin"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMax"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMin"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMax"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductGrayValue"].Value = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[_workFlowIndex];
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["OffsetX"].Value = offSetX;
                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunProcessBlock(ref _image2BRun);
                if (!Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].UpdateGraphicResult(GlobalCameraParams.cameraVisionControlList[_workFlowIndex]))
                {
                    //相机掉线
                    LogHelper.Error($"{_workFlowIndex + 1}相机掉线");  //写日志
                    //WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[e.Index], CogColorConstants.Red, 0, 0, "相机掉线", 60);
                    //_camResult[_workFlowIndex] = 0;

                    if ((Project.Instance().RobotManagerInstance.WaitStringN(RobotSignals.RobotNGetResult1, 30)))
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    else
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    Project.Instance().ProductionDataManagerInstance.L_ProductionStationNGCount[0]++;
                    //   _camComplete[e.Index] = false;
                    return;
                }



                Project.Instance().ProductionDataManagerInstance.L_productionCCDSumCountList[0][_workFlowIndex]++;
                bool isOk = false;
                Int16 FontSize = 15;
                bool bAccept = (bool)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["bAccept"].Value;
                string sError = (string)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["sError"].Value;
                double Pangle = (double)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["Angle"].Value;
                string _code1 = "";
                string _code2 = "";
                int _jiajuhao = 0;
                double _spacing = 0.0;
                if (Project.Instance().PLCManagerInstance._isPLCConnect)
                {
                    byte[] _plcdataD100 = new byte[90];
                    _plcdataD100 = Project.Instance().PLCManagerInstance.Read("D100", 45);
                    _code1 = Encoding.ASCII.GetString(Remove_zero(ReverseBytes(_plcdataD100, 2, 40))).Replace(":", "-");
                    _code2 = Encoding.ASCII.GetString(Remove_zero(ReverseBytes(_plcdataD100, 42, 40))).Replace(":", "-");
                    _jiajuhao = BitConverter.ToInt16(ReverseBytes(_plcdataD100, 0, 2), 0);
                    _spacing = BitConverter.ToSingle(ReverseBytes(_plcdataD100, 86, 4), 0);
                }

                if (bAccept)
                {
                    #region 读取vpp上的ResultList
                    isOk = true;
                    List<double[]> ListResult1 = new List<double[]>();
                    List<double[]> ListResult2 = new List<double[]>();
                    List<double[]> ListResult3 = new List<double[]>();
                    List<double[]> ListResult4 = new List<double[]>();

                    ListResult1 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList1"].Value;
                    ListResult2 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList2"].Value;
                    ListResult3 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList3"].Value;
                    ListResult4 = (List<double[]>)Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList4"].Value;
                    #endregion
                    #region 当前pos
                    for (int i = 0; i < ListResult1.Count; i++)
                    {
                        posXROB1[i] = ListResult1[i][0];
                        posYROB1[i] = ListResult1[i][1];
                        posTROB1[i] = ListResult1[i][2];
                        posXROB2[i] = ListResult2[i][0];
                        posYROB2[i] = ListResult2[i][1];
                        posTROB2[i] = ListResult2[i][2];
                        posXLAS1[i] = ListResult3[i][0];
                        posYLAS1[i] = ListResult3[i][1];
                        posTLAS1[i] = ListResult3[i][2];
                        posXLAS2[i] = ListResult4[i][0];
                        posYLAS2[i] = ListResult4[i][1];
                        posTLAS2[i] = ListResult4[i][2];
                    }
                    Cam1posXRob1 = posXROB1[0];
                    Cam1posYRob1 = posYROB1[0];
                    Cam1posRRob1 = posTROB1[0];
                    Cam1posXRob2 = posXROB2[0];
                    Cam1posYRob2 = posYROB2[0];
                    Cam1posRRob2 = posTROB2[0];
                    Cam1posXLas1 = posXLAS1[0];
                    Cam1posYLas1 = posYLAS1[0];
                    Cam1posRLas1 = posTLAS1[0];
                    Cam1posXLas2 = posXLAS2[0];
                    Cam1posYLas2 = posYLAS2[0];
                    Cam1posRLas2 = posTLAS2[0];


                    dT1[0] = 0;//stdT1[0] - Cam1posRRob1 + addT1[0];
                    double rc_angle1 = dT1[0] * (Math.PI / 180);
                    dT2[0] = 0;// stdT2[0] - Cam1posRRob2 + addT2[0];
                    double rc_angle2 = dT2[0] * (Math.PI / 180);
                    dT3[0] = 0;//stdT3[0] - Cam1posRLas1 + addT3[0];
                    double rc_angle3 = dT3[0] * (Math.PI / 180);
                    dT4[0] = 0;//stdT4[0] - Cam1posRLas2 + addT4[0];
                    double rc_angle4 = dT4[0] * (Math.PI / 180);          //相机角度偏移
                                                                          //当钢片角度落入某区间时给予Y固定补偿
                    if (Cam1posRRob1 > -1.5 && Cam1posRRob1 <= -0.5)
                    {
                        dY1[0] = angleAdd_1[0];
                    }
                    else if (Cam1posRRob1 > -2.5 && Cam1posRRob1 <= -1.5)
                    {
                        dY1[0] = angleAdd_2[0];
                    }
                    else if (Cam1posRRob1 > -3.5 && Cam1posRRob1 <= -2.5)
                    {
                        dY1[0] = angleAdd_3[0];
                    }
                    else if (Cam1posRRob1 >= 0.5 && Cam1posRRob1 < 1.5)
                    {
                        dY1[0] = angleAdd1[0];
                    }
                    else if (Cam1posRRob1 >= 1.5 && Cam1posRRob1 < 2.5)
                    {
                        dY1[0] = angleAdd2[0];
                    }
                    else if (Cam1posRRob1 >= 2.5 && Cam1posRRob1 < 3.5)
                    {
                        dY1[0] = angleAdd3[0];
                    }
                    else
                    {
                        dY1[0] = 0.0;
                        dY2[0] = 0.0;
                    }
                    if (Cam1posRRob2 > -1.5 && Cam1posRRob2 <= -0.5)
                    {
                        dY2[0] = angleAdd_1[0];
                    }
                    else if (Cam1posRRob2 > -2.5 && Cam1posRRob2 <= -1.5)
                    {
                        dY2[0] = angleAdd_2[0];
                    }
                    else if (Cam1posRRob2 > -3.5 && Cam1posRRob2 <= -2.5)
                    {
                        dY2[0] = angleAdd_3[0];
                    }
                    else if (Cam1posRRob2 >= 0.5 && Cam1posRRob2 < 1.5)
                    {
                        dY2[0] = angleAdd1[0];
                    }
                    else if (Cam1posRRob2 >= 1.5 && Cam1posRRob2 < 2.5)
                    {
                        dY2[0] = angleAdd2[0];
                    }
                    else if (Cam1posRRob2 >= 2.5 && Cam1posRRob2 < 3.5)
                    {
                        dY2[0] = angleAdd3[0];
                    }
                    else
                    {
                        dY2[0] = 0.0;
                    }
                    dX1[0] = -(stdX1[0] - Cam1posXRob1) + addX1[0];
                    dX2[0] = -(stdX2[0] - Cam1posXRob2) + addX2[0];
                    dX3[0] = -(stdX3[0] - Cam1posXLas1) + addX3[0];
                    dX4[0] = -(stdX4[0] - Cam1posXLas2) + addX4[0];          //相机X偏移

                    dY1[0] += -(stdY1[0] - Cam1posYRob1) + addY1[0];
                    dY2[0] += -(stdY2[0] - Cam1posYRob2) + addY2[0];
                    dY3[0] = -(stdY3[0] - Cam1posYLas1) + addY3[0];
                    dY4[0] = -(stdY4[0] - Cam1posYLas2) + addY4[0];          //相机y偏移

                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXRob1 = posXROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYRob1 = posYROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRRob1 = posTROB1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXRob2 = posXROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYRob2 = posYROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRRob2 = posTROB2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXLas1 = posXLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYLas1 = posYLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRLas1 = posTLAS1[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posXLas2 = posXLAS2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posYLas2 = posYLAS2[0];
                    Project.Instance().RobotManagerInstance.L_Robot[0].Cam1posRLas2 = posTLAS2[0];
                    #endregion

                    #region 根据夹具号来分别额外补偿，若无夹具号
                    if (_jiajuhao == 1)
                    {
                        AddR1X = AddR1J1X + dX1[0];
                        AddR1Y = AddR1J1Y + dY1[0];
                        AddR2X = AddR2J1X + dX2[0];
                        AddR2Y = AddR2J1Y + dY2[0];
                        AddL1X1 = AddL1J1X1 + dX3[0];
                        AddL1Y1 = AddL1J1Y1 / 2 + AddL1J1Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J1X2 + dX3[0];
                        AddL1Y2 = AddL1J1Y2 / 2 + AddL1J1Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J1X3 + dX3[0];
                        AddL1Y3 = AddL1J1Y3 + dY3[0];
                        AddL1X4 = AddL1J1X4 + dX3[0];
                        AddL1Y4 = AddL1J1Y4 + dY3[0];
                        AddL2X1 = AddL2J1X1 + dX4[0];
                        AddL2Y1 = AddL2J1Y1 + dY4[0];
                        AddL2X2 = AddL2J1X2 + dX4[0];
                        AddL2Y2 = AddL2J1Y2 + dY4[0];
                        AddL2X3 = AddL2J1X3 + dX4[0];
                        AddL2Y3 = AddL2J1Y3 + dY4[0];
                        AddL2X4 = AddL2J1X4 + dX4[0];
                        AddL2Y4 = AddL2J1Y4 + dY4[0];
                        LengthC = AddL1J1X2 - AddL1J1X1;
                    }
                    else if (_jiajuhao == 2)
                    {
                        AddR1X = AddR1J2X + dX1[0];
                        AddR1Y = AddR1J2Y + dY1[0];
                        AddR2X = AddR2J2X + dX2[0];
                        AddR2Y = AddR2J2Y + dY2[0];
                        AddL1X1 = AddL1J2X1 + dX3[0];
                        AddL1Y1 = AddL1J2Y1 / 2 + AddL1J2Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J2X2 + dX3[0];
                        AddL1Y2 = AddL1J2Y2 / 2 + AddL1J2Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J2X3 + dX3[0];
                        AddL1Y3 = AddL1J2Y3 + dY3[0];
                        AddL1X4 = AddL1J2X4 + dX3[0];
                        AddL1Y4 = AddL1J2Y4 + dY3[0];
                        AddL2X1 = AddL2J2X1 + dX4[0];
                        AddL2Y1 = AddL2J2Y1 + dY4[0];
                        AddL2X2 = AddL2J2X2 + dX4[0];
                        AddL2Y2 = AddL2J2Y2 + dY4[0];
                        AddL2X3 = AddL2J2X3 + dX4[0];
                        AddL2Y3 = AddL2J2Y3 + dY4[0];
                        AddL2X4 = AddL2J2X4 + dX4[0];
                        AddL2Y4 = AddL2J2Y4 + dY4[0];
                        LengthC = AddL1J2X2 - AddL1J2X1;

                    }
                    else if (_jiajuhao == 3)
                    {
                        AddR1X = AddR1J3X + dX1[0];
                        AddR1Y = AddR1J3Y + dY1[0];
                        AddR2X = AddR2J3X + dX2[0];
                        AddR2Y = AddR2J3Y + dY2[0];
                        AddL1X1 = AddL1J3X1 + dX3[0];
                        AddL1Y1 = AddL1J3Y1 / 2 + AddL1J3Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J3X2 + dX3[0];
                        AddL1Y2 = AddL1J3Y2 / 2 + AddL1J3Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J3X3 + dX3[0];
                        AddL1Y3 = AddL1J3Y3 + dY3[0];
                        AddL1X4 = AddL1J3X4 + dX3[0];
                        AddL1Y4 = AddL1J3Y4 + dY3[0];
                        AddL2X1 = AddL2J3X1 + dX4[0];
                        AddL2Y1 = AddL2J3Y1 + dY4[0];
                        AddL2X2 = AddL2J3X2 + dX4[0];
                        AddL2Y2 = AddL2J3Y2 + dY4[0];
                        AddL2X3 = AddL2J3X3 + dX4[0];
                        AddL2Y3 = AddL2J3Y3 + dY4[0];
                        AddL2X4 = AddL2J3X4 + dX4[0];
                        AddL2Y4 = AddL2J3Y4 + dY4[0];
                        LengthC = AddL1J3X2 - AddL1J3X1;

                    }
                    else if (_jiajuhao == 4)
                    {
                        AddR1X = AddR1J4X + dX1[0];
                        AddR1Y = AddR1J4Y + dY1[0];
                        AddR2X = AddR2J4X + dX2[0];
                        AddR2Y = AddR2J4Y + dY2[0];
                        AddL1X1 = AddL1J4X1 + dX3[0];
                        AddL1Y1 = AddL1J4Y1 / 2 + AddL1J4Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J4X2 + dX3[0];
                        AddL1Y2 = AddL1J4Y2 / 2 + AddL1J4Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J4X3 + dX3[0];
                        AddL1Y3 = AddL1J4Y3 + dY3[0];
                        AddL1X4 = AddL1J4X4 + dX3[0];
                        AddL1Y4 = AddL1J4Y4 + dY3[0];
                        AddL2X1 = AddL2J4X1 + dX4[0];
                        AddL2Y1 = AddL2J4Y1 + dY4[0];
                        AddL2X2 = AddL2J4X2 + dX4[0];
                        AddL2Y2 = AddL2J4Y2 + dY4[0];
                        AddL2X3 = AddL2J4X3 + dX4[0];
                        AddL2Y3 = AddL2J4Y3 + dY4[0];
                        AddL2X4 = AddL2J4X4 + dX4[0];
                        AddL2Y4 = AddL2J4Y4 + dY4[0];
                        LengthC = AddL1J4X2 - AddL1J4X1;

                    }
                    else if (_jiajuhao == 5)
                    {
                        AddR1X = AddR1J5X + dX1[0];
                        AddR1Y = AddR1J5Y + dY1[0];
                        AddR2X = AddR2J5X + dX2[0];
                        AddR2Y = AddR2J5Y + dY2[0];
                        AddL1X1 = AddL1J5X1 + dX3[0];
                        AddL1Y1 = AddL1J5Y1 / 2 + AddL1J5Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J5X2 + dX3[0];
                        AddL1Y2 = AddL1J5Y2 / 2 + AddL1J5Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J5X3 + dX3[0];
                        AddL1Y3 = AddL1J5Y3 + dY3[0];
                        AddL1X4 = AddL1J5X4 + dX3[0];
                        AddL1Y4 = AddL1J5Y4 + dY3[0];
                        AddL2X1 = AddL2J5X1 + dX4[0];
                        AddL2Y1 = AddL2J5Y1 + dY4[0];
                        AddL2X2 = AddL2J5X2 + dX4[0];
                        AddL2Y2 = AddL2J5Y2 + dY4[0];
                        AddL2X3 = AddL2J5X3 + dX4[0];
                        AddL2Y3 = AddL2J5Y3 + dY4[0];
                        AddL2X4 = AddL2J5X4 + dX4[0];
                        AddL2Y4 = AddL2J5Y4 + dY4[0];
                        LengthC = AddL1J5X2 - AddL1J5X1;

                    }
                    else if (_jiajuhao == 6)
                    {
                        AddR1X = AddR1J6X + dX1[0];
                        AddR1Y = AddR1J6Y + dY1[0];
                        AddR2X = AddR2J6X + dX2[0];
                        AddR2Y = AddR2J6Y + dY2[0];
                        AddL1X1 = AddL1J6X1 + dX3[0];
                        AddL1Y1 = AddL1J6Y1 / 2 + AddL1J6Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J6X2 + dX3[0];
                        AddL1Y2 = AddL1J6Y2 / 2 + AddL1J6Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J6X3 + dX3[0];
                        AddL1Y3 = AddL1J6Y3 + dY3[0];
                        AddL1X4 = AddL1J6X4 + dX3[0];
                        AddL1Y4 = AddL1J6Y4 + dY3[0];
                        AddL2X1 = AddL2J6X1 + dX4[0];
                        AddL2Y1 = AddL2J6Y1 + dY4[0];
                        AddL2X2 = AddL2J6X2 + dX4[0];
                        AddL2Y2 = AddL2J6Y2 + dY4[0];
                        AddL2X3 = AddL2J6X3 + dX4[0];
                        AddL2Y3 = AddL2J6Y3 + dY4[0];
                        AddL2X4 = AddL2J6X4 + dX4[0];
                        AddL2Y4 = AddL2J6Y4 + dY4[0];
                        LengthC = AddL1J6X2 - AddL1J6X1;

                    }
                    else if (_jiajuhao == 7)
                    {
                        AddR1X = AddR1J7X + dX1[0];
                        AddR1Y = AddR1J7Y + dY1[0];
                        AddR2X = AddR2J7X + dX2[0];
                        AddR2Y = AddR2J7Y + dY2[0];
                        AddL1X1 = AddL1J7X1 + dX3[0];
                        AddL1Y1 = AddL1J7Y1 / 2 + AddL1J7Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J7X2 + dX3[0];
                        AddL1Y2 = AddL1J7Y2 / 2 + AddL1J7Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J7X3 + dX3[0];
                        AddL1Y3 = AddL1J7Y3 + dY3[0];
                        AddL1X4 = AddL1J7X4 + dX3[0];
                        AddL1Y4 = AddL1J7Y4 + dY3[0];
                        AddL2X1 = AddL2J7X1 + dX4[0];
                        AddL2Y1 = AddL2J7Y1 + dY4[0];
                        AddL2X2 = AddL2J7X2 + dX4[0];
                        AddL2Y2 = AddL2J7Y2 + dY4[0];
                        AddL2X3 = AddL2J7X3 + dX4[0];
                        AddL2Y3 = AddL2J7Y3 + dY4[0];
                        AddL2X4 = AddL2J7X4 + dX4[0];
                        AddL2Y4 = AddL2J7Y4 + dY4[0];
                        LengthC = AddL1J7X2 - AddL1J7X1;

                    }
                    else if (_jiajuhao == 8)
                    {
                        AddR1X = AddR1J8X + dX1[0];
                        AddR1Y = AddR1J8Y + dY1[0];
                        AddR2X = AddR2J8X + dX2[0];
                        AddR2Y = AddR2J8Y + dY2[0];
                        AddL1X1 = AddL1J8X1 + dX3[0];
                        AddL1Y1 = AddL1J8Y1 / 2 + AddL1J8Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J8X2 + dX3[0];
                        AddL1Y2 = AddL1J8Y2 / 2 + AddL1J8Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J8X3 + dX3[0];
                        AddL1Y3 = AddL1J8Y3 + dY3[0];
                        AddL1X4 = AddL1J8X4 + dX3[0];
                        AddL1Y4 = AddL1J8Y4 + dY3[0];
                        AddL2X1 = AddL2J8X1 + dX4[0];
                        AddL2Y1 = AddL2J8Y1 + dY4[0];
                        AddL2X2 = AddL2J8X2 + dX4[0];
                        AddL2Y2 = AddL2J8Y2 + dY4[0];
                        AddL2X3 = AddL2J8X3 + dX4[0];
                        AddL2Y3 = AddL2J8Y3 + dY4[0];
                        AddL2X4 = AddL2J8X4 + dX4[0];
                        AddL2Y4 = AddL2J8Y4 + dY4[0];
                        LengthC = AddL1J8X2 - AddL1J8X1;

                    }
                    else if (_jiajuhao == 9)
                    {
                        AddR1X = AddR1J9X + dX1[0];
                        AddR1Y = AddR1J9Y + dY1[0];
                        AddR2X = AddR2J9X + dX2[0];
                        AddR2Y = AddR2J9Y + dY2[0];
                        AddL1X1 = AddL1J9X1 + dX3[0];
                        AddL1Y1 = AddL1J9Y1 / 2 + AddL1J9Y2 / 2 + dY3[0];
                        AddL1X2 = AddL1J9X2 + dX3[0];
                        AddL1Y2 = AddL1J9Y2 / 2 + AddL1J9Y1 / 2 + dY3[0];
                        AddL1X3 = AddL1J9X3 + dX3[0];
                        AddL1Y3 = AddL1J9Y3 + dY3[0];
                        AddL1X4 = AddL1J9X4 + dX3[0];
                        AddL1Y4 = AddL1J9Y4 + dY3[0];
                        AddL2X1 = AddL2J9X1 + dX4[0];
                        AddL2Y1 = AddL2J9Y1 + dY4[0];
                        AddL2X2 = AddL2J9X2 + dX4[0];
                        AddL2Y2 = AddL2J9Y2 + dY4[0];
                        AddL2X3 = AddL2J9X3 + dX4[0];
                        AddL2Y3 = AddL2J9Y3 + dY4[0];
                        AddL2X4 = AddL2J9X4 + dX4[0];
                        AddL2Y4 = AddL2J9Y4 + dY4[0];
                        LengthC = AddL1J9X2 - AddL1J9X1;

                    }
                    else
                    {
                        AddR1X = dX1[0];
                        AddR1Y = dY1[0];
                        AddR2X = dX2[0];
                        AddR2Y = dY2[0];
                        AddL1X1 = dX3[0];
                        AddL1Y1 = dY3[0];
                        AddL1X2 = dX3[0];
                        AddL1Y2 = dY3[0];
                        AddL1X3 = dX3[0];
                        AddL1Y3 = dY3[0];
                        AddL1X4 = dX3[0];
                        AddL1Y4 = dY3[0];
                        AddL2X1 = dX4[0];
                        AddL2Y1 = dY4[0];
                        AddL2X2 = dX4[0];
                        AddL2Y2 = dY4[0];
                        AddL2X3 = dX4[0];
                        AddL2Y3 = dY4[0];
                        AddL2X4 = dX4[0];
                        AddL2Y4 = dY4[0];
                    }

                    #endregion

                    if (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[_workFlowIndex] == 1.0)
                    {
                        double SpecingX = Math.Round((Convert.ToDouble(_spacing.ToString("f3")) - Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[_workFlowIndex]), 3);

                        AddL1X3 = dX3[0] + SpecingX;
                        AddL1X4 = dX3[0] + SpecingX;
                        AddL2X3 = dX4[0] + SpecingX;
                        AddL2X4 = dX4[0] + SpecingX;
                    }


                    Project.Instance().ProductionDataManagerInstance.L_productionCCDOKCountList[0][_workFlowIndex]++;
                    FinalResult = "OK";

                }
                else
                {
                    isOk = false;
                    Project.Instance().ProductionDataManagerInstance.L_productionCCDNGCountList[0][_workFlowIndex]++;
                    FinalResult = "NG";
                }
                _camResult[_workFlowIndex] = isOk ? 1 : 2;


                double limitMIN = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[_workFlowIndex];
                double limitMAX = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[_workFlowIndex];
                bool OutLimit = false;
                if (dX1[0] < limitMIN || dX1[0] > limitMAX || dX3[0] < limitMIN || dX3[0] > limitMAX || dY1[0] < limitMIN || dY1[0] > limitMAX || dY3[0] < limitMIN || dY3[0] > limitMAX)
                {
                    isOk = false;
                    OutLimit = true;
                    FinalResult = "NG";
                }


                ///显示界面:
                CogColorConstants Color = isOk ? CogColorConstants.Green : CogColorConstants.Red;
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], Color, 0, 0, string.Format("{0}", FinalResult), FontSize);
               // WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 2, "取像时间：" + mSeconds1.ToString() + "ms", FontSize);
               // WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 4, "处理时间：" + mSeconds2.ToString() + "ms", FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 6, "机械手1偏移X：" + dX2[0].ToString("f3") + "Y：" + dY2[0].ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 8, "焊点1偏移 X：" + (AddL2X1).ToString("f3") + "Y：" + (AddL2Y1).ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 10, "焊点2偏移 X：" + (AddL2X2).ToString("f3") + "Y：" + (AddL2Y2).ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 12, "焊点3偏移 X：" + (AddL2X3).ToString("f3") + "Y：" + (AddL2Y3).ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 14, "焊点4偏移 X：" + (AddL2X4).ToString("f3") + "Y：" + (AddL2Y4).ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 16, "焊点偏移X：" + dX4[0].ToString("f3") + "Y：" + dY4[0].ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 18, "弹夹角度：" + Pangle.ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 20, "胶片角度：" + Pangle.ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 22, "极耳间距：" + _spacing.ToString("f3"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 24, "工位号：" + "2(面朝屏幕左手端)", FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 26, "夹具号：" + _jiajuhao, FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 28, "电池条码：" + _code2, FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 30, DateTime.Now.ToString("HH:mm:ss"), FontSize);
                WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 36, sError, FontSize);//YBR
                if (OutLimit == true)
                {
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 32, "偏移值超限NG", FontSize);

                }
                TriggerEventArgs triggerEventArgs = new TriggerEventArgs();
                //VP或者Halcon存图
                triggerEventArgs.resultImage = GlobalCameraParams.cameraVisionControlList[_workFlowIndex];
                triggerEventArgs.rawImage = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                triggerEventArgs.imageName = (_workFlowIndex + 1).ToString();
                triggerEventArgs.results = isOk;
                triggerEventArgs.Index = _workFlowIndex;
                Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageSave.mSaveImageQueue[_workFlowIndex].Enqueue(triggerEventArgs);

            }
            catch (Exception ex)
            {
                LogHelper.Error(ex.Message);
            }
        }

        private void 单帧2工位ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            if (_isLive)
            {
                实时ToolStripMenuItem.Text = "开始实时";
                _isLive = false;
                this.cogRecordDisplay1.Display.StaticGraphics.Clear();
                this.cogRecordDisplay1.Subject = null;
                cogRecordDisplay1.Display.BackColor = Color.Black;
                cogRecordDisplay1.Display.GridColor = Color.Black;
                this.cogRecordDisplay1.Display.StopLiveDisplay();
            }
            try
            {
                string lasermove = "_PDMoveAbs(0," + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[0].ToString() + "," + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[0].ToString() + ",500);";
                Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser = Project.Instance().LaserManagerInstance.L_Laser[0].SendText(lasermove);
                if (!Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser)
                {
                    Project.Instance().LaserManagerInstance.L_Laser[0].Connect();
                    Thread.Sleep(50);
                    Project.Instance().LaserManagerInstance.L_Laser[0].IsConnectedLaser = Project.Instance().LaserManagerInstance.L_Laser[0].SendText(lasermove);
                }
                Thread.Sleep(50);
            }
            catch (Exception)
            {
                if (null != Project.Instance().LaserManagerInstance.L_Laser[0]) Project.Instance().LaserManagerInstance.L_Laser[0].Close();
                Project.Instance().LaserManagerInstance.L_Laser[0].Connect();
            }

            GrabImage1();
        }
        private byte[] ReverseBytes(byte[] input, int index, int count)
        {
            // 参数校验
            if (input == null)
                throw new ArgumentNullException(nameof(input));
            if (index < 0)
            {
                LogHelper.Error("index必须是非负的");
                return input;
            }
            if (count < 0 || count % 2 != 0)
            {
                LogHelper.Error("index+count超出数组边界");
                return input;
            }

            if (index + count > input.Length)
            {
                LogHelper.Error("index+count超出数组边界");
                return input;
            }
            // 创建输出数组并复制数据
            byte[] output = new byte[count];
            Array.Copy(input, index, output, 0, count);

            // 两两交换字节
            for (int i = 0; i < count; i += 2)
            {
                // 交换相邻字节
                byte temp = output[i];
                output[i] = output[i + 1];
                output[i + 1] = temp;
            }
            return output;
        }
        private byte[] Remove_zero(byte[] input)
        {
            List<byte> temp = new List<byte>();
            foreach (var element in input)
            {
                if (element != 0)
                {
                    temp.Add(element);
                }
            }
            byte[] output = temp.ToArray();
            return output;
        }
    }

}
