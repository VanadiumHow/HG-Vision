using System;
using System.Collections.Generic;
using System.Threading;
using Obj.Obj_File;
using HG_Vision.Contol.Control_Laser;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Laser
{
    public class LaserManager
    {

        private LaserClientConfiguration _LaserConfiguration = new LaserClientConfiguration();
        public LaserClientConfiguration LaserConfiguration
        {
            get
            {
                return _LaserConfiguration;
            }
        }
        public List<LaserObj> L_Laser = new List<LaserObj>();

        //用于镭射机通讯故障时显示的二维码
        public const string Error = "ERROR";
        //用于镭射机断开连接时显示的二维码
        public const string Disconnect = "DISCONNECT";

        public int LaserNum
        {
            get { return 1; }
        }
        public void Initial()
        {
            try
            {
                //释放
                for (int i = 0; i < L_Laser.Count; i++)
                {
                    if (L_Laser[i] != null)
                    {
                        L_Laser[i].Close();
                    }
                }
                L_Laser.Clear();
                LaserConfiguration.AnalysisLaserInfoConfig(LaserNum);
                for (int i = 0; i < LaserNum; i++)
                {
                    LaserObj LaserObj = new LaserObj(i + 1, LaserConfiguration.A_LaserInfo[i].LocalIP, int.Parse(LaserConfiguration.A_LaserInfo[i].LocalPort));//创建地址集);
                    L_Laser.Add(LaserObj);
                    L_Laser[i].StartClientLaser();
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Laser客户端失败：", ex);
            }
        }

        public string m_strLaser1Receive = "";

        public bool m_Stop = false;
        public bool WaitString(string strDes, int nSeconds)
        {
            DateTime nStart = DateTime.Now;
            TimeSpan ts; ;
            int nElipseSecond = 0;
            while (nSeconds == -1 || nElipseSecond <= nSeconds)
            {
                if (m_Stop)
                {
                    return false;
                }
                if (Project.Instance.LaserManagerInstance.m_strLaser1Receive.CompareTo(strDes) == 0)
                {
                    Project.Instance.LaserManagerInstance.m_strLaser1Receive = "";
                    return true;
                }
                Thread.Sleep(10);
                ts = DateTime.Now - nStart;
                nElipseSecond = Convert.ToInt16(ts.Seconds);
            }
            return false;
        }
        public void SetStop(bool bStop)
        {
            m_Stop = bStop;
        }

        #region 重连镭射机
        /// <summary>
        /// 重连镭射机
        /// </summary>
        public void LaserReConnect()
        {

            for (int i = 0; i < LaserNum; i++)
            {
                try
                {
                    L_Laser[i].IsConnectedLaser = Project.Instance.LaserManagerInstance.L_Laser[0].SendText("?");
                    if (L_Laser[i] != null)
                    {
                        bool flag = false;
                        if (!L_Laser[i].IsConnectedLaser)
                        {
                            flag = L_Laser[i].IsWarningOfReconn;
                            if (!flag)
                            {
                                flag = true;
                            }
                            if (null != L_Laser[i]) L_Laser[i].Close();
                            L_Laser[i] = new LaserObj(i + 1, _LaserConfiguration.A_LaserInfo[i].LocalIP, Convert.ToInt16(_LaserConfiguration.A_LaserInfo[i].LocalPort));
                            if (flag)
                            {
                                L_Laser[i].IsWarningOfReconn = true;
                            }

                            L_Laser[i].Connect();
                        }
                        else if (!L_Laser[i].Ping())
                        {
                            if (!L_Laser[i].IsWarningOfReconn)
                            {
                                L_Laser[i].IsWarningOfReconn = true;
                            }
                            L_Laser[i].Close();
                            L_Laser[i].IsConnectedLaser = false;
                        }
                        else
                        {
                            L_Laser[i].IsWarningOfReconn = false;
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
    }
}
