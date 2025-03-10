using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************

*****************************************************************/
namespace VisionProgram.Models.VModels
{
    public class ConstantModel
    {
        #region
        /// <summary>
        /// 程序使用常量
        /// </summary>
        public const bool OK = true;

        public const bool NG = false;

        public const int ZERO = 0;

        public const int ONE = 1;

        public const int TWO = 2;

        public const int THREE = 3;

        public const int SearchDBDays = 30;//数据查询时间范围。不做界面设置，防止暴力测试。
        #endregion
    }
}
