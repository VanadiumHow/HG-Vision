using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.SocketModel
{
    [XmlRoot("激光服务器连接本地客户端配置")]
    public class LaserServerModel
    {
        [XmlIgnore]
        public List<SocketInfoModel> LaserServerList = new List<SocketInfoModel>();

        [XmlArray("激光服务器信息")]
        [XmlArrayItem("激光")]
        public SocketInfoModel[] ArrLaserServer
        {
            get => LaserServerList.ToArray();
            set => LaserServerList = value != null ? new List<SocketInfoModel>(value) : new List<SocketInfoModel>();
        }
        public LaserServerModel() => LaserServerList.Add(new SocketInfoModel() { DeviceName = "Laser0", DeviceIP = "127.0.0.1", LocalIP = "127.0.0.1", LocalPort = "5000" });
    }
}
