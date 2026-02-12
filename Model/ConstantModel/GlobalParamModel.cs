using System.Xml.Serialization;
using Model.EnumModel;
namespace Model.ConstantModel
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    [XmlRoot("系统全局参数")]
    public class GlobalParamsModel
    {
        #region 视觉参数
        /// <summary>
        /// 最多支持8个相机
        /// </summary>
        public int MaxWorkNum = 8;

        /// <summary>
        /// 相机数目
        /// </summary>
        public int WorkFlowNum = 1;

        /// <summary>
        /// 吸嘴数量（U轴数量，对应几个旋转中心）（暂未使用）
        /// </summary>
        public int NozzleNum = 1;
        #endregion
        #region 通讯参数
        /// <summary>
        /// 机器人通讯协议类型
        /// </summary>
        public string RobotProtocolType = eProtocol.LYH.ToString();

        /// <summary>
        /// PLC通讯协议类型
        /// </summary>
        public string PLCAgreement = ePLCAgreement.Fins_TCP.ToString();

        /// <summary>
        /// 机器人数量
        /// </summary>
        public int RobotNum = 0;
        /// <summary>
        /// 激光数量
        /// </summary>
        public int LaserNum = 0;

        /// <summary>
        /// plc Tcp服务器数量
        /// </summary>
        public int PLC_TCP_Num = 0;

        #endregion


        /// <summary>
        /// 日志存储天数
        /// </summary>
        public int LogSaveDays = 7;

        /// <summary>
        /// 右侧面板展开宽度
        /// </summary>
        public int PanelRightWidth = 350;

        /// <summary>
        /// 交互记录可显示最大行数
        /// </summary>
        public int InteractionInfoMaxLines = 100;

        /// <summary>
        /// 软件主界面左上角标题名称
        /// </summary>
        public string ProgramTitle = "焊接引导程序";

        /// <summary>
        /// 当前产品名称
        /// </summary>
        public string CurProductName = "默认";

        /// <summary>
        /// 是否使用产品（1使用当前，0使用默认）
        /// </summary>
        public bool UseProductName = false;
    }
}
