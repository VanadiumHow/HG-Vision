using Model.EnumModel;
using Model.UserModel;
using Obj.Obj_File;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Obj.Obj_User
{
    public class UserHelper
    {
        private readonly UsersModel usersModel;
        public UserHelper(ref UsersModel usersModel)
        {
            this.usersModel = usersModel;
        }
        /// <summary>
        /// 新增用户(用户最多只开放5个)
        /// </summary>
        /// <param name="user"></param>
        public void Add(UserInfoModel user)
        {
            if (usersModel.UsersList.Count >= 5)
            {
                LogHelper.Error("已达到程序可设最大用户数5个，无法添加用户！");
                return;
            }

            if (usersModel.UsersList.Any(u => u.UserRoleName == user.UserRoleName))
            {
                LogHelper.Error("此用户名已存在，无法添加此用户！");
                return;
            }
            usersModel.UsersList.Add(user);
        }
        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="userRoleName">用户名</param>
        /// <param name="newPwd">新密码</param>
        /// <param name="oldPwd">旧密码</param>
        public bool AlterPassWord(string userRoleName, string oldPwd, string newPwd)
        {
            try
            {
                // Corrected the instantiation of UserInfoModel and property assignments
                eLoginStatus outputResult = CheckPassword(new UserInfoModel
                {
                    UserRoleName = userRoleName,
                    UserPassword = oldPwd
                });

                if (outputResult == eLoginStatus.LoginSuccessTag)
                {
                    foreach (UserInfoModel user in usersModel.ArrUser)
                    {
                        if (userRoleName == user.UserRoleName)
                        {
                            user.UserPassword = newPwd;
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                LogHelper.Error("修改用户密码失败！", e);
                return false;
            }
        }
        public eLoginStatus CheckPassword(UserInfoModel userInfo)
        {
            foreach (UserInfoModel user in usersModel.ArrUser)
            {
                if (userInfo.UserRoleName == user.UserRoleName)
                {
                    //校验密码是否正确
                    if (userInfo.UserPassword == user.UserPassword)
                    {
                        return eLoginStatus.LoginSuccessTag;
                    }
                    else
                    {
                        return eLoginStatus.LoginPswErrorTag;
                    }
                }
            }
            return eLoginStatus.LoginUserNotExistTag;
        }
        /// <summary>
        /// 判断角色是否已存在
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public bool IsExist(string userRoleName)
        {
            foreach (UserInfoModel user in usersModel.ArrUser)
            {
                if (userRoleName == user.UserRoleName)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 获取输入角色的密码
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string GetPassWord(string userRoleName)
        {
            foreach (UserInfoModel user in usersModel.ArrUser)
            {
                if (userRoleName == user.UserRoleName)
                    return user.UserPassword;
            }
            return string.Empty;
        }
        /// <summary>
        /// 获取所有角色名称
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllRoleNames()
        {
            List<string> roles = new List<string>();
            foreach (UserInfoModel user in usersModel.ArrUser)
            {
                roles.Add(user.UserRoleName);
            }
            return roles;
        }
    }
}
