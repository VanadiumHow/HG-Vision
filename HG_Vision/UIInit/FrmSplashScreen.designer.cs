using System.Windows.Forms;

namespace ProgramGerneral
{
    partial class FrmSplashScreen : Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.Title = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Loading_Text = new System.Windows.Forms.Label();
            this.progressBarEX = new VisionProgram.UserControls.UIProgressBar.ProgressBarEX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.lb_Version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Dock = System.Windows.Forms.DockStyle.Right;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Title.Location = new System.Drawing.Point(820, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 31);
            this.Title.TabIndex = 1;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // Loading_Text
            // 
            this.Loading_Text.BackColor = System.Drawing.Color.Transparent;
            this.Loading_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Loading_Text.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Loading_Text.ForeColor = System.Drawing.Color.Black;
            this.Loading_Text.Location = new System.Drawing.Point(0, 0);
            this.Loading_Text.Margin = new System.Windows.Forms.Padding(0);
            this.Loading_Text.Name = "Loading_Text";
            this.Loading_Text.Size = new System.Drawing.Size(283, 23);
            this.Loading_Text.TabIndex = 4;
            this.Loading_Text.Text = "Loading...";
            this.Loading_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarEX
            // 
            this.progressBarEX.BackColor = System.Drawing.Color.White;
            this.progressBarEX.ColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBarEX.ColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBarEX.Location = new System.Drawing.Point(384, 246);
            this.progressBarEX.Name = "progressBarEX";
            this.progressBarEX.ShowValue = false;
            this.progressBarEX.Size = new System.Drawing.Size(283, 23);
            this.progressBarEX.TabIndex = 6;
            this.progressBarEX.ValueFont = new System.Drawing.Font("微软雅黑", 9F);
            this.progressBarEX.ValueFontColor = System.Drawing.Color.Black;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HG_Vision.Properties.Resources.华工科技图标;
            this.pictureBox1.Location = new System.Drawing.Point(7, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 36F);
            this.label1.Location = new System.Drawing.Point(296, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "同轴激光焊接视觉软件";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.Loading_Text);
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(384, 277);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(283, 23);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 9;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Version
            // 
            this.lb_Version.AutoSize = true;
            this.lb_Version.Font = new System.Drawing.Font("黑体", 12F);
            this.lb_Version.Location = new System.Drawing.Point(593, 392);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(215, 16);
            this.lb_Version.TabIndex = 10;
            this.lb_Version.Text = "当前版本：V02.05.2025.1103";
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(820, 422);
            this.Controls.Add(this.lb_Version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarEX);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiPanel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSplashScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label Loading_Text;
        private VisionProgram.UserControls.UIProgressBar.ProgressBarEX progressBarEX;
        private PictureBox pictureBox1;
        private Label label1;
        private Sunny.UI.UIPanel uiPanel1;
        private Label lb_Version;
    }
}