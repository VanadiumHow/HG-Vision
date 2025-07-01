using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Model.DataModel;
using Model.UIModel;
using Obj.Obj_Sql;
using HG_Vision.Manager.Manager_Sql;
/****************************************************************

*****************************************************************/
namespace HG_Vision.DAL
{
    /// <summary>
    /// 数据查询 数据层
    /// </summary>
    public class OperationLogDataDal : BaseDal
    {
        private const string InsertProcName = "PROC_InsertOperationLogData";
        private const string SelectProcNameByPage = "PROC_GetOperationLogDataByPage";

        public DataSet LoadOperationLogDataByPage(QueryLogDataModel logDataQuery, int startIndex, int pageSize)
        {
            return GetPageDs<QueryLogDataModel>(SqlInfoManager.L_sqlConnection[0], SelectProcNameByPage, 2, logDataQuery, startIndex, pageSize);

        }

        /// <summary>
        /// 插入操作日志
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int InsertOperationLogData(OperationLogDataModel logData)
        {         
            List<SqlParameter> listParas = SqlHelper.CreateParameters<OperationLogDataModel>(logData);
            return Add(SqlInfoManager.L_sqlConnection[0], InsertProcName, 2, listParas.ToArray());
        }
    }
}
