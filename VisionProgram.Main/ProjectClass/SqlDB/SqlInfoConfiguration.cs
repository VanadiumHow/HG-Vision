using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VisionProgram.Common;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.SqlDB
{
    public class SqlInfoConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(FilePathModel.SqlParamPath);

        /// <summary>
        /// 数据库的信息
        /// </summary>
        public SqlInfo[] A_SqlInfo;
        public struct SqlInfo
        {
            public string ServerName;//服务器名称
            public string Uid;  //账号
            public string Pwd;//密码
            public string Database;//数据库
        }

        internal SqlInfoConfiguration() { }

        /// <summary>
        /// 解析SqlInfo,初始化数据库信息数组
        /// </summary>
        public void AnalysisSqlInfoConfig(out int num)
        {
            num = 0;
            try
            {
                InitConfigDirctory();
                List<string> L_AllSection = _ini.IniReadAllSection();
                A_SqlInfo = new SqlInfo[L_AllSection.Count];
                for (int i = 0; i < L_AllSection.Count; i++)
                {
                    SqlInfo sqlInfo = new SqlInfo();
                    string sqlSection = "SQL" + i.ToString();
                    string serverName = _ini.IniReadValue(sqlSection, "ServerName");
                    string uid = _ini.IniReadValue(sqlSection, "Uid");
                    string pwd = _ini.IniReadValue(sqlSection, "Pwd");
                    string database = _ini.IniReadValue(sqlSection, "Database");
                    sqlInfo.ServerName = serverName;
                    sqlInfo.Uid = uid;
                    sqlInfo.Pwd = pwd;
                    sqlInfo.Database = database;
                    A_SqlInfo[i] = sqlInfo;
                }
                num = A_SqlInfo.Length;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析数据库配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析数据库配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }

        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                //配置文件夹
                if (!Directory.Exists(FilePathModel.ConfigPath))
                    Directory.CreateDirectory(FilePathModel.ConfigPath);
                //主配置文件ini
                if (!File.Exists(FilePathModel.SqlParamPath))
                    File.Create(FilePathModel.SqlParamPath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查数据库配置文件路径出现异常", ex);
            }
        }
    }
}
