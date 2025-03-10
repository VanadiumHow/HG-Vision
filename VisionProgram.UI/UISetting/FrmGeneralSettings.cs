﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Models.VModels;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Common;

/****************************************************************

*****************************************************************/

namespace VisionProgram.UI.UISetting
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
                if (_instance == null)
                    _instance = new FrmGeneralSettings();
                return _instance;
            }
        }

        public void InitializeLoad()
        {
           TextBoxEXLogSaveDays.Text = Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays.ToString();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (this.QuestionInfoDialog( "确定要保存常规参数？", "提交参数") == DialogResult.Yes)
            {
                try
                {
                    List<OperationLogParamModel.OldParam> oldGeneralParamObjects = new List<OperationLogParamModel.OldParam>();

                    if (Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays != Convert.ToInt16(TextBoxEXLogSaveDays.Text))
                    {
                        oldGeneralParamObjects.Add(new OperationLogParamModel.OldParam() { Text = "日志保存天数", Field = "LogSaveDays", OldValue = Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays + "", NewValue = TextBoxEXLogSaveDays.Text });
                        Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays = Convert.ToInt16(TextBoxEXLogSaveDays.Text);
                        Project.Instance().GlobalManagerInstance.SaveOneParams("Config", "LogSaveDays", Project.Instance().GlobalManagerInstance.GlobalParamModel.logSaveDays.ToString());
                    }                

                    if (oldGeneralParamObjects.Count > 0)
                    {
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
                    LogHelper.Error("保存常规参数出现异常",ex);
                }
             
            }
        }


    }
}
