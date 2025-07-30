using System;
using Model.EnumModel;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_Message
{
    /// <summary>
    /// 消息通知  解耦
    /// </summary>
    public sealed class NoticeHelper
    {

        #region PLC流程消息
        public static bool IsOnPLCMessageRecievedRelatedMethod(string methodName)
        {
            if (OnPLCMessageRecieved == null)
                return false;

            Delegate[] delegAry = OnPLCMessageRecieved.GetInvocationList();
            foreach (Delegate deleg in delegAry)
            {
                if (deleg.Method.Name == methodName)
                    return true;
            }
            return false;
        }

        public delegate void PLCMessageRecieved(string msg, int plcIndex,string time, bool isOK = true);

        public static event PLCMessageRecieved OnPLCMessageRecieved;

        /// <summary>
        /// 发送相应PLC流程记录
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="plcIndex">PLC的下标</param>
        /// <param name="isOK">OK还是NG消息</param>
        public static void PLCMessageSend(string msg, bool isOK = true , int plcIndex = 0)
        {
            string time = DateTime.Now.ToString("MM-dd HH:mm:ss");
            OnPLCMessageRecieved?.Invoke(msg, plcIndex, time, isOK);
            
        }
        #endregion

        #region output非PLC流程消息
        public delegate void OutputMessageRecieved(string msg, int i);

        public static event OutputMessageRecieved OnOutputMessageRecieved;

        /// <summary>
        /// 发送非相应PLC流程记录
        /// </summary>
        /// <param name="msg">消息</param>
        /// <param name="i">消息等级</param>
        /// <param name="isSystemRunningPrint">是否在运行模式下打印</param>
        public static void OutputMessageSend(string msg, int i)
        {
            OnOutputMessageRecieved?.Invoke(msg, i);
        }
        #endregion       

        #region 更新良率数据渲染（表格型）

        public static bool IsOnUpdateYieldTableRelatedMethod(string methodName)
        {
            if (OnUpdateYieldTable == null)
                return false;

            Delegate[] delegAry = OnUpdateYieldTable.GetInvocationList();
            foreach (Delegate deleg in delegAry)
            {
                if (deleg.Method.Name == methodName)
                    return true;
            }
            return false;
        }

        public delegate void UpdateYieldTable(DeviceStatisticsModels model, int index);

        public static event UpdateYieldTable OnUpdateYieldTable;

        /// <summary>
        /// 通知重新渲染数据统计
        /// </summary>
        /// <param name="model"></param>
        /// <param name="index"></param>
        public static void UpdateYieldTableMessageSend(DeviceStatisticsModels model, int index)
        {
            OnUpdateYieldTable?.Invoke(model, index);
        }
        #endregion

        #region 更新产能数据渲染（统计图型）
        public delegate void UpdateCapaticyChart(int index);

        public static event UpdateCapaticyChart OnUpdateCapaticyChart;

        /// <summary>
        /// 通知重新渲染数据统计
        /// </summary>
        /// <param name="model"></param>
        /// <param name="index"></param>
        public static void UpdateCapaticyChartMessageSend(int index)
        {
            OnUpdateCapaticyChart?.Invoke(index);
        }
        #endregion

    }
}
