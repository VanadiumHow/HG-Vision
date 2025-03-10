using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VisionProgram.Main.ProjectClass.SqlDB;
using VisionProgram.Models.UIModels;
using VisionProgram.Models.DModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.DAL
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
