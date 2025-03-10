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
namespace VisionProgram.UserControls.UIRadioButton
{
    public partial class RadioButtonEX : RadioButton
    {
        #region 定义字段
        private Color _checkedColor = Color.MediumSlateBlue;
        private Color _unCheckedColor = Color.Gray;
        #endregion

        #region 定义属性
        public Color CheckedColor
        {
            get { return _checkedColor; }
            set
            {
                _checkedColor = value;
                this.Invalidate();
            }
        }

        public Color UnCheckedColor
        {
            get { return _unCheckedColor; }
            set
            {
                _unCheckedColor = value;
                this.Invalidate();
            }
        }

        #endregion

        public RadioButtonEX()
        {
            this.MinimumSize = new Size(0, 21);
            this.Padding = new Padding(10, 0, 0, 0);
            this.BackColor = System.Drawing.SystemColors.Control;
        }


        #region 定义方法
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2, //Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), //Center
                Y = (this.Height - rbCheckSize) / 2, //Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            //Drawing
            using (Pen penBorder = new Pen(_checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(_checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            {
                //Draw surface
                graphics.Clear(this.BackColor);
                //Draw Radio Button
                if (this.Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);//Circle border
                    graphics.FillEllipse(brushRbCheck, rectRbCheck); //Circle Radio Check
                }
                else
                {
                    penBorder.Color = _unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); //Circle border
                }
                //Draw text
                graphics.DrawString(this.Text, this.Font, brushText,
                    rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);//Y=Center
            }
        }
        //X-> Obsolete code, this was replaced by the Padding property in the constructor
        //(this.Padding = new Padding(10,0,0,0);)
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    this.Width = TextRenderer.MeasureText(this.Text, this.Font).Width + 30;
        //}
        #endregion
    }
}
