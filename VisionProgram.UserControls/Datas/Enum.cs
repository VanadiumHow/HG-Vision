using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/****************************************************************
*  
*****************************************************************/
namespace VisionProgram.UserControls.Datas
{
    class Enum
    {
    }

    #region Status 状态
    public enum Status
    {
        #region None 无
        /// <summary>
        /// 无
        /// </summary>
        None,
        #endregion

        #region OK 正常
        /// <summary>
        /// 正常
        /// </summary>
        OK,
        #endregion

        #region EX 异常
        /// <summary>
        /// 异常
        /// </summary>
        EX,
        #endregion

        #region ERR 错误
        /// <summary>
        /// 错误
        /// </summary>
        ERR,
        #endregion

        #region Open 开启
        /// <summary>
        /// 开启
        /// </summary>
        Open,
        #endregion

        #region Close 关闭
        /// <summary>
        /// 关闭
        /// </summary>
        Close,
        #endregion

        #region Stop 暂停
        /// <summary>
        /// 暂停
        /// </summary>
        Stop,
        #endregion
    }
    #endregion
}
