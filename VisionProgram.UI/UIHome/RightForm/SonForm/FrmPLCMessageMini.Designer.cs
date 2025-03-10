namespace VisionProgram.UI.UIHome.RightForm
{
    partial class FrmPLCMessageMini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPLCMessageMini));
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清屏PLC1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.放大窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ListView1 = new VisionProgram.UserControls.UIListView.ListViewEX();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PanelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // 清屏PLC1ToolStripMenuItem
            // 
            this.清屏PLC1ToolStripMenuItem.Name = "清屏PLC1ToolStripMenuItem";
            this.清屏PLC1ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清屏PLC1ToolStripMenuItem.Text = "清屏PLC1";
            // 
            // 放大窗口ToolStripMenuItem
            // 
            this.放大窗口ToolStripMenuItem.Name = "放大窗口ToolStripMenuItem";
            this.放大窗口ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.放大窗口ToolStripMenuItem.Text = "放大窗口";
            this.放大窗口ToolStripMenuItem.Click += new System.EventHandler(this.放大窗口ToolStripMenuItem_Click);
           
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.SystemColors.Window;
            this.PanelAll.Controls.Add(this.SplitContainer1);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(322, 630);
            this.PanelAll.TabIndex = 1;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.ContextMenuStrip = this.ContextMenuStrip1;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.SplitContainer1.Panel1MinSize = 15;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.ListView1);
            this.SplitContainer1.Size = new System.Drawing.Size(322, 630);
            this.SplitContainer1.SplitterDistance = 15;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.toolStripLabel1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.ToolStrip1.Size = new System.Drawing.Size(322, 15);
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.BackColor = System.Drawing.Color.Transparent;
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(46, 12);
            this.ToolStripButton1.Text = "PLC1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 12);
            this.toolStripLabel1.Text = "  ";
            // 
            // ListView1
            // 
            this.ListView1.BackColor = System.Drawing.SystemColors.Window;
            this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ListView1.ForeColor = System.Drawing.Color.Black;
            this.ListView1.FullRowSelect = true;
            this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView1.Location = new System.Drawing.Point(0, 0);
            this.ListView1.Margin = new System.Windows.Forms.Padding(0);
            this.ListView1.Name = "ListView1";
            this.ListView1.ShowItemToolTips = true;
            this.ListView1.Size = new System.Drawing.Size(322, 614);
            this.ListView1.TabIndex = 10;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "时间";
            this.ColumnHeader1.Width = 105;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "信息";
            this.ColumnHeader2.Width = 300;
            // 
            // FrmPLCMessageMini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(322, 630);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPLCMessageMini";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmPLCMessageMini";
            this.SizeChanged += new System.EventHandler(this.FrmPLCMessageMini_SizeChanged);
            this.PanelAll.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 清屏PLC1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 放大窗口ToolStripMenuItem;
        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private UserControls.UIListView.ListViewEX ListView1;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}