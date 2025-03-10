using System.Windows.Forms;

namespace ProgramGerneral
{
    partial class SplashScreen : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.Title = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.Loading_Panel = new System.Windows.Forms.Panel();
            this.Loading_Text = new System.Windows.Forms.Label();
            this.progressBarEX = new VisionProgram.UserControls.UIProgressBar.ProgressBarEX();
            this.Loading_Panel.SuspendLayout();
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
            // Loading_Panel
            // 
            this.Loading_Panel.BackColor = System.Drawing.Color.White;
            this.Loading_Panel.Controls.Add(this.Loading_Text);
            this.Loading_Panel.Location = new System.Drawing.Point(200, 363);
            this.Loading_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.Loading_Panel.Name = "Loading_Panel";
            this.Loading_Panel.Size = new System.Drawing.Size(283, 30);
            this.Loading_Panel.TabIndex = 4;
            // 
            // Loading_Text
            // 
            this.Loading_Text.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Loading_Text.ForeColor = System.Drawing.Color.Black;
            this.Loading_Text.Location = new System.Drawing.Point(0, -2);
            this.Loading_Text.Margin = new System.Windows.Forms.Padding(0);
            this.Loading_Text.Name = "Loading_Text";
            this.Loading_Text.Size = new System.Drawing.Size(283, 30);
            this.Loading_Text.TabIndex = 4;
            this.Loading_Text.Text = "Loading...";
            this.Loading_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarEX
            // 
            this.progressBarEX.BackColor = System.Drawing.Color.White;
            this.progressBarEX.ColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBarEX.ColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBarEX.Location = new System.Drawing.Point(200, 335);
            this.progressBarEX.Name = "progressBarEX";
            this.progressBarEX.ShowValue = false;
            this.progressBarEX.Size = new System.Drawing.Size(283, 23);
            this.progressBarEX.TabIndex = 6;
            this.progressBarEX.ValueFont = new System.Drawing.Font("微软雅黑", 9F);
            this.progressBarEX.ValueFontColor = System.Drawing.Color.Black;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VisionProgram.SplashScreen.Properties.Resources.splashScreen3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(820, 422);
            this.Controls.Add(this.progressBarEX);
            this.Controls.Add(this.Loading_Panel);
            this.Controls.Add(this.Title);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SplashScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Loading_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Panel Loading_Panel;
        private System.Windows.Forms.Label Loading_Text;
        private VisionProgram.UserControls.UIProgressBar.ProgressBarEX progressBarEX;
    }
}