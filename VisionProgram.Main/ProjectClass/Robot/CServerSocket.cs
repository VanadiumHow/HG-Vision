using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Net;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;

namespace VisionProgram.Main.ProjectClass.Robot
{
    public class CServerSocket
    {
        #region Delegates
        public delegate void ConnectionDelegate(Socket soc);
        public delegate void ErrorDelegate(string ErroMessage, Socket soc, int ErroCode);
        public delegate void ListenDelegate();
        public delegate void StopDelegate();
        #endregion

        #region Events
        public event ConnectionDelegate OnConnect;
        public event ConnectionDelegate OnDisconnect;
        public event StopDelegate OnStopServer;
        public event ConnectionDelegate OnRead;
        public event ConnectionDelegate OnWrite;
        public event ErrorDelegate OnError;
        public event ListenDelegate OnListen;
        public event ConnectionDelegate OnSendFile;
        #endregion

        #region Variables
        private ArrayList Clients = ArrayList.Synchronized(new ArrayList());
        private AsyncCallback WorkerCallBack;
        private Socket mainSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint serverEndPoint;
        private int mPort = 0;
        private byte[] mBytesReceived;
        private string mTextReceived = "";
        private string mTextSent = "";
        private bool mListening = false;  //Variable control

        #endregion

        #region Propetiers
        /// <summary>
        /// Port to connect with clients
        /// </summary>
        public int Port
        {
            get
            {
                return (mPort);
            }
        }

        public static List<string> GetLocalIP()
        {
            List<string> strIPs = new List<string>();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    var mac = adapter.GetPhysicalAddress();

                    IPInterfaceProperties ip = adapter.GetIPProperties();
                    UnicastIPAddressInformationCollection ipCollection = ip.UnicastAddresses;
                    foreach (UnicastIPAddressInformation ipadd in ipCollection)
                    {
                        //InterNetwork    IPV4地址      
                        //InterNetworkV6        IPV6地址 
                        if (ipadd.Address.AddressFamily == AddressFamily.InterNetwork)
                        {   //判断是否为ipv4            
                            strIPs.Add(ipadd.Address.ToString());
                        }
                    }
                }
            }
            //return string.Join(";", strIPs);
            return strIPs;
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
        /// Number of active connections
        /// </summary>
        public int ActiveConnections
        {
            get
            {
                return (Clients.Count);
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="port">Port to wait for call</param>
        public CServerSocket(IPEndPoint localEndPoint)
        {
            try
            {
                serverEndPoint = localEndPoint;
            }
            catch (Exception ex)
            {
                if (OnError != null)
                    OnError(ex.Message, null, 0);
            }
        }
        #endregion

        #region Class
        private class SocketPacket
        {
            public SocketPacket(Socket soc)
            {
                m_currentSocket = soc;
            }
            public Socket m_currentSocket;
            public byte[] dataBuffer = new byte[1024];
        }
        #endregion

        #region Functions and Events
        /// <summary>
        /// Active waiting for the call
        /// </summary>
        public bool Active()
        {
            try
            {
                mListening = true;
                mainSocket.Bind(serverEndPoint);
                mainSocket.Listen(0);
                mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
                if (OnListen != null)
                    OnListen();
                return true;
            }
            catch (SocketException se)
            {
                mListening = false;
                if (OnError != null)
                    OnError(se.Message, mainSocket, se.ErrorCode);
                return false;
            }
        }

        private void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                if (mListening)
                {
                    Socket workSocket = mainSocket.EndAccept(asyn);
                    try
                    {
                        WaitForData(workSocket);
                        lock (this)
                        {
                            Clients.Add(workSocket);
                        }
                        if (OnConnect != null)
                            OnConnect(workSocket);
                        mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
                    }
                    catch (SocketException se)
                    {
                        if (OnError != null)
                            OnError(se.Message, workSocket, se.ErrorCode);
                    }
                }
            }
            catch (ObjectDisposedException ex)
            {
                if (OnError != null)
                    OnError(ex.Message, null, 0);
            }
        }

        private void WaitForData(Socket soc)
        {
            try
            {
                if (WorkerCallBack == null) //Active only the beginning
                    WorkerCallBack = new AsyncCallback(OnDataReceived);
                SocketPacket theSocPkt = new SocketPacket(soc);
                soc.BeginReceive(theSocPkt.dataBuffer, 0, theSocPkt.dataBuffer.Length, SocketFlags.None, WorkerCallBack, theSocPkt);
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, soc, se.ErrorCode);
            }
        }

        private void OnDataReceived(IAsyncResult asyn)
        {
            SocketPacket socketData = (SocketPacket)asyn.AsyncState;
            try
            {
                int iRx = socketData.m_currentSocket.EndReceive(asyn);
                if (iRx < 1)
                {
                    socketData.m_currentSocket.Close();
                    if (!socketData.m_currentSocket.Connected)
                    {
                        if (OnDisconnect != null)
                            OnDisconnect(socketData.m_currentSocket);
                        Clients.Remove(socketData.m_currentSocket);
                        socketData.m_currentSocket = null;
                    }
                }
                else
                {

                    mBytesReceived = socketData.dataBuffer;
                    char[] chars = new char[iRx + 1];
                    Decoder d = Encoding.UTF8.GetDecoder();
                    d.GetChars(socketData.dataBuffer, 0, iRx, chars, 0);
                    mTextReceived = new String(chars);
                    if (OnRead != null)
                        OnRead(socketData.m_currentSocket);
                    WaitForData(socketData.m_currentSocket);
                }
            }
            catch (InvalidOperationException ex)
            {
                if (socketData.m_currentSocket.Connected)
                    socketData.m_currentSocket.Close();
                if (!socketData.m_currentSocket.Connected)
                {
                    if (OnDisconnect != null)
                        // OnDisconnect(socketData.m_currentSocket);
                        Clients.Remove(socketData.m_currentSocket);
                    socketData.m_currentSocket = null;
                }
                else
                    if (OnError != null)
                    OnError(ex.Message, null, 0);
            }
            catch (SocketException se)
            {
                if (OnError != null)
                    OnError(se.Message, socketData.m_currentSocket, se.ErrorCode);
                if (!socketData.m_currentSocket.Connected)
                {
                    if (OnDisconnect != null)
                        OnDisconnect(socketData.m_currentSocket);
                    Clients.Remove(socketData.m_currentSocket);
                    socketData.m_currentSocket = null;
                }
            }
        }

        /// <summary>
        /// Send a text messageby connecting selected
        /// </summary>
        /// <param name="mens">Message</param>
        /// <param name="SocketIndex">Index of connection</param>
        /// 
        /// 
        private static readonly object obj = new object();
        public bool SendText(string mens, int SocketIndex)
        {
            lock (obj)
            {
                if ((Clients.Count - 1) >= SocketIndex)
                {
                    Socket workerSocket = (Socket)Clients[SocketIndex];
                    try
                    {
                        byte[] byData = System.Text.Encoding.UTF8.GetBytes(mens);
                        int NumBytes = workerSocket.Send(byData);
                        if (NumBytes == byData.Length)
                        {
                            if (OnWrite != null)
                            {
                                mTextSent = mens;
                                OnWrite(workerSocket);
                            }
                            return true;
                        }
                        else
                            return false;
                    }
                    catch (ArgumentException ex)
                    {
                        if (OnError != null)
                            OnError(ex.Message, null, 0);
                        return false;
                    }
                    catch (ObjectDisposedException ex)
                    {
                        if (OnError != null)
                            OnError(ex.Message, null, 0);
                        return false;
                    }
                    catch (SocketException se)
                    {
                        if (OnError != null)
                            OnError(se.Message, null, 0);
                        return false;
                    }
                }
                else
                {
                    if (OnError != null)
                        OnError("Index was out of range. Must be non-negative and less than the size of the collection.", null, 0);
                    return false;
                }

            }


        }

        /// <summary>
        /// Send file by connecting selected
        /// </summary>
        /// <param name="FileName">Path File</param>
        /// <param name="SocketIndex">Index of connection</param>
        public bool SendFile(string FileName, int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket workerSocket = (Socket)Clients[SocketIndex];
                try
                {
                    workerSocket.BeginSendFile(FileName, new AsyncCallback(FileSendCallback), workerSocket);
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
                        OnError(se.Message, workerSocket, se.ErrorCode);
                    return false;
                }
            }
            else
            {
                if (OnError != null)
                    OnError("Index was out of range. Must be non-negative and less than the size of the collection.", null, 0);
                return false;
            }
        }

        /// <summary>
        /// Send file by connecting selected
        /// </summary>
        /// <param name="FileName">Path File</param>
        /// <param name="PreString">Message sent before the file</param>
        /// <param name="PosString">Message sent after the File</param>
        /// <param name="SocketIndex">Index of connection</param>
        public bool SendFile(string FileName, string PreString, string PosString, int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket workerSocket = (Socket)Clients[SocketIndex];
                try
                {
                    byte[] preBuf = Encoding.UTF8.GetBytes(PreString);
                    byte[] postBuf = Encoding.UTF8.GetBytes(PosString);
                    workerSocket.BeginSendFile(FileName, preBuf, postBuf, 0, new AsyncCallback(FileSendCallback), workerSocket);
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
                        OnError(se.Message, workerSocket, se.ErrorCode);
                    return false;
                }
            }
            else
            {
                if (OnError != null)
                    OnError("Index was out of range. Must be non-negative and less than the size of the collection.", null, 0);
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
        /// Deactivates the ServerSocket closing all connections
        /// </summary>
        public bool Deactive()
        {
            mListening = false;
            bool err = true;
            if (mainSocket != null)
                mainSocket.Close();
            int total = Clients.Count;
            for (int i = 0; i < total; i++)
            {
                Socket workerSocket = (Socket)Clients[i];
                if (workerSocket != null)
                {
                    try
                    {
                        workerSocket.Shutdown(SocketShutdown.Both);
                    }
                    catch (SocketException ex)
                    {
                        if (OnError != null)
                            OnError(ex.Message, null, i);
                    }
                    workerSocket.Close();
                    err = err && !workerSocket.Connected;
                }
            }
            Clients.Clear();
            if (OnStopServer != null && err)
                OnStopServer();
            return err;
        }

        /// <summary>
        /// Disables a specific connection
        /// </summary>
        /// <param name="SocketIndex">Index of connection</param>
        public bool CloseConnection(int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket workerSocket = (Socket)Clients[SocketIndex];
                if (workerSocket != null)
                    workerSocket.Close();
                if (!workerSocket.Connected)
                    return true;
                else
                    return false;
            }
            else
            {
                if (OnError != null)
                    OnError("Index was out of range. Must be non-negative and less than the size of the collection.", null, 0);
                return false;
            }
        }

        /// <summary>
        /// Returns true if the specific socket is connected
        /// </summary>
        /// <param name="SocketIndex">Index of connection</param>
        public bool Connected(int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket soc = (Socket)Clients[SocketIndex];
                return soc.Connected;
            }
            else
                return false;
        }

        /// <summary>
        /// Returns the client's IP connected to the specific socket
        /// </summary>
        /// <param name="SocketIndex">Index of connection</param>
        public string RemoteAddress(int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket soc = (Socket)Clients[SocketIndex];
                try
                {
                    IPEndPoint clientInfoT = (IPEndPoint)soc.RemoteEndPoint;
                    string temp = clientInfoT.Address.ToString() + @":" + clientInfoT.Port.ToString();
                    return temp;
                }
                catch (ArgumentException se)
                {
                    if (OnError != null)
                        OnError(se.Message, null, 0);
                    return "";
                }
                catch (SocketException se)
                {
                    if (OnError != null)
                        OnError(se.Message, null, 0);
                    return "";
                }
            }
            else
                return "";
        }

        /// <summary>
        /// Returns the client's Host connected to the specific socket
        /// </summary>
        /// <param name="SocketIndex">Index of connection</param>
        public string RemoteHost(int SocketIndex)
        {
            if ((Clients.Count - 1) >= SocketIndex)
            {
                Socket soc = (Socket)Clients[SocketIndex];
                try
                {
                    string temp = soc.RemoteEndPoint.ToString();
                    temp = temp.Substring(0, temp.IndexOf(":"));
                    IPHostEntry retorno = Dns.GetHostEntry(temp);
                    return retorno.HostName;
                }
                catch (ArgumentException se)
                {
                    if (OnError != null)
                        OnError(se.Message, null, 0);
                    return "";
                }
                catch (SocketException se)
                {
                    if (OnError != null)
                        OnError(se.Message, null, 0);
                    return "";
                }
            }
            else
                return "";
        }

        /// <summary>
        /// Returns the index of the specific socket
        /// </summary>
        /// <param name="soc">Socket</param>
        public int IndexOf(Socket soc)
        {
            return Clients.IndexOf(soc);
        }
        #endregion
    }
}
