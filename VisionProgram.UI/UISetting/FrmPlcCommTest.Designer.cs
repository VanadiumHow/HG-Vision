namespace VisionProgram.UI.UISetting
{
    partial class FrmPlcCommTest
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
            this.components = new System.ComponentModel.Container();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonUpAll = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonWrite = new System.Windows.Forms.Button();
            this.ButtonRead = new System.Windows.Forms.Button();
            this.PanelListView1 = new System.Windows.Forms.Panel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.PanelListView2 = new System.Windows.Forms.Panel();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.PanelText = new System.Windows.Forms.Panel();
            this.TextBoxEXText = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelPlcStatus = new System.Windows.Forms.Label();
            this.ComboBoxEXIP = new VisionProgram.UserControls.UIComboBox.ComboBoxEX();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxPort = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RichTextBoxRecord = new System.Windows.Forms.RichTextBox();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelAll = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TableLayoutPanelMain.SuspendLayout();
            this.TableLayoutPanelContent.SuspendLayout();
            this.PanelListView1.SuspendLayout();
            this.PanelListView2.SuspendLayout();
            this.PanelText.SuspendLayout();
            this.PanelTop.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.PanelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.TableLayoutPanelMain);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Size = new System.Drawing.Size(1285, 805);
            this.SplitContainer1.SplitterDistance = 721;
            this.SplitContainer1.SplitterWidth = 3;
            this.SplitContainer1.TabIndex = 3;
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.ColumnCount = 1;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelMain.Controls.Add(this.TableLayoutPanelContent, 0, 1);
            this.TableLayoutPanelMain.Controls.Add(this.PanelTop, 0, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 2;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(721, 805);
            this.TableLayoutPanelMain.TabIndex = 21;
            // 
            // TableLayoutPanelContent
            // 
            this.TableLayoutPanelContent.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelContent.ColumnCount = 5;
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.9F));
            this.TableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.1F));
            this.TableLayoutPanelContent.Controls.Add(this.ButtonDown, 0, 1);
            this.TableLayoutPanelContent.Controls.Add(this.ButtonUpAll, 2, 1);
            this.TableLayoutPanelContent.Controls.Add(this.ButtonUp, 1, 1);
            this.TableLayoutPanelContent.Controls.Add(this.ButtonWrite, 1, 3);
            this.TableLayoutPanelContent.Controls.Add(this.ButtonRead, 0, 3);
            this.TableLayoutPanelContent.Controls.Add(this.PanelListView1, 0, 0);
            this.TableLayoutPanelContent.Controls.Add(this.PanelListView2, 0, 2);
            this.TableLayoutPanelContent.Controls.Add(this.PanelText, 0, 4);
            this.TableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelContent.Location = new System.Drawing.Point(2, 52);
            this.TableLayoutPanelContent.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayoutPanelContent.Name = "TableLayoutPanelContent";
            this.TableLayoutPanelContent.RowCount = 6;
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.00199F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.170877F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.48517F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.170877F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.170877F));
            this.TableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.000203F));
            this.TableLayoutPanelContent.Size = new System.Drawing.Size(717, 794);
            this.TableLayoutPanelContent.TabIndex = 20;
            // 
            // ButtonDown
            // 
            this.ButtonDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonDown.Enabled = false;
            this.ButtonDown.FlatAppearance.BorderSize = 2;
            this.ButtonDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDown.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonDown.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonDown.Location = new System.Drawing.Point(0, 389);
            this.ButtonDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(71, 41);
            this.ButtonDown.TabIndex = 24;
            this.ButtonDown.Text = "↓";
            this.ButtonDown.UseVisualStyleBackColor = false;
            this.ButtonDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // ButtonUpAll
            // 
            this.ButtonUpAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonUpAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUpAll.FlatAppearance.BorderSize = 2;
            this.ButtonUpAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonUpAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonUpAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpAll.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpAll.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonUpAll.Location = new System.Drawing.Point(142, 389);
            this.ButtonUpAll.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUpAll.Name = "ButtonUpAll";
            this.ButtonUpAll.Size = new System.Drawing.Size(71, 41);
            this.ButtonUpAll.TabIndex = 26;
            this.ButtonUpAll.Text = "X";
            this.ButtonUpAll.UseVisualStyleBackColor = false;
            this.ButtonUpAll.Click += new System.EventHandler(this.BtnUpAll_Click);
            // 
            // ButtonUp
            // 
            this.ButtonUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.ButtonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonUp.Enabled = false;
            this.ButtonUp.FlatAppearance.BorderSize = 2;
            this.ButtonUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonUp.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonUp.Location = new System.Drawing.Point(71, 389);
            this.ButtonUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(71, 41);
            this.ButtonUp.TabIndex = 25;
            this.ButtonUp.Text = "↑";
            this.ButtonUp.UseVisualStyleBackColor = false;
            this.ButtonUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonWrite.FlatAppearance.BorderSize = 2;
            this.ButtonWrite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonWrite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWrite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonWrite.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonWrite.Location = new System.Drawing.Point(71, 672);
            this.ButtonWrite.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Size = new System.Drawing.Size(71, 41);
            this.ButtonWrite.TabIndex = 29;
            this.ButtonWrite.Text = "写入";
            this.ButtonWrite.UseVisualStyleBackColor = false;
            this.ButtonWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // ButtonRead
            // 
            this.ButtonRead.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonRead.FlatAppearance.BorderSize = 2;
            this.ButtonRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonRead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.ButtonRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRead.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonRead.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonRead.Location = new System.Drawing.Point(0, 672);
            this.ButtonRead.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(71, 41);
            this.ButtonRead.TabIndex = 28;
            this.ButtonRead.Text = "读取";
            this.ButtonRead.UseVisualStyleBackColor = false;
            this.ButtonRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // PanelListView1
            // 
            this.TableLayoutPanelContent.SetColumnSpan(this.PanelListView1, 4);
            this.PanelListView1.Controls.Add(this.ListView1);
            this.PanelListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListView1.Location = new System.Drawing.Point(0, 0);
            this.PanelListView1.Margin = new System.Windows.Forms.Padding(0);
            this.PanelListView1.Name = "PanelListView1";
            this.PanelListView1.Padding = new System.Windows.Forms.Padding(2);
            this.PanelListView1.Size = new System.Drawing.Size(714, 389);
            this.PanelListView1.TabIndex = 33;
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.SystemColors.Window;
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(2, 2);
            this.ListView1.Margin = new System.Windows.Forms.Padding(2);
            this.ListView1.Name = "ListView1";
            this.ListView1.ShowItemToolTips = true;
            this.ListView1.Size = new System.Drawing.Size(710, 385);
            this.ListView1.TabIndex = 32;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // PanelListView2
            // 
            this.TableLayoutPanelContent.SetColumnSpan(this.PanelListView2, 4);
            this.PanelListView2.Controls.Add(this.ListView2);
            this.PanelListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelListView2.Location = new System.Drawing.Point(0, 430);
            this.PanelListView2.Margin = new System.Windows.Forms.Padding(0);
            this.PanelListView2.Name = "PanelListView2";
            this.PanelListView2.Padding = new System.Windows.Forms.Padding(2);
            this.PanelListView2.Size = new System.Drawing.Size(714, 242);
            this.PanelListView2.TabIndex = 34;
            // 
            // ListView2
            // 
            this.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView2.FullRowSelect = true;
            this.ListView2.Location = new System.Drawing.Point(2, 2);
            this.ListView2.Margin = new System.Windows.Forms.Padding(2);
            this.ListView2.Name = "ListView2";
            this.ListView2.ShowItemToolTips = true;
            this.ListView2.Size = new System.Drawing.Size(710, 238);
            this.ListView2.TabIndex = 28;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            this.ListView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // PanelText
            // 
            this.PanelText.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelContent.SetColumnSpan(this.PanelText, 4);
            this.PanelText.Controls.Add(this.TextBoxEXText);
            this.PanelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelText.Location = new System.Drawing.Point(0, 713);
            this.PanelText.Margin = new System.Windows.Forms.Padding(0);
            this.PanelText.Name = "PanelText";
            this.PanelText.Size = new System.Drawing.Size(714, 41);
            this.PanelText.TabIndex = 35;
            // 
            // TextBoxEXText
            // 
            this.TextBoxEXText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEXText.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxEXText.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxEXText.BorderSize = 1;
            this.TextBoxEXText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEXText.Location = new System.Drawing.Point(2, 5);
            this.TextBoxEXText.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxEXText.Multiline = false;
            this.TextBoxEXText.Name = "TextBoxEXText";
            this.TextBoxEXText.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxEXText.PasswordChar = false;
            this.TextBoxEXText.ReadOnly = false;
            this.TextBoxEXText.Size = new System.Drawing.Size(712, 33);
            this.TextBoxEXText.TabIndex = 0;
            this.TextBoxEXText.UnderlinedStyle = false;
            this.TextBoxEXText.WatermarkText = null;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.LabelPlcStatus);
            this.PanelTop.Controls.Add(this.ComboBoxEXIP);
            this.PanelTop.Controls.Add(this.Label1);
            this.PanelTop.Controls.Add(this.TextBoxPort);
            this.PanelTop.Controls.Add(this.Label2);
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(715, 50);
            this.PanelTop.TabIndex = 19;
            // 
            // LabelPlcStatus
            // 
            this.LabelPlcStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelPlcStatus.AutoSize = true;
            this.LabelPlcStatus.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelPlcStatus.Location = new System.Drawing.Point(446, 15);
            this.LabelPlcStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlcStatus.Name = "LabelPlcStatus";
            this.LabelPlcStatus.Size = new System.Drawing.Size(92, 27);
            this.LabelPlcStatus.TabIndex = 16;
            this.LabelPlcStatus.Text = "连接状态";
            // 
            // ComboBoxEXIP
            // 
            this.ComboBoxEXIP.BackColor = System.Drawing.SystemColors.Window;
            this.ComboBoxEXIP.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxEXIP.BorderSize = 1;
            this.ComboBoxEXIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxEXIP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBoxEXIP.ForeColor = System.Drawing.Color.DimGray;
            this.ComboBoxEXIP.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ComboBoxEXIP.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.ComboBoxEXIP.ListTextColor = System.Drawing.Color.DimGray;
            this.ComboBoxEXIP.Location = new System.Drawing.Point(45, 11);
            this.ComboBoxEXIP.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBoxEXIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.ComboBoxEXIP.Name = "ComboBoxEXIP";
            this.ComboBoxEXIP.Padding = new System.Windows.Forms.Padding(1);
            this.ComboBoxEXIP.Size = new System.Drawing.Size(227, 30);
            this.ComboBoxEXIP.TabIndex = 15;
            this.ComboBoxEXIP.Texts = "";
            this.ComboBoxEXIP.OnSelectedIndexChanged += new System.EventHandler(this.CbPlcIp_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(15, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 27);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "IP";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxPort.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxPort.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxPort.BorderSize = 1;
            this.TextBoxPort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxPort.Location = new System.Drawing.Point(320, 11);
            this.TextBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPort.Multiline = false;
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxPort.PasswordChar = false;
            this.TextBoxPort.ReadOnly = true;
            this.TextBoxPort.Size = new System.Drawing.Size(98, 36);
            this.TextBoxPort.TabIndex = 13;
            this.TextBoxPort.UnderlinedStyle = false;
            this.TextBoxPort.WatermarkText = null;
            // 
            // Label2
            // 
            this.Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(274, 15);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 27);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Port";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.RichTextBoxRecord);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(8, 5, 5, 10);
            this.GroupBox1.Size = new System.Drawing.Size(561, 805);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "读写记录";
            // 
            // RichTextBoxRecord
            // 
            this.RichTextBoxRecord.BackColor = System.Drawing.Color.GhostWhite;
            this.RichTextBoxRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RichTextBoxRecord.ContextMenuStrip = this.ContextMenuStrip1;
            this.RichTextBoxRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBoxRecord.Location = new System.Drawing.Point(8, 32);
            this.RichTextBoxRecord.Margin = new System.Windows.Forms.Padding(2);
            this.RichTextBoxRecord.Name = "RichTextBoxRecord";
            this.RichTextBoxRecord.ReadOnly = true;
            this.RichTextBoxRecord.Size = new System.Drawing.Size(548, 763);
            this.RichTextBoxRecord.TabIndex = 2;
            this.RichTextBoxRecord.Text = "";
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空记录ToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 清空记录ToolStripMenuItem
            // 
            this.清空记录ToolStripMenuItem.Name = "清空记录ToolStripMenuItem";
            this.清空记录ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.清空记录ToolStripMenuItem.Text = "清空记录";
            this.清空记录ToolStripMenuItem.Click += new System.EventHandler(this.清空记录ToolStripMenuItem_Click);
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
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1288, 848);
            this.TableLayoutPanelAll.TabIndex = 7;
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
            this.PanelHeader.Size = new System.Drawing.Size(1288, 40);
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
            this.Label3.Text = " PLC读写测试";
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
            this.ButtonClose.Location = new System.Drawing.Point(1248, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(40, 40);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.SplitContainer1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 40);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.PanelMain.Size = new System.Drawing.Size(1288, 808);
            this.PanelMain.TabIndex = 0;
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
            this.PanelAll.Size = new System.Drawing.Size(1290, 850);
            this.PanelAll.TabIndex = 8;
            // 
            // FrmPlcCommTest
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1290, 850);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1290, 850);
            this.MinimumSize = new System.Drawing.Size(1290, 850);
            this.Name = "FrmPlcCommTest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLC读写测试";
            this.Load += new System.EventHandler(this.FrmPlcCommTest_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.TableLayoutPanelContent.ResumeLayout(false);
            this.PanelListView1.ResumeLayout(false);
            this.PanelListView2.ResumeLayout(false);
            this.PanelText.ResumeLayout(false);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.Panel PanelTop;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxPort;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelContent;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.Button ButtonUpAll;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonWrite;
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清空记录ToolStripMenuItem;
        private System.Windows.Forms.Label LabelPlcStatus;
        private VisionProgram.UserControls.UIComboBox.ComboBoxEX ComboBoxEXIP;
        private System.Windows.Forms.RichTextBox RichTextBoxRecord;
        private System.Windows.Forms.Panel PanelListView1;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Panel PanelListView2;
        private System.Windows.Forms.ListView ListView2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelAll;
        public System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel PanelText;
        private UserControls.UITextBox.TextBoxEX TextBoxEXText;
    }
}