using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Drawing.Imaging;
using Cognex.VisionPro;
using Model.ConstantModel;
using Obj.Obj_File;
using System.Linq;

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
                // 原始图像文件夹-确保目录存在
                Directory.CreateDirectory(imageParams.RawImagePosition);
                // 结果图片文件夹-确保目录存在
                Directory.CreateDirectory(imageParams.ResultImagePosition);

                // 清理原始图历史目录
                foreach (string dirname in Directory.GetDirectories(imageParams.RawImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    if (DateTime.TryParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out dirDateTime)
                        && (DateTime.Now - dirDateTime).Days >= imageParams.RawKeepingDays)
                    {
                        Directory.Delete(dirname, true);
                    }
                }

                // 清理结果图历史目录
                foreach (string dirname in Directory.GetDirectories(imageParams.ResultImagePosition))
                {
                    temp = dirname.Substring(dirname.LastIndexOf('\\') + 1);
                    if (DateTime.TryParseExact(temp, "yyyy-MM-dd", CultureInfo.CurrentCulture, DateTimeStyles.None, out dirDateTime)
                        && (DateTime.Now - dirDateTime).Days >= imageParams.ResultKeepingDays)
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
        public static void SaveResultImage(CogRecordsDisplay _cd, string imagename, bool bOK, string ymd, string hms, int index, ImageParamsModel imageParams)
        {
            if (imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.NONE)
                return;
            if ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ALL)
                || ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((imageParams.ResultImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveResultImageHelper(_cd, imagename, ymd, hms, index, bOK, imageParams);
            }
        }

        /// <summary>
        /// 存结果图-核心修复方法
        /// </summary>
        private static void SaveResultImageHelper(CogRecordsDisplay _cd, string imageName, string ymd, string hms, int index, bool isOk, ImageParamsModel imageParams)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((d) =>
            {
                try
                {
                    // 1. 工位判断：根据图片名称首字符确定工位（1=工位1，其他=工位2）
                    string station = imageName.StartsWith("1-1") ? "工位1" : "工位2";
                    // 2. 构建保存根路径（规范路径拼接，避免\\拼接问题）
                    string rootPath = Path.Combine(imageParams.ResultImagePosition, ymd, station, isOk ? "OK" : "NG");
                    // 3. 检查并创建目录（含盘符校验，抽离公共方法减少冗余）
                    if (!TryCreateSaveDirectory(rootPath))
                    {
                        LogHelper.Error($"创建结果图保存目录失败，盘符不存在：{rootPath}");
                        return;
                    }
                    // 4. 构建最终保存文件路径（规范拼接，避免非法字符）
                    string savePath = Path.Combine(rootPath, $"{imageName}-{hms}{imageParams.ResultImagePattern}");

                    // 【核心修复】使用using语句封装Image对象，自动释放GDI+非托管资源
                    // 解决GDI+一般性错误的根本方案，代码块结束自动执行Dispose()
                    using (Image ig = _cd.Display.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Custom, null, 0))
                    {
                        // 统一格式保存，根据配置的后缀自动匹配ImageFormat，消除重复switch
                        ImageFormat saveFormat = GetImageFormatByExtension(imageParams.ResultImagePattern);
                        ig.Save(savePath, saveFormat);
                    } // 此处自动释放ig的GDI+资源，无论是否保存成功
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
        public static void SaveRawImage(ICogImage img, string imagename, bool bOK, string ymd, string hms, int index, ImageParamsModel imageParams)
        {
            if (imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.NONE)
                return;
            if ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ALL)
                || ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYOK) && bOK)
                || ((imageParams.RawImageSaveOpportunity == ImageParamsModel.SAVEOPPORTUNITY.ONLYNG) && !bOK))
            {
                SaveRawImageHelper(img, imagename, ymd, hms, index, bOK, imageParams);
            }
        }

        /// <summary>
        /// Image转字节数组
        /// </summary>
        public static byte[] ImageToBytes(Image image, string formatPattern)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ImageFormat format = GetImageFormatByExtension(formatPattern);
                image.Save(ms, format);
                // 直接返回ToArray，简化流读取逻辑，避免Seek/Read的冗余操作
                return ms.ToArray();
            }
        }

        /// <summary>
        /// 存原图-辅助方法
        /// </summary>
        private static void SaveRawImageHelper(ICogImage img, string imageName, string ymd, string hms, int index, bool isOk, ImageParamsModel imageParams)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((d) =>
            {
                Cognex.VisionPro.ImageFile.CogImageFileTool imageFileTool = null;
                try
                {
                    // 1. 工位判断+路径构建（统一规范）
                    string station = imageName.StartsWith("1-1") ? "工位1" : "工位2";
                    string rootPath = Path.Combine(imageParams.RawImagePosition, ymd, station, isOk ? "OK" : "NG");
                    // 2. 检查并创建目录
                    if (!TryCreateSaveDirectory(rootPath))
                    {
                        LogHelper.Error($"创建原始图保存目录失败，盘符不存在：{rootPath}");
                        return;
                    }
                    // 3. 构建保存路径
                    string savePath = Path.Combine(rootPath,
                        imageName.StartsWith("1")
                            ? $"{imageName}-{hms}{imageParams.RawImagePattern}"
                            : $"{imageName}-{hms}{imageParams.RawImagePattern}");

                    // 4. 保存原始图（CogImageFileTool优化为using封装，自动释放）
                    using (imageFileTool = new Cognex.VisionPro.ImageFile.CogImageFileTool())
                    {
                        imageFileTool.InputImage = img;
                        imageFileTool.Operator.Open(savePath, Cognex.VisionPro.ImageFile.CogImageFileModeConstants.Write);
                        imageFileTool.Run();
                    } // 自动释放imageFileTool资源，替代手动Dispose()
                }
                catch (Exception ex)
                {
                    LogHelper.Error("存相机VP原始图出现异常", ex);
                }
                // 移除手动Dispose()，由using自动处理
            });
        }
        #endregion

        #region 公共辅助方法（抽离冗余逻辑，提升可维护性）
        /// <summary>
        /// 检查盘符并创建保存目录（无修改，兼容C#7.3）
        /// </summary>
        private static bool TryCreateSaveDirectory(string directoryPath)
        {
            try
            {
                string driveRoot = Path.GetPathRoot(directoryPath);
                bool driveExists = DriveInfo.GetDrives().Any(f => f.Name.Equals(driveRoot, StringComparison.OrdinalIgnoreCase));
                if (!driveExists)
                    return false;
                Directory.CreateDirectory(directoryPath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 根据文件后缀获取ImageFormat【适配C#7.3：传统switch+case穿透，替代switch表达式+or】
        /// </summary>
        /// <param name="extension">文件后缀（如.jpg/.png）</param>
        /// <returns>对应的ImageFormat</returns>
        private static ImageFormat GetImageFormatByExtension(string extension)
        {
            // 统一转小写，避免大小写判断问题
            string lowerExt = extension.ToLower();
            // C#7.3支持的传统switch语句
            switch (lowerExt)
            {
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".png":
                    return ImageFormat.Png;
                case ".tif":
                    return ImageFormat.Tiff;
                case ".jpg":
                case ".jpeg":
                    return ImageFormat.Jpeg;
                default: // 默认返回JPG格式，与原逻辑一致
                    return ImageFormat.Jpeg;
            }
        }
        #endregion
    }
}