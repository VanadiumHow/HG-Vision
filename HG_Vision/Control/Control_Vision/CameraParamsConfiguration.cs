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
        private readonly static string _xmldirctory = Project.Instance.VisionManagerInstance._visionParamPath + @"\Config";
        private readonly static string _xml = _xmldirctory + @"\ParamsModelC1.xml";
        
        /// <summary>
        /// 读取.xml文件参数
        /// </summary>
        public void AnalysisCameraParamsCommConfig(ref ParamsModelC1 cameraParams)
        {
            //配置文件夹
            if (!Directory.Exists(_xmldirctory))
                Directory.CreateDirectory(_xmldirctory);
            //主配置文件ini
            cameraParams = XmlHelper.Deserialize<ParamsModelC1>(_xml);
            if (!File.Exists(_xml))
            {
                File.Create(_xml).Close();
                XmlHelper.Serialize(cameraParams, _xml);
            }

        }
        /// <summary>
        /// 保存参数至.xml文件
        /// </summary>
        public void SaveAllParams(ParamsModelC1 cameraParams)
        {
            //配置文件夹
            if (!Directory.Exists(_xmldirctory))
                Directory.CreateDirectory(_xmldirctory);
            //主配置文件ini
            if (!File.Exists(_xml))
                File.Create(_xml).Close();
            XmlHelper.Serialize(cameraParams, _xml);
        }
        /// <summary>
        /// 存单个参数
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        //public void SaveOneParams(string section, string node, string value)
        //{
        //    try
        //    {
        //        _ini.WriteIniKey(section, node, value);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception($"{section}段 {node} 节点 写入{value}出现异常：{ex.Message}");
        //    }
        //}
    }
}
