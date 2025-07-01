using System;
using System.IO;
using System.Windows;
using Model.ConstantModel;
using Obj.Obj_File;

namespace HG_Vision.Contol.Control_Robot
{
    /****************************************************************

*****************************************************************/
    public class RobotSeverConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        public IniHelper _ini = new IniHelper(FilePathModel.RobotCommPath1);

        /// <summary>
        ///服务器的信息
        /// </summary>
        public RobotInfo A_RobotInfo;
        public struct RobotInfo
        {
            //服务器1
            public string LocalName;
            public string LocalIP;
            public string LocalPort;
            //服务器2
            public string LocalName1;
            public string LocalIP1;
            public string LocalPort1;
            //服务器3                 
            public string LocalName2;
            public string LocalIP2;
            public string LocalPort2;
            //服务器4           
            public string LocalName3;
            public string LocalIP3;
            public string LocalPort3;

        }

        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section">段</param>
        /// <param name="node">节点</param>
        /// <param name="value">值</param>
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

        /// <summary>
        /// 解析RobotInfo,初始化Robot信息数组
        /// </summary>
        public void AnalysisRobotInfoConfig(string strFilePath)
        {
            try
            {
                InitConfigDirctory(strFilePath);
                _ini.path = strFilePath;
                A_RobotInfo = new RobotInfo();

                string robotSection = "Robot1";
                A_RobotInfo.LocalName = _ini.IniReadValue(robotSection, "Name");
                A_RobotInfo.LocalIP = _ini.IniReadValue(robotSection, "Ip");
                A_RobotInfo.LocalPort = _ini.IniReadValue(robotSection, "Port");
                robotSection = "Robot2";
                A_RobotInfo.LocalName1 = _ini.IniReadValue(robotSection, "Name");
                A_RobotInfo.LocalIP1 = _ini.IniReadValue(robotSection, "Ip");
                A_RobotInfo.LocalPort1 = _ini.IniReadValue(robotSection, "Port");
                robotSection = "Laser";
                A_RobotInfo.LocalName2 = _ini.IniReadValue(robotSection, "Name");
                A_RobotInfo.LocalIP2 = _ini.IniReadValue(robotSection, "Ip");
                A_RobotInfo.LocalPort2 = _ini.IniReadValue(robotSection, "Port");
                robotSection = "Laser1";
                A_RobotInfo.LocalName3 = _ini.IniReadValue(robotSection, "Name");
                A_RobotInfo.LocalIP3 = _ini.IniReadValue(robotSection, "Ip");
                A_RobotInfo.LocalPort3 = _ini.IniReadValue(robotSection, "Port");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析Robot配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析Robot配置文件出现异常，类型转换错误或节点不存在", ex);
            }
        }

        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory(string strFilePath)
        {
            try
            {
                //
                //配置文件夹
                if (!Directory.Exists(FilePathModel.ConfigPath))
                    Directory.CreateDirectory(FilePathModel.ConfigPath);
                //主配置文件ini
                if (!File.Exists(strFilePath))
                    File.Create(strFilePath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查Robot配置文件路径出现异常", ex);
            }
        }

    }
}

