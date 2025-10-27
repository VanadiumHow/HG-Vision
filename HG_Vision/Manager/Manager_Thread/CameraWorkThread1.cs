using BaseThread;
using Cognex.VisionPro;
using HG_Vision.Contol.Control_PLC;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_Process;
using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Model.EnumModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using Obj.Obj_Queue;
using Obj.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;

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

				#region 相机取像
				Stopwatch watch1 = new Stopwatch();//计算取像耗时
				Stopwatch watch2 = new Stopwatch();//计算流程耗时
				watch1.Reset();
				watch1.Start();


				for (int attempt = 1; attempt <= acqRetriesNum; attempt++)
				{
					acqOK = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].RunAcquireBlock(out img);
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
						if (e.NozzleIdx.Equals(0))
							Project.Instance.RobotManagerInstance.L_Robot[0].SendText(RobotSignalsModel.CCD1RobotResultNG, 0);//？信息内容待定
						else
							Project.Instance.RobotManagerInstance.L_Robot[1].SendText(RobotSignalsModel.CCD1RobotResultNG, 0);//？信息内容待定
						Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]++;
					}
					return;
				}
				//读取PLC寄存器中：夹具号、产品条码、极耳间距
				byte[] _plcD100_45 = Project.Instance.PLCManagerInstance.Read("D100", 45);
				//plc发来的夹具号是从1开始的，这里要减1作为数组下标使用
				int _jigIndex = BitConverter.ToInt16(RegisterDataProcessing.ReverseBytes(_plcD100_45, 0, 2), 0) - 1;
				string _code1 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD100_45, 2, 40))).Trim().Replace(":", "-");
				string _code2 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcD100_45, 42, 40))).Trim().Replace(":", "-");
				double _spacing1 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD100_45, 82, 4), 0);
				double _spacing2 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcD100_45, 86, 4), 0);

				if (e.NozzleIdx.Equals(0))
				{
					if (!processOK)
					{
						processOK = false;
						finalResult = false;
					}
					else
					{
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
						//如果夹具号不在设定范围内，则不进行夹具补偿
						if (_jigIndex < 0 || _jigIndex >= jig_Compensations.Length)
						{
							LogHelper.Info($"读取到的夹具号{_jigIndex + 1}为非设定值，本次流程不进行夹具补偿");
							offset_in_jig.Bo1Axis = offset_dis_jig.Bo1Axis;
							offset_in_jig.L_La1Axis[0] = offset_dis_jig.La1Axis;
							offset_in_jig.L_La1Axis[1] = offset_dis_jig.La1Axis;
							offset_in_jig.L_La1Axis[2] = offset_dis_jig.La1Axis;
							offset_in_jig.L_La1Axis[3] = offset_dis_jig.La1Axis;
						}
						else
						{
							offset_in_jig.Bo1Axis.X = offset_dis_jig.Bo1Axis.X + jig_Compensations[_jigIndex].Bo1Axis.X;
							offset_in_jig.Bo1Axis.Y = offset_dis_jig.Bo1Axis.Y + jig_Compensations[_jigIndex].Bo1Axis.Y;
							offset_in_jig.L_La1Axis[0].X = offset_dis_jig.La1Axis.X + jig_Compensations[_jigIndex].L_La1Axis[0].X;
							offset_in_jig.L_La1Axis[1].X = offset_dis_jig.La1Axis.X + jig_Compensations[_jigIndex].L_La1Axis[1].X;
							offset_in_jig.L_La1Axis[2].X = offset_dis_jig.La1Axis.X + jig_Compensations[_jigIndex].L_La1Axis[2].X;
							offset_in_jig.L_La1Axis[3].X = offset_dis_jig.La1Axis.X + jig_Compensations[_jigIndex].L_La1Axis[3].X;
							offset_in_jig.L_La1Axis[0].Y = offset_dis_jig.La1Axis.Y + jig_Compensations[_jigIndex].L_La1Axis[0].Y;
							offset_in_jig.L_La1Axis[1].Y = offset_dis_jig.La1Axis.Y + jig_Compensations[_jigIndex].L_La1Axis[1].Y;
							offset_in_jig.L_La1Axis[2].Y = offset_dis_jig.La1Axis.Y + jig_Compensations[_jigIndex].L_La1Axis[2].Y;
							offset_in_jig.L_La1Axis[3].Y = offset_dis_jig.La1Axis.Y + jig_Compensations[_jigIndex].L_La1Axis[3].Y;
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
					double limitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMax;
					double limitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMin;
					double angleMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax;
					double angleMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin;
					bool isOutLimit = false;

					string NG_message = "";
					//机械手X/Y
					if (offset_in_jig.Bo1Axis.X < limitMin || offset_in_jig.Bo1Axis.X > limitMax)
					{
						isOutLimit = true;
						NG_message += "机械手偏移X超限NG;";
						finalResult = false;
					}
					if (offset_in_jig.Bo1Axis.Y < limitMin || offset_in_jig.Bo1Axis.Y > limitMax)
					{
						isOutLimit = true;
						NG_message += "机械手偏移Y超限NG;";
						finalResult = false;
					}
					//激光X/Y
					for (int i = 0; i < 4; i++)
					{
						if (offset_in_jig.L_La1Axis[i].X < limitMin || offset_in_jig.L_La1Axis[i].X > limitMax)
						{
							isOutLimit = true;
							NG_message += $"焊点{i + 1}偏移X超限NG;";
							finalResult = false;
						}
						if (offset_in_jig.L_La1Axis[i].Y < limitMin || offset_in_jig.L_La1Axis[i].Y > limitMax)
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
						string sendToRob, sendToLas;
						if (!finalResult)
						{

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse != 1)
								sendToRob = "PGE;0;1;0;0;0;0;\r\n";
							else
								sendToRob = $"PGE;0;2;0;{offset_in_jig.Bo1Axis.X:f3};{offset_in_jig.Bo1Axis.X:f3};0;\r\n";

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse != 1)
								sendToLas = "_OK;" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10";
							else
								sendToLas = CreatSentToLas(false, currentPose, offset_in_jig, 0);
							Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]++;
						}
						else
						{

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse != 1)
								sendToRob = "PGE;0;1;0;0;0;0;\r\n";
							else
								sendToRob = $"PGE;0;1;0;{offset_in_jig.Bo1Axis.X:f3};{offset_in_jig.Bo1Axis:f3};0;\r\n";

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse != 1)
								sendToLas = "_OK;" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10";
							else
								sendToLas = CreatSentToLas(true, currentPose, offset_in_jig, 0);
							Project.Instance.ProductionDataManagerInstance.L_ProduceStationOKCount[0]++;
						}
						Project.Instance.RobotManagerInstance.L_Robot[0].SendText(sendToRob, 0);
						Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendToLas, 0);
						LogHelper.Info("给到机械手返回：" + sendToRob);
						NoticeHelper.OutputMessageSend("给到机械手返回" + sendToRob, OutputLevelModel.INFO);
					}
					else
					{
						if (finalResult)
						{
							e.ResultOffset.Bo1Axis.X = offset_dis_jig.Bo1Axis.X;
							e.ResultOffset.Bo1Axis.Y = offset_dis_jig.Bo1Axis.Y;
							e.ResultOffset.Bo1Axis.R = offset_dis_jig.Bo1Axis.R;

							e.ResultOffset.La1Axis.X = offset_dis_jig.La1Axis.X;
							e.ResultOffset.La1Axis.Y = offset_dis_jig.La1Axis.Y;
							e.ResultOffset.La1Axis.R = offset_dis_jig.La1Axis.R;
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
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], Color, 0, 0, "工位号:" + "1(面朝屏幕右手端)" + string.Format("{0}", finalResult ? "OK" : "NG"), fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 4, "夹具号:" + _jigIndex, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 6, $"取像耗时:{mSeconds1:f2}ms", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 8, $"视觉总耗时:{totalTime:f2}ms", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 10, "(以下为 夹具补偿后X: Y: / 夹具补偿前X: Y: )", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 12, $"机械手1偏移 X:{offset_in_jig.Bo1Axis.X:f3} Y:{offset_in_jig.Bo1Axis.Y:f3} / X:{offset_dis_jig.Bo1Axis.X} Y:{offset_dis_jig.Bo1Axis.Y}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 14, $"机械手1当前 X:{currentPose.Bo1Axis.X:f3} Y:{currentPose.Bo1Axis.Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 16, $"焊点1偏移 X:{offset_in_jig.L_La1Axis[0].X:f3} Y:{offset_in_jig.L_La1Axis[0].Y:f3} / X:{offset_dis_jig.La1Axis.X:f3} Y:{offset_dis_jig.La1Axis.Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 18, $"焊点2偏移 X:{offset_in_jig.L_La1Axis[1].X:f3} Y:{offset_in_jig.L_La1Axis[1].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 20, $"焊点3偏移 X:{offset_in_jig.L_La1Axis[2].X:f3} Y:{offset_in_jig.L_La1Axis[2].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 22, $"焊点4偏移 X:{offset_in_jig.L_La1Axis[3].X:f3} Y:{offset_in_jig.L_La1Axis[3].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 24, $"连接片角度:{offset_in_jig.Bo1Axis.R:f3}°", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 26, $"极耳间距:{_spacing1:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 28, "电池条码:" + _code1, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 30, nowTime, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 0, fontSize * 32, mError, fontSize);
					if (isOutLimit == true)
						WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 0, fontSize * 34, NG_message, fontSize);
					#region 保存生产数据csv文件
					string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,弹夹角度,极耳间距,条码,时间";
					File_CSV csv = new File_CSV();
					strLogData[0] = finalResult.ToString();
					strLogData[1] = "1";
					strLogData[2] = _jigIndex.ToString();
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
					strLogData[24] = _spacing1.ToString("f3");
					strLogData[15] = _code1;
					strLogData[16] = nowTime;
					csv.AppendToCsv(strHead, strLogData, "PositionData");
					#endregion
					//VP或者Halcon存图
					e.DisplayObj = GlobalCameraParams.cameraVisionControlList[e.FlowIdx];
					e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[e.FlowIdx].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
					if (e.eMode == eProcessMode.produce)
						e.imageName = (e.FlowIdx + 1).ToString() + "-1-" + _jigIndex.ToString() + "-" + _code1.ToString();
					else
						e.imageName = (e.FlowIdx + 1).ToString() + "-1-" + DateTime.Now.ToString("HH:mm:ss") + "-" + e.eMode.ToString();
					e.results = finalResult;
					Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.FlowIdx].Enqueue(e);
					// 生成40个空格的字符串
					if (e.eMode == eProcessMode.produce)
					{
						byte[] aZero = new byte[40];
						Project.Instance.PLCManagerInstance.Write("D101", aZero);
					}
				}
				//下待定
				else
				{
					if (!processOK)
					{
						processOK = false;
						finalResult = false;
					}
					else
					{
						#region 读取vpp上的ResultArr
						double[] ResultArrBo2 = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrBo2"].Value;
						double[] ResultArrLa2 = (double[])Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[workFlowIdx].ProcessBlock.Outputs["ResultArrLa2"].Value;
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
						//如果夹具号不在设定范围内，则不进行夹具补偿
						if (_jigIndex < 0 || _jigIndex >= jig_Compensations.Length)
						{
							LogHelper.Info($"读取到的夹具号{_jigIndex + 1}为非设定值，本次流程不进行夹具补偿");
							offset_in_jig.Bo2Axis = offset_dis_jig.Bo2Axis;
							offset_in_jig.L_La2Axis[0] = offset_dis_jig.La2Axis;
							offset_in_jig.L_La2Axis[1] = offset_dis_jig.La2Axis;
							offset_in_jig.L_La2Axis[2] = offset_dis_jig.La2Axis;
							offset_in_jig.L_La2Axis[3] = offset_dis_jig.La2Axis;
						}
						else
						{
							offset_in_jig.Bo2Axis.X = offset_dis_jig.Bo2Axis.X + jig_Compensations[_jigIndex].Bo2Axis.X;
							offset_in_jig.Bo2Axis.Y = offset_dis_jig.Bo2Axis.Y + jig_Compensations[_jigIndex].Bo2Axis.Y;
							offset_in_jig.L_La2Axis[0].X = offset_dis_jig.La2Axis.X + jig_Compensations[_jigIndex].L_La2Axis[0].X;
							offset_in_jig.L_La2Axis[1].X = offset_dis_jig.La2Axis.X + jig_Compensations[_jigIndex].L_La2Axis[1].X;
							offset_in_jig.L_La2Axis[2].X = offset_dis_jig.La2Axis.X + jig_Compensations[_jigIndex].L_La2Axis[2].X;
							offset_in_jig.L_La2Axis[3].X = offset_dis_jig.La2Axis.X + jig_Compensations[_jigIndex].L_La2Axis[3].X;
							offset_in_jig.L_La2Axis[0].Y = offset_dis_jig.La2Axis.Y + jig_Compensations[_jigIndex].L_La2Axis[0].Y;
							offset_in_jig.L_La2Axis[1].Y = offset_dis_jig.La2Axis.Y + jig_Compensations[_jigIndex].L_La2Axis[1].Y;
							offset_in_jig.L_La2Axis[2].Y = offset_dis_jig.La2Axis.Y + jig_Compensations[_jigIndex].L_La2Axis[2].Y;
							offset_in_jig.L_La2Axis[3].Y = offset_dis_jig.La2Axis.Y + jig_Compensations[_jigIndex].L_La2Axis[3].Y;
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
					double limitMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMax;
					double limitMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMin;
					double angleMax = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax;
					double angleMin = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin;
					bool isOutLimit = false;

					string NG_message = "";
					//机械手X/Y
					if (offset_in_jig.Bo2Axis.X < limitMin || offset_in_jig.Bo2Axis.X > limitMax)
					{
						isOutLimit = true;
						NG_message += "机械手偏移X超限NG;";
						finalResult = false;
					}
					if (offset_in_jig.Bo2Axis.Y < limitMin || offset_in_jig.Bo2Axis.Y > limitMax)
					{
						isOutLimit = true;
						NG_message += "机械手偏移Y超限NG;";
						finalResult = false;
					}
					//激光X/Y
					for (int i = 0; i < 4; i++)
					{
						if (offset_in_jig.L_La2Axis[i].X < limitMin || offset_in_jig.L_La2Axis[i].X > limitMax)
						{
							isOutLimit = true;
							NG_message += $"焊点{i + 1}偏移X超限NG;";
							finalResult = false;
						}
						if (offset_in_jig.L_La2Axis[i].Y < limitMin || offset_in_jig.L_La2Axis[i].Y > limitMax)
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
						string sendToRob, sendToLas;
						if (!finalResult)
						{

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse != 1)
								sendToRob = "PGE;0;1;0;0;0;0;\r\n";
							else
								sendToRob = $"PGE;0;2;0;{offset_in_jig.Bo2Axis.X:f3};{offset_in_jig.Bo2Axis.X:f3};0;\r\n";

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse != 1)
								sendToLas = "_OK;" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10";
							else
								sendToLas = CreatSentToLas(false, currentPose, offset_in_jig, 1);
							Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]++;
						}
						else
						{

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse != 1)
								sendToRob = "PGE;0;1;0;0;0;0;\r\n";
							else
								sendToRob = $"PGE;0;1;0;{offset_in_jig.Bo2Axis.X:f3};{offset_in_jig.Bo2Axis:f3};0;\r\n";

							if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse != 1)
								sendToLas = "_OK;" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10#" + "0%0%0%0%0%10%10";
							else
								sendToLas = CreatSentToLas(true, currentPose, offset_in_jig, 1);
							Project.Instance.ProductionDataManagerInstance.L_ProduceStationOKCount[0]++;
						}
						Project.Instance.RobotManagerInstance.L_Robot[1].SendText(sendToRob, 0);
						Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendToLas, 0);
						LogHelper.Info("给到机械手返回：" + sendToRob);
						NoticeHelper.OutputMessageSend("给到机械手返回" + sendToRob, OutputLevelModel.INFO);
					}
					else
					{
						if (finalResult)
						{
							e.ResultOffset.Bo2Axis.X = offset_dis_jig.Bo2Axis.X;
							e.ResultOffset.Bo2Axis.Y = offset_dis_jig.Bo2Axis.Y;
							e.ResultOffset.Bo2Axis.R = offset_dis_jig.Bo2Axis.R;

							e.ResultOffset.La2Axis.X = offset_dis_jig.La2Axis.X;
							e.ResultOffset.La2Axis.Y = offset_dis_jig.La2Axis.Y;
							e.ResultOffset.La2Axis.R = offset_dis_jig.La2Axis.R;
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
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], Color, 0, 0, "工位号:" + "2(面朝屏幕左手端)" + string.Format("{0}", finalResult ? "OK" : "NG"), fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 4, "夹具号:" + _jigIndex, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 6, $"取像耗时:{mSeconds1:f2}ms", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 8, $"视觉总耗时:{totalTime:f2}ms", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 10, "(以下为 夹具补偿后X: Y: / 夹具补偿前X: Y: )", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 12, $"机械手1偏移 X:{offset_in_jig.Bo2Axis.X:f3} Y:{offset_in_jig.Bo2Axis.Y:f3} / X:{offset_dis_jig.Bo2Axis.X} Y:{offset_dis_jig.Bo2Axis.Y}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 14, $"机械手1当前 X:{currentPose.Bo2Axis.X:f3} Y:{currentPose.Bo2Axis.Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 16, $"焊点1偏移 X:{offset_in_jig.L_La2Axis[0].X:f3} Y:{offset_in_jig.L_La2Axis[0].Y:f3} / X:{offset_dis_jig.La2Axis.X:f3} Y:{offset_dis_jig.La2Axis.Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 18, $"焊点2偏移 X:{offset_in_jig.L_La2Axis[1].X:f3} Y:{offset_in_jig.L_La2Axis[1].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 20, $"焊点3偏移 X:{offset_in_jig.L_La2Axis[2].X:f3} Y:{offset_in_jig.L_La2Axis[2].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 22, $"焊点4偏移 X:{offset_in_jig.L_La2Axis[3].X:f3} Y:{offset_in_jig.L_La2Axis[3].Y:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 24, $"连接片角度:{offset_in_jig.Bo2Axis.R:f3}°", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 26, $"极耳间距:{_spacing2:f3}", fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 28, "电池条码:" + _code2, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Blue, 0, fontSize * 30, nowTime, fontSize);
					WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 0, fontSize * 32, mError, fontSize);
					if (isOutLimit == true)
						WorkFlow1.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[workFlowIdx], CogColorConstants.Red, 0, fontSize * 34, NG_message, fontSize);
					#region 保存生产数据csv文件
					string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
					string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,弹夹角度,极耳间距,条码,时间";
					File_CSV csv = new File_CSV();
					strLogData[0] = finalResult.ToString();
					strLogData[1] = "1";
					strLogData[2] = _jigIndex.ToString();
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
					strLogData[24] = _spacing2.ToString("f3");
					strLogData[15] = _code2;
					strLogData[16] = nowTime;
					csv.AppendToCsv(strHead, strLogData, "PositionData");
					#endregion
					//VP或者Halcon存图
					e.DisplayObj = GlobalCameraParams.cameraVisionControlList[e.FlowIdx];
					e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[e.FlowIdx].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
					if (e.eMode == eProcessMode.produce)
						e.imageName = (e.FlowIdx + 1).ToString() + "-2-" + _jigIndex.ToString() + "-" + _code2.ToString();
					else
						e.imageName = (e.FlowIdx + 1).ToString() + "-2-" + DateTime.Now.ToString("HH:mm:ss") + "-debug";
					e.results = finalResult;
					Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.FlowIdx].Enqueue(e);
					// 生成40个空格的字符串
					if (e.eMode == eProcessMode.produce)
					{
						byte[] aZero = new byte[40];
						Project.Instance.PLCManagerInstance.Write("D101", aZero);
					}
				}
				//良率统计
				Action act = () =>
				{
					NoticeHelper.UpdateYieldTableMessageSend(DeviceStatisticsModels.XCCD, e.FlowIdx);
					NoticeHelper.UpdateCapaticyChartMessageSend(0);
				};
				if (!act.TryCatch($"相机{e.FlowIdx + 1}重新刷新良率统计出现异常！"))
				{
					//SendPLCMessage($"相机{e.Index + 1}重新刷新良率统计出现异常！", ConstantModel.NG);
				}

			}
			catch (Exception ex)
			{
				LogHelper.Error($"处理{e.FlowIdx + 1}相机检测出现异常", ex);  //写日志
			}
		}
		private static string CreatSentToLas(bool isOK, BasePose currentPose, JigAdd in_offset,int LaserIdx)
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
