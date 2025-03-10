using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
*****************************************************************/
namespace VisionProgram.UI.UIVision
{
    public partial class FrmTest : Form
    {
        /// <summary>
        /// 第几个
        /// </summary>
        private string _index;

        public FrmTest(string index)
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            _index = index;

            this.label.Text = $"CCD{_index}";
        }
    }
}
