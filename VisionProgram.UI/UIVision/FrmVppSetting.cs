﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Vision.VP;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro;
using System.Threading;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass.Robot;
using System.Net.Sockets;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Main.ProjectClass.PLC;
using VisionProgram.Models.VModels;

namespace VisionProgram.UI
{
    public partial class FrmVppSetting : Form
    {
        #region 字段
      
        //1个服务器-2个机器人-1个VPP
        private IniHelper _iniRotation;//配置文件
        private WorkFlow cur_WorkFlow;
        Cognex.VisionPro.CogAcqFifoTool acq;//取相
        Cognex.VisionPro.ToolBlock.CogToolBlock _linear_UnCalibrate_block;//线性标定块
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool;//线性标定工具1
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool1;//线性标定工具2
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool2;//线性标定工具3
        Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool _linear_calib_tool3;//线性标定工具4
        Cognex.VisionPro.CogFitCircleTool _rotation_calib_tool;//拟合圆
        Cognex.VisionPro.CogFitCircleTool _rotation_calib_tool1;//拟合圆
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_caculate_block;//旋转中心标定块
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_UnCalibrated_block;//旋转中心标定工具
        Cognex.VisionPro.CogGraphicLabel cogGraphicLabel1, cogGraphicLabel2;//绘制轨迹
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_caculate_block1;//旋转中心标定块
        Cognex.VisionPro.ToolBlock.CogToolBlock _rotation_UnCalibrated_block1;//旋转中心标定工具
        Cognex.VisionPro.CogGraphicLabel cogGraphicLabel11, cogGraphicLabel21;//绘制轨迹
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

        bool PLC_Statue = false;//PLC状态
        bool ROBOT_Statue = false;//ROBOT状态
        bool ROBOT1_Statue = false;//ROBOT2状态
        bool LASER_Statue = false;//激光状态
        bool _b_Auto_Linear = false;//线性标定状态
        bool _b_Auto_Rotation = false;//旋转中心标定状态
        bool _inAuto = false; //是否处于自动九点标定状态中

        int _laserIndex = 0;//激光九点标定时标记当前圆位置
        private string module_X = "";//当前机构实际坐标X
        private string module_Y = "";//当前机构实际坐标Y
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
        public FrmVppSetting(WorkFlow wf, string vpp_name)
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
            acq = cur_WorkFlow.AcquireBlock.Tools["CogAcqFifoTool1"] as Cognex.VisionPro.CogAcqFifoTool;
            _linear_UnCalibrate_block = cur_WorkFlow.LinearCalibBlock.Tools["UnCalibrate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
            _linear_calib_tool = cur_WorkFlow.LinearCalibBlock.Tools["NPoint"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool1 = cur_WorkFlow.LinearCalibBlock.Tools["NPoint1"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool2 = cur_WorkFlow.LinearCalibBlock.Tools["NPoint2"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            _linear_calib_tool3 = cur_WorkFlow.LinearCalibBlock.Tools["NPoint3"] as Cognex.VisionPro.CalibFix.CogCalibNPointToNPointTool;
            cogGraphicLabel1 = new Cognex.VisionPro.CogGraphicLabel();
            cogGraphicLabel1.SelectedSpaceName = "#";
            cogGraphicLabel1.Alignment = Cognex.VisionPro.CogGraphicLabelAlignmentConstants.BaselineLeft;
            cogGraphicLabel1.Color = Cognex.VisionPro.CogColorConstants.Blue;
            cogGraphicLabel1.Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);

            cogGraphicLabel2 = new Cognex.VisionPro.CogGraphicLabel();
            cogGraphicLabel2.SelectedSpaceName = "#";
            cogGraphicLabel2.Alignment = Cognex.VisionPro.CogGraphicLabelAlignmentConstants.BaselineLeft;
            cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
            cogGraphicLabel2.Font = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            //默认PLC标定、默认单帧
            rdo_Snap_Linear.Checked = true;
            rdo_Snap_Rotation.Checked = true;
            rdo_Robot_Con_L.Checked = true;
            rdo_ROBOT_Con_R.Checked = true;
            //默认标定模式为手动
            SetLinearCalibMode(false);
            SetRotationCalibMode(false);
            //当前吸嘴Index
            for (int i = 0; i < Project.Instance().GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                this.cbo_Nozzle_Rotation.Items.Add(i + 1);
            }
            this.cbo_Nozzle_Rotation.SelectedIndex = 0;

            nozzleIndex = Convert.ToInt32(this.cbo_Nozzle_Rotation.Text) - 1;
            //开启服务器接收事件
            RobotSignals.CCDProcess = 1;
            Project.Instance().RobotManagerInstance.L_Robot[0].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
            Project.Instance().RobotManagerInstance.L_Robot[1].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
            Project.Instance().RobotManagerInstance.L_Robot[2].OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);
            //九点标定结果刷新
            Linear_RMS = _linear_calib_tool.Calibration.ComputedRMSError;
            //Rotation标定结果刷新
            //Rotation标定结果刷新
            if (vppindex == 0)
            {
                RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[nozzleIndex];
                RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[nozzleIndex];
                Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[nozzleIndex];
            }
            else if (vppindex == 1)
            {
                RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_X[nozzleIndex];
                RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_Y[nozzleIndex];
                Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_RMS[nozzleIndex];
            }
            else if (vppindex == 2)
            {
                RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_X[nozzleIndex];
                RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_Y[nozzleIndex];
                Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_RMS[nozzleIndex];
            }
            else if (vppindex == 3)
            {
                RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_X[nozzleIndex];
                RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_Y[nozzleIndex];
                Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_RMS[nozzleIndex];
            }

            RefleshLinearDataGridView();
            RefleshRotationDataGridView();
            //刷新UI控件Timer_Task1定时器开启    
            if (timer1 == null)
            {
                timer1 = new System.Threading.Timer(ControlFlush1, null, 0, Timeout.Infinite);
            }
            if (timer2 == null)
            {
                timer2 = new System.Threading.Timer(ControlFlush2, null, 0, Timeout.Infinite);
            }
            Project.Instance().RobotManagerInstance.SetStop(false);
        }
        private void FrmVppSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("退出之前是否保存设置", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //关闭服务器接收事件
                RobotSignals.CCDProcess = 0;
                Project.Instance().RobotManagerInstance.L_Robot[0].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
                Project.Instance().RobotManagerInstance.L_Robot[1].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
                Project.Instance().RobotManagerInstance.L_Robot[2].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);

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
            else
            {
                //关闭服务器接收事件
                RobotSignals.CCDProcess = 0;
                Project.Instance().RobotManagerInstance.L_Robot[0].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal1);
                Project.Instance().RobotManagerInstance.L_Robot[1].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal2);
                Project.Instance().RobotManagerInstance.L_Robot[2].OnRead -= new CServerSocket.ConnectionDelegate(Server_OnRead_Cal3);

               
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
        }
        #endregion

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

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
                //1.PLC状态刷新
                //if (rdo_PLC_Con_L.Checked)
                //{
                //    if (!Project.Instance().PLCManagerInstance.plc4Service.PLCConnectState)
                //    {
                //        PLC_Statue = false;
                //        rdo_PLC_Con_L.BackColor = Color.Red;
                //    }
                //    else
                //    {
                //        PLC_Statue = true;
                //        rdo_PLC_Con_L.BackColor = Color.LimeGreen;
                //    }
                //}
                if (rdo_Robot_Con_L.Checked)
                {
                    //当前相机对应机器人是否连接成功
                    if (!Project.Instance().RobotManagerInstance.L_Robot[0].IsConnected)
                    {
                        ROBOT_Statue = false;
                        rdo_Robot_Con_L.BackColor = Color.Red;
                    }
                    else
                    {
                        ROBOT_Statue = true;
                        rdo_Robot_Con_L.BackColor = Color.LimeGreen;
                    }
                }
                //更新坐标
                if (_inAuto == true)
                {
                    tb_X_Linear.Text = module_X;
                    tb_Y_Linear.Text = module_Y;
                }
                //更新标定误差
                tb_RMS_Linear.Text = Linear_RMS.ToString("f3");
            };
            sync_context.Post(callback1, null);
            if (timer1 != null)
            {
                timer1.Change(350, Timeout.Infinite);
                //线程回归线程池
            }
        }
        /// <summary>
        /// UI线程控件刷新2
        /// </summary>
        /// <param name="obj"></param>
        private void ControlFlush2(object obj)
        {
            //控件变色显示状态
            SendOrPostCallback callback2 = o =>
            {
                //if (rdo_PLC_Con_R.Checked)
                //{
                //    //1.PLC状态刷新
                //    if (!Project.Instance().PLCManagerInstance.plc4Service.PLCConnectState)
                //    {
                //        PLC_Statue = false;
                //        rdo_PLC_Con_R.BackColor = Color.Red;
                //    }
                //    else
                //    {
                //        PLC_Statue = true;
                //        rdo_PLC_Con_R.BackColor = Color.LimeGreen;
                //    }
                //}
                //当前相机对应机器人是否连接成功
                if (rdo_ROBOT_Con_R.Checked)
                {
                    if (!Project.Instance().RobotManagerInstance.L_Robot[0].IsConnected)
                    {
                        ROBOT_Statue = false;
                        rdo_ROBOT_Con_R.BackColor = Color.Red;
                    }
                    else
                    {
                        ROBOT_Statue = true;
                        rdo_ROBOT_Con_R.BackColor = Color.LimeGreen;
                    }
                }
                if (rdo_RobotR_Con_R.Checked)
                {
                    //当前相机对应机器人是否连接成功
                    if (!Project.Instance().RobotManagerInstance.L_Robot[1].IsConnected)
                    {
                        ROBOT1_Statue = false;
                        rdo_RobotR_Con_R.BackColor = Color.Red;
                    }
                    else
                    {
                        ROBOT1_Statue = true;
                        rdo_RobotR_Con_R.BackColor = Color.LimeGreen;
                    }
                }
                if (rdo_LaserL_Con_L.Checked)
                {
                    //当前相机对应机器人是否连接成功
                    if (!Project.Instance().RobotManagerInstance.L_Robot[2].IsConnected)
                    {
                        LASER_Statue = false;
                        rdo_LaserL_Con_L.BackColor = Color.Red;
                    }
                    else
                    {
                        LASER_Statue = true;
                        rdo_LaserL_Con_L.BackColor = Color.LimeGreen;
                    }
                }

                if (rdo_LaserR_Con_L.Checked)
                {
                    //当前相机对应机器人是否连接成功
                    if (!Project.Instance().RobotManagerInstance.L_Robot[2].IsConnected)
                    {
                        LASER_Statue = false;
                        rdo_LaserR_Con_L.BackColor = Color.Red;
                    }
                    else
                    {
                        LASER_Statue = true;
                        rdo_LaserR_Con_L.BackColor = Color.LimeGreen;
                    }
                }
                //更新旋转中心坐标
                tB_X_Rotation.Text = RotationCenter_X.ToString("f4");
                tB_Y_Rotation.Text = RotationCenter_Y.ToString("f4");
                //更新旋转中心误差
                tB_RMS_Rotation.Text = Rotation_RMS.ToString("f4");
            };
            sync_context.Post(callback2, null);
            if (timer2 != null)
            {
                timer2.Change(360, Timeout.Infinite);
                //线程回归线程池
            }
        }
        #endregion

        #region 线性标定
        #region Linear标定信号
        private volatile int Linear_TRG_1 = 0;                                         //1号相机触发
        private volatile int Old_Linear_TRG_1 = 1;
        private volatile int Linear_Move_END_TRG_1 = 0;                                         //PLC运行完毕
        private volatile int Old_Linear_Move_END_TRG_1 = 1;
        #endregion
        /// <summary>
        /// PLC与PC信号交互线程
        /// </summary>
        /// <param name="token">取消CancellationToken</param>
        /// <param name="SelectSignalExchange">信号交互选择(True交互全部地址，False只交互脉冲地址和屏蔽地址)</param>
        private void PC_PLC_SignalExchange_Linear(CancellationToken token, bool SelectSignalExchange)
        {
            //while (!token.IsCancellationRequested)
            //{
            //    Thread.Sleep(1);
            //    //1.掉线
            //    if (!Project.Instance().PLCManagerInstance.plc4Service.PLCConnectState)        //判断PLC是否连接
            //    {
            //        RefleshLinearTextMsgBox("PLC掉线......");
            //        Thread.Sleep(3000);
            //    }
            //    //SelectSignalExchange为False只与PLC交互脉冲信号
            //    if (SelectSignalExchange)
            //    {
            //        #region CCD信号交互
            //        //触发开始CCD拍照信号（(上升沿0→1时,拍照处理图片)）
            //        try
            //        {
            //            if (Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Mode_CCD) == 1)
            //            {
            //                string sobjR1 = "";
            //                int Cam_Get1;
            //                sobjR1 = Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.TrigSignal_CCD).ToString();
            //                Cam_Get1 = Convert.ToInt32(sobjR1);
            //                Linear_TRG_1 = Cam_Get1;
            //                if (Linear_TRG_1 != 1)
            //                {
            //                    Old_Linear_TRG_1 = 0;
            //                    Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 0);
            //                }
            //                else
            //                {
            //                    if (Linear_TRG_1 - Old_Linear_TRG_1 > 0)
            //                    {
            //                        RefleshLinearTextMsgBox("接收到CCD触发信号......");

            //                        //取向
            //                        if (Acq_Linear() && runLinear() && addMark_Linear())
            //                        {
            //                            //发处理结果ok发1
            //                            Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 1);
            //                            RefleshLinearTextMsgBox("CCD发送PLC结果：添加点对成功 ......");
            //                        }
            //                        else
            //                        {
            //                            //发处理结果NG发1
            //                            Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 1);
            //                            RefleshLinearTextMsgBox("CCD发送PLC结果：添加点对失败 ......");
            //                        }
            //                    }
            //                    Old_Linear_TRG_1 = 1;
            //                }

            //                //PLC运动结束信号
            //                sobjR1 = Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Linear_Move_End_CCD).ToString();
            //                int PLC_Get1 = Convert.ToInt32(sobjR1);
            //                Linear_Move_END_TRG_1 = PLC_Get1;
            //                if (Linear_Move_END_TRG_1 != 1)
            //                {
            //                    Old_Linear_Move_END_TRG_1 = 0;
            //                }
            //                else
            //                {
            //                    if (Linear_Move_END_TRG_1 - Old_Linear_Move_END_TRG_1 > 0)
            //                    {
            //                        RefleshLinearTextMsgBox("CCD接收到PLC运动结束信号......");
            //                        //标定
            //                        if (linear())
            //                        {
            //                            //发标定结果
            //                            //Project.Instance().PLCManagerInstance.plc4Service.Write(PlcSignals.Linear_Calib_End_CCD, 1, "int", 5);
            //                            RefleshLinearTextMsgBox("CCD发送标定结束信号：标定成功 ......");
            //                        }
            //                        else
            //                        {
            //                            //Project.Instance().PLCManagerInstance.plc4Service.Write(PlcSignals.Linear_Calib_End_CCD, 2, "int", 5);
            //                            RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
            //                        }
            //                        _b_Auto_Linear = false;
            //                        SetLinearCalibMode(false);
            //                    }

            //                    Old_Linear_Move_END_TRG_1 = 1;
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            LogHelper.Error("CCD信号交互(九点线性标定)出现异常", ex);
            //            RefleshLinearTextMsgBox(ex.ToString());
            //            // Class_Global.CCD_PLC_Connect_State = false;
            //        }
            //        #endregion
            //    }
            //}
        }
        /// <summary>
        /// 更改九点标定模式
        /// false为手动，true为自动
        /// </summary>
        private void SetLinearCalibMode(bool bAutoLinear)
        {
            //更改标定模式
            rdo_Manual_Linear.Checked = !bAutoLinear;
            rdo_Auto_Linear.Checked = bAutoLinear;

            gb_LinearCon.Enabled = !bAutoLinear;
            btn_Auto_Linear.Enabled = bAutoLinear;
            gb_Linear.Enabled = !bAutoLinear;

            //停止实时采集
            if (bAutoLinear)
            {
                bool a = this.rdo_Snap_Linear.Checked;
                bool b = this.rdo_Live_Linear.Checked;
                if (cogRecordDisplayLinear.LiveDisplayRunning)
                    cogRecordDisplayLinear.StopLiveDisplay();
                rdo_Snap_Linear.Checked = bAutoLinear;
                rdo_Live_Linear.Checked = !bAutoLinear;//修改于2022.2.1
                bool c = this.rdo_Snap_Linear.Checked;
                bool d = this.rdo_Live_Linear.Checked;
                gb_LinearVision.Enabled = !bAutoLinear;
                Project.Instance().RobotManagerInstance.SetStop(false);
            }
            else
            {
                _b_Auto_Linear = false;
                gb_LinearVision.Enabled = !bAutoLinear;
                gb_LinearVision.Enabled = true;
                btn_Run_Linear.Enabled = true;
                btn_AddMark_Linear.Enabled = true;
                btn_Linear.Enabled = true;
                btn_Clear_Linear.Enabled = true;
                btn_Save_Linear.Enabled = true;
                Project.Instance().RobotManagerInstance.SetStop(false);

                
                RefleshLinearTextMsgBox("CCD手动九点线性标定模式开启......");
            }
        }
        /// <summary>
        /// 单帧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Snap_Linear_CheckedChanged(object sender, EventArgs e)
        {
            btn_Acq_Linear.Text = "采集图像";
            btn_Acq_Linear.BackColor = Color.FromArgb(80, 160, 255);
        }
        /// <summary>
        /// 实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Live_Linear_CheckedChanged(object sender, EventArgs e)
        {
            btn_Acq_Linear.Text = "实时采集";
            btn_Acq_Linear.BackColor = Color.FromArgb(220, 155, 40);
        }

        /// <summary>
        /// 选中自动九点标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Auto_Linear_Click(object sender, EventArgs e)
        {
            bool a = this.rdo_Live_Linear.Checked;
            bool b = this.rdo_Snap_Linear.Checked;
            SetLinearCalibMode(true);
        }
        /// <summary>
        /// 连接模式ROBOT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_ROBOT_Con_L_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：ROBOT1");
            this.rdo_RobotR_Con_R.BackColor = Color.Transparent;
            this.rdo_LaserL_Con_L.BackColor = Color.Transparent;
            this.rdo_LaserR_Con_L.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
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
        /// <summary>
        /// 选中手动九点标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Manual_Linear_Click(object sender, EventArgs e)
        {
            SetLinearCalibMode(false);
        }

        #region 线性标定手动标定
        /// <summary>
        /// 采集图像(九点)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Acq_Linear_Click(object sender, EventArgs e)
        {
            Acq_Linear();
        }
        private bool Acq_Linear()
        {
            try
            {
                if (cogRecordDisplayLinear.Image != null)
                {
                    cogRecordDisplayLinear.StaticGraphics.Clear();
                    cogRecordDisplayLinear.InteractiveGraphics.Clear();
                }
                if (btn_Acq_Linear.Text == "采集图像")
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

                    if (rdo_Robot_Con_L.Checked)
                    {
                        //取图成功，触发机器人反馈实时坐标
                        if (ROBOT_Statue)
                        {
                            //Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotCalLocation, 0);
                        }
                    }
                    #endregion
                }
                else if (btn_Acq_Linear.Text == "实时采集")
                {
                    #region 实时采集
                    if (null == acq.Operator.FrameGrabber)
                    {
                        MessageBox.Show("没有相机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    btn_Acq_Linear.Text = "停止实时";
                    btn_Acq_Linear.BackColor = Color.FromArgb(230, 80, 80);
                    gb_LinearVision.Enabled = false;
                    btn_Run_Linear.Enabled = false;
                    btn_AddMark_Linear.Enabled = false;
                    btn_Linear.Enabled = false;
                    btn_Clear_Linear.Enabled = false;
                    btn_Save_Linear.Enabled = false;
                    if ((null != acq.Operator) && (null != acq.Operator.FrameGrabber))
                    {
                        if (cogRecordDisplayLinear.LiveDisplayRunning)
                            cogRecordDisplayLinear.StopLiveDisplay();
                        cogRecordDisplayLinear.StaticGraphics.Clear();
                        cogRecordDisplayLinear.StartLiveDisplay(acq.Operator, true);
                    }
                    #endregion
                }
                else if (btn_Acq_Linear.Text == "停止实时")
                {
                    #region 实时采集
                    btn_Acq_Linear.Text = "实时采集";
                    btn_Acq_Linear.BackColor = Color.FromArgb(220, 155, 40);
                    gb_LinearVision.Enabled = true;
                    btn_Run_Linear.Enabled = true;
                    btn_AddMark_Linear.Enabled = true;
                    btn_Linear.Enabled = true;
                    btn_Clear_Linear.Enabled = true;
                    btn_Save_Linear.Enabled = true;
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

        /// <summary>
        /// 服务器接收事件
        /// </summary>
        /// <param name="soc"></param>
        /// 
        public string module_X1 = "";
        public string module_Y1 = "";
        private void Server_OnRead_Cal1(Socket soc)
        {
            if (RobotSignals.CCDProcess == 1)
            {
                string receive_string = Project.Instance().RobotManagerInstance.L_Robot[0].ReceivedText.Trim().Replace("\r\n", "").Replace("\0", "");
                RefleshLinearTextMsgBox("接收数据：" + receive_string);
                Project.Instance().RobotManagerInstance.m_strRobot1Receive = receive_string;
                string[] str = receive_string.Split(';');
                int nCountNum = str.Length;
                try
                {
                    if (nCountNum == 4)
                    {
                        module_X1 = str[2];
                        module_Y1 = str[3];
                    }
                    double Step = 2;
                    _inAuto = true;
                    //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                    if (nCountNum == 4 && str[0] == "CBS")
                    {
                        #region //解析当前ROBOT实时坐标，添加九点标定点对
                        module_X = module_X1;
                        module_Y = module_Y1;

                        if (_b_Auto_Linear)
                        {
                            Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                            if (runLinear() && addMark_Linear())
                            {
                                RefleshLinearTextMsgBox("添加点对成功");
                            }

                            if (linear())
                            {
                                Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                            }
                            else
                            {
                                Project.Instance().RobotManagerInstance.L_Robot[0].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
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

        private void Server_OnRead_Cal2(Socket soc)
        {
            if (RobotSignals.CCDProcess == 1)
            {
                string receive_string = Project.Instance().RobotManagerInstance.L_Robot[1].ReceivedText.Trim().Replace("\r\n", "").Replace("\0", "");
                RefleshLinearTextMsgBox("接收数据：" + receive_string);
                Project.Instance().RobotManagerInstance.m_strRobot1Receive = receive_string;
                string[] str = receive_string.Split(';');
                int nCountNum = str.Length;
                try
                {
                    if (nCountNum == 4)
                    {
                        module_X1 = str[2];
                        module_Y1 = str[3];
                    }
                    double Step = 2;
                    _inAuto = true;
                    //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                    if (nCountNum == 4 && str[0] == "CBS")
                    {
                        #region //解析当前ROBOT实时坐标，添加九点标定点对
                        module_X = module_X1;
                        module_Y = module_Y1;

                        if (_b_Auto_Linear)
                        {
                            Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "01" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "02" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "03" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "04" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) + Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "05" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1)).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "06" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) + Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "07" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1)).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "08" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                                if (runLinear() && addMark_Linear1())
                                {
                                    module_X = (Convert.ToDouble(module_X1) - Step).ToString();
                                    module_Y = (Convert.ToDouble(module_Y1) - Step).ToString();
                                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBP" + ";" + "01" + ";" + "09" + ";" + module_X + ";" + module_Y + ";" + "\r\n", 0);
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
                            if (runLinear() && addMark_Linear1())
                            {
                                RefleshLinearTextMsgBox("添加点对成功");
                            }

                            if (linear1())
                            {
                                Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                RefleshLinearTextMsgBox("CCD发送结束标定点字符：" + "CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n");
                            }
                            else
                            {
                                Project.Instance().RobotManagerInstance.L_Robot[1].SendText("CBE" + ";" + "01" + ";" + "1/2" + ";" + "\r\n", 0);
                                RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
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
        //private void Server_OnRead_Cal1(Socket soc)
        //{
        //    if (RobotSignals.CCDProcess == 1)
        //    {
        //        string receive_string = Project.Instance().RobotManagerInstance.L_Robot[0].ReceivedText;
        //        Project.Instance().RobotManagerInstance.m_strRobot1Receive = receive_string;
        //        string[] str = receive_string.Split(';');
        //        int nCountNum = str.Length;
        //        //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
        //        if (nCountNum == 3)
        //        {
        //            #region //解析当前ROBOT实时坐标，添加九点标定点对
        //            module_X = str[1].Trim();
        //            module_Y = str[2].Trim();

        //            if (_b_Auto_Linear)
        //            {
        //                if (runLinear() && addMark_Linear())
        //                {
        //                    //发处理结果ok发1
        //                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDCONFIRM, 0);
        //                    RefleshLinearTextMsgBox("CCD发送Robot结果：添加点对成功 ......");
        //                }
        //                else
        //                {
        //                    //发处理结果NG发1
        //                    Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDCONFIRM, 0);
        //                    RefleshLinearTextMsgBox("CCD发送Robot结果：添加点对失败 ......");
        //                }

        //            }

        //            #endregion
        //        }
        //        else
        //        {
        //            #region  //自动九点标定
        //            string strText = str[0];
        //            if (RobotSignals.CCDRobotCal == "0")
        //            {
        //                //触发开始CCD拍照信号
        //                if ( strText.Contains(RobotSignals.CCDRobotCalTrigger))
        //                {
        //                    RefleshLinearTextMsgBox("接收到CCD触发信号......");
        //                    //取向
        //                    if (Acq_Linear())
        //                    {
        //                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotCalFinishOK, 0);
        //                        RefleshLinearTextMsgBox("CCD采集图像成功 ......");
        //                    }
        //                    else
        //                    {
        //                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotCalFinishNG, 0);
        //                    }
        //                }
        //                if (strText.Contains(RobotSignals.CCDRobotCalFinish))
        //                {
        //                    RefleshLinearTextMsgBox("CCD接收到Robot运动结束信号......");
        //                    //标定
        //                    if (linear())
        //                    {
        //                        RefleshLinearTextMsgBox("CCD发送标定结束信号：标定成功 ......");
        //                    }
        //                    else
        //                    {
        //                        RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
        //                    }
        //                    _b_Auto_Linear = false;

        //                    Action action = () => { SetLinearCalibMode(false); };
        //                    this.Invoke(action);
        //                }
        //            }
        //            #endregion
        //            #region   //旋转中心标定
        //            else if (RobotSignals.CCDRobotCal == "1")
        //            {
        //                //触发开始CCD拍照信号
        //                if (  strText.Contains(RobotSignals.CCDRobotRCalTrigger) )
        //                {
        //                    RefleshRotationTextMsgBox("接收到CCD触发信号......");
        //                    //取向
        //                    if (Acq_Rotation() && runRotation() && addMark_Rotation())
        //                    {
        //                        //发处理结果ok=1 
        //                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotRCalFinishOK, 0);
        //                        RefleshRotationTextMsgBox("CCD发送Robot结果：添加点对成功 ......");
        //                    }
        //                    else
        //                    {
        //                        //发处理结果NG=2
        //                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotRCalFinishNG, 0);
        //                        RefleshRotationTextMsgBox("CCD发送Robot结果：添加点对失败 ......");
        //                    }
        //                }
        //                else if ( strText.Contains(RobotSignals.CCDRobotRCalFinish))
        //                {
        //                    RefleshRotationTextMsgBox("CCD接收到Robot运动结束信号......");
        //                    //标定
        //                    if (rotation())
        //                    {
        //                        RefleshRotationTextMsgBox("CCD1发送标定结束信号：标定成功 ......");
        //                    }
        //                    else
        //                    {
        //                        RefleshRotationTextMsgBox("CCD1发送标定结束信号：标定失败 ......");
        //                    }
        //                    _b_Auto_Rotation = false;

        //                    Action action = () => { SetRotationCalibMode(false); };
        //                    this.Invoke(action);
        //                }
        //            }
        //            #endregion
        //        }
        //    }


        //}

        //private void Server_OnRead_Cal2(Socket soc)
        //{
        //    if (RobotSignals.CCDProcess == 1)
        //    {
        //        string receive_string = Project.Instance().RobotManagerInstance.L_Robot[1].ReceivedText;
        //        Project.Instance().RobotManagerInstance.m_strRobot2Receive = receive_string;
        //        string[] str = receive_string.Split(';');
        //        int nCountNum = str.Length;
        //        //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
        //        if (nCountNum == 3)
        //        {
        //            #region //解析当前ROBOT实时坐标，添加九点标定点对
        //            module_X = str[1].Trim();
        //            module_Y = str[2].Trim();

        //            if (_b_Auto_Linear)
        //            {
        //                if (runLinear() && addMark_Linear1())
        //                {
        //                    //发处理结果ok发1
        //                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDCONFIRM, 0);
        //                    RefleshLinearTextMsgBox("CCD发送Robot结果：添加点对成功 ......");
        //                }
        //                else
        //                {
        //                    //发处理结果NG发1
        //                    Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDCONFIRM, 0);
        //                    RefleshLinearTextMsgBox("CCD发送Robot结果：添加点对失败 ......");
        //                }

        //            }

        //            #endregion
        //        }
        //        else
        //        {
        //            #region  //自动九点标定
        //            string strText = str[0];
        //            if (RobotSignals.CCDRobotCal == "0")
        //            {
        //                //触发开始CCD拍照信号
        //                if (strText.Contains(RobotSignals.CCDRobotCalTrigger))
        //                {
        //                    RefleshLinearTextMsgBox("接收到CCD触发信号......");
        //                    //取向
        //                    if (Acq_Linear())
        //                    {
        //                        Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotCalFinishOK, 0);
        //                        RefleshLinearTextMsgBox("CCD采集图像成功 ......");
        //                    }
        //                    else
        //                    {
        //                        Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotCalFinishNG, 0);
        //                    }
        //                }
        //                if (strText.Contains(RobotSignals.CCDRobotCalFinish))
        //                {
        //                    RefleshLinearTextMsgBox("CCD接收到Robot运动结束信号......");
        //                    //标定
        //                    if (linear())
        //                    {
        //                        RefleshLinearTextMsgBox("CCD发送标定结束信号：标定成功 ......");
        //                    }
        //                    else
        //                    {
        //                        RefleshLinearTextMsgBox("CCD发送标定结束信号：标定失败 ......");
        //                    }
        //                    _b_Auto_Linear = false;

        //                    Action action = () => { SetLinearCalibMode(false); };
        //                    this.Invoke(action);
        //                }
        //            }
        //            #endregion
        //            #region   //旋转中心标定
        //            else if (RobotSignals.CCDRobotCal == "1")
        //            {
        //                //触发开始CCD拍照信号
        //                if (strText.Contains(RobotSignals.CCDRobotRCalTrigger))
        //                {
        //                    RefleshRotationTextMsgBox("接收到CCD触发信号......");
        //                    //取向
        //                    if (Acq_Rotation() && runRotation() && addMark_Rotation())
        //                    {
        //                        //发处理结果ok=1 
        //                        Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotRCalFinishOK, 0);
        //                        RefleshRotationTextMsgBox("CCD发送Robot结果：添加点对成功 ......");
        //                    }
        //                    else
        //                    {
        //                        //发处理结果NG=2
        //                        Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotRCalFinishNG, 0);
        //                        RefleshRotationTextMsgBox("CCD发送Robot结果：添加点对失败 ......");
        //                    }
        //                }
        //                else if (strText.Contains(RobotSignals.CCDRobotRCalFinish))
        //                {
        //                    RefleshRotationTextMsgBox("CCD接收到Robot运动结束信号......");
        //                    //标定
        //                    if (rotation())
        //                    {
        //                        RefleshRotationTextMsgBox("CCD1发送标定结束信号：标定成功 ......");
        //                    }
        //                    else
        //                    {
        //                        RefleshRotationTextMsgBox("CCD1发送标定结束信号：标定失败 ......");
        //                    }
        //                    _b_Auto_Rotation = false;

        //                    Action action = () => { SetRotationCalibMode(false); };
        //                    this.Invoke(action);
        //                }
        //            }
        //            #endregion
        //        }
        //    }


        //}

        private void Server_OnRead_Cal3(Socket soc)
        {
            if (RobotSignals.CCDProcess == 1)
            {
                string receive_string = Project.Instance().RobotManagerInstance.L_Robot[2].ReceivedText;
                Project.Instance().RobotManagerInstance.m_strRobot2Receive = receive_string;
                string[] str = receive_string.Split(',');
                int nCountNum = str.Length;
                int flag = 0;
                //解析receive_string，假设如果是位置就以首字母！发送并以；来间隔xy，否则则为其他信号,接受字符无结束符
                if (nCountNum == 3)
                {
                    if (str[0] == "T1")
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[2].SendText(RobotSignals.Laser1NinePointStr, 0);
                    }
                    else
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[2].SendText(RobotSignals.Laser2NinePointStr, 0);
                    }
                        
                    MessageBox.Show("激光此时正在出光，等待出光完成继续流程");
                    if (Acq_Linear())
                    {
                        RefleshLinearTextMsgBox("CCD采集图像成功 ......");
                    
                    for (int i = 0; i < 9; i++)
                    {
                            if (str[0] == "T1")
                            {
                                if (laserRunLinearL(i + 1) && addMark_Linear2() && str[0] == "T1")
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
                                if (laserRunLinearR(i + 1) && addMark_Linear3() && str[0] == "T2")
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
                        if (flag<10)
                        {
                    if (str[0]=="T1")
                    {
                        if (linear2())
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
                        if (linear3 ())
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

                    Action action = () => { SetLinearCalibMode(false); };
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
        /// 清除九点标定点数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Linear_Click(object sender, EventArgs e)
        {
            if (rdo_Robot_Con_L.Checked)
            {
                Clear_Linear();
            }
            else if(rdo_RobotR_Con_R.Checked)
            {
                Clear_Linear1();
            }
            else if (rdo_LaserL_Con_L.Checked)
            {
                Clear_Linear2();
            }
            else if (rdo_LaserR_Con_L.Checked)
            {
                Clear_Linear3();
            }
           
        }
        private bool Clear_Linear()
        {
            if (MessageBox.Show("将要清除rob1标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 0;
                cur_WorkFlow.LinearCalibBlock.Run();
                RefleshLinearDataGridView();
                module_X = "";
                module_Y = "";
                Linear_RMS = 0;
                RefleshLinearTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }

        private bool Clear_Linear1()
        {
            if (MessageBox.Show("将要清除rob2标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 1;
                cur_WorkFlow.LinearCalibBlock.Run();
                RefleshLinearDataGridView();
                module_X = "";
                module_Y = "";
                Linear_RMS = 0;
                RefleshLinearTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }
        private bool Clear_Linear2()
        {
            if (MessageBox.Show("将要清除laser1标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 2;
                cur_WorkFlow.LinearCalibBlock.Run();
                RefleshLinearDataGridView();
                module_X = "";
                module_Y = "";
                Linear_RMS = 0;
                RefleshLinearTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }
        private bool Clear_Linear3()
        {
            if (MessageBox.Show("将要清除laser2标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 3;
                cur_WorkFlow.LinearCalibBlock.Run();
                RefleshLinearDataGridView();
                module_X = "";
                module_Y = "";
                Linear_RMS = 0;
                RefleshLinearTextMsgBox("清除旧标定数据");
                return true;
            }
            return false;
        }
        /// <summary>
        /// 运行标定块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Run_Linear_Click(object sender, EventArgs e)
        {
            if (rdo_Robot_Con_L.Checked)
            {
                _Linear_State = runLinear();
            }
            else if (rdo_RobotR_Con_R.Checked)
            {
                _Linear_State = runLinear();
            }
            else if (rdo_LaserL_Con_L.Checked)
            {
                //_laserIndex = _laserIndex % 9;
                //if (_laserIndex==0)
                //{
                //    _laserIndex = _laserIndex + 1;
                //}
                // _Linear_State = laserRunLinearL(_laserIndex);

            }
            else if (rdo_LaserR_Con_L.Checked)
            {
                //_laserIndex = _laserIndex % 9;
                //if (_laserIndex == 0)
                //{
                //    _laserIndex = _laserIndex + 1;
                //}
                //_Linear_State = laserRunLinearR(_laserIndex);
            }
          
        }
        private bool runLinear()
        {
            try
            {
                if (img != null)
                {
                    cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 4;
                    cur_WorkFlow.LinearCalibBlock.Inputs["NIndex"].Value = 0;
                    cur_WorkFlow.RunLinearCalibBlock(ref img);
                    if (cur_WorkFlow.LinearCalibBlock.RunStatus.Result == Cognex.VisionPro.CogToolResultConstants.Accept)
                    {
                        cogRecordDisplayLinear.Record = cur_WorkFlow.LinearCalibBlock.CreateLastRunRecord();
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_linear_UnCalibrate_block.Outputs["X"].Value).ToString("F3"), ((double)_linear_UnCalibrate_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Red;
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
        private bool laserRunLinearL(int Index)
        {
            try
            {
                if (img != null)
                {
                    cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 4;
                    cur_WorkFlow.LinearCalibBlock.Inputs["NIndex"].Value = Index;
                    cur_WorkFlow.RunLinearCalibBlock(ref img);
                    if (cur_WorkFlow.LinearCalibBlock.RunStatus.Result == Cognex.VisionPro.CogToolResultConstants.Accept)
                    {
                        cogRecordDisplayLinear.Record = cur_WorkFlow.LinearCalibBlock.CreateLastRunRecord();
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_linear_UnCalibrate_block.Outputs["X"].Value).ToString("F3"), ((double)_linear_UnCalibrate_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Red;
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
                double Step = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[0];
                if (Index ==1)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex]- Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex]+Step).ToString();
                }
                if (Index == 2)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex]).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] + Step).ToString();
                }
                if (Index == 3)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] + Step).ToString();
                }
                if (Index == 4)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] ).ToString();
                }
                if (Index == 5)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] ).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] ).ToString();
                }
                if (Index == 6)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] - Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] ).ToString();
                }
                if (Index == 7)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] - Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] - Step).ToString();
                }
                if (Index == 8)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] ).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] - Step).ToString();
                }
                if (Index == 9)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[vppindex] - Step).ToString();
                }
            }
            catch
            {
                RefleshLinearTextMsgBox("标定视觉运行错误!");
                return false;
            }
            return true;
        }

        private bool laserRunLinearR(int Index)
        {
            try
            {
                if (img != null)
                {
                    cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 4;
                    cur_WorkFlow.LinearCalibBlock.Inputs["NIndex"].Value = Index;
                    cur_WorkFlow.RunLinearCalibBlock(ref img);
                    if (cur_WorkFlow.LinearCalibBlock.RunStatus.Result == Cognex.VisionPro.CogToolResultConstants.Accept)
                    {
                        cogRecordDisplayLinear.Record = cur_WorkFlow.LinearCalibBlock.CreateLastRunRecord();
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_linear_UnCalibrate_block.Outputs["X"].Value).ToString("F3"), ((double)_linear_UnCalibrate_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayLinear.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayLinear.Fit(true);
                        _Linear_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Red;
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
                double Step = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[0];
                if (Index == 1)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] - Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex]+Step).ToString();
                }
                if (Index == 2)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] ).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] + Step).ToString();
                }
                if (Index == 3)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] + Step).ToString();
                }
                if (Index == 4)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] ).ToString();
                }
                if (Index == 5)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] ).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] ).ToString();
                }
                if (Index == 6)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] -Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] ).ToString();
                }
                if (Index == 7)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] - Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] - Step).ToString();
                }
                if (Index == 8)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex]  ).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] - Step).ToString();
                }
                if (Index == 9)
                {
                    module_X = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[vppindex] + Step).ToString();
                    module_Y = (Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[vppindex] - Step).ToString();
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
        /// 添加标定点对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddMark_Linear_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (rdo_Robot_Con_L.Checked)
            {
                addMark_Linear();
            }
            else if (rdo_RobotR_Con_R.Checked)
            {
                addMark_Linear1();
            }
            else if (rdo_LaserL_Con_L.Checked)
            {
                for (int i = 0; i < 9; i++)
                {
                   
                        if (laserRunLinearL(i + 1) && addMark_Linear2() )
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
            else if (rdo_LaserR_Con_L.Checked)
            {
                for (int i = 0; i < 9; i++)
                {
                   
                       
                        if (laserRunLinearR(i + 1) && addMark_Linear3() )
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
        private bool addMark_Linear()
        {
            if (!_Linear_State)
            {
                return false;
            }
            module_X = tb_X_Linear.Text;
            module_Y = tb_Y_Linear.Text;
            cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 5;
            if ((!string.IsNullOrEmpty(module_X)) && (!string.IsNullOrEmpty(module_Y)))
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_X"].Value = double.Parse(module_X);
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_Y"].Value = double.Parse(module_Y);
                cur_WorkFlow.LinearCalibBlock.Run();
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
        private bool addMark_Linear1()
        {
            if (!_Linear_State)
            {
                return false;
            }
            module_X = tb_X_Linear.Text;
            module_Y = tb_Y_Linear.Text;

            cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 6;
            if ((!string.IsNullOrEmpty(module_X)) && (!string.IsNullOrEmpty(module_Y)))
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_X"].Value = double.Parse(module_X);
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_Y"].Value = double.Parse(module_Y);
                cur_WorkFlow.LinearCalibBlock.Run();
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
        private bool addMark_Linear2()
        {
            if (!_Linear_State)
            {
                return false;
            }
            cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 7;
            if ((!string.IsNullOrEmpty(module_X)) && (!string.IsNullOrEmpty(module_Y)))
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_X"].Value = double.Parse(module_X);
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_Y"].Value = double.Parse(module_Y);
                cur_WorkFlow.LinearCalibBlock.Run();
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
        private bool addMark_Linear3()
        {
            if (!_Linear_State)
            {
                return false;
            }
            cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 8;
            if ((!string.IsNullOrEmpty(module_X)) && (!string.IsNullOrEmpty(module_Y)))
            {
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_X"].Value = double.Parse(module_X);
                cur_WorkFlow.LinearCalibBlock.Inputs["Raw_Y"].Value = double.Parse(module_Y);
                cur_WorkFlow.LinearCalibBlock.Run();
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
        /// <summary>
        /// 开始标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Linear_Click(object sender, EventArgs e)
        {
            if (rdo_Robot_Con_L.Checked)
            {
                linear();
            }
            else if (rdo_RobotR_Con_R.Checked)
            {
                linear1();
            }
            else if (rdo_LaserL_Con_L.Checked)
            {
                linear2();
            }
            else if (rdo_LaserR_Con_L.Checked)
            {
                linear3();
            }
            
        }
        private bool linear()
        {
            try
            {
                if (!_Linear_State)
                {
                    return false;
                }
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 9;
                cur_WorkFlow.LinearCalibBlock.Run();
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
        private bool linear1()
        {
            try
            {
                //if (!_Linear_State)
                //{
                //    return false;
                //}
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 10;
                cur_WorkFlow.LinearCalibBlock.Run();
                //标定结果刷新
                Linear_RMS = _linear_calib_tool1.Calibration.ComputedRMSError;
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
        private bool linear2()
        {
            try
            {
                if (!_Linear_State)
                {
                    return false;
                }
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 11;
                cur_WorkFlow.LinearCalibBlock.Run();
                //标定结果刷新
                Linear_RMS = _linear_calib_tool2.Calibration.ComputedRMSError;
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
        private bool linear3()
        {
            try
            {
                if (!_Linear_State)
                {
                    return false;
                }
                cur_WorkFlow.LinearCalibBlock.Inputs["Index"].Value = 12;
                cur_WorkFlow.LinearCalibBlock.Run();
                //标定结果刷新
                Linear_RMS = _linear_calib_tool3.Calibration.ComputedRMSError;
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
        /// 九点标定保存结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Linear_Click(object sender, EventArgs e)
        {
            saveResult_Linear();
        }
        private void saveResult_Linear()
        {
            cur_WorkFlow.SaveTools();
            RefleshLinearTextMsgBox("标定结果保存成功！");
        }
        #endregion

        /// <summary>
        /// 开始自动标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Auto_Linear_Click(object sender, EventArgs e)
        {
            try
            {
                if (_b_Auto_Linear)
                {
                    return;
                }
                if (!Project.Instance().HardWareStateManagerInstance.L_ccdState[vppindex])
                {
                    MessageBox.Show("CCD未链接!");
                    return;
                }

                if (rdo_Robot_Con_L.Checked)
                {
                    bool bIsConnected = Project.Instance().RobotManagerInstance.L_Robot[0].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + 1 + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    try
                    {
                        //Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotCalStart, 0);
                        RefleshLinearTextMsgBox("rob1九点标定开启......");
                    }
                    catch
                    {
                        RefleshLinearTextMsgBox("CCD自动九点标定模式catch......");
                    }
                    #endregion
                    if (!Clear_Linear())
                    {
                        return;
                    }
                }
                else if (rdo_RobotR_Con_R.Checked)
                {
                    bool bIsConnected = Project.Instance().RobotManagerInstance.L_Robot[1].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + 2 + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    try
                    {
                        //Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotCalStart, 0);
                        RefleshLinearTextMsgBox("rob2九点标定开启......");
                    }
                    catch
                    {
                        RefleshLinearTextMsgBox("CCD自动九点标定模式catch......");
                    }
                    #endregion
                    if (!Clear_Linear1())
                    {
                        return;
                    }

                }
                else if (rdo_LaserL_Con_L.Checked)
                {
                    bool bIsConnected = Project.Instance().RobotManagerInstance.L_Robot[2].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("LASER"  + ":未链接!");
                        return;
                    }
                    if (!Clear_Linear2())
                    {
                        return;
                    }
                }
                else if (rdo_LaserR_Con_L.Checked)
                {
                    bool bIsConnected = Project.Instance().RobotManagerInstance.L_Robot[2].IsConnected;
                    if (!bIsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("LASER"  + ":未链接!");
                        return;
                    }
                    if (!Clear_Linear3())
                    {
                        return;
                    }

                }

                    _b_Auto_Linear = true;
                RobotSignals.CCDRobotCal = "0";
               

                RefleshLinearTextMsgBox("CCD自动九点线性标定模式开启......");
            }
            catch (Exception ex)
            {
                RefleshLinearTextMsgBox(ex.ToString());
            }
        }
        /// <summary>
        /// 读取标定MARK点
        /// </summary>
        /// 


        
        private void RefleshLinearDataGridView()
        {
            try
            {
                if (rdo_Robot_Con_L.Checked)
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
                else if (rdo_RobotR_Con_R.Checked)
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
                else if (rdo_LaserL_Con_L.Checked)
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
                else if (rdo_LaserR_Con_L.Checked)
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
        /// <summary>
        /// 刷新TextBox
        /// </summary>
        /// <param name="str"></param>
        private void RefleshLinearTextMsgBox(string str)
        {
            try
            {
                if (!this.tb_msg_Linear.IsDisposed)
                {
                    if (this.tb_msg_Linear.InvokeRequired)
                    {
                        RefleshTextMsgBoxCallback d = new RefleshTextMsgBoxCallback(RefleshLinearTextMsgBox);
                        this.Invoke(d, new object[] { str });
                    }
                    else
                    {
                        this.tb_msg_Linear.AppendText(System.Environment.NewLine);
                        str += DateTime.Now.ToString("  yyyy.MM.dd HH:mm:ss  ");
                        this.tb_msg_Linear.Text += str;
                        this.tb_msg_Linear.Select(this.tb_msg_Linear.TextLength, 0);
                        this.tb_msg_Linear.ScrollToCaret();
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
        /// <summary>
        /// 相机采图(畸变)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDistortionAcq_Click(object sender, EventArgs e)
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
        private void btnChooseDistortionImage_Click(object sender, EventArgs e)
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
        private void btnDistortion_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("是否进行畸变矫正", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
                //if (!Project.Instance().PLCManagerInstance.plc4Service.PLCConnectState)        //判断PLC是否连接
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
                //        if (Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Mode_CCD) == 2)
                //        {
                //            string sobjR1 = "";
                //            int Cam_Get1;
                //            sobjR1 = Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.TrigSignal_CCD).ToString();
                //            Cam_Get1 = Convert.ToInt32(sobjR1);
                //            Rotation_TRG_1 = Cam_Get1;
                //            if (Rotation_TRG_1 != 1)
                //            {
                //                Old_Rotation_TRG_1 = 0;
                //                Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 0);
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
                //                        Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 1);
                //                        RefleshRotationTextMsgBox("CCD发送PLC结果：添加点对成功 ......");
                //                    }
                //                    else
                //                    {
                //                        //发处理结果NG=2
                //                        Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.FinishSignal_CCD, 2);
                //                        RefleshRotationTextMsgBox("CCD发送PLC结果：添加点对失败 ......");
                //                    }
                //                }
                //                Old_Rotation_TRG_1 = 1;
                //            }

                //            //PLC运动结束信号
                //            sobjR1 = Project.Instance().PLCManagerInstance.plc4Service.ReadFromPLC1<Int16>(PlcSignals.PLC4.Rotation_Move_End_CCD).ToString();
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
            rdo_Manual_Rotation.Checked = !bAutoRotation;
            rdo_Auto_Rotation.Checked = bAutoRotation;
            btn_Auto_Rotation.Enabled = bAutoRotation;
            gb_Rotation.Enabled = !bAutoRotation;
            gb_RotationCon.Enabled = !bAutoRotation;

            //停止实时采集
            if (bAutoRotation)
            {
                if (cogRecordDisplayRotation.LiveDisplayRunning)
                    cogRecordDisplayRotation.StopLiveDisplay();

                rdo_Snap_Rotation.Checked = bAutoRotation;
                rdo_Live_Rotation.Checked = !bAutoRotation;
                gb_RotationVision.Enabled = !bAutoRotation;
            }
            else
            {
                //手动模式
                _b_Auto_Rotation = false;
                gb_RotationVision.Enabled = !bAutoRotation;
                gb_RotationVision.Enabled = true;
                btn_Run_Rotation.Enabled = true;
                btn_AddMark_Rotation.Enabled = true;
                btn_Rotation.Enabled = true;
                btn_Clear_Rotation.Enabled = true;
                btn_Save_Rotation.Enabled = true;
                btn_OpenImage_Rotation.Enabled = true;
                //if (rdo_PLC_Con_R.Checked)
                //{
                //    if (Project.Instance().PLCManagerInstance.plc4Service.PLCConnectState)
                //    {
                //        //通知PLC停止一键标定.
                //        Project.Instance().PLCManagerInstance.plc4Service.WriteToPlc1(PlcSignals.PLC4.Rotation_Request_CCD, 0);
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
                //    if (Project.Instance().RobotManagerInstance.RobotObj.IsConnectedRobot[vppindex])
                //    {
                //        Project.Instance().RobotManagerInstance.RobotObj.SendText(RobotSignals.CCDRobotRCalStop, 0);
                //    }
                //}
                RefleshRotationTextMsgBox("CCD手动旋转中心标定模式开启......");
            }
        }
        /// <summary>
        /// 单帧
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Snap_Rotation_CheckedChanged(object sender, EventArgs e)
        {
            btn_Acq_Rotation.Text = "采集图像";
            btn_Acq_Rotation.BackColor = Color.FromArgb(80, 160, 255);
        }
        /// <summary>
        /// 实时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Live_Rotation_CheckedChanged(object sender, EventArgs e)
        {
            btn_Acq_Rotation.Text = "实时采集";
            btn_Acq_Rotation.BackColor = Color.FromArgb(220, 155, 40);
        }

        /// <summary>
        /// 选中自动旋转中心标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Auto_Rotation_Click(object sender, EventArgs e)
        {
            SetRotationCalibMode(true);
        }
        /// <summary>
        /// 选中手动旋转中心标定模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_Manual_Rotation_Click(object sender, EventArgs e)
        {
            SetRotationCalibMode(false);
        }

        /// <summary>
        /// 当前吸嘴对应Rotation坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_Nozzle_Rotation_SelectedIndexChanged(object sender, EventArgs e)
        {
            nozzleIndex = Convert.ToInt32(cbo_Nozzle_Rotation.Text) - 1;
            switch (nozzleIndex)
            {
                case 0:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    _rotation_UnCalibrated_block1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool1 = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                case 1:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                case 2:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle3"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                case 3:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle4"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                case 4:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle5"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                case 5:
                    _rotation_UnCalibrated_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["UnCalibrated"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_caculate_block = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["RCCalculate"] as Cognex.VisionPro.ToolBlock.CogToolBlock;
                    _rotation_calib_tool = ((Cognex.VisionPro.ToolBlock.CogToolBlock)cur_WorkFlow.RotationCalibBlock.Tools["Nozzle6"]).Tools["FitCircle"] as Cognex.VisionPro.CogFitCircleTool;
                    break;
                default:
                    break;
            }
            //显示
            if (vppindex == 0)
            {
                if (rdo_ROBOT_Con_R.Checked)
                {
                    RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[0];
                    RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[0];
                    Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[0];
                }
                else
                {
                    RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[1];
                    RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[1];
                    Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[1];
                }
               
            }
            else if (vppindex == 1)
            {
                RotationCenter_X = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_X[nozzleIndex];
                RotationCenter_Y = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_Y[nozzleIndex];
                Rotation_RMS = Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_RMS[nozzleIndex];
            }
            //刷新界面
            RefleshRotationDataGridView();
        }
        #region 旋转中心手动标定
        /// <summary>
        /// Rotation采集图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Acq_Rotation_Click(object sender, EventArgs e)
        {
            Acq_Rotation();
        }
        private bool Acq_Rotation()
        {
            try
            {
                if (cogRecordDisplayRotation.Image != null)
                {
                    cogRecordDisplayRotation.StaticGraphics.Clear();
                    cogRecordDisplayRotation.InteractiveGraphics.Clear();
                }
                if (btn_Acq_Rotation.Text == "采集图像")
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
                else if (btn_Acq_Rotation.Text == "实时采集")
                {
                    #region 实时采集
                    if (null == acq.Operator.FrameGrabber)
                    {
                        MessageBox.Show("没有相机", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    btn_Acq_Rotation.Text = "停止实时";
                    btn_Acq_Rotation.BackColor = Color.FromArgb(230, 80, 80);
                    gb_RotationVision.Enabled = false;
                    btn_Run_Rotation.Enabled = false;
                    btn_AddMark_Rotation.Enabled = false;
                    btn_Rotation.Enabled = false;
                    btn_Clear_Rotation.Enabled = false;
                    btn_Save_Rotation.Enabled = false;
                    btn_OpenImage_Rotation.Enabled = false;
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
                else if (btn_Acq_Rotation.Text == "停止实时")
                {
                    #region 停止实时
                    btn_Acq_Rotation.Text = "实时采集";
                    btn_Acq_Rotation.BackColor = Color.FromArgb(220, 155, 40);
                    gb_RotationVision.Enabled = true;
                    btn_Run_Rotation.Enabled = true;
                    btn_AddMark_Rotation.Enabled = true;
                    btn_Rotation.Enabled = true;
                    btn_Clear_Rotation.Enabled = true;
                    btn_Save_Rotation.Enabled = true;
                    btn_OpenImage_Rotation.Enabled = true;
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
        /// <summary>
        /// Rotation文件取图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenImage_Rotation_Click(object sender, EventArgs e)
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
        /// Rotation清除MARK点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Rotation_Click(object sender, EventArgs e)
        {
            Clear_Rotation();
        }
        private bool Clear_Rotation()
        {
            if (MessageBox.Show("将要清楚旧标定数据，是否继续？", "询问", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 0;
                if (rdo_ROBOT_Con_R.Checked)
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

        /// <summary>
        /// Rotation运行标定块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Run_Rotation_Click(object sender, EventArgs e)
        {
            _Rotation_State = runRotation();
        }
        private bool runRotation()
        {
            try
            {
                if (img != null)
                {
                    if (rdo_ROBOT_Con_R.Checked)
                    { 
                        cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 1;
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 0;
                    cur_WorkFlow.RunRotationCalibBlock(ref img);
                    if (cur_WorkFlow.RotationCalibBlock.RunStatus.Result == Cognex.VisionPro.CogToolResultConstants.Accept)
                    {
                        
                        cogRecordDisplayRotation.Record = cur_WorkFlow.RotationCalibBlock.Tools["Nozzle1"].CreateLastRunRecord();
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
                        cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_rotation_UnCalibrated_block.Outputs["X"].Value).ToString("F3"), ((double)_rotation_UnCalibrated_block.Outputs["Y"].Value).ToString("F3")));
                        cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                        cogRecordDisplayRotation.Fit(true);
                        _Rotation_State = true;
                    }
                    else
                    {
                        cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Red;
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
                        if (cur_WorkFlow.RotationCalibBlock.RunStatus.Result == Cognex.VisionPro.CogToolResultConstants.Accept)
                        {
                            cogRecordDisplayRotation.Record = cur_WorkFlow.RotationCalibBlock.Tools["Nozzle2"].CreateLastRunRecord();
                            cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Blue;
                            cogGraphicLabel2.SetXYText(100, 200, string.Format("当前像素坐标XY:({0},{1})", ((double)_rotation_UnCalibrated_block.Outputs["X"].Value).ToString("F3"), ((double)_rotation_UnCalibrated_block.Outputs["Y"].Value).ToString("F3")));
                            cogRecordDisplayRotation.StaticGraphics.Add(cogGraphicLabel2, "");
                            cogRecordDisplayRotation.Fit(true);
                            _Rotation_State = true;
                        }
                        else
                        {
                            cogGraphicLabel2.Color = Cognex.VisionPro.CogColorConstants.Red;
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

        /// <summary>
        /// Rotation添加标定点对
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddMark_Rotation_Click(object sender, EventArgs e)
        {
            addMark_Rotation();
        }
        private bool addMark_Rotation()
        {
            if (!_Rotation_State)
            {
                return false;
            }
            cur_WorkFlow.RotationCalibBlock.Inputs["Index"].Value = 2;
            if (rdo_ROBOT_Con_R.Checked)
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

        /// <summary>
        /// Rotation开始标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rotation_Click(object sender, EventArgs e)
        {
            rotation();
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
                if (rdo_ROBOT_Con_R.Checked)
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 0;
                }
                else
                {
                    cur_WorkFlow.RotationCalibBlock.Inputs["Nozzle"].Value = 1;
                }
                cur_WorkFlow.RotationCalibBlock.Run();
                //标定结果刷新

                if (rdo_ROBOT_Con_R.Checked)
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Rotation_Click(object sender, EventArgs e)
        {
            saveResult_Rotation();
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
                    if (rdo_ROBOT_Con_R.Checked)
                    {
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[0] = RotationCenter_X;
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[0] = RotationCenter_Y;
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[0] = Rotation_RMS;
                    }
                    else
                    {
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[1] = RotationCenter_X;
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[1] = RotationCenter_Y;
                        Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[1] = Rotation_RMS;
                    }
                   
                }
                else if (vppindex == 1)
                {
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_X[nozzleIndex] = RotationCenter_X;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_RMS[nozzleIndex] = Rotation_RMS;
                }
                else if (vppindex == 2)
                {
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_X[nozzleIndex] = RotationCenter_X;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_RMS[nozzleIndex] = Rotation_RMS;
                }
                else if (vppindex == 3)
                {
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_X[nozzleIndex] = RotationCenter_X;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_Y[nozzleIndex] = RotationCenter_Y;
                    Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_RMS[nozzleIndex] = Rotation_RMS;
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
            string ssss=    Project.Instance().VisionManagerInstance._visionParamPath;
                _iniRotation = new IniHelper(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config"  + "\\CameraParams.ini");
                if (ccdIndex == 0)
                {
                    if (rdo_ROBOT_Con_R.Checked)
                    {
                        _iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[0].ToString());
                        _iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[0].ToString());
                        _iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[0].ToString());

                    }
                    else
                    {
                        _iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[1].ToString());
                        _iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[1].ToString());
                        _iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[1].ToString());

                    }
                    _iniRotation.WriteIniKey("camera1", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera1", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera1", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 1)
                {
                    _iniRotation.WriteIniKey("camera2", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_X[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera2", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_Y[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera2", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 2)
                {
                    _iniRotation.WriteIniKey("camera3", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_X[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera3", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_Y[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera3", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3Rotation_RMS[nozzleIndex].ToString());
                }
                else if (ccdIndex == 3)
                {
                    _iniRotation.WriteIniKey("camera4", "RC_X" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_X[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera4", "RC_Y" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_Y[nozzleIndex].ToString());
                    _iniRotation.WriteIniKey("camera4", "RC_RMS" + (nozzleIndex + 1).ToString(), Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4Rotation_RMS[nozzleIndex].ToString());
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

                        if (rdo_ROBOT_Con_R.Checked)
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
        /// Rotation自动标定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Auto_Rotation_Click(object sender, EventArgs e)
        {
            try
            {
                if (_b_Auto_Rotation)
                {
                    return;
                }
                if (!Project.Instance().HardWareStateManagerInstance.L_ccdState[vppindex])
                {
                    MessageBox.Show("CCD未链接!");
                    return;
                }

                if (rdo_ROBOT_Con_R.Checked)
                {
                    //通知ROBOT开始一键标定.
                    if (!Project.Instance().RobotManagerInstance.L_Robot[0].IsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT" + vppindex + ":未链接!");
                        return;
                    }
                    #region //通知ROBOT开始一键标定.
                    //通知ROBOT开始一键标定.
                    try
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCDRobotRCalStart, 0);
                    }
                    catch (Exception)
                    {
                        RefleshRotationTextMsgBox("CCD自动旋转中心标定模式catch......");
                    }
                    #endregion
                }
                else if (rdo_ROBOT2_Con_R.Checked)
                {
                    //通知ROBOT开始一键标定.
                    if (!Project.Instance().RobotManagerInstance.L_Robot[1].IsConnected)
                    {
                        //ROBOT未链接
                        MessageBox.Show("ROBOT2" + ":未链接!");
                        return;
                    }
                   
                    //通知ROBOT开始一键标定.
                    try
                    {
                        Project.Instance().RobotManagerInstance.L_Robot[1].SendText(RobotSignals.CCDRobotRCalStart, 0);
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
                RobotSignals.CCDRobotCal = "1";
                RefleshRotationTextMsgBox("CCD自动旋转中心标定模式开启......");
            }
            catch (Exception ex)
            {
                RefleshRotationTextMsgBox(ex.ToString());
            }
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
        /// <summary>
        /// 连接模式PLC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_PLC_Con_R_Click(object sender, EventArgs e)
        {
            RefleshRotationTextMsgBox("连接模式：PLC");
            this.rdo_ROBOT_Con_R.BackColor = Color.Transparent;
        }
        /// <summary>
        /// 连接模式Robot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdo_ROBOT_Con_R_Click(object sender, EventArgs e)
        {
            RefleshRotationTextMsgBox("连接模式：ROBOT1");
            this.rdo_ROBOT2_Con_R.BackColor = Color.Transparent;
            RefleshRotationDataGridView();
            //this.rdo_PLC_Con_R.BackColor = Color.Transparent;
        }

        private void rdo_Robot_Con_L_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdo_RobotR_Con_R_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：ROBOT2");
            this.rdo_LaserL_Con_L.BackColor = Color.Transparent;
            this.rdo_LaserR_Con_L.BackColor = Color.Transparent;
            this.rdo_Robot_Con_L.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }

        private void rdo_LaserL_Con_L_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：LASER振镜角度1");
            this.rdo_RobotR_Con_R.BackColor = Color.Transparent;
            this.rdo_LaserR_Con_L.BackColor = Color.Transparent;
            this.rdo_Robot_Con_L.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
        }

        private void rdo_ROBOT2_Con_R_Click(object sender, EventArgs e)
        {
            RefleshRotationTextMsgBox("连接模式：ROBOT1");
            this.rdo_ROBOT_Con_R.BackColor = Color.Transparent;
            RefleshRotationDataGridView();
        }

        private void rdo_LaserR_Con_L_Click(object sender, EventArgs e)
        {
            RefleshLinearTextMsgBox("连接模式：LASER振镜角度2");
            this.rdo_LaserL_Con_L.BackColor = Color.Transparent;
            this.rdo_RobotR_Con_R.BackColor = Color.Transparent;
            this.rdo_Robot_Con_L.BackColor = Color.Transparent;
            RefleshLinearDataGridView();
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
