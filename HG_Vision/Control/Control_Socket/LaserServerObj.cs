using BaseThread;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.EnumModel;
using Model.SocketModel;
using Obj.Obj_File;
using Obj.Obj_Queue;
using Obj.Obj_Socket;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows;
namespace HG_Vision.Contol.Control_Socket
{
    /// <summary>
    /// 机器人对象（仅实现个性逻辑）
    /// </summary>
    public class LaserServerObj : ServerObj
    {
        #region 激光专属属性
        //阻塞队列执行用户线程
        internal List<BlockQueue<TriggerEventArgs>> _taskQueueList = new List<BlockQueue<TriggerEventArgs>>();//相机触发队列集合
        #endregion

        #region 激光专属构造函数
        public LaserServerObj(string deviceId, string ip, string port) : base(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)))
        {
            DeviceId = deviceId;
            DeviceType = eDeviceType.Laser;
            DeviceName = $"激光_{deviceId}";
        }
        #endregion

        #region 激光专属方法

        /// <summary>
        /// 初始化相机线程
        /// </summary>
        public void InitCameraWorkThreads1()
        {
            //因为暂且每一个相机都是独立的，都有所属的自己的业务，因此分别定义工作委托，没有定义通用的CameraWork
            //可按实际情况删除或增加委托
            CameraWorkThrad1 mainWorkThread1 = new CameraWorkThrad1();
            Control_Thread[] _threadStartArray = new Control_Thread[] { mainWorkThread1 };
            if (_threadStartArray.Length < Project.Instance.GlobalManagerInstance.GlobalParamsModel.WorkFlowNum)
            {
                MessageBox.Show("相机线程数量不足工作流程数量，请检查代码或配置文件！", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //相机线程
            for (int i = 0; i < _threadStartArray.Length; i++)
            {
                int index = i;
                //装填队列集合
                _taskQueueList.Add(new BlockQueue<TriggerEventArgs>(20));
            }
            //实例化工作线程，并启动
            mainWorkThread1.TaskQueueListC1 = _taskQueueList[0];
            mainWorkThread1.Initialize();//启动主工作线程
            //后续相机处理线程可在此处添加
        }
        protected override void Server_OnRead(Socket soc)
        {
            if (SignalsModel.CCDProcess == 0)//0-自动运行
            {
                string receive_string = this.ReceivedText;
                string[] str = receive_string.Split(',');
                if (str.Length > 2 && (str[0].Contains("T1") || str[0].Contains("T2")))
                {
                    LogHelper.Info("收到激光触发：" + receive_string);
                    receive_string.Split(',');
                    TriggerEventArgs _e = new TriggerEventArgs
                    {
                        FlowIdx = 0,
                        eMode = Model.EnumModel.eProcessMode.produce,
                        NozzleIdx = str[0].Contains("T1") ? 0 : 1
                    };
                    _taskQueueList[0].Enqueue(_e);
                }
            }
        }
        #endregion
    }
}