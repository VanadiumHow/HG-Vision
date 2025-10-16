using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;
using Cognex.VisionPro;
using Model.ConstantModel;
using Obj.Obj_File;

/****************************************************************

*****************************************************************/
namespace Obj.Obj_Image
{
    /// <summary>
    /// 保存图片辅助类
    /// </summary>
    public static class ImageStoreHelper
    {
        /// <summary>
        /// 清除历史存图
        /// </summary>
        public static void CleanHistoryPicture(ImageParamsModel imageParams)
        {
            string temp;
            DateTime dirDateTime;
            try
            {
                //原始图像文件夹
                if (!Directory.Exists(imageParams.RawImagePosition))
                    Directory.CreateDirectory(imageParams.RawImagePosition);
                //结果图片文件夹
                if (!Directory.Exists(imageParams.ResultImagePosition))
                    Directory.CreateDirectory(imageParams.ResultImagePosition);

                foreach (string dirname in Directory.GetDirectories(imageParams.RawImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    dirDateTime = DateTime.ParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None);

                    if ((DateTime.Now - dirDateTime).Days >= imageParams.RawKeepingDays)
                    {
                        Directory.Delete(dirname, true);
                    }
                }

                foreach (string dirname in Directory.GetDirectories(imageParams.ResultImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    dirDateTime = DateTime.ParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None);
                    if ((DateTime.Now - dirDateTime).Days >= imageParams.ResultKeepingDays)
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
        public static void SaveResultImage(CogRecordsDisplay _cd, string imagename, bool bOK, string ymd, string hms, int index, ImageParamsModel imageParams)
        {
            if (imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.NONE)
                return;
            if ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ALL)
                || ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveResultImageHelper(_cd, imagename, ymd, hms, index, bOK, imageParams);
                return;
            }
        }

        /// <summary>
        /// 存结果图
        /// </summary>
        /// <param name="_cd"></param>
        /// <param name="imagename"></param>
        private static void SaveResultImageHelper(CogRecordsDisplay _cd, string imageName, string ymd, string hms, int index, bool isOk, ImageParamsModel imageParams)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((d) =>
            {
                try
                {

                    string path = imageParams.RawImagePosition + @"\" + ymd + @"\" + "工位1" + (isOk ? "\\OK" : "\\NG");
                    string path1 = imageParams.ResultImagePosition + @"\" + ymd + @"\" + "工位2" + (isOk ? "\\OK" : "\\NG");
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (!Directory.Exists(path1))
                    {
                        Directory.CreateDirectory(path1);
                    }
                    string str = path + @"\" + imageName + "-" + hms + imageParams.ResultImagePattern;//YBH
                    string str1 = path1 + @"\" + imageName + "-" + hms + imageParams.ResultImagePattern;

                    System.Drawing.Image ig = _cd.Display.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Custom, null, 0);
                    string L = "1";

                    string format = imageParams.ResultImagePattern;
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
        public static void SaveRawImage(ICogImage img, string imagename, bool bOK, string ymd, string hms, int index, ImageParamsModel imageParams)
        {
            if (imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.NONE)
                return;
            if ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ALL)
                || ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveRawImageHelper(img, imagename, ymd, hms, index, bOK, imageParams);
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
        private static void SaveRawImageHelper(ICogImage img, string imageName, string ymd, string hms, int index, bool isOk, ImageParamsModel imageParams)
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
                    string path = imageParams.RawImagePosition + @"\" + ymd1 + @"\" + "工位1" + (isOk ? "\\OK" : "\\NG");
                    string path1 = imageParams.RawImagePosition + @"\" + ymd1 + @"\" + "工位2" + (isOk ? "\\OK" : "\\NG");
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
                    string L = "1";
                    if (imageName1.Substring(0, 1) == L)
                    {
                        string str = path + @"\" + imageName1 + "-" + hms + "-" + imageParams.RawImagePattern;//YBH
                        a.Operator.Open(str, Cognex.VisionPro.ImageFile.CogImageFileModeConstants.Write);
                        a.Run();
                        a.Dispose();
                    }
                    else
                    {
                        string str1 = path1 + @"\" + imageName1 + "-" + hms + imageParams.RawImagePattern;

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