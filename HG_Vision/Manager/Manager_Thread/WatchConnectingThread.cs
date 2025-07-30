using BaseThread;
using HG_Vision.Manager.Manager_System;
using System.Collections.Generic;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class WatchConnectingThread : Control_Thread
    {

        //客户端IP
        private List<string> listConnectIPs = new List<string>();
        public List<string> ListConnectIPs
        {
            private get { return ListConnectIPs; }
            set { ListConnectIPs = value; }
        }
        //客户端IP长度
        private int clientIPNum = 0;
        public int ClientIPNum
        {
            private get { return clientIPNum; }
            set { clientIPNum = value; }
        }
        public override void Initialize()
        {
            base.Start(1000, "WatchConnectingThread");
        }

        public override void Deinitialize() => base.Stop();
        //客户端断开IP
        private List<string> _listDisconnetIPs = new List<string>();
        //临时客户端IP
        private List<string> _listTempConnetIPs = new List<string>();
        protected override void Run()
        {
            if (clientIPNum < listConnectIPs.Count)
            {
                _listDisconnetIPs.Clear();
                _listTempConnetIPs.Clear();
                for (int i = 0; i < clientIPNum; i++)
                {
                    _listTempConnetIPs.Add(Project.Instance.RobotManagerInstance.L_Robot[i].RemoteAddress(i));
                }
                foreach (var item in listConnectIPs)
                {
                    if (!_listTempConnetIPs.Contains(item))
                    {
                        _listDisconnetIPs.Add(item);
                    }
                }
                for (int i = 0; i < _listDisconnetIPs.Count; i++)
                {
                    if (_listDisconnetIPs[i] == listConnectIPs[i])
                    {
                        Project.Instance.RobotManagerInstance.L_Robot[i].SetIsConnectedRobot(0, false);
                    }
                }
            }
        }
    }
}
