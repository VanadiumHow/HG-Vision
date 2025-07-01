using System;
using System.Windows.Forms;
using Obj.Obj_Message;
using HG_Vision.Manager.Manager_System;
using VisionProgram.UserControls.UITextBox;

/****************************************************************

*****************************************************************/

namespace HG_Vision.UILogin
{
    public partial class FrmEdit : Form
    {
        private FrmLogin _pParentWin = null;
        private string _userPwd = null;

        public FrmEdit(FrmLogin parent, string roleName)
        {
            _pParentWin = parent;
            InitializeComponent();
            LabelRoleName.Text = roleName;
            _userPwd = Project.Instance.UserInfoManagerInstance.GetPassWord(roleName);
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            TextBoxOldPwd.Text = TextBoxOldPwd.Text.Trim();
            TextBoxNewPwd.Text = TextBoxNewPwd.Text.Trim();
            TextBoxFinalPwd.Text = TextBoxFinalPwd.Text.Trim();

            bool flag = CheckEmpty(TextBoxOldPwd, "请输入原始密码")
                       && CheckEmpty(TextBoxNewPwd, "请输入修改密码")
                       && CheckEmpty(TextBoxFinalPwd, "请输入确认密码");
            if (!flag)
                return;

            //先判断输入的原始密码是否正确
            if (TextBoxOldPwd.Text == _userPwd)
            {
                //再判断修改密码与确认密码是否相等以及长度是否大于6位
                if (TextBoxNewPwd.Text == TextBoxFinalPwd.Text)
                {
                    if (TextBoxNewPwd.Text.Length < 6)
                    {
                        this.ConfirmErrorDialog("密码长度不得小于6位，请重新输入！");
                        flag = false;
                    }
                    else
                    {
                        Project.Instance.UserInfoManagerInstance.ModifyPassWord(LabelRoleName.Text, TextBoxFinalPwd.Text);
                        flag &= true;
                    }
                }
                else
                {
                    this.ConfirmErrorDialog("确认密码和新密码不一致！");
                    flag = false;
                }
            }
            else
            {
                this.ConfirmErrorDialog($"原始密码输入不正确！");
                flag = false;
            }

            if (!flag)
                return;
            this.DialogResult = DialogResult.OK;
        }

        private bool CheckEmpty(TextBoxEX tb, string message)
        {
            if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
            {
                this.ConfirmErrorDialog(message);
                return false;
            }
            return true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
