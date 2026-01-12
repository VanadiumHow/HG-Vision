namespace HG_Vision.UILogin
{
    partial class FrmEdit
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
            this.TextBoxOldPwd = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.LabelOldPwd = new System.Windows.Forms.Label();
            this.TextBoxFinalPwd = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.LabelFinalPwd = new System.Windows.Forms.Label();
            this.LabelNewPwd = new System.Windows.Forms.Label();
            this.TextBoxNewPwd = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.LabelRole = new System.Windows.Forms.Label();
            this.LabelRoleName = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTile = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelTitle.SuspendLayout();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxOldPwd
            // 
            this.TextBoxOldPwd.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxOldPwd.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxOldPwd.BorderSize = 1;
            this.TextBoxOldPwd.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TextBoxOldPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxOldPwd.Location = new System.Drawing.Point(131, 57);
            this.TextBoxOldPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxOldPwd.MinimumSize = new System.Drawing.Size(4, 4);
            this.TextBoxOldPwd.Multiline = false;
            this.TextBoxOldPwd.Name = "TextBoxOldPwd";
            this.TextBoxOldPwd.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxOldPwd.PasswordChar = false;
            this.TextBoxOldPwd.ReadOnly = false;
            this.TextBoxOldPwd.Size = new System.Drawing.Size(340, 34);
            this.TextBoxOldPwd.TabIndex = 0;
            this.TextBoxOldPwd.UnderlinedStyle = false;
            this.TextBoxOldPwd.WatermarkText = null;
            // 
            // LabelOldPwd
            // 
            this.LabelOldPwd.AutoSize = true;
            this.LabelOldPwd.BackColor = System.Drawing.Color.Transparent;
            this.LabelOldPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOldPwd.ForeColor = System.Drawing.Color.Black;
            this.LabelOldPwd.Location = new System.Drawing.Point(37, 61);
            this.LabelOldPwd.Name = "LabelOldPwd";
            this.LabelOldPwd.Size = new System.Drawing.Size(88, 25);
            this.LabelOldPwd.TabIndex = 4;
            this.LabelOldPwd.Text = "原始密码";
            this.LabelOldPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxFinalPwd
            // 
            this.TextBoxFinalPwd.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxFinalPwd.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxFinalPwd.BorderSize = 1;
            this.TextBoxFinalPwd.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TextBoxFinalPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxFinalPwd.Location = new System.Drawing.Point(131, 176);
            this.TextBoxFinalPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxFinalPwd.MinimumSize = new System.Drawing.Size(4, 4);
            this.TextBoxFinalPwd.Multiline = false;
            this.TextBoxFinalPwd.Name = "TextBoxFinalPwd";
            this.TextBoxFinalPwd.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxFinalPwd.PasswordChar = true;
            this.TextBoxFinalPwd.ReadOnly = false;
            this.TextBoxFinalPwd.Size = new System.Drawing.Size(340, 34);
            this.TextBoxFinalPwd.TabIndex = 6;
            this.TextBoxFinalPwd.UnderlinedStyle = false;
            this.TextBoxFinalPwd.WatermarkText = null;
            // 
            // LabelFinalPwd
            // 
            this.LabelFinalPwd.AutoSize = true;
            this.LabelFinalPwd.BackColor = System.Drawing.Color.Transparent;
            this.LabelFinalPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelFinalPwd.ForeColor = System.Drawing.Color.Black;
            this.LabelFinalPwd.Location = new System.Drawing.Point(37, 181);
            this.LabelFinalPwd.Name = "LabelFinalPwd";
            this.LabelFinalPwd.Size = new System.Drawing.Size(88, 25);
            this.LabelFinalPwd.TabIndex = 15;
            this.LabelFinalPwd.Text = "确认密码";
            this.LabelFinalPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelNewPwd
            // 
            this.LabelNewPwd.AutoSize = true;
            this.LabelNewPwd.BackColor = System.Drawing.Color.Transparent;
            this.LabelNewPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelNewPwd.ForeColor = System.Drawing.Color.Black;
            this.LabelNewPwd.Location = new System.Drawing.Point(37, 120);
            this.LabelNewPwd.Name = "LabelNewPwd";
            this.LabelNewPwd.Size = new System.Drawing.Size(88, 25);
            this.LabelNewPwd.TabIndex = 16;
            this.LabelNewPwd.Text = "修改密码";
            this.LabelNewPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxNewPwd
            // 
            this.TextBoxNewPwd.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxNewPwd.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxNewPwd.BorderSize = 1;
            this.TextBoxNewPwd.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TextBoxNewPwd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxNewPwd.Location = new System.Drawing.Point(131, 115);
            this.TextBoxNewPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxNewPwd.MinimumSize = new System.Drawing.Size(4, 4);
            this.TextBoxNewPwd.Multiline = false;
            this.TextBoxNewPwd.Name = "TextBoxNewPwd";
            this.TextBoxNewPwd.Padding = new System.Windows.Forms.Padding(4);
            this.TextBoxNewPwd.PasswordChar = false;
            this.TextBoxNewPwd.ReadOnly = false;
            this.TextBoxNewPwd.Size = new System.Drawing.Size(340, 34);
            this.TextBoxNewPwd.TabIndex = 17;
            this.TextBoxNewPwd.UnderlinedStyle = false;
            this.TextBoxNewPwd.WatermarkText = null;
            // 
            // LabelRole
            // 
            this.LabelRole.BackColor = System.Drawing.Color.Transparent;
            this.LabelRole.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelRole.ForeColor = System.Drawing.Color.Black;
            this.LabelRole.Location = new System.Drawing.Point(37, 16);
            this.LabelRole.Name = "LabelRole";
            this.LabelRole.Size = new System.Drawing.Size(74, 23);
            this.LabelRole.TabIndex = 18;
            this.LabelRole.Text = "角色";
            this.LabelRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelRoleName
            // 
            this.LabelRoleName.BackColor = System.Drawing.Color.Transparent;
            this.LabelRoleName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelRoleName.ForeColor = System.Drawing.Color.Black;
            this.LabelRoleName.Location = new System.Drawing.Point(131, 16);
            this.LabelRoleName.Name = "LabelRoleName";
            this.LabelRoleName.Size = new System.Drawing.Size(159, 23);
            this.LabelRoleName.TabIndex = 19;
            this.LabelRoleName.Text = "XXXX";
            this.LabelRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.PanelTitle.Controls.Add(this.LabelTile);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(564, 36);
            this.PanelTitle.TabIndex = 20;
            // 
            // LabelTile
            // 
            this.LabelTile.BackColor = System.Drawing.Color.Transparent;
            this.LabelTile.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.LabelTile.ForeColor = System.Drawing.Color.White;
            this.LabelTile.Location = new System.Drawing.Point(3, 3);
            this.LabelTile.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTile.Name = "LabelTile";
            this.LabelTile.Size = new System.Drawing.Size(89, 36);
            this.LabelTile.TabIndex = 19;
            this.LabelTile.Text = "修改密码";
            this.LabelTile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(332, 221);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(88, 30);
            this.ButtonClose.TabIndex = 21;
            this.ButtonClose.Text = "关闭";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonOK
            // 
            this.ButtonOK.BackColor = System.Drawing.Color.CadetBlue;
            this.ButtonOK.FlatAppearance.BorderSize = 0;
            this.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOK.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonOK.Location = new System.Drawing.Point(442, 221);
            this.ButtonOK.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(88, 30);
            this.ButtonOK.TabIndex = 22;
            this.ButtonOK.Text = "确认";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Controls.Add(this.LabelRole);
            this.PanelMain.Controls.Add(this.ButtonOK);
            this.PanelMain.Controls.Add(this.LabelOldPwd);
            this.PanelMain.Controls.Add(this.ButtonClose);
            this.PanelMain.Controls.Add(this.TextBoxOldPwd);
            this.PanelMain.Controls.Add(this.LabelFinalPwd);
            this.PanelMain.Controls.Add(this.LabelRoleName);
            this.PanelMain.Controls.Add(this.TextBoxFinalPwd);
            this.PanelMain.Controls.Add(this.LabelNewPwd);
            this.PanelMain.Controls.Add(this.TextBoxNewPwd);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 36);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(564, 264);
            this.PanelMain.TabIndex = 23;
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(564, 300);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTitle.ResumeLayout(false);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxOldPwd;
        private System.Windows.Forms.Label LabelOldPwd;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxFinalPwd;
        private System.Windows.Forms.Label LabelFinalPwd;
        private System.Windows.Forms.Label LabelNewPwd;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxNewPwd;
        private System.Windows.Forms.Label LabelRole;
        private System.Windows.Forms.Label LabelRoleName;
        internal System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTile;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Panel PanelMain;
    }
}