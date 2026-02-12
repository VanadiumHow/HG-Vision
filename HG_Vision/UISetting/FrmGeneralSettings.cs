using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UISetting
{
    public partial class FrmGeneralSettings : Form
    {
        /// <summary>
        /// 记录修改
        /// </summary>
        public Action<List<OperationLogParamModel.OldParam>> OnChangeGeneralSettings;

        private FrmGeneralSettings()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmGeneralSettings _instance;
        public static FrmGeneralSettings Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmGeneralSettings();
                return _instance;
            }
        }

        public void InitializeLoad()
        {
            TextBoxEXLogSaveDays.Text = Project.Instance.GlobalManagerInstance.GlobalParamsModel.LogSaveDays.ToString();
            cbProtocolType.Text = Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType;
            cbPLCAgreement.Text = Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement;
            cb_AutoStart.Checked = AutoStartHelper.CheckShortCut();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (this.QuestionInfoDialog("确定要保存常规参数？", "提交参数") == DialogResult.Yes)
            {
                try
                {
                    List<OperationLogParamModel.OldParam> oldGeneralParamObjects = new List<OperationLogParamModel.OldParam>();
                    //日志保存天数参数保存
                    if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.LogSaveDays != Convert.ToInt16(TextBoxEXLogSaveDays.Text))
                    {
                        oldGeneralParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "日志保存天数", Field = "LogSaveDays", OldValue = Project.Instance.GlobalManagerInstance.GlobalParamsModel.LogSaveDays + "", NewValue = TextBoxEXLogSaveDays.Text });
                        Project.Instance.GlobalManagerInstance.GlobalParamsModel.LogSaveDays = Convert.ToInt16(TextBoxEXLogSaveDays.Text);
                    }

                    if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType != cbProtocolType.Text)
                    {
                        oldGeneralParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "机械手通讯协议", Field = "ProtocolType", OldValue = Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType, NewValue = cbProtocolType.Text });
                        Project.Instance.GlobalManagerInstance.GlobalParamsModel.RobotProtocolType = cbProtocolType.Text;
                    }

                    if (Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement != cbPLCAgreement.Text)
                    {
                        oldGeneralParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "PLC通讯协议类型", Field = "PLCAgreement", OldValue = Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement, NewValue = cbPLCAgreement.Text });
                        Project.Instance.GlobalManagerInstance.GlobalParamsModel.PLCAgreement = cbPLCAgreement.Text;
                    }

                    //windows启动文件夹下快捷方式保存
                    if (AutoStartHelper.CheckShortCut() != cb_AutoStart.Checked)
                    {
                        oldGeneralParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "开机自启动", Field = "AutoStart", OldValue = AutoStartHelper.CheckShortCut().ToString(), NewValue = cb_AutoStart.Checked.ToString() });
                        if (cb_AutoStart.Checked)
                            AutoStartHelper.CreateShortcut();
                        else
                            AutoStartHelper.DeleteShortcut();
                    }

                    if (oldGeneralParamObjects.Count > 0)
                    {
                        Project.Instance.GlobalManagerInstance.SaveAllParams();
                        this.ConfirmInfoDialog("常规参数修改成功！");
                        NoticeHelper.OutputMessageSend("常规参数修改成功！", OutputLevelModel.INFO);
                        OnChangeGeneralSettings?.Invoke(oldGeneralParamObjects);
                    }
                    else
                    {
                        NoticeHelper.OutputMessageSend("常规参数暂无修改！", OutputLevelModel.INFO);
                        this.ConfirmInfoDialog("常规参数暂无修改！");
                    }
                }
                catch (Exception ex)
                {
                    NoticeHelper.OutputMessageSend($"保存常规参数出现异常：{ex.Message}", OutputLevelModel.ERROR);
                    LogHelper.Error("保存常规参数出现异常", ex);
                }

            }
        }


    }
}
