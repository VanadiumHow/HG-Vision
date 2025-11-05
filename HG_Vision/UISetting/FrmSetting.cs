using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model.DataModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.UIHome;
using HG_Vision.UIVision;
using HG_Vision.Contol.Control_Sql;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UISetting
{
    public partial class FrmSetting : Form
    {
        //记录当前被点击的是哪个按钮对象
        private Button _newClickButton;

        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSetting()
        {
            InitializeComponent();

            #region 注册子窗体事件
            //常规
            FrmGeneralSettings.Instance.OnChangeGeneralSettings = ChangeGeneralSettings;

            //产品切换
            FrmProductChangeSettings.Instance.OnChangeProductSettings = ChangeProductSettings;
            FrmProductChangeSettings.Instance.OnRemoveProductSettings = RemoveProductSettings;

            #endregion
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmSetting _instance;
        public static FrmSetting Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmSetting();
                return _instance;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    //避免闪屏
                return cp;
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            //默认选择第一个
            ButtonCameraParamsSetting_Click(null, null);

            FrmGeneralSettings.Instance.InitializeLoad();
            FrmProductChangeSettings.Instance.InitializeLoad();
        }

        #region 界面切换按钮
        /// <summary>
        /// 通用方法 切换界面
        /// </summary>
        /// <param name="form"></param>

        public void LoadForm(Button button, object form)
        {
            //将当前（上一次）点击的按钮颜色复位掉
            if (_newClickButton != null)
            {
                _newClickButton.BackColor = Color.Transparent;
            }
            //将新的按钮颜色变掉
            button.BackColor = Color.FromArgb(60,67,78);
            //将当前按钮对象指向现在这个按钮
            _newClickButton = button;
            if (this.PanelMain.Controls.Count > 0)
                this.PanelMain.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.PanelMain.Controls.Add(f);
            this.PanelMain.Tag = f;
            f.Show();
            notifyIcon1.Visible = false;

        }




        #endregion

        #region 关闭按钮
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (this.QuestionInfoDialog("确实要关闭参数设置界面？", "关闭界面") == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();

            }
        }

        private void FrmSetting_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        #endregion

        #region 注册事件对应的实现

        #region 修改常规参数回调事件
        private void ChangeGeneralSettings(List<OperationLogParamModel.OldParam> oldGeneralParamObjects)
        {
            OperationLogDataBll.GetInstance().InsertOperationLog(oldGeneralParamObjects, "常规设置");
        }
        #endregion

        #region 修改产品更换参数回调事件
        /// <summary>
        /// 切换产品事件回调
        /// </summary>
        /// <param name="oldValue"></param>
        /// <param name="newValue"></param>
        private void ChangeProductSettings(string oldValue, string newValue)
        {
            try
            {
                this.Invoke(new Action(() =>
                {
                    FrmHome.Instance.LabelProgramTitle.Text = Project.Instance.GlobalManagerInstance.GlobalParamModel.programTitle + (Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel ? "  产品型号：" + Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel : "");
                    FrmHome.Instance.NotifyIcon1.Text = FrmHome.Instance.LabelProgramTitle.Text;
                }));
                OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance.UserManagerInstance.CurrentUser.UserRoleName,
                    OperationLogParamModel.LogCTypes[2], "ChangeProduct", oldValue, newValue, string.Format("触发{0}，将{1}从{2}变成{3}", "切换产品", "产品型号", oldValue, newValue)));
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"保存切换产品日志异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Error("保存切换产品日志异常", ex);
            }
        }

        /// <summary>
        /// 删除产品事件回调
        /// </summary>
        /// <param name="old"></param>
        private void RemoveProductSettings(string old)
        {
            try
            {
                OperationLogDataBll.GetInstance().OperationLogProcessFactory(new OperationLogDataModel(Project.Instance.UserManagerInstance.CurrentUser.UserRoleName,
                    OperationLogParamModel.LogCTypes[2], "DeleteProduct", old, null, $"触发删除产品型号{old}"));
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"保存删除产品日志异常：{ex.Message}", OutputLevelModel.ERROR);
                LogHelper.Error("保存删除产品日志异常", ex);
            }
        }



        #endregion

        #endregion



        private void ButtonMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else
            {
                this.Show();
                notifyIcon1.Visible = true;
            }
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private Point mPoint;
        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        /// <summary>
        /// 切换到相机参数界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCameraParamsSetting_Click(object sender, EventArgs e)
        {
            LoadForm(ButtonCameraParamsSetting, FrmCameraParamsSettings.Instance);
        }
        /// <summary>
        /// 切换到产品换型界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonProductChangeSet_Click(object sender, EventArgs e)
        {
            LoadForm(ButtonProductChangeSet, FrmProductChangeSettings.Instance);
        }
        ///// <summary>
        ///// 切换到常规设置界面
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        private void ButtonGeneralSet_Click(object sender, EventArgs e)
        {
            LoadForm(ButtonGeneralSet, FrmGeneralSettings.Instance);
        }
    }
}
