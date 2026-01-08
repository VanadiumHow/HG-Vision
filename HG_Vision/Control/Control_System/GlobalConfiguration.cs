using Model.ConstantModel;
using Obj.Obj_File;
using System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_System
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class GlobalConfiguration
    {
        /// <summary>
        /// xml读写对象
        /// </summary>
        private readonly static string _xml = FilePathModel.GlobalParamPath;

        /// <summary>
        /// 读取.xml文件参数
        /// </summary>
        public void AnalysisGlobalParamsConfig(ref GlobalParamsModel globalParams)
        {
            try
            {
                //反序列化.xml文件
                globalParams = XmlHelper.Deserialize<GlobalParamsModel>(_xml);
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisGlobalParamsConfig方法调用Deserialize方法失败", ex);
            }
        }
        /// <summary>
        /// 保存参数至.xml文件
        /// </summary>
        public void SaveGlobalParamsConfig(GlobalParamsModel globalParams)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(_xml, globalParams);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveGlobalParamsConfig方法调用Serialize方法失败", ex);
            }
        }
    }
}
