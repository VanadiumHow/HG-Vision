using BaseThread;
using System.Collections.Generic;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_Thread
{
    public class WatchConnectingThread : Control_Thread
    {

        //所有客户端IP
        private List<string> listConnectIPs = new List<string>();
        public List<string> ListConnectIPs
        {
            get { return listConnectIPs; }
            set { listConnectIPs = value; }
        }
        //已连接的客户端IP数量
        private int clientIPNum = 0;
        public int ClientIPNum
        {
            get { return clientIPNum; }
            set { clientIPNum = value; }
        }
        public delegate void DisconnectDelegate();
        public event DisconnectDelegate Disconnect;
        public override void Initialize()
        {
            base.Start(1000, "WatchConnectingThread");
        }

        public override void Deinitialize() => base.Stop();
        protected override void Run()
        {
            if (clientIPNum < listConnectIPs.Count)
            {
                Disconnect();
            }
        }
    }
}
