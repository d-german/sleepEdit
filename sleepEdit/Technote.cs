using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for PrelimInter.
    /// </summary>
    public class TechNote : Form
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        public delegate void PassControl(object sender);

        public PassControl passControl;

        public TechNote()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            comboBox_maskType.KeyDown += comboBox_maskType_KeyDown;
            //LoadMaskType();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //


            var mManager = new SleepEditDataManager();

            foreach (var maskSize in mManager.Data.MaskSizes)
            {
                comboBox_maskSize.Items.Add(maskSize);
            }

            foreach (var maskStyle in mManager.Data.MaskStyles)
            {
                comboBox_maskType.Items.Add(maskStyle);
            }
        }

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        //		protected override void Dispose()
        //		{
        //			// Save the items in the ComboBox
        //			SaveOccupation();
        //
        //			base.Dispose();
        //			if(components != null)
        //				components.Dispose();
        //		} 
        protected override void Dispose(bool disposing)
        {
            //SaveMaskType();

            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(TechNote));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskTypeToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.maskSizeToolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.addTechnicianNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskTypeToolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.maskSizeToolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_lat = new System.Windows.Forms.CheckBox();
            this.checkBox_prone = new System.Windows.Forms.CheckBox();
            this.checkBox_supine = new System.Windows.Forms.CheckBox();
            this.checkBox_modSnor = new System.Windows.Forms.CheckBox();
            this.checkBox_loudSnor = new System.Windows.Forms.CheckBox();
            this.checkBox_mildSnor = new System.Windows.Forms.CheckBox();
            this.checkBox_plms = new System.Windows.Forms.CheckBox();
            this.checkBox_resEvents = new System.Windows.Forms.CheckBox();
            this.checkBox_arr = new System.Windows.Forms.CheckBox();
            this.checkBoxRemEffect = new System.Windows.Forms.CheckBox();
            this.checkBoxPositionEffect = new System.Windows.Forms.CheckBox();
            this.checkBox_ambian = new System.Windows.Forms.CheckBox();
            this.checkBox_15lpmO2 = new System.Windows.Forms.CheckBox();
            this.checkBox_tooLateForCpap = new System.Windows.Forms.CheckBox();
            this.checkBox_NoCpap = new System.Windows.Forms.CheckBox();
            this.comboBox_finalEpap = new System.Windows.Forms.ComboBox();
            this.comboBox_iniCpap = new System.Windows.Forms.ComboBox();
            this.label_Initial = new System.Windows.Forms.Label();
            this.comboBox_finalCpap = new System.Windows.Forms.ComboBox();
            this.label_final = new System.Windows.Forms.Label();
            this.comboBox_initIpap = new System.Windows.Forms.ComboBox();
            this.comboBox_finalIpap = new System.Windows.Forms.ComboBox();
            this.comboBox_initialEpap = new System.Windows.Forms.ComboBox();
            this.label_slash1 = new System.Windows.Forms.Label();
            this.label_slash2 = new System.Windows.Forms.Label();
            this.label1_maskType = new System.Windows.Forms.Label();
            this.comboBox_maskType = new System.Windows.Forms.ComboBox();
            this.label_maskSize = new System.Windows.Forms.Label();
            this.comboBox_maskSize = new System.Windows.Forms.ComboBox();
            this.checkBox_chinStrap = new System.Windows.Forms.CheckBox();
            this.checkBox_humidifer = new System.Windows.Forms.CheckBox();
            this.checkBox_ptHasMachine = new System.Windows.Forms.CheckBox();
            this.label_pressVerified = new System.Windows.Forms.Label();
            this.comboBox_txVerifiedAT = new System.Windows.Forms.ComboBox();
            this.label_andChangedTo = new System.Windows.Forms.Label();
            this.comboBox_txChangedTo = new System.Windows.Forms.ComboBox();
            this.document = new System.Windows.Forms.RichTextBox();
            this.button_makeNote = new System.Windows.Forms.Button();
            this.mGoupBoxStudyPerformed = new System.Windows.Forms.GroupBox();
            this.mGroupCPAP_BIPAP = new System.Windows.Forms.GroupBox();
            this.mRadioButton_bipap = new System.Windows.Forms.RadioButton();
            this.mRadioButton_cpap = new System.Windows.Forms.RadioButton();
            this.mRadioButtonSplitNight = new System.Windows.Forms.RadioButton();
            this.mRadioButtonCpapBipapTitrat = new System.Windows.Forms.RadioButton();
            this.mRadioButtonPsg = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mCpapBipapInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.mPanelPressVerAndChangedTo = new System.Windows.Forms.Panel();
            this.mPanelBipap = new System.Windows.Forms.Panel();
            this.mPanelCpap = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.mGoupBoxStudyPerformed.SuspendLayout();
            this.mGroupCPAP_BIPAP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.mCpapBipapInfoGroupBox.SuspendLayout();
            this.mPanelPressVerAndChangedTo.SuspendLayout();
            this.mPanelBipap.SuspendLayout();
            this.mPanelCpap.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.addToolStripMenuItem,
                this.addTechnicianNameToolStripMenuItem
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 52);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.maskTypeToolStripMenuItemAdd,
                this.maskSizeToolStripMenuItemAdd
            });
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // maskTypeToolStripMenuItemAdd
            // 
            this.maskTypeToolStripMenuItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.maskTypeToolStripMenuItemAdd.Name = "maskTypeToolStripMenuItemAdd";
            this.maskTypeToolStripMenuItemAdd.Size = new System.Drawing.Size(159, 24);
            this.maskTypeToolStripMenuItemAdd.Text = "Mask Type";
            this.maskTypeToolStripMenuItemAdd.Click += new System.EventHandler(this.maskTypeToolStripMenuItemAdd_Click);
            // 
            // maskSizeToolStripMenuItemAdd
            // 
            this.maskSizeToolStripMenuItemAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.maskSizeToolStripMenuItemAdd.Name = "maskSizeToolStripMenuItemAdd";
            this.maskSizeToolStripMenuItemAdd.Size = new System.Drawing.Size(159, 24);
            this.maskSizeToolStripMenuItemAdd.Text = "Mask Size";
            this.maskSizeToolStripMenuItemAdd.Click += new System.EventHandler(this.maskSizeToolStripMenuItemAdd_Click);
            // 
            // addTechnicianNameToolStripMenuItem
            // 
            this.addTechnicianNameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.maskTypeToolStripMenuItemRemove,
                this.maskSizeToolStripMenuItemRemove
            });
            this.addTechnicianNameToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.addTechnicianNameToolStripMenuItem.Name = "addTechnicianNameToolStripMenuItem";
            this.addTechnicianNameToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.addTechnicianNameToolStripMenuItem.Text = "Remove";
            this.addTechnicianNameToolStripMenuItem.Click +=
                new System.EventHandler(this.addTechnicianNameToolStripMenuItem_Click);
            // 
            // maskTypeToolStripMenuItemRemove
            // 
            this.maskTypeToolStripMenuItemRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.maskTypeToolStripMenuItemRemove.Name = "maskTypeToolStripMenuItemRemove";
            this.maskTypeToolStripMenuItemRemove.Size = new System.Drawing.Size(159, 24);
            this.maskTypeToolStripMenuItemRemove.Text = "Mask Type";
            this.maskTypeToolStripMenuItemRemove.Click +=
                new System.EventHandler(this.maskTypeToolStripMenuItemRemove_Click);
            // 
            // maskSizeToolStripMenuItemRemove
            // 
            this.maskSizeToolStripMenuItemRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.maskSizeToolStripMenuItemRemove.Name = "maskSizeToolStripMenuItemRemove";
            this.maskSizeToolStripMenuItemRemove.Size = new System.Drawing.Size(159, 24);
            this.maskSizeToolStripMenuItemRemove.Text = "Mask Size";
            this.maskSizeToolStripMenuItemRemove.Click +=
                new System.EventHandler(this.maskSizeToolStripMenuItemRemove_Click);
            // 
            // checkBox_lat
            // 
            this.checkBox_lat.AutoSize = true;
            this.checkBox_lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_lat.Location = new System.Drawing.Point(20, 55);
            this.checkBox_lat.Name = "checkBox_lat";
            this.checkBox_lat.Size = new System.Drawing.Size(77, 24);
            this.checkBox_lat.TabIndex = 5;
            this.checkBox_lat.Text = "Lateral";
            // 
            // checkBox_prone
            // 
            this.checkBox_prone.AutoSize = true;
            this.checkBox_prone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_prone.Location = new System.Drawing.Point(20, 85);
            this.checkBox_prone.Name = "checkBox_prone";
            this.checkBox_prone.Size = new System.Drawing.Size(70, 24);
            this.checkBox_prone.TabIndex = 6;
            this.checkBox_prone.Text = "Prone";
            // 
            // checkBox_supine
            // 
            this.checkBox_supine.AutoSize = true;
            this.checkBox_supine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_supine.Location = new System.Drawing.Point(20, 25);
            this.checkBox_supine.Name = "checkBox_supine";
            this.checkBox_supine.Size = new System.Drawing.Size(78, 24);
            this.checkBox_supine.TabIndex = 7;
            this.checkBox_supine.Text = "Supine";
            // 
            // checkBox_modSnor
            // 
            this.checkBox_modSnor.AutoSize = true;
            this.checkBox_modSnor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_modSnor.Location = new System.Drawing.Point(19, 55);
            this.checkBox_modSnor.Name = "checkBox_modSnor";
            this.checkBox_modSnor.Size = new System.Drawing.Size(96, 24);
            this.checkBox_modSnor.TabIndex = 10;
            this.checkBox_modSnor.Text = "Moderate";
            // 
            // checkBox_loudSnor
            // 
            this.checkBox_loudSnor.AutoSize = true;
            this.checkBox_loudSnor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_loudSnor.Location = new System.Drawing.Point(19, 85);
            this.checkBox_loudSnor.Name = "checkBox_loudSnor";
            this.checkBox_loudSnor.Size = new System.Drawing.Size(64, 24);
            this.checkBox_loudSnor.TabIndex = 11;
            this.checkBox_loudSnor.Text = "Loud";
            // 
            // checkBox_mildSnor
            // 
            this.checkBox_mildSnor.AutoSize = true;
            this.checkBox_mildSnor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_mildSnor.Location = new System.Drawing.Point(19, 25);
            this.checkBox_mildSnor.Name = "checkBox_mildSnor";
            this.checkBox_mildSnor.Size = new System.Drawing.Size(56, 24);
            this.checkBox_mildSnor.TabIndex = 9;
            this.checkBox_mildSnor.Text = "Mild";
            // 
            // checkBox_plms
            // 
            this.checkBox_plms.AutoSize = true;
            this.checkBox_plms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_plms.Location = new System.Drawing.Point(6, 55);
            this.checkBox_plms.Name = "checkBox_plms";
            this.checkBox_plms.Size = new System.Drawing.Size(71, 24);
            this.checkBox_plms.TabIndex = 12;
            this.checkBox_plms.Text = "PLM\'s";
            // 
            // checkBox_resEvents
            // 
            this.checkBox_resEvents.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_resEvents.AutoSize = true;
            this.checkBox_resEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_resEvents.Location = new System.Drawing.Point(6, 25);
            this.checkBox_resEvents.Name = "checkBox_resEvents";
            this.checkBox_resEvents.Size = new System.Drawing.Size(166, 24);
            this.checkBox_resEvents.TabIndex = 13;
            this.checkBox_resEvents.Text = "Respiatory Events?";
            // 
            // checkBox_arr
            // 
            this.checkBox_arr.AutoSize = true;
            this.checkBox_arr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_arr.Location = new System.Drawing.Point(6, 85);
            this.checkBox_arr.Name = "checkBox_arr";
            this.checkBox_arr.Size = new System.Drawing.Size(121, 24);
            this.checkBox_arr.TabIndex = 14;
            this.checkBox_arr.Text = "Arrhythmias?";
            // 
            // checkBoxRemEffect
            // 
            this.checkBoxRemEffect.AutoSize = true;
            this.checkBoxRemEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxRemEffect.Location = new System.Drawing.Point(6, 55);
            this.checkBoxRemEffect.Name = "checkBoxRemEffect";
            this.checkBoxRemEffect.Size = new System.Drawing.Size(133, 24);
            this.checkBoxRemEffect.TabIndex = 12;
            this.checkBoxRemEffect.Text = "REM Related?";
            // 
            // checkBoxPositionEffect
            // 
            this.checkBoxPositionEffect.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                       | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPositionEffect.AutoSize = true;
            this.checkBoxPositionEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxPositionEffect.Location = new System.Drawing.Point(6, 25);
            this.checkBoxPositionEffect.Name = "checkBoxPositionEffect";
            this.checkBoxPositionEffect.Size = new System.Drawing.Size(140, 24);
            this.checkBoxPositionEffect.TabIndex = 13;
            this.checkBoxPositionEffect.Text = "Position Effect?";
            // 
            // checkBox_ambian
            // 
            this.checkBox_ambian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_ambian.AutoSize = true;
            this.checkBox_ambian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_ambian.Location = new System.Drawing.Point(16, 85);
            this.checkBox_ambian.Name = "checkBox_ambian";
            this.checkBox_ambian.Size = new System.Drawing.Size(91, 24);
            this.checkBox_ambian.TabIndex = 50;
            this.checkBox_ambian.Text = "Ambien?";
            this.checkBox_ambian.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // checkBox_15lpmO2
            // 
            this.checkBox_15lpmO2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_15lpmO2.AutoSize = true;
            this.checkBox_15lpmO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_15lpmO2.Location = new System.Drawing.Point(16, 115);
            this.checkBox_15lpmO2.Name = "checkBox_15lpmO2";
            this.checkBox_15lpmO2.Size = new System.Drawing.Size(304, 24);
            this.checkBox_15lpmO2.TabIndex = 51;
            this.checkBox_15lpmO2.Text = "Pt placed on 15 lpm O2 via NRB mask?";
            // 
            // checkBox_tooLateForCpap
            // 
            this.checkBox_tooLateForCpap.AutoSize = true;
            this.checkBox_tooLateForCpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_tooLateForCpap.Location = new System.Drawing.Point(16, 26);
            this.checkBox_tooLateForCpap.Name = "checkBox_tooLateForCpap";
            this.checkBox_tooLateForCpap.Size = new System.Drawing.Size(389, 24);
            this.checkBox_tooLateForCpap.TabIndex = 41;
            this.checkBox_tooLateForCpap.Text = "Pt met criteria for CPAP too late to begin treatment.";
            // 
            // checkBox_NoCpap
            // 
            this.checkBox_NoCpap.AutoSize = true;
            this.checkBox_NoCpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_NoCpap.Location = new System.Drawing.Point(16, 56);
            this.checkBox_NoCpap.Name = "checkBox_NoCpap";
            this.checkBox_NoCpap.Size = new System.Drawing.Size(375, 24);
            this.checkBox_NoCpap.TabIndex = 49;
            this.checkBox_NoCpap.Text = "Pt did not meet split night criteria to initiate CPAP.";
            // 
            // comboBox_finalEpap
            // 
            this.comboBox_finalEpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_finalEpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_finalEpap.Location = new System.Drawing.Point(90, 48);
            this.comboBox_finalEpap.MaxDropDownItems = 25;
            this.comboBox_finalEpap.Name = "comboBox_finalEpap";
            this.comboBox_finalEpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_finalEpap.TabIndex = 31;
            // 
            // comboBox_iniCpap
            // 
            this.comboBox_iniCpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_iniCpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_iniCpap.Location = new System.Drawing.Point(3, 3);
            this.comboBox_iniCpap.MaxDropDownItems = 10;
            this.comboBox_iniCpap.Name = "comboBox_iniCpap";
            this.comboBox_iniCpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_iniCpap.TabIndex = 24;
            // 
            // label_Initial
            // 
            this.label_Initial.AutoSize = true;
            this.label_Initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_Initial.Location = new System.Drawing.Point(6, 39);
            this.label_Initial.Name = "label_Initial";
            this.label_Initial.Size = new System.Drawing.Size(46, 20);
            this.label_Initial.TabIndex = 25;
            this.label_Initial.Text = "Initial";
            this.label_Initial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_finalCpap
            // 
            this.comboBox_finalCpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_finalCpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_finalCpap.Location = new System.Drawing.Point(3, 38);
            this.comboBox_finalCpap.MaxDropDownItems = 25;
            this.comboBox_finalCpap.Name = "comboBox_finalCpap";
            this.comboBox_finalCpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_finalCpap.TabIndex = 26;
            // 
            // label_final
            // 
            this.label_final.AutoSize = true;
            this.label_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_final.Location = new System.Drawing.Point(6, 79);
            this.label_final.Name = "label_final";
            this.label_final.Size = new System.Drawing.Size(43, 20);
            this.label_final.TabIndex = 27;
            this.label_final.Text = "Final";
            this.label_final.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox_initIpap
            // 
            this.comboBox_initIpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_initIpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_initIpap.Location = new System.Drawing.Point(7, 15);
            this.comboBox_initIpap.MaxDropDownItems = 25;
            this.comboBox_initIpap.Name = "comboBox_initIpap";
            this.comboBox_initIpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_initIpap.TabIndex = 28;
            // 
            // comboBox_finalIpap
            // 
            this.comboBox_finalIpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_finalIpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_finalIpap.Location = new System.Drawing.Point(7, 48);
            this.comboBox_finalIpap.MaxDropDownItems = 25;
            this.comboBox_finalIpap.Name = "comboBox_finalIpap";
            this.comboBox_finalIpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_finalIpap.TabIndex = 29;
            // 
            // comboBox_initialEpap
            // 
            this.comboBox_initialEpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_initialEpap.Items.AddRange(new object[]
            {
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30"
            });
            this.comboBox_initialEpap.Location = new System.Drawing.Point(90, 14);
            this.comboBox_initialEpap.MaxDropDownItems = 25;
            this.comboBox_initialEpap.Name = "comboBox_initialEpap";
            this.comboBox_initialEpap.Size = new System.Drawing.Size(53, 28);
            this.comboBox_initialEpap.TabIndex = 30;
            // 
            // label_slash1
            // 
            this.label_slash1.AutoSize = true;
            this.label_slash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_slash1.Location = new System.Drawing.Point(66, 17);
            this.label_slash1.Name = "label_slash1";
            this.label_slash1.Size = new System.Drawing.Size(18, 25);
            this.label_slash1.TabIndex = 32;
            this.label_slash1.Text = "/";
            this.label_slash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_slash2
            // 
            this.label_slash2.AutoSize = true;
            this.label_slash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_slash2.Location = new System.Drawing.Point(66, 47);
            this.label_slash2.Name = "label_slash2";
            this.label_slash2.Size = new System.Drawing.Size(18, 25);
            this.label_slash2.TabIndex = 33;
            this.label_slash2.Text = "/";
            this.label_slash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1_maskType
            // 
            this.label1_maskType.AutoSize = true;
            this.label1_maskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1_maskType.Location = new System.Drawing.Point(233, 23);
            this.label1_maskType.Name = "label1_maskType";
            this.label1_maskType.Size = new System.Drawing.Size(85, 20);
            this.label1_maskType.TabIndex = 20;
            this.label1_maskType.Text = "Mask Type";
            // 
            // comboBox_maskType
            // 
            this.comboBox_maskType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_maskType.Location = new System.Drawing.Point(237, 46);
            this.comboBox_maskType.Name = "comboBox_maskType";
            this.comboBox_maskType.Size = new System.Drawing.Size(180, 28);
            this.comboBox_maskType.Sorted = true;
            this.comboBox_maskType.TabIndex = 19;
            // 
            // label_maskSize
            // 
            this.label_maskSize.AutoSize = true;
            this.label_maskSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_maskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_maskSize.Location = new System.Drawing.Point(236, 81);
            this.label_maskSize.Name = "label_maskSize";
            this.label_maskSize.Size = new System.Drawing.Size(82, 20);
            this.label_maskSize.TabIndex = 34;
            this.label_maskSize.Text = "Mask Size";
            // 
            // comboBox_maskSize
            // 
            this.comboBox_maskSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_maskSize.Location = new System.Drawing.Point(240, 112);
            this.comboBox_maskSize.Name = "comboBox_maskSize";
            this.comboBox_maskSize.Size = new System.Drawing.Size(180, 28);
            this.comboBox_maskSize.TabIndex = 35;
            // 
            // checkBox_chinStrap
            // 
            this.checkBox_chinStrap.AutoSize = true;
            this.checkBox_chinStrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_chinStrap.Location = new System.Drawing.Point(13, 114);
            this.checkBox_chinStrap.Name = "checkBox_chinStrap";
            this.checkBox_chinStrap.Size = new System.Drawing.Size(112, 24);
            this.checkBox_chinStrap.TabIndex = 39;
            this.checkBox_chinStrap.Text = "Chin Strap?";
            // 
            // checkBox_humidifer
            // 
            this.checkBox_humidifer.AutoSize = true;
            this.checkBox_humidifer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_humidifer.Location = new System.Drawing.Point(13, 144);
            this.checkBox_humidifer.Name = "checkBox_humidifer";
            this.checkBox_humidifer.Size = new System.Drawing.Size(165, 24);
            this.checkBox_humidifer.TabIndex = 40;
            this.checkBox_humidifer.Text = "Heated Humidifier?";
            // 
            // checkBox_ptHasMachine
            // 
            this.checkBox_ptHasMachine.AutoSize = true;
            this.checkBox_ptHasMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_ptHasMachine.Location = new System.Drawing.Point(13, 172);
            this.checkBox_ptHasMachine.Name = "checkBox_ptHasMachine";
            this.checkBox_ptHasMachine.Size = new System.Drawing.Size(295, 24);
            this.checkBox_ptHasMachine.TabIndex = 42;
            this.checkBox_ptHasMachine.Text = "Pt has and brought a CPAP machine?";
            this.checkBox_ptHasMachine.CheckedChanged +=
                new System.EventHandler(this.checkBox_ptHasMachine_CheckedChanged);
            // 
            // label_pressVerified
            // 
            this.label_pressVerified.AutoSize = true;
            this.label_pressVerified.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_pressVerified.Location = new System.Drawing.Point(5, 15);
            this.label_pressVerified.Name = "label_pressVerified";
            this.label_pressVerified.Size = new System.Drawing.Size(144, 20);
            this.label_pressVerified.TabIndex = 43;
            this.label_pressVerified.Text = "Pressure verified at";
            // 
            // comboBox_txVerifiedAT
            // 
            this.comboBox_txVerifiedAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_txVerifiedAT.Items.AddRange(new object[]
            {
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20"
            });
            this.comboBox_txVerifiedAT.Location = new System.Drawing.Point(155, 12);
            this.comboBox_txVerifiedAT.Name = "comboBox_txVerifiedAT";
            this.comboBox_txVerifiedAT.Size = new System.Drawing.Size(54, 28);
            this.comboBox_txVerifiedAT.TabIndex = 45;
            // 
            // label_andChangedTo
            // 
            this.label_andChangedTo.AutoSize = true;
            this.label_andChangedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label_andChangedTo.Location = new System.Drawing.Point(215, 15);
            this.label_andChangedTo.Name = "label_andChangedTo";
            this.label_andChangedTo.Size = new System.Drawing.Size(120, 20);
            this.label_andChangedTo.TabIndex = 44;
            this.label_andChangedTo.Text = "and changed to";
            // 
            // comboBox_txChangedTo
            // 
            this.comboBox_txChangedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_txChangedTo.Items.AddRange(new object[]
            {
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20"
            });
            this.comboBox_txChangedTo.Location = new System.Drawing.Point(341, 12);
            this.comboBox_txChangedTo.Name = "comboBox_txChangedTo";
            this.comboBox_txChangedTo.Size = new System.Drawing.Size(60, 28);
            this.comboBox_txChangedTo.TabIndex = 46;
            // 
            // document
            // 
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.document.Location = new System.Drawing.Point(1374, 453);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(10, 10);
            this.document.TabIndex = 48;
            this.document.Text = "";
            this.document.Visible = false;
            // 
            // button_makeNote
            // 
            this.button_makeNote.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_makeNote.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_makeNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_makeNote.Location = new System.Drawing.Point(733, 419);
            this.button_makeNote.Name = "button_makeNote";
            this.button_makeNote.Size = new System.Drawing.Size(100, 62);
            this.button_makeNote.TabIndex = 21;
            this.button_makeNote.Text = "OK";
            this.button_makeNote.UseVisualStyleBackColor = false;
            this.button_makeNote.Click += new System.EventHandler(this.button_makeNote_Click);
            // 
            // mGoupBoxStudyPerformed
            // 
            this.mGoupBoxStudyPerformed.AutoSize = true;
            this.mGoupBoxStudyPerformed.Controls.Add(this.mGroupCPAP_BIPAP);
            this.mGoupBoxStudyPerformed.Controls.Add(this.mRadioButtonSplitNight);
            this.mGoupBoxStudyPerformed.Controls.Add(this.mRadioButtonCpapBipapTitrat);
            this.mGoupBoxStudyPerformed.Controls.Add(this.mRadioButtonPsg);
            this.mGoupBoxStudyPerformed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mGoupBoxStudyPerformed.Location = new System.Drawing.Point(12, 12);
            this.mGoupBoxStudyPerformed.Name = "mGoupBoxStudyPerformed";
            this.mGoupBoxStudyPerformed.Size = new System.Drawing.Size(320, 161);
            this.mGoupBoxStudyPerformed.TabIndex = 49;
            this.mGoupBoxStudyPerformed.TabStop = false;
            this.mGoupBoxStudyPerformed.Text = "Study Performed";
            // 
            // mGroupCPAP_BIPAP
            // 
            this.mGroupCPAP_BIPAP.Controls.Add(this.mRadioButton_bipap);
            this.mGroupCPAP_BIPAP.Controls.Add(this.mRadioButton_cpap);
            this.mGroupCPAP_BIPAP.Location = new System.Drawing.Point(193, 52);
            this.mGroupCPAP_BIPAP.Name = "mGroupCPAP_BIPAP";
            this.mGroupCPAP_BIPAP.Size = new System.Drawing.Size(108, 84);
            this.mGroupCPAP_BIPAP.TabIndex = 3;
            this.mGroupCPAP_BIPAP.TabStop = false;
            this.mGroupCPAP_BIPAP.Visible = false;
            // 
            // mRadioButton_bipap
            // 
            this.mRadioButton_bipap.AutoSize = true;
            this.mRadioButton_bipap.Location = new System.Drawing.Point(11, 52);
            this.mRadioButton_bipap.Name = "mRadioButton_bipap";
            this.mRadioButton_bipap.Size = new System.Drawing.Size(74, 24);
            this.mRadioButton_bipap.TabIndex = 1;
            this.mRadioButton_bipap.Text = "BIPAP";
            this.mRadioButton_bipap.UseVisualStyleBackColor = true;
            this.mRadioButton_bipap.CheckedChanged += new System.EventHandler(this.cpapBipap_CheckedChanged);
            // 
            // mRadioButton_cpap
            // 
            this.mRadioButton_cpap.AutoSize = true;
            this.mRadioButton_cpap.Location = new System.Drawing.Point(11, 21);
            this.mRadioButton_cpap.Name = "mRadioButton_cpap";
            this.mRadioButton_cpap.Size = new System.Drawing.Size(69, 24);
            this.mRadioButton_cpap.TabIndex = 0;
            this.mRadioButton_cpap.Text = "CPAP";
            this.mRadioButton_cpap.UseVisualStyleBackColor = true;
            this.mRadioButton_cpap.CheckedChanged += new System.EventHandler(this.cpapBipap_CheckedChanged);
            // 
            // mRadioButtonSplitNight
            // 
            this.mRadioButtonSplitNight.AutoSize = true;
            this.mRadioButtonSplitNight.Location = new System.Drawing.Point(6, 85);
            this.mRadioButtonSplitNight.Name = "mRadioButtonSplitNight";
            this.mRadioButtonSplitNight.Size = new System.Drawing.Size(99, 24);
            this.mRadioButtonSplitNight.TabIndex = 2;
            this.mRadioButtonSplitNight.Text = "Split Night";
            this.mRadioButtonSplitNight.UseVisualStyleBackColor = true;
            this.mRadioButtonSplitNight.CheckedChanged += new System.EventHandler(this.studyTypeRadio_CheckedChanged);
            // 
            // mRadioButtonCpapBipapTitrat
            // 
            this.mRadioButtonCpapBipapTitrat.AutoSize = true;
            this.mRadioButtonCpapBipapTitrat.Location = new System.Drawing.Point(6, 55);
            this.mRadioButtonCpapBipapTitrat.Name = "mRadioButtonCpapBipapTitrat";
            this.mRadioButtonCpapBipapTitrat.Size = new System.Drawing.Size(181, 24);
            this.mRadioButtonCpapBipapTitrat.TabIndex = 1;
            this.mRadioButtonCpapBipapTitrat.Text = "CPAP/BIPAP Titration";
            this.mRadioButtonCpapBipapTitrat.UseVisualStyleBackColor = true;
            this.mRadioButtonCpapBipapTitrat.CheckedChanged +=
                new System.EventHandler(this.studyTypeRadio_CheckedChanged);
            // 
            // mRadioButtonPsg
            // 
            this.mRadioButtonPsg.AutoSize = true;
            this.mRadioButtonPsg.Checked = true;
            this.mRadioButtonPsg.Location = new System.Drawing.Point(6, 25);
            this.mRadioButtonPsg.Name = "mRadioButtonPsg";
            this.mRadioButtonPsg.Size = new System.Drawing.Size(140, 24);
            this.mRadioButtonPsg.TabIndex = 0;
            this.mRadioButtonPsg.TabStop = true;
            this.mRadioButtonPsg.Text = "Polysomnogram";
            this.mRadioButtonPsg.UseVisualStyleBackColor = true;
            this.mRadioButtonPsg.CheckedChanged += new System.EventHandler(this.studyTypeRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.checkBox_lat);
            this.groupBox1.Controls.Add(this.checkBox_supine);
            this.groupBox1.Controls.Add(this.checkBox_prone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 135);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Body Position";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.checkBox_modSnor);
            this.groupBox3.Controls.Add(this.checkBox_loudSnor);
            this.groupBox3.Controls.Add(this.checkBox_mildSnor);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.Location = new System.Drawing.Point(152, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 134);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Snoring";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.checkBox_arr);
            this.groupBox4.Controls.Add(this.checkBox_plms);
            this.groupBox4.Controls.Add(this.checkBox_resEvents);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 322);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 134);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Events";
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.checkBoxRemEffect);
            this.groupBox5.Controls.Add(this.checkBoxPositionEffect);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox5.Location = new System.Drawing.Point(870, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 104);
            this.groupBox5.TabIndex = 54;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Effects";
            this.groupBox5.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.checkBox_15lpmO2);
            this.groupBox6.Controls.Add(this.checkBox_ambian);
            this.groupBox6.Controls.Add(this.checkBox_tooLateForCpap);
            this.groupBox6.Controls.Add(this.checkBox_NoCpap);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox6.Location = new System.Drawing.Point(338, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(428, 189);
            this.groupBox6.TabIndex = 55;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Misc";
            // 
            // mCpapBipapInfoGroupBox
            // 
            this.mCpapBipapInfoGroupBox.AutoSize = true;
            this.mCpapBipapInfoGroupBox.Controls.Add(this.mPanelPressVerAndChangedTo);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.mPanelBipap);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.mPanelCpap);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.label_Initial);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.comboBox_maskType);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.label1_maskType);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.checkBox_humidifer);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.checkBox_ptHasMachine);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.checkBox_chinStrap);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.label_maskSize);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.comboBox_maskSize);
            this.mCpapBipapInfoGroupBox.Controls.Add(this.label_final);
            this.mCpapBipapInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mCpapBipapInfoGroupBox.Location = new System.Drawing.Point(285, 207);
            this.mCpapBipapInfoGroupBox.Name = "mCpapBipapInfoGroupBox";
            this.mCpapBipapInfoGroupBox.Size = new System.Drawing.Size(442, 274);
            this.mCpapBipapInfoGroupBox.TabIndex = 56;
            this.mCpapBipapInfoGroupBox.TabStop = false;
            this.mCpapBipapInfoGroupBox.Text = "CPAP/BIPAP Info";
            this.mCpapBipapInfoGroupBox.Visible = false;
            // 
            // mPanelPressVerAndChangedTo
            // 
            this.mPanelPressVerAndChangedTo.AutoSize = true;
            this.mPanelPressVerAndChangedTo.Controls.Add(this.label_pressVerified);
            this.mPanelPressVerAndChangedTo.Controls.Add(this.label_andChangedTo);
            this.mPanelPressVerAndChangedTo.Controls.Add(this.comboBox_txChangedTo);
            this.mPanelPressVerAndChangedTo.Controls.Add(this.comboBox_txVerifiedAT);
            this.mPanelPressVerAndChangedTo.Location = new System.Drawing.Point(10, 202);
            this.mPanelPressVerAndChangedTo.Name = "mPanelPressVerAndChangedTo";
            this.mPanelPressVerAndChangedTo.Size = new System.Drawing.Size(413, 47);
            this.mPanelPressVerAndChangedTo.TabIndex = 57;
            this.mPanelPressVerAndChangedTo.Visible = false;
            // 
            // mPanelBipap
            // 
            this.mPanelBipap.AutoSize = true;
            this.mPanelBipap.Controls.Add(this.comboBox_initIpap);
            this.mPanelBipap.Controls.Add(this.comboBox_finalIpap);
            this.mPanelBipap.Controls.Add(this.comboBox_initialEpap);
            this.mPanelBipap.Controls.Add(this.comboBox_finalEpap);
            this.mPanelBipap.Controls.Add(this.label_slash2);
            this.mPanelBipap.Controls.Add(this.label_slash1);
            this.mPanelBipap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mPanelBipap.Location = new System.Drawing.Point(62, 25);
            this.mPanelBipap.Name = "mPanelBipap";
            this.mPanelBipap.Size = new System.Drawing.Size(163, 83);
            this.mPanelBipap.TabIndex = 57;
            // 
            // mPanelCpap
            // 
            this.mPanelCpap.AutoSize = true;
            this.mPanelCpap.Controls.Add(this.comboBox_iniCpap);
            this.mPanelCpap.Controls.Add(this.comboBox_finalCpap);
            this.mPanelCpap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mPanelCpap.Location = new System.Drawing.Point(58, 33);
            this.mPanelCpap.Name = "mPanelCpap";
            this.mPanelCpap.Size = new System.Drawing.Size(61, 69);
            this.mPanelCpap.TabIndex = 58;
            // 
            // TechNote
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 525);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.mGoupBoxStudyPerformed);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.document);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mCpapBipapInfoGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_makeNote);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "TechNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleep Note";
            this.contextMenuStrip1.ResumeLayout(false);
            this.mGoupBoxStudyPerformed.ResumeLayout(false);
            this.mGoupBoxStudyPerformed.PerformLayout();
            this.mGroupCPAP_BIPAP.ResumeLayout(false);
            this.mGroupCPAP_BIPAP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.mCpapBipapInfoGroupBox.ResumeLayout(false);
            this.mCpapBipapInfoGroupBox.PerformLayout();
            this.mPanelPressVerAndChangedTo.ResumeLayout(false);
            this.mPanelPressVerAndChangedTo.PerformLayout();
            this.mPanelBipap.ResumeLayout(false);
            this.mPanelBipap.PerformLayout();
            this.mPanelCpap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private string getBodyPos()
        {
            var strBodyPos = "";
            for (;;)
            {
                if (checkBox_lat.Checked && checkBox_supine.Checked && !checkBox_prone.Checked)
                {
                    strBodyPos = strBodyPos + "laterally and supine.";
                    break;
                } //endif
                if (checkBox_lat.Checked && checkBox_prone.Checked && !checkBox_supine.Checked)
                {
                    strBodyPos = strBodyPos + "laterally and prone.";
                    break;
                } //endif
                if (checkBox_lat.Checked && !checkBox_supine.Checked && !checkBox_prone.Checked)
                {
                    strBodyPos = strBodyPos + "laterally only.";
                    break;
                } //endif
                if (checkBox_prone.Checked && checkBox_supine.Checked && checkBox_lat.Checked)
                {
                    strBodyPos = strBodyPos + "in all positions.";
                    break;
                } //endif
                if (checkBox_prone.Checked && checkBox_supine.Checked && !checkBox_lat.Checked)
                {
                    strBodyPos = strBodyPos + "prone and supine.";
                    break;
                } //endif
                if (checkBox_prone.Checked)
                {
                    strBodyPos = strBodyPos + "prone only.";
                    break;
                } //endif
                strBodyPos = strBodyPos + "supine only.";
                break;
            } //endfr
            return strBodyPos;
        }

        private string getSnor()
        {
            var strSnoring = "";
            for (;;)
            {
                if (checkBox_mildSnor.Checked && !checkBox_modSnor.Checked && !checkBox_loudSnor.Checked)
                {
                    strSnoring = " Mild " + strSnoring;
                    break;
                } //endif
                if (checkBox_mildSnor.Checked && checkBox_modSnor.Checked && !checkBox_loudSnor.Checked)
                {
                    strSnoring = " Mild to moderate " + strSnoring;
                    break;
                } //endif
                if (!checkBox_mildSnor.Checked && !checkBox_modSnor.Checked && checkBox_loudSnor.Checked)
                {
                    strSnoring = " Loud " + strSnoring;
                    break;
                } //endif
                if (!checkBox_mildSnor.Checked && checkBox_modSnor.Checked && checkBox_loudSnor.Checked)
                {
                    strSnoring = " Moderate to loud " + strSnoring;
                    break;
                } //endif
                if (checkBox_mildSnor.Checked && checkBox_loudSnor.Checked && !checkBox_modSnor.Checked)
                {
                    strSnoring = " Mild to loud " + strSnoring;
                    break;
                } //endif
                if (!checkBox_mildSnor.Checked && !checkBox_modSnor.Checked && !checkBox_loudSnor.Checked)
                {
                    strSnoring = " No " + strSnoring;
                    break;
                } //endif
                if (checkBox_modSnor.Checked && !checkBox_mildSnor.Checked && !checkBox_loudSnor.Checked)
                {
                    strSnoring = " Moderate " + strSnoring;
                    break;
                } //endif
                if (checkBox_modSnor.Checked && checkBox_mildSnor.Checked && checkBox_loudSnor.Checked)
                {
                    strSnoring = " Mild to loud " + strSnoring;
                } //endif

                break;
            } //endfr
            strSnoring += "snoring was heard.";
            if (mRadioButtonCpapBipapTitrat.Checked)
                strSnoring = "";
            return strSnoring;
        }

        private string getArrPlm()
        {
            var strArrPlm = "";
            for (;;)
            {
                if (checkBox_arr.Checked && checkBox_plms.Checked)
                {
                    strArrPlm = " Arrhythmias and PLM's were noted.";
                    break;
                } //endif
                if (checkBox_arr.Checked && !checkBox_plms.Checked)
                {
                    strArrPlm = " Arrhythmias were noted. No PLM's were noted.";
                    break;
                } //endif
                if (checkBox_plms.Checked && !checkBox_arr.Checked)
                {
                    strArrPlm = " PLM's were noted. No arrhythmias were noted.";
                    break;
                } //endif
                if (!checkBox_arr.Checked && !checkBox_plms.Checked)
                {
                    strArrPlm = " Neither arrhythmias nor PLM's were noted.";
                    break;
                } //endif
            } //endfr
            return strArrPlm;
        }

        private string getTxInfo()
        {
            var strTx = "";
            if (mRadioButton_cpap.Checked)
            {
                strTx += " CPAP was initiated at " + comboBox_iniCpap.Text + " cm H2O and was titrated to ";
                strTx += comboBox_finalCpap.Text + " cm H2O.";
            }
            else
            {
                strTx += " BIPAP was initiated at " + comboBox_initIpap.Text + "/";
                strTx += comboBox_initialEpap.Text + " cm H2O and was increased to ";
                strTx += comboBox_finalIpap.Text + "/" + comboBox_finalEpap.Text;
                strTx += " cm H2O.";
            }

            if (comboBox_maskType.Text != "")
                strTx += " A " + comboBox_maskSize.Text + " " + comboBox_maskType.Text + " mask was used.";

            if (checkBox_chinStrap.Checked)
                strTx += " A chin strap was used.";
            if (checkBox_humidifer.Checked)
                strTx += " Heated humidity was used.";


            return strTx;
        }

        private string getResInfo()
        {
            var str = "";
            if (checkBox_resEvents.Checked && !mRadioButtonCpapBipapTitrat.Checked)
                str += " Respiratory events were observed.";
            else
            {
                str += "";
            }
            return str;
        }

        private void button_makeNote_Click(object sender, EventArgs e)
        {
            var strBodyPos = "The patient slept " + getBodyPos();
            var strSnoring = getSnor();
            var strResEvents = getResInfo();

            //string cpap = "";
            var output = "";

            if (checkBox_ambian.Checked)
                output += " The patient took 10 mg Ambien as per protocol.";
            if (checkBox_15lpmO2.Checked)
                output += " The patient was placed on 15 lpm O2 via NRB mask as per protocol.";
            output += strBodyPos;
            output += strSnoring;
            output += strResEvents;

            if (checkBox_tooLateForCpap.Checked)
                output += " The patient did not meet criteria for CPAP until too late to begin treatment.";
            if (checkBox_NoCpap.Checked)
                output += " The patient did not meet split night criteria to initiate CPAP.";

            if (mRadioButton_cpap.Checked || mRadioButton_bipap.Checked)
                output += getTxInfo();
            output += getArrPlm();
            if (checkBox_ptHasMachine.Checked)
            {
                output += " Patient has and brought machine. Pressure verified at ";
                output += comboBox_txVerifiedAT.Text + " cm H2O and changed to ";
                output += comboBox_txChangedTo.Text + " cm H2O.";
            }

            output = getEffects(output);

            document.Text = output; //
            document.SelectAll();
            document.Copy();

            if (passControl != null)
            {
                passControl(output);
            }

            Close();
        }

        private string getEffects(string output)
        {
            if (checkBoxPositionEffect.Checked)
            {
                output += " A position effect is noted.";
            }
            if (checkBoxRemEffect.Checked)
            {
                output += " A REM effect is noted.";
            }
            return output;
        }

        private void resetValues()
        {
            checkBox_supine.Checked = false;
            checkBox_prone.Checked = false;
            checkBox_lat.Checked = false;
            checkBox_loudSnor.Checked = false;
            checkBox_modSnor.Checked = false;
            checkBox_mildSnor.Checked = false;
            mRadioButton_cpap.Checked = false;
            mRadioButton_bipap.Checked = false;
            checkBox_chinStrap.Checked = false;
            checkBox_humidifer.Checked = false;
            checkBox_resEvents.Checked = false;
            checkBox_plms.Checked = false;
            checkBox_arr.Checked = false;
            checkBox_ptHasMachine.Checked = false;
            checkBox_humidifer.Checked = false;
            checkBox_15lpmO2.Checked = false;
            checkBox_tooLateForCpap.Checked = false;
            checkBox_ambian.Checked = false;
            comboBox_iniCpap.Text = "";
            comboBox_finalCpap.Text = "";
            comboBox_finalEpap.Text = "";
            comboBox_finalIpap.Text = "";
            comboBox_initialEpap.Text = "";
            comboBox_initIpap.Text = "";
            comboBox_maskSize.Text = "";
            comboBox_maskSize.Text = "";
            comboBox_txVerifiedAT.Text = "";
            comboBox_txChangedTo.Text = "";
            checkBoxRemEffect.Checked = false;
            checkBoxPositionEffect.Checked = false;
        }


        private void UpdateSettings(ComboBox cmb, ArrayList list, bool addItem)
        {
            try
            {
                var tx = new textInput();

                if (tx.ShowDialog() == DialogResult.OK)
                {
                    if (addItem)
                    {
                        var i = cmb.Items.Add(tx.document.Text);
                        list.Add(tx.document.Text);
                        cmb.SelectedIndex = i;
                    }
                    else //remove item
                    {
                        cmb.Items.Remove(tx.document.Text);
                        list.Remove(tx.document.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not update item");
            }
        }


        private void comboBox_maskType_KeyDown(object sender, KeyEventArgs e)
        {
            var index = 0;
            var cbo = (ComboBox) sender;
            index = cbo.FindStringExact(cbo.Text);

            // We only want to do something if the enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // FindStringExact searches for the string and is not
                // case-sensitive, which
                // is exactly what we need, as Programmer and programmer is the same.
                // If we find a match we'll move the selection in the ComboBox to
                // that item.
                index = cbo.FindStringExact(cbo.Text);
                if (index < 0) // FindStringExact return -1 if nothing was found.
                    cbo.Items.Add(cbo.Text);
                else
                    cbo.SelectedIndex = index;

                // Signal that we've handled the key down event
                e.Handled = true;
            }
        }


// 		private void checkBox_cpap_CheckedChanged(object sender, System.EventArgs e)
// 		{
// 			this.checkBox_bipap.Checked=false;
// 
// 
// 			if (this.label1_maskType.Visible)
// 			{
// 				this.label1_maskType.Visible=false;
// 				this.label_maskSize.Visible=false;
// 				this.comboBox_maskType.Visible=false;
// 				this.comboBox_maskSize.Visible=false;
// 				this.checkBox_chinStrap.Visible=false;
// 				this.checkBox_humidifer.Visible=false;
// 				this.checkBox_ptHasMachine.Visible=false;
// 				
// 			}
// 			else
// 			{
// 				this.label1_maskType.Visible=true;
// 				this.label_maskSize.Visible=true;
// 				this.comboBox_maskType.Visible=true;
// 				this.comboBox_maskSize.Visible=true;
// 				this.checkBox_chinStrap.Visible=true;
// 				this.checkBox_humidifer.Visible=true;
// 				this.checkBox_ptHasMachine.Visible=true;
// 
// 			}
// 
// 			if(this.comboBox_iniCpap.Visible)
// 			{
// 				this.comboBox_iniCpap.Visible = false;
// 				this.label_Initial.Visible=false;
// 			}
// 			else 
// 			{
// 				this.comboBox_iniCpap.Visible = true;
// 				this.label_Initial.Visible=true;
// 			}
// 			
// 			if(this.comboBox_finalCpap.Visible)
// 			{
// 				this.comboBox_finalCpap.Visible= false;
// 				this.label_final.Visible=false;
// 			}
// 			else
// 			{
// 				this.comboBox_finalCpap.Visible = true;
// 				this.label_final.Visible=true;
// 			}
// 		}

// 		private void checkBox_bipap_CheckedChanged(object sender, System.EventArgs e)
// 		{
// 			this.checkBox_cpap.Checked=false;
// 			if (this.label1_maskType.Visible)
// 			{
// 				this.label1_maskType.Visible=false;
// 				this.label_maskSize.Visible=false;
// 				this.comboBox_maskType.Visible=false;
// 				this.comboBox_maskSize.Visible=false;
// 				this.checkBox_chinStrap.Visible=false;
// 				this.checkBox_humidifer.Visible=false;
// 			}
// 			else
// 			{
// 				this.label1_maskType.Visible=true;
// 				this.label_maskSize.Visible=true;
// 				this.comboBox_maskType.Visible=true;
// 				this.comboBox_maskSize.Visible=true;
// 				this.checkBox_chinStrap.Visible=true;
// 				this.checkBox_humidifer.Visible=true;
// 
// 			}
// 
// 			if(this.comboBox_initIpap.Visible)
// 			{
// 				this.comboBox_initIpap.Visible = false;
// 				this.label_slash1.Visible=false;
// 				this.label_Initial.Visible=false;
// 			}
// 			else 
// 			{
// 				this.comboBox_initIpap.Visible = true;
// 				this.label_slash1.Visible=true;
// 				this.label_Initial.Visible=true;
// 			}
// 
// 			if(this.comboBox_initialEpap.Visible)
// 			{
// 				this.comboBox_initialEpap.Visible = false;
// 				this.label_slash2.Visible=false;
// 				this.label_Initial.Visible=false;
// 			}
// 			else 
// 			{
// 				this.comboBox_initialEpap.Visible = true;
// 				this.label_slash2.Visible = true;
// 				this.label_Initial.Visible=true;
// 			}
// 
// 			if(this.comboBox_finalEpap.Visible)
// 			{
// 				this.comboBox_finalEpap.Visible= false;
// 				this.label_final.Visible=false;
// 			}
// 			else
// 			{
// 				this.comboBox_finalEpap.Visible = true;
// 				this.label_final.Visible=true;
// 			}
// 
// 			
// 			if(this.comboBox_finalIpap.Visible)
// 			{
// 				this.comboBox_finalIpap.Visible= false;
// 				this.label_final.Visible=false;
// 			}
// 			else
// 			{
// 				this.comboBox_finalIpap.Visible = true;
// 				this.label_final.Visible=true;
// 			}
// 		
// 		}
// 
// 		private void checkBox_ptHasMachine_CheckedChanged(object sender, System.EventArgs e)
// 		{
// 			if(this.comboBox_txVerifiedAT.Visible)
// 			{
// 				this.comboBox_txVerifiedAT.Visible=false;
// 				this.comboBox_txChangedTo.Visible=false;
// 				this.label_pressVerified.Visible=false;
// 				this.label_andChangedTo.Visible=false;
// 			}
// 			else 
// 			{
// 				this.comboBox_txVerifiedAT.Visible=true;
// 				this.comboBox_txChangedTo.Visible=true;
// 				this.label_pressVerified.Visible=true;
// 				this.label_andChangedTo.Visible=true;
// 
// 			}
// 		}

        private void addTechnicianNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void maskTypeToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            UpdateSettings(comboBox_maskType, sleepEdit.maskType, true);
        }

        private void maskTypeToolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            UpdateSettings(comboBox_maskType, sleepEdit.maskType, false);
        }

        private void maskSizeToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            UpdateSettings(comboBox_maskSize, sleepEdit.maskSize, true);
        }

        private void maskSizeToolStripMenuItemRemove_Click(object sender, EventArgs e)
        {
            UpdateSettings(comboBox_maskSize, sleepEdit.maskSize, false);
        }

        private void studyTypeRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (mRadioButtonCpapBipapTitrat.Checked || mRadioButtonSplitNight.Checked)
            {
                mGroupCPAP_BIPAP.Visible = true;
                mCpapBipapInfoGroupBox.Visible = true;
                mRadioButton_cpap.Checked = true;
            }
            else
            {
                mGroupCPAP_BIPAP.Visible = false;
                mCpapBipapInfoGroupBox.Visible = false;
            }
        }

        private void cpapBipap_CheckedChanged(object sender, EventArgs e)
        {
            if (mRadioButton_cpap.Checked)
            {
                mPanelCpap.Visible = true;
                mPanelBipap.Visible = false;
            }
            else
            {
                mPanelCpap.Visible = false;
                mPanelBipap.Visible = true;
            }
        }

        private void checkBox_ptHasMachine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ptHasMachine.Checked && mCpapBipapInfoGroupBox.Visible)
            {
                mPanelPressVerAndChangedTo.Visible = true;
            }
            else
            {
                mPanelPressVerAndChangedTo.Visible = false;
            }
        }

        #region variables

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addTechnicianNameToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem maskTypeToolStripMenuItemAdd;
        private ToolStripMenuItem maskSizeToolStripMenuItemAdd;
        private ToolStripMenuItem maskTypeToolStripMenuItemRemove;
        private ToolStripMenuItem maskSizeToolStripMenuItemRemove;
        private Button button_makeNote;
        private CheckBox checkBox_lat;
        private CheckBox checkBox_prone;
        private CheckBox checkBox_supine;
        private CheckBox checkBox_modSnor;
        private CheckBox checkBox_loudSnor;
        private CheckBox checkBox_mildSnor;
        private CheckBox checkBox_plms;
        private CheckBox checkBox_resEvents;
        private CheckBox checkBox_arr;
        private CheckBox checkBoxRemEffect;
        private CheckBox checkBoxPositionEffect;
        private CheckBox checkBox_ambian;
        private CheckBox checkBox_15lpmO2;
        private CheckBox checkBox_tooLateForCpap;
        private CheckBox checkBox_NoCpap;
        private ComboBox comboBox_finalEpap;
        private ComboBox comboBox_iniCpap;
        private Label label_Initial;
        private ComboBox comboBox_finalCpap;
        private Label label_final;
        private ComboBox comboBox_initIpap;
        private ComboBox comboBox_finalIpap;
        private ComboBox comboBox_initialEpap;
        private Label label_slash1;
        private Label label_slash2;
        private RichTextBox document;
        private Label label1_maskType;
        private ComboBox comboBox_maskType;
        private Label label_maskSize;
        private ComboBox comboBox_maskSize;
        private CheckBox checkBox_chinStrap;
        private CheckBox checkBox_humidifer;
        private CheckBox checkBox_ptHasMachine;
        private Label label_pressVerified;
        private ComboBox comboBox_txVerifiedAT;
        private Label label_andChangedTo;
        private ComboBox comboBox_txChangedTo;
        private GroupBox mGoupBoxStudyPerformed;
        private RadioButton mRadioButtonSplitNight;
        private RadioButton mRadioButtonCpapBipapTitrat;
        private RadioButton mRadioButtonPsg;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private RadioButton mRadioButton_bipap;
        private RadioButton mRadioButton_cpap;
        private GroupBox mGroupCPAP_BIPAP;
        private GroupBox mCpapBipapInfoGroupBox;
        private Panel mPanelBipap;
        private Panel mPanelCpap;
        private Panel mPanelPressVerAndChangedTo;
        private IContainer components;

        #endregion
    }
}