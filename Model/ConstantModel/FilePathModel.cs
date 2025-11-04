using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace Model.ConstantModel
{
    public static class FilePathModel
    {
        /// <summary>
        /// 启动程序集的运行目录
        /// </summary>
        public static string DataPath = Application.StartupPath;

        /// <summary>
        /// 日志文件夹路径
        /// </summary>
        public static string LogPath = DataPath + @"\\Logger";

        //系统日志文件路径
        public static string SystemLogPath = LogPath + @"\\系统异常.log";

        /// <summary>
        /// Config文件夹路径
        /// </summary>
        public static string ConfigPath = DataPath + @"\\Config";

        //程序系统参数Configuration.ini加载路径
        public static string GlobalParamPath = DataPath + "\\Config\\Configuration.ini";

        //程序数据库参数Sql.ini加载路径
        public static string SqlParamPath = DataPath + "\\Config\\Sql.ini";

        //程序PLC参数PlcComm.ini加载路径
        public static string PlcCommPath = DataPath + "\\Config\\PlcComm.ini";

        //程序PLC交互信号excel加载路径
        public static string PlcSignalPath = string.Format(@"{0}..\..\..\..\..\交互信号.xlsx", DataPath);

        //程序Robot参数RobotComm.ini加载路径
        public static string RobotCommPath1 = DataPath + "\\Config\\RobotComm1.ini";

        //程序Robot参数RobotComm.ini加载路径
        public static string RobotCommPath2 = DataPath + "\\Config\\RobotComm2.ini";

        //程序Laser参数LaserComm.ini加载路径
        public static string LaserCommPath = DataPath + "\\Config\\LaserComm.ini";

        //程序用户登录信息UserInfo.json加载路径
        public static string UsersFilePath = DataPath + @"\\User\\Users.xml";

        //ParamsModelC1.xml加载路径
        //由于参数文件会随产品型号变化，所以放到Product文件夹下的不同目录中，因此无法在此处定义，由VisionManager动态赋值
        /// <summary>
        /// 程序默认视觉工具文件夹路径
        /// </summary>
        public static string VisionToolDefaultPath = DataPath + @"\\VisionTool";

        /// <summary>
        /// 程序默认视觉参数文件夹路径
        /// </summary>
        public static string VisionParamDefaultPath = DataPath + @"\\VisionParam";

        /// <summary>
        /// 产品文件夹路径
        /// </summary>
        public static string ProductPath = DataPath + @"\\Product";
    }
}
