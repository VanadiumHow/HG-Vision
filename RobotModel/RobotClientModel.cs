using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.SocketModel
{
    [XmlRoot("机械手客户端连接本地服务器配置")]
    public class RobotClientModel
    {
        [XmlIgnore]
        public List<SocketInfoModel> RobotClientList = new List<SocketInfoModel>();

        [XmlArray("机械手客户端信息")]
        [XmlArrayItem("机械手")]
        public SocketInfoModel[] ArrRobotClient
        {
            get => RobotClientList.ToArray();
            set => RobotClientList = value != null ? new List<SocketInfoModel>(value) : new List<SocketInfoModel>();
        }
        public RobotClientModel()
        {
            RobotClientList.Add(new SocketInfoModel() { LocalName = "Robot0", LocalIP = "192.168.250.26", LocalPort = "12000" });
            RobotClientList.Add(new SocketInfoModel() { LocalName = "Robot1", LocalIP = "192.168.250.25", LocalPort = "11000" });
        }
    }
}
