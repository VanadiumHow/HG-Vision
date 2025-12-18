using System.Windows.Forms;
using Sunny.UI;
namespace HG_Vision.UIVision
{
    partial class FrmVpVisionControl : Form
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.单帧ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单帧2工位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处理2工位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看图片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.lbSerialNum = new System.Windows.Forms.Label();
            this.lbImageName = new System.Windows.Forms.Label();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordsDisplay();
            this.tbExposeReal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单帧ToolStripMenuItem,
            this.单帧2工位ToolStripMenuItem,
            this.实时ToolStripMenuItem,
            this.打开图片ToolStripMenuItem,
            this.处理ToolStripMenuItem,
            this.处理2工位ToolStripMenuItem,
            this.查看图片ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(1500, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "打开图片";
            // 
            // 单帧ToolStripMenuItem
            // 
            this.单帧ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.单帧ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.单帧ToolStripMenuItem.Name = "单帧ToolStripMenuItem";
            this.单帧ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.单帧ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.单帧ToolStripMenuItem.Text = "单帧1工位";
            this.单帧ToolStripMenuItem.Click += new System.EventHandler(this.单帧ToolStripMenuItem_Click);
            // 
            // 单帧2工位ToolStripMenuItem
            // 
            this.单帧2工位ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.单帧2工位ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.单帧2工位ToolStripMenuItem.Name = "单帧2工位ToolStripMenuItem";
            this.单帧2工位ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.单帧2工位ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.单帧2工位ToolStripMenuItem.Text = "单帧2工位";
            this.单帧2工位ToolStripMenuItem.Click += new System.EventHandler(this.单帧2工位ToolStripMenuItem_Click);
            // 
            // 实时ToolStripMenuItem
            // 
            this.实时ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.实时ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.实时ToolStripMenuItem.Name = "实时ToolStripMenuItem";
            this.实时ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.实时ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.实时ToolStripMenuItem.Text = "开始实时";
            this.实时ToolStripMenuItem.Click += new System.EventHandler(this.实时ToolStripMenuItem_Click);
            // 
            // 打开图片ToolStripMenuItem
            // 
            this.打开图片ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.打开图片ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.打开图片ToolStripMenuItem.Name = "打开图片ToolStripMenuItem";
            this.打开图片ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.打开图片ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.打开图片ToolStripMenuItem.Text = "打开图片";
            this.打开图片ToolStripMenuItem.Click += new System.EventHandler(this.打开图片ToolStripMenuItem_Click);
            // 
            // 处理ToolStripMenuItem
            // 
            this.处理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.处理ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.处理ToolStripMenuItem.Name = "处理ToolStripMenuItem";
            this.处理ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.处理ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.处理ToolStripMenuItem.Text = "处理1工位";
            this.处理ToolStripMenuItem.Click += new System.EventHandler(this.处理ToolStripMenuItem_Click);
            // 
            // 处理2工位ToolStripMenuItem
            // 
            this.处理2工位ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.处理2工位ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.处理2工位ToolStripMenuItem.Name = "处理2工位ToolStripMenuItem";
            this.处理2工位ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.处理2工位ToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.处理2工位ToolStripMenuItem.Text = "处理2工位";
            this.处理2工位ToolStripMenuItem.Click += new System.EventHandler(this.处理2工位ToolStripMenuItem_Click);
            // 
            // 查看图片ToolStripMenuItem
            // 
            this.查看图片ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.查看图片ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.查看图片ToolStripMenuItem.Name = "查看图片ToolStripMenuItem";
            this.查看图片ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.查看图片ToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.查看图片ToolStripMenuItem.Text = "图片文件夹";
            this.查看图片ToolStripMenuItem.Click += new System.EventHandler(this.查看图片ToolStripMenuItem_Click);
            // 
            // 工具设置ToolStripMenuItem
            // 
            this.工具设置ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.工具设置ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.工具设置ToolStripMenuItem.Name = "工具设置ToolStripMenuItem";
            this.工具设置ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.工具设置ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.工具设置ToolStripMenuItem.Text = "工具";
            this.工具设置ToolStripMenuItem.Click += new System.EventHandler(this.工具设置ToolStripMenuItem_Click);
            // 
            // 图片保存ToolStripMenuItem
            // 
            this.图片保存ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.图片保存ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.图片保存ToolStripMenuItem.Name = "图片保存ToolStripMenuItem";
            this.图片保存ToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.图片保存ToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.图片保存ToolStripMenuItem.Text = "存图设置";
            this.图片保存ToolStripMenuItem.Click += new System.EventHandler(this.图片保存ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 932);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cogRecordDisplay1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1500, 932);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.TagString = null;
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiTableLayoutPanel1.ColumnCount = 3;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.uiTableLayoutPanel1.Controls.Add(this.lbSerialNum, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lbImageName, 0, 0);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 1;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1496, 13);
            this.uiTableLayoutPanel1.TabIndex = 1;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // lbSerialNum
            // 
            this.lbSerialNum.AutoSize = true;
            this.lbSerialNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSerialNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbSerialNum.Location = new System.Drawing.Point(449, 0);
            this.lbSerialNum.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbSerialNum.Name = "lbSerialNum";
            this.lbSerialNum.Size = new System.Drawing.Size(46, 13);
            this.lbSerialNum.TabIndex = 4;
            this.lbSerialNum.Text = "序列号";
            this.lbSerialNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbImageName
            // 
            this.lbImageName.AutoSize = true;
            this.lbImageName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbImageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbImageName.Location = new System.Drawing.Point(1, 0);
            this.lbImageName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbImageName.Name = "lbImageName";
            this.lbImageName.Size = new System.Drawing.Size(46, 13);
            this.lbImageName.TabIndex = 3;
            this.lbImageName.Text = "窗口名";
            this.lbImageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(2, 19);
            this.cogRecordDisplay1.Margin = new System.Windows.Forms.Padding(2);
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.SelectedRecordKey = null;
            this.cogRecordDisplay1.ShowRecordsDropDown = true;
            this.cogRecordDisplay1.Size = new System.Drawing.Size(1496, 911);
            this.cogRecordDisplay1.Subject = null;
            this.cogRecordDisplay1.TabIndex = 2;
            // 
            // tbExposeReal
            // 
            this.tbExposeReal.BackColor = System.Drawing.Color.White;
            this.tbExposeReal.Font = new System.Drawing.Font("宋体", 9F);
            this.tbExposeReal.Location = new System.Drawing.Point(864, 1);
            this.tbExposeReal.Name = "tbExposeReal";
            this.tbExposeReal.Size = new System.Drawing.Size(54, 21);
            this.tbExposeReal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(814, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "实时曝光：";
            // 
            // FrmVpVisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1500, 958);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExposeReal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmVpVisionControl";
            this.Text = "工具栏";
            this.Load += new System.EventHandler(this.FrmVisionControl_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 打开图片ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单帧ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具设置ToolStripMenuItem;
        private UITableLayoutPanel tableLayoutPanel1;
        private UITableLayoutPanel uiTableLayoutPanel1;
        private Label lbSerialNum;
        public Label lbImageName;
        private Cognex.VisionPro.CogRecordsDisplay cogRecordDisplay1;
        private ToolStripMenuItem 图片保存ToolStripMenuItem;
        private ToolStripMenuItem 查看图片ToolStripMenuItem;
        private ToolStripMenuItem 单帧2工位ToolStripMenuItem;
        private ToolStripMenuItem 处理2工位ToolStripMenuItem;
        private TextBox tbExposeReal;
        private Label label1;
    }
}