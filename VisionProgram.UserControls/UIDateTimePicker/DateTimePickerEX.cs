using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UIDataTimer
{
    public class DateTimePickerEX : DateTimePicker
    {
        private Color _skinColor = SystemColors.Window;
        private Color _textColor = Color.Black;
        private Color _borderColor = Color.CadetBlue;
        private int _borderSize = 1;
        private bool _drppedDown = false;
        private Image _calendarIcon = Properties.Resources.时间_30;
        private RectangleF _iconbuttonArea;
        private const int _calendarIconWidth = 35;
        private const int _arrowIconWidth = 17;

        [Category("自定义")]
        public Color SkinColor
        {
            get
            {
                return _skinColor;
            }
            set
            {
                _skinColor = value;
                if (_skinColor.GetBrightness() >= 0.8F)
                {
                    _calendarIcon = Properties.Resources.时间_30;
                }
                else
                {
                    _calendarIcon = Properties.Resources.时间_30;
                }
                this.Invalidate();
            }
        }

        [Category("自定义")]
        public Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                _textColor = value;
                this.Invalidate();
            }
        }

        [Category("自定义")]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [Category("自定义")]
        public int BorderSize
        {
            get
            {
                return _borderSize;
            }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }

        public DateTimePickerEX()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 12F);
        }

        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            _drppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            _drppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        /// 
        /// <summary> 
        ///  重绘 
        /// </summary> 
        /// <param name="e">
        /// </param> 
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            using (Pen penBorder = new Pen(_borderColor, BorderSize))
            using (SolidBrush skinBrush = new SolidBrush(_skinColor))
            using (SolidBrush openIocnBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(_textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - _calendarIconWidth, 0, _calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;
                g.FillRectangle(skinBrush, clientArea);
                g.DrawString(" " + this.Text, this.Font, textBrush, clientArea, textFormat);
                if (_drppedDown)
                {
                    g.FillRectangle(openIocnBrush, iconArea);
                }
                if (_borderSize >= 1)
                {
                    g.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }
                g.DrawImage(_calendarIcon, this.Width - _calendarIcon.Width - 2, (this.Height - _calendarIcon.Height) / 2); }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            _iconbuttonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_iconbuttonArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
        /// <summary> 
        /// 设置图标
        /// </summary> 
        /// <returns></returns> 
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidth < this.Width - (_calendarIconWidth + 20))
            {
                return _calendarIconWidth;
            }
            return _arrowIconWidth;
        }

    }
}
