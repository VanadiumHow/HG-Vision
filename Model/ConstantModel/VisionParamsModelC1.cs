using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
/****************************************************************

*****************************************************************/
namespace Model.ConstantModel
{
    /// <summary>
    /// 映射配置文件结构体
    /// </summary>
    [XmlRoot("ParamsModelC1")]
    public class ParamsModelC1
    {
        // 基准位置/补偿位置/旋转中心
        public BasePose StdPose = new BasePose();
        public BasePose AddPose = new BasePose();

        public double AngleMax = 0;
        public double AngleMin = 0;
        public double LimitMax = 0;
        public double LimitMin = 0;
        public double Exprosure = 1; //曝光时间单位ms

        public RobotPose RotationCenter = new RobotPose();
        public LaserPose LocationCenter = new LaserPose();

        public PointAxis P2byP1 = new PointAxis();
        public PointAxis P4byP3 = new PointAxis();
        public double RobotStep = 0;
        public double LaserStep = 0;

        public double Spacing = 0;
        public int SpacingUse = 0;
        public int BoUse = 0;
        public int LaUse = 0;

        public int NozzleNum = 0;
        // 夹具补偿
        public JigAdd[] JigCompensations = Enumerable.Range(0, 9)
            .Select(i => new JigAdd()).ToArray();
    }
    /// <summary>
    /// 补偿项类
    /// </summary>
    public class PointAxis
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        public double R { get; set; } = 0;
    }
    public class RobotPose
    {
        public PointAxis Bo1Axis { get; set; } = new PointAxis();
        public PointAxis Bo2Axis { get; set; } = new PointAxis();
    }
    public class LaserPose
    {
        public PointAxis La1Axis { get; set; } = new PointAxis();
        public PointAxis La2Axis { get; set; } = new PointAxis();
    }
    public class BasePose
    {
        private RobotPose Robot { get; set; } = new RobotPose();
        private LaserPose Laser { get; set; } = new LaserPose();
        // 代理属性
        public PointAxis Bo1Axis
        {
            get => Robot.Bo1Axis;
            set => Robot.Bo1Axis = value;
        }
        public PointAxis Bo2Axis
        {
            get => Robot.Bo2Axis;
            set => Robot.Bo2Axis = value;
        }
        public PointAxis La1Axis
        {
            get => Laser.La1Axis;
            set => Laser.La1Axis = value;
        }
        public PointAxis La2Axis
        {
            get => Laser.La2Axis;
            set => Laser.La2Axis = value;
        }
    }
    public class JigAdd
    {
        public int LaserPointNum = 4;
        public PointAxis Bo1Axis { get; set; } = new PointAxis();
        public PointAxis Bo2Axis { get; set; } = new PointAxis();

        // 将List改为数组，并预填充4个元素
        public PointAxis[] L_La1Axis { get; set; } = new PointAxis[4];
        public PointAxis[] L_La2Axis { get; set; } = new PointAxis[4];

        // 构造函数，确保数组中的每个元素都被初始化
        public JigAdd()
        {
            // 初始化数组中的每个元素
            for (int i = 0; i < 4; i++)
            {
                L_La1Axis[i] = new PointAxis();
                L_La2Axis[i] = new PointAxis();
            }
        }
    }
}
