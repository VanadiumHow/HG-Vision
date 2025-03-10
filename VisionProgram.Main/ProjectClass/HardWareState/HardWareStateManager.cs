using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using VisionProgram.Main.ProjectClass.SqlDB;
using System.Runtime.Remoting.Messaging;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.HardWareState
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
        /// ROBOT连接状态
        /// </summary>
        public List<bool> L_robotState = new List<bool>();

        internal HardWareStateManager() { }

        /// <summary>
        /// 初始化所有数据
        /// </summary>
        public void Initial()
        {
            L_ccdState.Clear();
            L_sqlState.Clear();
            L_robotState.Clear();
            //CCD连接状态初始化
            for (int i = 0; i < Project.Instance().VisionManagerInstance.CameraNum; i++)
            {
                L_ccdState.Add(false);
                L_ccdState[i] =  Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[i].connected();
            }

       
            for (int i = 0; i <1; i++)
            {
                L_robotState.Add(false);
         //    L_robotState[i] = Project.Instance().RobotManagerInstance.L_Robot[i].IsConnectedRobot[0];
            }
            //数据库连接状态初始化
            for (int i = 0; i < Project.Instance().SqlInfoManagerInstance.SqlNum; i++)
            {
                L_sqlState.Add(false);
            }
            //异步连接DB，防止同步连接失败造成进度条假死
            if (Project.Instance().SqlInfoManagerInstance.SqlNum > 0)
            {
                OnConnectDB = new Func<List<bool>>(() => { return Project.Instance().SqlInfoManagerInstance.ConnectSql(); });
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
                Project.Instance().SqlInfoManagerInstance.CreateOperationLogTable();
                Project.Instance().SqlInfoManagerInstance.CreateOperationLogProc();
            }          
        }
    }
}
