using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.SocketModel
{
    [XmlRoot("激光客户端连接本地服务器配置")]
    public class LaserClientModel
    {
        [XmlIgnore]
        public List<SocketInfoModel> LaserClientList = new List<SocketInfoModel>();

        [XmlArray("激光客户端信息")]
        [XmlArrayItem("激光")]
        public SocketInfoModel[] ArrLaserClient
        {
            get => LaserClientList.ToArray();
            set => LaserClientList = value != null ? new List<SocketInfoModel>(value) : new List<SocketInfoModel>();
        }
        public LaserClientModel()
        {
            LaserClientList.Add(new SocketInfoModel() { DeviceName = "Laser0",DeviceIP = "127.0.0.1", LocalIP = "127.0.0.1", LocalPort = "13000" });
        }
    }
}
