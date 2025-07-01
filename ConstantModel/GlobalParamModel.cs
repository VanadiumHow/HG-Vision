
/****************************************************************

*****************************************************************/

namespace Model.ConstantModel
{
    public class GlobalParamModel
    {
        /// <summary>
        /// 最多支持8个相机
        /// </summary>
        public int MaxWorkNum = 8;
        

        /// <summary>
        /// 相机数目
        /// </summary>
        private int workFlowNum = 0;
        public int WorkFlowNum
        {
            get
            {
                if (workFlowNum < MaxWorkNum)
                {
                    return workFlowNum;
                }
                else
                {
                    return MaxWorkNum;
                }
            }
            set { workFlowNum = value; }
        }
        /// <summary>
        /// 吸嘴数量（U轴数量，对应几个旋转中心）
        /// </summary>
        private int nozzleNum;
        public int NozzleNum
        {
            get
            {
                return nozzleNum;
            }
            set
            {
                nozzleNum = value;
            }
        }

        /// <summary>
        /// 机器人数量
        /// </summary>
        private int robotNum;
        public int RobotNum
        {
            get
            {
                return robotNum;
            }
            set
            {
                robotNum = value;
            }
        }

        /// <summary>
        /// mima
        /// </summary>
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string programTitle = "焊接程序";

        #region 常规设置
        /// <summary>
        /// 日志存储天数
        /// </summary>
        public int logSaveDays = 7;

        #endregion

        #region 数据库
        /// <summary>
        /// 是否按数据库的方式保存操作日志
        /// </summary>
        public bool saveOperationLogsByDB = false;
        #endregion

        #region 产品选择参数
        /// <summary>
        /// 产品名称
        /// </summary>
        public string curProductModel;
        /// <summary>
        /// 是否使用具体产品
        /// </summary>
        public bool useProductModel;

        #endregion


        #region 界面参数
        /// <summary>
        /// 右侧面板展开宽度
        /// </summary>
        public int PanelRightWidth { get; set; }

        /// <summary>
        /// 交互记录可显示最大行数
        /// </summary>
        public int InteractionInfoMaxLines { get; set; }
        #endregion

    }
}
