using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using VisionProgram.Common;
using VisionProgram.Models.VModels;

/****************************************************************

*****************************************************************/

namespace VisionProgram.Main.ProjectClass.User
{
    public class UserInfoManager
    {
        /// <summary>
        /// 用户信息配置类
        /// </summary>
        private UserConfiguration _userConfiguration = new UserConfiguration();

        /// <summary>
        /// 用户角色 按等级依次上升存储
        /// </summary>
        private SortedDictionary<string, string> _userRoleDic = new SortedDictionary<string, string>()
        {
            {"A-Operator", "操作员"},
            {"B-Admin", "管理员"},
            {"C-Technician", "工程师"}
        };

        /// <summary>
        /// 用户信息集合
        /// </summary>
        private Dictionary<string, UserInfoModel> _userInfoDic = new Dictionary<string, UserInfoModel>();

        /// <summary>
        /// 全局当前登录的用户，默认登录是程序写死的操作员
        /// </summary>
        public UserInfoModel LoginUser = null;

        /// <summary>
        /// 程序提供默认操作员对象
        /// </summary>
        private UserInfoModel _operatorUser = null;

        internal UserInfoManager() { }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            //实例化操作员对象，用于全局使用
            _operatorUser = new UserInfoModel("000000", "A-Operator", "操作员");
            //程序启动游客自动登录操作员
            Project.Instance().UserInfoManagerInstance.LoginUser = Project.Instance().UserInfoManagerInstance._operatorUser;
            _userInfoDic.Clear();
            _userConfiguration.AnalysisUserInfoConfig(_userRoleDic, ref _userInfoDic);

        }

        /// <summary>
        /// 切换到默认操作员
        /// </summary>
        public void SwitchToOperatorUser()
        {
            Project.Instance().UserInfoManagerInstance.LoginUser = Project.Instance().UserInfoManagerInstance._operatorUser;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="number"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginSituationModels UserLogin(string userRoleName, string password)
        {

            //校验
            LoginSituationModels tag = Uservalidate(userRoleName, password);
            //判断是否成功
            if (tag == LoginSituationModels.LoginSuccessTag)
            {
                LoginUser = _userInfoDic[userRoleName];
            }
            return tag;
        }

        /// <summary>
        /// 用户登录验证
        /// </summary>
        /// <param name="number"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginSituationModels Uservalidate(string userRoleName, string password)
        {
            LoginSituationModels tag = LoginSituationModels.LoginPawErrorTag;
            if (userRoleName == "工程师")
            {
                //if (password == Project.Instance().GlobalManagerInstance.GlobalParamModel.Password)
                if (password == "111")
                {

                    tag = LoginSituationModels.LoginSuccessTag;

                }
                else
                {
                    tag = LoginSituationModels.LoginPawErrorTag;
                }

            }
            else
            {
                tag = LoginSituationModels.LoginSuccessTag;

            }

            //再判断是否密码一致
            //if (!MD5Encrypt.Get32MD5One(password).Equals(_userInfoDic[userRoleName].UserPassWord))
            //{
            //    tag = LoginSituationModels.LoginPawErrorTag;
            //}
            return tag;
        }

        /// <summary>
        /// 判断角色是否已存在
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public bool IsExist(string userRoleName)
        {
            return _userInfoDic.ContainsKey(userRoleName);
        }

        /// <summary>
        /// 通过角色获取加密后的密码
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetPassWord(string userRoleName)
        {
            string password = "ERROR";
            //先判断是否存在该角色
            if (IsExist(userRoleName))
            {
                password = _userInfoDic[userRoleName].UserPassWord;
            }
            return password;
        }

        /// <summary>
        /// 修改用户密码并且持久化
        /// </summary>
        /// <returns></returns>
        public void ModifyPassWord(string userRoleName, string newPwd)
        {
            try
            {
                //先修改内存中全部用户信息中对应对象的密码
                _userInfoDic[userRoleName].UserPassWord = MD5Encrypt.Get32MD5One(newPwd);
                //若当前登录角色是修改密码的角色，则再将修改的对象重新赋值给登录对象
                if (LoginUser.UserRoleName == userRoleName)
                {
                    LoginUser = _userInfoDic[userRoleName];
                }

                //最后保存到文件中
                Dictionary<string, string> dic = new Dictionary<string, string>();
                foreach (UserInfoModel item in _userInfoDic.Values)
                {
                    dic.Add(item.UserRole, item.UserPassWord);
                }
                _userConfiguration.SaveOrUpdate(dic);
            }
            catch (Exception e)
            {
                LogHelper.Error("修改密码出现异常", e);
            }

        }

        /// <summary>
        /// 获取角色名称。非操作员
        /// </summary>
        /// <returns></returns>
        public List<string> GetRoleNames()
        {
            List<string> roles = _userRoleDic.Values.ToList<string>();
            roles.Remove("操作员");
            return roles;
        }

    }
}
