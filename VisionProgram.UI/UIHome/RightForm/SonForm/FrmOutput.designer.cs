namespace VisionProgram.UI.UIHome.RightForm
{
    partial class FrmOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOutput));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonError = new System.Windows.Forms.Button();
            this.ButtonWarn = new System.Windows.Forms.Button();
            this.ButtonTip = new System.Windows.Forms.Button();
            this.ButtonAll = new System.Windows.Forms.Button();
            this.ListView1 = new VisionProgram.UserControls.UIListView.ListViewEX();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除ToolStripMenuItem,
            this.历史日志ToolStripMenuItem});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 清除ToolStripMenuItem
            // 
            this.清除ToolStripMenuItem.Name = "清除ToolStripMenuItem";
            this.清除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清除ToolStripMenuItem.Text = "清除";
            this.清除ToolStripMenuItem.Click += new System.EventHandler(this.清除ToolStripMenuItem_Click);
            // 
            // 历史日志ToolStripMenuItem
            // 
            this.历史日志ToolStripMenuItem.Name = "历史日志ToolStripMenuItem";
            this.历史日志ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.历史日志ToolStripMenuItem.Text = "历史日志";
            this.历史日志ToolStripMenuItem.Click += new System.EventHandler(this.历史日志ToolStripMenuItem_Click);
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.TableLayoutPanel1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.ListView1);
            this.SplitContainer1.Size = new System.Drawing.Size(322, 628);
            this.SplitContainer1.SplitterDistance = 32;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 3;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite;
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.Controls.Add(this.ButtonError, 3, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonWarn, 2, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonTip, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonAll, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(322, 30);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // ButtonError
            // 
            this.ButtonError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonError.BackgroundImage")));
            this.ButtonError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonError.FlatAppearance.BorderSize = 0;
            this.ButtonError.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonError.Location = new System.Drawing.Point(242, 2);
            this.ButtonError.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonError.Name = "ButtonError";
            this.ButtonError.Size = new System.Drawing.Size(78, 26);
            this.ButtonError.TabIndex = 3;
            this.ButtonError.UseVisualStyleBackColor = true;
            this.ButtonError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // ButtonWarn
            // 
            this.ButtonWarn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonWarn.BackgroundImage")));
            this.ButtonWarn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonWarn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonWarn.FlatAppearance.BorderSize = 0;
            this.ButtonWarn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonWarn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWarn.Location = new System.Drawing.Point(162, 2);
            this.ButtonWarn.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonWarn.Name = "ButtonWarn";
            this.ButtonWarn.Size = new System.Drawing.Size(76, 26);
            this.ButtonWarn.TabIndex = 2;
            this.ButtonWarn.UseVisualStyleBackColor = true;
            this.ButtonWarn.Click += new System.EventHandler(this.BtnWarn_Click);
            // 
            // ButtonTip
            // 
            this.ButtonTip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonTip.BackgroundImage")));
            this.ButtonTip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonTip.FlatAppearance.BorderSize = 0;
            this.ButtonTip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonTip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTip.Location = new System.Drawing.Point(82, 2);
            this.ButtonTip.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonTip.Name = "ButtonTip";
            this.ButtonTip.Size = new System.Drawing.Size(76, 26);
            this.ButtonTip.TabIndex = 1;
            this.ButtonTip.UseVisualStyleBackColor = true;
            this.ButtonTip.Click += new System.EventHandler(this.BtnTip_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonAll.BackgroundImage")));
            this.ButtonAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAll.FlatAppearance.BorderSize = 0;
            this.ButtonAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ButtonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAll.Location = new System.Drawing.Point(2, 2);
            this.ButtonAll.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.Size = new System.Drawing.Size(76, 26);
            this.ButtonAll.TabIndex = 0;
            this.ButtonAll.UseVisualStyleBackColor = true;
            this.ButtonAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // ListView1
            // 
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView1.ForeColor = System.Drawing.Color.Black;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(0, 0);
            this.ListView1.Margin = new System.Windows.Forms.Padding(2);
            this.ListView1.Name = "ListView1";
            this.ListView1.ShowItemToolTips = true;
            this.ListView1.Size = new System.Drawing.Size(322, 595);
            this.ListView1.TabIndex = 2;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "时间";
            this.ColumnHeader1.Width = 90;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "信息";
            this.ColumnHeader2.Width = 100;
            // 
            // FrmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(322, 630);
            this.Controls.Add(this.SplitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmOutput";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Text = "日志";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Output_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Frm_Output_SizeChanged);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史日志ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button ButtonError;
        private System.Windows.Forms.Button ButtonWarn;
        private System.Windows.Forms.Button ButtonTip;
        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        public VisionProgram.UserControls.UIListView.ListViewEX ListView1;
    }
}