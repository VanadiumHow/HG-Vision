using HG_Vision.Contol.Control_Socket;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.ConstantModel;
using Model.EnumModel;
using Model.SocketModel;
using Obj.Obj_File;
using Obj.Obj_Socket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Socket
{
    public class ServerManager
    {
        /// <summary>
        /// Robo配置类
        /// </summary>
        private readonly SeverConfiguration _severConfiguration = new SeverConfiguration();
        public SeverConfiguration SeverConfiguration
        {
            get
            {
                return _severConfiguration;
            }
        }
        //加载配置文件，创建机械手对象并添加
        RobotClientModel robotClientModel = new RobotClientModel();
        //负责监听客户端的线程:创建一个监听线程
        /// <summary>
        /// 所有SocketServer连接的对象
        /// </summary>
        private readonly Dictionary<string, ServerObj> _allDevices = new Dictionary<string, ServerObj>();

        /// <summary>
        /// 按类型分类的对象Robot、Laser
        /// </summary>
        private readonly Dictionary<DeviceType, List<ServerObj>> _devicesByType = new Dictionary<DeviceType, List<ServerObj>>()
        {
            { DeviceType.Robot, new List<ServerObj>() },
            { DeviceType.Laser, new List<ServerObj>() }
        };

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            try
            {
                //停止当前所有设备
                StopAllDevices();
                //清空字典_a，清空字典_d的所有列表
                _allDevices.Clear();
                _devicesByType.Values.ToList().ForEach(list => list.Clear());

                _severConfiguration.AnalysisServerInfoConfig(ref robotClientModel);
                for (int i = 0; i < robotClientModel.RobotClientList.Count; i++)
                {
                    var robotObj = new RobotServerObj(robotClientModel.RobotClientList[i].LocalName, robotClientModel.RobotClientList[i].LocalIP, robotClientModel.RobotClientList[i].LocalPort);
                    AddDevice(robotObj);
                }
                //加载配置文件，创建激光对象并添加
                LaserClientModel laserClientModel = new LaserClientModel();
                _severConfiguration.AnalysisServerInfoConfig(ref laserClientModel);
                for (int i = 0; i < laserClientModel.LaserClientList.Count; i++)
                {
                    var laserObj = new LaserServerObj(laserClientModel.LaserClientList[i].LocalName, laserClientModel.LaserClientList[i].LocalIP, laserClientModel.LaserClientList[i].LocalPort);
                    laserObj.InitCameraWorkThreads1();
                    AddDevice(laserObj);
                }
                //启动所有设备连接
                StartAllDevices();

            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Robot服务器失败：", ex);
            }
        }
        #region 设备管理方法
        /// <summary>
        /// 添加设备（自动分类）
        /// </summary>
        public bool AddDevice(ServerObj device)
        {
            if (string.IsNullOrEmpty(device.DeviceId) || _allDevices.ContainsKey(device.DeviceId))
            {
                //Console.WriteLine($"设备ID重复或为空：{server.DeviceId}");
                return false;
            }
            // 添加到总字典和分类列表
            _allDevices.Add(device.DeviceId, device);
            _devicesByType[device.DeviceType].Add(device);
            //Console.WriteLine($"添加设备成功：{server.DeviceName}（ID：{server.DeviceId}）");
            return true;
        }

        /// <summary>
        /// 移除设备（按DeviceId，不影响其他设备）
        /// </summary>
        public bool RemoveDevice(string deviceId)
        {
            if (!_allDevices.TryGetValue(deviceId, out var device))
            {
                //Console.WriteLine($"设备不存在：{deviceId}");
                return false;
            }
            // 停止设备并移除
            device.StopServer();
            _allDevices.Remove(deviceId);
            _devicesByType[device.DeviceType].Remove(device);
            //Console.WriteLine($"移除设备成功：{server.DeviceName}（ID：{deviceId}）");
            return true;
        }
        /// <summary>
        /// 移除所有设备
        /// </summary>
        public bool RemoveAllDevice()
        {
            foreach (var device in _allDevices.Values)
            {
                device.StopServer();
                _allDevices.Remove(device.DeviceId);
                _devicesByType[device.DeviceType].Remove(device);
                //Console.WriteLine($"移除设备成功：{device.DeviceName}（ID：{device.DeviceId}）");
            }
            return true;
        }

        /// <summary>
        /// 获取所有设备
        /// </summary>
        public List<ServerObj> GetAllDevice()
        {
            List<ServerObj> devices = new List<ServerObj>();
            foreach (ServerObj g in _allDevices.Values)
            {
                devices.Add(g);
            }
            return devices;
        }
        /// <summary>
        /// 获取设备（按DeviceId，无需关心索引）
        /// </summary>
        public T GetDevice<T>(string deviceId) where T : ServerObj
        {
            _allDevices.TryGetValue(deviceId, out var device);
            return device as T;
        }
        /// <summary>
        /// 获取指定类型的所有设备（如所有机器人）
        /// </summary>
        public List<T> GetDevicesByType<T>(DeviceType deviceType) where T : ServerObj
        {
            return _devicesByType[deviceType].Cast<T>().ToList();
        }

        /// <summary>
        /// 启动所有设备
        /// </summary>
        public void StartAllDevices()
        {
            foreach (var device in _allDevices.Values)
            {
                device.StartServer();
            }
        }

        /// <summary>
        /// 停止所有设备
        /// </summary>
        public void StopAllDevices()
        {
            foreach (var device in _allDevices.Values)
            {
                device.StopServer();
            }
        }
        #endregion
    }
}
