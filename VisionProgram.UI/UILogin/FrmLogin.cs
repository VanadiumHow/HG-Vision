using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionProgram.Common;
using VisionProgram.Main.ProjectClass;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.UI.UILogin
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
                this.ComboBoxEXUser.Items.AddRange(Project.Instance().UserInfoManagerInstance.GetRoleNames().ToArray());
                this.ComboBoxEXUser.SelectedIndex = 0;
                this.ActiveControl = TextBoxEXPwd;
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

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxEXUser_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.TextBoxEXPwd.Focus();
        }

        private void ComboBoxEXUser_KeyDown(object sender, KeyEventArgs e)
        {
            this.TextBoxEXPwd.Focus();
        }

        private void timerLogin_Tick(object sender, EventArgs e)
        {
            //关闭定时器
            TimerLogin.Stop();
            string oldRoleName = Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName;
            //切换到操作员
            Project.Instance().UserInfoManagerInstance.SwitchToOperatorUser();
            //角色切换后响应事件
            OnAfterChangeUserRole?.Invoke(oldRoleName);
        }

        private void TextBoxEXPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
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
            string oldRoleName = Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName;
            LoginSituationModels tag = Project.Instance().UserInfoManagerInstance.UserLogin(roleName, loginPwd);
            switch (tag)
            {
                case LoginSituationModels.LoginPawErrorTag:
                    this.ConfirmErrorDialog("输入密码错误！");
                    break;
                case LoginSituationModels.LoginSuccessTag:
                    this.ConfirmInfoDialog($"角色【{roleName}】登录成功！");
                    this.LoginSuccess(oldRoleName);
                    break;
            }
        }

        /// <summary>
        /// 登录成功之后
        /// </summary>
        /// <param name="oldRoleName"></param>
        private void LoginSuccess(string oldRoleName)
        {
            //角色切换后响应事件
            if (TimerLogin.Enabled)
            {
                NoticeHelper.OutputMessageSend($"停止登录旧计时，开启当前角色【{Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName}】登录新计时", OutputLevelModel.INFO);
                TimerLogin.Stop();
            }
            else
                NoticeHelper.OutputMessageSend($"开启当前角色【{Project.Instance().UserInfoManagerInstance.LoginUser.UserRoleName}】登录计时", OutputLevelModel.INFO);

            TimerLogin.Start();
            OnAfterChangeUserRole?.Invoke(oldRoleName);
            this.Close();
            this.Dispose();
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
