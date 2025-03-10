namespace VisionProgram.UI.UIDC
{
    partial class FrmMainDC
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
            this.SuspendLayout();
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.Color.White;
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(1168, 661);
            this.PanelAll.TabIndex = 0;
            // 
            // FrmMainDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1168, 661);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainDC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmMainDC";
            this.Load += new System.EventHandler(this.FrmMainDC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelAll;
    }
}