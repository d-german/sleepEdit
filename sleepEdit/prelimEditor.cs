using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for prelimEditor.
    /// </summary>
    public class prelimEditor : Form
    {
        private Button button_copy;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private ContextMenu contextMenu1;
        public TextBox diag_lateralAHI;
        public TextBox diag_lowestSpO2;
        public TextBox diag_RemAHI;
        public TextBox diag_remSleepTime;
        public TextBox diag_sleepTime;
        public TextBox diag_supineAHI;
        public TextBox diag_supineSleepTime;
        public TextBox diag_totalAHI;
        public TextBox final_lateralAHI;
        public TextBox final_lowestSpO2;
        public TextBox final_RemAHI;
        public TextBox final_remSleepTime;
        public TextBox final_sleepTime;
        public TextBox final_supineAHI;
        public TextBox final_supineSleepTime;
        public TextBox final_totalAHI;
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private MenuItem menuItem1;
        private MenuItem menuItem6;
        private MenuItem menuItem7;
        private MenuItem menuItem8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        public TextBox psg_lateralAHI;
        public TextBox psg_lowestSpO2;
        public TextBox psg_RemAHI;
        public TextBox psg_remSleepTime;
        public TextBox psg_sleepTime;
        public TextBox psg_supineAHI;
        public TextBox psg_supineSleepTime;
        public TextBox psg_totalAHI;
        public RichTextBox richTextBox_interp;
        private TabControl tabControl1;
        private TabPage tabPage_diagnostic;
        private TabPage tabPage_finalTx;
        private TabPage tabPage_interp;
        private TabPage tabPage_psg;
        private TabPage tabPage_SleepStageAnalysis;
        public TextBox textBox_plmArousalIndex;
        public TextBox textBox_plmIndex;
        public TextBox textBox_rem_percentOfTST;
        public TextBox textBox_remLatency;
        public TextBox textBox_sleepEfficiency;
        public TextBox textBox_sleepLatency;
        public TextBox textBox_SleepTimeMin;
        public TextBox textBox_stage1_percentOfTST;
        public TextBox textBox_stage2_percentOfTST;
        public TextBox textBox_sws_percentOfTST;
        public TextBox textBox_wake_percentOfTST;

        public prelimEditor()
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(prelimEditor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_interp = new System.Windows.Forms.TabPage();
            this.richTextBox_interp = new System.Windows.Forms.RichTextBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.tabPage_SleepStageAnalysis = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_remLatency = new System.Windows.Forms.TextBox();
            this.textBox_sleepLatency = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_wake_percentOfTST = new System.Windows.Forms.TextBox();
            this.textBox_plmArousalIndex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_sleepEfficiency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sws_percentOfTST = new System.Windows.Forms.TextBox();
            this.textBox_plmIndex = new System.Windows.Forms.TextBox();
            this.textBox_stage1_percentOfTST = new System.Windows.Forms.TextBox();
            this.textBox_stage2_percentOfTST = new System.Windows.Forms.TextBox();
            this.textBox_rem_percentOfTST = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SleepTimeMin = new System.Windows.Forms.TextBox();
            this.button_copy = new System.Windows.Forms.Button();
            this.tabPage_psg = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.psg_supineSleepTime = new System.Windows.Forms.TextBox();
            this.psg_remSleepTime = new System.Windows.Forms.TextBox();
            this.psg_totalAHI = new System.Windows.Forms.TextBox();
            this.psg_RemAHI = new System.Windows.Forms.TextBox();
            this.psg_supineAHI = new System.Windows.Forms.TextBox();
            this.psg_lateralAHI = new System.Windows.Forms.TextBox();
            this.psg_lowestSpO2 = new System.Windows.Forms.TextBox();
            this.psg_sleepTime = new System.Windows.Forms.TextBox();
            this.tabPage_diagnostic = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.diag_supineSleepTime = new System.Windows.Forms.TextBox();
            this.diag_remSleepTime = new System.Windows.Forms.TextBox();
            this.diag_totalAHI = new System.Windows.Forms.TextBox();
            this.diag_RemAHI = new System.Windows.Forms.TextBox();
            this.diag_supineAHI = new System.Windows.Forms.TextBox();
            this.diag_lateralAHI = new System.Windows.Forms.TextBox();
            this.diag_lowestSpO2 = new System.Windows.Forms.TextBox();
            this.diag_sleepTime = new System.Windows.Forms.TextBox();
            this.tabPage_finalTx = new System.Windows.Forms.TabPage();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.final_supineSleepTime = new System.Windows.Forms.TextBox();
            this.final_remSleepTime = new System.Windows.Forms.TextBox();
            this.final_totalAHI = new System.Windows.Forms.TextBox();
            this.final_RemAHI = new System.Windows.Forms.TextBox();
            this.final_supineAHI = new System.Windows.Forms.TextBox();
            this.final_lateralAHI = new System.Windows.Forms.TextBox();
            this.final_lowestSpO2 = new System.Windows.Forms.TextBox();
            this.final_sleepTime = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_interp.SuspendLayout();
            this.tabPage_SleepStageAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabPage_psg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.tabPage_diagnostic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            this.tabPage_finalTx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage_interp);
            this.tabControl1.Controls.Add(this.tabPage_SleepStageAnalysis);
            this.tabControl1.Controls.Add(this.tabPage_psg);
            this.tabControl1.Controls.Add(this.tabPage_diagnostic);
            this.tabControl1.Controls.Add(this.tabPage_finalTx);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 558);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_interp
            // 
            this.tabPage_interp.Controls.Add(this.richTextBox_interp);
            this.tabPage_interp.Location = new System.Drawing.Point(4, 29);
            this.tabPage_interp.Name = "tabPage_interp";
            this.tabPage_interp.Size = new System.Drawing.Size(982, 525);
            this.tabPage_interp.TabIndex = 4;
            this.tabPage_interp.Text = "Interpretation";
            // 
            // richTextBox_interp
            // 
            this.richTextBox_interp.ContextMenu = this.contextMenu1;
            this.richTextBox_interp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_interp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.richTextBox_interp.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_interp.Name = "richTextBox_interp";
            this.richTextBox_interp.Size = new System.Drawing.Size(982, 525);
            this.richTextBox_interp.TabIndex = 0;
            this.richTextBox_interp.Text = "";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[]
            {
                this.menuItem6,
                this.menuItem7,
                this.menuItem8,
                this.menuItem1
            });
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Copy";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "Cut";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.Text = "Paste";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.Text = "Copy All to Clipboard";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // tabPage_SleepStageAnalysis
            // 
            this.tabPage_SleepStageAnalysis.Controls.Add(this.pictureBox1);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label13);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label12);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_remLatency);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_sleepLatency);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label11);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label10);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_wake_percentOfTST);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_plmArousalIndex);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label9);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label8);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_sleepEfficiency);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label7);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label6);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label5);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label4);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label3);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label2);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_sws_percentOfTST);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_plmIndex);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_stage1_percentOfTST);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_stage2_percentOfTST);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_rem_percentOfTST);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.label1);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.textBox_SleepTimeMin);
            this.tabPage_SleepStageAnalysis.Controls.Add(this.button_copy);
            this.tabPage_SleepStageAnalysis.Location = new System.Drawing.Point(4, 29);
            this.tabPage_SleepStageAnalysis.Name = "tabPage_SleepStageAnalysis";
            this.tabPage_SleepStageAnalysis.Size = new System.Drawing.Size(984, 527);
            this.tabPage_SleepStageAnalysis.TabIndex = 0;
            this.tabPage_SleepStageAnalysis.Text = "Sleep Stage Analysis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(507, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 180);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(307, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 28);
            this.label13.TabIndex = 22;
            this.label13.Text = "REM";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(300, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 28);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sleep Onset";
            // 
            // textBox_remLatency
            // 
            this.textBox_remLatency.Location = new System.Drawing.Point(407, 305);
            this.textBox_remLatency.Name = "textBox_remLatency";
            this.textBox_remLatency.Size = new System.Drawing.Size(100, 23);
            this.textBox_remLatency.TabIndex = 7;
            // 
            // textBox_sleepLatency
            // 
            this.textBox_sleepLatency.Location = new System.Drawing.Point(407, 263);
            this.textBox_sleepLatency.Name = "textBox_sleepLatency";
            this.textBox_sleepLatency.Size = new System.Drawing.Size(100, 23);
            this.textBox_sleepLatency.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(300, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 28);
            this.label11.TabIndex = 18;
            this.label11.Text = "Latencies                (min)";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(13, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Wake";
            // 
            // textBox_wake_percentOfTST
            // 
            this.textBox_wake_percentOfTST.Location = new System.Drawing.Point(93, 257);
            this.textBox_wake_percentOfTST.Name = "textBox_wake_percentOfTST";
            this.textBox_wake_percentOfTST.ReadOnly = true;
            this.textBox_wake_percentOfTST.Size = new System.Drawing.Size(84, 23);
            this.textBox_wake_percentOfTST.TabIndex = 2;
            // 
            // textBox_plmArousalIndex
            // 
            this.textBox_plmArousalIndex.Location = new System.Drawing.Point(700, 291);
            this.textBox_plmArousalIndex.Name = "textBox_plmArousalIndex";
            this.textBox_plmArousalIndex.Size = new System.Drawing.Size(83, 23);
            this.textBox_plmArousalIndex.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(553, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 42);
            this.label9.TabIndex = 15;
            this.label9.Text = "PLM w/arousal Index";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(553, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "PLM index";
            // 
            // textBox_sleepEfficiency
            // 
            this.textBox_sleepEfficiency.Location = new System.Drawing.Point(333, 132);
            this.textBox_sleepEfficiency.Name = "textBox_sleepEfficiency";
            this.textBox_sleepEfficiency.Size = new System.Drawing.Size(84, 23);
            this.textBox_sleepEfficiency.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(200, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sleep Efficiency";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(93, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "% TST";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "REM";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "SWS";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stage 2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stage 1";
            // 
            // textBox_sws_percentOfTST
            // 
            this.textBox_sws_percentOfTST.Location = new System.Drawing.Point(93, 367);
            this.textBox_sws_percentOfTST.Name = "textBox_sws_percentOfTST";
            this.textBox_sws_percentOfTST.ReadOnly = true;
            this.textBox_sws_percentOfTST.Size = new System.Drawing.Size(84, 23);
            this.textBox_sws_percentOfTST.TabIndex = 4;
            // 
            // textBox_plmIndex
            // 
            this.textBox_plmIndex.Location = new System.Drawing.Point(700, 243);
            this.textBox_plmIndex.Name = "textBox_plmIndex";
            this.textBox_plmIndex.Size = new System.Drawing.Size(83, 23);
            this.textBox_plmIndex.TabIndex = 8;
            // 
            // textBox_stage1_percentOfTST
            // 
            this.textBox_stage1_percentOfTST.Location = new System.Drawing.Point(93, 291);
            this.textBox_stage1_percentOfTST.Name = "textBox_stage1_percentOfTST";
            this.textBox_stage1_percentOfTST.ReadOnly = true;
            this.textBox_stage1_percentOfTST.Size = new System.Drawing.Size(84, 23);
            this.textBox_stage1_percentOfTST.TabIndex = 2;
            // 
            // textBox_stage2_percentOfTST
            // 
            this.textBox_stage2_percentOfTST.Location = new System.Drawing.Point(93, 333);
            this.textBox_stage2_percentOfTST.Name = "textBox_stage2_percentOfTST";
            this.textBox_stage2_percentOfTST.ReadOnly = true;
            this.textBox_stage2_percentOfTST.Size = new System.Drawing.Size(84, 23);
            this.textBox_stage2_percentOfTST.TabIndex = 3;
            // 
            // textBox_rem_percentOfTST
            // 
            this.textBox_rem_percentOfTST.Location = new System.Drawing.Point(93, 402);
            this.textBox_rem_percentOfTST.Name = "textBox_rem_percentOfTST";
            this.textBox_rem_percentOfTST.ReadOnly = true;
            this.textBox_rem_percentOfTST.Size = new System.Drawing.Size(84, 23);
            this.textBox_rem_percentOfTST.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "TST (Min)";
            // 
            // textBox_SleepTimeMin
            // 
            this.textBox_SleepTimeMin.Location = new System.Drawing.Point(107, 132);
            this.textBox_SleepTimeMin.Name = "textBox_SleepTimeMin";
            this.textBox_SleepTimeMin.Size = new System.Drawing.Size(83, 23);
            this.textBox_SleepTimeMin.TabIndex = 0;
            // 
            // button_copy
            // 
            this.button_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button_copy.Location = new System.Drawing.Point(40, 28);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(140, 27);
            this.button_copy.TabIndex = 3;
            this.button_copy.Text = "Copy to Clipbord";
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // tabPage_psg
            // 
            this.tabPage_psg.Controls.Add(this.pictureBox2);
            this.tabPage_psg.Controls.Add(this.label22);
            this.tabPage_psg.Controls.Add(this.label21);
            this.tabPage_psg.Controls.Add(this.label20);
            this.tabPage_psg.Controls.Add(this.label19);
            this.tabPage_psg.Controls.Add(this.label18);
            this.tabPage_psg.Controls.Add(this.label17);
            this.tabPage_psg.Controls.Add(this.label16);
            this.tabPage_psg.Controls.Add(this.label14);
            this.tabPage_psg.Controls.Add(this.psg_supineSleepTime);
            this.tabPage_psg.Controls.Add(this.psg_remSleepTime);
            this.tabPage_psg.Controls.Add(this.psg_totalAHI);
            this.tabPage_psg.Controls.Add(this.psg_RemAHI);
            this.tabPage_psg.Controls.Add(this.psg_supineAHI);
            this.tabPage_psg.Controls.Add(this.psg_lateralAHI);
            this.tabPage_psg.Controls.Add(this.psg_lowestSpO2);
            this.tabPage_psg.Controls.Add(this.psg_sleepTime);
            this.tabPage_psg.Location = new System.Drawing.Point(4, 29);
            this.tabPage_psg.Name = "tabPage_psg";
            this.tabPage_psg.Size = new System.Drawing.Size(984, 527);
            this.tabPage_psg.TabIndex = 1;
            this.tabPage_psg.Text = "PSG";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 104);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(107, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(133, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "Supine sleep time";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(107, 159);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "REM sleep time";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(367, 76);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "Total Index";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(367, 118);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "REM Index";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(367, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "Supine Index";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(367, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Lateral Index";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(367, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Lowest SaO2";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(113, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "Sleep Time (min)";
            // 
            // psg_supineSleepTime
            // 
            this.psg_supineSleepTime.Location = new System.Drawing.Point(253, 118);
            this.psg_supineSleepTime.Name = "psg_supineSleepTime";
            this.psg_supineSleepTime.Size = new System.Drawing.Size(84, 23);
            this.psg_supineSleepTime.TabIndex = 1;
            // 
            // psg_remSleepTime
            // 
            this.psg_remSleepTime.Location = new System.Drawing.Point(253, 159);
            this.psg_remSleepTime.Name = "psg_remSleepTime";
            this.psg_remSleepTime.Size = new System.Drawing.Size(84, 23);
            this.psg_remSleepTime.TabIndex = 2;
            // 
            // psg_totalAHI
            // 
            this.psg_totalAHI.Location = new System.Drawing.Point(507, 76);
            this.psg_totalAHI.Name = "psg_totalAHI";
            this.psg_totalAHI.Size = new System.Drawing.Size(83, 23);
            this.psg_totalAHI.TabIndex = 3;
            // 
            // psg_RemAHI
            // 
            this.psg_RemAHI.Location = new System.Drawing.Point(507, 118);
            this.psg_RemAHI.Name = "psg_RemAHI";
            this.psg_RemAHI.Size = new System.Drawing.Size(83, 23);
            this.psg_RemAHI.TabIndex = 4;
            // 
            // psg_supineAHI
            // 
            this.psg_supineAHI.Location = new System.Drawing.Point(507, 159);
            this.psg_supineAHI.Name = "psg_supineAHI";
            this.psg_supineAHI.Size = new System.Drawing.Size(83, 23);
            this.psg_supineAHI.TabIndex = 5;
            // 
            // psg_lateralAHI
            // 
            this.psg_lateralAHI.Location = new System.Drawing.Point(507, 201);
            this.psg_lateralAHI.Name = "psg_lateralAHI";
            this.psg_lateralAHI.Size = new System.Drawing.Size(83, 23);
            this.psg_lateralAHI.TabIndex = 6;
            // 
            // psg_lowestSpO2
            // 
            this.psg_lowestSpO2.Location = new System.Drawing.Point(507, 263);
            this.psg_lowestSpO2.Name = "psg_lowestSpO2";
            this.psg_lowestSpO2.Size = new System.Drawing.Size(83, 23);
            this.psg_lowestSpO2.TabIndex = 7;
            // 
            // psg_sleepTime
            // 
            this.psg_sleepTime.Location = new System.Drawing.Point(253, 76);
            this.psg_sleepTime.Name = "psg_sleepTime";
            this.psg_sleepTime.Size = new System.Drawing.Size(84, 23);
            this.psg_sleepTime.TabIndex = 0;
            // 
            // tabPage_diagnostic
            // 
            this.tabPage_diagnostic.Controls.Add(this.pictureBox3);
            this.tabPage_diagnostic.Controls.Add(this.label15);
            this.tabPage_diagnostic.Controls.Add(this.label23);
            this.tabPage_diagnostic.Controls.Add(this.label24);
            this.tabPage_diagnostic.Controls.Add(this.label25);
            this.tabPage_diagnostic.Controls.Add(this.label26);
            this.tabPage_diagnostic.Controls.Add(this.label27);
            this.tabPage_diagnostic.Controls.Add(this.label28);
            this.tabPage_diagnostic.Controls.Add(this.label29);
            this.tabPage_diagnostic.Controls.Add(this.diag_supineSleepTime);
            this.tabPage_diagnostic.Controls.Add(this.diag_remSleepTime);
            this.tabPage_diagnostic.Controls.Add(this.diag_totalAHI);
            this.tabPage_diagnostic.Controls.Add(this.diag_RemAHI);
            this.tabPage_diagnostic.Controls.Add(this.diag_supineAHI);
            this.tabPage_diagnostic.Controls.Add(this.diag_lateralAHI);
            this.tabPage_diagnostic.Controls.Add(this.diag_lowestSpO2);
            this.tabPage_diagnostic.Controls.Add(this.diag_sleepTime);
            this.tabPage_diagnostic.Location = new System.Drawing.Point(4, 29);
            this.tabPage_diagnostic.Name = "tabPage_diagnostic";
            this.tabPage_diagnostic.Size = new System.Drawing.Size(984, 527);
            this.tabPage_diagnostic.TabIndex = 2;
            this.tabPage_diagnostic.Text = "Diagnostic ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 104);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(53, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Supine sleep time";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(53, 153);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 19);
            this.label23.TabIndex = 31;
            this.label23.Text = "REM sleep time";
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(322, 75);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(105, 19);
            this.label24.TabIndex = 30;
            this.label24.Text = "Total Index";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(322, 116);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 20);
            this.label25.TabIndex = 29;
            this.label25.Text = "REM Index";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(322, 165);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(105, 20);
            this.label26.TabIndex = 28;
            this.label26.Text = "Supine Index";
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(322, 206);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(111, 20);
            this.label27.TabIndex = 27;
            this.label27.Text = "Lateral Index";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(322, 262);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 20);
            this.label28.TabIndex = 26;
            this.label28.Text = "Lowest SaO2";
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(53, 69);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(134, 20);
            this.label29.TabIndex = 25;
            this.label29.Text = "Sleep Time (min)";
            // 
            // diag_supineSleepTime
            // 
            this.diag_supineSleepTime.Location = new System.Drawing.Point(208, 116);
            this.diag_supineSleepTime.Name = "diag_supineSleepTime";
            this.diag_supineSleepTime.Size = new System.Drawing.Size(84, 23);
            this.diag_supineSleepTime.TabIndex = 18;
            // 
            // diag_remSleepTime
            // 
            this.diag_remSleepTime.Location = new System.Drawing.Point(208, 158);
            this.diag_remSleepTime.Name = "diag_remSleepTime";
            this.diag_remSleepTime.Size = new System.Drawing.Size(84, 23);
            this.diag_remSleepTime.TabIndex = 19;
            // 
            // diag_totalAHI
            // 
            this.diag_totalAHI.Location = new System.Drawing.Point(473, 76);
            this.diag_totalAHI.Name = "diag_totalAHI";
            this.diag_totalAHI.Size = new System.Drawing.Size(84, 23);
            this.diag_totalAHI.TabIndex = 20;
            // 
            // diag_RemAHI
            // 
            this.diag_RemAHI.Location = new System.Drawing.Point(473, 118);
            this.diag_RemAHI.Name = "diag_RemAHI";
            this.diag_RemAHI.Size = new System.Drawing.Size(84, 23);
            this.diag_RemAHI.TabIndex = 21;
            // 
            // diag_supineAHI
            // 
            this.diag_supineAHI.Location = new System.Drawing.Point(473, 159);
            this.diag_supineAHI.Name = "diag_supineAHI";
            this.diag_supineAHI.Size = new System.Drawing.Size(84, 23);
            this.diag_supineAHI.TabIndex = 22;
            // 
            // diag_lateralAHI
            // 
            this.diag_lateralAHI.Location = new System.Drawing.Point(473, 201);
            this.diag_lateralAHI.Name = "diag_lateralAHI";
            this.diag_lateralAHI.Size = new System.Drawing.Size(84, 23);
            this.diag_lateralAHI.TabIndex = 23;
            // 
            // diag_lowestSpO2
            // 
            this.diag_lowestSpO2.Location = new System.Drawing.Point(473, 263);
            this.diag_lowestSpO2.Name = "diag_lowestSpO2";
            this.diag_lowestSpO2.Size = new System.Drawing.Size(84, 23);
            this.diag_lowestSpO2.TabIndex = 24;
            // 
            // diag_sleepTime
            // 
            this.diag_sleepTime.Location = new System.Drawing.Point(208, 75);
            this.diag_sleepTime.Name = "diag_sleepTime";
            this.diag_sleepTime.Size = new System.Drawing.Size(84, 23);
            this.diag_sleepTime.TabIndex = 17;
            // 
            // tabPage_finalTx
            // 
            this.tabPage_finalTx.Controls.Add(this.pictureBox4);
            this.tabPage_finalTx.Controls.Add(this.label30);
            this.tabPage_finalTx.Controls.Add(this.label31);
            this.tabPage_finalTx.Controls.Add(this.label32);
            this.tabPage_finalTx.Controls.Add(this.label33);
            this.tabPage_finalTx.Controls.Add(this.label34);
            this.tabPage_finalTx.Controls.Add(this.label35);
            this.tabPage_finalTx.Controls.Add(this.label36);
            this.tabPage_finalTx.Controls.Add(this.label37);
            this.tabPage_finalTx.Controls.Add(this.final_supineSleepTime);
            this.tabPage_finalTx.Controls.Add(this.final_remSleepTime);
            this.tabPage_finalTx.Controls.Add(this.final_totalAHI);
            this.tabPage_finalTx.Controls.Add(this.final_RemAHI);
            this.tabPage_finalTx.Controls.Add(this.final_supineAHI);
            this.tabPage_finalTx.Controls.Add(this.final_lateralAHI);
            this.tabPage_finalTx.Controls.Add(this.final_lowestSpO2);
            this.tabPage_finalTx.Controls.Add(this.final_sleepTime);
            this.tabPage_finalTx.Location = new System.Drawing.Point(4, 29);
            this.tabPage_finalTx.Name = "tabPage_finalTx";
            this.tabPage_finalTx.Size = new System.Drawing.Size(984, 527);
            this.tabPage_finalTx.TabIndex = 3;
            this.tabPage_finalTx.Text = "Final TX";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(60, 222);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(193, 104);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(82, 116);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(145, 20);
            this.label30.TabIndex = 32;
            this.label30.Text = "Supine sleep time";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(82, 158);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(145, 20);
            this.label31.TabIndex = 31;
            this.label31.Text = "REM sleep time";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(413, 76);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(120, 20);
            this.label32.TabIndex = 30;
            this.label32.Text = "Total Index";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(413, 118);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(120, 20);
            this.label33.TabIndex = 29;
            this.label33.Text = "REM Index";
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(413, 166);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(120, 20);
            this.label34.TabIndex = 28;
            this.label34.Text = "Supine Index";
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(413, 208);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(120, 20);
            this.label35.TabIndex = 27;
            this.label35.Text = "Lateral Index";
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(413, 263);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 20);
            this.label36.TabIndex = 26;
            this.label36.Text = "Lowest SaO2";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(82, 75);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(145, 19);
            this.label37.TabIndex = 25;
            this.label37.Text = "Sleep Time (min)";
            // 
            // final_supineSleepTime
            // 
            this.final_supineSleepTime.Location = new System.Drawing.Point(253, 118);
            this.final_supineSleepTime.Name = "final_supineSleepTime";
            this.final_supineSleepTime.Size = new System.Drawing.Size(84, 23);
            this.final_supineSleepTime.TabIndex = 18;
            // 
            // final_remSleepTime
            // 
            this.final_remSleepTime.Location = new System.Drawing.Point(253, 159);
            this.final_remSleepTime.Name = "final_remSleepTime";
            this.final_remSleepTime.Size = new System.Drawing.Size(84, 23);
            this.final_remSleepTime.TabIndex = 19;
            // 
            // final_totalAHI
            // 
            this.final_totalAHI.Location = new System.Drawing.Point(573, 76);
            this.final_totalAHI.Name = "final_totalAHI";
            this.final_totalAHI.Size = new System.Drawing.Size(84, 23);
            this.final_totalAHI.TabIndex = 20;
            // 
            // final_RemAHI
            // 
            this.final_RemAHI.Location = new System.Drawing.Point(573, 118);
            this.final_RemAHI.Name = "final_RemAHI";
            this.final_RemAHI.Size = new System.Drawing.Size(84, 23);
            this.final_RemAHI.TabIndex = 21;
            // 
            // final_supineAHI
            // 
            this.final_supineAHI.Location = new System.Drawing.Point(573, 159);
            this.final_supineAHI.Name = "final_supineAHI";
            this.final_supineAHI.Size = new System.Drawing.Size(84, 23);
            this.final_supineAHI.TabIndex = 22;
            // 
            // final_lateralAHI
            // 
            this.final_lateralAHI.Location = new System.Drawing.Point(573, 201);
            this.final_lateralAHI.Name = "final_lateralAHI";
            this.final_lateralAHI.Size = new System.Drawing.Size(84, 23);
            this.final_lateralAHI.TabIndex = 23;
            // 
            // final_lowestSpO2
            // 
            this.final_lowestSpO2.Location = new System.Drawing.Point(573, 263);
            this.final_lowestSpO2.Name = "final_lowestSpO2";
            this.final_lowestSpO2.Size = new System.Drawing.Size(84, 23);
            this.final_lowestSpO2.TabIndex = 24;
            // 
            // final_sleepTime
            // 
            this.final_sleepTime.Location = new System.Drawing.Point(253, 76);
            this.final_sleepTime.Name = "final_sleepTime";
            this.final_sleepTime.Size = new System.Drawing.Size(84, 23);
            this.final_sleepTime.TabIndex = 17;
            // 
            // prelimEditor
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(990, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "prelimEditor";
            this.Text = "Preliminary Interpretation";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_interp.ResumeLayout(false);
            this.tabPage_SleepStageAnalysis.ResumeLayout(false);
            this.tabPage_SleepStageAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabPage_psg.ResumeLayout(false);
            this.tabPage_psg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.tabPage_diagnostic.ResumeLayout(false);
            this.tabPage_diagnostic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            this.tabPage_finalTx.ResumeLayout(false);
            this.tabPage_finalTx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private void textBox1_StudyDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            richTextBox_interp.SelectAll();
            richTextBox_interp.Copy();
        }

        private void contextMenu1_Popup(object sender, EventArgs e)
        {
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            richTextBox_interp.Copy();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            richTextBox_interp.Cut();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            richTextBox_interp.Paste();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            richTextBox_interp.SelectAll();
            richTextBox_interp.Copy();
        }
    }
}