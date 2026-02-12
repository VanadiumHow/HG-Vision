using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Obj.Obj_File;
using HG_Vision.Manager.Manager_System;
using VisionProgram.UserControls.UILamp;
using HG_Vision.Contol.Control_Socket;
using Model.EnumModel;
using Sunny.UI.Win32;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIHome.RightForm
{
    /// <summary>
    /// 硬件状态显示窗体
    /// </summary>
    public partial class FrmHardWareState : Form
    {
        /// <summary>
        /// 所有设备的指示灯，如有增加可继续创建对应设备的指示灯
        /// </summary>
        private List<LampEX> _plcLights = new List<LampEX>();
        private List<LampEX> _ccdLights = new List<LampEX>();
        private List<LampEX> _robotLights = new List<LampEX>();
        private List<LampEX> _laserLights = new List<LampEX>();

        internal int ColumnCount = 10;//列数
        internal int RowCount = 1;//行数
        internal int LampDiameter = 32;//灯直径


        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmHardWareState()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        //加载窗体(动态根据硬件数量渲染指示灯)
        private void FrmHardWareState_Load(object sender, EventArgs e)
        {
            //清空所有设备的指示灯集合
            _plcLights.Clear();
            _ccdLights.Clear();
            _robotLights.Clear();
            _laserLights.Clear();

            //设置行列
            TableLayoutPanelAll.ColumnCount = ColumnCount;
            TableLayoutPanelAll.RowCount = RowCount;

            #region 这部分代码采用从右往左创建，目的是控件居右排列（后续可优化表达）
            int _currentnum = Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser).Count;
            LoadLabelLight(0, ColumnCount - _currentnum * 2, _currentnum, "Laser"); //1
            int _deviceCount = _currentnum;

            //特殊情况，有机械手对象，但仅标定时才会连接，故此处不予显示
            if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType != eProtocol.HG.ToString())
            {
                _currentnum = Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot).Count;
                LoadLabelLight(0, ColumnCount - _deviceCount * 2 - _currentnum * 2, _currentnum, "Robot"); //2
                _deviceCount += _currentnum;
            }

            _currentnum = Project.Instance.VisionManagerInstance.CameraNum;
            LoadLabelLight(0, ColumnCount - _deviceCount * 2 - _currentnum * 2, _currentnum, "CCD"); //1
            _deviceCount += _currentnum;

            if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
                _currentnum = Project.Instance.PLCManagerInstance.PLCNum;
            else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
                _currentnum = Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC).Count;
            else
                _currentnum = 0;
            LoadLabelLight(0, ColumnCount - _deviceCount * 2 - _currentnum * 2, _currentnum, "PLC"); //1
            _deviceCount = _currentnum;
            #endregion
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmHardWareState _instance;
        public static FrmHardWareState Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmHardWareState();
                return _instance;
            }
        }
        #region 加载Label和指示灯

        /// <summary>
        /// 加载指示灯和标签（PLC/CCD/Robot/Laser排版）
        /// </summary>
        /// <param name="row">第几行</param>
        /// <param name="col">第几列</param>
        /// <param name="num">个数</param>
        /// <param name="str">文本</param>
        private void LoadLabelLight(int row, int col, int num, string str)
        {
            for (int i = 0; i < num; i++)
            {
                Panel p = new Panel();
                Label lbl = new Label();
                LampEX lamp = new LampEX();
                p.Dock = DockStyle.Fill;
                p.Margin = new Padding(7, 0, 0, 0);
                p.BackColor = Color.Transparent;
                if (str == "PLC")
                {
                    p.Name = $"uiPanel{str}";
                    p.Controls.Add(CreateUILabel(lbl, $"uiLbl{str}", str));
                    TableLayoutPanelAll.Controls.Add(p, col + 2 * i, row);
                    lamp = CreateUILight(lamp, $"uiLig{str}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + 2 * i + 1, row);
                }
                else if (str == "CCD")
                {
                    p.Name = $"uiPanel{"CCD" + 1}";
                    p.Controls.Add(CreateUILabel(lbl, $"uiLblCCD{i + 1}", "相机"));
                    TableLayoutPanelAll.Controls.Add(p, col + 2 * i, row);
                    lamp = CreateUILight(lamp, $"uiLig{str}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + 2 * i + 1, row);
                }
                else if (str == "Robot")
                {
                    p.Name = $"uiPanel{str + 1}";
                    p.Controls.Add(CreateUILabel(lbl, $"uiLbl{str}{i + 1}", $"机械手{i + 1}"));
                    TableLayoutPanelAll.Controls.Add(p, col + 2 * i, row);
                    lamp = CreateUILight(lamp, $"uiLig{str}{i + 1}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + 2 * i + 1, row);
                }
                else if (str == "Laser")
                {
                    p.Name = $"uiPanel{str + 1}";
                    p.Controls.Add(CreateUILabel(lbl, $"uiLblLaser{str}{i + 1}", $"激光{i + 1}"));
                    TableLayoutPanelAll.Controls.Add(p, col + 2 * i, row);
                    lamp = CreateUILight(lamp, $"uiLig{str}{i + 1}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + 2 * i + 1, row);
                }
                lamp.LedStatus = VisionProgram.UserControls.Datas.Status.ERR;//初始化后将灯色设置为红色，表示未连接状态
                switch (str)
                {
                    case "PLC":
                        _plcLights.Add(lamp);
                        break;
                    case "CCD":
                        _ccdLights.Add(lamp);
                        break;
                    case "Robot":
                        _robotLights.Add(lamp);
                        break;
                    case "Laser":
                        _laserLights.Add(lamp);
                        break;
                }
            }
        }

        private Label CreateUILabel(Label lbl, string name, string text)
        {
            lbl.Font = new Font("微软雅黑", 10.5F, FontStyle.Bold);
            lbl.ForeColor = Color.White;
            lbl.AutoSize = false;
            lbl.BackColor = Color.Transparent;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleRight;
            lbl.Location = new Point(1, 0);
            lbl.Name = name;
            lbl.Size = new Size(1, 1);
            lbl.TabIndex = 0;
            lbl.Text = text;
            return lbl;
        }

        private LampEX CreateUILight(LampEX lig, string str)
        {
            lig.Anchor = AnchorStyles.None;
            lig.MinimumSize = new Size(1, 1);
            lig.Name = str;
            lig.Size = new Size(LampDiameter, LampDiameter);
            lig.LedStatus = VisionProgram.UserControls.Datas.Status.None;
            lig.TabIndex = 0;
            lig.IsBorder = false;
            lig.IsFlash = false;
            lig.IsHighLight = true;
            return lig;
        }
        #endregion
        #region 刷新各种灯

        /// <summary>
        /// 定时刷新控件显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshHardWareStateDisplay()
        {
            if (this.IsHandleCreated)
            {
                try
                {
                    //1.PLC指示刷新
                    {
                        RefreshLight_PLC();
                    }
                    //2.CCD指示刷新
                    {
                        RefreshLight_CCD();
                    }
                    //3.Robot指示刷新
                    {
                        RefreshLight_Robot();
                    }
                    //3.Laser指示刷新
                    {
                        RefreshLight_Laser();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("定时任务刷新设备状态出现异常", ex);
                }
            }
            else
            {
                LogHelper.Error("FrmHardWareState窗体句柄未创建，无法刷新硬件状态显示");
            }
        }

        private void RefreshLight_PLC()
        {
            try
            {
                int nPLCNum;
                if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
                    nPLCNum = Project.Instance.PLCManagerInstance.PLCNum;
                else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
                    nPLCNum = Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC).Count;
                else
                    nPLCNum = 0;

                for (int i = 0; i < Math.Min(nPLCNum, _plcLights.Count); i++)
                {
                    if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.Fins_TCP.ToString())
                    {
                        //未连接
                        if (!Project.Instance.PLCManagerInstance._isPLCConnect)
                        {
                            if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                            {
                                _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                            }
                        }
                        //已连接 根据握手信号闪烁
                        else
                        {
                            if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            {
                                _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                            }
                        }
                    }
                    else if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement == ePLCAgreement.TCP.ToString())
                    {
                        //未连接
                        if (!Project.Instance.ClientManagerInstance.GetDevicesByType<PLCClientObj>(eDeviceType.PLC)[i].IsConnected)
                        {
                            if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                            {
                                _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                            }
                        }
                        //已连接 根据握手信号闪烁
                        else
                        {
                            if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            {
                                _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新PLC设备状态出现异常", ex);
            }
        }
        /// <summary>
        /// 刷新CCD连接的灯
        /// </summary>
        private void RefreshLight_CCD()
        {
            try
            {
                int nCCDNum = Project.Instance.VisionManagerInstance.CameraNum;
                for (int i = 0; i < Math.Min(nCCDNum, _ccdLights.Count); i++)
                {
                    if (!Project.Instance.HardWareStateManagerInstance.L_ccdState[i])
                    {
                        Project.Instance.HardWareStateManagerInstance.L_ccdState[i] = Project.Instance.VisionManagerInstance.CameraManagerInstance.WorkFlowList[i].connected();
                        //只有未在当前状态才切换状态
                        if (_ccdLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                            _ccdLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                    }
                    else
                    {
                        //只有未在当前状态才切换状态
                        if (_ccdLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            _ccdLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新CCD设备状态出现异常", ex);
            }
        }

        /// <summary>
        /// 刷新Robot连接的灯
        /// </summary>
        private void RefreshLight_Robot()
        {
            try
            {
                int nRobotNum = Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot).Count;
                for (int i = 0; i < Math.Min(nRobotNum, _robotLights.Count); i++)
                {
                    if (!Project.Instance.ServerManagerInstance.GetDevicesByType<RobotServerObj>(eDeviceType.Robot)[i].IsConnected)
                    {
                        //只有未在当前状态才切换状态
                        if (_robotLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                            _robotLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                    }
                    else
                    {
                        //只有未在当前状态才切换状态
                        if (_robotLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            _robotLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新ROBOT设备状态出现异常", ex);
            }
        }
        /// <summary>
        /// 刷新Laser连接的灯
        /// </summary>
        private void RefreshLight_Laser()
        {
            try
            {
                int nLaserNum = Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser).Count;
                for (int i = 0; i < Math.Min(nLaserNum, _laserLights.Count); i++)
                {
                    if (Project.Instance.ServerManagerInstance.GetDevicesByType<LaserServerObj>(eDeviceType.Laser)[i].IsConnected)
                    {
                        //只有未在当前状态才切换状态
                        if (_laserLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            _laserLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                    }
                    else
                    {
                        //只有未在当前状态才切换状态
                        if (_laserLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                            _laserLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新ROBOT设备状态出现异常", ex);
            }
        }
        #endregion
    }
}
