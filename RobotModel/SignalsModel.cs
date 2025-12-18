namespace Model.SocketModel
{
    /// <summary>
    /// 机器人静态信号
    /// </summary>
    public static class SignalsModel
    {
        //区分自动运行和自动标定标志位
        public static int CCDProcess = 0; //0-自动运行 1-标定

        #region 标定信号   
        public static string CCDRobotCal = "0"; //0-九点标定，1-旋转中心标定

        public static string CCDRobotCalStart = "CalStart"; //Robot开始一键九点标定

        public static string CCDRobotRCalStart = "RCalStart"; //Robot开始一键旋转标定
        #endregion

    }
}
