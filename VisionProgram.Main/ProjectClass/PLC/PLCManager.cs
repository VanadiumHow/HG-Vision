using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.PLC
{
    public class PLCManager
    {
        ///// <summary>
        ///// PLC业务类实例
        ///// </summary>
        //public PLC1Service plc1Service;
        //public PLC2Service plc2Service;
        //public PLC4Service plc4Service;

        /// <summary>
        /// 线程状态通知
        /// </summary>
        public CancellationTokenSource cts1Service = null;
        public CancellationTokenSource cts2Service = null;

        /// <summary>
        /// PLC配置类
        /// </summary>
        private PLCConfiguration _plcConfiguration = new PLCConfiguration();

        /// <summary>
        /// 程序中用的PLC业务类的集合
        /// </summary>
        public List<BasePLC> L_basePLCObjects = new List<BasePLC>();


        /// <summary>
        /// 线程状态通知的集合
        /// </summary>
        public List<CancellationTokenSource> L_PLCCtsServices = new List<CancellationTokenSource>();

        /// <summary>
        /// PLC信息的集合
        /// </summary>
        public List<PLCConfiguration.PLCInfo> L_PLCInfo = new List<PLCConfiguration.PLCInfo>();

        public List<List<PLCSignalInfo>> L_PLCSignalInfoList = new List<List<PLCSignalInfo>>(); //存储信号变量容器

        /// <summary>
        /// PLC数量
        /// </summary>
        public int PLCNum
        {
            get { return L_PLCInfo.Count; }
        }

        internal PLCManager() { }


        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            //清空PLC
            if (L_basePLCObjects.Count > 0)
            {
                for (int i = 0; i < L_basePLCObjects.Count; i++)
                {
                    if (L_basePLCObjects[i] != null)
                    {
                        L_basePLCObjects[i].Dispose();
                        L_basePLCObjects[i] = null;
                    }
                }
            }
            L_basePLCObjects.Clear();
            L_PLCSignalInfoList.Clear();
            //加载ini
            _plcConfiguration.AnalysisPlcCommConfig(ref L_PLCInfo, ref L_PLCSignalInfoList);

            //不在这里实例化
        }

        /// <summary>
        /// 退出所有PLC业务类的占用资源
        /// </summary>
        public void Exit()
        {
            foreach (var plc in L_basePLCObjects)
            {
                plc.Exit();
            }
        }
    }
}
