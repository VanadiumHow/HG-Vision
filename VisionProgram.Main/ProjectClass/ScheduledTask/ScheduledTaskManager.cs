using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using VisionProgram.Common;
using VisionProgram.Main.BLL;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.ProjectClass.ScheduledTask
{
    public class ScheduledTaskManager
    {
        /// <summary>
        /// 刷新状态指示灯
        /// </summary>
        private static System.Threading.Timer _hardWareStateDisplayTask;
        /// <summary>
        /// 刷新指示灯事件
        /// </summary>
        public Action OnRefreshHardWareStateDisplay;


        /// <summary>
        /// 刷新PLC交互信号监控
        /// </summary>
        public List<System.Timers.Timer> L_SignalMonitorTimer = new List<System.Timers.Timer>();
        /// <summary>
        /// 刷新PLC交互信号监控事件
        /// </summary>
        public Action<int> OnMonitorSignalExchange;


        /// <summary>
        /// 每天定时8:10分 
        /// </summary>
        private System.Timers.Timer _everyDayTask = new System.Timers.Timer(60000);



        internal ScheduledTaskManager() { }

        /// <summary>
        /// 开始定时器定时操作
        /// </summary>
        public void StartTask()
        {
            _hardWareStateDisplayTask = new System.Threading.Timer(hardWareStateDisplayTimerCallBack, 300, 0, Timeout.Infinite);

            InitSignalMonitor();

            _everyDayTask.Elapsed += EveryDayTimer_Elapsed;
            _everyDayTask.Start();

        }



        #region 刷新设备状态指示灯
        /// <summary>
        /// 刷新状态指示灯
        /// </summary>
        /// <param name="obj"></param>
        private void hardWareStateDisplayTimerCallBack(object obj)
        {
            OnRefreshHardWareStateDisplay?.Invoke();
            _hardWareStateDisplayTask.Change((int)obj, Timeout.Infinite);
        }
        #endregion

        #region 刷新PLC信号交互监控
        /// <summary>
        /// 刷新信号交互
        /// </summary>
        /// <param name="obj"></param>
        private void SignalMonitorTimer_Elapsed(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            object data = args.obj;
            int index = (int)data;

            OnMonitorSignalExchange?.Invoke(index);
        }

        private void InitSignalMonitor()
        {
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                int index = i;
                L_SignalMonitorTimer.Add(new System.Timers.Timer(300));
                L_SignalMonitorTimer[index].Elapsed += (o, e) => { SignalMonitorTimer_Elapsed(this, new MyEventArgs(index)); };
            }
        }

        public bool IsStartSignalMonitor(int index)
        {
            return L_SignalMonitorTimer[index].Enabled;
        }

        public void StartSignalMonitor(int index)
        {
            if (L_SignalMonitorTimer[index].Enabled)
                L_SignalMonitorTimer[index].Stop();
            L_SignalMonitorTimer[index].AutoReset = true;
            L_SignalMonitorTimer[index].Start();
        }

        public void StopSignalMonitor(int index)
        {
            if (L_SignalMonitorTimer[index].Enabled)
                L_SignalMonitorTimer[index].Stop();
        }
        #endregion

        #region 每天定时
        /// <summary>
        /// 每天定时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EveryDayTimer_Elapsed(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm") == "08:10")
            {
                //1.清空产能数据
                this.ClearProductData();
                //2.判断清除日志
                this.ClearLog();
                //3.判断清除N天前的图片
                this.ClearPicture();
            }
        }

        /// <summary>
        /// 清空产能数据 良率数据
        /// </summary>
        public void ClearProductData()
        {
            new Action(() =>
            {
                try
                {
                    Project.Instance().ProductionDataManagerInstance.ClearProductionData();
                    NoticeHelper.UpdateCapaticyChartMessageSend(-1);
                    NoticeHelper.UpdateYieldTableMessageSend(DeviceStatisticsModels.All, -1);
                    NoticeHelper.OutputMessageSend($"清空产能/良率完成", OutputLevelModel.INFO);
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend($"产能/良率数据自动清零出现异常：{ex.Message}", OutputLevelModel.ERROR);
                    LogHelper.Error("产能/良率数据自动清零出现异常：", ex);
                }
            }).BeginInvoke(null, null);
        }

        /// <summary>
        /// 判断清除N天前的日志
        /// </summary>
        public void ClearLog()
        {
            new Action(() =>
            {
                LogHelper.CleanHistoryLog(Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays);
                NoticeHelper.OutputMessageSend($"清空N天前的日志完成-----------------------------------------------------------------------", OutputLevelModel.INFO);
            }).BeginInvoke(null, null);
        }

        /// <summary>
        /// 判断清除N天前的图片
        /// </summary>
        public void ClearPicture()
        {
            new Action(() =>
            {
                Project.Instance().VisionManagerInstance.CleanHistoryImage();
                NoticeHelper.OutputMessageSend($"清空N天前的图片完成-----------------------------------------------------------------------", OutputLevelModel.INFO);
            }).BeginInvoke(null, null);
        }

        #endregion



        #region 停止定时任务
        /// <summary>
        /// 停止定时任务
        /// </summary>
        public void ScheduledTaskDispose()
        {
            try
            {
                if (_hardWareStateDisplayTask != null)
                    _hardWareStateDisplayTask.Dispose();

                if (L_SignalMonitorTimer != null && L_SignalMonitorTimer.Count > 0)
                {
                    for (int i = 0; i < L_SignalMonitorTimer.Count; i++)
                    {
                        L_SignalMonitorTimer[i].Dispose();
                    }
                }

                if (_everyDayTask != null)
                    _everyDayTask.Dispose();

            }
            catch (Exception ex)
            {
                LogHelper.Error("退出程序操作停止定时任务出现异常", ex);
            }
        }
        #endregion
    }
}
