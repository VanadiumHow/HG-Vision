using System;
using System.Collections.Generic;
using System.Linq;
using Obj.Obj_File;
using Model.UserModel;
using Model.EnumModel;
using HG_Vision.Contol.Control_System;
using HG_Vision.Manager.Manager_System;
/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_User
{
    public class UserManager
    {
        private UserInfoModel currentUser = null;
        /// <summary>
        /// 全局可获取的当前登录的用户
        /// </summary>
        public UserInfoModel CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
        /// <summary>
        /// 程序默认对象为数组第一个对象
        /// </summary>
        private UserInfoModel defultUser = null;
        public UserInfoModel DefultUser
        {
            get { return defultUser; }
        }
        /// <summary>
        /// 加实例化控制类
        /// </summary>
        public UserConfiguration userConfiguration;
        /// <summary>
        /// 实例化所有用户Model
        /// </summary>
        private UsersModel usersModel = new UsersModel();
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initial()
        {
            userConfiguration = new UserConfiguration();
            //调用操作类，解析用户信息配置文件
            userConfiguration.AnalysisUserInfoConfig(ref usersModel);
            //实例化默认对象
            defultUser = usersModel.ArrUser[0];
            //程序启动自动登录默认对象
            currentUser = defultUser;
        }
    }
}
