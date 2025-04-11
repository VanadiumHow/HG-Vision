using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ImageFile;
using System.IO;
using System.Globalization;
using VisionProgram.ProjectClass;
using System.Drawing.Imaging;
using VisionProgram.Main.ProjectClass;

namespace VisionProgram.Common
{
    /// <summary>
    /// 保存图片辅助类
    /// </summary>
    public static class ImageStoreHelper
    {
        /// <summary>
        /// 存图模式
        /// </summary>
        public enum SAVEOPPORTUNITY { NONE = 0, ONLYOK = 1, ONLYNG = 2, ALL = 3 }

        /// <summary>
        /// 清除历史存图
        /// </summary>
        public static void CleanHistoryPicture(int index)
        {
            string temp;
            DateTime dirDateTime;
            try
            {
                //原始图像文件夹
                if (!Directory.Exists(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition))
                    Directory.CreateDirectory(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition);
                //结果图片文件夹
                if (!Directory.Exists(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition))
                    Directory.CreateDirectory(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition);

                foreach (string dirname in Directory.GetDirectories(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    dirDateTime = DateTime.ParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None);

                    if ((DateTime.Now - dirDateTime).Days >= Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays)
                    {
                        Directory.Delete(dirname, true);
                    }
                }

                foreach (string dirname in Directory.GetDirectories(Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    dirDateTime = DateTime.ParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None);
                    if ((DateTime.Now - dirDateTime).Days >= Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays)
                    {
                        Directory.Delete(dirname, true);
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("自动清除历史存图出现异常", ex);
            }
        }

        #region VisionPro
        /// <summary>
        /// 存带结果图像
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="imagename"></param>
        /// <param name="bOK"></param>
        public static void SaveResultImage(CogRecordsDisplay _cd, string imagename, bool bOK, string ymd, string hms, int index)
        {
            if (Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity == SAVEOPPORTUNITY.NONE)
                return;
            if ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity == SAVEOPPORTUNITY.ALL)
                || ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity == SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity == SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveResultImageHelper(_cd, imagename, ymd, hms, index, bOK);
                return;
            }
        }

        /// <summary>
        /// 存结果图
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="imagename"></param>
        private static void SaveResultImageHelper(CogRecordsDisplay _cd, string imageName, string ymd, string hms, int index,bool isOk)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((d) =>
            {
                try
                {

                    string path= Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition + @"\" + ymd + @"\" + "CCD" +"工位1" + (isOk ? "\\OK" : "\\NG") ;
                    //string path = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition + @"\" + ymd + @"\" + "CCD" + imageName[0] + (isOk ? "\\OK" : "\\NG");
                    string path1 = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition + @"\" + ymd + @"\" + "CCD" + "工位2" + (isOk ? "\\OK" : "\\NG");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (!Directory.Exists(path1))
                    {
                        Directory.CreateDirectory(path1);
                    }
                    string str =path + @"\" + imageName + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern;//YBH
                    string str1 = path1 + @"\" + imageName + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern;
                    //string str = path + @"\" + hms + "_" + imageName + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern;
                    
                    System.Drawing.Image ig = _cd.Display.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Custom, null, 0);
                    string L = "1";
                   
                    string format = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern;
                    if (imageName.Substring(0, 1) == L)
                    {

                        switch (format)
                        {
                            case ".bmp":
                                ig.Save(str, ImageFormat.Bmp);
                                break;
                            case ".jpg":
                                ig.Save(str, ImageFormat.Jpeg);
                                break;
                            case ".png":
                                ig.Save(str, ImageFormat.Png);
                                break;
                            case ".tif":
                                ig.Save(str, ImageFormat.Tiff);
                                break;
                            default:
                                ig.Save(str, ImageFormat.Jpeg);
                                break;
                        }
                    }
                    else
                    {
                        switch (format)
                        {
                            case ".bmp":
                                ig.Save(str1, ImageFormat.Bmp);
                                break;
                            case ".jpg":
                                ig.Save(str1, ImageFormat.Jpeg);
                                break;
                            case ".png":
                                ig.Save(str1, ImageFormat.Png);
                                break;
                            case ".tif":
                                ig.Save(str1, ImageFormat.Tiff);
                                break;
                            default:
                                ig.Save(str1, ImageFormat.Jpeg);
                                break;
                        }
                    }
                    }
                catch (Exception ex)
                {
                    LogHelper.Error("存相机VP结果图出现异常", ex);
                }
            });
        }

        /// <summary>
        /// 存原图
        /// </summary>
        /// <param name="img"></param>
        /// <param name="imagename"></param>
        /// <param name="bOK"></param>
        public static void SaveRawImage(ICogImage img, string imagename, bool bOK, string ymd, string hms, int index)
        {
            if (Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity == SAVEOPPORTUNITY.NONE)
                return;
            if ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity == SAVEOPPORTUNITY.ALL)
                || ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity == SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity == SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveRawImageHelper(img, imagename, ymd, hms, index,bOK);
                return;
            }
        }
        public static byte[] ImageToBytes(Image image, string formatPattern)
        {
            ImageFormat format = image.RawFormat;
            using (MemoryStream ms = new MemoryStream())
            {
                switch (formatPattern)
                {
                    case ".bmp":
                        image.Save(ms, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        image.Save(ms, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        image.Save(ms, ImageFormat.Png);
                        break;
                    case ".tif":
                        image.Save(ms, ImageFormat.Tiff);
                        break;
                    default:
                        image.Save(ms, ImageFormat.Jpeg);
                        break;
                }
                byte[] buffer = new byte[ms.Length];
                //Image.Save()会改变MemoryStream的Position，需要重新Seek到Begin
                ms.Seek(0, SeekOrigin.Begin);
                ms.Read(buffer, 0, buffer.Length);
                return buffer;
            }
        }

        /// <summary>
        /// 存原图
        /// </summary>
        /// <param name="img"></param>
        /// <param name="imagename"></param>
        private static void SaveRawImageHelper(ICogImage img, string imageName, string ymd, string hms, int index,bool isOk)
        {
            ICogImage img1 = img;
            string imageName1 = imageName;
            string ymd1 = ymd;
            string hms1 = hms;
            int index1 = index;
            
            
            System.Threading.ThreadPool.QueueUserWorkItem((d) =>
            {
                try
                {
                    string path = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePosition + @"\" + ymd1 + @"\" + "CCD"+ "工位1"+(isOk ? "\\OK" : "\\NG");
                    string path1 = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePosition + @"\" + ymd1 + @"\" + "CCD" + "工位2" + (isOk ? "\\OK" : "\\NG");
                    //string path = Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePosition + @"\" + ymd1 + @"\" + "CCD" + imageName1[0] + (isOk ? "\\OK" : "\\NG");
                    if (!Directory.Exists(path))//2021_07_26\CCD1
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (!Directory.Exists(path1))//ybh
                    {
                        Directory.CreateDirectory(path1);
                    }
                    Cognex.VisionPro.ImageFile.CogImageFileTool a = new Cognex.VisionPro.ImageFile.CogImageFileTool();
                    a.InputImage = img1;
                    string L= "1";
                if (imageName1.Substring(0,1) == L)
                    {
                        //string str = path + @"\" + hms + "_" + imageName1 + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePattern;//12_34_45_1-1_OK_.BMP
                        string str = path + @"\"  + imageName1 + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePattern;//YBH
                        a.Operator.Open(str, Cognex.VisionPro.ImageFile.CogImageFileModeConstants.Write);
                        a.Run();
                        a.Dispose();
                    }
                    else
                    {
                        string str1 = path1 + @"\"  + imageName1 + Project.Instance().VisionManagerInstance.ImageManagerInstance.ImageParams[index1].RawImagePattern;

                        a.Operator.Open(str1, Cognex.VisionPro.ImageFile.CogImageFileModeConstants.Write);
                        a.Run();
                        a.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("存相机VP原始图出现异常", ex);
                }
            });
        }
        #endregion
    }
}