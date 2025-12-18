/****************************************************************

*****************************************************************/
using System.Xml.Serialization;

namespace Model.UserModel
{
    /// <summary>
    /// 用户信息Model
    /// </summary>
    public class UserInfoModel
    {
        //用户名
        public string UserRoleName { get; set; } = "";
        ////用户英文名？
        //public string UserRole { get; set; }
        //用户密码
        public string UserPassword { get; set; } = "";
    }
}
