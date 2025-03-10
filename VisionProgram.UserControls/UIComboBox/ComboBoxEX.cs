using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UIComboBox
{
    public partial class ComboBoxEX : UserControl
    {
        //定义字段
        private Color _backColor = Color.WhiteSmoke; //背景颜色
        private Color _iconColor = Color.DarkSlateGray; //图标颜色
        private Color _listBackColor = System.Drawing.SystemColors.Control;//下拉列表背景颜色
        private Color _listTextColor = Color.DimGray;//下拉列表字体颜色
        private Color _borderColor = Color.DarkSlateGray;//边框颜色
        private int _borderSize = 1;//边框线条尺寸
        private Size _size = new Size(200, 30);

        //定义类别
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //定义事件
        public event EventHandler OnSelectedIndexChanged;


        public ComboBoxEX()
        {
            InitializeComponent();

            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmbList.BackColor = _listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = _listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);

            //创建的时候我们加入下面创建的事件方法
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = _backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = _backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(4, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);

            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(1, 1);
            this.Size = _size;
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(_borderSize);
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = _borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }


        #region 定义方法 重写方法

        //定义方法，调整尺寸
        private void AdjustComboBoxDimensions()
        {
            cmbList.Location = new Point()
            {
                //X = this.Width - this.Padding.Right - cmbList.Width,
                X = lblText.Location.X,
                Y = lblText.Bottom - cmbList.Height
            };
            cmbList.Width = lblText.Width + btnIcon.Width;
        }

        //comboBox的下拉选择方法
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblText.Text = cmbList.Text;
        }

        //图标点击方法
        //上面的方法以及下面写的方法，我们需要赋给comboBox
        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);

            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }


        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //文字改变时刷新文字
            lblText.Text = cmbList.Text;
        }

        //图标绘制方法
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;


            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(_iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        #endregion


        //定义属性
        [Category("自定义")]
        public new Color BackColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                lblText.BackColor = _backColor;
                btnIcon.BackColor = _backColor;
            }
        }

        [Category("自定义")]
        public Color IconColor
        {
            get { return _iconColor; }
            set
            {
                _iconColor = value;
                btnIcon.Invalidate();
            }
        }

        [Category("自定义")]
        public Color ListBackColor
        {
            get { return _listBackColor; }
            set
            {
                _listBackColor = value;
                cmbList.BackColor = _listBackColor;
            }
        }

        [Category("自定义")]
        public Color ListTextColor
        {
            get { return _listTextColor; }
            set
            {
                _listTextColor = value;
                cmbList.ForeColor = _listTextColor;
            }
        }


        [Category("自定义")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                base.BackColor = _borderColor;
            }
        }

        [Category("自定义")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Padding = new Padding(_borderSize);
                AdjustComboBoxDimensions();
            }
        }


        

        [Category("自定义")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("自定义")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
                AdjustComboBoxDimensions();
            }
        }

        [Category("自定义")]
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }


        [Category("自定义")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }


        [Category("自定义数据")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        [Category("自定义数据")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("自定义数据")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }


        [Category("自定义数据")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }


        [Category("自定义数据")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }


        [Category("自定义数据")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        [Category("自定义数据")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        [Category("自定义数据")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SelectedText
        {
            get { return cmbList.SelectedText; }
            set { cmbList.SelectedText = value; }
        }

        [Category("自定义数据")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        [Category("自定义数据")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

    }
}
