using System.Windows.Forms;

namespace VisionProgram.UI.UIVision
{
    partial class FrmCameraParamsSettings:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.uiTabControlAll = new System.Windows.Forms.TabControl();
            this.uiTabPage1 = new System.Windows.Forms.TabPage();
            this.uiTableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Cam1StdT1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdT1 = new System.Windows.Forms.Label();
            this.tb_Cam1StdY1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdY1 = new System.Windows.Forms.Label();
            this.lb_Cam1StdX1 = new System.Windows.Forms.Label();
            this.tb_Cam1StdX1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdX2 = new System.Windows.Forms.Label();
            this.lb_Cam1StdY2 = new System.Windows.Forms.Label();
            this.lb_Cam1StdT2 = new System.Windows.Forms.Label();
            this.tb_Cam1StdX2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdY2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdT2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddX1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddY1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddT1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddX2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddY2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddX1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddY1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddT1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddT2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddY2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddX2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdX3 = new System.Windows.Forms.Label();
            this.lb_Cam1StdY3 = new System.Windows.Forms.Label();
            this.lb_Cam1StdT3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddX3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddY3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddT3 = new System.Windows.Forms.Label();
            this.lb_Cam1StdX4 = new System.Windows.Forms.Label();
            this.lb_Cam1StdY4 = new System.Windows.Forms.Label();
            this.lb_Cam1StdT4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddX4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddY4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddT4 = new System.Windows.Forms.Label();
            this.tb_Cam1StdX3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdY3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdT3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddX3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddY3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddT3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdX4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdY4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdT4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddX4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddY4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddT4 = new System.Windows.Forms.TextBox();
            this.btn_GetStd1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_Cam1AddT2 = new System.Windows.Forms.Label();
            this.lb_Cam1Exprosure = new System.Windows.Forms.Label();
            this.tb_Cam1Exprosure = new System.Windows.Forms.TextBox();
            this.tb_Cam1L1CalibX0 = new System.Windows.Forms.TextBox();
            this.tb_Cam1L1CalibY0 = new System.Windows.Forms.TextBox();
            this.tb_Cam1L2CalibX0 = new System.Windows.Forms.TextBox();
            this.tb_Cam1L2CalibY0 = new System.Windows.Forms.TextBox();
            this.lb_Cam1L1CalibX0 = new System.Windows.Forms.Label();
            this.lb_Cam1L1CalibY0 = new System.Windows.Forms.Label();
            this.lb_Cam1L2CalibX0 = new System.Windows.Forms.Label();
            this.lb_Cam1L2CalibY0 = new System.Windows.Forms.Label();
            this.lb_Cam1Limitmax = new System.Windows.Forms.Label();
            this.lb_Cam1Limitmin = new System.Windows.Forms.Label();
            this.lb_Cam1Anglemin = new System.Windows.Forms.Label();
            this.lb_Cam1Anglemax = new System.Windows.Forms.Label();
            this.tb_Cam1Limitmin = new System.Windows.Forms.TextBox();
            this.tb_Cam1Limitmax = new System.Windows.Forms.TextBox();
            this.tb_Cam1Anglemin = new System.Windows.Forms.TextBox();
            this.tb_Cam1Anglemax = new System.Windows.Forms.TextBox();
            this.lb_Cam1CellLineL = new System.Windows.Forms.Label();
            this.tb_Cam1CellLineL = new System.Windows.Forms.TextBox();
            this.lb_Cam1OffsetX = new System.Windows.Forms.Label();
            this.tb_Cam1OffsetX = new System.Windows.Forms.TextBox();
            this.lb_Cam1LaserStep = new System.Windows.Forms.Label();
            this.tb_Cam1LaserStep = new System.Windows.Forms.TextBox();
            this.tb_Cam1RobStep = new System.Windows.Forms.TextBox();
            this.lb_Cam1RobStep = new System.Windows.Forms.Label();
            this.lb_Cam1P4byP3Y = new System.Windows.Forms.Label();
            this.tb_Cam1P4byP3Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1P4byP3X = new System.Windows.Forms.Label();
            this.tb_Cam1P4byP3X = new System.Windows.Forms.TextBox();
            this.lb_Cam1P2byP1Y = new System.Windows.Forms.Label();
            this.tb_Cam1P2byP1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1P2byP1X = new System.Windows.Forms.Label();
            this.tb_Cam1P2byP1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Spacing = new System.Windows.Forms.Label();
            this.lb_Cam1SpacingUse = new System.Windows.Forms.Label();
            this.lb_Cam1RobUse = new System.Windows.Forms.Label();
            this.lb_Cam1LaserUse = new System.Windows.Forms.Label();
            this.tb_Cam1Spacing = new System.Windows.Forms.TextBox();
            this.tb_Cam1SpacingUse = new System.Windows.Forms.TextBox();
            this.tb_Cam1RobUse = new System.Windows.Forms.TextBox();
            this.tb_Cam1LaserUse = new System.Windows.Forms.TextBox();
            this.lb_Cam1ALX = new System.Windows.Forms.Label();
            this.lb_Cam1NI1X = new System.Windows.Forms.Label();
            this.lb_Cam1NI2X = new System.Windows.Forms.Label();
            this.lb_Cam1ALY = new System.Windows.Forms.Label();
            this.lb_Cam1NI1Y = new System.Windows.Forms.Label();
            this.lb_Cam1NI2Y = new System.Windows.Forms.Label();
            this.tb_Cam1ALX = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI1X = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI2X = new System.Windows.Forms.TextBox();
            this.tb_Cam1ALY = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI2Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1ALX1 = new System.Windows.Forms.Label();
            this.lb_Cam1ALY1 = new System.Windows.Forms.Label();
            this.lb_Cam1NI1X1 = new System.Windows.Forms.Label();
            this.lb_Cam1NI1Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1NI2X1 = new System.Windows.Forms.Label();
            this.lb_Cam1NI2Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1ALX1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1ALY1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI1X1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI1Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI2X1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1NI2Y1 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J1Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR2J1X = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J1Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J1X = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J1X = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J1Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J1X1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1X1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J1Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J1X1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J1Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J1X2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J1Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J1X2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J1Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J1X3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J1Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J1X3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J1Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J1X4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J1X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J1Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J1X4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J1X4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J2Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR2J2X = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J2Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J2X = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J2X = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J2Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J2X1 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2X1 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J2Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J2X1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J2Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J2X2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J2Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J2X2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J2Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J2X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J2Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J2X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J2Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J2Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J2Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J2X4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J2X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J2Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J2X4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J2X4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J3Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR2J3X = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J3Y = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J3X = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J3Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J3X = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J3Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J3X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J3Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J3X1 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3X1 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J3Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J3X1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J3Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J3X2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J3Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J3X2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J3Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J3X3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J3Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J3X3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J3Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J3X4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J3X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J3Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J3X4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J3X4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J4Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J4Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J4X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J4X = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J4Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J4Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J4X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J4X = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J4Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J4X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4X1 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J4Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J4X1 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J4Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J4X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J4X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J4X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J4Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J4X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J4Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J4X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J4Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J4X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J4Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J4X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J4Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J4X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J4Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J4X4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J5Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J5Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J5X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J5X = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J5Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J5Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J5X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J5X = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J5Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J5X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5X1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J5Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J5X1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J5Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J5X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J5X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J5X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J5Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J5X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J5Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J5X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J5Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J5X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J5Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J5X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J5Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J5X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J5Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J5X4 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J6Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J6Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J6X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J6X = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J6Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J6Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J6X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J6X = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J6Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J6X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6X1 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J6Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J6X1 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J6Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J6X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J6X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J6X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J6Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J6X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J6Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J6X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J6Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J6X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J6Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J6X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J6Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J6X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J6Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J6X4 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J7Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J7Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J7X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J7X = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J7Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J7Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J7X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J7X = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J7Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J7X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7X1 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J7Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J7X1 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J7Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J7X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J7X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J7X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J7Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J7X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J7Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J7X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J7Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J7X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J7Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J7X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J7Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J7X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J7Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J7X4 = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J8Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J8Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J8X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J8X = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J8Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J8Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J8X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J8X = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J8Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J8X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8X1 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J8Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J8X1 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J8Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J8X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J8X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J8X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J8Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J8X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J8Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J8X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J8Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J8X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J8Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J8X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J8Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J8X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J8Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J8X4 = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Cam1AddR2J9Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR2J9Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR2J9X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR2J9X = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.lb_Cam1AddR1J9Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddR1J9Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddR1J9X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddR1J9X = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL2J9Y1 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL2J9X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9X1 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J9Y1 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J9X1 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J9Y1 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J9X1 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9Y2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9Y2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9Y3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9Y3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9Y4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9Y4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL2J9X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL2J9X4 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J9Y2 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J9X2 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J9Y2 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J9X2 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J9Y3 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J9X3 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J9Y3 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J9X3 = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddL1J9Y4 = new System.Windows.Forms.Label();
            this.lb_Cam1AddL1J9X4 = new System.Windows.Forms.Label();
            this.tb_Cam1AddL1J9Y4 = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddL1J9X4 = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.uiSymbolButtonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.uiTabControlAll.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 650);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiTabControlAll);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uiSymbolButtonSave);
            this.splitContainer1.Size = new System.Drawing.Size(1308, 650);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 11;
            // 
            // uiTabControlAll
            // 
            this.uiTabControlAll.Controls.Add(this.uiTabPage1);
            this.uiTabControlAll.Controls.Add(this.tabPage1);
            this.uiTabControlAll.Controls.Add(this.tabPage2);
            this.uiTabControlAll.Controls.Add(this.tabPage3);
            this.uiTabControlAll.Controls.Add(this.tabPage4);
            this.uiTabControlAll.Controls.Add(this.tabPage5);
            this.uiTabControlAll.Controls.Add(this.tabPage6);
            this.uiTabControlAll.Controls.Add(this.tabPage7);
            this.uiTabControlAll.Controls.Add(this.tabPage8);
            this.uiTabControlAll.Controls.Add(this.tabPage9);
            this.uiTabControlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControlAll.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControlAll.ItemSize = new System.Drawing.Size(120, 40);
            this.uiTabControlAll.Location = new System.Drawing.Point(0, 0);
            this.uiTabControlAll.Margin = new System.Windows.Forms.Padding(0);
            this.uiTabControlAll.Name = "uiTabControlAll";
            this.uiTabControlAll.Padding = new System.Drawing.Point(0, 0);
            this.uiTabControlAll.SelectedIndex = 0;
            this.uiTabControlAll.Size = new System.Drawing.Size(1308, 600);
            this.uiTabControlAll.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlAll.TabIndex = 9;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.uiTabPage1.Controls.Add(this.uiTableLayoutPanel1);
            this.uiTabPage1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.uiTabPage1.Location = new System.Drawing.Point(4, 44);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1300, 552);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "相机1";
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.uiTableLayoutPanel1.ColumnCount = 14;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143266F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.143265F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140408F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140408F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdT1, 1, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdT1, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdY1, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdY1, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdX1, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdX1, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdX2, 2, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdY2, 2, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdT2, 2, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdX2, 3, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdY2, 3, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdT2, 3, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddX1, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddY1, 0, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddT1, 0, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddX2, 2, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddY2, 2, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddX1, 1, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddY1, 1, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddT1, 1, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddT2, 3, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddY2, 3, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddX2, 3, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdX3, 4, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdY3, 4, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdT3, 4, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddX3, 4, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddY3, 4, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddT3, 4, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdX4, 6, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdY4, 6, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdT4, 6, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddX4, 6, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddY4, 6, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddT4, 6, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdX3, 5, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdY3, 5, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdT3, 5, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddX3, 5, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddY3, 5, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddT3, 5, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdX4, 7, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdY4, 7, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdT4, 7, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddX4, 7, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddY4, 7, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddT4, 7, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_GetStd1, 1, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.button1, 3, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.button2, 5, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.button3, 7, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddT2, 2, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Exprosure, 0, 11);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Exprosure, 1, 11);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1L1CalibX0, 11, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1L1CalibY0, 11, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1L2CalibX0, 11, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1L2CalibY0, 11, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1L1CalibX0, 10, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1L1CalibY0, 10, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1L2CalibX0, 10, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1L2CalibY0, 10, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Limitmax, 8, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Limitmin, 8, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Anglemin, 8, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Anglemax, 8, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Limitmin, 9, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Limitmax, 9, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Anglemin, 9, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Anglemax, 9, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1CellLineL, 12, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1CellLineL, 13, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1OffsetX, 12, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1OffsetX, 13, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LaserStep, 10, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LaserStep, 11, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1RobStep, 11, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1RobStep, 10, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P4byP3Y, 12, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P4byP3Y, 13, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P4byP3X, 12, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P4byP3X, 13, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P2byP1Y, 12, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P2byP1Y, 13, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P2byP1X, 12, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P2byP1X, 13, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Spacing, 12, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1SpacingUse, 12, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1RobUse, 12, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LaserUse, 12, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Spacing, 13, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1SpacingUse, 13, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1RobUse, 13, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LaserUse, 13, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1ALX, 0, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI1X, 2, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI2X, 4, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1ALY, 0, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI1Y, 2, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI2Y, 4, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1ALX, 1, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI1X, 3, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI2X, 5, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1ALY, 1, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI1Y, 3, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI2Y, 5, 8);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1ALX1, 0, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1ALY1, 0, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI1X1, 2, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI1Y1, 2, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI2X1, 4, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1NI2Y1, 4, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1ALX1, 1, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1ALY1, 1, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI1X1, 3, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI1Y1, 3, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI2X1, 5, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1NI2Y1, 5, 10);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 12;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1300, 552);
            this.uiTableLayoutPanel1.TabIndex = 2;
            // 
            // tb_Cam1StdT1
            // 
            this.tb_Cam1StdT1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdT1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdT1.Location = new System.Drawing.Point(96, 97);
            this.tb_Cam1StdT1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdT1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdT1.Name = "tb_Cam1StdT1";
            this.tb_Cam1StdT1.ReadOnly = true;
            this.tb_Cam1StdT1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdT1.TabIndex = 8;
            // 
            // lb_Cam1StdT1
            // 
            this.lb_Cam1StdT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdT1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdT1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdT1.Location = new System.Drawing.Point(3, 92);
            this.lb_Cam1StdT1.Name = "lb_Cam1StdT1";
            this.lb_Cam1StdT1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdT1.TabIndex = 7;
            this.lb_Cam1StdT1.Text = "机械手1基准R";
            this.lb_Cam1StdT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdY1
            // 
            this.tb_Cam1StdY1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdY1.Location = new System.Drawing.Point(96, 51);
            this.tb_Cam1StdY1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdY1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdY1.Name = "tb_Cam1StdY1";
            this.tb_Cam1StdY1.ReadOnly = true;
            this.tb_Cam1StdY1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdY1.TabIndex = 5;
            // 
            // lb_Cam1StdY1
            // 
            this.lb_Cam1StdY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdY1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdY1.Location = new System.Drawing.Point(3, 46);
            this.lb_Cam1StdY1.Name = "lb_Cam1StdY1";
            this.lb_Cam1StdY1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdY1.TabIndex = 4;
            this.lb_Cam1StdY1.Text = "机械手1基准Y";
            this.lb_Cam1StdY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdX1
            // 
            this.lb_Cam1StdX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdX1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdX1.Location = new System.Drawing.Point(3, 0);
            this.lb_Cam1StdX1.Name = "lb_Cam1StdX1";
            this.lb_Cam1StdX1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdX1.TabIndex = 1;
            this.lb_Cam1StdX1.Text = "机械手1基准X";
            this.lb_Cam1StdX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdX1
            // 
            this.tb_Cam1StdX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdX1.Location = new System.Drawing.Point(96, 5);
            this.tb_Cam1StdX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdX1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdX1.Name = "tb_Cam1StdX1";
            this.tb_Cam1StdX1.ReadOnly = true;
            this.tb_Cam1StdX1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdX1.TabIndex = 2;
            // 
            // lb_Cam1StdX2
            // 
            this.lb_Cam1StdX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdX2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdX2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdX2.Location = new System.Drawing.Point(187, 0);
            this.lb_Cam1StdX2.Name = "lb_Cam1StdX2";
            this.lb_Cam1StdX2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdX2.TabIndex = 23;
            this.lb_Cam1StdX2.Text = "机械手2基准X";
            this.lb_Cam1StdX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdY2
            // 
            this.lb_Cam1StdY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdY2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdY2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdY2.Location = new System.Drawing.Point(187, 46);
            this.lb_Cam1StdY2.Name = "lb_Cam1StdY2";
            this.lb_Cam1StdY2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdY2.TabIndex = 23;
            this.lb_Cam1StdY2.Text = "机械手2基准Y";
            this.lb_Cam1StdY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdT2
            // 
            this.lb_Cam1StdT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdT2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdT2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdT2.Location = new System.Drawing.Point(187, 92);
            this.lb_Cam1StdT2.Name = "lb_Cam1StdT2";
            this.lb_Cam1StdT2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdT2.TabIndex = 23;
            this.lb_Cam1StdT2.Text = "机械手2基准R";
            this.lb_Cam1StdT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdX2
            // 
            this.tb_Cam1StdX2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdX2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdX2.Location = new System.Drawing.Point(280, 5);
            this.tb_Cam1StdX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdX2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdX2.Name = "tb_Cam1StdX2";
            this.tb_Cam1StdX2.ReadOnly = true;
            this.tb_Cam1StdX2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdX2.TabIndex = 2;
            // 
            // tb_Cam1StdY2
            // 
            this.tb_Cam1StdY2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdY2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdY2.Location = new System.Drawing.Point(280, 51);
            this.tb_Cam1StdY2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdY2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdY2.Name = "tb_Cam1StdY2";
            this.tb_Cam1StdY2.ReadOnly = true;
            this.tb_Cam1StdY2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdY2.TabIndex = 2;
            // 
            // tb_Cam1StdT2
            // 
            this.tb_Cam1StdT2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdT2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdT2.Location = new System.Drawing.Point(280, 97);
            this.tb_Cam1StdT2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdT2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdT2.Name = "tb_Cam1StdT2";
            this.tb_Cam1StdT2.ReadOnly = true;
            this.tb_Cam1StdT2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdT2.TabIndex = 2;
            // 
            // lb_Cam1AddX1
            // 
            this.lb_Cam1AddX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddX1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddX1.Location = new System.Drawing.Point(3, 138);
            this.lb_Cam1AddX1.Name = "lb_Cam1AddX1";
            this.lb_Cam1AddX1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddX1.TabIndex = 1;
            this.lb_Cam1AddX1.Text = "机械手1补偿X";
            this.lb_Cam1AddX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddY1
            // 
            this.lb_Cam1AddY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddY1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddY1.Location = new System.Drawing.Point(3, 184);
            this.lb_Cam1AddY1.Name = "lb_Cam1AddY1";
            this.lb_Cam1AddY1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddY1.TabIndex = 1;
            this.lb_Cam1AddY1.Text = "机械手1补偿Y";
            this.lb_Cam1AddY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddT1
            // 
            this.lb_Cam1AddT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddT1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddT1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddT1.Location = new System.Drawing.Point(3, 230);
            this.lb_Cam1AddT1.Name = "lb_Cam1AddT1";
            this.lb_Cam1AddT1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddT1.TabIndex = 1;
            this.lb_Cam1AddT1.Text = "机械手1补偿R";
            this.lb_Cam1AddT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddX2
            // 
            this.lb_Cam1AddX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddX2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddX2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddX2.Location = new System.Drawing.Point(187, 138);
            this.lb_Cam1AddX2.Name = "lb_Cam1AddX2";
            this.lb_Cam1AddX2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddX2.TabIndex = 1;
            this.lb_Cam1AddX2.Text = "机械手2补偿X";
            this.lb_Cam1AddX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddY2
            // 
            this.lb_Cam1AddY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddY2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddY2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddY2.Location = new System.Drawing.Point(187, 184);
            this.lb_Cam1AddY2.Name = "lb_Cam1AddY2";
            this.lb_Cam1AddY2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddY2.TabIndex = 1;
            this.lb_Cam1AddY2.Text = "机械手2补偿Y";
            this.lb_Cam1AddY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddX1
            // 
            this.tb_Cam1AddX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddX1.Location = new System.Drawing.Point(96, 143);
            this.tb_Cam1AddX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddX1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddX1.Name = "tb_Cam1AddX1";
            this.tb_Cam1AddX1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddX1.TabIndex = 2;
            // 
            // tb_Cam1AddY1
            // 
            this.tb_Cam1AddY1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddY1.Location = new System.Drawing.Point(96, 189);
            this.tb_Cam1AddY1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddY1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddY1.Name = "tb_Cam1AddY1";
            this.tb_Cam1AddY1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddY1.TabIndex = 2;
            // 
            // tb_Cam1AddT1
            // 
            this.tb_Cam1AddT1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddT1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddT1.Location = new System.Drawing.Point(96, 235);
            this.tb_Cam1AddT1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddT1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddT1.Name = "tb_Cam1AddT1";
            this.tb_Cam1AddT1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddT1.TabIndex = 2;
            // 
            // tb_Cam1AddT2
            // 
            this.tb_Cam1AddT2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddT2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddT2.Location = new System.Drawing.Point(280, 235);
            this.tb_Cam1AddT2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddT2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddT2.Name = "tb_Cam1AddT2";
            this.tb_Cam1AddT2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddT2.TabIndex = 2;
            // 
            // tb_Cam1AddY2
            // 
            this.tb_Cam1AddY2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddY2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddY2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddY2.Location = new System.Drawing.Point(280, 189);
            this.tb_Cam1AddY2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddY2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddY2.Name = "tb_Cam1AddY2";
            this.tb_Cam1AddY2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddY2.TabIndex = 2;
            // 
            // tb_Cam1AddX2
            // 
            this.tb_Cam1AddX2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddX2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddX2.Location = new System.Drawing.Point(280, 143);
            this.tb_Cam1AddX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddX2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddX2.Name = "tb_Cam1AddX2";
            this.tb_Cam1AddX2.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddX2.TabIndex = 2;
            // 
            // lb_Cam1StdX3
            // 
            this.lb_Cam1StdX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdX3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdX3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdX3.Location = new System.Drawing.Point(371, 0);
            this.lb_Cam1StdX3.Name = "lb_Cam1StdX3";
            this.lb_Cam1StdX3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdX3.TabIndex = 26;
            this.lb_Cam1StdX3.Text = "激光1基准X";
            this.lb_Cam1StdX3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdY3
            // 
            this.lb_Cam1StdY3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdY3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdY3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdY3.Location = new System.Drawing.Point(371, 46);
            this.lb_Cam1StdY3.Name = "lb_Cam1StdY3";
            this.lb_Cam1StdY3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdY3.TabIndex = 25;
            this.lb_Cam1StdY3.Text = "激光1基准Y";
            this.lb_Cam1StdY3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdT3
            // 
            this.lb_Cam1StdT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdT3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdT3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdT3.Location = new System.Drawing.Point(371, 92);
            this.lb_Cam1StdT3.Name = "lb_Cam1StdT3";
            this.lb_Cam1StdT3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdT3.TabIndex = 29;
            this.lb_Cam1StdT3.Text = "激光1基准R";
            this.lb_Cam1StdT3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddX3
            // 
            this.lb_Cam1AddX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddX3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddX3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddX3.Location = new System.Drawing.Point(371, 138);
            this.lb_Cam1AddX3.Name = "lb_Cam1AddX3";
            this.lb_Cam1AddX3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddX3.TabIndex = 28;
            this.lb_Cam1AddX3.Text = "激光1补偿X";
            this.lb_Cam1AddX3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddY3
            // 
            this.lb_Cam1AddY3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddY3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddY3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddY3.Location = new System.Drawing.Point(371, 184);
            this.lb_Cam1AddY3.Name = "lb_Cam1AddY3";
            this.lb_Cam1AddY3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddY3.TabIndex = 27;
            this.lb_Cam1AddY3.Text = "激光1补偿Y";
            this.lb_Cam1AddY3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddT3
            // 
            this.lb_Cam1AddT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddT3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddT3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddT3.Location = new System.Drawing.Point(371, 230);
            this.lb_Cam1AddT3.Name = "lb_Cam1AddT3";
            this.lb_Cam1AddT3.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddT3.TabIndex = 30;
            this.lb_Cam1AddT3.Text = "激光1补偿R";
            this.lb_Cam1AddT3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdX4
            // 
            this.lb_Cam1StdX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdX4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdX4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdX4.Location = new System.Drawing.Point(555, 0);
            this.lb_Cam1StdX4.Name = "lb_Cam1StdX4";
            this.lb_Cam1StdX4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdX4.TabIndex = 33;
            this.lb_Cam1StdX4.Text = "激光2基准X";
            this.lb_Cam1StdX4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdY4
            // 
            this.lb_Cam1StdY4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdY4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdY4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdY4.Location = new System.Drawing.Point(555, 46);
            this.lb_Cam1StdY4.Name = "lb_Cam1StdY4";
            this.lb_Cam1StdY4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdY4.TabIndex = 34;
            this.lb_Cam1StdY4.Text = "激光2基准Y";
            this.lb_Cam1StdY4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdT4
            // 
            this.lb_Cam1StdT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdT4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdT4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdT4.Location = new System.Drawing.Point(555, 92);
            this.lb_Cam1StdT4.Name = "lb_Cam1StdT4";
            this.lb_Cam1StdT4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdT4.TabIndex = 32;
            this.lb_Cam1StdT4.Text = "激光2基准R";
            this.lb_Cam1StdT4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddX4
            // 
            this.lb_Cam1AddX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddX4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddX4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddX4.Location = new System.Drawing.Point(555, 138);
            this.lb_Cam1AddX4.Name = "lb_Cam1AddX4";
            this.lb_Cam1AddX4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddX4.TabIndex = 31;
            this.lb_Cam1AddX4.Text = "激光2补偿X";
            this.lb_Cam1AddX4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddY4
            // 
            this.lb_Cam1AddY4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddY4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddY4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddY4.Location = new System.Drawing.Point(555, 184);
            this.lb_Cam1AddY4.Name = "lb_Cam1AddY4";
            this.lb_Cam1AddY4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddY4.TabIndex = 35;
            this.lb_Cam1AddY4.Text = "激光2补偿Y";
            this.lb_Cam1AddY4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddT4
            // 
            this.lb_Cam1AddT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddT4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddT4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddT4.Location = new System.Drawing.Point(555, 230);
            this.lb_Cam1AddT4.Name = "lb_Cam1AddT4";
            this.lb_Cam1AddT4.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddT4.TabIndex = 36;
            this.lb_Cam1AddT4.Text = "激光2补偿R";
            this.lb_Cam1AddT4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdX3
            // 
            this.tb_Cam1StdX3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdX3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdX3.Location = new System.Drawing.Point(464, 5);
            this.tb_Cam1StdX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdX3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdX3.Name = "tb_Cam1StdX3";
            this.tb_Cam1StdX3.ReadOnly = true;
            this.tb_Cam1StdX3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdX3.TabIndex = 40;
            // 
            // tb_Cam1StdY3
            // 
            this.tb_Cam1StdY3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdY3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdY3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdY3.Location = new System.Drawing.Point(464, 51);
            this.tb_Cam1StdY3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdY3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdY3.Name = "tb_Cam1StdY3";
            this.tb_Cam1StdY3.ReadOnly = true;
            this.tb_Cam1StdY3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdY3.TabIndex = 41;
            // 
            // tb_Cam1StdT3
            // 
            this.tb_Cam1StdT3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdT3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdT3.Location = new System.Drawing.Point(464, 97);
            this.tb_Cam1StdT3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdT3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdT3.Name = "tb_Cam1StdT3";
            this.tb_Cam1StdT3.ReadOnly = true;
            this.tb_Cam1StdT3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdT3.TabIndex = 42;
            // 
            // tb_Cam1AddX3
            // 
            this.tb_Cam1AddX3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddX3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddX3.Location = new System.Drawing.Point(464, 143);
            this.tb_Cam1AddX3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddX3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddX3.Name = "tb_Cam1AddX3";
            this.tb_Cam1AddX3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddX3.TabIndex = 39;
            // 
            // tb_Cam1AddY3
            // 
            this.tb_Cam1AddY3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddY3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddY3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddY3.Location = new System.Drawing.Point(464, 189);
            this.tb_Cam1AddY3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddY3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddY3.Name = "tb_Cam1AddY3";
            this.tb_Cam1AddY3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddY3.TabIndex = 38;
            // 
            // tb_Cam1AddT3
            // 
            this.tb_Cam1AddT3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddT3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddT3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddT3.Location = new System.Drawing.Point(464, 235);
            this.tb_Cam1AddT3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddT3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddT3.Name = "tb_Cam1AddT3";
            this.tb_Cam1AddT3.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddT3.TabIndex = 37;
            // 
            // tb_Cam1StdX4
            // 
            this.tb_Cam1StdX4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdX4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdX4.Location = new System.Drawing.Point(648, 5);
            this.tb_Cam1StdX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdX4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdX4.Name = "tb_Cam1StdX4";
            this.tb_Cam1StdX4.ReadOnly = true;
            this.tb_Cam1StdX4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdX4.TabIndex = 46;
            // 
            // tb_Cam1StdY4
            // 
            this.tb_Cam1StdY4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdY4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdY4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdY4.Location = new System.Drawing.Point(648, 51);
            this.tb_Cam1StdY4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdY4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdY4.Name = "tb_Cam1StdY4";
            this.tb_Cam1StdY4.ReadOnly = true;
            this.tb_Cam1StdY4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdY4.TabIndex = 47;
            // 
            // tb_Cam1StdT4
            // 
            this.tb_Cam1StdT4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdT4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdT4.Location = new System.Drawing.Point(648, 97);
            this.tb_Cam1StdT4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1StdT4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdT4.Name = "tb_Cam1StdT4";
            this.tb_Cam1StdT4.ReadOnly = true;
            this.tb_Cam1StdT4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdT4.TabIndex = 48;
            // 
            // tb_Cam1AddX4
            // 
            this.tb_Cam1AddX4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddX4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddX4.Location = new System.Drawing.Point(648, 143);
            this.tb_Cam1AddX4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddX4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddX4.Name = "tb_Cam1AddX4";
            this.tb_Cam1AddX4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddX4.TabIndex = 45;
            // 
            // tb_Cam1AddY4
            // 
            this.tb_Cam1AddY4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddY4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddY4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddY4.Location = new System.Drawing.Point(648, 189);
            this.tb_Cam1AddY4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddY4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddY4.Name = "tb_Cam1AddY4";
            this.tb_Cam1AddY4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddY4.TabIndex = 44;
            // 
            // tb_Cam1AddT4
            // 
            this.tb_Cam1AddT4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddT4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddT4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddT4.Location = new System.Drawing.Point(648, 235);
            this.tb_Cam1AddT4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddT4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddT4.Name = "tb_Cam1AddT4";
            this.tb_Cam1AddT4.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddT4.TabIndex = 43;
            // 
            // btn_GetStd1
            // 
            this.btn_GetStd1.Location = new System.Drawing.Point(95, 279);
            this.btn_GetStd1.Name = "btn_GetStd1";
            this.btn_GetStd1.Size = new System.Drawing.Size(75, 39);
            this.btn_GetStd1.TabIndex = 24;
            this.btn_GetStd1.Text = "获取基准";
            this.btn_GetStd1.UseVisualStyleBackColor = true;
            this.btn_GetStd1.Click += new System.EventHandler(this.btn_GetStd1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 49;
            this.button1.Text = "获取基准";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 50;
            this.button2.Text = "获取基准";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 51;
            this.button3.Text = "获取基准";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_Cam1AddT2
            // 
            this.lb_Cam1AddT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddT2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddT2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddT2.Location = new System.Drawing.Point(187, 230);
            this.lb_Cam1AddT2.Name = "lb_Cam1AddT2";
            this.lb_Cam1AddT2.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddT2.TabIndex = 1;
            this.lb_Cam1AddT2.Text = "机械手2补偿R";
            this.lb_Cam1AddT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Exprosure
            // 
            this.lb_Cam1Exprosure.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Cam1Exprosure.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Exprosure.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Exprosure.Location = new System.Drawing.Point(3, 506);
            this.lb_Cam1Exprosure.Name = "lb_Cam1Exprosure";
            this.lb_Cam1Exprosure.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Exprosure.TabIndex = 21;
            this.lb_Cam1Exprosure.Text = "曝光值(ms)";
            this.lb_Cam1Exprosure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Exprosure
            // 
            this.tb_Cam1Exprosure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Exprosure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Exprosure.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Exprosure.Location = new System.Drawing.Point(96, 511);
            this.tb_Cam1Exprosure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Exprosure.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Exprosure.Name = "tb_Cam1Exprosure";
            this.tb_Cam1Exprosure.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Exprosure.TabIndex = 20;
            // 
            // tb_Cam1L1CalibX0
            // 
            this.tb_Cam1L1CalibX0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1L1CalibX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1L1CalibX0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1L1CalibX0.Location = new System.Drawing.Point(1016, 5);
            this.tb_Cam1L1CalibX0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1L1CalibX0.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1L1CalibX0.Name = "tb_Cam1L1CalibX0";
            this.tb_Cam1L1CalibX0.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1L1CalibX0.TabIndex = 103;
            // 
            // tb_Cam1L1CalibY0
            // 
            this.tb_Cam1L1CalibY0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1L1CalibY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1L1CalibY0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1L1CalibY0.Location = new System.Drawing.Point(1016, 51);
            this.tb_Cam1L1CalibY0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1L1CalibY0.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1L1CalibY0.Name = "tb_Cam1L1CalibY0";
            this.tb_Cam1L1CalibY0.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1L1CalibY0.TabIndex = 113;
            // 
            // tb_Cam1L2CalibX0
            // 
            this.tb_Cam1L2CalibX0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1L2CalibX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1L2CalibX0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1L2CalibX0.Location = new System.Drawing.Point(1016, 97);
            this.tb_Cam1L2CalibX0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1L2CalibX0.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1L2CalibX0.Name = "tb_Cam1L2CalibX0";
            this.tb_Cam1L2CalibX0.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1L2CalibX0.TabIndex = 120;
            // 
            // tb_Cam1L2CalibY0
            // 
            this.tb_Cam1L2CalibY0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1L2CalibY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1L2CalibY0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1L2CalibY0.Location = new System.Drawing.Point(1016, 143);
            this.tb_Cam1L2CalibY0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1L2CalibY0.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1L2CalibY0.Name = "tb_Cam1L2CalibY0";
            this.tb_Cam1L2CalibY0.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1L2CalibY0.TabIndex = 131;
            // 
            // lb_Cam1L1CalibX0
            // 
            this.lb_Cam1L1CalibX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1L1CalibX0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1L1CalibX0.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1L1CalibX0.Location = new System.Drawing.Point(923, 0);
            this.lb_Cam1L1CalibX0.Name = "lb_Cam1L1CalibX0";
            this.lb_Cam1L1CalibX0.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1L1CalibX0.TabIndex = 52;
            this.lb_Cam1L1CalibX0.Text = "L1标定中心位X";
            this.lb_Cam1L1CalibX0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1L1CalibY0
            // 
            this.lb_Cam1L1CalibY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1L1CalibY0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1L1CalibY0.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1L1CalibY0.Location = new System.Drawing.Point(923, 46);
            this.lb_Cam1L1CalibY0.Name = "lb_Cam1L1CalibY0";
            this.lb_Cam1L1CalibY0.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1L1CalibY0.TabIndex = 53;
            this.lb_Cam1L1CalibY0.Text = "L1标定中心位Y";
            this.lb_Cam1L1CalibY0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1L2CalibX0
            // 
            this.lb_Cam1L2CalibX0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1L2CalibX0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1L2CalibX0.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1L2CalibX0.Location = new System.Drawing.Point(923, 92);
            this.lb_Cam1L2CalibX0.Name = "lb_Cam1L2CalibX0";
            this.lb_Cam1L2CalibX0.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1L2CalibX0.TabIndex = 65;
            this.lb_Cam1L2CalibX0.Text = "L2标定中心位X";
            this.lb_Cam1L2CalibX0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1L2CalibY0
            // 
            this.lb_Cam1L2CalibY0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1L2CalibY0.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1L2CalibY0.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1L2CalibY0.Location = new System.Drawing.Point(923, 138);
            this.lb_Cam1L2CalibY0.Name = "lb_Cam1L2CalibY0";
            this.lb_Cam1L2CalibY0.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1L2CalibY0.TabIndex = 66;
            this.lb_Cam1L2CalibY0.Text = "L2标定中心位Y";
            this.lb_Cam1L2CalibY0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Limitmax
            // 
            this.lb_Cam1Limitmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Limitmax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Limitmax.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Limitmax.Location = new System.Drawing.Point(739, 0);
            this.lb_Cam1Limitmax.Name = "lb_Cam1Limitmax";
            this.lb_Cam1Limitmax.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Limitmax.TabIndex = 142;
            this.lb_Cam1Limitmax.Text = "偏移范围Max";
            this.lb_Cam1Limitmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Limitmin
            // 
            this.lb_Cam1Limitmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Limitmin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Limitmin.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Limitmin.Location = new System.Drawing.Point(739, 46);
            this.lb_Cam1Limitmin.Name = "lb_Cam1Limitmin";
            this.lb_Cam1Limitmin.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Limitmin.TabIndex = 141;
            this.lb_Cam1Limitmin.Text = "偏移范围Min";
            this.lb_Cam1Limitmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Anglemin
            // 
            this.lb_Cam1Anglemin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Anglemin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Anglemin.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Anglemin.Location = new System.Drawing.Point(739, 92);
            this.lb_Cam1Anglemin.Name = "lb_Cam1Anglemin";
            this.lb_Cam1Anglemin.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Anglemin.TabIndex = 137;
            this.lb_Cam1Anglemin.Text = "钢片与壳角度Min";
            this.lb_Cam1Anglemin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Anglemax
            // 
            this.lb_Cam1Anglemax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Anglemax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Anglemax.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Anglemax.Location = new System.Drawing.Point(739, 138);
            this.lb_Cam1Anglemax.Name = "lb_Cam1Anglemax";
            this.lb_Cam1Anglemax.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Anglemax.TabIndex = 138;
            this.lb_Cam1Anglemax.Text = "钢片与壳角度Max";
            this.lb_Cam1Anglemax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Limitmin
            // 
            this.tb_Cam1Limitmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Limitmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Limitmin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Limitmin.Location = new System.Drawing.Point(832, 5);
            this.tb_Cam1Limitmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Limitmin.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Limitmin.Name = "tb_Cam1Limitmin";
            this.tb_Cam1Limitmin.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Limitmin.TabIndex = 143;
            // 
            // tb_Cam1Limitmax
            // 
            this.tb_Cam1Limitmax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Limitmax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Limitmax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Limitmax.Location = new System.Drawing.Point(832, 51);
            this.tb_Cam1Limitmax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Limitmax.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Limitmax.Name = "tb_Cam1Limitmax";
            this.tb_Cam1Limitmax.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Limitmax.TabIndex = 144;
            // 
            // tb_Cam1Anglemin
            // 
            this.tb_Cam1Anglemin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Anglemin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Anglemin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Anglemin.Location = new System.Drawing.Point(832, 97);
            this.tb_Cam1Anglemin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Anglemin.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Anglemin.Name = "tb_Cam1Anglemin";
            this.tb_Cam1Anglemin.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Anglemin.TabIndex = 139;
            // 
            // tb_Cam1Anglemax
            // 
            this.tb_Cam1Anglemax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Anglemax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Anglemax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Anglemax.Location = new System.Drawing.Point(832, 143);
            this.tb_Cam1Anglemax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Anglemax.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Anglemax.Name = "tb_Cam1Anglemax";
            this.tb_Cam1Anglemax.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Anglemax.TabIndex = 140;
            // 
            // lb_Cam1CellLineL
            // 
            this.lb_Cam1CellLineL.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1CellLineL.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1CellLineL.Location = new System.Drawing.Point(1107, 46);
            this.lb_Cam1CellLineL.Name = "lb_Cam1CellLineL";
            this.lb_Cam1CellLineL.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1CellLineL.TabIndex = 147;
            this.lb_Cam1CellLineL.Text = "AL焊印固定长度";
            this.lb_Cam1CellLineL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1CellLineL
            // 
            this.tb_Cam1CellLineL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1CellLineL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1CellLineL.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1CellLineL.Location = new System.Drawing.Point(1200, 51);
            this.tb_Cam1CellLineL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1CellLineL.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1CellLineL.Name = "tb_Cam1CellLineL";
            this.tb_Cam1CellLineL.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1CellLineL.TabIndex = 148;
            // 
            // lb_Cam1OffsetX
            // 
            this.lb_Cam1OffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1OffsetX.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1OffsetX.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1OffsetX.Location = new System.Drawing.Point(1107, 0);
            this.lb_Cam1OffsetX.Name = "lb_Cam1OffsetX";
            this.lb_Cam1OffsetX.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1OffsetX.TabIndex = 145;
            this.lb_Cam1OffsetX.Text = "焊印基准设定位置";
            this.lb_Cam1OffsetX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1OffsetX
            // 
            this.tb_Cam1OffsetX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1OffsetX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1OffsetX.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1OffsetX.Location = new System.Drawing.Point(1200, 5);
            this.tb_Cam1OffsetX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1OffsetX.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1OffsetX.Name = "tb_Cam1OffsetX";
            this.tb_Cam1OffsetX.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1OffsetX.TabIndex = 146;
            // 
            // lb_Cam1LaserStep
            // 
            this.lb_Cam1LaserStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1LaserStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LaserStep.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LaserStep.Location = new System.Drawing.Point(923, 184);
            this.lb_Cam1LaserStep.Name = "lb_Cam1LaserStep";
            this.lb_Cam1LaserStep.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LaserStep.TabIndex = 157;
            this.lb_Cam1LaserStep.Text = "激光九点间距";
            this.lb_Cam1LaserStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1LaserStep
            // 
            this.tb_Cam1LaserStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LaserStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1LaserStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LaserStep.Location = new System.Drawing.Point(1016, 189);
            this.tb_Cam1LaserStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1LaserStep.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LaserStep.Name = "tb_Cam1LaserStep";
            this.tb_Cam1LaserStep.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1LaserStep.TabIndex = 159;
            // 
            // tb_Cam1RobStep
            // 
            this.tb_Cam1RobStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1RobStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1RobStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1RobStep.Location = new System.Drawing.Point(1016, 235);
            this.tb_Cam1RobStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1RobStep.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1RobStep.Name = "tb_Cam1RobStep";
            this.tb_Cam1RobStep.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1RobStep.TabIndex = 158;
            // 
            // lb_Cam1RobStep
            // 
            this.lb_Cam1RobStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1RobStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1RobStep.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1RobStep.Location = new System.Drawing.Point(923, 230);
            this.lb_Cam1RobStep.Name = "lb_Cam1RobStep";
            this.lb_Cam1RobStep.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1RobStep.TabIndex = 160;
            this.lb_Cam1RobStep.Text = "机械手九点间距";
            this.lb_Cam1RobStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1P4byP3Y
            // 
            this.lb_Cam1P4byP3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1P4byP3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P4byP3Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P4byP3Y.Location = new System.Drawing.Point(1107, 414);
            this.lb_Cam1P4byP3Y.Name = "lb_Cam1P4byP3Y";
            this.lb_Cam1P4byP3Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P4byP3Y.TabIndex = 154;
            this.lb_Cam1P4byP3Y.Text = "固定点4随点3自动修改差值Y";
            this.lb_Cam1P4byP3Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P4byP3Y
            // 
            this.tb_Cam1P4byP3Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P4byP3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P4byP3Y.Location = new System.Drawing.Point(1200, 419);
            this.tb_Cam1P4byP3Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1P4byP3Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P4byP3Y.Name = "tb_Cam1P4byP3Y";
            this.tb_Cam1P4byP3Y.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1P4byP3Y.TabIndex = 155;
            // 
            // lb_Cam1P4byP3X
            // 
            this.lb_Cam1P4byP3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P4byP3X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P4byP3X.Location = new System.Drawing.Point(1107, 368);
            this.lb_Cam1P4byP3X.Name = "lb_Cam1P4byP3X";
            this.lb_Cam1P4byP3X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P4byP3X.TabIndex = 153;
            this.lb_Cam1P4byP3X.Text = "固定点4随点3自动修改差值X";
            this.lb_Cam1P4byP3X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P4byP3X
            // 
            this.tb_Cam1P4byP3X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P4byP3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P4byP3X.Location = new System.Drawing.Point(1200, 373);
            this.tb_Cam1P4byP3X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1P4byP3X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P4byP3X.Name = "tb_Cam1P4byP3X";
            this.tb_Cam1P4byP3X.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1P4byP3X.TabIndex = 156;
            // 
            // lb_Cam1P2byP1Y
            // 
            this.lb_Cam1P2byP1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P2byP1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P2byP1Y.Location = new System.Drawing.Point(1107, 322);
            this.lb_Cam1P2byP1Y.Name = "lb_Cam1P2byP1Y";
            this.lb_Cam1P2byP1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P2byP1Y.TabIndex = 152;
            this.lb_Cam1P2byP1Y.Text = "固定点2随点1自动修改差值Y";
            this.lb_Cam1P2byP1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P2byP1Y
            // 
            this.tb_Cam1P2byP1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P2byP1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P2byP1Y.Location = new System.Drawing.Point(1200, 327);
            this.tb_Cam1P2byP1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1P2byP1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P2byP1Y.Name = "tb_Cam1P2byP1Y";
            this.tb_Cam1P2byP1Y.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1P2byP1Y.TabIndex = 151;
            // 
            // lb_Cam1P2byP1X
            // 
            this.lb_Cam1P2byP1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P2byP1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P2byP1X.Location = new System.Drawing.Point(1107, 276);
            this.lb_Cam1P2byP1X.Name = "lb_Cam1P2byP1X";
            this.lb_Cam1P2byP1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P2byP1X.TabIndex = 149;
            this.lb_Cam1P2byP1X.Text = "固定点2随点1自动修改差值X";
            this.lb_Cam1P2byP1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P2byP1X
            // 
            this.tb_Cam1P2byP1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P2byP1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P2byP1X.Location = new System.Drawing.Point(1200, 281);
            this.tb_Cam1P2byP1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1P2byP1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P2byP1X.Name = "tb_Cam1P2byP1X";
            this.tb_Cam1P2byP1X.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1P2byP1X.TabIndex = 150;
            // 
            // lb_Cam1Spacing
            // 
            this.lb_Cam1Spacing.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Spacing.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Spacing.Location = new System.Drawing.Point(1107, 92);
            this.lb_Cam1Spacing.Name = "lb_Cam1Spacing";
            this.lb_Cam1Spacing.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Spacing.TabIndex = 162;
            this.lb_Cam1Spacing.Text = "极耳间距设定标准值";
            this.lb_Cam1Spacing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1SpacingUse
            // 
            this.lb_Cam1SpacingUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1SpacingUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1SpacingUse.Location = new System.Drawing.Point(1107, 138);
            this.lb_Cam1SpacingUse.Name = "lb_Cam1SpacingUse";
            this.lb_Cam1SpacingUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1SpacingUse.TabIndex = 161;
            this.lb_Cam1SpacingUse.Text = "屏蔽间距补偿（1启用0屏蔽）";
            this.lb_Cam1SpacingUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1RobUse
            // 
            this.lb_Cam1RobUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1RobUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1RobUse.Location = new System.Drawing.Point(1107, 184);
            this.lb_Cam1RobUse.Name = "lb_Cam1RobUse";
            this.lb_Cam1RobUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1RobUse.TabIndex = 163;
            this.lb_Cam1RobUse.Text = "屏蔽机械手补偿（1启用0屏蔽）";
            this.lb_Cam1RobUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1LaserUse
            // 
            this.lb_Cam1LaserUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LaserUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LaserUse.Location = new System.Drawing.Point(1107, 230);
            this.lb_Cam1LaserUse.Name = "lb_Cam1LaserUse";
            this.lb_Cam1LaserUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LaserUse.TabIndex = 164;
            this.lb_Cam1LaserUse.Text = "屏蔽激光补偿（1启用0屏蔽）";
            this.lb_Cam1LaserUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Spacing
            // 
            this.tb_Cam1Spacing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Spacing.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Spacing.Location = new System.Drawing.Point(1200, 97);
            this.tb_Cam1Spacing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1Spacing.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Spacing.Name = "tb_Cam1Spacing";
            this.tb_Cam1Spacing.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1Spacing.TabIndex = 167;
            // 
            // tb_Cam1SpacingUse
            // 
            this.tb_Cam1SpacingUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1SpacingUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1SpacingUse.Location = new System.Drawing.Point(1200, 143);
            this.tb_Cam1SpacingUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1SpacingUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1SpacingUse.Name = "tb_Cam1SpacingUse";
            this.tb_Cam1SpacingUse.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1SpacingUse.TabIndex = 166;
            // 
            // tb_Cam1RobUse
            // 
            this.tb_Cam1RobUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1RobUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1RobUse.Location = new System.Drawing.Point(1200, 189);
            this.tb_Cam1RobUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1RobUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1RobUse.Name = "tb_Cam1RobUse";
            this.tb_Cam1RobUse.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1RobUse.TabIndex = 165;
            // 
            // tb_Cam1LaserUse
            // 
            this.tb_Cam1LaserUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LaserUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LaserUse.Location = new System.Drawing.Point(1200, 235);
            this.tb_Cam1LaserUse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1LaserUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LaserUse.Name = "tb_Cam1LaserUse";
            this.tb_Cam1LaserUse.Size = new System.Drawing.Size(96, 21);
            this.tb_Cam1LaserUse.TabIndex = 168;
            // 
            // lb_Cam1ALX
            // 
            this.lb_Cam1ALX.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1ALX.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1ALX.Location = new System.Drawing.Point(3, 322);
            this.lb_Cam1ALX.Name = "lb_Cam1ALX";
            this.lb_Cam1ALX.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1ALX.TabIndex = 169;
            this.lb_Cam1ALX.Text = "1工位AL焊点X";
            this.lb_Cam1ALX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI1X
            // 
            this.lb_Cam1NI1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI1X.Location = new System.Drawing.Point(187, 322);
            this.lb_Cam1NI1X.Name = "lb_Cam1NI1X";
            this.lb_Cam1NI1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI1X.TabIndex = 170;
            this.lb_Cam1NI1X.Text = "1工位NI焊点1X";
            this.lb_Cam1NI1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI2X
            // 
            this.lb_Cam1NI2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI2X.Location = new System.Drawing.Point(371, 322);
            this.lb_Cam1NI2X.Name = "lb_Cam1NI2X";
            this.lb_Cam1NI2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI2X.TabIndex = 171;
            this.lb_Cam1NI2X.Text = "1工位NI焊点2X";
            this.lb_Cam1NI2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1ALY
            // 
            this.lb_Cam1ALY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1ALY.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1ALY.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1ALY.Location = new System.Drawing.Point(3, 368);
            this.lb_Cam1ALY.Name = "lb_Cam1ALY";
            this.lb_Cam1ALY.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1ALY.TabIndex = 172;
            this.lb_Cam1ALY.Text = "1工位AL焊点Y";
            this.lb_Cam1ALY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI1Y
            // 
            this.lb_Cam1NI1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI1Y.Location = new System.Drawing.Point(187, 368);
            this.lb_Cam1NI1Y.Name = "lb_Cam1NI1Y";
            this.lb_Cam1NI1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI1Y.TabIndex = 174;
            this.lb_Cam1NI1Y.Text = "1工位NI焊点1Y";
            this.lb_Cam1NI1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI2Y
            // 
            this.lb_Cam1NI2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI2Y.Location = new System.Drawing.Point(371, 368);
            this.lb_Cam1NI2Y.Name = "lb_Cam1NI2Y";
            this.lb_Cam1NI2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI2Y.TabIndex = 173;
            this.lb_Cam1NI2Y.Text = "1工位NI焊点2Y";
            this.lb_Cam1NI2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1ALX
            // 
            this.tb_Cam1ALX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1ALX.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1ALX.Location = new System.Drawing.Point(96, 327);
            this.tb_Cam1ALX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1ALX.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1ALX.Name = "tb_Cam1ALX";
            this.tb_Cam1ALX.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1ALX.TabIndex = 176;
            // 
            // tb_Cam1NI1X
            // 
            this.tb_Cam1NI1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI1X.Location = new System.Drawing.Point(280, 327);
            this.tb_Cam1NI1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI1X.Name = "tb_Cam1NI1X";
            this.tb_Cam1NI1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI1X.TabIndex = 177;
            // 
            // tb_Cam1NI2X
            // 
            this.tb_Cam1NI2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI2X.Location = new System.Drawing.Point(464, 327);
            this.tb_Cam1NI2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI2X.Name = "tb_Cam1NI2X";
            this.tb_Cam1NI2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI2X.TabIndex = 175;
            // 
            // tb_Cam1ALY
            // 
            this.tb_Cam1ALY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1ALY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1ALY.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1ALY.Location = new System.Drawing.Point(96, 373);
            this.tb_Cam1ALY.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1ALY.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1ALY.Name = "tb_Cam1ALY";
            this.tb_Cam1ALY.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1ALY.TabIndex = 180;
            // 
            // tb_Cam1NI1Y
            // 
            this.tb_Cam1NI1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI1Y.Location = new System.Drawing.Point(280, 373);
            this.tb_Cam1NI1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI1Y.Name = "tb_Cam1NI1Y";
            this.tb_Cam1NI1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI1Y.TabIndex = 178;
            // 
            // tb_Cam1NI2Y
            // 
            this.tb_Cam1NI2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI2Y.Location = new System.Drawing.Point(464, 373);
            this.tb_Cam1NI2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI2Y.Name = "tb_Cam1NI2Y";
            this.tb_Cam1NI2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI2Y.TabIndex = 179;
            // 
            // lb_Cam1ALX1
            // 
            this.lb_Cam1ALX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1ALX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1ALX1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1ALX1.Location = new System.Drawing.Point(3, 414);
            this.lb_Cam1ALX1.Name = "lb_Cam1ALX1";
            this.lb_Cam1ALX1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1ALX1.TabIndex = 183;
            this.lb_Cam1ALX1.Text = "2工位AL焊点X";
            this.lb_Cam1ALX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1ALY1
            // 
            this.lb_Cam1ALY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1ALY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1ALY1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1ALY1.Location = new System.Drawing.Point(3, 460);
            this.lb_Cam1ALY1.Name = "lb_Cam1ALY1";
            this.lb_Cam1ALY1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1ALY1.TabIndex = 184;
            this.lb_Cam1ALY1.Text = "2工位AL焊点Y";
            this.lb_Cam1ALY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI1X1
            // 
            this.lb_Cam1NI1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI1X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI1X1.Location = new System.Drawing.Point(187, 414);
            this.lb_Cam1NI1X1.Name = "lb_Cam1NI1X1";
            this.lb_Cam1NI1X1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI1X1.TabIndex = 185;
            this.lb_Cam1NI1X1.Text = "2工位NI焊点1X";
            this.lb_Cam1NI1X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI1Y1
            // 
            this.lb_Cam1NI1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI1Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI1Y1.Location = new System.Drawing.Point(187, 460);
            this.lb_Cam1NI1Y1.Name = "lb_Cam1NI1Y1";
            this.lb_Cam1NI1Y1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI1Y1.TabIndex = 186;
            this.lb_Cam1NI1Y1.Text = "2工位NI焊点1Y";
            this.lb_Cam1NI1Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI2X1
            // 
            this.lb_Cam1NI2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI2X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI2X1.Location = new System.Drawing.Point(371, 414);
            this.lb_Cam1NI2X1.Name = "lb_Cam1NI2X1";
            this.lb_Cam1NI2X1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI2X1.TabIndex = 181;
            this.lb_Cam1NI2X1.Text = "2工位NI焊点2X";
            this.lb_Cam1NI2X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1NI2Y1
            // 
            this.lb_Cam1NI2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1NI2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1NI2Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1NI2Y1.Location = new System.Drawing.Point(371, 460);
            this.lb_Cam1NI2Y1.Name = "lb_Cam1NI2Y1";
            this.lb_Cam1NI2Y1.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1NI2Y1.TabIndex = 182;
            this.lb_Cam1NI2Y1.Text = "2工位NI焊点2Y";
            this.lb_Cam1NI2Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1ALX1
            // 
            this.tb_Cam1ALX1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1ALX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1ALX1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1ALX1.Location = new System.Drawing.Point(96, 419);
            this.tb_Cam1ALX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1ALX1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1ALX1.Name = "tb_Cam1ALX1";
            this.tb_Cam1ALX1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1ALX1.TabIndex = 192;
            // 
            // tb_Cam1ALY1
            // 
            this.tb_Cam1ALY1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1ALY1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1ALY1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1ALY1.Location = new System.Drawing.Point(96, 465);
            this.tb_Cam1ALY1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1ALY1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1ALY1.Name = "tb_Cam1ALY1";
            this.tb_Cam1ALY1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1ALY1.TabIndex = 188;
            // 
            // tb_Cam1NI1X1
            // 
            this.tb_Cam1NI1X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI1X1.Location = new System.Drawing.Point(280, 419);
            this.tb_Cam1NI1X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI1X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI1X1.Name = "tb_Cam1NI1X1";
            this.tb_Cam1NI1X1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI1X1.TabIndex = 191;
            // 
            // tb_Cam1NI1Y1
            // 
            this.tb_Cam1NI1Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI1Y1.Location = new System.Drawing.Point(280, 465);
            this.tb_Cam1NI1Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI1Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI1Y1.Name = "tb_Cam1NI1Y1";
            this.tb_Cam1NI1Y1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI1Y1.TabIndex = 189;
            // 
            // tb_Cam1NI2X1
            // 
            this.tb_Cam1NI2X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI2X1.Location = new System.Drawing.Point(464, 419);
            this.tb_Cam1NI2X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI2X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI2X1.Name = "tb_Cam1NI2X1";
            this.tb_Cam1NI2X1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI2X1.TabIndex = 187;
            // 
            // tb_Cam1NI2Y1
            // 
            this.tb_Cam1NI2Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1NI2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1NI2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1NI2Y1.Location = new System.Drawing.Point(464, 465);
            this.tb_Cam1NI2Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1NI2Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1NI2Y1.Name = "tb_Cam1NI2Y1";
            this.tb_Cam1NI2Y1.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1NI2Y1.TabIndex = 190;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1300, 552);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "夹具1补偿";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 16;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddR2J1Y, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddR2J1X, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddR1J1Y, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddR1J1X, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddR2J1Y, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddR2J1X, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddR1J1Y, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddR1J1X, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1Y1, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1X1, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1Y1, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1X1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1Y1, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1X1, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1Y1, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1X1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1Y2, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1X2, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1Y2, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1X2, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1Y2, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1X2, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1Y2, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1X2, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1Y3, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1X3, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1Y3, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1X3, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1Y3, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1X3, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1Y3, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1X3, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1Y4, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL2J1X4, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1Y4, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1AddL1J1X4, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1Y4, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL2J1X4, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1Y4, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1AddL1J1X4, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lb_Cam1AddR2J1Y
            // 
            this.lb_Cam1AddR2J1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J1Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J1Y.Name = "lb_Cam1AddR2J1Y";
            this.lb_Cam1AddR2J1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J1Y.TabIndex = 15;
            this.lb_Cam1AddR2J1Y.Text = "Y:";
            this.lb_Cam1AddR2J1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR2J1X
            // 
            this.lb_Cam1AddR2J1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J1X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J1X.Name = "lb_Cam1AddR2J1X";
            this.lb_Cam1AddR2J1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J1X.TabIndex = 14;
            this.lb_Cam1AddR2J1X.Text = "X：";
            this.lb_Cam1AddR2J1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 45);
            this.label7.TabIndex = 13;
            this.label7.Text = "ROB2补偿";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J1Y
            // 
            this.lb_Cam1AddR1J1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J1Y.Name = "lb_Cam1AddR1J1Y";
            this.lb_Cam1AddR1J1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J1Y.TabIndex = 7;
            this.lb_Cam1AddR1J1Y.Text = "Y:";
            this.lb_Cam1AddR1J1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J1X
            // 
            this.lb_Cam1AddR1J1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J1X.Name = "lb_Cam1AddR1J1X";
            this.lb_Cam1AddR1J1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J1X.TabIndex = 3;
            this.lb_Cam1AddR1J1X.Text = "X：";
            this.lb_Cam1AddR1J1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "ROB1补偿";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J1Y
            // 
            this.tb_Cam1AddR2J1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J1Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J1Y.Name = "tb_Cam1AddR2J1Y";
            this.tb_Cam1AddR2J1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J1Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J1X
            // 
            this.tb_Cam1AddR2J1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J1X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J1X.Name = "tb_Cam1AddR2J1X";
            this.tb_Cam1AddR2J1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J1X.TabIndex = 11;
            // 
            // tb_Cam1AddR1J1Y
            // 
            this.tb_Cam1AddR1J1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J1Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J1Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J1Y.Name = "tb_Cam1AddR1J1Y";
            this.tb_Cam1AddR1J1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J1Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J1X
            // 
            this.tb_Cam1AddR1J1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J1X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J1X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J1X.Name = "tb_Cam1AddR1J1X";
            this.tb_Cam1AddR1J1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J1X.TabIndex = 2;
            // 
            // lb_Cam1AddL2J1Y1
            // 
            this.lb_Cam1AddL2J1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J1Y1.Name = "lb_Cam1AddL2J1Y1";
            this.lb_Cam1AddL2J1Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1Y1.TabIndex = 36;
            this.lb_Cam1AddL2J1Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J1Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J1X1
            // 
            this.lb_Cam1AddL2J1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J1X1.Name = "lb_Cam1AddL2J1X1";
            this.lb_Cam1AddL2J1X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1X1.TabIndex = 29;
            this.lb_Cam1AddL2J1X1.Text = "点1X：";
            this.lb_Cam1AddL2J1X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(246, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 45);
            this.label16.TabIndex = 28;
            this.label16.Text = "Laser2补偿";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1Y1
            // 
            this.lb_Cam1AddL1J1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J1Y1.Name = "lb_Cam1AddL1J1Y1";
            this.lb_Cam1AddL1J1Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1Y1.TabIndex = 19;
            this.lb_Cam1AddL1J1Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J1Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1X1
            // 
            this.lb_Cam1AddL1J1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J1X1.Name = "lb_Cam1AddL1J1X1";
            this.lb_Cam1AddL1J1X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1X1.TabIndex = 6;
            this.lb_Cam1AddL1J1X1.Text = "点1X：";
            this.lb_Cam1AddL1J1X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(246, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Laser1补偿";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J1Y1
            // 
            this.tb_Cam1AddL2J1Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J1Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1Y1.Name = "tb_Cam1AddL2J1Y1";
            this.tb_Cam1AddL2J1Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1Y1.TabIndex = 30;
            this.tb_Cam1AddL2J1Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J1Y1_TextChanged);
            // 
            // tb_Cam1AddL2J1X1
            // 
            this.tb_Cam1AddL2J1X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J1X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1X1.Name = "tb_Cam1AddL2J1X1";
            this.tb_Cam1AddL2J1X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1X1.TabIndex = 43;
            this.tb_Cam1AddL2J1X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J1X1_TextChanged);
            // 
            // tb_Cam1AddL1J1Y1
            // 
            this.tb_Cam1AddL1J1Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J1Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1Y1.Name = "tb_Cam1AddL1J1Y1";
            this.tb_Cam1AddL1J1Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1Y1.TabIndex = 9;
            this.tb_Cam1AddL1J1Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J1Y1_TextChanged);
            // 
            // tb_Cam1AddL1J1X1
            // 
            this.tb_Cam1AddL1J1X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J1X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1X1.Name = "tb_Cam1AddL1J1X1";
            this.tb_Cam1AddL1J1X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1X1.TabIndex = 10;
            this.tb_Cam1AddL1J1X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J1X1_TextChanged);
            // 
            // lb_Cam1AddL2J1Y2
            // 
            this.lb_Cam1AddL2J1Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J1Y2.Name = "lb_Cam1AddL2J1Y2";
            this.lb_Cam1AddL2J1Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1Y2.TabIndex = 35;
            this.lb_Cam1AddL2J1Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J1Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J1X2
            // 
            this.lb_Cam1AddL2J1X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J1X2.Name = "lb_Cam1AddL2J1X2";
            this.lb_Cam1AddL2J1X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1X2.TabIndex = 37;
            this.lb_Cam1AddL2J1X2.Text = "点2X：";
            this.lb_Cam1AddL2J1X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1Y2
            // 
            this.lb_Cam1AddL1J1Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J1Y2.Name = "lb_Cam1AddL1J1Y2";
            this.lb_Cam1AddL1J1Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1Y2.TabIndex = 18;
            this.lb_Cam1AddL1J1Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J1Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1X2
            // 
            this.lb_Cam1AddL1J1X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J1X2.Name = "lb_Cam1AddL1J1X2";
            this.lb_Cam1AddL1J1X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1X2.TabIndex = 20;
            this.lb_Cam1AddL1J1X2.Text = "点2X：";
            this.lb_Cam1AddL1J1X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J1Y2
            // 
            this.tb_Cam1AddL2J1Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J1Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1Y2.Name = "tb_Cam1AddL2J1Y2";
            this.tb_Cam1AddL2J1Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1Y2.TabIndex = 41;
            // 
            // tb_Cam1AddL2J1X2
            // 
            this.tb_Cam1AddL2J1X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J1X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1X2.Name = "tb_Cam1AddL2J1X2";
            this.tb_Cam1AddL2J1X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1X2.TabIndex = 42;
            // 
            // tb_Cam1AddL1J1Y2
            // 
            this.tb_Cam1AddL1J1Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J1Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1Y2.Name = "tb_Cam1AddL1J1Y2";
            this.tb_Cam1AddL1J1Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J1X2
            // 
            this.tb_Cam1AddL1J1X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J1X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1X2.Name = "tb_Cam1AddL1J1X2";
            this.tb_Cam1AddL1J1X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1X2.TabIndex = 24;
            // 
            // lb_Cam1AddL2J1Y3
            // 
            this.lb_Cam1AddL2J1Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J1Y3.Name = "lb_Cam1AddL2J1Y3";
            this.lb_Cam1AddL2J1Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1Y3.TabIndex = 31;
            this.lb_Cam1AddL2J1Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J1Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J1X3
            // 
            this.lb_Cam1AddL2J1X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J1X3.Name = "lb_Cam1AddL2J1X3";
            this.lb_Cam1AddL2J1X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1X3.TabIndex = 34;
            this.lb_Cam1AddL2J1X3.Text = "点3X：";
            this.lb_Cam1AddL2J1X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1Y3
            // 
            this.lb_Cam1AddL1J1Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J1Y3.Name = "lb_Cam1AddL1J1Y3";
            this.lb_Cam1AddL1J1Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1Y3.TabIndex = 5;
            this.lb_Cam1AddL1J1Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J1Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1X3
            // 
            this.lb_Cam1AddL1J1X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J1X3.Name = "lb_Cam1AddL1J1X3";
            this.lb_Cam1AddL1J1X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1X3.TabIndex = 17;
            this.lb_Cam1AddL1J1X3.Text = "点3X：";
            this.lb_Cam1AddL1J1X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J1Y3
            // 
            this.tb_Cam1AddL2J1Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J1Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1Y3.Name = "tb_Cam1AddL2J1Y3";
            this.tb_Cam1AddL2J1Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1Y3.TabIndex = 44;
            this.tb_Cam1AddL2J1Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J1Y3_TextChanged);
            // 
            // tb_Cam1AddL2J1X3
            // 
            this.tb_Cam1AddL2J1X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J1X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1X3.Name = "tb_Cam1AddL2J1X3";
            this.tb_Cam1AddL2J1X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1X3.TabIndex = 32;
            this.tb_Cam1AddL2J1X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J1X3_TextChanged);
            // 
            // tb_Cam1AddL1J1Y3
            // 
            this.tb_Cam1AddL1J1Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J1Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1Y3.Name = "tb_Cam1AddL1J1Y3";
            this.tb_Cam1AddL1J1Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1Y3.TabIndex = 22;
            this.tb_Cam1AddL1J1Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J1Y3_TextChanged);
            // 
            // tb_Cam1AddL1J1X3
            // 
            this.tb_Cam1AddL1J1X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J1X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1X3.Name = "tb_Cam1AddL1J1X3";
            this.tb_Cam1AddL1J1X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1X3.TabIndex = 26;
            this.tb_Cam1AddL1J1X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J1X3_TextChanged);
            // 
            // lb_Cam1AddL2J1Y4
            // 
            this.lb_Cam1AddL2J1Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J1Y4.Name = "lb_Cam1AddL2J1Y4";
            this.lb_Cam1AddL2J1Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1Y4.TabIndex = 38;
            this.lb_Cam1AddL2J1Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J1Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J1X4
            // 
            this.lb_Cam1AddL2J1X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J1X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J1X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J1X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J1X4.Name = "lb_Cam1AddL2J1X4";
            this.lb_Cam1AddL2J1X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J1X4.TabIndex = 33;
            this.lb_Cam1AddL2J1X4.Text = "点4X：";
            this.lb_Cam1AddL2J1X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1Y4
            // 
            this.lb_Cam1AddL1J1Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J1Y4.Name = "lb_Cam1AddL1J1Y4";
            this.lb_Cam1AddL1J1Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1Y4.TabIndex = 21;
            this.lb_Cam1AddL1J1Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J1Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J1X4
            // 
            this.lb_Cam1AddL1J1X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J1X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J1X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J1X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J1X4.Name = "lb_Cam1AddL1J1X4";
            this.lb_Cam1AddL1J1X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J1X4.TabIndex = 16;
            this.lb_Cam1AddL1J1X4.Text = "点4X：";
            this.lb_Cam1AddL1J1X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J1Y4
            // 
            this.tb_Cam1AddL2J1Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J1Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1Y4.Name = "tb_Cam1AddL2J1Y4";
            this.tb_Cam1AddL2J1Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1Y4.TabIndex = 39;
            // 
            // tb_Cam1AddL2J1X4
            // 
            this.tb_Cam1AddL2J1X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J1X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J1X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J1X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J1X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J1X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J1X4.Name = "tb_Cam1AddL2J1X4";
            this.tb_Cam1AddL2J1X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J1X4.TabIndex = 40;
            // 
            // tb_Cam1AddL1J1Y4
            // 
            this.tb_Cam1AddL1J1Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J1Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1Y4.Name = "tb_Cam1AddL1J1Y4";
            this.tb_Cam1AddL1J1Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J1X4
            // 
            this.tb_Cam1AddL1J1X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J1X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J1X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J1X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J1X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J1X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J1X4.Name = "tb_Cam1AddL1J1X4";
            this.tb_Cam1AddL1J1X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J1X4.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 45);
            this.label6.TabIndex = 47;
            this.label6.Text = "夹具1";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1300, 552);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "夹具2补偿";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 16;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddR2J2Y, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddR2J2X, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddR1J2Y, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddR1J2X, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddR2J2Y, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddR2J2X, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddR1J2Y, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddR1J2X, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2Y1, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2X1, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label40, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2Y1, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2X1, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label31, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2Y1, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2X1, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2Y1, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2X1, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2Y2, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2X2, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2Y2, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2X2, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2Y2, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2X2, 6, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2Y2, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2X2, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2Y3, 7, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2X3, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2Y3, 8, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2X3, 8, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2Y3, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2X3, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2Y3, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2X3, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2Y4, 9, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL2J2X4, 9, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2Y4, 9, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1AddL1J2X4, 9, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2Y4, 10, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL2J2X4, 10, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2Y4, 10, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1AddL1J2X4, 10, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // lb_Cam1AddR2J2Y
            // 
            this.lb_Cam1AddR2J2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J2Y.Name = "lb_Cam1AddR2J2Y";
            this.lb_Cam1AddR2J2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J2Y.TabIndex = 15;
            this.lb_Cam1AddR2J2Y.Text = "Y:";
            this.lb_Cam1AddR2J2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR2J2X
            // 
            this.lb_Cam1AddR2J2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J2X.Name = "lb_Cam1AddR2J2X";
            this.lb_Cam1AddR2J2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J2X.TabIndex = 14;
            this.lb_Cam1AddR2J2X.Text = "X：";
            this.lb_Cam1AddR2J2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(3, 180);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 45);
            this.label28.TabIndex = 13;
            this.label28.Text = "ROB2补偿";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J2Y
            // 
            this.lb_Cam1AddR1J2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J2Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J2Y.Name = "lb_Cam1AddR1J2Y";
            this.lb_Cam1AddR1J2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J2Y.TabIndex = 7;
            this.lb_Cam1AddR1J2Y.Text = "Y:";
            this.lb_Cam1AddR1J2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J2X
            // 
            this.lb_Cam1AddR1J2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J2X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J2X.Name = "lb_Cam1AddR1J2X";
            this.lb_Cam1AddR1J2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J2X.TabIndex = 3;
            this.lb_Cam1AddR1J2X.Text = "X：";
            this.lb_Cam1AddR1J2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(3, 45);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 45);
            this.label25.TabIndex = 1;
            this.label25.Text = "ROB1补偿";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J2Y
            // 
            this.tb_Cam1AddR2J2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J2Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J2Y.Name = "tb_Cam1AddR2J2Y";
            this.tb_Cam1AddR2J2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J2Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J2X
            // 
            this.tb_Cam1AddR2J2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J2X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J2X.Name = "tb_Cam1AddR2J2X";
            this.tb_Cam1AddR2J2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J2X.TabIndex = 11;
            // 
            // tb_Cam1AddR1J2Y
            // 
            this.tb_Cam1AddR1J2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J2Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J2Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J2Y.Name = "tb_Cam1AddR1J2Y";
            this.tb_Cam1AddR1J2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J2Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J2X
            // 
            this.tb_Cam1AddR1J2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J2X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J2X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J2X.Name = "tb_Cam1AddR1J2X";
            this.tb_Cam1AddR1J2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J2X.TabIndex = 2;
            // 
            // lb_Cam1AddL2J2Y1
            // 
            this.lb_Cam1AddL2J2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J2Y1.Name = "lb_Cam1AddL2J2Y1";
            this.lb_Cam1AddL2J2Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2Y1.TabIndex = 36;
            this.lb_Cam1AddL2J2Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J2Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J2X1
            // 
            this.lb_Cam1AddL2J2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J2X1.Name = "lb_Cam1AddL2J2X1";
            this.lb_Cam1AddL2J2X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2X1.TabIndex = 29;
            this.lb_Cam1AddL2J2X1.Text = "点1X：";
            this.lb_Cam1AddL2J2X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(246, 180);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(75, 45);
            this.label40.TabIndex = 28;
            this.label40.Text = "Laser2补偿";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2Y1
            // 
            this.lb_Cam1AddL1J2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J2Y1.Name = "lb_Cam1AddL1J2Y1";
            this.lb_Cam1AddL1J2Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2Y1.TabIndex = 19;
            this.lb_Cam1AddL1J2Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J2Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2X1
            // 
            this.lb_Cam1AddL1J2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J2X1.Name = "lb_Cam1AddL1J2X1";
            this.lb_Cam1AddL1J2X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2X1.TabIndex = 6;
            this.lb_Cam1AddL1J2X1.Text = "点1X：";
            this.lb_Cam1AddL1J2X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(246, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(75, 45);
            this.label31.TabIndex = 4;
            this.label31.Text = "Laser1补偿";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J2Y1
            // 
            this.tb_Cam1AddL2J2Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J2Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2Y1.Name = "tb_Cam1AddL2J2Y1";
            this.tb_Cam1AddL2J2Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2Y1.TabIndex = 30;
            this.tb_Cam1AddL2J2Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J2Y1_TextChanged);
            // 
            // tb_Cam1AddL2J2X1
            // 
            this.tb_Cam1AddL2J2X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J2X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2X1.Name = "tb_Cam1AddL2J2X1";
            this.tb_Cam1AddL2J2X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2X1.TabIndex = 43;
            this.tb_Cam1AddL2J2X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J2X1_TextChanged);
            // 
            // tb_Cam1AddL1J2Y1
            // 
            this.tb_Cam1AddL1J2Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J2Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2Y1.Name = "tb_Cam1AddL1J2Y1";
            this.tb_Cam1AddL1J2Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2Y1.TabIndex = 9;
            this.tb_Cam1AddL1J2Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J2Y1_TextChanged);
            // 
            // tb_Cam1AddL1J2X1
            // 
            this.tb_Cam1AddL1J2X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J2X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2X1.Name = "tb_Cam1AddL1J2X1";
            this.tb_Cam1AddL1J2X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2X1.TabIndex = 10;
            this.tb_Cam1AddL1J2X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J2X1_TextChanged);
            // 
            // lb_Cam1AddL2J2Y2
            // 
            this.lb_Cam1AddL2J2Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J2Y2.Name = "lb_Cam1AddL2J2Y2";
            this.lb_Cam1AddL2J2Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2Y2.TabIndex = 35;
            this.lb_Cam1AddL2J2Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J2Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J2X2
            // 
            this.lb_Cam1AddL2J2X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J2X2.Name = "lb_Cam1AddL2J2X2";
            this.lb_Cam1AddL2J2X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2X2.TabIndex = 37;
            this.lb_Cam1AddL2J2X2.Text = "点2X：";
            this.lb_Cam1AddL2J2X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2Y2
            // 
            this.lb_Cam1AddL1J2Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J2Y2.Name = "lb_Cam1AddL1J2Y2";
            this.lb_Cam1AddL1J2Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2Y2.TabIndex = 18;
            this.lb_Cam1AddL1J2Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J2Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2X2
            // 
            this.lb_Cam1AddL1J2X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J2X2.Name = "lb_Cam1AddL1J2X2";
            this.lb_Cam1AddL1J2X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2X2.TabIndex = 20;
            this.lb_Cam1AddL1J2X2.Text = "点2X：";
            this.lb_Cam1AddL1J2X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J2Y2
            // 
            this.tb_Cam1AddL2J2Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J2Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2Y2.Name = "tb_Cam1AddL2J2Y2";
            this.tb_Cam1AddL2J2Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2Y2.TabIndex = 41;
            // 
            // tb_Cam1AddL2J2X2
            // 
            this.tb_Cam1AddL2J2X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J2X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2X2.Name = "tb_Cam1AddL2J2X2";
            this.tb_Cam1AddL2J2X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2X2.TabIndex = 42;
            // 
            // tb_Cam1AddL1J2Y2
            // 
            this.tb_Cam1AddL1J2Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J2Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2Y2.Name = "tb_Cam1AddL1J2Y2";
            this.tb_Cam1AddL1J2Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J2X2
            // 
            this.tb_Cam1AddL1J2X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J2X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2X2.Name = "tb_Cam1AddL1J2X2";
            this.tb_Cam1AddL1J2X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2X2.TabIndex = 24;
            // 
            // lb_Cam1AddL2J2Y3
            // 
            this.lb_Cam1AddL2J2Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J2Y3.Name = "lb_Cam1AddL2J2Y3";
            this.lb_Cam1AddL2J2Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2Y3.TabIndex = 31;
            this.lb_Cam1AddL2J2Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J2Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J2X3
            // 
            this.lb_Cam1AddL2J2X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J2X3.Name = "lb_Cam1AddL2J2X3";
            this.lb_Cam1AddL2J2X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2X3.TabIndex = 34;
            this.lb_Cam1AddL2J2X3.Text = "点3X：";
            this.lb_Cam1AddL2J2X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J2Y3
            // 
            this.tb_Cam1AddL2J2Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J2Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2Y3.Name = "tb_Cam1AddL2J2Y3";
            this.tb_Cam1AddL2J2Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2Y3.TabIndex = 44;
            this.tb_Cam1AddL2J2Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J2Y3_TextChanged);
            // 
            // tb_Cam1AddL2J2X3
            // 
            this.tb_Cam1AddL2J2X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J2X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2X3.Name = "tb_Cam1AddL2J2X3";
            this.tb_Cam1AddL2J2X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2X3.TabIndex = 32;
            this.tb_Cam1AddL2J2X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J2X3_TextChanged);
            // 
            // lb_Cam1AddL1J2Y3
            // 
            this.lb_Cam1AddL1J2Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J2Y3.Name = "lb_Cam1AddL1J2Y3";
            this.lb_Cam1AddL1J2Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2Y3.TabIndex = 5;
            this.lb_Cam1AddL1J2Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J2Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2X3
            // 
            this.lb_Cam1AddL1J2X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J2X3.Name = "lb_Cam1AddL1J2X3";
            this.lb_Cam1AddL1J2X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2X3.TabIndex = 17;
            this.lb_Cam1AddL1J2X3.Text = "点3X：";
            this.lb_Cam1AddL1J2X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J2Y3
            // 
            this.tb_Cam1AddL1J2Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J2Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2Y3.Name = "tb_Cam1AddL1J2Y3";
            this.tb_Cam1AddL1J2Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2Y3.TabIndex = 22;
            this.tb_Cam1AddL1J2Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J2Y3_TextChanged);
            // 
            // tb_Cam1AddL1J2X3
            // 
            this.tb_Cam1AddL1J2X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J2X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2X3.Name = "tb_Cam1AddL1J2X3";
            this.tb_Cam1AddL1J2X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2X3.TabIndex = 26;
            this.tb_Cam1AddL1J2X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J2X3_TextChanged);
            // 
            // lb_Cam1AddL2J2Y4
            // 
            this.lb_Cam1AddL2J2Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J2Y4.Name = "lb_Cam1AddL2J2Y4";
            this.lb_Cam1AddL2J2Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2Y4.TabIndex = 38;
            this.lb_Cam1AddL2J2Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J2Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J2X4
            // 
            this.lb_Cam1AddL2J2X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J2X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J2X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J2X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J2X4.Name = "lb_Cam1AddL2J2X4";
            this.lb_Cam1AddL2J2X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J2X4.TabIndex = 33;
            this.lb_Cam1AddL2J2X4.Text = "点4X：";
            this.lb_Cam1AddL2J2X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2Y4
            // 
            this.lb_Cam1AddL1J2Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J2Y4.Name = "lb_Cam1AddL1J2Y4";
            this.lb_Cam1AddL1J2Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2Y4.TabIndex = 21;
            this.lb_Cam1AddL1J2Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J2Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J2X4
            // 
            this.lb_Cam1AddL1J2X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J2X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J2X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J2X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J2X4.Name = "lb_Cam1AddL1J2X4";
            this.lb_Cam1AddL1J2X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J2X4.TabIndex = 16;
            this.lb_Cam1AddL1J2X4.Text = "点4X：";
            this.lb_Cam1AddL1J2X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J2Y4
            // 
            this.tb_Cam1AddL2J2Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J2Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2Y4.Name = "tb_Cam1AddL2J2Y4";
            this.tb_Cam1AddL2J2Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2Y4.TabIndex = 39;
            // 
            // tb_Cam1AddL2J2X4
            // 
            this.tb_Cam1AddL2J2X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J2X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J2X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J2X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J2X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J2X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J2X4.Name = "tb_Cam1AddL2J2X4";
            this.tb_Cam1AddL2J2X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J2X4.TabIndex = 40;
            // 
            // tb_Cam1AddL1J2Y4
            // 
            this.tb_Cam1AddL1J2Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J2Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2Y4.Name = "tb_Cam1AddL1J2Y4";
            this.tb_Cam1AddL1J2Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J2X4
            // 
            this.tb_Cam1AddL1J2X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J2X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J2X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J2X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J2X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J2X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J2X4.Name = "tb_Cam1AddL1J2X4";
            this.tb_Cam1AddL1J2X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J2X4.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 45);
            this.label5.TabIndex = 47;
            this.label5.Text = "夹具2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1300, 552);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "夹具3补偿";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 16;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddR2J3Y, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddR2J3X, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label52, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddR1J3Y, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddR1J3X, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddR2J3Y, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddR2J3X, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddR1J3Y, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddR1J3X, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3Y1, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3X1, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label64, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3Y1, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3X1, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label55, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3Y1, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3X1, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3Y1, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3X1, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3Y2, 5, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3X2, 5, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3Y2, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3X2, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3Y2, 6, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3X2, 6, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3Y2, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3X2, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3Y3, 7, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3X3, 7, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3Y3, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3X3, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3Y3, 8, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3X3, 8, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3Y3, 8, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3X3, 8, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3Y4, 9, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL2J3X4, 9, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3Y4, 9, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1AddL1J3X4, 9, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3Y4, 10, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL2J3X4, 10, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3Y4, 10, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1AddL1J3X4, 10, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 12;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lb_Cam1AddR2J3Y
            // 
            this.lb_Cam1AddR2J3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J3Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J3Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J3Y.Name = "lb_Cam1AddR2J3Y";
            this.lb_Cam1AddR2J3Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J3Y.TabIndex = 15;
            this.lb_Cam1AddR2J3Y.Text = "Y:";
            this.lb_Cam1AddR2J3Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR2J3X
            // 
            this.lb_Cam1AddR2J3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J3X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J3X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J3X.Name = "lb_Cam1AddR2J3X";
            this.lb_Cam1AddR2J3X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J3X.TabIndex = 14;
            this.lb_Cam1AddR2J3X.Text = "X：";
            this.lb_Cam1AddR2J3X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(3, 180);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(75, 45);
            this.label52.TabIndex = 13;
            this.label52.Text = "ROB2补偿";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J3Y
            // 
            this.lb_Cam1AddR1J3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J3Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J3Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J3Y.Name = "lb_Cam1AddR1J3Y";
            this.lb_Cam1AddR1J3Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J3Y.TabIndex = 7;
            this.lb_Cam1AddR1J3Y.Text = "Y:";
            this.lb_Cam1AddR1J3Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J3X
            // 
            this.lb_Cam1AddR1J3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J3X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J3X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J3X.Name = "lb_Cam1AddR1J3X";
            this.lb_Cam1AddR1J3X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J3X.TabIndex = 3;
            this.lb_Cam1AddR1J3X.Text = "X：";
            this.lb_Cam1AddR1J3X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(3, 45);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(75, 45);
            this.label49.TabIndex = 1;
            this.label49.Text = "ROB1补偿";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J3Y
            // 
            this.tb_Cam1AddR2J3Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J3Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J3Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J3Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J3Y.Name = "tb_Cam1AddR2J3Y";
            this.tb_Cam1AddR2J3Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J3Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J3X
            // 
            this.tb_Cam1AddR2J3X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J3X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J3X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J3X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J3X.Name = "tb_Cam1AddR2J3X";
            this.tb_Cam1AddR2J3X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J3X.TabIndex = 11;
            // 
            // tb_Cam1AddR1J3Y
            // 
            this.tb_Cam1AddR1J3Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J3Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J3Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J3Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J3Y.Name = "tb_Cam1AddR1J3Y";
            this.tb_Cam1AddR1J3Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J3Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J3X
            // 
            this.tb_Cam1AddR1J3X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J3X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J3X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J3X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J3X.Name = "tb_Cam1AddR1J3X";
            this.tb_Cam1AddR1J3X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J3X.TabIndex = 2;
            // 
            // lb_Cam1AddL2J3Y1
            // 
            this.lb_Cam1AddL2J3Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J3Y1.Name = "lb_Cam1AddL2J3Y1";
            this.lb_Cam1AddL2J3Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3Y1.TabIndex = 36;
            this.lb_Cam1AddL2J3Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J3Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J3X1
            // 
            this.lb_Cam1AddL2J3X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J3X1.Name = "lb_Cam1AddL2J3X1";
            this.lb_Cam1AddL2J3X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3X1.TabIndex = 29;
            this.lb_Cam1AddL2J3X1.Text = "点1X：";
            this.lb_Cam1AddL2J3X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label64.ForeColor = System.Drawing.Color.Black;
            this.label64.Location = new System.Drawing.Point(246, 180);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(75, 45);
            this.label64.TabIndex = 28;
            this.label64.Text = "Laser2补偿";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3Y1
            // 
            this.lb_Cam1AddL1J3Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J3Y1.Name = "lb_Cam1AddL1J3Y1";
            this.lb_Cam1AddL1J3Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3Y1.TabIndex = 19;
            this.lb_Cam1AddL1J3Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J3Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3X1
            // 
            this.lb_Cam1AddL1J3X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J3X1.Name = "lb_Cam1AddL1J3X1";
            this.lb_Cam1AddL1J3X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3X1.TabIndex = 6;
            this.lb_Cam1AddL1J3X1.Text = "点1X：";
            this.lb_Cam1AddL1J3X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(246, 45);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(75, 45);
            this.label55.TabIndex = 4;
            this.label55.Text = "Laser1补偿";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J3Y1
            // 
            this.tb_Cam1AddL2J3Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J3Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3Y1.Name = "tb_Cam1AddL2J3Y1";
            this.tb_Cam1AddL2J3Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3Y1.TabIndex = 30;
            this.tb_Cam1AddL2J3Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J3Y1_TextChanged);
            // 
            // tb_Cam1AddL2J3X1
            // 
            this.tb_Cam1AddL2J3X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J3X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3X1.Name = "tb_Cam1AddL2J3X1";
            this.tb_Cam1AddL2J3X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3X1.TabIndex = 43;
            this.tb_Cam1AddL2J3X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J3X1_TextChanged);
            // 
            // tb_Cam1AddL1J3Y1
            // 
            this.tb_Cam1AddL1J3Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J3Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3Y1.Name = "tb_Cam1AddL1J3Y1";
            this.tb_Cam1AddL1J3Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3Y1.TabIndex = 9;
            this.tb_Cam1AddL1J3Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J3Y1_TextChanged);
            // 
            // tb_Cam1AddL1J3X1
            // 
            this.tb_Cam1AddL1J3X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J3X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3X1.Name = "tb_Cam1AddL1J3X1";
            this.tb_Cam1AddL1J3X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3X1.TabIndex = 10;
            this.tb_Cam1AddL1J3X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J3X1_TextChanged);
            // 
            // lb_Cam1AddL2J3Y2
            // 
            this.lb_Cam1AddL2J3Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J3Y2.Name = "lb_Cam1AddL2J3Y2";
            this.lb_Cam1AddL2J3Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3Y2.TabIndex = 35;
            this.lb_Cam1AddL2J3Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J3Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J3X2
            // 
            this.lb_Cam1AddL2J3X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J3X2.Name = "lb_Cam1AddL2J3X2";
            this.lb_Cam1AddL2J3X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3X2.TabIndex = 37;
            this.lb_Cam1AddL2J3X2.Text = "点2X：";
            this.lb_Cam1AddL2J3X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3Y2
            // 
            this.lb_Cam1AddL1J3Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J3Y2.Name = "lb_Cam1AddL1J3Y2";
            this.lb_Cam1AddL1J3Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3Y2.TabIndex = 18;
            this.lb_Cam1AddL1J3Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J3Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3X2
            // 
            this.lb_Cam1AddL1J3X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J3X2.Name = "lb_Cam1AddL1J3X2";
            this.lb_Cam1AddL1J3X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3X2.TabIndex = 20;
            this.lb_Cam1AddL1J3X2.Text = "点2X：";
            this.lb_Cam1AddL1J3X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J3Y2
            // 
            this.tb_Cam1AddL2J3Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J3Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3Y2.Name = "tb_Cam1AddL2J3Y2";
            this.tb_Cam1AddL2J3Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3Y2.TabIndex = 41;
            // 
            // tb_Cam1AddL2J3X2
            // 
            this.tb_Cam1AddL2J3X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J3X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3X2.Name = "tb_Cam1AddL2J3X2";
            this.tb_Cam1AddL2J3X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3X2.TabIndex = 42;
            // 
            // tb_Cam1AddL1J3Y2
            // 
            this.tb_Cam1AddL1J3Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J3Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3Y2.Name = "tb_Cam1AddL1J3Y2";
            this.tb_Cam1AddL1J3Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J3X2
            // 
            this.tb_Cam1AddL1J3X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J3X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3X2.Name = "tb_Cam1AddL1J3X2";
            this.tb_Cam1AddL1J3X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3X2.TabIndex = 24;
            // 
            // lb_Cam1AddL2J3Y3
            // 
            this.lb_Cam1AddL2J3Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J3Y3.Name = "lb_Cam1AddL2J3Y3";
            this.lb_Cam1AddL2J3Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3Y3.TabIndex = 31;
            this.lb_Cam1AddL2J3Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J3Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J3X3
            // 
            this.lb_Cam1AddL2J3X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J3X3.Name = "lb_Cam1AddL2J3X3";
            this.lb_Cam1AddL2J3X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3X3.TabIndex = 34;
            this.lb_Cam1AddL2J3X3.Text = "点3X：";
            this.lb_Cam1AddL2J3X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3Y3
            // 
            this.lb_Cam1AddL1J3Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J3Y3.Name = "lb_Cam1AddL1J3Y3";
            this.lb_Cam1AddL1J3Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3Y3.TabIndex = 5;
            this.lb_Cam1AddL1J3Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J3Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3X3
            // 
            this.lb_Cam1AddL1J3X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J3X3.Name = "lb_Cam1AddL1J3X3";
            this.lb_Cam1AddL1J3X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3X3.TabIndex = 17;
            this.lb_Cam1AddL1J3X3.Text = "点3X：";
            this.lb_Cam1AddL1J3X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J3Y3
            // 
            this.tb_Cam1AddL2J3Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J3Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3Y3.Name = "tb_Cam1AddL2J3Y3";
            this.tb_Cam1AddL2J3Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3Y3.TabIndex = 44;
            this.tb_Cam1AddL2J3Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J3Y3_TextChanged);
            // 
            // tb_Cam1AddL2J3X3
            // 
            this.tb_Cam1AddL2J3X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J3X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3X3.Name = "tb_Cam1AddL2J3X3";
            this.tb_Cam1AddL2J3X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3X3.TabIndex = 32;
            this.tb_Cam1AddL2J3X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J3X3_TextChanged);
            // 
            // tb_Cam1AddL1J3Y3
            // 
            this.tb_Cam1AddL1J3Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J3Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3Y3.Name = "tb_Cam1AddL1J3Y3";
            this.tb_Cam1AddL1J3Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3Y3.TabIndex = 22;
            this.tb_Cam1AddL1J3Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J3Y3_TextChanged);
            // 
            // tb_Cam1AddL1J3X3
            // 
            this.tb_Cam1AddL1J3X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J3X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3X3.Name = "tb_Cam1AddL1J3X3";
            this.tb_Cam1AddL1J3X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3X3.TabIndex = 26;
            this.tb_Cam1AddL1J3X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J3X3_TextChanged);
            // 
            // lb_Cam1AddL2J3Y4
            // 
            this.lb_Cam1AddL2J3Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J3Y4.Name = "lb_Cam1AddL2J3Y4";
            this.lb_Cam1AddL2J3Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3Y4.TabIndex = 38;
            this.lb_Cam1AddL2J3Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J3Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J3X4
            // 
            this.lb_Cam1AddL2J3X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J3X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J3X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J3X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J3X4.Name = "lb_Cam1AddL2J3X4";
            this.lb_Cam1AddL2J3X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J3X4.TabIndex = 33;
            this.lb_Cam1AddL2J3X4.Text = "点4X：";
            this.lb_Cam1AddL2J3X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3Y4
            // 
            this.lb_Cam1AddL1J3Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J3Y4.Name = "lb_Cam1AddL1J3Y4";
            this.lb_Cam1AddL1J3Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3Y4.TabIndex = 21;
            this.lb_Cam1AddL1J3Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J3Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J3X4
            // 
            this.lb_Cam1AddL1J3X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J3X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J3X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J3X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J3X4.Name = "lb_Cam1AddL1J3X4";
            this.lb_Cam1AddL1J3X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J3X4.TabIndex = 16;
            this.lb_Cam1AddL1J3X4.Text = "点4X：";
            this.lb_Cam1AddL1J3X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J3Y4
            // 
            this.tb_Cam1AddL2J3Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J3Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3Y4.Name = "tb_Cam1AddL2J3Y4";
            this.tb_Cam1AddL2J3Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3Y4.TabIndex = 39;
            // 
            // tb_Cam1AddL2J3X4
            // 
            this.tb_Cam1AddL2J3X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J3X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J3X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J3X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J3X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J3X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J3X4.Name = "tb_Cam1AddL2J3X4";
            this.tb_Cam1AddL2J3X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J3X4.TabIndex = 40;
            // 
            // tb_Cam1AddL1J3Y4
            // 
            this.tb_Cam1AddL1J3Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J3Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3Y4.Name = "tb_Cam1AddL1J3Y4";
            this.tb_Cam1AddL1J3Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J3X4
            // 
            this.tb_Cam1AddL1J3X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J3X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J3X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J3X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J3X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J3X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J3X4.Name = "tb_Cam1AddL1J3X4";
            this.tb_Cam1AddL1J3X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J3X4.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 45);
            this.label4.TabIndex = 46;
            this.label4.Text = "夹具3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1300, 552);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "夹具4补偿";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 16;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddR2J4Y, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddR2J4Y, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddR2J4X, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddR2J4X, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label76, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddR1J4Y, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddR1J4Y, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddR1J4X, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddR1J4X, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label73, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4Y1, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4Y1, 4, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4X1, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4X1, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.label88, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4Y1, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4X1, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label79, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4Y1, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4X1, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4Y2, 5, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4Y2, 6, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4Y3, 7, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4Y3, 8, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4Y4, 9, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4Y4, 10, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4X2, 5, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4X2, 6, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4X3, 7, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4X3, 8, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL2J4X4, 9, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL2J4X4, 10, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4Y2, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4X2, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4Y2, 6, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4X2, 6, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4Y3, 7, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4X3, 7, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4Y3, 8, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4X3, 8, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4Y4, 9, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1AddL1J4X4, 9, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4Y4, 10, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1AddL1J4X4, 10, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 12;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lb_Cam1AddR2J4Y
            // 
            this.lb_Cam1AddR2J4Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J4Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J4Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J4Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J4Y.Name = "lb_Cam1AddR2J4Y";
            this.lb_Cam1AddR2J4Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J4Y.TabIndex = 15;
            this.lb_Cam1AddR2J4Y.Text = "Y:";
            this.lb_Cam1AddR2J4Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J4Y
            // 
            this.tb_Cam1AddR2J4Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J4Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J4Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J4Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J4Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J4Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J4Y.Name = "tb_Cam1AddR2J4Y";
            this.tb_Cam1AddR2J4Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J4Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J4X
            // 
            this.tb_Cam1AddR2J4X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J4X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J4X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J4X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J4X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J4X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J4X.Name = "tb_Cam1AddR2J4X";
            this.tb_Cam1AddR2J4X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J4X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J4X
            // 
            this.lb_Cam1AddR2J4X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J4X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J4X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J4X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J4X.Name = "lb_Cam1AddR2J4X";
            this.lb_Cam1AddR2J4X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J4X.TabIndex = 14;
            this.lb_Cam1AddR2J4X.Text = "X：";
            this.lb_Cam1AddR2J4X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label76
            // 
            this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label76.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label76.ForeColor = System.Drawing.Color.Black;
            this.label76.Location = new System.Drawing.Point(3, 180);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(75, 45);
            this.label76.TabIndex = 13;
            this.label76.Text = "ROB2补偿";
            this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J4Y
            // 
            this.lb_Cam1AddR1J4Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J4Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J4Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J4Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J4Y.Name = "lb_Cam1AddR1J4Y";
            this.lb_Cam1AddR1J4Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J4Y.TabIndex = 7;
            this.lb_Cam1AddR1J4Y.Text = "Y:";
            this.lb_Cam1AddR1J4Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J4Y
            // 
            this.tb_Cam1AddR1J4Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J4Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J4Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J4Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J4Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J4Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J4Y.Name = "tb_Cam1AddR1J4Y";
            this.tb_Cam1AddR1J4Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J4Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J4X
            // 
            this.tb_Cam1AddR1J4X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J4X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J4X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J4X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J4X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J4X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J4X.Name = "tb_Cam1AddR1J4X";
            this.tb_Cam1AddR1J4X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J4X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J4X
            // 
            this.lb_Cam1AddR1J4X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J4X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J4X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J4X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J4X.Name = "lb_Cam1AddR1J4X";
            this.lb_Cam1AddR1J4X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J4X.TabIndex = 3;
            this.lb_Cam1AddR1J4X.Text = "X：";
            this.lb_Cam1AddR1J4X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label73
            // 
            this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label73.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label73.ForeColor = System.Drawing.Color.Black;
            this.label73.Location = new System.Drawing.Point(3, 45);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(75, 45);
            this.label73.TabIndex = 1;
            this.label73.Text = "ROB1补偿";
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J4Y1
            // 
            this.lb_Cam1AddL2J4Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J4Y1.Name = "lb_Cam1AddL2J4Y1";
            this.lb_Cam1AddL2J4Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4Y1.TabIndex = 36;
            this.lb_Cam1AddL2J4Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J4Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4Y1
            // 
            this.tb_Cam1AddL2J4Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J4Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4Y1.Name = "tb_Cam1AddL2J4Y1";
            this.tb_Cam1AddL2J4Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4Y1.TabIndex = 30;
            this.tb_Cam1AddL2J4Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J4Y1_TextChanged);
            // 
            // tb_Cam1AddL2J4X1
            // 
            this.tb_Cam1AddL2J4X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J4X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4X1.Name = "tb_Cam1AddL2J4X1";
            this.tb_Cam1AddL2J4X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4X1.TabIndex = 43;
            this.tb_Cam1AddL2J4X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J4X1_TextChanged);
            // 
            // lb_Cam1AddL2J4X1
            // 
            this.lb_Cam1AddL2J4X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J4X1.Name = "lb_Cam1AddL2J4X1";
            this.lb_Cam1AddL2J4X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4X1.TabIndex = 29;
            this.lb_Cam1AddL2J4X1.Text = "点1X：";
            this.lb_Cam1AddL2J4X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label88.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label88.ForeColor = System.Drawing.Color.Black;
            this.label88.Location = new System.Drawing.Point(246, 180);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(75, 45);
            this.label88.TabIndex = 28;
            this.label88.Text = "Laser2补偿";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J4Y1
            // 
            this.lb_Cam1AddL1J4Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J4Y1.Name = "lb_Cam1AddL1J4Y1";
            this.lb_Cam1AddL1J4Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4Y1.TabIndex = 19;
            this.lb_Cam1AddL1J4Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J4Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J4X1
            // 
            this.lb_Cam1AddL1J4X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J4X1.Name = "lb_Cam1AddL1J4X1";
            this.lb_Cam1AddL1J4X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4X1.TabIndex = 6;
            this.lb_Cam1AddL1J4X1.Text = "点1X：";
            this.lb_Cam1AddL1J4X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label79
            // 
            this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label79.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label79.ForeColor = System.Drawing.Color.Black;
            this.label79.Location = new System.Drawing.Point(246, 45);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(75, 45);
            this.label79.TabIndex = 4;
            this.label79.Text = "Laser1补偿";
            this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J4Y1
            // 
            this.tb_Cam1AddL1J4Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J4Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4Y1.Name = "tb_Cam1AddL1J4Y1";
            this.tb_Cam1AddL1J4Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4Y1.TabIndex = 9;
            this.tb_Cam1AddL1J4Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J4Y1_TextChanged);
            // 
            // tb_Cam1AddL1J4X1
            // 
            this.tb_Cam1AddL1J4X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J4X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4X1.Name = "tb_Cam1AddL1J4X1";
            this.tb_Cam1AddL1J4X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4X1.TabIndex = 10;
            this.tb_Cam1AddL1J4X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J4X1_TextChanged);
            // 
            // lb_Cam1AddL2J4Y2
            // 
            this.lb_Cam1AddL2J4Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J4Y2.Name = "lb_Cam1AddL2J4Y2";
            this.lb_Cam1AddL2J4Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4Y2.TabIndex = 35;
            this.lb_Cam1AddL2J4Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J4Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4Y2
            // 
            this.tb_Cam1AddL2J4Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J4Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4Y2.Name = "tb_Cam1AddL2J4Y2";
            this.tb_Cam1AddL2J4Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J4Y3
            // 
            this.lb_Cam1AddL2J4Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J4Y3.Name = "lb_Cam1AddL2J4Y3";
            this.lb_Cam1AddL2J4Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4Y3.TabIndex = 31;
            this.lb_Cam1AddL2J4Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J4Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4Y3
            // 
            this.tb_Cam1AddL2J4Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J4Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4Y3.Name = "tb_Cam1AddL2J4Y3";
            this.tb_Cam1AddL2J4Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4Y3.TabIndex = 44;
            this.tb_Cam1AddL2J4Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J4Y3_TextChanged);
            // 
            // lb_Cam1AddL2J4Y4
            // 
            this.lb_Cam1AddL2J4Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J4Y4.Name = "lb_Cam1AddL2J4Y4";
            this.lb_Cam1AddL2J4Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4Y4.TabIndex = 38;
            this.lb_Cam1AddL2J4Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J4Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4Y4
            // 
            this.tb_Cam1AddL2J4Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J4Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4Y4.Name = "tb_Cam1AddL2J4Y4";
            this.tb_Cam1AddL2J4Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J4X2
            // 
            this.lb_Cam1AddL2J4X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J4X2.Name = "lb_Cam1AddL2J4X2";
            this.lb_Cam1AddL2J4X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4X2.TabIndex = 37;
            this.lb_Cam1AddL2J4X2.Text = "点2X：";
            this.lb_Cam1AddL2J4X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4X2
            // 
            this.tb_Cam1AddL2J4X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J4X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4X2.Name = "tb_Cam1AddL2J4X2";
            this.tb_Cam1AddL2J4X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J4X3
            // 
            this.lb_Cam1AddL2J4X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J4X3.Name = "lb_Cam1AddL2J4X3";
            this.lb_Cam1AddL2J4X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4X3.TabIndex = 34;
            this.lb_Cam1AddL2J4X3.Text = "点3X：";
            this.lb_Cam1AddL2J4X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4X3
            // 
            this.tb_Cam1AddL2J4X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J4X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4X3.Name = "tb_Cam1AddL2J4X3";
            this.tb_Cam1AddL2J4X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4X3.TabIndex = 32;
            this.tb_Cam1AddL2J4X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J4X3_TextChanged);
            // 
            // lb_Cam1AddL2J4X4
            // 
            this.lb_Cam1AddL2J4X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J4X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J4X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J4X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J4X4.Name = "lb_Cam1AddL2J4X4";
            this.lb_Cam1AddL2J4X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J4X4.TabIndex = 33;
            this.lb_Cam1AddL2J4X4.Text = "点4X：";
            this.lb_Cam1AddL2J4X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J4X4
            // 
            this.tb_Cam1AddL2J4X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J4X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J4X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J4X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J4X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J4X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J4X4.Name = "tb_Cam1AddL2J4X4";
            this.tb_Cam1AddL2J4X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J4X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J4Y2
            // 
            this.lb_Cam1AddL1J4Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J4Y2.Name = "lb_Cam1AddL1J4Y2";
            this.lb_Cam1AddL1J4Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4Y2.TabIndex = 18;
            this.lb_Cam1AddL1J4Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J4Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J4X2
            // 
            this.lb_Cam1AddL1J4X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J4X2.Name = "lb_Cam1AddL1J4X2";
            this.lb_Cam1AddL1J4X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4X2.TabIndex = 20;
            this.lb_Cam1AddL1J4X2.Text = "点2X：";
            this.lb_Cam1AddL1J4X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J4Y2
            // 
            this.tb_Cam1AddL1J4Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J4Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4Y2.Name = "tb_Cam1AddL1J4Y2";
            this.tb_Cam1AddL1J4Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J4X2
            // 
            this.tb_Cam1AddL1J4X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J4X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4X2.Name = "tb_Cam1AddL1J4X2";
            this.tb_Cam1AddL1J4X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J4Y3
            // 
            this.lb_Cam1AddL1J4Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J4Y3.Name = "lb_Cam1AddL1J4Y3";
            this.lb_Cam1AddL1J4Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4Y3.TabIndex = 5;
            this.lb_Cam1AddL1J4Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J4Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J4X3
            // 
            this.lb_Cam1AddL1J4X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J4X3.Name = "lb_Cam1AddL1J4X3";
            this.lb_Cam1AddL1J4X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4X3.TabIndex = 17;
            this.lb_Cam1AddL1J4X3.Text = "点3X：";
            this.lb_Cam1AddL1J4X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J4Y3
            // 
            this.tb_Cam1AddL1J4Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J4Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4Y3.Name = "tb_Cam1AddL1J4Y3";
            this.tb_Cam1AddL1J4Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4Y3.TabIndex = 22;
            this.tb_Cam1AddL1J4Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J4Y3_TextChanged);
            // 
            // tb_Cam1AddL1J4X3
            // 
            this.tb_Cam1AddL1J4X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J4X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4X3.Name = "tb_Cam1AddL1J4X3";
            this.tb_Cam1AddL1J4X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4X3.TabIndex = 26;
            this.tb_Cam1AddL1J4X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J4X3_TextChanged);
            // 
            // lb_Cam1AddL1J4Y4
            // 
            this.lb_Cam1AddL1J4Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J4Y4.Name = "lb_Cam1AddL1J4Y4";
            this.lb_Cam1AddL1J4Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4Y4.TabIndex = 21;
            this.lb_Cam1AddL1J4Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J4Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J4X4
            // 
            this.lb_Cam1AddL1J4X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J4X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J4X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J4X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J4X4.Name = "lb_Cam1AddL1J4X4";
            this.lb_Cam1AddL1J4X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J4X4.TabIndex = 16;
            this.lb_Cam1AddL1J4X4.Text = "点4X：";
            this.lb_Cam1AddL1J4X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J4Y4
            // 
            this.tb_Cam1AddL1J4Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J4Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4Y4.Name = "tb_Cam1AddL1J4Y4";
            this.tb_Cam1AddL1J4Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J4X4
            // 
            this.tb_Cam1AddL1J4X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J4X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J4X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J4X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J4X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J4X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J4X4.Name = "tb_Cam1AddL1J4X4";
            this.tb_Cam1AddL1J4X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J4X4.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 45);
            this.label1.TabIndex = 45;
            this.label1.Text = "夹具4";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1300, 552);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "夹具5补偿";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 16;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddR2J5Y, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddR2J5Y, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddR2J5X, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddR2J5X, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddR1J5Y, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddR1J5Y, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddR1J5X, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddR1J5X, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5Y1, 3, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5Y1, 4, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5X1, 4, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5X1, 3, 5);
            this.tableLayoutPanel5.Controls.Add(this.label17, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5Y1, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5X1, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label20, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5Y1, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5X1, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5Y2, 5, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5Y2, 6, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5Y3, 7, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5Y3, 8, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5Y4, 9, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5Y4, 10, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5X2, 5, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5X2, 6, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5X3, 7, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5X3, 8, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL2J5X4, 9, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL2J5X4, 10, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5Y2, 5, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5X2, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5Y2, 6, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5X2, 6, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5Y3, 7, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5X3, 7, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5Y3, 8, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5X3, 8, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5Y4, 9, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1AddL1J5X4, 9, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5Y4, 10, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1AddL1J5X4, 10, 2);
            this.tableLayoutPanel5.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 12;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // lb_Cam1AddR2J5Y
            // 
            this.lb_Cam1AddR2J5Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J5Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J5Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J5Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J5Y.Name = "lb_Cam1AddR2J5Y";
            this.lb_Cam1AddR2J5Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J5Y.TabIndex = 15;
            this.lb_Cam1AddR2J5Y.Text = "Y:";
            this.lb_Cam1AddR2J5Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J5Y
            // 
            this.tb_Cam1AddR2J5Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J5Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J5Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J5Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J5Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J5Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J5Y.Name = "tb_Cam1AddR2J5Y";
            this.tb_Cam1AddR2J5Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J5Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J5X
            // 
            this.tb_Cam1AddR2J5X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J5X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J5X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J5X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J5X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J5X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J5X.Name = "tb_Cam1AddR2J5X";
            this.tb_Cam1AddR2J5X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J5X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J5X
            // 
            this.lb_Cam1AddR2J5X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J5X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J5X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J5X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J5X.Name = "lb_Cam1AddR2J5X";
            this.lb_Cam1AddR2J5X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J5X.TabIndex = 14;
            this.lb_Cam1AddR2J5X.Text = "X：";
            this.lb_Cam1AddR2J5X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 45);
            this.label10.TabIndex = 13;
            this.label10.Text = "ROB2补偿";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J5Y
            // 
            this.lb_Cam1AddR1J5Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J5Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J5Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J5Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J5Y.Name = "lb_Cam1AddR1J5Y";
            this.lb_Cam1AddR1J5Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J5Y.TabIndex = 7;
            this.lb_Cam1AddR1J5Y.Text = "Y:";
            this.lb_Cam1AddR1J5Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J5Y
            // 
            this.tb_Cam1AddR1J5Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J5Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J5Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J5Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J5Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J5Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J5Y.Name = "tb_Cam1AddR1J5Y";
            this.tb_Cam1AddR1J5Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J5Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J5X
            // 
            this.tb_Cam1AddR1J5X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J5X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J5X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J5X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J5X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J5X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J5X.Name = "tb_Cam1AddR1J5X";
            this.tb_Cam1AddR1J5X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J5X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J5X
            // 
            this.lb_Cam1AddR1J5X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J5X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J5X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J5X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J5X.Name = "lb_Cam1AddR1J5X";
            this.lb_Cam1AddR1J5X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J5X.TabIndex = 3;
            this.lb_Cam1AddR1J5X.Text = "X：";
            this.lb_Cam1AddR1J5X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 45);
            this.label13.TabIndex = 1;
            this.label13.Text = "ROB1补偿";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J5Y1
            // 
            this.lb_Cam1AddL2J5Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J5Y1.Name = "lb_Cam1AddL2J5Y1";
            this.lb_Cam1AddL2J5Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5Y1.TabIndex = 36;
            this.lb_Cam1AddL2J5Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J5Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5Y1
            // 
            this.tb_Cam1AddL2J5Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J5Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5Y1.Name = "tb_Cam1AddL2J5Y1";
            this.tb_Cam1AddL2J5Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5Y1.TabIndex = 30;
            this.tb_Cam1AddL2J5Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J5Y1_TextChanged);
            // 
            // tb_Cam1AddL2J5X1
            // 
            this.tb_Cam1AddL2J5X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J5X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5X1.Name = "tb_Cam1AddL2J5X1";
            this.tb_Cam1AddL2J5X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5X1.TabIndex = 43;
            this.tb_Cam1AddL2J5X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J5X1_TextChanged);
            // 
            // lb_Cam1AddL2J5X1
            // 
            this.lb_Cam1AddL2J5X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J5X1.Name = "lb_Cam1AddL2J5X1";
            this.lb_Cam1AddL2J5X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5X1.TabIndex = 29;
            this.lb_Cam1AddL2J5X1.Text = "点1X：";
            this.lb_Cam1AddL2J5X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(246, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 45);
            this.label17.TabIndex = 28;
            this.label17.Text = "Laser2补偿";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J5Y1
            // 
            this.lb_Cam1AddL1J5Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J5Y1.Name = "lb_Cam1AddL1J5Y1";
            this.lb_Cam1AddL1J5Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5Y1.TabIndex = 19;
            this.lb_Cam1AddL1J5Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J5Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J5X1
            // 
            this.lb_Cam1AddL1J5X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J5X1.Name = "lb_Cam1AddL1J5X1";
            this.lb_Cam1AddL1J5X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5X1.TabIndex = 6;
            this.lb_Cam1AddL1J5X1.Text = "点1X：";
            this.lb_Cam1AddL1J5X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(246, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 45);
            this.label20.TabIndex = 4;
            this.label20.Text = "Laser1补偿";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J5Y1
            // 
            this.tb_Cam1AddL1J5Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J5Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5Y1.Name = "tb_Cam1AddL1J5Y1";
            this.tb_Cam1AddL1J5Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5Y1.TabIndex = 9;
            this.tb_Cam1AddL1J5Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J5Y1_TextChanged);
            // 
            // tb_Cam1AddL1J5X1
            // 
            this.tb_Cam1AddL1J5X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J5X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5X1.Name = "tb_Cam1AddL1J5X1";
            this.tb_Cam1AddL1J5X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5X1.TabIndex = 10;
            this.tb_Cam1AddL1J5X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J5X1_TextChanged);
            // 
            // lb_Cam1AddL2J5Y2
            // 
            this.lb_Cam1AddL2J5Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J5Y2.Name = "lb_Cam1AddL2J5Y2";
            this.lb_Cam1AddL2J5Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5Y2.TabIndex = 35;
            this.lb_Cam1AddL2J5Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J5Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5Y2
            // 
            this.tb_Cam1AddL2J5Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J5Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5Y2.Name = "tb_Cam1AddL2J5Y2";
            this.tb_Cam1AddL2J5Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J5Y3
            // 
            this.lb_Cam1AddL2J5Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J5Y3.Name = "lb_Cam1AddL2J5Y3";
            this.lb_Cam1AddL2J5Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5Y3.TabIndex = 31;
            this.lb_Cam1AddL2J5Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J5Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5Y3
            // 
            this.tb_Cam1AddL2J5Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J5Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5Y3.Name = "tb_Cam1AddL2J5Y3";
            this.tb_Cam1AddL2J5Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5Y3.TabIndex = 44;
            this.tb_Cam1AddL2J5Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J5Y3_TextChanged);
            // 
            // lb_Cam1AddL2J5Y4
            // 
            this.lb_Cam1AddL2J5Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J5Y4.Name = "lb_Cam1AddL2J5Y4";
            this.lb_Cam1AddL2J5Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5Y4.TabIndex = 38;
            this.lb_Cam1AddL2J5Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J5Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5Y4
            // 
            this.tb_Cam1AddL2J5Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J5Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5Y4.Name = "tb_Cam1AddL2J5Y4";
            this.tb_Cam1AddL2J5Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J5X2
            // 
            this.lb_Cam1AddL2J5X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J5X2.Name = "lb_Cam1AddL2J5X2";
            this.lb_Cam1AddL2J5X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5X2.TabIndex = 37;
            this.lb_Cam1AddL2J5X2.Text = "点2X：";
            this.lb_Cam1AddL2J5X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5X2
            // 
            this.tb_Cam1AddL2J5X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J5X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5X2.Name = "tb_Cam1AddL2J5X2";
            this.tb_Cam1AddL2J5X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J5X3
            // 
            this.lb_Cam1AddL2J5X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J5X3.Name = "lb_Cam1AddL2J5X3";
            this.lb_Cam1AddL2J5X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5X3.TabIndex = 34;
            this.lb_Cam1AddL2J5X3.Text = "点3X：";
            this.lb_Cam1AddL2J5X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5X3
            // 
            this.tb_Cam1AddL2J5X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J5X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5X3.Name = "tb_Cam1AddL2J5X3";
            this.tb_Cam1AddL2J5X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5X3.TabIndex = 32;
            this.tb_Cam1AddL2J5X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J5X3_TextChanged);
            // 
            // lb_Cam1AddL2J5X4
            // 
            this.lb_Cam1AddL2J5X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J5X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J5X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J5X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J5X4.Name = "lb_Cam1AddL2J5X4";
            this.lb_Cam1AddL2J5X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J5X4.TabIndex = 33;
            this.lb_Cam1AddL2J5X4.Text = "点4X：";
            this.lb_Cam1AddL2J5X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J5X4
            // 
            this.tb_Cam1AddL2J5X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J5X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J5X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J5X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J5X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J5X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J5X4.Name = "tb_Cam1AddL2J5X4";
            this.tb_Cam1AddL2J5X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J5X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J5Y2
            // 
            this.lb_Cam1AddL1J5Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J5Y2.Name = "lb_Cam1AddL1J5Y2";
            this.lb_Cam1AddL1J5Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5Y2.TabIndex = 18;
            this.lb_Cam1AddL1J5Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J5Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J5X2
            // 
            this.lb_Cam1AddL1J5X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J5X2.Name = "lb_Cam1AddL1J5X2";
            this.lb_Cam1AddL1J5X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5X2.TabIndex = 20;
            this.lb_Cam1AddL1J5X2.Text = "点2X：";
            this.lb_Cam1AddL1J5X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J5Y2
            // 
            this.tb_Cam1AddL1J5Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J5Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5Y2.Name = "tb_Cam1AddL1J5Y2";
            this.tb_Cam1AddL1J5Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J5X2
            // 
            this.tb_Cam1AddL1J5X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J5X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5X2.Name = "tb_Cam1AddL1J5X2";
            this.tb_Cam1AddL1J5X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J5Y3
            // 
            this.lb_Cam1AddL1J5Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J5Y3.Name = "lb_Cam1AddL1J5Y3";
            this.lb_Cam1AddL1J5Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5Y3.TabIndex = 5;
            this.lb_Cam1AddL1J5Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J5Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J5X3
            // 
            this.lb_Cam1AddL1J5X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J5X3.Name = "lb_Cam1AddL1J5X3";
            this.lb_Cam1AddL1J5X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5X3.TabIndex = 17;
            this.lb_Cam1AddL1J5X3.Text = "点3X：";
            this.lb_Cam1AddL1J5X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J5Y3
            // 
            this.tb_Cam1AddL1J5Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J5Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5Y3.Name = "tb_Cam1AddL1J5Y3";
            this.tb_Cam1AddL1J5Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5Y3.TabIndex = 22;
            this.tb_Cam1AddL1J5Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J5Y3_TextChanged);
            // 
            // tb_Cam1AddL1J5X3
            // 
            this.tb_Cam1AddL1J5X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J5X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5X3.Name = "tb_Cam1AddL1J5X3";
            this.tb_Cam1AddL1J5X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5X3.TabIndex = 26;
            this.tb_Cam1AddL1J5X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J5X3_TextChanged);
            // 
            // lb_Cam1AddL1J5Y4
            // 
            this.lb_Cam1AddL1J5Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J5Y4.Name = "lb_Cam1AddL1J5Y4";
            this.lb_Cam1AddL1J5Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5Y4.TabIndex = 21;
            this.lb_Cam1AddL1J5Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J5Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J5X4
            // 
            this.lb_Cam1AddL1J5X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J5X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J5X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J5X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J5X4.Name = "lb_Cam1AddL1J5X4";
            this.lb_Cam1AddL1J5X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J5X4.TabIndex = 16;
            this.lb_Cam1AddL1J5X4.Text = "点4X：";
            this.lb_Cam1AddL1J5X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J5Y4
            // 
            this.tb_Cam1AddL1J5Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J5Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5Y4.Name = "tb_Cam1AddL1J5Y4";
            this.tb_Cam1AddL1J5Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J5X4
            // 
            this.tb_Cam1AddL1J5X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J5X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J5X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J5X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J5X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J5X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J5X4.Name = "tb_Cam1AddL1J5X4";
            this.tb_Cam1AddL1J5X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J5X4.TabIndex = 25;
            // 
            // label36
            // 
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 45);
            this.label36.TabIndex = 45;
            this.label36.Text = "夹具5";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1300, 552);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "夹具6补偿";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 16;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddR2J6Y, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddR2J6Y, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddR2J6X, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddR2J6X, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label39, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddR1J6Y, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddR1J6Y, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddR1J6X, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddR1J6X, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label43, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6Y1, 3, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6Y1, 4, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6X1, 4, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6X1, 3, 5);
            this.tableLayoutPanel6.Controls.Add(this.label46, 3, 4);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6Y1, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6X1, 3, 2);
            this.tableLayoutPanel6.Controls.Add(this.label50, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6Y1, 4, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6X1, 4, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6Y2, 5, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6Y2, 6, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6Y3, 7, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6Y3, 8, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6Y4, 9, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6Y4, 10, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6X2, 5, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6X2, 6, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6X3, 7, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6X3, 8, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL2J6X4, 9, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL2J6X4, 10, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6Y2, 5, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6X2, 5, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6Y2, 6, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6X2, 6, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6Y3, 7, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6X3, 7, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6Y3, 8, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6X3, 8, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6Y4, 9, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1AddL1J6X4, 9, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6Y4, 10, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1AddL1J6X4, 10, 2);
            this.tableLayoutPanel6.Controls.Add(this.label66, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 12;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // lb_Cam1AddR2J6Y
            // 
            this.lb_Cam1AddR2J6Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J6Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J6Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J6Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J6Y.Name = "lb_Cam1AddR2J6Y";
            this.lb_Cam1AddR2J6Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J6Y.TabIndex = 15;
            this.lb_Cam1AddR2J6Y.Text = "Y:";
            this.lb_Cam1AddR2J6Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J6Y
            // 
            this.tb_Cam1AddR2J6Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J6Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J6Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J6Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J6Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J6Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J6Y.Name = "tb_Cam1AddR2J6Y";
            this.tb_Cam1AddR2J6Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J6Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J6X
            // 
            this.tb_Cam1AddR2J6X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J6X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J6X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J6X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J6X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J6X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J6X.Name = "tb_Cam1AddR2J6X";
            this.tb_Cam1AddR2J6X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J6X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J6X
            // 
            this.lb_Cam1AddR2J6X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J6X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J6X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J6X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J6X.Name = "lb_Cam1AddR2J6X";
            this.lb_Cam1AddR2J6X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J6X.TabIndex = 14;
            this.lb_Cam1AddR2J6X.Text = "X：";
            this.lb_Cam1AddR2J6X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(3, 180);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(75, 45);
            this.label39.TabIndex = 13;
            this.label39.Text = "ROB2补偿";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J6Y
            // 
            this.lb_Cam1AddR1J6Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J6Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J6Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J6Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J6Y.Name = "lb_Cam1AddR1J6Y";
            this.lb_Cam1AddR1J6Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J6Y.TabIndex = 7;
            this.lb_Cam1AddR1J6Y.Text = "Y:";
            this.lb_Cam1AddR1J6Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J6Y
            // 
            this.tb_Cam1AddR1J6Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J6Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J6Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J6Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J6Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J6Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J6Y.Name = "tb_Cam1AddR1J6Y";
            this.tb_Cam1AddR1J6Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J6Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J6X
            // 
            this.tb_Cam1AddR1J6X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J6X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J6X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J6X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J6X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J6X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J6X.Name = "tb_Cam1AddR1J6X";
            this.tb_Cam1AddR1J6X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J6X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J6X
            // 
            this.lb_Cam1AddR1J6X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J6X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J6X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J6X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J6X.Name = "lb_Cam1AddR1J6X";
            this.lb_Cam1AddR1J6X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J6X.TabIndex = 3;
            this.lb_Cam1AddR1J6X.Text = "X：";
            this.lb_Cam1AddR1J6X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(3, 45);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(75, 45);
            this.label43.TabIndex = 1;
            this.label43.Text = "ROB1补偿";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J6Y1
            // 
            this.lb_Cam1AddL2J6Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J6Y1.Name = "lb_Cam1AddL2J6Y1";
            this.lb_Cam1AddL2J6Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6Y1.TabIndex = 36;
            this.lb_Cam1AddL2J6Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J6Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6Y1
            // 
            this.tb_Cam1AddL2J6Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J6Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6Y1.Name = "tb_Cam1AddL2J6Y1";
            this.tb_Cam1AddL2J6Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6Y1.TabIndex = 30;
            this.tb_Cam1AddL2J6Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J6Y1_TextChanged);
            // 
            // tb_Cam1AddL2J6X1
            // 
            this.tb_Cam1AddL2J6X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J6X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6X1.Name = "tb_Cam1AddL2J6X1";
            this.tb_Cam1AddL2J6X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6X1.TabIndex = 43;
            this.tb_Cam1AddL2J6X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J6X1_TextChanged);
            // 
            // lb_Cam1AddL2J6X1
            // 
            this.lb_Cam1AddL2J6X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J6X1.Name = "lb_Cam1AddL2J6X1";
            this.lb_Cam1AddL2J6X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6X1.TabIndex = 29;
            this.lb_Cam1AddL2J6X1.Text = "点1X：";
            this.lb_Cam1AddL2J6X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label46.ForeColor = System.Drawing.Color.Black;
            this.label46.Location = new System.Drawing.Point(246, 180);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(75, 45);
            this.label46.TabIndex = 28;
            this.label46.Text = "Laser2补偿";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J6Y1
            // 
            this.lb_Cam1AddL1J6Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J6Y1.Name = "lb_Cam1AddL1J6Y1";
            this.lb_Cam1AddL1J6Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6Y1.TabIndex = 19;
            this.lb_Cam1AddL1J6Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J6Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J6X1
            // 
            this.lb_Cam1AddL1J6X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J6X1.Name = "lb_Cam1AddL1J6X1";
            this.lb_Cam1AddL1J6X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6X1.TabIndex = 6;
            this.lb_Cam1AddL1J6X1.Text = "点1X：";
            this.lb_Cam1AddL1J6X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label50.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(246, 45);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(75, 45);
            this.label50.TabIndex = 4;
            this.label50.Text = "Laser1补偿";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J6Y1
            // 
            this.tb_Cam1AddL1J6Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J6Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6Y1.Name = "tb_Cam1AddL1J6Y1";
            this.tb_Cam1AddL1J6Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6Y1.TabIndex = 9;
            this.tb_Cam1AddL1J6Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J6Y1_TextChanged);
            // 
            // tb_Cam1AddL1J6X1
            // 
            this.tb_Cam1AddL1J6X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J6X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6X1.Name = "tb_Cam1AddL1J6X1";
            this.tb_Cam1AddL1J6X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6X1.TabIndex = 10;
            this.tb_Cam1AddL1J6X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J6X1_TextChanged);
            // 
            // lb_Cam1AddL2J6Y2
            // 
            this.lb_Cam1AddL2J6Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J6Y2.Name = "lb_Cam1AddL2J6Y2";
            this.lb_Cam1AddL2J6Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6Y2.TabIndex = 35;
            this.lb_Cam1AddL2J6Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J6Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6Y2
            // 
            this.tb_Cam1AddL2J6Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J6Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6Y2.Name = "tb_Cam1AddL2J6Y2";
            this.tb_Cam1AddL2J6Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J6Y3
            // 
            this.lb_Cam1AddL2J6Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J6Y3.Name = "lb_Cam1AddL2J6Y3";
            this.lb_Cam1AddL2J6Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6Y3.TabIndex = 31;
            this.lb_Cam1AddL2J6Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J6Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6Y3
            // 
            this.tb_Cam1AddL2J6Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J6Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6Y3.Name = "tb_Cam1AddL2J6Y3";
            this.tb_Cam1AddL2J6Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6Y3.TabIndex = 44;
            this.tb_Cam1AddL2J6Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J6Y3_TextChanged);
            // 
            // lb_Cam1AddL2J6Y4
            // 
            this.lb_Cam1AddL2J6Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J6Y4.Name = "lb_Cam1AddL2J6Y4";
            this.lb_Cam1AddL2J6Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6Y4.TabIndex = 38;
            this.lb_Cam1AddL2J6Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J6Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6Y4
            // 
            this.tb_Cam1AddL2J6Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J6Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6Y4.Name = "tb_Cam1AddL2J6Y4";
            this.tb_Cam1AddL2J6Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J6X2
            // 
            this.lb_Cam1AddL2J6X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J6X2.Name = "lb_Cam1AddL2J6X2";
            this.lb_Cam1AddL2J6X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6X2.TabIndex = 37;
            this.lb_Cam1AddL2J6X2.Text = "点2X：";
            this.lb_Cam1AddL2J6X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6X2
            // 
            this.tb_Cam1AddL2J6X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J6X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6X2.Name = "tb_Cam1AddL2J6X2";
            this.tb_Cam1AddL2J6X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J6X3
            // 
            this.lb_Cam1AddL2J6X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J6X3.Name = "lb_Cam1AddL2J6X3";
            this.lb_Cam1AddL2J6X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6X3.TabIndex = 34;
            this.lb_Cam1AddL2J6X3.Text = "点3X：";
            this.lb_Cam1AddL2J6X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6X3
            // 
            this.tb_Cam1AddL2J6X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J6X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6X3.Name = "tb_Cam1AddL2J6X3";
            this.tb_Cam1AddL2J6X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6X3.TabIndex = 32;
            this.tb_Cam1AddL2J6X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J6X3_TextChanged);
            // 
            // lb_Cam1AddL2J6X4
            // 
            this.lb_Cam1AddL2J6X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J6X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J6X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J6X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J6X4.Name = "lb_Cam1AddL2J6X4";
            this.lb_Cam1AddL2J6X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J6X4.TabIndex = 33;
            this.lb_Cam1AddL2J6X4.Text = "点4X：";
            this.lb_Cam1AddL2J6X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J6X4
            // 
            this.tb_Cam1AddL2J6X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J6X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J6X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J6X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J6X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J6X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J6X4.Name = "tb_Cam1AddL2J6X4";
            this.tb_Cam1AddL2J6X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J6X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J6Y2
            // 
            this.lb_Cam1AddL1J6Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J6Y2.Name = "lb_Cam1AddL1J6Y2";
            this.lb_Cam1AddL1J6Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6Y2.TabIndex = 18;
            this.lb_Cam1AddL1J6Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J6Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J6X2
            // 
            this.lb_Cam1AddL1J6X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J6X2.Name = "lb_Cam1AddL1J6X2";
            this.lb_Cam1AddL1J6X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6X2.TabIndex = 20;
            this.lb_Cam1AddL1J6X2.Text = "点2X：";
            this.lb_Cam1AddL1J6X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J6Y2
            // 
            this.tb_Cam1AddL1J6Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J6Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6Y2.Name = "tb_Cam1AddL1J6Y2";
            this.tb_Cam1AddL1J6Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J6X2
            // 
            this.tb_Cam1AddL1J6X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J6X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6X2.Name = "tb_Cam1AddL1J6X2";
            this.tb_Cam1AddL1J6X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J6Y3
            // 
            this.lb_Cam1AddL1J6Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J6Y3.Name = "lb_Cam1AddL1J6Y3";
            this.lb_Cam1AddL1J6Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6Y3.TabIndex = 5;
            this.lb_Cam1AddL1J6Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J6Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J6X3
            // 
            this.lb_Cam1AddL1J6X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J6X3.Name = "lb_Cam1AddL1J6X3";
            this.lb_Cam1AddL1J6X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6X3.TabIndex = 17;
            this.lb_Cam1AddL1J6X3.Text = "点3X：";
            this.lb_Cam1AddL1J6X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J6Y3
            // 
            this.tb_Cam1AddL1J6Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J6Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6Y3.Name = "tb_Cam1AddL1J6Y3";
            this.tb_Cam1AddL1J6Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6Y3.TabIndex = 22;
            this.tb_Cam1AddL1J6Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J6Y3_TextChanged);
            // 
            // tb_Cam1AddL1J6X3
            // 
            this.tb_Cam1AddL1J6X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J6X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6X3.Name = "tb_Cam1AddL1J6X3";
            this.tb_Cam1AddL1J6X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6X3.TabIndex = 26;
            this.tb_Cam1AddL1J6X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J6X3_TextChanged);
            // 
            // lb_Cam1AddL1J6Y4
            // 
            this.lb_Cam1AddL1J6Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J6Y4.Name = "lb_Cam1AddL1J6Y4";
            this.lb_Cam1AddL1J6Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6Y4.TabIndex = 21;
            this.lb_Cam1AddL1J6Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J6Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J6X4
            // 
            this.lb_Cam1AddL1J6X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J6X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J6X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J6X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J6X4.Name = "lb_Cam1AddL1J6X4";
            this.lb_Cam1AddL1J6X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J6X4.TabIndex = 16;
            this.lb_Cam1AddL1J6X4.Text = "点4X：";
            this.lb_Cam1AddL1J6X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J6Y4
            // 
            this.tb_Cam1AddL1J6Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J6Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6Y4.Name = "tb_Cam1AddL1J6Y4";
            this.tb_Cam1AddL1J6Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J6X4
            // 
            this.tb_Cam1AddL1J6X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J6X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J6X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J6X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J6X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J6X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J6X4.Name = "tb_Cam1AddL1J6X4";
            this.tb_Cam1AddL1J6X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J6X4.TabIndex = 25;
            // 
            // label66
            // 
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label66.ForeColor = System.Drawing.Color.Black;
            this.label66.Location = new System.Drawing.Point(3, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(75, 45);
            this.label66.TabIndex = 45;
            this.label66.Text = "夹具6";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tableLayoutPanel7);
            this.tabPage7.Location = new System.Drawing.Point(4, 44);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1300, 552);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "夹具7补偿";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 16;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddR2J7Y, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddR2J7Y, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddR2J7X, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddR2J7X, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label69, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddR1J7Y, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddR1J7Y, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddR1J7X, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddR1J7X, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label72, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7Y1, 3, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7Y1, 4, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7X1, 4, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7X1, 3, 5);
            this.tableLayoutPanel7.Controls.Add(this.label77, 3, 4);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7Y1, 3, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7X1, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.label81, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7Y1, 4, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7X1, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7Y2, 5, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7Y2, 6, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7Y3, 7, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7Y3, 8, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7Y4, 9, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7Y4, 10, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7X2, 5, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7X2, 6, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7X3, 7, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7X3, 8, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL2J7X4, 9, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL2J7X4, 10, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7Y2, 5, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7X2, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7Y2, 6, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7X2, 6, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7Y3, 7, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7X3, 7, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7Y3, 8, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7X3, 8, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7Y4, 9, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1AddL1J7X4, 9, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7Y4, 10, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1AddL1J7X4, 10, 2);
            this.tableLayoutPanel7.Controls.Add(this.label95, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 12;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // lb_Cam1AddR2J7Y
            // 
            this.lb_Cam1AddR2J7Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J7Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J7Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J7Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J7Y.Name = "lb_Cam1AddR2J7Y";
            this.lb_Cam1AddR2J7Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J7Y.TabIndex = 15;
            this.lb_Cam1AddR2J7Y.Text = "Y:";
            this.lb_Cam1AddR2J7Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J7Y
            // 
            this.tb_Cam1AddR2J7Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J7Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J7Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J7Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J7Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J7Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J7Y.Name = "tb_Cam1AddR2J7Y";
            this.tb_Cam1AddR2J7Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J7Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J7X
            // 
            this.tb_Cam1AddR2J7X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J7X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J7X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J7X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J7X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J7X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J7X.Name = "tb_Cam1AddR2J7X";
            this.tb_Cam1AddR2J7X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J7X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J7X
            // 
            this.lb_Cam1AddR2J7X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J7X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J7X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J7X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J7X.Name = "lb_Cam1AddR2J7X";
            this.lb_Cam1AddR2J7X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J7X.TabIndex = 14;
            this.lb_Cam1AddR2J7X.Text = "X：";
            this.lb_Cam1AddR2J7X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label69
            // 
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label69.ForeColor = System.Drawing.Color.Black;
            this.label69.Location = new System.Drawing.Point(3, 180);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(75, 45);
            this.label69.TabIndex = 13;
            this.label69.Text = "ROB2补偿";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J7Y
            // 
            this.lb_Cam1AddR1J7Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J7Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J7Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J7Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J7Y.Name = "lb_Cam1AddR1J7Y";
            this.lb_Cam1AddR1J7Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J7Y.TabIndex = 7;
            this.lb_Cam1AddR1J7Y.Text = "Y:";
            this.lb_Cam1AddR1J7Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J7Y
            // 
            this.tb_Cam1AddR1J7Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J7Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J7Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J7Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J7Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J7Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J7Y.Name = "tb_Cam1AddR1J7Y";
            this.tb_Cam1AddR1J7Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J7Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J7X
            // 
            this.tb_Cam1AddR1J7X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J7X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J7X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J7X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J7X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J7X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J7X.Name = "tb_Cam1AddR1J7X";
            this.tb_Cam1AddR1J7X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J7X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J7X
            // 
            this.lb_Cam1AddR1J7X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J7X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J7X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J7X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J7X.Name = "lb_Cam1AddR1J7X";
            this.lb_Cam1AddR1J7X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J7X.TabIndex = 3;
            this.lb_Cam1AddR1J7X.Text = "X：";
            this.lb_Cam1AddR1J7X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label72
            // 
            this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label72.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label72.ForeColor = System.Drawing.Color.Black;
            this.label72.Location = new System.Drawing.Point(3, 45);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(75, 45);
            this.label72.TabIndex = 1;
            this.label72.Text = "ROB1补偿";
            this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J7Y1
            // 
            this.lb_Cam1AddL2J7Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J7Y1.Name = "lb_Cam1AddL2J7Y1";
            this.lb_Cam1AddL2J7Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7Y1.TabIndex = 36;
            this.lb_Cam1AddL2J7Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J7Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7Y1
            // 
            this.tb_Cam1AddL2J7Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J7Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7Y1.Name = "tb_Cam1AddL2J7Y1";
            this.tb_Cam1AddL2J7Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7Y1.TabIndex = 30;
            this.tb_Cam1AddL2J7Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J7Y1_TextChanged);
            // 
            // tb_Cam1AddL2J7X1
            // 
            this.tb_Cam1AddL2J7X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J7X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7X1.Name = "tb_Cam1AddL2J7X1";
            this.tb_Cam1AddL2J7X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7X1.TabIndex = 43;
            this.tb_Cam1AddL2J7X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J7X1_TextChanged);
            // 
            // lb_Cam1AddL2J7X1
            // 
            this.lb_Cam1AddL2J7X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J7X1.Name = "lb_Cam1AddL2J7X1";
            this.lb_Cam1AddL2J7X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7X1.TabIndex = 29;
            this.lb_Cam1AddL2J7X1.Text = "点1X：";
            this.lb_Cam1AddL2J7X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label77
            // 
            this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label77.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.Location = new System.Drawing.Point(246, 180);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(75, 45);
            this.label77.TabIndex = 28;
            this.label77.Text = "Laser2补偿";
            this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J7Y1
            // 
            this.lb_Cam1AddL1J7Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J7Y1.Name = "lb_Cam1AddL1J7Y1";
            this.lb_Cam1AddL1J7Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7Y1.TabIndex = 19;
            this.lb_Cam1AddL1J7Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J7Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J7X1
            // 
            this.lb_Cam1AddL1J7X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J7X1.Name = "lb_Cam1AddL1J7X1";
            this.lb_Cam1AddL1J7X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7X1.TabIndex = 6;
            this.lb_Cam1AddL1J7X1.Text = "点1X：";
            this.lb_Cam1AddL1J7X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label81
            // 
            this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label81.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label81.ForeColor = System.Drawing.Color.Black;
            this.label81.Location = new System.Drawing.Point(246, 45);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 45);
            this.label81.TabIndex = 4;
            this.label81.Text = "Laser1补偿";
            this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J7Y1
            // 
            this.tb_Cam1AddL1J7Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J7Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7Y1.Name = "tb_Cam1AddL1J7Y1";
            this.tb_Cam1AddL1J7Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7Y1.TabIndex = 9;
            this.tb_Cam1AddL1J7Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J7Y1_TextChanged);
            // 
            // tb_Cam1AddL1J7X1
            // 
            this.tb_Cam1AddL1J7X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J7X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7X1.Name = "tb_Cam1AddL1J7X1";
            this.tb_Cam1AddL1J7X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7X1.TabIndex = 10;
            this.tb_Cam1AddL1J7X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J7X1_TextChanged);
            // 
            // lb_Cam1AddL2J7Y2
            // 
            this.lb_Cam1AddL2J7Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J7Y2.Name = "lb_Cam1AddL2J7Y2";
            this.lb_Cam1AddL2J7Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7Y2.TabIndex = 35;
            this.lb_Cam1AddL2J7Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J7Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7Y2
            // 
            this.tb_Cam1AddL2J7Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J7Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7Y2.Name = "tb_Cam1AddL2J7Y2";
            this.tb_Cam1AddL2J7Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J7Y3
            // 
            this.lb_Cam1AddL2J7Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J7Y3.Name = "lb_Cam1AddL2J7Y3";
            this.lb_Cam1AddL2J7Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7Y3.TabIndex = 31;
            this.lb_Cam1AddL2J7Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J7Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7Y3
            // 
            this.tb_Cam1AddL2J7Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J7Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7Y3.Name = "tb_Cam1AddL2J7Y3";
            this.tb_Cam1AddL2J7Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7Y3.TabIndex = 44;
            this.tb_Cam1AddL2J7Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J7Y3_TextChanged);
            // 
            // lb_Cam1AddL2J7Y4
            // 
            this.lb_Cam1AddL2J7Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J7Y4.Name = "lb_Cam1AddL2J7Y4";
            this.lb_Cam1AddL2J7Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7Y4.TabIndex = 38;
            this.lb_Cam1AddL2J7Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J7Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7Y4
            // 
            this.tb_Cam1AddL2J7Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J7Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7Y4.Name = "tb_Cam1AddL2J7Y4";
            this.tb_Cam1AddL2J7Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J7X2
            // 
            this.lb_Cam1AddL2J7X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J7X2.Name = "lb_Cam1AddL2J7X2";
            this.lb_Cam1AddL2J7X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7X2.TabIndex = 37;
            this.lb_Cam1AddL2J7X2.Text = "点2X：";
            this.lb_Cam1AddL2J7X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7X2
            // 
            this.tb_Cam1AddL2J7X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J7X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7X2.Name = "tb_Cam1AddL2J7X2";
            this.tb_Cam1AddL2J7X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J7X3
            // 
            this.lb_Cam1AddL2J7X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J7X3.Name = "lb_Cam1AddL2J7X3";
            this.lb_Cam1AddL2J7X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7X3.TabIndex = 34;
            this.lb_Cam1AddL2J7X3.Text = "点3X：";
            this.lb_Cam1AddL2J7X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7X3
            // 
            this.tb_Cam1AddL2J7X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J7X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7X3.Name = "tb_Cam1AddL2J7X3";
            this.tb_Cam1AddL2J7X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7X3.TabIndex = 32;
            this.tb_Cam1AddL2J7X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J7X3_TextChanged);
            // 
            // lb_Cam1AddL2J7X4
            // 
            this.lb_Cam1AddL2J7X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J7X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J7X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J7X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J7X4.Name = "lb_Cam1AddL2J7X4";
            this.lb_Cam1AddL2J7X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J7X4.TabIndex = 33;
            this.lb_Cam1AddL2J7X4.Text = "点4X：";
            this.lb_Cam1AddL2J7X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J7X4
            // 
            this.tb_Cam1AddL2J7X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J7X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J7X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J7X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J7X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J7X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J7X4.Name = "tb_Cam1AddL2J7X4";
            this.tb_Cam1AddL2J7X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J7X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J7Y2
            // 
            this.lb_Cam1AddL1J7Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J7Y2.Name = "lb_Cam1AddL1J7Y2";
            this.lb_Cam1AddL1J7Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7Y2.TabIndex = 18;
            this.lb_Cam1AddL1J7Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J7Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J7X2
            // 
            this.lb_Cam1AddL1J7X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J7X2.Name = "lb_Cam1AddL1J7X2";
            this.lb_Cam1AddL1J7X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7X2.TabIndex = 20;
            this.lb_Cam1AddL1J7X2.Text = "点2X：";
            this.lb_Cam1AddL1J7X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J7Y2
            // 
            this.tb_Cam1AddL1J7Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J7Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7Y2.Name = "tb_Cam1AddL1J7Y2";
            this.tb_Cam1AddL1J7Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J7X2
            // 
            this.tb_Cam1AddL1J7X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J7X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7X2.Name = "tb_Cam1AddL1J7X2";
            this.tb_Cam1AddL1J7X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J7Y3
            // 
            this.lb_Cam1AddL1J7Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J7Y3.Name = "lb_Cam1AddL1J7Y3";
            this.lb_Cam1AddL1J7Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7Y3.TabIndex = 5;
            this.lb_Cam1AddL1J7Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J7Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J7X3
            // 
            this.lb_Cam1AddL1J7X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J7X3.Name = "lb_Cam1AddL1J7X3";
            this.lb_Cam1AddL1J7X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7X3.TabIndex = 17;
            this.lb_Cam1AddL1J7X3.Text = "点3X：";
            this.lb_Cam1AddL1J7X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J7Y3
            // 
            this.tb_Cam1AddL1J7Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J7Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7Y3.Name = "tb_Cam1AddL1J7Y3";
            this.tb_Cam1AddL1J7Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7Y3.TabIndex = 22;
            this.tb_Cam1AddL1J7Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J7Y3_TextChanged);
            // 
            // tb_Cam1AddL1J7X3
            // 
            this.tb_Cam1AddL1J7X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J7X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7X3.Name = "tb_Cam1AddL1J7X3";
            this.tb_Cam1AddL1J7X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7X3.TabIndex = 26;
            this.tb_Cam1AddL1J7X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J7X3_TextChanged);
            // 
            // lb_Cam1AddL1J7Y4
            // 
            this.lb_Cam1AddL1J7Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J7Y4.Name = "lb_Cam1AddL1J7Y4";
            this.lb_Cam1AddL1J7Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7Y4.TabIndex = 21;
            this.lb_Cam1AddL1J7Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J7Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J7X4
            // 
            this.lb_Cam1AddL1J7X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J7X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J7X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J7X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J7X4.Name = "lb_Cam1AddL1J7X4";
            this.lb_Cam1AddL1J7X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J7X4.TabIndex = 16;
            this.lb_Cam1AddL1J7X4.Text = "点4X：";
            this.lb_Cam1AddL1J7X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J7Y4
            // 
            this.tb_Cam1AddL1J7Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J7Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7Y4.Name = "tb_Cam1AddL1J7Y4";
            this.tb_Cam1AddL1J7Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J7X4
            // 
            this.tb_Cam1AddL1J7X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J7X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J7X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J7X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J7X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J7X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J7X4.Name = "tb_Cam1AddL1J7X4";
            this.tb_Cam1AddL1J7X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J7X4.TabIndex = 25;
            // 
            // label95
            // 
            this.label95.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label95.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label95.ForeColor = System.Drawing.Color.Black;
            this.label95.Location = new System.Drawing.Point(3, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(75, 45);
            this.label95.TabIndex = 45;
            this.label95.Text = "夹具7";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tableLayoutPanel8);
            this.tabPage8.Location = new System.Drawing.Point(4, 44);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1300, 552);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "夹具8补偿";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel8.ColumnCount = 16;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddR2J8Y, 0, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddR2J8Y, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddR2J8X, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddR2J8X, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.label98, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddR1J8Y, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddR1J8Y, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddR1J8X, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddR1J8X, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label101, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8Y1, 3, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8Y1, 4, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8X1, 4, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8X1, 3, 5);
            this.tableLayoutPanel8.Controls.Add(this.label104, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8Y1, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8X1, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.label107, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8Y1, 4, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8X1, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8Y2, 5, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8Y2, 6, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8Y3, 7, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8Y3, 8, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8Y4, 9, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8Y4, 10, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8X2, 5, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8X2, 6, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8X3, 7, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8X3, 8, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL2J8X4, 9, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL2J8X4, 10, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8Y2, 5, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8X2, 5, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8Y2, 6, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8X2, 6, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8Y3, 7, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8X3, 7, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8Y3, 8, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8X3, 8, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8Y4, 9, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1AddL1J8X4, 9, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8Y4, 10, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1AddL1J8X4, 10, 2);
            this.tableLayoutPanel8.Controls.Add(this.label120, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 12;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel8.TabIndex = 5;
            // 
            // lb_Cam1AddR2J8Y
            // 
            this.lb_Cam1AddR2J8Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J8Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J8Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J8Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J8Y.Name = "lb_Cam1AddR2J8Y";
            this.lb_Cam1AddR2J8Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J8Y.TabIndex = 15;
            this.lb_Cam1AddR2J8Y.Text = "Y:";
            this.lb_Cam1AddR2J8Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J8Y
            // 
            this.tb_Cam1AddR2J8Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J8Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J8Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J8Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J8Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J8Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J8Y.Name = "tb_Cam1AddR2J8Y";
            this.tb_Cam1AddR2J8Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J8Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J8X
            // 
            this.tb_Cam1AddR2J8X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J8X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J8X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J8X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J8X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J8X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J8X.Name = "tb_Cam1AddR2J8X";
            this.tb_Cam1AddR2J8X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J8X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J8X
            // 
            this.lb_Cam1AddR2J8X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J8X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J8X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J8X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J8X.Name = "lb_Cam1AddR2J8X";
            this.lb_Cam1AddR2J8X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J8X.TabIndex = 14;
            this.lb_Cam1AddR2J8X.Text = "X：";
            this.lb_Cam1AddR2J8X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label98
            // 
            this.label98.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label98.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label98.ForeColor = System.Drawing.Color.Black;
            this.label98.Location = new System.Drawing.Point(3, 180);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(75, 45);
            this.label98.TabIndex = 13;
            this.label98.Text = "ROB2补偿";
            this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J8Y
            // 
            this.lb_Cam1AddR1J8Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J8Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J8Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J8Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J8Y.Name = "lb_Cam1AddR1J8Y";
            this.lb_Cam1AddR1J8Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J8Y.TabIndex = 7;
            this.lb_Cam1AddR1J8Y.Text = "Y:";
            this.lb_Cam1AddR1J8Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J8Y
            // 
            this.tb_Cam1AddR1J8Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J8Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J8Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J8Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J8Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J8Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J8Y.Name = "tb_Cam1AddR1J8Y";
            this.tb_Cam1AddR1J8Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J8Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J8X
            // 
            this.tb_Cam1AddR1J8X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J8X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J8X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J8X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J8X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J8X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J8X.Name = "tb_Cam1AddR1J8X";
            this.tb_Cam1AddR1J8X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J8X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J8X
            // 
            this.lb_Cam1AddR1J8X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J8X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J8X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J8X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J8X.Name = "lb_Cam1AddR1J8X";
            this.lb_Cam1AddR1J8X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J8X.TabIndex = 3;
            this.lb_Cam1AddR1J8X.Text = "X：";
            this.lb_Cam1AddR1J8X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label101
            // 
            this.label101.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label101.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label101.ForeColor = System.Drawing.Color.Black;
            this.label101.Location = new System.Drawing.Point(3, 45);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(75, 45);
            this.label101.TabIndex = 1;
            this.label101.Text = "ROB1补偿";
            this.label101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J8Y1
            // 
            this.lb_Cam1AddL2J8Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J8Y1.Name = "lb_Cam1AddL2J8Y1";
            this.lb_Cam1AddL2J8Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8Y1.TabIndex = 36;
            this.lb_Cam1AddL2J8Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J8Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8Y1
            // 
            this.tb_Cam1AddL2J8Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J8Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8Y1.Name = "tb_Cam1AddL2J8Y1";
            this.tb_Cam1AddL2J8Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8Y1.TabIndex = 30;
            this.tb_Cam1AddL2J8Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J8Y1_TextChanged);
            // 
            // tb_Cam1AddL2J8X1
            // 
            this.tb_Cam1AddL2J8X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J8X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8X1.Name = "tb_Cam1AddL2J8X1";
            this.tb_Cam1AddL2J8X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8X1.TabIndex = 43;
            this.tb_Cam1AddL2J8X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J8X1_TextChanged);
            // 
            // lb_Cam1AddL2J8X1
            // 
            this.lb_Cam1AddL2J8X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J8X1.Name = "lb_Cam1AddL2J8X1";
            this.lb_Cam1AddL2J8X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8X1.TabIndex = 29;
            this.lb_Cam1AddL2J8X1.Text = "点1X：";
            this.lb_Cam1AddL2J8X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label104
            // 
            this.label104.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label104.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label104.ForeColor = System.Drawing.Color.Black;
            this.label104.Location = new System.Drawing.Point(246, 180);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(75, 45);
            this.label104.TabIndex = 28;
            this.label104.Text = "Laser2补偿";
            this.label104.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J8Y1
            // 
            this.lb_Cam1AddL1J8Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J8Y1.Name = "lb_Cam1AddL1J8Y1";
            this.lb_Cam1AddL1J8Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8Y1.TabIndex = 19;
            this.lb_Cam1AddL1J8Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J8Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J8X1
            // 
            this.lb_Cam1AddL1J8X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J8X1.Name = "lb_Cam1AddL1J8X1";
            this.lb_Cam1AddL1J8X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8X1.TabIndex = 6;
            this.lb_Cam1AddL1J8X1.Text = "点1X：";
            this.lb_Cam1AddL1J8X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label107
            // 
            this.label107.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label107.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label107.ForeColor = System.Drawing.Color.Black;
            this.label107.Location = new System.Drawing.Point(246, 45);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(75, 45);
            this.label107.TabIndex = 4;
            this.label107.Text = "Laser1补偿";
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J8Y1
            // 
            this.tb_Cam1AddL1J8Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J8Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8Y1.Name = "tb_Cam1AddL1J8Y1";
            this.tb_Cam1AddL1J8Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8Y1.TabIndex = 9;
            this.tb_Cam1AddL1J8Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J8Y1_TextChanged);
            // 
            // tb_Cam1AddL1J8X1
            // 
            this.tb_Cam1AddL1J8X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J8X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8X1.Name = "tb_Cam1AddL1J8X1";
            this.tb_Cam1AddL1J8X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8X1.TabIndex = 10;
            this.tb_Cam1AddL1J8X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J8X1_TextChanged);
            // 
            // lb_Cam1AddL2J8Y2
            // 
            this.lb_Cam1AddL2J8Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J8Y2.Name = "lb_Cam1AddL2J8Y2";
            this.lb_Cam1AddL2J8Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8Y2.TabIndex = 35;
            this.lb_Cam1AddL2J8Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J8Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8Y2
            // 
            this.tb_Cam1AddL2J8Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J8Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8Y2.Name = "tb_Cam1AddL2J8Y2";
            this.tb_Cam1AddL2J8Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J8Y3
            // 
            this.lb_Cam1AddL2J8Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J8Y3.Name = "lb_Cam1AddL2J8Y3";
            this.lb_Cam1AddL2J8Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8Y3.TabIndex = 31;
            this.lb_Cam1AddL2J8Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J8Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8Y3
            // 
            this.tb_Cam1AddL2J8Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J8Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8Y3.Name = "tb_Cam1AddL2J8Y3";
            this.tb_Cam1AddL2J8Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8Y3.TabIndex = 44;
            this.tb_Cam1AddL2J8Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J8Y3_TextChanged);
            // 
            // lb_Cam1AddL2J8Y4
            // 
            this.lb_Cam1AddL2J8Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J8Y4.Name = "lb_Cam1AddL2J8Y4";
            this.lb_Cam1AddL2J8Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8Y4.TabIndex = 38;
            this.lb_Cam1AddL2J8Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J8Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8Y4
            // 
            this.tb_Cam1AddL2J8Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J8Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8Y4.Name = "tb_Cam1AddL2J8Y4";
            this.tb_Cam1AddL2J8Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J8X2
            // 
            this.lb_Cam1AddL2J8X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J8X2.Name = "lb_Cam1AddL2J8X2";
            this.lb_Cam1AddL2J8X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8X2.TabIndex = 37;
            this.lb_Cam1AddL2J8X2.Text = "点2X：";
            this.lb_Cam1AddL2J8X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8X2
            // 
            this.tb_Cam1AddL2J8X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J8X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8X2.Name = "tb_Cam1AddL2J8X2";
            this.tb_Cam1AddL2J8X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J8X3
            // 
            this.lb_Cam1AddL2J8X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J8X3.Name = "lb_Cam1AddL2J8X3";
            this.lb_Cam1AddL2J8X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8X3.TabIndex = 34;
            this.lb_Cam1AddL2J8X3.Text = "点3X：";
            this.lb_Cam1AddL2J8X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8X3
            // 
            this.tb_Cam1AddL2J8X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J8X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8X3.Name = "tb_Cam1AddL2J8X3";
            this.tb_Cam1AddL2J8X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8X3.TabIndex = 32;
            this.tb_Cam1AddL2J8X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J8X3_TextChanged);
            // 
            // lb_Cam1AddL2J8X4
            // 
            this.lb_Cam1AddL2J8X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J8X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J8X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J8X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J8X4.Name = "lb_Cam1AddL2J8X4";
            this.lb_Cam1AddL2J8X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J8X4.TabIndex = 33;
            this.lb_Cam1AddL2J8X4.Text = "点4X：";
            this.lb_Cam1AddL2J8X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J8X4
            // 
            this.tb_Cam1AddL2J8X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J8X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J8X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J8X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J8X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J8X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J8X4.Name = "tb_Cam1AddL2J8X4";
            this.tb_Cam1AddL2J8X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J8X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J8Y2
            // 
            this.lb_Cam1AddL1J8Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J8Y2.Name = "lb_Cam1AddL1J8Y2";
            this.lb_Cam1AddL1J8Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8Y2.TabIndex = 18;
            this.lb_Cam1AddL1J8Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J8Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J8X2
            // 
            this.lb_Cam1AddL1J8X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J8X2.Name = "lb_Cam1AddL1J8X2";
            this.lb_Cam1AddL1J8X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8X2.TabIndex = 20;
            this.lb_Cam1AddL1J8X2.Text = "点2X：";
            this.lb_Cam1AddL1J8X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J8Y2
            // 
            this.tb_Cam1AddL1J8Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J8Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8Y2.Name = "tb_Cam1AddL1J8Y2";
            this.tb_Cam1AddL1J8Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J8X2
            // 
            this.tb_Cam1AddL1J8X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J8X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8X2.Name = "tb_Cam1AddL1J8X2";
            this.tb_Cam1AddL1J8X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J8Y3
            // 
            this.lb_Cam1AddL1J8Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J8Y3.Name = "lb_Cam1AddL1J8Y3";
            this.lb_Cam1AddL1J8Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8Y3.TabIndex = 5;
            this.lb_Cam1AddL1J8Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J8Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J8X3
            // 
            this.lb_Cam1AddL1J8X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J8X3.Name = "lb_Cam1AddL1J8X3";
            this.lb_Cam1AddL1J8X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8X3.TabIndex = 17;
            this.lb_Cam1AddL1J8X3.Text = "点3X：";
            this.lb_Cam1AddL1J8X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J8Y3
            // 
            this.tb_Cam1AddL1J8Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J8Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8Y3.Name = "tb_Cam1AddL1J8Y3";
            this.tb_Cam1AddL1J8Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8Y3.TabIndex = 22;
            this.tb_Cam1AddL1J8Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J8Y3_TextChanged);
            // 
            // tb_Cam1AddL1J8X3
            // 
            this.tb_Cam1AddL1J8X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J8X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8X3.Name = "tb_Cam1AddL1J8X3";
            this.tb_Cam1AddL1J8X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8X3.TabIndex = 26;
            this.tb_Cam1AddL1J8X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J8X3_TextChanged);
            // 
            // lb_Cam1AddL1J8Y4
            // 
            this.lb_Cam1AddL1J8Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J8Y4.Name = "lb_Cam1AddL1J8Y4";
            this.lb_Cam1AddL1J8Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8Y4.TabIndex = 21;
            this.lb_Cam1AddL1J8Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J8Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J8X4
            // 
            this.lb_Cam1AddL1J8X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J8X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J8X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J8X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J8X4.Name = "lb_Cam1AddL1J8X4";
            this.lb_Cam1AddL1J8X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J8X4.TabIndex = 16;
            this.lb_Cam1AddL1J8X4.Text = "点4X：";
            this.lb_Cam1AddL1J8X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J8Y4
            // 
            this.tb_Cam1AddL1J8Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J8Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8Y4.Name = "tb_Cam1AddL1J8Y4";
            this.tb_Cam1AddL1J8Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J8X4
            // 
            this.tb_Cam1AddL1J8X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J8X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J8X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J8X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J8X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J8X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J8X4.Name = "tb_Cam1AddL1J8X4";
            this.tb_Cam1AddL1J8X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J8X4.TabIndex = 25;
            // 
            // label120
            // 
            this.label120.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label120.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label120.ForeColor = System.Drawing.Color.Black;
            this.label120.Location = new System.Drawing.Point(3, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(75, 45);
            this.label120.TabIndex = 45;
            this.label120.Text = "夹具8";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.tableLayoutPanel9);
            this.tabPage9.Location = new System.Drawing.Point(4, 44);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1300, 552);
            this.tabPage9.TabIndex = 9;
            this.tabPage9.Text = "夹具9补偿";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel9.ColumnCount = 16;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250626F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.250625F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.248125F));
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddR2J9Y, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddR2J9Y, 1, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddR2J9X, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddR2J9X, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.label123, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddR1J9Y, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddR1J9Y, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddR1J9X, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddR1J9X, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label126, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9Y1, 3, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9Y1, 4, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9X1, 4, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9X1, 3, 5);
            this.tableLayoutPanel9.Controls.Add(this.label129, 3, 4);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9Y1, 3, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9X1, 3, 2);
            this.tableLayoutPanel9.Controls.Add(this.label132, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9Y1, 4, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9X1, 4, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9Y2, 5, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9Y2, 6, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9Y3, 7, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9Y3, 8, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9Y4, 9, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9Y4, 10, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9X2, 5, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9X2, 6, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9X3, 7, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9X3, 8, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL2J9X4, 9, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL2J9X4, 10, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9Y2, 5, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9X2, 5, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9Y2, 6, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9X2, 6, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9Y3, 7, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9X3, 7, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9Y3, 8, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9X3, 8, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9Y4, 9, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1AddL1J9X4, 9, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9Y4, 10, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1AddL1J9X4, 10, 2);
            this.tableLayoutPanel9.Controls.Add(this.label145, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 12;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1300, 552);
            this.tableLayoutPanel9.TabIndex = 5;
            // 
            // lb_Cam1AddR2J9Y
            // 
            this.lb_Cam1AddR2J9Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J9Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J9Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J9Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1AddR2J9Y.Name = "lb_Cam1AddR2J9Y";
            this.lb_Cam1AddR2J9Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J9Y.TabIndex = 15;
            this.lb_Cam1AddR2J9Y.Text = "Y:";
            this.lb_Cam1AddR2J9Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR2J9Y
            // 
            this.tb_Cam1AddR2J9Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J9Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J9Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J9Y.Location = new System.Drawing.Point(85, 275);
            this.tb_Cam1AddR2J9Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J9Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J9Y.Name = "tb_Cam1AddR2J9Y";
            this.tb_Cam1AddR2J9Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J9Y.TabIndex = 8;
            // 
            // tb_Cam1AddR2J9X
            // 
            this.tb_Cam1AddR2J9X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR2J9X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR2J9X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR2J9X.Location = new System.Drawing.Point(85, 230);
            this.tb_Cam1AddR2J9X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR2J9X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR2J9X.Name = "tb_Cam1AddR2J9X";
            this.tb_Cam1AddR2J9X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR2J9X.TabIndex = 11;
            // 
            // lb_Cam1AddR2J9X
            // 
            this.lb_Cam1AddR2J9X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR2J9X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR2J9X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR2J9X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1AddR2J9X.Name = "lb_Cam1AddR2J9X";
            this.lb_Cam1AddR2J9X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR2J9X.TabIndex = 14;
            this.lb_Cam1AddR2J9X.Text = "X：";
            this.lb_Cam1AddR2J9X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label123.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label123.ForeColor = System.Drawing.Color.Black;
            this.label123.Location = new System.Drawing.Point(3, 180);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(75, 45);
            this.label123.TabIndex = 13;
            this.label123.Text = "ROB2补偿";
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddR1J9Y
            // 
            this.lb_Cam1AddR1J9Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J9Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J9Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J9Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1AddR1J9Y.Name = "lb_Cam1AddR1J9Y";
            this.lb_Cam1AddR1J9Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J9Y.TabIndex = 7;
            this.lb_Cam1AddR1J9Y.Text = "Y:";
            this.lb_Cam1AddR1J9Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddR1J9Y
            // 
            this.tb_Cam1AddR1J9Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J9Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J9Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J9Y.Location = new System.Drawing.Point(85, 140);
            this.tb_Cam1AddR1J9Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J9Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J9Y.Name = "tb_Cam1AddR1J9Y";
            this.tb_Cam1AddR1J9Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J9Y.TabIndex = 12;
            // 
            // tb_Cam1AddR1J9X
            // 
            this.tb_Cam1AddR1J9X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddR1J9X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddR1J9X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddR1J9X.Location = new System.Drawing.Point(85, 95);
            this.tb_Cam1AddR1J9X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddR1J9X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddR1J9X.Name = "tb_Cam1AddR1J9X";
            this.tb_Cam1AddR1J9X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddR1J9X.TabIndex = 2;
            // 
            // lb_Cam1AddR1J9X
            // 
            this.lb_Cam1AddR1J9X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddR1J9X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddR1J9X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddR1J9X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1AddR1J9X.Name = "lb_Cam1AddR1J9X";
            this.lb_Cam1AddR1J9X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddR1J9X.TabIndex = 3;
            this.lb_Cam1AddR1J9X.Text = "X：";
            this.lb_Cam1AddR1J9X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label126
            // 
            this.label126.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label126.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label126.ForeColor = System.Drawing.Color.Black;
            this.label126.Location = new System.Drawing.Point(3, 45);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(75, 45);
            this.label126.TabIndex = 1;
            this.label126.Text = "ROB1补偿";
            this.label126.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL2J9Y1
            // 
            this.lb_Cam1AddL2J9Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9Y1.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1AddL2J9Y1.Name = "lb_Cam1AddL2J9Y1";
            this.lb_Cam1AddL2J9Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9Y1.TabIndex = 36;
            this.lb_Cam1AddL2J9Y1.Text = "点1Y：";
            this.lb_Cam1AddL2J9Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9Y1
            // 
            this.tb_Cam1AddL2J9Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9Y1.Location = new System.Drawing.Point(328, 275);
            this.tb_Cam1AddL2J9Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9Y1.Name = "tb_Cam1AddL2J9Y1";
            this.tb_Cam1AddL2J9Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9Y1.TabIndex = 30;
            this.tb_Cam1AddL2J9Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J9Y1_TextChanged);
            // 
            // tb_Cam1AddL2J9X1
            // 
            this.tb_Cam1AddL2J9X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9X1.Location = new System.Drawing.Point(328, 230);
            this.tb_Cam1AddL2J9X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9X1.Name = "tb_Cam1AddL2J9X1";
            this.tb_Cam1AddL2J9X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9X1.TabIndex = 43;
            this.tb_Cam1AddL2J9X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J9X1_TextChanged);
            // 
            // lb_Cam1AddL2J9X1
            // 
            this.lb_Cam1AddL2J9X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9X1.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1AddL2J9X1.Name = "lb_Cam1AddL2J9X1";
            this.lb_Cam1AddL2J9X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9X1.TabIndex = 29;
            this.lb_Cam1AddL2J9X1.Text = "点1X：";
            this.lb_Cam1AddL2J9X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label129
            // 
            this.label129.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label129.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label129.ForeColor = System.Drawing.Color.Black;
            this.label129.Location = new System.Drawing.Point(246, 180);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(75, 45);
            this.label129.TabIndex = 28;
            this.label129.Text = "Laser2补偿";
            this.label129.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J9Y1
            // 
            this.lb_Cam1AddL1J9Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9Y1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9Y1.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1AddL1J9Y1.Name = "lb_Cam1AddL1J9Y1";
            this.lb_Cam1AddL1J9Y1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9Y1.TabIndex = 19;
            this.lb_Cam1AddL1J9Y1.Text = "点1Y：";
            this.lb_Cam1AddL1J9Y1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J9X1
            // 
            this.lb_Cam1AddL1J9X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9X1.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9X1.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1AddL1J9X1.Name = "lb_Cam1AddL1J9X1";
            this.lb_Cam1AddL1J9X1.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9X1.TabIndex = 6;
            this.lb_Cam1AddL1J9X1.Text = "点1X：";
            this.lb_Cam1AddL1J9X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label132
            // 
            this.label132.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label132.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label132.ForeColor = System.Drawing.Color.Black;
            this.label132.Location = new System.Drawing.Point(246, 45);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(75, 45);
            this.label132.TabIndex = 4;
            this.label132.Text = "Laser1补偿";
            this.label132.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J9Y1
            // 
            this.tb_Cam1AddL1J9Y1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9Y1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9Y1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9Y1.Location = new System.Drawing.Point(328, 140);
            this.tb_Cam1AddL1J9Y1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9Y1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9Y1.Name = "tb_Cam1AddL1J9Y1";
            this.tb_Cam1AddL1J9Y1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9Y1.TabIndex = 9;
            this.tb_Cam1AddL1J9Y1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J9Y1_TextChanged);
            // 
            // tb_Cam1AddL1J9X1
            // 
            this.tb_Cam1AddL1J9X1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9X1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9X1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9X1.Location = new System.Drawing.Point(328, 95);
            this.tb_Cam1AddL1J9X1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9X1.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9X1.Name = "tb_Cam1AddL1J9X1";
            this.tb_Cam1AddL1J9X1.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9X1.TabIndex = 10;
            this.tb_Cam1AddL1J9X1.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J9X1_TextChanged);
            // 
            // lb_Cam1AddL2J9Y2
            // 
            this.lb_Cam1AddL2J9Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9Y2.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1AddL2J9Y2.Name = "lb_Cam1AddL2J9Y2";
            this.lb_Cam1AddL2J9Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9Y2.TabIndex = 35;
            this.lb_Cam1AddL2J9Y2.Text = "点2Y：";
            this.lb_Cam1AddL2J9Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9Y2
            // 
            this.tb_Cam1AddL2J9Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9Y2.Location = new System.Drawing.Point(490, 275);
            this.tb_Cam1AddL2J9Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9Y2.Name = "tb_Cam1AddL2J9Y2";
            this.tb_Cam1AddL2J9Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9Y2.TabIndex = 41;
            // 
            // lb_Cam1AddL2J9Y3
            // 
            this.lb_Cam1AddL2J9Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9Y3.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1AddL2J9Y3.Name = "lb_Cam1AddL2J9Y3";
            this.lb_Cam1AddL2J9Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9Y3.TabIndex = 31;
            this.lb_Cam1AddL2J9Y3.Text = "点3Y:";
            this.lb_Cam1AddL2J9Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9Y3
            // 
            this.tb_Cam1AddL2J9Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9Y3.Location = new System.Drawing.Point(652, 275);
            this.tb_Cam1AddL2J9Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9Y3.Name = "tb_Cam1AddL2J9Y3";
            this.tb_Cam1AddL2J9Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9Y3.TabIndex = 44;
            this.tb_Cam1AddL2J9Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J9Y3_TextChanged);
            // 
            // lb_Cam1AddL2J9Y4
            // 
            this.lb_Cam1AddL2J9Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9Y4.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1AddL2J9Y4.Name = "lb_Cam1AddL2J9Y4";
            this.lb_Cam1AddL2J9Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9Y4.TabIndex = 38;
            this.lb_Cam1AddL2J9Y4.Text = "点4Y：";
            this.lb_Cam1AddL2J9Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9Y4
            // 
            this.tb_Cam1AddL2J9Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9Y4.Location = new System.Drawing.Point(814, 275);
            this.tb_Cam1AddL2J9Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9Y4.Name = "tb_Cam1AddL2J9Y4";
            this.tb_Cam1AddL2J9Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9Y4.TabIndex = 39;
            // 
            // lb_Cam1AddL2J9X2
            // 
            this.lb_Cam1AddL2J9X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9X2.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1AddL2J9X2.Name = "lb_Cam1AddL2J9X2";
            this.lb_Cam1AddL2J9X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9X2.TabIndex = 37;
            this.lb_Cam1AddL2J9X2.Text = "点2X：";
            this.lb_Cam1AddL2J9X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9X2
            // 
            this.tb_Cam1AddL2J9X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9X2.Location = new System.Drawing.Point(490, 230);
            this.tb_Cam1AddL2J9X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9X2.Name = "tb_Cam1AddL2J9X2";
            this.tb_Cam1AddL2J9X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9X2.TabIndex = 42;
            // 
            // lb_Cam1AddL2J9X3
            // 
            this.lb_Cam1AddL2J9X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9X3.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1AddL2J9X3.Name = "lb_Cam1AddL2J9X3";
            this.lb_Cam1AddL2J9X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9X3.TabIndex = 34;
            this.lb_Cam1AddL2J9X3.Text = "点3X：";
            this.lb_Cam1AddL2J9X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9X3
            // 
            this.tb_Cam1AddL2J9X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9X3.Location = new System.Drawing.Point(652, 230);
            this.tb_Cam1AddL2J9X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9X3.Name = "tb_Cam1AddL2J9X3";
            this.tb_Cam1AddL2J9X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9X3.TabIndex = 32;
            this.tb_Cam1AddL2J9X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL2J9X3_TextChanged);
            // 
            // lb_Cam1AddL2J9X4
            // 
            this.lb_Cam1AddL2J9X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL2J9X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL2J9X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL2J9X4.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1AddL2J9X4.Name = "lb_Cam1AddL2J9X4";
            this.lb_Cam1AddL2J9X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL2J9X4.TabIndex = 33;
            this.lb_Cam1AddL2J9X4.Text = "点4X：";
            this.lb_Cam1AddL2J9X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL2J9X4
            // 
            this.tb_Cam1AddL2J9X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL2J9X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL2J9X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL2J9X4.Location = new System.Drawing.Point(814, 230);
            this.tb_Cam1AddL2J9X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL2J9X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL2J9X4.Name = "tb_Cam1AddL2J9X4";
            this.tb_Cam1AddL2J9X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL2J9X4.TabIndex = 40;
            // 
            // lb_Cam1AddL1J9Y2
            // 
            this.lb_Cam1AddL1J9Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9Y2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9Y2.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1AddL1J9Y2.Name = "lb_Cam1AddL1J9Y2";
            this.lb_Cam1AddL1J9Y2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9Y2.TabIndex = 18;
            this.lb_Cam1AddL1J9Y2.Text = "点2Y：";
            this.lb_Cam1AddL1J9Y2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J9X2
            // 
            this.lb_Cam1AddL1J9X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9X2.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9X2.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1AddL1J9X2.Name = "lb_Cam1AddL1J9X2";
            this.lb_Cam1AddL1J9X2.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9X2.TabIndex = 20;
            this.lb_Cam1AddL1J9X2.Text = "点2X：";
            this.lb_Cam1AddL1J9X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J9Y2
            // 
            this.tb_Cam1AddL1J9Y2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9Y2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9Y2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9Y2.Location = new System.Drawing.Point(490, 140);
            this.tb_Cam1AddL1J9Y2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9Y2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9Y2.Name = "tb_Cam1AddL1J9Y2";
            this.tb_Cam1AddL1J9Y2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9Y2.TabIndex = 27;
            // 
            // tb_Cam1AddL1J9X2
            // 
            this.tb_Cam1AddL1J9X2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9X2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9X2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9X2.Location = new System.Drawing.Point(490, 95);
            this.tb_Cam1AddL1J9X2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9X2.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9X2.Name = "tb_Cam1AddL1J9X2";
            this.tb_Cam1AddL1J9X2.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9X2.TabIndex = 24;
            // 
            // lb_Cam1AddL1J9Y3
            // 
            this.lb_Cam1AddL1J9Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9Y3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9Y3.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1AddL1J9Y3.Name = "lb_Cam1AddL1J9Y3";
            this.lb_Cam1AddL1J9Y3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9Y3.TabIndex = 5;
            this.lb_Cam1AddL1J9Y3.Text = "点3Y:";
            this.lb_Cam1AddL1J9Y3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J9X3
            // 
            this.lb_Cam1AddL1J9X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9X3.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9X3.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1AddL1J9X3.Name = "lb_Cam1AddL1J9X3";
            this.lb_Cam1AddL1J9X3.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9X3.TabIndex = 17;
            this.lb_Cam1AddL1J9X3.Text = "点3X：";
            this.lb_Cam1AddL1J9X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J9Y3
            // 
            this.tb_Cam1AddL1J9Y3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9Y3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9Y3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9Y3.Location = new System.Drawing.Point(652, 140);
            this.tb_Cam1AddL1J9Y3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9Y3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9Y3.Name = "tb_Cam1AddL1J9Y3";
            this.tb_Cam1AddL1J9Y3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9Y3.TabIndex = 22;
            this.tb_Cam1AddL1J9Y3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J9Y3_TextChanged);
            // 
            // tb_Cam1AddL1J9X3
            // 
            this.tb_Cam1AddL1J9X3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9X3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9X3.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9X3.Location = new System.Drawing.Point(652, 95);
            this.tb_Cam1AddL1J9X3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9X3.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9X3.Name = "tb_Cam1AddL1J9X3";
            this.tb_Cam1AddL1J9X3.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9X3.TabIndex = 26;
            this.tb_Cam1AddL1J9X3.TextChanged += new System.EventHandler(this.tb_Cam1AddL1J9X3_TextChanged);
            // 
            // lb_Cam1AddL1J9Y4
            // 
            this.lb_Cam1AddL1J9Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9Y4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9Y4.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1AddL1J9Y4.Name = "lb_Cam1AddL1J9Y4";
            this.lb_Cam1AddL1J9Y4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9Y4.TabIndex = 21;
            this.lb_Cam1AddL1J9Y4.Text = "点4Y：";
            this.lb_Cam1AddL1J9Y4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddL1J9X4
            // 
            this.lb_Cam1AddL1J9X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddL1J9X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddL1J9X4.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddL1J9X4.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1AddL1J9X4.Name = "lb_Cam1AddL1J9X4";
            this.lb_Cam1AddL1J9X4.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1AddL1J9X4.TabIndex = 16;
            this.lb_Cam1AddL1J9X4.Text = "点4X：";
            this.lb_Cam1AddL1J9X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddL1J9Y4
            // 
            this.tb_Cam1AddL1J9Y4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9Y4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9Y4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9Y4.Location = new System.Drawing.Point(814, 140);
            this.tb_Cam1AddL1J9Y4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9Y4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9Y4.Name = "tb_Cam1AddL1J9Y4";
            this.tb_Cam1AddL1J9Y4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9Y4.TabIndex = 23;
            // 
            // tb_Cam1AddL1J9X4
            // 
            this.tb_Cam1AddL1J9X4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddL1J9X4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddL1J9X4.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddL1J9X4.Location = new System.Drawing.Point(814, 95);
            this.tb_Cam1AddL1J9X4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Cam1AddL1J9X4.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddL1J9X4.Name = "tb_Cam1AddL1J9X4";
            this.tb_Cam1AddL1J9X4.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1AddL1J9X4.TabIndex = 25;
            // 
            // label145
            // 
            this.label145.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label145.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label145.ForeColor = System.Drawing.Color.Black;
            this.label145.Location = new System.Drawing.Point(3, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(75, 45);
            this.label145.TabIndex = 45;
            this.label145.Text = "夹具9";
            this.label145.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolButtonSave
            // 
            this.uiSymbolButtonSave.BackColor = System.Drawing.Color.CadetBlue;
            this.uiSymbolButtonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButtonSave.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButtonSave.ForeColor = System.Drawing.Color.White;
            this.uiSymbolButtonSave.Location = new System.Drawing.Point(0, 0);
            this.uiSymbolButtonSave.Name = "uiSymbolButtonSave";
            this.uiSymbolButtonSave.Size = new System.Drawing.Size(1308, 46);
            this.uiSymbolButtonSave.TabIndex = 10;
            this.uiSymbolButtonSave.Text = "应用参数";
            this.uiSymbolButtonSave.UseVisualStyleBackColor = false;
            this.uiSymbolButtonSave.Click += new System.EventHandler(this.uiSymbolButtonSave_Click);
            // 
            // FrmCameraParamsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1308, 650);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1090);
            this.Name = "FrmCameraParamsSettings";
            this.Text = "相机参数设置";
            this.Load += new System.EventHandler(this.FrmCCDParamSettings_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.uiTabControlAll.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiTableLayoutPanel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button uiSymbolButtonSave;
        private SplitContainer splitContainer1;
        private TabControl uiTabControlAll;
        private TabPage uiTabPage1;
        private TableLayoutPanel uiTableLayoutPanel1;
        private TextBox tb_Cam1StdT1;
        private Label lb_Cam1StdT1;
        private TextBox tb_Cam1StdY1;
        private Label lb_Cam1StdY1;
        private Label lb_Cam1StdX1;
        private TextBox tb_Cam1StdX1;
        private Label lb_Cam1StdX2;
        private Label lb_Cam1StdY2;
        private Label lb_Cam1StdT2;
        private TextBox tb_Cam1StdX2;
        private TextBox tb_Cam1StdY2;
        private TextBox tb_Cam1StdT2;
        private Label lb_Cam1AddX1;
        private Label lb_Cam1AddY1;
        private Label lb_Cam1AddT1;
        private Label lb_Cam1AddX2;
        private Label lb_Cam1AddY2;
        private TextBox tb_Cam1AddX1;
        private TextBox tb_Cam1AddY1;
        private TextBox tb_Cam1AddT1;
        private TextBox tb_Cam1AddT2;
        private TextBox tb_Cam1AddY2;
        private TextBox tb_Cam1AddX2;
        private Label lb_Cam1StdX3;
        private Label lb_Cam1StdY3;
        private Label lb_Cam1StdT3;
        private Label lb_Cam1AddX3;
        private Label lb_Cam1AddY3;
        private Label lb_Cam1AddT3;
        private Label lb_Cam1StdX4;
        private Label lb_Cam1StdY4;
        private Label lb_Cam1StdT4;
        private Label lb_Cam1AddX4;
        private Label lb_Cam1AddY4;
        private Label lb_Cam1AddT4;
        private TextBox tb_Cam1StdX3;
        private TextBox tb_Cam1StdY3;
        private TextBox tb_Cam1StdT3;
        private TextBox tb_Cam1AddX3;
        private TextBox tb_Cam1AddY3;
        private TextBox tb_Cam1AddT3;
        private TextBox tb_Cam1StdX4;
        private TextBox tb_Cam1StdY4;
        private TextBox tb_Cam1StdT4;
        private TextBox tb_Cam1AddX4;
        private TextBox tb_Cam1AddY4;
        private TextBox tb_Cam1AddT4;
        private Button btn_GetStd1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lb_Cam1Exprosure;
        private TextBox tb_Cam1Exprosure;
        private Label lb_Cam1AddT2;
        private Label lb_Cam1Anglemin;
        private Label lb_Cam1Anglemax;
        private TextBox tb_Cam1Anglemin;
        private TextBox tb_Cam1Anglemax;
        private Label lb_Cam1Limitmin;
        private Label lb_Cam1Limitmax;
        private TextBox tb_Cam1Limitmin;
        private TextBox tb_Cam1Limitmax;
        private Label lb_Cam1OffsetX;
        private TextBox tb_Cam1OffsetX;
        private Label lb_Cam1L1CalibX0;
        private Label lb_Cam1L1CalibY0;
        private Label lb_Cam1L2CalibX0;
        private Label lb_Cam1L2CalibY0;
        private TextBox tb_Cam1L1CalibX0;
        private TextBox tb_Cam1L1CalibY0;
        private TextBox tb_Cam1L2CalibX0;
        private TextBox tb_Cam1L2CalibY0;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tb_Cam1AddR1J1X;
        private Label label3;
        private Label lb_Cam1AddR1J1X;
        private Label lb_Cam1AddR1J1Y;
        private TextBox tb_Cam1AddR1J1Y;
        private Label label7;
        private TextBox tb_Cam1AddR2J1X;
        private TextBox tb_Cam1AddR2J1Y;
        private Label lb_Cam1AddR2J1X;
        private Label lb_Cam1AddR2J1Y;
        private Label label2;
        private Label lb_Cam1AddL1J1X1;
        private TextBox tb_Cam1AddL1J1X1;
        private Label lb_Cam1AddL1J1Y2;
        private TextBox tb_Cam1AddL1J1X2;
        private TextBox tb_Cam1AddL1J1Y2;
        private Label lb_Cam1AddL1J1Y1;
        private Label lb_Cam1AddL1J1X2;
        private TextBox tb_Cam1AddL1J1Y1;
        private Label lb_Cam1AddL1J1X3;
        private TextBox tb_Cam1AddL1J1X3;
        private Label lb_Cam1AddL1J1Y3;
        private TextBox tb_Cam1AddL1J1Y3;
        private Label lb_Cam1AddL1J1X4;
        private Label lb_Cam1AddL1J1Y4;
        private TextBox tb_Cam1AddL1J1X4;
        private TextBox tb_Cam1AddL1J1Y4;
        private Label label16;
        private Label lb_Cam1AddL2J1X1;
        private Label lb_Cam1AddL2J1Y1;
        private TextBox tb_Cam1AddL2J1X1;
        private TextBox tb_Cam1AddL2J1Y1;
        private Label lb_Cam1AddL2J1X2;
        private Label lb_Cam1AddL2J1Y2;
        private Label lb_Cam1AddL2J1Y3;
        private Label lb_Cam1AddL2J1X3;
        private TextBox tb_Cam1AddL2J1X3;
        private TextBox tb_Cam1AddL2J1Y3;
        private Label lb_Cam1AddL2J1X4;
        private Label lb_Cam1AddL2J1Y4;
        private TextBox tb_Cam1AddL2J1X2;
        private TextBox tb_Cam1AddL2J1Y2;
        private TextBox tb_Cam1AddL2J1X4;
        private TextBox tb_Cam1AddL2J1Y4;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tb_Cam1AddR1J2X;
        private Label label25;
        private Label lb_Cam1AddR1J2X;
        private Label lb_Cam1AddR1J2Y;
        private TextBox tb_Cam1AddR1J2Y;
        private Label label28;
        private TextBox tb_Cam1AddR2J2X;
        private TextBox tb_Cam1AddR2J2Y;
        private Label lb_Cam1AddR2J2X;
        private Label lb_Cam1AddR2J2Y;
        private Label label31;
        private Label lb_Cam1AddL1J2X1;
        private TextBox tb_Cam1AddL1J2X1;
        private Label lb_Cam1AddL1J2Y2;
        private TextBox tb_Cam1AddL1J2X2;
        private TextBox tb_Cam1AddL1J2Y2;
        private Label lb_Cam1AddL1J2Y1;
        private Label lb_Cam1AddL1J2X2;
        private TextBox tb_Cam1AddL1J2Y1;
        private Label lb_Cam1AddL1J2X3;
        private TextBox tb_Cam1AddL1J2X3;
        private Label lb_Cam1AddL1J2Y3;
        private TextBox tb_Cam1AddL1J2Y3;
        private Label lb_Cam1AddL1J2X4;
        private Label lb_Cam1AddL1J2Y4;
        private TextBox tb_Cam1AddL1J2X4;
        private TextBox tb_Cam1AddL1J2Y4;
        private Label label40;
        private Label lb_Cam1AddL2J2X1;
        private Label lb_Cam1AddL2J2Y1;
        private TextBox tb_Cam1AddL2J2X1;
        private TextBox tb_Cam1AddL2J2Y1;
        private Label lb_Cam1AddL2J2X2;
        private Label lb_Cam1AddL2J2Y2;
        private Label lb_Cam1AddL2J2Y3;
        private Label lb_Cam1AddL2J2X3;
        private TextBox tb_Cam1AddL2J2X3;
        private TextBox tb_Cam1AddL2J2Y3;
        private Label lb_Cam1AddL2J2X4;
        private Label lb_Cam1AddL2J2Y4;
        private TextBox tb_Cam1AddL2J2X2;
        private TextBox tb_Cam1AddL2J2Y2;
        private TextBox tb_Cam1AddL2J2X4;
        private TextBox tb_Cam1AddL2J2Y4;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tb_Cam1AddR1J3X;
        private Label label49;
        private Label lb_Cam1AddR1J3X;
        private Label lb_Cam1AddR1J3Y;
        private TextBox tb_Cam1AddR1J3Y;
        private Label label52;
        private TextBox tb_Cam1AddR2J3X;
        private TextBox tb_Cam1AddR2J3Y;
        private Label lb_Cam1AddR2J3X;
        private Label lb_Cam1AddR2J3Y;
        private Label label55;
        private Label lb_Cam1AddL1J3X1;
        private TextBox tb_Cam1AddL1J3X1;
        private Label lb_Cam1AddL1J3Y2;
        private TextBox tb_Cam1AddL1J3X2;
        private TextBox tb_Cam1AddL1J3Y2;
        private Label lb_Cam1AddL1J3Y1;
        private Label lb_Cam1AddL1J3X2;
        private TextBox tb_Cam1AddL1J3Y1;
        private Label lb_Cam1AddL1J3X3;
        private TextBox tb_Cam1AddL1J3X3;
        private Label lb_Cam1AddL1J3Y3;
        private TextBox tb_Cam1AddL1J3Y3;
        private Label lb_Cam1AddL1J3X4;
        private Label lb_Cam1AddL1J3Y4;
        private TextBox tb_Cam1AddL1J3X4;
        private TextBox tb_Cam1AddL1J3Y4;
        private Label label64;
        private Label lb_Cam1AddL2J3X1;
        private Label lb_Cam1AddL2J3Y1;
        private TextBox tb_Cam1AddL2J3X1;
        private TextBox tb_Cam1AddL2J3Y1;
        private Label lb_Cam1AddL2J3X2;
        private Label lb_Cam1AddL2J3Y2;
        private Label lb_Cam1AddL2J3Y3;
        private Label lb_Cam1AddL2J3X3;
        private TextBox tb_Cam1AddL2J3X3;
        private TextBox tb_Cam1AddL2J3Y3;
        private Label lb_Cam1AddL2J3X4;
        private Label lb_Cam1AddL2J3Y4;
        private TextBox tb_Cam1AddL2J3X2;
        private TextBox tb_Cam1AddL2J3Y2;
        private TextBox tb_Cam1AddL2J3X4;
        private TextBox tb_Cam1AddL2J3Y4;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox tb_Cam1AddR1J4X;
        private Label label73;
        private Label lb_Cam1AddR1J4X;
        private Label lb_Cam1AddR1J4Y;
        private TextBox tb_Cam1AddR1J4Y;
        private Label label76;
        private TextBox tb_Cam1AddR2J4X;
        private TextBox tb_Cam1AddR2J4Y;
        private Label lb_Cam1AddR2J4X;
        private Label lb_Cam1AddR2J4Y;
        private Label label79;
        private Label lb_Cam1AddL1J4X1;
        private TextBox tb_Cam1AddL1J4X1;
        private Label lb_Cam1AddL1J4Y2;
        private TextBox tb_Cam1AddL1J4X2;
        private TextBox tb_Cam1AddL1J4Y2;
        private Label lb_Cam1AddL1J4Y1;
        private Label lb_Cam1AddL1J4X2;
        private TextBox tb_Cam1AddL1J4Y1;
        private Label lb_Cam1AddL1J4X3;
        private TextBox tb_Cam1AddL1J4X3;
        private Label lb_Cam1AddL1J4Y3;
        private TextBox tb_Cam1AddL1J4Y3;
        private Label lb_Cam1AddL1J4X4;
        private Label lb_Cam1AddL1J4Y4;
        private TextBox tb_Cam1AddL1J4X4;
        private TextBox tb_Cam1AddL1J4Y4;
        private Label label88;
        private Label lb_Cam1AddL2J4X1;
        private Label lb_Cam1AddL2J4Y1;
        private TextBox tb_Cam1AddL2J4X1;
        private TextBox tb_Cam1AddL2J4Y1;
        private Label lb_Cam1AddL2J4X2;
        private Label lb_Cam1AddL2J4Y2;
        private Label lb_Cam1AddL2J4Y3;
        private Label lb_Cam1AddL2J4X3;
        private TextBox tb_Cam1AddL2J4X3;
        private TextBox tb_Cam1AddL2J4Y3;
        private Label lb_Cam1AddL2J4X4;
        private Label lb_Cam1AddL2J4Y4;
        private TextBox tb_Cam1AddL2J4X2;
        private TextBox tb_Cam1AddL2J4Y2;
        private TextBox tb_Cam1AddL2J4X4;
        private TextBox tb_Cam1AddL2J4Y4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lb_Cam1AddR2J5Y;
        private TextBox tb_Cam1AddR2J5Y;
        private TextBox tb_Cam1AddR2J5X;
        private Label lb_Cam1AddR2J5X;
        private Label label10;
        private Label lb_Cam1AddR1J5Y;
        private TextBox tb_Cam1AddR1J5Y;
        private TextBox tb_Cam1AddR1J5X;
        private Label lb_Cam1AddR1J5X;
        private Label label13;
        private Label lb_Cam1AddL2J5Y1;
        private TextBox tb_Cam1AddL2J5Y1;
        private TextBox tb_Cam1AddL2J5X1;
        private Label lb_Cam1AddL2J5X1;
        private Label label17;
        private Label lb_Cam1AddL1J5Y1;
        private Label lb_Cam1AddL1J5X1;
        private Label label20;
        private TextBox tb_Cam1AddL1J5Y1;
        private TextBox tb_Cam1AddL1J5X1;
        private Label lb_Cam1AddL2J5Y2;
        private TextBox tb_Cam1AddL2J5Y2;
        private Label lb_Cam1AddL2J5Y3;
        private TextBox tb_Cam1AddL2J5Y3;
        private Label lb_Cam1AddL2J5Y4;
        private TextBox tb_Cam1AddL2J5Y4;
        private Label lb_Cam1AddL2J5X2;
        private TextBox tb_Cam1AddL2J5X2;
        private Label lb_Cam1AddL2J5X3;
        private TextBox tb_Cam1AddL2J5X3;
        private Label lb_Cam1AddL2J5X4;
        private TextBox tb_Cam1AddL2J5X4;
        private Label lb_Cam1AddL1J5Y2;
        private Label lb_Cam1AddL1J5X2;
        private TextBox tb_Cam1AddL1J5Y2;
        private TextBox tb_Cam1AddL1J5X2;
        private Label lb_Cam1AddL1J5Y3;
        private Label lb_Cam1AddL1J5X3;
        private TextBox tb_Cam1AddL1J5Y3;
        private TextBox tb_Cam1AddL1J5X3;
        private Label lb_Cam1AddL1J5Y4;
        private Label lb_Cam1AddL1J5X4;
        private TextBox tb_Cam1AddL1J5Y4;
        private TextBox tb_Cam1AddL1J5X4;
        private Label label36;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lb_Cam1AddR2J6Y;
        private TextBox tb_Cam1AddR2J6Y;
        private TextBox tb_Cam1AddR2J6X;
        private Label lb_Cam1AddR2J6X;
        private Label label39;
        private Label lb_Cam1AddR1J6Y;
        private TextBox tb_Cam1AddR1J6Y;
        private TextBox tb_Cam1AddR1J6X;
        private Label lb_Cam1AddR1J6X;
        private Label label43;
        private Label lb_Cam1AddL2J6Y1;
        private TextBox tb_Cam1AddL2J6Y1;
        private TextBox tb_Cam1AddL2J6X1;
        private Label lb_Cam1AddL2J6X1;
        private Label label46;
        private Label lb_Cam1AddL1J6Y1;
        private Label lb_Cam1AddL1J6X1;
        private Label label50;
        private TextBox tb_Cam1AddL1J6Y1;
        private TextBox tb_Cam1AddL1J6X1;
        private Label lb_Cam1AddL2J6Y2;
        private TextBox tb_Cam1AddL2J6Y2;
        private Label lb_Cam1AddL2J6Y3;
        private TextBox tb_Cam1AddL2J6Y3;
        private Label lb_Cam1AddL2J6Y4;
        private TextBox tb_Cam1AddL2J6Y4;
        private Label lb_Cam1AddL2J6X2;
        private TextBox tb_Cam1AddL2J6X2;
        private Label lb_Cam1AddL2J6X3;
        private TextBox tb_Cam1AddL2J6X3;
        private Label lb_Cam1AddL2J6X4;
        private TextBox tb_Cam1AddL2J6X4;
        private Label lb_Cam1AddL1J6Y2;
        private Label lb_Cam1AddL1J6X2;
        private TextBox tb_Cam1AddL1J6Y2;
        private TextBox tb_Cam1AddL1J6X2;
        private Label lb_Cam1AddL1J6Y3;
        private Label lb_Cam1AddL1J6X3;
        private TextBox tb_Cam1AddL1J6Y3;
        private TextBox tb_Cam1AddL1J6X3;
        private Label lb_Cam1AddL1J6Y4;
        private Label lb_Cam1AddL1J6X4;
        private TextBox tb_Cam1AddL1J6Y4;
        private TextBox tb_Cam1AddL1J6X4;
        private Label label66;
        private TableLayoutPanel tableLayoutPanel7;
        private Label lb_Cam1AddR2J7Y;
        private TextBox tb_Cam1AddR2J7Y;
        private TextBox tb_Cam1AddR2J7X;
        private Label lb_Cam1AddR2J7X;
        private Label label69;
        private Label lb_Cam1AddR1J7Y;
        private TextBox tb_Cam1AddR1J7Y;
        private TextBox tb_Cam1AddR1J7X;
        private Label lb_Cam1AddR1J7X;
        private Label label72;
        private Label lb_Cam1AddL2J7Y1;
        private TextBox tb_Cam1AddL2J7Y1;
        private TextBox tb_Cam1AddL2J7X1;
        private Label lb_Cam1AddL2J7X1;
        private Label label77;
        private Label lb_Cam1AddL1J7Y1;
        private Label lb_Cam1AddL1J7X1;
        private Label label81;
        private TextBox tb_Cam1AddL1J7Y1;
        private TextBox tb_Cam1AddL1J7X1;
        private Label lb_Cam1AddL2J7Y2;
        private TextBox tb_Cam1AddL2J7Y2;
        private Label lb_Cam1AddL2J7Y3;
        private TextBox tb_Cam1AddL2J7Y3;
        private Label lb_Cam1AddL2J7Y4;
        private TextBox tb_Cam1AddL2J7Y4;
        private Label lb_Cam1AddL2J7X2;
        private TextBox tb_Cam1AddL2J7X2;
        private Label lb_Cam1AddL2J7X3;
        private TextBox tb_Cam1AddL2J7X3;
        private Label lb_Cam1AddL2J7X4;
        private TextBox tb_Cam1AddL2J7X4;
        private Label lb_Cam1AddL1J7Y2;
        private Label lb_Cam1AddL1J7X2;
        private TextBox tb_Cam1AddL1J7Y2;
        private TextBox tb_Cam1AddL1J7X2;
        private Label lb_Cam1AddL1J7Y3;
        private Label lb_Cam1AddL1J7X3;
        private TextBox tb_Cam1AddL1J7Y3;
        private TextBox tb_Cam1AddL1J7X3;
        private Label lb_Cam1AddL1J7Y4;
        private Label lb_Cam1AddL1J7X4;
        private TextBox tb_Cam1AddL1J7Y4;
        private TextBox tb_Cam1AddL1J7X4;
        private Label label95;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lb_Cam1AddR2J8Y;
        private TextBox tb_Cam1AddR2J8Y;
        private TextBox tb_Cam1AddR2J8X;
        private Label lb_Cam1AddR2J8X;
        private Label label98;
        private Label lb_Cam1AddR1J8Y;
        private TextBox tb_Cam1AddR1J8Y;
        private TextBox tb_Cam1AddR1J8X;
        private Label lb_Cam1AddR1J8X;
        private Label label101;
        private Label lb_Cam1AddL2J8Y1;
        private TextBox tb_Cam1AddL2J8Y1;
        private TextBox tb_Cam1AddL2J8X1;
        private Label lb_Cam1AddL2J8X1;
        private Label label104;
        private Label lb_Cam1AddL1J8Y1;
        private Label lb_Cam1AddL1J8X1;
        private Label label107;
        private TextBox tb_Cam1AddL1J8Y1;
        private TextBox tb_Cam1AddL1J8X1;
        private Label lb_Cam1AddL2J8Y2;
        private TextBox tb_Cam1AddL2J8Y2;
        private Label lb_Cam1AddL2J8Y3;
        private TextBox tb_Cam1AddL2J8Y3;
        private Label lb_Cam1AddL2J8Y4;
        private TextBox tb_Cam1AddL2J8Y4;
        private Label lb_Cam1AddL2J8X2;
        private TextBox tb_Cam1AddL2J8X2;
        private Label lb_Cam1AddL2J8X3;
        private TextBox tb_Cam1AddL2J8X3;
        private Label lb_Cam1AddL2J8X4;
        private TextBox tb_Cam1AddL2J8X4;
        private Label lb_Cam1AddL1J8Y2;
        private Label lb_Cam1AddL1J8X2;
        private TextBox tb_Cam1AddL1J8Y2;
        private TextBox tb_Cam1AddL1J8X2;
        private Label lb_Cam1AddL1J8Y3;
        private Label lb_Cam1AddL1J8X3;
        private TextBox tb_Cam1AddL1J8Y3;
        private TextBox tb_Cam1AddL1J8X3;
        private Label lb_Cam1AddL1J8Y4;
        private Label lb_Cam1AddL1J8X4;
        private TextBox tb_Cam1AddL1J8Y4;
        private TextBox tb_Cam1AddL1J8X4;
        private Label label120;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lb_Cam1AddR2J9Y;
        private TextBox tb_Cam1AddR2J9Y;
        private TextBox tb_Cam1AddR2J9X;
        private Label lb_Cam1AddR2J9X;
        private Label label123;
        private Label lb_Cam1AddR1J9Y;
        private TextBox tb_Cam1AddR1J9Y;
        private TextBox tb_Cam1AddR1J9X;
        private Label lb_Cam1AddR1J9X;
        private Label label126;
        private Label lb_Cam1AddL2J9Y1;
        private TextBox tb_Cam1AddL2J9Y1;
        private TextBox tb_Cam1AddL2J9X1;
        private Label lb_Cam1AddL2J9X1;
        private Label label129;
        private Label lb_Cam1AddL1J9Y1;
        private Label lb_Cam1AddL1J9X1;
        private Label label132;
        private TextBox tb_Cam1AddL1J9Y1;
        private TextBox tb_Cam1AddL1J9X1;
        private Label lb_Cam1AddL2J9Y2;
        private TextBox tb_Cam1AddL2J9Y2;
        private Label lb_Cam1AddL2J9Y3;
        private TextBox tb_Cam1AddL2J9Y3;
        private Label lb_Cam1AddL2J9Y4;
        private TextBox tb_Cam1AddL2J9Y4;
        private Label lb_Cam1AddL2J9X2;
        private TextBox tb_Cam1AddL2J9X2;
        private Label lb_Cam1AddL2J9X3;
        private TextBox tb_Cam1AddL2J9X3;
        private Label lb_Cam1AddL2J9X4;
        private TextBox tb_Cam1AddL2J9X4;
        private Label lb_Cam1AddL1J9Y2;
        private Label lb_Cam1AddL1J9X2;
        private TextBox tb_Cam1AddL1J9Y2;
        private TextBox tb_Cam1AddL1J9X2;
        private Label lb_Cam1AddL1J9Y3;
        private Label lb_Cam1AddL1J9X3;
        private TextBox tb_Cam1AddL1J9Y3;
        private TextBox tb_Cam1AddL1J9X3;
        private Label lb_Cam1AddL1J9Y4;
        private Label lb_Cam1AddL1J9X4;
        private TextBox tb_Cam1AddL1J9Y4;
        private TextBox tb_Cam1AddL1J9X4;
        private Label label145;
        private Label lb_Cam1CellLineL;
        private TextBox tb_Cam1CellLineL;
        private Label lb_Cam1P2byP1X;
        private TextBox tb_Cam1P2byP1X;
        private TextBox tb_Cam1P2byP1Y;
        private Label lb_Cam1P2byP1Y;
        private Label lb_Cam1P4byP3X;
        private Label lb_Cam1P4byP3Y;
        private TextBox tb_Cam1P4byP3X;
        private TextBox tb_Cam1P4byP3Y;
        private Label lb_Cam1LaserStep;
        private TextBox tb_Cam1LaserStep;
        private TextBox tb_Cam1RobStep;
        private Label lb_Cam1RobStep;
        private Label lb_Cam1Spacing;
        private Label lb_Cam1SpacingUse;
        private Label lb_Cam1RobUse;
        private Label lb_Cam1LaserUse;
        private TextBox tb_Cam1Spacing;
        private TextBox tb_Cam1SpacingUse;
        private TextBox tb_Cam1RobUse;
        private TextBox tb_Cam1LaserUse;
        private Label lb_Cam1ALX;
        private Label lb_Cam1NI1X;
        private Label lb_Cam1NI2X;
        private Label lb_Cam1ALY;
        private Label lb_Cam1NI1Y;
        private Label lb_Cam1NI2Y;
        private TextBox tb_Cam1ALX;
        private TextBox tb_Cam1NI1X;
        private TextBox tb_Cam1NI2X;
        private TextBox tb_Cam1ALY;
        private TextBox tb_Cam1NI1Y;
        private TextBox tb_Cam1NI2Y;
        private Label lb_Cam1ALX1;
        private Label lb_Cam1ALY1;
        private Label lb_Cam1NI1X1;
        private Label lb_Cam1NI1Y1;
        private Label lb_Cam1NI2X1;
        private Label lb_Cam1NI2Y1;
        private TextBox tb_Cam1ALX1;
        private TextBox tb_Cam1ALY1;
        private TextBox tb_Cam1NI1X1;
        private TextBox tb_Cam1NI1Y1;
        private TextBox tb_Cam1NI2X1;
        private TextBox tb_Cam1NI2Y1;
    }
}