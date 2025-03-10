using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionProgram.Common;
using VisionProgram.Main.DAL;
using VisionProgram.Models.DModels;
using VisionProgram.Models.UIModels;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Main.BLL
{
    public class CCDDataBll
    {
        CCDDataDal ccdDataDal = new CCDDataDal();

        /// <summary>
        /// 单例
        /// </summary>
        private static readonly CCDDataBll _instance = new CCDDataBll();
        private CCDDataBll() { }
        public static CCDDataBll GetInstance()
        {
            return _instance;
        }


        /// <summary>
        /// 分页查询CCD数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataSet SelectCCDDataByPage(QueryCCDDataModel paraModel, int startIndex, int pageSize)
        {
            DataSet ds = ccdDataDal.LoadCCDDataByPage(paraModel, startIndex, pageSize);
            return ds;
        }

        /// <summary>
        /// 查询CCD数据
        /// </summary>
        /// <param name="paraModel"></param>
        /// <param name="startIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public DataTable SelectCCDData(QueryCCDDataModel paraModel)
        {
            DataTable dt = ccdDataDal.LoadCCDData(paraModel);
            return dt;
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="ccdData"></param>
        /// <returns></returns>
        public bool InsertCCDData(CCDDataModel ccdData)
        {
            try
            {
                ccdData.CreateDatetime = DateTime.Now;
                return ccdDataDal.InsertCCDData(ccdData) > 0;
            }
            catch (Exception ex)
            {
                LogHelper.Error("CCD数据插入失败", ex);
                return false;
            }
        }
    }
}
