using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Model.SocketModel
{
    [XmlRoot("PLC服务器连接本地客户端配置")]
    public class PLCServerModel
    {
        [XmlIgnore]
        public List<SocketInfoModel> PLCServerList = new List<SocketInfoModel>();

        [XmlArray("PLC服务器信息")]
        [XmlArrayItem("PLC")]
        public SocketInfoModel[] ArrPLCServer
        {
            get => PLCServerList.ToArray();
            set => PLCServerList = value != null ? new List<SocketInfoModel>(value) : new List<SocketInfoModel>();
        }
        public PLCServerModel() => PLCServerList.Add(new SocketInfoModel() { DeviceName = "PLC0", DeviceIP = "192.168.250.1", LocalIP = "192.168.250.26", LocalPort = "9600" });
    }
}
