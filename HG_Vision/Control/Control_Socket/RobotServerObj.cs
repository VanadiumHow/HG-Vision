using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using Model.ConstantModel;
using Model.EnumModel;
using Model.SocketModel;
using Obj.Obj_File;
using Obj.Obj_Socket;
using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;

namespace HG_Vision.Contol.Control_Socket
{
    /// <summary>
    /// 机器人对象（仅实现个性逻辑）
    /// </summary>
    public class RobotServerObj : ServerObj
    {
        #region 机器人专属属性
        public RobotDataTempModel RobotData = new RobotDataTempModel();
        #endregion

        #region 机器人专属构造函数
        public RobotServerObj(string deviceId, string ip, string port) : base(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)))
        {
            RobotData = XmlHelper.Deserialize<RobotDataTempModel>(FilePathModel.RobotDataTempPath);
            DeviceId = deviceId;
            DeviceType = eDeviceType.Robot;
            DeviceName = $"机器人_{deviceId}";
        }
        #endregion

        #region 机器人专属方法
        protected override void Server_OnRead(Socket soc)
        {
            if (SignalsModel.CCDProcess == 0)//0-自动运行
            {
                //以;分组处理机器人请求信号
                string receive_string = this.ReceivedText;
                string[] str = receive_string.TrimEnd('\0').TrimEnd('\n').TrimEnd('\r').Split(';');
                //机器人请求偏移量数据：格式：PGS;工位号(1或2);条码
                if (str[0] == "PGS" && DeviceId.Contains((Convert.ToInt16(str[1]) - 1).ToString()))
                {
                    LogHelper.Info($"收到机器人{str[1]}请求：" + receive_string);
                    string send_string = str[0].Replace('S', 'E') + ";";
                    for (int i = 1; i < str.Length; i++)
                    {
                        send_string = send_string + str[i] + ";";
                    }
                    send_string = send_string + RobotData.RobotOffsetString + "\r\n";
                    if (!SendText(send_string, 0))
                        LogHelper.Error("发送偏移量数据失败>>机械手!");
                    else
                    {
                        LogHelper.Info("发送偏移量数据成功>>机械手：" + send_string);
                    }
                }
            }
        }
        internal void SaveRobotOffsetData(string offsetData)
        {
            RobotData.RobotOffsetString = offsetData;
            XmlHelper.Serialize(FilePathModel.RobotDataTempPath, RobotData);
        }
        #endregion
    }
}