using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using VisionProgram.UserControls.Datas;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UILamp
{
    public partial class LampEX : UserControl
    {
        private Timer _timer = new Timer();
        private int _intColorIndex = 0;
        /// <summary>
        /// 指示灯控件的所有逻辑和绘制代码类
        /// </summary>
        public LampEX()
        {

            InitializeComponent();

            #region 【1】设置双缓冲等属性



            _timer.Enabled = false;
            _timer.Tick += Timer_Tick;

            #endregion

        }
        /// <summary>
        /// 计时器事件，用于闪烁
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {

            _intColorIndex++;
            if (_intColorIndex >= _lampColor.Length)
            {
                _intColorIndex = 0;
            }
            this.Invalidate();

        }

        #region 【2】定义三个字段

        private Graphics _g;
        private Pen _p;
        private SolidBrush _sb;

        #endregion

        #region 【3】添加一个设置Graphics的方法
        /// <summary>
        /// 设置画布的属性
        /// </summary>
        /// <param name="g"></param>
        private void SetGraphics(Graphics g)
        {
            // 设置图形为高质量抗锯齿
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // 设置文本为ClearType渲染
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        }

        #endregion

        #region 【4】根据实际控件分析的结果，创建属性

        private Color _ledTrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));

        [Category("自定义")]
        [Description("TRUE的时候Lamp指示灯颜色")]
        public Color LedTrueColor
        {
            get { return _ledTrueColor; }
            set
            {
                _ledTrueColor = value;
                this.Invalidate();
            }
        }

        private Color _ledFalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));

        [Category("自定义")]
        [Description("False的时候Lamp指示灯颜色")]
        public Color LedFalseColor
        {
            get { return _ledFalseColor; }
            set
            {
                _ledFalseColor = value;
                this.Invalidate();
            }
        }

        private Status _ledStatus = VisionProgram.UserControls.Datas.Status.None;

        [Category("自定义")]
        [Description("当前的状态")]
        public Status LedStatus
        {
            get { return _ledStatus; }
            set
            {
                _ledStatus = value;
                this.Invalidate();
            }
        }

        private Color _ledColor = Color.Green;

        [Category("自定义")]
        [Description("Lamp指示灯演示")]
        public Color LedColor
        {
            get { return _ledColor; }
            set
            {
                _ledColor = value;
                this.Invalidate();
            }
        }

        private bool _isBorder = true;

        [Category("自定义")]
        [Description("是否有边框")]
        public bool IsBorder
        {
            get { return _isBorder; }
            set
            {
                _isBorder = value;
                this.Invalidate();
            }
        }

        private int _borderWidth = 5;

        [Category("自定义")]
        [Description("圆环的宽度")]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                this.Invalidate();
            }
        }

        private int _gapWidth = 5;

        [Category("自定义")]
        [Description("间隙的宽度")]
        public int GapWidth
        {
            get { return _gapWidth; }
            set
            {
                _gapWidth = value;
                this.Invalidate();
            }
        }

        private bool _isHighLight = true;

        [Category("自定义")]
        [Description("是否高亮")]
        public bool IsHighLight
        {
            get { return _isHighLight; }
            set
            {
                _isHighLight = value;
                this.Invalidate();
            }
        }

        private Color _centerColor = Color.White;

        [Category("自定义")]
        [Description("渐变中心的颜色")]
        public Color CenterColor
        {
            get { return _centerColor; }
            set
            {
                _centerColor = value;
                this.Invalidate();
            }
        }

        private bool _isFlash = true;

        [Category("自定义")]
        [Description("是否闪烁")]
        public bool IsFlash
        {
            get { return _isFlash; }
            set
            {
                _isFlash = value;
                this.Invalidate();
            }
        }

        private int _flashInterval = 500;

        [Category("自定义")]
        [Description("闪烁的频率")]
        public int FlashInterval
        {
            get { return _flashInterval; }
            set
            {
                _flashInterval = value;
                _timer.Interval = _flashInterval;//timer的时间间隔要放在这里
                this.Invalidate();
            }
        }

        private Color[] _lampColor = new Color[] { };

        [Category("自定义")]
        [Description("闪烁灯的几种颜色，当需要闪烁时，至少需要2个及以上颜色，不需要闪烁则至少需要1个颜色")]
        public Color[] LampColor
        {
            get { return _lampColor; }
            set
            {
                if (value == null || value.Length <= 0)
                    return;
                _lampColor = value;
                this.Invalidate();
            }
        }


        #endregion

        #region 【5】创建重绘的事件

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _g = e.Graphics;//获取画布
            SetGraphics(_g);//设置画布

            #region 1，画一个圆

            int LEDWidth = Math.Min(this.Width, this.Height);

            Color color = GetStatusColor(this.LedStatus);
            if (_isFlash)
            {
                _lampColor = new Color[] { color, Color.Yellow };
                color = _lampColor[_intColorIndex];
            }

            _sb = new SolidBrush(color);
            RectangleF rec = new RectangleF(1, 1, LEDWidth - 2, LEDWidth - 2);//创建矩形
            _g.FillEllipse(_sb, rec);//画圆

            #endregion

            #region 2,在圆里面画一个圆环

            //如果有边框，那就画一个圆环
            if (_isBorder)//参数这里用字段或属性都可以，如果用属性，程序要都走一些判断的代码
            {
                _p = new Pen(this.BackColor, _borderWidth);//使用背景色
                //p = new Pen(Color.Red, borderWidth);
                float x = 1 + _gapWidth + _borderWidth * 0.5f;
                rec = new RectangleF(x, x, LEDWidth - 2 * x, LEDWidth - 2 * x);
                _g.DrawEllipse(_p, rec);//画圆环
            }

            #endregion

            #region 3，渐变色绘制，是否高亮

            if (_isHighLight)
            {
                GraphicsPath gp = new GraphicsPath();
                float x = _isBorder ? 1 + _gapWidth + _borderWidth : 1;//使用三元运算来判断，优化代码
                rec = new RectangleF(x, x, LEDWidth - 2 * x, LEDWidth - 2 * x);
                gp.AddEllipse(rec);//把矩形添加到路径

                //渐变色画刷，高亮
                PathGradientBrush pgb = new PathGradientBrush(gp);//把路径传入

                Color[] surroundColor = new Color[] { color };

                pgb.CenterColor = this._centerColor;

                //设置有多少组颜色来渐变
                pgb.SurroundColors = surroundColor;
                _g.FillPath(pgb, gp);
            }

            #endregion


        }

        #endregion



        #region GetStatusColor 获取状态对应的颜色
        /// <summary>
        /// 颜色可扩展
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        private Color GetStatusColor(Status status)
        {
            switch (status)
            {
                case Status.OK:
                case Status.Open:
                    return LedTrueColor;
                case Status.EX:
                case Status.ERR:
                    return LedFalseColor;
                case Status.Stop:
                    return System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
                case Status.Close:
                    return Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(232)))));
                case Status.None:
                default:
                    return System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            }
        }
        #endregion
    }
}
