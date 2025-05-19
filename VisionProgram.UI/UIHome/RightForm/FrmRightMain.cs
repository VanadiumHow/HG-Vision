using DataCollection.UI.UIHome.RightForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;

/****************************************************************

*****************************************************************/
namespace VisionProgram.UI.UIHome.RightForm
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
        /// 良率表格统计
        /// </summary>
        //private void PanelYieldDataChart()
        //{
        //    //为了使FrmYieldData的IsHandleCreate为true，进而可以使用BeginInvoke。因为是独立窗体，所以进行以下两行代码操作
        //    FrmYieldData.Instance.Visible = true;
        //    FrmYieldData.Instance.Visible = false;
        //}

        /// <summary>
        /// 加载PLCMessageMin信息面板
        /// </summary>
        private void PanelPLCMessageMinLoad()
        {
            //TabPageInteractionInfo.Controls.Clear();
            //TabPageInteractionInfo.Controls.Add(FrmPLCMessageMini.Instance);


            if (FrmPLCMessageMini.Instance.OnClearMessageMinEvent == null)
                FrmPLCMessageMini.Instance.OnClearMessageMinEvent += ClearPLCMessageData;

            if (FrmPLCMessageMini.Instance.OnSetPLCMessageFormNormalEvent == null)
                FrmPLCMessageMini.Instance.OnSetPLCMessageFormNormalEvent += SetPLCMessageFormNormal;
        }

        /// <summary>
        /// 加载PLCMessage信息面板
        /// </summary>
        private void PanelPLCMessageLoad()
        {
            //为了使FrmPLCMessage的IsHandleCreate为true，进而可以使用BeginInvoke。因为是独立窗体，所以进行以下两行代码操作
            {
                FrmPLCMessage.Instance.Visible = true;
                FrmPLCMessage.Instance.Visible = false;
            }

            if (FrmPLCMessage.Instance.OnClearMessageEvent == null)
                FrmPLCMessage.Instance.OnClearMessageEvent += ClearPLCMessageData;

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

        #region 事件方法

        private void ClearPLCMessageData(int index)
        {
            FrmPLCMessage.Instance.ClearInfo(index);
            FrmPLCMessageMini.Instance.ClearInfo(index);
        }

        /// <summary>
        /// 点击放大PLCMessagePLC流程信息窗体
        /// </summary>
        private void SetPLCMessageFormNormal()
        {
            if (!FrmPLCMessage.Instance.Visible)
            {
                FrmPLCMessage.Instance.SetPLCMessageFormLocation();
                if (FrmPLCMessage.Instance.OnClearMessageEvent == null)
                    FrmPLCMessage.Instance.OnClearMessageEvent += ClearPLCMessageData;
                FrmPLCMessage.Instance.Show();
            }
            else
            {
                this.ConfirmInfoDialog("PLC流程信息窗体已打开！");
            }
        }

        #endregion


    }
}
