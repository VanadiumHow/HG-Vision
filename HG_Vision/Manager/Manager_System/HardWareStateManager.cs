using System;
using System.Collections.Generic;

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
            L_ccdState.Clear();
            L_sqlState.Clear();
            L_robotState.Clear();
            L_laserState.Clear();
            //CCD连接状态初始化
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
            {
                L_ccdState.Add(false);
                L_ccdState[i] = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[i].connected();
            }

            foreach(var robot in Project.Instance.ServerManagerInstance.GetAllDevice())
            {
                L_robotState.Add(robot.IsConnected);
            }

            //数据库连接状态初始化
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
