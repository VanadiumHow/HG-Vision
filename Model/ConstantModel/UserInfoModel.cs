using System;

/****************************************************************

*****************************************************************/
namespace Model.ConstantModel
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    [Serializable]  //必须添加序列化特性
    public class UserInfoModel
    {     
        public string UserPassWord { get; set; }

        public string UserRoleName { get; set; } = "DEFAULT";

        public string UserRole { get; set; }


        public UserInfoModel()
        {

        }

        public UserInfoModel(string userPassWord,string userRole, string userRoleName)
        {
            this.UserPassWord = userPassWord;
            this.UserRole = userRole;
            this.UserRoleName = userRoleName;
        }
    }
}
