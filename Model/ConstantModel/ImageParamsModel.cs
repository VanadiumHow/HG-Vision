namespace Model.ConstantModel
{
    /// <summary>
    /// 图片保存参数
    /// </summary>
    public class ImageParamsModel
    {
        //图像保存位置
        public string RawImagePosition;
        public string ResultImagePosition;
        //图像保存格式
        public string RawImagePattern;
        public string ResultImagePattern;
        //图像保存天数
        public int RawKeepingDays;
        public int ResultKeepingDays;

        //存图模式
        public enum SAVEOPPORTUNITY { NONE = 0, ONLYOK = 1, ONLYNG = 2, ALL = 3 }
        //图像保存模式
        public SAVEOPPORTUNITY RawImageSaveOpportunity;
        public SAVEOPPORTUNITY ResultImageSaveOpportunity;
    }
}
