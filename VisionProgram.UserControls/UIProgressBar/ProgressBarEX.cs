using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UIProgressBar
{
    public partial class ProgressBarEX : ProgressBar
    {
        private Color _yStartColor = Color.Transparent;
        private Color _yEndColor = Color.Green;
        private bool _yIsShowValue = false;
        private Font _yValueFont = new Font("微软雅黑",9,System.Drawing.FontStyle.Regular);
        private Color _yValueFontColor = Color.Black;

        public ProgressBarEX()
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.UserPaint,true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }

        [Description("渐变颜色起始颜色"),Browsable(true),Category("自定义属性")]
        public Color ColorStart
        {
            get { return _yStartColor; }
            set
            {
                _yStartColor = value;
                Refresh();
            }
        }

        [Description("渐变颜色结束颜色"), Browsable(true), Category("自定义属性")]
        public Color ColorEnd
        {
            get { return _yEndColor; }
            set
            {
                _yEndColor = value;
                Refresh();
            }
        }

        [Description("是否显示value值"), Browsable(true), Category("自定义属性")]
        public bool ShowValue
        {
            get { return _yIsShowValue; }
            set
            {
                _yIsShowValue = value;
                Refresh();
            }
        }

        [Description("是否显示value值字体颜色"), Browsable(true), Category("自定义属性")]
        public Color ValueFontColor
        {
            get { return _yValueFontColor; }
            set
            {
                _yValueFontColor = value;
                Refresh();
            }
        }


        [Description("显示value值字体"), Browsable(true), Category("自定义属性")]
        public Font ValueFont
        {
            get { return _yValueFont; }
            set
            {
                _yValueFont = value;
                Refresh();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush = null;
            Rectangle rect = new Rectangle(0, 0, base.Width, base.Height);
            rect.Height -= 4;
            rect.Width = ((int)(rect.Width * (((double)base.Value) / ((double)base.Maximum)))) - 4;
            brush = new LinearGradientBrush(this.ClientRectangle, _yStartColor, _yEndColor, LinearGradientMode.Horizontal);
            e.Graphics.FillRectangle(brush, 2, 2, rect.Width, rect.Height);

            if (_yIsShowValue)
            {
                SizeF sizeF = e.Graphics.MeasureString(base.Value.ToString(), _yValueFont);
                float x, y;
                x = base.Width / 2 - sizeF.Width / 2;
                y = base.Height / 2 - sizeF.Height / 2;
                e.Graphics.DrawString(base.Value.ToString(), _yValueFont, new SolidBrush(_yValueFontColor), x, y);
            }

            e.Graphics.DrawRectangle(new Pen(Color.Silver), 0, 0, base.Width - 1, base.Height - 1);
        }
    }
}
