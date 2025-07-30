using HG_Vision.DAL;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.DataModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using Obj.Obj_Queue;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Sql
{
    public class OperationLogDataBll
    {
        OperationLogDataDal logDataDal = new OperationLogDataDal();

        //任务队列
        private BlockQueue<OperationLogDataModel> _taskQueue = new BlockQueue<OperationLogDataModel>(50);
        // 处理任务队列线程
        private InsertDataThread _workThread;

        /// <summary>
        /// 单例
        /// </summary>
        private static readonly OperationLogDataBll _instance = new OperationLogDataBll();
        private OperationLogDataBll() { }
        public static OperationLogDataBll GetInstance()
        {
            return _instance;
        }

        #region 开启线程
        public void InitThread()
        {
            _workThread = new InsertDataThread(_taskQueue, logDataDal);
            _workThread.SetApartmentState(ApartmentState.STA);
            _workThread.Initialize();
        }
        #endregion

        #region 入队按数据库方式保存/按日志方式保存
        /// <summary>
        /// 操作日志处理
        /// </summary>
        /// <param name="logData"></param>
        public void OperationLogProcessFactory(OperationLogDataModel logData)
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.saveOperationLogsByDB)
            {
                SaveOperationLogByDB(logData);
            }
            else
            {
                SaveOperationLogByLogger(logData);
            }
        }

        /// <summary>
        /// 按数据库方式
        /// </summary>
        /// <param name="logData"></param>
        private void SaveOperationLogByDB(OperationLogDataModel logData)
        {
            _taskQueue.Enqueue(logData);
        }

        /// <summary>
        /// 按日志记录方式
        /// </summary>
        /// <param name="logData"></param>
        private void SaveOperationLogByLogger(OperationLogDataModel logData)
        {
            LogHelper.Info(logData.GetStr());
        }
        #endregion

        #region 出队保存操作日志

        public void InsertOperationLog(List<OperationLogParamModel.OldParam> oldParamObjects,string tag)
        {
            try
            {
                foreach (OperationLogParamModel.OldParam item in oldParamObjects)
                {
                    OperationLogProcessFactory(new OperationLogDataModel(
                    Project.Instance.UserInfoManagerInstance.LoginUser.UserRoleName,
                    OperationLogParamModel.LogCTypes[2], item.Field, item.OldValue, item.NewValue, string.Format("触发{0}，将{1}从{2}变成{3}", $"修改{tag}参数", item.Text,
                    item.OldValue, item.NewValue)));
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"保存参数修改日志异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Error("保存参数修改日志异常", ex);
            }
        }
        #endregion

        #region 数据库操作
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="logDataQuery"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet SelectOperationLogDataByPage(QueryLogDataModel logDataQuery, int startIndex, int pageSize)
        {
            return logDataDal.LoadOperationLogDataByPage(logDataQuery, startIndex, pageSize);
        }


        /// <summary>
        /// 插入敏感日志
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool InsertData(OperationLogDataModel logData)
        {
            try
            {
                return logDataDal.InsertOperationLogData(logData) > 0;
            }
            catch (Exception ex)
            {
                LogHelper.Error("操作日志插入失败", ex);
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 获取中文对应的英文类型
        /// </summary>
        /// <param name="types"></param>
        /// <returns></returns>
        public static string getLogTypeCtoE(string type)
        {
            if (OperationLogParamModel.LogCTypes.Contains(type))
            {
                return OperationLogParamModel.LogETypes[OperationLogParamModel.LogCTypes.ToList().IndexOf(type)];
            }
            else
            {
                return null;
            }
        }

        #region 关闭队列
        public void CloseQueue()
        {
            //先停止队列再加入
            _taskQueue.CompleteAdding();
            //自旋判断队列是否消费完
            while (!_taskQueue.IsCompleted)
            {              
                Thread.Sleep(100);//阻塞当前调用线程，等待队列数据处理完
            }
            if (_workThread != null)
            {
                _workThread.Deinitialize();
            }
            Thread.Sleep(30);
            _taskQueue.Close();
        }
        #endregion
    }
}
