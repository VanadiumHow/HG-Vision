using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;

namespace VisionProgram.UI.UIHome.RightForm
{

    /****************************************************************
    
    *****************************************************************/
    public partial class FrmPLCMessage : Form
    {
        private bool[] _isAutoRollFlagArray = new bool[Project.Instance().PLCManagerInstance.PLCNum];//dataGridview控件滚动到最新数据行
        //PLC展示信息数组
        private DataGridView[] _dataGridViewArray = new DataGridView[Project.Instance().PLCManagerInstance.PLCNum];
        private List<ToolStripButton> _toolStripButtonArray = new List<ToolStripButton>();
        //展示信息委托
        private delegate void UpdateControls(string msg, int plcIndex, string time, bool isOK = true);
        private UpdateControls _upd = null;

        internal Action<int> OnClearMessageEvent;

        private bool _inited = false;

        #region 构造 单例
        /// <summary>
        /// 私有构造器
        /// </summary>
        private FrmPLCMessage()
        {
            _inited = true;
            InitializeComponent();
            if (!NoticeHelper.IsOnPLCMessageRecievedRelatedMethod("PLCMessageReceived"))
                NoticeHelper.OnPLCMessageRecieved += PLCMessageReceived;

            _upd = new UpdateControls(UpdateShowMessage);
            InitData();
            InitControl();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab        
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmPLCMessage _instance;
        public static FrmPLCMessage Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new FrmPLCMessage();
                }
                return _instance;
            }
        }

        #endregion   

        #region 初始化渲染
        private void InitData()
        {
            for (int i = 0; i < _isAutoRollFlagArray.Length; i++)
                _isAutoRollFlagArray[i] = true;
        }

        private void InitControl()
        {
            //先加载默认的一个PLC的ListView
            _dataGridViewArray[0] = this.DataGridViewMessage;

            this.停止滚动PLC1ToolStripMenuItem.Click += (o, e) => { 停止滚动PLCToolStripMenuItem_Click(停止滚动PLC1ToolStripMenuItem, new MyEventArgs(0)); };
            清屏PLC1ToolStripMenuItem.Click += (o, e) => { 清屏PLCToolStripMenuItem_Click(this, new MyEventArgs(0)); };
            ToolStripButton1.Click += (o, e) => { SwitchDataGridView_Click(this, new MyEventArgs(new string[] { "0", ToolStripButton1.Name })); };
            _toolStripButtonArray.Clear();
            _toolStripButtonArray.Add(ToolStripButton1);
            ToolStripButton1.PerformClick();

            InitAllMessageDataGridView();
            for (int i = 0; i < _dataGridViewArray.Length; i++)
                InitDataGridView(_dataGridViewArray[i]);
        }


        /// <summary>
        /// 根据PLC的个数把DataGridView动态渲染出来
        /// </summary>
        private void InitAllMessageDataGridView()
        {
            for (int i = 1; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                //注意直接在匿名回调方法中或者lambda表达式中使用循环体中的增值变量i，得到的外部的值
                //因为C#后台在回调方法执行之前就提前存储了该回调方法使用的外部变量
                int index = i;

                ToolStripButton tsButton = new ToolStripButton();
                tsButton.CheckOnClick = this.ToolStripButton1.CheckOnClick;
                tsButton.BackColor = Color.Transparent;
                tsButton.DisplayStyle = this.ToolStripButton1.DisplayStyle;
                tsButton.AutoSize = false;
                tsButton.ForeColor = this.ToolStripButton1.ForeColor;
                tsButton.ImageTransparentColor = this.ToolStripButton1.ImageTransparentColor;
                tsButton.Size = ToolStripButton1.Size;
                tsButton.Name = $"ToolStripButton{i + 1}";
                tsButton.Text = $"PLC{i + 1}";
                tsButton.Font = ToolStripButton1.Font;
                tsButton.Margin = this.ToolStripButton1.Margin;
                tsButton.Click += (o, e) => { SwitchDataGridView_Click(this, new MyEventArgs(new string[] { index + "", tsButton.Name })); };
                this.ToolStrip1.Items.Add(tsButton);
                _toolStripButtonArray.Add(tsButton);

                ToolStripLabel tsLabel = new ToolStripLabel();
                tsLabel.Name = $"toolStripLabel{i + 1}";
                tsLabel.Size = toolStripLabel1.Size;
                tsLabel.Text = toolStripLabel1.Text;
                this.ToolStrip1.Items.Add(tsLabel);

                //创建DataGridView
                DataGridView dgView = new DataGridView();
                dgView.Text = "";
                dgView.Name = $"DataGridViewMessage{i + 1}";
                dgView.Dock = DockStyle.Fill;
                dgView.AllowUserToAddRows = DataGridViewMessage.AllowUserToAddRows;
                dgView.BorderStyle = DataGridViewMessage.BorderStyle;
                dgView.AllowUserToDeleteRows = DataGridViewMessage.AllowUserToDeleteRows;
                dgView.BackgroundColor = DataGridViewMessage.BackgroundColor;

                dgView.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                dgView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                dgView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 13.8F);
                dgView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
                dgView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dgView.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                dgView.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

                dgView.ColumnHeadersBorderStyle = DataGridViewMessage.ColumnHeadersBorderStyle;
                dgView.ColumnHeadersHeight = DataGridViewMessage.ColumnHeadersHeight;
                dgView.ColumnHeadersHeightSizeMode = DataGridViewMessage.ColumnHeadersHeightSizeMode;
                dgView.EnableHeadersVisualStyles = DataGridViewMessage.EnableHeadersVisualStyles;
                dgView.DefaultCellStyle = this.DataGridViewMessage.DefaultCellStyle;
                dgView.GridColor = DataGridViewMessage.GridColor;
                dgView.Font = DataGridViewMessage.Font;
                dgView.Location = DataGridViewMessage.Location;
                dgView.ReadOnly = DataGridViewMessage.ReadOnly;
                dgView.RowTemplate.Height = DataGridViewMessage.RowTemplate.Height;
                dgView.Size = DataGridViewMessage.Size;
                dgView.Margin = this.DataGridViewMessage.Margin;

                DataGridViewTextBoxColumn ColTime = new DataGridViewTextBoxColumn();
                ColTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                ColTime.DefaultCellStyle = this.DataGridViewTextBoxColumnTime1.DefaultCellStyle;
                ColTime.Frozen = true;
                ColTime.HeaderText = "时间";
                ColTime.Name = $"DataGridViewTextBoxColumnTime{i + 1}";
                ColTime.ReadOnly = true;
                ColTime.Width = this.DataGridViewTextBoxColumnTime1.Width;

                DataGridViewTextBoxColumn ColInfo = new DataGridViewTextBoxColumn();
                ColInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                ColInfo.DefaultCellStyle = this.DataGridViewTextBoxColumnInfo1.DefaultCellStyle;
                ColInfo.HeaderText = "信息";
                ColInfo.Name = $"DataGridViewTextBoxColumnInfo{i + 1}";
                ColInfo.ReadOnly = true;

                dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColTime, ColInfo });
                dgView.RowHeadersVisible = false;
                dgView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                _dataGridViewArray[i] = dgView;
            }

            this.ContextMenuStrip1.Items.Add(this.停止滚动PLC1ToolStripMenuItem);
            for (int i = 1; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                int index = i;
                ToolStripMenuItem tsmItem1 = new ToolStripMenuItem();
                tsmItem1.Name = $"停止滚动PLC{i + 1}ToolStripMenuItem";
                tsmItem1.Size = this.停止滚动PLC1ToolStripMenuItem.Size;
                tsmItem1.Text = $"停止滚动PLC{i + 1}";
                tsmItem1.Click += (o, e) => { 停止滚动PLCToolStripMenuItem_Click(tsmItem1, new MyEventArgs(index)); };
                this.ContextMenuStrip1.Items.Add(tsmItem1);
            }
            this.ContextMenuStrip1.Items.Add(this.清屏PLC1ToolStripMenuItem);
            for (int i = 1; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                int index = i;
                ToolStripMenuItem tsmItem2 = new ToolStripMenuItem();
                tsmItem2.Name = $"清屏PLC{i + 1}ToolStripMenuItem";
                tsmItem2.Size = this.清屏PLC1ToolStripMenuItem.Size;
                tsmItem2.Text = $"清屏PLC{i + 1}";
                tsmItem2.Click += (o, e) => { 清屏PLCToolStripMenuItem_Click(this, new MyEventArgs(index)); };
                this.ContextMenuStrip1.Items.Add(tsmItem2);
            }

            this.ContextMenuStrip1.Items.Add(this.关闭ToolStripMenuItem);
        }

        public void InitDataGridView(DataGridView DGV)
        {
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV.RowHeadersVisible = false;
            DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//不能用鼠标调整列标头宽度 
            DGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列标题居中显示
            DGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;//单元格内容居中显示  //行为
            DGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            DGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGV.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            DGV.AutoGenerateColumns = false;//不自动创建列
            DGV.AllowUserToAddRows = false;//不启用添加 
            DGV.ReadOnly = true;//只读
            DGV.AllowUserToDeleteRows = false;//不启用删除
            DGV.SelectionMode = DataGridViewSelectionMode.CellSelect;//单击单元格选中单个  
            DGV.MultiSelect = true;//不能多选 
            DGV.AllowUserToResizeRows = false;
        }

        #endregion

        #region 显示信息方法

        public void PLCMessageReceived(string msg, int i, string time, bool isOK = true)
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(_upd, msg, i, time, isOK);
            }
        }

        /// <summary>
        /// 更新面板显示信息
        /// </summary>
        /// <param name="strData"></param>
        /// <param name="i"></param>
        /// <param name="isOK"></param>
        public void UpdateShowMessage(string data, int plcIndex, string time, bool isOK = true)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrWhiteSpace(data))
                return;

            if (this.IsHandleCreated)
            {
                int index = _dataGridViewArray[plcIndex].Rows.Add();//默认添加数字类型
                _dataGridViewArray[plcIndex].Rows[index].Cells[0].Value = time;
                _dataGridViewArray[plcIndex].Rows[index].Cells[1].Value = data;
                if (!isOK)
                {
                    _dataGridViewArray[plcIndex].Rows[index].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
                }
                if (_dataGridViewArray[plcIndex].Rows.Count > Project.Instance().GlobalManagerInstance.GlobalParamModel.InteractionInfoMaxLines)
                    _dataGridViewArray[plcIndex].Rows.RemoveAt(0);
                if (_isAutoRollFlagArray[plcIndex])
                {
                    _dataGridViewArray[plcIndex].CurrentCell = _dataGridViewArray[plcIndex].Rows[_dataGridViewArray[plcIndex].RowCount - 1].Cells[0];
                }
            }
        }

        #endregion 

        #region 方法
        /// <summary>
        /// 点击切换DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchDataGridView_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            string[] data = (String[])args.obj;
            this.PanelData.Controls.Clear();
            for (int i = 0; i < this.ToolStrip1.Items.Count; i++)
            {
                if (this.ToolStrip1.Items[i].Name != data[1])
                    this.ToolStrip1.Items[i].BackColor = Color.Transparent;
                else
                    this.ToolStrip1.Items[i].BackColor = Color.CadetBlue;
            }
            this.PanelData.Controls.Add(_dataGridViewArray[Convert.ToInt32(data[0])]);
        }

        private void 停止滚动PLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            int index = (int)args.obj;
            ToolStripMenuItem tsmItem = (ToolStripMenuItem)sender;
            if (_isAutoRollFlagArray[index])
            {
                tsmItem.Text = $"自动滚动PLC{index + 1}";
                _isAutoRollFlagArray[index] = false;
            }
            else
            {
                tsmItem.Text = $"停止滚动PLC{index + 1}";
                _dataGridViewArray[index].CurrentCell = _dataGridViewArray[index].Rows[_dataGridViewArray[index].RowCount - 1].Cells[0];
                _isAutoRollFlagArray[index] = true;
            }
        }

        private void 清屏PLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            int index = (int)args.obj;
            OnClearMessageEvent?.Invoke(index);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        internal void ClearInfo(int index)
        {
            _dataGridViewArray[index].Rows.Clear();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmPLCMessage_Deactivate(object sender, EventArgs e)
        {
            if (_inited)
                _inited = !_inited;
            else
                this.Hide();
        }

        //拦截操作系统提供的关闭
        private void FrmPLCMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void FrmPLCMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        internal void SetPLCMessageFormLocation()
        {
            //防止上次关闭前移动窗体，强制每次打开窗体都居中
            FrmPLCMessage.Instance.StartPosition = FormStartPosition.Manual;
            int xW = SystemInformation.PrimaryMonitorSize.Width - FrmPLCMessage.Instance.Width;
            int yH = SystemInformation.PrimaryMonitorSize.Height - FrmPLCMessage.Instance.Height;
            FrmPLCMessage.Instance.Location = new Point(xW / 2, yH / 2 - 10);
        }
        #endregion

        #region 拖动窗体
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;





        #endregion


    }
}
