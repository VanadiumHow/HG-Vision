using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UI.UISetting
{
    public partial class FrmPlcCommMonitor : Form
    {
        private List<TableLayoutPanel> _allSignalTablePanelList = new List<TableLayoutPanel>();//一个PLC对应一个TablePanel   
        private List<ToolStripButton> _toolStripButtonList = new List<ToolStripButton>();
        private List<DataGridView> _allDataGridViewList = new List<DataGridView>();//一个PLC对应一个DataGridView  展示全部
        private List<DataGridView> _checkDataGridViewList = new List<DataGridView>();//一个PLC对应一个DataGridView  展示勾选

        private List<List<string>> _singleMsgAllList = new List<List<string>>();//展示信号说明列表。
        private List<List<string>> _singleNameAllList = new List<List<string>>();//展示信号变量名列表。

        private List<List<string>> _singleMsgCheckList = new List<List<string>>();//展示勾选的信号说明列表。
        private List<List<string>> _singleNameCheckList = new List<List<string>>();//展示勾选的信号变量名列表。
        private List<List<string>> _singleDataCheckList = new List<List<string>>();//展示勾选的信号数据列表。

        internal bool IsFormOpen = false;
        private FrmPlcCommMonitor()
        {
            InitializeComponent();

            _singleMsgAllList.Clear();
            _singleNameAllList.Clear();
            _singleMsgCheckList.Clear();
            _singleNameCheckList.Clear();
            _singleDataCheckList.Clear();
            for (int i = 0; i < Project.Instance().PLCManagerInstance.L_PLCSignalInfoList.Count; i++)
            {
                _singleMsgAllList.Add(new List<string>());
                _singleNameAllList.Add(new List<string>());
                _singleMsgCheckList.Add(new List<string>());
                _singleNameCheckList.Add(new List<string>());
                _singleDataCheckList.Add(new List<string>());
                for (int k = 0; k < Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[i].Count; k++)
                {
                    _singleMsgAllList[i].Add(Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[i][k].Msg);
                    _singleNameAllList[i].Add(Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[i][k].Name);
                }
            }

            Project.Instance().ScheduledTaskManagerInstance.OnMonitorSignalExchange = MonitorSignalDataRefreshDisplay;

            this.InitControl();
            this.UpdateForm();
           
            ToolStripButton1.PerformClick();
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

        /// 窗体对象实例
        /// </summary>
        private static FrmPlcCommMonitor _instance;
        public static FrmPlcCommMonitor Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmPlcCommMonitor();
                return _instance;
            }
        }

        private void InitControl()
        {
            _allSignalTablePanelList.Clear();
            _toolStripButtonList.Clear();
            _allDataGridViewList.Clear();
            _checkDataGridViewList.Clear();

            _allSignalTablePanelList.Add(this.TableLayoutPanelPLC1All);
            _toolStripButtonList.Add(this.ToolStripButton1);
            _allDataGridViewList.Add(this.DataGridViewAllPLC1);
            _checkDataGridViewList.Add(this.DataGridViewCheckPLC1);
            
            //定义按钮事件
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                int index = i;
                if (index > 0)
                {
                    Button buttonMonitor = new Button();
                    buttonMonitor.BackColor = this.ButtonMonitorPLC1.BackColor;
                    buttonMonitor.Dock = this.ButtonMonitorPLC1.Dock;
                    buttonMonitor.FlatStyle = this.ButtonMonitorPLC1.FlatStyle;
                    buttonMonitor.Font = this.ButtonMonitorPLC1.Font;
                    buttonMonitor.ForeColor = this.ButtonMonitorPLC1.ForeColor;
                    buttonMonitor.Location = this.ButtonMonitorPLC1.Location;
                    buttonMonitor.Margin = this.ButtonMonitorPLC1.Margin;
                    buttonMonitor.Name = $"ButtonPLC{index + 1}";
                    buttonMonitor.Size = this.ButtonMonitorPLC1.Size;
                    buttonMonitor.Text = $"开始监听PLC{index + 1}";
                    buttonMonitor.UseVisualStyleBackColor = this.ButtonMonitorPLC1.UseVisualStyleBackColor;
                    buttonMonitor.Click += (o, e) => { Btn_SignalMonitor_Click(buttonMonitor, new MyEventArgs(index)); };

                    Button buttonClearSignal = new Button();
                    buttonClearSignal.BackColor = this.ButtonClearSignalPLC1.BackColor;
                    buttonClearSignal.FlatStyle = this.ButtonClearSignalPLC1.FlatStyle;
                    buttonClearSignal.Font = this.ButtonClearSignalPLC1.Font;
                    buttonClearSignal.ForeColor = this.ButtonClearSignalPLC1.ForeColor;
                    buttonClearSignal.Location = this.ButtonClearSignalPLC1.Location;
                    buttonClearSignal.Name = $"ButtonClearSignalPLC{index + 1}";
                    buttonClearSignal.Size = this.ButtonClearSignalPLC1.Size;
                    buttonClearSignal.Text = "清空监听信号";
                    buttonClearSignal.UseVisualStyleBackColor = this.ButtonClearSignalPLC1.UseVisualStyleBackColor;
                    buttonClearSignal.Click += (o, e) => { Btn_SignalClear_Click(buttonClearSignal, new MyEventArgs(index)); };

                    Button buttonResetResult = new Button();
                    buttonResetResult.BackColor = this.ButtonResetResultPLC1.BackColor;
                    buttonResetResult.FlatStyle = this.ButtonResetResultPLC1.FlatStyle;
                    buttonResetResult.Font = this.ButtonResetResultPLC1.Font;
                    buttonResetResult.ForeColor = this.ButtonResetResultPLC1.ForeColor;
                    buttonResetResult.Location = this.ButtonResetResultPLC1.Location;
                    buttonResetResult.Name = $"ButtonResetResultPLC{index + 1}";
                    buttonResetResult.Size = this.ButtonResetResultPLC1.Size;
                    buttonResetResult.Text = "重置监听结果";
                    buttonResetResult.UseVisualStyleBackColor = this.ButtonResetResultPLC1.UseVisualStyleBackColor;
                    buttonResetResult.Click += (o, e) => { Btn_ResetResult_Click(buttonClearSignal, new MyEventArgs(index)); }; 

                    Button buttonCheckAll = new Button();
                    buttonCheckAll.BackColor = this.ButtonCheckAllPLC1.BackColor;
                    buttonCheckAll.FlatStyle = this.ButtonCheckAllPLC1.FlatStyle;
                    buttonCheckAll.Font = this.ButtonCheckAllPLC1.Font;
                    buttonCheckAll.ForeColor = this.ButtonCheckAllPLC1.ForeColor;
                    buttonCheckAll.Location = this.ButtonCheckAllPLC1.Location;
                    buttonCheckAll.Name = $"ButtonResetResultPLC{index + 1}";
                    buttonCheckAll.Size = this.ButtonCheckAllPLC1.Size;
                    buttonCheckAll.Text = "全选";
                    buttonCheckAll.UseVisualStyleBackColor = this.ButtonCheckAllPLC1.UseVisualStyleBackColor;
                    buttonCheckAll.Click += (o, e) => { Btn_CheckAll_Click(buttonCheckAll, new MyEventArgs(index)); };

                    Panel panelHeader = new Panel();
                    panelHeader.Controls.Add(buttonMonitor);
                    panelHeader.Controls.Add(buttonClearSignal);
                    panelHeader.Controls.Add(buttonResetResult);
                    panelHeader.Controls.Add(buttonCheckAll);
                    panelHeader.Dock = this.PanelPLC1Header.Dock;
                    panelHeader.Location = this.PanelPLC1Header.Location;
                    panelHeader.Margin = this.PanelPLC1Header.Margin;
                    panelHeader.Name = $"PanelPLC{index + 1}Header";
                    panelHeader.Padding = this.PanelPLC1Header.Padding;
                    panelHeader.Size = this.PanelPLC1Header.Size;

                    DataGridViewCheckBoxColumn dataGridViewAllColumnCheck = new DataGridViewCheckBoxColumn();
                    dataGridViewAllColumnCheck.HeaderText = this.DataGridViewAllColumnCheck1.HeaderText;
                    dataGridViewAllColumnCheck.Name = $"DataGridViewAllColumnCheck{index + 1}";
                    dataGridViewAllColumnCheck.ReadOnly = false;

                    DataGridViewTextBoxColumn dataGridViewAllColumnName = new DataGridViewTextBoxColumn();
                    dataGridViewAllColumnName.AutoSizeMode = this.DataGridViewAllColumnName1.AutoSizeMode;
                    dataGridViewAllColumnName.DefaultCellStyle = this.DataGridViewAllColumnName1.DefaultCellStyle;
                    dataGridViewAllColumnName.HeaderText = this.DataGridViewAllColumnName1.HeaderText;
                    dataGridViewAllColumnName.Name = $"DataGridViewAllColumnName{index + 1}";
                    dataGridViewAllColumnName.ReadOnly = true;

                    DataGridViewTextBoxColumn dataGridViewAllColumnMsg = new DataGridViewTextBoxColumn();
                    dataGridViewAllColumnMsg.AutoSizeMode = this.DataGridViewAllColumnMsg1.AutoSizeMode;
                    dataGridViewAllColumnMsg.DefaultCellStyle = this.DataGridViewAllColumnMsg1.DefaultCellStyle;
                    dataGridViewAllColumnMsg.HeaderText = this.DataGridViewAllColumnMsg1.HeaderText;
                    dataGridViewAllColumnMsg.Name = $"DataGridViewAllColumnMsg{index + 1}";
                    dataGridViewAllColumnMsg.ReadOnly = true;

                    DataGridView dataGridViewAll = new DataGridView();
                    dataGridViewAll.AllowUserToAddRows = this.DataGridViewAllPLC1.AllowUserToAddRows;
                    dataGridViewAll.AllowUserToDeleteRows = this.DataGridViewAllPLC1.AllowUserToDeleteRows;
                    dataGridViewAll.BackgroundColor = this.DataGridViewAllPLC1.BackgroundColor;
                    dataGridViewAll.BorderStyle = this.DataGridViewAllPLC1.BorderStyle;

                    dataGridViewAll.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F);
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                    dataGridViewAll.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

                    dataGridViewAll.ColumnHeadersHeightSizeMode = this.DataGridViewAllPLC1.ColumnHeadersHeightSizeMode;
                    dataGridViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                        dataGridViewAllColumnCheck,
                        dataGridViewAllColumnName,
                        dataGridViewAllColumnMsg
                    });
                    dataGridViewAll.ColumnHeadersHeight = DataGridViewAllPLC1.ColumnHeadersHeight;
                    dataGridViewAll.ColumnHeadersBorderStyle = DataGridViewAllPLC1.ColumnHeadersBorderStyle;
                    dataGridViewAll.EnableHeadersVisualStyles = DataGridViewAllPLC1.EnableHeadersVisualStyles;
                    dataGridViewAll.GridColor = DataGridViewAllPLC1.GridColor;
                    dataGridViewAll.DefaultCellStyle = this.DataGridViewAllPLC1.DefaultCellStyle;
                    dataGridViewAll.Dock = this.DataGridViewAllPLC1.Dock;
                    dataGridViewAll.Location = this.DataGridViewAllPLC1.Location;
                    dataGridViewAll.Margin = this.DataGridViewAllPLC1.Margin;
                    dataGridViewAll.Name = $"DataGridViewPLC{index + 1}";
                    dataGridViewAll.ReadOnly = false;
                    dataGridViewAll.RowTemplate.Height = this.DataGridViewAllPLC1.RowTemplate.Height;
                    dataGridViewAll.Size = this.DataGridViewAllPLC1.Size;
                    _allDataGridViewList.Add(dataGridViewAll);



                    DataGridViewTextBoxColumn dataGridViewCheckColumnName = new DataGridViewTextBoxColumn();
                    dataGridViewCheckColumnName.AutoSizeMode = this.DataGridViewCheckColumnName1.AutoSizeMode;
                    dataGridViewCheckColumnName.DefaultCellStyle = this.DataGridViewCheckColumnName1.DefaultCellStyle;
                    dataGridViewCheckColumnName.HeaderText = this.DataGridViewCheckColumnName1.HeaderText;
                    dataGridViewCheckColumnName.Name = $"DataGridViewCheckColumnName{index + 1}";
                    dataGridViewCheckColumnName.ReadOnly = true;

                    DataGridViewTextBoxColumn dataGridViewCheckColumnMsg = new DataGridViewTextBoxColumn();
                    dataGridViewCheckColumnMsg.AutoSizeMode = this.DataGridViewCheckColumnMsg1.AutoSizeMode;
                    dataGridViewCheckColumnMsg.DefaultCellStyle = this.DataGridViewCheckColumnMsg1.DefaultCellStyle;
                    dataGridViewCheckColumnMsg.HeaderText = this.DataGridViewCheckColumnMsg1.HeaderText;
                    dataGridViewCheckColumnMsg.Name = $"DataGridViewCheckColumnMsg{index + 1}";
                    dataGridViewCheckColumnMsg.ReadOnly = true;

                    DataGridViewTextBoxColumn dataGridViewCheckColumnData = new DataGridViewTextBoxColumn();
                    dataGridViewCheckColumnData.AutoSizeMode = DataGridViewCheckColumnData1.AutoSizeMode;
                    dataGridViewCheckColumnData.DefaultCellStyle = DataGridViewCheckColumnData1.DefaultCellStyle;
                    dataGridViewCheckColumnData.HeaderText = DataGridViewCheckColumnData1.HeaderText;
                    dataGridViewCheckColumnData.Name = $"DataGridViewCheckColumnData{index + 1}";
                    dataGridViewCheckColumnData.ReadOnly = true;

                    DataGridView dataGridViewCheck = new DataGridView();
                    dataGridViewCheck.AllowUserToAddRows = DataGridViewCheckPLC1.AllowUserToAddRows;
                    dataGridViewCheck.AllowUserToDeleteRows = DataGridViewCheckPLC1.AllowUserToDeleteRows;
                    dataGridViewCheck.BackgroundColor = DataGridViewCheckPLC1.BackgroundColor;
                    dataGridViewCheck.BorderStyle = DataGridViewCheckPLC1.BorderStyle;

                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F);
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                    dataGridViewCheck.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

                    dataGridViewCheck.ColumnHeadersHeight = DataGridViewCheckPLC1.ColumnHeadersHeight;
                    dataGridViewCheck.ColumnHeadersHeightSizeMode = DataGridViewCheckPLC1.ColumnHeadersHeightSizeMode;
                    dataGridViewCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                    dataGridViewCheckColumnName,dataGridViewCheckColumnMsg,dataGridViewCheckColumnData});

                    dataGridViewCheck.DefaultCellStyle = DataGridViewCheckPLC1.DefaultCellStyle;
                    dataGridViewCheck.Dock = DataGridViewCheckPLC1.Dock;
                    dataGridViewCheck.Location = DataGridViewCheckPLC1.Location;
                    dataGridViewCheck.Margin = DataGridViewCheckPLC1.Margin;
                    dataGridViewCheck.Name = $"DataGridViewCheckPLC{index + 1}";
                    dataGridViewCheck.ReadOnly = true;
                    dataGridViewCheck.RowTemplate.Height = DataGridViewCheckPLC1.RowTemplate.Height;
                    dataGridViewCheck.Size = DataGridViewCheckPLC1.Size;
                    _checkDataGridViewList.Add(dataGridViewCheck);

                    SplitContainer splitContainerPLC = new SplitContainer();
                    splitContainerPLC.Dock = this.SplitContainerPLC1.Dock;
                    splitContainerPLC.Location = SplitContainerPLC1.Location;
                    splitContainerPLC.Name = $"SplitContainerPLC{index + 1}";
                    splitContainerPLC.Orientation = SplitContainerPLC1.Orientation;
                    splitContainerPLC.Panel1.Controls.Add(dataGridViewAll);
                    splitContainerPLC.Panel2.Controls.Add(dataGridViewCheck);
                    splitContainerPLC.Size = SplitContainerPLC1.Size;
                    splitContainerPLC.SplitterDistance = SplitContainerPLC1.SplitterDistance;
                    splitContainerPLC.SplitterWidth = SplitContainerPLC1.SplitterWidth;

                    TableLayoutPanel tableLayoutPanelAll = new TableLayoutPanel();
                    tableLayoutPanelAll.ColumnCount = this.TableLayoutPanelPLC1All.ColumnCount;
                    tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    tableLayoutPanelAll.Controls.Add(panelHeader, 0, 0);
                    tableLayoutPanelAll.Controls.Add(splitContainerPLC, 0, 1);
                    tableLayoutPanelAll.Dock = this.TableLayoutPanelPLC1All.Dock;
                    tableLayoutPanelAll.Location = this.TableLayoutPanelPLC1All.Location;
                    tableLayoutPanelAll.Margin = this.TableLayoutPanelPLC1All.Margin;
                    tableLayoutPanelAll.Name = $"TableLayoutPanelPLC{index + 1}All";
                    tableLayoutPanelAll.RowCount = this.TableLayoutPanelPLC1All.RowCount;
                    tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
                    tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    tableLayoutPanelAll.Size = this.TableLayoutPanelPLC1All.Size;
                    _allSignalTablePanelList.Add(tableLayoutPanelAll);

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
                    tsButton.Click += (o, e) => { SwitchtableLayoutPanelAll_Click(this, new MyEventArgs(new string[] { index + "", tsButton.Name })); };
                    this.ToolStrip1.Items.Add(tsButton);
                    _toolStripButtonList.Add(tsButton);

                    ToolStripLabel tsLabel = new ToolStripLabel();
                    tsLabel.Name = $"toolStripLabel{i + 1}";
                    tsLabel.Size = toolStripLabel1.Size;
                    tsLabel.Text = toolStripLabel1.Text;
                    this.ToolStrip1.Items.Add(tsLabel);
                }
            }
            this.ButtonCheckAllPLC1.Click += (o, e) => { Btn_CheckAll_Click(ButtonCheckAllPLC1, new MyEventArgs(0)); };
            this.ButtonClearSignalPLC1.Click += (o, e) => { Btn_SignalClear_Click(ButtonClearSignalPLC1, new MyEventArgs(0)); };
            this.ButtonResetResultPLC1.Click += (o, e) => { Btn_ResetResult_Click(ButtonResetResultPLC1, new MyEventArgs(0)); };
            this.ButtonMonitorPLC1.Click += (o, e) => { Btn_SignalMonitor_Click(ButtonMonitorPLC1, new MyEventArgs(0)); };
            this.ToolStripButton1.Click += (o, e) => { SwitchtableLayoutPanelAll_Click(this, new MyEventArgs(new string[] {"0", ToolStripButton1.Name })); };
            for (int i = 0; i < _allDataGridViewList.Count; i++)
                InitDataGridView(_allDataGridViewList[i],new double[] { 0.1 , 0.58 , 0.3 });
            for (int i = 0; i < _checkDataGridViewList.Count; i++)
                InitDataGridView(_checkDataGridViewList[i], new double[] { 0.5, 0.25, 0.25 });
        }

        public void InitDataGridView(DataGridView DGV,double[] proportions)
        {
            DGV.Columns[0].Width = Convert.ToInt32((DGV.Width - 10) * proportions[0]);
            DGV.Columns[1].Width = Convert.ToInt32((DGV.Width - 10) * proportions[1]);
            DGV.Columns[2].Width = Convert.ToInt32((DGV.Width - 10) * proportions[2]);
            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                DGV.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGV.RowHeadersVisible = false;
            DGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//不能用鼠标调整列标头宽度 
            DGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//单元格内容居中显示  //行为
            DGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            DGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGV.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            DGV.AutoGenerateColumns = false;//不自动创建列
            DGV.AllowUserToAddRows = false;//不启用添加 
            DGV.AllowUserToDeleteRows = false;//不启用删除
            DGV.SelectionMode = DataGridViewSelectionMode.CellSelect;//单击单元格选中单个  
            DGV.MultiSelect = true;//不能多选 
            DGV.AllowUserToResizeRows = false;
        }

        private void UpdateForm()
        {
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
            {
                int signalCount = Project.Instance().PLCManagerInstance.L_PLCSignalInfoList[i].Count;              
                for (int j = 0; j < signalCount; j++)
                {
                    _allDataGridViewList[i].Rows.Add();
                    _allDataGridViewList[i].Rows[j].Cells[1].Value = _singleNameAllList[i][j];
                    _allDataGridViewList[i].Rows[j].Cells[2].Value = _singleMsgAllList[i][j];
                }             
            }
        }


        /// <summary>
        /// 点击切换tableLayoutPanel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SwitchtableLayoutPanelAll_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            string[] data = (String[])args.obj;
            this.PanelContent.Controls.Clear();
            for (int i = 0; i < this.ToolStrip1.Items.Count; i++)
            {
                if (this.ToolStrip1.Items[i].Name != data[1])
                    this.ToolStrip1.Items[i].BackColor = Color.Transparent;
                else
                    this.ToolStrip1.Items[i].BackColor = Color.CadetBlue;
            }
            this.PanelContent.Controls.Add(_allSignalTablePanelList[Convert.ToInt32(data[0])]);
        }


        /// <summary>
        /// 全选/取消全选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CheckAll_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            object data = args.obj;
            int index = (int)data;
            Button button = (Button)sender;
            if (button.Text == $"全选")
            {
                button.Text = $"取消全选";
                for (int i = 0; i < _allDataGridViewList[index].Rows.Count; i++)
                {
                    _allDataGridViewList[index].Rows[i].Cells[0].Value = 1;
                }
            }
            else if (button.Text == $"取消全选")
            {
                button.Text = $"全选";
                for (int i = 0; i < _allDataGridViewList[index].Rows.Count; i++)
                {
                    _allDataGridViewList[index].Rows[i].Cells[0].Value = 0;
                }
            }
        }

        /// <summary>
        ///  清空选择的信号数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SignalClear_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            object data = args.obj;
            int index = (int)data;

            if (Project.Instance().ScheduledTaskManagerInstance.IsStartSignalMonitor(index))
            {
                this.ConfirmErrorDialog("正在实时监听信号，不能清空信号！"); return;
            }

            _singleMsgCheckList[index].Clear();
            _singleNameCheckList[index].Clear();
            _singleDataCheckList[index].Clear();
            _checkDataGridViewList[index].Rows.Clear();
        }

        /// <summary>
        ///  重置监听结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ResetResult_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            object data = args.obj;
            int index = (int)data;
            if (_checkDataGridViewList[index].Rows.Count <= 0)
            {
                this.ConfirmErrorDialog("未选择需要监听的信号！"); return;
            }
            for (int k = 0; k < _singleDataCheckList[index].Count; k++)
            {
                _singleDataCheckList[index][k] = "Unknown";
            }
            UpdateSignalData(index);
        }

        

        /// <summary>
        /// 开始/停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SignalMonitor_Click(object sender, EventArgs e)
        {
            MyEventArgs args = (MyEventArgs)e;
            object data = args.obj;
            int index = (int)data;
            Button button = (Button)sender;
            if (button.Text == $"开始监听PLC{index + 1}")
            {
                if (_checkDataGridViewList[index].Rows.Count <= 0)
                    LoadCheckDataGridViewData(index);

                if (_checkDataGridViewList[index].Rows.Count <= 0)
                {
                    this.ConfirmErrorDialog("未选择需要监听的信号！"); return;
                }
                button.Text = $"停止监听PLC{index + 1}";
                LoadCheckData(index);
                Project.Instance().ScheduledTaskManagerInstance.StartSignalMonitor(index);
            }
            else if (button.Text == $"停止监听PLC{index + 1}")
            {
                button.Text = $"开始监听PLC{index + 1}";
                Project.Instance().ScheduledTaskManagerInstance.StopSignalMonitor(index);
            }
        }

        /// <summary>
        /// 将全部数据的表格中已选择的数据复制到选择的表格中
        /// </summary>
        /// <param name="index"></param>
        private void LoadCheckDataGridViewData(int index)
        {
            for (int i = 0; i < _allDataGridViewList[index].Rows.Count; i++)
            {
                if ((bool)_allDataGridViewList[index].Rows[i].Cells[0].EditedFormattedValue == true)
                {
                    _checkDataGridViewList[index].Rows.Add();
                    int rowIndex = _checkDataGridViewList[index].Rows.Count - 1;
                    _checkDataGridViewList[index].Rows[rowIndex].Cells[0].Value = _allDataGridViewList[index].Rows[i].Cells[1].Value;
                    _checkDataGridViewList[index].Rows[rowIndex].Cells[1].Value = _allDataGridViewList[index].Rows[i].Cells[2].Value;
                    _checkDataGridViewList[index].Rows[rowIndex].Cells[2].Value = "Unknown";
                }
            }
        }

        /// <summary>
        /// 将选择的表格的数据复制到变量容器中
        /// </summary>
        /// <param name="index"></param>
        private void LoadCheckData(int index)
        {
            _singleNameCheckList[index].Clear();
            _singleMsgCheckList[index].Clear();
            _singleDataCheckList[index].Clear();
            for (int i = 0; i < _checkDataGridViewList[index].Rows.Count; i++)
            {
                _singleNameCheckList[index].Add(_checkDataGridViewList[index].Rows[i].Cells[0].Value.ToString());
                _singleMsgCheckList[index].Add(_checkDataGridViewList[index].Rows[i].Cells[1].Value.ToString());
                _singleDataCheckList[index].Add("Unknown");
            }
        }    
        

        /// <summary>
        /// 读取信号后更新
        /// </summary>
        public void MonitorSignalDataRefreshDisplay(int index)
        {
            try
            {
                object[] objValue = new object[_singleNameCheckList[index].Count];
                //Project.Instance().PLCManagerInstance.L_basePLCObjects[index].ReadMultiSignal(_singleNameCheckList[index].ToArray(), out objValue);
                for (int i = 0; i < objValue.Length; i++)
                {
                    if (objValue[i] == null)
                    {
                        objValue[i] = "NULL";
                    }
                    _singleDataCheckList[index][i] = objValue[i].ToString();
                }
                UpdateSignalData(index);
            }
            catch(Exception ex)
            {
                LogHelper.Error($"实时监听PLC{index + 1}信号出现异常",ex);
            }
        }

        /// <summary>
        /// 刷新信号的数据
        /// </summary>
        /// <param name="plcIndex"></param>
        private void UpdateSignalData(int plcIndex)
        {
            if (this.IsHandleCreated)
            {
                for (int j = 0; j < _singleDataCheckList[plcIndex].Count; j++)
                {
                    _checkDataGridViewList[plcIndex].Rows[j].Cells[2].Value = _singleDataCheckList[plcIndex][j];
                }
            }
        }

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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            IsFormOpen = false;
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
                Project.Instance().ScheduledTaskManagerInstance.StopSignalMonitor(i);
            this.Close();
        }

        private void FrmPlcCommMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < Project.Instance().PLCManagerInstance.PLCNum; i++)
                Project.Instance().ScheduledTaskManagerInstance.StopSignalMonitor(i);
            Thread.Sleep(500);
        }

        private void FrmPlcCommMonitor_Load(object sender, EventArgs e)
        {
            IsFormOpen = true;
        }
    }
}
