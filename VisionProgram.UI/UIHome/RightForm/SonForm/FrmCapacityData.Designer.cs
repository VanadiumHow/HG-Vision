namespace DataCollection.UI.UIHome.RightForm
{
    partial class FrmCapacityData
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.硬件设备良率ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.产能清0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原始图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结果图像ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAll.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelAll.ContextMenuStrip = this.ContextMenuStrip1;
            this.PanelAll.Controls.Add(this.TableLayoutPanelAll);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(390, 554);
            this.PanelAll.TabIndex = 0;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.硬件设备良率ToolStripMenuItem,
            this.产能清0ToolStripMenuItem,
            this.原始图像ToolStripMenuItem,
            this.结果图像ToolStripMenuItem1});
            this.ContextMenuStrip1.Name = "contextMenuStrip1";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(185, 92);
            // 
            // 硬件设备良率ToolStripMenuItem
            // 
            this.硬件设备良率ToolStripMenuItem.Name = "硬件设备良率ToolStripMenuItem";
            this.硬件设备良率ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            // 
            // 产能清0ToolStripMenuItem
            // 
            this.产能清0ToolStripMenuItem.Name = "产能清0ToolStripMenuItem";
            this.产能清0ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.产能清0ToolStripMenuItem.Text = "产能数据清零";
            this.产能清0ToolStripMenuItem.Click += new System.EventHandler(this.产能清0ToolStripMenuItem_Click);
            // 
            // 原始图像ToolStripMenuItem
            // 
            this.原始图像ToolStripMenuItem.Name = "原始图像ToolStripMenuItem";
            this.原始图像ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.原始图像ToolStripMenuItem.Text = "打开原始图像文件夹";
            this.原始图像ToolStripMenuItem.Click += new System.EventHandler(this.原始图像ToolStripMenuItem_Click);
            // 
            // 结果图像ToolStripMenuItem1
            // 
            this.结果图像ToolStripMenuItem1.Name = "结果图像ToolStripMenuItem1";
            this.结果图像ToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.结果图像ToolStripMenuItem1.Text = "打开结果图像文件夹";
            this.结果图像ToolStripMenuItem1.Click += new System.EventHandler(this.结果图像ToolStripMenuItem1_Click);
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Controls.Add(this.Chart1, 0, 1);
            this.TableLayoutPanelAll.Controls.Add(this.label1, 0, 0);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.ForeColor = System.Drawing.Color.Black;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(390, 554);
            this.TableLayoutPanelAll.TabIndex = 1;
            // 
            // Chart1
            // 
            this.Chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("微软雅黑", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 20F;
            legend1.Position.Width = 40F;
            legend1.Position.X = 60F;
            legend1.Position.Y = 7F;
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(3, 23);
            this.Chart1.Name = "Chart1";
            this.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.Chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(184)))), ((int)(((byte)(188))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(71)))), ((int)(((byte)(71))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "机台1OK数";
            dataPoint1.CustomProperties = "PieLabelStyle=Outside";
            dataPoint1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataPoint1.LegendText = "机台1OK数";
            dataPoint2.AxisLabel = "机台1NG数";
            dataPoint2.CustomProperties = "PieLabelStyle=Outside";
            dataPoint2.LegendText = "机台1NG数";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(384, 528);
            this.Chart1.TabIndex = 3;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title1.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            title1.Name = "PosTitle";
            title1.Text = "·机台1";
            this.Chart1.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "产能统计";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCapacityData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(390, 554);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapacityData";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmDataChart";
            this.PanelAll.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 硬件设备良率ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 产能清0ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.ToolStripMenuItem 原始图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结果图像ToolStripMenuItem1;
    }
}