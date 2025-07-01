using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/

namespace Model.UIModel
{
    /// <summary>
    /// 数据库 连接信息
    /// </summary>
    public class SqlInfoModel
    {
        public SqlInfoModel() { }
        /// <summary>
        /// 数据库服务器地址
        /// </summary>
        private static string Server { get; set; }
        /// <summary>
        /// 数据库名
        /// </summary>
        private static string DBName { get; set; }
        /// <summary>
        /// 数据库用户名
        /// </summary>
        private static string UserId { get; set; }
        /// <summary>
        /// 数据库密码
        /// </summary>
        private static string Password { get; set; }


    }
}
