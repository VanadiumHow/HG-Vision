namespace VisionProgram.UserControls.UIPagination
{
    partial class PaginationEX
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.labPageIndex = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labPageCount = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnJump = new System.Windows.Forms.Button();
            this.PanelAll = new System.Windows.Forms.Panel();
            this.LabelCount = new System.Windows.Forms.Label();
            this.txtPageIndex = new VisionProgram.UserControls.UITextBox.TextBoxEX();
            this.PanelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前页";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPageIndex
            // 
            this.labPageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labPageIndex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPageIndex.ForeColor = System.Drawing.Color.Red;
            this.labPageIndex.Location = new System.Drawing.Point(187, 0);
            this.labPageIndex.Name = "labPageIndex";
            this.labPageIndex.Size = new System.Drawing.Size(36, 35);
            this.labPageIndex.TabIndex = 3;
            this.labPageIndex.Text = "999";
            this.labPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(225, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "/";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labPageCount
            // 
            this.labPageCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labPageCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPageCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labPageCount.Location = new System.Drawing.Point(247, 0);
            this.labPageCount.Name = "labPageCount";
            this.labPageCount.Size = new System.Drawing.Size(41, 35);
            this.labPageCount.TabIndex = 5;
            this.labPageCount.Text = "999";
            this.labPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFirst.BackColor = System.Drawing.Color.DarkCyan;
            this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFirst.Location = new System.Drawing.Point(307, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(50, 25);
            this.btnFirst.TabIndex = 6;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.BackColor = System.Drawing.Color.Teal;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrev.Location = new System.Drawing.Point(363, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(62, 25);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNext.BackColor = System.Drawing.Color.Teal;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(431, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 25);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLast.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLast.Location = new System.Drawing.Point(499, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(50, 25);
            this.btnLast.TabIndex = 9;
            this.btnLast.Text = "末页";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(575, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 35);
            this.label6.TabIndex = 10;
            this.label6.Text = "跳转";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJump
            // 
            this.btnJump.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnJump.BackColor = System.Drawing.Color.CadetBlue;
            this.btnJump.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJump.FlatAppearance.BorderSize = 0;
            this.btnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJump.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJump.ForeColor = System.Drawing.Color.White;
            this.btnJump.Location = new System.Drawing.Point(758, 5);
            this.btnJump.Name = "btnJump";
            this.btnJump.Size = new System.Drawing.Size(50, 25);
            this.btnJump.TabIndex = 12;
            this.btnJump.Text = "GO";
            this.btnJump.UseVisualStyleBackColor = false;
            this.btnJump.Click += new System.EventHandler(this.btnJump_Click);
            // 
            // PanelAll
            // 
            this.PanelAll.BackColor = System.Drawing.Color.Transparent;
            this.PanelAll.Controls.Add(this.LabelCount);
            this.PanelAll.Controls.Add(this.btnJump);
            this.PanelAll.Controls.Add(this.label2);
            this.PanelAll.Controls.Add(this.txtPageIndex);
            this.PanelAll.Controls.Add(this.labPageIndex);
            this.PanelAll.Controls.Add(this.label6);
            this.PanelAll.Controls.Add(this.label4);
            this.PanelAll.Controls.Add(this.btnLast);
            this.PanelAll.Controls.Add(this.labPageCount);
            this.PanelAll.Controls.Add(this.btnNext);
            this.PanelAll.Controls.Add(this.btnFirst);
            this.PanelAll.Controls.Add(this.btnPrev);
            this.PanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAll.Location = new System.Drawing.Point(0, 0);
            this.PanelAll.Name = "PanelAll";
            this.PanelAll.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.PanelAll.Size = new System.Drawing.Size(931, 35);
            this.PanelAll.TabIndex = 13;
            // 
            // LabelCount
            // 
            this.LabelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCount.BackColor = System.Drawing.Color.Transparent;
            this.LabelCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCount.Location = new System.Drawing.Point(5, 0);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(116, 35);
            this.LabelCount.TabIndex = 13;
            this.LabelCount.Text = "总行数：";
            this.LabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.txtPageIndex.BorderFocusColor = System.Drawing.Color.Teal;
            this.txtPageIndex.BorderSize = 1;
            this.txtPageIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPageIndex.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPageIndex.Location = new System.Drawing.Point(612, 7);
            this.txtPageIndex.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtPageIndex.Multiline = false;
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.Padding = new System.Windows.Forms.Padding(1);
            this.txtPageIndex.PasswordChar = false;
            this.txtPageIndex.Size = new System.Drawing.Size(126, 23);
            this.txtPageIndex.TabIndex = 11;
            this.txtPageIndex.UnderlinedStyle = false;
            this.txtPageIndex.WatermarkText = null;
            this.txtPageIndex.TextChanged += new System.EventHandler(this.txtPageIndex_TextChanged);
            this.txtPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageIndex_KeyPress);
            this.txtPageIndex.Leave += new System.EventHandler(this.txtPageIndex_Leave);
            // 
            // PaginationEX
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.PanelAll);
            this.DoubleBuffered = true;
            this.Name = "PaginationEX";
            this.Size = new System.Drawing.Size(931, 35);
            this.PanelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labPageIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labPageCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label label6;
        private VisionProgram.UserControls.UITextBox.TextBoxEX txtPageIndex;
        private System.Windows.Forms.Button btnJump;
        private System.Windows.Forms.Panel PanelAll;
        private System.Windows.Forms.Label LabelCount;
    }
}
