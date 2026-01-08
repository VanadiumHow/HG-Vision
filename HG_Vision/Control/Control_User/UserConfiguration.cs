using Model.ConstantModel;
using Model.EnumModel;
using Model.UserModel;
using Obj.Obj_File;
using System;
using Obj.Obj_User;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Contol.Control_User
{
    public class UserConfiguration
    {
        private UsersModel usersModel;
        public UserHelper userHelper;
        /// <summary>
        /// 解析.xml文件反序列化成用户类
        /// </summary>
        public void AnalysisUserInfoConfig(ref UsersModel usersModel)
        {
            try
            {
                var deserializedModel = XmlHelper.Deserialize<UsersModel>(FilePathModel.UsersFilePath);
                userHelper = new UserHelper(ref deserializedModel);
                usersModel = deserializedModel;
                this.usersModel = deserializedModel; // 同时更新两个引用
            }
            catch (Exception ex)
            {
                LogHelper.Error("AnalysisUserInfoConfig方法调用Deserialize方法失败", ex);
            }
        }
        /// <summary>
        /// 序列化成.xml文件保存用户类
        /// </summary>
        /// <param name="section"></param>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public void SaveUserInfoConfig(UsersModel usersModel)
        {
            try
            {
                //序列化保存.xml文件
                XmlHelper.Serialize(FilePathModel.UsersFilePath, usersModel);
            }
            catch (Exception ex)
            {
                LogHelper.Error("SaveUserInfoConfig方法调用Serialize方法失败", ex);
            }
        }
        public eLoginStatus UserLogin(UserInfoModel user)
        {
            eLoginStatus eLoginStatus = userHelper.CheckPassword(user);
            if (eLoginStatus == eLoginStatus.LoginSuccessTag)
                Project.Instance.UserManagerInstance.CurrentUser = user;
            return eLoginStatus;
        }
        public bool AlterPassWord(string UserRoleName, string oldpwd, string newpwd)
        {
            if (userHelper.AlterPassWord(UserRoleName, oldpwd, newpwd))
            {
                SaveUserInfoConfig(usersModel);
                return true;
            }
            return false;
        }
    }
}