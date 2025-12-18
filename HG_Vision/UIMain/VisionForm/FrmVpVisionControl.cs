using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Cognex.VisionPro;
using Cognex.VisionPro.ImageFile;
using System.Diagnostics;
using System.Threading;
using Model.ConstantModel;
using Model.UIModel;
using Obj.Obj_File;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using HG_Vision.Contol.Control_Socket;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIVision
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
        private WorkFlow1 _curWorkFlow;
        public WorkFlow1 CurWorkFlow
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
        /// <param name="p">名称</param>
        public FrmVpVisionControl(string p)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            _vppName = p;
            //当前窗体对应的vpp索引
            _workFlowIndex = Convert.ToInt16(_vppName) - 1;

            try
            {
                _curWorkFlow = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[_workFlowIndex];
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
                Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[_workFlowIndex].disconnect();
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
                if (tbExposeReal.Text != null && tbExposeReal.Text != "")
                {
                    relExpose = Convert.ToDouble(tbExposeReal.Text);
                }
                else
                {
                    relExpose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure;
                }
            }
            catch
            {
                relExpose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure;
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
            ICogAcqFifo CamOperator = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[_workFlowIndex].AcquireTool.Operator;
            if (CamOperator != null && CamOperator.FrameGrabber != null)
            {
                if (CamOperator.CameraPort >= 0)
                {
                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure = CamOperator.OwnedExposureParams.Exposure;
                    //写入config的.xml
                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveAllParams();
                    //刷新CCD链接状态
                    Project.Instance.HardWareStateManagerInstance.L_ccdState[_workFlowIndex] = true;
                }
            }
        }

        /// <summary>
        /// 显示窗体标题
        /// </summary>
        public void showTitle()
        {
            lbImageName.Text = Project.Instance.VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[_workFlowIndex].ImageWindowName;
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
        public void AddRextOnImage(string text, int x, int y, CogColorConstants color, float textSize, bool beforeClear = true)
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
                string lasermove = "_PDMoveAbs(0," + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X.ToString() +
                    "," + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y.ToString() + ",500);";
                Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected = Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").SendText(lasermove);
                if (!Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected)
                {
                    Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").Connect();
                    Thread.Sleep(50);
                    Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected = Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").SendText(lasermove);
                }
                Thread.Sleep(100);
            }
            catch (Exception)
            {
                if (null != Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}")) Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").StopClient();
                Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").Connect();
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

        private volatile bool[] _camComplete = new bool[Project.Instance.VisionManagerInstance.CameraNum]; //相机完成标识
        private volatile int[] _camResult = new int[Project.Instance.VisionManagerInstance.CameraNum];//相机结果标识

        private void 处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TriggerEventArgs args = new TriggerEventArgs()
            {
                FlowIdx = 0,
                NozzleIdx = 0,
                eMode = Model.EnumModel.eProcessMode.debug,
                InputImage = cogRecordDisplay1.Display.Image
            };
            CameraWorkThrad1.VisionProcess(args);
            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.StandPose = args.ResultOffset;
        }
        //已失效
        private void 工具设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_curWorkFlow.SettingBlock != null)
            //{
            //    FrmVppSetting VisionToolSettingForm = new FrmVppSetting(_curWorkFlow, _vppName);
            //    VisionToolSettingForm.AfterSaveTool += AfterSaveTool;
            //    VisionToolSettingForm.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("SettingBlock！", "异常信息");
            //}
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
                Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[_workFlowIndex].AcquireBlock.Outputs["bAccept"].Value = true;
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
        //已失效

        private void 图片保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmImageStoreSettings FrmImageStoreSettings = new FrmImageStoreSettings(_vppName);

            //FrmImageStoreSettings.ShowDialog();
        }

        private void 查看图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string path = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[_workFlowIndex].ResultImagePosition;
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
            TriggerEventArgs args = new TriggerEventArgs()
            {
                FlowIdx = 0,
                NozzleIdx = 1,
                eMode = Model.EnumModel.eProcessMode.debug
            };
            CameraWorkThrad1.VisionProcess(args);
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
                string lasermove = "_PDMoveAbs(0," + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.X.ToString() + "," + 
                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.Y.ToString() + ",500);";
                Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected = Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").SendText(lasermove);
                if (!Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected)
                {
                    Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").Connect();
                    Thread.Sleep(50);
                    Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").IsConnected = Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").SendText(lasermove);
                }
                Thread.Sleep(50);
            }
            catch (Exception)
            {
                if (null != Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}")) Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").StopClient();
                Project.Instance.ClientManagerInstance.GetDevice<LaserClientObj>($"Laser{0}").Connect();
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
