using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using Model.ConstantModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UISetting
{
    public partial class FrmProductChangeSettings : Form
    {
        //切换产品 触发回调事件
        public Action<string, string> OnChangeProductSettings;
        //移除产品 触发回调事件
        public Action<string> OnRemoveProductSettings;

        private FrmProductChangeSettings()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        private static FrmProductChangeSettings _instance;
        public static FrmProductChangeSettings Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmProductChangeSettings();
                return _instance;
            }
        }

        /// <summary>
        /// 加载界面信息
        /// </summary>
        public void InitializeLoad()
        {
            TextBoxEXNewProductModelName.Clear();
            RefreshProductList();
        }


        /// <summary>
        /// 刷新listbox
        /// </summary>
        private void RefreshProductList()
        {
            string file;
            ListBoxProductModelList.Items.Clear();
            if (!Directory.Exists(FilePathModel.ProductPath))
            {
                Directory.CreateDirectory(FilePathModel.ProductPath);
                return;
            }
            ListBoxProductModelList.Items.Add("默认");
            foreach (string filename in System.IO.Directory.GetDirectories(FilePathModel.ProductPath))
            {
                file = filename.Substring(filename.LastIndexOf(@"\") + 1);
                ListBoxProductModelList.Items.Add(file);
            }

            //选中当前型号
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel)
            {
                ListBoxProductModelList.SelectedIndex = ListBoxProductModelList.Items.IndexOf(Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel);
            }
            else
            {
                ListBoxProductModelList.SelectedIndex = 0;
            }

        }

        #region 切换
        /// <summary>
        /// 切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExchangeProductModel_Click(object sender, EventArgs e)
        {
            if (this.QuestionInfoDialog("确定要切换产品型号吗？", "切换产品型号") == DialogResult.Yes)
            {
                ChangeProductStyle();
            }
        }

        private void ChangeProductStyle()
        {
            if (-1 == ListBoxProductModelList.SelectedIndex)
            {
                this.ConfirmErrorDialog("请选中要切换的类型！");
                return;
            }
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel == ListBoxProductModelList.Text)
            {
                this.ConfirmErrorDialog("请选择和当前类型不同的类型");
                return;
            }
            string oldValue = Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel ? Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel : "默认";
            string newValue = ListBoxProductModelList.Text;
            NoticeHelper.OutputMessageSend($"切换产品型号 {ListBoxProductModelList.Text} 中....", OutputLevelModel.INFO);
            try
            {
                //设置产品模式
                Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel = ListBoxProductModelList.Text;
                Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel = ListBoxProductModelList.Text == "默认" ? false : true;
                //修改config 模型参数设置 持久化
                Project.Instance.GlobalManagerInstance.SetCurProductModel();
                // 更新视觉参数、视觉工具文件夹路径
                {
                    Project.Instance.VisionManagerInstance.LoadVisionPath();
                }
                // 重新加载视觉参数
                {
                    Project.Instance.VisionManagerInstance.LoadVisionParam();
                }
                // 重新加载视觉工具
                {
                    Project.Instance.VisionManagerInstance.LoadVisionTool();
                }
                OnChangeProductSettings?.Invoke(oldValue, newValue);
                Thread.Sleep(200);
                NoticeHelper.OutputMessageSend($"切换产品型号 {Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel} 成功！", OutputLevelModel.INFO);
                this.ConfirmInfoDialog("切换产品型号 " + Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel + " 成功！");
            }
            catch (Exception ex)
            {
                NoticeHelper.OutputMessageSend($"切换产品型号 {ListBoxProductModelList.Text} 异常：{ex.Message}", OutputLevelModel.ERROR);
                this.ConfirmErrorDialog($"切换产品型号 {ListBoxProductModelList.Text} 异常：" + ex.Message);
                LogHelper.Error($"切换产品型号 {ListBoxProductModelList.Text} 异常", ex);
            }

        }
        #endregion


        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewProductModel_Click(object sender, EventArgs e)
        {
            string t = TextBoxEXNewProductModelName.Text.Trim();

            if (string.IsNullOrEmpty(t))
            {
                this.ConfirmErrorDialog("输入请不要为空！");
                return;
            }

            if (this.QuestionInfoDialog("确定要添加该产品型号吗？", "添加产品型号") == DialogResult.Yes)
            {
                bool bExits = ListBoxProductModelList.Items.Contains(t);

                if (!bExits)
                {
                    DirectoryHelper.CopyDirectories(FilePathModel.VisionToolDefaultPath, FilePathModel.ProductPath + @"\" + TextBoxEXNewProductModelName.Text + @"\VisionTool");
                    DirectoryHelper.CopyDirectories(FilePathModel.VisionParamDefaultPath, FilePathModel.ProductPath + @"\" + TextBoxEXNewProductModelName.Text + @"\VisionParam");
                    RefreshProductList();
                    NoticeHelper.OutputMessageSend($"添加产品型号 {TextBoxEXNewProductModelName.Text} 成功！", OutputLevelModel.INFO);
                    this.ConfirmInfoDialog("添加产品型号 " + TextBoxEXNewProductModelName.Text + " 成功！");
                }
                else
                {
                    this.ConfirmErrorDialog("重复的命名，请重新输入新的产品型号。");
                }
            }
        }
        #endregion

        #region 移除
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDeleteProductModel_Click(object sender, EventArgs e)
        {
            if (-1 == ListBoxProductModelList.SelectedIndex)
            {
                this.ConfirmErrorDialog("请选中要删除的类型！");
                return;
            }
            if (ListBoxProductModelList.Text == "默认")
            {
                this.ConfirmErrorDialog("请勿删除默认，默认代表适用于全部产品，是程序的默认加载！");
                return;
            }
            if (Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel == ListBoxProductModelList.Text)
            {
                this.ConfirmErrorDialog("请勿删除当前产品类型，程序正在使用当前产品类型视觉配置！");
                return;
            }

            string oldText = ListBoxProductModelList.Text;
            if (this.ConfirmInfoDialog("是否删除选中产品型号的配置文件", "删除产品型号") == DialogResult.OK)
            {
                try
                {
                    Thread.Sleep(100);
                    Directory.Delete(FilePathModel.ProductPath + @"\" + ListBoxProductModelList.Text, true);
                    RefreshProductList();
                    Thread.Sleep(100);
                    NoticeHelper.OutputMessageSend($"删除产品型号 {oldText} 成功！", OutputLevelModel.INFO);
                    this.ConfirmInfoDialog($"删除产品型号{oldText} 成功！");
                    OnRemoveProductSettings?.Invoke(oldText);
                }
                catch (Exception ex)
                {
                    this.ConfirmErrorDialog(ex.Message);
                }
            }
        }


        #endregion
    }
}
