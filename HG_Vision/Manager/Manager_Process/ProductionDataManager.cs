using System.Collections.Generic;
using Model.EnumModel;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/
namespace HG_Vision.Manager.Manager_Process
{
    public class ProductionDataManager
    {

        #region 机台产能统计数据
        //产能统计界面建议为了界面美观最多放置两个饼状图，因此框架中提供的下面两个默认变量的集合长度为2
        //如果自己的产能统计需求跟框架默认提供的不太一致，比如在饼状图中显示的OK数是多个OK数的总和等等，那请大家自定义自己需要的产能变量，来适配框架提供的产能界面饼状图显示

        /// <summary>
        /// 相机OK数量
        /// </summary>
        public List<double> L_ProduceStationOKCount = new List<double>();

        /// <summary>
        /// 相机NG数量
        /// </summary>
        public List<double> L_ProduceStationNGCount = new List<double>();

        #endregion


        internal ProductionDataManager() { }

        /// <summary>
        /// 初始化所有数据
        /// </summary>
        public void Initial()
        {
            InitialProductionData();
        }

        /// <summary>
        /// 初始化生产数据   
        /// </summary>
        public void InitialProductionData()
        {
            L_ProduceStationOKCount.Clear();
            L_ProduceStationNGCount.Clear();
            for (int i = 0; i < 2; i++)
            {
                L_ProduceStationOKCount.Add(0);
                L_ProduceStationNGCount.Add(0);
            }
        }

        #region 数据清0

        /// <summary>
        /// 定时器调用
        /// </summary>
        public void ClearProductionData()
        {
            ClearCapaticyData();
        }

        /// <summary>
        /// 清产能
        /// </summary>
        public void ClearCapaticyData()
        {
            for (int i = 0; i < 2; i++)
            {
                L_ProduceStationOKCount[i] = 0;
                L_ProduceStationNGCount[i] = 0;
            }
        }

        #endregion
    }
}
