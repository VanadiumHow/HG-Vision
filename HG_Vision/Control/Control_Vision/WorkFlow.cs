using System;
using System.Windows.Forms;
using System.Drawing;
#region using Cognex::namespace
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.CalibFix;
#endregion
using Obj.Obj_File;
using Obj.Obj_Queue;
using HG_Vision.Manager.Manager_System;
using Model.EnumModel;
using System.Reflection;
using log4net.Repository.Hierarchy;
using Model.ConstantModel;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Vision
{
    /// <summary>
    /// 流程触发事件参数
    /// </summary>
    internal class TriggerEventArgs : EventArgs
    {
        internal int FlowIdx { get; set; }
        internal int NozzleIdx {  get; set; } // 振镜位置
        internal eProcessMode eMode { get; set; } // 流程模式
        internal CogRecordsDisplay DisplayObj { get; set; } // 存结果图片
        internal ICogImage rawImage { get; set; } // 存原图
        internal bool results { get; set; } // 处理结果
        internal string imageName { get; set; } // 图片名
        internal BasePose ResultOffset { get; set; } // 基准位置记录
        internal double X { get; set; } // 结果X
        internal double Y { get; set; } // 结果Y
        internal double R { get; set; } // 结果R
        //构造方法
        internal TriggerEventArgs()
        {
            ResultOffset = new BasePose();
        }
    }

    public class WorkFlow1
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
        private string _VerificatecalibBlockpath;//标定验证
        private string _processBlockpath;//处理

        protected ICogTransform2D LinearTransform;  //rob1九点线性坐标转换关系
        protected ICogTransform2D LinearTransform1;  //rob2九点线性坐标转换关系
        protected ICogTransform2D LinearTransform2;  //laser1九点线性坐标转换关系
        protected ICogTransform2D LinearTransform3;  //laser2九点线性坐标转换关系
        protected ICogTransform2D DistortionTransform; //畸变坐标转换关系
        //已标定标志位
        bool calibflag = false;

        public static readonly object obj = new object();
        //取图队列
        public BlockQueue<ICogImage> mImageQueue = new BlockQueue<ICogImage>(200);

        /// <summary>
        /// 取相工具Tool
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
        /// 标定验证模块
        /// </summary>
        protected CogToolBlock m_VerificatecalibBlock;
        /// <summary>
        /// 标定验证模块
        /// </summary>
        public CogToolBlock VerificatecalibBlock
        {
            get
            {
                return m_VerificatecalibBlock;
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
        public WorkFlow1(string p)
        {
            _vppName = p;
            _vppIndex = Convert.ToInt16(_vppName) - 1;
            _acquireBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\acquire\AcquireBlock" + _vppName + ".vpp";
            _distortioncalibBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\calib_distortion\DistortionCalibBlock" + _vppName + ".vpp";
            _linearcalibBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\calib_linear\LinearCalibBlock" + _vppName + ".vpp";
            _rotationcalibBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\calib_rotation\RotationCalibBlock" + _vppName + ".vpp";
            _VerificatecalibBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\calib_Verificate\VerificateCalibBlock" + _vppName + ".vpp";
            _processBlockpath = Project.Instance.VisionManagerInstance._visionToolPath + @"\process\ProcessBlock" + _vppName + ".vpp";
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
                m_VerificatecalibBlock = CogSerializer.LoadObjectFromFile(_VerificatecalibBlockpath) as CogToolBlock;

                m_AcquireTool = m_AcquireBlock.Tools["相机取像工具*"] as CogAcqFifoTool;

                try
                {
                    //待完成：如果不启用则不加载校正结果
                    DistortionTransform = DistortionCalibBlock.Outputs["DistortionTransform"].Value as ICogTransform2D;
                    LinearTransform = LinearCalibBlock.Outputs["LinearTransformBo"].Value as ICogTransform2D;
                    LinearTransform1 = LinearCalibBlock.Outputs["LinearTransformBo2"].Value as ICogTransform2D;
                    LinearTransform2 = LinearCalibBlock.Outputs["LinearTransformLa"].Value as ICogTransform2D;
                    LinearTransform3 = LinearCalibBlock.Outputs["LinearTransformLa2"].Value as ICogTransform2D;
                    calibflag = true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    calibflag = false;
                }
                m_SettingBlock = new CogToolBlock();
                SettingBlock.Tools.Add(m_AcquireBlock);
                if (calibflag)
                {
                    SettingBlock.Tools.Add(DistortionCalibBlock);
                    SettingBlock.Tools.Add(LinearCalibBlock);
                    SettingBlock.Tools.Add(RotationCalibBlock);
                    SettingBlock.Tools.Add(VerificatecalibBlock);
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
                CogSerializer.SaveObjectToFile(m_AcquireBlock, _acquireBlockpath,
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
                CogSerializer.SaveObjectToFile(m_AcquireBlock, _acquireBlockpath,
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
                CogSerializer.SaveObjectToFile(VerificatecalibBlock, _VerificatecalibBlockpath,
                    typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter),
                    CogSerializationOptionsConstants.Minimum);
                try
                {
                    //待完成：如果不启用则不加载校正结果
                    DistortionTransform = DistortionCalibBlock.Outputs["DistortionTransform"].Value as ICogTransform2D;
                    LinearTransform = LinearCalibBlock.Outputs["LinearTransformRo"].Value as ICogTransform2D;
                    LinearTransform1 = LinearCalibBlock.Outputs["LinearTransformRo2"].Value as ICogTransform2D;
                    LinearTransform2 = LinearCalibBlock.Outputs["LinearTransformLa"].Value as ICogTransform2D;
                    LinearTransform3 = LinearCalibBlock.Outputs["LinearTransformLa2"].Value as ICogTransform2D;
                }
                catch { }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                LogHelper.Error("保存视觉工具出现异常", ex);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 运行取像模块
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunAcquireBlock(out ICogImage img)
        {
            try
            {
                if (m_AcquireTool.Operator.FrameGrabber == null) //检查视频格式是否为空，为空则相机未连接
                {
                    img = null;
                    MessageBox.Show("控件CamOperator属性未赋值.", "取像失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveExprosure
                (0, Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure);
                m_AcquireBlock.Run();
                if (m_AcquireBlock.RunStatus.Result != CogToolResultConstants.Accept)
                {
                    LogHelper.Error($"取像工具块运行输出非可接受结果:{m_AcquireBlock.RunStatus.Message}");
                    img = null;
                    return false;
                }
                img = m_AcquireBlock.Outputs["OutputImage"].Value as ICogImage;
                if (img == null)
                {
                    LogHelper.Error("取像工具块运行输出图像为空");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("取像工具块出现异常", ex);
                img = null;
                return false;
            }
        }
        /// <summary>
        /// 运行畸变标定模块
        /// </summary>
        /// <param name="img">引用类型的图像</param>
        /// <returns></returns>
        public bool RunDistortionCalibBlock(ref ICogImage img)
        {
            try
            {
                m_DistortionCalibBlock.Inputs["InputImage"].Value = img;
                m_DistortionCalibBlock.Run();
                if (m_DistortionCalibBlock.RunStatus.Result != CogToolResultConstants.Accept)
                {
                    LogHelper.Error($"畸变校正块运行输出非可接受结果:{m_DistortionCalibBlock.RunStatus.Message}");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("畸变校正块出现异常", ex);
                return false;
            }
        }
        /// <summary>
        /// 运行九点线性标定模块
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunLinearCalibBlock(eLinearCalib_Step step, eLinearCalib_Link type = eLinearCalib_Link.useless, ICogImage img = null)
        {
            if (step == eLinearCalib_Step.clear)
            {
                if (type == eLinearCalib_Link.useless)
                {
                    LogHelper.Error($"代码块异常：当前{step.ToString()}的对象枚举不能为{type.ToString()}");
                    return false;
                }
                if (MessageBox.Show($"将要清除{type.ToString()}标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    m_LinearCalibBlock.Inputs["Index"].Value = (int)type;
                    m_LinearCalibBlock.Run();
                    return true;
                }
                return false;
            }
            else if (step == eLinearCalib_Step.FindCircle)
            {
                try
                {
                    if (img == null)
                    {
                        LogHelper.Error($"代码块异常：当前{step.ToString()}的输入图像不能为null");
                        return false;
                    }
                    m_LinearCalibBlock.Inputs["InputImage"].Value = img;
                    m_LinearCalibBlock.Inputs["Index"].Value = 4;
                    m_LinearCalibBlock.Inputs["DistortionTransform"].Value = DistortionTransform;
                    m_LinearCalibBlock.Run();
                    if (m_LinearCalibBlock.RunStatus.Result != CogToolResultConstants.Accept)
                    {
                        LogHelper.Error($"九点线性标定块运行输出非可接受结果:{m_LinearCalibBlock.RunStatus.Message}");
                        return false;
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    LogHelper.Error("九点线性标定块出现异常", ex);
                    MessageBox.Show(ex.Message);
                }
            }
            else if (step == eLinearCalib_Step.insert)
            {
                if (type == eLinearCalib_Link.useless)
                {
                    LogHelper.Error($"代码块异常：当前{step.ToString()}的对象枚举不能为{type.ToString()}");
                    return false;
                }
                m_LinearCalibBlock.Inputs["Index"].Value = type + 5;
                m_LinearCalibBlock.Run();
            }
            else if (step == eLinearCalib_Step.calculate)
            {
                if (type == eLinearCalib_Link.useless)
                {
                    LogHelper.Error($"代码块异常：当前{step.ToString()}的对象枚举不能为{type.ToString()}");
                    return false;
                }
                m_LinearCalibBlock.Inputs["Index"].Value = type + 9;
                m_LinearCalibBlock.Run();
            }
            return false;
        }
        /// <summary>
        /// 运行旋转中心标定模块(功能未完善，结构未优化，后续使用需继续开发)
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
        /// 运行标定验证模块
        /// </summary>
        /// <param name="img"></param>
        /// <param name="calibimg"></param>
        /// <returns></returns>
        public bool RunVerificatecalibBlock(ref ICogImage img, eLinearCalib_Link type)
        {
            try
            {
                VerificatecalibBlock.Inputs["InputImage"].Value = img;
                if (type == eLinearCalib_Link.Robot1)
                {
                    VerificatecalibBlock.Inputs["LinearTransform"].Value = LinearTransform;
                }
                else if (type == eLinearCalib_Link.Robot2)
                {
                    VerificatecalibBlock.Inputs["LinearTransform"].Value = LinearTransform1;
                }
                else
                {
                    LogHelper.Error($"代码块异常：当前标定验证的对象枚举不能为{type.ToString()}");
                    return false;
                }
                VerificatecalibBlock.Run();
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
        /// 运行处理模块
        /// </summary>
        /// <param name="e"></param>
        /// <param name="img"></param>
        /// <returns></returns>
        public bool RunProcessBlock(ref ICogImage img, out string mError)
        {
            try
            {
                m_ProcessBlock.Inputs["InputImage"].Value = img;
                if (!calibflag)
                {                     
                    LogHelper.Error("当前处理模块未加载标定结果，无法运行");
                    mError = "当前处理模块未加载标定结果，无法运行";
                    return false;
                }
                else
                {
                    m_ProcessBlock.Inputs["DistortionTransform"].Value = DistortionTransform;
                    m_ProcessBlock.Inputs["LinearTransformBo"].Value = LinearTransform;
                    m_ProcessBlock.Inputs["LinearTransformBo2"].Value = LinearTransform1;
                    m_ProcessBlock.Inputs["LinearTransformLa"].Value = LinearTransform2;
                    m_ProcessBlock.Inputs["LinearTransformLa2"].Value = LinearTransform3;
                }
                m_ProcessBlock.Run();
                //此流程CogToolResultConstants具有三态，Accept,Reject,Error
                if (m_ProcessBlock.RunStatus.Result != CogToolResultConstants.Accept)
                {
                    LogHelper.Error($"运行处理模块运行输出非可接受结果:{m_ProcessBlock.RunStatus.Message}");
                    mError = m_ProcessBlock.RunStatus.Message;
                    return false;
                }
                mError = "";
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.Error("运行处理模块工具出现异常", ex);
                MessageBox.Show(ex.Message);
                mError = ex.Message;
            }
            return false;
        }
        /// <summary>
        /// 刷新界面显示
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="bAccquire"></param>  是否刷新取向
        /// <returns></returns>
        public bool UpdateGraphicResult(CogRecordsDisplay _cd)
        {
            bool _result;
            _result = (bool)_cd.Invoke(new Func<bool>(() =>
            {
                try
                {
                    ICogRecord r = null;
                    _cd.Display.Image = null;
                    _cd.Display.InteractiveGraphics.Clear();
                    _cd.Display.StaticGraphics.Clear();
                    //流程运行失败只展示相机取像结果
                    if (ProcessBlock.RunStatus.Result == CogToolResultConstants.Error)
                    {
                        r = m_AcquireBlock.CreateLastRunRecord();
                        _cd.Subject = r.SubRecords["图像算法处理.OutputImage"];
                    }
                    else
                    {
                        r = ProcessBlock.CreateLastRunRecord();
                        _cd.Subject = r.SubRecords["图像算法处理*.OutputImage"];
                    }
                    _cd.Display.Fit(false);
                    _cd.Display.BackColor = Color.Black;
                    _cd.Display.GridColor = Color.Black;//网格颜色
                    return true;
                }
                catch (Exception ex)
                {
                    LogHelper.Error($"跨线程更新Record控件失败:", ex);
                    return false;
                }
            }));
            return _result;
        }

        //窗体显示文字信息
        public static void DisplayLabelCogDisplay(CogRecordsDisplay mydisplay, CogColorConstants Color, Single x, Single y, string text, Int16 fontSize = 15)
        {
            // 定义实际执行的操作
            void AddLabel()
            {
                try
                {
                    mydisplay.Invoke((MethodInvoker)delegate
                    {
                        CogGraphicLabel GraphicLabel = new CogGraphicLabel();
                        GraphicLabel.SetXYText(fontSize * x, fontSize * y, text);
                        Font font = new Font("微软雅黑", fontSize, FontStyle.Bold);
                        GraphicLabel.Font = font;
                        GraphicLabel.Alignment = CogGraphicLabelAlignmentConstants.TopLeft;
                        GraphicLabel.SelectedSpaceName = mydisplay.Display.UserDisplayTree.RootName;
                        GraphicLabel.Color = Color;
                        mydisplay.Display.InteractiveGraphics.Add(GraphicLabel, "me", true);
                    });
                }
                catch (Exception ex)
                {
                    LogHelper.Error("Label加载异常", ex);
                }
            }

            // 线程安全调用
            if (mydisplay.InvokeRequired)
            {
                mydisplay.Invoke(new Action(AddLabel));
            }
            else
            {
                AddLabel(); // 直接调用，无需锁或Action.Invoke()
            }
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
