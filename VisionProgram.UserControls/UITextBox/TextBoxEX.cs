using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UITextBox
{
    public partial class TextBoxEX : UserControl
    {
        public TextBoxEX()
        {
            InitializeComponent();
        }

        #region 定义字段

        private Color _borderColor = Color.DarkSlateGray;//边框颜色
        private int _borderSize = 1;//边框尺寸
        private bool _underlinedStyle = false;//是否只显示下边框
        private Color _borderFocusColor = Color.Teal;//聚焦时颜色
        private bool _isFocused = false;//

        private string _watermarkText;
        private const uint ECM_FIRST = 0x1500;
        private const uint EM_SETCUEBANNER = ECM_FIRST + 1;
        #endregion

        #region 定义属性

        [Category("自定义")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }


        [Category("自定义")]
        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        [Category("自定义")]
        public bool UnderlinedStyle
        {
            get { return _underlinedStyle; }
            set
            {
                _underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("自定义")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("自定义")]
        public bool ReadOnly
        {
            get { return textBox1.ReadOnly; }
            set { textBox1.ReadOnly = value; }
        }

        [Category("自定义")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }


        [Category("自定义")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("自定义")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("自定义")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("自定义")]
        public new Padding Padding
        {
            get { return base.Padding; }
            set
            {
                base.Padding = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("自定义")]
        public new Padding Margin
        {
            get { return base.Margin; }
            set
            {
                base.Margin = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("自定义")]
        public new string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        [Category("自定义")]
        public Color BorderFocusColor
        {
            get { return _borderFocusColor; }
            set { _borderFocusColor = value; }
        }

        [Category("自定义")]
        public string WatermarkText
        {
            get { return _watermarkText; }
            set
            {
                _watermarkText = value;
                SetWatermark(_watermarkText);
            }
        }
        #endregion


        #region 定义方法

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text",this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(_borderColor,_borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (_isFocused)
                    penBorder.Color = _borderFocusColor;
                if (_underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

            }
            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            _isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            _isFocused = false;
            this.Invalidate();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (OnTextsChanged != null)
                OnTextsChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        public void Clear()
        {
            textBox1.Clear();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto,SetLastError =false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void SetWatermark(string watermarkText)
        {
            SendMessage(this.textBox1.Handle, EM_SETCUEBANNER, 0, watermarkText);
        }

        
        #endregion

        #region 定义事件

        /// <summary>
        /// 文本改变事件
        /// </summary>
        public event EventHandler OnTextsChanged;



        #endregion

     
    }
}
