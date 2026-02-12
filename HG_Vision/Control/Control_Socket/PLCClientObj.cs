using BaseThread;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.ConstantModel;
using Model.EnumModel;
using Model.SocketModel;
using Model.VisionModel;
using Obj.Obj_File;
using Obj.Obj_Queue;
using Obj.Obj_Socket;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Xml.Linq;
namespace HG_Vision.Contol.Control_Socket
{
    /// <summary>
    /// 机器人对象（仅实现个性逻辑）
    /// </summary>
    public class PLCClientObj : ClientObj
    {
        #region PLC专属属性
        //阻塞队列执行用户线程
        internal List<BlockQueue<TriggerEventArgs>> _taskQueueList = new List<BlockQueue<TriggerEventArgs>>();//相机触发队列集合

        public PLCDataTempModel PLCData = new PLCDataTempModel();

        #endregion

        #region PLC专属构造函数
        public PLCClientObj(string deviceId, string ip, string port) : base(new IPEndPoint(IPAddress.Parse(ip), int.Parse(port)))
        {
            PLCData = XmlHelper.Deserialize<PLCDataTempModel>(FilePathModel.PLCDataTempPath);
            DeviceId = deviceId;
            DeviceType = eDeviceType.PLC;
            DeviceName = $"PLC_{deviceId}";
        }
        #endregion

        #region PLC专属方法
        protected override void Client_OnRead(Socket soc)
        {
            if (SignalsModel.CCDProcess == 0)//0-自动运行
            {
                //以;分组处理PLC发来的数据
                //格式：PGS;电芯序号(1或2);夹具号;电芯条码;极耳间距
                //示例：PGS;1;5;PG44035381258596;11.243
                string receive_string = this.ReceivedText;
                string[] str = receive_string.Split(';');
                if (str.Length == 5 && str[0] == "PGS")
                {
                    LogHelper.Info($"工位{str[1]}收到PLC数据：" + receive_string);
                    if (str[1].Contains("1"))
                    {
                        PLCData.JigIndex = Convert.ToInt32(str[2]);
                        PLCData.Code1 = str[3];
                        PLCData.Spaing1 = Convert.ToDouble(str[4]);
                        if (!Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").SendText(receive_string))
                            LogHelper.Error("工位1数据返回PLC失败！");
                    }
                    else if (str[1].Contains("2"))
                    {
                        PLCData.JigIndex = Convert.ToInt32(str[2]);
                        PLCData.Code2 = str[3];
                        PLCData.Spaing2 = Convert.ToDouble(str[4]);
                        if (!Project.Instance.ClientManagerInstance.GetDevice<PLCClientObj>($"PLC{0}").SendText(receive_string))
                            LogHelper.Error("工位2数据返回PLC失败！");
                    }
                    XmlHelper.Serialize(FilePathModel.PLCDataTempPath, PLCData);
                }
            }
        }
        #endregion
    }
}