using HG_Vision.Contol.Control_System;
using HG_Vision.Contol.Control_Vision;
using Model.ConstantModel;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_System
{
    public class GlobalManager
    {
        /// <summary>
        /// 系统参数配置类
        /// </summary>
        private GlobalConfiguration _globalConfiguration = new GlobalConfiguration();
        public GlobalConfiguration GlobalConfiguration
        {
            get { return _globalConfiguration; }
        }
        /// <summary>
        /// 系统参数类
        /// </summary>
        private GlobalParamsModel _globalParamsModel;

        public GlobalParamsModel GlobalParamsModel
        {
            get { return _globalParamsModel; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            _globalConfiguration.AnalysisGlobalParamsConfig(ref _globalParamsModel);
        }

        /// <summary>
        /// 存所有参数
        /// </summary>
        public void SaveAllParams()
        {
            _globalConfiguration.SaveGlobalParamsConfig(_globalParamsModel);
        }
    }
}
