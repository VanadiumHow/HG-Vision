using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;
using System.Collections;
using VisionProgram.Common;
using VisionProgram.Models.VModels;

/****************************************************************

*
*****************************************************************/


namespace VisionProgram.Main.ProjectClass
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class GlobalConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(FilePathModel.GlobalParamPath);

        internal GlobalConfiguration() { }

        public void AnalysisGlobalConfig(ref GlobalParamModel globalParamModel)
        {
            try
            {
                InitConfigDirctory();
                globalParamModel.WorkFlowNum = Convert.ToInt16(_ini.IniReadValue("Config", "WorkFlowNum"));
                globalParamModel.NozzleNum = Convert.ToInt16(_ini.IniReadValue("Config", "NozzleNum"));
                globalParamModel.RobotNum= Convert.ToInt16(_ini.IniReadValue("Config", "RobotNum"));
                globalParamModel.programTitle = _ini.IniReadValue("Config", "ProgramTitle");
                globalParamModel.logSaveDays = Convert.ToInt16(_ini.IniReadValue("Config", "LogSaveDays"));
                globalParamModel.PanelRightWidth = Convert.ToInt32(_ini.IniReadValue("Config", "PanelRightWidth"));
                globalParamModel.InteractionInfoMaxLines = Convert.ToInt32(_ini.IniReadValue("Config", "InteractionInfoMaxLines"));
                globalParamModel.Password = _ini.IniReadValue("Config", "Password");




                if (globalParamModel.WorkFlowNum > 0)
                {
                    globalParamModel.curProductModel = _ini.IniReadValue("Config", "CurProductModel");
                    globalParamModel.useProductModel = Convert.ToInt16(_ini.IniReadValue("Config", "UseProductModel")) == 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"读取Configuration配置项出现异常，类型转换错误或节点不存在：{ex.Message}");
                LogHelper.Error("读取Configuration配置项出现异常，类型转换错误或节点不存在", ex);
            }
        }

     

        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SaveOneParams(string section, string node, string value)
        {
            try
            {
                _ini.WriteIniKey(section, node, value);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
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
                if (!File.Exists(FilePathModel.GlobalParamPath))
                    File.Create(FilePathModel.GlobalParamPath).Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查Configuration配置文件路径出现异常", ex);
            }
        }
    }
}
