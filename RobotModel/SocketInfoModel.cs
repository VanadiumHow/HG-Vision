using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.SocketModel
{
    public class SocketInfoModel
    {
        public string DeviceName { get; set; } = "";
        public string DeviceIP { get; set; } = "";
        public string LocalIP { get; set; } = "";

        public string LocalPort { get; set; } = "";
    }
}
