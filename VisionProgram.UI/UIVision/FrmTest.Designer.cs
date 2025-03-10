namespace VisionProgram.UI.UIVision
{
    partial class FrmTest
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
            this.uiPanelAll = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.uiPanelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelAll
            // 
            this.uiPanelAll.BackColor = System.Drawing.Color.White;
            this.uiPanelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiPanelAll.Controls.Add(this.label);
            this.uiPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanelAll.Location = new System.Drawing.Point(0, 0);
            this.uiPanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanelAll.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiPanelAll.Name = "uiPanelAll";
            this.uiPanelAll.Size = new System.Drawing.Size(480, 274);
            this.uiPanelAll.TabIndex = 0;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(478, 272);
            this.label.TabIndex = 1;
            this.label.Text = "1";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 274);
            this.Controls.Add(this.uiPanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmTest";
            this.uiPanelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiPanelAll;
        private System.Windows.Forms.Label label;
    }
}