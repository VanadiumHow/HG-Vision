using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisionProgram.Main.ProjectClass.Robot
{
    /****************************************************************

*****************************************************************/
    public static class RobotSignals
    {
        //自动运行信号1
        public static string CCD1RobotTrigger1 = "T1"; //Laser触发相机信号1
        public static string CCD1RobotTrigger2 = "T2"; //Laser触发相机信号2
        public static string CCD1Receive = ""; //接收到的触发信号

        public static string CCD2RobotTrigger = "Trigger2\0"; //Robot触发相机

        public static string CCDRobotPRespond = "PCSEND;P;TriggerOK";
        public static string CCDRobotNRespond = "PCSEND;N;TriggerOK";

        public static string CCDRobotOffset = "1;2;3;"; //x,y,r偏移量    //ReceiveOK

        public static string CCD1RobotResultNG = "PCSEND;N;NG1"; //ccd1结果信号
        public static string CCD1RobotResultOK = "PCSEND;N;OK1"; //ccd1结果信号

        public static string CCD2RobotResultNG = "PCSEND;N;NG2"; //ccd2结果信号
        public static string CCD2RobotResultOK = "PCSEND;N;OK2"; //ccd2结果信号

        public static string CCD3RobotResultNG = "PCSEND;P;NG1"; //ccd3结果信号
        public static string CCD3RobotResultOK = "PCSEND;P;OK1"; //ccd3结果信号

        public static string CCD4RobotResultNG = "PCSEND;P;NG2"; //ccd4结果信号
        public static string CCD4RobotResultOK = "PCSEND;P;OK2"; //ccd4结果信号


        //区分自动运行和自动标定标志位
        public static int CCDProcess = 0; //0-自动运行 1-标定

        #region 标定信号   
        public static string CCDRobotCal = "0"; //0-九点标定，1-旋转中心标定
        //线性标定信号
        public static string CCDRobotCalLocation = "CalLocation"; //触发反馈当前机器人的坐标

        public static string CCDRobotCalStart = "CalStart"; //Robot开始一键标定

        public static string CCDCONFIRM = "ROBOTSEND;CONFIRM\0"; //Robot开始一键标定

        public static string CCDRobotCalTrigger = "CalTrigger"; //相机触发字符
        public static string CCDRobotCalFinishOK = "PCSEND;CalFinishOK"; //相机完成字符OK
        public static string CCDRobotCalFinishNG = "PCSEND;CalFinishNG"; //相机完成字符NG
        public static string CCDRobotCalFinish = "CalFinish"; //机器人运行结束，计算

        //旋转中心标定信号
        public static string CCDRobotRCalStart = "RCalStart"; //Robot开始一键标定
        public static string CCDRobotRCalTrigger = "RCalTrigger\0"; //相机触发字符
        public static string CCDRobotRCalFinishOK = "PCSEND;RCalFinishOK"; //相机完成字符OK
        public static string CCDRobotRCalFinishNG = "PCSEND;RCalFinishNG"; //相机完成字符NG
        public static string CCDRobotRCalFinish = "RCalFinish\0"; //机器人运行结束，计算

        //负极机器人发送内容
        public static string RobotNGetResult1 = "ROBOTSEND,N,ReceiveResult1\0";
        public static string RobotNGetResult2 = "ROBOTSEND,N,ReceiveResult2\0";

        //正极机器人发送内容
        public static string RobotPGetResult1 = "ROBOTSEND,P,ReceiveResult1\0";
        public static string RobotPGetResult2 = "ROBOTSEND,P,ReceiveResult2\0";

        //激光的发送内容
        public static string Laser1NinePointStr =
          "_OK;" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX1[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY1[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX2[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY2[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX3[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY3[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX4[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY4[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX5[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY5[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX6[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY6[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX7[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY7[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX8[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY8[0].ToString() + "#"
                + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX9[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY9[0].ToString() + "#"
            ;

        public static string Laser2NinePointStr =
         "_OK;" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX1[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY1[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX2[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY2[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX3[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY3[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX4[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY4[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX5[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY5[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX6[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY6[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX7[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY7[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX8[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY8[0].ToString() + "#"
               + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX9[0].ToString() + "%" + Project.Instance().VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY9[0].ToString() + "#"
           ;

        #endregion

    }
}
