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
namespace VisionProgram.UI.UIDC
{
    public partial class FrmMainDC : Form
    {
        private FrmMainDC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmMainDC _instance;

        public static FrmMainDC Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmMainDC();
                return _instance;
            }
        }


        private void FrmMainDC_Load(object sender, EventArgs e)
        {

        }
    }
}
