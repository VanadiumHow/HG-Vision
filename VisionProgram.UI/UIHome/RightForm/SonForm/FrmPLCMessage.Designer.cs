namespace VisionProgram.UI.UIHome.RightForm
{
    partial class FrmPLCMessage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPLCMessage));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清屏PLC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止滚动PLC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.TableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.PanelData = new System.Windows.Forms.Panel();
            this.DataGridViewMessage = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumnTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumnInfo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTool = new System.Windows.Forms.Panel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.TableLayoutPanelMain.SuspendLayout();
            this.PanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMessage)).BeginInit();
            this.PanelTool.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 清屏PLC1ToolStripMenuItem
            // 
            this.清屏PLC1ToolStripMenuItem.Name = "清屏PLC1ToolStripMenuItem";
            this.清屏PLC1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清屏PLC1ToolStripMenuItem.Text = "清屏PLC1";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭ToolStripMenuItem.Text = "退出流程信息查看";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 停止滚动PLC1ToolStripMenuItem
            // 
            this.停止滚动PLC1ToolStripMenuItem.Name = "停止滚动PLC1ToolStripMenuItem";
            this.停止滚动PLC1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.停止滚动PLC1ToolStripMenuItem.Text = "停止滚动PLC1";
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
            this.ButtonClose.Location = new System.Drawing.Point(1889, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(53, 50);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "✖";
            this.ToolTip1.SetToolTip(this.ButtonClose, "关闭");
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLayoutPanelAll.Controls.Add(this.PanelMain, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.PanelHeader, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1942, 1102);
            this.TableLayoutPanelAll.TabIndex = 3;
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.TableLayoutPanelMain);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 50);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.PanelMain.Size = new System.Drawing.Size(1942, 1190);
            this.PanelMain.TabIndex = 3;
            // 
            // TableLayoutPanelMain
            // 
            this.TableLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelMain.ColumnCount = 1;
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TableLayoutPanelMain.Controls.Add(this.PanelData, 0, 1);
            this.TableLayoutPanelMain.Controls.Add(this.PanelTool, 0, 0);
            this.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMain.Font = new System.Drawing.Font("宋体", 13.8F);
            this.TableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TableLayoutPanelMain.Name = "TableLayoutPanelMain";
            this.TableLayoutPanelMain.RowCount = 2;
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMain.Size = new System.Drawing.Size(1940, 1186);
            this.TableLayoutPanelMain.TabIndex = 0;
            // 
            // PanelData
            // 
            this.PanelData.ContextMenuStrip = this.ContextMenuStrip1;
            this.PanelData.Controls.Add(this.DataGridViewMessage);
            this.PanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelData.Font = new System.Drawing.Font("宋体", 13.8F);
            this.PanelData.Location = new System.Drawing.Point(0, 38);
            this.PanelData.Margin = new System.Windows.Forms.Padding(0);
            this.PanelData.Name = "PanelData";
            this.PanelData.Size = new System.Drawing.Size(1940, 1148);
            this.PanelData.TabIndex = 13;
            // 
            // DataGridViewMessage
            // 
            this.DataGridViewMessage.AllowUserToAddRows = false;
            this.DataGridViewMessage.AllowUserToDeleteRows = false;
            this.DataGridViewMessage.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DataGridViewMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 13.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMessage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewMessage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMessage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumnTime1,
            this.DataGridViewTextBoxColumnInfo1});
            this.DataGridViewMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewMessage.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewMessage.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewMessage.Name = "DataGridViewMessage";
            this.DataGridViewMessage.ReadOnly = true;
            this.DataGridViewMessage.RowTemplate.Height = 27;
            this.DataGridViewMessage.Size = new System.Drawing.Size(1940, 1148);
            this.DataGridViewMessage.TabIndex = 13;
            // 
            // DataGridViewTextBoxColumnTime1
            // 
            this.DataGridViewTextBoxColumnTime1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 13.8F);
            this.DataGridViewTextBoxColumnTime1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewTextBoxColumnTime1.Frozen = true;
            this.DataGridViewTextBoxColumnTime1.HeaderText = "时间";
            this.DataGridViewTextBoxColumnTime1.Name = "DataGridViewTextBoxColumnTime1";
            this.DataGridViewTextBoxColumnTime1.ReadOnly = true;
            this.DataGridViewTextBoxColumnTime1.Width = 180;
            // 
            // DataGridViewTextBoxColumnInfo1
            // 
            this.DataGridViewTextBoxColumnInfo1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 13.8F);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTextBoxColumnInfo1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTextBoxColumnInfo1.HeaderText = "信息";
            this.DataGridViewTextBoxColumnInfo1.Name = "DataGridViewTextBoxColumnInfo1";
            this.DataGridViewTextBoxColumnInfo1.ReadOnly = true;
            // 
            // PanelTool
            // 
            this.PanelTool.BackColor = System.Drawing.Color.Transparent;
            this.PanelTool.Controls.Add(this.ToolStrip1);
            this.PanelTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTool.Location = new System.Drawing.Point(0, 0);
            this.PanelTool.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTool.Name = "PanelTool";
            this.PanelTool.Size = new System.Drawing.Size(1940, 38);
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
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(7, 0, 1, 0);
            this.ToolStrip1.Size = new System.Drawing.Size(1940, 38);
            this.ToolStrip1.TabIndex = 13;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(80, 35);
            this.ToolStripButton1.Text = "    PLC1    ";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(17, 35);
            this.toolStripLabel1.Text = "  ";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.PanelHeader.Controls.Add(this.Label1);
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1942, 50);
            this.PanelHeader.TabIndex = 1;
            this.PanelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(263, 50);
            this.Label1.TabIndex = 1;
            this.Label1.Text = " PLC流程信息";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmPLCMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.TableLayoutPanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2400, 1240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "FrmPLCMessage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "交互信息";
            this.Deactivate += new System.EventHandler(this.FrmPLCMessage_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPLCMessage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPLCMessage_FormClosed);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.TableLayoutPanelMain.ResumeLayout(false);
            this.PanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMessage)).EndInit();
            this.PanelTool.ResumeLayout(false);
            this.PanelTool.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清屏PLC1ToolStripMenuItem;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ToolStripMenuItem 停止滚动PLC1ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        public System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMain;
        private System.Windows.Forms.Panel PanelData;
        private System.Windows.Forms.Panel PanelTool;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridViewMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumnInfo1;
    }
}