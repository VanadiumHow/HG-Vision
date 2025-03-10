using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UserControls.UIPagination
{
    public partial class PaginationEX : UserControl
    {
        public PaginationEX()
        {
            InitializeComponent();
          
        }

        //当前页
        private int _pageIndex = 1;
        //页面记录数
        private int _pageSize = 200;
        //当前页面开始行
        private int _startIndex;
        //当前页面结束行
        private int _endIndex;
        //总记录数
        private int _recordCount = 0;
        //总页面数
        private int _pageCount = 1;
        //跳转页面
        private string _jumpIndex = string.Empty;


        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex
        {
            get { return this._pageIndex; }
            set { this._pageIndex = value; }
        }

        /// <summary>
        /// 页面记录数
        /// </summary>
        public int PageSize
        {
            get { return this._pageSize; }
            set { this._pageSize = value; }
        }

        /// <summary>
        /// 当前页面开始行
        /// </summary>
        public int StartIndex
        {
            get
            {
                _startIndex = (PageIndex - 1 <= 0 ? 0 : PageIndex - 1) * (PageSize <= 0 ? 1 : PageSize) + 1;
                return _startIndex;
            }
        }

        /// <summary>
        /// 当前页面结束行
        /// </summary>
        public int EndIndex
        {
            get
            {
                _endIndex = PageIndex * (PageSize <= 0 ? 0 : PageSize);
                return _endIndex;
            }
        }

        /// <summary>
        /// 总记录数
        /// </summary>
        public int RecordCount
        {
            get
            {
                return this._recordCount;
            }
            set
            {
                this._recordCount = value;
                GetPageCount();
                DrawControl(false);
            }
        }

        /// <summary>
        /// 总页面数
        /// </summary>
        public int PageCount
        {
            get
            {
                this._pageCount = GetPageCount();
                return this._pageCount;
            }
        }

        /// <summary>
        /// 跳转页面
        /// </summary>
        public string JumpIndex
        {
            get
            {
                return this._jumpIndex;
            }
            set
            {
                this._jumpIndex = value;
            }
        }

        /// <summary>
        /// 计算总页面数
        /// </summary>
        /// <returns></returns>
        private int GetPageCount()
        {
            if (PageSize <= 0)
            {
                return 1;
            }
            int page_Count = RecordCount / PageSize;
            if (RecordCount % PageSize != 0)
            {
                page_Count++;
            }
            return page_Count;
        }

        /// <summary>
        /// 页数改变事件
        /// </summary>
        public event EventHandler OnPageChanged;

        /// <summary>
        ///  重绘控件
        /// </summary>
        private void DrawControl(bool callEvent)
        {
            LabelCount.Text = "总行数："+RecordCount;
            labPageIndex.Text = PageIndex.ToString();
            labPageCount.Text = PageCount.ToString();
            txtPageIndex.Text = JumpIndex;

            if (PageCount == 0 || PageCount == 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                if (PageIndex == 1)
                {
                    btnFirst.Enabled = false;
                    btnPrev.Enabled = false;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
                else if (PageIndex == PageCount)
                {
                    btnFirst.Enabled = true;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = false;
                    btnLast.Enabled = false;
                }
                else
                {
                    btnFirst.Enabled = true;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnLast.Enabled = true;
                }
            }
            if (callEvent && OnPageChanged != null)
            {
                OnPageChanged(this, null);//当前分页数字改变时，触发委托事件
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            PageIndex = 1;
            DrawControl(true);
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Max(1, PageIndex - 1);
            DrawControl(true);
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            PageIndex = Math.Min(PageIndex + 1, PageCount);
            DrawControl(true);
        }


        /// <summary>
        /// 末页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            PageIndex = PageCount;
            DrawControl(true);
        }

        private void txtPageIndex_TextChanged(object sender, EventArgs e)
        {
            if (txtPageIndex.Text.Trim() != string.Empty && txtPageIndex.Text.Trim() != JumpIndex)
            {
                int index = 0;
                if (!int.TryParse(txtPageIndex.Text.Trim(), out index))
                {
                    txtPageIndex.Text = JumpIndex;
                    return;
                }
            }
            JumpIndex = txtPageIndex.Text.Trim();
        }

        private void txtPageIndex_Leave(object sender, EventArgs e)
        {
            if (txtPageIndex.Text.Trim() != string.Empty && txtPageIndex.Text.Trim() != JumpIndex)
            {
                int index = 0;
                if (!int.TryParse(txtPageIndex.Text.Trim(), out index))
                {
                    txtPageIndex.Text = JumpIndex;
                    return;
                }
            }
            JumpIndex = txtPageIndex.Text.Trim();
        }


        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJump_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPageIndex.Text.Trim()))
            {
                txtPageIndex.Text = "";
                return;
            }
            int index = 0;
            if (!int.TryParse(txtPageIndex.Text.Trim(), out index))
            {
                txtPageIndex.Text = "";
                return;
            }
            if (index <= 0 || index > PageCount)
            {
                txtPageIndex.Text = "";
                return;
            }
            PageIndex = index;
            DrawControl(true);
            txtPageIndex.Text = "";
        }

        private void txtPageIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void Reset()
        {
            PageIndex = 1;
            RecordCount = 0;
            JumpIndex = string.Empty;
            txtPageIndex.Text = "";
        }
    }
}
