using System.Windows.Forms;

namespace VisionProgram.UI
{
    partial class FrmVppSetting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVppSetting));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_C_VisionTool = new System.Windows.Forms.TabControl();
            this.tab_EditVision = new System.Windows.Forms.TabPage();
            this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
            this.tab_VisionDistortion = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.cogRecordDisplayDistortion = new Cognex.VisionPro.CogRecordDisplay();
            this.btnDistortion = new System.Windows.Forms.Button();
            this.btnChooseDistortionImage = new System.Windows.Forms.Button();
            this.btnDistortionAcq = new System.Windows.Forms.Button();
            this.tab_VisionLinear = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cogRecordDisplayLinear = new Cognex.VisionPro.CogRecordDisplay();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer14 = new System.Windows.Forms.SplitContainer();
            this.gb_LinearCon = new System.Windows.Forms.GroupBox();
            this.rdo_Laser1_Con_L = new System.Windows.Forms.RadioButton();
            this.rdo_Laser_Con_L = new System.Windows.Forms.RadioButton();
            this.rdo_Robot1_Con_L = new System.Windows.Forms.RadioButton();
            this.rdo_Robot_Con_L = new System.Windows.Forms.RadioButton();
            this.splitContainer15 = new System.Windows.Forms.SplitContainer();
            this.gb_LinearMode = new System.Windows.Forms.GroupBox();
            this.rdo_Verificate_Linear = new System.Windows.Forms.RadioButton();
            this.rdo_Manual_Linear = new System.Windows.Forms.RadioButton();
            this.rdo_Auto_Linear = new System.Windows.Forms.RadioButton();
            this.gb_LinearVision = new System.Windows.Forms.GroupBox();
            this.rdo_Live_Linear = new System.Windows.Forms.RadioButton();
            this.rdo_Snap_Linear = new System.Windows.Forms.RadioButton();
            this.btn_Auto_Linear = new System.Windows.Forms.Button();
            this.gb_Linear = new System.Windows.Forms.GroupBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_Save_Linear = new System.Windows.Forms.Button();
            this.btn_Linear = new System.Windows.Forms.Button();
            this.btn_AddMark_Linear = new System.Windows.Forms.Button();
            this.btn_Run_Linear = new System.Windows.Forms.Button();
            this.btn_Clear_Linear = new System.Windows.Forms.Button();
            this.btn_Acq_Linear = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewLinear = new System.Windows.Forms.DataGridView();
            this.UncalibratedPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UncalibratedPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawCalibratedPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawCalibratedPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_RMS_Linear = new System.Windows.Forms.TextBox();
            this.tb_Y_Linear = new System.Windows.Forms.TextBox();
            this.tb_X_Linear = new System.Windows.Forms.TextBox();
            this.lb_RMS = new System.Windows.Forms.Label();
            this.lb_Y_Axis = new System.Windows.Forms.Label();
            this.lb_X_Axis = new System.Windows.Forms.Label();
            this.tb_msg_Linear = new System.Windows.Forms.TextBox();
            this.tab_VisionRotation = new System.Windows.Forms.TabPage();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.cogRecordDisplayRotation = new Cognex.VisionPro.CogRecordDisplay();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.splitContainer13 = new System.Windows.Forms.SplitContainer();
            this.splitContainer16 = new System.Windows.Forms.SplitContainer();
            this.gb_RotationCon = new System.Windows.Forms.GroupBox();
            this.rdo_ROBOT2_Con_R = new System.Windows.Forms.RadioButton();
            this.rdo_ROBOT_Con_R = new System.Windows.Forms.RadioButton();
            this.splitContainer17 = new System.Windows.Forms.SplitContainer();
            this.gb_RotationMode = new System.Windows.Forms.GroupBox();
            this.rdo_Manual_Rotation = new System.Windows.Forms.RadioButton();
            this.rdo_Auto_Rotation = new System.Windows.Forms.RadioButton();
            this.gb_RotationVision = new System.Windows.Forms.GroupBox();
            this.rdo_Live_Rotation = new System.Windows.Forms.RadioButton();
            this.rdo_Snap_Rotation = new System.Windows.Forms.RadioButton();
            this.btn_Auto_Rotation = new System.Windows.Forms.Button();
            this.gb_Rotation = new System.Windows.Forms.GroupBox();
            this.btn_OpenImage_Rotation = new System.Windows.Forms.Button();
            this.btn_Save_Rotation = new System.Windows.Forms.Button();
            this.btn_Rotation = new System.Windows.Forms.Button();
            this.btn_AddMark_Rotation = new System.Windows.Forms.Button();
            this.btn_Run_Rotation = new System.Windows.Forms.Button();
            this.btn_Clear_Rotation = new System.Windows.Forms.Button();
            this.btn_Acq_Rotation = new System.Windows.Forms.Button();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewRotation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiLabel4 = new System.Windows.Forms.Label();
            this.uiLabel3 = new System.Windows.Forms.Label();
            this.uiLabel2 = new System.Windows.Forms.Label();
            this.uiLabel1 = new System.Windows.Forms.Label();
            this.cbo_Nozzle_Rotation = new System.Windows.Forms.ComboBox();
            this.tB_RMS_Rotation = new System.Windows.Forms.TextBox();
            this.tB_Y_Rotation = new System.Windows.Forms.TextBox();
            this.tB_X_Rotation = new System.Windows.Forms.TextBox();
            this.tb_msg_Rotation = new System.Windows.Forms.TextBox();
            this.tb_Step = new System.Windows.Forms.TextBox();
            this.lb_Step = new System.Windows.Forms.Label();
            this.tab_C_VisionTool.SuspendLayout();
            this.tab_EditVision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
            this.tab_VisionDistortion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayDistortion)).BeginInit();
            this.tab_VisionLinear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).BeginInit();
            this.splitContainer14.Panel1.SuspendLayout();
            this.splitContainer14.Panel2.SuspendLayout();
            this.splitContainer14.SuspendLayout();
            this.gb_LinearCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).BeginInit();
            this.splitContainer15.Panel1.SuspendLayout();
            this.splitContainer15.Panel2.SuspendLayout();
            this.splitContainer15.SuspendLayout();
            this.gb_LinearMode.SuspendLayout();
            this.gb_LinearVision.SuspendLayout();
            this.gb_Linear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_VisionRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).BeginInit();
            this.splitContainer13.Panel1.SuspendLayout();
            this.splitContainer13.Panel2.SuspendLayout();
            this.splitContainer13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).BeginInit();
            this.splitContainer16.Panel1.SuspendLayout();
            this.splitContainer16.Panel2.SuspendLayout();
            this.splitContainer16.SuspendLayout();
            this.gb_RotationCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).BeginInit();
            this.splitContainer17.Panel1.SuspendLayout();
            this.splitContainer17.Panel2.SuspendLayout();
            this.splitContainer17.SuspendLayout();
            this.gb_RotationMode.SuspendLayout();
            this.gb_RotationVision.SuspendLayout();
            this.gb_Rotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_C_VisionTool
            // 
            this.tab_C_VisionTool.AllowDrop = true;
            this.tab_C_VisionTool.Controls.Add(this.tab_EditVision);
            this.tab_C_VisionTool.Controls.Add(this.tab_VisionDistortion);
            this.tab_C_VisionTool.Controls.Add(this.tab_VisionLinear);
            this.tab_C_VisionTool.Controls.Add(this.tab_VisionRotation);
            this.tab_C_VisionTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_C_VisionTool.Location = new System.Drawing.Point(0, 0);
            this.tab_C_VisionTool.Name = "tab_C_VisionTool";
            this.tab_C_VisionTool.SelectedIndex = 0;
            this.tab_C_VisionTool.Size = new System.Drawing.Size(1284, 761);
            this.tab_C_VisionTool.TabIndex = 6;
            // 
            // tab_EditVision
            // 
            this.tab_EditVision.AutoScroll = true;
            this.tab_EditVision.BackColor = System.Drawing.Color.Transparent;
            this.tab_EditVision.Controls.Add(this.cogToolBlockEditV21);
            this.tab_EditVision.Location = new System.Drawing.Point(4, 30);
            this.tab_EditVision.Name = "tab_EditVision";
            this.tab_EditVision.Size = new System.Drawing.Size(1276, 727);
            this.tab_EditVision.TabIndex = 0;
            this.tab_EditVision.Text = "VP工具编辑";
            // 
            // cogToolBlockEditV21
            // 
            this.cogToolBlockEditV21.AllowDrop = true;
            this.cogToolBlockEditV21.AutoSize = true;
            this.cogToolBlockEditV21.BackColor = System.Drawing.Color.Transparent;
            this.cogToolBlockEditV21.ContextMenuCustomizer = null;
            this.cogToolBlockEditV21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogToolBlockEditV21.Location = new System.Drawing.Point(0, 0);
            this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(489, 0);
            this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
            this.cogToolBlockEditV21.ShowNodeToolTips = true;
            this.cogToolBlockEditV21.Size = new System.Drawing.Size(1276, 727);
            this.cogToolBlockEditV21.SuspendElectricRuns = false;
            this.cogToolBlockEditV21.TabIndex = 1;
            // 
            // tab_VisionDistortion
            // 
            this.tab_VisionDistortion.Controls.Add(this.splitContainer7);
            this.tab_VisionDistortion.Location = new System.Drawing.Point(4, 30);
            this.tab_VisionDistortion.Name = "tab_VisionDistortion";
            this.tab_VisionDistortion.Size = new System.Drawing.Size(1276, 727);
            this.tab_VisionDistortion.TabIndex = 2;
            this.tab_VisionDistortion.Text = "畸变矫正";
            this.tab_VisionDistortion.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.cogRecordDisplayDistortion);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.btnDistortion);
            this.splitContainer7.Panel2.Controls.Add(this.btnChooseDistortionImage);
            this.splitContainer7.Panel2.Controls.Add(this.btnDistortionAcq);
            this.splitContainer7.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer7.SplitterDistance = 670;
            this.splitContainer7.TabIndex = 0;
            // 
            // cogRecordDisplayDistortion
            // 
            this.cogRecordDisplayDistortion.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayDistortion.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplayDistortion.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplayDistortion.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayDistortion.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplayDistortion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplayDistortion.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplayDistortion.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplayDistortion.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplayDistortion.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplayDistortion.MouseWheelSensitivity = 1D;
            this.cogRecordDisplayDistortion.Name = "cogRecordDisplayDistortion";
            this.cogRecordDisplayDistortion.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplayDistortion.OcxState")));
            this.cogRecordDisplayDistortion.Size = new System.Drawing.Size(1274, 668);
            this.cogRecordDisplayDistortion.TabIndex = 1;
            // 
            // btnDistortion
            // 
            this.btnDistortion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDistortion.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDistortion.Location = new System.Drawing.Point(215, 6);
            this.btnDistortion.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDistortion.Name = "btnDistortion";
            this.btnDistortion.Size = new System.Drawing.Size(100, 35);
            this.btnDistortion.TabIndex = 69;
            this.btnDistortion.Text = "畸变校正";
            this.btnDistortion.Click += new System.EventHandler(this.btnDistortion_Click);
            // 
            // btnChooseDistortionImage
            // 
            this.btnChooseDistortionImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseDistortionImage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnChooseDistortionImage.ForeColor = System.Drawing.Color.Black;
            this.btnChooseDistortionImage.Location = new System.Drawing.Point(109, 6);
            this.btnChooseDistortionImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChooseDistortionImage.Name = "btnChooseDistortionImage";
            this.btnChooseDistortionImage.Size = new System.Drawing.Size(100, 35);
            this.btnChooseDistortionImage.TabIndex = 68;
            this.btnChooseDistortionImage.Text = "文件取图";
            this.btnChooseDistortionImage.Click += new System.EventHandler(this.btnChooseDistortionImage_Click);
            // 
            // btnDistortionAcq
            // 
            this.btnDistortionAcq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDistortionAcq.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnDistortionAcq.Location = new System.Drawing.Point(3, 6);
            this.btnDistortionAcq.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDistortionAcq.Name = "btnDistortionAcq";
            this.btnDistortionAcq.Size = new System.Drawing.Size(100, 35);
            this.btnDistortionAcq.TabIndex = 67;
            this.btnDistortionAcq.Text = "单帧取图";
            this.btnDistortionAcq.Click += new System.EventHandler(this.btnDistortionAcq_Click);
            // 
            // tab_VisionLinear
            // 
            this.tab_VisionLinear.Controls.Add(this.splitContainer1);
            this.tab_VisionLinear.Location = new System.Drawing.Point(4, 30);
            this.tab_VisionLinear.Name = "tab_VisionLinear";
            this.tab_VisionLinear.Size = new System.Drawing.Size(1276, 727);
            this.tab_VisionLinear.TabIndex = 1;
            this.tab_VisionLinear.Text = "九点标定";
            this.tab_VisionLinear.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cogRecordDisplayLinear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer1.SplitterDistance = 803;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 23;
            // 
            // cogRecordDisplayLinear
            // 
            this.cogRecordDisplayLinear.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayLinear.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplayLinear.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplayLinear.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayLinear.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplayLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplayLinear.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplayLinear.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplayLinear.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplayLinear.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplayLinear.MouseWheelSensitivity = 1D;
            this.cogRecordDisplayLinear.Name = "cogRecordDisplayLinear";
            this.cogRecordDisplayLinear.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplayLinear.OcxState")));
            this.cogRecordDisplayLinear.Size = new System.Drawing.Size(803, 727);
            this.cogRecordDisplayLinear.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(470, 727);
            this.splitContainer2.SplitterDistance = 99;
            this.splitContainer2.TabIndex = 23;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.gb_Linear);
            this.splitContainer5.Size = new System.Drawing.Size(99, 727);
            this.splitContainer5.SplitterDistance = 454;
            this.splitContainer5.TabIndex = 25;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.splitContainer14);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.btn_Auto_Linear);
            this.splitContainer6.Size = new System.Drawing.Size(99, 454);
            this.splitContainer6.SplitterDistance = 400;
            this.splitContainer6.SplitterWidth = 1;
            this.splitContainer6.TabIndex = 0;
            // 
            // splitContainer14
            // 
            this.splitContainer14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer14.Location = new System.Drawing.Point(0, 0);
            this.splitContainer14.Name = "splitContainer14";
            this.splitContainer14.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer14.Panel1
            // 
            this.splitContainer14.Panel1.Controls.Add(this.gb_LinearCon);
            // 
            // splitContainer14.Panel2
            // 
            this.splitContainer14.Panel2.Controls.Add(this.splitContainer15);
            this.splitContainer14.Size = new System.Drawing.Size(99, 400);
            this.splitContainer14.SplitterDistance = 180;
            this.splitContainer14.TabIndex = 0;
            // 
            // gb_LinearCon
            // 
            this.gb_LinearCon.Controls.Add(this.rdo_Laser1_Con_L);
            this.gb_LinearCon.Controls.Add(this.rdo_Laser_Con_L);
            this.gb_LinearCon.Controls.Add(this.rdo_Robot1_Con_L);
            this.gb_LinearCon.Controls.Add(this.rdo_Robot_Con_L);
            this.gb_LinearCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearCon.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearCon.Name = "gb_LinearCon";
            this.gb_LinearCon.Size = new System.Drawing.Size(99, 180);
            this.gb_LinearCon.TabIndex = 55;
            this.gb_LinearCon.TabStop = false;
            this.gb_LinearCon.Text = "连接模式";
            // 
            // rdo_Laser1_Con_L
            // 
            this.rdo_Laser1_Con_L.AutoSize = true;
            this.rdo_Laser1_Con_L.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Laser1_Con_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Laser1_Con_L.Location = new System.Drawing.Point(16, 121);
            this.rdo_Laser1_Con_L.Name = "rdo_Laser1_Con_L";
            this.rdo_Laser1_Con_L.Size = new System.Drawing.Size(76, 25);
            this.rdo_Laser1_Con_L.TabIndex = 31;
            this.rdo_Laser1_Con_L.Text = "Laser2";
            this.rdo_Laser1_Con_L.UseVisualStyleBackColor = false;
            this.rdo_Laser1_Con_L.Click += new System.EventHandler(this.rdo_LaserR_Con_L_Click);
            // 
            // rdo_Laser_Con_L
            // 
            this.rdo_Laser_Con_L.AutoSize = true;
            this.rdo_Laser_Con_L.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Laser_Con_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Laser_Con_L.Location = new System.Drawing.Point(16, 90);
            this.rdo_Laser_Con_L.Name = "rdo_Laser_Con_L";
            this.rdo_Laser_Con_L.Size = new System.Drawing.Size(76, 25);
            this.rdo_Laser_Con_L.TabIndex = 30;
            this.rdo_Laser_Con_L.Text = "Laser1";
            this.rdo_Laser_Con_L.UseVisualStyleBackColor = false;
            this.rdo_Laser_Con_L.Click += new System.EventHandler(this.rdo_LaserL_Con_L_Click);
            // 
            // rdo_Robot1_Con_L
            // 
            this.rdo_Robot1_Con_L.AutoSize = true;
            this.rdo_Robot1_Con_L.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Robot1_Con_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Robot1_Con_L.Location = new System.Drawing.Point(16, 59);
            this.rdo_Robot1_Con_L.Name = "rdo_Robot1_Con_L";
            this.rdo_Robot1_Con_L.Size = new System.Drawing.Size(83, 25);
            this.rdo_Robot1_Con_L.TabIndex = 29;
            this.rdo_Robot1_Con_L.Text = "Robot2";
            this.rdo_Robot1_Con_L.UseVisualStyleBackColor = false;
            this.rdo_Robot1_Con_L.Click += new System.EventHandler(this.rdo_RobotR_Con_R_Click);
            // 
            // rdo_Robot_Con_L
            // 
            this.rdo_Robot_Con_L.AutoSize = true;
            this.rdo_Robot_Con_L.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Robot_Con_L.Checked = true;
            this.rdo_Robot_Con_L.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Robot_Con_L.Location = new System.Drawing.Point(16, 28);
            this.rdo_Robot_Con_L.Name = "rdo_Robot_Con_L";
            this.rdo_Robot_Con_L.Size = new System.Drawing.Size(83, 25);
            this.rdo_Robot_Con_L.TabIndex = 28;
            this.rdo_Robot_Con_L.TabStop = true;
            this.rdo_Robot_Con_L.Text = "Robot1";
            this.rdo_Robot_Con_L.UseVisualStyleBackColor = false;
            this.rdo_Robot_Con_L.CheckedChanged += new System.EventHandler(this.rdo_Robot_Con_L_CheckedChanged);
            this.rdo_Robot_Con_L.Click += new System.EventHandler(this.rdo_ROBOT_Con_L_Click);
            // 
            // splitContainer15
            // 
            this.splitContainer15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer15.Location = new System.Drawing.Point(0, 0);
            this.splitContainer15.Name = "splitContainer15";
            this.splitContainer15.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer15.Panel1
            // 
            this.splitContainer15.Panel1.Controls.Add(this.gb_LinearMode);
            // 
            // splitContainer15.Panel2
            // 
            this.splitContainer15.Panel2.Controls.Add(this.gb_LinearVision);
            this.splitContainer15.Size = new System.Drawing.Size(99, 216);
            this.splitContainer15.SplitterDistance = 101;
            this.splitContainer15.TabIndex = 0;
            // 
            // gb_LinearMode
            // 
            this.gb_LinearMode.Controls.Add(this.rdo_Verificate_Linear);
            this.gb_LinearMode.Controls.Add(this.rdo_Manual_Linear);
            this.gb_LinearMode.Controls.Add(this.rdo_Auto_Linear);
            this.gb_LinearMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearMode.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearMode.Name = "gb_LinearMode";
            this.gb_LinearMode.Size = new System.Drawing.Size(99, 101);
            this.gb_LinearMode.TabIndex = 24;
            this.gb_LinearMode.TabStop = false;
            this.gb_LinearMode.Text = "标定模式";
            // 
            // rdo_Verificate_Linear
            // 
            this.rdo_Verificate_Linear.AutoSize = true;
            this.rdo_Verificate_Linear.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Verificate_Linear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Verificate_Linear.Location = new System.Drawing.Point(16, 71);
            this.rdo_Verificate_Linear.Name = "rdo_Verificate_Linear";
            this.rdo_Verificate_Linear.Size = new System.Drawing.Size(60, 25);
            this.rdo_Verificate_Linear.TabIndex = 27;
            this.rdo_Verificate_Linear.Text = "验证";
            this.rdo_Verificate_Linear.UseVisualStyleBackColor = false;
            this.rdo_Verificate_Linear.Click += new System.EventHandler(this.rdo_Verificate_Linear_Click);
            // 
            // rdo_Manual_Linear
            // 
            this.rdo_Manual_Linear.AutoSize = true;
            this.rdo_Manual_Linear.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Manual_Linear.Checked = true;
            this.rdo_Manual_Linear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Manual_Linear.Location = new System.Drawing.Point(16, 25);
            this.rdo_Manual_Linear.Name = "rdo_Manual_Linear";
            this.rdo_Manual_Linear.Size = new System.Drawing.Size(60, 25);
            this.rdo_Manual_Linear.TabIndex = 26;
            this.rdo_Manual_Linear.TabStop = true;
            this.rdo_Manual_Linear.Text = "手动";
            this.rdo_Manual_Linear.UseVisualStyleBackColor = false;
            this.rdo_Manual_Linear.Click += new System.EventHandler(this.rdo_Manual_Linear_Click);
            // 
            // rdo_Auto_Linear
            // 
            this.rdo_Auto_Linear.AutoSize = true;
            this.rdo_Auto_Linear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Auto_Linear.Location = new System.Drawing.Point(16, 48);
            this.rdo_Auto_Linear.Name = "rdo_Auto_Linear";
            this.rdo_Auto_Linear.Size = new System.Drawing.Size(60, 25);
            this.rdo_Auto_Linear.TabIndex = 25;
            this.rdo_Auto_Linear.Text = "自动";
            this.rdo_Auto_Linear.UseVisualStyleBackColor = true;
            this.rdo_Auto_Linear.Click += new System.EventHandler(this.rdo_Auto_Linear_Click);
            // 
            // gb_LinearVision
            // 
            this.gb_LinearVision.Controls.Add(this.rdo_Live_Linear);
            this.gb_LinearVision.Controls.Add(this.rdo_Snap_Linear);
            this.gb_LinearVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearVision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearVision.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearVision.Name = "gb_LinearVision";
            this.gb_LinearVision.Size = new System.Drawing.Size(99, 111);
            this.gb_LinearVision.TabIndex = 22;
            this.gb_LinearVision.TabStop = false;
            this.gb_LinearVision.Text = "图像模式";
            // 
            // rdo_Live_Linear
            // 
            this.rdo_Live_Linear.AutoSize = true;
            this.rdo_Live_Linear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Live_Linear.Location = new System.Drawing.Point(16, 51);
            this.rdo_Live_Linear.Name = "rdo_Live_Linear";
            this.rdo_Live_Linear.Size = new System.Drawing.Size(60, 25);
            this.rdo_Live_Linear.TabIndex = 26;
            this.rdo_Live_Linear.Text = "实时";
            this.rdo_Live_Linear.UseVisualStyleBackColor = true;
            this.rdo_Live_Linear.CheckedChanged += new System.EventHandler(this.rdo_Live_Linear_CheckedChanged);
            // 
            // rdo_Snap_Linear
            // 
            this.rdo_Snap_Linear.AutoSize = true;
            this.rdo_Snap_Linear.Checked = true;
            this.rdo_Snap_Linear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Snap_Linear.Location = new System.Drawing.Point(16, 28);
            this.rdo_Snap_Linear.Name = "rdo_Snap_Linear";
            this.rdo_Snap_Linear.Size = new System.Drawing.Size(60, 25);
            this.rdo_Snap_Linear.TabIndex = 25;
            this.rdo_Snap_Linear.TabStop = true;
            this.rdo_Snap_Linear.Text = "单帧";
            this.rdo_Snap_Linear.UseVisualStyleBackColor = true;
            this.rdo_Snap_Linear.CheckedChanged += new System.EventHandler(this.rdo_Snap_Linear_CheckedChanged);
            // 
            // btn_Auto_Linear
            // 
            this.btn_Auto_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Auto_Linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Auto_Linear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Auto_Linear.Location = new System.Drawing.Point(0, 0);
            this.btn_Auto_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Auto_Linear.Name = "btn_Auto_Linear";
            this.btn_Auto_Linear.Size = new System.Drawing.Size(99, 53);
            this.btn_Auto_Linear.TabIndex = 67;
            this.btn_Auto_Linear.Text = "自动标定";
            this.btn_Auto_Linear.Click += new System.EventHandler(this.btn_Auto_Linear_Click);
            // 
            // gb_Linear
            // 
            this.gb_Linear.Controls.Add(this.btn_test);
            this.gb_Linear.Controls.Add(this.btn_Save_Linear);
            this.gb_Linear.Controls.Add(this.btn_Linear);
            this.gb_Linear.Controls.Add(this.btn_AddMark_Linear);
            this.gb_Linear.Controls.Add(this.btn_Run_Linear);
            this.gb_Linear.Controls.Add(this.btn_Clear_Linear);
            this.gb_Linear.Controls.Add(this.btn_Acq_Linear);
            this.gb_Linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Linear.Location = new System.Drawing.Point(0, 0);
            this.gb_Linear.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Linear.Name = "gb_Linear";
            this.gb_Linear.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Linear.Size = new System.Drawing.Size(99, 269);
            this.gb_Linear.TabIndex = 22;
            this.gb_Linear.TabStop = false;
            // 
            // btn_test
            // 
            this.btn_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_test.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_test.Location = new System.Drawing.Point(11, 229);
            this.btn_test.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(91, 26);
            this.btn_test.TabIndex = 73;
            this.btn_test.Text = "测试按钮";
            this.btn_test.Visible = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_Save_Linear
            // 
            this.btn_Save_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Save_Linear.Location = new System.Drawing.Point(11, 197);
            this.btn_Save_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save_Linear.Name = "btn_Save_Linear";
            this.btn_Save_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_Save_Linear.TabIndex = 72;
            this.btn_Save_Linear.Text = "保存结果";
            this.btn_Save_Linear.Click += new System.EventHandler(this.btn_Save_Linear_Click);
            // 
            // btn_Linear
            // 
            this.btn_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Linear.Location = new System.Drawing.Point(11, 163);
            this.btn_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Linear.Name = "btn_Linear";
            this.btn_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_Linear.TabIndex = 71;
            this.btn_Linear.Text = "开始标定";
            this.btn_Linear.Click += new System.EventHandler(this.btn_Linear_Click);
            // 
            // btn_AddMark_Linear
            // 
            this.btn_AddMark_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddMark_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_AddMark_Linear.Location = new System.Drawing.Point(11, 129);
            this.btn_AddMark_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AddMark_Linear.Name = "btn_AddMark_Linear";
            this.btn_AddMark_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_AddMark_Linear.TabIndex = 70;
            this.btn_AddMark_Linear.Text = "添加Mark";
            this.btn_AddMark_Linear.Click += new System.EventHandler(this.btn_AddMark_Linear_Click);
            // 
            // btn_Run_Linear
            // 
            this.btn_Run_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Run_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Run_Linear.Location = new System.Drawing.Point(11, 95);
            this.btn_Run_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Run_Linear.Name = "btn_Run_Linear";
            this.btn_Run_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_Run_Linear.TabIndex = 69;
            this.btn_Run_Linear.Text = "运行程序";
            this.btn_Run_Linear.Click += new System.EventHandler(this.btn_Run_Linear_Click);
            // 
            // btn_Clear_Linear
            // 
            this.btn_Clear_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Clear_Linear.Location = new System.Drawing.Point(11, 61);
            this.btn_Clear_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Clear_Linear.Name = "btn_Clear_Linear";
            this.btn_Clear_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_Clear_Linear.TabIndex = 68;
            this.btn_Clear_Linear.Text = "重新标定";
            this.btn_Clear_Linear.Click += new System.EventHandler(this.btn_Clear_Linear_Click);
            // 
            // btn_Acq_Linear
            // 
            this.btn_Acq_Linear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acq_Linear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Acq_Linear.Location = new System.Drawing.Point(11, 27);
            this.btn_Acq_Linear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Acq_Linear.Name = "btn_Acq_Linear";
            this.btn_Acq_Linear.Size = new System.Drawing.Size(91, 26);
            this.btn_Acq_Linear.TabIndex = 67;
            this.btn_Acq_Linear.Text = "采集图像";
            this.btn_Acq_Linear.Click += new System.EventHandler(this.btn_Acq_Linear_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dataGridViewLinear);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(367, 727);
            this.splitContainer3.SplitterDistance = 399;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // dataGridViewLinear
            // 
            this.dataGridViewLinear.AllowUserToAddRows = false;
            this.dataGridViewLinear.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridViewLinear.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLinear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLinear.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLinear.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewLinear.ColumnHeadersHeight = 32;
            this.dataGridViewLinear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLinear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UncalibratedPointX,
            this.UncalibratedPointY,
            this.RawCalibratedPointX,
            this.RawCalibratedPointY});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLinear.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLinear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLinear.EnableHeadersVisualStyles = false;
            this.dataGridViewLinear.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridViewLinear.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLinear.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLinear.MultiSelect = false;
            this.dataGridViewLinear.Name = "dataGridViewLinear";
            this.dataGridViewLinear.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLinear.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridViewLinear.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewLinear.RowTemplate.Height = 30;
            this.dataGridViewLinear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLinear.Size = new System.Drawing.Size(367, 399);
            this.dataGridViewLinear.TabIndex = 0;
            this.dataGridViewLinear.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewLinear_RowPostPaint);
            // 
            // UncalibratedPointX
            // 
            this.UncalibratedPointX.HeaderText = "未校正X";
            this.UncalibratedPointX.MaxInputLength = 6;
            this.UncalibratedPointX.Name = "UncalibratedPointX";
            this.UncalibratedPointX.ReadOnly = true;
            // 
            // UncalibratedPointY
            // 
            this.UncalibratedPointY.HeaderText = "未校正Y";
            this.UncalibratedPointY.MaxInputLength = 6;
            this.UncalibratedPointY.Name = "UncalibratedPointY";
            this.UncalibratedPointY.ReadOnly = true;
            // 
            // RawCalibratedPointX
            // 
            this.RawCalibratedPointX.HeaderText = "已校正X";
            this.RawCalibratedPointX.MaxInputLength = 6;
            this.RawCalibratedPointX.Name = "RawCalibratedPointX";
            this.RawCalibratedPointX.ReadOnly = true;
            // 
            // RawCalibratedPointY
            // 
            this.RawCalibratedPointY.HeaderText = "已校正Y";
            this.RawCalibratedPointY.MaxInputLength = 6;
            this.RawCalibratedPointY.Name = "RawCalibratedPointY";
            this.RawCalibratedPointY.ReadOnly = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.tb_msg_Linear);
            this.splitContainer4.Size = new System.Drawing.Size(367, 325);
            this.splitContainer4.SplitterDistance = 81;
            this.splitContainer4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_Step);
            this.panel1.Controls.Add(this.lb_Step);
            this.panel1.Controls.Add(this.tb_RMS_Linear);
            this.panel1.Controls.Add(this.tb_Y_Linear);
            this.panel1.Controls.Add(this.tb_X_Linear);
            this.panel1.Controls.Add(this.lb_RMS);
            this.panel1.Controls.Add(this.lb_Y_Axis);
            this.panel1.Controls.Add(this.lb_X_Axis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 81);
            this.panel1.TabIndex = 0;
            // 
            // tb_RMS_Linear
            // 
            this.tb_RMS_Linear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_RMS_Linear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_RMS_Linear.Location = new System.Drawing.Point(186, 36);
            this.tb_RMS_Linear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_RMS_Linear.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_RMS_Linear.Name = "tb_RMS_Linear";
            this.tb_RMS_Linear.Size = new System.Drawing.Size(84, 29);
            this.tb_RMS_Linear.TabIndex = 38;
            // 
            // tb_Y_Linear
            // 
            this.tb_Y_Linear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Y_Linear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Y_Linear.Location = new System.Drawing.Point(96, 36);
            this.tb_Y_Linear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Y_Linear.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Y_Linear.Name = "tb_Y_Linear";
            this.tb_Y_Linear.Size = new System.Drawing.Size(84, 29);
            this.tb_Y_Linear.TabIndex = 39;
            // 
            // tb_X_Linear
            // 
            this.tb_X_Linear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_X_Linear.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_X_Linear.Location = new System.Drawing.Point(6, 36);
            this.tb_X_Linear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_X_Linear.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_X_Linear.Name = "tb_X_Linear";
            this.tb_X_Linear.Size = new System.Drawing.Size(84, 29);
            this.tb_X_Linear.TabIndex = 40;
            // 
            // lb_RMS
            // 
            this.lb_RMS.AutoSize = true;
            this.lb_RMS.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_RMS.Location = new System.Drawing.Point(186, 10);
            this.lb_RMS.Name = "lb_RMS";
            this.lb_RMS.Size = new System.Drawing.Size(79, 20);
            this.lb_RMS.TabIndex = 35;
            this.lb_RMS.Text = "标定误差：";
            this.lb_RMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Y_Axis
            // 
            this.lb_Y_Axis.AutoSize = true;
            this.lb_Y_Axis.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Y_Axis.Location = new System.Drawing.Point(96, 10);
            this.lb_Y_Axis.Name = "lb_Y_Axis";
            this.lb_Y_Axis.Size = new System.Drawing.Size(73, 20);
            this.lb_Y_Axis.TabIndex = 36;
            this.lb_Y_Axis.Text = "Y轴坐标：";
            this.lb_Y_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_X_Axis
            // 
            this.lb_X_Axis.AutoSize = true;
            this.lb_X_Axis.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_X_Axis.Location = new System.Drawing.Point(6, 10);
            this.lb_X_Axis.Name = "lb_X_Axis";
            this.lb_X_Axis.Size = new System.Drawing.Size(74, 20);
            this.lb_X_Axis.TabIndex = 37;
            this.lb_X_Axis.Text = "X轴坐标：";
            this.lb_X_Axis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_msg_Linear
            // 
            this.tb_msg_Linear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_msg_Linear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_msg_Linear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_msg_Linear.Location = new System.Drawing.Point(0, 0);
            this.tb_msg_Linear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_msg_Linear.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_msg_Linear.Multiline = true;
            this.tb_msg_Linear.Name = "tb_msg_Linear";
            this.tb_msg_Linear.Size = new System.Drawing.Size(367, 240);
            this.tb_msg_Linear.TabIndex = 6;
            // 
            // tab_VisionRotation
            // 
            this.tab_VisionRotation.Controls.Add(this.splitContainer8);
            this.tab_VisionRotation.Location = new System.Drawing.Point(4, 30);
            this.tab_VisionRotation.Name = "tab_VisionRotation";
            this.tab_VisionRotation.Size = new System.Drawing.Size(1276, 727);
            this.tab_VisionRotation.TabIndex = 3;
            this.tab_VisionRotation.Text = "旋转中心标定";
            this.tab_VisionRotation.UseVisualStyleBackColor = true;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.IsSplitterFixed = true;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.cogRecordDisplayRotation);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer8.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer8.SplitterDistance = 771;
            this.splitContainer8.TabIndex = 0;
            // 
            // cogRecordDisplayRotation
            // 
            this.cogRecordDisplayRotation.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayRotation.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplayRotation.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplayRotation.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplayRotation.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplayRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplayRotation.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplayRotation.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplayRotation.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplayRotation.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplayRotation.MouseWheelSensitivity = 1D;
            this.cogRecordDisplayRotation.Name = "cogRecordDisplayRotation";
            this.cogRecordDisplayRotation.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplayRotation.OcxState")));
            this.cogRecordDisplayRotation.Size = new System.Drawing.Size(771, 727);
            this.cogRecordDisplayRotation.TabIndex = 1;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.splitContainer12);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.splitContainer10);
            this.splitContainer9.Size = new System.Drawing.Size(501, 727);
            this.splitContainer9.SplitterDistance = 112;
            this.splitContainer9.TabIndex = 0;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            this.splitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.splitContainer13);
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.gb_Rotation);
            this.splitContainer12.Size = new System.Drawing.Size(112, 727);
            this.splitContainer12.SplitterDistance = 402;
            this.splitContainer12.SplitterIncrement = 3;
            this.splitContainer12.SplitterWidth = 8;
            this.splitContainer12.TabIndex = 0;
            // 
            // splitContainer13
            // 
            this.splitContainer13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer13.Location = new System.Drawing.Point(0, 0);
            this.splitContainer13.Name = "splitContainer13";
            this.splitContainer13.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            this.splitContainer13.Panel1.Controls.Add(this.splitContainer16);
            // 
            // splitContainer13.Panel2
            // 
            this.splitContainer13.Panel2.Controls.Add(this.btn_Auto_Rotation);
            this.splitContainer13.Size = new System.Drawing.Size(112, 402);
            this.splitContainer13.SplitterDistance = 306;
            this.splitContainer13.TabIndex = 0;
            // 
            // splitContainer16
            // 
            this.splitContainer16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer16.Location = new System.Drawing.Point(0, 0);
            this.splitContainer16.Name = "splitContainer16";
            this.splitContainer16.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer16.Panel1
            // 
            this.splitContainer16.Panel1.Controls.Add(this.gb_RotationCon);
            // 
            // splitContainer16.Panel2
            // 
            this.splitContainer16.Panel2.Controls.Add(this.splitContainer17);
            this.splitContainer16.Size = new System.Drawing.Size(112, 306);
            this.splitContainer16.SplitterDistance = 103;
            this.splitContainer16.TabIndex = 0;
            // 
            // gb_RotationCon
            // 
            this.gb_RotationCon.Controls.Add(this.rdo_ROBOT2_Con_R);
            this.gb_RotationCon.Controls.Add(this.rdo_ROBOT_Con_R);
            this.gb_RotationCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationCon.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationCon.Name = "gb_RotationCon";
            this.gb_RotationCon.Size = new System.Drawing.Size(112, 103);
            this.gb_RotationCon.TabIndex = 54;
            this.gb_RotationCon.TabStop = false;
            this.gb_RotationCon.Text = "连接模式";
            // 
            // rdo_ROBOT2_Con_R
            // 
            this.rdo_ROBOT2_Con_R.AutoSize = true;
            this.rdo_ROBOT2_Con_R.BackColor = System.Drawing.Color.Transparent;
            this.rdo_ROBOT2_Con_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_ROBOT2_Con_R.Location = new System.Drawing.Point(13, 59);
            this.rdo_ROBOT2_Con_R.Name = "rdo_ROBOT2_Con_R";
            this.rdo_ROBOT2_Con_R.Size = new System.Drawing.Size(83, 25);
            this.rdo_ROBOT2_Con_R.TabIndex = 29;
            this.rdo_ROBOT2_Con_R.Text = "Robot2";
            this.rdo_ROBOT2_Con_R.UseVisualStyleBackColor = false;
            this.rdo_ROBOT2_Con_R.Click += new System.EventHandler(this.rdo_ROBOT2_Con_R_Click);
            // 
            // rdo_ROBOT_Con_R
            // 
            this.rdo_ROBOT_Con_R.AutoSize = true;
            this.rdo_ROBOT_Con_R.BackColor = System.Drawing.Color.Transparent;
            this.rdo_ROBOT_Con_R.Checked = true;
            this.rdo_ROBOT_Con_R.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_ROBOT_Con_R.Location = new System.Drawing.Point(13, 28);
            this.rdo_ROBOT_Con_R.Name = "rdo_ROBOT_Con_R";
            this.rdo_ROBOT_Con_R.Size = new System.Drawing.Size(83, 25);
            this.rdo_ROBOT_Con_R.TabIndex = 28;
            this.rdo_ROBOT_Con_R.TabStop = true;
            this.rdo_ROBOT_Con_R.Text = "Robot1";
            this.rdo_ROBOT_Con_R.UseVisualStyleBackColor = false;
            this.rdo_ROBOT_Con_R.Click += new System.EventHandler(this.rdo_ROBOT_Con_R_Click);
            // 
            // splitContainer17
            // 
            this.splitContainer17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer17.Location = new System.Drawing.Point(0, 0);
            this.splitContainer17.Name = "splitContainer17";
            this.splitContainer17.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer17.Panel1
            // 
            this.splitContainer17.Panel1.Controls.Add(this.gb_RotationMode);
            // 
            // splitContainer17.Panel2
            // 
            this.splitContainer17.Panel2.Controls.Add(this.gb_RotationVision);
            this.splitContainer17.Size = new System.Drawing.Size(112, 199);
            this.splitContainer17.SplitterDistance = 92;
            this.splitContainer17.TabIndex = 0;
            // 
            // gb_RotationMode
            // 
            this.gb_RotationMode.Controls.Add(this.rdo_Manual_Rotation);
            this.gb_RotationMode.Controls.Add(this.rdo_Auto_Rotation);
            this.gb_RotationMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationMode.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationMode.Name = "gb_RotationMode";
            this.gb_RotationMode.Size = new System.Drawing.Size(112, 92);
            this.gb_RotationMode.TabIndex = 27;
            this.gb_RotationMode.TabStop = false;
            this.gb_RotationMode.Text = "标定模式";
            // 
            // rdo_Manual_Rotation
            // 
            this.rdo_Manual_Rotation.AutoSize = true;
            this.rdo_Manual_Rotation.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Manual_Rotation.Checked = true;
            this.rdo_Manual_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Manual_Rotation.Location = new System.Drawing.Point(18, 57);
            this.rdo_Manual_Rotation.Name = "rdo_Manual_Rotation";
            this.rdo_Manual_Rotation.Size = new System.Drawing.Size(60, 25);
            this.rdo_Manual_Rotation.TabIndex = 28;
            this.rdo_Manual_Rotation.TabStop = true;
            this.rdo_Manual_Rotation.Text = "手动";
            this.rdo_Manual_Rotation.UseVisualStyleBackColor = false;
            this.rdo_Manual_Rotation.Click += new System.EventHandler(this.rdo_Manual_Rotation_Click);
            // 
            // rdo_Auto_Rotation
            // 
            this.rdo_Auto_Rotation.AutoSize = true;
            this.rdo_Auto_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Auto_Rotation.Location = new System.Drawing.Point(18, 22);
            this.rdo_Auto_Rotation.Name = "rdo_Auto_Rotation";
            this.rdo_Auto_Rotation.Size = new System.Drawing.Size(60, 25);
            this.rdo_Auto_Rotation.TabIndex = 27;
            this.rdo_Auto_Rotation.Text = "自动";
            this.rdo_Auto_Rotation.UseVisualStyleBackColor = true;
            this.rdo_Auto_Rotation.Click += new System.EventHandler(this.rdo_Auto_Rotation_Click);
            // 
            // gb_RotationVision
            // 
            this.gb_RotationVision.Controls.Add(this.rdo_Live_Rotation);
            this.gb_RotationVision.Controls.Add(this.rdo_Snap_Rotation);
            this.gb_RotationVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationVision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationVision.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationVision.Name = "gb_RotationVision";
            this.gb_RotationVision.Size = new System.Drawing.Size(112, 103);
            this.gb_RotationVision.TabIndex = 26;
            this.gb_RotationVision.TabStop = false;
            this.gb_RotationVision.Text = "图像模式";
            // 
            // rdo_Live_Rotation
            // 
            this.rdo_Live_Rotation.AutoSize = true;
            this.rdo_Live_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Live_Rotation.Location = new System.Drawing.Point(18, 51);
            this.rdo_Live_Rotation.Name = "rdo_Live_Rotation";
            this.rdo_Live_Rotation.Size = new System.Drawing.Size(60, 25);
            this.rdo_Live_Rotation.TabIndex = 28;
            this.rdo_Live_Rotation.Text = "实时";
            this.rdo_Live_Rotation.UseVisualStyleBackColor = true;
            this.rdo_Live_Rotation.CheckedChanged += new System.EventHandler(this.rdo_Live_Rotation_CheckedChanged);
            // 
            // rdo_Snap_Rotation
            // 
            this.rdo_Snap_Rotation.AutoSize = true;
            this.rdo_Snap_Rotation.Checked = true;
            this.rdo_Snap_Rotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Snap_Rotation.Location = new System.Drawing.Point(18, 28);
            this.rdo_Snap_Rotation.Name = "rdo_Snap_Rotation";
            this.rdo_Snap_Rotation.Size = new System.Drawing.Size(60, 25);
            this.rdo_Snap_Rotation.TabIndex = 27;
            this.rdo_Snap_Rotation.TabStop = true;
            this.rdo_Snap_Rotation.Text = "单帧";
            this.rdo_Snap_Rotation.UseVisualStyleBackColor = true;
            this.rdo_Snap_Rotation.CheckedChanged += new System.EventHandler(this.rdo_Snap_Rotation_CheckedChanged);
            // 
            // btn_Auto_Rotation
            // 
            this.btn_Auto_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Auto_Rotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Auto_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Auto_Rotation.Location = new System.Drawing.Point(0, 0);
            this.btn_Auto_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Auto_Rotation.Name = "btn_Auto_Rotation";
            this.btn_Auto_Rotation.Size = new System.Drawing.Size(112, 92);
            this.btn_Auto_Rotation.TabIndex = 68;
            this.btn_Auto_Rotation.Text = "自动标定";
            this.btn_Auto_Rotation.Click += new System.EventHandler(this.btn_Auto_Rotation_Click);
            // 
            // gb_Rotation
            // 
            this.gb_Rotation.Controls.Add(this.btn_OpenImage_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_Save_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_AddMark_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_Run_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_Clear_Rotation);
            this.gb_Rotation.Controls.Add(this.btn_Acq_Rotation);
            this.gb_Rotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Rotation.Location = new System.Drawing.Point(0, 0);
            this.gb_Rotation.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Rotation.Name = "gb_Rotation";
            this.gb_Rotation.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Rotation.Size = new System.Drawing.Size(112, 317);
            this.gb_Rotation.TabIndex = 23;
            this.gb_Rotation.TabStop = false;
            // 
            // btn_OpenImage_Rotation
            // 
            this.btn_OpenImage_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenImage_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_OpenImage_Rotation.Location = new System.Drawing.Point(13, 240);
            this.btn_OpenImage_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_OpenImage_Rotation.Name = "btn_OpenImage_Rotation";
            this.btn_OpenImage_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_OpenImage_Rotation.TabIndex = 80;
            this.btn_OpenImage_Rotation.Text = "文件取图";
            this.btn_OpenImage_Rotation.Click += new System.EventHandler(this.btn_OpenImage_Rotation_Click);
            // 
            // btn_Save_Rotation
            // 
            this.btn_Save_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Save_Rotation.Location = new System.Drawing.Point(13, 206);
            this.btn_Save_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Save_Rotation.Name = "btn_Save_Rotation";
            this.btn_Save_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_Save_Rotation.TabIndex = 79;
            this.btn_Save_Rotation.Text = "保存结果";
            this.btn_Save_Rotation.Click += new System.EventHandler(this.btn_Save_Rotation_Click);
            // 
            // btn_Rotation
            // 
            this.btn_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Rotation.Location = new System.Drawing.Point(13, 172);
            this.btn_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Rotation.Name = "btn_Rotation";
            this.btn_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_Rotation.TabIndex = 78;
            this.btn_Rotation.Text = "开始标定";
            this.btn_Rotation.Click += new System.EventHandler(this.btn_Rotation_Click);
            // 
            // btn_AddMark_Rotation
            // 
            this.btn_AddMark_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddMark_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_AddMark_Rotation.Location = new System.Drawing.Point(13, 138);
            this.btn_AddMark_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_AddMark_Rotation.Name = "btn_AddMark_Rotation";
            this.btn_AddMark_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_AddMark_Rotation.TabIndex = 77;
            this.btn_AddMark_Rotation.Text = "添加Mark";
            this.btn_AddMark_Rotation.Click += new System.EventHandler(this.btn_AddMark_Rotation_Click);
            // 
            // btn_Run_Rotation
            // 
            this.btn_Run_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Run_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Run_Rotation.Location = new System.Drawing.Point(13, 104);
            this.btn_Run_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Run_Rotation.Name = "btn_Run_Rotation";
            this.btn_Run_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_Run_Rotation.TabIndex = 76;
            this.btn_Run_Rotation.Text = "运行程序";
            this.btn_Run_Rotation.Click += new System.EventHandler(this.btn_Run_Rotation_Click);
            // 
            // btn_Clear_Rotation
            // 
            this.btn_Clear_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Clear_Rotation.Location = new System.Drawing.Point(13, 70);
            this.btn_Clear_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Clear_Rotation.Name = "btn_Clear_Rotation";
            this.btn_Clear_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_Clear_Rotation.TabIndex = 75;
            this.btn_Clear_Rotation.Text = "重新标定";
            this.btn_Clear_Rotation.Click += new System.EventHandler(this.btn_Clear_Rotation_Click);
            // 
            // btn_Acq_Rotation
            // 
            this.btn_Acq_Rotation.BackColor = System.Drawing.Color.Transparent;
            this.btn_Acq_Rotation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acq_Rotation.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Acq_Rotation.Location = new System.Drawing.Point(13, 36);
            this.btn_Acq_Rotation.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Acq_Rotation.Name = "btn_Acq_Rotation";
            this.btn_Acq_Rotation.Size = new System.Drawing.Size(86, 25);
            this.btn_Acq_Rotation.TabIndex = 74;
            this.btn_Acq_Rotation.Text = "采集图像";
            this.btn_Acq_Rotation.UseVisualStyleBackColor = false;
            this.btn_Acq_Rotation.Click += new System.EventHandler(this.btn_Acq_Rotation_Click);
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.dataGridViewRotation);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(385, 727);
            this.splitContainer10.SplitterDistance = 342;
            this.splitContainer10.TabIndex = 0;
            // 
            // dataGridViewRotation
            // 
            this.dataGridViewRotation.AllowUserToAddRows = false;
            this.dataGridViewRotation.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dataGridViewRotation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRotation.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRotation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRotation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRotation.ColumnHeadersHeight = 32;
            this.dataGridViewRotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRotation.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRotation.EnableHeadersVisualStyles = false;
            this.dataGridViewRotation.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dataGridViewRotation.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRotation.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRotation.MultiSelect = false;
            this.dataGridViewRotation.Name = "dataGridViewRotation";
            this.dataGridViewRotation.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRotation.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataGridViewRotation.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewRotation.RowTemplate.Height = 30;
            this.dataGridViewRotation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRotation.Size = new System.Drawing.Size(385, 342);
            this.dataGridViewRotation.TabIndex = 1;
            this.dataGridViewRotation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewRotation_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "未校正X";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "未校正Y";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            this.splitContainer11.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.tb_msg_Rotation);
            this.splitContainer11.Size = new System.Drawing.Size(385, 381);
            this.splitContainer11.SplitterDistance = 134;
            this.splitContainer11.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uiLabel4);
            this.panel2.Controls.Add(this.uiLabel3);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.uiLabel1);
            this.panel2.Controls.Add(this.cbo_Nozzle_Rotation);
            this.panel2.Controls.Add(this.tB_RMS_Rotation);
            this.panel2.Controls.Add(this.tB_Y_Rotation);
            this.panel2.Controls.Add(this.tB_X_Rotation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 134);
            this.panel2.TabIndex = 0;
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(119, 6);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(92, 17);
            this.uiLabel4.TabIndex = 55;
            this.uiLabel4.Text = "当前转轴序号：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(119, 65);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(92, 17);
            this.uiLabel3.TabIndex = 55;
            this.uiLabel3.Text = "旋转中心误差：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(3, 65);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(75, 17);
            this.uiLabel2.TabIndex = 55;
            this.uiLabel2.Text = "旋转中心Y：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 6);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(76, 17);
            this.uiLabel1.TabIndex = 55;
            this.uiLabel1.Text = "旋转中心X：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbo_Nozzle_Rotation
            // 
            this.cbo_Nozzle_Rotation.DropDownWidth = 300;
            this.cbo_Nozzle_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbo_Nozzle_Rotation.Location = new System.Drawing.Point(123, 26);
            this.cbo_Nozzle_Rotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Nozzle_Rotation.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbo_Nozzle_Rotation.Name = "cbo_Nozzle_Rotation";
            this.cbo_Nozzle_Rotation.Size = new System.Drawing.Size(100, 29);
            this.cbo_Nozzle_Rotation.TabIndex = 54;
            this.cbo_Nozzle_Rotation.SelectedIndexChanged += new System.EventHandler(this.cbo_Nozzle_Rotation_SelectedIndexChanged);
            // 
            // tB_RMS_Rotation
            // 
            this.tB_RMS_Rotation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_RMS_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tB_RMS_Rotation.Location = new System.Drawing.Point(123, 89);
            this.tB_RMS_Rotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_RMS_Rotation.MinimumSize = new System.Drawing.Size(4, 4);
            this.tB_RMS_Rotation.Name = "tB_RMS_Rotation";
            this.tB_RMS_Rotation.Size = new System.Drawing.Size(100, 29);
            this.tB_RMS_Rotation.TabIndex = 32;
            // 
            // tB_Y_Rotation
            // 
            this.tB_Y_Rotation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_Y_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tB_Y_Rotation.Location = new System.Drawing.Point(7, 89);
            this.tB_Y_Rotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_Y_Rotation.MinimumSize = new System.Drawing.Size(4, 4);
            this.tB_Y_Rotation.Name = "tB_Y_Rotation";
            this.tB_Y_Rotation.Size = new System.Drawing.Size(100, 29);
            this.tB_Y_Rotation.TabIndex = 31;
            // 
            // tB_X_Rotation
            // 
            this.tB_X_Rotation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tB_X_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tB_X_Rotation.Location = new System.Drawing.Point(7, 26);
            this.tB_X_Rotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_X_Rotation.MinimumSize = new System.Drawing.Size(4, 4);
            this.tB_X_Rotation.Name = "tB_X_Rotation";
            this.tB_X_Rotation.Size = new System.Drawing.Size(100, 29);
            this.tB_X_Rotation.TabIndex = 30;
            // 
            // tb_msg_Rotation
            // 
            this.tb_msg_Rotation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_msg_Rotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_msg_Rotation.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_msg_Rotation.Location = new System.Drawing.Point(0, 0);
            this.tb_msg_Rotation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_msg_Rotation.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_msg_Rotation.Multiline = true;
            this.tb_msg_Rotation.Name = "tb_msg_Rotation";
            this.tb_msg_Rotation.Size = new System.Drawing.Size(385, 243);
            this.tb_msg_Rotation.TabIndex = 6;
            // 
            // tb_Step
            // 
            this.tb_Step.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Step.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Step.Location = new System.Drawing.Point(276, 36);
            this.tb_Step.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Step.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Step.Name = "tb_Step";
            this.tb_Step.Size = new System.Drawing.Size(84, 29);
            this.tb_Step.TabIndex = 42;
            // 
            // lb_Step
            // 
            this.lb_Step.AutoSize = true;
            this.lb_Step.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Step.Location = new System.Drawing.Point(276, 10);
            this.lb_Step.Name = "lb_Step";
            this.lb_Step.Size = new System.Drawing.Size(93, 20);
            this.lb_Step.TabIndex = 41;
            this.lb_Step.Text = "标定偏移量：";
            this.lb_Step.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmVppSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.tab_C_VisionTool);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FrmVppSetting";
            this.Text = "工具设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVppSetting_FormClosing);
            this.Load += new System.EventHandler(this.FrmVppSetting_Load);
            this.tab_C_VisionTool.ResumeLayout(false);
            this.tab_EditVision.ResumeLayout(false);
            this.tab_EditVision.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
            this.tab_VisionDistortion.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayDistortion)).EndInit();
            this.tab_VisionLinear.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayLinear)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer14.Panel1.ResumeLayout(false);
            this.splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer14)).EndInit();
            this.splitContainer14.ResumeLayout(false);
            this.gb_LinearCon.ResumeLayout(false);
            this.gb_LinearCon.PerformLayout();
            this.splitContainer15.Panel1.ResumeLayout(false);
            this.splitContainer15.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer15)).EndInit();
            this.splitContainer15.ResumeLayout(false);
            this.gb_LinearMode.ResumeLayout(false);
            this.gb_LinearMode.PerformLayout();
            this.gb_LinearVision.ResumeLayout(false);
            this.gb_LinearVision.PerformLayout();
            this.gb_Linear.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinear)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_VisionRotation.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayRotation)).EndInit();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            this.splitContainer13.Panel1.ResumeLayout(false);
            this.splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).EndInit();
            this.splitContainer13.ResumeLayout(false);
            this.splitContainer16.Panel1.ResumeLayout(false);
            this.splitContainer16.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer16)).EndInit();
            this.splitContainer16.ResumeLayout(false);
            this.gb_RotationCon.ResumeLayout(false);
            this.gb_RotationCon.PerformLayout();
            this.splitContainer17.Panel1.ResumeLayout(false);
            this.splitContainer17.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer17)).EndInit();
            this.splitContainer17.ResumeLayout(false);
            this.gb_RotationMode.ResumeLayout(false);
            this.gb_RotationMode.PerformLayout();
            this.gb_RotationVision.ResumeLayout(false);
            this.gb_RotationVision.PerformLayout();
            this.gb_Rotation.ResumeLayout(false);
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).EndInit();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_C_VisionTool;
        private System.Windows.Forms.TabPage tab_EditVision;
        private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
        private System.Windows.Forms.TabPage tab_VisionDistortion;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplayDistortion;
        private System.Windows.Forms.TabPage tab_VisionLinear;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplayLinear;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.GroupBox gb_LinearVision;
        private System.Windows.Forms.GroupBox gb_LinearMode;
        private System.Windows.Forms.GroupBox gb_Linear;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dataGridViewLinear;
        private System.Windows.Forms.DataGridViewTextBoxColumn UncalibratedPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn UncalibratedPointY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawCalibratedPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawCalibratedPointY;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_VisionRotation;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplayRotation;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private System.Windows.Forms.SplitContainer splitContainer13;
        private System.Windows.Forms.GroupBox gb_RotationVision;
        private System.Windows.Forms.GroupBox gb_RotationMode;
        private System.Windows.Forms.GroupBox gb_Rotation;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.DataGridView dataGridViewRotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.Panel panel2;
        private Button btnDistortion;
        private Button btnChooseDistortionImage;
        private Button btnDistortionAcq;
        private Button btn_Auto_Linear;
        private Button btn_Save_Linear;
        private Button btn_Linear;
        private Button btn_AddMark_Linear;
        private Button btn_Run_Linear;
        private Button btn_Clear_Linear;
        private Button btn_Acq_Linear;
        private TextBox tb_msg_Linear;
        private Label lb_RMS;
        private Label lb_Y_Axis;
        private Label lb_X_Axis;
        private TextBox tb_RMS_Linear;
        private TextBox tb_Y_Linear;
        private TextBox tb_X_Linear;
        private Button btn_OpenImage_Rotation;
        private Button btn_Save_Rotation;
        private Button btn_Rotation;
        private Button btn_AddMark_Rotation;
        private Button btn_Run_Rotation;
        private Button btn_Clear_Rotation;
        private Button btn_Acq_Rotation;
        private Button btn_Auto_Rotation;
        private ComboBox cbo_Nozzle_Rotation;
        private TextBox tB_RMS_Rotation;
        private TextBox tB_Y_Rotation;
        private TextBox tB_X_Rotation;
        private Label uiLabel4;
        private Label uiLabel3;
        private Label uiLabel2;
        private Label uiLabel1;
        private TextBox tb_msg_Rotation;
        private System.Windows.Forms.SplitContainer splitContainer14;
        private System.Windows.Forms.SplitContainer splitContainer15;
        private System.Windows.Forms.SplitContainer splitContainer16;
        private System.Windows.Forms.SplitContainer splitContainer17;
        private System.Windows.Forms.RadioButton rdo_Manual_Linear;
        private System.Windows.Forms.RadioButton rdo_Auto_Linear;
        private System.Windows.Forms.RadioButton rdo_Live_Linear;
        private System.Windows.Forms.RadioButton rdo_Snap_Linear;
        private System.Windows.Forms.RadioButton rdo_Manual_Rotation;
        private System.Windows.Forms.RadioButton rdo_Auto_Rotation;
        private System.Windows.Forms.RadioButton rdo_Live_Rotation;
        private System.Windows.Forms.RadioButton rdo_Snap_Rotation;
        private System.Windows.Forms.GroupBox gb_LinearCon;
        private System.Windows.Forms.RadioButton rdo_Robot_Con_L;
        private System.Windows.Forms.GroupBox gb_RotationCon;
        private System.Windows.Forms.RadioButton rdo_ROBOT_Con_R;
        private RadioButton rdo_Laser1_Con_L;
        private RadioButton rdo_Laser_Con_L;
        private RadioButton rdo_Robot1_Con_L;
        private RadioButton rdo_ROBOT2_Con_R;
        private RadioButton rdo_Verificate_Linear;
        private Button btn_test;
        private TextBox tb_Step;
        private Label lb_Step;
    }
}