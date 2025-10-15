using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model.UIModel;
using HG_Vision.Manager.Manager_System;
using Sunny.UI;
/****************************************************************

*****************************************************************/
namespace HG_Vision.UIVision
{
    public partial class FrmMainVision : Form
    {
        //图像窗口列表
        private List<Form> _frmVisionControlList = new List<Form>();

        private FrmMainVision()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            //初始化图像窗口LIST
            //InitialFrmVisionControlList(Project.Instance.VisionManagerInstance.CameraManagerInstance.CameraNum);
        }


        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmMainVision _instance;
        public static FrmMainVision Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmMainVision();
                return _instance;
            }
        }

        private void FrmMainVision_Load(object sender, EventArgs e)
        {
            //初始化图像窗口LIST
            InitialFrmVisionControlList(Project.Instance.VisionManagerInstance.CameraNum);
            //布局图像窗口
            LoadCameraForm(Project.Instance.GlobalManagerInstance.GlobalParamModel.MaxWorkNum, Project.Instance.VisionManagerInstance.CameraNum);

        }

        //
        /// <summary>
        /// 初始化图像窗口LIST
        /// </summary>
        /// 
        public void InitialFrmVisionControlList(int workFlowNum)
        {
            if (workFlowNum <= 0) return;

            //动态加载相机窗口，填充到L_frmVisionControl
            _frmVisionControlList.Clear();
            //传递窗体显示display
            GlobalCameraParams.cameraVisionControlList.Clear();

            for (int i = 0; i < workFlowNum; i++)
            {
                if (Project.Instance.VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[i].ImageWindowType == "VP")
                {
                    FrmVpVisionControl frmVisionControl1 = new FrmVpVisionControl((i + 1).ToString());
                    _frmVisionControlList.Add(frmVisionControl1);
                    GlobalCameraParams.cameraVisionControlList.Add(frmVisionControl1.RecordDisplay);
                }

            }
        }

        /// <summary>
        /// 调整画面布局
        /// </summary>
        /// <param name="videoNum"></param>
        /// <returns></returns>
        private void LoadCameraForm(int maxWorkNum, int workFlowNum)
        {
            if (workFlowNum <= 0) return;
            //清空画布上的控件
            this.PanelAll.Controls.Clear();

            //界面设计是分两页展示8个相机，一页4个。目前没有做到通过用户DIY页面完全动态布局
            //若有需求需要一页把相机全部展示完，则需要在以下方法中进行更改。
            if (maxWorkNum / workFlowNum > 1)//1234
            {
                this.PanelAll.Controls.Add(this.TableLayoutPanelMainVision);
                LoadCameraTabPage1(workFlowNum, TableLayoutPanelMainVision);
            }
            else//5678
            {
                this.PanelAll.Controls.Add(this.TabControlAll);
                LoadCameraTabPage1(4, TableLayoutPanelFirstVision);
                LoadCameraTabPage2(workFlowNum - 4);
            }
        }

        /// <summary>
        /// 加载第一页相机
        /// </summary>
        /// <param name="workFlowNum"></param>
        private void LoadCameraTabPage1(int workFlowNum, UITableLayoutPanel tlp)
        {

            int newRowCount = workFlowNum > 2 ? 2 : 1;//1 1 2 2
            int newColCount = workFlowNum > 1 ? 2 : 1;//1 2 2 2 

            tlp.Refresh();
            tlp.RowCount = newRowCount;
            tlp.ColumnCount = newColCount;
            tlp.ColumnStyles.Clear();
            tlp.RowStyles.Clear();
            for (int i = 0; i < newColCount; i++)
            {
                tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / newColCount));
            }
            for (int i = 0; i < newRowCount; i++)
            {
                tlp.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / newRowCount));
            }
            //窗体布局
            for (int i = 0; i < workFlowNum; i++)
            {
                _frmVisionControlList[i].Dock = System.Windows.Forms.DockStyle.Fill;
                tlp.Controls.Add(_frmVisionControlList[i], i % newColCount, i / newColCount);
                _frmVisionControlList[i].Show();
            }
        }

        /// <summary>
        /// 加载第二页相机
        /// </summary>
        /// <param name="workFlowNum"></param>
        private void LoadCameraTabPage2(int workFlowNum)
        {
            int newRowCount = 2, newColCount = 2;

            TableLayoutPanelSecondVision.Refresh();
            TableLayoutPanelSecondVision.RowCount = newRowCount;
            TableLayoutPanelSecondVision.ColumnCount = newColCount;
            TableLayoutPanelSecondVision.ColumnStyles.Clear();
            TableLayoutPanelSecondVision.RowStyles.Clear();
            for (int i = 0; i < newColCount; i++)
            {
                TableLayoutPanelSecondVision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / newColCount));
            }
            for (int i = 0; i < newRowCount; i++)
            {
                TableLayoutPanelSecondVision.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / newRowCount));
            }
            //窗体布局
            for (int i = 0; i < workFlowNum; i++)
            {
                _frmVisionControlList[4 + i].Dock = System.Windows.Forms.DockStyle.Fill;
                TableLayoutPanelSecondVision.Controls.Add(_frmVisionControlList[4 + i], i % newColCount, i / newColCount);
                _frmVisionControlList[4 + i].Show();
            }
        }

        private void FrmMainVision_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //停止实时取向
        public void stopLiveDisplay()
        {
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraManagerInstance.CameraNum; i++)
            {
                if (Project.Instance.VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[i].ImageWindowType == "VP")
                {
                    if (((FrmVpVisionControl)_frmVisionControlList[i]).IsLive)
                    {
                        ((FrmVpVisionControl)_frmVisionControlList[i]).stopLiveDisplay();
                    }
                }
            }
        }

        /// <summary>
        /// 释放e
        /// </summary>
        public void Exit()
        {
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraManagerInstance.CameraNum; i++)
            {
                if (Project.Instance.VisionManagerInstance.CameraManagerInstance.A_CameraAttributes[i].ImageWindowType == "VP")
                {
                    ((FrmVpVisionControl)_frmVisionControlList[i]).Exit();
                }
            }
        }
    }
}
