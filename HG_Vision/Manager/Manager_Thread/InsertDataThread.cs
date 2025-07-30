using BaseThread;
using HG_Vision.DAL;
using Model.DataModel;
using Obj.Obj_File;
using Obj.Obj_Queue;
using System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Thread
{
    internal class InsertDataThread : Control_Thread
    {
        private BlockQueue<OperationLogDataModel> _taskQueue;
        OperationLogDataDal logDataDal;
        public InsertDataThread(BlockQueue<OperationLogDataModel> _block, OperationLogDataDal _dataDal)
        {
            _taskQueue = _block;
            logDataDal = _dataDal;
        }
        public override void Initialize() => base.Start(1000, "InsertDataThread");
        public override void Deinitialize()
        {
            if (_taskQueue.IsCompleted)
                base.Stop();
        }
        protected override void Run()
        {
            if (_taskQueue.IsCompleted)
            {
                return;
            }
            try
            {
                OperationLogDataModel logData = _taskQueue.Dequeue();
                if (logData != null)
                {
                    try
                    {
                        InsertData(logData);
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error("线程处理操作日志出现异常", ex);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("线程处理操作日志出现异常", ex);
            }
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
    }
}
