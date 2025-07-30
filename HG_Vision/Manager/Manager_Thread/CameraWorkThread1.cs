using BaseThread;
using Cognex.VisionPro;
using HG_Vision.Contol.Control_PLC;
using HG_Vision.Contol.Control_Vision;
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
using System.Diagnostics;
using System.Text;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class CameraWorkThrad1 : Control_Thread
    {
        private BlockQueue<TriggerEventArgs> _taskQueueList;//相机触发队列集合
        internal BlockQueue<TriggerEventArgs> TaskQueueList
        {
            private get { return _taskQueueList; }
            set { _taskQueueList = value; }
        }
        Stopwatch watch1 = new Stopwatch();//计算程序耗时
        Stopwatch watch2 = new Stopwatch();//计算程序耗时
        private volatile int[] _camResult = new int[Project.Instance.VisionManagerInstance.CameraNum];//相机结果标识
        private volatile bool[] _camComplete = new bool[Project.Instance.VisionManagerInstance.CameraNum]; //相机完成标识

        private double Cam1posXRob1 = 0.0;
        private double Cam1posYRob1 = 0.0;
        private double Cam1posRRob1 = 0.0;
        private double Cam1posXRob2 = 0.0;
        private double Cam1posYRob2 = 0.0;
        private double Cam1posRRob2 = 0.0;
        private double Cam1posXLas1 = 0.0;
        private double Cam1posYLas1 = 0.0;
        private double Cam1posRLas1 = 0.0;
        private double Cam1posXLas2 = 0.0;
        private double Cam1posYLas2 = 0.0;
        private double Cam1posRLas2 = 0.0;

        private double WeldLength = 0.0;
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
            {
                e = _taskQueueList.Dequeue();
            }
            if (null == e)
            {
                LogHelper.Info("TaskQueueList[0]队列内以已无元素且停止加入新元素！");
                return;
            }
            int _workFlowIndex = e.Index;

            try
            {
                #region 模拟视觉 
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
                #endregion

                #region 
                for (int i = 0; i < NozzleNum; i++)
                {
                    //基准1
                    stdX1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[i];
                    stdY1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[i];
                    stdT1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[i];
                    //补偿1
                    addX1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[i];
                    addY1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[i];
                    addT1[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[i];
                    //基准2
                    stdX2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[i];
                    stdY2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[i];
                    stdT2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[i];
                    //补偿2
                    addX2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[i];
                    addY2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[i];
                    addT2[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[i];
                    //基准3
                    stdX3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[i];
                    stdY3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[i];
                    stdT3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[i];
                    //补偿3
                    addX3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[i];
                    addY3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[i];
                    addT3[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[i];
                    //基准4
                    stdX4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[i];
                    stdY4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[i];
                    stdT4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[i];
                    //补偿4
                    addX4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[i];
                    addY4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[i];
                    addT4[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[i];

                    ////旋转中心
                    //Rotation_X[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_X[i];
                    //Rotation_Y[i] = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1Rotation_Y[i];
                }



                #endregion

                #region 额外补偿
                double AddR1J1X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[0];
                double AddR1J1Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[0];
                double AddR2J1X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[0];
                double AddR2J1Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[0];
                double AddL1J1X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[0];
                double AddL1J1Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[0];
                double AddL1J1X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[0];
                double AddL1J1Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[0];
                double AddL1J1X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[0];
                double AddL1J1Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[0];
                double AddL1J1X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[0];
                double AddL1J1Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[0];
                double AddL2J1X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[0];
                double AddL2J1Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[0];
                double AddL2J1X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[0];
                double AddL2J1Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[0];
                double AddL2J1X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[0];
                double AddL2J1Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[0];
                double AddL2J1X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[0];
                double AddL2J1Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[0];

                double AddR1J2X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[0];
                double AddR1J2Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[0];
                double AddR2J2X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[0];
                double AddR2J2Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[0];
                double AddL1J2X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[0];
                double AddL1J2Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[0];
                double AddL1J2X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[0];
                double AddL1J2Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[0];
                double AddL1J2X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[0];
                double AddL1J2Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[0];
                double AddL1J2X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[0];
                double AddL1J2Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[0];
                double AddL2J2X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[0];
                double AddL2J2Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[0];
                double AddL2J2X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[0];
                double AddL2J2Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[0];
                double AddL2J2X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[0];
                double AddL2J2Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[0];
                double AddL2J2X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[0];
                double AddL2J2Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[0];

                double AddR1J3X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[0];
                double AddR1J3Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[0];
                double AddR2J3X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[0];
                double AddR2J3Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[0];
                double AddL1J3X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[0];
                double AddL1J3Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[0];
                double AddL1J3X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[0];
                double AddL1J3Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[0];
                double AddL1J3X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[0];
                double AddL1J3Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[0];
                double AddL1J3X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[0];
                double AddL1J3Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[0];
                double AddL2J3X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[0];
                double AddL2J3Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[0];
                double AddL2J3X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[0];
                double AddL2J3Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[0];
                double AddL2J3X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[0];
                double AddL2J3Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[0];
                double AddL2J3X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[0];
                double AddL2J3Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[0];

                double AddR1J4X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[0];
                double AddR1J4Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[0];
                double AddR2J4X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[0];
                double AddR2J4Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[0];
                double AddL1J4X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[0];
                double AddL1J4Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[0];
                double AddL1J4X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[0];
                double AddL1J4Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[0];
                double AddL1J4X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[0];
                double AddL1J4Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[0];
                double AddL1J4X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[0];
                double AddL1J4Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[0];
                double AddL2J4X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[0];
                double AddL2J4Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[0];
                double AddL2J4X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[0];
                double AddL2J4Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[0];
                double AddL2J4X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[0];
                double AddL2J4Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[0];
                double AddL2J4X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[0];
                double AddL2J4Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[0];

                double AddR1J5X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[0];
                double AddR1J5Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[0];
                double AddR2J5X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[0];
                double AddR2J5Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[0];
                double AddL1J5X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[0];
                double AddL1J5Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[0];
                double AddL1J5X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[0];
                double AddL1J5Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[0];
                double AddL1J5X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[0];
                double AddL1J5Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[0];
                double AddL1J5X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[0];
                double AddL1J5Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[0];
                double AddL2J5X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[0];
                double AddL2J5Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[0];
                double AddL2J5X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[0];
                double AddL2J5Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[0];
                double AddL2J5X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[0];
                double AddL2J5Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[0];
                double AddL2J5X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[0];
                double AddL2J5Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[0];

                double AddR1J6X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[0];
                double AddR1J6Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[0];
                double AddR2J6X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[0];
                double AddR2J6Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[0];
                double AddL1J6X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[0];
                double AddL1J6Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[0];
                double AddL1J6X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[0];
                double AddL1J6Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[0];
                double AddL1J6X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[0];
                double AddL1J6Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[0];
                double AddL1J6X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[0];
                double AddL1J6Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[0];
                double AddL2J6X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[0];
                double AddL2J6Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[0];
                double AddL2J6X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[0];
                double AddL2J6Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[0];
                double AddL2J6X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[0];
                double AddL2J6Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[0];
                double AddL2J6X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[0];
                double AddL2J6Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[0];

                double AddR1J7X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[0];
                double AddR1J7Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[0];
                double AddR2J7X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[0];
                double AddR2J7Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[0];
                double AddL1J7X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[0];
                double AddL1J7Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[0];
                double AddL1J7X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[0];
                double AddL1J7Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[0];
                double AddL1J7X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[0];
                double AddL1J7Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[0];
                double AddL1J7X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[0];
                double AddL1J7Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[0];
                double AddL2J7X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[0];
                double AddL2J7Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[0];
                double AddL2J7X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[0];
                double AddL2J7Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[0];
                double AddL2J7X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[0];
                double AddL2J7Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[0];
                double AddL2J7X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[0];
                double AddL2J7Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[0];

                double AddR1J8X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[0];
                double AddR1J8Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[0];
                double AddR2J8X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[0];
                double AddR2J8Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[0];
                double AddL1J8X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[0];
                double AddL1J8Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[0];
                double AddL1J8X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[0];
                double AddL1J8Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[0];
                double AddL1J8X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[0];
                double AddL1J8Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[0];
                double AddL1J8X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[0];
                double AddL1J8Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[0];
                double AddL2J8X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[0];
                double AddL2J8Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[0];
                double AddL2J8X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[0];
                double AddL2J8Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[0];
                double AddL2J8X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[0];
                double AddL2J8Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[0];
                double AddL2J8X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[0];
                double AddL2J8Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[0];

                double AddR1J9X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[0];
                double AddR1J9Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[0];
                double AddR2J9X = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[0];
                double AddR2J9Y = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[0];
                double AddL1J9X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[0];
                double AddL1J9Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[0];
                double AddL1J9X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[0];
                double AddL1J9Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[0];
                double AddL1J9X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[0];
                double AddL1J9Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[0];
                double AddL1J9X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[0];
                double AddL1J9Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[0];
                double AddL2J9X1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[0];
                double AddL2J9Y1 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[0];
                double AddL2J9X2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[0];
                double AddL2J9Y2 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[0];
                double AddL2J9X3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[0];
                double AddL2J9Y3 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[0];
                double AddL2J9X4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[0];
                double AddL2J9Y4 = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[0];


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

                ICogImage img = null;
                watch1.Reset();
                watch1.Start();
                //Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunAcquireBlock(out img);
                bool bResult = Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunAcquireBlock(out img);
                if (img == null && !bResult)
                {
                    Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunAcquireBlock(out img);
                }
                Int32 offSetX = Convert.ToInt32((Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[_workFlowIndex]) / 0.005116);
                watch1.Stop();
                watch2.Reset();
                watch2.Start();
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMin"].Value = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[_workFlowIndex];
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductDistanceMax"].Value = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[_workFlowIndex];
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMin"].Value = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[_workFlowIndex];
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["AngleMax"].Value = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[_workFlowIndex];
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["ProductGrayValue"].Value = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[_workFlowIndex];
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Inputs["OffsetX"].Value = offSetX;
                Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].RunProcessBlock(ref img);

                var mSeconds1 = watch1.ElapsedMilliseconds;


                if (!Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].UpdateGraphicResult(GlobalCameraParams.cameraVisionControlList[_workFlowIndex]))
                {
                    //相机掉线
                    LogHelper.Error($"{_workFlowIndex + 1}相机掉线");  //写日志
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[e.Index], CogColorConstants.Red, 0, 0, "相机掉线", 60);
                    _camResult[_workFlowIndex] = 0;

                    if ((Project.Instance.RobotManagerInstance.WaitStringN(RobotSignals.RobotNGetResult1, 30)))
                    {
                        Project.Instance.RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    else
                    {
                        Project.Instance.RobotManagerInstance.L_Robot[0].SendText(RobotSignals.CCD1RobotResultNG, 0);
                    }
                    Project.Instance.ProductionDataManagerInstance.L_ProductionStationNGCount[0]++;
                    _camComplete[e.Index] = false;
                    return;
                }



                Project.Instance.ProductionDataManagerInstance.L_productionCCDSumCountList[0][_workFlowIndex]++;
                bool isOk = false;
                Int16 FontSize = 15;
                bool bAccept = (bool)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["bAccept"].Value;
                string sError = (string)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["sError"].Value;
                double Pangle = (double)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["Angle"].Value;

                watch2.Stop();
                var mSeconds2 = watch2.ElapsedMilliseconds;
                string _code1 = "";
                string _code2 = "";
                int _jiajuhao = 0;
                double _spacing = 0.0;
                double _spacing1 = 0.0;

                byte[] _plcdataD100 = new byte[90];
                _plcdataD100 = Project.Instance.PLCManagerInstance.Read("D100", 45);
                _code1 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcdataD100, 2, 40))).Trim().Replace(":", "-");
                _code2 = Encoding.ASCII.GetString(RegisterDataProcessing.Remove_zero(RegisterDataProcessing.ReverseBytes(_plcdataD100, 42, 40))).Trim().Replace(":", "-");
                _jiajuhao = BitConverter.ToInt16(RegisterDataProcessing.ReverseBytes(_plcdataD100, 0, 2), 0);

                _spacing = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcdataD100, 82, 4), 0);
                _spacing1 = BitConverter.ToSingle(RegisterDataProcessing.ReverseBytes(_plcdataD100, 86, 4), 0);

                if (bAccept)
                {
                    #region 读取vpp上的ResultList
                    isOk = true;
                    List<double[]> ListResult1 = new List<double[]>();
                    List<double[]> ListResult2 = new List<double[]>();
                    List<double[]> ListResult3 = new List<double[]>();
                    List<double[]> ListResult4 = new List<double[]>();

                    ListResult1 = (List<double[]>)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList1"].Value;
                    ListResult2 = (List<double[]>)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList2"].Value;
                    ListResult3 = (List<double[]>)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList3"].Value;
                    ListResult4 = (List<double[]>)Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[_workFlowIndex].ProcessBlock.Outputs["ResultList4"].Value;
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

                    dX1[0] = -(stdX1[0] - Cam1posXRob1) + addX1[0];
                    dX2[0] = -(stdX2[0] - Cam1posXRob2) + addX2[0];
                    dX3[0] = -(stdX3[0] - Cam1posXLas1) + addX3[0];
                    dX4[0] = -(stdX4[0] - Cam1posXLas2) + addX4[0];          //相机X偏移

                    dY1[0] = -(stdY1[0] - Cam1posYRob1) + addY1[0];
                    dY2[0] = -(stdY2[0] - Cam1posYRob2) + addY2[0];
                    dY3[0] = -(stdY3[0] - Cam1posYLas1) + addY3[0];
                    dY4[0] = -(stdY4[0] - Cam1posYLas2) + addY4[0];          //相机y偏移

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
                        LengthC = -(AddL1J1X2 - AddL1J1X1);
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
                        LengthC = -(AddL1J2X2 - AddL1J2X1);

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
                        LengthC = -(AddL1J3X2 - AddL1J3X1);

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
                        LengthC = -(AddL1J4X2 - AddL1J4X1);

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
                        LengthC = -(AddL1J5X2 - AddL1J5X1);

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
                        LengthC = -(AddL1J6X2 - AddL1J6X1);

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
                        LengthC = -(AddL1J7X2 - AddL1J7X1);

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
                        LengthC = -(AddL1J8X2 - AddL1J8X1);

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
                        LengthC = -(AddL1J9X2 - AddL1J9X1);

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
                    string q = _spacing.ToString("f3");
                    if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[_workFlowIndex] == 1.0)
                    {
                        //工位一间距
                        double SpecingX = Math.Round((Convert.ToDouble(_spacing.ToString("f3")) - Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[_workFlowIndex]), 3);
                        //工位二间距
                        double SpecingX2 = Math.Round((Convert.ToDouble(_spacing1.ToString("f3")) - Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[_workFlowIndex]), 3);

                        AddL1X3 = AddL1X3 + SpecingX;
                        AddL1X4 = AddL1X4 + SpecingX;

                        AddL2X3 = AddL2X3 + SpecingX2;
                        AddL2X4 = AddL2X4 + SpecingX2;
                    }


                    Project.Instance.ProductionDataManagerInstance.L_productionCCDOKCountList[0][_workFlowIndex]++;
                    FinalResult = "OK";

                }
                else
                {
                    isOk = false;
                    Project.Instance.ProductionDataManagerInstance.L_productionCCDNGCountList[0][_workFlowIndex]++;
                    FinalResult = "NG";
                }
                _camResult[_workFlowIndex] = isOk ? 1 : 2;

                if (Project.Instance.RobotManagerInstance.m_strLaserReceive.Contains("T1"))
                {
                    double limitMIN = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[_workFlowIndex];
                    double limitMAX = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[_workFlowIndex];
                    bool OutLimit = false;
                    if (dX1[0] < limitMIN || dX1[0] > limitMAX || dX3[0] < limitMIN || dX3[0] > limitMAX || dY1[0] < limitMIN || dY1[0] > limitMAX || dY3[0] < limitMIN || dY3[0] > limitMAX)
                    {
                        isOk = false;
                        OutLimit = true;
                        FinalResult = "NG";
                    }
                    if (!isOk)
                    {

                        string sendtorob = "PGE" + ";" + "0" + ";" + "2" + ";" + "0" + ";" + AddR1X.ToString("f3") + ";" + AddR1Y.ToString("f3") + ";" + "0" + ";" + "\r\n";  //

                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[0] != 1)
                        {
                            sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "\r\n";
                        }

                        string sendtolasb = "_NG;" + AddL1X1.ToString("f3") + "%" + AddL1Y1.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10" + "#" + AddL1X3.ToString("f3") + "%" + AddL1Y3.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10" + "#" + AddL1X4.ToString("f3") + "%" + AddL1Y4.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10";

                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[0] != 1)
                        {
                            sendtolasb = "_OK;" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10";
                        }

                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.weldlength[0] = LengthC + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[0];

                        Project.Instance.RobotManagerInstance.L_Robot[0].SendText(sendtorob, 0);
                        Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendtolasb, 0);
                        Project.Instance.ProductionDataManagerInstance.L_ProductionStationNGCount[0]++;
                        _camComplete[e.Index] = false;
                        LogHelper.Info("给到机械手返回：" + sendtorob);
                        NoticeHelper.OutputMessageSend("给到机械手返回" + sendtorob, OutputLevelModel.INFO);

                    }
                    else
                    {
                        string sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + AddR1X.ToString("f3") + ";" + AddR1Y.ToString("f3") + ";" + "0" + ";" + "\r\n";  //
                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[0] != 1)
                        {
                            sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "\r\n";
                        }
                        string sendtolasb = "_OK;" + AddL1X1.ToString("f3") + "%" + AddL1Y1.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                + "#" + AddL1X3.ToString("f3") + "%" + AddL1Y3.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                + "#" + AddL1X4.ToString("f3") + "%" + AddL1Y4.ToString("f3") + "%" + dT3[0].ToString("f3") + "%" + posXLAS1[0].ToString("f3") + "%" + posYLAS1[0].ToString("f3") + "%" + "10" + "%" + "10";

                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[0] != 1)
                        {
                            sendtolasb = "_OK;" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10";
                        }
                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.weldlength[0] = LengthC + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[0];

                        Project.Instance.RobotManagerInstance.L_Robot[0].SendText(sendtorob, 0);
                        Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendtolasb, 0);
                        WeldLength = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.weldlength[0];
                        Project.Instance.ProductionDataManagerInstance.L_ProductionStationOKCount[0]++;
                        _camComplete[e.Index] = true;
                        LogHelper.Info("给到机械手返回：" + sendtorob);
                        NoticeHelper.OutputMessageSend("给到机械手返回" + sendtorob, OutputLevelModel.INFO);

                    }

                    ///显示界面:
                    CogColorConstants Color = isOk ? CogColorConstants.Green : CogColorConstants.Red;
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], Color, 0, 0, string.Format("{0}", FinalResult), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 2, "取像时间：" + mSeconds1.ToString() + "ms", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 4, "处理时间：" + mSeconds2.ToString() + "ms", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 6, "机械手1偏移X：" + AddR1X.ToString("f3") + "Y：" + AddR1Y.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 8, "机械手1当前X：" + Cam1posXRob1.ToString("f3") + "Y：" + Cam1posYRob1.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 10, "焊点1偏移 X：" + (AddL1X1).ToString("f3") + "Y：" + (AddL1Y1).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 12, "焊点2偏移 X：" + (AddL1X2).ToString("f3") + "Y：" + (AddL1Y2).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 14, "焊点3偏移 X：" + (AddL1X3).ToString("f3") + "Y：" + (AddL1Y3).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 16, "焊点4偏移 X：" + (AddL1X4).ToString("f3") + "Y：" + (AddL1Y4).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 18, "焊点偏移X：" + dX3[0].ToString("f3") + "Y：" + dY3[0].ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 20, "弹夹角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 22, "胶片角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 24, "极耳间距：" + _spacing.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 26, "工位号：" + "1(面朝屏幕右手端)", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 28, "夹具号：" + _jiajuhao, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 30, "电池条码：" + _code1, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 32, DateTime.Now.ToString("HH:mm:ss"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 36, sError, FontSize);//YBR
                    if (OutLimit == true)
                    {
                        WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 34, "偏移值超限NG", FontSize);

                    }

                    #region 保存数据
                    string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                    string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,机械手偏移Angle,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,焊点偏移X,焊点偏移Y,胶片角度Angle,弹夹角度Angle,时间,编码,极耳间距";
                    File_CSV csv = new File_CSV();
                    strLogData[0] = FinalResult;
                    strLogData[1] = "1";
                    strLogData[2] = _jiajuhao.ToString();
                    strLogData[3] = AddR1X.ToString("f3");//YB
                    strLogData[4] = AddR1Y.ToString("f3");
                    //strLogData[3] = dX1[0].ToString("f3");
                    //strLogData[4] = dY1[0].ToString("f3");
                    strLogData[5] = dT1[0].ToString("f3");
                    strLogData[6] = (AddL1X1).ToString("f3");
                    strLogData[7] = (AddL1Y1).ToString("f3");
                    strLogData[8] = (AddL1X2).ToString("f3");
                    strLogData[9] = (AddL1Y2).ToString("f3");
                    strLogData[10] = (AddL1X3).ToString("f3");
                    strLogData[11] = (AddL1Y3).ToString("f3");
                    strLogData[12] = (AddL1X4).ToString("f3");
                    strLogData[13] = (AddL1Y4).ToString("f3");
                    strLogData[14] = dX3[0].ToString("f3");
                    strLogData[15] = dY3[0].ToString("f3");
                    strLogData[16] = Pangle.ToString("f3");
                    strLogData[17] = Pangle.ToString("f3");
                    strLogData[18] = string.Format("{0}{1:000}", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.Millisecond);
                    strLogData[19] = _code1.ToString();
                    strLogData[20] = _spacing.ToString("f3");
                    csv.AppendToCsv(strHead, strLogData, "PositionData");
                    #endregion  
                    #region 存图
                    //VP或者Halcon存图
                    e.resultImage = GlobalCameraParams.cameraVisionControlList[e.Index];
                    e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[e.Index].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                    //e.imageName = (e.Index +1).ToString() + "1" + "-" + _jiajuhao.ToString() + "-" + _code1.ToString();
                    e.imageName = "1" + "-" + _jiajuhao.ToString() + "-" + _code1.ToString();
                    e.results = isOk;
                    Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.Index].Enqueue(e);
                    #endregion
                    #endregion
                    // 生成40个空格的字符串
                    string Null_String = new string(' ', 40);
                    Project.Instance.PLCManagerInstance.WriteString("D101", Null_String, 40);
                }
                else
                {
                    double limitMIN = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[_workFlowIndex];
                    double limitMAX = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[_workFlowIndex];
                    bool OutLimit = false;
                    if (dX2[0] < limitMIN || dX2[0] > limitMAX || dX4[0] < limitMIN || dX4[0] > limitMAX || dY2[0] < limitMIN || dY2[0] > limitMAX || dY4[0] < limitMIN || dY4[0] > limitMAX)
                    {
                        isOk = false;
                        OutLimit = true;
                        FinalResult = "NG";

                    }

                    ////这里接受plc数据，先判断plc的连接，再进行标签读取工作
                    //string _code = "";
                    // _code = Project.Instance.PLCManagerInstance.ReadString("",10);

                    if (!isOk)
                    {


                        string sendtorob = "PGE" + ";" + "0" + ";" + "2" + ";" + "0" + ";" + AddR2X.ToString("f3") + ";" + AddR2Y.ToString("f3") + ";" + "0" + ";" + "\r\n";  //

                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[0] != 1)
                        {
                            sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "\r\n";
                        }
                        string sendtolasb = "_NG;" + AddL2X1.ToString("f3") + "%" + AddL2Y1.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                   + "#" + AddL2X3.ToString("f3") + "%" + AddL2Y3.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                   + "#" + AddL2X4.ToString("f3") + "%" + AddL2Y4.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10";
                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[0] != 1)
                        {
                            sendtolasb = "_OK;" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10";
                        }

                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.weldlength[0] = LengthC + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[0];

                        Project.Instance.RobotManagerInstance.L_Robot[1].SendText(sendtorob, 0);
                        Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendtolasb, 0);
                        Project.Instance.ProductionDataManagerInstance.L_ProductionStationNGCount[0]++;
                        _camComplete[e.Index] = false;
                        LogHelper.Info("给到机械手返回：" + sendtorob);
                        NoticeHelper.OutputMessageSend("给到机械手返回" + sendtorob, OutputLevelModel.INFO);

                    }
                    else
                    {

                        string sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + AddR2X.ToString("f3") + ";" + AddR2Y.ToString("f3") + ";" + "0" + ";" + "\r\n";  //

                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[0] != 1)
                        {
                            sendtorob = "PGE" + ";" + "0" + ";" + "1" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "0" + ";" + "\r\n";
                        }

                        string sendtolasb = "_OK;" + AddL2X1.ToString("f3") + "%" + AddL2Y1.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                 + "#" + AddL2X3.ToString("f3") + "%" + AddL2Y3.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10"
                                                 + "#" + AddL2X4.ToString("f3") + "%" + AddL2Y4.ToString("f3") + "%" + dT4[0].ToString("f3") + "%" + posXLAS2[0].ToString("f3") + "%" + posYLAS2[0].ToString("f3") + "%" + "10" + "%" + "10";
                        if (Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[0] != 1)
                        {
                            sendtolasb = "_OK;" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10"
                                                + "#" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "0" + "%" + "10" + "%" + "10";
                        }

                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.weldlength[0] = LengthC + Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[0];

                        Project.Instance.RobotManagerInstance.L_Robot[1].SendText(sendtorob, 0);
                        Project.Instance.RobotManagerInstance.L_Robot[2].SendText(sendtolasb, 0);

                        Project.Instance.ProductionDataManagerInstance.L_ProductionStationOKCount[0]++;
                        _camComplete[e.Index] = true;
                        LogHelper.Info("给到机械手返回：" + sendtorob);
                        NoticeHelper.OutputMessageSend("给到机械手返回" + sendtorob, OutputLevelModel.INFO);

                    }


                    ///显示界面:
                    CogColorConstants Color = isOk ? CogColorConstants.Green : CogColorConstants.Red;
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], Color, 0, 0, string.Format("{0}", FinalResult), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 2, "取像时间：" + mSeconds1.ToString() + "ms", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 4, "处理时间：" + mSeconds2.ToString() + "ms", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 6, "机械手2偏移X：" + AddR2X.ToString("f3") + "Y：" + AddR2Y.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 8, "机械手2当前X：" + Cam1posXRob2.ToString("f3") + "Y：" + Cam1posYRob2.ToString("f3"), FontSize);

                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 10, "焊点1偏移 X：" + (AddL2X1).ToString("f3") + "Y：" + (AddL2Y1).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 12, "焊点2偏移 X：" + (AddL2X2).ToString("f3") + "Y：" + (AddL2Y2).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 14, "焊点3偏移 X：" + (AddL2X3).ToString("f3") + "Y：" + (AddL2Y3).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 16, "焊点4偏移 X：" + (AddL2X4).ToString("f3") + "Y：" + (AddL2Y4).ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 18, "焊点偏移X：" + dX4[0].ToString("f3") + "Y：" + dY4[0].ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 20, "弹夹角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 22, "胶片角度：" + Pangle.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 24, "极耳间距：" + _spacing1.ToString("f3"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 26, "工位号：" + "2(面朝屏幕左手端)", FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 28, "夹具号：" + _jiajuhao, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 30, "电池条码：" + _code2, FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Blue, 0, FontSize * 32, DateTime.Now.ToString("HH:mm:ss"), FontSize);
                    WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 36, sError, FontSize);//YBH
                    if (OutLimit == true)
                    {
                        WorkFlow.DisplayLabelCogDisplay(GlobalCameraParams.cameraVisionControlList[_workFlowIndex], CogColorConstants.Red, 0, FontSize * 34, "偏移值超限NG", FontSize);

                    }

                    #region 保存数据
                    string[] strLogData = { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
                    string strHead = "状态,工位,夹具,机械手偏移X,机械手偏移Y,机械手偏移Angle,焊点1X,焊点1Y,焊点2X,焊点2Y,焊点3X,焊点3Y,焊点4X,焊点4Y,焊点偏移X,焊点偏移Y,胶片角度Angle,弹夹角度Angle,时间,编码,极耳间距";
                    File_CSV csv = new File_CSV();
                    strLogData[0] = FinalResult;
                    strLogData[1] = "2";
                    strLogData[2] = _jiajuhao.ToString();
                    strLogData[3] = AddR2X.ToString("f3");//YB
                    strLogData[4] = AddR2Y.ToString("f3");
                    //strLogData[3] = dX2[0].ToString("f3");
                    //strLogData[4] = dY2[0].ToString("f3");
                    strLogData[5] = dT2[0].ToString("f3");
                    strLogData[6] = (AddL2X1).ToString("f3");
                    strLogData[7] = (AddL2Y1).ToString("f3");
                    strLogData[8] = (AddL2X2).ToString("f3");
                    strLogData[9] = (AddL2Y2).ToString("f3");
                    strLogData[10] = (AddL2X3).ToString("f3");
                    strLogData[11] = (AddL2Y3).ToString("f3");
                    strLogData[12] = (AddL2X4).ToString("f3");
                    strLogData[13] = (AddL2Y4).ToString("f3");
                    strLogData[14] = dX4[0].ToString("f3");
                    strLogData[15] = dY4[0].ToString("f3");
                    strLogData[16] = Pangle.ToString("f3");
                    strLogData[17] = Pangle.ToString("f3");
                    strLogData[18] = string.Format("{0}{1:000}", DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.Millisecond);
                    strLogData[19] = _code2.ToString();
                    strLogData[20] = _spacing1.ToString("f3");
                    csv.AppendToCsv(strHead, strLogData, "PositionData");
                    #endregion

                    #region 存图
                    ////VP或者Halcon存图
                    //e.resultImage = GlobalCameraParams.cameraVisionControlList[e.Index];
                    //e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[e.Index].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                    //e.imageName = (e.Index + 1).ToString() + "2" + "-" + _jiajuhao.ToString() + "-" + _code2.ToString();
                    //e.results = isOk;
                    //Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.mSaveImageQueue[e.Index].Enqueue(e);

                    //VP或者Halcon存图
                    e.resultImage = GlobalCameraParams.cameraVisionControlList[e.Index];
                    e.rawImage = Project.Instance.VisionManagerInstance.CameraManagerInstance.L_workFlowList[e.Index].ProcessBlock.Inputs["InputImage"].Value as ICogImage;
                    //e.imageName = (e.Index + 1).ToString() + "2" + "-" + _jiajuhao.ToString() +"-" + _code2.ToString();
                    e.imageName = "2" + "-" + _jiajuhao.ToString() + "-" + _code2.ToString();
                    e.results = isOk;
                    Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.saveImageQueueList[e.Index].Enqueue(e);


                    #endregion
                    string Null_String = new string(' ', 40);
                    Project.Instance.PLCManagerInstance.WriteString("D121", Null_String, 40);
                }



                #region 更新界面显示良率
                //良率统计
                Action act = () =>
                {
                    NoticeHelper.UpdateYieldTableMessageSend(DeviceStatisticsModels.XCCD, e.Index);
                    NoticeHelper.UpdateCapaticyChartMessageSend(0);
                };
                if (!act.TryCatch($"相机{e.Index + 1}重新刷新良率统计出现异常！"))
                {
                    //SendPLCMessage($"相机{e.Index + 1}重新刷新良率统计出现异常！", ConstantModel.NG);
                }
                #endregion

            }
            catch (Exception ex)
            {
                _camResult[e.Index] = 0;
                _camComplete[e.Index] = false;
                //SendPLCMessage("相机" + (e.Index + 1).ToString() + $"图像处理失败，抛出异常，请检查原因！", ConstantModel.NG);
                LogHelper.Error($"处理{e.Index + 1}相机检测出现异常", ex);  //写日志
            }
        }
    }
}
