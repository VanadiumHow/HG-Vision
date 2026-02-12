using BaseThread;
using Cognex.VisionPro;
using HG_Vision.Contol.Control_PLC;
using HG_Vision.Contol.Control_Socket;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Model.EnumModel;
using Model.UIModel;
using Model.VisionModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using Obj.Obj_Queue;
using Obj.Utility;
using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class CameraWorkThrad1 : Control_Thread
    {
        private BlockQueue<TriggerEventArgs> _taskQueueList;//相机触发队列集合
        internal BlockQueue<TriggerEventArgs> TaskQueueListC1
        {
            set { _taskQueueList = value; }
        }
        private string _someData;

        // 定义事件，使用标准的EventHandler委托
        public event EventHandler<string> DataChanged;

        public string SomeData
        {
            get { return _someData; }
            set
            {
                if (_someData != value)
                {
                    _someData = value;
                    // 当数据改变时，触发事件
                    OnDataChanged(value);
                }
            }
        }

        // 触发事件的方法
        protected virtual void OnDataChanged(string newData)
        {
            DataChanged?.Invoke(this, newData);
        }
        public override void Initialize() => base.Start(10, "CameraWorkThread1");

        public override void Deinitialize() => base.Stop();
        protected override void Run()
        {
            try
            {
                DoWorkThreadC1();
            }
            catch (Exception ex)
            {
                LogHelper.Error("相机1工作线程出现异常", ex);  //写日志 
            }
        }
        private void DoWorkThreadC1()
        {
            TriggerEventArgs e = null;
            //从队列中取出数据
            if (!_taskQueueList.IsCompleted)
                e = _taskQueueList.Dequeue();
            //防呆设计，确保取出的任务非null并且是本线程的
            if (e == null && e.FlowIdx != 0)
            {
                LogHelper.Error("相机1工作线程收到非本线程任务！");
                return;
            }
            VisionProcess(e);
        }
        internal static void VisionProcess(TriggerEventArgs e)
        {
            //最终偏移量 = 当前位置 - 基准位置 + 对位补偿 + 夹具补偿
            try
            {
                //相机序号&吸嘴数量(振镜位置)
                int workFlowIdx = e.FlowIdx;
                //int nozzleIdx = e.NozzleIdx;

                //取像失败重试一次
                int acqRetriesNum = 2;
                bool acqOK = false;

                bool processOK = false;

                bool finalResult = false;

                ICogImage img = null;

                BasePose currentPose = new BasePose();
                BasePose stdPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose;
                BasePose addPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose;
                JigAdd[] jig_Compensations = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations;
                BasePose offset_dis_jig = new BasePose();
                JigAdd offset_in_jig = new JigAdd();

                double AddLengthAl = 0.00;
                double AddLengthNi = 0.00;

                #region 相机取像
                Stopwatch watch1 = new Stopwatch();//计算取像耗时
                Stopwatch watch2 = new Stopwatch();//计算流程耗时
                watch1.Reset();
                watch1.Start();


                for (int attempt = 1; attempt <= acqRetriesNum; attempt++)
                {
                    if (e.InputImage == null)
                        acqOK = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].RunAcquireBlock(out img);
                    else
                    {
                        img = e.InputImage;
                        e.InputImage = null;
                        acqOK = true;
                    }
                    if (acqOK)
                        break;
                }
                watch1.Stop();
                if (!acqOK)
                {
                    LogHelper.Error($"相机取像失败，工作流索引：{workFlowIdx}。共尝试{acqRetriesNum}次");
                    return;
                }

                var mSeconds1 = watch1.ElapsedMilliseconds;
                #endregion
                watch2.Reset();
                watch2.Start();
                Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Inputs["NozzleIdx"].Value = e.NozzleIdx;
                processOK = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].RunProcessBlock(ref img, out string mError);
                //获取不了相机工具运行结果
                if (!Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].UpdateGraphicResult(GlobalCameraParams.cameraVisionControlList[workFlowIdx]))
                {
                    LogHelper.Error($"{workFlowIdx + 1}相机跨线程更新Record控件失败！");  //写日志
                    WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 0, 0, "显示图像失败", 60);
                    if (e.eMode == eProcessMode.produce)
                    {
                        SendMessageToDevice(false, e.NozzleIdx, new JigAdd(), new BasePose());
                        Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]++;
                    }
                    return;
                }
                int _jigIndex = -1;
                string _code1 = "", _code2 = "";
                double _spacing1 = 0.00, _spacing2 = 0.00;
                if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType == eProtocol.LYH.ToString())
                {
                    //读取PLC寄存器中：夹具号、产品条码、极耳间距
                    if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
                    {
                        byte[] _plcD100_45 = Project.Instance.PLCManagerInstance.Read("D100", 45);
                        if (_plcD100_45 != null)
                        {
                            _jigIndex = BitConverter.ToInt16(RegisterDataProcessing.ReverseBytes(_plcD100_45, 0, 2), 0);
                            _code1 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD100_45, 2, 40))).Trim().Replace(":", "-");
                            _code2 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD100_45, 42, 40))).Trim().Replace(":", "-");
                            _spacing1 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD100_45, 82, 4), 0);
                            _spacing2 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD100_45, 86, 4), 0);
                        }
                        // PLC无法自动清除旧数据，需手动生成40个空格的字符串
                        if (e.eMode == eProcessMode.produce)
                        {
                            byte[] aZero = new byte[40];
                            Project.Instance.PLCManagerInstance.Write("D101", aZero);
                        }
                    }
                    else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
                    {
                        _jigIndex = Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData.JigIndex;
                        _code1 = Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData.Code1;
                        _code2 = Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData.Code2;
                        _spacing1 = Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData.Spaing1;
                        _spacing2 = Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData.Spaing2;
                        if (e.eMode == eProcessMode.produce)
                        {
                            Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").PLCData = new PLCDataTempModel();
                        }
                    }
                }
                else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType == eProtocol.HG.ToString())
                {
                    //读取PLC寄存器中：夹具号、产品条码、极耳间距
                    //plc发来的夹具号是从1开始的，这里要减1作为数组下标使用
                    //_jigIndex = BitConverter.ToInt16(Project.Instance.PLCManagerInstance.Read("D550", 1), 0) - 1;
                    //byte[] _plcD5000_100 = Project.Instance.PLCManagerInstance.Read("D5000", 100);
                    //byte[] _plcD5100_100 = Project.Instance.PLCManagerInstance.Read("D5100", 100);
                    //_code1 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD5000_100, 0, 160))).Trim().Replace(":", "-");
                    //_code2 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD5100_100, 0, 160))).Trim().Replace(":", "-");
                    //byte[] _plcD1100_4 = Project.Instance.PLCManagerInstance.Read("D1100", 4);
                    //_spacing1 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD1100_4, 0, 4), 0);
                    //_spacing2 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD1100_4, 4, 4), 0);

                    //plc发来的夹具号是从1开始的，这里要减1作为数组下标使用
                    _jigIndex = Project.Instance.PLCManagerInstance.ReadInt16("D550") - 1;
                    _code1 = Project.Instance.PLCManagerInstance.ReadString("D5000", 100);
                    if (_code1 == "")
                        _code1 = "null";
                    _code2 = Project.Instance.PLCManagerInstance.ReadString("D5100", 100);
                    if (_code2 == "")
                        _code2 = "null";
                    _spacing1 = Project.Instance.PLCManagerInstance.ReadFloat("D1100");
                    _spacing2 = Project.Instance.PLCManagerInstance.ReadFloat("D1102");
                    // PLC无法自动清除旧数据，需手动生成40个空格的字符串 (暂未实现，优先让PLC程序实现)
                    //if (e.eMode == eProcessMode.produce)
                    //{
                    //    byte[] aZero = new byte[40];
                    //    Project.Instance.PLCManagerInstance.Write("D101", aZero);
                    //}
                }
                else
                {
                    LogHelper.Error("未知协议类型，无法读取PLC数据！");
                    return;
                }
                if (e.NozzleIdx.Equals(0))
                {
                    try
                    {
                        if (!processOK)
                        {
                            LogHelper.Error($"{workFlowIdx + 1}相机视觉流程运行失败！");
                            processOK = false;
                            finalResult = false;
                        }
                        else
                        {
                            LogHelper.Info($"{workFlowIdx + 1}相机视觉流程运行成功！");
                            #region 读取vpp上的ResultArr
                            double[] ResultArrBo = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrBo"].Value;
                            double[] ResultArrLa = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrLa"].Value;
                            #endregion
                            #region 当前pos
                            currentPose.Bo1Axis.X = ResultArrBo[0];
                            currentPose.Bo1Axis.Y = ResultArrBo[1];
                            currentPose.La1Axis.X = ResultArrLa[0];
                            currentPose.La1Axis.Y = ResultArrLa[1];

                            //角度R不参与补偿
                            currentPose.Bo1Axis.R = ResultArrBo[2];

                            //补偿结果            =     当前位置    -    标准位置       +      固定对位补偿
                            offset_dis_jig.Bo1Axis.X = currentPose.Bo1Axis.X - stdPose.Bo1Axis.X + addPose.Bo1Axis.X;
                            offset_dis_jig.Bo1Axis.Y = currentPose.Bo1Axis.Y - stdPose.Bo1Axis.Y + addPose.Bo1Axis.Y;
                            offset_dis_jig.La1Axis.X = currentPose.La1Axis.X - stdPose.La1Axis.X + addPose.La1Axis.X;
                            offset_dis_jig.La1Axis.Y = currentPose.La1Axis.Y - stdPose.La1Axis.Y + addPose.La1Axis.Y;

                            offset_dis_jig.Bo1Axis.R = currentPose.Bo1Axis.R;

                            #endregion
                            #region 根据夹具号来分别额外补偿
                            offset_in_jig.Bo1Axis = new PointAxis { X = offset_dis_jig.Bo1Axis.X, Y = offset_dis_jig.Bo1Axis.Y, R = offset_dis_jig.Bo1Axis.R };
                            offset_in_jig.L_La1Axis[0] = new PointAxis { X = offset_dis_jig.La1Axis.X, Y = offset_dis_jig.La1Axis.Y, R = offset_dis_jig.La1Axis.R };
                            offset_in_jig.L_La1Axis[1] = new PointAxis { X = offset_dis_jig.La1Axis.X, Y = offset_dis_jig.La1Axis.Y, R = offset_dis_jig.La1Axis.R };
                            offset_in_jig.L_La1Axis[2] = new PointAxis { X = offset_dis_jig.La1Axis.X, Y = offset_dis_jig.La1Axis.Y, R = offset_dis_jig.La1Axis.R };
                            offset_in_jig.L_La1Axis[3] = new PointAxis { X = offset_dis_jig.La1Axis.X, Y = offset_dis_jig.La1Axis.Y, R = offset_dis_jig.La1Axis.R };
                            //如果夹具号不在设定范围内，则不进行夹具补偿
                            if (_jigIndex < 0 || _jigIndex >= jig_Compensations.Length)
                            {
                                LogHelper.Info($"读取到的夹具号{_jigIndex + 1}为非设定值，本次流程不进行夹具补偿");
                            }
                            else
                            {
                                offset_in_jig.Bo1Axis.X += jig_Compensations[_jigIndex].Bo1Axis.X;
                                offset_in_jig.Bo1Axis.Y += jig_Compensations[_jigIndex].Bo1Axis.Y;

                                offset_in_jig.L_La1Axis[0].X += jig_Compensations[_jigIndex].L_La1Axis[0].X;
                                offset_in_jig.L_La1Axis[1].X += jig_Compensations[_jigIndex].L_La1Axis[1].X;
                                offset_in_jig.L_La1Axis[2].X += jig_Compensations[_jigIndex].L_La1Axis[2].X;
                                offset_in_jig.L_La1Axis[3].X += jig_Compensations[_jigIndex].L_La1Axis[3].X;
                                offset_in_jig.L_La1Axis[0].Y += jig_Compensations[_jigIndex].L_La1Axis[0].Y;
                                offset_in_jig.L_La1Axis[1].Y += jig_Compensations[_jigIndex].L_La1Axis[1].Y;
                                offset_in_jig.L_La1Axis[2].Y += jig_Compensations[_jigIndex].L_La1Axis[2].Y;
                                offset_in_jig.L_La1Axis[3].Y += jig_Compensations[_jigIndex].L_La1Axis[3].Y;
                            }
                            offset_in_jig.Bo1Axis.R = offset_dis_jig.Bo1Axis.R;
                            #endregion
                            #region 极耳间距补偿
                            if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.SpacingUse == 1)
                            {
                                double spacingOffset = Math.Round(_spacing1 - Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Spacing, 3);
                                offset_in_jig.L_La1Axis[2].X += spacingOffset;
                                offset_in_jig.L_La1Axis[3].X += spacingOffset;
                            }
                            #endregion
                            finalResult = true;
                        }
                        #region 偏移上下限判断
                        double bolimitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoLimitMax;
                        double bolimitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoLimitMin;
                        double lalimitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaLimitMax;
                        double lalimitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaLimitMin;
                        double angleMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax;
                        double angleMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin;
                        bool isOutLimit = false;

                        string NG_message = "";
                        //机械手X/Y
                        if (offset_in_jig.Bo1Axis.X < bolimitMin || offset_in_jig.Bo1Axis.X > bolimitMax)
                        {
                            isOutLimit = true;
                            NG_message += "机械手偏移X超限NG;";
                            finalResult = false;
                        }
                        if (offset_in_jig.Bo1Axis.Y < bolimitMin || offset_in_jig.Bo1Axis.Y > bolimitMax)
                        {
                            isOutLimit = true;
                            NG_message += "机械手偏移Y超限NG;";
                            finalResult = false;
                        }
                        //激光X/Y
                        for (int i = 0; i < 4; i++)
                        {
                            if (offset_in_jig.L_La1Axis[i].X < lalimitMin || offset_in_jig.L_La1Axis[i].X > lalimitMax)
                            {
                                isOutLimit = true;
                                NG_message += $"焊点{i + 1}偏移X超限NG;";
                                finalResult = false;
                            }
                            if (offset_in_jig.L_La1Axis[i].Y < lalimitMin || offset_in_jig.L_La1Axis[i].Y > lalimitMax)
                            {
                                isOutLimit = true;
                                NG_message += $"焊点{i + 1}偏移Y超限NG;";
                                finalResult = false;
                            }
                        }
                        //连接片R
                        if (offset_in_jig.Bo1Axis.R < angleMin || offset_in_jig.Bo1Axis.R > angleMax)
                        {
                            isOutLimit = true;
                            NG_message += "连接片角度R超限NG";
                            finalResult = false;
                        }
                        #endregion

                        #region 结果数据发送机器人、激光
                        if (e.eMode == eProcessMode.produce)
                        {
                            SendMessageToDevice(finalResult, 0, offset_in_jig, currentPose);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.WeldlengthAl = AddLengthAl + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdweldlengthAl;
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.WeldlengthNi = AddLengthNi + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdweldlengthNi;
                        }
                        else
                        {
                            if (processOK)
                            {
                                e.ResultOffset.Bo1Axis.X = currentPose.Bo1Axis.X;
                                e.ResultOffset.Bo1Axis.Y = currentPose.Bo1Axis.Y;
                                e.ResultOffset.Bo1Axis.R = currentPose.Bo1Axis.R;

                                e.ResultOffset.La1Axis.X = currentPose.La1Axis.X;
                                e.ResultOffset.La1Axis.Y = currentPose.La1Axis.Y;
                                e.ResultOffset.La1Axis.R = currentPose.La1Axis.R;
                            }
                            else
                            {
                                e.ResultOffset.Bo1Axis = null;
                                e.ResultOffset.La1Axis = null;
                            }
                        }
                        #endregion
                        watch2.Stop();
                        var mSeconds2 = watch2.ElapsedMilliseconds;
                        var totalTime = mSeconds1 + mSeconds2;
                        //显示界面:
                        Int16 fontSize = 15;
                        string nowTime = DateTime.Now.ToString("HH:mm:ss");
                        CogColorConstants Color = processOK ? CogColorConstants.Green : CogColorConstants.Red;
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], Color, 1, 0, "工位号:" + "1(面朝屏幕左手端)" + string.Format("{0}", finalResult ? "OK" : "NG"), fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 2, "夹具号:" + (_jigIndex + 1), fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 4, $"电池条码:{_code1}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 6, $"极耳间距:{_spacing1:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 8, $"取像耗时:{mSeconds1:f2}ms", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 10, $"视觉总耗时:{totalTime:f2}ms", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 12, $"当前1产品位置 X:{currentPose.Bo1Axis.X:f3} Y:{currentPose.Bo1Axis.Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 14, $"机械手1偏移 X:{offset_dis_jig.Bo1Axis.X:f3} Y:{offset_dis_jig.Bo1Axis.Y:f3}(未进行夹具补偿)", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 16, $"焊点偏移 X:{offset_dis_jig.La1Axis.X:f3} Y:{offset_dis_jig.La1Axis.Y:f3}(未进行夹具补偿)", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 19, "-------以下为夹具补偿后X、Y(最终发送):-------", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 22, $"机械手1偏移 X:{offset_in_jig.Bo1Axis.X:f3} Y:{offset_in_jig.Bo1Axis.Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 24, $"焊点1偏移 X:{offset_in_jig.L_La1Axis[0].X:f3} Y:{offset_in_jig.L_La1Axis[0].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 26, $"焊点2偏移 X:{offset_in_jig.L_La1Axis[1].X:f3} Y:{offset_in_jig.L_La1Axis[1].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 28, $"焊点3偏移 X:{offset_in_jig.L_La1Axis[2].X:f3} Y:{offset_in_jig.L_La1Axis[2].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 30, $"焊点4偏移 X:{offset_in_jig.L_La1Axis[3].X:f3} Y:{offset_in_jig.L_La1Axis[3].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 32, $"连接片角度:{offset_in_jig.Bo1Axis.R:f3}°", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 34, nowTime, fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 1, 36, mError, fontSize);
                        if (isOutLimit == true)
                            WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 1, 40, NG_message, fontSize);
                        #region 保存生产数据csv文件
                        string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                        string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,弹夹角度,极耳间距,条码,时间";
                        File_CSV csv = new File_CSV();
                        strLogData[0] = finalResult.ToString();
                        strLogData[1] = "1";
                        strLogData[2] = (_jigIndex + 1).ToString();
                        strLogData[3] = offset_in_jig.Bo1Axis.X.ToString("f3");
                        strLogData[4] = offset_in_jig.Bo1Axis.Y.ToString("f3");
                        strLogData[5] = offset_in_jig.L_La1Axis[0].X.ToString("f3");
                        strLogData[6] = offset_in_jig.L_La1Axis[0].Y.ToString("f3");
                        strLogData[7] = offset_in_jig.L_La1Axis[1].X.ToString("f3");
                        strLogData[8] = offset_in_jig.L_La1Axis[1].Y.ToString("f3");
                        strLogData[9] = offset_in_jig.L_La1Axis[2].X.ToString("f3");
                        strLogData[10] = offset_in_jig.L_La1Axis[2].Y.ToString("f3");
                        strLogData[11] = offset_in_jig.L_La1Axis[3].X.ToString("f3");
                        strLogData[12] = offset_in_jig.L_La1Axis[3].Y.ToString("f3");
                        strLogData[13] = offset_in_jig.Bo1Axis.R.ToString("f3");
                        strLogData[14] = _spacing1.ToString("f3");
                        strLogData[15] = _code1;
                        strLogData[16] = nowTime;
                        csv.AppendToCsv(strHead, strLogData, "PositionData");
                        #endregion
                        //VP或者Halcon存图
                        e.DisplayObj = GlobalCameraParams.cameraVisionControlList[e.FlowIdx];
                        e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[e.FlowIdx].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                        if (e.eMode == eProcessMode.produce)
                            e.imageName = (e.FlowIdx + 1).ToString() + "-1-" + (_jigIndex + 1).ToString() + "-" + _code1;
                        else
                            e.imageName = (e.FlowIdx + 1).ToString() + "-1-" + e.eMode.ToString();
                        e.results = finalResult;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.FlowIdx].Enqueue(e);
                    }
                    catch (Exception ex)
                    {
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[e.FlowIdx], CogColorConstants.Red, 0, 0, $"工位{e.NozzleIdx}发生错误：{ex}", 15);
                    }
                }
                else
                {
                    try
                    {
                        if (!processOK)
                        {
                            LogHelper.Error($"{workFlowIdx + 1}相机视觉流程运行失败！");
                            processOK = false;
                            finalResult = false;
                        }
                        else
                        {
                            LogHelper.Info($"{workFlowIdx + 1}相机视觉流程运行成功！");
                            #region 读取vpp上的ResultArr
                            double[] ResultArrBo2 = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrBo"].Value;
                            double[] ResultArrLa2 = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrLa"].Value;
                            #endregion
                            #region 当前pos
                            currentPose.Bo2Axis.X = ResultArrBo2[0];
                            currentPose.Bo2Axis.Y = ResultArrBo2[1];
                            currentPose.La2Axis.X = ResultArrLa2[0];
                            currentPose.La2Axis.Y = ResultArrLa2[1];

                            //角度R不参与补偿
                            currentPose.Bo2Axis.R = ResultArrBo2[2];

                            //补偿结果            =     当前位置    -    标准位置       +      固定对位补偿
                            offset_dis_jig.Bo2Axis.X = currentPose.Bo2Axis.X - stdPose.Bo2Axis.X + addPose.Bo2Axis.X;
                            offset_dis_jig.Bo2Axis.Y = currentPose.Bo2Axis.Y - stdPose.Bo2Axis.Y + addPose.Bo2Axis.Y;
                            offset_dis_jig.La2Axis.X = currentPose.La2Axis.X - stdPose.La2Axis.X + addPose.La2Axis.X;
                            offset_dis_jig.La2Axis.Y = currentPose.La2Axis.Y - stdPose.La2Axis.Y + addPose.La2Axis.Y;

                            offset_dis_jig.Bo2Axis.R = currentPose.Bo2Axis.R;

                            #endregion
                            #region 根据夹具号来分别额外补偿
                            offset_in_jig.Bo2Axis = new PointAxis { X = offset_dis_jig.Bo2Axis.X, Y = offset_dis_jig.Bo2Axis.Y, R = offset_dis_jig.Bo2Axis.R };
                            offset_in_jig.L_La2Axis[0] = new PointAxis { X = offset_dis_jig.La2Axis.X, Y = offset_dis_jig.La2Axis.Y, R = offset_dis_jig.La2Axis.R };
                            offset_in_jig.L_La2Axis[1] = new PointAxis { X = offset_dis_jig.La2Axis.X, Y = offset_dis_jig.La2Axis.Y, R = offset_dis_jig.La2Axis.R };
                            offset_in_jig.L_La2Axis[2] = new PointAxis { X = offset_dis_jig.La2Axis.X, Y = offset_dis_jig.La2Axis.Y, R = offset_dis_jig.La2Axis.R };
                            offset_in_jig.L_La2Axis[3] = new PointAxis { X = offset_dis_jig.La2Axis.X, Y = offset_dis_jig.La2Axis.Y, R = offset_dis_jig.La2Axis.R };
                            //如果夹具号不在设定范围内，则不进行夹具补偿
                            if (_jigIndex < 0 || _jigIndex >= jig_Compensations.Length)
                            {
                                LogHelper.Info($"读取到的夹具号{_jigIndex + 1}为非设定值，本次流程不进行夹具补偿");
                            }
                            else
                            {
                                offset_in_jig.Bo2Axis.X += jig_Compensations[_jigIndex].Bo2Axis.X;
                                offset_in_jig.Bo2Axis.Y += jig_Compensations[_jigIndex].Bo2Axis.Y;
                            
                                offset_in_jig.L_La1Axis[0].X += jig_Compensations[_jigIndex].L_La1Axis[0].X;
                                offset_in_jig.L_La1Axis[1].X += jig_Compensations[_jigIndex].L_La1Axis[1].X;
                                offset_in_jig.L_La1Axis[2].X += jig_Compensations[_jigIndex].L_La1Axis[2].X;
                                offset_in_jig.L_La1Axis[3].X += jig_Compensations[_jigIndex].L_La1Axis[3].X;
                                offset_in_jig.L_La1Axis[0].Y += jig_Compensations[_jigIndex].L_La1Axis[0].Y;
                                offset_in_jig.L_La1Axis[1].Y += jig_Compensations[_jigIndex].L_La1Axis[1].Y;
                                offset_in_jig.L_La1Axis[2].Y += jig_Compensations[_jigIndex].L_La1Axis[2].Y;
                                offset_in_jig.L_La1Axis[3].Y += jig_Compensations[_jigIndex].L_La1Axis[3].Y;
                            }
                            offset_in_jig.Bo2Axis.R = offset_dis_jig.Bo2Axis.R;
                            #endregion
                            #region 极耳间距补偿
                            if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.SpacingUse == 1)
                            {
                                double spacingOffset = Math.Round(_spacing2 - Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Spacing, 3);
                                offset_in_jig.L_La2Axis[2].X += spacingOffset;
                                offset_in_jig.L_La2Axis[3].X += spacingOffset;
                            }
                            #endregion
                            finalResult = true;
                        }
                        #region 偏移上下限判断
                        double bolimitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoLimitMax;
                        double bolimitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoLimitMin;
                        double lalimitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaLimitMax;
                        double lalimitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaLimitMin;
                        double angleMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax;
                        double angleMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin;
                        bool isOutLimit = false;

                        string NG_message = "";
                        //机械手X/Y
                        if (offset_in_jig.Bo2Axis.X < bolimitMin || offset_in_jig.Bo2Axis.X > bolimitMax)
                        {
                            isOutLimit = true;
                            NG_message += "机械手偏移X超限NG;";
                            finalResult = false;
                        }
                        if (offset_in_jig.Bo2Axis.Y < bolimitMin || offset_in_jig.Bo2Axis.Y > bolimitMax)
                        {
                            isOutLimit = true;
                            NG_message += "机械手偏移Y超限NG;";
                            finalResult = false;
                        }
                        //激光X/Y
                        for (int i = 0; i < 4; i++)
                        {
                            if (offset_in_jig.L_La2Axis[i].X < lalimitMin || offset_in_jig.L_La2Axis[i].X > lalimitMax)
                            {
                                isOutLimit = true;
                                NG_message += $"焊点{i + 1}偏移X超限NG;";
                                finalResult = false;
                            }
                            if (offset_in_jig.L_La2Axis[i].Y < lalimitMin || offset_in_jig.L_La2Axis[i].Y > lalimitMax)
                            {
                                isOutLimit = true;
                                NG_message += $"焊点{i + 1}偏移Y超限NG;";
                                finalResult = false;
                            }
                        }
                        //连接片R
                        if (offset_in_jig.Bo2Axis.R < angleMin || offset_in_jig.Bo2Axis.R > angleMax)
                        {
                            isOutLimit = true;
                            NG_message += "连接片角度R超限NG";
                            finalResult = false;
                        }
                        #endregion

                        #region 结果数据发送机器人、激光
                        if (e.eMode == eProcessMode.produce)
                        {
                            SendMessageToDevice(finalResult, 1, offset_in_jig, currentPose);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.WeldlengthAl = AddLengthAl + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdweldlengthAl;
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.WeldlengthNi = AddLengthNi + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdweldlengthNi;
                        }
                        else
                        {
                            if (processOK)
                            {
                                e.ResultOffset.Bo2Axis.X = currentPose.Bo2Axis.X;
                                e.ResultOffset.Bo2Axis.Y = currentPose.Bo2Axis.Y;
                                e.ResultOffset.Bo2Axis.R = currentPose.Bo2Axis.R;

                                e.ResultOffset.La2Axis.X = currentPose.La2Axis.X;
                                e.ResultOffset.La2Axis.Y = currentPose.La2Axis.Y;
                                e.ResultOffset.La2Axis.R = currentPose.La2Axis.R;
                            }
                            else
                            {
                                e.ResultOffset.Bo2Axis = null;
                                e.ResultOffset.La2Axis = null;
                            }
                        }
                        #endregion
                        watch2.Stop();
                        var mSeconds2 = watch2.ElapsedMilliseconds;
                        var totalTime = mSeconds1 + mSeconds2;
                        //显示界面:
                        Int16 fontSize = 15;
                        string nowTime = DateTime.Now.ToString("HH:mm:ss");
                        CogColorConstants Color = processOK ? CogColorConstants.Green : CogColorConstants.Red;
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], Color, 1, 0, "工位号:" + "2(面朝屏幕左手端)" + string.Format("{0}", finalResult ? "OK" : "NG"), fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 2, "夹具号:" + (_jigIndex + 1), fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 4, $"电池条码:{_code2}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 6, $"极耳间距:{_spacing2:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 8, $"取像耗时:{mSeconds1:f2}ms", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 10, $"视觉总耗时:{totalTime:f2}ms", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 12, $"当前2产品位置 X:{currentPose.Bo2Axis.X:f3} Y:{currentPose.Bo2Axis.Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 14, $"机械手2偏移 X:{offset_dis_jig.Bo2Axis.X:f3} Y:{offset_dis_jig.Bo2Axis.Y:f3}(未进行夹具补偿)", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 16, $"焊点偏移 X:{offset_dis_jig.La2Axis.X:f3} Y:{offset_dis_jig.La2Axis.Y:f3}(未进行夹具补偿)", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 19, "-------以下为夹具补偿后X、Y(最终发送):-------", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 22, $"机械手2偏移 X:{offset_in_jig.Bo2Axis.X:f3} Y:{offset_in_jig.Bo2Axis.Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 24, $"焊点1偏移 X:{offset_in_jig.L_La2Axis[0].X:f3} Y:{offset_in_jig.L_La2Axis[0].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 26, $"焊点2偏移 X:{offset_in_jig.L_La2Axis[1].X:f3} Y:{offset_in_jig.L_La2Axis[1].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 28, $"焊点3偏移 X:{offset_in_jig.L_La2Axis[2].X:f3} Y:{offset_in_jig.L_La2Axis[2].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 30, $"焊点4偏移 X:{offset_in_jig.L_La2Axis[3].X:f3} Y:{offset_in_jig.L_La2Axis[3].Y:f3}", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 32, $"连接片角度:{offset_in_jig.Bo2Axis.R:f3}°", fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 1, 34, nowTime, fontSize);
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 1, 36, mError, fontSize);
                        if (isOutLimit == true)
                            WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 1, 40, NG_message, fontSize);
                        #region 保存生产数据csv文件
                        string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                        string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,弹夹角度,极耳间距,条码,时间";
                        File_CSV csv = new File_CSV();
                        strLogData[0] = finalResult.ToString();
                        strLogData[1] = "2";
                        strLogData[2] = (_jigIndex + 1).ToString();
                        strLogData[3] = offset_in_jig.Bo2Axis.X.ToString("f3");
                        strLogData[4] = offset_in_jig.Bo2Axis.Y.ToString("f3");
                        strLogData[5] = offset_in_jig.L_La2Axis[0].X.ToString("f3");
                        strLogData[6] = offset_in_jig.L_La2Axis[0].Y.ToString("f3");
                        strLogData[7] = offset_in_jig.L_La2Axis[1].X.ToString("f3");
                        strLogData[8] = offset_in_jig.L_La2Axis[1].Y.ToString("f3");
                        strLogData[9] = offset_in_jig.L_La2Axis[2].X.ToString("f3");
                        strLogData[10] = offset_in_jig.L_La2Axis[2].Y.ToString("f3");
                        strLogData[11] = offset_in_jig.L_La2Axis[3].X.ToString("f3");
                        strLogData[12] = offset_in_jig.L_La2Axis[3].Y.ToString("f3");
                        strLogData[13] = offset_in_jig.Bo2Axis.R.ToString("f3");
                        strLogData[14] = _spacing2.ToString("f3");
                        strLogData[15] = _code2;
                        strLogData[16] = nowTime;
                        csv.AppendToCsv(strHead, strLogData, "PositionData");
                        #endregion
                        //VP或者Halcon存图
                        e.DisplayObj = GlobalCameraParams.cameraVisionControlList[e.FlowIdx];
                        e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[e.FlowIdx].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                        if (e.eMode == eProcessMode.produce)
                            e.imageName = (e.FlowIdx + 1).ToString() + "-2-" + (_jigIndex + 1).ToString() + "-" + _code2;
                        else
                            e.imageName = (e.FlowIdx + 1).ToString() + "-2-" + e.eMode.ToString();
                        e.results = finalResult;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.FlowIdx].Enqueue(e);
                    }
                    catch (Exception ex)
                    {
                        WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[e.FlowIdx], CogColorConstants.Red, 0, 0, $"工位{e.NozzleIdx}发生错误：{ex}", 15);
                    }
                }
                //良率统计
                Action act = () =>
                {
                    NoticeHelper.UpdateYieldTableMessageSend(DeviceStatisticsModels.XCCD, e.FlowIdx);
                    NoticeHelper.UpdateCapaticyChartMessageSend(0);
                };
                act.TryCatch($"相机{e.FlowIdx + 1}重新刷新良率统计出现异常！");
            }
            catch (Exception ex)
            {
                LogHelper.Error($"处理{e.FlowIdx + 1}相机检测出现异常", ex);  //写日志
            }
        }
        /// <summary>
        /// 发送数据到设备(机器人、激光)
        /// </summary>
        /// <param name="isOK">视觉总结果</param>
        /// <param name="index">工位号</param>
        /// <param name="offset_in_jig">补偿后偏移量</param>
        /// <param name="currentPose">当前位置</param>
        private static void SendMessageToDevice(bool isOK, int index, JigAdd offset_in_jig, BasePose currentPose)
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType == eProtocol.LYH.ToString())
            {
                string sendToRob;
                #region 设定机械手偏移量字符串
                if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse != 1)
                    sendToRob = "1;0.0;0.0;";
                else
                    sendToRob = $"{(isOK ? 1 : 2)};{currentPose.GetBoAxis(index).X:f3};{currentPose.GetBoAxis(index).Y:f3};";
                #endregion

                #region 缓存机械手偏移量字符串

                Project.Instance.ServerManagerInstance.GetDevice<RobotServerObj>($"Robot{index}").SaveRobotOffsetData(sendToRob);
                #endregion
            }
            else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType == eProtocol.HG.ToString())
            {
                byte[] sendToPLC = new byte[16];

                #region 设定机械手偏移量按Omron寄存器数量装箱
                if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse == 1)
                {
                    float x = Convert.ToSingle(offset_in_jig.GetBoAxis(index).X);
                    byte[] xBytes = BitConverter.GetBytes(x);
                    Array.Copy(xBytes, sendToPLC, xBytes.Length);
                    float y = Convert.ToSingle(offset_in_jig.GetBoAxis(index).Y);
                    byte[] yBytes = BitConverter.GetBytes(y);
                    // 从源数组复制到目标数组的后面
                    Array.Copy(yBytes, 0, sendToPLC, xBytes.Length, yBytes.Length);
                }
                #endregion

                #region 发送机械手偏移量给PLC(Fins通讯)
                if (index == 0)
                {
                    if (Project.Instance.PLCManagerInstance.Write("D2100", RegisterDataProcessing.ReverseBytes(sendToPLC, 0, sendToPLC.Length)))
                        LogHelper.Info("发送偏移量数据成功>>PLC!");
                    else
                        LogHelper.Error("发送偏移量数据失败>>PLC!");
                }
                if (index == 1)
                {
                    if (Project.Instance.PLCManagerInstance.Write("D2106", RegisterDataProcessing.ReverseBytes(sendToPLC, 0, sendToPLC.Length)))
                        LogHelper.Info("发送偏移量数据成功>>PLC!");
                    else
                        LogHelper.Error("发送偏移量数据失败>>PLC!");
                }

                if (isOK)
                    if (Project.Instance.PLCManagerInstance.WriteInt("D750", 1))
                        LogHelper.Info("发送OK信号成功>>PLC!");
                    else
                        LogHelper.Error("发送OK信号失败>>PLC!");
                else
                {
                    if (Project.Instance.PLCManagerInstance.WriteInt("D750", 2))
                        LogHelper.Info("发送NG信号成功>>PLC!");
                    else
                        LogHelper.Error("发送NG信号失败>>PLC!");
                }
                #endregion
            }
            else
            {
                LogHelper.Error("未知协议类型，无法发送视觉数据！");
                return;
            }

            string sendToLas;

            #region 设定激光偏移量字符串
            if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse != 1)
            {
                sendToLas = "_OK;" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10";
            }
            else
            {
                if (!isOK)
                {
                    sendToLas = CreatSentToLas(false, currentPose, offset_in_jig, index);
                    Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]++;
                }
                else
                {
                    sendToLas = CreatSentToLas(true, currentPose, offset_in_jig, index);
                    Project.Instance.ProductionDataManagerInstance.L_ProduceStationOKCount[0]++;
                }
            }
            #endregion

            #region 发送激光偏移量字符串
            if (Project.Instance.ServerManagerInstance.GetDevice<LaserServerObj>($"Laser{0}").SendText(sendToLas, 0))
                LogHelper.Info("发送完成信号成功>>激光：" + sendToLas);
            else
                LogHelper.Error("发送完成信号失败>>激光!");
            #endregion
        }
        private static string CreatSentToLas(bool isOK, BasePose currentPose, JigAdd in_offset, int LaserIdx)
        {
            string sendToLas;
            if (isOK)
                sendToLas = "_OK;";
            else
                sendToLas = "_NG;";

            if (LaserIdx == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    sendToLas += $"{in_offset.L_La1Axis[i].X:f3}%{in_offset.L_La1Axis[i].Y:f3}%0.000%{currentPose.La1Axis.X}%{currentPose.La1Axis.Y}%10%10%10#";
                }
            }
            else if (LaserIdx == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    sendToLas += $"{in_offset.L_La2Axis[i].X:f3}%{in_offset.L_La2Axis[i].Y:f3}%0.000%{currentPose.La2Axis.X}%{currentPose.La2Axis.Y}%10%10%10#";
                }
            }
            else
            {
                LogHelper.Error($"CreatSentToLas方法中的形参LaserIdx输入非可接受类型");
            }
            sendToLas = sendToLas.Remove(sendToLas.Length - 1); //去掉最后一个#
            return sendToLas;
        }
    }
}
