using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Model.UserModel
{
    [XmlRoot("用户参数")]
    public class UsersModel
    {
        [XmlIgnore]
        public List<UserInfoModel> UsersList = new List<UserInfoModel>();

        [XmlArray("Users")]
        [XmlArrayItem("User")]
        public UserInfoModel[] ArrUser
        {
            get => UsersList.ToArray();
            set => UsersList = value != null ? new List<UserInfoModel>(value) : new List<UserInfoModel>();
        }
        public UsersModel()
        {
            UsersList.Add(new UserInfoModel() { UserRoleName = "操作者", UserPassword = "1" });
            UsersList.Add(new UserInfoModel() { UserRoleName = "管理员", UserPassword = "2" });
            UsersList.Add(new UserInfoModel() { UserRoleName = "工程师", UserPassword = "3" });
        }
    }
}