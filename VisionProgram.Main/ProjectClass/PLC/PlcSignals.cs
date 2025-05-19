using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
*
*****************************************************************/
namespace VisionProgram.Main.ProjectClass.PLC
{
    /// <summary>
    /// 全部PLC信号类
    /// 欧姆龙传标签即可。倍福需传ID，则也可以在该信号类中定义倍福专用信号寄存器地址的ID集合，可使用WriteToPLC方法等直接传给倍福PLC方法，或调用Write等方法让底层用标签去换ID
    /// </summary>
    public static class PlcSignals
    {
        /// <summary>
        /// <summary>
        /// 每个PLC的信号都封装成对应的静态类
        /// </summary>
        #region 欧姆龙PLC1
        public static class PLC1
        {
            //握手信号
            public static string PulseToPLC = "G_stPC_PLC.ax1sClkFromPC[0]";//--
            //握手信号
            public static string PulseToPC = "G_stPC_PLC.ax1sClkToPC[0]";//--

            //CCD掉线信号
            public static string DisconnectCCD = "G_stPC_PLC.axCCDOfflineFromPC";//[0]--[8]

            #region CCD
            //CCD触发信号
            public static string CCDTrigger = "G_stPC_PLC.aiTrigToPC";//[0]--[8]

            //CCD 读取PLC的ScanCode
            public static string PLCCode = "G_stPC_PLC[.asQRCodeToPC";//0--8

            //CCD结果信号
            public static string CCDResult = "G_stPC_PLC.aiResultFromPC";//[0]--[8]

            //CCD完成信号
            public static string CCDComplete = "G_stPC_PLC.aiCompleteFromPC";//[0]--[8]
            #endregion       
        }

        #endregion   

        #region 倍福PLC2
        public static class PLC2
        {
            public static string CCDPLCHandshakeOut = ".gwHMICCDOneSecondPulse1"; //bool PLC给的握手信号
            public static string CCDPLCHandshakeIn = ".gwHMICCDOneSecondPulse11";   //bool 给PLC的握手信号
        }

        #endregion
        #region 倍福PLC4
        public static class PLC4
        {
            public static string CCDPLCHandshakeOut = ".gwHMICCDOneSecondPulse1"; //bool PLC给的握手信号
            public static string CCDPLCHandshakeIn = ".G_CCDHandShake";   //int 给PLC的握手信号
            #region 对位信号
            //相机自动标定模式

            public static string DeviceHandshakeSignal = ".G_CCDHandShake";//PC&PLC握手信号

            //CCD1偏差值 6个吸嘴       
            public static string[] OffsetX_CCD1 = { ".G_XPositionCoordinates[1]", ".G_XPositionCoordinates[2]", ".G_XPositionCoordinates[3]", ".G_XPositionCoordinates[4]", ".G_XPositionCoordinates[5]", ".G_XPositionCoordinates[6]" };
            public static string[] OffsetY_CCD1 = { ".G_YPositionCoordinates[1]", ".G_YPositionCoordinates[2]", ".G_YPositionCoordinates[3]", ".G_YPositionCoordinates[4]", ".G_YPositionCoordinates[5]", ".G_YPositionCoordinates[6]" };
            public static string[] OffsetT_CCD1 = { ".G_CPositionCoordinates[1]", ".G_CPositionCoordinates[2]", ".G_CPositionCoordinates[3]", ".G_CPositionCoordinates[4]", ".G_CPositionCoordinates[5]", ".G_CPositionCoordinates[6]" };

            public static string[] OffsetX_CCD2 = { ".G_XPositionCoordinates[7]", ".G_XPositionCoordinates[8]", ".G_XPositionCoordinates[9]", ".G_XPositionCoordinates[10]", ".G_XPositionCoordinates[11]", ".G_XPositionCoordinates[12]" };
            public static string[] OffsetY_CCD2 = { ".G_YPositionCoordinates[7]", ".G_YPositionCoordinates[8]", ".G_YPositionCoordinates[9]", ".G_YPositionCoordinates[10]", ".G_YPositionCoordinates[11]", ".G_YPositionCoordinates[12]" };
            public static string[] OffsetT_CCD2 = { ".G_CPositionCoordinates[7]", ".G_CPositionCoordinates[8]", ".G_CPositionCoordinates[9]", ".G_CPositionCoordinates[10]", ".G_CPositionCoordinates[11]", ".G_CPositionCoordinates[12]" };
            #endregion


            #region   //PLC标定信号
            public static string Mode_CCD = ".G_CCDdemarcate1Mode";//相机1模式  0 代表正常生产模式  1代表九点标定开始；2代表旋转中心标定
            public static string TrigSignal_CCD = ".G_CCDStart";  //相机触发信号
            public static string FinishSignal_CCD = ".G_CCDFinish";//相机完成信号   
            public static string Linear_Current_PosX = ".G_CCDdemarcatePosX"; //模组CCD1当前坐标X
            public static string Linear_Current_PosY = ".G_CCDdemarcatePosY"; //模组CCD1当前坐标Y

            #region 九点标定信号 
            public static string Linear_Request_CCD = ".G_CCDdemarcateReady";//相机请求PLC开始九点标定信号
            public static string Linear_Move_End_CCD = ".G_CCDdemarcateFinish";//PLC通知CCD模组九点运动结束信号
            #endregion

            #region Rotation标定信号
            public static string Rotation_Request_CCD = ".G_CCDdemarcateReady";//相机请求PLC开始旋转标定信号
            public static string Rotation_Move_End_CCD = ".G_CCDdemarcateFinish";//PLC通知CCD模组旋转运动结束信号
            #endregion
            #endregion

            public static double ProductGrayValueCCD1 = 0;
            public static double ProductNumCCD1 = 0;
            public static double[] XdateCCD1 = { 0, 0, 0, 0, 0, 0 };
            public static double[] YdateCCD1 = { 0, 0, 0, 0, 0, 0 };
            public static double[] TdateCCD1 = { 0, 0, 0, 0, 0, 0 };

            public static double ProductGrayValueCCD2 = 0;
            public static double ProductNumCCD2 = 0;
            public static double[] XdateCCD2 = { 0, 0, 0, 0, 0, 0 };
            public static double[] YdateCCD2 = { 0, 0, 0, 0, 0, 0 };
            public static double[] TdateCCD2 = { 0, 0, 0, 0, 0, 0 };






















        }

        #endregion
    }

}
