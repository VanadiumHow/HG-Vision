using BaseThread;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.ConstantModel;
using Obj.Obj_File;
using Obj.Obj_Queue;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Vision
{
    public class ImageConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(Project.Instance.VisionManagerInstance._visionParamPath + "\\ImageParams.ini");

        /// <summary>
        /// ImageParamsModel,初始化ImageParams
        /// </summary>
        public void AnalysisImageParamsConfig(ref List<ImageParamsModel> imageParams)
        {
            try
            {
                InitConfigDirctory();
                imageParams = new List<ImageParamsModel>();
                imageParams.Clear();
                //读取图像保存参数
                for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamsModel.WorkFlowNum; i++)
                {
                    ImageParamsModel imp = new ImageParamsModel();
                    imp.RawImagePattern = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RAWPATTERN");
                    imp.ResultImagePattern = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RESULTPATTERN");
                    imp.RawImagePosition = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RawImagePosition");
                    imp.ResultImagePosition = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ResultImagePosition");
                    imp.RawKeepingDays = Convert.ToInt16(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RawKeepingDays"));
                    imp.ResultKeepingDays = Convert.ToInt16(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ResultKeepingDays"));
                    imp.RawImageSaveOpportunity = (ImageParamsModel.SAVEOPPORTUNITY)(Convert.ToInt32(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ISRAWSAVE").ToString()));
                    imp.ResultImageSaveOpportunity = (ImageParamsModel.SAVEOPPORTUNITY)(Convert.ToInt32(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ISRESULTSAVE").ToString()));
                    imageParams.Add(imp);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析图像保存参数配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析图像保存参数配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }


        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                string ss = Project.Instance.VisionManagerInstance._visionParamPath.ToString();
                //配置文件夹
                if (!Directory.Exists(Project.Instance.VisionManagerInstance._visionParamPath))
                    Directory.CreateDirectory(Project.Instance.VisionManagerInstance._visionParamPath);
                //主配置文件ini
                if (!File.Exists(Project.Instance.VisionManagerInstance._visionParamPath + "\\ImageParams.ini"))
                    File.Create(Project.Instance.VisionManagerInstance._visionParamPath + "\\ImageParams.ini").Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查图像保存参数配置文件路径出现异常", ex);
            }
        }

        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveOneParams(string section, string node, string value)
        {
            try
            {
                _ini.WriteIniKey(section, node, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"{section}段 {node} 节点 写入{value}出现异常：{ex.Message}");
            }
        }
    }

    public class ImageSave
    {
        //存图队列
        internal List<BlockQueue<TriggerEventArgs>> saveImageQueueList = new List<BlockQueue<TriggerEventArgs>>();
        private Control_Thread[] _Threads;
        public void InitSaveImage()
        {
            SaveImageThread mSaveImageThread = new SaveImageThread();
            _Threads = new Control_Thread[] { mSaveImageThread };
            if (_Threads.Length < Project.Instance.GlobalManagerInstance.GlobalParamsModel.WorkFlowNum)
            {
                MessageBox.Show("存图线程数量不足工作流程数量，请检查代码或配置文件！", "提示", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // 手动填充空对象
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamsModel.WorkFlowNum; i++)
            {
                saveImageQueueList.Add(null); // 初始化每个元素
            }
            for (int i = 0; i < _Threads.Length; i++)
            {
                if (saveImageQueueList[i] == null)
                {
                    saveImageQueueList[i] = new BlockQueue<TriggerEventArgs>(20);
                }
            }
            mSaveImageThread.SaveImageQueue = saveImageQueueList[0];
            mSaveImageThread.Initialize();
        }
        public void CloseSaveImage()
        {
            for (int i = 0; i < saveImageQueueList.Count; i++)
            {
                saveImageQueueList[i].CompleteAdding();
                //自旋判断队列是否消费完
                while (!saveImageQueueList[i].IsCompleted)
                {
                    Thread.Sleep(200);//阻塞当前调用线程，等待队列数据处理完
                }
            }
            for (int i = 0; i < _Threads.Length; i++)
            {
                if (_Threads[i] != null)
                {
                    _Threads[i].Deinitialize();
                }
            }
            Thread.Sleep(30);
            for (int i = 0; i < saveImageQueueList.Count; i++)
            {
                saveImageQueueList[i].Close();
            }
        }

    }


}
