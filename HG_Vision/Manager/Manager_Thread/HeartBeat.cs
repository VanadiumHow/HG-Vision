using BaseThread;
using HG_Vision.Contol.Control_Socket;
using HG_Vision.Manager.Manager_System;
using Model.SocketModel;
using Obj.Obj_File;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HG_Vision.Manager.Manager_Thread
{
    internal class HeartBeat : Control_Thread
    {
        public override void Initialize() => base.Start(500, "HeartBeat");
        public override void Deinitialize() => base.Stop();

        protected override void Run()
        {
            try
            {
                int currentHeartBeat = Project.Instance.PLCManagerInstance.ReadInt16("D28");
                if (currentHeartBeat == 0)
                {
                    if (Project.Instance.ServerManagerInstance.GetDevice<LaserServerObj>($"Laser{0}").IsConnected)
                    {
                        Project.Instance.PLCManagerInstance.WriteInt("D28", 1);
                    }
                }
                if (currentHeartBeat == 1)
                {
                    if (Project.Instance.ServerManagerInstance.GetDevice<LaserServerObj>($"Laser{0}").IsConnected)
                    {
                        Project.Instance.PLCManagerInstance.WriteInt("D28", 0);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("PLC心跳线程出现异常", ex);  //写日志 
            }
        }
    }
}
