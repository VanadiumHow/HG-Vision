using Model.EnumModel;
using Obj.Obj_Socket;
using System.Net;

namespace HG_Vision.Contol.Control_Socket
{
    /// <summary>
    /// 机器人对象（仅实现个性逻辑）
    /// </summary>
    public class RobotServerObj : ServerObj
    {
        #region 机器人专属属性
        #endregion

        #region 机器人专属构造函数
        public RobotServerObj(string deviceId, string ip, string port) : base(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)))
        {
            DeviceId = deviceId;
            DeviceType = DeviceType.Robot;
            DeviceName = $"机器人_{deviceId}";
        }
        #endregion

        #region 机器人专属方法
        #endregion
    }
}