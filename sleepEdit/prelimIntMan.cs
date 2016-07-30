using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for prelimIntMan.
    /// </summary>
    public class prelimIntMan : Form
    {
        private Button button1;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private ContextMenu contextMenu_all;
        private GroupBox groupBox_diag;
        private GroupBox groupBox_psg;
        private GroupBox groupBox_tx;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label3;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label4;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        public RadioButton radioButton_Psgonly;
        public RadioButton radioButton_splitstudy;
        public RadioButton radioButton_titration;
        public TextBox textBox_diagAvgSpo2;
        public TextBox textBox_diagLatRdi;
        public TextBox textBox_diagLatTime;
        public TextBox textBox_diagLowSpo2;
        public TextBox textBox_diagRemRdi;
        public TextBox textBox_diagRemTime;
        public TextBox textBox_diagSupRdi;
        public TextBox textBox_diagSupTime;
        public TextBox textBox_diagTotRdi;
        public TextBox textBox_diagTst;
        public TextBox textBox_finalAvgSpo2;
        public TextBox textBox_finalLatRdi;
        public TextBox textBox_finalLatSpo2;
        public TextBox textBox_finalLatTime;
        public TextBox textBox_finalRdi;
        public TextBox textBox_finalRemTime;
        public TextBox textBox_finalSupRdi;
        public TextBox textBox_finalSupTime;
        public TextBox textBox_finalTotRdi;
        public TextBox textBox_finalTst;
        public TextBox textBox_FinalTx;
        public TextBox textBox_plmArrIdx;
        public TextBox textBox_plmIdx;
        public TextBox textBox_psgAvgSpo2;
        public TextBox textBox_psgLatRdi;
        public TextBox textBox_PsgLatTime;
        public TextBox textBox_psgLowSpo2;
        public TextBox textBox_psgRem;
        public TextBox textBox_PsgRemRdi;
        public TextBox textBox_psgSupRdi;
        public TextBox textBox_psgSupTime;
        public TextBox textBox_psgTotRdi;
        public TextBox textBox_PsgTST;
        public TextBox textBox_PtAge;
        public TextBox textBox_remLat;
        public TextBox textBox_remTst;
        public TextBox textBox_s1tst;
        public TextBox textBox_s2Tst;
        public TextBox textBox_sleepEff;
        public TextBox textBox_slpLat;
        public TextBox textBox_swsTst;
        public TextBox textBox_TST;
        public TextBox textBox_wakeTst;

        public prelimIntMan()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.textBox_PtAge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_plmArrIdx = new System.Windows.Forms.TextBox();
            this.textBox_plmIdx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_sleepEff = new System.Windows.Forms.TextBox();
            this.textBox_remLat = new System.Windows.Forms.TextBox();
            this.textBox_slpLat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_remTst = new System.Windows.Forms.TextBox();
            this.textBox_swsTst = new System.Windows.Forms.TextBox();
            this.textBox_s2Tst = new System.Windows.Forms.TextBox();
            this.textBox_s1tst = new System.Windows.Forms.TextBox();
            this.textBox_wakeTst = new System.Windows.Forms.TextBox();
            this.textBox_TST = new System.Windows.Forms.TextBox();
            this.groupBox_psg = new System.Windows.Forms.GroupBox();
            this.textBox_psgAvgSpo2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_psgLowSpo2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_psgLatRdi = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_psgSupRdi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_PsgRemRdi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_psgTotRdi = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_psgRem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_PsgLatTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_psgSupTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_PsgTST = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox_diag = new System.Windows.Forms.GroupBox();
            this.textBox_diagAvgSpo2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_diagLowSpo2 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox_diagLatRdi = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox_diagSupRdi = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox_diagRemRdi = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_diagTotRdi = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_diagRemTime = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox_diagLatTime = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox_diagSupTime = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox_diagTst = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox_tx = new System.Windows.Forms.GroupBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox_FinalTx = new System.Windows.Forms.TextBox();
            this.textBox_finalAvgSpo2 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox_finalLatSpo2 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox_finalLatRdi = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox_finalSupRdi = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_finalRdi = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox_finalTotRdi = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox_finalRemTime = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox_finalLatTime = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox_finalSupTime = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox_finalTst = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton_titration = new System.Windows.Forms.RadioButton();
            this.radioButton_splitstudy = new System.Windows.Forms.RadioButton();
            this.radioButton_Psgonly = new System.Windows.Forms.RadioButton();
            this.contextMenu_all = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox_psg.SuspendLayout();
            this.groupBox_diag.SuspendLayout();
            this.groupBox_tx.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label42);
            this.groupBox1.Controls.Add(this.textBox_PtAge);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_plmArrIdx);
            this.groupBox1.Controls.Add(this.textBox_plmIdx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_sleepEff);
            this.groupBox1.Controls.Add(this.textBox_remLat);
            this.groupBox1.Controls.Add(this.textBox_slpLat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_remTst);
            this.groupBox1.Controls.Add(this.textBox_swsTst);
            this.groupBox1.Controls.Add(this.textBox_s2Tst);
            this.groupBox1.Controls.Add(this.textBox_s1tst);
            this.groupBox1.Controls.Add(this.textBox_wakeTst);
            this.groupBox1.Controls.Add(this.textBox_TST);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Sleep Parameters";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(14, 25);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(96, 20);
            this.label42.TabIndex = 24;
            this.label42.Text = "Patient Age:";
            // 
            // textBox_PtAge
            // 
            this.textBox_PtAge.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PtAge.Location = new System.Drawing.Point(224, 21);
            this.textBox_PtAge.Name = "textBox_PtAge";
            this.textBox_PtAge.Size = new System.Drawing.Size(62, 26);
            this.textBox_PtAge.TabIndex = 23;
            this.textBox_PtAge.Text = "25";
            this.textBox_PtAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "PLM aroual Index:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "PLM index:";
            // 
            // textBox_plmArrIdx
            // 
            this.textBox_plmArrIdx.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_plmArrIdx.Location = new System.Drawing.Point(224, 327);
            this.textBox_plmArrIdx.Name = "textBox_plmArrIdx";
            this.textBox_plmArrIdx.Size = new System.Drawing.Size(62, 26);
            this.textBox_plmArrIdx.TabIndex = 25;
            this.textBox_plmArrIdx.Text = "9.9";
            // 
            // textBox_plmIdx
            // 
            this.textBox_plmIdx.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_plmIdx.Location = new System.Drawing.Point(224, 296);
            this.textBox_plmIdx.Name = "textBox_plmIdx";
            this.textBox_plmIdx.Size = new System.Drawing.Size(62, 26);
            this.textBox_plmIdx.TabIndex = 18;
            this.textBox_plmIdx.Text = "16.5";
            this.textBox_plmIdx.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sleep Efficiency:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "REM Latency (Min);";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Sleep Latency (Min);";
            // 
            // textBox_sleepEff
            // 
            this.textBox_sleepEff.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_sleepEff.Location = new System.Drawing.Point(224, 267);
            this.textBox_sleepEff.Name = "textBox_sleepEff";
            this.textBox_sleepEff.Size = new System.Drawing.Size(62, 26);
            this.textBox_sleepEff.TabIndex = 14;
            this.textBox_sleepEff.Text = "73.2";
            this.textBox_sleepEff.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_remLat
            // 
            this.textBox_remLat.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_remLat.Location = new System.Drawing.Point(224, 235);
            this.textBox_remLat.Name = "textBox_remLat";
            this.textBox_remLat.Size = new System.Drawing.Size(62, 26);
            this.textBox_remLat.TabIndex = 13;
            this.textBox_remLat.Text = "133.0";
            this.textBox_remLat.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_slpLat
            // 
            this.textBox_slpLat.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_slpLat.Location = new System.Drawing.Point(224, 203);
            this.textBox_slpLat.Name = "textBox_slpLat";
            this.textBox_slpLat.Size = new System.Drawing.Size(62, 26);
            this.textBox_slpLat.TabIndex = 12;
            this.textBox_slpLat.Text = "5.0";
            this.textBox_slpLat.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "REM %TST:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "N3 %TST:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "N2 %TST:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "N1 %TST:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "W % TST:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Sleep Time (min);";
            // 
            // textBox_remTst
            // 
            this.textBox_remTst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_remTst.Location = new System.Drawing.Point(224, 177);
            this.textBox_remTst.Name = "textBox_remTst";
            this.textBox_remTst.Size = new System.Drawing.Size(62, 26);
            this.textBox_remTst.TabIndex = 5;
            this.textBox_remTst.Text = "15.9";
            this.textBox_remTst.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_swsTst
            // 
            this.textBox_swsTst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_swsTst.Location = new System.Drawing.Point(224, 151);
            this.textBox_swsTst.Name = "textBox_swsTst";
            this.textBox_swsTst.Size = new System.Drawing.Size(62, 26);
            this.textBox_swsTst.TabIndex = 4;
            this.textBox_swsTst.Text = "0";
            this.textBox_swsTst.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_s2Tst
            // 
            this.textBox_s2Tst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_s2Tst.Location = new System.Drawing.Point(224, 125);
            this.textBox_s2Tst.Name = "textBox_s2Tst";
            this.textBox_s2Tst.Size = new System.Drawing.Size(62, 26);
            this.textBox_s2Tst.TabIndex = 3;
            this.textBox_s2Tst.Text = "68.7";
            this.textBox_s2Tst.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_s1tst
            // 
            this.textBox_s1tst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_s1tst.Location = new System.Drawing.Point(224, 99);
            this.textBox_s1tst.Name = "textBox_s1tst";
            this.textBox_s1tst.Size = new System.Drawing.Size(62, 26);
            this.textBox_s1tst.TabIndex = 2;
            this.textBox_s1tst.Text = "15.4";
            this.textBox_s1tst.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_wakeTst
            // 
            this.textBox_wakeTst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_wakeTst.Location = new System.Drawing.Point(224, 73);
            this.textBox_wakeTst.Name = "textBox_wakeTst";
            this.textBox_wakeTst.Size = new System.Drawing.Size(62, 26);
            this.textBox_wakeTst.TabIndex = 1;
            this.textBox_wakeTst.Text = "18";
            this.textBox_wakeTst.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // textBox_TST
            // 
            this.textBox_TST.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TST.Location = new System.Drawing.Point(224, 47);
            this.textBox_TST.Name = "textBox_TST";
            this.textBox_TST.Size = new System.Drawing.Size(62, 26);
            this.textBox_TST.TabIndex = 0;
            this.textBox_TST.Text = "389.5";
            this.textBox_TST.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // groupBox_psg
            // 
            this.groupBox_psg.AutoSize = true;
            this.groupBox_psg.Controls.Add(this.textBox_psgAvgSpo2);
            this.groupBox_psg.Controls.Add(this.label21);
            this.groupBox_psg.Controls.Add(this.textBox_psgLowSpo2);
            this.groupBox_psg.Controls.Add(this.label20);
            this.groupBox_psg.Controls.Add(this.textBox_psgLatRdi);
            this.groupBox_psg.Controls.Add(this.label19);
            this.groupBox_psg.Controls.Add(this.textBox_psgSupRdi);
            this.groupBox_psg.Controls.Add(this.label18);
            this.groupBox_psg.Controls.Add(this.textBox_PsgRemRdi);
            this.groupBox_psg.Controls.Add(this.label17);
            this.groupBox_psg.Controls.Add(this.textBox_psgTotRdi);
            this.groupBox_psg.Controls.Add(this.label16);
            this.groupBox_psg.Controls.Add(this.textBox_psgRem);
            this.groupBox_psg.Controls.Add(this.label15);
            this.groupBox_psg.Controls.Add(this.textBox_PsgLatTime);
            this.groupBox_psg.Controls.Add(this.label14);
            this.groupBox_psg.Controls.Add(this.textBox_psgSupTime);
            this.groupBox_psg.Controls.Add(this.label13);
            this.groupBox_psg.Controls.Add(this.textBox_PsgTST);
            this.groupBox_psg.Controls.Add(this.label10);
            this.groupBox_psg.Location = new System.Drawing.Point(341, 99);
            this.groupBox_psg.Name = "groupBox_psg";
            this.groupBox_psg.Size = new System.Drawing.Size(235, 302);
            this.groupBox_psg.TabIndex = 1;
            this.groupBox_psg.TabStop = false;
            this.groupBox_psg.Text = "PSG ONLY";
            // 
            // textBox_psgAvgSpo2
            // 
            this.textBox_psgAvgSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgAvgSpo2.Location = new System.Drawing.Point(174, 247);
            this.textBox_psgAvgSpo2.Name = "textBox_psgAvgSpo2";
            this.textBox_psgAvgSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgAvgSpo2.TabIndex = 19;
            this.textBox_psgAvgSpo2.Text = "0.0";
            this.textBox_psgAvgSpo2.WordWrap = false;
            this.textBox_psgAvgSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(10, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "Avg SpO2:";
            // 
            // textBox_psgLowSpo2
            // 
            this.textBox_psgLowSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgLowSpo2.Location = new System.Drawing.Point(174, 224);
            this.textBox_psgLowSpo2.Name = "textBox_psgLowSpo2";
            this.textBox_psgLowSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgLowSpo2.TabIndex = 17;
            this.textBox_psgLowSpo2.Text = "0.0";
            this.textBox_psgLowSpo2.WordWrap = false;
            this.textBox_psgLowSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 224);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "Lowest SpO2:";
            // 
            // textBox_psgLatRdi
            // 
            this.textBox_psgLatRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgLatRdi.Location = new System.Drawing.Point(174, 203);
            this.textBox_psgLatRdi.Name = "textBox_psgLatRdi";
            this.textBox_psgLatRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgLatRdi.TabIndex = 15;
            this.textBox_psgLatRdi.Text = "0.0";
            this.textBox_psgLatRdi.WordWrap = false;
            this.textBox_psgLatRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 203);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "Lateral RDI:";
            // 
            // textBox_psgSupRdi
            // 
            this.textBox_psgSupRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgSupRdi.Location = new System.Drawing.Point(174, 177);
            this.textBox_psgSupRdi.Name = "textBox_psgSupRdi";
            this.textBox_psgSupRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgSupRdi.TabIndex = 13;
            this.textBox_psgSupRdi.Text = "0.0";
            this.textBox_psgSupRdi.WordWrap = false;
            this.textBox_psgSupRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 177);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Supine RDI:";
            // 
            // textBox_PsgRemRdi
            // 
            this.textBox_PsgRemRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PsgRemRdi.Location = new System.Drawing.Point(174, 153);
            this.textBox_PsgRemRdi.Name = "textBox_PsgRemRdi";
            this.textBox_PsgRemRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_PsgRemRdi.TabIndex = 11;
            this.textBox_PsgRemRdi.Text = "0.0";
            this.textBox_PsgRemRdi.WordWrap = false;
            this.textBox_PsgRemRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 20);
            this.label17.TabIndex = 10;
            this.label17.Text = "REM RDI:";
            // 
            // textBox_psgTotRdi
            // 
            this.textBox_psgTotRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgTotRdi.Location = new System.Drawing.Point(174, 130);
            this.textBox_psgTotRdi.Name = "textBox_psgTotRdi";
            this.textBox_psgTotRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgTotRdi.TabIndex = 9;
            this.textBox_psgTotRdi.Text = "0.0";
            this.textBox_psgTotRdi.WordWrap = false;
            this.textBox_psgTotRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Total RDI:";
            // 
            // textBox_psgRem
            // 
            this.textBox_psgRem.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgRem.Location = new System.Drawing.Point(174, 104);
            this.textBox_psgRem.Name = "textBox_psgRem";
            this.textBox_psgRem.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgRem.TabIndex = 7;
            this.textBox_psgRem.Text = "0.0";
            this.textBox_psgRem.WordWrap = false;
            this.textBox_psgRem.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "REM Time (Min);";
            // 
            // textBox_PsgLatTime
            // 
            this.textBox_PsgLatTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PsgLatTime.Location = new System.Drawing.Point(174, 78);
            this.textBox_PsgLatTime.Name = "textBox_PsgLatTime";
            this.textBox_PsgLatTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_PsgLatTime.TabIndex = 5;
            this.textBox_PsgLatTime.Text = "0.0";
            this.textBox_PsgLatTime.WordWrap = false;
            this.textBox_PsgLatTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Lat Sleep Time (Min):";
            // 
            // textBox_psgSupTime
            // 
            this.textBox_psgSupTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_psgSupTime.Location = new System.Drawing.Point(174, 52);
            this.textBox_psgSupTime.Name = "textBox_psgSupTime";
            this.textBox_psgSupTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_psgSupTime.TabIndex = 3;
            this.textBox_psgSupTime.Text = "0.0";
            this.textBox_psgSupTime.WordWrap = false;
            this.textBox_psgSupTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Supine Sleep (min):";
            // 
            // textBox_PsgTST
            // 
            this.textBox_PsgTST.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PsgTST.Location = new System.Drawing.Point(174, 26);
            this.textBox_PsgTST.Name = "textBox_PsgTST";
            this.textBox_PsgTST.Size = new System.Drawing.Size(55, 26);
            this.textBox_PsgTST.TabIndex = 1;
            this.textBox_PsgTST.Text = "0.0";
            this.textBox_PsgTST.WordWrap = false;
            this.textBox_PsgTST.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "TST:";
            // 
            // groupBox_diag
            // 
            this.groupBox_diag.Controls.Add(this.textBox_diagAvgSpo2);
            this.groupBox_diag.Controls.Add(this.label22);
            this.groupBox_diag.Controls.Add(this.textBox_diagLowSpo2);
            this.groupBox_diag.Controls.Add(this.label23);
            this.groupBox_diag.Controls.Add(this.textBox_diagLatRdi);
            this.groupBox_diag.Controls.Add(this.label24);
            this.groupBox_diag.Controls.Add(this.textBox_diagSupRdi);
            this.groupBox_diag.Controls.Add(this.label25);
            this.groupBox_diag.Controls.Add(this.textBox_diagRemRdi);
            this.groupBox_diag.Controls.Add(this.label26);
            this.groupBox_diag.Controls.Add(this.textBox_diagTotRdi);
            this.groupBox_diag.Controls.Add(this.label27);
            this.groupBox_diag.Controls.Add(this.textBox_diagRemTime);
            this.groupBox_diag.Controls.Add(this.label28);
            this.groupBox_diag.Controls.Add(this.textBox_diagLatTime);
            this.groupBox_diag.Controls.Add(this.label29);
            this.groupBox_diag.Controls.Add(this.textBox_diagSupTime);
            this.groupBox_diag.Controls.Add(this.label30);
            this.groupBox_diag.Controls.Add(this.textBox_diagTst);
            this.groupBox_diag.Controls.Add(this.label31);
            this.groupBox_diag.Location = new System.Drawing.Point(329, 99);
            this.groupBox_diag.Name = "groupBox_diag";
            this.groupBox_diag.Size = new System.Drawing.Size(266, 300);
            this.groupBox_diag.TabIndex = 2;
            this.groupBox_diag.TabStop = false;
            this.groupBox_diag.Text = "Diagnostic Portion";
            // 
            // textBox_diagAvgSpo2
            // 
            this.textBox_diagAvgSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagAvgSpo2.Location = new System.Drawing.Point(205, 250);
            this.textBox_diagAvgSpo2.Name = "textBox_diagAvgSpo2";
            this.textBox_diagAvgSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagAvgSpo2.TabIndex = 19;
            this.textBox_diagAvgSpo2.Text = "94";
            this.textBox_diagAvgSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 18;
            this.label22.Text = "Avg SpO2:";
            // 
            // textBox_diagLowSpo2
            // 
            this.textBox_diagLowSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagLowSpo2.Location = new System.Drawing.Point(205, 224);
            this.textBox_diagLowSpo2.Name = "textBox_diagLowSpo2";
            this.textBox_diagLowSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagLowSpo2.TabIndex = 17;
            this.textBox_diagLowSpo2.Text = "76";
            this.textBox_diagLowSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 20);
            this.label23.TabIndex = 16;
            this.label23.Text = "Lowest SpO2:";
            // 
            // textBox_diagLatRdi
            // 
            this.textBox_diagLatRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagLatRdi.Location = new System.Drawing.Point(205, 200);
            this.textBox_diagLatRdi.Name = "textBox_diagLatRdi";
            this.textBox_diagLatRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagLatRdi.TabIndex = 15;
            this.textBox_diagLatRdi.Text = "24";
            this.textBox_diagLatRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 203);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 20);
            this.label24.TabIndex = 14;
            this.label24.Text = "Lat RDI:";
            // 
            // textBox_diagSupRdi
            // 
            this.textBox_diagSupRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagSupRdi.Location = new System.Drawing.Point(205, 174);
            this.textBox_diagSupRdi.Name = "textBox_diagSupRdi";
            this.textBox_diagSupRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagSupRdi.TabIndex = 13;
            this.textBox_diagSupRdi.Text = "83";
            this.textBox_diagSupRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 177);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 20);
            this.label25.TabIndex = 12;
            this.label25.Text = "Supine RDI:";
            // 
            // textBox_diagRemRdi
            // 
            this.textBox_diagRemRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagRemRdi.Location = new System.Drawing.Point(205, 153);
            this.textBox_diagRemRdi.Name = "textBox_diagRemRdi";
            this.textBox_diagRemRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagRemRdi.TabIndex = 11;
            this.textBox_diagRemRdi.Text = "120";
            this.textBox_diagRemRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 20);
            this.label26.TabIndex = 10;
            this.label26.Text = "REM RDI:";
            // 
            // textBox_diagTotRdi
            // 
            this.textBox_diagTotRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagTotRdi.Location = new System.Drawing.Point(205, 125);
            this.textBox_diagTotRdi.Name = "textBox_diagTotRdi";
            this.textBox_diagTotRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagTotRdi.TabIndex = 9;
            this.textBox_diagTotRdi.Text = "39";
            this.textBox_diagTotRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 130);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(81, 20);
            this.label27.TabIndex = 8;
            this.label27.Text = "Total RDI:";
            // 
            // textBox_diagRemTime
            // 
            this.textBox_diagRemTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagRemTime.Location = new System.Drawing.Point(205, 97);
            this.textBox_diagRemTime.Name = "textBox_diagRemTime";
            this.textBox_diagRemTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagRemTime.TabIndex = 7;
            this.textBox_diagRemTime.Text = "6.0";
            this.textBox_diagRemTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 104);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(126, 20);
            this.label28.TabIndex = 6;
            this.label28.Text = "REM Time (Min);";
            // 
            // textBox_diagLatTime
            // 
            this.textBox_diagLatTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagLatTime.Location = new System.Drawing.Point(205, 72);
            this.textBox_diagLatTime.Name = "textBox_diagLatTime";
            this.textBox_diagLatTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagLatTime.TabIndex = 5;
            this.textBox_diagLatTime.Text = "126.0";
            this.textBox_diagLatTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(10, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(158, 20);
            this.label29.TabIndex = 4;
            this.label29.Text = "Lat Sleep Time (Min):";
            // 
            // textBox_diagSupTime
            // 
            this.textBox_diagSupTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagSupTime.Location = new System.Drawing.Point(205, 47);
            this.textBox_diagSupTime.Name = "textBox_diagSupTime";
            this.textBox_diagSupTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagSupTime.TabIndex = 3;
            this.textBox_diagSupTime.Text = "29.5";
            this.textBox_diagSupTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(10, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(147, 20);
            this.label30.TabIndex = 2;
            this.label30.Text = "Supine Sleep (min):";
            // 
            // textBox_diagTst
            // 
            this.textBox_diagTst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_diagTst.Location = new System.Drawing.Point(205, 21);
            this.textBox_diagTst.Name = "textBox_diagTst";
            this.textBox_diagTst.Size = new System.Drawing.Size(55, 26);
            this.textBox_diagTst.TabIndex = 1;
            this.textBox_diagTst.Text = "155.5";
            this.textBox_diagTst.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 20);
            this.label31.TabIndex = 0;
            this.label31.Text = "TST:";
            // 
            // groupBox_tx
            // 
            this.groupBox_tx.Controls.Add(this.label44);
            this.groupBox_tx.Controls.Add(this.label43);
            this.groupBox_tx.Controls.Add(this.textBox_FinalTx);
            this.groupBox_tx.Controls.Add(this.textBox_finalAvgSpo2);
            this.groupBox_tx.Controls.Add(this.label32);
            this.groupBox_tx.Controls.Add(this.textBox_finalLatSpo2);
            this.groupBox_tx.Controls.Add(this.label33);
            this.groupBox_tx.Controls.Add(this.textBox_finalLatRdi);
            this.groupBox_tx.Controls.Add(this.label34);
            this.groupBox_tx.Controls.Add(this.textBox_finalSupRdi);
            this.groupBox_tx.Controls.Add(this.label35);
            this.groupBox_tx.Controls.Add(this.textBox_finalRdi);
            this.groupBox_tx.Controls.Add(this.label36);
            this.groupBox_tx.Controls.Add(this.textBox_finalTotRdi);
            this.groupBox_tx.Controls.Add(this.label37);
            this.groupBox_tx.Controls.Add(this.textBox_finalRemTime);
            this.groupBox_tx.Controls.Add(this.label38);
            this.groupBox_tx.Controls.Add(this.textBox_finalLatTime);
            this.groupBox_tx.Controls.Add(this.label39);
            this.groupBox_tx.Controls.Add(this.textBox_finalSupTime);
            this.groupBox_tx.Controls.Add(this.label40);
            this.groupBox_tx.Controls.Add(this.textBox_finalTst);
            this.groupBox_tx.Controls.Add(this.label41);
            this.groupBox_tx.Location = new System.Drawing.Point(652, 92);
            this.groupBox_tx.Name = "groupBox_tx";
            this.groupBox_tx.Size = new System.Drawing.Size(261, 332);
            this.groupBox_tx.TabIndex = 3;
            this.groupBox_tx.TabStop = false;
            this.groupBox_tx.Text = "Final TX:";
            // 
            // label44
            // 
            this.label44.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(156, 31);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(70, 20);
            this.label44.TabIndex = 22;
            this.label44.Text = "CM H2O";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(4, 31);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(63, 20);
            this.label43.TabIndex = 21;
            this.label43.Text = "Final tx:";
            // 
            // textBox_FinalTx
            // 
            this.textBox_FinalTx.Location = new System.Drawing.Point(88, 26);
            this.textBox_FinalTx.Name = "textBox_FinalTx";
            this.textBox_FinalTx.Size = new System.Drawing.Size(62, 26);
            this.textBox_FinalTx.TabIndex = 20;
            // 
            // textBox_finalAvgSpo2
            // 
            this.textBox_finalAvgSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalAvgSpo2.Location = new System.Drawing.Point(200, 293);
            this.textBox_finalAvgSpo2.Name = "textBox_finalAvgSpo2";
            this.textBox_finalAvgSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalAvgSpo2.TabIndex = 19;
            this.textBox_finalAvgSpo2.Text = "96";
            this.textBox_finalAvgSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 293);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(85, 20);
            this.label32.TabIndex = 18;
            this.label32.Text = "Avg SpO2:";
            // 
            // textBox_finalLatSpo2
            // 
            this.textBox_finalLatSpo2.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalLatSpo2.Location = new System.Drawing.Point(200, 268);
            this.textBox_finalLatSpo2.Name = "textBox_finalLatSpo2";
            this.textBox_finalLatSpo2.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalLatSpo2.TabIndex = 17;
            this.textBox_finalLatSpo2.Text = "88";
            this.textBox_finalLatSpo2.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(10, 271);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(109, 20);
            this.label33.TabIndex = 16;
            this.label33.Text = "Lowest SpO2:";
            // 
            // textBox_finalLatRdi
            // 
            this.textBox_finalLatRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalLatRdi.Location = new System.Drawing.Point(200, 242);
            this.textBox_finalLatRdi.Name = "textBox_finalLatRdi";
            this.textBox_finalLatRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalLatRdi.TabIndex = 15;
            this.textBox_finalLatRdi.Text = "0";
            this.textBox_finalLatRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(10, 248);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 20);
            this.label34.TabIndex = 14;
            this.label34.Text = "Lat RDI:";
            // 
            // textBox_finalSupRdi
            // 
            this.textBox_finalSupRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalSupRdi.Location = new System.Drawing.Point(200, 219);
            this.textBox_finalSupRdi.Name = "textBox_finalSupRdi";
            this.textBox_finalSupRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalSupRdi.TabIndex = 13;
            this.textBox_finalSupRdi.Text = "10.8";
            this.textBox_finalSupRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(4, 222);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(96, 20);
            this.label35.TabIndex = 12;
            this.label35.Text = "Supine RDI:";
            // 
            // textBox_finalRdi
            // 
            this.textBox_finalRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalRdi.Location = new System.Drawing.Point(200, 192);
            this.textBox_finalRdi.Name = "textBox_finalRdi";
            this.textBox_finalRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalRdi.TabIndex = 11;
            this.textBox_finalRdi.Text = "0";
            this.textBox_finalRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(4, 194);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(82, 20);
            this.label36.TabIndex = 10;
            this.label36.Text = "REM RDI:";
            // 
            // textBox_finalTotRdi
            // 
            this.textBox_finalTotRdi.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalTotRdi.Location = new System.Drawing.Point(200, 165);
            this.textBox_finalTotRdi.Name = "textBox_finalTotRdi";
            this.textBox_finalTotRdi.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalTotRdi.TabIndex = 9;
            this.textBox_finalTotRdi.Text = "2";
            this.textBox_finalTotRdi.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 168);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(81, 20);
            this.label37.TabIndex = 8;
            this.label37.Text = "Total RDI:";
            // 
            // textBox_finalRemTime
            // 
            this.textBox_finalRemTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalRemTime.Location = new System.Drawing.Point(200, 140);
            this.textBox_finalRemTime.Name = "textBox_finalRemTime";
            this.textBox_finalRemTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalRemTime.TabIndex = 7;
            this.textBox_finalRemTime.Text = "19.5";
            this.textBox_finalRemTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 143);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(126, 20);
            this.label38.TabIndex = 6;
            this.label38.Text = "REM Time (Min);";
            // 
            // textBox_finalLatTime
            // 
            this.textBox_finalLatTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalLatTime.Location = new System.Drawing.Point(200, 114);
            this.textBox_finalLatTime.Name = "textBox_finalLatTime";
            this.textBox_finalLatTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalLatTime.TabIndex = 5;
            this.textBox_finalLatTime.Text = "51.5";
            this.textBox_finalLatTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(6, 117);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(158, 20);
            this.label39.TabIndex = 4;
            this.label39.Text = "Lat Sleep Time (Min):";
            // 
            // textBox_finalSupTime
            // 
            this.textBox_finalSupTime.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalSupTime.Location = new System.Drawing.Point(200, 88);
            this.textBox_finalSupTime.Name = "textBox_finalSupTime";
            this.textBox_finalSupTime.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalSupTime.TabIndex = 3;
            this.textBox_finalSupTime.Text = "11.1";
            this.textBox_finalSupTime.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(6, 91);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(147, 20);
            this.label40.TabIndex = 2;
            this.label40.Text = "Supine Sleep (min):";
            // 
            // textBox_finalTst
            // 
            this.textBox_finalTst.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                      | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_finalTst.Location = new System.Drawing.Point(200, 62);
            this.textBox_finalTst.Name = "textBox_finalTst";
            this.textBox_finalTst.Size = new System.Drawing.Size(55, 26);
            this.textBox_finalTst.TabIndex = 1;
            this.textBox_finalTst.Text = "62.5";
            this.textBox_finalTst.Validating +=
                new System.ComponentModel.CancelEventHandler(this.textBox_float_Validating);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(10, 69);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 20);
            this.label41.TabIndex = 0;
            this.label41.Text = "TST:";
            // 
            // button1
            // 
            this.button1.Anchor =
                ((System.Windows.Forms.AnchorStyles)
                    ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(818, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.AutoSize = true;
            this.groupBox5.Controls.Add(this.radioButton_titration);
            this.groupBox5.Controls.Add(this.radioButton_splitstudy);
            this.groupBox5.Controls.Add(this.radioButton_Psgonly);
            this.groupBox5.Location = new System.Drawing.Point(323, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(420, 68);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Study Type";
            // 
            // radioButton_titration
            // 
            this.radioButton_titration.AutoSize = true;
            this.radioButton_titration.Location = new System.Drawing.Point(224, 19);
            this.radioButton_titration.Name = "radioButton_titration";
            this.radioButton_titration.Size = new System.Drawing.Size(181, 24);
            this.radioButton_titration.TabIndex = 2;
            this.radioButton_titration.Text = "CPAP/BIPAP Titration";
            this.radioButton_titration.CheckedChanged +=
                new System.EventHandler(this.radioButton_studyType_CheckedChanged);
            // 
            // radioButton_splitstudy
            // 
            this.radioButton_splitstudy.AutoSize = true;
            this.radioButton_splitstudy.Checked = true;
            this.radioButton_splitstudy.Location = new System.Drawing.Point(115, 19);
            this.radioButton_splitstudy.Name = "radioButton_splitstudy";
            this.radioButton_splitstudy.Size = new System.Drawing.Size(103, 24);
            this.radioButton_splitstudy.TabIndex = 1;
            this.radioButton_splitstudy.TabStop = true;
            this.radioButton_splitstudy.Text = "Split Study";
            this.radioButton_splitstudy.CheckedChanged +=
                new System.EventHandler(this.radioButton_studyType_CheckedChanged);
            // 
            // radioButton_Psgonly
            // 
            this.radioButton_Psgonly.AutoSize = true;
            this.radioButton_Psgonly.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Psgonly.Name = "radioButton_Psgonly";
            this.radioButton_Psgonly.Size = new System.Drawing.Size(96, 24);
            this.radioButton_Psgonly.TabIndex = 0;
            this.radioButton_Psgonly.Text = "PSG Only";
            this.radioButton_Psgonly.CheckedChanged += new System.EventHandler(this.radioButton_studyType_CheckedChanged);
            // 
            // contextMenu_all
            // 
            this.contextMenu_all.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem1
            });
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem2
            });
            this.menuItem1.Text = "Reset";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "All";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // prelimIntMan
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(945, 523);
            this.ContextMenu = this.contextMenu_all;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_tx);
            this.Controls.Add(this.groupBox_diag);
            this.Controls.Add(this.groupBox_psg);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Name = "prelimIntMan";
            this.Text = "Enter Data";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_psg.ResumeLayout(false);
            this.groupBox_psg.PerformLayout();
            this.groupBox_diag.ResumeLayout(false);
            this.groupBox_diag.PerformLayout();
            this.groupBox_tx.ResumeLayout(false);
            this.groupBox_tx.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public bool ValidTextBoxFloat(string valueStr, out string errorMessage)
        {
            var pattern = @"^([0-9])?([0-9])?[0-9](\.[0-9])?$";
            var isMatched = Regex.IsMatch(valueStr, pattern);
            if (isMatched)
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Invalid Value!";
            return false;
        }

        private void textBox_float_Validating(object sender, CancelEventArgs e)
        {
            var tb = (TextBox) sender;
            string errorMsg;
            if (!ValidTextBoxFloat(tb.Text, out errorMsg))
            {
                errorMsg = tb.Text + " " + errorMsg;
                e.Cancel = true;
                MessageBox.Show(errorMsg);
                textBox_TST.Select(0, textBox_TST.Text.Length);
            }
        }

        private void radioButton_studyType_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Psgonly.Checked)
            {
                groupBox_tx.Visible = false;
                groupBox_diag.Visible = false;
                groupBox_psg.Visible = true;
            }
            if (radioButton_splitstudy.Checked)
            {
                groupBox_psg.Visible = false;
                groupBox_tx.Visible = true;
                groupBox_diag.Visible = true;
            }
            if (radioButton_titration.Checked)
            {
                groupBox_psg.Visible = false;
                groupBox_diag.Visible = false;
                groupBox_tx.Visible = true;
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            textBox_TST.Text = "0.0";
            textBox_wakeTst.Text = "0.0";
            textBox_s1tst.Text = "0.0";
            textBox_s2Tst.Text = "0.0";
            textBox_swsTst.Text = "0.0";
            textBox_remTst.Text = "0.0";
            textBox_sleepEff.Text = "0.0";
            textBox_remLat.Text = "0.0";
            textBox_slpLat.Text = "0.0";
            textBox_plmArrIdx.Text = "0.0";
            textBox_plmIdx.Text = "0.0";
            textBox_PsgTST.Text = "0.0";
            textBox_psgRem.Text = "0.0";
            textBox_psgTotRdi.Text = "0.0";
            textBox_PsgRemRdi.Text = "0.0";
            textBox_psgSupRdi.Text = "0.0";
            textBox_psgLatRdi.Text = "0.0";
            textBox_psgLowSpo2.Text = "0.0";
            textBox_psgAvgSpo2.Text = "0.0";
            textBox_psgSupTime.Text = "0.0";
            textBox_PsgLatTime.Text = "0.0";
            textBox_diagAvgSpo2.Text = "0.0";
            textBox_diagLowSpo2.Text = "0.0";
            textBox_diagLatRdi.Text = "0.0";
            textBox_diagSupRdi.Text = "0.0";
            textBox_diagRemRdi.Text = "0.0";
            textBox_diagTotRdi.Text = "0.0";
            textBox_diagRemTime.Text = "0.0";
            textBox_diagLatTime.Text = "0.0";
            textBox_diagSupTime.Text = "0.0";
            textBox_diagTst.Text = "0.0";
            textBox_finalAvgSpo2.Text = "0.0";
            textBox_finalLatSpo2.Text = "0.0";
            textBox_finalLatRdi.Text = "0.0";
            textBox_finalSupRdi.Text = "0.0";
            textBox_finalRdi.Text = "0.0";
            textBox_finalTotRdi.Text = "0.0";
            textBox_finalRemTime.Text = "0.0";
            textBox_finalLatTime.Text = "0.0";
            textBox_finalSupTime.Text = "0.0";
            textBox_finalTst.Text = "0.0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}