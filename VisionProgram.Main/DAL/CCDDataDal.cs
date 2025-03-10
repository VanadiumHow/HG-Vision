using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionProgram.Main.ProjectClass.SqlDB;
using VisionProgram.Models.DModels;
using VisionProgram.Models.UIModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.DAL
{
    public class CCDDataDal : BaseDal
    {
        private const string SelectByPageProcName = "PROC_GetCCDDataByPage";
        private const string SelectProcName = "PROC_GetCCDData";
        private const string InsertProcName = "PROC_InsertCCDData";


        /// <summary>
        /// 分页查询单据列表
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet LoadCCDDataByPage(QueryCCDDataModel paraModel, int startIndex, int pageSize)
        {
            DataSet ds = GetPageDs<QueryCCDDataModel>(SqlInfoManager.L_sqlConnection[0], SelectByPageProcName, 2, paraModel, startIndex, pageSize);
            return ds;
        }


        /// <summary>
        /// 查询单据列表
        /// </summary>
        /// <param name="paraModel"></param>
        /// <returns></returns>
        public DataTable LoadCCDData(QueryCCDDataModel paraModel)
        {
            DataTable dt = GetList<QueryCCDDataModel>(SqlInfoManager.L_sqlConnection[0], SelectProcName, 2, paraModel);
            return dt;
        }


        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int InsertCCDData(CCDDataModel ccdData)
        {
            List<SqlParameter> listParas = SqlHelper.CreateParameters<CCDDataModel>(ccdData);
            return Add(SqlInfoManager.L_sqlConnection[0], InsertProcName, 2, listParas.ToArray());
        }

    }
}
