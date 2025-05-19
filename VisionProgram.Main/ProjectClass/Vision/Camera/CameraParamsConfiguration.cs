using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Cognex.VisionPro;
using VisionProgram.Common;
using VisionProgram.Models.VModels;
using VisionProgram.Main.ProjectClass;

namespace VisionProgram.ProjectClass.CameraParams
{

    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    public class CameraParams
    {
        #region 相机参数
        public List<double> L_camExprosure;//曝光
        //相机1基准X，Y，T
        public List<double> L_cam1StdX = new List<double>();
        public List<double> L_cam1StdY = new List<double>();
        public List<double> L_cam1StdT = new List<double>();
        //相机2基准X,Y,R
        public List<double> L_cam2StdX = new List<double>();
        public List<double> L_cam2StdY = new List<double>();
        public List<double> L_cam2StdT = new List<double>();
        //相机1补偿X，Y，T
        public List<double> L_cam1AddX = new List<double>();
        public List<double> L_cam1AddY = new List<double>();
        public List<double> L_cam1AddT = new List<double>();
        //相机2补偿X，Y，T                
        public List<double> L_cam2AddX = new List<double>();
        public List<double> L_cam2AddY = new List<double>();
        public List<double> L_cam2AddT = new List<double>();
        //相机1旋转中心
        public List<double> L_cam1Rotation_X = new List<double>();
        public List<double> L_cam1Rotation_Y = new List<double>();
        public List<double> L_cam1Rotation_RMS = new List<double>();
        //相机2旋转中心
        public List<double> L_cam2Rotation_X = new List<double>();
        public List<double> L_cam2Rotation_Y = new List<double>();
        public List<double> L_cam2Rotation_RMS = new List<double>();

        /// ///////////////////////////////////////////////////////////
        //相机3基准X，Y，T
        public List<double> L_cam3StdX = new List<double>();
        public List<double> L_cam3StdY = new List<double>();
        public List<double> L_cam3StdT = new List<double>();
        //相机4基准X，Y，T
        public List<double> L_cam4StdX = new List<double>();
        public List<double> L_cam4StdY = new List<double>();
        public List<double> L_cam4StdT = new List<double>();
        //相机3补偿X，Y，T
        public List<double> L_cam3AddX = new List<double>();
        public List<double> L_cam3AddY = new List<double>();
        public List<double> L_cam3AddT = new List<double>();
        //相机4补偿X，Y，T                
        public List<double> L_cam4AddX = new List<double>();
        public List<double> L_cam4AddY = new List<double>();
        public List<double> L_cam4AddT = new List<double>();
        //相机3旋转中心
        public List<double> L_cam3Rotation_X = new List<double>();
        public List<double> L_cam3Rotation_Y = new List<double>();
        public List<double> L_cam3Rotation_RMS = new List<double>();
        //相机4旋转中心
        public List<double> L_cam4Rotation_X = new List<double>();
        public List<double> L_cam4Rotation_Y = new List<double>();
        public List<double> L_cam4Rotation_RMS = new List<double>();




        //产品上二维码面积大小（识别正反用） 
        public List<double> L_ProductCodeAreaMin = new List<double>();
        public List<double> L_ProductCodeAreaMax = new List<double>();
        //盘中物料平均灰度下限（控制料盘下料）
        public List<double> L_ProductGrayValueMin = new List<double>();
        //单个产品面积大小（判断是否叠料用）
        public List<double> L_ProductAreaMin = new List<double>();
        public List<double> L_ProductAreaMax = new List<double>();
        //产品圆心距大小（判断是否变形）
        public List<double> L_ProductDistanceMin = new List<double>();
        public List<double> L_ProductDistanceMax = new List<double>();

        public List<double> L_Anglemin = new List<double>();
        public List<double> L_Anglemax = new List<double>();
        public List<double> L_Limitmin = new List<double>();
        public List<double> L_Limitmax = new List<double>();
        public List<double> L_OffsetX = new List<double>();

        //激光九点坐标设定
        public List<double> L1CalibX0 = new List<double>();
        public List<double> L1CalibY0 = new List<double>();
        public List<double> L1CalibX1 = new List<double>();
        public List<double> L1CalibY1 = new List<double>();
        public List<double> L1CalibX2 = new List<double>();
        public List<double> L1CalibY2 = new List<double>();
        public List<double> L1CalibX3 = new List<double>();
        public List<double> L1CalibY3 = new List<double>();
        public List<double> L1CalibX4 = new List<double>();
        public List<double> L1CalibY4 = new List<double>();
        public List<double> L1CalibX5 = new List<double>();
        public List<double> L1CalibY5 = new List<double>();
        public List<double> L1CalibX6 = new List<double>();
        public List<double> L1CalibY6 = new List<double>();
        public List<double> L1CalibX7 = new List<double>();
        public List<double> L1CalibY7 = new List<double>();
        public List<double> L1CalibX8 = new List<double>();
        public List<double> L1CalibY8 = new List<double>();
        public List<double> L1CalibX9 = new List<double>();
        public List<double> L1CalibY9 = new List<double>();

        public List<double> L2CalibX0 = new List<double>();
        public List<double> L2CalibY0 = new List<double>();
        public List<double> L2CalibX1 = new List<double>();
        public List<double> L2CalibY1 = new List<double>();
        public List<double> L2CalibX2 = new List<double>();
        public List<double> L2CalibY2 = new List<double>();
        public List<double> L2CalibX3 = new List<double>();
        public List<double> L2CalibY3 = new List<double>();
        public List<double> L2CalibX4 = new List<double>();
        public List<double> L2CalibY4 = new List<double>();
        public List<double> L2CalibX5 = new List<double>();
        public List<double> L2CalibY5 = new List<double>();
        public List<double> L2CalibX6 = new List<double>();
        public List<double> L2CalibY6 = new List<double>();
        public List<double> L2CalibX7 = new List<double>();
        public List<double> L2CalibY7 = new List<double>();
        public List<double> L2CalibX8 = new List<double>();
        public List<double> L2CalibY8 = new List<double>();
        public List<double> L2CalibX9 = new List<double>();
        public List<double> L2CalibY9 = new List<double>();


        public List<double> CellLineL = new List<double>();
        public List<double> P2byP1X = new List<double>();
        public List<double> P2byP1Y = new List<double>();
        public List<double> P4byP3X = new List<double>();
        public List<double> P4byP3Y = new List<double>();
        public List<double> LaserStep = new List<double>();
        public List<double> RobStep = new List<double>();

        public List<double> Spacing = new List<double>();
        public List<double> SpacingUse = new List<double>();
        public List<double> RobUse = new List<double>();
        public List<double> LaserUse = new List<double>();

        public List<double> ALX = new List<double>();
        public List<double> ALY = new List<double>();
        public List<double> NI1X = new List<double>();
        public List<double> NI1Y = new List<double>();
        public List<double> NI2X = new List<double>();
        public List<double> NI2Y = new List<double>();

        public List<double> ALX1 = new List<double>();
        public List<double> ALY1 = new List<double>();
        public List<double> NI1X1 = new List<double>();
        public List<double> NI1Y1 = new List<double>();
        public List<double> NI2X1 = new List<double>();
        public List<double> NI2Y1 = new List<double>();



        //夹具1补偿
        public List<double> AddR1J1X = new List<double>();
        public List<double> AddR1J1Y = new List<double>();
        public List<double> AddR2J1X = new List<double>();
        public List<double> AddR2J1Y = new List<double>();
        public List<double> AddL1J1X1 = new List<double>();
        public List<double> AddL1J1Y1 = new List<double>();
        public List<double> AddL1J1X2 = new List<double>();
        public List<double> AddL1J1Y2 = new List<double>();
        public List<double> AddL1J1X3 = new List<double>();
        public List<double> AddL1J1Y3 = new List<double>();
        public List<double> AddL1J1X4 = new List<double>();
        public List<double> AddL1J1Y4 = new List<double>();
        public List<double> AddL2J1X1 = new List<double>();
        public List<double> AddL2J1Y1 = new List<double>();
        public List<double> AddL2J1X2 = new List<double>();
        public List<double> AddL2J1Y2 = new List<double>();
        public List<double> AddL2J1X3 = new List<double>();
        public List<double> AddL2J1Y3 = new List<double>();
        public List<double> AddL2J1X4 = new List<double>();
        public List<double> AddL2J1Y4 = new List<double>();
        //夹具2补偿
        public List<double> AddR1J2X = new List<double>();
        public List<double> AddR1J2Y = new List<double>();
        public List<double> AddR2J2X = new List<double>();
        public List<double> AddR2J2Y = new List<double>();
        public List<double> AddL1J2X1 = new List<double>();
        public List<double> AddL1J2Y1 = new List<double>();
        public List<double> AddL1J2X2 = new List<double>();
        public List<double> AddL1J2Y2 = new List<double>();
        public List<double> AddL1J2X3 = new List<double>();
        public List<double> AddL1J2Y3 = new List<double>();
        public List<double> AddL1J2X4 = new List<double>();
        public List<double> AddL1J2Y4 = new List<double>();
        public List<double> AddL2J2X1 = new List<double>();
        public List<double> AddL2J2Y1 = new List<double>();
        public List<double> AddL2J2X2 = new List<double>();
        public List<double> AddL2J2Y2 = new List<double>();
        public List<double> AddL2J2X3 = new List<double>();
        public List<double> AddL2J2Y3 = new List<double>();
        public List<double> AddL2J2X4 = new List<double>();
        public List<double> AddL2J2Y4 = new List<double>();
        //夹具1补偿
        public List<double> AddR1J3X = new List<double>();
        public List<double> AddR1J3Y = new List<double>();
        public List<double> AddR2J3X = new List<double>();
        public List<double> AddR2J3Y = new List<double>();
        public List<double> AddL1J3X1 = new List<double>();
        public List<double> AddL1J3Y1 = new List<double>();
        public List<double> AddL1J3X2 = new List<double>();
        public List<double> AddL1J3Y2 = new List<double>();
        public List<double> AddL1J3X3 = new List<double>();
        public List<double> AddL1J3Y3 = new List<double>();
        public List<double> AddL1J3X4 = new List<double>();
        public List<double> AddL1J3Y4 = new List<double>();
        public List<double> AddL2J3X1 = new List<double>();
        public List<double> AddL2J3Y1 = new List<double>();
        public List<double> AddL2J3X2 = new List<double>();
        public List<double> AddL2J3Y2 = new List<double>();
        public List<double> AddL2J3X3 = new List<double>();
        public List<double> AddL2J3Y3 = new List<double>();
        public List<double> AddL2J3X4 = new List<double>();
        public List<double> AddL2J3Y4 = new List<double>();
        //夹具1补偿
        public List<double> AddR1J4X = new List<double>();
        public List<double> AddR1J4Y = new List<double>();
        public List<double> AddR2J4X = new List<double>();
        public List<double> AddR2J4Y = new List<double>();
        public List<double> AddL1J4X1 = new List<double>();
        public List<double> AddL1J4Y1 = new List<double>();
        public List<double> AddL1J4X2 = new List<double>();
        public List<double> AddL1J4Y2 = new List<double>();
        public List<double> AddL1J4X3 = new List<double>();
        public List<double> AddL1J4Y3 = new List<double>();
        public List<double> AddL1J4X4 = new List<double>();
        public List<double> AddL1J4Y4 = new List<double>();
        public List<double> AddL2J4X1 = new List<double>();
        public List<double> AddL2J4Y1 = new List<double>();
        public List<double> AddL2J4X2 = new List<double>();
        public List<double> AddL2J4Y2 = new List<double>();
        public List<double> AddL2J4X3 = new List<double>();
        public List<double> AddL2J4Y3 = new List<double>();
        public List<double> AddL2J4X4 = new List<double>();
        public List<double> AddL2J4Y4 = new List<double>();
        //夹具1补偿
        public List<double> AddR1J5X = new List<double>();
        public List<double> AddR1J5Y = new List<double>();
        public List<double> AddR2J5X = new List<double>();
        public List<double> AddR2J5Y = new List<double>();
        public List<double> AddL1J5X1 = new List<double>();
        public List<double> AddL1J5Y1 = new List<double>();
        public List<double> AddL1J5X2 = new List<double>();
        public List<double> AddL1J5Y2 = new List<double>();
        public List<double> AddL1J5X3 = new List<double>();
        public List<double> AddL1J5Y3 = new List<double>();
        public List<double> AddL1J5X4 = new List<double>();
        public List<double> AddL1J5Y4 = new List<double>();
        public List<double> AddL2J5X1 = new List<double>();
        public List<double> AddL2J5Y1 = new List<double>();
        public List<double> AddL2J5X2 = new List<double>();
        public List<double> AddL2J5Y2 = new List<double>();
        public List<double> AddL2J5X3 = new List<double>();
        public List<double> AddL2J5Y3 = new List<double>();
        public List<double> AddL2J5X4 = new List<double>();
        public List<double> AddL2J5Y4 = new List<double>();
        //夹具1补偿
        public List<double> AddR1J6X = new List<double>();
        public List<double> AddR1J6Y = new List<double>();
        public List<double> AddR2J6X = new List<double>();
        public List<double> AddR2J6Y = new List<double>();
        public List<double> AddL1J6X1 = new List<double>();
        public List<double> AddL1J6Y1 = new List<double>();
        public List<double> AddL1J6X2 = new List<double>();
        public List<double> AddL1J6Y2 = new List<double>();
        public List<double> AddL1J6X3 = new List<double>();
        public List<double> AddL1J6Y3 = new List<double>();
        public List<double> AddL1J6X4 = new List<double>();
        public List<double> AddL1J6Y4 = new List<double>();
        public List<double> AddL2J6X1 = new List<double>();
        public List<double> AddL2J6Y1 = new List<double>();
        public List<double> AddL2J6X2 = new List<double>();
        public List<double> AddL2J6Y2 = new List<double>();
        public List<double> AddL2J6X3 = new List<double>();
        public List<double> AddL2J6Y3 = new List<double>();
        public List<double> AddL2J6X4 = new List<double>();
        public List<double> AddL2J6Y4 = new List<double>();
        //夹具1补
        public List<double> AddR1J7X = new List<double>();
        public List<double> AddR1J7Y = new List<double>();
        public List<double> AddR2J7X = new List<double>();
        public List<double> AddR2J7Y = new List<double>();
        public List<double> AddL1J7X1 = new List<double>();
        public List<double> AddL1J7Y1 = new List<double>();
        public List<double> AddL1J7X2 = new List<double>();
        public List<double> AddL1J7Y2 = new List<double>();
        public List<double> AddL1J7X3 = new List<double>();
        public List<double> AddL1J7Y3 = new List<double>();
        public List<double> AddL1J7X4 = new List<double>();
        public List<double> AddL1J7Y4 = new List<double>();
        public List<double> AddL2J7X1 = new List<double>();
        public List<double> AddL2J7Y1 = new List<double>();
        public List<double> AddL2J7X2 = new List<double>();
        public List<double> AddL2J7Y2 = new List<double>();
        public List<double> AddL2J7X3 = new List<double>();
        public List<double> AddL2J7Y3 = new List<double>();
        public List<double> AddL2J7X4 = new List<double>();
        public List<double> AddL2J7Y4 = new List<double>();
        //夹具1补偿
        public List<double> AddR1J8X = new List<double>();
        public List<double> AddR1J8Y = new List<double>();
        public List<double> AddR2J8X = new List<double>();
        public List<double> AddR2J8Y = new List<double>();
        public List<double> AddL1J8X1 = new List<double>();
        public List<double> AddL1J8Y1 = new List<double>();
        public List<double> AddL1J8X2 = new List<double>();
        public List<double> AddL1J8Y2 = new List<double>();
        public List<double> AddL1J8X3 = new List<double>();
        public List<double> AddL1J8Y3 = new List<double>();
        public List<double> AddL1J8X4 = new List<double>();
        public List<double> AddL1J8Y4 = new List<double>();
        public List<double> AddL2J8X1 = new List<double>();
        public List<double> AddL2J8Y1 = new List<double>();
        public List<double> AddL2J8X2 = new List<double>();
        public List<double> AddL2J8Y2 = new List<double>();
        public List<double> AddL2J8X3 = new List<double>();
        public List<double> AddL2J8Y3 = new List<double>();
        public List<double> AddL2J8X4 = new List<double>();
        public List<double> AddL2J8Y4 = new List<double>();

        //夹具1补偿
        public List<double> AddR1J9X = new List<double>();
        public List<double> AddR1J9Y = new List<double>();
        public List<double> AddR2J9X = new List<double>();
        public List<double> AddR2J9Y = new List<double>();
        public List<double> AddL1J9X1 = new List<double>();
        public List<double> AddL1J9Y1 = new List<double>();
        public List<double> AddL1J9X2 = new List<double>();
        public List<double> AddL1J9Y2 = new List<double>();
        public List<double> AddL1J9X3 = new List<double>();
        public List<double> AddL1J9Y3 = new List<double>();
        public List<double> AddL1J9X4 = new List<double>();
        public List<double> AddL1J9Y4 = new List<double>();
        public List<double> AddL2J9X1 = new List<double>();
        public List<double> AddL2J9Y1 = new List<double>();
        public List<double> AddL2J9X2 = new List<double>();
        public List<double> AddL2J9Y2 = new List<double>();
        public List<double> AddL2J9X3 = new List<double>();
        public List<double> AddL2J9Y3 = new List<double>();
        public List<double> AddL2J9X4 = new List<double>();
        public List<double> AddL2J9Y4 = new List<double>();

        public List<double> weldlength = new List<double>();







        #endregion
    }

    public class CameraParamsConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config" + "\\CameraParams.ini");


        /// <summary>
        /// 解析Comm,初始化数组
        /// </summary>
        public void AnalysisCameraParamsCommConfig(ref CameraParams cameraParams)
        {
            try
            {
                InitConfigDirctory();
                InitCameraParams(cameraParams);
                for (int i = 0; i < Project.Instance().VisionManagerInstance.CameraNum; i++)
                {
                    string varName = "camera" + (i + 1).ToString();
                    cameraParams.L_camExprosure.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Exprosure", "0")));
                    //每个相机6个基准，6个旋转中心

                    cameraParams.L_ProductCodeAreaMin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductCodeAreaMin", "0")));
                    cameraParams.L_ProductCodeAreaMax.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductCodeAreaMax", "0")));
                    cameraParams.L_ProductGrayValueMin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductGrayValueMin", "0")));
                    cameraParams.L_ProductAreaMin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductAreaMin", "0")));
                    cameraParams.L_ProductAreaMax.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductAreaMax", "0")));
                    cameraParams.L_ProductDistanceMin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductDistanceMin", "0")));
                    cameraParams.L_ProductDistanceMax.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ProductDistanceMax", "0")));
                    cameraParams.L_Anglemin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Anglemin", "0")));
                    cameraParams.L_Anglemax.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Anglemax", "0")));
                    cameraParams.L_Limitmin.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Limitmin", "0")));
                    cameraParams.L_Limitmax.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Limitmax", "0")));
                    cameraParams.L_OffsetX.Add(Convert.ToDouble(_ini.IniReadValue(varName, "OffsetX", "0")));

                    cameraParams.L1CalibX0.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX0", "0")));
                    cameraParams.L1CalibY0.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY0", "0")));
                    cameraParams.L1CalibX1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX1", "0")));
                    cameraParams.L1CalibY1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY1", "0")));
                    cameraParams.L1CalibX2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX2", "0")));
                    cameraParams.L1CalibY2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY2", "0")));
                    cameraParams.L1CalibX3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX3", "0")));
                    cameraParams.L1CalibY3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY3", "0")));
                    cameraParams.L1CalibX4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX4", "0")));
                    cameraParams.L1CalibY4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY4", "0")));
                    cameraParams.L1CalibX5.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX5", "0")));
                    cameraParams.L1CalibY5.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY5", "0")));
                    cameraParams.L1CalibX6.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX6", "0")));
                    cameraParams.L1CalibY6.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY6", "0")));
                    cameraParams.L1CalibX7.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX7", "0")));
                    cameraParams.L1CalibY7.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY7", "0")));
                    cameraParams.L1CalibX8.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX8", "0")));
                    cameraParams.L1CalibY8.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY8", "0")));
                    cameraParams.L1CalibX9.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibX9", "0")));
                    cameraParams.L1CalibY9.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L1CalibY9", "0")));

                    cameraParams.L2CalibX0.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX0", "0")));
                    cameraParams.L2CalibY0.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY0", "0")));
                    cameraParams.L2CalibX1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX1", "0")));
                    cameraParams.L2CalibY1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY1", "0")));
                    cameraParams.L2CalibX2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX2", "0")));
                    cameraParams.L2CalibY2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY2", "0")));
                    cameraParams.L2CalibX3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX3", "0")));
                    cameraParams.L2CalibY3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY3", "0")));
                    cameraParams.L2CalibX4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX4", "0")));
                    cameraParams.L2CalibY4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY4", "0")));
                    cameraParams.L2CalibX5.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX5", "0")));
                    cameraParams.L2CalibY5.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY5", "0")));
                    cameraParams.L2CalibX6.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX6", "0")));
                    cameraParams.L2CalibY6.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY6", "0")));
                    cameraParams.L2CalibX7.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX7", "0")));
                    cameraParams.L2CalibY7.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY7", "0")));
                    cameraParams.L2CalibX8.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX8", "0")));
                    cameraParams.L2CalibY8.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY8", "0")));
                    cameraParams.L2CalibX9.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibX9", "0")));
                    cameraParams.L2CalibY9.Add(Convert.ToDouble(_ini.IniReadValue(varName, "L2CalibY9", "0")));

                    cameraParams.CellLineL.Add(Convert.ToDouble(_ini.IniReadValue(varName, "CellLineL", "0")));
                    cameraParams.P2byP1X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "P2byP1X", "0")));
                    cameraParams.P2byP1Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "P2byP1Y", "0")));
                    cameraParams.P4byP3X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "P4byP3X", "0")));
                    cameraParams.P4byP3Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "P4byP3Y", "0")));
                    cameraParams.LaserStep.Add(Convert.ToDouble(_ini.IniReadValue(varName, "LaserStep", "0")));
                    cameraParams.RobStep.Add(Convert.ToDouble(_ini.IniReadValue(varName, "RobStep", "0")));
                    cameraParams.Spacing.Add(Convert.ToDouble(_ini.IniReadValue(varName, "Spacing", "0")));
                    cameraParams.SpacingUse.Add(Convert.ToDouble(_ini.IniReadValue(varName, "SpacingUse", "0")));
                    cameraParams.RobUse.Add(Convert.ToDouble(_ini.IniReadValue(varName, "RobUse", "0")));
                    cameraParams.LaserUse.Add(Convert.ToDouble(_ini.IniReadValue(varName, "LaserUse", "0")));

                    cameraParams.ALX.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ALX", "0")));
                    cameraParams.ALY.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ALY", "0")));
                    cameraParams.NI1X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI1X", "0")));
                    cameraParams.NI1Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI1Y", "0")));
                    cameraParams.NI2X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI2X", "0")));
                    cameraParams.NI2Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI2Y", "0")));
                    cameraParams.ALX1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ALX1", "0")));
                    cameraParams.ALY1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "ALY1", "0")));
                    cameraParams.NI1X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI1X1", "0")));
                    cameraParams.NI1Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI1Y1", "0")));
                    cameraParams.NI2X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI2X1", "0")));
                    cameraParams.NI2Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "NI2Y1", "0")));


                    cameraParams.AddR1J1X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J1X", "0")));
                    cameraParams.AddR1J1Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J1Y", "0")));
                    cameraParams.AddR2J1X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J1X", "0")));
                    cameraParams.AddR2J1Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J1Y", "0")));
                    cameraParams.AddL1J1X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1X1", "0")));
                    cameraParams.AddL1J1Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1Y1", "0")));
                    cameraParams.AddL1J1X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1X2", "0")));
                    cameraParams.AddL1J1Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1Y2", "0")));
                    cameraParams.AddL1J1X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1X3", "0")));
                    cameraParams.AddL1J1Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1Y3", "0")));
                    cameraParams.AddL1J1X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1X4", "0")));
                    cameraParams.AddL1J1Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J1Y4", "0")));
                    cameraParams.AddL2J1X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1X1", "0")));
                    cameraParams.AddL2J1Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1Y1", "0")));
                    cameraParams.AddL2J1X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1X2", "0")));
                    cameraParams.AddL2J1Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1Y2", "0")));
                    cameraParams.AddL2J1X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1X3", "0")));
                    cameraParams.AddL2J1Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1Y3", "0")));
                    cameraParams.AddL2J1X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1X4", "0")));
                    cameraParams.AddL2J1Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J1Y4", "0")));

                    cameraParams.AddR1J2X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J2X", "0")));
                    cameraParams.AddR1J2Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J2Y", "0")));
                    cameraParams.AddR2J2X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J2X", "0")));
                    cameraParams.AddR2J2Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J2Y", "0")));
                    cameraParams.AddL1J2X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2X1", "0")));
                    cameraParams.AddL1J2Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2Y1", "0")));
                    cameraParams.AddL1J2X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2X2", "0")));
                    cameraParams.AddL1J2Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2Y2", "0")));
                    cameraParams.AddL1J2X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2X3", "0")));
                    cameraParams.AddL1J2Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2Y3", "0")));
                    cameraParams.AddL1J2X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2X4", "0")));
                    cameraParams.AddL1J2Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J2Y4", "0")));
                    cameraParams.AddL2J2X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2X1", "0")));
                    cameraParams.AddL2J2Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2Y1", "0")));
                    cameraParams.AddL2J2X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2X2", "0")));
                    cameraParams.AddL2J2Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2Y2", "0")));
                    cameraParams.AddL2J2X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2X3", "0")));
                    cameraParams.AddL2J2Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2Y3", "0")));
                    cameraParams.AddL2J2X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2X4", "0")));
                    cameraParams.AddL2J2Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J2Y4", "0")));

                    cameraParams.AddR1J3X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J3X", "0")));
                    cameraParams.AddR1J3Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J3Y", "0")));
                    cameraParams.AddR2J3X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J3X", "0")));
                    cameraParams.AddR2J3Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J3Y", "0")));
                    cameraParams.AddL1J3X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3X1", "0")));
                    cameraParams.AddL1J3Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3Y1", "0")));
                    cameraParams.AddL1J3X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3X2", "0")));
                    cameraParams.AddL1J3Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3Y2", "0")));
                    cameraParams.AddL1J3X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3X3", "0")));
                    cameraParams.AddL1J3Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3Y3", "0")));
                    cameraParams.AddL1J3X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3X4", "0")));
                    cameraParams.AddL1J3Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J3Y4", "0")));
                    cameraParams.AddL2J3X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3X1", "0")));
                    cameraParams.AddL2J3Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3Y1", "0")));
                    cameraParams.AddL2J3X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3X2", "0")));
                    cameraParams.AddL2J3Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3Y2", "0")));
                    cameraParams.AddL2J3X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3X3", "0")));
                    cameraParams.AddL2J3Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3Y3", "0")));
                    cameraParams.AddL2J3X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3X4", "0")));
                    cameraParams.AddL2J3Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J3Y4", "0")));

                    cameraParams.AddR1J4X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J4X", "0")));
                    cameraParams.AddR1J4Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J4Y", "0")));
                    cameraParams.AddR2J4X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J4X", "0")));
                    cameraParams.AddR2J4Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J4Y", "0")));
                    cameraParams.AddL1J4X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4X1", "0")));
                    cameraParams.AddL1J4Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4Y1", "0")));
                    cameraParams.AddL1J4X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4X2", "0")));
                    cameraParams.AddL1J4Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4Y2", "0")));
                    cameraParams.AddL1J4X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4X3", "0")));
                    cameraParams.AddL1J4Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4Y3", "0")));
                    cameraParams.AddL1J4X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4X4", "0")));
                    cameraParams.AddL1J4Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J4Y4", "0")));
                    cameraParams.AddL2J4X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4X1", "0")));
                    cameraParams.AddL2J4Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4Y1", "0")));
                    cameraParams.AddL2J4X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4X2", "0")));
                    cameraParams.AddL2J4Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4Y2", "0")));
                    cameraParams.AddL2J4X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4X3", "0")));
                    cameraParams.AddL2J4Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4Y3", "0")));
                    cameraParams.AddL2J4X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4X4", "0")));
                    cameraParams.AddL2J4Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J4Y4", "0")));

                    cameraParams.AddR1J5X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J5X", "0")));
                    cameraParams.AddR1J5Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J5Y", "0")));
                    cameraParams.AddR2J5X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J5X", "0")));
                    cameraParams.AddR2J5Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J5Y", "0")));
                    cameraParams.AddL1J5X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5X1", "0")));
                    cameraParams.AddL1J5Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5Y1", "0")));
                    cameraParams.AddL1J5X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5X2", "0")));
                    cameraParams.AddL1J5Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5Y2", "0")));
                    cameraParams.AddL1J5X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5X3", "0")));
                    cameraParams.AddL1J5Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5Y3", "0")));
                    cameraParams.AddL1J5X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5X4", "0")));
                    cameraParams.AddL1J5Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J5Y4", "0")));
                    cameraParams.AddL2J5X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5X1", "0")));
                    cameraParams.AddL2J5Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5Y1", "0")));
                    cameraParams.AddL2J5X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5X2", "0")));
                    cameraParams.AddL2J5Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5Y2", "0")));
                    cameraParams.AddL2J5X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5X3", "0")));
                    cameraParams.AddL2J5Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5Y3", "0")));
                    cameraParams.AddL2J5X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5X4", "0")));
                    cameraParams.AddL2J5Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J5Y4", "0")));

                    cameraParams.AddR1J6X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J6X", "0")));
                    cameraParams.AddR1J6Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J6Y", "0")));
                    cameraParams.AddR2J6X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J6X", "0")));
                    cameraParams.AddR2J6Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J6Y", "0")));
                    cameraParams.AddL1J6X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6X1", "0")));
                    cameraParams.AddL1J6Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6Y1", "0")));
                    cameraParams.AddL1J6X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6X2", "0")));
                    cameraParams.AddL1J6Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6Y2", "0")));
                    cameraParams.AddL1J6X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6X3", "0")));
                    cameraParams.AddL1J6Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6Y3", "0")));
                    cameraParams.AddL1J6X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6X4", "0")));
                    cameraParams.AddL1J6Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J6Y4", "0")));
                    cameraParams.AddL2J6X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6X1", "0")));
                    cameraParams.AddL2J6Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6Y1", "0")));
                    cameraParams.AddL2J6X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6X2", "0")));
                    cameraParams.AddL2J6Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6Y2", "0")));
                    cameraParams.AddL2J6X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6X3", "0")));
                    cameraParams.AddL2J6Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6Y3", "0")));
                    cameraParams.AddL2J6X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6X4", "0")));
                    cameraParams.AddL2J6Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J6Y4", "0")));

                    cameraParams.AddR1J7X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J7X", "0")));
                    cameraParams.AddR1J7Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J7Y", "0")));
                    cameraParams.AddR2J7X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J7X", "0")));
                    cameraParams.AddR2J7Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J7Y", "0")));
                    cameraParams.AddL1J7X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7X1", "0")));
                    cameraParams.AddL1J7Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7Y1", "0")));
                    cameraParams.AddL1J7X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7X2", "0")));
                    cameraParams.AddL1J7Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7Y2", "0")));
                    cameraParams.AddL1J7X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7X3", "0")));
                    cameraParams.AddL1J7Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7Y3", "0")));
                    cameraParams.AddL1J7X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7X4", "0")));
                    cameraParams.AddL1J7Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J7Y4", "0")));
                    cameraParams.AddL2J7X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7X1", "0")));
                    cameraParams.AddL2J7Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7Y1", "0")));
                    cameraParams.AddL2J7X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7X2", "0")));
                    cameraParams.AddL2J7Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7Y2", "0")));
                    cameraParams.AddL2J7X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7X3", "0")));
                    cameraParams.AddL2J7Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7Y3", "0")));
                    cameraParams.AddL2J7X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7X4", "0")));
                    cameraParams.AddL2J7Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J7Y4", "0")));

                    cameraParams.AddR1J8X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J8X", "0")));
                    cameraParams.AddR1J8Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J8Y", "0")));
                    cameraParams.AddR2J8X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J8X", "0")));
                    cameraParams.AddR2J8Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J8Y", "0")));
                    cameraParams.AddL1J8X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8X1", "0")));
                    cameraParams.AddL1J8Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8Y1", "0")));
                    cameraParams.AddL1J8X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8X2", "0")));
                    cameraParams.AddL1J8Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8Y2", "0")));
                    cameraParams.AddL1J8X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8X3", "0")));
                    cameraParams.AddL1J8Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8Y3", "0")));
                    cameraParams.AddL1J8X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8X4", "0")));
                    cameraParams.AddL1J8Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J8Y4", "0")));
                    cameraParams.AddL2J8X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8X1", "0")));
                    cameraParams.AddL2J8Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8Y1", "0")));
                    cameraParams.AddL2J8X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8X2", "0")));
                    cameraParams.AddL2J8Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8Y2", "0")));
                    cameraParams.AddL2J8X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8X3", "0")));
                    cameraParams.AddL2J8Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8Y3", "0")));
                    cameraParams.AddL2J8X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8X4", "0")));
                    cameraParams.AddL2J8Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J8Y4", "0")));

                    cameraParams.AddR1J9X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J9X", "0")));
                    cameraParams.AddR1J9Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR1J9Y", "0")));
                    cameraParams.AddR2J9X.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J9X", "0")));
                    cameraParams.AddR2J9Y.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddR2J9Y", "0")));
                    cameraParams.AddL1J9X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9X1", "0")));
                    cameraParams.AddL1J9Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9Y1", "0")));
                    cameraParams.AddL1J9X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9X2", "0")));
                    cameraParams.AddL1J9Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9Y2", "0")));
                    cameraParams.AddL1J9X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9X3", "0")));
                    cameraParams.AddL1J9Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9Y3", "0")));
                    cameraParams.AddL1J9X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9X4", "0")));
                    cameraParams.AddL1J9Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL1J9Y4", "0")));
                    cameraParams.AddL2J9X1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9X1", "0")));
                    cameraParams.AddL2J9Y1.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9Y1", "0")));
                    cameraParams.AddL2J9X2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9X2", "0")));
                    cameraParams.AddL2J9Y2.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9Y2", "0")));
                    cameraParams.AddL2J9X3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9X3", "0")));
                    cameraParams.AddL2J9Y3.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9Y3", "0")));
                    cameraParams.AddL2J9X4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9X4", "0")));
                    cameraParams.AddL2J9Y4.Add(Convert.ToDouble(_ini.IniReadValue(varName, "AddL2J9Y4", "0")));
                    cameraParams.weldlength.Add(0.0);
                }
                for (int j = 0; j < Project.Instance().GlobalManagerInstance.GlobalParamModel.NozzleNum; j++)
                {
                    //Camera1基准
                    cameraParams.L_cam1StdX.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "StdX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1StdY.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "StdY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1StdT.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "StdT" + (j + 1).ToString(), "0")));
                    //补偿
                    cameraParams.L_cam1AddX.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "AddX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1AddY.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "AddY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1AddT.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "AddT" + (j + 1).ToString(), "0")));
                    //旋转中心
                    cameraParams.L_cam1Rotation_X.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_X" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1Rotation_Y.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_Y" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam1Rotation_RMS.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_RMS" + (j + 1).ToString(), "0")));

                    cameraParams.L_cam1Rotation_X.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_X" + (j + 2).ToString(), "0")));
                    cameraParams.L_cam1Rotation_Y.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_Y" + (j + 2).ToString(), "0")));
                    cameraParams.L_cam1Rotation_RMS.Add(Convert.ToDouble(_ini.IniReadValue("camera1", "RC_RMS" + (j + 2).ToString(), "0")));

                    //Camera2基准
                    cameraParams.L_cam2StdX.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "StdX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2StdY.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "StdY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2StdT.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "StdT" + (j + 1).ToString(), "0")));
                    //补偿
                    cameraParams.L_cam2AddX.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "AddX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2AddY.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "AddY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2AddT.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "AddT" + (j + 1).ToString(), "0")));
                    //旋转中心
                    cameraParams.L_cam2Rotation_X.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "RC_X" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2Rotation_Y.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "RC_Y" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam2Rotation_RMS.Add(Convert.ToDouble(_ini.IniReadValue("camera2", "RC_RMS" + (j + 1).ToString(), "0")));

                    //Camera3基准
                    cameraParams.L_cam3StdX.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "StdX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3StdY.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "StdY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3StdT.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "StdT" + (j + 1).ToString(), "0")));
                    //补偿
                    cameraParams.L_cam3AddX.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "AddX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3AddY.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "AddY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3AddT.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "AddT" + (j + 1).ToString(), "0")));
                    //旋转中心
                    cameraParams.L_cam3Rotation_X.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "RC_X" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3Rotation_Y.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "RC_Y" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam3Rotation_RMS.Add(Convert.ToDouble(_ini.IniReadValue("camera3", "RC_RMS" + (j + 1).ToString(), "0")));

                    //Camera4基准
                    cameraParams.L_cam4StdX.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "StdX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4StdY.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "StdY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4StdT.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "StdT" + (j + 1).ToString(), "0")));
                    //补偿
                    cameraParams.L_cam4AddX.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "AddX" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4AddY.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "AddY" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4AddT.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "AddT" + (j + 1).ToString(), "0")));
                    //旋转中心
                    cameraParams.L_cam4Rotation_X.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "RC_X" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4Rotation_Y.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "RC_Y" + (j + 1).ToString(), "0")));
                    cameraParams.L_cam4Rotation_RMS.Add(Convert.ToDouble(_ini.IniReadValue("camera4", "RC_RMS" + (j + 1).ToString(), "0")));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析相机参数配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析相机参数配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }


        private void InitCameraParams(CameraParams cameraParams)
        {
            cameraParams.L_camExprosure.Clear();
            cameraParams.L_cam1StdX.Clear();
            cameraParams.L_cam1StdY.Clear();
            cameraParams.L_cam1StdT.Clear();

            cameraParams.L_cam1AddX.Clear();
            cameraParams.L_cam1AddY.Clear();
            cameraParams.L_cam1AddT.Clear();

            cameraParams.L_cam1Rotation_X.Clear();
            cameraParams.L_cam1Rotation_Y.Clear();
            cameraParams.L_cam1Rotation_RMS.Clear();

            cameraParams.L_cam2StdX.Clear();
            cameraParams.L_cam2StdY.Clear();
            cameraParams.L_cam2StdT.Clear();

            cameraParams.L_cam2AddX.Clear();
            cameraParams.L_cam2AddY.Clear();
            cameraParams.L_cam2AddT.Clear();

            cameraParams.L_cam2Rotation_X.Clear();
            cameraParams.L_cam2Rotation_Y.Clear();
            cameraParams.L_cam2Rotation_RMS.Clear();

            cameraParams.L_ProductCodeAreaMin.Clear();
            cameraParams.L_ProductCodeAreaMax.Clear();
            cameraParams.L_ProductGrayValueMin.Clear();
            cameraParams.L_ProductAreaMin.Clear();
            cameraParams.L_ProductAreaMax.Clear();
            cameraParams.L_ProductDistanceMin.Clear();
            cameraParams.L_ProductDistanceMax.Clear();
        }
        /// <summary>
        /// 保存所有配置项
        /// </summary>
        //public void Save()
        //{
        //    try
        //    {
        //        for (int i = 0; i < Project.Instance.configuration.WorkFlowNum; i++)
        //        {
        //            string varName = "CCD" + (i + 1).ToString();
        //            ini.WriteIniKey(varName, "CamExprosure", L_camExprosure[i].ToString());
        //            //曝光写到工具                    
        //            ICogAcqFifo CamOperator = Project.Instance.L_workFlowList[i].AcquireTool.Operator;
        //            if (CamOperator != null && CamOperator.FrameGrabber != null)
        //            {
        //                if (CamOperator.CameraPort >= 0)
        //                {
        //                    CamOperator.OwnedExposureParams.Exposure = L_camExprosure[i];
        //                    Project.Instance.L_workFlowList[i].SaveAccquireTools();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Notice.OutputMessageSend($"保存相机曝光参数异常：{ex.Message}", OutputLevelModel.ERROR,true);
        //        LogHelper.Error("保存相机曝光参数异常", ex);
        //    }
        //}
        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                //配置文件夹
                if (!Directory.Exists(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config"))
                    Directory.CreateDirectory(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config");
                //主配置文件ini
                if (!File.Exists(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config" + @"\\CameraParams.ini"))
                    File.Create(Project.Instance().VisionManagerInstance._visionParamPath + @"\\Config" + @"\\CameraParams.ini").Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查相机参数配置文件路径出现异常", ex);
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
}
