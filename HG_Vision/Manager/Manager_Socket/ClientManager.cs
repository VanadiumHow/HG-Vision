using HG_Vision.Contol.Control_Socket;
using HG_Vision.Manager.Manager_System;
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
    public class ClientManager
    {
        /// <summary>
        /// 激光配置类
        /// </summary>
        private ClientConfiguration _clientConfiguration = new ClientConfiguration();
        public ClientConfiguration ClientConfiguration
        {
            get
            {
                return _clientConfiguration;
            }
        }
        /// <summary>
        /// 激光服务器端IP、端口信息
        /// </summary>
        private LaserServerModel laserServerModel = new LaserServerModel();
        /// <summary>
        /// 所有SocketClient连接的对象
        /// </summary>
        private readonly Dictionary<string, ClientObj> _allDevices = new Dictionary<string, ClientObj>();

        /// <summary>
        /// 按类型分类的对象Robot、Laser
        /// </summary>
        private readonly Dictionary<eDeviceType, List<ClientObj>> _devicesByType = new Dictionary<eDeviceType, List<ClientObj>>()
        {
            { eDeviceType.Laser, new List<ClientObj>() }
        };
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            try
            {
                StopAllDevices();
                //清空字典_a，清空字典_d的所有列表
                _allDevices.Clear();
                _devicesByType.Values.ToList().ForEach(list => list.Clear());

                //加载配置文件，创建激光对象并添加
                _clientConfiguration.AnalysisLaserInfoConfig(ref laserServerModel);
                for (int i = 0; i < laserServerModel.LaserServerList.Count; i++)
                {
                    var laserObj = new LaserClientObj(laserServerModel.LaserServerList[i].LocalName, laserServerModel.LaserServerList[i].LocalIP, laserServerModel.LaserServerList[i].LocalPort);
                    AddDevice(laserObj);
                }
                //启动所有设备连接
                StartAllDevices();
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Laser客户端失败：", ex);
            }
        }

        #region 重连激光器
        /// <summary>
        /// 重连激光器
        /// </summary>
        public void LaserReConnect()
        {

            for (int i = 0; i < GetAllDevice().Count; i++)
            {
                try
                {
                    var laser = GetDevice<LaserClientObj>($"Laser{i}");
                    laser.IsConnected = laser.SendText("?");
                    if (laser != null)
                    {
                        bool flag = false;
                        if (!laser.IsConnected)
                        {
                            flag = laser.IsWarningOfReconn;
                            if (!flag)
                            {
                                flag = true;
                            }
                            if (null != laser) laser.StopClient();
                            laser = new LaserClientObj(laserServerModel.LaserServerList[i].LocalName, laserServerModel.LaserServerList[i].LocalIP, laserServerModel.LaserServerList[i].LocalPort);
                            ;
                            if (flag)
                            {
                                laser.IsWarningOfReconn = true;
                            }

                            laser.Connect();
                        }
                        else if (!laser.Ping())
                        {
                            if (!laser.IsWarningOfReconn)
                            {
                                laser.IsWarningOfReconn = true;
                            }
                            laser.StopClient();
                            laser.IsConnected = false;
                        }
                        else
                        {
                            laser.IsWarningOfReconn = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error(string.Format("错误：laser【{0}】重连异常，原因：【{1}】", i + 1, ex));
                }
            }
        }
        #endregion
        #region 设备管理方法
        /// <summary>
        /// 添加设备（自动分类）
        /// </summary>
        public bool AddDevice(ClientObj device)
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
            device.StopClient();
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
                device.StopClient();
                _allDevices.Remove(device.DeviceId);
                _devicesByType[device.DeviceType].Remove(device);
                //Console.WriteLine($"移除设备成功：{device.DeviceName}（ID：{device.DeviceId}）");
            }
            return true;
        }

        /// <summary>
        /// 获取所有设备
        /// </summary>
        public List<ClientObj> GetAllDevice()
        {
            List<ClientObj> devices = new List<ClientObj>();
            foreach (ClientObj g in _allDevices.Values)
            {
                devices.Add(g);
            }
            return devices;
        }
        /// <summary>
        /// 获取设备（按DeviceId，无需关心索引）
        /// </summary>
        public T GetDevice<T>(string deviceId) where T : ClientObj
        {
            _allDevices.TryGetValue(deviceId, out var device);
            return device as T;
        }
        /// <summary>
        /// 获取指定类型的所有设备（如所有机器人）
        /// </summary>
        public List<T> GetDevicesByType<T>(eDeviceType deviceType) where T : ClientObj
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
                device.StartClient();
            }
        }

        /// <summary>
        /// 停止所有设备
        /// </summary>
        public void StopAllDevices()
        {
            foreach (var device in _allDevices.Values)
            {
                device.StopClient();
            }
        }
        #endregion
    }
}
