namespace Model.EnumModel
{
    public class EnumModel
    {
    }

    /// <summary>
    /// 良率展示 主要是CCD
    /// All全部    CCD   还可以加其他硬件类型
    /// 例：若全部CCD分散在整个机台的各个工位，需要分开展示良率的话，则可根据具体实际需求将枚举中CCD分为xxxCCD、yyyyCCD。只是举例，具体命名自己定义，
    ///  当前程序模拟8个相机在1个工位 显示良率 1# XCCD 
    /// </summary>
    public enum DeviceStatisticsModels
    {         
        XCCD,
        All
    }

    /// <summary>
    /// 登录情况
    /// </summary>
    public enum LoginSituationModels
    {
        LoginPawErrorTag = 1,//密码错误
        LoginSuccessTag = 2,//成功
    }


    /// <summary>
    /// 日志等级
    /// </summary>
    public enum FlashLogLevel
    {
        Debug,
        Info,
        Error,
        Fatal
    }

    /// <summary>
    /// 存图模式
    /// </summary>
    public enum SAVEOPPORTUNITY
    {
        NONE = 0,
        ONLYOK = 1,
        ONLYNG = 2,
        ALL = 3
    }
    public enum eProcessMode
    {
        //test = -1,//预留测试模式
        debug = 0,//手动触发流程
        produce = 1//生产触发流程
    }
    /// <summary>
    /// 九点线性标定步骤
    /// </summary>
    public enum eLinearCalib_Step
    {
        clear = 0,//清除旧的标定数据
        FindCircle = 1,//找圆：NIndex == 0：机械手标定；NIndex == 1~9：激光标定
        insert = 2,//插入标定工具
        calculate = 3//计算校正
    }
    /// <summary>
    /// 九点线性标定对象类型
    /// </summary>
    public enum eLinearCalib_Link
    {
        useless = -1,
        Robot1 = 0,
        Robot2 = 1,
        Laser1 = 2,
        Laser2 = 3
    }
}
