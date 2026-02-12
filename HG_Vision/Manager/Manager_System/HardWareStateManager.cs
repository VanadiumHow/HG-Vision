using HG_Vision.Contol.Control_Socket;
using Model.EnumModel;
using System;
using System.Collections.Generic;
using System.Threading;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_System
{
    public class HardWareStateManager
    {
        /// <summary>
        /// 异步连接DB事件
        /// </summary>
        private Func<List<bool>> OnConnectDB;

        /// <summary>
        /// PLC连接状态
        /// </summary>
        public List<bool> L_PLCState = new List<bool>();

        /// <summary>
        /// 相机连接状态
        /// </summary>
        public List<bool> L_ccdState = new List<bool>();
        /// <summary>
        /// SQL连接状态
        /// </summary>
        public List<bool> L_sqlState = new List<bool>();

        /// <summary>
        /// 机械手连接状态
        /// </summary>
        public List<bool> L_robotState = new List<bool>();
        /// <summary>
        /// 激光连接状态
        /// </summary>
        public List<bool> L_laserState = new List<bool>();

        internal HardWareStateManager() { }

        /// <summary>
        /// 初始化所有数据
        /// </summary>
        public void Initial()
        {
            L_PLCState.Clear();
            L_ccdState.Clear();
            L_sqlState.Clear();
            L_robotState.Clear();
            L_laserState.Clear();

            if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
            {
                //PLC连接状态初始化（默认未连接）
                for (int i = 0; i < Project.Instance.PLCManagerInstance.PLCNum; i++)
                {
                    L_PLCState.Add(false);
                }
            }
            else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
            {
                //PLC连接状态初始化（默认未连接）
                for (int i = 0; i < Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC).Count; i++)
                {
                    L_PLCState.Add(false);
                }
            }

            //CCD连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
            {
                L_ccdState.Add(false);
            }

            //机械手连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot).Count; i++)
            {
                L_robotState.Add(false);
            }

            //激光连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser).Count; i++)
            {
                L_laserState.Add(false);
            }

            CheckLink_Relink();
            //数据库连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.SqlInfoManagerInstance.SqlNum; i++)
            {
                L_sqlState.Add(false);
            }
            //异步连接DB，防止同步连接失败造成进度条假死
            if (Project.Instance.SqlInfoManagerInstance.SqlNum > 0)
            {
                OnConnectDB = new Func<List<bool>>(() => { return Project.Instance.SqlInfoManagerInstance.ConnectSql(); });
                OnConnectDB.BeginInvoke(DoneConnectDBCallback, OnConnectDB);
            }
        }

        public void CheckLink_Relink()
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
            {
                //PLC连接状态初始化（默认未连接）
                for (int i = 0; i < Project.Instance.PLCManagerInstance.PLCNum; i++)
                {
                    if (!Project.Instance.PLCManagerInstance._isPLCConnect)
                    {
                        Project.Instance.PLCManagerInstance.Connect();
                        Thread.Sleep(50);
                    }
                    L_PLCState[i] = Project.Instance.PLCManagerInstance._isPLCConnect;
                }
            }
            else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
            {
                //PLC连接状态初始化（默认未连接）
                for (int i = 0; i < Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC).Count; i++)
                {
                    if (!Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC)[i].IsConnected)
                    {
                        Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC)[i].Connect();
                        Thread.Sleep(50);
                    }
                    L_PLCState[i] = Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC)[i].IsConnected;
                }
            }
            //CCD连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
            {
                //相机无法通过代码重连
                L_ccdState[i] = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[i].connected();
            }

            //机械手连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot).Count; i++)
            {
                //作为服务器只能被动等客户端连接
                L_robotState[i] = Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot)[i].IsConnected;
            }

            //激光连接状态初始化（默认未连接）
            for (int i = 0; i < Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser).Count; i++)
            {
                //作为服务器只能被动等客户端连接
                L_laserState[i] = Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser)[i].IsConnected;
            }
        }
        public void DoneConnectDBCallback(IAsyncResult asyncResult)
        {
            Func<List<bool>> onConnectDB = asyncResult.AsyncState as Func<List<bool>>;
            //第二个写法：
            //AsyncResult ar = (AsyncResult)asyncResult;
            //Func<List<bool>> onConnectDB = (Func<List<bool>>)ar.AsyncDelegate;
            List<bool> result = onConnectDB.EndInvoke(asyncResult);
            L_sqlState = result;

            //自动创建表、存储过程，若出现则不创建
            if (L_sqlState[0])
            {
                Project.Instance.SqlInfoManagerInstance.CreateOperationLogTable();
                Project.Instance.SqlInfoManagerInstance.CreateOperationLogProc();
            }
        }
    }
}
