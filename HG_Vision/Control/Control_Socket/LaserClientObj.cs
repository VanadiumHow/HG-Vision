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
    public class LaserClientObj : ClientObj
    {
        #region 激光专属属性
        //阻塞队列执行用户线程
        internal List<BlockQueue<TriggerEventArgs>> _taskQueueList = new List<BlockQueue<TriggerEventArgs>>();//相机触发队列集合
        #endregion

        #region 激光专属构造函数
        public LaserClientObj(string deviceId, string ip, string port) : base(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)))
        {
            DeviceId = deviceId;
            DeviceType = eDeviceType.Laser;
            DeviceName = $"激光_{deviceId}";
        }
        #endregion

        #region 激光专属方法
        #endregion
    }
}