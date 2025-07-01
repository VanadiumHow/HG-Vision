using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Model.ConstantModel;
using Obj.Obj_File;
using HG_Vision.Contol.Control_Robot;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Robot
{
    public class RobotManager
    {
        /// <summary>
        /// Robot配置类
        /// </summary>
        private RobotSeverConfiguration _robotConfiguration = new RobotSeverConfiguration();
        public RobotSeverConfiguration RobotConfiguration
        {
            get
            {
                return _robotConfiguration;
            }
        }
        /// <summary>
        /// 机器人数量
        /// </summary>
        public int RobotNum
        {
            get { return Project.Instance.GlobalManagerInstance.GlobalParamModel.RobotNum; }
        }
        /// <summary>
        /// 机器人对象集合
        /// </summary>
        public List<RobotObj> L_Robot = new List<RobotObj>();
        /// <summary>
        /// 服务器对象
        /// </summary>


        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            try
            {
                //释放机器人
                for (int i = 0; i < L_Robot.Count; i++)
                {
                    if (L_Robot[i] != null)
                    {
                        L_Robot[i].StopServer();
                    }
                }
                L_Robot.Clear();

                for (int i = 0; i < RobotNum; i++)
                {
                    if (i == 0)
                    {
                        RobotConfiguration.AnalysisRobotInfoConfig(FilePathModel.RobotCommPath1);
                    }


                    if (int.Parse(RobotConfiguration.A_RobotInfo.LocalPort) < 65536)
                    {
                        if (i == 0)
                        {
                            RobotObj RobotObj = new RobotObj(new IPEndPoint(IPAddress.Parse(RobotConfiguration.A_RobotInfo.LocalIP), int.Parse(RobotConfiguration.A_RobotInfo.LocalPort)));//创建地址集);
                            L_Robot.Add(RobotObj);

                        }
                        else if (i == 1)
                        {
                            RobotObj RobotObj = new RobotObj(new IPEndPoint(IPAddress.Parse(RobotConfiguration.A_RobotInfo.LocalIP1), int.Parse(RobotConfiguration.A_RobotInfo.LocalPort1)));//创建地址集);
                            L_Robot.Add(RobotObj);

                        }
                        else if (i == 2)
                        {
                            RobotObj RobotObj = new RobotObj(new IPEndPoint(IPAddress.Parse(RobotConfiguration.A_RobotInfo.LocalIP2), int.Parse(RobotConfiguration.A_RobotInfo.LocalPort2)));//创建地址集);
                            L_Robot.Add(RobotObj);
                            RobotObj.InitCameraWorkThreads1();
                        }
                        else if (i == 3)
                        {
                            RobotObj RobotObj = new RobotObj(new IPEndPoint(IPAddress.Parse(RobotConfiguration.A_RobotInfo.LocalIP3), int.Parse(RobotConfiguration.A_RobotInfo.LocalPort3)));//创建地址集);
                            L_Robot.Add(RobotObj);
                        }
                        L_Robot[i].StartServerRobot();

                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化Robot服务器失败：", ex);
            }
        }

        public string m_strRobot1Receive = "";
        public string m_strRobot2Receive = "";
        public string m_strLaserReceive = "";
        public string m_strLaserReceiveTragger = "";
        public string m_strLaserReceiveX = "0";
        public string m_strLaserReceiveY = "0";
        public bool m_Stop = false;
        public bool WaitStringN(string strDes, int nSeconds)
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

                if (Project.Instance.RobotManagerInstance.m_strRobot1Receive.CompareTo(strDes) == 0)
                {
                    Project.Instance.RobotManagerInstance.m_strRobot1Receive = "";
                    return true;
                }


                Thread.Sleep(10);
                ts = DateTime.Now - nStart;
                nElipseSecond = Convert.ToInt16(ts.Seconds);
            }
            return false;
        }
        public bool WaitStringP(string strDes, int nSeconds)
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

                if (Project.Instance.RobotManagerInstance.m_strRobot2Receive.CompareTo(strDes) == 0)
                {
                    Project.Instance.RobotManagerInstance.m_strRobot2Receive = "";
                    return true;
                }
                Thread.Sleep(10);
                ts = DateTime.Now - nStart;
                nElipseSecond = Convert.ToInt16(ts.Seconds);
            }
            return false;
        }

        public bool WaitStringL(string strDes, int nSeconds)
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

                if (Project.Instance.RobotManagerInstance.m_strLaserReceive.CompareTo(strDes) == 0)
                {
                    Project.Instance.RobotManagerInstance.m_strLaserReceive = "";
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
    }
}
