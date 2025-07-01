using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/

namespace Model.UIModel
{
    public class OperationLogParamModel
    {
        //LogETypes  LogCTypes 中英文一一对应
        public static string[] LogETypes = new string[] { "LOGIN","EXIT" ,"MODIFY","SHIELD", "RELIEVE", "CLOSE", "ENABLE" };
        public static string[] LogCTypes = new string[] { "登录","退出系统", "修改参数","屏蔽", "解除", "关闭", "启用" };

        /// <summary>
        /// 操作日志的新旧数据
        /// </summary>
        public struct OldParam
        {
            public string Text;
            public string Field;
            public string OldValue;
            public string NewValue;
        }
    }
}
