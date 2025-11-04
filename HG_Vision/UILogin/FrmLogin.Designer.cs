namespace HG_Vision.UILogin
{
    partial class FrmLogin
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.TextBoxEXPwd = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.ComboBoxEXUser = new System.Windows.Forms.ComboBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelHeader.SuspendLayout();
            this.PanelAll.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(5, 7);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "欢迎登录";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label5.Location = new System.Drawing.Point(563, 351);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 19);
            this.Label5.TabIndex = 1;
            this.Label5.Text = "焊接软件";
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonModify.FlatAppearance.BorderSize = 0;
            this.ButtonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonModify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonModify.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonModify.Location = new System.Drawing.Point(236, 283);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(88, 30);
            this.ButtonModify.TabIndex = 7;
            this.ButtonModify.Text = "修改";
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.btModify_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonLogin.Location = new System.Drawing.Point(91, 283);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(88, 30);
            this.ButtonLogin.TabIndex = 6;
            this.ButtonLogin.Text = "登录";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(169, 124);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 26);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "用户登录";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.CadetBlue;
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Controls.Add(this.Label1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(420, 36);
            this.PanelHeader.TabIndex = 11;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(384, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(36, 36);
            this.ButtonClose.TabIndex = 12;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // TextBoxEXPwd
            // 
            this.TextBoxEXPwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxEXPwd.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxEXPwd.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxEXPwd.BorderSize = 1;
            this.TextBoxEXPwd.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TextBoxEXPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEXPwd.Location = new System.Drawing.Point(91, 218);
            this.TextBoxEXPwd.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxEXPwd.Multiline = false;
            this.TextBoxEXPwd.Name = "TextBoxEXPwd";
            this.TextBoxEXPwd.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxEXPwd.PasswordChar = true;
            this.TextBoxEXPwd.ReadOnly = false;
            this.TextBoxEXPwd.Size = new System.Drawing.Size(233, 34);
            this.TextBoxEXPwd.TabIndex = 13;
            this.TextBoxEXPwd.UnderlinedStyle = false;
            this.TextBoxEXPwd.WatermarkText = null;
            this.TextBoxEXPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxEXPwd_KeyPress);
            // 
            // PanelAll
            // 
            this.PanelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAll.Controls.Add(this.ComboBoxEXUser);
            this.PanelAll.Controls.Add(this.PanelTitle);
            this.PanelAll.Controls.Add(this.ButtonModify);
            this.PanelAll.Controls.Add(this.TextBoxEXPwd);
            this.PanelAll.Controls.Add(this.ButtonLogin);
            this.PanelAll.Controls.Add(this.Label2);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PanelAll.Location = new System.Drawing.Point(0, 36);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(420, 343);
            this.PanelAll.TabIndex = 15;
            // 
            // ComboBoxEXUser
            // 
            this.ComboBoxEXUser.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ComboBoxEXUser.FormattingEnabled = true;
            this.ComboBoxEXUser.Location = new System.Drawing.Point(91, 168);
            this.ComboBoxEXUser.Name = "ComboBoxEXUser";
            this.ComboBoxEXUser.Size = new System.Drawing.Size(233, 29);
            this.ComboBoxEXUser.TabIndex = 16;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.Transparent;
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(418, 100);
            this.PanelTitle.TabIndex = 15;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(418, 100);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Welcome To LoginWin";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 379);
            this.Controls.Add(this.PanelAll);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.Label5);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelAll.ResumeLayout(false);
            this.PanelAll.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Button ButtonClose;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxEXPwd;
        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxEXUser;
    }
}