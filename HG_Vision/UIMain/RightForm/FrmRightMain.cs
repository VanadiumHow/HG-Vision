using DataCollection.UI.UIHome.RightForm;
using System;
using System.Windows.Forms;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIHome.RightForm
{
    public partial class FrmRightMain : Form
    {
        private FrmRightMain()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmRightMain _instance;
        public static FrmRightMain Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmRightMain();
                return _instance;
            }
        }

        private void FrmRightMain_Load(object sender, EventArgs e)
        {

            //产能统计图统计
            PanelCapaticyDataChart();
            //良率表格统计
            // PanelYieldDataChart();
            ////加载PLCMessageMin信息面板
            //PanelPLCMessageMinLoad();
            ////加载PLCMessage信息面板
            //PanelPLCMessageLoad();
            //加载日志面板
            PanelLogLoad();

        }

        #region 实例化窗体



        /// <summary>
        /// 产能统计图统计
        /// </summary>
        private void PanelCapaticyDataChart()
        {
            Panel5.Controls.Clear();
            Panel5.Controls.Add(FrmCapacityData.Instance);
        }

        /// <summary>
        /// 加载日志面板
        /// </summary>
        private void PanelLogLoad()
        {
            TabPageLog.Controls.Clear();
            TabPageLog.Controls.Add(FrmOutput.Instance);
        }

        #endregion


        #region 加载界面
        internal void ShowForm()
        {
            this.Show();
            FrmHardWareState.Instance.Show();
            //计算分割距离
            double cellWidth = double.Parse(FrmHardWareState.Instance.Width.ToString()) / FrmHardWareState.Instance.ColumnCount;//计算高度
            double cellHeight = cellWidth > (FrmHardWareState.Instance.LampWidth + 10) ? (FrmHardWareState.Instance.LampWidth + 10) : cellWidth;
            int rowHeight = Convert.ToInt32(cellHeight * FrmHardWareState.Instance.RowCount);
            FrmHome.Instance.FrmRightMain.SplitContainer1.SplitterDistance = rowHeight + FrmHome.Instance.FrmRightMain.PanelLampTitle.Height + 1;
            FrmHome.Instance.FrmRightMain.SplitContainer1.SplitterDistance = 354;
            FrmCapacityData.Instance.Show();
            //FrmPLCMessageMini.Instance.Show();
            FrmOutput.Instance.Show();
        }
        #endregion
    }
}
