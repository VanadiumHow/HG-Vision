using Sunny.UI;

namespace HG_Vision.UIHome
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelGuodu4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelRunMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelGuodu2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelStartTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelGuodu3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerRefreshDate = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanelAll = new Sunny.UI.UITableLayoutPanel();
            this.TableLayoutPanelMain = new Sunny.UI.UITableLayoutPanel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PanelVisionMain = new System.Windows.Forms.Panel();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ButtonShrinkPage = new System.Windows.Forms.Button();
            this.PanelRightMain = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.LabelProgramTitle = new System.Windows.Forms.Label();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerLogout = new System.Windows.Forms.Timer(this.components);
            this.TableLayoutPanelAll.SuspendLayout();
            this.TableLayoutPanelMain.SuspendLayout();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Location = new System.Drawing.Point(102, 5);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(100, 49);
            this.ButtonLogin.TabIndex = 30;
            this.ButtonLogin.Tag = "3";
            this.ToolTip1.SetToolTip(this.ButtonLogin, "用户登录");
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonSetting
            // 
            this.ButtonSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSetting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSetting.BackgroundImage")));
            this.ButtonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSetting.Enabled = false;
            this.ButtonSetting.FlatAppearance.BorderSize = 0;
            this.ButtonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetting.Location = new System.Drawing.Point(202, 6);
            this.ButtonSetting.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(100, 49);
            this.ButtonSetting.TabIndex = 28;
            this.ButtonSetting.Tag = "4";
            this.ToolTip1.SetToolTip(this.ButtonSetting, "系统设置");
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonStart.BackgroundImage")));
            this.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Location = new System.Drawing.Point(2, 5);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 49);
            this.ButtonStart.TabIndex = 26;
            this.ButtonStart.Tag = "0";
            this.ToolTip1.SetToolTip(this.ButtonStart, "启动");
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClose.BackgroundImage")));
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonClose.Location = new System.Drawing.Point(1231, 2);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(38, 28);
            this.ButtonClose.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.ButtonClose, "关闭程序");
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMin.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonMin.BackgroundImage")));
            this.ButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonMin.ForeColor = System.Drawing.Color.White;
            this.ButtonMin.Location = new System.Drawing.Point(1181, 2);
            this.ButtonMin.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(40, 28);
            this.ButtonMin.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.ButtonMin, "最小化");
            this.ButtonMin.UseVisualStyleBackColor = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Location = new System.Drawing.Point(0, 938);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 7, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1280, 22);
            this.StatusStrip1.TabIndex = 28;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabel1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel1.Image")));
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(94, 24);
            this.ToolStripStatusLabel1.Text = "当前角色：";
            // 
            // ToolStripStatusLabelUserRole
            // 
            this.ToolStripStatusLabelUserRole.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelUserRole.Name = "ToolStripStatusLabelUserRole";
            this.ToolStripStatusLabelUserRole.Size = new System.Drawing.Size(44, 24);
            this.ToolStripStatusLabelUserRole.Text = "操作员";
            // 
            // ToolStripStatusLabelGuodu4
            // 
            this.ToolStripStatusLabelGuodu4.Name = "ToolStripStatusLabelGuodu4";
            this.ToolStripStatusLabelGuodu4.Size = new System.Drawing.Size(14, 24);
            this.ToolStripStatusLabelGuodu4.Text = "||";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabel2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel2.Image")));
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(94, 24);
            this.ToolStripStatusLabel2.Text = "当前模式：";
            // 
            // ToolStripStatusLabelRunMode
            // 
            this.ToolStripStatusLabelRunMode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelRunMode.ForeColor = System.Drawing.Color.OrangeRed;
            this.ToolStripStatusLabelRunMode.LinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabelRunMode.Name = "ToolStripStatusLabelRunMode";
            this.ToolStripStatusLabelRunMode.Size = new System.Drawing.Size(31, 24);
            this.ToolStripStatusLabelRunMode.Text = "暂停";
            // 
            // ToolStripStatusLabelGuodu2
            // 
            this.ToolStripStatusLabelGuodu2.Name = "ToolStripStatusLabelGuodu2";
            this.ToolStripStatusLabelGuodu2.Size = new System.Drawing.Size(30, 24);
            this.ToolStripStatusLabelGuodu2.Text = "  ||  ";
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabel3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel3.Image")));
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(120, 24);
            this.ToolStripStatusLabel3.Text = "软件开启时间：";
            // 
            // ToolStripStatusLabelStartTime
            // 
            this.ToolStripStatusLabelStartTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelStartTime.Name = "ToolStripStatusLabelStartTime";
            this.ToolStripStatusLabelStartTime.Size = new System.Drawing.Size(19, 24);
            this.ToolStripStatusLabelStartTime.Text = "xx";
            // 
            // ToolStripStatusLabelGuodu3
            // 
            this.ToolStripStatusLabelGuodu3.Name = "ToolStripStatusLabelGuodu3";
            this.ToolStripStatusLabelGuodu3.Size = new System.Drawing.Size(30, 24);
            this.ToolStripStatusLabelGuodu3.Text = "  ||  ";
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabel4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripStatusLabel4.Image")));
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(68, 24);
            this.ToolStripStatusLabel4.Text = "时间：";
            // 
            // ToolStripStatusLabelDate
            // 
            this.ToolStripStatusLabelDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelDate.Name = "ToolStripStatusLabelDate";
            this.ToolStripStatusLabelDate.Size = new System.Drawing.Size(19, 24);
            this.ToolStripStatusLabelDate.Text = "xx";
            // 
            // ToolStripStatusLabelWeek
            // 
            this.ToolStripStatusLabelWeek.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelWeek.Name = "ToolStripStatusLabelWeek";
            this.ToolStripStatusLabelWeek.Size = new System.Drawing.Size(19, 24);
            this.ToolStripStatusLabelWeek.Text = "xx";
            // 
            // ToolStripStatusLabelTime
            // 
            this.ToolStripStatusLabelTime.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripStatusLabelTime.Name = "ToolStripStatusLabelTime";
            this.ToolStripStatusLabelTime.Size = new System.Drawing.Size(19, 24);
            this.ToolStripStatusLabelTime.Text = "xx";
            // 
            // TimerRefreshDate
            // 
            this.TimerRefreshDate.Interval = 1000;
            this.TimerRefreshDate.Tick += new System.EventHandler(this.timerRefreshDate_Tick);
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Controls.Add(this.TableLayoutPanelMain, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1280, 938);
            this.TableLayoutPanelAll.TabIndex = 31;
            this.TableLayoutPanelAll.TagString = null;
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelMain.ColumnCount = 1;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.Controls.Add(this.PanelMain, 0, 2);
            this.TableLayoutPanelMain.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 30);
            this.TableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 3;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(1280, 915);
            this.TableLayoutPanelMain.TabIndex = 30;
            this.TableLayoutPanelMain.TagString = null;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.SystemColors.GrayText;
            this.PanelMain.Controls.Add(this.SplitContainer1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.ForeColor = System.Drawing.Color.Transparent;
            this.PanelMain.Location = new System.Drawing.Point(0, 64);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1280, 851);
            this.PanelMain.TabIndex = 34;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.PanelVisionMain);
            this.SplitContainer1.Panel1MinSize = 1000;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Panel2MinSize = 16;
            this.SplitContainer1.Size = new System.Drawing.Size(1280, 851);
            this.SplitContainer1.SplitterDistance = 1000;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 0;
            // 
            // PanelVisionMain
            // 
            this.PanelVisionMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelVisionMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelVisionMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelVisionMain.Location = new System.Drawing.Point(0, 0);
            this.PanelVisionMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelVisionMain.Name = "PanelVisionMain";
            this.PanelVisionMain.Size = new System.Drawing.Size(1000, 851);
            this.PanelVisionMain.TabIndex = 0;
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.IsSplitterFixed = true;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer2.Panel1.Controls.Add(this.ButtonShrinkPage);
            this.SplitContainer2.Panel1MinSize = 15;
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.PanelRightMain);
            this.SplitContainer2.Panel2MinSize = 16;
            this.SplitContainer2.Size = new System.Drawing.Size(279, 851);
            this.SplitContainer2.SplitterDistance = 25;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // ButtonShrinkPage
            // 
            this.ButtonShrinkPage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonShrinkPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonShrinkPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShrinkPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonShrinkPage.FlatAppearance.BorderSize = 0;
            this.ButtonShrinkPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShrinkPage.Location = new System.Drawing.Point(0, 0);
            this.ButtonShrinkPage.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonShrinkPage.Name = "ButtonShrinkPage";
            this.ButtonShrinkPage.Size = new System.Drawing.Size(25, 851);
            this.ButtonShrinkPage.TabIndex = 3;
            this.ButtonShrinkPage.UseVisualStyleBackColor = false;
            this.ButtonShrinkPage.Click += new System.EventHandler(this.ButtonShrinkPage_Click);
            // 
            // PanelRightMain
            // 
            this.PanelRightMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelRightMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRightMain.Location = new System.Drawing.Point(0, 0);
            this.PanelRightMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRightMain.Name = "PanelRightMain";
            this.PanelRightMain.Size = new System.Drawing.Size(253, 851);
            this.PanelRightMain.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.ButtonLogin);
            this.Panel2.Controls.Add(this.ButtonSetting);
            this.Panel2.Controls.Add(this.ButtonStart);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1280, 60);
            this.Panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(585, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 60);
            this.panel3.TabIndex = 33;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.Panel1.Controls.Add(this.ButtonClose);
            this.Panel1.Controls.Add(this.ButtonMin);
            this.Panel1.Controls.Add(this.LabelProgramTitle);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1280, 30);
            this.Panel1.TabIndex = 1;
            // 
            // LabelProgramTitle
            // 
            this.LabelProgramTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelProgramTitle.AutoSize = true;
            this.LabelProgramTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.LabelProgramTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.LabelProgramTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.LabelProgramTitle.Location = new System.Drawing.Point(11, 2);
            this.LabelProgramTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProgramTitle.Name = "LabelProgramTitle";
            this.LabelProgramTitle.Size = new System.Drawing.Size(74, 22);
            this.LabelProgramTitle.TabIndex = 1;
            this.LabelProgramTitle.Text = "焊接程序";
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // TimerLogout
            // 
            this.TimerLogout.Interval = 5000;
            this.TimerLogout.Tick += new System.EventHandler(this.TimerLogout_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1280, 960);
            this.Controls.Add(this.TableLayoutPanelAll);
            this.Controls.Add(this.StatusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHome";
            this.Text = "VisionProgram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Activated += new System.EventHandler(this.FrmHome_Activated);
            this.Deactivate += new System.EventHandler(this.FrmHome_Deactivate);
            this.Resize += new System.EventHandler(this.FrmHome_Resize);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelUserRole;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelGuodu4;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelRunMode;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelGuodu2;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelStartTime;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelGuodu3;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelWeek;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelTime;
        private System.Windows.Forms.Timer TimerRefreshDate;
        private UITableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMin;
        internal System.Windows.Forms.Label LabelProgramTitle;
        private UITableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.Panel PanelVisionMain;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.Button ButtonShrinkPage;
        private System.Windows.Forms.Panel PanelRightMain;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonSetting;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer TimerLogout;
    }
}