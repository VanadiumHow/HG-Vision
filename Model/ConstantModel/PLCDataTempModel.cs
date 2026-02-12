using System.Xml.Serialization;

namespace Model.ConstantModel
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    [XmlRoot("PLC临时数据（防止软件异常关闭丢失数据）")]
    public class PLCDataTempModel
    {
        public int JigIndex = -1;
        public string Code1 = "null";
        public string Code2 = "null";
        public double Spaing1 = 0;
        public double Spaing2 = 0;
    }
}
