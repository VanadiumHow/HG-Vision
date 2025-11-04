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
            _userPwd = Project.Instance.UserManagerInstance.userConfiguration.userHelper.GetPassWord(roleName);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            TextBoxOldPwd.Text = TextBoxOldPwd.Text.Trim();
            TextBoxNewPwd.Text = TextBoxNewPwd.Text.Trim();
            TextBoxFinalPwd.Text = TextBoxFinalPwd.Text.Trim();

            bool flag = CheckEmpty(TextBoxOldPwd, "请输入原始密码")
                       && CheckEmpty(TextBoxNewPwd, "请输入修改密码")
                       && CheckEmpty(TextBoxFinalPwd, "请输入确认密码");
            if (flag)
                return;
            if (!TextBoxNewPwd.Text.Equals(TextBoxFinalPwd.Text))
            {
                this.ConfirmErrorDialog("两次输入的新密码不一致，请重新输入！");
                return;
            }
            if (Project.Instance.UserManagerInstance.userConfiguration.AlterPassWord
                (LabelRoleName.Text, TextBoxOldPwd.Text, TextBoxNewPwd.Text))
                MessageBox.Show("密码修改成功！");
            else
                MessageBox.Show("密码修改失败，请检查原始密码是否正确！");
                
        }
        /// <summary>
        /// 检查是否为空
        /// </summary>
        /// <param name="tb">TextBox工具</param>
        /// <param name="message">为空则显示的信息</param>
        /// <returns>为空则输出true，不为空则输出false</returns>
        private bool CheckEmpty(TextBoxEX tb, string message)
        {
            if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
            {
                this.ConfirmErrorDialog(message);
                return true;
            }
            return false;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
