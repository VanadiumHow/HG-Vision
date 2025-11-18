using Cognex.VisionPro;
using HG_Vision.Contol.Control_Sql;
using HG_Vision.Contol.Control_Vision;
using HG_Vision.Manager.Manager_System;
using HG_Vision.Manager.Manager_Thread;
using Model.ConstantModel;
using Model.EnumModel;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Utility;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

/****************************************************************

*****************************************************************/
namespace HG_Vision.UIVision
{
    public partial class FrmCameraParamsSettings : Form
    {
        private DateTime buttonPressTime;//点击时间点
        private Button currentButton; // 记录当前按下的按钮
        private readonly Timer holdTimer = new Timer();
        // 创建按钮与处理逻辑的映射字典
        private readonly Dictionary<Button, Action> buttonActions = new Dictionary<Button, Action>();
        // 创建控件映射集合
        private readonly List<(CheckBox checkbox, Button button)> Pairscb_btn = new List<(CheckBox checkbox, Button button)>();
        private readonly List<(Button button, TabPage tabpage)> Pairsbtn_tp = new List<(Button button, TabPage TabPage)>();

        /// <summary>
        /// 存储控件验证时发生的值
        /// </summary>
        //private Dictionary<string, string> _validatingDic = new Dictionary<string, string>();
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
        public FrmCameraParamsSettings()
        {
            InitializeComponent();
            // 初始化按钮按钮逻辑
            InitializaButtonActions();
            // 初始化关联关系
            InitializeControlPairs();
        }
        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FrmCameraParamsSettings _instance;
        public static FrmCameraParamsSettings Instance
        {

            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmCameraParamsSettings();
                return _instance;
            }
        }


        private Dictionary<TextBox, (TextBox outputTextBox, TextBox addendTextBox)> textBoxMappings;

        private void FrmCCDParamSettings_Load(object sender, EventArgs e)
        {
            textBoxMappings = new Dictionary<TextBox, (TextBox, TextBox)>
            {
                // J1
                { tb_Cam1Jig1La11X, (tb_Cam1Jig1La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig1La11Y, (tb_Cam1Jig1La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig1La21X, (tb_Cam1Jig1La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig1La21Y, (tb_Cam1Jig1La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig1La13X, (tb_Cam1Jig1La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig1La13Y, (tb_Cam1Jig1La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig1La23X, (tb_Cam1Jig1La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig1La23Y, (tb_Cam1Jig1La24Y, tb_Cam1P4byP3Y) },
                // J2
                { tb_Cam1Jig2La11X, (tb_Cam1Jig2La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig2La11Y, (tb_Cam1Jig2La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig2La21X, (tb_Cam1Jig2La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig2La21Y, (tb_Cam1Jig2La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig2La13X, (tb_Cam1Jig2La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig2La13Y, (tb_Cam1Jig2La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig2La23X, (tb_Cam1Jig2La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig2La23Y, (tb_Cam1Jig2La24Y, tb_Cam1P4byP3Y) },
                // J3
                { tb_Cam1Jig3La11X, (tb_Cam1Jig3La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig3La11Y, (tb_Cam1Jig3La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig3La21X, (tb_Cam1Jig3La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig3La21Y, (tb_Cam1Jig3La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig3La13X, (tb_Cam1Jig3La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig3La13Y, (tb_Cam1Jig3La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig3La23X, (tb_Cam1Jig3La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig3La23Y, (tb_Cam1Jig3La24Y, tb_Cam1P4byP3Y) },
                // J4
                { tb_Cam1Jig4La11X, (tb_Cam1Jig4La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig4La11Y, (tb_Cam1Jig4La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig4La21X, (tb_Cam1Jig4La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig4La21Y, (tb_Cam1Jig4La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig4La13X, (tb_Cam1Jig4La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig4La13Y, (tb_Cam1Jig4La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig4La23X, (tb_Cam1Jig4La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig4La23Y, (tb_Cam1Jig4La24Y, tb_Cam1P4byP3Y) },
                // J5
                { tb_Cam1Jig5La11X, (tb_Cam1Jig5La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig5La11Y, (tb_Cam1Jig5La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig5La21X, (tb_Cam1Jig5La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig5La21Y, (tb_Cam1Jig5La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig5La13X, (tb_Cam1Jig5La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig5La13Y, (tb_Cam1Jig5La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig5La23X, (tb_Cam1Jig5La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig5La23Y, (tb_Cam1Jig5La24Y, tb_Cam1P4byP3Y) },
                // J6
                { tb_Cam1Jig6La11X, (tb_Cam1Jig6La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig6La11Y, (tb_Cam1Jig6La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig6La21X, (tb_Cam1Jig6La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig6La21Y, (tb_Cam1Jig6La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig6La13X, (tb_Cam1Jig6La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig6La13Y, (tb_Cam1Jig6La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig6La23X, (tb_Cam1Jig6La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig6La23Y, (tb_Cam1Jig6La24Y, tb_Cam1P4byP3Y) },
                // J7
                { tb_Cam1Jig7La11X, (tb_Cam1Jig7La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig7La11Y, (tb_Cam1Jig7La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig7La21X, (tb_Cam1Jig7La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig7La21Y, (tb_Cam1Jig7La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig7La13X, (tb_Cam1Jig7La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig7La13Y, (tb_Cam1Jig7La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig7La23X, (tb_Cam1Jig7La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig7La23Y, (tb_Cam1Jig7La24Y, tb_Cam1P4byP3Y) },
                // J8
                { tb_Cam1Jig8La11X, (tb_Cam1Jig8La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig8La11Y, (tb_Cam1Jig8La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig8La21X, (tb_Cam1Jig8La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig8La21Y, (tb_Cam1Jig8La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig8La13X, (tb_Cam1Jig8La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig8La13Y, (tb_Cam1Jig8La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig8La23X, (tb_Cam1Jig8La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig8La23Y, (tb_Cam1Jig8La24Y, tb_Cam1P4byP3Y) },
                // J9
                { tb_Cam1Jig9La11X, (tb_Cam1Jig9La12X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig9La11Y, (tb_Cam1Jig9La12Y, tb_Cam1P2byP1Y) },
                { tb_Cam1Jig9La21X, (tb_Cam1Jig9La22X, tb_Cam1P2byP1X) },
                { tb_Cam1Jig9La21Y, (tb_Cam1Jig9La22Y, tb_Cam1P2byP1Y) },

                { tb_Cam1Jig9La13X, (tb_Cam1Jig9La14X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig9La13Y, (tb_Cam1Jig9La14Y, tb_Cam1P4byP3Y) },
                { tb_Cam1Jig9La23X, (tb_Cam1Jig9La24X, tb_Cam1P4byP3X) },
                { tb_Cam1Jig9La23Y, (tb_Cam1Jig9La24Y, tb_Cam1P4byP3Y) },
            };
            Control[] controls = {
                                    tb_Cam1StdBo1X,tb_Cam1StdBo1Y,tb_Cam1StdBo1R,
                                    tb_Cam1StdBo2X,tb_Cam1StdBo2Y,tb_Cam1StdBo2R,
                                    tb_Cam1StdLa1X,tb_Cam1StdLa1Y,tb_Cam1StdLa1R,
                                    tb_Cam1StdLa2X,tb_Cam1StdLa2Y,tb_Cam1StdLa2R,

                                    tb_Cam1AddBo1X,tb_Cam1AddBo1Y,tb_Cam1AddBo1R,
                                    tb_Cam1AddBo2X,tb_Cam1AddBo2Y,tb_Cam1AddBo2R,
                                    tb_Cam1AddLa1X,tb_Cam1AddLa1Y,tb_Cam1AddLa1R,
                                    tb_Cam1AddLa2X,tb_Cam1AddLa2Y,tb_Cam1AddLa2R,

                                    tb_Cam1AngleMax,tb_Cam1AngleMin,
                                    tb_Cam1LimitMax,tb_Cam1LimitMin,tb_Cam1Exprosure,

                                    tb_Cam1CenterLa1X,tb_Cam1CenterLa1Y,
                                    tb_Cam1CenterLa2X,tb_Cam1CenterLa2Y,

                                    tb_Cam1P2byP1X,tb_Cam1P2byP1Y,tb_Cam1P4byP3X,tb_Cam1P4byP3Y,
                                    tb_Cam1RobotStep,tb_Cam1LaserStep,
                                    tb_Cam1Spacing,tb_Cam1SpacingUse,tb_Cam1RobotUse,tb_Cam1LaserUse,

                                    tb_Cam1Jig1Bo1X,tb_Cam1Jig1Bo1Y,tb_Cam1Jig1Bo2X,tb_Cam1Jig1Bo2Y,
                                    tb_Cam1Jig1La11X,tb_Cam1Jig1La11Y,tb_Cam1Jig1La21X,tb_Cam1Jig1La21Y,
                                    tb_Cam1Jig1La12X,tb_Cam1Jig1La12Y,tb_Cam1Jig1La22X,tb_Cam1Jig1La22Y,
                                    tb_Cam1Jig1La13X,tb_Cam1Jig1La13Y,tb_Cam1Jig1La23X,tb_Cam1Jig1La23Y,
                                    tb_Cam1Jig1La14X,tb_Cam1Jig1La14Y,tb_Cam1Jig1La24X,tb_Cam1Jig1La24Y,

                                    tb_Cam1Jig2Bo1X,tb_Cam1Jig2Bo1Y,tb_Cam1Jig2Bo2X,tb_Cam1Jig2Bo2Y,
                                    tb_Cam1Jig2La11X,tb_Cam1Jig2La11Y,tb_Cam1Jig2La21X,tb_Cam1Jig2La21Y,
                                    tb_Cam1Jig2La12X,tb_Cam1Jig2La12Y,tb_Cam1Jig2La22X,tb_Cam1Jig2La22Y,
                                    tb_Cam1Jig2La13X,tb_Cam1Jig2La13Y,tb_Cam1Jig2La23X,tb_Cam1Jig2La23Y,
                                    tb_Cam1Jig2La14X,tb_Cam1Jig2La14Y,tb_Cam1Jig2La24X,tb_Cam1Jig2La24Y,

                                    tb_Cam1Jig3Bo1X,tb_Cam1Jig3Bo1Y,tb_Cam1Jig3Bo2X,tb_Cam1Jig3Bo2Y,
                                    tb_Cam1Jig3La11X,tb_Cam1Jig3La11Y,tb_Cam1Jig3La21X,tb_Cam1Jig3La21Y,
                                    tb_Cam1Jig3La12X,tb_Cam1Jig3La12Y,tb_Cam1Jig3La22X,tb_Cam1Jig3La22Y,
                                    tb_Cam1Jig3La13X,tb_Cam1Jig3La13Y,tb_Cam1Jig3La23X,tb_Cam1Jig3La23Y,
                                    tb_Cam1Jig3La14X,tb_Cam1Jig3La14Y,tb_Cam1Jig3La24X,tb_Cam1Jig3La24Y,

                                    tb_Cam1Jig4Bo1X,tb_Cam1Jig4Bo1Y,tb_Cam1Jig4Bo2X,tb_Cam1Jig4Bo2Y,
                                    tb_Cam1Jig4La11X,tb_Cam1Jig4La11Y,tb_Cam1Jig4La21X,tb_Cam1Jig4La21Y,
                                    tb_Cam1Jig4La12X,tb_Cam1Jig4La12Y,tb_Cam1Jig4La22X,tb_Cam1Jig4La22Y,
                                    tb_Cam1Jig4La13X,tb_Cam1Jig4La13Y,tb_Cam1Jig4La23X,tb_Cam1Jig4La23Y,
                                    tb_Cam1Jig4La14X,tb_Cam1Jig4La14Y,tb_Cam1Jig4La24X,tb_Cam1Jig4La24Y,

                                    tb_Cam1Jig5Bo1X,tb_Cam1Jig5Bo1Y,tb_Cam1Jig5Bo2X,tb_Cam1Jig5Bo2Y,
                                    tb_Cam1Jig5La11X,tb_Cam1Jig5La11Y,tb_Cam1Jig5La21X,tb_Cam1Jig5La21Y,
                                    tb_Cam1Jig5La12X,tb_Cam1Jig5La12Y,tb_Cam1Jig5La22X,tb_Cam1Jig5La22Y,
                                    tb_Cam1Jig5La13X,tb_Cam1Jig5La13Y,tb_Cam1Jig5La23X,tb_Cam1Jig5La23Y,
                                    tb_Cam1Jig5La14X,tb_Cam1Jig5La14Y,tb_Cam1Jig5La24X,tb_Cam1Jig5La24Y,

                                    tb_Cam1Jig6Bo1X,tb_Cam1Jig6Bo1Y,tb_Cam1Jig6Bo2X,tb_Cam1Jig6Bo2Y,
                                    tb_Cam1Jig6La11X,tb_Cam1Jig6La11Y,tb_Cam1Jig6La21X,tb_Cam1Jig6La21Y,
                                    tb_Cam1Jig6La12X,tb_Cam1Jig6La12Y,tb_Cam1Jig6La22X,tb_Cam1Jig6La22Y,
                                    tb_Cam1Jig6La13X,tb_Cam1Jig6La13Y,tb_Cam1Jig6La23X,tb_Cam1Jig6La23Y,
                                    tb_Cam1Jig6La14X,tb_Cam1Jig6La14Y,tb_Cam1Jig6La24X,tb_Cam1Jig6La24Y,

                                    tb_Cam1Jig7Bo1X,tb_Cam1Jig7Bo1Y,tb_Cam1Jig7Bo2X,tb_Cam1Jig7Bo2Y,
                                    tb_Cam1Jig7La11X,tb_Cam1Jig7La11Y,tb_Cam1Jig7La21X,tb_Cam1Jig7La21Y,
                                    tb_Cam1Jig7La12X,tb_Cam1Jig7La12Y,tb_Cam1Jig7La22X,tb_Cam1Jig7La22Y,
                                    tb_Cam1Jig7La13X,tb_Cam1Jig7La13Y,tb_Cam1Jig7La23X,tb_Cam1Jig7La23Y,
                                    tb_Cam1Jig7La14X,tb_Cam1Jig7La14Y,tb_Cam1Jig7La24X,tb_Cam1Jig7La24Y,

                                    tb_Cam1Jig8Bo1X,tb_Cam1Jig8Bo1Y,tb_Cam1Jig8Bo2X,tb_Cam1Jig8Bo2Y,
                                    tb_Cam1Jig8La11X,tb_Cam1Jig8La11Y,tb_Cam1Jig8La21X,tb_Cam1Jig8La21Y,
                                    tb_Cam1Jig8La12X,tb_Cam1Jig8La12Y,tb_Cam1Jig8La22X,tb_Cam1Jig8La22Y,
                                    tb_Cam1Jig8La13X,tb_Cam1Jig8La13Y,tb_Cam1Jig8La23X,tb_Cam1Jig8La23Y,
                                    tb_Cam1Jig8La14X,tb_Cam1Jig8La14Y,tb_Cam1Jig8La24X,tb_Cam1Jig8La24Y,

                                    tb_Cam1Jig9Bo1X,tb_Cam1Jig9Bo1Y,tb_Cam1Jig9Bo2X,tb_Cam1Jig9Bo2Y,
                                    tb_Cam1Jig9La11X,tb_Cam1Jig9La11Y,tb_Cam1Jig9La21X,tb_Cam1Jig9La21Y,
                                    tb_Cam1Jig9La12X,tb_Cam1Jig9La12Y,tb_Cam1Jig9La22X,tb_Cam1Jig9La22Y,
                                    tb_Cam1Jig9La13X,tb_Cam1Jig9La13Y,tb_Cam1Jig9La23X,tb_Cam1Jig9La23Y,
                                    tb_Cam1Jig9La14X,tb_Cam1Jig9La14Y,tb_Cam1Jig9La24X,tb_Cam1Jig9La24Y
                                };
            List<string> values = new List<string>
            {
                // StdPose基准位置
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.R.ToString(),
                // AddPose补偿位置
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.R.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.R.ToString(),
                // Angle/Limit/Exprosure
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMax.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMin.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure.ToString(),
                // LaserCenter
                //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.X.ToString(),
                //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.Y.ToString(),
                //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.X.ToString(),
                //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.Y.ToString(),

                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.Y.ToString(),

                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.X.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.Y.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep.ToString(),

                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Spacing.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.SpacingUse.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse.ToString(),
                Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse.ToString(),

                //Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.NozzleNum.ToString()
            };
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations.Length; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.X.ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.Y.ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.X.ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.Y.ToString());
                for (int j = 0; j < 4; j++)
                {
                    values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].X.ToString());
                    values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].Y.ToString());
                    values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].X.ToString());
                    values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].Y.ToString());
                }
            }

            CommonUtility.SetControlsText(this, controls, values, "相机参数");
            _textBoxes.Clear();
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].TextChanged += tb__Validating;//此处注册事件
            }
            // 直接指定要显示的TabPage
            uiTabControlAll.SelectedTab = uiTabPage1;
        }

        private void FrmCameraParamsSettings_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 序列化保存参数并记录修改日志
        /// </summary>
        /// <param name="tb">文本框对象</param>
        /// <param name="productName">工序名（焊接 等）</param>
        /// <param name="oldCameraParamObjects"></param>
        private void CheckAndSave(TextBox tb, string productName, ref List<OperationLogParamModel.OldParam> oldCameraParamObjects)
        {
            //int nozzleIndex = Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum;
            int cameraIndex = Convert.ToInt32(tb.Name.Substring(6, 1));   //截取第七位 //tb_Cam1...tb_Cam2...tb_Cam3...tb_Cam4...
            string item = tb.Name.Substring(7);//截取第七位以后的内容
            #region 在此作每个相机的判断，因为真实项目中多个相机的功能不一定一致，对应的参数不一定一致。若一致，可以整合。不一致，可以整合与分开结合或不结合
            if (cameraIndex == 1)
            {
                double _oldValue, _newValue;
                switch (item)
                {
                    #region 基准Std
                    case "StdBo1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.X = _newValue;
                        break;
                    case "StdBo1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.Y = _newValue;
                        break;
                    case "StdBo1R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo1Axis.R = _newValue;
                        break;

                    case "StdBo2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.X = _newValue;
                        break;
                    case "StdBo2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.Y = _newValue;
                        break;
                    case "StdBo2R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.Bo2Axis.R = _newValue;
                        break;

                    case "StdLa1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.X = _newValue;
                        break;
                    case "StdLa1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.Y = _newValue;
                        break;
                    case "StdLa1R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La1Axis.R = _newValue;
                        break;

                    case "StdLa2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.X = _newValue;
                        break;
                    case "StdLa2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.Y = _newValue;
                        break;
                    case "StdLa2R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.StdPose.La2Axis.R = _newValue;
                        break;
                    #endregion
                    #region 补偿Add
                    case "AddBo1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.X = _newValue;
                        break;
                    case "AddBo1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.Y = _newValue;
                        break;
                    case "AddBo1R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo1Axis.R = _newValue;
                        break;

                    case "AddBo2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.X = _newValue;
                        break;
                    case "AddBo2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.Y = _newValue;
                        break;
                    case "AddBo2R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.Bo2Axis.R = _newValue;
                        break;

                    case "AddLa1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.X = _newValue;
                        break;
                    case "AddLa1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.Y = _newValue;
                        break;
                    case "AddLa1R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La1Axis.R = _newValue;
                        break;

                    case "AddLa2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.X = _newValue;
                        break;
                    case "AddLa2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.Y = _newValue;
                        break;
                    case "AddLa2R":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.R;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AddPose.La2Axis.R = _newValue;
                        break;
                    #endregion

                    case "AngleMax":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMax = _newValue;
                        break;
                    case "AngleMin":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.AngleMin = _newValue;
                        break;
                    case "LimitMax":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMax;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMax = _newValue;
                        break;
                    case "LimitMin":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMin;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LimitMin = _newValue;
                        break;
                    case "Exprosure":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Exprosure = _newValue;
                        break;

                    // 机器人旋转中心
                    case "CenterBo1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.X = _newValue;
                        break;
                    case "CenterBo1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo1Axis.Y = _newValue;
                        break;
                    case "CenterBo2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.X = _newValue;
                        break;
                    case "CenterBo2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RotationCenter.Bo2Axis.Y = _newValue;
                        break;

                    // 激光九点标定中心(控制振镜偏移坐标)
                    case "CenterLa1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.X = _newValue;
                        break;
                    case "CenterLa1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La1Axis.Y = _newValue;
                        break;
                    case "CenterLa2X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.X = _newValue;
                        break;
                    case "CenterLa2Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LocationCenter.La2Axis.Y = _newValue;
                        break;

                    // 九点标定步长
                    case "RobotStep":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.RobotStep = _newValue;
                        break;
                    case "LaserStep":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaserStep = _newValue;
                        break;

                    // 极耳间距补偿及相关使能
                    case "Spacing":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Spacing;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.Spacing = _newValue;
                        break;
                    case "SpacingUse":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.SpacingUse;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.SpacingUse = (int)_newValue;
                        break;
                    case "RobotUse":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.BoUse = (int)_newValue;
                        break;
                    case "LaserUse":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.LaUse = (int)_newValue;
                        break;

                    // 激光九点标定中心(控制振镜偏移坐标)
                    case "P2byP1X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.X = _newValue;
                        break;
                    case "P2byP1Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P2byP1.Y = _newValue;
                        break;
                    case "P4byP3X":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.X;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.X = _newValue;
                        break;
                    case "P4byP3Y":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.Y;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.P4byP3.Y = _newValue;
                        break;

                    case "NozzleNum":
                        _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.NozzleNum;
                        if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.NozzleNum = (int)_newValue;
                        break;
                }
                // 夹具补偿对应参数较多，由此按名称查询，缩短运行时间
                if (item.Contains("Jig"))
                {
                    bool shouldBreak = false;
                    if (item.Contains("Bo1"))
                    {
                        for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations.Length; i++)
                        {
                            if (item == $"Jig{i + 1}Bo1X")
                            {
                                _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.X;
                                if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                {
                                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.X = _newValue;
                                    break;
                                }
                            }
                            if (item == $"Jig{i + 1}Bo1Y")
                            {
                                _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.Y;
                                if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                {
                                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo1Axis.Y = _newValue;
                                    break;
                                }
                            }
                        }
                    }
                    else if (item.Contains("Bo2"))
                    {
                        for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations.Length; i++)
                        {
                            if (item == $"Jig{i + 1}Bo2X")
                            {
                                _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.X;
                                if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                {
                                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.X = _newValue;
                                    break;
                                }
                            }
                            if (item == $"Jig{i + 1}Bo2Y")
                            {
                                _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.Y;
                                if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                {
                                    Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].Bo2Axis.Y = _newValue;
                                    break;
                                }
                            }
                        }
                    }
                    else if (item.Contains("La1"))
                    {
                        for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations.Length; i++)
                        {
                            for (int j = 0; j < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[0].LaserPointNum; j++)
                            {
                                if (item == $"Jig{i + 1}La1{j + 1}X")
                                {
                                    _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].X;
                                    if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                    {
                                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].X = _newValue;
                                        shouldBreak = true;
                                        break;
                                    }
                                }
                                if (item == $"Jig{i + 1}La1{j + 1}Y")
                                {
                                    _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].Y;
                                    if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                    {
                                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La1Axis[j].Y = _newValue;
                                        shouldBreak = true;
                                        break;
                                    }
                                }
                            }
                            if (shouldBreak)
                            {
                                break;
                            }
                        }
                    }
                    else if (item.Contains("La2"))
                    {
                        for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations.Length; i++)
                        {
                            for (int j = 0; j < Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[0].LaserPointNum; j++)
                            {
                                if (item == $"Jig{i + 1}La2{j + 1}X")
                                {
                                    _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].X;
                                    if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                    {
                                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].X = _newValue;
                                        shouldBreak = true;
                                        break;
                                    }
                                }
                                if (item == $"Jig{i + 1}La2{j + 1}Y")
                                {
                                    _oldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].Y;
                                    if (IsParamChange(productName, cameraIndex, tb, _oldValue, ref oldCameraParamObjects, out _newValue))
                                    {
                                        Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.ParamsC1.JigCompensations[i].L_La2Axis[j].Y = _newValue;
                                        shouldBreak = true;
                                        break;
                                    }
                                }
                            }
                            if (shouldBreak)
                            {
                                break;
                            }
                        }
                    }
                    else
                        LogHelper.Error("相机参数设置窗体CheckAndSave函数中，Jig补偿参数名称解析错误！" + item);
                }
            }
            #endregion
        }
        /// <summary>
        /// 判断文本框内容是否修改，若修改则输出修改后参数的通用方法
        /// </summary>
        /// <param name="productName">工序名</param>
        /// <param name="cameraIndex">相机Index</param>
        /// <param name="tb">指针点击过的TextBox</param>
        /// <param name="oldValue">旧的参数</param>
        /// <param name="oldCameraParamObjects">修改数据存放的模型</param>
        /// <param name="newValue">新的参数（从TextBox中提取）</param>
        /// <returns>新旧值 是t 否f 有出入</returns>
        private bool IsParamChange(string productName, int cameraIndex, TextBox tb, double oldValue, ref List<OperationLogParamModel.OldParam> oldCameraParamObjects, out double newValue)
        {
            if (!oldValue.ToString().Equals(tb.Text))
            {
                oldCameraParamObjects.Add(new OperationLogParamModel.OldParam()
                {
                    //{工序名}camera{1}{tag}
                    Text = $"{productName}camera{cameraIndex}{tb.Tag}",
                    Field = tb.Name.Substring(7),
                    OldValue = oldValue.ToString(),
                    NewValue = tb.Text
                });
                newValue = double.Parse(tb.Text);
                return true;
            }
            newValue = oldValue;
            return false;
        }
        private void UiSymbolButtonSave_Click(object sender, EventArgs e)
        {
            if (_textBoxes.Count == 0)
                System.Windows.MessageBox.Show("相机设置参数暂无修改");
            //若有控件获取过焦点
            List<OperationLogParamModel.OldParam> oldCameraParamObjects = new List<OperationLogParamModel.OldParam>();
            string productName = Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel ? Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel : "通用产品";
            foreach (TextBox tb in _textBoxes)
                CheckAndSave(tb, productName, ref oldCameraParamObjects);
            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveAllParams();
            if (oldCameraParamObjects.Count > 0)
            {
                System.Windows.MessageBox.Show("相机设置参数修改成功！");

                OperationLogDataBll.GetInstance().InsertOperationLog(oldCameraParamObjects, "相机设置");
            }
            else
            {
                System.Windows.MessageBox.Show("相机设置参数暂无修改！");
            }


        }

        /// <summary>
        /// 利用这个离焦验证，记录当前操作人鼠标点过哪些文本框（文本框获取过焦点）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb__Validating(object sender, EventArgs e)
        {
            try
            {
                TextBox uiTb = (TextBox)sender;
                uiTb.Text = uiTb.Text.Trim();
                Label l = (Label)this.Controls.Find("lb_" + uiTb.Name.Substring(3), true)[0];
                TabPage currentTab = GetParentTabPage(l);

                #region 数值检查
                if (string.IsNullOrEmpty(uiTb.Text))
                {
                    MessageBox.Show($"{l.Text}文本框内不能为空！");
                    return;
                }
                if (uiTb.Name == "tb_Cam1RobStep" || uiTb.Name == "tb_Cam1LaserStep")
                {
                    if (Convert.ToDouble(uiTb.Text) > 3)
                    {
                        DialogResult res = MessageBox.Show($"{l.Text}数值不宜设置过大，目前为{uiTb.Text}，是否使用？", "数值检查", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (res != DialogResult.OK)
                        {
                            uiTb.Text = null;
                            return;
                        }
                    }
                }
                #endregion

                LogHelper.Info(currentTab.Text + l.Text + $"填入参数{uiTb.Text}成功");
                //判断是否已在集合中
                if (!_textBoxes.Contains(uiTb))
                    _textBoxes.Add(uiTb);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
        }
        private void InitializaButtonActions()
        {
            // 使用数组和循环简化按钮与事件的绑定
            var stdButtons = new[] { btn_GetStd1, btn_GetStd2, btn_GetStd3, btn_GetStd4 };
            var stdClickHandlers = new Action[]
            {
                () => btn_GetStd1_Click(btn_GetStd1, EventArgs.Empty),
                () => btn_GetStd2_Click(btn_GetStd2, EventArgs.Empty),
                () => btn_GetStd3_Click(btn_GetStd3, EventArgs.Empty),
                () => btn_GetStd4_Click(btn_GetStd4, EventArgs.Empty)
            };
            for (int i = 0; i < stdButtons.Length; i++)
            {
                buttonActions.Add(stdButtons[i], stdClickHandlers[i]);
            }

            var clearButtons = new[] { btn_clearJ1, btn_clearJ2, btn_clearJ3, btn_clearJ4, btn_clearJ5, btn_clearJ6, btn_clearJ7, btn_clearJ8, btn_clearJ9 };
            foreach (var btn in clearButtons)
            {
                buttonActions.Add(btn, () => Button_Click(btn, EventArgs.Empty));
            }

            foreach (var btn in buttonActions.Keys)
            {
                btn.MouseDown += Button_MouseDown;
                btn.MouseUp += Button_MouseUp;
            }

            holdTimer.Interval = 100;
            holdTimer.Tick += HoldTimer_Tick;
        }
        private void InitializeControlPairs()
        {
            // 使用数组和循环简化控件对的添加
            var clearCheckboxes = new[] { cb_clearJ1, cb_clearJ2, cb_clearJ3, cb_clearJ4, cb_clearJ5, cb_clearJ6, cb_clearJ7, cb_clearJ8, cb_clearJ9 };
            var clearButtons = new[] { btn_clearJ1, btn_clearJ2, btn_clearJ3, btn_clearJ4, btn_clearJ5, btn_clearJ6, btn_clearJ7, btn_clearJ8, btn_clearJ9 };
            var tabPages = new[] { tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6, tabPage7, tabPage8, tabPage9 };

            for (int i = 0; i < clearCheckboxes.Length; i++)
            {
                Pairscb_btn.Add((clearCheckboxes[i], clearButtons[i]));
                Pairsbtn_tp.Add((clearButtons[i], tabPages[i]));
            }

            foreach (var pair in Pairscb_btn)
            {
                pair.checkbox.CheckedChanged += Checkbox_CheckedChanged;
                pair.button.Enabled = pair.checkbox.Checked;
            }
        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            currentButton = sender as Button; // 记录当前操作的按钮
            currentButton.Tag = currentButton.Text;
            buttonPressTime = DateTime.Now;
            holdTimer.Start();
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            holdTimer.Stop();
            if (currentButton == null) return;
            currentButton.Text = currentButton.Tag.ToString();
            currentButton = null;
        }

        private void HoldTimer_Tick(object sender, EventArgs e)
        {
            if (currentButton == null) return;

            var holdDuration = DateTime.Now - buttonPressTime;

            double progress = Math.Min((DateTime.Now - buttonPressTime).TotalSeconds / 3 * 100, 100);
            currentButton.Text = $"{progress:0}%";

            if (holdDuration.TotalSeconds >= 3)
            {
                holdTimer.Stop();
                if (buttonActions.TryGetValue(currentButton, out var action))
                {
                    action.Invoke(); // 执行对应逻辑
                }
                if (currentButton == null) return;
                currentButton.Text = currentButton.Tag.ToString();
                currentButton = null;
            }
        }
        private void btn_GetStd1_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser.UserRoleName == "工程师")
            {
                PointAxis _standPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.StandPose.Bo1Axis;
                if (MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdBo1X.Text = _standPose.X.ToString("f3");
                    tb_Cam1StdBo1Y.Text = _standPose.Y.ToString("f3");
                    tb_Cam1StdBo1R.Text = _standPose.R.ToString("f3");

                    //判断是否已在集合中
                    if (!_textBoxes.Contains(tb_Cam1StdBo1X))
                        _textBoxes.Add(tb_Cam1StdBo1X);
                    if (!_textBoxes.Contains(tb_Cam1StdBo1Y))
                        _textBoxes.Add(tb_Cam1StdBo1Y);
                    if (!_textBoxes.Contains(tb_Cam1StdBo1R))
                        _textBoxes.Add(tb_Cam1StdBo1R);
                }
            }
            else
                System.Windows.MessageBox.Show("工程师才可修改基准");

        }
        private void btn_GetStd2_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser.UserRoleName == "工程师")
            {
                PointAxis _standPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.StandPose.Bo2Axis;
                if (MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdBo2X.Text = _standPose.X.ToString("f3");
                    tb_Cam1StdBo2Y.Text = _standPose.Y.ToString("f3");
                    tb_Cam1StdBo2R.Text = _standPose.R.ToString("f3");
                    //判断是否已在集合中
                    if (!_textBoxes.Contains(tb_Cam1StdBo2X))
                        _textBoxes.Add(tb_Cam1StdBo2X);
                    if (!_textBoxes.Contains(tb_Cam1StdBo2Y))
                        _textBoxes.Add(tb_Cam1StdBo2Y);
                    if (!_textBoxes.Contains(tb_Cam1StdBo2R))
                        _textBoxes.Add(tb_Cam1StdBo2R);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }
        }

        private void btn_GetStd3_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser.UserRoleName == "工程师")
            {
                PointAxis _standPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.StandPose.La1Axis;
                if (MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdLa1X.Text = _standPose.X.ToString("f3");
                    tb_Cam1StdLa1Y.Text = _standPose.Y.ToString("f3");
                    tb_Cam1StdLa1R.Text = _standPose.R.ToString("f3");
                    //判断是否已在集合中
                    if (!_textBoxes.Contains(tb_Cam1StdLa1X))
                        _textBoxes.Add(tb_Cam1StdLa1X);
                    if (!_textBoxes.Contains(tb_Cam1StdLa1Y))
                        _textBoxes.Add(tb_Cam1StdLa1Y);
                    if (!_textBoxes.Contains(tb_Cam1StdLa1R))
                        _textBoxes.Add(tb_Cam1StdLa1R);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }

        }

        private void btn_GetStd4_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserManagerInstance.CurrentUser.UserRoleName == "工程师")
            {
                PointAxis _standPose = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.StandPose.La2Axis;
                if (MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdLa2X.Text = _standPose.X.ToString("f3");
                    tb_Cam1StdLa2Y.Text = _standPose.Y.ToString("f3");
                    tb_Cam1StdLa2R.Text = _standPose.R.ToString("f3");
                    //判断是否已在集合中
                    if (!_textBoxes.Contains(tb_Cam1StdLa2X))
                        _textBoxes.Add(tb_Cam1StdLa2X);
                    if (!_textBoxes.Contains(tb_Cam1StdLa2Y))
                        _textBoxes.Add(tb_Cam1StdLa2Y);
                    if (!_textBoxes.Contains(tb_Cam1StdLa2R))
                        _textBoxes.Add(tb_Cam1StdLa2R);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }

        }

        private void GenericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox triggeringTextBox = (TextBox)sender;

            if (textBoxMappings.TryGetValue(triggeringTextBox, out var mapping))
            {
                if (double.TryParse(triggeringTextBox.Text, out double addValue) &&
                    double.TryParse(mapping.addendTextBox.Text, out double addendValue))
                {
                    mapping.outputTextBox.Text = (addValue + addendValue).ToString();
                }
            }
        }
        // 所有夹具页面checkbox状态改变事件
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            var currentCheckbox = sender as CheckBox;

            // 查找对应的按钮
            var targetButton = Pairscb_btn
                .FirstOrDefault(p => p.checkbox == currentCheckbox).button;

            if (targetButton != null)
            {
                // 实时更新按钮状态
                targetButton.Enabled = currentCheckbox.Checked;
            }
        }
        // 方法：递归设置所有TextBox的值
        private void SetAllTextBoxZero(Control container)
        {
            foreach (Control ctrl in container.Controls)
            {
                // 如果是文本框直接设置
                if (ctrl is TextBox txt)
                {
                    txt.Text = "0";
                }
                // 如果是容器控件则递归遍历
                else if (ctrl.HasChildren)
                {
                    SetAllTextBoxZero(ctrl);
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            var currentButton = sender as Button;

            // 查找对应的按钮
            var targetTabPage = Pairsbtn_tp
                .FirstOrDefault(p => p.button == currentButton).tabpage;

            if (targetTabPage != null)
            {
                if (System.Windows.Forms.MessageBox.Show("是否确定清除当前页面所有补偿", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    // 实时更新按钮状态
                    SetAllTextBoxZero(targetTabPage);
                }
            }

        }
        // 通用方法：查找控件所在的TabPage
        public static TabPage GetParentTabPage(Control control)
        {
            if (control == null) return null;

            Control parent = control.Parent;
            while (parent != null)
            {
                if (parent is TabPage tabPage)
                {
                    return tabPage;
                }
                parent = parent.Parent;
            }
            return null;
        }
    }
}
