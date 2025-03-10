using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Main.ProjectClass;
using VisionProgram.UI.UIHome;
using VisionProgram.Common;
using VisionProgram.UserControls.UILamp;

/****************************************************************

*****************************************************************/

namespace VisionProgram.UI.UIHome.RightForm
{
    public partial class FrmHardWareState : Form
    {
        /// <summary>
        /// 所有设备的指示灯，如有增加可继续创建对应设备的指示灯
        /// </summary>
        private List<LampEX> _sqlLights = new List<LampEX>();
        private List<LampEX> _plcLights = new List<LampEX>();
        private List<LampEX> _ccdLights = new List<LampEX>();
        private List<LampEX> _robotLights = new List<LampEX>();
        internal int ColumnCount = 12;//默认9，无需改变
        internal int RowCount;//行数
        internal int LampWidth = 32;


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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

        /// <summary>
        /// Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHardWareState_Load(object sender, EventArgs e)
        {
            //动态根据硬件数量渲染指示灯
            this.LoadSelf();
        }

        /// <summary>
        /// 动态根据硬件数量渲染指示灯
        /// </summary>
        private void LoadSelf()
        {
            //清空所有设备的指示灯集合
            _sqlLights.Clear();
            _plcLights.Clear();
            _ccdLights.Clear();
            _robotLights.Clear();

            //计算tabLayOutPanel的行列以及父控件的高度，实现动态排版
            int deviceCount = Project.Instance().VisionManagerInstance.CameraNum;//非SQL及PLC的设备数量,如有新设备可继续相加

            RowCount = 1;// + (deviceCount % ColumnCount == 0 ? deviceCount / ColumnCount : deviceCount / ColumnCount + 1) * 2;//计算行数
            TableLayoutPanelAll.ColumnCount = ColumnCount;//设置行列
            TableLayoutPanelAll.RowCount = RowCount;
            //渲染指示灯
            //默认SQL和PLC的指示灯在一行，其他设备另起一行，排列一起
            //LoadLabelLight(0, 0, Project.Instance().SqlInfoManagerInstance.SqlNum, "SQL");
            LoadLabelLight(0, 0, Project.Instance().PLCManagerInstance.PLCNum, "PLC");
            //LoadLabelLight(0, Project.Instance().SqlInfoManagerInstance.SqlNum + Project.Instance().PLCManagerInstance.PLCNum, Project.Instance().RobotManagerInstance.RobotNum, "BOT");
            LoadLabelLight(0, 2*Project.Instance().PLCManagerInstance.PLCNum, Project.Instance().RobotManagerInstance.RobotNum, "BOT");
            LoadLabelLight(0,2* Project.Instance().RobotManagerInstance.RobotNum+ 2 * Project.Instance().PLCManagerInstance.PLCNum, Project.Instance().VisionManagerInstance.CameraNum, "CCD");

            //if (deviceCount > 0)
            //{
            //    List<Label> labs = new List<Label>();
            //    List<LampEX> lights = new List<LampEX>();
            //    LoadLabelLights(deviceCount, ref labs, ref lights);
            //    UpdateLabelLight(labs, lights, 0, Project.Instance().VisionManagerInstance.CameraNum, "CCD");
            //}
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

        /// <summary>
        /// SQL/PLC/ROBOT排版
        /// </summary>
        /// <param name="row">第几行</param>
        /// <param name="col">第几列</param>
        /// <param name="num">个数</param>
        /// <param name="str">文本</param>
        private void LoadLabelLight(int row, int col, int num, string str)
        {
            Label lbl = null; LampEX lamp = null; Panel p = null;
            for (int i = 0; i < num; i++)
            {
                int index = i + 1;
                if (str == "BOT" && i == 2)
                {
                    p = new Panel();
                    p.Dock = DockStyle.Fill;
                    p.Name = $"uiPanel{"LSR" + 1}";
                    p.BackColor = Color.Transparent;
                    p.Controls.Add(CreateUILabel(lbl, $"uiLbl{"LAS" + 1}"));
                    TableLayoutPanelAll.Controls.Add(p, col + i, row);
                    lamp = CreateUILight(lamp, $"uiLig{"LASER" + 1}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + i, row);
                }
                else if (str == "BOT" && i == 3)
                {
                    p = new Panel();
                    p.Dock = DockStyle.Fill;
                    p.Name = $"uiPanel{"LSR" + 1}";
                    p.BackColor = Color.Transparent;
                    p.Controls.Add(CreateUILabel(lbl, $"uiLbl{"LAS" + 2}"));
                    TableLayoutPanelAll.Controls.Add(p, col + i, row);
                    lamp = CreateUILight(lamp, $"uiLig{"LASER" + 2}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + i, row);
                }

                else
                {
                    p = new Panel();
                    p.Dock = DockStyle.Fill;
                    p.Name = $"uiPanel{str + index}";
                    p.BackColor = Color.Transparent;
                    p.Controls.Add(CreateUILabel(lbl, $"uiLbl{str + index}"));
                    TableLayoutPanelAll.Controls.Add(p, col + i, row);
                    lamp = CreateUILight(lamp, $"uiLig{str + index}");
                    TableLayoutPanelAll.Controls.Add(lamp, col + i, row);

                }
               
               
              
                switch (str)
                {
                    case "SQL":
                        _sqlLights.Add(lamp);
                        break;
                    case "PLC":
                        _plcLights.Add(lamp);
                        break;
                    case "BOT":
                        _robotLights.Add(lamp);
                        break;
                    case "CCD":
                        _ccdLights.Add(lamp);
                        break;
                    default:
                        break;
                }
            }
        }

        private void LoadLabelLights(int num, ref List<Label> labs, ref List<LampEX> lights)
        {
            Label lbl = null; LampEX lamp = null; Panel p = null;
            for (int i = 0; i < num; i++)
            {
                int index = i + 1;
                lbl = CreateUILabel(lbl, $"uiLblTest{index}");
                p = new Panel();
                p.Dock = DockStyle.Fill;
                p.Name = $"uiPanelTest{index}";
                p.BackColor = Color.Transparent; ;
                p.Controls.Add(lbl);
                TableLayoutPanelAll.Controls.Add(p, i % ColumnCount, 2 + (i / 10 * 2));
                lamp = CreateUILight(lamp, $"uiLigTest{index}");
                TableLayoutPanelAll.Controls.Add(lamp, i % ColumnCount, 3 + (i / 10 * 2));
                labs.Add(lbl);
                lights.Add(lamp);
            }
        }

        private void UpdateLabelLight(List<Label> labs, List<LampEX> lights, int start, int num, string str)
        {
            int index = 0;
            for (int i = start; i < start + num; i++)
            {
                index++;
                switch (str)
                {
                    case "CCD":
                        UpdateUILabel(labs[i], $"uiLbl{str + index}", $"相机{index}");
                        _ccdLights.Add(UpdateUILight(lights[i], $"uiLig{str + index}"));
                        this.toolTip1.SetToolTip(lights[i], Project.Instance().VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[index - 1].ImageWindowName);
                        this.toolTip1.SetToolTip(labs[i], Project.Instance().VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[index - 1].ImageWindowName);
                        break;
                    default:
                        break;
                }
            }
        }

        private Label CreateUILabel(Label lbl, string str)
        {
            lbl = new Label();
            lbl.Font = new System.Drawing.Font("微软雅黑", 8.5F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = Color.Black;
            lbl.AutoSize = false;
            lbl.BackColor = Color.Transparent;
            lbl.Dock = DockStyle.Fill;
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Location = new System.Drawing.Point(1, 0);
            lbl.Name = str;
            lbl.Size = new System.Drawing.Size(1, 1);
            lbl.TabIndex = 0;
            lbl.Text = str.Substring(5);
            return lbl;
        }

        private LampEX CreateUILight(LampEX lig, string str)
        {
            lig = new LampEX();
            lig.Anchor = System.Windows.Forms.AnchorStyles.None;
            lig.MinimumSize = new System.Drawing.Size(1, 1);
            lig.Name = str;
            lig.Size = new System.Drawing.Size(LampWidth, LampWidth);
            lig.LedStatus = VisionProgram.UserControls.Datas.Status.None;
            lig.TabIndex = 0;
            lig.IsBorder = false;
            lig.IsFlash = false;
            lig.IsHighLight = true;
            return lig;
        }


        private Label UpdateUILabel(Label lbl, string name, string text)
        {
            lbl.Name = name;
            lbl.Text = text;
            return lbl;
        }

        private LampEX UpdateUILight(LampEX lig, string name)
        {
            lig.Name = name;
            return lig;
        }




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
                        RefreshLight_PLC();//刷新PLC中的灯                  
                    }

                    //2.SQL指示刷新
                    {
                      //  RefreshLight_SQL();//刷新SQL的灯
                    }

                    //3.CCD指示刷新
                    {
                        RefreshLight_CCD();//刷新CCD连接的灯
                    }
                    //4.ROOT指示刷新
                    {
                        RefreshLight_ROBOT();
                    }
                }
                catch (Exception ex)
                {
                    LogHelper.Error("定时任务刷新设备状态出现异常", ex);
                }
            }
        }

        private void RefreshLight_PLC()
        {
            try
            {
                for (int i = 0; i < Project.Instance().PLCManagerInstance.L_PLCInfo.Count; i++)
                {
                    //未连接
                    if (!Project.Instance().PLCManagerInstance._isPLCConnect)
                    {
                        if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                        {
                            _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                        }
                    }
                    //已连接 根据握手信号闪烁
                    else
                    {
                        if (Project.Instance().PLCManagerInstance._isPLCConnect)
                        {//绿色
                            if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                            {
                                _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                            }
                        }
                        //else if (Project.Instance().PLCManagerInstance.L_basePLCObjects[i].PLCHand == 1)
                        //{//浅色
                        //    if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Close)
                        //    {
                        //        _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Close;
                        //    }
                        //}
                        //else if (Project.Instance().PLCManagerInstance.L_basePLCObjects[i].PLCHand == 2)
                        //{//绿色
                        //    if (_plcLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                        //    {
                        //        _plcLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                        //    }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新PLC设备状态出现异常", ex);
            }
        }


        /// <summary>
        /// 刷新SQL的灯
        /// </summary>
        private void RefreshLight_SQL()
        {
            try
            {
                for (int i = 0; i < Project.Instance().SqlInfoManagerInstance.SqlNum; i++)
                {
                    if (!Project.Instance().HardWareStateManagerInstance.L_sqlState[i])
                    {
                        //未连接
                        if (_sqlLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                        {
                            _sqlLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                        }
                    }
                    else
                    {
                        //防止频繁无效刷新连接状态
                        if (_sqlLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                        {
                            _sqlLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新数据库设备状态出现异常", ex);
            }
        }

        /// <summary>
        /// 刷新CCD连接的灯
        /// </summary>
        private void RefreshLight_CCD()
        {
            try
            {
                for (int i = 0; i < Project.Instance().VisionManagerInstance.CameraNum; i++)
                {
                    if (!Project.Instance().HardWareStateManagerInstance.L_ccdState[i])
                    {
                        Project.Instance().HardWareStateManagerInstance.L_ccdState[i] = Project.Instance().VisionManagerInstance.CameraManagerInstance.L_workFlowList[i].connected();
                        //未连接
                        if (_ccdLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR)
                        {
                            _ccdLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                        }
                    }
                    else
                    {
                        //防止频繁无效刷新连接状态
                        if (_ccdLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                        {
                            _ccdLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新CCD设备状态出现异常", ex);
            }
        }

        /// <summary>
        /// 刷新ROOT连接的灯
        /// </summary>
        private void RefreshLight_ROBOT()
        {
            try
            {
                int nRobotNum = Project.Instance().RobotManagerInstance.RobotNum;
                for (int i = 0; i < nRobotNum; i++)
                {
                    if (!Project.Instance().RobotManagerInstance.L_Robot[i].IsConnectedRobot[0])
                    {
                    //    Project.Instance().HardWareStateManagerInstance.L_robotState[i] = Project.Instance().RobotManagerInstance.L_Robot[i].IsConnectedRobot[0];
                        //未连接
                        if (_robotLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR && i !=3)
                        {
                            _robotLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.ERR;
                        }
                        if (_robotLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.ERR && i == 3)
                        {
                            _robotLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                        }
                    }
                    else
                    {
                    //    Project.Instance().HardWareStateManagerInstance.L_robotState[i] = Project.Instance().RobotManagerInstance.L_Robot[i].IsConnectedRobot[0];
                        //防止频繁无效刷新连接状态
                        if (_robotLights[i].LedStatus != VisionProgram.UserControls.Datas.Status.Open)
                        {
                            _robotLights[i].LedStatus = VisionProgram.UserControls.Datas.Status.Open;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("定时任务刷新ROBOT设备状态出现异常", ex);
            }
        }
        #endregion

        private void FrmHardWareState_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

    }
}
