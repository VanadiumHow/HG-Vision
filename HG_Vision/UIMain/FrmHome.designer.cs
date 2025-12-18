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
            this.ButtonPictureSetting = new System.Windows.Forms.Button();
            this.ButtonVisionTool = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonSetting = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelBreak1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelBreak2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.StripStatusLabelBreak3 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelProgramTitle = new System.Windows.Forms.Label();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerLogout = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonPictureSetting
            // 
            this.ButtonPictureSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPictureSetting.BackgroundImage = global::HG_Vision.Properties.Resources.文件夹设置;
            this.ButtonPictureSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonPictureSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPictureSetting.Enabled = false;
            this.ButtonPictureSetting.FlatAppearance.BorderSize = 0;
            this.ButtonPictureSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonPictureSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPictureSetting.Location = new System.Drawing.Point(402, 5);
            this.ButtonPictureSetting.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPictureSetting.Name = "ButtonPictureSetting";
            this.ButtonPictureSetting.Size = new System.Drawing.Size(100, 49);
            this.ButtonPictureSetting.TabIndex = 35;
            this.ButtonPictureSetting.Tag = "4";
            this.ToolTip1.SetToolTip(this.ButtonPictureSetting, "存图设置");
            this.ButtonPictureSetting.UseVisualStyleBackColor = true;
            this.ButtonPictureSetting.Click += new System.EventHandler(this.ButtonPictureSetting_Click);
            // 
            // ButtonVisionTool
            // 
            this.ButtonVisionTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonVisionTool.BackgroundImage = global::HG_Vision.Properties.Resources.智能;
            this.ButtonVisionTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonVisionTool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVisionTool.Enabled = false;
            this.ButtonVisionTool.FlatAppearance.BorderSize = 0;
            this.ButtonVisionTool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonVisionTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisionTool.Location = new System.Drawing.Point(302, 5);
            this.ButtonVisionTool.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonVisionTool.Name = "ButtonVisionTool";
            this.ButtonVisionTool.Size = new System.Drawing.Size(100, 49);
            this.ButtonVisionTool.TabIndex = 34;
            this.ButtonVisionTool.Tag = "4";
            this.ToolTip1.SetToolTip(this.ButtonVisionTool, "视觉工具");
            this.ButtonVisionTool.UseVisualStyleBackColor = true;
            this.ButtonVisionTool.Click += new System.EventHandler(this.ButtonVisionTool_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonLogin.BackgroundImage = global::HG_Vision.Properties.Resources.未登录;
            this.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
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
            this.ButtonSetting.BackgroundImage = global::HG_Vision.Properties.Resources.螺母;
            this.ButtonSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSetting.Enabled = false;
            this.ButtonSetting.FlatAppearance.BorderSize = 0;
            this.ButtonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSetting.Location = new System.Drawing.Point(202, 5);
            this.ButtonSetting.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSetting.Name = "ButtonSetting";
            this.ButtonSetting.Size = new System.Drawing.Size(100, 49);
            this.ButtonSetting.TabIndex = 28;
            this.ButtonSetting.Tag = "4";
            this.ToolTip1.SetToolTip(this.ButtonSetting, "参数设置");
            this.ButtonSetting.UseVisualStyleBackColor = true;
            this.ButtonSetting.Click += new System.EventHandler(this.ButtonSetting_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStart.BackgroundImage = global::HG_Vision.Properties.Resources.开始;
            this.ButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.FlatAppearance.BorderSize = 0;
            this.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
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
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ButtonClose.BackgroundImage = global::HG_Vision.Properties.Resources.退出;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(1881, 4);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(38, 29);
            this.ButtonClose.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.ButtonClose, "关闭程序");
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonMin
            // 
            this.ButtonMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ButtonMin.BackgroundImage = global::HG_Vision.Properties.Resources.缩小;
            this.ButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.ForeColor = System.Drawing.Color.Black;
            this.ButtonMin.Location = new System.Drawing.Point(1840, 4);
            this.ButtonMin.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(38, 29);
            this.ButtonMin.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.ButtonMin, "最小化");
            this.ButtonMin.UseVisualStyleBackColor = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabelStatus,
            this.StripStatusLabelBreak1,
            this.StripStatusLabelUser,
            this.StripStatusLabelBreak2,
            this.StripStatusLabelTime});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 1058);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 7, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1920, 22);
            this.StatusStrip1.TabIndex = 28;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabelStatus
            // 
            this.StripStatusLabelStatus.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StripStatusLabelStatus.ForeColor = System.Drawing.Color.Orange;
            this.StripStatusLabelStatus.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.StripStatusLabelStatus.Name = "StripStatusLabelStatus";
            this.StripStatusLabelStatus.Size = new System.Drawing.Size(43, 17);
            this.StripStatusLabelStatus.Text = "暂停中";
            // 
            // StripStatusLabelBreak1
            // 
            this.StripStatusLabelBreak1.Name = "StripStatusLabelBreak1";
            this.StripStatusLabelBreak1.Size = new System.Drawing.Size(30, 17);
            this.StripStatusLabelBreak1.Text = "  ||  ";
            // 
            // StripStatusLabelUser
            // 
            this.StripStatusLabelUser.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StripStatusLabelUser.Name = "StripStatusLabelUser";
            this.StripStatusLabelUser.Size = new System.Drawing.Size(67, 17);
            this.StripStatusLabelUser.Text = "当前角色：";
            // 
            // StripStatusLabelBreak2
            // 
            this.StripStatusLabelBreak2.Name = "StripStatusLabelBreak2";
            this.StripStatusLabelBreak2.Size = new System.Drawing.Size(30, 17);
            this.StripStatusLabelBreak2.Text = "  ||  ";
            // 
            // StripStatusLabelTime
            // 
            this.StripStatusLabelTime.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StripStatusLabelTime.Name = "StripStatusLabelTime";
            this.StripStatusLabelTime.Size = new System.Drawing.Size(91, 17);
            this.StripStatusLabelTime.Text = "软件运行时间：";
            // 
            // StripStatusLabelBreak3
            // 
            this.StripStatusLabelBreak3.Name = "StripStatusLabelBreak3";
            this.StripStatusLabelBreak3.Size = new System.Drawing.Size(14, 24);
            this.StripStatusLabelBreak3.Text = "||";
            // 
            // TimerRefreshDate
            // 
            this.TimerRefreshDate.Interval = 1000;
            this.TimerRefreshDate.Tick += new System.EventHandler(this.timerRefreshDate_Tick);
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1920F));
            this.TableLayoutPanelAll.Controls.Add(this.TableLayoutPanelMain, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1920, 1058);
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
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 36);
            this.TableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 3;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(1920, 1022);
            this.TableLayoutPanelMain.TabIndex = 30;
            this.TableLayoutPanelMain.TagString = null;
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.SystemColors.GrayText;
            this.PanelMain.Controls.Add(this.SplitContainer1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.ForeColor = System.Drawing.Color.Transparent;
            this.PanelMain.Location = new System.Drawing.Point(0, 62);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1920, 960);
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
            this.SplitContainer1.Size = new System.Drawing.Size(1920, 960);
            this.SplitContainer1.SplitterDistance = 1500;
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
            this.PanelVisionMain.Size = new System.Drawing.Size(1500, 960);
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
            this.SplitContainer2.Size = new System.Drawing.Size(419, 960);
            this.SplitContainer2.SplitterDistance = 37;
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
            this.ButtonShrinkPage.Size = new System.Drawing.Size(37, 960);
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
            this.PanelRightMain.Size = new System.Drawing.Size(381, 960);
            this.PanelRightMain.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.Panel2.Controls.Add(this.ButtonPictureSetting);
            this.Panel2.Controls.Add(this.ButtonVisionTool);
            this.Panel2.Controls.Add(this.panel3);
            this.Panel2.Controls.Add(this.ButtonLogin);
            this.Panel2.Controls.Add(this.ButtonSetting);
            this.Panel2.Controls.Add(this.ButtonStart);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1920, 60);
            this.Panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(695, 60);
            this.panel3.TabIndex = 33;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Controls.Add(this.ButtonClose);
            this.Panel1.Controls.Add(this.ButtonMin);
            this.Panel1.Controls.Add(this.LabelProgramTitle);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1920, 36);
            this.Panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LabelProgramTitle
            // 
            this.LabelProgramTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelProgramTitle.AutoSize = true;
            this.LabelProgramTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.LabelProgramTitle.Font = new System.Drawing.Font("新細明體-ExtB", 12F);
            this.LabelProgramTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.LabelProgramTitle.Location = new System.Drawing.Point(44, 8);
            this.LabelProgramTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelProgramTitle.Name = "LabelProgramTitle";
            this.LabelProgramTitle.Size = new System.Drawing.Size(167, 16);
            this.LabelProgramTitle.TabIndex = 1;
            this.LabelProgramTitle.Text = "同轴激光焊接视觉软件";
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseClick);
            // 
            // TimerLogout
            // 
            this.TimerLogout.Interval = 6000;
            this.TimerLogout.Tick += new System.EventHandler(this.TimerLogout_Tick);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.TableLayoutPanelAll);
            this.Controls.Add(this.StatusStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHome";
            this.Text = "VisionProgram";
            this.Activated += new System.EventHandler(this.FrmHome_Activated);
            this.Deactivate += new System.EventHandler(this.FrmHome_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.Resize += new System.EventHandler(this.FrmHome_Resize);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelBreak3;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelBreak1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelBreak2;
        private System.Windows.Forms.Timer TimerRefreshDate;
        private UITableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonMin;
        internal System.Windows.Forms.Label LabelProgramTitle;
        internal System.Windows.Forms.NotifyIcon NotifyIcon1;
        private System.Windows.Forms.Timer TimerLogout;
        private UITableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.Panel PanelVisionMain;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.Button ButtonShrinkPage;
        private System.Windows.Forms.Panel PanelRightMain;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonSetting;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonVisionTool;
        private System.Windows.Forms.Button ButtonPictureSetting;
    }
}