using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Obj.Obj_File;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Shapes;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Vision
{
    /// <summary>
    /// 读取ini文件
    /// </summary>
    public class CameraParamsConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private readonly static string _xml = Project.Instance.VisionManagerInstance._visionParamPath + @"\Config\ParamsModelC1.xml";
        /// <summary>
        /// 读取.xml文件参数
        /// </summary>
        public void AnalysisCameraParamsConfig(ref ParamsModelC1 cameraParams)
        {
            try
            {
                //反序列化.xml文件
                cameraParams = XmlHelper.Deserialize<ParamsModelC1>(_xml);
            }
            catch(Exception ex)
            {
                LogHelper.Error("AnalysisCameraParamsConfig方法调用Deserialize方法失败", ex);
            }
        }
        /// <summary>
        /// 保存参数至.xml文件
        /// </summary>
        public void SaveAllParams(ParamsModelC1 cameraParams)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(_xml, cameraParams);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveAllParams方法调用Serialize方法失败", ex);
            }
        }
    }
}
