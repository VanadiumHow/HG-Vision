using System.Windows.Forms;

namespace HG_Vision
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
            this.splitContainer18 = new System.Windows.Forms.SplitContainer();
            this.groupBoxOperation = new System.Windows.Forms.GroupBox();
            this.uiPanelOperation = new Sunny.UI.UITableLayoutPanel();
            this.btn_Di_Start = new System.Windows.Forms.Button();
            this.btn_Di_Acq = new System.Windows.Forms.Button();
            this.btn_Di_FileImage = new System.Windows.Forms.Button();
            this.lb_Di_Enable = new System.Windows.Forms.Label();
            this.cbb_Di_Enable = new System.Windows.Forms.ComboBox();
            this.tab_VisionLinear = new System.Windows.Forms.TabPage();
            this.splitContainer_Li_1 = new System.Windows.Forms.SplitContainer();
            this.cogRecordDisplayLinear = new Cognex.VisionPro.CogRecordDisplay();
            this.splitContainer_Li_2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Li_5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Li_6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Li_7 = new System.Windows.Forms.SplitContainer();
            this.gb_LinearCon = new System.Windows.Forms.GroupBox();
            this.rdo_Li_Laser2 = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Laser1 = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Robot2 = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Robot1 = new System.Windows.Forms.RadioButton();
            this.splitContainer_Li_8 = new System.Windows.Forms.SplitContainer();
            this.gb_LinearMode = new System.Windows.Forms.GroupBox();
            this.rdo_Li_Verificate = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Manual = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Auto = new System.Windows.Forms.RadioButton();
            this.gb_LinearVision = new System.Windows.Forms.GroupBox();
            this.rdo_Li_Live = new System.Windows.Forms.RadioButton();
            this.rdo_Li_Snap = new System.Windows.Forms.RadioButton();
            this.btn_Li_Auto = new System.Windows.Forms.Button();
            this.gb_Li_operation = new System.Windows.Forms.GroupBox();
            this.btn_Li_test = new System.Windows.Forms.Button();
            this.btn_Li_Save = new System.Windows.Forms.Button();
            this.btn_Li_Start = new System.Windows.Forms.Button();
            this.btn_Li_AddMark = new System.Windows.Forms.Button();
            this.btn_Li_Run = new System.Windows.Forms.Button();
            this.btn_Li_Clear = new System.Windows.Forms.Button();
            this.btn_Li_Acq = new System.Windows.Forms.Button();
            this.splitContainer_Li_3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewLinear = new System.Windows.Forms.DataGridView();
            this.UncalibratedPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UncalibratedPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawCalibratedPointX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawCalibratedPointY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer_Li_4 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Li_Step = new System.Windows.Forms.TextBox();
            this.lb_Li_Step = new System.Windows.Forms.Label();
            this.tb_Li_RMS = new System.Windows.Forms.TextBox();
            this.tb_Li_Y = new System.Windows.Forms.TextBox();
            this.tb_Li_X = new System.Windows.Forms.TextBox();
            this.lb_Li_RMS = new System.Windows.Forms.Label();
            this.lb_Li_Y = new System.Windows.Forms.Label();
            this.lb_Li_X = new System.Windows.Forms.Label();
            this.tb_Li_msg = new System.Windows.Forms.TextBox();
            this.tab_VisionRotation = new System.Windows.Forms.TabPage();
            this.splitContainer_Ro_1 = new System.Windows.Forms.SplitContainer();
            this.cogRecordDisplayRotation = new Cognex.VisionPro.CogRecordDisplay();
            this.splitContainer_Ro_2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Ro_5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Ro_6 = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Ro_7 = new System.Windows.Forms.SplitContainer();
            this.gb_RotationCon = new System.Windows.Forms.GroupBox();
            this.rdo_Ro_Robot2 = new System.Windows.Forms.RadioButton();
            this.rdo_Ro_Robot1 = new System.Windows.Forms.RadioButton();
            this.splitContainer_Ro_8 = new System.Windows.Forms.SplitContainer();
            this.gb_RotationMode = new System.Windows.Forms.GroupBox();
            this.rdo_Ro_Manual = new System.Windows.Forms.RadioButton();
            this.rdo_Ro_Auto = new System.Windows.Forms.RadioButton();
            this.gb_RotationVision = new System.Windows.Forms.GroupBox();
            this.rdo_Ro_Live = new System.Windows.Forms.RadioButton();
            this.rdo_Ro_Snap = new System.Windows.Forms.RadioButton();
            this.btn_Ro_Auto = new System.Windows.Forms.Button();
            this.gb_Rotation = new System.Windows.Forms.GroupBox();
            this.btn_Ro_FileImage = new System.Windows.Forms.Button();
            this.btn_Ro_Save = new System.Windows.Forms.Button();
            this.btn_Ro_Start = new System.Windows.Forms.Button();
            this.btn_Ro_AddMark = new System.Windows.Forms.Button();
            this.btn_Ro_Run = new System.Windows.Forms.Button();
            this.btn_Ro_Clear = new System.Windows.Forms.Button();
            this.btn_Ro_Acq = new System.Windows.Forms.Button();
            this.splitContainer_Ro_3 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewRotation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer_Ro_4 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Ro_Num = new System.Windows.Forms.Label();
            this.lb_Ro_RMS = new System.Windows.Forms.Label();
            this.lb_Ro_Y = new System.Windows.Forms.Label();
            this.lb_Ro_X = new System.Windows.Forms.Label();
            this.cbb_Ro_Nozzle = new System.Windows.Forms.ComboBox();
            this.tb_Ro_RMS = new System.Windows.Forms.TextBox();
            this.tb_Ro_Y = new System.Windows.Forms.TextBox();
            this.tb_Ro_X = new System.Windows.Forms.TextBox();
            this.tb_msg_Rotation = new System.Windows.Forms.TextBox();
            this.tab_C_VisionTool.SuspendLayout();
            this.tab_EditVision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
            this.tab_VisionDistortion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayDistortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).BeginInit();
            this.splitContainer18.Panel1.SuspendLayout();
            this.splitContainer18.SuspendLayout();
            this.groupBoxOperation.SuspendLayout();
            this.uiPanelOperation.SuspendLayout();
            this.tab_VisionLinear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_1)).BeginInit();
            this.splitContainer_Li_1.Panel1.SuspendLayout();
            this.splitContainer_Li_1.Panel2.SuspendLayout();
            this.splitContainer_Li_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_2)).BeginInit();
            this.splitContainer_Li_2.Panel1.SuspendLayout();
            this.splitContainer_Li_2.Panel2.SuspendLayout();
            this.splitContainer_Li_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_5)).BeginInit();
            this.splitContainer_Li_5.Panel1.SuspendLayout();
            this.splitContainer_Li_5.Panel2.SuspendLayout();
            this.splitContainer_Li_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_6)).BeginInit();
            this.splitContainer_Li_6.Panel1.SuspendLayout();
            this.splitContainer_Li_6.Panel2.SuspendLayout();
            this.splitContainer_Li_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_7)).BeginInit();
            this.splitContainer_Li_7.Panel1.SuspendLayout();
            this.splitContainer_Li_7.Panel2.SuspendLayout();
            this.splitContainer_Li_7.SuspendLayout();
            this.gb_LinearCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_8)).BeginInit();
            this.splitContainer_Li_8.Panel1.SuspendLayout();
            this.splitContainer_Li_8.Panel2.SuspendLayout();
            this.splitContainer_Li_8.SuspendLayout();
            this.gb_LinearMode.SuspendLayout();
            this.gb_LinearVision.SuspendLayout();
            this.gb_Li_operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_3)).BeginInit();
            this.splitContainer_Li_3.Panel1.SuspendLayout();
            this.splitContainer_Li_3.Panel2.SuspendLayout();
            this.splitContainer_Li_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_4)).BeginInit();
            this.splitContainer_Li_4.Panel1.SuspendLayout();
            this.splitContainer_Li_4.Panel2.SuspendLayout();
            this.splitContainer_Li_4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_VisionRotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_1)).BeginInit();
            this.splitContainer_Ro_1.Panel1.SuspendLayout();
            this.splitContainer_Ro_1.Panel2.SuspendLayout();
            this.splitContainer_Ro_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_2)).BeginInit();
            this.splitContainer_Ro_2.Panel1.SuspendLayout();
            this.splitContainer_Ro_2.Panel2.SuspendLayout();
            this.splitContainer_Ro_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_5)).BeginInit();
            this.splitContainer_Ro_5.Panel1.SuspendLayout();
            this.splitContainer_Ro_5.Panel2.SuspendLayout();
            this.splitContainer_Ro_5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_6)).BeginInit();
            this.splitContainer_Ro_6.Panel1.SuspendLayout();
            this.splitContainer_Ro_6.Panel2.SuspendLayout();
            this.splitContainer_Ro_6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_7)).BeginInit();
            this.splitContainer_Ro_7.Panel1.SuspendLayout();
            this.splitContainer_Ro_7.Panel2.SuspendLayout();
            this.splitContainer_Ro_7.SuspendLayout();
            this.gb_RotationCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_8)).BeginInit();
            this.splitContainer_Ro_8.Panel1.SuspendLayout();
            this.splitContainer_Ro_8.Panel2.SuspendLayout();
            this.splitContainer_Ro_8.SuspendLayout();
            this.gb_RotationMode.SuspendLayout();
            this.gb_RotationVision.SuspendLayout();
            this.gb_Rotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_3)).BeginInit();
            this.splitContainer_Ro_3.Panel1.SuspendLayout();
            this.splitContainer_Ro_3.Panel2.SuspendLayout();
            this.splitContainer_Ro_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_4)).BeginInit();
            this.splitContainer_Ro_4.Panel1.SuspendLayout();
            this.splitContainer_Ro_4.Panel2.SuspendLayout();
            this.splitContainer_Ro_4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_C_VisionTool
            // 
            this.tab_C_VisionTool.AllowDrop = true;
            this.tab_C_VisionTool.Controls.Add(this.tab_EditVision);
            this.tab_C_VisionTool.Controls.Add(this.tab_VisionDistortion);
            this.tab_C_VisionTool.Controls.Add(this.tab_VisionLinear);
            //this.tab_C_VisionTool.Controls.Add(this.tab_VisionRotation);
            this.tab_C_VisionTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_C_VisionTool.Location = new System.Drawing.Point(0, 0);
            this.tab_C_VisionTool.Name = "tab_C_VisionTool";
            this.tab_C_VisionTool.SelectedIndex = 0;
            this.tab_C_VisionTool.Size = new System.Drawing.Size(1284, 761);
            this.tab_C_VisionTool.TabIndex = 6;
            this.tab_C_VisionTool.SelectedIndexChanged += new System.EventHandler(this.tab_C_VisionTool_SelectedIndexChanged);
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
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.cogRecordDisplayDistortion);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer18);
            this.splitContainer7.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer7.SplitterDistance = 804;
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
            this.cogRecordDisplayDistortion.Size = new System.Drawing.Size(804, 727);
            this.cogRecordDisplayDistortion.TabIndex = 1;
            // 
            // splitContainer18
            // 
            this.splitContainer18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer18.Location = new System.Drawing.Point(0, 0);
            this.splitContainer18.Name = "splitContainer18";
            this.splitContainer18.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer18.Panel1
            // 
            this.splitContainer18.Panel1.Controls.Add(this.groupBoxOperation);
            this.splitContainer18.Size = new System.Drawing.Size(468, 727);
            this.splitContainer18.SplitterDistance = 111;
            this.splitContainer18.TabIndex = 71;
            // 
            // groupBoxOperation
            // 
            this.groupBoxOperation.Controls.Add(this.uiPanelOperation);
            this.groupBoxOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOperation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOperation.Name = "groupBoxOperation";
            this.groupBoxOperation.Size = new System.Drawing.Size(468, 111);
            this.groupBoxOperation.TabIndex = 0;
            this.groupBoxOperation.TabStop = false;
            this.groupBoxOperation.Text = "操作";
            // 
            // uiPanelOperation
            // 
            this.uiPanelOperation.ColumnCount = 3;
            this.uiPanelOperation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.uiPanelOperation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.uiPanelOperation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.uiPanelOperation.Controls.Add(this.btn_Di_Start, 2, 0);
            this.uiPanelOperation.Controls.Add(this.btn_Di_Acq, 0, 0);
            this.uiPanelOperation.Controls.Add(this.btn_Di_FileImage, 1, 0);
            this.uiPanelOperation.Controls.Add(this.lb_Di_Enable, 0, 1);
            this.uiPanelOperation.Controls.Add(this.cbb_Di_Enable, 1, 1);
            this.uiPanelOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelOperation.Location = new System.Drawing.Point(3, 25);
            this.uiPanelOperation.Name = "uiPanelOperation";
            this.uiPanelOperation.RowCount = 2;
            this.uiPanelOperation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiPanelOperation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiPanelOperation.Size = new System.Drawing.Size(462, 83);
            this.uiPanelOperation.TabIndex = 71;
            this.uiPanelOperation.TagString = null;
            // 
            // btn_Di_Start
            // 
            this.btn_Di_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Di_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Di_Start.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Di_Start.Location = new System.Drawing.Point(309, 3);
            this.btn_Di_Start.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Di_Start.Name = "btn_Di_Start";
            this.btn_Di_Start.Size = new System.Drawing.Size(150, 35);
            this.btn_Di_Start.TabIndex = 69;
            this.btn_Di_Start.Text = "畸变校正";
            this.btn_Di_Start.Click += new System.EventHandler(this.btn_Di_Start_Click);
            // 
            // btn_Di_Acq
            // 
            this.btn_Di_Acq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Di_Acq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Di_Acq.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Di_Acq.Location = new System.Drawing.Point(3, 3);
            this.btn_Di_Acq.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Di_Acq.Name = "btn_Di_Acq";
            this.btn_Di_Acq.Size = new System.Drawing.Size(147, 35);
            this.btn_Di_Acq.TabIndex = 67;
            this.btn_Di_Acq.Text = "单帧取图";
            this.btn_Di_Acq.Click += new System.EventHandler(this.btn_Di_Acq_Click);
            // 
            // btn_Di_FileImage
            // 
            this.btn_Di_FileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Di_FileImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Di_FileImage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Di_FileImage.ForeColor = System.Drawing.Color.Black;
            this.btn_Di_FileImage.Location = new System.Drawing.Point(156, 3);
            this.btn_Di_FileImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Di_FileImage.Name = "btn_Di_FileImage";
            this.btn_Di_FileImage.Size = new System.Drawing.Size(147, 35);
            this.btn_Di_FileImage.TabIndex = 68;
            this.btn_Di_FileImage.Text = "文件取图";
            this.btn_Di_FileImage.Click += new System.EventHandler(this.btn_Di_FileImage_Click);
            // 
            // lb_Di_Enable
            // 
            this.lb_Di_Enable.AutoSize = true;
            this.lb_Di_Enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Di_Enable.Location = new System.Drawing.Point(3, 41);
            this.lb_Di_Enable.Name = "lb_Di_Enable";
            this.lb_Di_Enable.Size = new System.Drawing.Size(147, 42);
            this.lb_Di_Enable.TabIndex = 70;
            this.lb_Di_Enable.Text = "是否启用畸变校正:";
            this.lb_Di_Enable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_Di_Enable
            // 
            this.cbb_Di_Enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_Di_Enable.FormattingEnabled = true;
            this.cbb_Di_Enable.Items.AddRange(new object[] {
            "启用",
            "禁用"});
            this.cbb_Di_Enable.Location = new System.Drawing.Point(156, 48);
            this.cbb_Di_Enable.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cbb_Di_Enable.MaxDropDownItems = 2;
            this.cbb_Di_Enable.Name = "cbb_Di_Enable";
            this.cbb_Di_Enable.Size = new System.Drawing.Size(147, 29);
            this.cbb_Di_Enable.TabIndex = 71;
            // 
            // tab_VisionLinear
            // 
            this.tab_VisionLinear.Controls.Add(this.splitContainer_Li_1);
            this.tab_VisionLinear.Location = new System.Drawing.Point(4, 30);
            this.tab_VisionLinear.Name = "tab_VisionLinear";
            this.tab_VisionLinear.Size = new System.Drawing.Size(1276, 727);
            this.tab_VisionLinear.TabIndex = 1;
            this.tab_VisionLinear.Text = "九点标定";
            this.tab_VisionLinear.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Li_1
            // 
            this.splitContainer_Li_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Li_1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_1.Name = "splitContainer_Li_1";
            // 
            // splitContainer_Li_1.Panel1
            // 
            this.splitContainer_Li_1.Panel1.Controls.Add(this.cogRecordDisplayLinear);
            // 
            // splitContainer_Li_1.Panel2
            // 
            this.splitContainer_Li_1.Panel2.Controls.Add(this.splitContainer_Li_2);
            this.splitContainer_Li_1.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer_Li_1.SplitterDistance = 771;
            this.splitContainer_Li_1.TabIndex = 23;
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
            this.cogRecordDisplayLinear.Size = new System.Drawing.Size(771, 727);
            this.cogRecordDisplayLinear.TabIndex = 0;
            // 
            // splitContainer_Li_2
            // 
            this.splitContainer_Li_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_2.Name = "splitContainer_Li_2";
            // 
            // splitContainer_Li_2.Panel1
            // 
            this.splitContainer_Li_2.Panel1.Controls.Add(this.splitContainer_Li_5);
            // 
            // splitContainer_Li_2.Panel2
            // 
            this.splitContainer_Li_2.Panel2.Controls.Add(this.splitContainer_Li_3);
            this.splitContainer_Li_2.Size = new System.Drawing.Size(501, 727);
            this.splitContainer_Li_2.SplitterDistance = 100;
            this.splitContainer_Li_2.TabIndex = 23;
            // 
            // splitContainer_Li_5
            // 
            this.splitContainer_Li_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_5.Name = "splitContainer_Li_5";
            this.splitContainer_Li_5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_5.Panel1
            // 
            this.splitContainer_Li_5.Panel1.Controls.Add(this.splitContainer_Li_6);
            // 
            // splitContainer_Li_5.Panel2
            // 
            this.splitContainer_Li_5.Panel2.Controls.Add(this.gb_Li_operation);
            this.splitContainer_Li_5.Size = new System.Drawing.Size(100, 727);
            this.splitContainer_Li_5.SplitterDistance = 448;
            this.splitContainer_Li_5.TabIndex = 25;
            // 
            // splitContainer_Li_6
            // 
            this.splitContainer_Li_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_6.Name = "splitContainer_Li_6";
            this.splitContainer_Li_6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_6.Panel1
            // 
            this.splitContainer_Li_6.Panel1.Controls.Add(this.splitContainer_Li_7);
            // 
            // splitContainer_Li_6.Panel2
            // 
            this.splitContainer_Li_6.Panel2.Controls.Add(this.btn_Li_Auto);
            this.splitContainer_Li_6.Size = new System.Drawing.Size(100, 448);
            this.splitContainer_Li_6.SplitterDistance = 394;
            this.splitContainer_Li_6.TabIndex = 0;
            // 
            // splitContainer_Li_7
            // 
            this.splitContainer_Li_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_7.Name = "splitContainer_Li_7";
            this.splitContainer_Li_7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_7.Panel1
            // 
            this.splitContainer_Li_7.Panel1.Controls.Add(this.gb_LinearCon);
            // 
            // splitContainer_Li_7.Panel2
            // 
            this.splitContainer_Li_7.Panel2.Controls.Add(this.splitContainer_Li_8);
            this.splitContainer_Li_7.Size = new System.Drawing.Size(100, 394);
            this.splitContainer_Li_7.SplitterDistance = 161;
            this.splitContainer_Li_7.TabIndex = 0;
            // 
            // gb_LinearCon
            // 
            this.gb_LinearCon.Controls.Add(this.rdo_Li_Laser2);
            this.gb_LinearCon.Controls.Add(this.rdo_Li_Laser1);
            this.gb_LinearCon.Controls.Add(this.rdo_Li_Robot2);
            this.gb_LinearCon.Controls.Add(this.rdo_Li_Robot1);
            this.gb_LinearCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearCon.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearCon.Name = "gb_LinearCon";
            this.gb_LinearCon.Size = new System.Drawing.Size(100, 161);
            this.gb_LinearCon.TabIndex = 55;
            this.gb_LinearCon.TabStop = false;
            this.gb_LinearCon.Text = "连接对象";
            // 
            // rdo_Li_Laser2
            // 
            this.rdo_Li_Laser2.AutoSize = true;
            this.rdo_Li_Laser2.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Laser2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Laser2.Location = new System.Drawing.Point(13, 112);
            this.rdo_Li_Laser2.Name = "rdo_Li_Laser2";
            this.rdo_Li_Laser2.Size = new System.Drawing.Size(76, 25);
            this.rdo_Li_Laser2.TabIndex = 31;
            this.rdo_Li_Laser2.Text = "Laser2";
            this.rdo_Li_Laser2.UseVisualStyleBackColor = false;
            this.rdo_Li_Laser2.CheckedChanged += new System.EventHandler(this.RedioColor);
            this.rdo_Li_Laser2.Click += new System.EventHandler(this.rdo_Li_Laser2_Click);
            // 
            // rdo_Li_Laser1
            // 
            this.rdo_Li_Laser1.AutoSize = true;
            this.rdo_Li_Laser1.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Laser1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Laser1.Location = new System.Drawing.Point(13, 84);
            this.rdo_Li_Laser1.Name = "rdo_Li_Laser1";
            this.rdo_Li_Laser1.Size = new System.Drawing.Size(76, 25);
            this.rdo_Li_Laser1.TabIndex = 30;
            this.rdo_Li_Laser1.Text = "Laser1";
            this.rdo_Li_Laser1.UseVisualStyleBackColor = false;
            this.rdo_Li_Laser1.CheckedChanged += new System.EventHandler(this.RedioColor);
            this.rdo_Li_Laser1.Click += new System.EventHandler(this.rdo_Li_Laser1_Click);
            // 
            // rdo_Li_Robot2
            // 
            this.rdo_Li_Robot2.AutoSize = true;
            this.rdo_Li_Robot2.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Robot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Robot2.Location = new System.Drawing.Point(13, 56);
            this.rdo_Li_Robot2.Name = "rdo_Li_Robot2";
            this.rdo_Li_Robot2.Size = new System.Drawing.Size(83, 25);
            this.rdo_Li_Robot2.TabIndex = 29;
            this.rdo_Li_Robot2.Text = "Robot2";
            this.rdo_Li_Robot2.UseVisualStyleBackColor = false;
            this.rdo_Li_Robot2.CheckedChanged += new System.EventHandler(this.RedioColor);
            this.rdo_Li_Robot2.Click += new System.EventHandler(this.rdo_Li_Robot2_Click);
            // 
            // rdo_Li_Robot1
            // 
            this.rdo_Li_Robot1.AutoSize = true;
            this.rdo_Li_Robot1.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Robot1.Checked = true;
            this.rdo_Li_Robot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Robot1.Location = new System.Drawing.Point(13, 28);
            this.rdo_Li_Robot1.Name = "rdo_Li_Robot1";
            this.rdo_Li_Robot1.Size = new System.Drawing.Size(83, 25);
            this.rdo_Li_Robot1.TabIndex = 28;
            this.rdo_Li_Robot1.TabStop = true;
            this.rdo_Li_Robot1.Text = "Robot1";
            this.rdo_Li_Robot1.UseVisualStyleBackColor = false;
            this.rdo_Li_Robot1.CheckedChanged += new System.EventHandler(this.RedioColor);
            this.rdo_Li_Robot1.Click += new System.EventHandler(this.rdo_Li_Robot1_Click);
            // 
            // splitContainer_Li_8
            // 
            this.splitContainer_Li_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_8.Name = "splitContainer_Li_8";
            this.splitContainer_Li_8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_8.Panel1
            // 
            this.splitContainer_Li_8.Panel1.Controls.Add(this.gb_LinearMode);
            // 
            // splitContainer_Li_8.Panel2
            // 
            this.splitContainer_Li_8.Panel2.Controls.Add(this.gb_LinearVision);
            this.splitContainer_Li_8.Size = new System.Drawing.Size(100, 229);
            this.splitContainer_Li_8.SplitterDistance = 120;
            this.splitContainer_Li_8.TabIndex = 0;
            // 
            // gb_LinearMode
            // 
            this.gb_LinearMode.Controls.Add(this.rdo_Li_Verificate);
            this.gb_LinearMode.Controls.Add(this.rdo_Li_Manual);
            this.gb_LinearMode.Controls.Add(this.rdo_Li_Auto);
            this.gb_LinearMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearMode.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearMode.Name = "gb_LinearMode";
            this.gb_LinearMode.Size = new System.Drawing.Size(100, 120);
            this.gb_LinearMode.TabIndex = 24;
            this.gb_LinearMode.TabStop = false;
            this.gb_LinearMode.Text = "标定模式";
            // 
            // rdo_Li_Verificate
            // 
            this.rdo_Li_Verificate.AutoSize = true;
            this.rdo_Li_Verificate.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Verificate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Verificate.Location = new System.Drawing.Point(13, 84);
            this.rdo_Li_Verificate.Name = "rdo_Li_Verificate";
            this.rdo_Li_Verificate.Size = new System.Drawing.Size(60, 25);
            this.rdo_Li_Verificate.TabIndex = 27;
            this.rdo_Li_Verificate.Text = "验证";
            this.rdo_Li_Verificate.UseVisualStyleBackColor = false;
            this.rdo_Li_Verificate.Click += new System.EventHandler(this.rdo_Li_Verificate_Click);
            // 
            // rdo_Li_Manual
            // 
            this.rdo_Li_Manual.AutoSize = true;
            this.rdo_Li_Manual.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Li_Manual.Checked = true;
            this.rdo_Li_Manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Manual.Location = new System.Drawing.Point(13, 28);
            this.rdo_Li_Manual.Name = "rdo_Li_Manual";
            this.rdo_Li_Manual.Size = new System.Drawing.Size(60, 25);
            this.rdo_Li_Manual.TabIndex = 26;
            this.rdo_Li_Manual.TabStop = true;
            this.rdo_Li_Manual.Text = "手动";
            this.rdo_Li_Manual.UseVisualStyleBackColor = false;
            this.rdo_Li_Manual.Click += new System.EventHandler(this.rdo_Li_Manual_Click);
            // 
            // rdo_Li_Auto
            // 
            this.rdo_Li_Auto.AutoSize = true;
            this.rdo_Li_Auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Auto.Location = new System.Drawing.Point(13, 56);
            this.rdo_Li_Auto.Name = "rdo_Li_Auto";
            this.rdo_Li_Auto.Size = new System.Drawing.Size(60, 25);
            this.rdo_Li_Auto.TabIndex = 25;
            this.rdo_Li_Auto.Text = "自动";
            this.rdo_Li_Auto.UseVisualStyleBackColor = true;
            this.rdo_Li_Auto.Click += new System.EventHandler(this.rdo_Li_Auto_Click);
            // 
            // gb_LinearVision
            // 
            this.gb_LinearVision.Controls.Add(this.rdo_Li_Live);
            this.gb_LinearVision.Controls.Add(this.rdo_Li_Snap);
            this.gb_LinearVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_LinearVision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_LinearVision.Location = new System.Drawing.Point(0, 0);
            this.gb_LinearVision.Name = "gb_LinearVision";
            this.gb_LinearVision.Size = new System.Drawing.Size(100, 105);
            this.gb_LinearVision.TabIndex = 22;
            this.gb_LinearVision.TabStop = false;
            this.gb_LinearVision.Text = "图像模式";
            // 
            // rdo_Li_Live
            // 
            this.rdo_Li_Live.AutoSize = true;
            this.rdo_Li_Live.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Live.Location = new System.Drawing.Point(13, 56);
            this.rdo_Li_Live.Name = "rdo_Li_Live";
            this.rdo_Li_Live.Size = new System.Drawing.Size(60, 25);
            this.rdo_Li_Live.TabIndex = 26;
            this.rdo_Li_Live.Text = "实时";
            this.rdo_Li_Live.UseVisualStyleBackColor = true;
            this.rdo_Li_Live.CheckedChanged += new System.EventHandler(this.rdo_Li_Live_CheckedChanged);
            // 
            // rdo_Li_Snap
            // 
            this.rdo_Li_Snap.AutoSize = true;
            this.rdo_Li_Snap.Checked = true;
            this.rdo_Li_Snap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Li_Snap.Location = new System.Drawing.Point(13, 28);
            this.rdo_Li_Snap.Name = "rdo_Li_Snap";
            this.rdo_Li_Snap.Size = new System.Drawing.Size(60, 25);
            this.rdo_Li_Snap.TabIndex = 25;
            this.rdo_Li_Snap.TabStop = true;
            this.rdo_Li_Snap.Text = "单帧";
            this.rdo_Li_Snap.UseVisualStyleBackColor = true;
            this.rdo_Li_Snap.CheckedChanged += new System.EventHandler(this.rdo_Li_Snap_CheckedChanged);
            // 
            // btn_Li_Auto
            // 
            this.btn_Li_Auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Auto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Li_Auto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Li_Auto.Location = new System.Drawing.Point(0, 0);
            this.btn_Li_Auto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Auto.Name = "btn_Li_Auto";
            this.btn_Li_Auto.Size = new System.Drawing.Size(100, 50);
            this.btn_Li_Auto.TabIndex = 67;
            this.btn_Li_Auto.Text = "自动标定";
            this.btn_Li_Auto.Click += new System.EventHandler(this.btn_Li_Auto_Click);
            // 
            // gb_Li_operation
            // 
            this.gb_Li_operation.Controls.Add(this.btn_Li_test);
            this.gb_Li_operation.Controls.Add(this.btn_Li_Save);
            this.gb_Li_operation.Controls.Add(this.btn_Li_Start);
            this.gb_Li_operation.Controls.Add(this.btn_Li_AddMark);
            this.gb_Li_operation.Controls.Add(this.btn_Li_Run);
            this.gb_Li_operation.Controls.Add(this.btn_Li_Clear);
            this.gb_Li_operation.Controls.Add(this.btn_Li_Acq);
            this.gb_Li_operation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Li_operation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_Li_operation.Location = new System.Drawing.Point(0, 0);
            this.gb_Li_operation.Name = "gb_Li_operation";
            this.gb_Li_operation.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Li_operation.Size = new System.Drawing.Size(100, 275);
            this.gb_Li_operation.TabIndex = 22;
            this.gb_Li_operation.TabStop = false;
            // 
            // btn_Li_test
            // 
            this.btn_Li_test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_test.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_test.Location = new System.Drawing.Point(5, 229);
            this.btn_Li_test.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_test.Name = "btn_Li_test";
            this.btn_Li_test.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_test.TabIndex = 73;
            this.btn_Li_test.Text = "测试按钮";
            this.btn_Li_test.Visible = false;
            this.btn_Li_test.Click += new System.EventHandler(this.btn_Li_test_Click);
            // 
            // btn_Li_Save
            // 
            this.btn_Li_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_Save.Location = new System.Drawing.Point(5, 197);
            this.btn_Li_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Save.Name = "btn_Li_Save";
            this.btn_Li_Save.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_Save.TabIndex = 72;
            this.btn_Li_Save.Text = "保存结果";
            this.btn_Li_Save.Click += new System.EventHandler(this.btn_Li_Save_Click);
            // 
            // btn_Li_Start
            // 
            this.btn_Li_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Start.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_Start.Location = new System.Drawing.Point(5, 163);
            this.btn_Li_Start.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Start.Name = "btn_Li_Start";
            this.btn_Li_Start.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_Start.TabIndex = 71;
            this.btn_Li_Start.Text = "开始标定";
            this.btn_Li_Start.Click += new System.EventHandler(this.btn_Li_Start_Click);
            // 
            // btn_Li_AddMark
            // 
            this.btn_Li_AddMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_AddMark.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_AddMark.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_AddMark.Location = new System.Drawing.Point(5, 129);
            this.btn_Li_AddMark.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_AddMark.Name = "btn_Li_AddMark";
            this.btn_Li_AddMark.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_AddMark.TabIndex = 70;
            this.btn_Li_AddMark.Text = "添加Mark";
            this.btn_Li_AddMark.Click += new System.EventHandler(this.btn_Li_AddMark_Click);
            // 
            // btn_Li_Run
            // 
            this.btn_Li_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Run.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_Run.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_Run.Location = new System.Drawing.Point(5, 95);
            this.btn_Li_Run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Run.Name = "btn_Li_Run";
            this.btn_Li_Run.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_Run.TabIndex = 69;
            this.btn_Li_Run.Text = "运行程序";
            this.btn_Li_Run.Click += new System.EventHandler(this.btn_Li_Run_Click);
            // 
            // btn_Li_Clear
            // 
            this.btn_Li_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Clear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_Clear.Location = new System.Drawing.Point(5, 61);
            this.btn_Li_Clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Clear.Name = "btn_Li_Clear";
            this.btn_Li_Clear.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_Clear.TabIndex = 68;
            this.btn_Li_Clear.Text = "重新标定";
            this.btn_Li_Clear.Click += new System.EventHandler(this.btn_Li_Clear_Click);
            // 
            // btn_Li_Acq
            // 
            this.btn_Li_Acq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Li_Acq.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Li_Acq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Li_Acq.Location = new System.Drawing.Point(5, 27);
            this.btn_Li_Acq.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Li_Acq.Name = "btn_Li_Acq";
            this.btn_Li_Acq.Size = new System.Drawing.Size(91, 26);
            this.btn_Li_Acq.TabIndex = 67;
            this.btn_Li_Acq.Text = "采集图像";
            this.btn_Li_Acq.Click += new System.EventHandler(this.btn_Li_Acq_Click);
            // 
            // splitContainer_Li_3
            // 
            this.splitContainer_Li_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_3.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer_Li_3.Name = "splitContainer_Li_3";
            this.splitContainer_Li_3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_3.Panel1
            // 
            this.splitContainer_Li_3.Panel1.Controls.Add(this.dataGridViewLinear);
            // 
            // splitContainer_Li_3.Panel2
            // 
            this.splitContainer_Li_3.Panel2.Controls.Add(this.splitContainer_Li_4);
            this.splitContainer_Li_3.Size = new System.Drawing.Size(397, 727);
            this.splitContainer_Li_3.SplitterDistance = 393;
            this.splitContainer_Li_3.TabIndex = 0;
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
            this.dataGridViewLinear.Size = new System.Drawing.Size(397, 393);
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
            // splitContainer_Li_4
            // 
            this.splitContainer_Li_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Li_4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Li_4.Name = "splitContainer_Li_4";
            this.splitContainer_Li_4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Li_4.Panel1
            // 
            this.splitContainer_Li_4.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer_Li_4.Panel2
            // 
            this.splitContainer_Li_4.Panel2.Controls.Add(this.tb_Li_msg);
            this.splitContainer_Li_4.Size = new System.Drawing.Size(397, 330);
            this.splitContainer_Li_4.SplitterDistance = 62;
            this.splitContainer_Li_4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_Li_Step);
            this.panel1.Controls.Add(this.lb_Li_Step);
            this.panel1.Controls.Add(this.tb_Li_RMS);
            this.panel1.Controls.Add(this.tb_Li_Y);
            this.panel1.Controls.Add(this.tb_Li_X);
            this.panel1.Controls.Add(this.lb_Li_RMS);
            this.panel1.Controls.Add(this.lb_Li_Y);
            this.panel1.Controls.Add(this.lb_Li_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 62);
            this.panel1.TabIndex = 0;
            // 
            // tb_Li_Step
            // 
            this.tb_Li_Step.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Li_Step.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Li_Step.Location = new System.Drawing.Point(291, 28);
            this.tb_Li_Step.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Li_Step.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Li_Step.Name = "tb_Li_Step";
            this.tb_Li_Step.Size = new System.Drawing.Size(84, 29);
            this.tb_Li_Step.TabIndex = 42;
            // 
            // lb_Li_Step
            // 
            this.lb_Li_Step.AutoSize = true;
            this.lb_Li_Step.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Li_Step.Location = new System.Drawing.Point(291, 2);
            this.lb_Li_Step.Name = "lb_Li_Step";
            this.lb_Li_Step.Size = new System.Drawing.Size(93, 20);
            this.lb_Li_Step.TabIndex = 41;
            this.lb_Li_Step.Text = "标定偏移量：";
            this.lb_Li_Step.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Li_RMS
            // 
            this.tb_Li_RMS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Li_RMS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Li_RMS.Location = new System.Drawing.Point(201, 28);
            this.tb_Li_RMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Li_RMS.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Li_RMS.Name = "tb_Li_RMS";
            this.tb_Li_RMS.Size = new System.Drawing.Size(84, 29);
            this.tb_Li_RMS.TabIndex = 38;
            // 
            // tb_Li_Y
            // 
            this.tb_Li_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Li_Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Li_Y.Location = new System.Drawing.Point(111, 28);
            this.tb_Li_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Li_Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Li_Y.Name = "tb_Li_Y";
            this.tb_Li_Y.Size = new System.Drawing.Size(84, 29);
            this.tb_Li_Y.TabIndex = 39;
            // 
            // tb_Li_X
            // 
            this.tb_Li_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Li_X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Li_X.Location = new System.Drawing.Point(21, 28);
            this.tb_Li_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Li_X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Li_X.Name = "tb_Li_X";
            this.tb_Li_X.Size = new System.Drawing.Size(84, 29);
            this.tb_Li_X.TabIndex = 40;
            // 
            // lb_Li_RMS
            // 
            this.lb_Li_RMS.AutoSize = true;
            this.lb_Li_RMS.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Li_RMS.Location = new System.Drawing.Point(201, 2);
            this.lb_Li_RMS.Name = "lb_Li_RMS";
            this.lb_Li_RMS.Size = new System.Drawing.Size(79, 20);
            this.lb_Li_RMS.TabIndex = 35;
            this.lb_Li_RMS.Text = "标定误差：";
            this.lb_Li_RMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Li_Y
            // 
            this.lb_Li_Y.AutoSize = true;
            this.lb_Li_Y.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Li_Y.Location = new System.Drawing.Point(111, 2);
            this.lb_Li_Y.Name = "lb_Li_Y";
            this.lb_Li_Y.Size = new System.Drawing.Size(73, 20);
            this.lb_Li_Y.TabIndex = 36;
            this.lb_Li_Y.Text = "Y轴坐标：";
            this.lb_Li_Y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Li_X
            // 
            this.lb_Li_X.AutoSize = true;
            this.lb_Li_X.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_Li_X.Location = new System.Drawing.Point(21, 2);
            this.lb_Li_X.Name = "lb_Li_X";
            this.lb_Li_X.Size = new System.Drawing.Size(74, 20);
            this.lb_Li_X.TabIndex = 37;
            this.lb_Li_X.Text = "X轴坐标：";
            this.lb_Li_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Li_msg
            // 
            this.tb_Li_msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Li_msg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Li_msg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Li_msg.Location = new System.Drawing.Point(0, 0);
            this.tb_Li_msg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Li_msg.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Li_msg.Multiline = true;
            this.tb_Li_msg.Name = "tb_Li_msg";
            this.tb_Li_msg.Size = new System.Drawing.Size(397, 264);
            this.tb_Li_msg.TabIndex = 6;
            // 
            // tab_VisionRotation
            // 
            this.tab_VisionRotation.Controls.Add(this.splitContainer_Ro_1);
            this.tab_VisionRotation.Location = new System.Drawing.Point(4, 30);
            this.tab_VisionRotation.Name = "tab_VisionRotation";
            this.tab_VisionRotation.Size = new System.Drawing.Size(1276, 727);
            this.tab_VisionRotation.TabIndex = 3;
            this.tab_VisionRotation.Text = "旋转中心标定";
            this.tab_VisionRotation.UseVisualStyleBackColor = true;
            // 
            // splitContainer_Ro_1
            // 
            this.splitContainer_Ro_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Ro_1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_1.Name = "splitContainer_Ro_1";
            // 
            // splitContainer_Ro_1.Panel1
            // 
            this.splitContainer_Ro_1.Panel1.Controls.Add(this.cogRecordDisplayRotation);
            // 
            // splitContainer_Ro_1.Panel2
            // 
            this.splitContainer_Ro_1.Panel2.Controls.Add(this.splitContainer_Ro_2);
            this.splitContainer_Ro_1.Size = new System.Drawing.Size(1276, 727);
            this.splitContainer_Ro_1.SplitterDistance = 771;
            this.splitContainer_Ro_1.TabIndex = 0;
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
            // splitContainer_Ro_2
            // 
            this.splitContainer_Ro_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_2.Name = "splitContainer_Ro_2";
            // 
            // splitContainer_Ro_2.Panel1
            // 
            this.splitContainer_Ro_2.Panel1.Controls.Add(this.splitContainer_Ro_5);
            // 
            // splitContainer_Ro_2.Panel2
            // 
            this.splitContainer_Ro_2.Panel2.Controls.Add(this.splitContainer_Ro_3);
            this.splitContainer_Ro_2.Size = new System.Drawing.Size(501, 727);
            this.splitContainer_Ro_2.SplitterDistance = 100;
            this.splitContainer_Ro_2.TabIndex = 0;
            // 
            // splitContainer_Ro_5
            // 
            this.splitContainer_Ro_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_5.Name = "splitContainer_Ro_5";
            this.splitContainer_Ro_5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_5.Panel1
            // 
            this.splitContainer_Ro_5.Panel1.Controls.Add(this.splitContainer_Ro_6);
            // 
            // splitContainer_Ro_5.Panel2
            // 
            this.splitContainer_Ro_5.Panel2.Controls.Add(this.gb_Rotation);
            this.splitContainer_Ro_5.Size = new System.Drawing.Size(100, 727);
            this.splitContainer_Ro_5.SplitterDistance = 448;
            this.splitContainer_Ro_5.TabIndex = 0;
            // 
            // splitContainer_Ro_6
            // 
            this.splitContainer_Ro_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_6.Name = "splitContainer_Ro_6";
            this.splitContainer_Ro_6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_6.Panel1
            // 
            this.splitContainer_Ro_6.Panel1.Controls.Add(this.splitContainer_Ro_7);
            // 
            // splitContainer_Ro_6.Panel2
            // 
            this.splitContainer_Ro_6.Panel2.Controls.Add(this.btn_Ro_Auto);
            this.splitContainer_Ro_6.Size = new System.Drawing.Size(100, 448);
            this.splitContainer_Ro_6.SplitterDistance = 394;
            this.splitContainer_Ro_6.TabIndex = 0;
            // 
            // splitContainer_Ro_7
            // 
            this.splitContainer_Ro_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_7.Name = "splitContainer_Ro_7";
            this.splitContainer_Ro_7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_7.Panel1
            // 
            this.splitContainer_Ro_7.Panel1.Controls.Add(this.gb_RotationCon);
            // 
            // splitContainer_Ro_7.Panel2
            // 
            this.splitContainer_Ro_7.Panel2.Controls.Add(this.splitContainer_Ro_8);
            this.splitContainer_Ro_7.Size = new System.Drawing.Size(100, 394);
            this.splitContainer_Ro_7.SplitterDistance = 161;
            this.splitContainer_Ro_7.TabIndex = 0;
            // 
            // gb_RotationCon
            // 
            this.gb_RotationCon.Controls.Add(this.rdo_Ro_Robot2);
            this.gb_RotationCon.Controls.Add(this.rdo_Ro_Robot1);
            this.gb_RotationCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationCon.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationCon.Name = "gb_RotationCon";
            this.gb_RotationCon.Size = new System.Drawing.Size(100, 161);
            this.gb_RotationCon.TabIndex = 54;
            this.gb_RotationCon.TabStop = false;
            this.gb_RotationCon.Text = "连接对象";
            // 
            // rdo_Ro_Robot2
            // 
            this.rdo_Ro_Robot2.AutoSize = true;
            this.rdo_Ro_Robot2.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Ro_Robot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Robot2.Location = new System.Drawing.Point(13, 56);
            this.rdo_Ro_Robot2.Name = "rdo_Ro_Robot2";
            this.rdo_Ro_Robot2.Size = new System.Drawing.Size(83, 25);
            this.rdo_Ro_Robot2.TabIndex = 29;
            this.rdo_Ro_Robot2.Text = "Robot2";
            this.rdo_Ro_Robot2.UseVisualStyleBackColor = false;
            this.rdo_Ro_Robot2.Click += new System.EventHandler(this.rdo_Ro_Robot2_Click);
            // 
            // rdo_Ro_Robot1
            // 
            this.rdo_Ro_Robot1.AutoSize = true;
            this.rdo_Ro_Robot1.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Ro_Robot1.Checked = true;
            this.rdo_Ro_Robot1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Robot1.Location = new System.Drawing.Point(13, 28);
            this.rdo_Ro_Robot1.Name = "rdo_Ro_Robot1";
            this.rdo_Ro_Robot1.Size = new System.Drawing.Size(83, 25);
            this.rdo_Ro_Robot1.TabIndex = 28;
            this.rdo_Ro_Robot1.TabStop = true;
            this.rdo_Ro_Robot1.Text = "Robot1";
            this.rdo_Ro_Robot1.UseVisualStyleBackColor = false;
            this.rdo_Ro_Robot1.Click += new System.EventHandler(this.rdo_Ro_Robot1_Click);
            // 
            // splitContainer_Ro_8
            // 
            this.splitContainer_Ro_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_8.Name = "splitContainer_Ro_8";
            this.splitContainer_Ro_8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_8.Panel1
            // 
            this.splitContainer_Ro_8.Panel1.Controls.Add(this.gb_RotationMode);
            // 
            // splitContainer_Ro_8.Panel2
            // 
            this.splitContainer_Ro_8.Panel2.Controls.Add(this.gb_RotationVision);
            this.splitContainer_Ro_8.Size = new System.Drawing.Size(100, 229);
            this.splitContainer_Ro_8.SplitterDistance = 120;
            this.splitContainer_Ro_8.TabIndex = 0;
            // 
            // gb_RotationMode
            // 
            this.gb_RotationMode.Controls.Add(this.rdo_Ro_Manual);
            this.gb_RotationMode.Controls.Add(this.rdo_Ro_Auto);
            this.gb_RotationMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationMode.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationMode.Name = "gb_RotationMode";
            this.gb_RotationMode.Size = new System.Drawing.Size(100, 120);
            this.gb_RotationMode.TabIndex = 27;
            this.gb_RotationMode.TabStop = false;
            this.gb_RotationMode.Text = "标定模式";
            // 
            // rdo_Ro_Manual
            // 
            this.rdo_Ro_Manual.AutoSize = true;
            this.rdo_Ro_Manual.BackColor = System.Drawing.Color.Transparent;
            this.rdo_Ro_Manual.Checked = true;
            this.rdo_Ro_Manual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Manual.Location = new System.Drawing.Point(13, 56);
            this.rdo_Ro_Manual.Name = "rdo_Ro_Manual";
            this.rdo_Ro_Manual.Size = new System.Drawing.Size(60, 25);
            this.rdo_Ro_Manual.TabIndex = 28;
            this.rdo_Ro_Manual.TabStop = true;
            this.rdo_Ro_Manual.Text = "手动";
            this.rdo_Ro_Manual.UseVisualStyleBackColor = false;
            this.rdo_Ro_Manual.Click += new System.EventHandler(this.rdo_Ro_Manual_Click);
            // 
            // rdo_Ro_Auto
            // 
            this.rdo_Ro_Auto.AutoSize = true;
            this.rdo_Ro_Auto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Auto.Location = new System.Drawing.Point(13, 28);
            this.rdo_Ro_Auto.Name = "rdo_Ro_Auto";
            this.rdo_Ro_Auto.Size = new System.Drawing.Size(60, 25);
            this.rdo_Ro_Auto.TabIndex = 27;
            this.rdo_Ro_Auto.Text = "自动";
            this.rdo_Ro_Auto.UseVisualStyleBackColor = true;
            this.rdo_Ro_Auto.Click += new System.EventHandler(this.rdo_Ro_Auto_Click);
            // 
            // gb_RotationVision
            // 
            this.gb_RotationVision.Controls.Add(this.rdo_Ro_Live);
            this.gb_RotationVision.Controls.Add(this.rdo_Ro_Snap);
            this.gb_RotationVision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_RotationVision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.gb_RotationVision.Location = new System.Drawing.Point(0, 0);
            this.gb_RotationVision.Name = "gb_RotationVision";
            this.gb_RotationVision.Size = new System.Drawing.Size(100, 105);
            this.gb_RotationVision.TabIndex = 26;
            this.gb_RotationVision.TabStop = false;
            this.gb_RotationVision.Text = "图像模式";
            // 
            // rdo_Ro_Live
            // 
            this.rdo_Ro_Live.AutoSize = true;
            this.rdo_Ro_Live.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Live.Location = new System.Drawing.Point(13, 56);
            this.rdo_Ro_Live.Name = "rdo_Ro_Live";
            this.rdo_Ro_Live.Size = new System.Drawing.Size(60, 25);
            this.rdo_Ro_Live.TabIndex = 28;
            this.rdo_Ro_Live.Text = "实时";
            this.rdo_Ro_Live.UseVisualStyleBackColor = true;
            this.rdo_Ro_Live.CheckedChanged += new System.EventHandler(this.rdo_Ro_Live_CheckedChanged);
            // 
            // rdo_Ro_Snap
            // 
            this.rdo_Ro_Snap.AutoSize = true;
            this.rdo_Ro_Snap.Checked = true;
            this.rdo_Ro_Snap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.rdo_Ro_Snap.Location = new System.Drawing.Point(13, 28);
            this.rdo_Ro_Snap.Name = "rdo_Ro_Snap";
            this.rdo_Ro_Snap.Size = new System.Drawing.Size(60, 25);
            this.rdo_Ro_Snap.TabIndex = 27;
            this.rdo_Ro_Snap.TabStop = true;
            this.rdo_Ro_Snap.Text = "单帧";
            this.rdo_Ro_Snap.UseVisualStyleBackColor = true;
            this.rdo_Ro_Snap.CheckedChanged += new System.EventHandler(this.rdo_Ro_Snap_CheckedChanged);
            // 
            // btn_Ro_Auto
            // 
            this.btn_Ro_Auto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Auto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ro_Auto.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_Ro_Auto.Location = new System.Drawing.Point(0, 0);
            this.btn_Ro_Auto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Auto.Name = "btn_Ro_Auto";
            this.btn_Ro_Auto.Size = new System.Drawing.Size(100, 50);
            this.btn_Ro_Auto.TabIndex = 68;
            this.btn_Ro_Auto.Text = "自动标定";
            this.btn_Ro_Auto.Click += new System.EventHandler(this.btn_Ro_Auto_Click);
            // 
            // gb_Rotation
            // 
            this.gb_Rotation.Controls.Add(this.btn_Ro_FileImage);
            this.gb_Rotation.Controls.Add(this.btn_Ro_Save);
            this.gb_Rotation.Controls.Add(this.btn_Ro_Start);
            this.gb_Rotation.Controls.Add(this.btn_Ro_AddMark);
            this.gb_Rotation.Controls.Add(this.btn_Ro_Run);
            this.gb_Rotation.Controls.Add(this.btn_Ro_Clear);
            this.gb_Rotation.Controls.Add(this.btn_Ro_Acq);
            this.gb_Rotation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Rotation.Location = new System.Drawing.Point(0, 0);
            this.gb_Rotation.Name = "gb_Rotation";
            this.gb_Rotation.Size = new System.Drawing.Size(100, 275);
            this.gb_Rotation.TabIndex = 23;
            this.gb_Rotation.TabStop = false;
            // 
            // btn_Ro_FileImage
            // 
            this.btn_Ro_FileImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_FileImage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_FileImage.Location = new System.Drawing.Point(5, 229);
            this.btn_Ro_FileImage.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_FileImage.Name = "btn_Ro_FileImage";
            this.btn_Ro_FileImage.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_FileImage.TabIndex = 80;
            this.btn_Ro_FileImage.Text = "文件取图";
            this.btn_Ro_FileImage.Click += new System.EventHandler(this.btn_Ro_FileImage_Click);
            // 
            // btn_Ro_Save
            // 
            this.btn_Ro_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Save.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_Save.Location = new System.Drawing.Point(5, 197);
            this.btn_Ro_Save.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Save.Name = "btn_Ro_Save";
            this.btn_Ro_Save.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_Save.TabIndex = 79;
            this.btn_Ro_Save.Text = "保存结果";
            this.btn_Ro_Save.Click += new System.EventHandler(this.btn_Ro_Save_Click);
            // 
            // btn_Ro_Start
            // 
            this.btn_Ro_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Start.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_Start.Location = new System.Drawing.Point(5, 163);
            this.btn_Ro_Start.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Start.Name = "btn_Ro_Start";
            this.btn_Ro_Start.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_Start.TabIndex = 78;
            this.btn_Ro_Start.Text = "开始标定";
            this.btn_Ro_Start.Click += new System.EventHandler(this.btn_Ro_Start_Click);
            // 
            // btn_Ro_AddMark
            // 
            this.btn_Ro_AddMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_AddMark.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_AddMark.Location = new System.Drawing.Point(5, 129);
            this.btn_Ro_AddMark.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_AddMark.Name = "btn_Ro_AddMark";
            this.btn_Ro_AddMark.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_AddMark.TabIndex = 77;
            this.btn_Ro_AddMark.Text = "添加Mark";
            this.btn_Ro_AddMark.Click += new System.EventHandler(this.btn_Ro_AddMark_Click);
            // 
            // btn_Ro_Run
            // 
            this.btn_Ro_Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Run.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_Run.Location = new System.Drawing.Point(5, 95);
            this.btn_Ro_Run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Run.Name = "btn_Ro_Run";
            this.btn_Ro_Run.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_Run.TabIndex = 76;
            this.btn_Ro_Run.Text = "运行程序";
            this.btn_Ro_Run.Click += new System.EventHandler(this.btn_Ro_Run_Click);
            // 
            // btn_Ro_Clear
            // 
            this.btn_Ro_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Clear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_Clear.Location = new System.Drawing.Point(5, 61);
            this.btn_Ro_Clear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Clear.Name = "btn_Ro_Clear";
            this.btn_Ro_Clear.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_Clear.TabIndex = 75;
            this.btn_Ro_Clear.Text = "重新标定";
            this.btn_Ro_Clear.Click += new System.EventHandler(this.btn_Ro_Clear_Click);
            // 
            // btn_Ro_Acq
            // 
            this.btn_Ro_Acq.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ro_Acq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ro_Acq.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_Ro_Acq.Location = new System.Drawing.Point(5, 27);
            this.btn_Ro_Acq.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_Ro_Acq.Name = "btn_Ro_Acq";
            this.btn_Ro_Acq.Size = new System.Drawing.Size(91, 26);
            this.btn_Ro_Acq.TabIndex = 74;
            this.btn_Ro_Acq.Text = "采集图像";
            this.btn_Ro_Acq.UseVisualStyleBackColor = false;
            this.btn_Ro_Acq.Click += new System.EventHandler(this.btn_Ro_Acq_Click);
            // 
            // splitContainer_Ro_3
            // 
            this.splitContainer_Ro_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_3.Name = "splitContainer_Ro_3";
            this.splitContainer_Ro_3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_3.Panel1
            // 
            this.splitContainer_Ro_3.Panel1.Controls.Add(this.dataGridViewRotation);
            // 
            // splitContainer_Ro_3.Panel2
            // 
            this.splitContainer_Ro_3.Panel2.Controls.Add(this.splitContainer_Ro_4);
            this.splitContainer_Ro_3.Size = new System.Drawing.Size(397, 727);
            this.splitContainer_Ro_3.SplitterDistance = 393;
            this.splitContainer_Ro_3.TabIndex = 0;
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
            this.dataGridViewRotation.Size = new System.Drawing.Size(397, 393);
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
            // splitContainer_Ro_4
            // 
            this.splitContainer_Ro_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Ro_4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Ro_4.Name = "splitContainer_Ro_4";
            this.splitContainer_Ro_4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Ro_4.Panel1
            // 
            this.splitContainer_Ro_4.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer_Ro_4.Panel2
            // 
            this.splitContainer_Ro_4.Panel2.Controls.Add(this.tb_msg_Rotation);
            this.splitContainer_Ro_4.Size = new System.Drawing.Size(397, 330);
            this.splitContainer_Ro_4.SplitterDistance = 62;
            this.splitContainer_Ro_4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_Ro_Num);
            this.panel2.Controls.Add(this.lb_Ro_RMS);
            this.panel2.Controls.Add(this.lb_Ro_Y);
            this.panel2.Controls.Add(this.lb_Ro_X);
            this.panel2.Controls.Add(this.cbb_Ro_Nozzle);
            this.panel2.Controls.Add(this.tb_Ro_RMS);
            this.panel2.Controls.Add(this.tb_Ro_Y);
            this.panel2.Controls.Add(this.tb_Ro_X);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 62);
            this.panel2.TabIndex = 0;
            // 
            // lb_Ro_Num
            // 
            this.lb_Ro_Num.AutoSize = true;
            this.lb_Ro_Num.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lb_Ro_Num.Location = new System.Drawing.Point(291, 2);
            this.lb_Ro_Num.Name = "lb_Ro_Num";
            this.lb_Ro_Num.Size = new System.Drawing.Size(79, 20);
            this.lb_Ro_Num.TabIndex = 55;
            this.lb_Ro_Num.Text = "转轴序号：";
            this.lb_Ro_Num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Ro_RMS
            // 
            this.lb_Ro_RMS.AutoSize = true;
            this.lb_Ro_RMS.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lb_Ro_RMS.Location = new System.Drawing.Point(201, 2);
            this.lb_Ro_RMS.Name = "lb_Ro_RMS";
            this.lb_Ro_RMS.Size = new System.Drawing.Size(79, 20);
            this.lb_Ro_RMS.TabIndex = 55;
            this.lb_Ro_RMS.Text = "标定误差：";
            this.lb_Ro_RMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Ro_Y
            // 
            this.lb_Ro_Y.AutoSize = true;
            this.lb_Ro_Y.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lb_Ro_Y.Location = new System.Drawing.Point(111, 2);
            this.lb_Ro_Y.Name = "lb_Ro_Y";
            this.lb_Ro_Y.Size = new System.Drawing.Size(73, 20);
            this.lb_Ro_Y.TabIndex = 55;
            this.lb_Ro_Y.Text = "Y轴坐标：";
            this.lb_Ro_Y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Ro_X
            // 
            this.lb_Ro_X.AutoSize = true;
            this.lb_Ro_X.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_Ro_X.Location = new System.Drawing.Point(21, 2);
            this.lb_Ro_X.Name = "lb_Ro_X";
            this.lb_Ro_X.Size = new System.Drawing.Size(74, 20);
            this.lb_Ro_X.TabIndex = 55;
            this.lb_Ro_X.Text = "X轴坐标：";
            this.lb_Ro_X.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_Ro_Nozzle
            // 
            this.cbb_Ro_Nozzle.DropDownWidth = 300;
            this.cbb_Ro_Nozzle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cbb_Ro_Nozzle.Location = new System.Drawing.Point(291, 28);
            this.cbb_Ro_Nozzle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbb_Ro_Nozzle.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbb_Ro_Nozzle.Name = "cbb_Ro_Nozzle";
            this.cbb_Ro_Nozzle.Size = new System.Drawing.Size(84, 29);
            this.cbb_Ro_Nozzle.TabIndex = 54;
            this.cbb_Ro_Nozzle.SelectedIndexChanged += new System.EventHandler(this.cbo_Nozzle_Rotation_SelectedIndexChanged);
            // 
            // tb_Ro_RMS
            // 
            this.tb_Ro_RMS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Ro_RMS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Ro_RMS.Location = new System.Drawing.Point(201, 28);
            this.tb_Ro_RMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Ro_RMS.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Ro_RMS.Name = "tb_Ro_RMS";
            this.tb_Ro_RMS.Size = new System.Drawing.Size(84, 29);
            this.tb_Ro_RMS.TabIndex = 32;
            // 
            // tb_Ro_Y
            // 
            this.tb_Ro_Y.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Ro_Y.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Ro_Y.Location = new System.Drawing.Point(111, 28);
            this.tb_Ro_Y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Ro_Y.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Ro_Y.Name = "tb_Ro_Y";
            this.tb_Ro_Y.Size = new System.Drawing.Size(84, 29);
            this.tb_Ro_Y.TabIndex = 31;
            // 
            // tb_Ro_X
            // 
            this.tb_Ro_X.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Ro_X.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tb_Ro_X.Location = new System.Drawing.Point(21, 28);
            this.tb_Ro_X.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Ro_X.MinimumSize = new System.Drawing.Size(4, 4);
            this.tb_Ro_X.Name = "tb_Ro_X";
            this.tb_Ro_X.Size = new System.Drawing.Size(84, 29);
            this.tb_Ro_X.TabIndex = 30;
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
            this.tb_msg_Rotation.Size = new System.Drawing.Size(397, 264);
            this.tb_msg_Rotation.TabIndex = 6;
            // 
            // FrmVppSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.tab_C_VisionTool);
            this.DoubleBuffered = true;
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
            this.splitContainer18.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer18)).EndInit();
            this.splitContainer18.ResumeLayout(false);
            this.groupBoxOperation.ResumeLayout(false);
            this.uiPanelOperation.ResumeLayout(false);
            this.uiPanelOperation.PerformLayout();
            this.tab_VisionLinear.ResumeLayout(false);
            this.splitContainer_Li_1.Panel1.ResumeLayout(false);
            this.splitContainer_Li_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_1)).EndInit();
            this.splitContainer_Li_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayLinear)).EndInit();
            this.splitContainer_Li_2.Panel1.ResumeLayout(false);
            this.splitContainer_Li_2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_2)).EndInit();
            this.splitContainer_Li_2.ResumeLayout(false);
            this.splitContainer_Li_5.Panel1.ResumeLayout(false);
            this.splitContainer_Li_5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_5)).EndInit();
            this.splitContainer_Li_5.ResumeLayout(false);
            this.splitContainer_Li_6.Panel1.ResumeLayout(false);
            this.splitContainer_Li_6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_6)).EndInit();
            this.splitContainer_Li_6.ResumeLayout(false);
            this.splitContainer_Li_7.Panel1.ResumeLayout(false);
            this.splitContainer_Li_7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_7)).EndInit();
            this.splitContainer_Li_7.ResumeLayout(false);
            this.gb_LinearCon.ResumeLayout(false);
            this.gb_LinearCon.PerformLayout();
            this.splitContainer_Li_8.Panel1.ResumeLayout(false);
            this.splitContainer_Li_8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_8)).EndInit();
            this.splitContainer_Li_8.ResumeLayout(false);
            this.gb_LinearMode.ResumeLayout(false);
            this.gb_LinearMode.PerformLayout();
            this.gb_LinearVision.ResumeLayout(false);
            this.gb_LinearVision.PerformLayout();
            this.gb_Li_operation.ResumeLayout(false);
            this.splitContainer_Li_3.Panel1.ResumeLayout(false);
            this.splitContainer_Li_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_3)).EndInit();
            this.splitContainer_Li_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinear)).EndInit();
            this.splitContainer_Li_4.Panel1.ResumeLayout(false);
            this.splitContainer_Li_4.Panel2.ResumeLayout(false);
            this.splitContainer_Li_4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Li_4)).EndInit();
            this.splitContainer_Li_4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_VisionRotation.ResumeLayout(false);
            this.splitContainer_Ro_1.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_1)).EndInit();
            this.splitContainer_Ro_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplayRotation)).EndInit();
            this.splitContainer_Ro_2.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_2)).EndInit();
            this.splitContainer_Ro_2.ResumeLayout(false);
            this.splitContainer_Ro_5.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_5)).EndInit();
            this.splitContainer_Ro_5.ResumeLayout(false);
            this.splitContainer_Ro_6.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_6)).EndInit();
            this.splitContainer_Ro_6.ResumeLayout(false);
            this.splitContainer_Ro_7.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_7)).EndInit();
            this.splitContainer_Ro_7.ResumeLayout(false);
            this.gb_RotationCon.ResumeLayout(false);
            this.gb_RotationCon.PerformLayout();
            this.splitContainer_Ro_8.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_8)).EndInit();
            this.splitContainer_Ro_8.ResumeLayout(false);
            this.gb_RotationMode.ResumeLayout(false);
            this.gb_RotationMode.PerformLayout();
            this.gb_RotationVision.ResumeLayout(false);
            this.gb_RotationVision.PerformLayout();
            this.gb_Rotation.ResumeLayout(false);
            this.splitContainer_Ro_3.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_3)).EndInit();
            this.splitContainer_Ro_3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRotation)).EndInit();
            this.splitContainer_Ro_4.Panel1.ResumeLayout(false);
            this.splitContainer_Ro_4.Panel2.ResumeLayout(false);
            this.splitContainer_Ro_4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Ro_4)).EndInit();
            this.splitContainer_Ro_4.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer splitContainer_Li_1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplayLinear;
        private System.Windows.Forms.SplitContainer splitContainer_Li_2;
        private System.Windows.Forms.SplitContainer splitContainer_Li_5;
        private System.Windows.Forms.SplitContainer splitContainer_Li_6;
        private System.Windows.Forms.GroupBox gb_LinearVision;
        private System.Windows.Forms.GroupBox gb_LinearMode;
        private System.Windows.Forms.GroupBox gb_Li_operation;
        private System.Windows.Forms.SplitContainer splitContainer_Li_3;
        private System.Windows.Forms.DataGridView dataGridViewLinear;
        private System.Windows.Forms.DataGridViewTextBoxColumn UncalibratedPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn UncalibratedPointY;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawCalibratedPointX;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawCalibratedPointY;
        private System.Windows.Forms.SplitContainer splitContainer_Li_4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tab_VisionRotation;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_1;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplayRotation;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_2;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_5;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_6;
        private System.Windows.Forms.GroupBox gb_RotationVision;
        private System.Windows.Forms.GroupBox gb_RotationMode;
        private System.Windows.Forms.GroupBox gb_Rotation;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_3;
        private System.Windows.Forms.DataGridView dataGridViewRotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_4;
        private System.Windows.Forms.Panel panel2;
        private Button btn_Li_Auto;
        private Button btn_Li_Save;
        private Button btn_Li_Start;
        private Button btn_Li_AddMark;
        private Button btn_Li_Run;
        private Button btn_Li_Clear;
        private Button btn_Li_Acq;
        private TextBox tb_Li_msg;
        private Label lb_Li_RMS;
        private Label lb_Li_Y;
        private Label lb_Li_X;
        private TextBox tb_Li_RMS;
        private TextBox tb_Li_Y;
        private TextBox tb_Li_X;
        private Button btn_Ro_FileImage;
        private Button btn_Ro_Save;
        private Button btn_Ro_Start;
        private Button btn_Ro_AddMark;
        private Button btn_Ro_Run;
        private Button btn_Ro_Clear;
        private Button btn_Ro_Acq;
        private Button btn_Ro_Auto;
        private ComboBox cbb_Ro_Nozzle;
        private TextBox tb_Ro_RMS;
        private TextBox tb_Ro_Y;
        private TextBox tb_Ro_X;
        private Label lb_Ro_Num;
        private Label lb_Ro_RMS;
        private Label lb_Ro_Y;
        private Label lb_Ro_X;
        private TextBox tb_msg_Rotation;
        private System.Windows.Forms.SplitContainer splitContainer_Li_7;
        private System.Windows.Forms.SplitContainer splitContainer_Li_8;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_7;
        private System.Windows.Forms.SplitContainer splitContainer_Ro_8;
        private System.Windows.Forms.RadioButton rdo_Li_Manual;
        private System.Windows.Forms.RadioButton rdo_Li_Auto;
        private System.Windows.Forms.RadioButton rdo_Li_Live;
        private System.Windows.Forms.RadioButton rdo_Li_Snap;
        private System.Windows.Forms.RadioButton rdo_Ro_Manual;
        private System.Windows.Forms.RadioButton rdo_Ro_Auto;
        private System.Windows.Forms.RadioButton rdo_Ro_Live;
        private System.Windows.Forms.RadioButton rdo_Ro_Snap;
        private System.Windows.Forms.GroupBox gb_LinearCon;
        private System.Windows.Forms.RadioButton rdo_Li_Robot1;
        private System.Windows.Forms.GroupBox gb_RotationCon;
        private System.Windows.Forms.RadioButton rdo_Ro_Robot1;
        private RadioButton rdo_Li_Laser2;
        private RadioButton rdo_Li_Laser1;
        private RadioButton rdo_Li_Robot2;
        private RadioButton rdo_Ro_Robot2;
        private RadioButton rdo_Li_Verificate;
        private Button btn_Li_test;
        private TextBox tb_Li_Step;
        private Label lb_Li_Step;
        private SplitContainer splitContainer18;
        private GroupBox groupBoxOperation;
        private Sunny.UI.UITableLayoutPanel uiPanelOperation;
        private Button btn_Di_Start;
        private Button btn_Di_Acq;
        private Button btn_Di_FileImage;
        private Label lb_Di_Enable;
        private ComboBox cbb_Di_Enable;
    }
}