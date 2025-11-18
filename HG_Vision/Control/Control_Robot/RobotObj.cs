using BaseSocket;
using BaseThread;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.ConstantModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using Obj.Obj_Queue;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Windows;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Robot
{
    public class RobotObj : CServerSocket
    {

        #region 字段或者属性
        //服务器状态
        private bool _isConnected = false;
        /// <summary>
        ///服务器连接状态
        /// </summary>
        public bool IsConnected
        {
            set { _isConnected = value; }
            get { return _isConnected; }
        }
        //Robot连接状态
        private List<bool> _isConnectedRobot = new List<bool>() { false, false, false, false };
        private readonly object _isConnectedRobotLock = new object();
        /// <summary>
        ///Robo连接状态
        /// </summary>
        // 线程安全地修改某个元素
        public void SetIsConnectedRobot(int index, bool value)
        {
            lock (_isConnectedRobotLock)
            {
                if (index >= 0 && index < _isConnectedRobot.Count)
                    _isConnectedRobot[index] = value;
            }
        }

        // 线程安全地读取某个元素
        public bool GetIsConnectedRobot(int index)
        {
            lock (_isConnectedRobotLock)
            {
                if (index >= 0 && index < _isConnectedRobot.Count)
                    return _isConnectedRobot[index];
                return false;
            }
        }
        //服务器ip地址
        public IPEndPoint _localEndPoint;

        #region 暂且每一个相机都是独立的，都有所属的自己的业务
        //阻塞队列执行用户线程
        internal List<BlockQueue<TriggerEventArgs>> _taskQueueList = new List<BlockQueue<TriggerEventArgs>>();//相机触发队列集合
        #endregion
        
        #endregion

        #region 构造函数
        public RobotObj(IPEndPoint localEndPoint) : base(localEndPoint)
        {
            _localEndPoint = localEndPoint;

        }
        #endregion

        /// <summary>
        /// 初始化相机线程
        /// </summary>
        public void InitCameraWorkThreads1()
        {
            //因为暂且每一个相机都是独立的，都有所属的自己的业务，因此分别定义工作委托，没有定义通用的CameraWork
            //可按实际情况删除或增加委托
            CameraWorkThrad1 mainWorkThread1 = new CameraWorkThrad1();
            Control_Thread[] _threadStartArray = new Control_Thread[] { mainWorkThread1 };
            if (_threadStartArray.Length < Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum)
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

        #region Robot服务器事件
        /// <summary>
        ///启动服务器Robot
        /// </summary>
        /// <returns></returns>
        public void StartServerRobot()
        {
            this.OnConnect += new CServerSocket.ConnectionDelegate(Server_OnConnect);
            this.OnDisconnect += new CServerSocket.ConnectionDelegate(Server_OnDisconnect);
            this.OnListen += new CServerSocket.ListenDelegate(Server_OnListen);
            this.OnRead += new CServerSocket.ConnectionDelegate(Server_OnRead);
            this.OnWrite += new CServerSocket.ConnectionDelegate(Server_OnWrite);
            if (!this.Active())
            {
                IsConnected = false;
                LogHelper.Info(string.Format("错误：激光服务器启动失败"));
            }
            else
            {
                IsConnected = true;
            }
        }
        /// <summary>
        /// 停止服务器
        /// </summary>
        /// <returns></returns>
        public bool StopServer()
        {
            if (this.Deactive())
            {
                IsConnected = false;
            }
            else
            {
                IsConnected = true;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 服务器链接事件
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnConnect(Socket soc)
        {
            Threadwatch.ClientIPNum++;
            if (!Threadwatch.ListConnectIPs.Contains((soc.RemoteEndPoint as IPEndPoint).Address.ToString()))
            {
                Threadwatch.ListConnectIPs.Add((soc.RemoteEndPoint as IPEndPoint).Address.ToString());
            }

            if ((soc.RemoteEndPoint as IPEndPoint).Address.ToString() == Threadwatch.ListConnectIPs[0])
            {
                SetIsConnectedRobot(0, true);

            }
        }
        /// <summary>
        /// 断开服务器链接事件
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnDisconnect(Socket soc)
        {
            Threadwatch.ClientIPNum--;
        }

        //负责监听客户端的线程:创建一个监听线程  
        private WatchConnectingThread Threadwatch = new WatchConnectingThread();
        /// <summary>
        /// 服务器开始监听
        /// </summary>
        private void Server_OnListen()
        {
            //将窗体线程设置为与后台同步，随着主线程结束而结束  
            Threadwatch.IsBackground = true;

            //启动线程     
            Threadwatch.Initialize();
        }
        /// <summary>
        /// 服务器接收数据事件
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnRead(Socket soc)
        {
            if (RobotSignalsModel.CCDProcess == 0)//0-自动运行
            {
                string receive_string = this.ReceivedText;
                if ((this._localEndPoint.Port).ToString() == Project.Instance.RobotManagerInstance.L_Robot[2]._localEndPoint.Port.ToString())
                {
					Project.Instance.RobotManagerInstance.m_strLaserReceive = receive_string;
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
        }

        /// <summary>
        ///服务器写数据
        /// </summary>
        /// <param name="soc"></param>
        private void Server_OnWrite(Socket soc)
        {
        }
        #endregion
    }
}
