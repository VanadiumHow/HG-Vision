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
        public static string LogPath = DataPath + "\\Logger";

        //系统日志文件路径
        public static string SystemLogPath = LogPath + "\\系统异常.log";

        /// <summary>
        /// Config文件夹路径
        /// </summary>
        public static string ConfigPath = DataPath + "\\Config";

        //程序系统参数Configuration.ini加载路径
        public static string GlobalParamPath = DataPath + "\\Config\\GlobalParam.xml";

        //程序数据库参数Sql.ini加载路径
        public static string SqlParamPath = DataPath + "\\Config\\Sql.ini";

        //程序PLC参数PlcComm.ini加载路径
        public static string PlcCommPath = DataPath + "\\Config\\PlcComm.ini";

        //程序PLC交互信号excel加载路径
        public static string PlcSignalPath = string.Format(@"{0}..\..\..\..\..\交互信号.xlsx", DataPath);

        //程序Robot客户端对象参数RobotClient.xml加载路径
        public static string RobotClientPath = DataPath + "\\Config\\RobotClient.xml";

        //程序Laser客户端对象参数LaserClient.xml加载路径
        public static string LaserClientPath = DataPath + "\\Config\\LaserClient.xml";

        //程序Laser客户端对象参数LaserServer.xml加载路径
        public static string LaserServerPath = DataPath + "\\Config\\LaserServer.xml";

        //程序Laser客户端对象参数PLCServer.xml加载路径
        public static string PLCServerPath = DataPath + "\\Config\\PLCServer.xml";

        //PLC发送临时数据（夹具号、条码、极耳间距）PLCDataTemp.xml加载路径
        public static string PLCDataTempPath = DataPath + "\\temp\\PLCDataTemp.xml";

        //发送给机械手的临时数据RobotDataTempPath.xml加载路径
        public static string RobotDataTempPath = DataPath + "\\temp\\RobotDataTempPath.xml";

        //程序MES数据校验参数MESDataCheck.xml加载路径
        public static string MESDataCheckPath = DataPath + "\\Config\\DataCheckComm.ini";

        //程序用户登录信息UserInfo.json加载路径
        public static string UsersFilePath = DataPath + "\\User\\Users.xml";

        //ParamsC1Model.xml加载路径
        //由于参数文件会随产品型号变化，所以放到Product文件夹下的不同目录中，因此无法在此处定义，由VisionManager动态赋值

        // 产品文件夹路径
        public static string ProductPath = DataPath + "\\Product";

        //默认产品型号文件夹路径
        public static string VisionDefaultPath = ProductPath + "\\默认";

        //当前产品型号文件夹路径
        public static string VisionCurrentPath = ProductPath + "\\默认";

        //视觉参数文件夹路径
        public static string VisionParamPath;

        //视觉工具文件夹路径
        public static string VisionToolPath;
    }
}
