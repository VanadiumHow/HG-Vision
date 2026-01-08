using System;
using System.Collections.Generic;
using Cognex.VisionPro;
using Model.VisionModel;
using Obj.Obj_File;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Vision
{
    /// <summary>
    /// 相机参数管理类，用于输出对应相机的视觉参数
    /// </summary>
    public class CameraParamsManager
    {
        private CameraParamsConfiguration _cameraParamsConfiguration = new CameraParamsConfiguration();

        public CameraParamsConfiguration CameraParamsConfiguration
        {
            get { return _cameraParamsConfiguration; }
        }

        private ParamsC1Model _cameraParams;

        public ParamsC1Model ParamsC1
        {
            get { return _cameraParams; }
        }

        /// <summary>
        /// 基准位置（在Initial方法中实例化，通过手动触发赋值，在获取基准位置时调用）
        /// </summary>
        internal BasePose StandPose;
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            StandPose = new BasePose();
            _cameraParamsConfiguration.AnalysisCameraParamsConfig(ref _cameraParams);
        }
        /// <summary>
        /// 存单个参数(此处增加对应用层的调用接口，以简化调用方法的代码长度)
        /// Project.Instance.VisionManagerInstance.CameraParamsConfiguration.CameraParamsManagerInstance.SaveOneParams
        ///                                    ↓
        /// Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveAllParams()
        {
            _cameraParamsConfiguration.SaveCameraParamsConfig(_cameraParams);
        }
        /// <summary>
        /// 将曝光值写入到取图工具
        /// </summary>
        public void SaveExprosure(int index, double camExprosure)
        {
            try
            {
                if (index >= 0)
                {
                    ICogAcqFifo CamOperator = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[index].AcquireTool.Operator;
                    if (CamOperator != null && CamOperator.FrameGrabber != null) // 检查工具是否已连接硬件
                    {
                        if (CamOperator.CameraPort >= 0)
                        {
                            CamOperator.OwnedExposureParams.Exposure = camExprosure;
                            Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[index].SaveAccquireTools();
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
                    {
                        //曝光写到工具                    
                        ICogAcqFifo CamOperator = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[i].AcquireTool.Operator;
                        if (CamOperator != null && CamOperator.FrameGrabber != null)
                        {
                            if (CamOperator.CameraPort >= 0)
                            {
                                CamOperator.OwnedExposureParams.Exposure = camExprosure;
                                Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[i].SaveAccquireTools();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                LogHelper.Error("保存相机曝光值到工具出现异常", ex);
            }
        }
    }
}
