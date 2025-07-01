using System.Data.SqlClient;

namespace Model.DataModel
{
    public class CommandInfo
    {
        public string CommandText;//sql或存储过程名
        public SqlParameter[] Paras; //参数列表
        public bool IsProc; //是否是存储过程
        public CommandInfo()
        {

        }

        public CommandInfo(string comText, bool isProc)
        {
            this.CommandText = comText;
            this.IsProc = isProc;
        }

        public CommandInfo(string sqlText, bool isProc, SqlParameter[] para)
        {
            this.CommandText = sqlText;
            this.Paras = para;
            this.IsProc = isProc;
        }
    }
}
