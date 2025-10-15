using Sunny.UI;
namespace HG_Vision.UISetting
{
    partial class FrmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            this.PanelForm = new System.Windows.Forms.Panel();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.TableLayoutPanelAll = new UITableLayoutPanel();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.ButtonMin = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.ButtonGeneralSet = new System.Windows.Forms.Button();
            this.ButtonProductChangeSet = new System.Windows.Forms.Button();
            this.ButtonCameraParamsSetting = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelAll.SuspendLayout();
            this.TableLayoutPanelAll.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.SystemColors.Window;
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PanelForm.Location = new System.Drawing.Point(0, 0);
            this.PanelForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(766, 504);
            this.PanelForm.TabIndex = 0;
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.SystemColors.Window;
            this.PanelAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAll.Controls.Add(this.TableLayoutPanelAll);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Margin = new System.Windows.Forms.Padding(0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Size = new System.Drawing.Size(1470, 750);
            this.PanelAll.TabIndex = 0;
            // 
            // TableLayoutPanelAll
            // 
            this.TableLayoutPanelAll.BackColor = System.Drawing.Color.Transparent;
            this.TableLayoutPanelAll.ColumnCount = 1;
            this.TableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelAll.Controls.Add(this.PanelTitle, 0, 0);
            this.TableLayoutPanelAll.Controls.Add(this.PanelBottom, 0, 1);
            this.TableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelAll.Name = "TableLayoutPanelAll";
            this.TableLayoutPanelAll.RowCount = 2;
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelAll.Size = new System.Drawing.Size(1468, 748);
            this.TableLayoutPanelAll.TabIndex = 0;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PanelTitle.Controls.Add(this.ButtonMin);
            this.PanelTitle.Controls.Add(this.ButtonClose);
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(1468, 40);
            this.PanelTitle.TabIndex = 0;
            // 
            // ButtonMin
            // 
            this.ButtonMin.BackColor = System.Drawing.Color.SlateGray;
            this.ButtonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMin.FlatAppearance.BorderSize = 0;
            this.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMin.ForeColor = System.Drawing.Color.White;
            this.ButtonMin.Image = global::HG_Vision.Properties.Resources.向下;
            this.ButtonMin.Location = new System.Drawing.Point(1360, 0);
            this.ButtonMin.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMin.Name = "ButtonMin";
            this.ButtonMin.Size = new System.Drawing.Size(54, 40);
            this.ButtonMin.TabIndex = 14;
            this.ButtonMin.UseVisualStyleBackColor = false;
            this.ButtonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.SlateGray;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Image = global::HG_Vision.Properties.Resources.错误;
            this.ButtonClose.Location = new System.Drawing.Point(1414, 0);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(54, 40);
            this.ButtonClose.TabIndex = 13;
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.SlateGray;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitle.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(1371, 40);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = " 系统设置";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseDown);
            this.LabelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelTitle_MouseMove);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.PanelMain);
            this.PanelBottom.Controls.Add(this.PanelLeft);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(0, 40);
            this.PanelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1468, 709);
            this.PanelBottom.TabIndex = 1;
            // 
            // PanelMain
            // 
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(151, 0);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1317, 709);
            this.PanelMain.TabIndex = 2;
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.SlateGray;
            this.PanelLeft.Controls.Add(this.ButtonGeneralSet);
            this.PanelLeft.Controls.Add(this.ButtonProductChangeSet);
            this.PanelLeft.Controls.Add(this.ButtonCameraParamsSetting);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 0);
            this.PanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(151, 709);
            this.PanelLeft.TabIndex = 0;
            // 
            // ButtonGeneralSet
            // 
            this.ButtonGeneralSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGeneralSet.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGeneralSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonGeneralSet.FlatAppearance.BorderSize = 0;
            this.ButtonGeneralSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonGeneralSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGeneralSet.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonGeneralSet.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonGeneralSet.Image = global::HG_Vision.Properties.Resources.打印;
            this.ButtonGeneralSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGeneralSet.Location = new System.Drawing.Point(0, 85);
            this.ButtonGeneralSet.Name = "ButtonGeneralSet";
            this.ButtonGeneralSet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonGeneralSet.Size = new System.Drawing.Size(151, 35);
            this.ButtonGeneralSet.TabIndex = 5;
            this.ButtonGeneralSet.Text = "常规设置";
            this.ButtonGeneralSet.UseVisualStyleBackColor = false;
            this.ButtonGeneralSet.Click += new System.EventHandler(this.ButtonGeneralSet_Click);
            // 
            // ButtonProductChangeSet
            // 
            this.ButtonProductChangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonProductChangeSet.BackColor = System.Drawing.Color.Transparent;
            this.ButtonProductChangeSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonProductChangeSet.FlatAppearance.BorderSize = 0;
            this.ButtonProductChangeSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonProductChangeSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonProductChangeSet.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonProductChangeSet.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonProductChangeSet.Image = global::HG_Vision.Properties.Resources.卡券标签;
            this.ButtonProductChangeSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonProductChangeSet.Location = new System.Drawing.Point(0, 44);
            this.ButtonProductChangeSet.Name = "ButtonProductChangeSet";
            this.ButtonProductChangeSet.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonProductChangeSet.Size = new System.Drawing.Size(151, 35);
            this.ButtonProductChangeSet.TabIndex = 4;
            this.ButtonProductChangeSet.Text = "产品换型";
            this.ButtonProductChangeSet.UseVisualStyleBackColor = false;
            this.ButtonProductChangeSet.Click += new System.EventHandler(this.ButtonProductChangeSet_Click);
            // 
            // ButtonCameraParamsSetting
            // 
            this.ButtonCameraParamsSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCameraParamsSetting.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCameraParamsSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonCameraParamsSetting.FlatAppearance.BorderSize = 0;
            this.ButtonCameraParamsSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonCameraParamsSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCameraParamsSetting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonCameraParamsSetting.ForeColor = System.Drawing.SystemColors.Window;
            this.ButtonCameraParamsSetting.Image = global::HG_Vision.Properties.Resources.系统;
            this.ButtonCameraParamsSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCameraParamsSetting.Location = new System.Drawing.Point(0, 3);
            this.ButtonCameraParamsSetting.Name = "ButtonCameraParamsSetting";
            this.ButtonCameraParamsSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.ButtonCameraParamsSetting.Size = new System.Drawing.Size(151, 35);
            this.ButtonCameraParamsSetting.TabIndex = 3;
            this.ButtonCameraParamsSetting.Text = "相机参数";
            this.ButtonCameraParamsSetting.UseVisualStyleBackColor = false;
            this.ButtonCameraParamsSetting.Click += new System.EventHandler(this.ButtonCameraParamsSetting_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1470, 750);
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1470, 750);
            this.MinimumSize = new System.Drawing.Size(1470, 750);
            this.Name = "FrmSetting";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSetting_FormClosing);
            this.Load += new System.EventHandler(this.FrmSetting_Load);
            this.PanelAll.ResumeLayout(false);
            this.TableLayoutPanelAll.ResumeLayout(false);
            this.PanelTitle.ResumeLayout(false);
            this.PanelBottom.ResumeLayout(false);
            this.PanelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Panel PanelAll;
        private UITableLayoutPanel TableLayoutPanelAll;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonCameraParamsSetting;
        private System.Windows.Forms.Button ButtonMin;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ButtonProductChangeSet;
        private System.Windows.Forms.Button ButtonGeneralSet;
    }
}