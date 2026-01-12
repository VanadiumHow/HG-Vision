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
            this.Label5 = new System.Windows.Forms.Label();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxEXPwd = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.ComboBoxEXUser = new System.Windows.Forms.ComboBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.PanelHeader.SuspendLayout();
            this.PanelAll.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
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
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
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
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.PanelHeader.Controls.Add(this.ButtonClose);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(420, 36);
            this.PanelHeader.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "登录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(420, 342);
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
            this.LabelTitle.Text = "Welcome To Login";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PanelHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelAll);
            this.splitContainer1.Size = new System.Drawing.Size(420, 379);
            this.splitContainer1.SplitterDistance = 36;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 16;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.ButtonClose.BackgroundImage = global::HG_Vision.Properties.Resources.退出;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(76)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(380, 3);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(38, 29);
            this.ButtonClose.TabIndex = 14;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(420, 379);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.splitContainer1);
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
            this.PanelAll.ResumeLayout(false);
            this.PanelAll.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel PanelHeader;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxEXPwd;
        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.ComboBox ComboBoxEXUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClose;
    }
}