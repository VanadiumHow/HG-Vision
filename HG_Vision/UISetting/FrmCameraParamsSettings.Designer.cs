using System.Windows.Forms;
using Sunny.UI;
namespace HG_Vision.UIVision
{
    partial class FrmCameraParamsSettings : Form
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
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1StdBo1X = new System.Windows.Forms.Label();
            this.tb_Cam1StdBo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdBo2X = new System.Windows.Forms.Label();
            this.tb_Cam1StdBo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdLa1X = new System.Windows.Forms.Label();
            this.tb_Cam1StdLa1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdLa2X = new System.Windows.Forms.Label();
            this.tb_Cam1StdLa2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdBo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1StdBo1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdBo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1StdBo2Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdLa1Y = new System.Windows.Forms.Label();
            this.tb_Cam1StdLa1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdLa2Y = new System.Windows.Forms.Label();
            this.tb_Cam1StdLa2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdLa2R = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdLa1R = new System.Windows.Forms.Label();
            this.lb_Cam1StdLa2R = new System.Windows.Forms.Label();
            this.tb_Cam1StdLa1R = new System.Windows.Forms.TextBox();
            this.tb_Cam1StdBo2R = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdBo2R = new System.Windows.Forms.Label();
            this.tb_Cam1StdBo1R = new System.Windows.Forms.TextBox();
            this.lb_Cam1StdBo1R = new System.Windows.Forms.Label();
            this.btn_GetStd1 = new System.Windows.Forms.Button();
            this.btn_GetStd2 = new System.Windows.Forms.Button();
            this.btn_GetStd3 = new System.Windows.Forms.Button();
            this.btn_GetStd4 = new System.Windows.Forms.Button();
            this.tb_Cam1AddLa2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa2X = new System.Windows.Forms.Label();
            this.tb_Cam1AddLa1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa1X = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddBo2X = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddBo1X = new System.Windows.Forms.Label();
            this.lb_Cam1AddBo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddBo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo2Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa1Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddLa1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa2Y = new System.Windows.Forms.Label();
            this.tb_Cam1AddLa2Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa2R = new System.Windows.Forms.Label();
            this.tb_Cam1AddLa2R = new System.Windows.Forms.TextBox();
            this.tb_Cam1AddLa1R = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddLa1R = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo2R = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddBo2R = new System.Windows.Forms.Label();
            this.tb_Cam1AddBo1R = new System.Windows.Forms.TextBox();
            this.lb_Cam1AddBo1R = new System.Windows.Forms.Label();
            this.lb_Cam1Exprosure = new System.Windows.Forms.Label();
            this.tb_Cam1Exprosure = new System.Windows.Forms.TextBox();
            this.lb_Cam1P2byP1X = new System.Windows.Forms.Label();
            this.tb_Cam1P2byP1X = new System.Windows.Forms.TextBox();
            this.tb_Cam1P2byP1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1P2byP1Y = new System.Windows.Forms.Label();
            this.tb_Cam1P4byP3X = new System.Windows.Forms.TextBox();
            this.lb_Cam1P4byP3X = new System.Windows.Forms.Label();
            this.tb_Cam1P4byP3Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1P4byP3Y = new System.Windows.Forms.Label();
            this.lb_Cam1AngleMax = new System.Windows.Forms.Label();
            this.tb_Cam1AngleMax = new System.Windows.Forms.TextBox();
            this.lb_Cam1CenterLa1X = new System.Windows.Forms.Label();
            this.tb_Cam1CenterLa1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1CenterLa1Y = new System.Windows.Forms.Label();
            this.tb_Cam1CenterLa1Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1AngleMin = new System.Windows.Forms.Label();
            this.tb_Cam1AngleMin = new System.Windows.Forms.TextBox();
            this.lb_Cam1LimitMax = new System.Windows.Forms.Label();
            this.tb_Cam1LimitMax = new System.Windows.Forms.TextBox();
            this.lb_Cam1CenterLa2X = new System.Windows.Forms.Label();
            this.tb_Cam1CenterLa2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1CenterLa2Y = new System.Windows.Forms.Label();
            this.tb_Cam1CenterLa2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1LimitMin = new System.Windows.Forms.TextBox();
            this.lb_Cam1LimitMin = new System.Windows.Forms.Label();
            this.lb_Cam1Spacing = new System.Windows.Forms.Label();
            this.lb_Cam1SpacingUse = new System.Windows.Forms.Label();
            this.tb_Cam1SpacingUse = new System.Windows.Forms.TextBox();
            this.lb_Cam1RobotStep = new System.Windows.Forms.Label();
            this.lb_Cam1RobotUse = new System.Windows.Forms.Label();
            this.tb_Cam1RobotUse = new System.Windows.Forms.TextBox();
            this.tb_Cam1LaserUse = new System.Windows.Forms.TextBox();
            this.lb_Cam1LaserUse = new System.Windows.Forms.Label();
            this.lb_Cam1LaserStep = new System.Windows.Forms.Label();
            this.tb_Cam1LaserStep = new System.Windows.Forms.TextBox();
            this.tb_Cam1Spacing = new System.Windows.Forms.TextBox();
            this.tb_Cam1RobotStep = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig1Bo2Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1Bo2X = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1Bo1Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1Bo1X = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig1Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1Bo2X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig1La21Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La21X = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La11X = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig1La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La21X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig1La22Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La22X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig1La22Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La22X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig1La23Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La23X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig1La23Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La23X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig1La24Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La24X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig1La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig1La24Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La24X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig1La14X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_clearJ1 = new System.Windows.Forms.CheckBox();
            this.btn_clearJ1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig2Bo2Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2Bo2X = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2Bo1Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2Bo1X = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2Bo2X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig2La21Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La21X = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La11X = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La21X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig2La22Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La22X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2La22Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La22X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig2La23Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2La23Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig2La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig2La24Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La24X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig2La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig2La24Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La24X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig2La14X = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clearJ2 = new System.Windows.Forms.Button();
            this.cb_clearJ2 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig3Bo2Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3Bo2X = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3Bo1Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3Bo1X = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig3Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3Bo2X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig3La21Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La21X = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La11X = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig3La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La21X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig3La22Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La22X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig3La22Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La22X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig3La23Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La23X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig3La23Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La23X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig3La24Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La24X = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig3La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig3La24Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La24X = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig3La14X = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_clearJ3 = new System.Windows.Forms.Button();
            this.cb_clearJ3 = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig4Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4Bo2X = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4Bo1X = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La21X = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La11X = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig4La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig4La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig4La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig4La14X = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearJ4 = new System.Windows.Forms.Button();
            this.cb_clearJ4 = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig5Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5Bo2X = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5Bo1X = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La21X = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La11X = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig5La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig5La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig5La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig5La14X = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.btn_clearJ5 = new System.Windows.Forms.Button();
            this.cb_clearJ5 = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig6Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6Bo2X = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6Bo1X = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La21X = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La11X = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig6La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig6La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig6La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig6La14X = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.btn_clearJ6 = new System.Windows.Forms.Button();
            this.cb_clearJ6 = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig7Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7Bo2X = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7Bo1X = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La21X = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La11X = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig7La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig7La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig7La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig7La14X = new System.Windows.Forms.TextBox();
            this.label95 = new System.Windows.Forms.Label();
            this.btn_clearJ7 = new System.Windows.Forms.Button();
            this.cb_clearJ7 = new System.Windows.Forms.CheckBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig8Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8Bo2X = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8Bo1X = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La21X = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La11X = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig8La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig8La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig8La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig8La14X = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.btn_clearJ8 = new System.Windows.Forms.Button();
            this.cb_clearJ8 = new System.Windows.Forms.CheckBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new Sunny.UI.UITableLayoutPanel();
            this.lb_Cam1Jig9Bo2Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9Bo2Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9Bo2X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9Bo2X = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9Bo1Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9Bo1Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9Bo1X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9Bo1X = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La21Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La21Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9La21X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La21X = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La11Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La11X = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La11Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9La11X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La22Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La22Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La23Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La23Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La24Y = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La24Y = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La22X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La22X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La23X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La23X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La24X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La24X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La12Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La12X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La12Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9La12X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La13Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La13X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La13Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9La13X = new System.Windows.Forms.TextBox();
            this.lb_Cam1Jig9La14Y = new System.Windows.Forms.Label();
            this.lb_Cam1Jig9La14X = new System.Windows.Forms.Label();
            this.tb_Cam1Jig9La14Y = new System.Windows.Forms.TextBox();
            this.tb_Cam1Jig9La14X = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.btn_clearJ9 = new System.Windows.Forms.Button();
            this.cb_clearJ9 = new System.Windows.Forms.CheckBox();
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
            this.uiTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.uiTabPage1.Controls.Add(this.uiTableLayoutPanel1);
            this.uiTabPage1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabPage1.ForeColor = System.Drawing.Color.Black;
            this.uiTabPage1.Location = new System.Drawing.Point(4, 44);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(1300, 552);
            this.uiTabPage1.TabIndex = 0;
            this.uiTabPage1.Text = "相机1";
            this.uiTabPage1.UseVisualStyleBackColor = true;
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
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo1X, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo1X, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo2X, 2, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo2X, 3, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa1X, 4, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa1X, 5, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa2X, 6, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa2X, 7, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo1Y, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo1Y, 1, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo2Y, 2, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo2Y, 3, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa1Y, 4, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa1Y, 5, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa2Y, 6, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa2Y, 7, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa2R, 7, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa2R, 6, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdLa1R, 5, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdLa1R, 4, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo2R, 3, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo2R, 2, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1StdBo1R, 1, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1StdBo1R, 0, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_GetStd1, 1, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_GetStd2, 3, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_GetStd3, 5, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.btn_GetStd4, 7, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa2X, 7, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa2X, 6, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa1X, 5, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa1X, 4, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo2X, 3, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo2X, 2, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo1X, 1, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo1X, 0, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo1Y, 0, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo1Y, 1, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo2Y, 2, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo2Y, 3, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa1Y, 4, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa1Y, 5, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa2Y, 6, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa2Y, 7, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa2R, 6, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa2R, 7, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddLa1R, 5, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddLa1R, 4, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo2R, 3, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo2R, 2, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AddBo1R, 1, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AddBo1R, 0, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Exprosure, 0, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Exprosure, 1, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P2byP1X, 3, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P2byP1X, 4, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P2byP1Y, 4, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P2byP1Y, 3, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P4byP3X, 7, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P4byP3X, 6, 9);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1P4byP3Y, 7, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1P4byP3Y, 6, 10);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AngleMax, 9, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AngleMax, 10, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1CenterLa1X, 11, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1CenterLa1X, 12, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1CenterLa1Y, 11, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1CenterLa1Y, 12, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1AngleMin, 9, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1AngleMin, 10, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LimitMax, 9, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LimitMax, 10, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1CenterLa2X, 11, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1CenterLa2X, 12, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1CenterLa2Y, 11, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1CenterLa2Y, 12, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LimitMin, 10, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LimitMin, 9, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1Spacing, 9, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1SpacingUse, 11, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1SpacingUse, 12, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1RobotStep, 9, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1RobotUse, 11, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1RobotUse, 12, 6);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LaserUse, 12, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LaserUse, 11, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.lb_Cam1LaserStep, 9, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1LaserStep, 10, 7);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1Spacing, 10, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.tb_Cam1RobotStep, 10, 6);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
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
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // lb_Cam1StdBo1X
            // 
            this.lb_Cam1StdBo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo1X.Location = new System.Drawing.Point(3, 46);
            this.lb_Cam1StdBo1X.Name = "lb_Cam1StdBo1X";
            this.lb_Cam1StdBo1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo1X.TabIndex = 1;
            this.lb_Cam1StdBo1X.Text = "机械手1基准X";
            this.lb_Cam1StdBo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdBo1X
            // 
            this.tb_Cam1StdBo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo1X.Location = new System.Drawing.Point(96, 58);
            this.tb_Cam1StdBo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo1X.Name = "tb_Cam1StdBo1X";
            this.tb_Cam1StdBo1X.ReadOnly = true;
            this.tb_Cam1StdBo1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo1X.TabIndex = 2;
            this.tb_Cam1StdBo1X.Tag = "";
            // 
            // lb_Cam1StdBo2X
            // 
            this.lb_Cam1StdBo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo2X.Location = new System.Drawing.Point(187, 46);
            this.lb_Cam1StdBo2X.Name = "lb_Cam1StdBo2X";
            this.lb_Cam1StdBo2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo2X.TabIndex = 23;
            this.lb_Cam1StdBo2X.Text = "机械手2基准X";
            this.lb_Cam1StdBo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdBo2X
            // 
            this.tb_Cam1StdBo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo2X.Location = new System.Drawing.Point(280, 58);
            this.tb_Cam1StdBo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo2X.Name = "tb_Cam1StdBo2X";
            this.tb_Cam1StdBo2X.ReadOnly = true;
            this.tb_Cam1StdBo2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo2X.TabIndex = 2;
            this.tb_Cam1StdBo2X.Tag = "";
            // 
            // lb_Cam1StdLa1X
            // 
            this.lb_Cam1StdLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa1X.Location = new System.Drawing.Point(371, 46);
            this.lb_Cam1StdLa1X.Name = "lb_Cam1StdLa1X";
            this.lb_Cam1StdLa1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa1X.TabIndex = 26;
            this.lb_Cam1StdLa1X.Text = "激光1基准X";
            this.lb_Cam1StdLa1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdLa1X
            // 
            this.tb_Cam1StdLa1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa1X.Location = new System.Drawing.Point(464, 58);
            this.tb_Cam1StdLa1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa1X.Name = "tb_Cam1StdLa1X";
            this.tb_Cam1StdLa1X.ReadOnly = true;
            this.tb_Cam1StdLa1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa1X.TabIndex = 40;
            this.tb_Cam1StdLa1X.Tag = "";
            // 
            // lb_Cam1StdLa2X
            // 
            this.lb_Cam1StdLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa2X.Location = new System.Drawing.Point(555, 46);
            this.lb_Cam1StdLa2X.Name = "lb_Cam1StdLa2X";
            this.lb_Cam1StdLa2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa2X.TabIndex = 33;
            this.lb_Cam1StdLa2X.Text = "激光2基准X";
            this.lb_Cam1StdLa2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdLa2X
            // 
            this.tb_Cam1StdLa2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa2X.Location = new System.Drawing.Point(648, 58);
            this.tb_Cam1StdLa2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa2X.Name = "tb_Cam1StdLa2X";
            this.tb_Cam1StdLa2X.ReadOnly = true;
            this.tb_Cam1StdLa2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa2X.TabIndex = 46;
            this.tb_Cam1StdLa2X.Tag = "";
            // 
            // lb_Cam1StdBo1Y
            // 
            this.lb_Cam1StdBo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo1Y.Location = new System.Drawing.Point(3, 92);
            this.lb_Cam1StdBo1Y.Name = "lb_Cam1StdBo1Y";
            this.lb_Cam1StdBo1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo1Y.TabIndex = 4;
            this.lb_Cam1StdBo1Y.Text = "机械手1基准Y";
            this.lb_Cam1StdBo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdBo1Y
            // 
            this.tb_Cam1StdBo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo1Y.Location = new System.Drawing.Point(96, 104);
            this.tb_Cam1StdBo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo1Y.Name = "tb_Cam1StdBo1Y";
            this.tb_Cam1StdBo1Y.ReadOnly = true;
            this.tb_Cam1StdBo1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo1Y.TabIndex = 5;
            this.tb_Cam1StdBo1Y.Tag = "";
            // 
            // lb_Cam1StdBo2Y
            // 
            this.lb_Cam1StdBo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo2Y.Location = new System.Drawing.Point(187, 92);
            this.lb_Cam1StdBo2Y.Name = "lb_Cam1StdBo2Y";
            this.lb_Cam1StdBo2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo2Y.TabIndex = 23;
            this.lb_Cam1StdBo2Y.Text = "机械手2基准Y";
            this.lb_Cam1StdBo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdBo2Y
            // 
            this.tb_Cam1StdBo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo2Y.Location = new System.Drawing.Point(280, 104);
            this.tb_Cam1StdBo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo2Y.Name = "tb_Cam1StdBo2Y";
            this.tb_Cam1StdBo2Y.ReadOnly = true;
            this.tb_Cam1StdBo2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo2Y.TabIndex = 2;
            this.tb_Cam1StdBo2Y.Tag = "";
            // 
            // lb_Cam1StdLa1Y
            // 
            this.lb_Cam1StdLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa1Y.Location = new System.Drawing.Point(371, 92);
            this.lb_Cam1StdLa1Y.Name = "lb_Cam1StdLa1Y";
            this.lb_Cam1StdLa1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa1Y.TabIndex = 25;
            this.lb_Cam1StdLa1Y.Text = "激光1基准Y";
            this.lb_Cam1StdLa1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdLa1Y
            // 
            this.tb_Cam1StdLa1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa1Y.Location = new System.Drawing.Point(464, 104);
            this.tb_Cam1StdLa1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa1Y.Name = "tb_Cam1StdLa1Y";
            this.tb_Cam1StdLa1Y.ReadOnly = true;
            this.tb_Cam1StdLa1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa1Y.TabIndex = 41;
            this.tb_Cam1StdLa1Y.Tag = "";
            // 
            // lb_Cam1StdLa2Y
            // 
            this.lb_Cam1StdLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa2Y.Location = new System.Drawing.Point(555, 92);
            this.lb_Cam1StdLa2Y.Name = "lb_Cam1StdLa2Y";
            this.lb_Cam1StdLa2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa2Y.TabIndex = 34;
            this.lb_Cam1StdLa2Y.Text = "激光2基准Y";
            this.lb_Cam1StdLa2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdLa2Y
            // 
            this.tb_Cam1StdLa2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa2Y.Location = new System.Drawing.Point(648, 104);
            this.tb_Cam1StdLa2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa2Y.Name = "tb_Cam1StdLa2Y";
            this.tb_Cam1StdLa2Y.ReadOnly = true;
            this.tb_Cam1StdLa2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa2Y.TabIndex = 47;
            this.tb_Cam1StdLa2Y.Tag = "";
            // 
            // tb_Cam1StdLa2R
            // 
            this.tb_Cam1StdLa2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa2R.Location = new System.Drawing.Point(648, 150);
            this.tb_Cam1StdLa2R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa2R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa2R.Name = "tb_Cam1StdLa2R";
            this.tb_Cam1StdLa2R.ReadOnly = true;
            this.tb_Cam1StdLa2R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa2R.TabIndex = 48;
            this.tb_Cam1StdLa2R.Tag = this.lb_Cam1StdLa1R.Text;
            // 
            // lb_Cam1StdLa1R
            // 
            this.lb_Cam1StdLa1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa1R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa1R.Location = new System.Drawing.Point(371, 138);
            this.lb_Cam1StdLa1R.Name = "lb_Cam1StdLa1R";
            this.lb_Cam1StdLa1R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa1R.TabIndex = 29;
            this.lb_Cam1StdLa1R.Text = "激光1基准R";
            this.lb_Cam1StdLa1R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1StdLa2R
            // 
            this.lb_Cam1StdLa2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdLa2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdLa2R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdLa2R.Location = new System.Drawing.Point(555, 138);
            this.lb_Cam1StdLa2R.Name = "lb_Cam1StdLa2R";
            this.lb_Cam1StdLa2R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdLa2R.TabIndex = 32;
            this.lb_Cam1StdLa2R.Text = "激光2基准R";
            this.lb_Cam1StdLa2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdLa1R
            // 
            this.tb_Cam1StdLa1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdLa1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdLa1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdLa1R.Location = new System.Drawing.Point(464, 150);
            this.tb_Cam1StdLa1R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdLa1R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdLa1R.Name = "tb_Cam1StdLa1R";
            this.tb_Cam1StdLa1R.ReadOnly = true;
            this.tb_Cam1StdLa1R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdLa1R.TabIndex = 42;
            this.tb_Cam1StdLa1R.Tag = "";
            // 
            // tb_Cam1StdBo2R
            // 
            this.tb_Cam1StdBo2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo2R.Location = new System.Drawing.Point(280, 150);
            this.tb_Cam1StdBo2R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo2R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo2R.Name = "tb_Cam1StdBo2R";
            this.tb_Cam1StdBo2R.ReadOnly = true;
            this.tb_Cam1StdBo2R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo2R.TabIndex = 2;
            this.tb_Cam1StdBo2R.Tag = "";
            // 
            // lb_Cam1StdBo2R
            // 
            this.lb_Cam1StdBo2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo2R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo2R.Location = new System.Drawing.Point(187, 138);
            this.lb_Cam1StdBo2R.Name = "lb_Cam1StdBo2R";
            this.lb_Cam1StdBo2R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo2R.TabIndex = 23;
            this.lb_Cam1StdBo2R.Text = "机械手2基准R";
            this.lb_Cam1StdBo2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1StdBo1R
            // 
            this.tb_Cam1StdBo1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1StdBo1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1StdBo1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1StdBo1R.Location = new System.Drawing.Point(96, 150);
            this.tb_Cam1StdBo1R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1StdBo1R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1StdBo1R.Name = "tb_Cam1StdBo1R";
            this.tb_Cam1StdBo1R.ReadOnly = true;
            this.tb_Cam1StdBo1R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1StdBo1R.TabIndex = 8;
            this.tb_Cam1StdBo1R.Tag = "";
            // 
            // lb_Cam1StdBo1R
            // 
            this.lb_Cam1StdBo1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1StdBo1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1StdBo1R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1StdBo1R.Location = new System.Drawing.Point(3, 138);
            this.lb_Cam1StdBo1R.Name = "lb_Cam1StdBo1R";
            this.lb_Cam1StdBo1R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1StdBo1R.TabIndex = 7;
            this.lb_Cam1StdBo1R.Text = "机械手1基准R";
            this.lb_Cam1StdBo1R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GetStd1
            // 
            this.btn_GetStd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GetStd1.ForeColor = System.Drawing.Color.Black;
            this.btn_GetStd1.Location = new System.Drawing.Point(95, 187);
            this.btn_GetStd1.Name = "btn_GetStd1";
            this.btn_GetStd1.Size = new System.Drawing.Size(86, 40);
            this.btn_GetStd1.TabIndex = 24;
            this.btn_GetStd1.Text = "获取基准";
            this.btn_GetStd1.UseVisualStyleBackColor = true;
            // 
            // btn_GetStd2
            // 
            this.btn_GetStd2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GetStd2.ForeColor = System.Drawing.Color.Black;
            this.btn_GetStd2.Location = new System.Drawing.Point(279, 187);
            this.btn_GetStd2.Name = "btn_GetStd2";
            this.btn_GetStd2.Size = new System.Drawing.Size(86, 40);
            this.btn_GetStd2.TabIndex = 49;
            this.btn_GetStd2.Text = "获取基准";
            this.btn_GetStd2.UseVisualStyleBackColor = true;
            // 
            // btn_GetStd3
            // 
            this.btn_GetStd3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GetStd3.ForeColor = System.Drawing.Color.Black;
            this.btn_GetStd3.Location = new System.Drawing.Point(463, 187);
            this.btn_GetStd3.Name = "btn_GetStd3";
            this.btn_GetStd3.Size = new System.Drawing.Size(86, 40);
            this.btn_GetStd3.TabIndex = 50;
            this.btn_GetStd3.Text = "获取基准";
            this.btn_GetStd3.UseVisualStyleBackColor = true;
            // 
            // btn_GetStd4
            // 
            this.btn_GetStd4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_GetStd4.ForeColor = System.Drawing.Color.Black;
            this.btn_GetStd4.Location = new System.Drawing.Point(647, 187);
            this.btn_GetStd4.Name = "btn_GetStd4";
            this.btn_GetStd4.Size = new System.Drawing.Size(86, 40);
            this.btn_GetStd4.TabIndex = 51;
            this.btn_GetStd4.Text = "获取基准";
            this.btn_GetStd4.UseVisualStyleBackColor = true;
            // 
            // tb_Cam1AddLa2X
            // 
            this.tb_Cam1AddLa2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa2X.Location = new System.Drawing.Point(648, 242);
            this.tb_Cam1AddLa2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa2X.Name = "tb_Cam1AddLa2X";
            this.tb_Cam1AddLa2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa2X.TabIndex = 45;
            this.tb_Cam1AddLa2X.Tag = "激光2补偿X";
            // 
            // lb_Cam1AddLa2X
            // 
            this.lb_Cam1AddLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa2X.Location = new System.Drawing.Point(555, 230);
            this.lb_Cam1AddLa2X.Name = "lb_Cam1AddLa2X";
            this.lb_Cam1AddLa2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa2X.TabIndex = 31;
            this.lb_Cam1AddLa2X.Text = "激光2补偿X";
            this.lb_Cam1AddLa2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddLa1X
            // 
            this.tb_Cam1AddLa1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa1X.Location = new System.Drawing.Point(464, 242);
            this.tb_Cam1AddLa1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa1X.Name = "tb_Cam1AddLa1X";
            this.tb_Cam1AddLa1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa1X.TabIndex = 39;
            this.tb_Cam1AddLa1X.Tag = "激光1补偿X";
            // 
            // lb_Cam1AddLa1X
            // 
            this.lb_Cam1AddLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa1X.Location = new System.Drawing.Point(371, 230);
            this.lb_Cam1AddLa1X.Name = "lb_Cam1AddLa1X";
            this.lb_Cam1AddLa1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa1X.TabIndex = 28;
            this.lb_Cam1AddLa1X.Text = "激光1补偿X";
            this.lb_Cam1AddLa1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo2X
            // 
            this.tb_Cam1AddBo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo2X.Location = new System.Drawing.Point(280, 242);
            this.tb_Cam1AddBo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo2X.Name = "tb_Cam1AddBo2X";
            this.tb_Cam1AddBo2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo2X.TabIndex = 2;
            this.tb_Cam1AddBo2X.Tag = "机械手2补偿X";
            // 
            // lb_Cam1AddBo2X
            // 
            this.lb_Cam1AddBo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo2X.Location = new System.Drawing.Point(187, 230);
            this.lb_Cam1AddBo2X.Name = "lb_Cam1AddBo2X";
            this.lb_Cam1AddBo2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo2X.TabIndex = 1;
            this.lb_Cam1AddBo2X.Text = "机械手2补偿X";
            this.lb_Cam1AddBo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo1X
            // 
            this.tb_Cam1AddBo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo1X.Location = new System.Drawing.Point(96, 242);
            this.tb_Cam1AddBo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo1X.Name = "tb_Cam1AddBo1X";
            this.tb_Cam1AddBo1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo1X.TabIndex = 2;
            this.tb_Cam1AddBo1X.Tag = "机械手1补偿X";
            // 
            // lb_Cam1AddBo1X
            // 
            this.lb_Cam1AddBo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo1X.Location = new System.Drawing.Point(3, 230);
            this.lb_Cam1AddBo1X.Name = "lb_Cam1AddBo1X";
            this.lb_Cam1AddBo1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo1X.TabIndex = 1;
            this.lb_Cam1AddBo1X.Text = "机械手1补偿X";
            this.lb_Cam1AddBo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AddBo1Y
            // 
            this.lb_Cam1AddBo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo1Y.Location = new System.Drawing.Point(3, 276);
            this.lb_Cam1AddBo1Y.Name = "lb_Cam1AddBo1Y";
            this.lb_Cam1AddBo1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo1Y.TabIndex = 1;
            this.lb_Cam1AddBo1Y.Text = "机械手1补偿Y";
            this.lb_Cam1AddBo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo1Y
            // 
            this.tb_Cam1AddBo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo1Y.Location = new System.Drawing.Point(96, 288);
            this.tb_Cam1AddBo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo1Y.Name = "tb_Cam1AddBo1Y";
            this.tb_Cam1AddBo1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo1Y.TabIndex = 2;
            this.tb_Cam1AddBo1Y.Tag = "机械手1补偿Y";
            // 
            // lb_Cam1AddBo2Y
            // 
            this.lb_Cam1AddBo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo2Y.Location = new System.Drawing.Point(187, 276);
            this.lb_Cam1AddBo2Y.Name = "lb_Cam1AddBo2Y";
            this.lb_Cam1AddBo2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo2Y.TabIndex = 1;
            this.lb_Cam1AddBo2Y.Text = "机械手2补偿Y";
            this.lb_Cam1AddBo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo2Y
            // 
            this.tb_Cam1AddBo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo2Y.Location = new System.Drawing.Point(280, 288);
            this.tb_Cam1AddBo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo2Y.Name = "tb_Cam1AddBo2Y";
            this.tb_Cam1AddBo2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo2Y.TabIndex = 2;
            this.tb_Cam1AddBo2Y.Tag = "机械手2补偿Y";
            // 
            // lb_Cam1AddLa1Y
            // 
            this.lb_Cam1AddLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa1Y.Location = new System.Drawing.Point(371, 276);
            this.lb_Cam1AddLa1Y.Name = "lb_Cam1AddLa1Y";
            this.lb_Cam1AddLa1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa1Y.TabIndex = 27;
            this.lb_Cam1AddLa1Y.Text = "激光1补偿Y";
            this.lb_Cam1AddLa1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddLa1Y
            // 
            this.tb_Cam1AddLa1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa1Y.Location = new System.Drawing.Point(464, 288);
            this.tb_Cam1AddLa1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa1Y.Name = "tb_Cam1AddLa1Y";
            this.tb_Cam1AddLa1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa1Y.TabIndex = 38;
            this.tb_Cam1AddLa1Y.Tag = "激光1补偿Y";
            // 
            // lb_Cam1AddLa2Y
            // 
            this.lb_Cam1AddLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa2Y.Location = new System.Drawing.Point(555, 276);
            this.lb_Cam1AddLa2Y.Name = "lb_Cam1AddLa2Y";
            this.lb_Cam1AddLa2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa2Y.TabIndex = 35;
            this.lb_Cam1AddLa2Y.Text = "激光2补偿Y";
            this.lb_Cam1AddLa2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddLa2Y
            // 
            this.tb_Cam1AddLa2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa2Y.Location = new System.Drawing.Point(648, 288);
            this.tb_Cam1AddLa2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa2Y.Name = "tb_Cam1AddLa2Y";
            this.tb_Cam1AddLa2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa2Y.TabIndex = 44;
            this.tb_Cam1AddLa2Y.Tag = "激光2补偿Y";
            // 
            // lb_Cam1AddLa2R
            // 
            this.lb_Cam1AddLa2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa2R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa2R.Location = new System.Drawing.Point(555, 322);
            this.lb_Cam1AddLa2R.Name = "lb_Cam1AddLa2R";
            this.lb_Cam1AddLa2R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa2R.TabIndex = 36;
            this.lb_Cam1AddLa2R.Text = "激光2补偿R";
            this.lb_Cam1AddLa2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddLa2R
            // 
            this.tb_Cam1AddLa2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa2R.Location = new System.Drawing.Point(648, 334);
            this.tb_Cam1AddLa2R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa2R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa2R.Name = "tb_Cam1AddLa2R";
            this.tb_Cam1AddLa2R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa2R.TabIndex = 43;
            this.tb_Cam1AddLa2R.Tag = "激光2补偿R";
            // 
            // tb_Cam1AddLa1R
            // 
            this.tb_Cam1AddLa1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddLa1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddLa1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddLa1R.Location = new System.Drawing.Point(464, 334);
            this.tb_Cam1AddLa1R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddLa1R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddLa1R.Name = "tb_Cam1AddLa1R";
            this.tb_Cam1AddLa1R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddLa1R.TabIndex = 37;
            this.tb_Cam1AddLa1R.Tag = "激光1补偿R";
            // 
            // lb_Cam1AddLa1R
            // 
            this.lb_Cam1AddLa1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddLa1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddLa1R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddLa1R.Location = new System.Drawing.Point(371, 322);
            this.lb_Cam1AddLa1R.Name = "lb_Cam1AddLa1R";
            this.lb_Cam1AddLa1R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddLa1R.TabIndex = 30;
            this.lb_Cam1AddLa1R.Text = "激光1补偿R";
            this.lb_Cam1AddLa1R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo2R
            // 
            this.tb_Cam1AddBo2R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo2R.Location = new System.Drawing.Point(280, 334);
            this.tb_Cam1AddBo2R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo2R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo2R.Name = "tb_Cam1AddBo2R";
            this.tb_Cam1AddBo2R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo2R.TabIndex = 2;
            this.tb_Cam1AddBo2R.Tag = "机械手2补偿R";
            // 
            // lb_Cam1AddBo2R
            // 
            this.lb_Cam1AddBo2R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo2R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo2R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo2R.Location = new System.Drawing.Point(187, 322);
            this.lb_Cam1AddBo2R.Name = "lb_Cam1AddBo2R";
            this.lb_Cam1AddBo2R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo2R.TabIndex = 1;
            this.lb_Cam1AddBo2R.Text = "机械手2补偿R";
            this.lb_Cam1AddBo2R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AddBo1R
            // 
            this.tb_Cam1AddBo1R.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AddBo1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AddBo1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AddBo1R.Location = new System.Drawing.Point(96, 334);
            this.tb_Cam1AddBo1R.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AddBo1R.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AddBo1R.Name = "tb_Cam1AddBo1R";
            this.tb_Cam1AddBo1R.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AddBo1R.TabIndex = 2;
            this.tb_Cam1AddBo1R.Tag = "机械手1补偿R";
            // 
            // lb_Cam1AddBo1R
            // 
            this.lb_Cam1AddBo1R.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AddBo1R.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AddBo1R.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AddBo1R.Location = new System.Drawing.Point(3, 322);
            this.lb_Cam1AddBo1R.Name = "lb_Cam1AddBo1R";
            this.lb_Cam1AddBo1R.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AddBo1R.TabIndex = 1;
            this.lb_Cam1AddBo1R.Text = "机械手1补偿R";
            this.lb_Cam1AddBo1R.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Exprosure
            // 
            this.lb_Cam1Exprosure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Exprosure.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Exprosure.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Exprosure.Location = new System.Drawing.Point(3, 414);
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
            this.tb_Cam1Exprosure.Location = new System.Drawing.Point(96, 426);
            this.tb_Cam1Exprosure.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Exprosure.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Exprosure.Name = "tb_Cam1Exprosure";
            this.tb_Cam1Exprosure.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Exprosure.TabIndex = 20;
            // 
            // lb_Cam1P2byP1X
            // 
            this.lb_Cam1P2byP1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1P2byP1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P2byP1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P2byP1X.Location = new System.Drawing.Point(279, 414);
            this.lb_Cam1P2byP1X.Name = "lb_Cam1P2byP1X";
            this.lb_Cam1P2byP1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P2byP1X.TabIndex = 169;
            this.lb_Cam1P2byP1X.Text = "固定点2随点1自动修改差值X";
            this.lb_Cam1P2byP1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P2byP1X
            // 
            this.tb_Cam1P2byP1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P2byP1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1P2byP1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P2byP1X.Location = new System.Drawing.Point(372, 426);
            this.tb_Cam1P2byP1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1P2byP1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P2byP1X.Name = "tb_Cam1P2byP1X";
            this.tb_Cam1P2byP1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1P2byP1X.TabIndex = 170;
            this.tb_Cam1P2byP1X.Tag = "";
            // 
            // tb_Cam1P2byP1Y
            // 
            this.tb_Cam1P2byP1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P2byP1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1P2byP1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P2byP1Y.Location = new System.Drawing.Point(372, 472);
            this.tb_Cam1P2byP1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1P2byP1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P2byP1Y.Name = "tb_Cam1P2byP1Y";
            this.tb_Cam1P2byP1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1P2byP1Y.TabIndex = 172;
            this.tb_Cam1P2byP1Y.Tag = "";
            // 
            // lb_Cam1P2byP1Y
            // 
            this.lb_Cam1P2byP1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1P2byP1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P2byP1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P2byP1Y.Location = new System.Drawing.Point(279, 460);
            this.lb_Cam1P2byP1Y.Name = "lb_Cam1P2byP1Y";
            this.lb_Cam1P2byP1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P2byP1Y.TabIndex = 171;
            this.lb_Cam1P2byP1Y.Text = "固定点2随点1自动修改差值Y";
            this.lb_Cam1P2byP1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P4byP3X
            // 
            this.tb_Cam1P4byP3X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P4byP3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1P4byP3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P4byP3X.Location = new System.Drawing.Point(648, 426);
            this.tb_Cam1P4byP3X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1P4byP3X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P4byP3X.Name = "tb_Cam1P4byP3X";
            this.tb_Cam1P4byP3X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1P4byP3X.TabIndex = 174;
            this.tb_Cam1P4byP3X.Tag = "";
            // 
            // lb_Cam1P4byP3X
            // 
            this.lb_Cam1P4byP3X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1P4byP3X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P4byP3X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P4byP3X.Location = new System.Drawing.Point(555, 414);
            this.lb_Cam1P4byP3X.Name = "lb_Cam1P4byP3X";
            this.lb_Cam1P4byP3X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P4byP3X.TabIndex = 173;
            this.lb_Cam1P4byP3X.Text = "固定点4随点3自动修改差值X";
            this.lb_Cam1P4byP3X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1P4byP3Y
            // 
            this.tb_Cam1P4byP3Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1P4byP3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1P4byP3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1P4byP3Y.Location = new System.Drawing.Point(648, 472);
            this.tb_Cam1P4byP3Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1P4byP3Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1P4byP3Y.Name = "tb_Cam1P4byP3Y";
            this.tb_Cam1P4byP3Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1P4byP3Y.TabIndex = 176;
            this.tb_Cam1P4byP3Y.Tag = "";
            // 
            // lb_Cam1P4byP3Y
            // 
            this.lb_Cam1P4byP3Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1P4byP3Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1P4byP3Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1P4byP3Y.Location = new System.Drawing.Point(555, 460);
            this.lb_Cam1P4byP3Y.Name = "lb_Cam1P4byP3Y";
            this.lb_Cam1P4byP3Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1P4byP3Y.TabIndex = 175;
            this.lb_Cam1P4byP3Y.Text = "固定点4随点3自动修改差值Y";
            this.lb_Cam1P4byP3Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1AngleMax
            // 
            this.lb_Cam1AngleMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AngleMax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AngleMax.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AngleMax.Location = new System.Drawing.Point(831, 46);
            this.lb_Cam1AngleMax.Name = "lb_Cam1AngleMax";
            this.lb_Cam1AngleMax.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AngleMax.TabIndex = 138;
            this.lb_Cam1AngleMax.Text = "钢片与壳角度Max";
            this.lb_Cam1AngleMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AngleMax
            // 
            this.tb_Cam1AngleMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AngleMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AngleMax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AngleMax.Location = new System.Drawing.Point(924, 58);
            this.tb_Cam1AngleMax.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AngleMax.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AngleMax.Name = "tb_Cam1AngleMax";
            this.tb_Cam1AngleMax.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AngleMax.TabIndex = 140;
            this.tb_Cam1AngleMax.Tag = "";
            // 
            // lb_Cam1CenterLa1X
            // 
            this.lb_Cam1CenterLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1CenterLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1CenterLa1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1CenterLa1X.Location = new System.Drawing.Point(1015, 46);
            this.lb_Cam1CenterLa1X.Name = "lb_Cam1CenterLa1X";
            this.lb_Cam1CenterLa1X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1CenterLa1X.TabIndex = 52;
            this.lb_Cam1CenterLa1X.Text = "L1标定中心位X";
            this.lb_Cam1CenterLa1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1CenterLa1X
            // 
            this.tb_Cam1CenterLa1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1CenterLa1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1CenterLa1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1CenterLa1X.Location = new System.Drawing.Point(1108, 58);
            this.tb_Cam1CenterLa1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1CenterLa1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1CenterLa1X.Name = "tb_Cam1CenterLa1X";
            this.tb_Cam1CenterLa1X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1CenterLa1X.TabIndex = 113;
            // 
            // lb_Cam1CenterLa1Y
            // 
            this.lb_Cam1CenterLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1CenterLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1CenterLa1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1CenterLa1Y.Location = new System.Drawing.Point(1015, 92);
            this.lb_Cam1CenterLa1Y.Name = "lb_Cam1CenterLa1Y";
            this.lb_Cam1CenterLa1Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1CenterLa1Y.TabIndex = 53;
            this.lb_Cam1CenterLa1Y.Text = "L1标定中心位Y";
            this.lb_Cam1CenterLa1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1CenterLa1Y
            // 
            this.tb_Cam1CenterLa1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1CenterLa1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1CenterLa1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1CenterLa1Y.Location = new System.Drawing.Point(1108, 104);
            this.tb_Cam1CenterLa1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1CenterLa1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1CenterLa1Y.Name = "tb_Cam1CenterLa1Y";
            this.tb_Cam1CenterLa1Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1CenterLa1Y.TabIndex = 103;
            // 
            // lb_Cam1AngleMin
            // 
            this.lb_Cam1AngleMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1AngleMin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1AngleMin.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1AngleMin.Location = new System.Drawing.Point(831, 92);
            this.lb_Cam1AngleMin.Name = "lb_Cam1AngleMin";
            this.lb_Cam1AngleMin.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1AngleMin.TabIndex = 137;
            this.lb_Cam1AngleMin.Text = "钢片与壳角度Min";
            this.lb_Cam1AngleMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1AngleMin
            // 
            this.tb_Cam1AngleMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1AngleMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1AngleMin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1AngleMin.Location = new System.Drawing.Point(924, 104);
            this.tb_Cam1AngleMin.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1AngleMin.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1AngleMin.Name = "tb_Cam1AngleMin";
            this.tb_Cam1AngleMin.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1AngleMin.TabIndex = 139;
            this.tb_Cam1AngleMin.Tag = "";
            // 
            // lb_Cam1LimitMax
            // 
            this.lb_Cam1LimitMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1LimitMax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LimitMax.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LimitMax.Location = new System.Drawing.Point(831, 138);
            this.lb_Cam1LimitMax.Name = "lb_Cam1LimitMax";
            this.lb_Cam1LimitMax.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LimitMax.TabIndex = 142;
            this.lb_Cam1LimitMax.Text = "偏移范围Max";
            this.lb_Cam1LimitMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1LimitMax
            // 
            this.tb_Cam1LimitMax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LimitMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1LimitMax.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LimitMax.Location = new System.Drawing.Point(924, 150);
            this.tb_Cam1LimitMax.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1LimitMax.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LimitMax.Name = "tb_Cam1LimitMax";
            this.tb_Cam1LimitMax.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1LimitMax.TabIndex = 144;
            this.tb_Cam1LimitMax.Tag = "";
            // 
            // lb_Cam1CenterLa2X
            // 
            this.lb_Cam1CenterLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1CenterLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1CenterLa2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1CenterLa2X.Location = new System.Drawing.Point(1015, 138);
            this.lb_Cam1CenterLa2X.Name = "lb_Cam1CenterLa2X";
            this.lb_Cam1CenterLa2X.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1CenterLa2X.TabIndex = 65;
            this.lb_Cam1CenterLa2X.Text = "L2标定中心位X";
            this.lb_Cam1CenterLa2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1CenterLa2X
            // 
            this.tb_Cam1CenterLa2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1CenterLa2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1CenterLa2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1CenterLa2X.Location = new System.Drawing.Point(1108, 150);
            this.tb_Cam1CenterLa2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1CenterLa2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1CenterLa2X.Name = "tb_Cam1CenterLa2X";
            this.tb_Cam1CenterLa2X.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1CenterLa2X.TabIndex = 120;
            // 
            // lb_Cam1CenterLa2Y
            // 
            this.lb_Cam1CenterLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1CenterLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1CenterLa2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1CenterLa2Y.Location = new System.Drawing.Point(1015, 184);
            this.lb_Cam1CenterLa2Y.Name = "lb_Cam1CenterLa2Y";
            this.lb_Cam1CenterLa2Y.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1CenterLa2Y.TabIndex = 66;
            this.lb_Cam1CenterLa2Y.Text = "L2标定中心位Y";
            this.lb_Cam1CenterLa2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1CenterLa2Y
            // 
            this.tb_Cam1CenterLa2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1CenterLa2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1CenterLa2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1CenterLa2Y.Location = new System.Drawing.Point(1108, 196);
            this.tb_Cam1CenterLa2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1CenterLa2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1CenterLa2Y.Name = "tb_Cam1CenterLa2Y";
            this.tb_Cam1CenterLa2Y.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1CenterLa2Y.TabIndex = 131;
            // 
            // tb_Cam1LimitMin
            // 
            this.tb_Cam1LimitMin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LimitMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1LimitMin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LimitMin.Location = new System.Drawing.Point(924, 196);
            this.tb_Cam1LimitMin.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1LimitMin.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LimitMin.Name = "tb_Cam1LimitMin";
            this.tb_Cam1LimitMin.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1LimitMin.TabIndex = 143;
            this.tb_Cam1LimitMin.Tag = "";
            // 
            // lb_Cam1LimitMin
            // 
            this.lb_Cam1LimitMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1LimitMin.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LimitMin.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LimitMin.Location = new System.Drawing.Point(831, 184);
            this.lb_Cam1LimitMin.Name = "lb_Cam1LimitMin";
            this.lb_Cam1LimitMin.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LimitMin.TabIndex = 141;
            this.lb_Cam1LimitMin.Text = "偏移范围Min";
            this.lb_Cam1LimitMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Spacing
            // 
            this.lb_Cam1Spacing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Spacing.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Spacing.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Spacing.Location = new System.Drawing.Point(831, 230);
            this.lb_Cam1Spacing.Name = "lb_Cam1Spacing";
            this.lb_Cam1Spacing.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1Spacing.TabIndex = 162;
            this.lb_Cam1Spacing.Text = "极耳间距设定标准值";
            this.lb_Cam1Spacing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1SpacingUse
            // 
            this.lb_Cam1SpacingUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1SpacingUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1SpacingUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1SpacingUse.Location = new System.Drawing.Point(1015, 230);
            this.lb_Cam1SpacingUse.Name = "lb_Cam1SpacingUse";
            this.lb_Cam1SpacingUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1SpacingUse.TabIndex = 161;
            this.lb_Cam1SpacingUse.Text = "屏蔽间距补偿（1启用0屏蔽）";
            this.lb_Cam1SpacingUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1SpacingUse
            // 
            this.tb_Cam1SpacingUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1SpacingUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1SpacingUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1SpacingUse.Location = new System.Drawing.Point(1108, 242);
            this.tb_Cam1SpacingUse.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1SpacingUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1SpacingUse.Name = "tb_Cam1SpacingUse";
            this.tb_Cam1SpacingUse.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1SpacingUse.TabIndex = 166;
            // 
            // lb_Cam1RobotStep
            // 
            this.lb_Cam1RobotStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1RobotStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1RobotStep.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1RobotStep.Location = new System.Drawing.Point(831, 276);
            this.lb_Cam1RobotStep.Name = "lb_Cam1RobotStep";
            this.lb_Cam1RobotStep.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1RobotStep.TabIndex = 160;
            this.lb_Cam1RobotStep.Text = "机械手标定偏移";
            this.lb_Cam1RobotStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1RobotUse
            // 
            this.lb_Cam1RobotUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1RobotUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1RobotUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1RobotUse.Location = new System.Drawing.Point(1015, 276);
            this.lb_Cam1RobotUse.Name = "lb_Cam1RobotUse";
            this.lb_Cam1RobotUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1RobotUse.TabIndex = 163;
            this.lb_Cam1RobotUse.Text = "屏蔽机械手补偿（1启用0屏蔽）";
            this.lb_Cam1RobotUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1RobotUse
            // 
            this.tb_Cam1RobotUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1RobotUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1RobotUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1RobotUse.Location = new System.Drawing.Point(1108, 288);
            this.tb_Cam1RobotUse.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1RobotUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1RobotUse.Name = "tb_Cam1RobotUse";
            this.tb_Cam1RobotUse.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1RobotUse.TabIndex = 165;
            // 
            // tb_Cam1LaserUse
            // 
            this.tb_Cam1LaserUse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LaserUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1LaserUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LaserUse.Location = new System.Drawing.Point(1108, 334);
            this.tb_Cam1LaserUse.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1LaserUse.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LaserUse.Name = "tb_Cam1LaserUse";
            this.tb_Cam1LaserUse.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1LaserUse.TabIndex = 168;
            // 
            // lb_Cam1LaserUse
            // 
            this.lb_Cam1LaserUse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1LaserUse.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LaserUse.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LaserUse.Location = new System.Drawing.Point(1015, 322);
            this.lb_Cam1LaserUse.Name = "lb_Cam1LaserUse";
            this.lb_Cam1LaserUse.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LaserUse.TabIndex = 164;
            this.lb_Cam1LaserUse.Text = "屏蔽激光补偿（1启用0屏蔽）";
            this.lb_Cam1LaserUse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1LaserStep
            // 
            this.lb_Cam1LaserStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1LaserStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1LaserStep.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1LaserStep.Location = new System.Drawing.Point(831, 322);
            this.lb_Cam1LaserStep.Name = "lb_Cam1LaserStep";
            this.lb_Cam1LaserStep.Size = new System.Drawing.Size(86, 46);
            this.lb_Cam1LaserStep.TabIndex = 157;
            this.lb_Cam1LaserStep.Text = "激光标定偏移";
            this.lb_Cam1LaserStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1LaserStep
            // 
            this.tb_Cam1LaserStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1LaserStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1LaserStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1LaserStep.Location = new System.Drawing.Point(924, 334);
            this.tb_Cam1LaserStep.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1LaserStep.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1LaserStep.Name = "tb_Cam1LaserStep";
            this.tb_Cam1LaserStep.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1LaserStep.TabIndex = 159;
            this.tb_Cam1LaserStep.Tag = "";
            // 
            // tb_Cam1Spacing
            // 
            this.tb_Cam1Spacing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Spacing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Spacing.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Spacing.Location = new System.Drawing.Point(924, 242);
            this.tb_Cam1Spacing.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Spacing.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Spacing.Name = "tb_Cam1Spacing";
            this.tb_Cam1Spacing.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1Spacing.TabIndex = 167;
            this.tb_Cam1Spacing.Tag = "";
            // 
            // tb_Cam1RobotStep
            // 
            this.tb_Cam1RobotStep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1RobotStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1RobotStep.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1RobotStep.Location = new System.Drawing.Point(924, 288);
            this.tb_Cam1RobotStep.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1RobotStep.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1RobotStep.Name = "tb_Cam1RobotStep";
            this.tb_Cam1RobotStep.Size = new System.Drawing.Size(84, 21);
            this.tb_Cam1RobotStep.TabIndex = 158;
            this.tb_Cam1RobotStep.Tag = "";
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
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1Bo2Y, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1Bo2X, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1Bo1Y, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1Bo1X, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1Bo2Y, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1Bo2X, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1Bo1Y, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1Bo1X, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La21Y, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La21X, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La11Y, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La11X, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La21Y, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La21X, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La11Y, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La11X, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La22Y, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La22X, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La12Y, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La12X, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La22Y, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La22X, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La12Y, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La12X, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La23Y, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La23X, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La13Y, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La13X, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La23Y, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La23X, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La13Y, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La13X, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La24Y, 9, 6);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La24X, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La14Y, 9, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Cam1Jig1La14X, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La24Y, 10, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La24X, 10, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La14Y, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Cam1Jig1La14X, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_clearJ1, 13, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_clearJ1, 12, 4);
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
            this.tableLayoutPanel1.TagString = null;
            // 
            // lb_Cam1Jig1Bo2Y
            // 
            this.lb_Cam1Jig1Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig1Bo2Y.Name = "lb_Cam1Jig1Bo2Y";
            this.lb_Cam1Jig1Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig1Bo2Y.Text = "Y：";
            this.lb_Cam1Jig1Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1Bo2X
            // 
            this.lb_Cam1Jig1Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig1Bo2X.Name = "lb_Cam1Jig1Bo2X";
            this.lb_Cam1Jig1Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1Bo2X.TabIndex = 14;
            this.lb_Cam1Jig1Bo2X.Text = "X：";
            this.lb_Cam1Jig1Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig1Bo1Y
            // 
            this.lb_Cam1Jig1Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig1Bo1Y.Name = "lb_Cam1Jig1Bo1Y";
            this.lb_Cam1Jig1Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig1Bo1Y.Text = "Y：";
            this.lb_Cam1Jig1Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1Bo1X
            // 
            this.lb_Cam1Jig1Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig1Bo1X.Name = "lb_Cam1Jig1Bo1X";
            this.lb_Cam1Jig1Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1Bo1X.TabIndex = 3;
            this.lb_Cam1Jig1Bo1X.Text = "X：";
            this.lb_Cam1Jig1Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig1Bo2Y
            // 
            this.tb_Cam1Jig1Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig1Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1Bo2Y.Name = "tb_Cam1Jig1Bo2Y";
            this.tb_Cam1Jig1Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig1Bo2X
            // 
            this.tb_Cam1Jig1Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig1Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1Bo2X.Name = "tb_Cam1Jig1Bo2X";
            this.tb_Cam1Jig1Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1Bo2X.TabIndex = 11;
            // 
            // tb_Cam1Jig1Bo1Y
            // 
            this.tb_Cam1Jig1Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig1Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1Bo1Y.Name = "tb_Cam1Jig1Bo1Y";
            this.tb_Cam1Jig1Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig1Bo1X
            // 
            this.tb_Cam1Jig1Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig1Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1Bo1X.Name = "tb_Cam1Jig1Bo1X";
            this.tb_Cam1Jig1Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig1La21Y
            // 
            this.lb_Cam1Jig1La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig1La21Y.Name = "lb_Cam1Jig1La21Y";
            this.lb_Cam1Jig1La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La21Y.TabIndex = 36;
            this.lb_Cam1Jig1La21Y.Text = "点1Y：";
            this.lb_Cam1Jig1La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La21X
            // 
            this.lb_Cam1Jig1La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig1La21X.Name = "lb_Cam1Jig1La21X";
            this.lb_Cam1Jig1La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La21X.TabIndex = 29;
            this.lb_Cam1Jig1La21X.Text = "点1X：";
            this.lb_Cam1Jig1La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig1La11Y
            // 
            this.lb_Cam1Jig1La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig1La11Y.Name = "lb_Cam1Jig1La11Y";
            this.lb_Cam1Jig1La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La11Y.TabIndex = 19;
            this.lb_Cam1Jig1La11Y.Text = "点1Y：";
            this.lb_Cam1Jig1La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La11X
            // 
            this.lb_Cam1Jig1La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig1La11X.Name = "lb_Cam1Jig1La11X";
            this.lb_Cam1Jig1La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La11X.TabIndex = 6;
            this.lb_Cam1Jig1La11X.Text = "点1X：";
            this.lb_Cam1Jig1La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig1La21Y
            // 
            this.tb_Cam1Jig1La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig1La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La21Y.Name = "tb_Cam1Jig1La21Y";
            this.tb_Cam1Jig1La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La21Y.TabIndex = 30;
            this.tb_Cam1Jig1La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La21X
            // 
            this.tb_Cam1Jig1La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig1La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La21X.Name = "tb_Cam1Jig1La21X";
            this.tb_Cam1Jig1La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La21X.TabIndex = 43;
            this.tb_Cam1Jig1La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La11Y
            // 
            this.tb_Cam1Jig1La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig1La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La11Y.Name = "tb_Cam1Jig1La11Y";
            this.tb_Cam1Jig1La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La11Y.TabIndex = 9;
            this.tb_Cam1Jig1La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La11X
            // 
            this.tb_Cam1Jig1La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig1La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La11X.Name = "tb_Cam1Jig1La11X";
            this.tb_Cam1Jig1La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La11X.TabIndex = 10;
            this.tb_Cam1Jig1La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig1La22Y
            // 
            this.lb_Cam1Jig1La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig1La22Y.Name = "lb_Cam1Jig1La22Y";
            this.lb_Cam1Jig1La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La22Y.TabIndex = 35;
            this.lb_Cam1Jig1La22Y.Text = "点2Y：";
            this.lb_Cam1Jig1La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La22X
            // 
            this.lb_Cam1Jig1La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig1La22X.Name = "lb_Cam1Jig1La22X";
            this.lb_Cam1Jig1La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La22X.TabIndex = 37;
            this.lb_Cam1Jig1La22X.Text = "点2X：";
            this.lb_Cam1Jig1La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La12Y
            // 
            this.lb_Cam1Jig1La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig1La12Y.Name = "lb_Cam1Jig1La12Y";
            this.lb_Cam1Jig1La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La12Y.TabIndex = 18;
            this.lb_Cam1Jig1La12Y.Text = "点2Y：";
            this.lb_Cam1Jig1La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La12X
            // 
            this.lb_Cam1Jig1La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig1La12X.Name = "lb_Cam1Jig1La12X";
            this.lb_Cam1Jig1La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La12X.TabIndex = 20;
            this.lb_Cam1Jig1La12X.Text = "点2X：";
            this.lb_Cam1Jig1La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig1La22Y
            // 
            this.tb_Cam1Jig1La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig1La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La22Y.Name = "tb_Cam1Jig1La22Y";
            this.tb_Cam1Jig1La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La22Y.TabIndex = 41;
            // 
            // tb_Cam1Jig1La22X
            // 
            this.tb_Cam1Jig1La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig1La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La22X.Name = "tb_Cam1Jig1La22X";
            this.tb_Cam1Jig1La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La22X.TabIndex = 42;
            // 
            // tb_Cam1Jig1La12Y
            // 
            this.tb_Cam1Jig1La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig1La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La12Y.Name = "tb_Cam1Jig1La12Y";
            this.tb_Cam1Jig1La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig1La12X
            // 
            this.tb_Cam1Jig1La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig1La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La12X.Name = "tb_Cam1Jig1La12X";
            this.tb_Cam1Jig1La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig1La23Y
            // 
            this.lb_Cam1Jig1La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig1La23Y.Name = "lb_Cam1Jig1La23Y";
            this.lb_Cam1Jig1La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La23Y.TabIndex = 31;
            this.lb_Cam1Jig1La23Y.Text = "点3Y：";
            this.lb_Cam1Jig1La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La23X
            // 
            this.lb_Cam1Jig1La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig1La23X.Name = "lb_Cam1Jig1La23X";
            this.lb_Cam1Jig1La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La23X.TabIndex = 34;
            this.lb_Cam1Jig1La23X.Text = "点3X：";
            this.lb_Cam1Jig1La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La13Y
            // 
            this.lb_Cam1Jig1La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig1La13Y.Name = "lb_Cam1Jig1La13Y";
            this.lb_Cam1Jig1La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La13Y.TabIndex = 5;
            this.lb_Cam1Jig1La13Y.Text = "点3Y：";
            this.lb_Cam1Jig1La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La13X
            // 
            this.lb_Cam1Jig1La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig1La13X.Name = "lb_Cam1Jig1La13X";
            this.lb_Cam1Jig1La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La13X.TabIndex = 17;
            this.lb_Cam1Jig1La13X.Text = "点3X：";
            this.lb_Cam1Jig1La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig1La23Y
            // 
            this.tb_Cam1Jig1La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig1La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La23Y.Name = "tb_Cam1Jig1La23Y";
            this.tb_Cam1Jig1La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La23Y.TabIndex = 44;
            this.tb_Cam1Jig1La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La23X
            // 
            this.tb_Cam1Jig1La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig1La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La23X.Name = "tb_Cam1Jig1La23X";
            this.tb_Cam1Jig1La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La23X.TabIndex = 32;
            this.tb_Cam1Jig1La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La13Y
            // 
            this.tb_Cam1Jig1La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig1La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La13Y.Name = "tb_Cam1Jig1La13Y";
            this.tb_Cam1Jig1La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La13Y.TabIndex = 22;
            this.tb_Cam1Jig1La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig1La13X
            // 
            this.tb_Cam1Jig1La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig1La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La13X.Name = "tb_Cam1Jig1La13X";
            this.tb_Cam1Jig1La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La13X.TabIndex = 26;
            this.tb_Cam1Jig1La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig1La24Y
            // 
            this.lb_Cam1Jig1La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig1La24Y.Name = "lb_Cam1Jig1La24Y";
            this.lb_Cam1Jig1La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La24Y.TabIndex = 38;
            this.lb_Cam1Jig1La24Y.Text = "点4Y：";
            this.lb_Cam1Jig1La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La24X
            // 
            this.lb_Cam1Jig1La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig1La24X.Name = "lb_Cam1Jig1La24X";
            this.lb_Cam1Jig1La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La24X.TabIndex = 33;
            this.lb_Cam1Jig1La24X.Text = "点4X：";
            this.lb_Cam1Jig1La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La14Y
            // 
            this.lb_Cam1Jig1La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig1La14Y.Name = "lb_Cam1Jig1La14Y";
            this.lb_Cam1Jig1La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La14Y.TabIndex = 21;
            this.lb_Cam1Jig1La14Y.Text = "点4Y：";
            this.lb_Cam1Jig1La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig1La14X
            // 
            this.lb_Cam1Jig1La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig1La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig1La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig1La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig1La14X.Name = "lb_Cam1Jig1La14X";
            this.lb_Cam1Jig1La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig1La14X.TabIndex = 16;
            this.lb_Cam1Jig1La14X.Text = "点4X：";
            this.lb_Cam1Jig1La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig1La24Y
            // 
            this.tb_Cam1Jig1La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig1La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La24Y.Name = "tb_Cam1Jig1La24Y";
            this.tb_Cam1Jig1La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La24Y.TabIndex = 39;
            // 
            // tb_Cam1Jig1La24X
            // 
            this.tb_Cam1Jig1La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig1La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La24X.Name = "tb_Cam1Jig1La24X";
            this.tb_Cam1Jig1La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La24X.TabIndex = 40;
            // 
            // tb_Cam1Jig1La14Y
            // 
            this.tb_Cam1Jig1La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig1La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La14Y.Name = "tb_Cam1Jig1La14Y";
            this.tb_Cam1Jig1La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig1La14X
            // 
            this.tb_Cam1Jig1La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig1La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig1La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig1La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig1La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig1La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig1La14X.Name = "tb_Cam1Jig1La14X";
            this.tb_Cam1Jig1La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig1La14X.TabIndex = 25;
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
            // cb_clearJ1
            // 
            this.cb_clearJ1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ1.AutoSize = true;
            this.cb_clearJ1.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ1.Name = "cb_clearJ1";
            this.cb_clearJ1.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ1.TabIndex = 53;
            this.cb_clearJ1.UseVisualStyleBackColor = true;
            // 
            // btn_clearJ1
            // 
            this.btn_clearJ1.Enabled = false;
            this.btn_clearJ1.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ1.Name = "btn_clearJ1";
            this.btn_clearJ1.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ1.TabIndex = 52;
            this.btn_clearJ1.Text = "清除补偿";
            this.btn_clearJ1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2Bo2Y, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2Bo2X, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label28, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2Bo1Y, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2Bo1X, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2Bo2Y, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2Bo2X, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2Bo1Y, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2Bo1X, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La21Y, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La21X, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.label40, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La11Y, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La11X, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label31, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La21Y, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La21X, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La11Y, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La11X, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La22Y, 5, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La22X, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La12Y, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La12X, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La22Y, 6, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La22X, 6, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La12Y, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La12X, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La23Y, 7, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La23X, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La23Y, 8, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La23X, 8, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La13Y, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La13X, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La13Y, 8, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La13X, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La24Y, 9, 6);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La24X, 9, 5);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La14Y, 9, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Cam1Jig2La14X, 9, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La24Y, 10, 6);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La24X, 10, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La14Y, 10, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_Cam1Jig2La14X, 10, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_clearJ2, 12, 4);
            this.tableLayoutPanel2.Controls.Add(this.cb_clearJ2, 13, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
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
            this.tableLayoutPanel2.TagString = null;
            // 
            // lb_Cam1Jig2Bo2Y
            // 
            this.lb_Cam1Jig2Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig2Bo2Y.Name = "lb_Cam1Jig2Bo2Y";
            this.lb_Cam1Jig2Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig2Bo2Y.Text = "Y：";
            this.lb_Cam1Jig2Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2Bo2X
            // 
            this.lb_Cam1Jig2Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig2Bo2X.Name = "lb_Cam1Jig2Bo2X";
            this.lb_Cam1Jig2Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2Bo2X.TabIndex = 14;
            this.lb_Cam1Jig2Bo2X.Text = "X：";
            this.lb_Cam1Jig2Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig2Bo1Y
            // 
            this.lb_Cam1Jig2Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig2Bo1Y.Name = "lb_Cam1Jig2Bo1Y";
            this.lb_Cam1Jig2Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig2Bo1Y.Text = "Y：";
            this.lb_Cam1Jig2Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2Bo1X
            // 
            this.lb_Cam1Jig2Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig2Bo1X.Name = "lb_Cam1Jig2Bo1X";
            this.lb_Cam1Jig2Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2Bo1X.TabIndex = 3;
            this.lb_Cam1Jig2Bo1X.Text = "X：";
            this.lb_Cam1Jig2Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig2Bo2Y
            // 
            this.tb_Cam1Jig2Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig2Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2Bo2Y.Name = "tb_Cam1Jig2Bo2Y";
            this.tb_Cam1Jig2Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig2Bo2X
            // 
            this.tb_Cam1Jig2Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig2Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2Bo2X.Name = "tb_Cam1Jig2Bo2X";
            this.tb_Cam1Jig2Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2Bo2X.TabIndex = 11;
            // 
            // tb_Cam1Jig2Bo1Y
            // 
            this.tb_Cam1Jig2Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig2Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2Bo1Y.Name = "tb_Cam1Jig2Bo1Y";
            this.tb_Cam1Jig2Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig2Bo1X
            // 
            this.tb_Cam1Jig2Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig2Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2Bo1X.Name = "tb_Cam1Jig2Bo1X";
            this.tb_Cam1Jig2Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig2La21Y
            // 
            this.lb_Cam1Jig2La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig2La21Y.Name = "lb_Cam1Jig2La21Y";
            this.lb_Cam1Jig2La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La21Y.TabIndex = 36;
            this.lb_Cam1Jig2La21Y.Text = "点1Y：";
            this.lb_Cam1Jig2La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La21X
            // 
            this.lb_Cam1Jig2La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig2La21X.Name = "lb_Cam1Jig2La21X";
            this.lb_Cam1Jig2La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La21X.TabIndex = 29;
            this.lb_Cam1Jig2La21X.Text = "点1X：";
            this.lb_Cam1Jig2La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig2La11Y
            // 
            this.lb_Cam1Jig2La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig2La11Y.Name = "lb_Cam1Jig2La11Y";
            this.lb_Cam1Jig2La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La11Y.TabIndex = 19;
            this.lb_Cam1Jig2La11Y.Text = "点1Y：";
            this.lb_Cam1Jig2La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La11X
            // 
            this.lb_Cam1Jig2La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig2La11X.Name = "lb_Cam1Jig2La11X";
            this.lb_Cam1Jig2La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La11X.TabIndex = 6;
            this.lb_Cam1Jig2La11X.Text = "点1X：";
            this.lb_Cam1Jig2La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig2La21Y
            // 
            this.tb_Cam1Jig2La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig2La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La21Y.Name = "tb_Cam1Jig2La21Y";
            this.tb_Cam1Jig2La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La21Y.TabIndex = 30;
            this.tb_Cam1Jig2La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig2La21X
            // 
            this.tb_Cam1Jig2La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig2La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La21X.Name = "tb_Cam1Jig2La21X";
            this.tb_Cam1Jig2La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La21X.TabIndex = 43;
            this.tb_Cam1Jig2La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig2La11Y
            // 
            this.tb_Cam1Jig2La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig2La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La11Y.Name = "tb_Cam1Jig2La11Y";
            this.tb_Cam1Jig2La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La11Y.TabIndex = 9;
            this.tb_Cam1Jig2La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig2La11X
            // 
            this.tb_Cam1Jig2La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig2La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La11X.Name = "tb_Cam1Jig2La11X";
            this.tb_Cam1Jig2La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La11X.TabIndex = 10;
            this.tb_Cam1Jig2La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig2La22Y
            // 
            this.lb_Cam1Jig2La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig2La22Y.Name = "lb_Cam1Jig2La22Y";
            this.lb_Cam1Jig2La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La22Y.TabIndex = 35;
            this.lb_Cam1Jig2La22Y.Text = "点2Y：";
            this.lb_Cam1Jig2La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La22X
            // 
            this.lb_Cam1Jig2La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig2La22X.Name = "lb_Cam1Jig2La22X";
            this.lb_Cam1Jig2La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La22X.TabIndex = 37;
            this.lb_Cam1Jig2La22X.Text = "点2X：";
            this.lb_Cam1Jig2La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La12Y
            // 
            this.lb_Cam1Jig2La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig2La12Y.Name = "lb_Cam1Jig2La12Y";
            this.lb_Cam1Jig2La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La12Y.TabIndex = 18;
            this.lb_Cam1Jig2La12Y.Text = "点2Y：";
            this.lb_Cam1Jig2La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La12X
            // 
            this.lb_Cam1Jig2La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig2La12X.Name = "lb_Cam1Jig2La12X";
            this.lb_Cam1Jig2La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La12X.TabIndex = 20;
            this.lb_Cam1Jig2La12X.Text = "点2X：";
            this.lb_Cam1Jig2La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig2La22Y
            // 
            this.tb_Cam1Jig2La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig2La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La22Y.Name = "tb_Cam1Jig2La22Y";
            this.tb_Cam1Jig2La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La22Y.TabIndex = 41;
            // 
            // tb_Cam1Jig2La22X
            // 
            this.tb_Cam1Jig2La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig2La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La22X.Name = "tb_Cam1Jig2La22X";
            this.tb_Cam1Jig2La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La22X.TabIndex = 42;
            // 
            // tb_Cam1Jig2La12Y
            // 
            this.tb_Cam1Jig2La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig2La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La12Y.Name = "tb_Cam1Jig2La12Y";
            this.tb_Cam1Jig2La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig2La12X
            // 
            this.tb_Cam1Jig2La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig2La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La12X.Name = "tb_Cam1Jig2La12X";
            this.tb_Cam1Jig2La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig2La23Y
            // 
            this.lb_Cam1Jig2La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig2La23Y.Name = "lb_Cam1Jig2La23Y";
            this.lb_Cam1Jig2La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La23Y.TabIndex = 31;
            this.lb_Cam1Jig2La23Y.Text = "点3Y：";
            this.lb_Cam1Jig2La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La23X
            // 
            this.lb_Cam1Jig2La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig2La23X.Name = "lb_Cam1Jig2La23X";
            this.lb_Cam1Jig2La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La23X.TabIndex = 34;
            this.lb_Cam1Jig2La23X.Text = "点3X：";
            this.lb_Cam1Jig2La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig2La23Y
            // 
            this.tb_Cam1Jig2La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig2La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La23Y.Name = "tb_Cam1Jig2La23Y";
            this.tb_Cam1Jig2La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La23Y.TabIndex = 44;
            this.tb_Cam1Jig2La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig2La23X
            // 
            this.tb_Cam1Jig2La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig2La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La23X.Name = "tb_Cam1Jig2La23X";
            this.tb_Cam1Jig2La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La23X.TabIndex = 32;
            this.tb_Cam1Jig2La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig2La13Y
            // 
            this.lb_Cam1Jig2La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig2La13Y.Name = "lb_Cam1Jig2La13Y";
            this.lb_Cam1Jig2La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La13Y.TabIndex = 5;
            this.lb_Cam1Jig2La13Y.Text = "点3Y：";
            this.lb_Cam1Jig2La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La13X
            // 
            this.lb_Cam1Jig2La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig2La13X.Name = "lb_Cam1Jig2La13X";
            this.lb_Cam1Jig2La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La13X.TabIndex = 17;
            this.lb_Cam1Jig2La13X.Text = "点3X：";
            this.lb_Cam1Jig2La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig2La13Y
            // 
            this.tb_Cam1Jig2La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig2La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La13Y.Name = "tb_Cam1Jig2La13Y";
            this.tb_Cam1Jig2La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La13Y.TabIndex = 22;
            this.tb_Cam1Jig2La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig2La13X
            // 
            this.tb_Cam1Jig2La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig2La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La13X.Name = "tb_Cam1Jig2La13X";
            this.tb_Cam1Jig2La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La13X.TabIndex = 26;
            this.tb_Cam1Jig2La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig2La24Y
            // 
            this.lb_Cam1Jig2La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig2La24Y.Name = "lb_Cam1Jig2La24Y";
            this.lb_Cam1Jig2La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La24Y.TabIndex = 38;
            this.lb_Cam1Jig2La24Y.Text = "点4Y：";
            this.lb_Cam1Jig2La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La24X
            // 
            this.lb_Cam1Jig2La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig2La24X.Name = "lb_Cam1Jig2La24X";
            this.lb_Cam1Jig2La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La24X.TabIndex = 33;
            this.lb_Cam1Jig2La24X.Text = "点4X：";
            this.lb_Cam1Jig2La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La14Y
            // 
            this.lb_Cam1Jig2La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig2La14Y.Name = "lb_Cam1Jig2La14Y";
            this.lb_Cam1Jig2La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La14Y.TabIndex = 21;
            this.lb_Cam1Jig2La14Y.Text = "点4Y：";
            this.lb_Cam1Jig2La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig2La14X
            // 
            this.lb_Cam1Jig2La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig2La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig2La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig2La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig2La14X.Name = "lb_Cam1Jig2La14X";
            this.lb_Cam1Jig2La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig2La14X.TabIndex = 16;
            this.lb_Cam1Jig2La14X.Text = "点4X：";
            this.lb_Cam1Jig2La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig2La24Y
            // 
            this.tb_Cam1Jig2La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig2La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La24Y.Name = "tb_Cam1Jig2La24Y";
            this.tb_Cam1Jig2La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La24Y.TabIndex = 39;
            // 
            // tb_Cam1Jig2La24X
            // 
            this.tb_Cam1Jig2La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig2La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La24X.Name = "tb_Cam1Jig2La24X";
            this.tb_Cam1Jig2La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La24X.TabIndex = 40;
            // 
            // tb_Cam1Jig2La14Y
            // 
            this.tb_Cam1Jig2La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig2La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La14Y.Name = "tb_Cam1Jig2La14Y";
            this.tb_Cam1Jig2La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig2La14X
            // 
            this.tb_Cam1Jig2La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig2La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig2La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig2La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig2La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig2La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig2La14X.Name = "tb_Cam1Jig2La14X";
            this.tb_Cam1Jig2La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig2La14X.TabIndex = 25;
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
            // btn_clearJ2
            // 
            this.btn_clearJ2.Enabled = false;
            this.btn_clearJ2.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ2.Name = "btn_clearJ2";
            this.btn_clearJ2.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ2.TabIndex = 54;
            this.btn_clearJ2.Text = "清除补偿";
            this.btn_clearJ2.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ2
            // 
            this.cb_clearJ2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ2.AutoSize = true;
            this.cb_clearJ2.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ2.Name = "cb_clearJ2";
            this.cb_clearJ2.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ2.TabIndex = 55;
            this.cb_clearJ2.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3Bo2Y, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3Bo2X, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label52, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3Bo1Y, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3Bo1X, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3Bo2Y, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3Bo2X, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3Bo1Y, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3Bo1X, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La21Y, 3, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La21X, 3, 5);
            this.tableLayoutPanel3.Controls.Add(this.label64, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La11Y, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La11X, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.label55, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La21Y, 4, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La21X, 4, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La11Y, 4, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La11X, 4, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La22Y, 5, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La22X, 5, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La12Y, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La12X, 5, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La22Y, 6, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La22X, 6, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La12Y, 6, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La12X, 6, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La23Y, 7, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La23X, 7, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La13Y, 7, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La13X, 7, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La23Y, 8, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La23X, 8, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La13Y, 8, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La13X, 8, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La24Y, 9, 6);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La24X, 9, 5);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La14Y, 9, 3);
            this.tableLayoutPanel3.Controls.Add(this.lb_Cam1Jig3La14X, 9, 2);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La24Y, 10, 6);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La24X, 10, 5);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La14Y, 10, 3);
            this.tableLayoutPanel3.Controls.Add(this.tb_Cam1Jig3La14X, 10, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_clearJ3, 12, 4);
            this.tableLayoutPanel3.Controls.Add(this.cb_clearJ3, 13, 4);
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
            this.tableLayoutPanel3.TagString = null;
            // 
            // lb_Cam1Jig3Bo2Y
            // 
            this.lb_Cam1Jig3Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig3Bo2Y.Name = "lb_Cam1Jig3Bo2Y";
            this.lb_Cam1Jig3Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig3Bo2Y.Text = "Y：";
            this.lb_Cam1Jig3Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3Bo2X
            // 
            this.lb_Cam1Jig3Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig3Bo2X.Name = "lb_Cam1Jig3Bo2X";
            this.lb_Cam1Jig3Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3Bo2X.TabIndex = 14;
            this.lb_Cam1Jig3Bo2X.Text = "X：";
            this.lb_Cam1Jig3Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig3Bo1Y
            // 
            this.lb_Cam1Jig3Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig3Bo1Y.Name = "lb_Cam1Jig3Bo1Y";
            this.lb_Cam1Jig3Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig3Bo1Y.Text = "Y：";
            this.lb_Cam1Jig3Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3Bo1X
            // 
            this.lb_Cam1Jig3Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig3Bo1X.Name = "lb_Cam1Jig3Bo1X";
            this.lb_Cam1Jig3Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3Bo1X.TabIndex = 3;
            this.lb_Cam1Jig3Bo1X.Text = "X：";
            this.lb_Cam1Jig3Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig3Bo2Y
            // 
            this.tb_Cam1Jig3Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig3Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3Bo2Y.Name = "tb_Cam1Jig3Bo2Y";
            this.tb_Cam1Jig3Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig3Bo2X
            // 
            this.tb_Cam1Jig3Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig3Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3Bo2X.Name = "tb_Cam1Jig3Bo2X";
            this.tb_Cam1Jig3Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3Bo2X.TabIndex = 11;
            // 
            // tb_Cam1Jig3Bo1Y
            // 
            this.tb_Cam1Jig3Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig3Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3Bo1Y.Name = "tb_Cam1Jig3Bo1Y";
            this.tb_Cam1Jig3Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig3Bo1X
            // 
            this.tb_Cam1Jig3Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig3Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3Bo1X.Name = "tb_Cam1Jig3Bo1X";
            this.tb_Cam1Jig3Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig3La21Y
            // 
            this.lb_Cam1Jig3La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig3La21Y.Name = "lb_Cam1Jig3La21Y";
            this.lb_Cam1Jig3La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La21Y.TabIndex = 36;
            this.lb_Cam1Jig3La21Y.Text = "点1Y：";
            this.lb_Cam1Jig3La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La21X
            // 
            this.lb_Cam1Jig3La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig3La21X.Name = "lb_Cam1Jig3La21X";
            this.lb_Cam1Jig3La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La21X.TabIndex = 29;
            this.lb_Cam1Jig3La21X.Text = "点1X：";
            this.lb_Cam1Jig3La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig3La11Y
            // 
            this.lb_Cam1Jig3La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig3La11Y.Name = "lb_Cam1Jig3La11Y";
            this.lb_Cam1Jig3La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La11Y.TabIndex = 19;
            this.lb_Cam1Jig3La11Y.Text = "点1Y：";
            this.lb_Cam1Jig3La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La11X
            // 
            this.lb_Cam1Jig3La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig3La11X.Name = "lb_Cam1Jig3La11X";
            this.lb_Cam1Jig3La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La11X.TabIndex = 6;
            this.lb_Cam1Jig3La11X.Text = "点1X：";
            this.lb_Cam1Jig3La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig3La21Y
            // 
            this.tb_Cam1Jig3La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig3La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La21Y.Name = "tb_Cam1Jig3La21Y";
            this.tb_Cam1Jig3La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La21Y.TabIndex = 30;
            this.tb_Cam1Jig3La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La21X
            // 
            this.tb_Cam1Jig3La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig3La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La21X.Name = "tb_Cam1Jig3La21X";
            this.tb_Cam1Jig3La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La21X.TabIndex = 43;
            this.tb_Cam1Jig3La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La11Y
            // 
            this.tb_Cam1Jig3La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig3La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La11Y.Name = "tb_Cam1Jig3La11Y";
            this.tb_Cam1Jig3La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La11Y.TabIndex = 9;
            this.tb_Cam1Jig3La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La11X
            // 
            this.tb_Cam1Jig3La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig3La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La11X.Name = "tb_Cam1Jig3La11X";
            this.tb_Cam1Jig3La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La11X.TabIndex = 10;
            this.tb_Cam1Jig3La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig3La22Y
            // 
            this.lb_Cam1Jig3La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig3La22Y.Name = "lb_Cam1Jig3La22Y";
            this.lb_Cam1Jig3La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La22Y.TabIndex = 35;
            this.lb_Cam1Jig3La22Y.Text = "点2Y：";
            this.lb_Cam1Jig3La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La22X
            // 
            this.lb_Cam1Jig3La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig3La22X.Name = "lb_Cam1Jig3La22X";
            this.lb_Cam1Jig3La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La22X.TabIndex = 37;
            this.lb_Cam1Jig3La22X.Text = "点2X：";
            this.lb_Cam1Jig3La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La12Y
            // 
            this.lb_Cam1Jig3La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig3La12Y.Name = "lb_Cam1Jig3La12Y";
            this.lb_Cam1Jig3La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La12Y.TabIndex = 18;
            this.lb_Cam1Jig3La12Y.Text = "点2Y：";
            this.lb_Cam1Jig3La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La12X
            // 
            this.lb_Cam1Jig3La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig3La12X.Name = "lb_Cam1Jig3La12X";
            this.lb_Cam1Jig3La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La12X.TabIndex = 20;
            this.lb_Cam1Jig3La12X.Text = "点2X：";
            this.lb_Cam1Jig3La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig3La22Y
            // 
            this.tb_Cam1Jig3La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig3La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La22Y.Name = "tb_Cam1Jig3La22Y";
            this.tb_Cam1Jig3La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La22Y.TabIndex = 41;
            // 
            // tb_Cam1Jig3La22X
            // 
            this.tb_Cam1Jig3La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig3La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La22X.Name = "tb_Cam1Jig3La22X";
            this.tb_Cam1Jig3La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La22X.TabIndex = 42;
            // 
            // tb_Cam1Jig3La12Y
            // 
            this.tb_Cam1Jig3La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig3La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La12Y.Name = "tb_Cam1Jig3La12Y";
            this.tb_Cam1Jig3La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig3La12X
            // 
            this.tb_Cam1Jig3La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig3La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La12X.Name = "tb_Cam1Jig3La12X";
            this.tb_Cam1Jig3La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig3La23Y
            // 
            this.lb_Cam1Jig3La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig3La23Y.Name = "lb_Cam1Jig3La23Y";
            this.lb_Cam1Jig3La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La23Y.TabIndex = 31;
            this.lb_Cam1Jig3La23Y.Text = "点3Y：";
            this.lb_Cam1Jig3La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La23X
            // 
            this.lb_Cam1Jig3La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig3La23X.Name = "lb_Cam1Jig3La23X";
            this.lb_Cam1Jig3La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La23X.TabIndex = 34;
            this.lb_Cam1Jig3La23X.Text = "点3X：";
            this.lb_Cam1Jig3La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La13Y
            // 
            this.lb_Cam1Jig3La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig3La13Y.Name = "lb_Cam1Jig3La13Y";
            this.lb_Cam1Jig3La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La13Y.TabIndex = 5;
            this.lb_Cam1Jig3La13Y.Text = "点3Y：";
            this.lb_Cam1Jig3La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La13X
            // 
            this.lb_Cam1Jig3La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig3La13X.Name = "lb_Cam1Jig3La13X";
            this.lb_Cam1Jig3La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La13X.TabIndex = 17;
            this.lb_Cam1Jig3La13X.Text = "点3X：";
            this.lb_Cam1Jig3La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig3La23Y
            // 
            this.tb_Cam1Jig3La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig3La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La23Y.Name = "tb_Cam1Jig3La23Y";
            this.tb_Cam1Jig3La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La23Y.TabIndex = 44;
            this.tb_Cam1Jig3La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La23X
            // 
            this.tb_Cam1Jig3La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig3La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La23X.Name = "tb_Cam1Jig3La23X";
            this.tb_Cam1Jig3La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La23X.TabIndex = 32;
            this.tb_Cam1Jig3La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La13Y
            // 
            this.tb_Cam1Jig3La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig3La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La13Y.Name = "tb_Cam1Jig3La13Y";
            this.tb_Cam1Jig3La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La13Y.TabIndex = 22;
            this.tb_Cam1Jig3La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig3La13X
            // 
            this.tb_Cam1Jig3La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig3La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La13X.Name = "tb_Cam1Jig3La13X";
            this.tb_Cam1Jig3La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La13X.TabIndex = 26;
            this.tb_Cam1Jig3La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig3La24Y
            // 
            this.lb_Cam1Jig3La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig3La24Y.Name = "lb_Cam1Jig3La24Y";
            this.lb_Cam1Jig3La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La24Y.TabIndex = 38;
            this.lb_Cam1Jig3La24Y.Text = "点4Y：";
            this.lb_Cam1Jig3La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La24X
            // 
            this.lb_Cam1Jig3La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig3La24X.Name = "lb_Cam1Jig3La24X";
            this.lb_Cam1Jig3La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La24X.TabIndex = 33;
            this.lb_Cam1Jig3La24X.Text = "点4X：";
            this.lb_Cam1Jig3La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La14Y
            // 
            this.lb_Cam1Jig3La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig3La14Y.Name = "lb_Cam1Jig3La14Y";
            this.lb_Cam1Jig3La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La14Y.TabIndex = 21;
            this.lb_Cam1Jig3La14Y.Text = "点4Y：";
            this.lb_Cam1Jig3La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig3La14X
            // 
            this.lb_Cam1Jig3La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig3La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig3La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig3La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig3La14X.Name = "lb_Cam1Jig3La14X";
            this.lb_Cam1Jig3La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig3La14X.TabIndex = 16;
            this.lb_Cam1Jig3La14X.Text = "点4X：";
            this.lb_Cam1Jig3La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig3La24Y
            // 
            this.tb_Cam1Jig3La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig3La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La24Y.Name = "tb_Cam1Jig3La24Y";
            this.tb_Cam1Jig3La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La24Y.TabIndex = 39;
            // 
            // tb_Cam1Jig3La24X
            // 
            this.tb_Cam1Jig3La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig3La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La24X.Name = "tb_Cam1Jig3La24X";
            this.tb_Cam1Jig3La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La24X.TabIndex = 40;
            // 
            // tb_Cam1Jig3La14Y
            // 
            this.tb_Cam1Jig3La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig3La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La14Y.Name = "tb_Cam1Jig3La14Y";
            this.tb_Cam1Jig3La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig3La14X
            // 
            this.tb_Cam1Jig3La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig3La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig3La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig3La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig3La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig3La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig3La14X.Name = "tb_Cam1Jig3La14X";
            this.tb_Cam1Jig3La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig3La14X.TabIndex = 25;
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
            // btn_clearJ3
            // 
            this.btn_clearJ3.Enabled = false;
            this.btn_clearJ3.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ3.Name = "btn_clearJ3";
            this.btn_clearJ3.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ3.TabIndex = 54;
            this.btn_clearJ3.Text = "清除补偿";
            this.btn_clearJ3.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ3
            // 
            this.cb_clearJ3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ3.AutoSize = true;
            this.cb_clearJ3.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ3.Name = "cb_clearJ3";
            this.cb_clearJ3.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ3.TabIndex = 55;
            this.cb_clearJ3.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4Bo2Y, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4Bo2Y, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4Bo2X, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4Bo2X, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label76, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4Bo1Y, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4Bo1Y, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4Bo1X, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4Bo1X, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label73, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La21Y, 3, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La21Y, 4, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La21X, 4, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La21X, 3, 5);
            this.tableLayoutPanel4.Controls.Add(this.label88, 3, 4);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La11Y, 3, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La11X, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.label79, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La11Y, 4, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La11X, 4, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La22Y, 5, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La22Y, 6, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La23Y, 7, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La23Y, 8, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La24Y, 9, 6);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La24Y, 10, 6);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La22X, 5, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La22X, 6, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La23X, 7, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La23X, 8, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La24X, 9, 5);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La24X, 10, 5);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La12Y, 5, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La12X, 5, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La12Y, 6, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La12X, 6, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La13Y, 7, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La13X, 7, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La13Y, 8, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La13X, 8, 2);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La14Y, 9, 3);
            this.tableLayoutPanel4.Controls.Add(this.lb_Cam1Jig4La14X, 9, 2);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La14Y, 10, 3);
            this.tableLayoutPanel4.Controls.Add(this.tb_Cam1Jig4La14X, 10, 2);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_clearJ4, 12, 4);
            this.tableLayoutPanel4.Controls.Add(this.cb_clearJ4, 13, 4);
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
            this.tableLayoutPanel4.TagString = null;
            // 
            // lb_Cam1Jig4Bo2Y
            // 
            this.lb_Cam1Jig4Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig4Bo2Y.Name = "lb_Cam1Jig4Bo2Y";
            this.lb_Cam1Jig4Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig4Bo2Y.Text = "Y：";
            this.lb_Cam1Jig4Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4Bo2Y
            // 
            this.tb_Cam1Jig4Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig4Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4Bo2Y.Name = "tb_Cam1Jig4Bo2Y";
            this.tb_Cam1Jig4Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig4Bo2X
            // 
            this.tb_Cam1Jig4Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig4Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4Bo2X.Name = "tb_Cam1Jig4Bo2X";
            this.tb_Cam1Jig4Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig4Bo2X
            // 
            this.lb_Cam1Jig4Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig4Bo2X.Name = "lb_Cam1Jig4Bo2X";
            this.lb_Cam1Jig4Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4Bo2X.TabIndex = 14;
            this.lb_Cam1Jig4Bo2X.Text = "X：";
            this.lb_Cam1Jig4Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig4Bo1Y
            // 
            this.lb_Cam1Jig4Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig4Bo1Y.Name = "lb_Cam1Jig4Bo1Y";
            this.lb_Cam1Jig4Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig4Bo1Y.Text = "Y：";
            this.lb_Cam1Jig4Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4Bo1Y
            // 
            this.tb_Cam1Jig4Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig4Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4Bo1Y.Name = "tb_Cam1Jig4Bo1Y";
            this.tb_Cam1Jig4Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig4Bo1X
            // 
            this.tb_Cam1Jig4Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig4Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4Bo1X.Name = "tb_Cam1Jig4Bo1X";
            this.tb_Cam1Jig4Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig4Bo1X
            // 
            this.lb_Cam1Jig4Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig4Bo1X.Name = "lb_Cam1Jig4Bo1X";
            this.lb_Cam1Jig4Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4Bo1X.TabIndex = 3;
            this.lb_Cam1Jig4Bo1X.Text = "X：";
            this.lb_Cam1Jig4Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig4La21Y
            // 
            this.lb_Cam1Jig4La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig4La21Y.Name = "lb_Cam1Jig4La21Y";
            this.lb_Cam1Jig4La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La21Y.TabIndex = 36;
            this.lb_Cam1Jig4La21Y.Text = "点1Y：";
            this.lb_Cam1Jig4La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La21Y
            // 
            this.tb_Cam1Jig4La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig4La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La21Y.Name = "tb_Cam1Jig4La21Y";
            this.tb_Cam1Jig4La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La21Y.TabIndex = 30;
            this.tb_Cam1Jig4La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig4La21X
            // 
            this.tb_Cam1Jig4La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig4La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La21X.Name = "tb_Cam1Jig4La21X";
            this.tb_Cam1Jig4La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La21X.TabIndex = 43;
            this.tb_Cam1Jig4La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig4La21X
            // 
            this.lb_Cam1Jig4La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig4La21X.Name = "lb_Cam1Jig4La21X";
            this.lb_Cam1Jig4La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La21X.TabIndex = 29;
            this.lb_Cam1Jig4La21X.Text = "点1X：";
            this.lb_Cam1Jig4La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig4La11Y
            // 
            this.lb_Cam1Jig4La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig4La11Y.Name = "lb_Cam1Jig4La11Y";
            this.lb_Cam1Jig4La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La11Y.TabIndex = 19;
            this.lb_Cam1Jig4La11Y.Text = "点1Y：";
            this.lb_Cam1Jig4La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig4La11X
            // 
            this.lb_Cam1Jig4La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig4La11X.Name = "lb_Cam1Jig4La11X";
            this.lb_Cam1Jig4La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La11X.TabIndex = 6;
            this.lb_Cam1Jig4La11X.Text = "点1X：";
            this.lb_Cam1Jig4La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig4La11Y
            // 
            this.tb_Cam1Jig4La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig4La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La11Y.Name = "tb_Cam1Jig4La11Y";
            this.tb_Cam1Jig4La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La11Y.TabIndex = 9;
            this.tb_Cam1Jig4La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig4La11X
            // 
            this.tb_Cam1Jig4La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig4La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La11X.Name = "tb_Cam1Jig4La11X";
            this.tb_Cam1Jig4La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La11X.TabIndex = 10;
            this.tb_Cam1Jig4La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig4La22Y
            // 
            this.lb_Cam1Jig4La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig4La22Y.Name = "lb_Cam1Jig4La22Y";
            this.lb_Cam1Jig4La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La22Y.TabIndex = 35;
            this.lb_Cam1Jig4La22Y.Text = "点2Y：";
            this.lb_Cam1Jig4La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La22Y
            // 
            this.tb_Cam1Jig4La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig4La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La22Y.Name = "tb_Cam1Jig4La22Y";
            this.tb_Cam1Jig4La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig4La23Y
            // 
            this.lb_Cam1Jig4La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig4La23Y.Name = "lb_Cam1Jig4La23Y";
            this.lb_Cam1Jig4La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La23Y.TabIndex = 31;
            this.lb_Cam1Jig4La23Y.Text = "点3Y：";
            this.lb_Cam1Jig4La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La23Y
            // 
            this.tb_Cam1Jig4La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig4La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La23Y.Name = "tb_Cam1Jig4La23Y";
            this.tb_Cam1Jig4La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La23Y.TabIndex = 44;
            this.tb_Cam1Jig4La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig4La24Y
            // 
            this.lb_Cam1Jig4La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig4La24Y.Name = "lb_Cam1Jig4La24Y";
            this.lb_Cam1Jig4La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La24Y.TabIndex = 38;
            this.lb_Cam1Jig4La24Y.Text = "点4Y：";
            this.lb_Cam1Jig4La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La24Y
            // 
            this.tb_Cam1Jig4La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig4La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La24Y.Name = "tb_Cam1Jig4La24Y";
            this.tb_Cam1Jig4La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig4La22X
            // 
            this.lb_Cam1Jig4La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig4La22X.Name = "lb_Cam1Jig4La22X";
            this.lb_Cam1Jig4La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La22X.TabIndex = 37;
            this.lb_Cam1Jig4La22X.Text = "点2X：";
            this.lb_Cam1Jig4La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La22X
            // 
            this.tb_Cam1Jig4La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig4La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La22X.Name = "tb_Cam1Jig4La22X";
            this.tb_Cam1Jig4La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig4La23X
            // 
            this.lb_Cam1Jig4La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig4La23X.Name = "lb_Cam1Jig4La23X";
            this.lb_Cam1Jig4La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La23X.TabIndex = 34;
            this.lb_Cam1Jig4La23X.Text = "点3X：";
            this.lb_Cam1Jig4La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La23X
            // 
            this.tb_Cam1Jig4La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig4La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La23X.Name = "tb_Cam1Jig4La23X";
            this.tb_Cam1Jig4La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La23X.TabIndex = 32;
            this.tb_Cam1Jig4La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig4La24X
            // 
            this.lb_Cam1Jig4La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig4La24X.Name = "lb_Cam1Jig4La24X";
            this.lb_Cam1Jig4La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La24X.TabIndex = 33;
            this.lb_Cam1Jig4La24X.Text = "点4X：";
            this.lb_Cam1Jig4La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La24X
            // 
            this.tb_Cam1Jig4La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig4La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La24X.Name = "tb_Cam1Jig4La24X";
            this.tb_Cam1Jig4La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig4La12Y
            // 
            this.lb_Cam1Jig4La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig4La12Y.Name = "lb_Cam1Jig4La12Y";
            this.lb_Cam1Jig4La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La12Y.TabIndex = 18;
            this.lb_Cam1Jig4La12Y.Text = "点2Y：";
            this.lb_Cam1Jig4La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig4La12X
            // 
            this.lb_Cam1Jig4La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig4La12X.Name = "lb_Cam1Jig4La12X";
            this.lb_Cam1Jig4La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La12X.TabIndex = 20;
            this.lb_Cam1Jig4La12X.Text = "点2X：";
            this.lb_Cam1Jig4La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La12Y
            // 
            this.tb_Cam1Jig4La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig4La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La12Y.Name = "tb_Cam1Jig4La12Y";
            this.tb_Cam1Jig4La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig4La12X
            // 
            this.tb_Cam1Jig4La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig4La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La12X.Name = "tb_Cam1Jig4La12X";
            this.tb_Cam1Jig4La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig4La13Y
            // 
            this.lb_Cam1Jig4La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig4La13Y.Name = "lb_Cam1Jig4La13Y";
            this.lb_Cam1Jig4La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La13Y.TabIndex = 5;
            this.lb_Cam1Jig4La13Y.Text = "点3Y：";
            this.lb_Cam1Jig4La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig4La13X
            // 
            this.lb_Cam1Jig4La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig4La13X.Name = "lb_Cam1Jig4La13X";
            this.lb_Cam1Jig4La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La13X.TabIndex = 17;
            this.lb_Cam1Jig4La13X.Text = "点3X：";
            this.lb_Cam1Jig4La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La13Y
            // 
            this.tb_Cam1Jig4La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig4La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La13Y.Name = "tb_Cam1Jig4La13Y";
            this.tb_Cam1Jig4La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La13Y.TabIndex = 22;
            this.tb_Cam1Jig4La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig4La13X
            // 
            this.tb_Cam1Jig4La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig4La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La13X.Name = "tb_Cam1Jig4La13X";
            this.tb_Cam1Jig4La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La13X.TabIndex = 26;
            this.tb_Cam1Jig4La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig4La14Y
            // 
            this.lb_Cam1Jig4La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig4La14Y.Name = "lb_Cam1Jig4La14Y";
            this.lb_Cam1Jig4La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La14Y.TabIndex = 21;
            this.lb_Cam1Jig4La14Y.Text = "点4Y：";
            this.lb_Cam1Jig4La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig4La14X
            // 
            this.lb_Cam1Jig4La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig4La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig4La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig4La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig4La14X.Name = "lb_Cam1Jig4La14X";
            this.lb_Cam1Jig4La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig4La14X.TabIndex = 16;
            this.lb_Cam1Jig4La14X.Text = "点4X：";
            this.lb_Cam1Jig4La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig4La14Y
            // 
            this.tb_Cam1Jig4La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig4La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La14Y.Name = "tb_Cam1Jig4La14Y";
            this.tb_Cam1Jig4La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig4La14X
            // 
            this.tb_Cam1Jig4La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig4La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig4La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig4La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig4La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig4La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig4La14X.Name = "tb_Cam1Jig4La14X";
            this.tb_Cam1Jig4La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig4La14X.TabIndex = 25;
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
            // btn_clearJ4
            // 
            this.btn_clearJ4.Enabled = false;
            this.btn_clearJ4.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ4.Name = "btn_clearJ4";
            this.btn_clearJ4.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ4.TabIndex = 54;
            this.btn_clearJ4.Text = "清除补偿";
            this.btn_clearJ4.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ4
            // 
            this.cb_clearJ4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ4.AutoSize = true;
            this.cb_clearJ4.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ4.Name = "cb_clearJ4";
            this.cb_clearJ4.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ4.TabIndex = 55;
            this.cb_clearJ4.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5Bo2Y, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5Bo2Y, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5Bo2X, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5Bo2X, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5Bo1Y, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5Bo1Y, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5Bo1X, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5Bo1X, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La21Y, 3, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La21Y, 4, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La21X, 4, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La21X, 3, 5);
            this.tableLayoutPanel5.Controls.Add(this.label17, 3, 4);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La11Y, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La11X, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.label20, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La11Y, 4, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La11X, 4, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La22Y, 5, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La22Y, 6, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La23Y, 7, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La23Y, 8, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La24Y, 9, 6);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La24Y, 10, 6);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La22X, 5, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La22X, 6, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La23X, 7, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La23X, 8, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La24X, 9, 5);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La24X, 10, 5);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La12Y, 5, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La12X, 5, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La12Y, 6, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La12X, 6, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La13Y, 7, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La13X, 7, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La13Y, 8, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La13X, 8, 2);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La14Y, 9, 3);
            this.tableLayoutPanel5.Controls.Add(this.lb_Cam1Jig5La14X, 9, 2);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La14Y, 10, 3);
            this.tableLayoutPanel5.Controls.Add(this.tb_Cam1Jig5La14X, 10, 2);
            this.tableLayoutPanel5.Controls.Add(this.label36, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_clearJ5, 12, 4);
            this.tableLayoutPanel5.Controls.Add(this.cb_clearJ5, 13, 4);
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
            this.tableLayoutPanel5.TagString = null;
            // 
            // lb_Cam1Jig5Bo2Y
            // 
            this.lb_Cam1Jig5Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig5Bo2Y.Name = "lb_Cam1Jig5Bo2Y";
            this.lb_Cam1Jig5Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig5Bo2Y.Text = "Y：";
            this.lb_Cam1Jig5Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5Bo2Y
            // 
            this.tb_Cam1Jig5Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig5Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5Bo2Y.Name = "tb_Cam1Jig5Bo2Y";
            this.tb_Cam1Jig5Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig5Bo2X
            // 
            this.tb_Cam1Jig5Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig5Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5Bo2X.Name = "tb_Cam1Jig5Bo2X";
            this.tb_Cam1Jig5Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig5Bo2X
            // 
            this.lb_Cam1Jig5Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig5Bo2X.Name = "lb_Cam1Jig5Bo2X";
            this.lb_Cam1Jig5Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5Bo2X.TabIndex = 14;
            this.lb_Cam1Jig5Bo2X.Text = "X：";
            this.lb_Cam1Jig5Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig5Bo1Y
            // 
            this.lb_Cam1Jig5Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig5Bo1Y.Name = "lb_Cam1Jig5Bo1Y";
            this.lb_Cam1Jig5Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig5Bo1Y.Text = "Y：";
            this.lb_Cam1Jig5Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5Bo1Y
            // 
            this.tb_Cam1Jig5Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig5Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5Bo1Y.Name = "tb_Cam1Jig5Bo1Y";
            this.tb_Cam1Jig5Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig5Bo1X
            // 
            this.tb_Cam1Jig5Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig5Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5Bo1X.Name = "tb_Cam1Jig5Bo1X";
            this.tb_Cam1Jig5Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig5Bo1X
            // 
            this.lb_Cam1Jig5Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig5Bo1X.Name = "lb_Cam1Jig5Bo1X";
            this.lb_Cam1Jig5Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5Bo1X.TabIndex = 3;
            this.lb_Cam1Jig5Bo1X.Text = "X：";
            this.lb_Cam1Jig5Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig5La21Y
            // 
            this.lb_Cam1Jig5La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig5La21Y.Name = "lb_Cam1Jig5La21Y";
            this.lb_Cam1Jig5La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La21Y.TabIndex = 36;
            this.lb_Cam1Jig5La21Y.Text = "点1Y：";
            this.lb_Cam1Jig5La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La21Y
            // 
            this.tb_Cam1Jig5La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig5La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La21Y.Name = "tb_Cam1Jig5La21Y";
            this.tb_Cam1Jig5La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La21Y.TabIndex = 30;
            this.tb_Cam1Jig5La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig5La21X
            // 
            this.tb_Cam1Jig5La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig5La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La21X.Name = "tb_Cam1Jig5La21X";
            this.tb_Cam1Jig5La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La21X.TabIndex = 43;
            this.tb_Cam1Jig5La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig5La21X
            // 
            this.lb_Cam1Jig5La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig5La21X.Name = "lb_Cam1Jig5La21X";
            this.lb_Cam1Jig5La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La21X.TabIndex = 29;
            this.lb_Cam1Jig5La21X.Text = "点1X：";
            this.lb_Cam1Jig5La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig5La11Y
            // 
            this.lb_Cam1Jig5La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig5La11Y.Name = "lb_Cam1Jig5La11Y";
            this.lb_Cam1Jig5La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La11Y.TabIndex = 19;
            this.lb_Cam1Jig5La11Y.Text = "点1Y：";
            this.lb_Cam1Jig5La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig5La11X
            // 
            this.lb_Cam1Jig5La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig5La11X.Name = "lb_Cam1Jig5La11X";
            this.lb_Cam1Jig5La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La11X.TabIndex = 6;
            this.lb_Cam1Jig5La11X.Text = "点1X：";
            this.lb_Cam1Jig5La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig5La11Y
            // 
            this.tb_Cam1Jig5La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig5La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La11Y.Name = "tb_Cam1Jig5La11Y";
            this.tb_Cam1Jig5La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La11Y.TabIndex = 9;
            this.tb_Cam1Jig5La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig5La11X
            // 
            this.tb_Cam1Jig5La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig5La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La11X.Name = "tb_Cam1Jig5La11X";
            this.tb_Cam1Jig5La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La11X.TabIndex = 10;
            this.tb_Cam1Jig5La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig5La22Y
            // 
            this.lb_Cam1Jig5La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig5La22Y.Name = "lb_Cam1Jig5La22Y";
            this.lb_Cam1Jig5La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La22Y.TabIndex = 35;
            this.lb_Cam1Jig5La22Y.Text = "点2Y：";
            this.lb_Cam1Jig5La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La22Y
            // 
            this.tb_Cam1Jig5La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig5La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La22Y.Name = "tb_Cam1Jig5La22Y";
            this.tb_Cam1Jig5La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig5La23Y
            // 
            this.lb_Cam1Jig5La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig5La23Y.Name = "lb_Cam1Jig5La23Y";
            this.lb_Cam1Jig5La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La23Y.TabIndex = 31;
            this.lb_Cam1Jig5La23Y.Text = "点3Y：";
            this.lb_Cam1Jig5La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La23Y
            // 
            this.tb_Cam1Jig5La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig5La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La23Y.Name = "tb_Cam1Jig5La23Y";
            this.tb_Cam1Jig5La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La23Y.TabIndex = 44;
            this.tb_Cam1Jig5La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig5La24Y
            // 
            this.lb_Cam1Jig5La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig5La24Y.Name = "lb_Cam1Jig5La24Y";
            this.lb_Cam1Jig5La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La24Y.TabIndex = 38;
            this.lb_Cam1Jig5La24Y.Text = "点4Y：";
            this.lb_Cam1Jig5La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La24Y
            // 
            this.tb_Cam1Jig5La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig5La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La24Y.Name = "tb_Cam1Jig5La24Y";
            this.tb_Cam1Jig5La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig5La22X
            // 
            this.lb_Cam1Jig5La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig5La22X.Name = "lb_Cam1Jig5La22X";
            this.lb_Cam1Jig5La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La22X.TabIndex = 37;
            this.lb_Cam1Jig5La22X.Text = "点2X：";
            this.lb_Cam1Jig5La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La22X
            // 
            this.tb_Cam1Jig5La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig5La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La22X.Name = "tb_Cam1Jig5La22X";
            this.tb_Cam1Jig5La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig5La23X
            // 
            this.lb_Cam1Jig5La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig5La23X.Name = "lb_Cam1Jig5La23X";
            this.lb_Cam1Jig5La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La23X.TabIndex = 34;
            this.lb_Cam1Jig5La23X.Text = "点3X：";
            this.lb_Cam1Jig5La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La23X
            // 
            this.tb_Cam1Jig5La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig5La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La23X.Name = "tb_Cam1Jig5La23X";
            this.tb_Cam1Jig5La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La23X.TabIndex = 32;
            this.tb_Cam1Jig5La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig5La24X
            // 
            this.lb_Cam1Jig5La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig5La24X.Name = "lb_Cam1Jig5La24X";
            this.lb_Cam1Jig5La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La24X.TabIndex = 33;
            this.lb_Cam1Jig5La24X.Text = "点4X：";
            this.lb_Cam1Jig5La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La24X
            // 
            this.tb_Cam1Jig5La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig5La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La24X.Name = "tb_Cam1Jig5La24X";
            this.tb_Cam1Jig5La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig5La12Y
            // 
            this.lb_Cam1Jig5La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig5La12Y.Name = "lb_Cam1Jig5La12Y";
            this.lb_Cam1Jig5La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La12Y.TabIndex = 18;
            this.lb_Cam1Jig5La12Y.Text = "点2Y：";
            this.lb_Cam1Jig5La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig5La12X
            // 
            this.lb_Cam1Jig5La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig5La12X.Name = "lb_Cam1Jig5La12X";
            this.lb_Cam1Jig5La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La12X.TabIndex = 20;
            this.lb_Cam1Jig5La12X.Text = "点2X：";
            this.lb_Cam1Jig5La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La12Y
            // 
            this.tb_Cam1Jig5La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig5La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La12Y.Name = "tb_Cam1Jig5La12Y";
            this.tb_Cam1Jig5La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig5La12X
            // 
            this.tb_Cam1Jig5La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig5La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La12X.Name = "tb_Cam1Jig5La12X";
            this.tb_Cam1Jig5La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig5La13Y
            // 
            this.lb_Cam1Jig5La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig5La13Y.Name = "lb_Cam1Jig5La13Y";
            this.lb_Cam1Jig5La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La13Y.TabIndex = 5;
            this.lb_Cam1Jig5La13Y.Text = "点3Y：";
            this.lb_Cam1Jig5La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig5La13X
            // 
            this.lb_Cam1Jig5La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig5La13X.Name = "lb_Cam1Jig5La13X";
            this.lb_Cam1Jig5La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La13X.TabIndex = 17;
            this.lb_Cam1Jig5La13X.Text = "点3X：";
            this.lb_Cam1Jig5La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La13Y
            // 
            this.tb_Cam1Jig5La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig5La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La13Y.Name = "tb_Cam1Jig5La13Y";
            this.tb_Cam1Jig5La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La13Y.TabIndex = 22;
            this.tb_Cam1Jig5La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig5La13X
            // 
            this.tb_Cam1Jig5La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig5La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La13X.Name = "tb_Cam1Jig5La13X";
            this.tb_Cam1Jig5La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La13X.TabIndex = 26;
            this.tb_Cam1Jig5La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig5La14Y
            // 
            this.lb_Cam1Jig5La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig5La14Y.Name = "lb_Cam1Jig5La14Y";
            this.lb_Cam1Jig5La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La14Y.TabIndex = 21;
            this.lb_Cam1Jig5La14Y.Text = "点4Y：";
            this.lb_Cam1Jig5La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig5La14X
            // 
            this.lb_Cam1Jig5La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig5La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig5La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig5La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig5La14X.Name = "lb_Cam1Jig5La14X";
            this.lb_Cam1Jig5La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig5La14X.TabIndex = 16;
            this.lb_Cam1Jig5La14X.Text = "点4X：";
            this.lb_Cam1Jig5La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig5La14Y
            // 
            this.tb_Cam1Jig5La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig5La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La14Y.Name = "tb_Cam1Jig5La14Y";
            this.tb_Cam1Jig5La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig5La14X
            // 
            this.tb_Cam1Jig5La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig5La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig5La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig5La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig5La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig5La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig5La14X.Name = "tb_Cam1Jig5La14X";
            this.tb_Cam1Jig5La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig5La14X.TabIndex = 25;
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
            // btn_clearJ5
            // 
            this.btn_clearJ5.Enabled = false;
            this.btn_clearJ5.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ5.Name = "btn_clearJ5";
            this.btn_clearJ5.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ5.TabIndex = 54;
            this.btn_clearJ5.Text = "清除补偿";
            this.btn_clearJ5.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ5
            // 
            this.cb_clearJ5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ5.AutoSize = true;
            this.cb_clearJ5.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ5.Name = "cb_clearJ5";
            this.cb_clearJ5.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ5.TabIndex = 55;
            this.cb_clearJ5.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6Bo2Y, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6Bo2Y, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6Bo2X, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6Bo2X, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label39, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6Bo1Y, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6Bo1Y, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6Bo1X, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6Bo1X, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.label43, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La21Y, 3, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La21Y, 4, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La21X, 4, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La21X, 3, 5);
            this.tableLayoutPanel6.Controls.Add(this.label46, 3, 4);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La11Y, 3, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La11X, 3, 2);
            this.tableLayoutPanel6.Controls.Add(this.label50, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La11Y, 4, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La11X, 4, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La22Y, 5, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La22Y, 6, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La23Y, 7, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La23Y, 8, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La24Y, 9, 6);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La24Y, 10, 6);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La22X, 5, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La22X, 6, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La23X, 7, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La23X, 8, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La24X, 9, 5);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La24X, 10, 5);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La12Y, 5, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La12X, 5, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La12Y, 6, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La12X, 6, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La13Y, 7, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La13X, 7, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La13Y, 8, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La13X, 8, 2);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La14Y, 9, 3);
            this.tableLayoutPanel6.Controls.Add(this.lb_Cam1Jig6La14X, 9, 2);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La14Y, 10, 3);
            this.tableLayoutPanel6.Controls.Add(this.tb_Cam1Jig6La14X, 10, 2);
            this.tableLayoutPanel6.Controls.Add(this.label66, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_clearJ6, 12, 4);
            this.tableLayoutPanel6.Controls.Add(this.cb_clearJ6, 13, 4);
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
            this.tableLayoutPanel6.TagString = null;
            // 
            // lb_Cam1Jig6Bo2Y
            // 
            this.lb_Cam1Jig6Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig6Bo2Y.Name = "lb_Cam1Jig6Bo2Y";
            this.lb_Cam1Jig6Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig6Bo2Y.Text = "Y：";
            this.lb_Cam1Jig6Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6Bo2Y
            // 
            this.tb_Cam1Jig6Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig6Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6Bo2Y.Name = "tb_Cam1Jig6Bo2Y";
            this.tb_Cam1Jig6Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig6Bo2X
            // 
            this.tb_Cam1Jig6Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig6Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6Bo2X.Name = "tb_Cam1Jig6Bo2X";
            this.tb_Cam1Jig6Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig6Bo2X
            // 
            this.lb_Cam1Jig6Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig6Bo2X.Name = "lb_Cam1Jig6Bo2X";
            this.lb_Cam1Jig6Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6Bo2X.TabIndex = 14;
            this.lb_Cam1Jig6Bo2X.Text = "X：";
            this.lb_Cam1Jig6Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig6Bo1Y
            // 
            this.lb_Cam1Jig6Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig6Bo1Y.Name = "lb_Cam1Jig6Bo1Y";
            this.lb_Cam1Jig6Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig6Bo1Y.Text = "Y：";
            this.lb_Cam1Jig6Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6Bo1Y
            // 
            this.tb_Cam1Jig6Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig6Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6Bo1Y.Name = "tb_Cam1Jig6Bo1Y";
            this.tb_Cam1Jig6Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig6Bo1X
            // 
            this.tb_Cam1Jig6Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig6Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6Bo1X.Name = "tb_Cam1Jig6Bo1X";
            this.tb_Cam1Jig6Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig6Bo1X
            // 
            this.lb_Cam1Jig6Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig6Bo1X.Name = "lb_Cam1Jig6Bo1X";
            this.lb_Cam1Jig6Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6Bo1X.TabIndex = 3;
            this.lb_Cam1Jig6Bo1X.Text = "X：";
            this.lb_Cam1Jig6Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig6La21Y
            // 
            this.lb_Cam1Jig6La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig6La21Y.Name = "lb_Cam1Jig6La21Y";
            this.lb_Cam1Jig6La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La21Y.TabIndex = 36;
            this.lb_Cam1Jig6La21Y.Text = "点1Y：";
            this.lb_Cam1Jig6La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La21Y
            // 
            this.tb_Cam1Jig6La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig6La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La21Y.Name = "tb_Cam1Jig6La21Y";
            this.tb_Cam1Jig6La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La21Y.TabIndex = 30;
            this.tb_Cam1Jig6La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig6La21X
            // 
            this.tb_Cam1Jig6La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig6La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La21X.Name = "tb_Cam1Jig6La21X";
            this.tb_Cam1Jig6La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La21X.TabIndex = 43;
            this.tb_Cam1Jig6La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig6La21X
            // 
            this.lb_Cam1Jig6La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig6La21X.Name = "lb_Cam1Jig6La21X";
            this.lb_Cam1Jig6La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La21X.TabIndex = 29;
            this.lb_Cam1Jig6La21X.Text = "点1X：";
            this.lb_Cam1Jig6La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig6La11Y
            // 
            this.lb_Cam1Jig6La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig6La11Y.Name = "lb_Cam1Jig6La11Y";
            this.lb_Cam1Jig6La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La11Y.TabIndex = 19;
            this.lb_Cam1Jig6La11Y.Text = "点1Y：";
            this.lb_Cam1Jig6La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig6La11X
            // 
            this.lb_Cam1Jig6La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig6La11X.Name = "lb_Cam1Jig6La11X";
            this.lb_Cam1Jig6La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La11X.TabIndex = 6;
            this.lb_Cam1Jig6La11X.Text = "点1X：";
            this.lb_Cam1Jig6La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig6La11Y
            // 
            this.tb_Cam1Jig6La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig6La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La11Y.Name = "tb_Cam1Jig6La11Y";
            this.tb_Cam1Jig6La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La11Y.TabIndex = 9;
            this.tb_Cam1Jig6La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig6La11X
            // 
            this.tb_Cam1Jig6La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig6La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La11X.Name = "tb_Cam1Jig6La11X";
            this.tb_Cam1Jig6La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La11X.TabIndex = 10;
            this.tb_Cam1Jig6La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig6La22Y
            // 
            this.lb_Cam1Jig6La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig6La22Y.Name = "lb_Cam1Jig6La22Y";
            this.lb_Cam1Jig6La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La22Y.TabIndex = 35;
            this.lb_Cam1Jig6La22Y.Text = "点2Y：";
            this.lb_Cam1Jig6La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La22Y
            // 
            this.tb_Cam1Jig6La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig6La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La22Y.Name = "tb_Cam1Jig6La22Y";
            this.tb_Cam1Jig6La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig6La23Y
            // 
            this.lb_Cam1Jig6La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig6La23Y.Name = "lb_Cam1Jig6La23Y";
            this.lb_Cam1Jig6La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La23Y.TabIndex = 31;
            this.lb_Cam1Jig6La23Y.Text = "点3Y：";
            this.lb_Cam1Jig6La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La23Y
            // 
            this.tb_Cam1Jig6La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig6La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La23Y.Name = "tb_Cam1Jig6La23Y";
            this.tb_Cam1Jig6La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La23Y.TabIndex = 44;
            this.tb_Cam1Jig6La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig6La24Y
            // 
            this.lb_Cam1Jig6La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig6La24Y.Name = "lb_Cam1Jig6La24Y";
            this.lb_Cam1Jig6La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La24Y.TabIndex = 38;
            this.lb_Cam1Jig6La24Y.Text = "点4Y：";
            this.lb_Cam1Jig6La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La24Y
            // 
            this.tb_Cam1Jig6La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig6La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La24Y.Name = "tb_Cam1Jig6La24Y";
            this.tb_Cam1Jig6La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig6La22X
            // 
            this.lb_Cam1Jig6La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig6La22X.Name = "lb_Cam1Jig6La22X";
            this.lb_Cam1Jig6La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La22X.TabIndex = 37;
            this.lb_Cam1Jig6La22X.Text = "点2X：";
            this.lb_Cam1Jig6La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La22X
            // 
            this.tb_Cam1Jig6La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig6La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La22X.Name = "tb_Cam1Jig6La22X";
            this.tb_Cam1Jig6La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig6La23X
            // 
            this.lb_Cam1Jig6La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig6La23X.Name = "lb_Cam1Jig6La23X";
            this.lb_Cam1Jig6La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La23X.TabIndex = 34;
            this.lb_Cam1Jig6La23X.Text = "点3X：";
            this.lb_Cam1Jig6La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La23X
            // 
            this.tb_Cam1Jig6La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig6La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La23X.Name = "tb_Cam1Jig6La23X";
            this.tb_Cam1Jig6La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La23X.TabIndex = 32;
            this.tb_Cam1Jig6La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig6La24X
            // 
            this.lb_Cam1Jig6La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig6La24X.Name = "lb_Cam1Jig6La24X";
            this.lb_Cam1Jig6La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La24X.TabIndex = 33;
            this.lb_Cam1Jig6La24X.Text = "点4X：";
            this.lb_Cam1Jig6La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La24X
            // 
            this.tb_Cam1Jig6La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig6La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La24X.Name = "tb_Cam1Jig6La24X";
            this.tb_Cam1Jig6La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig6La12Y
            // 
            this.lb_Cam1Jig6La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig6La12Y.Name = "lb_Cam1Jig6La12Y";
            this.lb_Cam1Jig6La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La12Y.TabIndex = 18;
            this.lb_Cam1Jig6La12Y.Text = "点2Y：";
            this.lb_Cam1Jig6La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig6La12X
            // 
            this.lb_Cam1Jig6La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig6La12X.Name = "lb_Cam1Jig6La12X";
            this.lb_Cam1Jig6La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La12X.TabIndex = 20;
            this.lb_Cam1Jig6La12X.Text = "点2X：";
            this.lb_Cam1Jig6La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La12Y
            // 
            this.tb_Cam1Jig6La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig6La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La12Y.Name = "tb_Cam1Jig6La12Y";
            this.tb_Cam1Jig6La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig6La12X
            // 
            this.tb_Cam1Jig6La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig6La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La12X.Name = "tb_Cam1Jig6La12X";
            this.tb_Cam1Jig6La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig6La13Y
            // 
            this.lb_Cam1Jig6La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig6La13Y.Name = "lb_Cam1Jig6La13Y";
            this.lb_Cam1Jig6La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La13Y.TabIndex = 5;
            this.lb_Cam1Jig6La13Y.Text = "点3Y：";
            this.lb_Cam1Jig6La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig6La13X
            // 
            this.lb_Cam1Jig6La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig6La13X.Name = "lb_Cam1Jig6La13X";
            this.lb_Cam1Jig6La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La13X.TabIndex = 17;
            this.lb_Cam1Jig6La13X.Text = "点3X：";
            this.lb_Cam1Jig6La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La13Y
            // 
            this.tb_Cam1Jig6La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig6La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La13Y.Name = "tb_Cam1Jig6La13Y";
            this.tb_Cam1Jig6La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La13Y.TabIndex = 22;
            this.tb_Cam1Jig6La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig6La13X
            // 
            this.tb_Cam1Jig6La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig6La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La13X.Name = "tb_Cam1Jig6La13X";
            this.tb_Cam1Jig6La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La13X.TabIndex = 26;
            this.tb_Cam1Jig6La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig6La14Y
            // 
            this.lb_Cam1Jig6La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig6La14Y.Name = "lb_Cam1Jig6La14Y";
            this.lb_Cam1Jig6La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La14Y.TabIndex = 21;
            this.lb_Cam1Jig6La14Y.Text = "点4Y：";
            this.lb_Cam1Jig6La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig6La14X
            // 
            this.lb_Cam1Jig6La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig6La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig6La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig6La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig6La14X.Name = "lb_Cam1Jig6La14X";
            this.lb_Cam1Jig6La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig6La14X.TabIndex = 16;
            this.lb_Cam1Jig6La14X.Text = "点4X：";
            this.lb_Cam1Jig6La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig6La14Y
            // 
            this.tb_Cam1Jig6La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig6La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La14Y.Name = "tb_Cam1Jig6La14Y";
            this.tb_Cam1Jig6La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig6La14X
            // 
            this.tb_Cam1Jig6La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig6La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig6La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig6La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig6La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig6La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig6La14X.Name = "tb_Cam1Jig6La14X";
            this.tb_Cam1Jig6La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig6La14X.TabIndex = 25;
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
            // btn_clearJ6
            // 
            this.btn_clearJ6.Enabled = false;
            this.btn_clearJ6.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ6.Name = "btn_clearJ6";
            this.btn_clearJ6.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ6.TabIndex = 54;
            this.btn_clearJ6.Text = "清除补偿";
            this.btn_clearJ6.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ6
            // 
            this.cb_clearJ6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ6.AutoSize = true;
            this.cb_clearJ6.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ6.Name = "cb_clearJ6";
            this.cb_clearJ6.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ6.TabIndex = 55;
            this.cb_clearJ6.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7Bo2Y, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7Bo2Y, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7Bo2X, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7Bo2X, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.label69, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7Bo1Y, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7Bo1Y, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7Bo1X, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7Bo1X, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label72, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La21Y, 3, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La21Y, 4, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La21X, 4, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La21X, 3, 5);
            this.tableLayoutPanel7.Controls.Add(this.label77, 3, 4);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La11Y, 3, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La11X, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.label81, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La11Y, 4, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La11X, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La22Y, 5, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La22Y, 6, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La23Y, 7, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La23Y, 8, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La24Y, 9, 6);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La24Y, 10, 6);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La22X, 5, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La22X, 6, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La23X, 7, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La23X, 8, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La24X, 9, 5);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La24X, 10, 5);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La12Y, 5, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La12X, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La12Y, 6, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La12X, 6, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La13Y, 7, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La13X, 7, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La13Y, 8, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La13X, 8, 2);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La14Y, 9, 3);
            this.tableLayoutPanel7.Controls.Add(this.lb_Cam1Jig7La14X, 9, 2);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La14Y, 10, 3);
            this.tableLayoutPanel7.Controls.Add(this.tb_Cam1Jig7La14X, 10, 2);
            this.tableLayoutPanel7.Controls.Add(this.label95, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btn_clearJ7, 12, 4);
            this.tableLayoutPanel7.Controls.Add(this.cb_clearJ7, 13, 4);
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
            this.tableLayoutPanel7.TagString = null;
            // 
            // lb_Cam1Jig7Bo2Y
            // 
            this.lb_Cam1Jig7Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig7Bo2Y.Name = "lb_Cam1Jig7Bo2Y";
            this.lb_Cam1Jig7Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig7Bo2Y.Text = "Y：";
            this.lb_Cam1Jig7Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7Bo2Y
            // 
            this.tb_Cam1Jig7Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig7Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7Bo2Y.Name = "tb_Cam1Jig7Bo2Y";
            this.tb_Cam1Jig7Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig7Bo2X
            // 
            this.tb_Cam1Jig7Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig7Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7Bo2X.Name = "tb_Cam1Jig7Bo2X";
            this.tb_Cam1Jig7Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig7Bo2X
            // 
            this.lb_Cam1Jig7Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig7Bo2X.Name = "lb_Cam1Jig7Bo2X";
            this.lb_Cam1Jig7Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7Bo2X.TabIndex = 14;
            this.lb_Cam1Jig7Bo2X.Text = "X：";
            this.lb_Cam1Jig7Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig7Bo1Y
            // 
            this.lb_Cam1Jig7Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig7Bo1Y.Name = "lb_Cam1Jig7Bo1Y";
            this.lb_Cam1Jig7Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig7Bo1Y.Text = "Y：";
            this.lb_Cam1Jig7Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7Bo1Y
            // 
            this.tb_Cam1Jig7Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig7Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7Bo1Y.Name = "tb_Cam1Jig7Bo1Y";
            this.tb_Cam1Jig7Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig7Bo1X
            // 
            this.tb_Cam1Jig7Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig7Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7Bo1X.Name = "tb_Cam1Jig7Bo1X";
            this.tb_Cam1Jig7Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig7Bo1X
            // 
            this.lb_Cam1Jig7Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig7Bo1X.Name = "lb_Cam1Jig7Bo1X";
            this.lb_Cam1Jig7Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7Bo1X.TabIndex = 3;
            this.lb_Cam1Jig7Bo1X.Text = "X：";
            this.lb_Cam1Jig7Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig7La21Y
            // 
            this.lb_Cam1Jig7La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig7La21Y.Name = "lb_Cam1Jig7La21Y";
            this.lb_Cam1Jig7La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La21Y.TabIndex = 36;
            this.lb_Cam1Jig7La21Y.Text = "点1Y：";
            this.lb_Cam1Jig7La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La21Y
            // 
            this.tb_Cam1Jig7La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig7La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La21Y.Name = "tb_Cam1Jig7La21Y";
            this.tb_Cam1Jig7La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La21Y.TabIndex = 30;
            this.tb_Cam1Jig7La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig7La21X
            // 
            this.tb_Cam1Jig7La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig7La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La21X.Name = "tb_Cam1Jig7La21X";
            this.tb_Cam1Jig7La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La21X.TabIndex = 43;
            this.tb_Cam1Jig7La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig7La21X
            // 
            this.lb_Cam1Jig7La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig7La21X.Name = "lb_Cam1Jig7La21X";
            this.lb_Cam1Jig7La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La21X.TabIndex = 29;
            this.lb_Cam1Jig7La21X.Text = "点1X：";
            this.lb_Cam1Jig7La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig7La11Y
            // 
            this.lb_Cam1Jig7La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig7La11Y.Name = "lb_Cam1Jig7La11Y";
            this.lb_Cam1Jig7La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La11Y.TabIndex = 19;
            this.lb_Cam1Jig7La11Y.Text = "点1Y：";
            this.lb_Cam1Jig7La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig7La11X
            // 
            this.lb_Cam1Jig7La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig7La11X.Name = "lb_Cam1Jig7La11X";
            this.lb_Cam1Jig7La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La11X.TabIndex = 6;
            this.lb_Cam1Jig7La11X.Text = "点1X：";
            this.lb_Cam1Jig7La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig7La11Y
            // 
            this.tb_Cam1Jig7La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig7La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La11Y.Name = "tb_Cam1Jig7La11Y";
            this.tb_Cam1Jig7La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La11Y.TabIndex = 9;
            this.tb_Cam1Jig7La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig7La11X
            // 
            this.tb_Cam1Jig7La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig7La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La11X.Name = "tb_Cam1Jig7La11X";
            this.tb_Cam1Jig7La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La11X.TabIndex = 10;
            this.tb_Cam1Jig7La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig7La22Y
            // 
            this.lb_Cam1Jig7La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig7La22Y.Name = "lb_Cam1Jig7La22Y";
            this.lb_Cam1Jig7La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La22Y.TabIndex = 35;
            this.lb_Cam1Jig7La22Y.Text = "点2Y：";
            this.lb_Cam1Jig7La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La22Y
            // 
            this.tb_Cam1Jig7La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig7La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La22Y.Name = "tb_Cam1Jig7La22Y";
            this.tb_Cam1Jig7La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig7La23Y
            // 
            this.lb_Cam1Jig7La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig7La23Y.Name = "lb_Cam1Jig7La23Y";
            this.lb_Cam1Jig7La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La23Y.TabIndex = 31;
            this.lb_Cam1Jig7La23Y.Text = "点3Y：";
            this.lb_Cam1Jig7La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La23Y
            // 
            this.tb_Cam1Jig7La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig7La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La23Y.Name = "tb_Cam1Jig7La23Y";
            this.tb_Cam1Jig7La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La23Y.TabIndex = 44;
            this.tb_Cam1Jig7La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig7La24Y
            // 
            this.lb_Cam1Jig7La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig7La24Y.Name = "lb_Cam1Jig7La24Y";
            this.lb_Cam1Jig7La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La24Y.TabIndex = 38;
            this.lb_Cam1Jig7La24Y.Text = "点4Y：";
            this.lb_Cam1Jig7La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La24Y
            // 
            this.tb_Cam1Jig7La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig7La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La24Y.Name = "tb_Cam1Jig7La24Y";
            this.tb_Cam1Jig7La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig7La22X
            // 
            this.lb_Cam1Jig7La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig7La22X.Name = "lb_Cam1Jig7La22X";
            this.lb_Cam1Jig7La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La22X.TabIndex = 37;
            this.lb_Cam1Jig7La22X.Text = "点2X：";
            this.lb_Cam1Jig7La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La22X
            // 
            this.tb_Cam1Jig7La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig7La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La22X.Name = "tb_Cam1Jig7La22X";
            this.tb_Cam1Jig7La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig7La23X
            // 
            this.lb_Cam1Jig7La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig7La23X.Name = "lb_Cam1Jig7La23X";
            this.lb_Cam1Jig7La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La23X.TabIndex = 34;
            this.lb_Cam1Jig7La23X.Text = "点3X：";
            this.lb_Cam1Jig7La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La23X
            // 
            this.tb_Cam1Jig7La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig7La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La23X.Name = "tb_Cam1Jig7La23X";
            this.tb_Cam1Jig7La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La23X.TabIndex = 32;
            this.tb_Cam1Jig7La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig7La24X
            // 
            this.lb_Cam1Jig7La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig7La24X.Name = "lb_Cam1Jig7La24X";
            this.lb_Cam1Jig7La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La24X.TabIndex = 33;
            this.lb_Cam1Jig7La24X.Text = "点4X：";
            this.lb_Cam1Jig7La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La24X
            // 
            this.tb_Cam1Jig7La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig7La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La24X.Name = "tb_Cam1Jig7La24X";
            this.tb_Cam1Jig7La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig7La12Y
            // 
            this.lb_Cam1Jig7La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig7La12Y.Name = "lb_Cam1Jig7La12Y";
            this.lb_Cam1Jig7La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La12Y.TabIndex = 18;
            this.lb_Cam1Jig7La12Y.Text = "点2Y：";
            this.lb_Cam1Jig7La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig7La12X
            // 
            this.lb_Cam1Jig7La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig7La12X.Name = "lb_Cam1Jig7La12X";
            this.lb_Cam1Jig7La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La12X.TabIndex = 20;
            this.lb_Cam1Jig7La12X.Text = "点2X：";
            this.lb_Cam1Jig7La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La12Y
            // 
            this.tb_Cam1Jig7La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig7La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La12Y.Name = "tb_Cam1Jig7La12Y";
            this.tb_Cam1Jig7La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig7La12X
            // 
            this.tb_Cam1Jig7La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig7La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La12X.Name = "tb_Cam1Jig7La12X";
            this.tb_Cam1Jig7La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig7La13Y
            // 
            this.lb_Cam1Jig7La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig7La13Y.Name = "lb_Cam1Jig7La13Y";
            this.lb_Cam1Jig7La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La13Y.TabIndex = 5;
            this.lb_Cam1Jig7La13Y.Text = "点3Y：";
            this.lb_Cam1Jig7La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig7La13X
            // 
            this.lb_Cam1Jig7La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig7La13X.Name = "lb_Cam1Jig7La13X";
            this.lb_Cam1Jig7La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La13X.TabIndex = 17;
            this.lb_Cam1Jig7La13X.Text = "点3X：";
            this.lb_Cam1Jig7La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La13Y
            // 
            this.tb_Cam1Jig7La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig7La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La13Y.Name = "tb_Cam1Jig7La13Y";
            this.tb_Cam1Jig7La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La13Y.TabIndex = 22;
            this.tb_Cam1Jig7La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig7La13X
            // 
            this.tb_Cam1Jig7La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig7La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La13X.Name = "tb_Cam1Jig7La13X";
            this.tb_Cam1Jig7La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La13X.TabIndex = 26;
            this.tb_Cam1Jig7La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig7La14Y
            // 
            this.lb_Cam1Jig7La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig7La14Y.Name = "lb_Cam1Jig7La14Y";
            this.lb_Cam1Jig7La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La14Y.TabIndex = 21;
            this.lb_Cam1Jig7La14Y.Text = "点4Y：";
            this.lb_Cam1Jig7La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig7La14X
            // 
            this.lb_Cam1Jig7La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig7La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig7La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig7La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig7La14X.Name = "lb_Cam1Jig7La14X";
            this.lb_Cam1Jig7La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig7La14X.TabIndex = 16;
            this.lb_Cam1Jig7La14X.Text = "点4X：";
            this.lb_Cam1Jig7La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig7La14Y
            // 
            this.tb_Cam1Jig7La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig7La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La14Y.Name = "tb_Cam1Jig7La14Y";
            this.tb_Cam1Jig7La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig7La14X
            // 
            this.tb_Cam1Jig7La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig7La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig7La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig7La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig7La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig7La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig7La14X.Name = "tb_Cam1Jig7La14X";
            this.tb_Cam1Jig7La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig7La14X.TabIndex = 25;
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
            // btn_clearJ7
            // 
            this.btn_clearJ7.Enabled = false;
            this.btn_clearJ7.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ7.Name = "btn_clearJ7";
            this.btn_clearJ7.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ7.TabIndex = 54;
            this.btn_clearJ7.Text = "清除补偿";
            this.btn_clearJ7.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ7
            // 
            this.cb_clearJ7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ7.AutoSize = true;
            this.cb_clearJ7.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ7.Name = "cb_clearJ7";
            this.cb_clearJ7.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ7.TabIndex = 55;
            this.cb_clearJ7.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8Bo2Y, 0, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8Bo2Y, 1, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8Bo2X, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8Bo2X, 0, 5);
            this.tableLayoutPanel8.Controls.Add(this.label98, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8Bo1Y, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8Bo1Y, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8Bo1X, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8Bo1X, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label101, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La21Y, 3, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La21Y, 4, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La21X, 4, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La21X, 3, 5);
            this.tableLayoutPanel8.Controls.Add(this.label104, 3, 4);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La11Y, 3, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La11X, 3, 2);
            this.tableLayoutPanel8.Controls.Add(this.label107, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La11Y, 4, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La11X, 4, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La22Y, 5, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La22Y, 6, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La23Y, 7, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La23Y, 8, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La24Y, 9, 6);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La24Y, 10, 6);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La22X, 5, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La22X, 6, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La23X, 7, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La23X, 8, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La24X, 9, 5);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La24X, 10, 5);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La12Y, 5, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La12X, 5, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La12Y, 6, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La12X, 6, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La13Y, 7, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La13X, 7, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La13Y, 8, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La13X, 8, 2);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La14Y, 9, 3);
            this.tableLayoutPanel8.Controls.Add(this.lb_Cam1Jig8La14X, 9, 2);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La14Y, 10, 3);
            this.tableLayoutPanel8.Controls.Add(this.tb_Cam1Jig8La14X, 10, 2);
            this.tableLayoutPanel8.Controls.Add(this.label120, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btn_clearJ8, 12, 4);
            this.tableLayoutPanel8.Controls.Add(this.cb_clearJ8, 13, 4);
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
            this.tableLayoutPanel8.TagString = null;
            // 
            // lb_Cam1Jig8Bo2Y
            // 
            this.lb_Cam1Jig8Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig8Bo2Y.Name = "lb_Cam1Jig8Bo2Y";
            this.lb_Cam1Jig8Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig8Bo2Y.Text = "Y：";
            this.lb_Cam1Jig8Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8Bo2Y
            // 
            this.tb_Cam1Jig8Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig8Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8Bo2Y.Name = "tb_Cam1Jig8Bo2Y";
            this.tb_Cam1Jig8Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig8Bo2X
            // 
            this.tb_Cam1Jig8Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig8Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8Bo2X.Name = "tb_Cam1Jig8Bo2X";
            this.tb_Cam1Jig8Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig8Bo2X
            // 
            this.lb_Cam1Jig8Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig8Bo2X.Name = "lb_Cam1Jig8Bo2X";
            this.lb_Cam1Jig8Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8Bo2X.TabIndex = 14;
            this.lb_Cam1Jig8Bo2X.Text = "X：";
            this.lb_Cam1Jig8Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig8Bo1Y
            // 
            this.lb_Cam1Jig8Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig8Bo1Y.Name = "lb_Cam1Jig8Bo1Y";
            this.lb_Cam1Jig8Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig8Bo1Y.Text = "Y：";
            this.lb_Cam1Jig8Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8Bo1Y
            // 
            this.tb_Cam1Jig8Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig8Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8Bo1Y.Name = "tb_Cam1Jig8Bo1Y";
            this.tb_Cam1Jig8Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig8Bo1X
            // 
            this.tb_Cam1Jig8Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig8Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8Bo1X.Name = "tb_Cam1Jig8Bo1X";
            this.tb_Cam1Jig8Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig8Bo1X
            // 
            this.lb_Cam1Jig8Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig8Bo1X.Name = "lb_Cam1Jig8Bo1X";
            this.lb_Cam1Jig8Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8Bo1X.TabIndex = 3;
            this.lb_Cam1Jig8Bo1X.Text = "X：";
            this.lb_Cam1Jig8Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig8La21Y
            // 
            this.lb_Cam1Jig8La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig8La21Y.Name = "lb_Cam1Jig8La21Y";
            this.lb_Cam1Jig8La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La21Y.TabIndex = 36;
            this.lb_Cam1Jig8La21Y.Text = "点1Y：";
            this.lb_Cam1Jig8La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La21Y
            // 
            this.tb_Cam1Jig8La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig8La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La21Y.Name = "tb_Cam1Jig8La21Y";
            this.tb_Cam1Jig8La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La21Y.TabIndex = 30;
            this.tb_Cam1Jig8La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig8La21X
            // 
            this.tb_Cam1Jig8La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig8La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La21X.Name = "tb_Cam1Jig8La21X";
            this.tb_Cam1Jig8La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La21X.TabIndex = 43;
            this.tb_Cam1Jig8La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig8La21X
            // 
            this.lb_Cam1Jig8La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig8La21X.Name = "lb_Cam1Jig8La21X";
            this.lb_Cam1Jig8La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La21X.TabIndex = 29;
            this.lb_Cam1Jig8La21X.Text = "点1X：";
            this.lb_Cam1Jig8La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig8La11Y
            // 
            this.lb_Cam1Jig8La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig8La11Y.Name = "lb_Cam1Jig8La11Y";
            this.lb_Cam1Jig8La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La11Y.TabIndex = 19;
            this.lb_Cam1Jig8La11Y.Text = "点1Y：";
            this.lb_Cam1Jig8La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig8La11X
            // 
            this.lb_Cam1Jig8La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig8La11X.Name = "lb_Cam1Jig8La11X";
            this.lb_Cam1Jig8La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La11X.TabIndex = 6;
            this.lb_Cam1Jig8La11X.Text = "点1X：";
            this.lb_Cam1Jig8La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig8La11Y
            // 
            this.tb_Cam1Jig8La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig8La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La11Y.Name = "tb_Cam1Jig8La11Y";
            this.tb_Cam1Jig8La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La11Y.TabIndex = 9;
            this.tb_Cam1Jig8La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig8La11X
            // 
            this.tb_Cam1Jig8La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig8La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La11X.Name = "tb_Cam1Jig8La11X";
            this.tb_Cam1Jig8La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La11X.TabIndex = 10;
            this.tb_Cam1Jig8La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig8La22Y
            // 
            this.lb_Cam1Jig8La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig8La22Y.Name = "lb_Cam1Jig8La22Y";
            this.lb_Cam1Jig8La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La22Y.TabIndex = 35;
            this.lb_Cam1Jig8La22Y.Text = "点2Y：";
            this.lb_Cam1Jig8La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La22Y
            // 
            this.tb_Cam1Jig8La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig8La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La22Y.Name = "tb_Cam1Jig8La22Y";
            this.tb_Cam1Jig8La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig8La23Y
            // 
            this.lb_Cam1Jig8La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig8La23Y.Name = "lb_Cam1Jig8La23Y";
            this.lb_Cam1Jig8La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La23Y.TabIndex = 31;
            this.lb_Cam1Jig8La23Y.Text = "点3Y：";
            this.lb_Cam1Jig8La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La23Y
            // 
            this.tb_Cam1Jig8La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig8La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La23Y.Name = "tb_Cam1Jig8La23Y";
            this.tb_Cam1Jig8La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La23Y.TabIndex = 44;
            this.tb_Cam1Jig8La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig8La24Y
            // 
            this.lb_Cam1Jig8La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig8La24Y.Name = "lb_Cam1Jig8La24Y";
            this.lb_Cam1Jig8La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La24Y.TabIndex = 38;
            this.lb_Cam1Jig8La24Y.Text = "点4Y：";
            this.lb_Cam1Jig8La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La24Y
            // 
            this.tb_Cam1Jig8La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig8La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La24Y.Name = "tb_Cam1Jig8La24Y";
            this.tb_Cam1Jig8La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig8La22X
            // 
            this.lb_Cam1Jig8La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig8La22X.Name = "lb_Cam1Jig8La22X";
            this.lb_Cam1Jig8La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La22X.TabIndex = 37;
            this.lb_Cam1Jig8La22X.Text = "点2X：";
            this.lb_Cam1Jig8La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La22X
            // 
            this.tb_Cam1Jig8La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig8La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La22X.Name = "tb_Cam1Jig8La22X";
            this.tb_Cam1Jig8La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig8La23X
            // 
            this.lb_Cam1Jig8La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig8La23X.Name = "lb_Cam1Jig8La23X";
            this.lb_Cam1Jig8La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La23X.TabIndex = 34;
            this.lb_Cam1Jig8La23X.Text = "点3X：";
            this.lb_Cam1Jig8La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La23X
            // 
            this.tb_Cam1Jig8La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig8La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La23X.Name = "tb_Cam1Jig8La23X";
            this.tb_Cam1Jig8La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La23X.TabIndex = 32;
            this.tb_Cam1Jig8La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig8La24X
            // 
            this.lb_Cam1Jig8La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig8La24X.Name = "lb_Cam1Jig8La24X";
            this.lb_Cam1Jig8La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La24X.TabIndex = 33;
            this.lb_Cam1Jig8La24X.Text = "点4X：";
            this.lb_Cam1Jig8La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La24X
            // 
            this.tb_Cam1Jig8La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig8La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La24X.Name = "tb_Cam1Jig8La24X";
            this.tb_Cam1Jig8La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig8La12Y
            // 
            this.lb_Cam1Jig8La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig8La12Y.Name = "lb_Cam1Jig8La12Y";
            this.lb_Cam1Jig8La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La12Y.TabIndex = 18;
            this.lb_Cam1Jig8La12Y.Text = "点2Y：";
            this.lb_Cam1Jig8La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig8La12X
            // 
            this.lb_Cam1Jig8La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig8La12X.Name = "lb_Cam1Jig8La12X";
            this.lb_Cam1Jig8La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La12X.TabIndex = 20;
            this.lb_Cam1Jig8La12X.Text = "点2X：";
            this.lb_Cam1Jig8La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La12Y
            // 
            this.tb_Cam1Jig8La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig8La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La12Y.Name = "tb_Cam1Jig8La12Y";
            this.tb_Cam1Jig8La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig8La12X
            // 
            this.tb_Cam1Jig8La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig8La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La12X.Name = "tb_Cam1Jig8La12X";
            this.tb_Cam1Jig8La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig8La13Y
            // 
            this.lb_Cam1Jig8La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig8La13Y.Name = "lb_Cam1Jig8La13Y";
            this.lb_Cam1Jig8La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La13Y.TabIndex = 5;
            this.lb_Cam1Jig8La13Y.Text = "点3Y：";
            this.lb_Cam1Jig8La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig8La13X
            // 
            this.lb_Cam1Jig8La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig8La13X.Name = "lb_Cam1Jig8La13X";
            this.lb_Cam1Jig8La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La13X.TabIndex = 17;
            this.lb_Cam1Jig8La13X.Text = "点3X：";
            this.lb_Cam1Jig8La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La13Y
            // 
            this.tb_Cam1Jig8La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig8La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La13Y.Name = "tb_Cam1Jig8La13Y";
            this.tb_Cam1Jig8La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La13Y.TabIndex = 22;
            this.tb_Cam1Jig8La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig8La13X
            // 
            this.tb_Cam1Jig8La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig8La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La13X.Name = "tb_Cam1Jig8La13X";
            this.tb_Cam1Jig8La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La13X.TabIndex = 26;
            this.tb_Cam1Jig8La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig8La14Y
            // 
            this.lb_Cam1Jig8La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig8La14Y.Name = "lb_Cam1Jig8La14Y";
            this.lb_Cam1Jig8La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La14Y.TabIndex = 21;
            this.lb_Cam1Jig8La14Y.Text = "点4Y：";
            this.lb_Cam1Jig8La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig8La14X
            // 
            this.lb_Cam1Jig8La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig8La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig8La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig8La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig8La14X.Name = "lb_Cam1Jig8La14X";
            this.lb_Cam1Jig8La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig8La14X.TabIndex = 16;
            this.lb_Cam1Jig8La14X.Text = "点4X：";
            this.lb_Cam1Jig8La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig8La14Y
            // 
            this.tb_Cam1Jig8La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig8La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La14Y.Name = "tb_Cam1Jig8La14Y";
            this.tb_Cam1Jig8La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig8La14X
            // 
            this.tb_Cam1Jig8La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig8La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig8La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig8La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig8La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig8La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig8La14X.Name = "tb_Cam1Jig8La14X";
            this.tb_Cam1Jig8La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig8La14X.TabIndex = 25;
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
            // btn_clearJ8
            // 
            this.btn_clearJ8.Enabled = false;
            this.btn_clearJ8.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ8.Name = "btn_clearJ8";
            this.btn_clearJ8.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ8.TabIndex = 54;
            this.btn_clearJ8.Text = "清除补偿";
            this.btn_clearJ8.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ8
            // 
            this.cb_clearJ8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ8.AutoSize = true;
            this.cb_clearJ8.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ8.Name = "cb_clearJ8";
            this.cb_clearJ8.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ8.TabIndex = 55;
            this.cb_clearJ8.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9Bo2Y, 0, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9Bo2Y, 1, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9Bo2X, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9Bo2X, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.label123, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9Bo1Y, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9Bo1Y, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9Bo1X, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9Bo1X, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label126, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La21Y, 3, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La21Y, 4, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La21X, 4, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La21X, 3, 5);
            this.tableLayoutPanel9.Controls.Add(this.label129, 3, 4);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La11Y, 3, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La11X, 3, 2);
            this.tableLayoutPanel9.Controls.Add(this.label132, 3, 1);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La11Y, 4, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La11X, 4, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La22Y, 5, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La22Y, 6, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La23Y, 7, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La23Y, 8, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La24Y, 9, 6);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La24Y, 10, 6);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La22X, 5, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La22X, 6, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La23X, 7, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La23X, 8, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La24X, 9, 5);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La24X, 10, 5);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La12Y, 5, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La12X, 5, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La12Y, 6, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La12X, 6, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La13Y, 7, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La13X, 7, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La13Y, 8, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La13X, 8, 2);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La14Y, 9, 3);
            this.tableLayoutPanel9.Controls.Add(this.lb_Cam1Jig9La14X, 9, 2);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La14Y, 10, 3);
            this.tableLayoutPanel9.Controls.Add(this.tb_Cam1Jig9La14X, 10, 2);
            this.tableLayoutPanel9.Controls.Add(this.label145, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_clearJ9, 12, 4);
            this.tableLayoutPanel9.Controls.Add(this.cb_clearJ9, 13, 4);
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
            this.tableLayoutPanel9.TagString = null;
            // 
            // lb_Cam1Jig9Bo2Y
            // 
            this.lb_Cam1Jig9Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9Bo2Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9Bo2Y.Location = new System.Drawing.Point(3, 270);
            this.lb_Cam1Jig9Bo2Y.Name = "lb_Cam1Jig9Bo2Y";
            this.lb_Cam1Jig9Bo2Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9Bo2Y.TabIndex = 15;
            this.lb_Cam1Jig9Bo2Y.Text = "Y：";
            this.lb_Cam1Jig9Bo2Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9Bo2Y
            // 
            this.tb_Cam1Jig9Bo2Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9Bo2Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9Bo2Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9Bo2Y.Location = new System.Drawing.Point(85, 282);
            this.tb_Cam1Jig9Bo2Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9Bo2Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9Bo2Y.Name = "tb_Cam1Jig9Bo2Y";
            this.tb_Cam1Jig9Bo2Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9Bo2Y.TabIndex = 8;
            // 
            // tb_Cam1Jig9Bo2X
            // 
            this.tb_Cam1Jig9Bo2X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9Bo2X.Location = new System.Drawing.Point(85, 237);
            this.tb_Cam1Jig9Bo2X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9Bo2X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9Bo2X.Name = "tb_Cam1Jig9Bo2X";
            this.tb_Cam1Jig9Bo2X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9Bo2X.TabIndex = 11;
            // 
            // lb_Cam1Jig9Bo2X
            // 
            this.lb_Cam1Jig9Bo2X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9Bo2X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9Bo2X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9Bo2X.Location = new System.Drawing.Point(3, 225);
            this.lb_Cam1Jig9Bo2X.Name = "lb_Cam1Jig9Bo2X";
            this.lb_Cam1Jig9Bo2X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9Bo2X.TabIndex = 14;
            this.lb_Cam1Jig9Bo2X.Text = "X：";
            this.lb_Cam1Jig9Bo2X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig9Bo1Y
            // 
            this.lb_Cam1Jig9Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9Bo1Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9Bo1Y.Location = new System.Drawing.Point(3, 135);
            this.lb_Cam1Jig9Bo1Y.Name = "lb_Cam1Jig9Bo1Y";
            this.lb_Cam1Jig9Bo1Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9Bo1Y.TabIndex = 7;
            this.lb_Cam1Jig9Bo1Y.Text = "Y：";
            this.lb_Cam1Jig9Bo1Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9Bo1Y
            // 
            this.tb_Cam1Jig9Bo1Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9Bo1Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9Bo1Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9Bo1Y.Location = new System.Drawing.Point(85, 147);
            this.tb_Cam1Jig9Bo1Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9Bo1Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9Bo1Y.Name = "tb_Cam1Jig9Bo1Y";
            this.tb_Cam1Jig9Bo1Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9Bo1Y.TabIndex = 12;
            // 
            // tb_Cam1Jig9Bo1X
            // 
            this.tb_Cam1Jig9Bo1X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9Bo1X.Location = new System.Drawing.Point(85, 102);
            this.tb_Cam1Jig9Bo1X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9Bo1X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9Bo1X.Name = "tb_Cam1Jig9Bo1X";
            this.tb_Cam1Jig9Bo1X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9Bo1X.TabIndex = 2;
            // 
            // lb_Cam1Jig9Bo1X
            // 
            this.lb_Cam1Jig9Bo1X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9Bo1X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9Bo1X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9Bo1X.Location = new System.Drawing.Point(3, 90);
            this.lb_Cam1Jig9Bo1X.Name = "lb_Cam1Jig9Bo1X";
            this.lb_Cam1Jig9Bo1X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9Bo1X.TabIndex = 3;
            this.lb_Cam1Jig9Bo1X.Text = "X：";
            this.lb_Cam1Jig9Bo1X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig9La21Y
            // 
            this.lb_Cam1Jig9La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La21Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La21Y.Location = new System.Drawing.Point(246, 270);
            this.lb_Cam1Jig9La21Y.Name = "lb_Cam1Jig9La21Y";
            this.lb_Cam1Jig9La21Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La21Y.TabIndex = 36;
            this.lb_Cam1Jig9La21Y.Text = "点1Y：";
            this.lb_Cam1Jig9La21Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La21Y
            // 
            this.tb_Cam1Jig9La21Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La21Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La21Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La21Y.Location = new System.Drawing.Point(328, 282);
            this.tb_Cam1Jig9La21Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La21Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La21Y.Name = "tb_Cam1Jig9La21Y";
            this.tb_Cam1Jig9La21Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La21Y.TabIndex = 30;
            this.tb_Cam1Jig9La21Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig9La21X
            // 
            this.tb_Cam1Jig9La21X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La21X.Location = new System.Drawing.Point(328, 237);
            this.tb_Cam1Jig9La21X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La21X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La21X.Name = "tb_Cam1Jig9La21X";
            this.tb_Cam1Jig9La21X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La21X.TabIndex = 43;
            this.tb_Cam1Jig9La21X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig9La21X
            // 
            this.lb_Cam1Jig9La21X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La21X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La21X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La21X.Location = new System.Drawing.Point(246, 225);
            this.lb_Cam1Jig9La21X.Name = "lb_Cam1Jig9La21X";
            this.lb_Cam1Jig9La21X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La21X.TabIndex = 29;
            this.lb_Cam1Jig9La21X.Text = "点1X：";
            this.lb_Cam1Jig9La21X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lb_Cam1Jig9La11Y
            // 
            this.lb_Cam1Jig9La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La11Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La11Y.Location = new System.Drawing.Point(246, 135);
            this.lb_Cam1Jig9La11Y.Name = "lb_Cam1Jig9La11Y";
            this.lb_Cam1Jig9La11Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La11Y.TabIndex = 19;
            this.lb_Cam1Jig9La11Y.Text = "点1Y：";
            this.lb_Cam1Jig9La11Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig9La11X
            // 
            this.lb_Cam1Jig9La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La11X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La11X.Location = new System.Drawing.Point(246, 90);
            this.lb_Cam1Jig9La11X.Name = "lb_Cam1Jig9La11X";
            this.lb_Cam1Jig9La11X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La11X.TabIndex = 6;
            this.lb_Cam1Jig9La11X.Text = "点1X：";
            this.lb_Cam1Jig9La11X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // tb_Cam1Jig9La11Y
            // 
            this.tb_Cam1Jig9La11Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La11Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La11Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La11Y.Location = new System.Drawing.Point(328, 147);
            this.tb_Cam1Jig9La11Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La11Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La11Y.Name = "tb_Cam1Jig9La11Y";
            this.tb_Cam1Jig9La11Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La11Y.TabIndex = 9;
            this.tb_Cam1Jig9La11Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig9La11X
            // 
            this.tb_Cam1Jig9La11X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La11X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La11X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La11X.Location = new System.Drawing.Point(328, 102);
            this.tb_Cam1Jig9La11X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La11X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La11X.Name = "tb_Cam1Jig9La11X";
            this.tb_Cam1Jig9La11X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La11X.TabIndex = 10;
            this.tb_Cam1Jig9La11X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig9La22Y
            // 
            this.lb_Cam1Jig9La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La22Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La22Y.Location = new System.Drawing.Point(408, 270);
            this.lb_Cam1Jig9La22Y.Name = "lb_Cam1Jig9La22Y";
            this.lb_Cam1Jig9La22Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La22Y.TabIndex = 35;
            this.lb_Cam1Jig9La22Y.Text = "点2Y：";
            this.lb_Cam1Jig9La22Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La22Y
            // 
            this.tb_Cam1Jig9La22Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La22Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La22Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La22Y.Location = new System.Drawing.Point(490, 282);
            this.tb_Cam1Jig9La22Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La22Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La22Y.Name = "tb_Cam1Jig9La22Y";
            this.tb_Cam1Jig9La22Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La22Y.TabIndex = 41;
            // 
            // lb_Cam1Jig9La23Y
            // 
            this.lb_Cam1Jig9La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La23Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La23Y.Location = new System.Drawing.Point(570, 270);
            this.lb_Cam1Jig9La23Y.Name = "lb_Cam1Jig9La23Y";
            this.lb_Cam1Jig9La23Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La23Y.TabIndex = 31;
            this.lb_Cam1Jig9La23Y.Text = "点3Y：";
            this.lb_Cam1Jig9La23Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La23Y
            // 
            this.tb_Cam1Jig9La23Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La23Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La23Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La23Y.Location = new System.Drawing.Point(652, 282);
            this.tb_Cam1Jig9La23Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La23Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La23Y.Name = "tb_Cam1Jig9La23Y";
            this.tb_Cam1Jig9La23Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La23Y.TabIndex = 44;
            this.tb_Cam1Jig9La23Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig9La24Y
            // 
            this.lb_Cam1Jig9La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La24Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La24Y.Location = new System.Drawing.Point(732, 270);
            this.lb_Cam1Jig9La24Y.Name = "lb_Cam1Jig9La24Y";
            this.lb_Cam1Jig9La24Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La24Y.TabIndex = 38;
            this.lb_Cam1Jig9La24Y.Text = "点4Y：";
            this.lb_Cam1Jig9La24Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La24Y
            // 
            this.tb_Cam1Jig9La24Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La24Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La24Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La24Y.Location = new System.Drawing.Point(814, 282);
            this.tb_Cam1Jig9La24Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La24Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La24Y.Name = "tb_Cam1Jig9La24Y";
            this.tb_Cam1Jig9La24Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La24Y.TabIndex = 39;
            // 
            // lb_Cam1Jig9La22X
            // 
            this.lb_Cam1Jig9La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La22X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La22X.Location = new System.Drawing.Point(408, 225);
            this.lb_Cam1Jig9La22X.Name = "lb_Cam1Jig9La22X";
            this.lb_Cam1Jig9La22X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La22X.TabIndex = 37;
            this.lb_Cam1Jig9La22X.Text = "点2X：";
            this.lb_Cam1Jig9La22X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La22X
            // 
            this.tb_Cam1Jig9La22X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La22X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La22X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La22X.Location = new System.Drawing.Point(490, 237);
            this.tb_Cam1Jig9La22X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La22X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La22X.Name = "tb_Cam1Jig9La22X";
            this.tb_Cam1Jig9La22X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La22X.TabIndex = 42;
            // 
            // lb_Cam1Jig9La23X
            // 
            this.lb_Cam1Jig9La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La23X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La23X.Location = new System.Drawing.Point(570, 225);
            this.lb_Cam1Jig9La23X.Name = "lb_Cam1Jig9La23X";
            this.lb_Cam1Jig9La23X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La23X.TabIndex = 34;
            this.lb_Cam1Jig9La23X.Text = "点3X：";
            this.lb_Cam1Jig9La23X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La23X
            // 
            this.tb_Cam1Jig9La23X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La23X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La23X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La23X.Location = new System.Drawing.Point(652, 237);
            this.tb_Cam1Jig9La23X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La23X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La23X.Name = "tb_Cam1Jig9La23X";
            this.tb_Cam1Jig9La23X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La23X.TabIndex = 32;
            this.tb_Cam1Jig9La23X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig9La24X
            // 
            this.lb_Cam1Jig9La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La24X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La24X.Location = new System.Drawing.Point(732, 225);
            this.lb_Cam1Jig9La24X.Name = "lb_Cam1Jig9La24X";
            this.lb_Cam1Jig9La24X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La24X.TabIndex = 33;
            this.lb_Cam1Jig9La24X.Text = "点4X：";
            this.lb_Cam1Jig9La24X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La24X
            // 
            this.tb_Cam1Jig9La24X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La24X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La24X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La24X.Location = new System.Drawing.Point(814, 237);
            this.tb_Cam1Jig9La24X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La24X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La24X.Name = "tb_Cam1Jig9La24X";
            this.tb_Cam1Jig9La24X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La24X.TabIndex = 40;
            // 
            // lb_Cam1Jig9La12Y
            // 
            this.lb_Cam1Jig9La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La12Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La12Y.Location = new System.Drawing.Point(408, 135);
            this.lb_Cam1Jig9La12Y.Name = "lb_Cam1Jig9La12Y";
            this.lb_Cam1Jig9La12Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La12Y.TabIndex = 18;
            this.lb_Cam1Jig9La12Y.Text = "点2Y：";
            this.lb_Cam1Jig9La12Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig9La12X
            // 
            this.lb_Cam1Jig9La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La12X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La12X.Location = new System.Drawing.Point(408, 90);
            this.lb_Cam1Jig9La12X.Name = "lb_Cam1Jig9La12X";
            this.lb_Cam1Jig9La12X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La12X.TabIndex = 20;
            this.lb_Cam1Jig9La12X.Text = "点2X：";
            this.lb_Cam1Jig9La12X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La12Y
            // 
            this.tb_Cam1Jig9La12Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La12Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La12Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La12Y.Location = new System.Drawing.Point(490, 147);
            this.tb_Cam1Jig9La12Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La12Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La12Y.Name = "tb_Cam1Jig9La12Y";
            this.tb_Cam1Jig9La12Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La12Y.TabIndex = 27;
            // 
            // tb_Cam1Jig9La12X
            // 
            this.tb_Cam1Jig9La12X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La12X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La12X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La12X.Location = new System.Drawing.Point(490, 102);
            this.tb_Cam1Jig9La12X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La12X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La12X.Name = "tb_Cam1Jig9La12X";
            this.tb_Cam1Jig9La12X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La12X.TabIndex = 24;
            // 
            // lb_Cam1Jig9La13Y
            // 
            this.lb_Cam1Jig9La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La13Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La13Y.Location = new System.Drawing.Point(570, 135);
            this.lb_Cam1Jig9La13Y.Name = "lb_Cam1Jig9La13Y";
            this.lb_Cam1Jig9La13Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La13Y.TabIndex = 5;
            this.lb_Cam1Jig9La13Y.Text = "点3Y：";
            this.lb_Cam1Jig9La13Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig9La13X
            // 
            this.lb_Cam1Jig9La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La13X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La13X.Location = new System.Drawing.Point(570, 90);
            this.lb_Cam1Jig9La13X.Name = "lb_Cam1Jig9La13X";
            this.lb_Cam1Jig9La13X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La13X.TabIndex = 17;
            this.lb_Cam1Jig9La13X.Text = "点3X：";
            this.lb_Cam1Jig9La13X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La13Y
            // 
            this.tb_Cam1Jig9La13Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La13Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La13Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La13Y.Location = new System.Drawing.Point(652, 147);
            this.tb_Cam1Jig9La13Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La13Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La13Y.Name = "tb_Cam1Jig9La13Y";
            this.tb_Cam1Jig9La13Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La13Y.TabIndex = 22;
            this.tb_Cam1Jig9La13Y.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // tb_Cam1Jig9La13X
            // 
            this.tb_Cam1Jig9La13X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La13X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La13X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La13X.Location = new System.Drawing.Point(652, 102);
            this.tb_Cam1Jig9La13X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La13X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La13X.Name = "tb_Cam1Jig9La13X";
            this.tb_Cam1Jig9La13X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La13X.TabIndex = 26;
            this.tb_Cam1Jig9La13X.TextChanged += new System.EventHandler(this.GenericTextBox_TextChanged);
            // 
            // lb_Cam1Jig9La14Y
            // 
            this.lb_Cam1Jig9La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La14Y.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La14Y.Location = new System.Drawing.Point(732, 135);
            this.lb_Cam1Jig9La14Y.Name = "lb_Cam1Jig9La14Y";
            this.lb_Cam1Jig9La14Y.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La14Y.TabIndex = 21;
            this.lb_Cam1Jig9La14Y.Text = "点4Y：";
            this.lb_Cam1Jig9La14Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Cam1Jig9La14X
            // 
            this.lb_Cam1Jig9La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Cam1Jig9La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Cam1Jig9La14X.ForeColor = System.Drawing.Color.Black;
            this.lb_Cam1Jig9La14X.Location = new System.Drawing.Point(732, 90);
            this.lb_Cam1Jig9La14X.Name = "lb_Cam1Jig9La14X";
            this.lb_Cam1Jig9La14X.Size = new System.Drawing.Size(75, 45);
            this.lb_Cam1Jig9La14X.TabIndex = 16;
            this.lb_Cam1Jig9La14X.Text = "点4X：";
            this.lb_Cam1Jig9La14X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Cam1Jig9La14Y
            // 
            this.tb_Cam1Jig9La14Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La14Y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La14Y.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La14Y.Location = new System.Drawing.Point(814, 147);
            this.tb_Cam1Jig9La14Y.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La14Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La14Y.Name = "tb_Cam1Jig9La14Y";
            this.tb_Cam1Jig9La14Y.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La14Y.TabIndex = 23;
            // 
            // tb_Cam1Jig9La14X
            // 
            this.tb_Cam1Jig9La14X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Cam1Jig9La14X.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Cam1Jig9La14X.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Cam1Jig9La14X.Location = new System.Drawing.Point(814, 102);
            this.tb_Cam1Jig9La14X.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.tb_Cam1Jig9La14X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Cam1Jig9La14X.Name = "tb_Cam1Jig9La14X";
            this.tb_Cam1Jig9La14X.Size = new System.Drawing.Size(73, 21);
            this.tb_Cam1Jig9La14X.TabIndex = 25;
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
            // btn_clearJ9
            // 
            this.btn_clearJ9.Enabled = false;
            this.btn_clearJ9.Location = new System.Drawing.Point(975, 183);
            this.btn_clearJ9.Name = "btn_clearJ9";
            this.btn_clearJ9.Size = new System.Drawing.Size(75, 39);
            this.btn_clearJ9.TabIndex = 54;
            this.btn_clearJ9.Text = "清除补偿";
            this.btn_clearJ9.UseVisualStyleBackColor = true;
            // 
            // cb_clearJ9
            // 
            this.cb_clearJ9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cb_clearJ9.AutoSize = true;
            this.cb_clearJ9.Location = new System.Drawing.Point(1056, 195);
            this.cb_clearJ9.Name = "cb_clearJ9";
            this.cb_clearJ9.Size = new System.Drawing.Size(15, 14);
            this.cb_clearJ9.TabIndex = 55;
            this.cb_clearJ9.UseVisualStyleBackColor = true;
            // 
            // uiSymbolButtonSave
            // 
            this.uiSymbolButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButtonSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButtonSave.Location = new System.Drawing.Point(1135, -1);
            this.uiSymbolButtonSave.Name = "uiSymbolButtonSave";
            this.uiSymbolButtonSave.Size = new System.Drawing.Size(168, 43);
            this.uiSymbolButtonSave.TabIndex = 10;
            this.uiSymbolButtonSave.Text = "应用参数";
            this.uiSymbolButtonSave.UseVisualStyleBackColor = false;
            this.uiSymbolButtonSave.Click += new System.EventHandler(this.UiSymbolButtonSave_Click);
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
        private UITableLayoutPanel uiTableLayoutPanel1;
        private TextBox tb_Cam1StdBo1R;
        private Label lb_Cam1StdBo1R;
        private TextBox tb_Cam1StdBo1Y;
        private Label lb_Cam1StdBo1Y;
        private Label lb_Cam1StdBo1X;
        private TextBox tb_Cam1StdBo1X;
        private Label lb_Cam1StdBo2X;
        private Label lb_Cam1StdBo2Y;
        private Label lb_Cam1StdBo2R;
        private TextBox tb_Cam1StdBo2X;
        private TextBox tb_Cam1StdBo2Y;
        private TextBox tb_Cam1StdBo2R;
        private Label lb_Cam1AddBo1X;
        private Label lb_Cam1AddBo1Y;
        private Label lb_Cam1AddBo1R;
        private Label lb_Cam1AddBo2X;
        private Label lb_Cam1AddBo2Y;
        private TextBox tb_Cam1AddBo1X;
        private TextBox tb_Cam1AddBo1Y;
        private TextBox tb_Cam1AddBo1R;
        private TextBox tb_Cam1AddBo2R;
        private TextBox tb_Cam1AddBo2Y;
        private TextBox tb_Cam1AddBo2X;
        private Label lb_Cam1StdLa1X;
        private Label lb_Cam1StdLa1Y;
        private Label lb_Cam1StdLa1R;
        private Label lb_Cam1AddLa1X;
        private Label lb_Cam1AddLa1Y;
        private Label lb_Cam1AddLa1R;
        private Label lb_Cam1StdLa2X;
        private Label lb_Cam1StdLa2Y;
        private Label lb_Cam1StdLa2R;
        private Label lb_Cam1AddLa2X;
        private Label lb_Cam1AddLa2Y;
        private Label lb_Cam1AddLa2R;
        private TextBox tb_Cam1StdLa1X;
        private TextBox tb_Cam1StdLa1Y;
        private TextBox tb_Cam1StdLa1R;
        private TextBox tb_Cam1AddLa1X;
        private TextBox tb_Cam1AddLa1Y;
        private TextBox tb_Cam1AddLa1R;
        private TextBox tb_Cam1StdLa2X;
        private TextBox tb_Cam1StdLa2Y;
        private TextBox tb_Cam1StdLa2R;
        private TextBox tb_Cam1AddLa2X;
        private TextBox tb_Cam1AddLa2Y;
        private TextBox tb_Cam1AddLa2R;
        private Button btn_GetStd1;
        private Button btn_GetStd2;
        private Button btn_GetStd3;
        private Label lb_Cam1Exprosure;
        private TextBox tb_Cam1Exprosure;
        private Label lb_Cam1AddBo2R;
        private Label lb_Cam1AngleMin;
        private Label lb_Cam1AngleMax;
        private TextBox tb_Cam1AngleMin;
        private TextBox tb_Cam1AngleMax;
        private Label lb_Cam1LimitMin;
        private Label lb_Cam1LimitMax;
        private TextBox tb_Cam1LimitMin;
        private TextBox tb_Cam1LimitMax;
        private Label lb_Cam1CenterLa1X;
        private Label lb_Cam1CenterLa1Y;
        private Label lb_Cam1CenterLa2X;
        private Label lb_Cam1CenterLa2Y;
        private TextBox tb_Cam1CenterLa1Y;
        private TextBox tb_Cam1CenterLa1X;
        private TextBox tb_Cam1CenterLa2X;
        private TextBox tb_Cam1CenterLa2Y;
        private TabPage tabPage1;
        private UITableLayoutPanel tableLayoutPanel1;
        private TextBox tb_Cam1Jig1Bo1X;
        private Label label3;
        private Label lb_Cam1Jig1Bo1X;
        private Label lb_Cam1Jig1Bo1Y;
        private TextBox tb_Cam1Jig1Bo1Y;
        private Label label7;
        private TextBox tb_Cam1Jig1Bo2X;
        private TextBox tb_Cam1Jig1Bo2Y;
        private Label lb_Cam1Jig1Bo2X;
        private Label lb_Cam1Jig1Bo2Y;
        private Label label2;
        private Label lb_Cam1Jig1La11X;
        private TextBox tb_Cam1Jig1La11X;
        private Label lb_Cam1Jig1La12Y;
        private TextBox tb_Cam1Jig1La12X;
        private TextBox tb_Cam1Jig1La12Y;
        private Label lb_Cam1Jig1La11Y;
        private Label lb_Cam1Jig1La12X;
        private TextBox tb_Cam1Jig1La11Y;
        private Label lb_Cam1Jig1La13X;
        private TextBox tb_Cam1Jig1La13X;
        private Label lb_Cam1Jig1La13Y;
        private TextBox tb_Cam1Jig1La13Y;
        private Label lb_Cam1Jig1La14X;
        private Label lb_Cam1Jig1La14Y;
        private TextBox tb_Cam1Jig1La14X;
        private TextBox tb_Cam1Jig1La14Y;
        private Label label16;
        private Label lb_Cam1Jig1La21X;
        private Label lb_Cam1Jig1La21Y;
        private TextBox tb_Cam1Jig1La21X;
        private TextBox tb_Cam1Jig1La21Y;
        private Label lb_Cam1Jig1La22X;
        private Label lb_Cam1Jig1La22Y;
        private Label lb_Cam1Jig1La23Y;
        private Label lb_Cam1Jig1La23X;
        private TextBox tb_Cam1Jig1La23X;
        private TextBox tb_Cam1Jig1La23Y;
        private Label lb_Cam1Jig1La24X;
        private Label lb_Cam1Jig1La24Y;
        private TextBox tb_Cam1Jig1La22X;
        private TextBox tb_Cam1Jig1La22Y;
        private TextBox tb_Cam1Jig1La24X;
        private TextBox tb_Cam1Jig1La24Y;
        private TabPage tabPage2;
        private UITableLayoutPanel tableLayoutPanel2;
        private TextBox tb_Cam1Jig2Bo1X;
        private Label label25;
        private Label lb_Cam1Jig2Bo1X;
        private Label lb_Cam1Jig2Bo1Y;
        private TextBox tb_Cam1Jig2Bo1Y;
        private Label label28;
        private TextBox tb_Cam1Jig2Bo2X;
        private TextBox tb_Cam1Jig2Bo2Y;
        private Label lb_Cam1Jig2Bo2X;
        private Label lb_Cam1Jig2Bo2Y;
        private Label label31;
        private Label lb_Cam1Jig2La11X;
        private TextBox tb_Cam1Jig2La11X;
        private Label lb_Cam1Jig2La12Y;
        private TextBox tb_Cam1Jig2La12X;
        private TextBox tb_Cam1Jig2La12Y;
        private Label lb_Cam1Jig2La11Y;
        private Label lb_Cam1Jig2La12X;
        private TextBox tb_Cam1Jig2La11Y;
        private Label lb_Cam1Jig2La13X;
        private TextBox tb_Cam1Jig2La13X;
        private Label lb_Cam1Jig2La13Y;
        private TextBox tb_Cam1Jig2La13Y;
        private Label lb_Cam1Jig2La14X;
        private Label lb_Cam1Jig2La14Y;
        private TextBox tb_Cam1Jig2La14X;
        private TextBox tb_Cam1Jig2La14Y;
        private Label label40;
        private Label lb_Cam1Jig2La21X;
        private Label lb_Cam1Jig2La21Y;
        private TextBox tb_Cam1Jig2La21X;
        private TextBox tb_Cam1Jig2La21Y;
        private Label lb_Cam1Jig2La22X;
        private Label lb_Cam1Jig2La22Y;
        private Label lb_Cam1Jig2La23Y;
        private Label lb_Cam1Jig2La23X;
        private TextBox tb_Cam1Jig2La23X;
        private TextBox tb_Cam1Jig2La23Y;
        private Label lb_Cam1Jig2La24X;
        private Label lb_Cam1Jig2La24Y;
        private TextBox tb_Cam1Jig2La22X;
        private TextBox tb_Cam1Jig2La22Y;
        private TextBox tb_Cam1Jig2La24X;
        private TextBox tb_Cam1Jig2La24Y;
        private TabPage tabPage3;
        private UITableLayoutPanel tableLayoutPanel3;
        private TextBox tb_Cam1Jig3Bo1X;
        private Label label49;
        private Label lb_Cam1Jig3Bo1X;
        private Label lb_Cam1Jig3Bo1Y;
        private TextBox tb_Cam1Jig3Bo1Y;
        private Label label52;
        private TextBox tb_Cam1Jig3Bo2X;
        private TextBox tb_Cam1Jig3Bo2Y;
        private Label lb_Cam1Jig3Bo2X;
        private Label lb_Cam1Jig3Bo2Y;
        private Label label55;
        private Label lb_Cam1Jig3La11X;
        private TextBox tb_Cam1Jig3La11X;
        private Label lb_Cam1Jig3La12Y;
        private TextBox tb_Cam1Jig3La12X;
        private TextBox tb_Cam1Jig3La12Y;
        private Label lb_Cam1Jig3La11Y;
        private Label lb_Cam1Jig3La12X;
        private TextBox tb_Cam1Jig3La11Y;
        private Label lb_Cam1Jig3La13X;
        private TextBox tb_Cam1Jig3La13X;
        private Label lb_Cam1Jig3La13Y;
        private TextBox tb_Cam1Jig3La13Y;
        private Label lb_Cam1Jig3La14X;
        private Label lb_Cam1Jig3La14Y;
        private TextBox tb_Cam1Jig3La14X;
        private TextBox tb_Cam1Jig3La14Y;
        private Label label64;
        private Label lb_Cam1Jig3La21X;
        private Label lb_Cam1Jig3La21Y;
        private TextBox tb_Cam1Jig3La21X;
        private TextBox tb_Cam1Jig3La21Y;
        private Label lb_Cam1Jig3La22X;
        private Label lb_Cam1Jig3La22Y;
        private Label lb_Cam1Jig3La23Y;
        private Label lb_Cam1Jig3La23X;
        private TextBox tb_Cam1Jig3La23X;
        private TextBox tb_Cam1Jig3La23Y;
        private Label lb_Cam1Jig3La24X;
        private Label lb_Cam1Jig3La24Y;
        private TextBox tb_Cam1Jig3La22X;
        private TextBox tb_Cam1Jig3La22Y;
        private TextBox tb_Cam1Jig3La24X;
        private TextBox tb_Cam1Jig3La24Y;
        private TabPage tabPage4;
        private UITableLayoutPanel tableLayoutPanel4;
        private TextBox tb_Cam1Jig4Bo1X;
        private Label label73;
        private Label lb_Cam1Jig4Bo1X;
        private Label lb_Cam1Jig4Bo1Y;
        private TextBox tb_Cam1Jig4Bo1Y;
        private Label label76;
        private TextBox tb_Cam1Jig4Bo2X;
        private TextBox tb_Cam1Jig4Bo2Y;
        private Label lb_Cam1Jig4Bo2X;
        private Label lb_Cam1Jig4Bo2Y;
        private Label label79;
        private Label lb_Cam1Jig4La11X;
        private TextBox tb_Cam1Jig4La11X;
        private Label lb_Cam1Jig4La12Y;
        private TextBox tb_Cam1Jig4La12X;
        private TextBox tb_Cam1Jig4La12Y;
        private Label lb_Cam1Jig4La11Y;
        private Label lb_Cam1Jig4La12X;
        private TextBox tb_Cam1Jig4La11Y;
        private Label lb_Cam1Jig4La13X;
        private TextBox tb_Cam1Jig4La13X;
        private Label lb_Cam1Jig4La13Y;
        private TextBox tb_Cam1Jig4La13Y;
        private Label lb_Cam1Jig4La14X;
        private Label lb_Cam1Jig4La14Y;
        private TextBox tb_Cam1Jig4La14X;
        private TextBox tb_Cam1Jig4La14Y;
        private Label label88;
        private Label lb_Cam1Jig4La21X;
        private Label lb_Cam1Jig4La21Y;
        private TextBox tb_Cam1Jig4La21X;
        private TextBox tb_Cam1Jig4La21Y;
        private Label lb_Cam1Jig4La22X;
        private Label lb_Cam1Jig4La22Y;
        private Label lb_Cam1Jig4La23Y;
        private Label lb_Cam1Jig4La23X;
        private TextBox tb_Cam1Jig4La23X;
        private TextBox tb_Cam1Jig4La23Y;
        private Label lb_Cam1Jig4La24X;
        private Label lb_Cam1Jig4La24Y;
        private TextBox tb_Cam1Jig4La22X;
        private TextBox tb_Cam1Jig4La22Y;
        private TextBox tb_Cam1Jig4La24X;
        private TextBox tb_Cam1Jig4La24Y;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private UITableLayoutPanel tableLayoutPanel5;
        private Label lb_Cam1Jig5Bo2Y;
        private TextBox tb_Cam1Jig5Bo2Y;
        private TextBox tb_Cam1Jig5Bo2X;
        private Label lb_Cam1Jig5Bo2X;
        private Label label10;
        private Label lb_Cam1Jig5Bo1Y;
        private TextBox tb_Cam1Jig5Bo1Y;
        private TextBox tb_Cam1Jig5Bo1X;
        private Label lb_Cam1Jig5Bo1X;
        private Label label13;
        private Label lb_Cam1Jig5La21Y;
        private TextBox tb_Cam1Jig5La21Y;
        private TextBox tb_Cam1Jig5La21X;
        private Label lb_Cam1Jig5La21X;
        private Label label17;
        private Label lb_Cam1Jig5La11Y;
        private Label lb_Cam1Jig5La11X;
        private Label label20;
        private TextBox tb_Cam1Jig5La11Y;
        private TextBox tb_Cam1Jig5La11X;
        private Label lb_Cam1Jig5La22Y;
        private TextBox tb_Cam1Jig5La22Y;
        private Label lb_Cam1Jig5La23Y;
        private TextBox tb_Cam1Jig5La23Y;
        private Label lb_Cam1Jig5La24Y;
        private TextBox tb_Cam1Jig5La24Y;
        private Label lb_Cam1Jig5La22X;
        private TextBox tb_Cam1Jig5La22X;
        private Label lb_Cam1Jig5La23X;
        private TextBox tb_Cam1Jig5La23X;
        private Label lb_Cam1Jig5La24X;
        private TextBox tb_Cam1Jig5La24X;
        private Label lb_Cam1Jig5La12Y;
        private Label lb_Cam1Jig5La12X;
        private TextBox tb_Cam1Jig5La12Y;
        private TextBox tb_Cam1Jig5La12X;
        private Label lb_Cam1Jig5La13Y;
        private Label lb_Cam1Jig5La13X;
        private TextBox tb_Cam1Jig5La13Y;
        private TextBox tb_Cam1Jig5La13X;
        private Label lb_Cam1Jig5La14Y;
        private Label lb_Cam1Jig5La14X;
        private TextBox tb_Cam1Jig5La14Y;
        private TextBox tb_Cam1Jig5La14X;
        private Label label36;
        private UITableLayoutPanel tableLayoutPanel6;
        private Label lb_Cam1Jig6Bo2Y;
        private TextBox tb_Cam1Jig6Bo2Y;
        private TextBox tb_Cam1Jig6Bo2X;
        private Label lb_Cam1Jig6Bo2X;
        private Label label39;
        private Label lb_Cam1Jig6Bo1Y;
        private TextBox tb_Cam1Jig6Bo1Y;
        private TextBox tb_Cam1Jig6Bo1X;
        private Label lb_Cam1Jig6Bo1X;
        private Label label43;
        private Label lb_Cam1Jig6La21Y;
        private TextBox tb_Cam1Jig6La21Y;
        private TextBox tb_Cam1Jig6La21X;
        private Label lb_Cam1Jig6La21X;
        private Label label46;
        private Label lb_Cam1Jig6La11Y;
        private Label lb_Cam1Jig6La11X;
        private Label label50;
        private TextBox tb_Cam1Jig6La11Y;
        private TextBox tb_Cam1Jig6La11X;
        private Label lb_Cam1Jig6La22Y;
        private TextBox tb_Cam1Jig6La22Y;
        private Label lb_Cam1Jig6La23Y;
        private TextBox tb_Cam1Jig6La23Y;
        private Label lb_Cam1Jig6La24Y;
        private TextBox tb_Cam1Jig6La24Y;
        private Label lb_Cam1Jig6La22X;
        private TextBox tb_Cam1Jig6La22X;
        private Label lb_Cam1Jig6La23X;
        private TextBox tb_Cam1Jig6La23X;
        private Label lb_Cam1Jig6La24X;
        private TextBox tb_Cam1Jig6La24X;
        private Label lb_Cam1Jig6La12Y;
        private Label lb_Cam1Jig6La12X;
        private TextBox tb_Cam1Jig6La12Y;
        private TextBox tb_Cam1Jig6La12X;
        private Label lb_Cam1Jig6La13Y;
        private Label lb_Cam1Jig6La13X;
        private TextBox tb_Cam1Jig6La13Y;
        private TextBox tb_Cam1Jig6La13X;
        private Label lb_Cam1Jig6La14Y;
        private Label lb_Cam1Jig6La14X;
        private TextBox tb_Cam1Jig6La14Y;
        private TextBox tb_Cam1Jig6La14X;
        private Label label66;
        private UITableLayoutPanel tableLayoutPanel7;
        private Label lb_Cam1Jig7Bo2Y;
        private TextBox tb_Cam1Jig7Bo2Y;
        private TextBox tb_Cam1Jig7Bo2X;
        private Label lb_Cam1Jig7Bo2X;
        private Label label69;
        private Label lb_Cam1Jig7Bo1Y;
        private TextBox tb_Cam1Jig7Bo1Y;
        private TextBox tb_Cam1Jig7Bo1X;
        private Label lb_Cam1Jig7Bo1X;
        private Label label72;
        private Label lb_Cam1Jig7La21Y;
        private TextBox tb_Cam1Jig7La21Y;
        private TextBox tb_Cam1Jig7La21X;
        private Label lb_Cam1Jig7La21X;
        private Label label77;
        private Label lb_Cam1Jig7La11Y;
        private Label lb_Cam1Jig7La11X;
        private Label label81;
        private TextBox tb_Cam1Jig7La11Y;
        private TextBox tb_Cam1Jig7La11X;
        private Label lb_Cam1Jig7La22Y;
        private TextBox tb_Cam1Jig7La22Y;
        private Label lb_Cam1Jig7La23Y;
        private TextBox tb_Cam1Jig7La23Y;
        private Label lb_Cam1Jig7La24Y;
        private TextBox tb_Cam1Jig7La24Y;
        private Label lb_Cam1Jig7La22X;
        private TextBox tb_Cam1Jig7La22X;
        private Label lb_Cam1Jig7La23X;
        private TextBox tb_Cam1Jig7La23X;
        private Label lb_Cam1Jig7La24X;
        private TextBox tb_Cam1Jig7La24X;
        private Label lb_Cam1Jig7La12Y;
        private Label lb_Cam1Jig7La12X;
        private TextBox tb_Cam1Jig7La12Y;
        private TextBox tb_Cam1Jig7La12X;
        private Label lb_Cam1Jig7La13Y;
        private Label lb_Cam1Jig7La13X;
        private TextBox tb_Cam1Jig7La13Y;
        private TextBox tb_Cam1Jig7La13X;
        private Label lb_Cam1Jig7La14Y;
        private Label lb_Cam1Jig7La14X;
        private TextBox tb_Cam1Jig7La14Y;
        private TextBox tb_Cam1Jig7La14X;
        private Label label95;
        private UITableLayoutPanel tableLayoutPanel8;
        private Label lb_Cam1Jig8Bo2Y;
        private TextBox tb_Cam1Jig8Bo2Y;
        private TextBox tb_Cam1Jig8Bo2X;
        private Label lb_Cam1Jig8Bo2X;
        private Label label98;
        private Label lb_Cam1Jig8Bo1Y;
        private TextBox tb_Cam1Jig8Bo1Y;
        private TextBox tb_Cam1Jig8Bo1X;
        private Label lb_Cam1Jig8Bo1X;
        private Label label101;
        private Label lb_Cam1Jig8La21Y;
        private TextBox tb_Cam1Jig8La21Y;
        private TextBox tb_Cam1Jig8La21X;
        private Label lb_Cam1Jig8La21X;
        private Label label104;
        private Label lb_Cam1Jig8La11Y;
        private Label lb_Cam1Jig8La11X;
        private Label label107;
        private TextBox tb_Cam1Jig8La11Y;
        private TextBox tb_Cam1Jig8La11X;
        private Label lb_Cam1Jig8La22Y;
        private TextBox tb_Cam1Jig8La22Y;
        private Label lb_Cam1Jig8La23Y;
        private TextBox tb_Cam1Jig8La23Y;
        private Label lb_Cam1Jig8La24Y;
        private TextBox tb_Cam1Jig8La24Y;
        private Label lb_Cam1Jig8La22X;
        private TextBox tb_Cam1Jig8La22X;
        private Label lb_Cam1Jig8La23X;
        private TextBox tb_Cam1Jig8La23X;
        private Label lb_Cam1Jig8La24X;
        private TextBox tb_Cam1Jig8La24X;
        private Label lb_Cam1Jig8La12Y;
        private Label lb_Cam1Jig8La12X;
        private TextBox tb_Cam1Jig8La12Y;
        private TextBox tb_Cam1Jig8La12X;
        private Label lb_Cam1Jig8La13Y;
        private Label lb_Cam1Jig8La13X;
        private TextBox tb_Cam1Jig8La13Y;
        private TextBox tb_Cam1Jig8La13X;
        private Label lb_Cam1Jig8La14Y;
        private Label lb_Cam1Jig8La14X;
        private TextBox tb_Cam1Jig8La14Y;
        private TextBox tb_Cam1Jig8La14X;
        private Label label120;
        private UITableLayoutPanel tableLayoutPanel9;
        private Label lb_Cam1Jig9Bo2Y;
        private TextBox tb_Cam1Jig9Bo2Y;
        private TextBox tb_Cam1Jig9Bo2X;
        private Label lb_Cam1Jig9Bo2X;
        private Label label123;
        private Label lb_Cam1Jig9Bo1Y;
        private TextBox tb_Cam1Jig9Bo1Y;
        private TextBox tb_Cam1Jig9Bo1X;
        private Label lb_Cam1Jig9Bo1X;
        private Label label126;
        private Label lb_Cam1Jig9La21Y;
        private TextBox tb_Cam1Jig9La21Y;
        private TextBox tb_Cam1Jig9La21X;
        private Label lb_Cam1Jig9La21X;
        private Label label129;
        private Label lb_Cam1Jig9La11Y;
        private Label lb_Cam1Jig9La11X;
        private Label label132;
        private TextBox tb_Cam1Jig9La11Y;
        private TextBox tb_Cam1Jig9La11X;
        private Label lb_Cam1Jig9La22Y;
        private TextBox tb_Cam1Jig9La22Y;
        private Label lb_Cam1Jig9La23Y;
        private TextBox tb_Cam1Jig9La23Y;
        private Label lb_Cam1Jig9La24Y;
        private TextBox tb_Cam1Jig9La24Y;
        private Label lb_Cam1Jig9La22X;
        private TextBox tb_Cam1Jig9La22X;
        private Label lb_Cam1Jig9La23X;
        private TextBox tb_Cam1Jig9La23X;
        private Label lb_Cam1Jig9La24X;
        private TextBox tb_Cam1Jig9La24X;
        private Label lb_Cam1Jig9La12Y;
        private Label lb_Cam1Jig9La12X;
        private TextBox tb_Cam1Jig9La12Y;
        private TextBox tb_Cam1Jig9La12X;
        private Label lb_Cam1Jig9La13Y;
        private Label lb_Cam1Jig9La13X;
        private TextBox tb_Cam1Jig9La13Y;
        private TextBox tb_Cam1Jig9La13X;
        private Label lb_Cam1Jig9La14Y;
        private Label lb_Cam1Jig9La14X;
        private TextBox tb_Cam1Jig9La14Y;
        private TextBox tb_Cam1Jig9La14X;
        private Label label145;
        private Label lb_Cam1LaserStep;
        private TextBox tb_Cam1LaserStep;
        private TextBox tb_Cam1RobotStep;
        private Label lb_Cam1RobotStep;
        private Label lb_Cam1Spacing;
        private Label lb_Cam1SpacingUse;
        private Label lb_Cam1RobotUse;
        private Label lb_Cam1LaserUse;
        private TextBox tb_Cam1Spacing;
        private TextBox tb_Cam1SpacingUse;
        private TextBox tb_Cam1RobotUse;
        private TextBox tb_Cam1LaserUse;
        private Button btn_GetStd4;
        private Button btn_clearJ1;
        private CheckBox cb_clearJ1;
        private Button btn_clearJ2;
        private CheckBox cb_clearJ2;
        private Button btn_clearJ3;
        private CheckBox cb_clearJ3;
        private Button btn_clearJ4;
        private CheckBox cb_clearJ4;
        private Button btn_clearJ5;
        private CheckBox cb_clearJ5;
        private Button btn_clearJ6;
        private CheckBox cb_clearJ6;
        private Button btn_clearJ7;
        private CheckBox cb_clearJ7;
        private Button btn_clearJ8;
        private CheckBox cb_clearJ8;
        private Button btn_clearJ9;
        private CheckBox cb_clearJ9;
        private Label lb_Cam1P2byP1X;
        private TextBox tb_Cam1P2byP1X;
        private TextBox tb_Cam1P2byP1Y;
        private Label lb_Cam1P2byP1Y;
        private TextBox tb_Cam1P4byP3X;
        private Label lb_Cam1P4byP3X;
        private TextBox tb_Cam1P4byP3Y;
        private Label lb_Cam1P4byP3Y;
    }
}