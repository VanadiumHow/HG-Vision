using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model.UIModel;
using Obj.Obj_File;
using Obj.Utility;
using HG_Vision.Contol.Control_Sql;
using HG_Vision.Manager.Manager_System;

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
        private Dictionary<string, string> _validatingDic = new Dictionary<string, string>();

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




        private void FrmCCDParamSettings_Load(object sender, EventArgs e)
        {
            Control[] controls = {
                                              tb_Cam1StdX1,tb_Cam1StdY1,tb_Cam1StdT1,
                                              tb_Cam1StdX2,tb_Cam1StdY2,tb_Cam1StdT2,
                                              tb_Cam1StdX3,tb_Cam1StdY3,tb_Cam1StdT3,
                                              tb_Cam1StdX4,tb_Cam1StdY4,tb_Cam1StdT4,
                                              tb_Cam1AddX1,tb_Cam1AddY1,tb_Cam1AddT1,
                                              tb_Cam1AddX2,tb_Cam1AddY2,tb_Cam1AddT2,
                                              tb_Cam1AddX3,tb_Cam1AddY3,tb_Cam1AddT3,
                                              tb_Cam1AddX4,tb_Cam1AddY4,tb_Cam1AddT4,
                                              tb_Cam1Anglemin,tb_Cam1Anglemax,
                                              tb_Cam1Limitmin,tb_Cam1Limitmax,tb_Cam1OffsetX,
                                             tb_Cam1Exprosure,
                                              tb_Cam1L1CalibX0,tb_Cam1L1CalibY0,
                                              tb_Cam1L2CalibX0,tb_Cam1L2CalibY0,
                                                tb_Cam1CellLineL,tb_Cam1P2byP1X,tb_Cam1P2byP1Y,tb_Cam1P4byP3X,
                                             tb_Cam1P4byP3Y,tb_Cam1LaserStep,tb_Cam1RobStep,tb_Cam1Spacing,
                                                tb_Cam1SpacingUse,tb_Cam1RobUse,tb_Cam1LaserUse,
                                                tb_Cam1ALX,tb_Cam1ALY,tb_Cam1NI1X,tb_Cam1NI1Y,tb_Cam1NI2X,tb_Cam1NI2Y,
                                                tb_Cam1ALX1,tb_Cam1ALY1,tb_Cam1NI1X1,tb_Cam1NI1Y1,tb_Cam1NI2X1,tb_Cam1NI2Y1,


                                              tb_Cam1AddR1J1X,tb_Cam1AddR1J1Y,tb_Cam1AddR2J1X,tb_Cam1AddR2J1Y,
                                              tb_Cam1AddL1J1X1,tb_Cam1AddL1J1Y1,tb_Cam1AddL1J1X2,tb_Cam1AddL1J1Y2,
                                              tb_Cam1AddL1J1X3,tb_Cam1AddL1J1Y3,tb_Cam1AddL1J1X4,tb_Cam1AddL1J1Y4,
                                               tb_Cam1AddL2J1X1,tb_Cam1AddL2J1Y1,tb_Cam1AddL2J1X2,tb_Cam1AddL2J1Y2,
                                              tb_Cam1AddL2J1X3,tb_Cam1AddL2J1Y3,tb_Cam1AddL2J1X4,tb_Cam1AddL2J1Y4,

                                               tb_Cam1AddR1J2X,tb_Cam1AddR1J2Y,tb_Cam1AddR2J2X,tb_Cam1AddR2J2Y,
                                              tb_Cam1AddL1J2X1,tb_Cam1AddL1J2Y1,tb_Cam1AddL1J2X2,tb_Cam1AddL1J2Y2,
                                              tb_Cam1AddL1J2X3,tb_Cam1AddL1J2Y3,tb_Cam1AddL1J2X4,tb_Cam1AddL1J2Y4,
                                               tb_Cam1AddL2J2X1,tb_Cam1AddL2J2Y1,tb_Cam1AddL2J2X2,tb_Cam1AddL2J2Y2,
                                              tb_Cam1AddL2J2X3,tb_Cam1AddL2J2Y3,tb_Cam1AddL2J2X4,tb_Cam1AddL2J2Y4,

                                               tb_Cam1AddR1J3X,tb_Cam1AddR1J3Y,tb_Cam1AddR2J3X,tb_Cam1AddR2J3Y,
                                              tb_Cam1AddL1J3X1,tb_Cam1AddL1J3Y1,tb_Cam1AddL1J3X2,tb_Cam1AddL1J3Y2,
                                              tb_Cam1AddL1J3X3,tb_Cam1AddL1J3Y3,tb_Cam1AddL1J3X4,tb_Cam1AddL1J3Y4,
                                               tb_Cam1AddL2J3X1,tb_Cam1AddL2J3Y1,tb_Cam1AddL2J3X2,tb_Cam1AddL2J3Y2,
                                              tb_Cam1AddL2J3X3,tb_Cam1AddL2J3Y3,tb_Cam1AddL2J3X4,tb_Cam1AddL2J3Y4,

                                               tb_Cam1AddR1J4X,tb_Cam1AddR1J4Y,tb_Cam1AddR2J4X,tb_Cam1AddR2J4Y,
                                              tb_Cam1AddL1J4X1,tb_Cam1AddL1J4Y1,tb_Cam1AddL1J4X2,tb_Cam1AddL1J4Y2,
                                              tb_Cam1AddL1J4X3,tb_Cam1AddL1J4Y3,tb_Cam1AddL1J4X4,tb_Cam1AddL1J4Y4,
                                               tb_Cam1AddL2J4X1,tb_Cam1AddL2J4Y1,tb_Cam1AddL2J4X2,tb_Cam1AddL2J4Y2,
                                              tb_Cam1AddL2J4X3,tb_Cam1AddL2J4Y3,tb_Cam1AddL2J4X4,tb_Cam1AddL2J4Y4,

                                               tb_Cam1AddR1J5X,tb_Cam1AddR1J5Y,tb_Cam1AddR2J5X,tb_Cam1AddR2J5Y,
                                              tb_Cam1AddL1J5X1,tb_Cam1AddL1J5Y1,tb_Cam1AddL1J5X2,tb_Cam1AddL1J5Y2,
                                              tb_Cam1AddL1J5X3,tb_Cam1AddL1J5Y3,tb_Cam1AddL1J5X4,tb_Cam1AddL1J5Y4,
                                               tb_Cam1AddL2J5X1,tb_Cam1AddL2J5Y1,tb_Cam1AddL2J5X2,tb_Cam1AddL2J5Y2,
                                              tb_Cam1AddL2J5X3,tb_Cam1AddL2J5Y3,tb_Cam1AddL2J5X4,tb_Cam1AddL2J5Y4,

                                               tb_Cam1AddR1J6X,tb_Cam1AddR1J6Y,tb_Cam1AddR2J6X,tb_Cam1AddR2J6Y,
                                              tb_Cam1AddL1J6X1,tb_Cam1AddL1J6Y1,tb_Cam1AddL1J6X2,tb_Cam1AddL1J6Y2,
                                              tb_Cam1AddL1J6X3,tb_Cam1AddL1J6Y3,tb_Cam1AddL1J6X4,tb_Cam1AddL1J6Y4,
                                               tb_Cam1AddL2J6X1,tb_Cam1AddL2J6Y1,tb_Cam1AddL2J6X2,tb_Cam1AddL2J6Y2,
                                              tb_Cam1AddL2J6X3,tb_Cam1AddL2J6Y3,tb_Cam1AddL2J6X4,tb_Cam1AddL2J6Y4,

                                               tb_Cam1AddR1J7X,tb_Cam1AddR1J7Y,tb_Cam1AddR2J7X,tb_Cam1AddR2J7Y,
                                              tb_Cam1AddL1J7X1,tb_Cam1AddL1J7Y1,tb_Cam1AddL1J7X2,tb_Cam1AddL1J7Y2,
                                              tb_Cam1AddL1J7X3,tb_Cam1AddL1J7Y3,tb_Cam1AddL1J7X4,tb_Cam1AddL1J7Y4,
                                               tb_Cam1AddL2J7X1,tb_Cam1AddL2J7Y1,tb_Cam1AddL2J7X2,tb_Cam1AddL2J7Y2,
                                              tb_Cam1AddL2J7X3,tb_Cam1AddL2J7Y3,tb_Cam1AddL2J7X4,tb_Cam1AddL2J7Y4,

                                               tb_Cam1AddR1J8X,tb_Cam1AddR1J8Y,tb_Cam1AddR2J8X,tb_Cam1AddR2J8Y,
                                              tb_Cam1AddL1J8X1,tb_Cam1AddL1J8Y1,tb_Cam1AddL1J8X2,tb_Cam1AddL1J8Y2,
                                              tb_Cam1AddL1J8X3,tb_Cam1AddL1J8Y3,tb_Cam1AddL1J8X4,tb_Cam1AddL1J8Y4,
                                               tb_Cam1AddL2J8X1,tb_Cam1AddL2J8Y1,tb_Cam1AddL2J8X2,tb_Cam1AddL2J8Y2,
                                              tb_Cam1AddL2J8X3,tb_Cam1AddL2J8Y3,tb_Cam1AddL2J8X4,tb_Cam1AddL2J8Y4,

                                                 tb_Cam1AddR1J9X,tb_Cam1AddR1J9Y,tb_Cam1AddR2J9X,tb_Cam1AddR2J9Y,
                                              tb_Cam1AddL1J9X1,tb_Cam1AddL1J9Y1,tb_Cam1AddL1J9X2,tb_Cam1AddL1J9Y2,
                                              tb_Cam1AddL1J9X3,tb_Cam1AddL1J9Y3,tb_Cam1AddL1J9X4,tb_Cam1AddL1J9Y4,
                                               tb_Cam1AddL2J9X1,tb_Cam1AddL2J9Y1,tb_Cam1AddL2J9X2,tb_Cam1AddL2J9Y2,
                                              tb_Cam1AddL2J9X3,tb_Cam1AddL2J9Y3,tb_Cam1AddL2J9X4,tb_Cam1AddL2J9Y4

                                           };
            List<string> values = new List<string>();
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[i].ToString());
            }
            //////////////////////////////////////////////////////////////////
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[i].ToString());
            }
            for (int i = 0; i < Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[i].ToString());
            }

            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraManagerInstance.CameraNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[i].ToString());

            }
            for (int i = 0; i < Project.Instance.VisionManagerInstance.CameraManagerInstance.CameraNum; i++)
            {
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobStep[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y1[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[i].ToString());

                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[i].ToString());
                values.Add(Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[i].ToString());
            }

            CommonUtility.SetControlsText(this, controls, values, "相机参数");
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].TextChanged += tb__Validating;

            }
            _validatingDic.Clear();
            // 直接指定要显示的TabPage
            uiTabControlAll.SelectedTab = tabPage1;
        }

        private void FrmCameraParamsSettings_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="text"></param>
        /// <param name="productName"></param>
        /// <param name="oldCameraParamObjects"></param>
        /// <returns></returns>
        private void checkAndSave(string name, string text, string productName, ref List<OperationLogParamModel.OldParam> oldCameraParamObjects)
        {
            int nozzleIndex = Project.Instance.GlobalManagerInstance.GlobalParamModel.NozzleNum;
            int cameraIndex = Convert.ToInt32(name.Substring(6, 1));   //截取第七位 //tb_Cam1...tb_Cam2...tb_Cam3...tb_Cam4...
            string item = name.Substring(7);//截取第七位以后的内容
            #region 在此作每个相机的判断，因为真实项目中多个相机的功能不一定一致，对应的参数不一定一致。若一致，可以整合。不一致，可以整合与分开结合或不结合
            if (cameraIndex == 1)
            {
                switch (item)
                {
                    #region 基准X
                    case "StdX1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X1", Field = "StdX1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "StdX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[0].ToString());
                        }
                        break;
                    case "StdX2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X2", Field = "StdX2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "StdX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdX[0].ToString());
                        }
                        break;
                    case "StdX3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X3", Field = "StdX3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "StdX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdX[0].ToString());
                        }
                        break;
                    case "StdX4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X4", Field = "StdX4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "StdX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdX[0].ToString());
                        }
                        break;
                    case "StdX5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X5", Field = "StdX5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdX5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[4].ToString());
                        }
                        break;
                    case "StdX6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准X6", Field = "StdX6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdX6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdX[5].ToString());
                        }
                        break;
                    #endregion
                    #region 基准Y
                    case "StdY1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y1", Field = "StdY1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "StdY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[0].ToString());
                        }
                        break;
                    case "StdY2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y2", Field = "StdY2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "StdY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdY[0].ToString());
                        }
                        break;
                    case "StdY3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y3", Field = "StdY3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "StdY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdY[0].ToString());
                        }
                        break;
                    case "StdY4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y4", Field = "StdY4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "StdY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdY[0].ToString());
                        }
                        break;
                    case "StdY5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y5", Field = "StdY5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdY5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[4].ToString());
                        }
                        break;
                    case "StdY6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准Y6", Field = "StdY6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdY6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdY[5].ToString());
                        }
                        break;
                    #endregion
                    #region 基准T
                    case "StdT1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T1", Field = "StdT1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "StdT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[0].ToString());
                        }
                        break;
                    case "StdT2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T2", Field = "StdT2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "StdT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2StdT[0].ToString());
                        }
                        break;
                    case "StdT3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T3", Field = "StdT3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "StdT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3StdT[0].ToString());
                        }
                        break;
                    case "StdT4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T4", Field = "StdT4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "StdT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4StdT[0].ToString());
                        }
                        break;
                    case "StdT5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T5", Field = "StdT5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdT5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[4].ToString());
                        }
                        break;
                    case "StdT6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}基准T6", Field = "StdT6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "StdT6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1StdT[5].ToString());
                        }
                        break;
                    #endregion
                    #region 补偿X
                    case "AddX1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X1", Field = "AddX1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "AddX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[0].ToString());
                        }
                        break;
                    case "AddX2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X2", Field = "AddX2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "AddX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddX[0].ToString());
                        }
                        break;
                    case "AddX3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X3", Field = "AddX3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "AddX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddX[0].ToString());
                        }
                        break;
                    case "AddX4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X4", Field = "AddX4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "AddX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddX[0].ToString());
                        }
                        break;
                    case "AddX5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X5", Field = "AddX5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddX5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[4].ToString());
                        }
                        break;
                    case "AddX6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿X6", Field = "AddX6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddX6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddX[5].ToString());
                        }
                        break;
                    #endregion
                    #region 补偿Y
                    case "AddY1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y1", Field = "AddY1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "AddY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[0].ToString());
                        }
                        break;
                    case "AddY2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y2", Field = "AddY2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "AddY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddY[0].ToString());
                        }
                        break;
                    case "AddY3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y3", Field = "AddY3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "AddY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddY[0].ToString());
                        }
                        break;
                    case "AddY4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y4", Field = "AddY4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "AddY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddY[0].ToString());
                        }
                        break;
                    case "AddY5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y5", Field = "AddY5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddY5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[4].ToString());
                        }
                        break;
                    case "AddY6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿Y6", Field = "AddY6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddY6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddY[5].ToString());
                        }
                        break;
                    #endregion
                    #region 补偿T
                    case "AddT1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T1", Field = "AddT1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{1}", "AddT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[0].ToString());
                        }
                        break;
                    case "AddT2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T2", Field = "AddT2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{2}", "AddT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam2AddT[0].ToString());
                        }
                        break;
                    case "AddT3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T3", Field = "AddT3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{3}", "AddT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam3AddT[0].ToString());
                        }
                        break;
                    case "AddT4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[0].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T4", Field = "AddT4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[0].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[0] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{4}", "AddT1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam4AddT[0].ToString());
                        }
                        break;
                    case "AddT5":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[4].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T5", Field = "AddT5", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[4].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[4] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddT5", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[4].ToString());
                        }
                        break;
                    case "AddT6":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[5].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}补偿T6", Field = "AddT6", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[5].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[5] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddT6", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_cam1AddT[5].ToString());
                        }
                        break;
                    #endregion
                    case "ProductCodeAreaMin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}二维码面积下限", Field = "ProductCodeAreaMin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductCodeAreaMin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMin[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductCodeAreaMax":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMax[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}二维码面积上限", Field = "ProductCodeAreaMax", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMax[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMax[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductCodeAreaMax", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductCodeAreaMax[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductAreaMin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}产品面积下限", Field = "ProductAreaMin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductAreaMin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMin[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductAreaMax":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMax[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}产品面积上限", Field = "ProductAreaMax", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMax[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMax[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductAreaMax", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductAreaMax[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductDistanceMin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}圆心距下限", Field = "ProductDistanceMin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductDistanceMin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMin[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductDistanceMax":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}圆心距上限", Field = "ProductDistanceMax", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductDistanceMax", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductDistanceMax[cameraIndex - 1].ToString());
                        }
                        break;
                    case "ProductGrayValueMin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}物料平均灰度下限", Field = "ProductGrayValueMin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ProductGrayValueMin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_ProductGrayValueMin[cameraIndex - 1].ToString());
                        }
                        break;
                    case "Exprosure":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}曝光值", Field = "Exprosure", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Exprosure", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_camExprosure[cameraIndex - 1].ToString());
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveExprosure(cameraIndex - 1, double.Parse(text));
                        }
                        break;

                    case "Anglemin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}Anglemin", Field = "Anglemin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Anglemin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemin[cameraIndex - 1].ToString());
                        }
                        break;

                    case "Anglemax":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}Anglemax", Field = "Anglemax", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Anglemax", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Anglemax[cameraIndex - 1].ToString());
                        }
                        break;

                    case "Limitmin":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}Limitmin", Field = "Limitmin", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Limitmin", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmin[cameraIndex - 1].ToString());
                        }
                        break;

                    case "Limitmax":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}Limitmax", Field = "Limitmax", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Limitmax", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_Limitmax[cameraIndex - 1].ToString());
                        }
                        break;

                    case "OffsetX":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}OffsetX", Field = "OffsetX", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "OffsetX", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L_OffsetX[cameraIndex - 1].ToString());
                        }
                        break;

                    #region 激光九点标定点
                    case "L1CalibX0":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点L1CalibX0", Field = "L1CalibX0", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "L1CalibX0", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibX0[cameraIndex - 1].ToString());
                        }
                        break;


                    case "L1CalibY0":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点L1CalibY0", Field = "L1CalibY0", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "L1CalibY0", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L1CalibY0[cameraIndex - 1].ToString());
                        }
                        break;

                    case "L2CalibX0":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点L2CalibX0", Field = "L2CalibX0", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "L2CalibX0", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibX0[cameraIndex - 1].ToString());
                        }
                        break;


                    case "L2CalibY0":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点L2CalibY0", Field = "L2CalibY0", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "L2CalibY0", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.L2CalibY0[cameraIndex - 1].ToString());
                        }
                        break;

                    case "CellLineL":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点CellLineL", Field = "CellLineL", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "CellLineL", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.CellLineL[cameraIndex - 1].ToString());
                        }
                        break;

                    case "P2byP1X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点P2byP1X", Field = "P2byP1X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "P2byP1X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1X[cameraIndex - 1].ToString());
                        }
                        break;

                    case "P2byP1Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点P2byP1Y", Field = "P2byP1Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "P2byP1Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P2byP1Y[cameraIndex - 1].ToString());
                        }
                        break;

                    case "P4byP3X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点P4byP3X", Field = "P4byP3X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "P4byP3X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3X[cameraIndex - 1].ToString());
                        }
                        break;

                    case "P4byP3Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点P4byP3Y", Field = "P4byP3Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "P4byP3Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.P4byP3Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "LaserStep":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点LaserStep", Field = "LaserStep", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "LaserStep", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserStep[cameraIndex - 1].ToString());
                        }
                        break;
                    case "RobStep":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobStep[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点RobStep", Field = "RobStep", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobStep[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobStep[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "RobStep", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobStep[cameraIndex - 1].ToString());
                        }
                        break;

                    case "Spacing":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点Spacing", Field = "Spacing", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "Spacing", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.Spacing[cameraIndex - 1].ToString());
                        }
                        break;

                    case "SpacingUse":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点SpacingUse", Field = "SpacingUse", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "SpacingUse", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.SpacingUse[cameraIndex - 1].ToString());
                        }
                        break;
                    case "RobUse":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点RobUse", Field = "RobUse", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "RobUse", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.RobUse[cameraIndex - 1].ToString());
                        }
                        break;
                    case "LaserUse":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点LaserUse", Field = "LaserUse", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "LaserUse", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.LaserUse[cameraIndex - 1].ToString());
                        }
                        break;

                    case "ALX":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点ALX", Field = "ALX", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ALX", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX[cameraIndex - 1].ToString());
                        }
                        break;

                    case "ALY":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点ALY", Field = "ALY", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ALY", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY[cameraIndex - 1].ToString());
                        }
                        break;

                    case "NI1X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI1X", Field = "NI1X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI1X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "NI1Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI1Y", Field = "NI1Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI1Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y[cameraIndex - 1].ToString());
                        }
                        break;


                    case "NI2X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI2X", Field = "NI2X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI2X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X[cameraIndex - 1].ToString());
                        }
                        break;

                    case "NI2Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI2Y", Field = "NI2Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI2Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y[cameraIndex - 1].ToString());
                        }
                        break;

                    case "ALX1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点ALX1", Field = "ALX1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ALX1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALX1[cameraIndex - 1].ToString());
                        }
                        break;

                    case "ALY1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点ALY1", Field = "ALY1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "ALY1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.ALY1[cameraIndex - 1].ToString());
                        }
                        break;

                    case "NI1X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI1X1", Field = "NI1X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI1X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "NI1Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI1Y1", Field = "NI1Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI1Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI1Y1[cameraIndex - 1].ToString());
                        }
                        break;


                    case "NI2X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI2X1", Field = "NI2X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI2X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2X1[cameraIndex - 1].ToString());
                        }
                        break;

                    case "NI2Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}激光九点NI2Y1", Field = "NI2Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "NI2Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.NI2Y1[cameraIndex - 1].ToString());
                        }
                        break;

                    case "AddR1J1X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J1X", Field = "AddR1J1X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J1X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J1Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J1Y", Field = "AddR1J1Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J1Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J1Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J1X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J1X", Field = "AddR2J1X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J1X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J1Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J1Y", Field = "AddR2J1Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J1Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J1Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1X1", Field = "AddL1J1X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1X2", Field = "AddL1J1X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1Y1", Field = "AddL1J1Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1Y2", Field = "AddL1J1Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1X3", Field = "AddL1J1X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1Y3", Field = "AddL1J1Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1X4", Field = "AddL1J1X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J1Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J1Y4", Field = "AddL1J1Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J1Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J1Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1X1", Field = "AddL2J1X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1X2", Field = "AddL2J1X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1Y1", Field = "AddL2J1Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1Y2", Field = "AddL2J1Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1X3", Field = "AddL2J1X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1Y3", Field = "AddL2J1Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1X4", Field = "AddL2J1X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J1Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J1Y4", Field = "AddL2J1Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J1Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J1Y4[cameraIndex - 1].ToString());
                        }
                        break;

                    case "AddR1J2X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J2X", Field = "AddR1J2X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J2X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J2Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J2Y", Field = "AddR1J2Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J2Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J2Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J2X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J2X", Field = "AddR2J2X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J2X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J2Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J2Y", Field = "AddR2J2Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J2Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J2Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2X1", Field = "AddL1J2X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2X2", Field = "AddL1J2X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2Y1", Field = "AddL1J2Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2Y2", Field = "AddL1J2Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2X3", Field = "AddL1J2X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2Y3", Field = "AddL1J2Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2X4", Field = "AddL1J2X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J2Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J2Y4", Field = "AddL1J2Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J2Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J2Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2X1", Field = "AddL2J2X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2X2", Field = "AddL2J2X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2Y1", Field = "AddL2J2Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2Y2", Field = "AddL2J2Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2X3", Field = "AddL2J2X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2Y3", Field = "AddL2J2Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2X4", Field = "AddL2J2X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J2Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J2Y4", Field = "AddL2J2Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J2Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J2Y4[cameraIndex - 1].ToString());
                        }
                        break;


                    ///////////////
                    ///
                    case "AddR1J3X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J3X", Field = "AddR1J3X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J3X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J3Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J3Y", Field = "AddR1J3Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J3Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J3Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J3X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J3X", Field = "AddR2J3X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J3X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J3Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J3Y", Field = "AddR2J3Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J3Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J3Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3X1", Field = "AddL1J3X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3X2", Field = "AddL1J3X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3Y1", Field = "AddL1J3Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3Y2", Field = "AddL1J3Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3X3", Field = "AddL1J3X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3Y3", Field = "AddL1J3Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3X4", Field = "AddL1J3X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J3Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J3Y4", Field = "AddL1J3Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J3Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J3Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3X1", Field = "AddL2J3X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3X2", Field = "AddL2J3X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3Y1", Field = "AddL2J3Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3Y2", Field = "AddL2J3Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3X3", Field = "AddL2J3X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3Y3", Field = "AddL2J3Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3X4", Field = "AddL2J3X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J3Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J3Y4", Field = "AddL2J3Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J3Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J3Y4[cameraIndex - 1].ToString());
                        }
                        break;









                    case "AddR1J4X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J4X", Field = "AddR1J4X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J4X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J4Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J4Y", Field = "AddR1J4Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J4Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J4Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J4X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J4X", Field = "AddR2J4X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J4X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J4Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J4Y", Field = "AddR2J4Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J4Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J4Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4X1", Field = "AddL1J4X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4X2", Field = "AddL1J4X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4Y1", Field = "AddL1J4Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4Y2", Field = "AddL1J4Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4X3", Field = "AddL1J4X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4Y3", Field = "AddL1J4Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4X4", Field = "AddL1J4X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J4Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J4Y4", Field = "AddL1J4Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J4Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J4Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4X1", Field = "AddL2J4X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4X2", Field = "AddL2J4X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4Y1", Field = "AddL2J4Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4Y2", Field = "AddL2J4Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4X3", Field = "AddL2J4X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4Y3", Field = "AddL2J4Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4X4", Field = "AddL2J4X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J4Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J4Y4", Field = "AddL2J4Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J4Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J4Y4[cameraIndex - 1].ToString());
                        }
                        break;
















                    case "AddR1J5X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J5X", Field = "AddR1J5X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J5X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J5Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J5Y", Field = "AddR1J5Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J5Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J5Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J5X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J5X", Field = "AddR2J5X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J5X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J5Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J5Y", Field = "AddR2J5Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J5Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J5Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5X1", Field = "AddL1J5X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5X2", Field = "AddL1J5X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5Y1", Field = "AddL1J5Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5Y2", Field = "AddL1J5Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5X3", Field = "AddL1J5X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5Y3", Field = "AddL1J5Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5X4", Field = "AddL1J5X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J5Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J5Y4", Field = "AddL1J5Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J5Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J5Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5X1", Field = "AddL2J5X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5X2", Field = "AddL2J5X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5Y1", Field = "AddL2J5Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5Y2", Field = "AddL2J5Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5X3", Field = "AddL2J5X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5Y3", Field = "AddL2J5Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5X4", Field = "AddL2J5X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J5Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J5Y4", Field = "AddL2J5Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J5Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J5Y4[cameraIndex - 1].ToString());
                        }
                        break;












                    case "AddR1J6X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J6X", Field = "AddR1J6X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J6X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J6Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J6Y", Field = "AddR1J6Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J6Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J6Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J6X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J6X", Field = "AddR2J6X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J6X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J6Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J6Y", Field = "AddR2J6Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J6Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J6Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6X1", Field = "AddL1J6X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6X2", Field = "AddL1J6X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6Y1", Field = "AddL1J6Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6Y2", Field = "AddL1J6Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6X3", Field = "AddL1J6X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6Y3", Field = "AddL1J6Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6X4", Field = "AddL1J6X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J6Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J6Y4", Field = "AddL1J6Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J6Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J6Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6X1", Field = "AddL2J6X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6X2", Field = "AddL2J6X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6Y1", Field = "AddL2J6Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6Y2", Field = "AddL2J6Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6X3", Field = "AddL2J6X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6Y3", Field = "AddL2J6Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6X4", Field = "AddL2J6X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J6Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J6Y4", Field = "AddL2J6Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J6Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J6Y4[cameraIndex - 1].ToString());
                        }
                        break;

















                    case "AddR1J7X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J7X", Field = "AddR1J7X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J7X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J7Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J7Y", Field = "AddR1J7Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J7Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J7Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J7X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J7X", Field = "AddR2J7X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J7X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J7Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J7Y", Field = "AddR2J7Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J7Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J7Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7X1", Field = "AddL1J7X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7X2", Field = "AddL1J7X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7Y1", Field = "AddL1J7Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7Y2", Field = "AddL1J7Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7X3", Field = "AddL1J7X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7Y3", Field = "AddL1J7Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7X4", Field = "AddL1J7X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J7Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J7Y4", Field = "AddL1J7Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J7Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J7Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7X1", Field = "AddL2J7X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7X2", Field = "AddL2J7X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7Y1", Field = "AddL2J7Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7Y2", Field = "AddL2J7Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7X3", Field = "AddL2J7X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7Y3", Field = "AddL2J7Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7X4", Field = "AddL2J7X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J7Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J7Y4", Field = "AddL2J7Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J7Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J7Y4[cameraIndex - 1].ToString());
                        }
                        break;










                    case "AddR1J8X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J8X", Field = "AddR1J8X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J8X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J8Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J8Y", Field = "AddR1J8Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J8Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J8Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J8X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J8X", Field = "AddR2J8X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J8X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J8Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J8Y", Field = "AddR2J8Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J8Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J8Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8X1", Field = "AddL1J8X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8X2", Field = "AddL1J8X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8Y1", Field = "AddL1J8Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8Y2", Field = "AddL1J8Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8X3", Field = "AddL1J8X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8Y3", Field = "AddL1J8Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8X4", Field = "AddL1J8X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J8Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J8Y4", Field = "AddL1J8Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J8Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J8Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8X1", Field = "AddL2J8X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8X2", Field = "AddL2J8X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8Y1", Field = "AddL2J8Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8Y2", Field = "AddL2J8Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8X3", Field = "AddL2J8X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8Y3", Field = "AddL2J8Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8X4", Field = "AddL2J8X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J8Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J8Y4", Field = "AddL2J8Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J8Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J8Y4[cameraIndex - 1].ToString());
                        }
                        break;









                    case "AddR1J9X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J9X", Field = "AddR1J9X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J9X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR1J9Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR1J9Y", Field = "AddR1J9Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR1J9Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR1J9Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J9X":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J9X", Field = "AddR2J9X", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J9X", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9X[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddR2J9Y":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddR2J9Y", Field = "AddR2J9Y", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddR2J9Y", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddR2J9Y[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9X1", Field = "AddL1J9X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9X2", Field = "AddL1J9X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9Y1", Field = "AddL1J9Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9Y2", Field = "AddL1J9Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9X3", Field = "AddL1J9X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9Y3", Field = "AddL1J9Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9X4", Field = "AddL1J9X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL1J9Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL1J9Y4", Field = "AddL1J9Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL1J9Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL1J9Y4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9X1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9X1", Field = "AddL2J9X1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9X1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9X2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9X2", Field = "AddL2J9X2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9X2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9Y1":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9Y1", Field = "AddL2J9Y1", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9Y1", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y1[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9Y2":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9Y2", Field = "AddL2J9Y2", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9Y2", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y2[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9X3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9X3", Field = "AddL2J9X3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9X3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9Y3":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9Y3", Field = "AddL2J9Y3", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9Y3", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y3[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9X4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9X4", Field = "AddL2J9X4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9X4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9X4[cameraIndex - 1].ToString());
                        }
                        break;
                    case "AddL2J9Y4":
                        if (!Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[cameraIndex - 1].ToString().Equals(text))
                        {
                            oldCameraParamObjects.Add(new OperationLogParamModel.OldParam() { Text = $"{productName}camera{cameraIndex}AddL2J9Y4", Field = "AddL2J9Y4", OldValue = Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[cameraIndex - 1].ToString(), NewValue = text });
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[cameraIndex - 1] = double.Parse(text);
                            Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.SaveOneParams($"camera{cameraIndex}", "AddL2J9Y4", Project.Instance.VisionManagerInstance.CameraParamsManagerInstance.CameraParams.AddL2J9Y4[cameraIndex - 1].ToString());
                        }
                        break;





                        #endregion
                }
            }

            #endregion
        }
        private void uiSymbolButtonSave_Click(object sender, EventArgs e)
        {

            if (_validatingDic.Keys.Count == 0)
            {
                System.Windows.MessageBox.Show("相机设置参数暂无修改");

            }
            //若有控件获取过焦点
            List<OperationLogParamModel.OldParam> oldCameraParamObjects = new List<OperationLogParamModel.OldParam>();
            string productName = Project.Instance.GlobalManagerInstance.GlobalParamModel.useProductModel ? Project.Instance.GlobalManagerInstance.GlobalParamModel.curProductModel : "通用产品";
            foreach (string name in _validatingDic.Keys)
            {
                checkAndSave(name, _validatingDic[name], productName, ref oldCameraParamObjects);
            }

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
        private void tb__Validating(object sender, /*CancelEventArgs e*/EventArgs e)
        {
            try
            {

                TextBox uiTb = (TextBox)sender;
                uiTb.Text = uiTb.Text.Trim();
                Label l = (Label)this.Controls.Find("lb_" + uiTb.Name.Substring(3), true)[0];
                TabPage currentTab = GetParentTabPage(l);

                LogHelper.Info(currentTab.Text + l.Text + $"填入参数{uiTb.Text}成功");
                if (string.IsNullOrEmpty(uiTb.Text))
                {
                    System.Windows.MessageBox.Show($"{l.Text}文本框内不能为空！");
                    return;
                }
                if (uiTb.Name == "tb_Cam1RobStep" || uiTb.Name == "tb_Cam1LaserStep")
                {
                    if (Convert.ToDouble(uiTb.Text) > 3)
                    {
                        DialogResult res = System.Windows.Forms.MessageBox.Show($"{l.Text}数值不宜设置过大，目前为{uiTb.Text}，是否使用？", "数值检查", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (res != DialogResult.OK)
                        {
                            uiTb.Text = null;
                            return;
                        }
                    }
                }
                // if (!Regex.IsMatch(uiTb.Text, @"^(([0-9]+\.[0-9]*[1-9][0-9]*)|([0-9]*[1-9][0-9]*\.[0-9]+)|([0-9]*[1-9][0-9]*))$"))   //正浮点数匹配
                //if (!Regex.IsMatch(uiTb.Text, @"^(-?\d+)(\.\d+)?$"))  //浮点数匹配
                //{
                //    e.Cancel = true;
                //    System.Windows.MessageBox.Show($"{l.Text }：{ uiTb.Text}参数格式不正确！");
                //    return;
                //}

                //判断是否已在集合中
                if (_validatingDic.ContainsKey(uiTb.Name))
                {
                    _validatingDic[uiTb.Name] = uiTb.Text;
                }
                else
                {
                    _validatingDic.Add(uiTb.Name, uiTb.Text);
                }

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
            if (Project.Instance.UserInfoManagerInstance.LoginUser.UserRoleName == "工程师")
            {
                if (System.Windows.Forms.MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdX1.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posXRob1.ToString("f3");
                    tb_Cam1StdY1.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posYRob1.ToString("f3");
                    tb_Cam1StdT1.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posRRob1.ToString("f3");

                    //判断是否已在集合中
                    if (_validatingDic.ContainsKey(tb_Cam1StdX1.Name))
                    {
                        _validatingDic[tb_Cam1StdX1.Name] = tb_Cam1StdX1.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdX1.Name, tb_Cam1StdX1.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdY1.Name))
                    {
                        _validatingDic[tb_Cam1StdY1.Name] = tb_Cam1StdY1.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdY1.Name, tb_Cam1StdY1.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdT1.Name))
                    {
                        _validatingDic[tb_Cam1StdT1.Name] = tb_Cam1StdT1.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdT1.Name, tb_Cam1StdT1.Text);
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }

        }
        private void btn_GetStd2_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserInfoManagerInstance.LoginUser.UserRoleName == "工程师")
            {
                if (System.Windows.Forms.MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdX2.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posXRob2.ToString("f3");
                    tb_Cam1StdY2.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posYRob2.ToString("f3");
                    tb_Cam1StdT2.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posRRob2.ToString("f3");

                    //判断是否已在集合中
                    if (_validatingDic.ContainsKey(tb_Cam1StdX2.Name))
                    {
                        _validatingDic[tb_Cam1StdX2.Name] = tb_Cam1StdX2.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdX2.Name, tb_Cam1StdX2.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdY2.Name))
                    {
                        _validatingDic[tb_Cam1StdY2.Name] = tb_Cam1StdY2.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdY2.Name, tb_Cam1StdY2.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdT2.Name))
                    {
                        _validatingDic[tb_Cam1StdT2.Name] = tb_Cam1StdT2.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdT2.Name, tb_Cam1StdT2.Text);
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }
        }

        private void btn_GetStd3_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserInfoManagerInstance.LoginUser.UserRoleName == "工程师")
            {
                if (System.Windows.Forms.MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdX3.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posXLas1.ToString("f3");
                    tb_Cam1StdY3.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posYLas1.ToString("f3");
                    tb_Cam1StdT3.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posRLas1.ToString("f3");

                    //判断是否已在集合中
                    if (_validatingDic.ContainsKey(tb_Cam1StdX3.Name))
                    {
                        _validatingDic[tb_Cam1StdX3.Name] = tb_Cam1StdX3.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdX3.Name, tb_Cam1StdX3.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdY3.Name))
                    {
                        _validatingDic[tb_Cam1StdY3.Name] = tb_Cam1StdY3.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdY3.Name, tb_Cam1StdY3.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdT3.Name))
                    {
                        _validatingDic[tb_Cam1StdT3.Name] = tb_Cam1StdT3.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdT3.Name, tb_Cam1StdT3.Text);
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }

        }

        private void btn_GetStd4_Click(object sender, EventArgs e)
        {
            if (Project.Instance.UserInfoManagerInstance.LoginUser.UserRoleName == "工程师")
            {
                if (System.Windows.Forms.MessageBox.Show("是否确定重新获取基准", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    tb_Cam1StdX4.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posXLas2.ToString("f3");
                    tb_Cam1StdY4.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posYLas2.ToString("f3");
                    tb_Cam1StdT4.Text = Project.Instance.RobotManagerInstance.L_Robot[0].Cam1posRLas2.ToString("f3");

                    //判断是否已在集合中
                    if (_validatingDic.ContainsKey(tb_Cam1StdX4.Name))
                    {
                        _validatingDic[tb_Cam1StdX4.Name] = tb_Cam1StdX4.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdX4.Name, tb_Cam1StdX4.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdY4.Name))
                    {
                        _validatingDic[tb_Cam1StdY4.Name] = tb_Cam1StdY4.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdY4.Name, tb_Cam1StdY4.Text);
                    }

                    if (_validatingDic.ContainsKey(tb_Cam1StdT4.Name))
                    {
                        _validatingDic[tb_Cam1StdT4.Name] = tb_Cam1StdT4.Text;
                    }
                    else
                    {
                        _validatingDic.Add(tb_Cam1StdT4.Name, tb_Cam1StdT4.Text);
                    }
                }
            }
            else
            {
                System.Windows.MessageBox.Show("工程师才可修改基准");
            }

        }

        private void tb_Cam1AddL1J1X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J1X2.Text = (Convert.ToDouble(tb_Cam1AddL1J1X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();
        }

        private void tb_Cam1AddL1J1Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J1Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J1Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();
        }

        private void tb_Cam1AddL2J1X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J1X2.Text = (Convert.ToDouble(tb_Cam1AddL2J1X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();
        }

        private void tb_Cam1AddL2J1Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J1Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J1Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J1X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J1X4.Text = (Convert.ToDouble(tb_Cam1AddL1J1X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J1Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J1Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J1Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J1X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J1X4.Text = (Convert.ToDouble(tb_Cam1AddL2J1X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J1Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J1Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J1Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J2X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J2X2.Text = (Convert.ToDouble(tb_Cam1AddL1J2X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J2Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J2Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J2Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J2X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J2X2.Text = (Convert.ToDouble(tb_Cam1AddL2J2X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J2Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J2Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J2Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J2X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J2X4.Text = (Convert.ToDouble(tb_Cam1AddL1J2X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J2Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J2Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J2Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J2X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J2X4.Text = (Convert.ToDouble(tb_Cam1AddL2J2X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J2Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J2Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J2Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J3X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J3X2.Text = (Convert.ToDouble(tb_Cam1AddL1J3X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J3Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J3Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J3Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J3X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J3X2.Text = (Convert.ToDouble(tb_Cam1AddL2J3X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J3Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J3Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J3Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J3X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J3X4.Text = (Convert.ToDouble(tb_Cam1AddL1J3X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J3Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J3Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J3Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J3X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J3X4.Text = (Convert.ToDouble(tb_Cam1AddL2J3X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J3Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J3Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J3Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J4X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J4X2.Text = (Convert.ToDouble(tb_Cam1AddL1J4X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J4Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J4Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J4Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J4X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J4X2.Text = (Convert.ToDouble(tb_Cam1AddL2J4X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J4Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J4Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J4Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J4X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J4X4.Text = (Convert.ToDouble(tb_Cam1AddL1J4X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J4Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J4Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J4Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J4X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J4X4.Text = (Convert.ToDouble(tb_Cam1AddL2J4X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J4Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J4Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J4Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J5X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J5X2.Text = (Convert.ToDouble(tb_Cam1AddL1J5X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J5Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J5Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J5Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J5X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J5X2.Text = (Convert.ToDouble(tb_Cam1AddL2J5X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J5Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J5Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J5Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J5X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J5X4.Text = (Convert.ToDouble(tb_Cam1AddL1J5X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J5Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J5Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J5Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J5X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J5X4.Text = (Convert.ToDouble(tb_Cam1AddL2J5X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J5Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J5Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J5Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J6X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J6X2.Text = (Convert.ToDouble(tb_Cam1AddL1J6X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J6Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J6Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J6Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J6X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J6X2.Text = (Convert.ToDouble(tb_Cam1AddL2J6X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J6Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J6Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J6Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J6X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J6X4.Text = (Convert.ToDouble(tb_Cam1AddL1J6X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J6Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J6Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J6Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J6X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J6X4.Text = (Convert.ToDouble(tb_Cam1AddL2J6X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J6Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J6Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J6Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J7X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J7X2.Text = (Convert.ToDouble(tb_Cam1AddL1J7X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J7Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J7Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J7Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J7X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J7X2.Text = (Convert.ToDouble(tb_Cam1AddL2J7X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J7Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J7Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J7Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J7X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J7X4.Text = (Convert.ToDouble(tb_Cam1AddL1J7X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J7Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J7Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J7Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J7X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J7X4.Text = (Convert.ToDouble(tb_Cam1AddL2J7X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J7Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J7Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J7Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J8X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J8X2.Text = (Convert.ToDouble(tb_Cam1AddL1J8X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J8Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J8Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J8Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J8X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J8X2.Text = (Convert.ToDouble(tb_Cam1AddL2J8X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J8Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J8Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J8Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J8X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J8X4.Text = (Convert.ToDouble(tb_Cam1AddL1J8X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J8Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J8Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J8Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J8X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J8X4.Text = (Convert.ToDouble(tb_Cam1AddL2J8X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J8Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J8Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J8Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J9X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J9X2.Text = (Convert.ToDouble(tb_Cam1AddL1J9X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL1J9Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J9Y2.Text = (Convert.ToDouble(tb_Cam1AddL1J9Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J9X1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J9X2.Text = (Convert.ToDouble(tb_Cam1AddL2J9X1.Text) + Convert.ToDouble(tb_Cam1P2byP1X.Text)).ToString();

        }

        private void tb_Cam1AddL2J9Y1_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J9Y2.Text = (Convert.ToDouble(tb_Cam1AddL2J9Y1.Text) + Convert.ToDouble(tb_Cam1P2byP1Y.Text)).ToString();

        }

        private void tb_Cam1AddL1J9X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J9X4.Text = (Convert.ToDouble(tb_Cam1AddL1J9X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL1J9Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL1J9Y4.Text = (Convert.ToDouble(tb_Cam1AddL1J9Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

        }

        private void tb_Cam1AddL2J9X3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J9X4.Text = (Convert.ToDouble(tb_Cam1AddL2J9X3.Text) + Convert.ToDouble(tb_Cam1P4byP3X.Text)).ToString();

        }

        private void tb_Cam1AddL2J9Y3_TextChanged(object sender, EventArgs e)
        {
            tb_Cam1AddL2J9Y4.Text = (Convert.ToDouble(tb_Cam1AddL2J9Y3.Text) + Convert.ToDouble(tb_Cam1P4byP3Y.Text)).ToString();

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
