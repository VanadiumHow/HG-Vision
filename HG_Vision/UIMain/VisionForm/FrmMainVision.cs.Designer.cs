using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
namespace HG_Vision.UIVision
{
    partial class FrmMainVision
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
            this.PanelAll = new System.Windows.Forms.Panel();
            this.TabControlAll = new VisionProgram.UserControls.UITabControl.TabControlEx();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelFirstVision = new UITableLayoutPanel();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelSecondVision = new UITableLayoutPanel();
            this.TableLayoutPanelMainVision = new UITableLayoutPanel();
            this.TabControlAll.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.Color.Transparent;
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(1557, 826);
            this.PanelAll.TabIndex = 1;
            // 
            // TabControlAll
            // 
            this.TabControlAll.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.TabControlAll.BackColor = System.Drawing.Color.Transparent;
            this.TabControlAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(141)))));
            this.TabControlAll.BorderColor = System.Drawing.Color.Transparent;
            this.TabControlAll.Controls.Add(this.TabPage1);
            this.TabControlAll.Controls.Add(this.TabPage2);
            this.TabControlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAll.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControlAll.Location = new System.Drawing.Point(0, 0);
            this.TabControlAll.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlAll.Multiline = true;
            this.TabControlAll.Name = "TabControlAll";
            this.TabControlAll.Padding = new System.Drawing.Point(0, 0);
            this.TabControlAll.SelectedIndex = 0;
            this.TabControlAll.ShowClose = false;
            this.TabControlAll.Size = new System.Drawing.Size(1138, 653);
            this.TabControlAll.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlAll.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.White;
            this.TabPage1.Controls.Add(this.TableLayoutPanelFirstVision);
            this.TabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage1.ForeColor = System.Drawing.Color.White;
            this.TabPage1.Location = new System.Drawing.Point(4, 30);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(1130, 619);
            this.TabPage1.TabIndex = 3;
            this.TabPage1.Text = "相机区1";
            

            // 
            // TableLayoutPanelFirstVision
            // 
            this.TableLayoutPanelFirstVision.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelFirstVision.ColumnCount = 1;
            this.TableLayoutPanelFirstVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelFirstVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelFirstVision.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelFirstVision.Name = "TableLayoutPanelFirstVision";
            this.TableLayoutPanelFirstVision.RowCount = 1;
            this.TableLayoutPanelFirstVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelFirstVision.Size = new System.Drawing.Size(1130, 619);
            this.TableLayoutPanelFirstVision.TabIndex = 5;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.White;
            this.TabPage2.Controls.Add(this.TableLayoutPanelSecondVision);
            this.TabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabPage2.ForeColor = System.Drawing.Color.White;
            this.TabPage2.Location = new System.Drawing.Point(4, 30);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(1130, 619);
            this.TabPage2.TabIndex = 4;
            this.TabPage2.Text = "相机区2";
            // 
            // TableLayoutPanelSecondVision
            // 
            this.TableLayoutPanelSecondVision.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelSecondVision.ColumnCount = 1;
            this.TableLayoutPanelSecondVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelSecondVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelSecondVision.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelSecondVision.Name = "TableLayoutPanelSecondVision";
            this.TableLayoutPanelSecondVision.RowCount = 1;
            this.TableLayoutPanelSecondVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelSecondVision.Size = new System.Drawing.Size(1130, 619);
            this.TableLayoutPanelSecondVision.TabIndex = 6;
            // 
            // TableLayoutPanelMainVision
            // 
            this.TableLayoutPanelMainVision.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelMainVision.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TableLayoutPanelMainVision.ColumnCount = 1;
            this.TableLayoutPanelMainVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMainVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMainVision.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMainVision.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayoutPanelMainVision.Name = "TableLayoutPanelMainVision";
            this.TableLayoutPanelMainVision.RowCount = 1;
            this.TableLayoutPanelMainVision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMainVision.Size = new System.Drawing.Size(1138, 623);
            this.TableLayoutPanelMainVision.TabIndex = 7;
            // 
            // FrmMainVision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1557, 826);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmMainVision";
            this.ShowInTaskbar = false;
            this.Text = "FrmVision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainVision_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainVision_Load);
            this.TabControlAll.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAll;
        private VisionProgram.UserControls.UITabControl.TabControlEx TabControlAll;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private UITableLayoutPanel TableLayoutPanelFirstVision;
        private UITableLayoutPanel TableLayoutPanelSecondVision;
        private UITableLayoutPanel TableLayoutPanelMainVision;
    }
}