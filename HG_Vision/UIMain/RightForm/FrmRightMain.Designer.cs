using Sunny.UI;

namespace HG_Vision.UIHome.RightForm
{
    partial class FrmRightMain
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableLayoutPanelLamp = new UITableLayoutPanel();
            this.PanelLampTitle = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.TabControl1 = new VisionProgram.UserControls.UITabControl.TabControlEx();
            this.TabPageLog = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TableLayoutPanelLamp.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.IsSplitterFixed = true;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.SplitContainer1.Panel1.Controls.Add(this.TableLayoutPanelLamp);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer1.Size = new System.Drawing.Size(410, 546);
            this.SplitContainer1.SplitterDistance = 180;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 0;
            // 
            // TableLayoutPanelLamp
            // 
            this.TableLayoutPanelLamp.ColumnCount = 1;
            this.TableLayoutPanelLamp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelLamp.Controls.Add(this.PanelLampTitle, 0, 0);
            this.TableLayoutPanelLamp.Controls.Add(this.Panel5, 0, 1);
            this.TableLayoutPanelLamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelLamp.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelLamp.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanelLamp.Name = "TableLayoutPanelLamp";
            this.TableLayoutPanelLamp.RowCount = 2;
            this.TableLayoutPanelLamp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayoutPanelLamp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelLamp.Size = new System.Drawing.Size(410, 180);
            this.TableLayoutPanelLamp.TabIndex = 2;
            // 
            // PanelLampTitle
            // 
            this.PanelLampTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.PanelLampTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLampTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelLampTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLampTitle.Name = "PanelLampTitle";
            this.PanelLampTitle.Size = new System.Drawing.Size(410, 30);
            this.PanelLampTitle.TabIndex = 0;
            // 
            // Panel5
            // 
            this.Panel5.BackColor = System.Drawing.Color.Transparent;
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel5.Location = new System.Drawing.Point(0, 30);
            this.Panel5.Margin = new System.Windows.Forms.Padding(0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(410, 166);
            this.Panel5.TabIndex = 1;
            // 
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControl1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.TabControl1.BorderColor = System.Drawing.Color.White;
            this.TabControl1.Controls.Add(this.TabPageLog);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl1.ItemSize = new System.Drawing.Size(110, 25);
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.Padding = new System.Drawing.Point(15, 3);
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.ShowClose = false;
            this.TabControl1.Size = new System.Drawing.Size(410, 365);
            this.TabControl1.TabIndex = 5;
            // 
            // TabPageLog
            // 
            this.TabPageLog.BackColor = System.Drawing.Color.White;
            this.TabPageLog.ForeColor = System.Drawing.Color.White;
            this.TabPageLog.Location = new System.Drawing.Point(4, 29);
            this.TabPageLog.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageLog.Name = "TabPageLog";
            this.TabPageLog.Padding = new System.Windows.Forms.Padding(2);
            this.TabPageLog.Size = new System.Drawing.Size(402, 332);
            this.TabPageLog.TabIndex = 0;
            this.TabPageLog.Text = "日志";
            // 
            // FrmRightMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 546);
            this.Controls.Add(this.SplitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRightMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmRightMain";
            this.Load += new System.EventHandler(this.FrmRightMain_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.TableLayoutPanelLamp.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        private VisionProgram.UserControls.UITabControl.TabControlEx TabControl1;
        private System.Windows.Forms.TabPage TabPageLog;
        private UITableLayoutPanel TableLayoutPanelLamp;
        internal System.Windows.Forms.Panel PanelLampTitle;
        private System.Windows.Forms.Panel Panel5;
    }
}