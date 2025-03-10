using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Models.VModels
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

        /// <summary>
        /// User文件夹路径
        /// </summary>
        public static string UserPath = DataPath + @"\\User";

        //程序用户登录信息UserInfo.json加载路径
        public static string UserInfoFilePath = DataPath + @"\\User\\UserInfo.txt";//尽量放到某磁盘某个文件夹，不随程序而动

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
