using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Globalization;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Common
{
    public sealed class LogHelper
    {
        /// <summary>
        /// 一般错误
        /// </summary>
        private readonly log4net.ILog _logerror = log4net.LogManager.GetLogger("logerror");
        /// <summary>
        /// 信息日志
        /// </summary>
        private readonly log4net.ILog _loginfo = log4net.LogManager.GetLogger("loginfo");
        /// <summary>
        /// 致命错误
        /// </summary>
        private readonly log4net.ILog _logfatal = log4net.LogManager.GetLogger("logfatal");
        /// <summary>
        /// 调试日志
        /// </summary>
        private readonly log4net.ILog _logdebug = log4net.LogManager.GetLogger("logdebug");
       

        /// <summary>
        /// 任务队列
        /// </summary>
        private readonly BlockQueue<FlashLogModel> _flashLogQueue = new BlockQueue<FlashLogModel>(500);
        /// <summary>
        /// 处理任务队列线程
        /// </summary>
        private Thread _flashLogThread;

        /// <summary>
        /// 日志类
        /// </summary>
        private static LogHelper _logHelper = new LogHelper();

        private LogHelper()
        {
        }

        /// <summary>
        /// 实现单例
        /// </summary>
        /// <returns></returns>
        public static LogHelper Instance()
        {
            return _logHelper;
        }

        #region 启动日志处理线程
        /// <summary>
        /// 启动日志处理线程
        /// </summary>
        public void InitThread()
        {
            _flashLogThread = new Thread(PersistentLog);
            _flashLogThread.SetApartmentState(ApartmentState.STA);//2025  04  07
            _flashLogThread.Start();
        }
        #endregion

        #region 加入到队列
        /// <summary>
        /// 加入阻塞队列
        /// </summary>
        /// <param name="message">日志文本</param>
        /// <param name="level">等级</param>
        /// <param name="ex">Exception</param>
        public void EnqueueMessage(string message, FlashLogLevel level, Exception ex = null)
        {
            if ((level == FlashLogLevel.Debug && _logdebug.IsDebugEnabled)
             || (level == FlashLogLevel.Error && _logerror.IsErrorEnabled)
             || (level == FlashLogLevel.Fatal && _logfatal.IsFatalEnabled)
             || (level == FlashLogLevel.Info && _loginfo.IsInfoEnabled))
            {
                _flashLogQueue.TryEnqueue(new FlashLogModel
                {
                    Message = message,
                    Level = level,
                    Exception = ex
                });
            }
        }

        /// <summary>
        /// 调试信息日志
        /// </summary>
        /// <param name="msg"></param>
        public static void Debug(string msg)
        {
            Instance().EnqueueMessage(msg, FlashLogLevel.Debug);
        }

        /// <summary>
        /// 一般信息日志
        /// </summary>
        /// <param name="msg"></param>
        public static void Info(string msg)
        {
            Instance().EnqueueMessage(msg, FlashLogLevel.Info);
        }

        /// <summary>
        /// 一般错误日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void Error(string msg, Exception ex = null)
        {
            Instance().EnqueueMessage(msg, FlashLogLevel.Error, ex);
        }

        /// <summary>
        /// 致命错误日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public static void Fatal(string msg, Exception ex = null)
        {
            Instance().EnqueueMessage(msg, FlashLogLevel.Fatal, ex);
        }
        #endregion

        #region 消费队列
        /// <summary>
        /// 从队列中持久化日志至磁盘
        /// </summary>
        private void PersistentLog()
        {
            while (!_flashLogQueue.IsCompleted)
            {
                FlashLogModel msg = _flashLogQueue.Dequeue();
                try
                {
                    switch (msg.Level)
                    {
                        case FlashLogLevel.Debug:
                            _logdebug.Debug(msg.Message);
                            break;
                        case FlashLogLevel.Info:
                            _loginfo.Info(msg.Message);
                            break;
                        case FlashLogLevel.Error:
                            _logerror.Error(msg.Message, msg.Exception);
                            break;
                        case FlashLogLevel.Fatal:
                            _logfatal.Fatal(msg.Message, msg.Exception);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend($"log4net写入日志出现异常失败：{ex.Message}", OutputLevelModel.ERROR);
                }
            }
        }
        #endregion

        #region 清除日志
        /// <summary>
        /// 清除历史日志
        /// </summary>
        public static void CleanHistoryLog(int logSaveDays)
        {
            string path = FilePathModel.LogPath;
            string temp;
            DateTime dirDateTime;
            try
            {
                if (Directory.Exists(path))
                {
                    foreach (string dirname in Directory.GetDirectories(path))
                    {
                        foreach (FileSystemInfo fsinfo in new DirectoryInfo(dirname).GetFileSystemInfos())
                        {
                            if (fsinfo is DirectoryInfo)
                            {
                                temp = fsinfo.FullName.Substring(fsinfo.FullName.LastIndexOf('\\') + 1);
                                dirDateTime = DateTime.ParseExact(temp, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None);
                                if ((DateTime.Now - dirDateTime).Days >= logSaveDays)
                                {
                                    Directory.Delete(fsinfo.FullName, true);
                                }
                            }
                            else if (fsinfo is FileInfo)
                            {
                                temp = fsinfo.FullName.Substring(fsinfo.FullName.LastIndexOf('\\') + 1);
                                temp = temp.Substring(0, temp.LastIndexOf('_'));
                                dirDateTime = DateTime.ParseExact(temp, "yyyyMMdd", CultureInfo.CurrentCulture, DateTimeStyles.None);
                                if ((DateTime.Now - dirDateTime).Days >= logSaveDays)
                                {
                                    File.Delete(fsinfo.FullName);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("自动清除历史日志出现异常", ex);
            }
        }
        #endregion

    }

    /// <summary>
    /// 日志内容
    /// </summary>
    public class FlashLogModel
    {
        public string Message { get; set; }
        public FlashLogLevel Level { get; set; }
        public Exception Exception { get; set; }

    }
}
