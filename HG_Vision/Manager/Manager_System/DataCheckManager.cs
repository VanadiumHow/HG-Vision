using HG_Vision.Contol.Control_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_System
{
    /// <summary>
    /// 数据校验管理类
    /// </summary>
    public class DataCheckManager
    {
        private DataCheckConfiguration _dataCheckConfiguration = new DataCheckConfiguration();

        public DataCheckConfiguration DataCheckConfiguration
        {
            get { return _dataCheckConfiguration; }
        }

        private CheckInfo _checkInfo;

        public CheckInfo CheckInfo
        {
            get { return _checkInfo; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            _checkInfo = new CheckInfo();
            //加载ini
            _dataCheckConfiguration.AnalysisDataCheckCommConfig(ref _checkInfo);
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
            _dataCheckConfiguration.SaveOneParams(section, node, value);
        }
    }
}
