using BaseSocket;
using Model.EnumModel;
using Obj.Obj_File;
using System.Net;
using System.Net.Sockets;

/****************************************************************
此类是本软件作为服务器设备的基类对象，设备对象应继承此类以实现不同设备的个性化逻辑
*****************************************************************/
namespace Obj.Obj_Socket
{
    public class ServerObj : CServerSocket
    {
        #region 共性属性（所有设备都需要）
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
        public DeviceType DeviceType { get; protected set; }
        /// <summary>
        /// 服务器ip地址
        /// </summary>
        public IPEndPoint _localEndPoint;
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
        #endregion

        #region 构造函数
        public ServerObj(IPEndPoint localEndPoint) : base(localEndPoint)
        {
            _localEndPoint = localEndPoint;
        }
        #endregion

        #region Robot服务器启停
        /// <summary>
        ///启动服务器Robot
        /// </summary>
        /// <returns></returns>
        public void StartServer()
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
        }
        /// <summary>
        /// 停止服务器
        /// </summary>
        /// <returns></returns>
        public bool StopServer()
        {
            if (this.Deactive())
            {
                _isConnected = false;
            }
            else
            {
                _isConnected = true;
                return false;
            }
            return true;
        }
        #region 服务器监控

        #endregion
        #endregion
        #region 服务器事件（作为虚方法可被派生类重写）
        /// <summary>
        /// 服务器链接事件
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Server_OnConnect(Socket soc)
        {
            _isConnected = true;
        }
        /// <summary>
        /// 断开服务器链接事件
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Server_OnDisconnect(Socket soc)
        {
            _isConnected = false;
        }

        /// <summary>
        /// 服务器开始监听
        /// </summary>
        protected virtual void Server_OnListen()
        {
        }
        /// <summary>
        /// 服务器接收数据事件
        /// </summary>
        /// <param name="soc"></param>
        protected virtual void Server_OnRead(Socket soc)
        {
        }

        /// <summary>
        ///服务器写数据
        /// </summary>
        /// <param name="soc"></param>

        protected virtual void Server_OnWrite(Socket soc)
        {
        }
        #endregion
    }
}
