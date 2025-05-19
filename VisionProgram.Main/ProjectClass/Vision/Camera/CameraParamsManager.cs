using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cognex.VisionPro;
using VisionProgram.Models.VModels;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;

namespace VisionProgram.ProjectClass.CameraParams
{
    public class CameraParamsManager
    {
        private CameraParamsConfiguration _cameraParamsConfiguration = new CameraParamsConfiguration();

        public CameraParamsConfiguration CameraParamsConfiguration
        {
            get { return _cameraParamsConfiguration; }
        }

        private CameraParams _cameraParams;

        public CameraParams CameraParams
        {
            get { return _cameraParams; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            InitCameraParams();
            Analysis();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Analysis()
        {
            CameraParamsConfiguration.AnalysisCameraParamsCommConfig(ref _cameraParams);
        }

        private void InitCameraParams()
        {
            _cameraParams = new CameraParams();
            _cameraParams.L_camExprosure = new List<double>();
            _cameraParams.L_cam1StdX = new List<double>();
            _cameraParams.L_cam1StdY = new List<double>();
            _cameraParams.L_cam1StdT = new List<double>();

            _cameraParams.L_cam2StdX = new List<double>();
            _cameraParams.L_cam2StdY = new List<double>();
            _cameraParams.L_cam2StdT = new List<double>();

            _cameraParams.L_cam1Rotation_X = new List<double>();
            _cameraParams.L_cam1Rotation_X = new List<double>();
            _cameraParams.L_cam1Rotation_RMS = new List<double>();

            _cameraParams.L_cam2Rotation_X = new List<double>();
            _cameraParams.L_cam2Rotation_X = new List<double>();
            _cameraParams.L_cam2Rotation_RMS = new List<double>();

            _cameraParams.L_ProductCodeAreaMin = new List<double>();
            _cameraParams.L_ProductCodeAreaMax = new List<double>();
            _cameraParams.L_ProductGrayValueMin = new List<double>();
            _cameraParams.L_ProductAreaMin = new List<double>();
            _cameraParams.L_ProductAreaMax = new List<double>();
            _cameraParams.L_ProductDistanceMin = new List<double>();
            _cameraParams.L_ProductDistanceMax = new List<double>();
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
            _cameraParamsConfiguration.SaveOneParams(section, node, value);
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
                    ICogAcqFifo CamOperator = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[index].AcquireTool.Operator;
                    if (CamOperator != null && CamOperator.FrameGrabber != null)
                    {
                        if (CamOperator.CameraPort >= 0)
                        {
                            CamOperator.OwnedExposureParams.Exposure = camExprosure;
                            Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[index].SaveAccquireTools();
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < Project.Instance().VisionManagerInstance.CameraNum; i++)
                    {
                        //曝光写到工具                    
                        ICogAcqFifo CamOperator = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[i].AcquireTool.Operator;
                        if (CamOperator != null && CamOperator.FrameGrabber != null)
                        {
                            if (CamOperator.CameraPort >= 0)
                            {
                                CamOperator.OwnedExposureParams.Exposure = camExprosure;
                                Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[i].SaveAccquireTools();
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
