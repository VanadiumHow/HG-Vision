using System;
using System.Windows.Forms;
using Model.ConstantModel;
using Obj.Obj_File;
using Obj.Obj_Image;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Contol.Control_Vision;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Vision
{
    public class VisionManager
    {
        /// <summary>
        /// 图像保存参数管理类
        /// </summary>
        public ImageManager ImageManagerInstance;
        /// <summary>
        /// 相机参数管理类
        /// </summary>
        public CameraParamsManager CameraParamsManagerInstance;

        /// <summary>
        /// 相机管理类
        /// </summary>
        public CameraManager CameraManagerInstance;

        #region 视觉工具路径和视觉参数路径  程序加载时自动赋值或者切换产品时更新赋值
        /// <summary>
        /// 相机加载工具路径（分产品）
        /// </summary>
        public string _visionToolPath;

        /// <summary>
        /// 相机加载参数路径（分产品）
        /// </summary>
        public string _visionParamPath;
        #endregion

        /// <summary>
        /// 相机数量
        /// </summary>
        public int CameraNum
        {
            get { return Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum; }
        }

        internal VisionManager() { }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            LoadVision();
        }

        #region 视觉

        /// <summary>
        /// 加载视觉
        /// </summary>
        public void LoadVision()
        {
            try
            {
                //先获取路径
                LoadVisionPath();
                ManagerInstance();
                LoadImageParam();
                LoadVisionParam();
                LoadVisionTool();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载视觉检测工具出现异常：{ex.Message}");
                LogHelper.Error("加载视觉检测工具出现异常", ex);
            }
        }

        /// <summary>
        /// 声明相机管理类
        /// </summary>
        public void ManagerInstance()
        {
            ImageManagerInstance = new ImageManager();
            CameraParamsManagerInstance = new CameraParamsManager();
            CameraManagerInstance = new CameraManager();
        }

        /// <summary>
        /// 加载视觉参数、视觉工具的路径
        /// </summary>
        public void LoadVisionPath()
        {
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel)
            {
                //当前型号为空
                if (string.IsNullOrEmpty(Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel))
                {
                    MessageBox.Show("Configuration设置CurProductModel为空，请先将UseProductModel设置为0！");

                    _visionToolPath = FilePathModel.VisionDefaultPath + "\\VisionTool";
                    _visionParamPath = FilePathModel.VisionDefaultPath + "\\VisionParam";
                    Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel = "默认";
                }
                else
                {
                    _visionToolPath = FilePathModel.ProductPath + "\\" + Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel + "\\VisionTool";
                    _visionParamPath = FilePathModel.ProductPath + "\\" + Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel + "\\VisionParam";
                }
            }
            else
            {
                _visionToolPath = FilePathModel.VisionDefaultPath + "\\VisionTool";
                _visionParamPath = FilePathModel.VisionDefaultPath + "\\VisionParam";
            }
        }

        /// <summary>
        /// 加载图像参数
        /// </summary>
        public void LoadImageParam()
        {
            ImageManagerInstance.Initial();
        }


        /// <summary>
        /// 加载视觉参数
        /// </summary>
        public void LoadVisionParam()
        {
            CameraParamsManagerInstance.Initial();
        }

        /// <summary>
        /// 加载视觉工具
        /// </summary>
        public void LoadVisionTool()
        {
            CameraManagerInstance.Initial();
        }
        #endregion

        #region 图像
        /// <summary>
        /// 初始化保存图像，如队列，开启线程
        /// </summary>
        public void InitSaveImageThreads()
        {
            Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.InitSaveImage();
        }

        /// <summary>
        /// 关闭存图队列、线程
        /// </summary>
        public void CloseSaveImageQueue()
        {
            Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageSave.CloseSaveImage();
        }

        /// <summary>
        /// 获取原始图像保存路径
        /// </summary>
        public string GetRawImagePosition()
        {
            return Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].RawImagePosition;
        }

        /// <summary>
        /// 获取处理图像保存路径
        /// </summary>
        public string GetResultImagePosition()
        {
            return Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].ResultImagePosition;
        }
        /// <summary>
        /// 清除图片
        /// </summary>
        public void CleanHistoryImage()
        {
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum; i++)
            {
                ImageParamsModel imageParams = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[i];
                ImageStoreHelper.CleanHistoryPicture(imageParams);
            }
        }
        #endregion

    }
}
