using Sunny.UI;
namespace HG_Vision.UISetting
{
    partial class FrmProductChangeSettings
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TableLayoutPanel1 = new UITableLayoutPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TextBoxEXNewProductModelName = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.ButtonDeleteProductModel = new System.Windows.Forms.Button();
            this.ButtonExchangeProductModel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxProductModelList = new System.Windows.Forms.ListBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.ButtonAddNewProductModel = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.TableLayoutPanel1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.Panel1.Size = new System.Drawing.Size(1016, 708);
            this.Panel1.TabIndex = 0;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1015, 707);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.Panel2.Controls.Add(this.TextBoxEXNewProductModelName);
            this.Panel2.Controls.Add(this.ButtonDeleteProductModel);
            this.Panel2.Controls.Add(this.ButtonExchangeProductModel);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.ButtonAddNewProductModel);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1015, 707);
            this.Panel2.TabIndex = 9;
            // 
            // TextBoxEXNewProductModelName
            // 
            this.TextBoxEXNewProductModelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxEXNewProductModelName.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.TextBoxEXNewProductModelName.BorderFocusColor = System.Drawing.Color.Teal;
            this.TextBoxEXNewProductModelName.BorderSize = 1;
            this.TextBoxEXNewProductModelName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBoxEXNewProductModelName.Location = new System.Drawing.Point(510, 53);
            this.TextBoxEXNewProductModelName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TextBoxEXNewProductModelName.Multiline = false;
            this.TextBoxEXNewProductModelName.Name = "TextBoxEXNewProductModelName";
            this.TextBoxEXNewProductModelName.Padding = new System.Windows.Forms.Padding(3);
            this.TextBoxEXNewProductModelName.PasswordChar = false;
            this.TextBoxEXNewProductModelName.ReadOnly = false;
            this.TextBoxEXNewProductModelName.Size = new System.Drawing.Size(256, 27);
            this.TextBoxEXNewProductModelName.TabIndex = 8;
            this.TextBoxEXNewProductModelName.UnderlinedStyle = false;
            this.TextBoxEXNewProductModelName.WatermarkText = null;
            // 
            // ButtonDeleteProductModel
            // 
            this.ButtonDeleteProductModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteProductModel.FlatAppearance.BorderSize = 2;
            this.ButtonDeleteProductModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteProductModel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonDeleteProductModel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonDeleteProductModel.Location = new System.Drawing.Point(655, 586);
            this.ButtonDeleteProductModel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDeleteProductModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonDeleteProductModel.Name = "ButtonDeleteProductModel";
            this.ButtonDeleteProductModel.Size = new System.Drawing.Size(152, 47);
            this.ButtonDeleteProductModel.TabIndex = 7;
            this.ButtonDeleteProductModel.Tag = "移除产品型号";
            this.ButtonDeleteProductModel.Text = "移除产品型号";
            this.ButtonDeleteProductModel.Click += new System.EventHandler(this.ButtonDeleteProductModel_Click);
            // 
            // ButtonExchangeProductModel
            // 
            this.ButtonExchangeProductModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExchangeProductModel.FlatAppearance.BorderSize = 2;
            this.ButtonExchangeProductModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExchangeProductModel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonExchangeProductModel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonExchangeProductModel.Location = new System.Drawing.Point(431, 586);
            this.ButtonExchangeProductModel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonExchangeProductModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonExchangeProductModel.Name = "ButtonExchangeProductModel";
            this.ButtonExchangeProductModel.Size = new System.Drawing.Size(152, 47);
            this.ButtonExchangeProductModel.TabIndex = 2;
            this.ButtonExchangeProductModel.Tag = "切换产品型号";
            this.ButtonExchangeProductModel.Text = "切换产品型号";
            this.ButtonExchangeProductModel.Click += new System.EventHandler(this.ButtonExchangeProductModel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListBoxProductModelList);
            this.GroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(20, 12);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.GroupBox1.Size = new System.Drawing.Size(404, 621);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "产品系列";
            // 
            // ListBoxProductModelList
            // 
            this.ListBoxProductModelList.BackColor = System.Drawing.Color.GhostWhite;
            this.ListBoxProductModelList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxProductModelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxProductModelList.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ListBoxProductModelList.ForeColor = System.Drawing.Color.Black;
            this.ListBoxProductModelList.ItemHeight = 21;
            this.ListBoxProductModelList.Location = new System.Drawing.Point(0, 40);
            this.ListBoxProductModelList.Margin = new System.Windows.Forms.Padding(0);
            this.ListBoxProductModelList.MinimumSize = new System.Drawing.Size(4, 4);
            this.ListBoxProductModelList.Name = "ListBoxProductModelList";
            this.ListBoxProductModelList.Size = new System.Drawing.Size(404, 581);
            this.ListBoxProductModelList.TabIndex = 2;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Label14.ForeColor = System.Drawing.Color.DimGray;
            this.Label14.Location = new System.Drawing.Point(506, 80);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(260, 23);
            this.Label14.TabIndex = 4;
            this.Label14.Text = "(名字的命名包含字母、_或者数字)";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAddNewProductModel
            // 
            this.ButtonAddNewProductModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddNewProductModel.FlatAppearance.BorderSize = 2;
            this.ButtonAddNewProductModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddNewProductModel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ButtonAddNewProductModel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonAddNewProductModel.Location = new System.Drawing.Point(431, 116);
            this.ButtonAddNewProductModel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonAddNewProductModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ButtonAddNewProductModel.Name = "ButtonAddNewProductModel";
            this.ButtonAddNewProductModel.Size = new System.Drawing.Size(152, 47);
            this.ButtonAddNewProductModel.TabIndex = 5;
            this.ButtonAddNewProductModel.Tag = "添加产品型号";
            this.ButtonAddNewProductModel.Text = "添加产品型号";
            this.ButtonAddNewProductModel.Click += new System.EventHandler(this.ButtonAddNewProductModel_Click);
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label11.Location = new System.Drawing.Point(427, 54);
            this.Label11.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(92, 26);
            this.Label11.TabIndex = 3;
            this.Label11.Text = "产品型号：";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmProductChangeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 708);
            this.Controls.Add(this.Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductChangeSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "产品";
            this.Panel1.ResumeLayout(false);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private UITableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Button ButtonDeleteProductModel;
        private System.Windows.Forms.Button ButtonExchangeProductModel;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ListBox ListBoxProductModelList;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Button ButtonAddNewProductModel;
        private System.Windows.Forms.Label Label11;
        private VisionProgram.UserControls.UITextBox.TextBoxEX TextBoxEXNewProductModelName;
    }
}