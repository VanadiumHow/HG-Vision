using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionProgram.Common;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.GlobalConfig
{
    public class GlobalManager
    {
        /// <summary>
        /// 系统参数配置类
        /// </summary>
        private GlobalConfiguration _globalConfiguration = new GlobalConfiguration();     

        /// <summary>
        /// 系统参数类
        /// </summary>
        private GlobalParamModel _globalParamModel;

        public GlobalParamModel GlobalParamModel
        {
            get { return _globalParamModel; }
        }

        internal GlobalManager() { }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            _globalParamModel = new GlobalParamModel();
            _globalConfiguration.AnalysisGlobalConfig(ref _globalParamModel);
        }

        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveOneParams(string section, string node, string value)
        {
            _globalConfiguration.SaveOneParams(section, node, value);
        }

        /// <summary>
        /// 同步产品
        /// </summary>
        /// <returns></returns>
        public bool SetCurProductModel()
        {
            SaveOneParams("Config", "CurProductModel", Project.Instance().GlobalManagerInstance.GlobalParamModel.curProductModel);
            SaveOneParams("Config", "UseProductModel", Project.Instance().GlobalManagerInstance.GlobalParamModel.useProductModel ? "1" : "0");
            return true;
        }

      
    }
}
