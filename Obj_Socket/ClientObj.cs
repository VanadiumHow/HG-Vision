using BaseSocket;
using Model.EnumModel;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

/****************************************************************
此类是本软件作为客户端设备的基类对象，设备对象应继承此类以实现不同设备的个性化逻辑
*****************************************************************/
namespace Obj.Obj_Socket
{
    public class ClientObj : CClientSocket
    {

        #region 字段或者属性
        /// <summary>
        /// 设备唯一标识（可用Robot0等命名）
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// 设备中文名称
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// 设备类型（枚举，便于分类判断）
        /// </summary>
        public eDeviceType DeviceType { get; protected set; }
        /// <summary>
        /// 客户端ip地址
        /// </summary>
        public IPEndPoint LocalEndPoint;
        //客户端连接状态
        private bool _isConnected = false;
        /// <summary>
        ///客户端连接状态
        /// </summary>
        public bool IsConnected
        {
            set { _isConnected = value; }
            get { return _isConnected; }
        }

        private bool _isWarningOfReconn = false;//是否已经发送重连失败提醒 
        public bool IsWarningOfReconn
        {
            set { _isWarningOfReconn = value; }
            get { return _isWarningOfReconn; }
        }

        #region 构造函数

        public ClientObj(IPEndPoint localEndPoint) : base(localEndPoint)
        {
            LocalEndPoint = localEndPoint;
        }
        #endregion


        #region 客户端事件
        /// <summary>
        ///启动客户端
        /// </summary>
        /// <returns></returns>
        public void StartClient()
        {
            this.OnConnect += new CClientSocket.ConnectionDelegate(Client_OnConnect);
            this.OnDisconnect += new CClientSocket.ConnectionDelegate(Client_OnDisconnect);
            this.OnRead += new CClientSocket.ConnectionDelegate(Client_OnRead);
            this.Connect();
        }
        #endregion




        public void StopClient()
        {
            if (this.Disconnect())
            {
                _isConnected = false;
            }
            else
            {
                _isConnected = true;
            }
        }

        #endregion
        #region 断线检测
        /// <summary>
        /// PING  服务器
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool Ping()
        {
            try
            {
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                System.Net.NetworkInformation.PingOptions options = new System.Net.NetworkInformation.PingOptions();
                options.DontFragment = true;
                string data = "Test Data!";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 5000; // Timeout 时间，单位：毫秒  
                System.Net.NetworkInformation.PingReply reply = p.Send(LocalEndPoint.Address, timeout, buffer, options);
                if (reply == null || reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    return true;

                return false;
            }
            catch
            {

                return false;
            }
        }
        #endregion
        #region 服务器事件（作为虚方法可被派生类重写）
        /// <summary>
        /// 客户端链接事件
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Client_OnConnect(Socket soc)
        {
            _isConnected = true;
        }
        /// <summary>
        /// 断开客户端链接事件
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Client_OnDisconnect(Socket soc)
        {
            IsConnected = false;
            Connect();
        }
        /// <summary>
        /// 客户端接收数据事件（虚方法，在子类中重写以实现个性化逻辑）
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Client_OnRead(Socket soc)
        {
        }
        #endregion
    }
}
