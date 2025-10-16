using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace DataCollection.UI.UIHome.RightForm
{
    public partial class FrmCapacityData : Form
    {
        List<Chart> _chartList = new List<Chart>();

        List<List<string>> xDatas = new List<List<string>>();

        #region 构造 单例
        private FrmCapacityData()
        {

            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            NoticeHelper.OnUpdateCapaticyChart += UpdateChartData;

            xDatas.Add(new List<string>() { "机台1OK数", "机台1NG数" });//这两个名字可以根据自己需求更改，但必须是什么什么OK数、什么什么NG数
            //当前界面模拟一个Chart!! 若还有第二个统计图，可继续添加其对应的图例说明，如下面屏蔽的代码
            //xDatas.Add(new List<string>() { "机台2OK数", "机台2NG数" });//这两个名字可以根据自己需求更改，但必须是什么什么OK数、什么什么NG数

            _chartList.Clear();
            _chartList.Add(InitChart(Chart1,
               xDatas[0],
                new List<double>() {
                Project.Instance.ProductionDataManagerInstance.L_ProduceStationOKCount[0],
                Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[0]
            }));

        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmCapacityData _instance;
        public static FrmCapacityData Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmCapacityData();
                return _instance;
            }
        }

        #endregion

        #region 渲染控件

        private Chart InitChart(Chart chart, List<string> xData, List<double> yData)
        {
            chart.Series["Series1"]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart.Series["Series1"]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart.Series["Series1"].ToolTip = "#VALX：#VAL";//鼠标停靠在饼状图上时，显示数值。
            chart.Series["Series1"].Points.DataBindXY(xData, yData);
            //修改每个块指引出来的标签文本
            for (int i = 0; i < chart.Series[0].Points.Count; i++)
            {
                chart.Series[0].Points[i].Label = yData[i].ToString();
                chart.Series[0].Points[i].LegendText = xData[i];
            }
            chart.Titles[0].Text = string.Format("{0}({1})", chart.Titles[0].Text, yData[0] + yData[1] > 0 ? (yData[0] / (yData[0] + yData[1])).ToString("p") : "0%");
            return chart;
        }

        #endregion 

        #region 渲染统计图数据
        private static readonly object O = new object();
        /// <summary>
        /// 修改统计数据 
        /// </summary>
        /// <param name="index">第一个就是0 第二个就是1 ..... 全部就是-1</param>
        public void UpdateChartData(int index)
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(new Action(() =>
                {
                    lock (O)
                    {
                        if (index < 0)
                        {
                            UpdateChart(0);//因为当前界面只显示了一个Chart，若还有第二个Chart，可继续写 UpdateChart(1)；
                        }
                        else
                            UpdateChart(index);
                    }
                }));
            }

        }

        /// <summary>
        /// Chart刷新
        /// </summary>
        /// <param name="chart"></param>
        private void UpdateChart(int index)
        {
            double[] yValues = {   Project.Instance.ProductionDataManagerInstance.L_ProduceStationOKCount[index],
                                    Project.Instance.ProductionDataManagerInstance.L_ProduceStationNGCount[index]};
            string[] xValues = xDatas[index].ToArray();
            _chartList[index].Series["Series1"].Points.DataBindXY(xValues, yValues);

            foreach (DataPoint point in _chartList[index].Series["Series1"].Points)
            {
                if (point.AxisLabel.Contains("OK数"))
                {
                    point.Label = yValues[0].ToString();
                    point.LegendText = xValues[0];
                }
                if (point.AxisLabel.Contains("NG数"))
                {
                    point.Label = yValues[1].ToString();
                    point.LegendText = xValues[1];
                }
            }
            _chartList[index].Titles[0].Text = string.Format("·{0}({1})", xValues[0].TrimEnd("OK数".ToArray()), yValues[0] + yValues[1] > 0 ? (yValues[0] / (yValues[0] + yValues[1])).ToString("p") : "0%");
            _chartList[index].Series["Series1"].IsXValueIndexed = false;
            _chartList[index].Series["Series1"].IsValueShownAsLabel = false;

        }


        #endregion

        #region 按钮

        //private void 硬件设备良率ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!FrmYieldData.Instance.Visible)
        //    {
        //        FrmYieldData.Instance.SetYieldDataFormLocation();
        //        FrmYieldData.Instance.Show();
        //    }
        //    else
        //        this.ConfirmInfoDialog("硬件设备良率统计信息窗体已打开！");
        //}

        private void 产能清0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.QuestionWarningDialog("确定要清除机台产能数据吗", "清除机台产能数据") == DialogResult.Yes)
                {
                    Project.Instance.ProductionDataManagerInstance.ClearCapaticyData();
                    NoticeHelper.UpdateCapaticyChartMessageSend(-1);//全部
                    NoticeHelper.OutputMessageSend("清除机台产能数据", OutputLevelModel.INFO);
                }
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"清除机台产能数据时发生异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Error("清除机台产能数据时发生异常", ex);
            }
        }

        #endregion



        private void 原始图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //默认打开相机1的路径
            if (Directory.Exists(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].RawImagePosition))
            {
                Process.Start(Project.Instance.VisionManagerInstance.GetRawImagePosition());
            }
            else
            {
                MessageBox.Show("目标文件夹不存在");
            }
        }

        private void 结果图像ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //默认打开相机1的路径
            if (Directory.Exists(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[0].ResultImagePosition))
            {
                Process.Start(Project.Instance.VisionManagerInstance.GetResultImagePosition());
            }
            else
            {
                MessageBox.Show("目标文件夹不存在");
            }
        }
    }
}
