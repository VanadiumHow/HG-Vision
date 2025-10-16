using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Obj.Obj_File;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Contol.Control_Vision;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Vision
{
    public class CameraManager
    {
        /// <summary>
        /// 相机信息配置类
        /// </summary>
        private CameraConfiguration _cameraConfiguration = new CameraConfiguration();
        public CameraConfiguration CameraConfiguration
        {
            get
            {
                return _cameraConfiguration;
            }
        }
        public CameraAttribute[] A_CameraAttributes;

        /// <summary>
        /// 工具集合
        /// </summary>
        private List<WorkFlow1> _workFlowList = new List<WorkFlow1>();
        public List<WorkFlow1> WorkFlowList
        {
            get { return _workFlowList; }
            set { _workFlowList = value; }
        }

        /// <summary>
        /// 相机数量
        /// </summary>
        public int CameraNum
        {
            get { return Project.Instance.GlobalManagerInstance.GlobalParamModel.WorkFlowNum; }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            A_CameraAttributes = new CameraAttribute[CameraNum];
            //加载ini
            _cameraConfiguration.AnalysisCameraAttributeConfig(ref A_CameraAttributes);

            LoadVpp();

        }

        /// <summary>
        /// 
        /// </summary>
        public void LoadVpp()
        {
            try
            {
                //加载视觉工具 内部已经初始化相机
                _workFlowList.Clear();
                for (int i = 0; i < CameraNum; i++)
                {
                    WorkFlow1 df = new WorkFlow1((i + 1).ToString());
                    _workFlowList.Add(df);
                    _workFlowList[i].InitTools();

                    //重新写入曝光到工具
                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveExprosure(i, Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载视觉检测工具出现异常：{ex.Message}");
                LogHelper.Error("加载视觉检测工具出现异常", ex);
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
            _cameraConfiguration.SaveOneParams(section, node, value);
        }
    }
}
