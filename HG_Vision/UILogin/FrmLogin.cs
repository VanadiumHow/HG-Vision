using System;
using System.Windows.Forms;
using Obj.Obj_Message;
using Model.EnumModel;
using Model.UIModel;
using HG_Vision.Manager.Manager_System;
using System.Windows.Controls;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UILogin
{
    public partial class FrmLogin : Form
    {
        //角色切换后的响应事件
        public event Action<string> OnAfterChangeUserRole;


        private FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmLogin _instance;
        public static FrmLogin Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmLogin();
                return _instance;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.TextBoxEXPwd.Clear();
            this.ComboBoxEXUser.Items.Clear();
            this.ComboBoxEXUser.Items.AddRange(Project.Instance.UserManagerInstance.userConfiguration.userHelper.GetAllRoleNames().ToArray());
            this.ComboBoxEXUser.SelectedIndex = 0;
            this.ActiveControl = TextBoxEXPwd;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBoxEXPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLogin.PerformClick();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string roleName = ComboBoxEXUser.SelectedItem.ToString().Trim();
            string loginPwd = TextBoxEXPwd.Text.Trim();

            if (string.IsNullOrEmpty(loginPwd))
            {
                this.ConfirmErrorDialog("请输入登录的密码！");
                return;
            }
            string oldRoleName = Project.Instance.UserManagerInstance.CurrentUser.UserRoleName;
            eLoginStatus tag = Project.Instance.UserManagerInstance.userConfiguration.UserLogin(new Model.UserModel.UserInfoModel { UserRoleName = roleName, UserPassword = loginPwd });
            switch (tag)
            {
                case eLoginStatus.LoginPswErrorTag:
                    this.ConfirmErrorDialog("输入密码错误！");
                    break;
                case eLoginStatus.LoginSuccessTag:
                    this.ConfirmInfoDialog($"角色【{roleName}】登录成功！");
                    //登录成功之后触发FrmHome中定义的事件，并退出关闭当前窗体
                    OnAfterChangeUserRole?.Invoke(oldRoleName);
                    this.Close();
                    this.Dispose();
                    break;
                case eLoginStatus.LoginUserNotExistTag:
                    this.ConfirmErrorDialog("选择的角色不存在！");
                    break;
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            if (ComboBoxEXUser.SelectedIndex < 0)
            {
                this.ConfirmErrorDialog("请先选择需要修改密码的角色！");
                return;
            }

            FrmEdit ue = new FrmEdit(this, ComboBoxEXUser.SelectedItem.ToString());

            if (ue.ShowDialog() == DialogResult.OK)
            {
                this.ConfirmInfoDialog($"角色{ComboBoxEXUser.SelectedItem.ToString()} 密码修改成功！");
                ue.Close();
                ue.Dispose();
            }
        }

    }
}
