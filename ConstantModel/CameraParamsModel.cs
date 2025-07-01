using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ConstantModel
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    public class CameraParamsModel
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
}
