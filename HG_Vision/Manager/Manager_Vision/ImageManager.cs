using Model.ConstantModel;
using System.Collections.Generic;
using HG_Vision.Contol.Control_Vision;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Vision
{
    public class ImageManager
    {
        private ImageConfiguration _imageConfiguration = new ImageConfiguration();

        public ImageConfiguration ImageConfiguration
        {
            get { return _imageConfiguration; }
        }

        private List<ImageParamsModel> _imageParams;

        public List<ImageParamsModel> ImageParams
        {
            get { return _imageParams; }
        }

        private ImageSave _imageSave;

        public ImageSave ImageSave
        {
            get { return _imageSave; }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            _imageSave = new ImageSave();

            _imageParams = new List<ImageParamsModel>();
            //加载ini
            _imageConfiguration.AnalysisImageParamsConfig(ref _imageParams);
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
            _imageConfiguration.SaveOneParams(section, node, value);
        }
    }
}
