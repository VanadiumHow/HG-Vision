using System.Collections.Generic;
using System.Data.SqlClient;
using Model.DataModel;
using Obj.Obj_Sql;

/****************************************************************

*****************************************************************/
namespace HG_Vision.DAL
{
    public class BaseDal : BQuery
    {

        #region 添加
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="returnType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public int Add(string connStr, string sql, int cmdType, params SqlParameter[] paras )
        {
            if (paras == null)
                return 0;
            //执行sql命令
            return SqlHelper.ExecuteNonQuery(connStr, sql, cmdType, paras);
        }
        #endregion

        #region 修改

        /// <summary>
        /// 修改信息实体
        /// </summary>
        /// <param name="connStr"></param>
        /// <param name="sql"></param>
        /// <param name="cmdType"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public bool Update(string connStr, string sql, int cmdType, params SqlParameter[] paras)
        {
            if (paras == null)
                return false;
            //执行sql命令
            return SqlHelper.ExecuteNonQuery(connStr, sql, cmdType, paras) > 0;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 按条件删除数据
        /// </summary>
        /// <param name="strWhere">条件</param>
        /// <param name="paras">参数列表</param>
        /// <returns></returns>
        public bool Delete(string connStr, string sql, int cmdType, params SqlParameter[] paras)
        {
            List<CommandInfo> list = new List<CommandInfo>();
            list.Add(new CommandInfo()
            {
                CommandText = sql,
                IsProc = cmdType==2,
                Paras = paras
            });
            return SqlHelper.ExecuteTrans(connStr,list);
        }

        #endregion


    }
}
