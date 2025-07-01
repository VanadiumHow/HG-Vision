using System.Collections.Generic;
using System.Linq;
using Model.EnumModel;
using HG_Vision.Manager.Manager_System;

/****************************************************************

*****************************************************************/

namespace HG_Vision.Manager.Manager_Process
{
    /// <summary>
    /// 程序模拟8个相机在1个工位
    /// 若多工位下，并在展示列一致的情况下（如OK、NG、SUM、YIELD）,下面的List<List<double>>即可兼容多工位
    /// 若展示列不一样，需按工位去定义
    /// </summary>
    public class ProductionDataManager
    {
        #region 工位CCD统计数据  

        /// <summary>
        /// CCD拍照总数量
        /// </summary>
        public List<List<int>> L_productionCCDSumCountList = new List<List<int>>();

        /// <summary>
        /// CCD检测OK数量
        /// </summary>
        public List<List<int>> L_productionCCDOKCountList = new List<List<int>>();

        /// <summary>
        /// CCD检测NG数量
        /// </summary>
        public List<List<int>> L_productionCCDNGCountList = new List<List<int>>();

        #endregion


        #region 机台产能统计数据
        //产能统计界面建议为了界面美观最多放置两个饼状图，因此框架中提供的下面两个默认变量的集合长度为2
        //如果自己的产能统计需求跟框架默认提供的不太一致，比如在饼状图中显示的OK数是多个OK数的总和等等，那请大家自定义自己需要的产能变量，来适配框架提供的产能界面饼状图显示

        /// <summary>
        /// 机台OK数量
        /// </summary>
        public List<double> L_ProductionStationOKCount = new List<double>();

        /// <summary>
        /// 机台NG数量
        /// </summary>
        public List<double> L_ProductionStationNGCount = new List<double>();

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
            L_productionCCDSumCountList.Clear();
            L_productionCCDOKCountList.Clear();
            L_productionCCDNGCountList.Clear();
            L_productionCCDSumCountList.AddRange(new List<int>[] { new List<int>() });
            L_productionCCDOKCountList.AddRange(new List<int>[] { new List<int>() });
            L_productionCCDNGCountList.AddRange(new List<int>[] { new List<int>() });

            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
            {
                L_productionCCDSumCountList[0].Add(0);
                L_productionCCDOKCountList[0].Add(0);
                L_productionCCDNGCountList[0].Add(0);
            }


            L_ProductionStationOKCount.Clear();
            L_ProductionStationNGCount.Clear();
            for (int i = 0; i < 2; i++)
            {
                L_ProductionStationOKCount.Add(0);
                L_ProductionStationNGCount.Add(0);
            }
        }

        #region 数据清0

        /// <summary>
        /// 定时器调用
        /// </summary>
        public void ClearProductionData()
        {
            ClearYieldData(DeviceStatisticsModels.All);
            ClearCapaticyData();
        }

        /// <summary>
        /// 清良率
        /// </summary>
        /// <param name="model"></param>
        public void ClearYieldData(DeviceStatisticsModels model)
        {
            switch (model)
            {
                case DeviceStatisticsModels.XCCD:
                    for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraNum; i++)
                    {
                        L_productionCCDSumCountList[0][i] = 0;
                        L_productionCCDOKCountList[0][i] = 0;
                        L_productionCCDNGCountList[0][i] = 0;
                    }
                    break;
                case DeviceStatisticsModels.All:
                    ClearYieldData(DeviceStatisticsModels.XCCD);
                    break;
            }
        }

        /// <summary>
        /// 清产能
        /// </summary>
        public void ClearCapaticyData()
        {
            for (int i = 0; i < 2; i++)
            {
                L_ProductionStationOKCount[i] = 0;
                L_ProductionStationNGCount[i] = 0;
            }
        }

        #endregion
    }
}
