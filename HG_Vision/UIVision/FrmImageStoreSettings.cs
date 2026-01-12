using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model.ConstantModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIVision
{
    public partial class FrmImageStoreSettings : Form
    {
        /// <summary>
        /// 记录修改
        /// </summary>
        public Action<List<OperationLogParamModel.OldParam>> OnChangeImageStoreSettings;

        /// <summary>
        /// 特征码，区分不同的流程
        /// </summary>
        private int index;
        public FrmImageStoreSettings(string p)
        {
            InitializeComponent();
            //this.TopLevel = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopLevel = false;
            //this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            this.LabelTitle.Text = p + "号相机图像保存设置";
            //当前窗体对应的vpp索引
            index = Convert.ToInt16(p) - 1;

            InitializeLoad();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_APPWINDOW = 0x40000;
                const int WS_EX_TOOLWINDOW = 0x80;
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~WS_EX_APPWINDOW);    // 不显示在TaskBar
                cp.ExStyle |= WS_EX_TOOLWINDOW;      // 不显示在Alt+Tab
                return cp;
            }
        }

        public void InitializeLoad()
        {
            cbRawImagePattern.Text = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePattern;
            cbResultImagePattern.Text = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern;
            lbRawPosition.Text = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition;
            lbResultPosition.Text = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition;
            numUDRawKeepingDays.Value = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays;
            numUDResultKeepingDays.Value = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays;
            radioChanceRawIsSave.SelectedIndex = (int)(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity);
            radioChanceResultIsSave.SelectedIndex = (int)(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity);
        }

        private void btnChangeRawPosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                lbRawPosition.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnChangeResultPosition_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {
                lbResultPosition.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要保存图像参数？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    List<OperationLogParamModel.OldParam> oldImageParamObjects = new List<OperationLogParamModel.OldParam>();

                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePattern.Equals(cbRawImagePattern.Text))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "历史图片格式", Field = "gRawImagePattern", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePattern, NewValue = cbRawImagePattern.Text });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePattern = cbRawImagePattern.Text;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "RAWPATTERN", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePattern);
                    }
                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity.Equals((ImageParamsModel.SAVEOPPORTUNITY)radioChanceRawIsSave.SelectedIndex))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "历史图片是否保存", Field = "gRawImageSaveOpportunity", OldValue = GetSaveOpportunityText((int)Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity), NewValue = (radioChanceRawIsSave.Items[radioChanceRawIsSave.SelectedIndex]).ToString() });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity = (ImageParamsModel.SAVEOPPORTUNITY)radioChanceRawIsSave.SelectedIndex;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "ISRAWSAVE", (Convert.ToInt16(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImageSaveOpportunity)).ToString());
                    }
                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition.Equals(lbRawPosition.Text))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "历史图片位置", Field = "gRawImagePosition", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition, NewValue = lbRawPosition.Text });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition = lbRawPosition.Text;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "RawImagePosition", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawImagePosition);
                    }
                    if (!(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays == numUDRawKeepingDays.Value))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "历史图片保存天数", Field = "gRawKeepingDays", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays + "", NewValue = numUDRawKeepingDays.Value + "" });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays = (int)(numUDRawKeepingDays.Value);
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "RawKeepingDays", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].RawKeepingDays.ToString());
                    }
                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern.Equals(cbResultImagePattern.Text))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "结果图片格式", Field = "gResultImagePattern", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern, NewValue = cbResultImagePattern.Text });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern = cbResultImagePattern.Text;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "RESULTPATTERN", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePattern);
                    }
                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity.Equals((ImageParamsModel.SAVEOPPORTUNITY)radioChanceResultIsSave.SelectedIndex))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "结果图片是否保存", Field = "gResultImageSaveOpportunity", OldValue = GetSaveOpportunityText((int)Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity), NewValue = (radioChanceResultIsSave.Items[radioChanceResultIsSave.SelectedIndex]).ToString() });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity = (ImageParamsModel.SAVEOPPORTUNITY)radioChanceResultIsSave.SelectedIndex;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "ISRESULTSAVE", (Convert.ToInt16(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImageSaveOpportunity)).ToString());
                    }
                    if (!Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition.Equals(lbResultPosition.Text.Trim()))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "结果图片位置", Field = "gResultImagePosition", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition, NewValue = lbResultPosition.Text });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition = lbResultPosition.Text;
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "ResultImagePosition", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultImagePosition);
                    }
                    if (!(Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays == numUDResultKeepingDays.Value))
                    {
                        oldImageParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "结果图片保存天数", Field = "gResultKeepingDays", OldValue = Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays + "", NewValue = numUDResultKeepingDays.Value + "" });
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays = (int)(numUDResultKeepingDays.Value);
                        Project.Instance.VisionManagerInstance.ImageManagerInstance.SaveOneParams("IMAGESAVE" + (index + 1).ToString(), "ResultKeepingDays", Project.Instance.VisionManagerInstance.ImageManagerInstance.ImageParams[index].ResultKeepingDays.ToString());
                    }

                    if (oldImageParamObjects.Count > 0)
                    {
                        MessageBox.Show("图像设置参数修改成功！");
                        OnChangeImageStoreSettings?.Invoke(oldImageParamObjects);
                    }
                    else
                    {
                        MessageBox.Show("图像设置参数暂无修改");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存图像设置参数出现异常:" + ex.ToString());
                    LogHelper.Error("保存图像设置参数出现异常", ex);
                }

            }
        }

        private string GetSaveOpportunityText(int index)
        {
            string str = "";
            switch (index)
            {
                case 0:
                    str = "都不保存";
                    break;
                case 1:
                    str = "仅OK保存";
                    break;
                case 2:
                    str = "仅NG保存";
                    break;
                case 3:
                    str = "全部保存";
                    break;
            }
            return str;
        }

        private void FrmImageStoreSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认关闭？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e) =>  this.Close();
    }
}
