using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region using Cognex::namespace
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System.Drawing;
#endregion
using VisionProgram.Common;
using Cognex.VisionPro.CalibFix;
using VisionProgram.Main.ProjectClass;
using System.Threading.Tasks;

namespace VisionProgram.Vision.VP
{
    public class TriggerEventArgs : EventArgs
    {
        public int Index { get; set; } = 0;
        public bool IsAcquire { get; set; }
        public int CalibMode { get; set; } //标定模式
        public string Filename { get; set; }
        /// <summary>
        ///  脚本运行模式
        /// 0为正常运行检测
        /// 1为获取基准数据
        /// </summary>
        public int PorcMode { get; set; }
        public bool IsShowResults { get; set; }
        public System.Drawing.Image ig { get; set; }//存结果图片
        public CogRecordsDisplay resultImage { get; set; }//存结果图片
        public ICogImage rawImage { get; set; }//存原图
        public ICogImage inputImage { get; set; }//存原图
        public bool results { get; set; }//处理结果
        public string imageName { get; set; }//图片名
        public string Code { get; set; }
    }

    public class WorkFlow
    {
        //当前流程索引
        private string _vppName;
        private int _vppIndex;
        public string VppName
        {
            get { return _vppName; }
        }
        private string _acquireBlockpath;//取相
        private string _distortioncalibBlockpath;//畸变标定
        private string _linearcalibBlockpath;//九点线性标定   
        private string _rotationcalibBlockpath;//旋转中心标定
        private string _processBlockpath;//处理

        protected ICogTransform2D LinearTransform;  //rob1九点线性坐标转换关系
        protected ICogTransform2D LinearTransform1;  //rob2九点线性坐标转换关系
        protected ICogTransform2D LinearTransform2;  //laser1九点线性坐标转换关系
        protected ICogTransform2D LinearTransform3;  //laser2九点线性坐标转换关系
        protected ICogTransform2D DistortionTransform; //畸变坐标转换关系
        bool calibflag = false;

        public static readonly object obj = new object();
        //取图队列
        public BlockQueue<ICogImage> mImageQueue = new BlockQueue<ICogImage>(200);

        /// <summary>
        /// 取相工具集
        /// </summary>
        protected CogAcqFifoTool m_AcquireTool;
        public CogAcqFifoTool AcquireTool
        {
            get { return m_AcquireTool; }
        }
        /// <summary>
        /// 取相模块
        /// </summary>
        protected CogToolBlock m_AcquireBlock;
        /// <summary>
        /// 取相模块
        /// </summary>
        public CogToolBlock AcquireBlock
        {
            get
            {
                return m_AcquireBlock;
            }
        }
        /// <summary>
        /// 畸变标定模块
        /// </summary>
        protected CogToolBlock m_DistortionCalibBlock;
        /// <summary>
        /// 畸变标定模块
        /// </summary>
        public CogToolBlock DistortionCalibBlock
        {
            get
            {
                return m_DistortionCalibBlock;
            }
        }
        /// <summary>
        /// 九点线性标定模块
        /// </summary>
        protected CogToolBlock m_LinearCalibBlock;
        /// <summary>
        /// 九点线性标定模块
        /// </summary>
        public CogToolBlock LinearCalibBlock
        {
            get
            {
                return m_LinearCalibBlock;
            }
        }

        /// <summary>
        /// 旋转中心标定模块
        /// </summary>
        protected CogToolBlock m_RotationCalibBlock;
        /// <summary>
        /// 旋转中心标定模块
        /// </summary>
        public CogToolBlock RotationCalibBlock
        {
            get
            {
                return m_RotationCalibBlock;
            }
        }

        /// <summary>
        /// 处理模块
        /// </summary>
        protected CogToolBlock m_ProcessBlock;
        /// <summary>
        /// 处理模块
        /// </summary>
        public CogToolBlock ProcessBlock
        {
            get
            {
                return m_ProcessBlock;
            }
        }

        /// <summary>
        /// 参数设置模块
        /// </summary>
        protected CogToolBlock m_SettingBlock;
        /// <summary>
        /// 参数设置模块
        /// </summary>
        public CogToolBlock SettingBlock
        {
            get
            {
                return m_SettingBlock;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="p"></param> 特征索引 区分不同流程
        public WorkFlow(string p)
        {
            _vppName = p;
            _vppIndex = Convert.ToInt16(_vppName) - 1;
            _acquireBlockpath = Project.Instance().VisionManagerInstance._visionToolPath + @"\acquire\AcquireBlock" + _vppName + ".vpp";
            _distortioncalibBlockpath= Project.Instance().VisionManagerInstance._visionToolPath + @"\calib_distortion\DistortionCalibBlock" + _vppName + ".vpp";
            _linearcalibBlockpath = Project.Instance().VisionManagerInstance._visionToolPath + @"\calib_linear\LinearCalibBlock" + _vppName + ".vpp";
            _rotationcalibBlockpath= Project.Instance().VisionManagerInstance._visionToolPath + @"\calib_rotation\RotationCalibBlock" + _vppName + ".vpp";
            _processBlockpath = Project.Instance().VisionManagerInstance._visionToolPath + @"\process\ProcessBlock" + _vppName + ".vpp";
        }
        /// <summary>
        /// 加载工具
        /// </summary>
        /// <returns></returns>
        public bool InitTools()
        {
            try
            {
        
                    m_AcquireBlock = CogSerializer.LoadObjectFromFile(_acquireBlockpath) as CogToolBlock;      
                    m_ProcessBlock = CogSerializer.LoadObjectFromFile(_processBlockpath) as CogToolBlock;
                    m_DistortionCalibBlock = CogSerializer.LoadObjectFromFile(_distortioncalibBlockpath) as CogToolBlock;
                    m_LinearCalibBlock = CogSerializer.LoadObjectFromFile(_linearcalibBlockpath) as CogToolBlock;
                    m_RotationCalibBlock = CogSerializer.LoadObjectFromFile(_rotationcalibBlockpath) as CogToolBlock;
                    m_AcquireTool = m_AcquireBlock.Tools["CogAcqFifoTool1"] as CogAcqFifoTool;

                    try
                    {
                        DistortionTransform = DistortionCalibBlock.Outputs["DistortionTransform"].Value as ICogTransform2D;
                        LinearTransform = LinearCalibBlock.Outputs["LinearTransform"].Value as ICogTransform2D;
                    LinearTransform1 = LinearCalibBlock.Outputs["LinearTransform2"].Value as ICogTransform2D;
                    LinearTransform2 = LinearCalibBlock.Outputs["LinearTransform3"].Value as ICogTransform2D;
                    LinearTransform3 = LinearCalibBlock.Outputs["LinearTransform4"].Value as ICogTransform2D;


                    calibflag = true;
                    }
                    catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    calibflag = false;
                    }
                    m_SettingBlock = new CogToolBlock();
                    SettingBlock.Tools.Add(AcquireBlock);
                    if (calibflag)
                    {
                        SettingBlock.Tools.Add(DistortionCalibBlock);
                        SettingBlock.Tools.Add(LinearCalibBlock);
                        SettingBlock.Tools.Add(RotationCalibBlock);
                    }     
                    SettingBlock.Tools.Add(ProcessBlock);
              
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogHelper.Error("加载视觉工具出现异常", ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 存取图工具
        /// </summary>
        /// <returns></returns>
        public bool SaveAccquireTools()
        {
            try
            {
                CogSerializer.SaveObjectToFile(AcquireBlock, _acquireBlockpath,
                typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                CogSerializationOptionsConstants.Minimum);
            }
            catch (Exception ex)
            {
                LogHelper.Error("保存取像工具出现异常", ex);
                return false;
            }
            return true;
        }


        /// <summary>
        /// 保存工具
        /// </summary>
        /// <returns></returns>
        public bool SaveTools()
        {
            try
            {
                    CogSerializer.SaveObjectToFile(AcquireBlock, _acquireBlockpath,
                                typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                                CogSerializationOptionsConstants.Minimum);
                    CogSerializer.SaveObjectToFile(ProcessBlock, _processBlockpath,
                            typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                            CogSerializationOptionsConstants.Minimum);
                    CogSerializer.SaveObjectToFile(DistortionCalibBlock, _distortioncalibBlockpath,
                            typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                            CogSerializationOptionsConstants.Minimum);
                    CogSerializer.SaveObjectToFile(LinearCalibBlock, _linearcalibBlockpath,
                            typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                            CogSerializationOptionsConstants.Minimum);
                    CogSerializer.SaveObjectToFile(RotationCalibBlock, _rotationcalibBlockpath,
                             typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                             CogSerializationOptionsConstants.Minimum);
                    try
                    {
                        DistortionTransform = DistortionCalibBlock.Outputs["DistortionTransform"].Value as ICogTransform2D;
                        LinearTransform = LinearCalibBlock.Outputs["LinearTransform"].Value as ICogTransform2D;
                    LinearTransform1 = LinearCalibBlock.Outputs["LinearTransform2"].Value as ICogTransform2D;
                    LinearTransform2 = LinearCalibBlock.Outputs["LinearTransform3"].Value as ICogTransform2D;
                    LinearTransform3 = LinearCalibBlock.Outputs["LinearTransform4"].Value as ICogTransform2D;

                }
                    catch { }
       
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogHelper.Error("保存视觉工具出现异常", ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 运行取向模块
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunAcquireBlock(out ICogImage img)
        {
            if ((m_AcquireTool.Operator.FrameGrabber != null))
            {
                Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.SaveExprosure(0, Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[0]);
                m_AcquireBlock.Run();
                img = m_AcquireBlock.Outputs["OutputImage"].Value as ICogImage;
                return (bool)(AcquireBlock.Outputs["bAccept"].Value);
            }
            else
            {
                img = null;
                MessageBox.Show("控件CamOperator属性未赋值.", "取像时...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
     

        /// <summary>
        /// 运行处理模块
        /// </summary>
        /// <param name="e"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunProcessBlock(ref ICogImage img)
        {
            try
            {
                ProcessBlock.Inputs["InputImage"].Value = img;
                if (calibflag)
                {
                    ProcessBlock.Inputs["LinearTransform"].Value = LinearTransform;
                    ProcessBlock.Inputs["LinearTransform1"].Value = LinearTransform1;
                    ProcessBlock.Inputs["LinearTransform2"].Value = LinearTransform2;
                    ProcessBlock.Inputs["LinearTransform3"].Value = LinearTransform3;
                    ProcessBlock.Inputs["DistortionTransform"].Value = DistortionTransform;
                }
                ProcessBlock.Run();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("运行处理模块工具出现异常", ex);
                MessageBox.Show(ex.Message);
            }
            return false;

        }
        /// <summary>
        /// 运行畸变标定模块
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunDistortionCalibBlock(ref ICogImage img)
        {
            try
            {
                DistortionCalibBlock.Inputs["InputImage"].Value = img;
                CogCalibCheckerboardTool tool = DistortionCalibBlock.Tools["CogCalibCheckerboardTool1"] as CogCalibCheckerboardTool;
                CogCalibCheckerboard board = new CogCalibCheckerboard
                {
                    CalibrationImage = img,
                    ComputationMode = CogCalibFixComputationModeConstants.PerspectiveAndRadialWarp,
                    FeatureFinder = CogCalibCheckerboardFeatureFinderConstants.Checkerboard,//棋盘格
                    FiducialMark = CogCalibCheckerboardFiducialConstants.DataMatrix,
                    PhysicalTileSizeX = 4,    //4mm标定版
                    PhysicalTileSizeY = 4      //4mm标定版
                };
                board.Calibrate();
                tool.Calibration = board;
                DistortionCalibBlock.Run();
                DistortionCalibBlock.Outputs["DistortionTransform"].Value = tool.Calibration.GetComputedUncalibratedFromCalibratedTransform();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("运行畸变标定模块工具出现异常", ex);
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// 运行九点线性标定模块
        /// </summary>
        /// <param name="img"></param>
        /// <param name="calibimg"></param>
        /// <returns></returns>
        public bool RunLinearCalibBlock(ref ICogImage img)
        {
            try
            {
                LinearCalibBlock.Inputs["InputImage"].Value = img;
                LinearCalibBlock.Inputs["DistortionTransform"].Value = DistortionTransform;
                LinearCalibBlock.Run();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("运行九点线性标定模块工具出现异常", ex);
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// 运行旋转中心标定模块
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunRotationCalibBlock(ref ICogImage img)
        {
            try
            {
                RotationCalibBlock.Inputs["InputImage"].Value = img;
                RotationCalibBlock.Inputs["LinearTransform"].Value = LinearTransform;
                RotationCalibBlock.Inputs["LinearTransform1"].Value = LinearTransform2;
                RotationCalibBlock.Inputs["DistortionTransform"].Value = DistortionTransform;
                RotationCalibBlock.Run();
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("运行旋转中心标定模块工具出现异常", ex);
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// 运行取向+处理模块
        /// </summary>
        /// <returns></returns>
        public bool RunAProc()
        {
            ICogImage img;
            RunAcquireBlock(out img);
            return RunProcessBlock(ref img);
        }
       
        /// <summary>
        /// 运行取向+标定模块
        /// </summary>
        /// <returns></returns>
        public bool RunACalib()
        {
            ICogImage img;
            RunAcquireBlock(out img);
            return RunLinearCalibBlock(ref img);
        }

        /// <summary>
        /// 刷新界面显示
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="bAccquire"></param>  是否刷新取向
        /// <returns></returns>
        public bool UpdateGraphicResult(CogRecordsDisplay _cd)
        {
            if (!(bool)(AcquireBlock.Outputs["bAccept"].Value))
            {
                return false;
            }
            _cd.Invoke((MethodInvoker)delegate
            {
                ICogRecord r = null;
                _cd.Display.Image = null;
                _cd.Display.InteractiveGraphics.Clear();
                _cd.Display.StaticGraphics.Clear();
                if (!(bool)(AcquireBlock.Outputs["bAccept"].Value))
                {
                    r = AcquireBlock.CreateLastRunRecord();
                    _cd.Subject = r.SubRecords["CogAcqFifoTool1.OutputImage"];
                }
                else
                {
                    r = ProcessBlock.CreateLastRunRecord();
                    //显示结果
                    _cd.Subject = r.SubRecords["CogFixtureTool1.OutputImage"];
                }
                _cd.Display.Fit(false);
                _cd.Display.BackColor = Color.Black;
                _cd.Display.GridColor = Color.Black;
            });
            return true;
        }

        /// <summary>
        /// 图片显示到CogRecordDisplay
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool UpdateImage(CogRecordsDisplay _cd, ref ICogImage img)
        {
            if (!(bool)(AcquireBlock.Outputs["bAccept"].Value))
            {
                return false;
            }
            _cd.Display.DrawingEnabled = false;
            _cd.Display.InteractiveGraphics.Clear();
            _cd.Display.StaticGraphics.Clear();
            if ((bool)(AcquireBlock.Outputs["bAccept"].Value))
            {
                _cd.Display.Image = img;
            }

            _cd.Display.DrawingEnabled = true;

            return true;
        }

        /// <summary>
        /// 连接相机
        /// </summary>
        /// <returns></returns>
        public bool connected()
        {
            /******** GIGE ******/
            ICogFrameGrabber fg = m_AcquireTool.Operator.FrameGrabber;
            if (fg == null)
            {
                return false;
            }
            CogFrameGrabberStatusConstants st = fg.GetStatus(false);
            if (st == CogFrameGrabberStatusConstants.Active)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 断开相机
        /// </summary>
        /// <returns></returns>
        public bool disconnect()
        {
            try
            {
                if ((null != m_AcquireTool.Operator) && (null != m_AcquireTool.Operator.FrameGrabber))
                {
                    m_AcquireTool.Operator.FrameGrabber.Disconnect(false);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //窗体显示文字信息
        public  static void DisplayLabelCogDisplay(CogRecordsDisplay mydisplay, CogColorConstants Color, System.Single x, System.Single y, string text, System.Int16 fontSize)
        {
            new Action(() =>
            {
                lock (obj)
                {
                    try
                    {
                        CogGraphicLabel GraphicLabel = new CogGraphicLabel();
                        GraphicLabel.SetXYText(x, y, text);
                        Font font = new System.Drawing.Font("微软雅黑", fontSize, FontStyle.Bold);
                        GraphicLabel.Font = font;
                        GraphicLabel.Alignment = CogGraphicLabelAlignmentConstants.TopLeft;
                        GraphicLabel.SelectedSpaceName = mydisplay.Display.UserDisplayTree.RootName;
                        GraphicLabel.Color = Color;
                        mydisplay.Display.InteractiveGraphics.Add(GraphicLabel, "me", true);
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("Label加载异常", ex);
                    }
                }
            }).Invoke();
        }


        #region 硬触发
        /*
        /// <summary>
        /// 添加相机硬触发事件
        /// </summary>
        public void AddCamEvent()
        {
             
            {

                m_AcquireTool.Operator.Complete += new CogCompleteEventHandler(Operator_Complete);
                m_AcquireTool.Operator.OwnedTriggerParams.TriggerEnabled = true;
                m_AcquireTool.Operator.OwnedTriggerParams.TriggerLowToHigh = true;
                m_AcquireTool.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
                // Form_Main.TriggerMode[int.Parse(_vpp_name) - 1] = true;
            }
            catch { }
        }

        private void Operator_Complete(object sender, CogCompleteEventArgs e)
        {
            int numReadyVal, numPendingVal;
            bool busyVal;

            CogAcqInfo info = new CogAcqInfo();6

            try
            {
                m_AcquireTool.Operator.GetFifoState(out numPendingVal, out numReadyVal, out busyVal);
                if (numReadyVal > 0)
                {
                    var mICogImage = (ICogImage)m_AcquireTool.Operator.CompleteAcquireEx(info);
                    mImageQueue.Enqueue(mICogImage);
                }

                Project.Instance.ProductionDataManagerInstance.L_productionCCDStartDealTime[_vppIndex] = DateTime.Now;

            }
            catch
            {


            }

        }
        /// <summary>
        /// 删除相机硬触发事件
        /// </summary>
        public void DeleteCamEvent()
        {
            try
            {

                m_AcquireTool.Operator.Complete -= new CogCompleteEventHandler(Operator_Complete);
                m_AcquireTool.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Manual;

            }
            catch { }
        } */
        #endregion
    }
}
