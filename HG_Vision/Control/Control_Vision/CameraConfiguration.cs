using System;
using System.IO;
using System.Windows;
using Obj.Obj_File;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_Vision
{
    public struct CameraAttribute
    {
        public string ImageWindowName;
        public string ImageWindowType;
    }
    public class CameraConfiguration
    {
        /// <summary>
        /// Ini读写对象
        /// </summary>
        private IniHelper _ini = new IniHelper(Project.Instance.VisionManagerInstance._visionParamPath + "\\CameraAttribute.ini");

        /// <summary>
        /// 检查各配置文件
        /// </summary>
        private void InitConfigDirctory()
        {
            try
            {
                //配置文件夹
                if (!Directory.Exists(Project.Instance.VisionManagerInstance._visionParamPath + "\\Config"))
                    Directory.CreateDirectory(Project.Instance.VisionManagerInstance._visionParamPath + "\\Config");
                //主配置文件ini
                if (!File.Exists(Project.Instance.VisionManagerInstance._visionParamPath + "\\Config\\CameraAttribute.ini"))
                    File.Create(Project.Instance.VisionManagerInstance._visionParamPath + "\\Config\\CameraAttribute.ini").Close();
            }
            catch (Exception ex)
            {
                LogHelper.Error("检查相机属性配置文件路径出现异常", ex);
            }
        }

        /// <summary>
        /// 解析CameraAttribute,初始化数组
        /// </summary>
        public void AnalysisCameraAttributeConfig(ref CameraAttribute[] cameraAttributes)
        {
            try
            {
                InitConfigDirctory();
                for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum; i++)
                {
                    CameraAttribute _cameraAttribute = new CameraAttribute();
                    string ScanSection = "Camera" + (i + 1).ToString();
                    string ImageWindowName = _ini.IniReadValue(ScanSection, "ImageWindowName");
                    string ImageWindowType = _ini.IniReadValue(ScanSection, "ImageWindowType");
                    _cameraAttribute.ImageWindowName = ImageWindowName;
                    _cameraAttribute.ImageWindowType = ImageWindowType;
                    cameraAttributes[i] = _cameraAttribute;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"解析相机属性配置文件出现异常：{ex.Message}");
                LogHelper.Error("解析相机属性配置文件出现异常", ex);
            }
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
            try
            {
                _ini.WriteIniKey(section, node, value);
            }
            catch (Exception ex)
            {
                throw new Exception($"{section}段 {node} 节点 写入{value}出现异常：{ex.Message}");
            }
        }
    }
}
