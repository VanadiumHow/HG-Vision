namespace VisionProgram.UI.UISetting
{
    partial class FrmPlcCommMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlcCommMonitor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TableLayoutPanelMonitorMain = new System.Windows.Forms.TableLayoutPanel();
            this.PanelTool = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.TableLayoutPanelPLC1All = new System.Windows.Forms.TableLayoutPanel();
            this.PanelPLC1Header = new System.Windows.Forms.Panel();
            this.ButtonClearSignalPLC1 = new System.Windows.Forms.Button();
            this.ButtonCheckAllPLC1 = new System.Windows.Forms.Button();
            this.ButtonResetResultPLC1 = new System.Windows.Forms.Button();
            this.ButtonMonitorPLC1 = new System.Windows.Forms.Button();
            this.SplitContainerPLC1 = new System.Windows.Forms.SplitContainer();
            this.DataGridViewAllPLC1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewAllColumnCheck1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataGridViewAllColumnName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewAllColumnMsg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckPLC1 = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckColumnName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckColumnMsg1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewCheckColumnData1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelMain.SuspendLayout();
            this.TableLayoutPanelMonitorMain.SuspendLayout();
            this.PanelTool.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.TableLayoutPanelPLC1All.SuspendLayout();
            this.PanelPLC1Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerPLC1)).BeginInit();
            this.SplitContainerPLC1.Panel1.SuspendLayout();
            this.SplitContainerPLC1.Panel2.SuspendLayout();
            this.SplitContainerPLC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllPLC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCheckPLC1)).BeginInit();
            this.PanelAll.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.SystemColors.Window;
            this.PanelMain.Controls.Add(this.TableLayoutPanelMonitorMain);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelMain.Location = new System.Drawing.Point(0, 40);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1448, 858);
            this.PanelMain.TabIndex = 1;
            // 
            // TableLayoutPanelMonitorMain
            // 
            this.TableLayoutPanelMonitorMain.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelMonitorMain.ColumnCount = 1;
            this.TableLayoutPanelMonitorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMonitorMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelMonitorMain.Controls.Add(this.PanelTool, 0, 0);
            this.TableLayoutPanelMonitorMain.Controls.Add(this.PanelContent, 0, 1);
            this.TableLayoutPanelMonitorMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMonitorMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMonitorMain.Name = "TableLayoutPanelMonitorMain";
            this.TableLayoutPanelMonitorMain.RowCount = 2;
            this.TableLayoutPanelMonitorMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelMonitorMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMonitorMain.Size = new System.Drawing.Size(1448, 858);
            this.TableLayoutPanelMonitorMain.TabIndex = 1;
            // 
            // PanelTool
            // 
            this.PanelTool.BackColor = System.Drawing.Color.Transparent;
            this.PanelTool.Controls.Add(this.ToolStrip1);
            this.PanelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTool.Location = new System.Drawing.Point(0, 0);
            this.PanelTool.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTool.Name = "PanelTool";
            this.PanelTool.Size = new System.Drawing.Size(1448, 30);
            this.PanelTool.TabIndex = 14;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.toolStripLabel1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.ToolStrip1.Size = new System.Drawing.Size(1448, 30);
            this.ToolStrip1.TabIndex = 13;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(101, 27);
            this.ToolStripButton1.Text = "    PLC1    ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 27);
            this.toolStripLabel1.Text = "  ";
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.TableLayoutPanelPLC1All);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 30);
            this.PanelContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1448, 828);
            this.PanelContent.TabIndex = 15;
            // 
            // TableLayoutPanelPLC1All
            // 
            this.TableLayoutPanelPLC1All.ColumnCount = 1;
            this.TableLayoutPanelPLC1All.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelPLC1All.Controls.Add(this.PanelPLC1Header, 0, 0);
            this.TableLayoutPanelPLC1All.Controls.Add(this.SplitContainerPLC1, 0, 1);
            this.TableLayoutPanelPLC1All.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelPLC1All.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelPLC1All.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelPLC1All.Name = "TableLayoutPanelPLC1All";
            this.TableLayoutPanelPLC1All.RowCount = 2;
            this.TableLayoutPanelPLC1All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelPLC1All.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelPLC1All.Size = new System.Drawing.Size(1448, 828);
            this.TableLayoutPanelPLC1All.TabIndex = 2;
            // 
            // PanelPLC1Header
            // 
            this.PanelPLC1Header.Controls.Add(this.ButtonClearSignalPLC1);
            this.PanelPLC1Header.Controls.Add(this.ButtonCheckAllPLC1);
            this.PanelPLC1Header.Controls.Add(this.ButtonResetResultPLC1);
            this.PanelPLC1Header.Controls.Add(this.ButtonMonitorPLC1);
            this.PanelPLC1Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPLC1Header.Location = new System.Drawing.Point(0, 0);
            this.PanelPLC1Header.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPLC1Header.Name = "PanelPLC1Header";
            this.PanelPLC1Header.Padding = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.PanelPLC1Header.Size = new System.Drawing.Size(1448, 50);
            this.PanelPLC1Header.TabIndex = 1;
            // 
            // ButtonClearSignalPLC1
            // 
            this.ButtonClearSignalPLC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonClearSignalPLC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearSignalPLC1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonClearSignalPLC1.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonClearSignalPLC1.Location = new System.Drawing.Point(1022, 5);
            this.ButtonClearSignalPLC1.Name = "ButtonClearSignalPLC1";
            this.ButtonClearSignalPLC1.Size = new System.Drawing.Size(128, 40);
            this.ButtonClearSignalPLC1.TabIndex = 9;
            this.ButtonClearSignalPLC1.Text = "清空监听信号";
            this.ButtonClearSignalPLC1.UseVisualStyleBackColor = false;
            // 
            // ButtonCheckAllPLC1
            // 
            this.ButtonCheckAllPLC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonCheckAllPLC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheckAllPLC1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCheckAllPLC1.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonCheckAllPLC1.Location = new System.Drawing.Point(5, 5);
            this.ButtonCheckAllPLC1.Name = "ButtonCheckAllPLC1";
            this.ButtonCheckAllPLC1.Size = new System.Drawing.Size(128, 40);
            this.ButtonCheckAllPLC1.TabIndex = 8;
            this.ButtonCheckAllPLC1.Text = "全选";
            this.ButtonCheckAllPLC1.UseVisualStyleBackColor = false;
            // 
            // ButtonResetResultPLC1
            // 
            this.ButtonResetResultPLC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonResetResultPLC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonResetResultPLC1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonResetResultPLC1.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonResetResultPLC1.Location = new System.Drawing.Point(1166, 5);
            this.ButtonResetResultPLC1.Name = "ButtonResetResultPLC1";
            this.ButtonResetResultPLC1.Size = new System.Drawing.Size(128, 40);
            this.ButtonResetResultPLC1.TabIndex = 7;
            this.ButtonResetResultPLC1.Text = "重置监听结果";
            this.ButtonResetResultPLC1.UseVisualStyleBackColor = false;
            // 
            // ButtonMonitorPLC1
            // 
            this.ButtonMonitorPLC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonMonitorPLC1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMonitorPLC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMonitorPLC1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonMonitorPLC1.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonMonitorPLC1.Location = new System.Drawing.Point(1310, 5);
            this.ButtonMonitorPLC1.Name = "ButtonMonitorPLC1";
            this.ButtonMonitorPLC1.Size = new System.Drawing.Size(128, 40);
            this.ButtonMonitorPLC1.TabIndex = 6;
            this.ButtonMonitorPLC1.Text = "开始监听PLC1";
            this.ButtonMonitorPLC1.UseVisualStyleBackColor = false;
            // 
            // SplitContainerPLC1
            // 
            this.SplitContainerPLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerPLC1.Location = new System.Drawing.Point(3, 53);
            this.SplitContainerPLC1.Name = "SplitContainerPLC1";
            // 
            // SplitContainerPLC1.Panel1
            // 
            this.SplitContainerPLC1.Panel1.Controls.Add(this.DataGridViewAllPLC1);
            // 
            // SplitContainerPLC1.Panel2
            // 
            this.SplitContainerPLC1.Panel2.Controls.Add(this.DataGridViewCheckPLC1);
            this.SplitContainerPLC1.Size = new System.Drawing.Size(1442, 772);
            this.SplitContainerPLC1.SplitterDistance = 650;
            this.SplitContainerPLC1.SplitterWidth = 10;
            this.SplitContainerPLC1.TabIndex = 2;
            // 
            // DataGridViewAllPLC1
            // 
            this.DataGridViewAllPLC1.AllowUserToAddRows = false;
            this.DataGridViewAllPLC1.AllowUserToDeleteRows = false;
            this.DataGridViewAllPLC1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewAllPLC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllPLC1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAllPLC1.ColumnHeadersHeight = 27;
            this.DataGridViewAllPLC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewAllPLC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewAllColumnCheck1,
            this.DataGridViewAllColumnName1,
            this.DataGridViewAllColumnMsg1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAllPLC1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewAllPLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewAllPLC1.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewAllPLC1.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewAllPLC1.Name = "DataGridViewAllPLC1";
            this.DataGridViewAllPLC1.RowTemplate.Height = 27;
            this.DataGridViewAllPLC1.Size = new System.Drawing.Size(650, 772);
            this.DataGridViewAllPLC1.TabIndex = 14;
            // 
            // DataGridViewAllColumnCheck1
            // 
            this.DataGridViewAllColumnCheck1.HeaderText = "选择";
            this.DataGridViewAllColumnCheck1.Name = "DataGridViewAllColumnCheck1";
            this.DataGridViewAllColumnCheck1.Width = 50;
            // 
            // DataGridViewAllColumnName1
            // 
            this.DataGridViewAllColumnName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 13.8F);
            this.DataGridViewAllColumnName1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAllColumnName1.HeaderText = "变量名";
            this.DataGridViewAllColumnName1.Name = "DataGridViewAllColumnName1";
            this.DataGridViewAllColumnName1.ReadOnly = true;
            this.DataGridViewAllColumnName1.Width = 250;
            // 
            // DataGridViewAllColumnMsg1
            // 
            this.DataGridViewAllColumnMsg1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 13.8F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAllColumnMsg1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewAllColumnMsg1.HeaderText = "备注";
            this.DataGridViewAllColumnMsg1.Name = "DataGridViewAllColumnMsg1";
            this.DataGridViewAllColumnMsg1.ReadOnly = true;
            this.DataGridViewAllColumnMsg1.Width = 240;
            // 
            // DataGridViewCheckPLC1
            // 
            this.DataGridViewCheckPLC1.AllowUserToAddRows = false;
            this.DataGridViewCheckPLC1.AllowUserToDeleteRows = false;
            this.DataGridViewCheckPLC1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewCheckPLC1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCheckPLC1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewCheckPLC1.ColumnHeadersHeight = 27;
            this.DataGridViewCheckPLC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewCheckPLC1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckColumnName1,
            this.DataGridViewCheckColumnMsg1,
            this.DataGridViewCheckColumnData1});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCheckPLC1.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewCheckPLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewCheckPLC1.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewCheckPLC1.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewCheckPLC1.Name = "DataGridViewCheckPLC1";
            this.DataGridViewCheckPLC1.ReadOnly = true;
            this.DataGridViewCheckPLC1.RowTemplate.Height = 27;
            this.DataGridViewCheckPLC1.Size = new System.Drawing.Size(782, 772);
            this.DataGridViewCheckPLC1.TabIndex = 16;
            // 
            // DataGridViewCheckColumnName1
            // 
            this.DataGridViewCheckColumnName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 13.8F);
            this.DataGridViewCheckColumnName1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewCheckColumnName1.HeaderText = "变量名";
            this.DataGridViewCheckColumnName1.Name = "DataGridViewCheckColumnName1";
            this.DataGridViewCheckColumnName1.ReadOnly = true;
            this.DataGridViewCheckColumnName1.Width = 250;
            // 
            // DataGridViewCheckColumnMsg1
            // 
            this.DataGridViewCheckColumnMsg1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 13.8F);
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCheckColumnMsg1.DefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewCheckColumnMsg1.HeaderText = "备注";
            this.DataGridViewCheckColumnMsg1.Name = "DataGridViewCheckColumnMsg1";
            this.DataGridViewCheckColumnMsg1.ReadOnly = true;
            this.DataGridViewCheckColumnMsg1.Width = 240;
            // 
            // DataGridViewCheckColumnData1
            // 
            this.DataGridViewCheckColumnData1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DataGridViewCheckColumnData1.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewCheckColumnData1.HeaderText = "数据";
            this.DataGridViewCheckColumnData1.Name = "DataGridViewCheckColumnData1";
            this.DataGridViewCheckColumnData1.ReadOnly = true;
            this.DataGridViewCheckColumnData1.Width = 150;
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.SystemColors.Window;
            this.PanelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAll.Controls.Add(this.TableLayoutPanelAll);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(1450, 900);
            this.PanelAll.TabIndex = 2;
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAll.Controls.Add(this.PanelHeader, 0, 0);
            this.TableLayoutPanelAll.Controls.Add(this.PanelMain, 0, 1);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1448, 898);
            this.TableLayoutPanelAll.TabIndex = 0;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.PanelHeader.Controls.Add(this.Label3);
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1448, 40);
            this.PanelHeader.TabIndex = 3;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Label3
            // 
            this.Label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(0, 0);
            this.Label3.Margin = new System.Windows.Forms.Padding(0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(197, 40);
            this.Label3.TabIndex = 1;
            this.Label3.Text = " PLC实时监控";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(1408, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(40, 40);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FrmPlcCommMonitor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1450, 900);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1450, 900);
            this.MinimumSize = new System.Drawing.Size(1450, 900);
            this.Name = "FrmPlcCommMonitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC实时监控";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPlcCommMonitor_FormClosing);
            this.Load += new System.EventHandler(this.FrmPlcCommMonitor_Load);
            this.PanelMain.ResumeLayout(false);
            this.TableLayoutPanelMonitorMain.ResumeLayout(false);
            this.PanelTool.ResumeLayout(false);
            this.PanelTool.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.TableLayoutPanelPLC1All.ResumeLayout(false);
            this.PanelPLC1Header.ResumeLayout(false);
            this.SplitContainerPLC1.Panel1.ResumeLayout(false);
            this.SplitContainerPLC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerPLC1)).EndInit();
            this.SplitContainerPLC1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAllPLC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCheckPLC1)).EndInit();
            this.PanelAll.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMonitorMain;
        private System.Windows.Forms.Panel PanelTool;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelPLC1All;
        private System.Windows.Forms.Panel PanelPLC1Header;
        public System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.SplitContainer SplitContainerPLC1;
        private System.Windows.Forms.DataGridView DataGridViewAllPLC1;
        private System.Windows.Forms.Button ButtonClearSignalPLC1;
        private System.Windows.Forms.Button ButtonCheckAllPLC1;
        private System.Windows.Forms.Button ButtonResetResultPLC1;
        private System.Windows.Forms.Button ButtonMonitorPLC1;
        private System.Windows.Forms.DataGridView DataGridViewCheckPLC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCheckColumnName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCheckColumnMsg1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewCheckColumnData1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewAllColumnCheck1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewAllColumnName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewAllColumnMsg1;
    }
}