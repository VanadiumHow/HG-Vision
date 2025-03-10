using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Vision.VP;

namespace VisionProgram.ProjectClass.Image
{
    /// <summary>
    /// 图片保存参数
    /// </summary>
    public class ImageParams
    {
        /// <summary>
        /// 图像保存位置
        /// </summary>
        public string RawImagePosition;
        public string ResultImagePosition;
        /// <summary>
        /// 图像保存天数
        /// </summary>
        public int RawKeepingDays;
        public int ResultKeepingDays;
        /// <summary>
        /// 图像保存格式
        /// </summary>
        public string RawImagePattern;
        public string ResultImagePattern;
        /// <summary>
        /// 图像保存模式
        /// </summary>
        public ImageStoreHelper.SAVEOPPORTUNITY RawImageSaveOpportunity;
        public ImageStoreHelper.SAVEOPPORTUNITY ResultImageSaveOpportunity;
    }

    public class ImageConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(Project.Instance().VisionManagerInstance._visionParamPath + "\\Config\\ImageParams.ini");

        /// <summary>
        /// 解析ImageParams,初始化ImageParams
        /// </summary>
        public void AnalysisImageParamsConfig(ref List<ImageParams> imageParams)
        {
            try
            {
                InitConfigDirctory();
                imageParams = new List<Image.ImageParams>();
                imageParams.Clear();
                //读取图像保存参数
                for (int i = 0; i < Project.Instance().GlobalManagerInstance.GlobalParamModel.WorkFlowNum; i++)
                {
                    ImageParams imp = new ImageParams();
                    imp.RawImagePattern = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RAWPATTERN");
                    imp.ResultImagePattern = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RESULTPATTERN");
                    imp.RawImagePosition = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RawImagePosition");
                    imp.ResultImagePosition = _ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ResultImagePosition");
                    imp.RawKeepingDays = Convert.ToInt16(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "RawKeepingDays"));
                    imp.ResultKeepingDays = Convert.ToInt16(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ResultKeepingDays"));
                    imp.RawImageSaveOpportunity = (ImageStoreHelper.SAVEOPPORTUNITY)(Convert.ToInt32(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ISRAWSAVE").ToString()));
                    imp.ResultImageSaveOpportunity = (ImageStoreHelper.SAVEOPPORTUNITY)(Convert.ToInt32(_ini.IniReadValue("IMAGESAVE" + (i + 1).ToString(), "ISRESULTSAVE").ToString()));
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
                string ss = Project.Instance().VisionManagerInstance._visionParamPath.ToString();
                //配置文件夹
                if (!Directory.Exists(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config"))
                    Directory.CreateDirectory(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config");
                //主配置文件ini
                if (!File.Exists(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config\\ImageParams.ini"))
                    File.Create(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config\\ImageParams.ini").Close();
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
        //存图线程
        public Thread[] mSaveImageThread = new Thread[Project.Instance().GlobalManagerInstance.GlobalParamModel.WorkFlowNum];
        //存图队列
        public BlockQueue<TriggerEventArgs>[] mSaveImageQueue = new BlockQueue<TriggerEventArgs>[Project.Instance().GlobalManagerInstance.GlobalParamModel.WorkFlowNum];
        public void InitSaveImage()
        {
            for (int i = 0; i < Project.Instance().GlobalManagerInstance.GlobalParamModel.WorkFlowNum; i++)
            {
                if (mSaveImageQueue[i] == null)
                {
                    mSaveImageQueue[i] = new BlockQueue<TriggerEventArgs>(20);
                }
                int workindex = i;
                (mSaveImageThread[i] = new Thread(() => WorkThreadSaveImage(workindex))).Start();
            }
        }
        public void WorkThreadSaveImage(int index)
        {
            while (true)
            {
                try
                {
                    TriggerEventArgs e = new TriggerEventArgs();
                    if (mSaveImageQueue[index].TryDequeue(out e))
                    {
                        SaveImage(e.rawImage, e.resultImage, e.imageName, e.results, DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("HH-mm-ss-ffffff"), e.Index);
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("存图线程异常", ex);
                }
                Thread.Sleep(10);
            }
        }
        public void CloseSaveImage()
        {
            for (int i = 0; i < mSaveImageQueue.Length; i++)
            {
                mSaveImageQueue[i].CompleteAdding();
            }

            for (int i = 0; i < mSaveImageQueue.Length; i++)
            {
                //自旋判断队列是否消费完
                while (!mSaveImageQueue[i].IsCompleted)
                {
                    Thread.Sleep(200);//阻塞当前调用线程，等待队列数据处理完
                }
            }
            Thread.Sleep(30);
            for (int i = 0; i < mSaveImageThread.Length; i++)
            {
                if (null != mSaveImageThread[i] && mSaveImageThread[i].IsAlive)
                {
                    mSaveImageThread[i].Abort();
                    mSaveImageThread[i] = null;
                }
            }
            for (int i = 0; i < mSaveImageQueue.Length; i++)
            {
                mSaveImageQueue[i].Close();
            }
        }
        public void SaveImage(ICogImage img, CogRecordsDisplay _cd, string imagename, bool bOK, string ymd, string hms, int index)
        {

            ImageStoreHelper.SaveRawImage(img, imagename, bOK, ymd, hms, index);
            ImageStoreHelper.SaveResultImage(_cd, imagename, bOK, ymd, hms, index);
        }
    }


}
