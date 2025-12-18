using System;
using Obj.Obj_File;
using HG_Vision.Manager.Manager_Sql;
using HG_Vision.Manager.Manager_Vision;
using HG_Vision.Manager.Manager_Process;
using HG_Vision.Manager.Manager_Socket;
using HG_Vision.Manager.Manager_PLC;
using HG_Vision.Manager.Manager_User;
using HslCommunication.Enthernet;
/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_System
{
    public class Project
    {

        /// <summary>
        /// 系统参数管理类
        /// </summary>
        public GlobalManager GlobalManagerInstance = null;

        /// <summary>
        /// 用户信息管理类
        /// </summary>
        public UserManager UserManagerInstance = null;

        /// <summary>
        /// 数据库管理类
        /// </summary>
        public SqlInfoManager SqlInfoManagerInstance = null;

        /// <summary>
        /// 相机管理类
        /// </summary>
        public VisionManager VisionManagerInstance = null;

        /// <summary>
        /// PLC配置类
        /// </summary>
        public HSLPLCOmron PLCManagerInstance = null;

        /// <summary>
        /// 硬件连接状态
        /// </summary>
        public HardWareStateManager HardWareStateManagerInstance = null;

        /// <summary>
        /// 生产数据
        /// </summary>
        public ProductionDataManager ProductionDataManagerInstance = null;

        /// <summary>
        /// 定时任务管理类
        /// </summary>
        public ScheduledTaskManager ScheduledTaskManagerInstance = null;

        /// <summary>
        /// Robot服务器管理类
        /// </summary>
        public ServerManager ServerManagerInstance = null;

        /// <summary>
        /// Laser客户端管理类
        /// </summary>
        public ClientManager ClientManagerInstance = null;

        /// <summary>
        /// 双重锁校验声明单例
        /// </summary>
        //private static Project _instance = null;
        //private static readonly object obj = new object();
        //private Project() { }
        //public static Project Instance
        //{
        //    if (_instance == null)
        //    {
        //        lock (obj)
        //        {
        //            if (_instance == null)
        //            { _instance = new Project(); }
        //        }
        //    }
        //    return _instance;
        //}
        private static readonly Lazy<Project> _lazyInstance =
          new Lazy<Project>(() => new Project(), isThreadSafe: true);

        public static Project Instance => _lazyInstance.Value;
        /// <summary>
        /// 懒加载管理类
        /// </summary>
        public void InitialManagerObj()
        {
            GlobalManagerInstance = new GlobalManager();

            UserManagerInstance = new UserManager();

            SqlInfoManagerInstance = new SqlInfoManager();

            VisionManagerInstance = new VisionManager();

            PLCManagerInstance = new HSLPLCOmron();              //在这里已经初始化了

            ServerManagerInstance = new ServerManager();

            ClientManagerInstance = new ClientManager();

            HardWareStateManagerInstance = new HardWareStateManager();

            ProductionDataManagerInstance = new ProductionDataManager();

            ScheduledTaskManagerInstance = new ScheduledTaskManager();

        }

        /// <summary>
        /// 初始Robot/laser服务器
        /// </summary>
        public void InitialSocketSever()
        {
            try
            {
                //初始化Robot服务器
                Project.Instance.ServerManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Robot服务器出现异常", ex);
            }

        }


        /// <summary>
        /// 初始Laser客户端
        /// </summary>
        public void InitialSocketClient()
        {
            try
            {
                //初始化Laser客户端
                Project.Instance.ClientManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Laser客户端出现异常", ex);
            }

        }
        /// <summary>
        /// 加载系统参数
        /// </summary>
        /// <returns></returns>
        public void LoadGlobalConfig()
        {
            try
            {
                Project.Instance.GlobalManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("加载系统参数出现异常", ex);
            }
        }

        /// <summary>
        /// 加载用户信息
        /// </summary>
        /// <returns></returns>
        public void LoadUserInfo()
        {
            try
            {
                Project.Instance.UserManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("加载用户信息出现异常", ex);
            }
        }



        /// <summary>
        /// 加载数据库信息
        /// </summary>
        /// <returns></returns>
        public void LoadSQLInfo()
        {
            try
            {
                Project.Instance.SqlInfoManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("加载数据库信息出现异常", ex);
            }
        }

        /// <summary>
        /// 加载视觉参数
        /// </summary>
        public void LoadVisionInfo()
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum > 0)
            {
                try
                {
                    Project.Instance.VisionManagerInstance.Initial();
                }
                catch (Exception ex)
                {
                    LogHelper.Error("加载视觉功能块出现异常", ex);
                }
            }
        }

        /// <summary>
        /// 初始化PLC
        /// </summary>
        /// <returns></returns>
        public void InitialPLC()
        {
            try
            {
                //初始化PLC
                Project.Instance.PLCManagerInstance.Connect();
            }
            catch (Exception ex)
            {
                LogHelper.Error("连接PLC出现异常", ex);
            }
        }


        public void InitialHardWareState()
        {
            try
            {
                Project.Instance.HardWareStateManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化硬件状态出现异常", ex);
            }
        }


        public void InitialProductionData()
        {
            try
            {
                Project.Instance.ProductionDataManagerInstance.Initial();
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化生产数据出现异常", ex);
            }
        }
    }
}
