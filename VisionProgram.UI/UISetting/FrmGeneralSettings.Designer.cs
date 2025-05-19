namespace VisionProgram.UI.UISetting
{
    partial class FrmGeneralSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneralSettings));
            this.PanelAll = new System.Windows.Forms.Panel();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPic = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_AxisTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelSet = new System.Windows.Forms.TableLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxEXLogSaveDays = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.cb_AutoStart = new System.Windows.Forms.CheckBox();
            this.PanelAll.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.TableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAll
            // 
            this.PanelAll.Controls.Add(this.TableLayoutPanelAll);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.PanelAll.Size = new System.Drawing.Size(1016, 708);
            this.PanelAll.TabIndex = 0;
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.BackColor = System.Drawing.SystemColors.Window;
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Controls.Add(this.ButtonSubmit, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.TableLayoutPanelMain, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 643F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1015, 707);
            this.TableLayoutPanelAll.TabIndex = 77;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSubmit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSubmit.FlatAppearance.BorderSize = 2;
            this.ButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSubmit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonSubmit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonSubmit.Location = new System.Drawing.Point(775, 647);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 60, 10);
            this.ButtonSubmit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(180, 51);
            this.ButtonSubmit.TabIndex = 80;
            this.ButtonSubmit.Text = "应用常规参数";
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.BackColor = System.Drawing.SystemColors.Window;
            this.TableLayoutPanelMain.ColumnCount = 2;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.TableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSet, 0, 0);
            this.TableLayoutPanelMain.Controls.Add(this.tableLayoutPanelPic, 1, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(3, 3);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 1;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 637F));
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(1009, 637);
            this.TableLayoutPanelMain.TabIndex = 75;
            // 
            // tableLayoutPanelPic
            // 
            this.tableLayoutPanelPic.ColumnCount = 2;
            this.tableLayoutPanelPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPic.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanelPic.Controls.Add(this.pictureBox3, 1, 0);
            this.tableLayoutPanelPic.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanelPic.Controls.Add(this.lb_AxisTitle, 0, 0);
            this.tableLayoutPanelPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPic.Location = new System.Drawing.Point(366, 3);
            this.tableLayoutPanelPic.Name = "tableLayoutPanelPic";
            this.tableLayoutPanelPic.RowCount = 2;
            this.tableLayoutPanelPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPic.Size = new System.Drawing.Size(640, 631);
            this.tableLayoutPanelPic.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 318);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 310);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(323, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(314, 309);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_AxisTitle
            // 
            this.lb_AxisTitle.AutoSize = true;
            this.lb_AxisTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_AxisTitle.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold);
            this.lb_AxisTitle.ForeColor = System.Drawing.Color.Black;
            this.lb_AxisTitle.Location = new System.Drawing.Point(3, 0);
            this.lb_AxisTitle.Name = "lb_AxisTitle";
            this.lb_AxisTitle.Size = new System.Drawing.Size(314, 315);
            this.lb_AxisTitle.TabIndex = 6;
            this.lb_AxisTitle.Text = "坐标轴示意图：";
            this.lb_AxisTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelSet
            // 
            this.tableLayoutPanelSet.ColumnCount = 2;
            this.tableLayoutPanelSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSet.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanelSet.Controls.Add(this.TextBoxEXLogSaveDays, 1, 0);
            this.tableLayoutPanelSet.Controls.Add(this.cb_AutoStart, 0, 1);
            this.tableLayoutPanelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSet.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanelSet.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSet.Name = "tableLayoutPanelSet";
            this.tableLayoutPanelSet.RowCount = 10;
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSet.Size = new System.Drawing.Size(357, 631);
            this.tableLayoutPanelSet.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(1, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(176, 63);
            this.Label1.TabIndex = 28;
            this.Label1.Text = "系统日志保存天数：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxEXLogSaveDays
            // 
            this.TextBoxEXLogSaveDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxEXLogSaveDays.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxEXLogSaveDays.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxEXLogSaveDays.BorderSize = 1;
            this.TextBoxEXLogSaveDays.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEXLogSaveDays.ForeColor = System.Drawing.Color.DimGray;
            this.TextBoxEXLogSaveDays.Location = new System.Drawing.Point(192, 15);
            this.TextBoxEXLogSaveDays.Margin = new System.Windows.Forms.Padding(5, 8, 7, 8);
            this.TextBoxEXLogSaveDays.Multiline = false;
            this.TextBoxEXLogSaveDays.Name = "TextBoxEXLogSaveDays";
            this.TextBoxEXLogSaveDays.Padding = new System.Windows.Forms.Padding(5);
            this.TextBoxEXLogSaveDays.PasswordChar = false;
            this.TextBoxEXLogSaveDays.ReadOnly = false;
            this.TextBoxEXLogSaveDays.Size = new System.Drawing.Size(149, 32);
            this.TextBoxEXLogSaveDays.TabIndex = 29;
            this.TextBoxEXLogSaveDays.UnderlinedStyle = false;
            this.TextBoxEXLogSaveDays.WatermarkText = null;
            // 
            // cb_AutoStart
            // 
            this.cb_AutoStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_AutoStart.AutoSize = true;
            this.cb_AutoStart.Location = new System.Drawing.Point(34, 81);
            this.cb_AutoStart.Name = "cb_AutoStart";
            this.cb_AutoStart.Size = new System.Drawing.Size(109, 26);
            this.cb_AutoStart.TabIndex = 31;
            this.cb_AutoStart.Text = "开机自启动";
            this.cb_AutoStart.UseVisualStyleBackColor = true;
            // 
            // FrmGeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 708);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmGeneralSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "常规";
            this.PanelAll.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelPic.ResumeLayout(false);
            this.tableLayoutPanelPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelSet.ResumeLayout(false);
            this.tableLayoutPanelSet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_AxisTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSet;
        internal System.Windows.Forms.Label Label1;
        private UserControls.UITextBox.TextBoxEX TextBoxEXLogSaveDays;
        private System.Windows.Forms.CheckBox cb_AutoStart;
    }
}