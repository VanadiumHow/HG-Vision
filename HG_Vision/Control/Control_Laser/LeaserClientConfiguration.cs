using System;
using System.IO;
using System.Windows;
using Model.ConstantModel;
using Obj.Obj_File;

namespace HG_Vision.Contol.Control_Laser
{
    /****************************************************************
 
*   描述说明：RobotSeverConfiguration配置类
*   主要负责读写Robot配置信息
*   修改历史：
*
*
*****************************************************************/
    public class LaserClientConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        public IniHelper _ini = new IniHelper(FilePathModel.LaserCommPath);

        /// <summary>
        ///服务器的信息
        /// </summary>
        public LaserInfo[] A_LaserInfo;
        public struct LaserInfo
        {
            //服务器
            public string LocalName;
            public string LocalIP;
            public string LocalPort;
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
        /// 解析
        /// </summary>
        public void AnalysisLaserInfoConfig(int num)
        {
            try
            {
                InitConfigDirctory();
                A_LaserInfo = new LaserInfo[num];
                for (int i = 0; i < num; i++)
                {
                    LaserInfo laserInfo = new LaserInfo();
                    string laserSection = "Laser" + i.ToString(); ;
                    string LocalName = _ini.IniReadValue(laserSection, "Name");
                    string LocalIP = _ini.IniReadValue(laserSection, "Ip");
                    string LocalPort = _ini.IniReadValue(laserSection, "Port");
                    laserInfo.LocalName = LocalName;
                    laserInfo.LocalIP = LocalIP;
                    laserInfo.LocalPort = LocalPort;
                    A_LaserInfo[i] = laserInfo;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析laser配置文件出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("解析laser配置文件出现异常，类型转换错误或节点不存在", ex);
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
                if (!File.Exists(FilePathModel.LaserCommPath))
                    File.Create(FilePathModel.LaserCommPath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查Laser配置文件路径出现异常", ex);
            }
        }

    }
}
