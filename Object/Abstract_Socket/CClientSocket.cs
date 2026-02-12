using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using static BaseSocket.CServerSocket;

/****************************************************************

*****************************************************************/
namespace BaseSocket
{
    public abstract class CClientSocket
    {
        #region Delegates
        public delegate void ConnectionDelegate(Socket soc);
        public delegate void ErrorDelegate(string ErroMessage, Socket soc, int ErroCode);
        #endregion

        #region Events
        public event ConnectionDelegate OnConnect;
        public event ConnectionDelegate OnDisconnect;
        public event ConnectionDelegate OnRead;
        public event ConnectionDelegate OnWrite;
        public event ErrorDelegate OnError;
        public event ConnectionDelegate OnSendFile;
        #endregion

        #region Variables
        private AsyncCallback WorkerCallBack;
        private Socket mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint serverEndPoint;
        private byte[] dataBuffer = new byte[1024];
        private int mPort = 0;
        private byte[] mBytesReceived;
        private string mTextReceived = "";
        private string mTextSent = "";
        private string mRemoteAddress = "";
        private string mRemoteHost = "";
        #endregion

        #region Propetiers
        /// <summary>
        /// Port to connect to server
        /// </summary>
        public int Port
        {
            get
            {
                return (mPort);
            }
        }

        /// <summary>
        /// Bytes received by the Socket
        /// </summary>
        public byte[] ReceivedBytes
        {
            get
            {
                byte[] temp = null;
                if (mBytesReceived != null)
                {
                    temp = mBytesReceived;
                    mBytesReceived = null;
                }
                return (temp);
            }
        }

        /// <summary>
        /// Message received by the Socket
        /// </summary>
        public string ReceivedText
        {
            get
            {
                string temp = mTextReceived;
                mTextReceived = "";
                return (temp);
            }
        }

        /// <summary>
        /// Message send by the Socket
        /// </summary>
        public string WriteText
        {
            get
            {
                string temp = mTextSent;
                mTextSent = "";
                return (temp);
            }
        }

        /// <summary>
        /// IP Server
        /// </summary>
        public string RemoteAddress
        {
            get
            {
                if (mainSocket.Connected)
                    return (mRemoteAddress);
                else
                    return "";
            }
        }

        /// <summary>
        /// Host Server
        /// </summary>
        public string RemoteHost
        {
            get
            {
                if (mainSocket.Connected)
                    return (mRemoteHost);
                else
                    return "";
            }
        }

        /// <summary>
        /// Return true if the ClientSocket is connected to the Server
        /// </summary>
        public bool Connected
        {
            get
            {
                return (mainSocket.Connected);
            }
        }
        #endregion

        #region 构造函数（增加重载）
        /// <summary>
        /// 核心构造函数：通过服务器端点（IPEndPoint）连接
        /// </summary>
        /// <param name="serverEndPoint">服务器端点（IP + 端口）</param>
        public CClientSocket(IPEndPoint serverEndPoint)
        {
            try
            {
                this.serverEndPoint = serverEndPoint;
                mPort = serverEndPoint.Port;
                mRemoteAddress = serverEndPoint.Address.ToString();
                mRemoteHost = Dns.GetHostEntry(mRemoteAddress).HostName; // 修复：解析服务器主机名
            }
            catch (Exception ex)
            {
                OnError?.Invoke(ex.Message, null, 0);
            }
        }
        #endregion

        #region Functions and Events
        /// <summary>
        /// Establishes connection with the IP and Port Server
        /// </summary>
        public bool Connect()
        {
            try
            {
                mainSocket?.Close(); // 先关闭旧实例
                mainSocket = null;
                mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //Connect to Server
                mainSocket.BeginConnect(serverEndPoint, ConfirmConnect, mainSocket);
                return true;
            }
            catch (Exception ex)
            {
                OnError?.Invoke(ex.Message, mainSocket, ex is SocketException se ? se.ErrorCode : 0);
                return false;
            }
        }

        private void ConfirmConnect(IAsyncResult asyn)
        {
            Socket soc = asyn.AsyncState as Socket;
            if (soc == null) return;

            try
            {
                soc.EndConnect(asyn);
                WaitForData(soc);
                OnConnect?.Invoke(soc);
            }
            catch (Exception ex)
            {
                OnError?.Invoke(ex.Message, soc, ex is SocketException se ? se.ErrorCode : 0);
            }
        }

        private void WaitForData(Socket soc)
        {
            try
            {
                if (WorkerCallBack == null)
                    WorkerCallBack = new AsyncCallback(OnDataReceived);
                // 修复：将Socket实例作为state传递，回调中可获取有效实例
                soc.BeginReceive(dataBuffer, 0, dataBuffer.Length, SocketFlags.None, WorkerCallBack, soc);
            }
            catch (SocketException se)
            {
                OnError?.Invoke(se.Message, soc, se.ErrorCode);
            }
        }

        private void OnDataReceived(IAsyncResult asyn)
        {
            Socket soc = asyn.AsyncState as Socket; // 获取传递的有效Socket
            if (soc == null || !soc.Connected) return; // 提前判空，避免无效操作

            try
            {
                int iRx = soc.EndReceive(asyn); // 操作传递的Socket，而非全局mainSocket

                if (iRx < 1)
                {
                    mainSocket.Close();
                    if (!mainSocket.Connected)
                        if (OnDisconnect != null)
                            OnDisconnect(mainSocket);
                }
                else
                {
                    mBytesReceived = dataBuffer;
                    char[] chars = new char[iRx + 1];
                    Decoder d = Encoding.UTF8.GetDecoder();
                    d.GetChars(dataBuffer, 0, iRx, chars, 0);
                    mTextReceived = new String(chars);
                    if (OnRead != null)
                        OnRead(mainSocket);
                    WaitForData(mainSocket);
                }
            }
            catch (ArgumentException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
            }
            catch (InvalidOperationException se)
            {
                mainSocket.Close();
                if (!mainSocket.Connected)
                    if (OnDisconnect != null)
                        OnDisconnect(mainSocket);
                    else
                        if (OnError != null)
                        OnError(se.Message, null, 0);
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, mainSocket, se.ErrorCode);
                if (!mainSocket.Connected)
                    if (OnDisconnect != null)
                        OnDisconnect(mainSocket);
            }
        }

        /// <summary>
        /// Send a text message
        /// </summary>
        /// <param name="mens">Message</param>
        public bool SendText(string mens)
        {
            try
            {
                byte[] byData = System.Text.Encoding.UTF8.GetBytes(mens);
                int NumBytes = mainSocket.Send(byData);
                if (NumBytes == byData.Length)
                {
                    if (OnWrite != null)
                    {
                        mTextSent = mens;
                        OnWrite(mainSocket);
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (ArgumentException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (ObjectDisposedException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, mainSocket, se.ErrorCode);
                return false;
            }
        }

        /// <summary>
        /// Send file
        /// </summary>
        /// <param name="FileName">Path File</param>
        public bool SendFile(string FileName)
        {
            try
            {
                mainSocket.BeginSendFile(FileName, new AsyncCallback(FileSendCallback), mainSocket);
                return true;
            }
            catch (FileNotFoundException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (ObjectDisposedException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, mainSocket, se.ErrorCode);
                return false;
            }
        }

        /// <summary>
        /// Send file
        /// </summary>
        /// <param name="FileName">Path File</param>
        /// <param name="PreString">Message sent before the file</param>
        /// <param name="PosString">Message sent after the File</param>
        public bool SendFile(string FileName, string PreString, string PosString)
        {
            try
            {
                byte[] preBuf = Encoding.UTF8.GetBytes(PreString);
                byte[] postBuf = Encoding.UTF8.GetBytes(PosString);
                mainSocket.BeginSendFile(FileName, preBuf, postBuf, 0, new AsyncCallback(FileSendCallback), mainSocket);
                return true;
            }
            catch (ArgumentException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (ObjectDisposedException se)
            {
                if (OnError != null)
                    OnError(se.Message, null, 0);
                return false;
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, mainSocket, se.ErrorCode);
                return false;
            }
        }

        private void FileSendCallback(IAsyncResult ar)
        {
            Socket workerSocket = (Socket)ar.AsyncState;
            workerSocket.EndSendFile(ar);
            if (OnSendFile != null)
                OnSendFile(workerSocket);
        }

        /// <summary>
        /// Close connection to the server
        /// </summary>
        public bool Disconnect()
        {
            try
            {
                if (mainSocket.Connected)
                {
                    mainSocket.Shutdown(SocketShutdown.Both); // 先终止读写，通知对方
                    mainSocket.Close(1000); // 等待1秒，让异步操作收尾
                }
                return !mainSocket.Connected;
            }
            catch (SocketException se)
            {
                OnError?.Invoke(se.Message, mainSocket, se.ErrorCode);
                return false;
            }
        }
        #endregion
    }
}
