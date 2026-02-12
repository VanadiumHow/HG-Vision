using System.Xml.Serialization;

namespace Model.ConstantModel
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    [XmlRoot("机器人偏移临时数据（防止软件异常关闭丢失数据）")]
    public class RobotDataTempModel
    {
        //预期格式：OK;X;Y
        public string RobotOffsetString = "2;0;0;";
    }
}
