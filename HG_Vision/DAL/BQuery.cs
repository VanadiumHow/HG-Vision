using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Obj.Obj_Sql;

/****************************************************************

*****************************************************************/
namespace HG_Vision.DAL
{
    public class BQuery
    {
        #region 查询
        /// <summary>
        /// 执行sql语句或存储过程，返回DataRow
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataRow GetModel(string connStr,string sql,int cmdType, params SqlParameter[] paras)
        {
            DataTable dt = SqlHelper.GetDataTable(connStr, sql, cmdType, paras);
            if (0 < dt.Rows.Count)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }          
        }

        /// <summary>
        /// 执行sql语句或存储过程，返回int 查询是否存在
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public int isExitst(string connStr, string sql, int cmdType, params SqlParameter[] paras)
        {
            object id = SqlHelper.ExecuteScalar(connStr, sql, cmdType, paras);
            int result = 0;
            if (id != null && id.ToString() != "")
            {
                int.TryParse(id?.ToString(), out result);
                return result;
            }
            else
                return 0;
        }

       

        /// <summary>
        /// 执行sql语句或存储过程，返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="listCols"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable GetList(string connStr,string sql, int cmdType, params SqlParameter[] paras)
        {
            DataTable dt = SqlHelper.GetDataTable(connStr,sql, cmdType, paras);
            return dt;
        }

        /// <summary>
        /// 执行sql语句或存储过程，返回DataTable
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="listCols"></param>
        /// <param name="T"></param>
        /// <returns></returns>
        public DataTable GetList<T>(string connStr, string sql, int cmdType, T t)
        {
            List<SqlParameter> listParas = SqlHelper.CreateParameters<T>(t);
            DataTable dt = GetList(connStr, sql, cmdType, listParas.ToArray());
            return dt;
        }

        /// <summary>
        /// 执行sql语句或存储过程，返回DataSet 可以是多个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataSet GetDs(string connStr, string sql, int cmdType, params SqlParameter[] paras)
        {
            DataSet ds = SqlHelper.GetDataSet(connStr,sql, cmdType, paras);
            return ds;
        }

        /// <summary>
        /// 执行分页查询 
        /// </summary>
        /// <typeparam name="T">参数对象</typeparam>
        /// <param name="typeId"></param>
        /// <param name="keywords"></param>
        /// <param name="strCols"></param>
        /// <param name="proName"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet GetPageDs<T>(string connStr, string sql, int cmdType,T t, int startIndex, int pageSize)
        {
            List<SqlParameter> listParas = SqlHelper.CreateParameters<T>(t);
            listParas.Add(new SqlParameter("@pageIndex", startIndex));
            listParas.Add(new SqlParameter("@pageSize", pageSize));
            DataSet ds = GetDs(connStr, sql, cmdType, listParas.ToArray());
            return ds;
        }

        #endregion

       
    }
}
