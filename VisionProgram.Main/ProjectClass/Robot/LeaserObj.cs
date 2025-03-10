using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;



namespace VisionProgram.Main.ProjectClass.Robot
{
    public class LaserObj : CClientSocket
    {

        #region 字段或者属性
        //服务器状态
        private bool _isConnected = false;

        private bool _isWarningOfReconn = false;//是否已经发送重连失败提醒 
        public bool IsWarningOfReconn
        {
            set { _isWarningOfReconn = value; }
            get { return _isWarningOfReconn; }
        }

        //Robot连接状态
        private bool _isConnectedLaser = false;
        /// <summary>
        ///Laser连接状态
        /// </summary>
        public bool IsConnectedLaser
        {
            set { _isConnectedLaser = value; }
            get { return _isConnectedLaser; }
        }
        //服务器ip地址
        public IPEndPoint _localEndPoint;

        //客户端IP
        private List<string> dicConnectIP = new List<string>();

        //客户端断开IP
        private List<string> dicDisConnectIP = new List<string>();

        //客户端IP
        private List<string> dicTempConnectIP = new List<string>();

        //客户端IP长度
        private int clientIPNum = 0;




        private string _ip;
        private int _port;

        public int Number;//当前第几个客户端

        #region 构造函数
        public LaserObj(int num, string ip, int port) : base(ip, port)
        {
            Number = num;
            _ip = ip;
            _port = port;
        }
        #endregion


        #region Laser客户端事件
        /// <summary>
        ///启动laser客户端
        /// </summary>
        /// <returns></returns>
        public void StartClientLaser()
        {
            this.OnConnect += Client_OnConnect;
            this.OnDisconnect += Client_OnDisconnect;
            this.OnRead += Client_OnRead;
            this.OnWrite += Client_OnWrite;
            this.Connect();
        }
        #endregion


        /// <summary>
        /// 客户端链接事件
        /// </summary>
        /// <param name="soc"></param>
        private void Client_OnConnect(Socket soc)
        {
            clientIPNum++;
            if (!dicConnectIP.Contains((soc.RemoteEndPoint as IPEndPoint).Address.ToString()))
            {
                dicConnectIP.Add((soc.RemoteEndPoint as IPEndPoint).Address.ToString());
            }
            if ((soc.RemoteEndPoint as IPEndPoint).Address.ToString() == dicConnectIP[0])
            {
                IsConnectedLaser = true;
            }
        }
        /// <summary>
        /// 断开客户端链接事件
        /// </summary>
        /// <param name="soc"></param>
        private void Client_OnDisconnect(Socket soc)
        {
            clientIPNum--;
        }

        public void Close()
        {
            if (null != this)
            {
                this.Disconnect();
            }
        }


        /// <summary>
        /// 服务器接收数据事件
        /// </summary>
        /// <param name="soc"></param>
        private void Client_OnRead(Socket soc)
        {
            if (RobotSignals.CCDProcess == 0)//0-自动运行
            {


            }
        }

        /// <summary>
        ///服务器写数据
        /// </summary>
        /// <param name="soc"></param>
        private void Client_OnWrite(Socket soc)
        {
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
                System.Net.NetworkInformation.PingReply reply = p.Send(_ip, timeout, buffer, options);
                if (reply == null || reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                    return true;

                return false;
            }
            catch (System.Net.NetworkInformation.PingException e)
            {

                return false;
            }
        }



        #endregion
    }
}
