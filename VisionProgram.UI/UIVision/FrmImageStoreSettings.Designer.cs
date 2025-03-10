using System.Windows.Forms;

namespace VisionProgram.UI.UIVision
{
    partial class FrmImageStoreSettings
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.uiPanel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiSymbolButton1 = new System.Windows.Forms.Button();
            this.uiGroupBoxRaw = new System.Windows.Forms.GroupBox();
            this.uiTableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numUDRawKeepingDays = new System.Windows.Forms.NumericUpDown();
            this.cbRawImagePattern = new System.Windows.Forms.ComboBox();
            this.uiPanelRawPath = new System.Windows.Forms.Panel();
            this.lbRawPosition = new System.Windows.Forms.Label();
            this.btnChangeRawPosition = new System.Windows.Forms.Button();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.radioChanceRawIsSave = new System.Windows.Forms.ListBox();
            this.uiGroupBoxResult = new System.Windows.Forms.GroupBox();
            this.uiTableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numUDResultKeepingDays = new System.Windows.Forms.NumericUpDown();
            this.cbResultImagePattern = new System.Windows.Forms.ComboBox();
            this.uiLabel6 = new System.Windows.Forms.Label();
            this.uiLabel5 = new System.Windows.Forms.Label();
            this.uiLabel4 = new System.Windows.Forms.Label();
            this.uiPanel_ResultPath = new System.Windows.Forms.Panel();
            this.lbResultPosition = new System.Windows.Forms.Label();
            this.btnChangeResultPosition = new System.Windows.Forms.Button();
            this.radioChanceResultIsSave = new System.Windows.Forms.ListBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiGroupBoxRaw.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRawKeepingDays)).BeginInit();
            this.uiPanelRawPath.SuspendLayout();
            this.uiGroupBoxResult.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDResultKeepingDays)).BeginInit();
            this.uiPanel_ResultPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.uiPanel1.Controls.Add(this.splitContainer1);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 1);
            this.uiPanel1.Size = new System.Drawing.Size(855, 456);
            this.uiPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiTableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(853, 455);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 4;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiSymbolButton1, 2, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiGroupBoxRaw, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiGroupBoxResult, 2, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 2;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.80309F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.19691F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(853, 414);
            this.uiTableLayoutPanel1.TabIndex = 0;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.uiSymbolButton1.Location = new System.Drawing.Point(427, 369);
            this.uiSymbolButton1.Margin = new System.Windows.Forms.Padding(2);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(379, 43);
            this.uiSymbolButton1.TabIndex = 83;
            this.uiSymbolButton1.Text = "应用图像参数";
            this.uiSymbolButton1.UseVisualStyleBackColor = false;
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiGroupBoxRaw
            // 
            this.uiGroupBoxRaw.Controls.Add(this.uiTableLayoutPanel2);
            this.uiGroupBoxRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBoxRaw.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBoxRaw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiGroupBoxRaw.Location = new System.Drawing.Point(44, 3);
            this.uiGroupBoxRaw.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiGroupBoxRaw.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBoxRaw.Name = "uiGroupBoxRaw";
            this.uiGroupBoxRaw.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.uiGroupBoxRaw.Size = new System.Drawing.Size(379, 361);
            this.uiGroupBoxRaw.TabIndex = 1;
            this.uiGroupBoxRaw.TabStop = false;
            this.uiGroupBoxRaw.Text = "原始图像";
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.ColumnCount = 2;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.uiTableLayoutPanel2.Controls.Add(this.numUDRawKeepingDays, 1, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.cbRawImagePattern, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiPanelRawPath, 0, 4);
            this.uiTableLayoutPanel2.Controls.Add(this.btnChangeRawPosition, 0, 3);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel2.Controls.Add(this.uiLabel3, 0, 2);
            this.uiTableLayoutPanel2.Controls.Add(this.radioChanceRawIsSave, 1, 2);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.uiTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 5;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83879F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.89169F));
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(379, 318);
            this.uiTableLayoutPanel2.TabIndex = 0;
            // 
            // numUDRawKeepingDays
            // 
            this.numUDRawKeepingDays.BackColor = System.Drawing.SystemColors.Control;
            this.numUDRawKeepingDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDRawKeepingDays.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numUDRawKeepingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.numUDRawKeepingDays.Location = new System.Drawing.Point(153, 34);
            this.numUDRawKeepingDays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numUDRawKeepingDays.MinimumSize = new System.Drawing.Size(60, 0);
            this.numUDRawKeepingDays.Name = "numUDRawKeepingDays";
            this.numUDRawKeepingDays.Size = new System.Drawing.Size(224, 29);
            this.numUDRawKeepingDays.TabIndex = 6;
            // 
            // cbRawImagePattern
            // 
            this.cbRawImagePattern.BackColor = System.Drawing.SystemColors.Control;
            this.cbRawImagePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRawImagePattern.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbRawImagePattern.Items.AddRange(new object[] {
            ".bmp"});
            this.cbRawImagePattern.Location = new System.Drawing.Point(153, 3);
            this.cbRawImagePattern.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbRawImagePattern.MinimumSize = new System.Drawing.Size(39, 0);
            this.cbRawImagePattern.Name = "cbRawImagePattern";
            this.cbRawImagePattern.Size = new System.Drawing.Size(224, 29);
            this.cbRawImagePattern.TabIndex = 5;
            // 
            // uiPanelRawPath
            // 
            this.uiTableLayoutPanel2.SetColumnSpan(this.uiPanelRawPath, 2);
            this.uiPanelRawPath.Controls.Add(this.lbRawPosition);
            this.uiPanelRawPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelRawPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelRawPath.Location = new System.Drawing.Point(2, 259);
            this.uiPanelRawPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiPanelRawPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanelRawPath.Name = "uiPanelRawPath";
            this.uiPanelRawPath.Size = new System.Drawing.Size(375, 56);
            this.uiPanelRawPath.TabIndex = 0;
            // 
            // lbRawPosition
            // 
            this.lbRawPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbRawPosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbRawPosition.Location = new System.Drawing.Point(0, 0);
            this.lbRawPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRawPosition.Name = "lbRawPosition";
            this.lbRawPosition.Size = new System.Drawing.Size(375, 56);
            this.lbRawPosition.TabIndex = 0;
            this.lbRawPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeRawPosition
            // 
            this.btnChangeRawPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeRawPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeRawPosition.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnChangeRawPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnChangeRawPosition.Location = new System.Drawing.Point(2, 221);
            this.btnChangeRawPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeRawPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChangeRawPosition.Name = "btnChangeRawPosition";
            this.btnChangeRawPosition.Size = new System.Drawing.Size(147, 33);
            this.btnChangeRawPosition.TabIndex = 1;
            this.btnChangeRawPosition.Text = "更改图像路径";
            this.btnChangeRawPosition.Click += new System.EventHandler(this.btnChangeRawPosition_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel1.Location = new System.Drawing.Point(2, 0);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(147, 31);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "保存格式：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel2.Location = new System.Drawing.Point(2, 31);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(147, 31);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "保存天数：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel3.Location = new System.Drawing.Point(2, 62);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(147, 31);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "保存类型：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioChanceRawIsSave
            // 
            this.radioChanceRawIsSave.BackColor = System.Drawing.SystemColors.Control;
            this.radioChanceRawIsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioChanceRawIsSave.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioChanceRawIsSave.FormattingEnabled = true;
            this.radioChanceRawIsSave.ItemHeight = 20;
            this.radioChanceRawIsSave.Items.AddRange(new object[] {
            "都不保存",
            "仅OK保存",
            "仅NG保存",
            "全部保存"});
            this.radioChanceRawIsSave.Location = new System.Drawing.Point(153, 64);
            this.radioChanceRawIsSave.Margin = new System.Windows.Forms.Padding(2);
            this.radioChanceRawIsSave.Name = "radioChanceRawIsSave";
            this.radioChanceRawIsSave.Size = new System.Drawing.Size(224, 153);
            this.radioChanceRawIsSave.TabIndex = 7;
            // 
            // uiGroupBoxResult
            // 
            this.uiGroupBoxResult.Controls.Add(this.uiTableLayoutPanel3);
            this.uiGroupBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiGroupBoxResult.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBoxResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiGroupBoxResult.Location = new System.Drawing.Point(427, 3);
            this.uiGroupBoxResult.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiGroupBoxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBoxResult.Name = "uiGroupBoxResult";
            this.uiGroupBoxResult.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.uiGroupBoxResult.Size = new System.Drawing.Size(379, 361);
            this.uiGroupBoxResult.TabIndex = 2;
            this.uiGroupBoxResult.TabStop = false;
            this.uiGroupBoxResult.Text = "结果图像";
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.ColumnCount = 2;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.uiTableLayoutPanel3.Controls.Add(this.numUDResultKeepingDays, 1, 1);
            this.uiTableLayoutPanel3.Controls.Add(this.cbResultImagePattern, 1, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.uiLabel6, 0, 2);
            this.uiTableLayoutPanel3.Controls.Add(this.uiLabel5, 0, 1);
            this.uiTableLayoutPanel3.Controls.Add(this.uiLabel4, 0, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.uiPanel_ResultPath, 0, 4);
            this.uiTableLayoutPanel3.Controls.Add(this.btnChangeResultPosition, 0, 3);
            this.uiTableLayoutPanel3.Controls.Add(this.radioChanceResultIsSave, 1, 2);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(0, 43);
            this.uiTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 5;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83879F));
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.89169F));
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(379, 318);
            this.uiTableLayoutPanel3.TabIndex = 1;
            // 
            // numUDResultKeepingDays
            // 
            this.numUDResultKeepingDays.BackColor = System.Drawing.SystemColors.Control;
            this.numUDResultKeepingDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numUDResultKeepingDays.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numUDResultKeepingDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.numUDResultKeepingDays.Location = new System.Drawing.Point(153, 34);
            this.numUDResultKeepingDays.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numUDResultKeepingDays.MinimumSize = new System.Drawing.Size(60, 0);
            this.numUDResultKeepingDays.Name = "numUDResultKeepingDays";
            this.numUDResultKeepingDays.Size = new System.Drawing.Size(224, 29);
            this.numUDResultKeepingDays.TabIndex = 7;
            // 
            // cbResultImagePattern
            // 
            this.cbResultImagePattern.BackColor = System.Drawing.SystemColors.Control;
            this.cbResultImagePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbResultImagePattern.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbResultImagePattern.Items.AddRange(new object[] {
            ".bmp",
            ".jpg",
            ".png",
            ".tif"});
            this.cbResultImagePattern.Location = new System.Drawing.Point(153, 3);
            this.cbResultImagePattern.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbResultImagePattern.MinimumSize = new System.Drawing.Size(39, 0);
            this.cbResultImagePattern.Name = "cbResultImagePattern";
            this.cbResultImagePattern.Size = new System.Drawing.Size(224, 29);
            this.cbResultImagePattern.TabIndex = 6;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel6.Location = new System.Drawing.Point(2, 62);
            this.uiLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(147, 31);
            this.uiLabel6.TabIndex = 5;
            this.uiLabel6.Text = "保存类型：";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel5.Location = new System.Drawing.Point(2, 31);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(147, 31);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "保存天数：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiLabel4.Location = new System.Drawing.Point(2, 0);
            this.uiLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(147, 31);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "保存格式：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel_ResultPath
            // 
            this.uiTableLayoutPanel3.SetColumnSpan(this.uiPanel_ResultPath, 2);
            this.uiPanel_ResultPath.Controls.Add(this.lbResultPosition);
            this.uiPanel_ResultPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel_ResultPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel_ResultPath.Location = new System.Drawing.Point(2, 259);
            this.uiPanel_ResultPath.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.uiPanel_ResultPath.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel_ResultPath.Name = "uiPanel_ResultPath";
            this.uiPanel_ResultPath.Size = new System.Drawing.Size(375, 56);
            this.uiPanel_ResultPath.TabIndex = 0;
            // 
            // lbResultPosition
            // 
            this.lbResultPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResultPosition.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbResultPosition.Location = new System.Drawing.Point(0, 0);
            this.lbResultPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResultPosition.Name = "lbResultPosition";
            this.lbResultPosition.Size = new System.Drawing.Size(375, 56);
            this.lbResultPosition.TabIndex = 0;
            this.lbResultPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeResultPosition
            // 
            this.btnChangeResultPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeResultPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeResultPosition.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnChangeResultPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.btnChangeResultPosition.Location = new System.Drawing.Point(2, 221);
            this.btnChangeResultPosition.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeResultPosition.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChangeResultPosition.Name = "btnChangeResultPosition";
            this.btnChangeResultPosition.Size = new System.Drawing.Size(147, 33);
            this.btnChangeResultPosition.TabIndex = 1;
            this.btnChangeResultPosition.Text = "更改图像路径";
            this.btnChangeResultPosition.Click += new System.EventHandler(this.btnChangeResultPosition_Click);
            // 
            // radioChanceResultIsSave
            // 
            this.radioChanceResultIsSave.BackColor = System.Drawing.SystemColors.Control;
            this.radioChanceResultIsSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioChanceResultIsSave.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioChanceResultIsSave.FormattingEnabled = true;
            this.radioChanceResultIsSave.ItemHeight = 20;
            this.radioChanceResultIsSave.Items.AddRange(new object[] {
            "都不保存",
            "仅OK保存",
            "仅NG保存",
            "全部保存"});
            this.radioChanceResultIsSave.Location = new System.Drawing.Point(153, 64);
            this.radioChanceResultIsSave.Margin = new System.Windows.Forms.Padding(2);
            this.radioChanceResultIsSave.Name = "radioChanceResultIsSave";
            this.radioChanceResultIsSave.Size = new System.Drawing.Size(224, 153);
            this.radioChanceResultIsSave.TabIndex = 8;
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(855, 47);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "保存设置";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(802, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(53, 47);
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.uiPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(855, 506);
            this.splitContainer2.SplitterDistance = 47;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonClose);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 47);
            this.panel1.TabIndex = 15;
            // 
            // FrmImageStoreSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 506);
            this.Controls.Add(this.splitContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmImageStoreSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图像";
            this.uiPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiGroupBoxRaw.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDRawKeepingDays)).EndInit();
            this.uiPanelRawPath.ResumeLayout(false);
            this.uiGroupBoxResult.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDResultKeepingDays)).EndInit();
            this.uiPanel_ResultPath.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Panel uiPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TableLayoutPanel uiTableLayoutPanel1;
        private GroupBox uiGroupBoxResult;
        private TableLayoutPanel uiTableLayoutPanel3;
        public NumericUpDown numUDResultKeepingDays;
        public ComboBox cbResultImagePattern;
        private Label uiLabel6;
        private Label uiLabel5;
        private Label uiLabel4;
        private Panel uiPanel_ResultPath;
        private Label lbResultPosition;
        private Button btnChangeResultPosition;
        private Button uiSymbolButton1;
        private GroupBox uiGroupBoxRaw;
        private TableLayoutPanel uiTableLayoutPanel2;
        public NumericUpDown numUDRawKeepingDays;
        public ComboBox cbRawImagePattern;
        private Panel uiPanelRawPath;
        private Label lbRawPosition;
        private Button btnChangeRawPosition;
        private Label uiLabel1;
        private Label uiLabel2;
        private Label uiLabel3;
        private ListBox radioChanceRawIsSave;
        private ListBox radioChanceResultIsSave;
        private Label LabelTitle;
        private Button ButtonClose;
        private SplitContainer splitContainer2;
        private Panel panel1;
    }
}