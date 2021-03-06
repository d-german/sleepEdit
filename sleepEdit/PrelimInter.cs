using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using RespirationsComment;
using SleepArch;
using TSTbodyPosComment;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for PrelimInter.
    /// </summary>
    public class PrelimInter : Form
    {
        public PrelimInter()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            path = sleepEdit.prelimIntPath; //this saves the current directory
            // because it changes when you open up a file from another directory.
            //It is restored in the the destructor.

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }


        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            sleepEdit.prelimIntPath = path; //restores the path to current directory.
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PrelimInter));
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_studyType = new System.Windows.Forms.GroupBox();
            this.radioButton_split = new System.Windows.Forms.RadioButton();
            this.groupBox_finalTx = new System.Windows.Forms.GroupBox();
            this.comboBox_finalCpap = new System.Windows.Forms.ComboBox();
            this.radioButton_CPAP = new System.Windows.Forms.RadioButton();
            this.radioButton_titration = new System.Windows.Forms.RadioButton();
            this.radioButton_PSG = new System.Windows.Forms.RadioButton();
            this.checkBox_alphaIntrusion = new System.Windows.Forms.CheckBox();
            this.checkBox_REM_SWS_rebound = new System.Windows.Forms.CheckBox();
            this.comboBox_arrhy = new System.Windows.Forms.ComboBox();
            this.checkBox_Arrhythmias = new System.Windows.Forms.CheckBox();
            this.comboBox_arrfreq = new System.Windows.Forms.ComboBox();
            this.checkBox_bruxism = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_getInterp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkBoxCarboxy = new System.Windows.Forms.CheckBox();
            this.checkBoxHypoxemia = new System.Windows.Forms.CheckBox();
            this.groupBox_studyType.SuspendLayout();
            this.groupBox_finalTx.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.Filter = "sleepEdit files (*.DDR)|*sleepEdit*.DDR";
            // 
            // groupBox_studyType
            // 
            this.groupBox_studyType.AutoSize = true;
            this.groupBox_studyType.Controls.Add(this.radioButton_split);
            this.groupBox_studyType.Controls.Add(this.groupBox_finalTx);
            this.groupBox_studyType.Controls.Add(this.radioButton_titration);
            this.groupBox_studyType.Controls.Add(this.radioButton_PSG);
            this.groupBox_studyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox_studyType.Location = new System.Drawing.Point(288, 57);
            this.groupBox_studyType.Name = "groupBox_studyType";
            this.groupBox_studyType.Size = new System.Drawing.Size(361, 165);
            this.groupBox_studyType.TabIndex = 6;
            this.groupBox_studyType.TabStop = false;
            this.groupBox_studyType.Text = "Study Type";
            // 
            // radioButton_split
            // 
            this.radioButton_split.AutoSize = true;
            this.radioButton_split.Location = new System.Drawing.Point(6, 60);
            this.radioButton_split.Name = "radioButton_split";
            this.radioButton_split.Size = new System.Drawing.Size(71, 24);
            this.radioButton_split.TabIndex = 4;
            this.radioButton_split.Text = "SPLIT";
            this.radioButton_split.CheckedChanged += new System.EventHandler(this.radioButton_split_CheckedChanged);
            // 
            // groupBox_finalTx
            // 
            this.groupBox_finalTx.AutoSize = true;
            this.groupBox_finalTx.Controls.Add(this.comboBox_finalCpap);
            this.groupBox_finalTx.Controls.Add(this.radioButton_CPAP);
            this.groupBox_finalTx.Enabled = false;
            this.groupBox_finalTx.Location = new System.Drawing.Point(151, 33);
            this.groupBox_finalTx.Name = "groupBox_finalTx";
            this.groupBox_finalTx.Size = new System.Drawing.Size(189, 103);
            this.groupBox_finalTx.TabIndex = 3;
            this.groupBox_finalTx.TabStop = false;
            this.groupBox_finalTx.Text = "Final CPAP/BiPAP";
            // 
            // comboBox_finalCpap
            // 
            this.comboBox_finalCpap.Font = new System.Drawing.Font("Arial Narrow", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_finalCpap.Items.AddRange(new object[]
            {
                "TX=5",
                "TX=7",
                "TX=8",
                "TX=9",
                "TX=10",
                "TX=11",
                "TX=12",
                "TX=13",
                "TX=14",
                "TX=15",
                "TX=16",
                "TX=17",
                "TX=18",
                "TX=19",
                "TX=20"
            });
            this.comboBox_finalCpap.Location = new System.Drawing.Point(7, 53);
            this.comboBox_finalCpap.MaxDropDownItems = 25;
            this.comboBox_finalCpap.Name = "comboBox_finalCpap";
            this.comboBox_finalCpap.Size = new System.Drawing.Size(105, 25);
            this.comboBox_finalCpap.TabIndex = 34;
            this.comboBox_finalCpap.SelectedIndexChanged +=
                new System.EventHandler(this.comboBox_finalCpap_SelectedIndexChanged);
            // 
            // radioButton_CPAP
            // 
            this.radioButton_CPAP.AutoSize = true;
            this.radioButton_CPAP.Location = new System.Drawing.Point(7, 19);
            this.radioButton_CPAP.Name = "radioButton_CPAP";
            this.radioButton_CPAP.Size = new System.Drawing.Size(118, 24);
            this.radioButton_CPAP.TabIndex = 0;
            this.radioButton_CPAP.Text = "CPAP/BiPAP";
            this.radioButton_CPAP.CheckedChanged += new System.EventHandler(this.radioButton_CPAP_CheckedChanged);
            // 
            // radioButton_titration
            // 
            this.radioButton_titration.AutoSize = true;
            this.radioButton_titration.Location = new System.Drawing.Point(6, 93);
            this.radioButton_titration.Name = "radioButton_titration";
            this.radioButton_titration.Size = new System.Drawing.Size(110, 24);
            this.radioButton_titration.TabIndex = 2;
            this.radioButton_titration.Text = "TITRATION";
            this.radioButton_titration.CheckedChanged +=
                new System.EventHandler(this.radioButton_titration_CheckedChanged);
            // 
            // radioButton_PSG
            // 
            this.radioButton_PSG.AutoSize = true;
            this.radioButton_PSG.Location = new System.Drawing.Point(6, 32);
            this.radioButton_PSG.Name = "radioButton_PSG";
            this.radioButton_PSG.Size = new System.Drawing.Size(61, 24);
            this.radioButton_PSG.TabIndex = 0;
            this.radioButton_PSG.Text = "PSG";
            this.radioButton_PSG.CheckedChanged += new System.EventHandler(this.radioButton_PSG_CheckedChanged);
            // 
            // checkBox_alphaIntrusion
            // 
            this.checkBox_alphaIntrusion.AutoSize = true;
            this.checkBox_alphaIntrusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_alphaIntrusion.Location = new System.Drawing.Point(12, 57);
            this.checkBox_alphaIntrusion.Name = "checkBox_alphaIntrusion";
            this.checkBox_alphaIntrusion.Size = new System.Drawing.Size(144, 24);
            this.checkBox_alphaIntrusion.TabIndex = 7;
            this.checkBox_alphaIntrusion.Text = "Alpha Intrusion?";
            // 
            // checkBox_REM_SWS_rebound
            // 
            this.checkBox_REM_SWS_rebound.AutoSize = true;
            this.checkBox_REM_SWS_rebound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_REM_SWS_rebound.Location = new System.Drawing.Point(12, 90);
            this.checkBox_REM_SWS_rebound.Name = "checkBox_REM_SWS_rebound";
            this.checkBox_REM_SWS_rebound.Size = new System.Drawing.Size(244, 24);
            this.checkBox_REM_SWS_rebound.TabIndex = 8;
            this.checkBox_REM_SWS_rebound.Text = "REM/SWS Rebound from TX?";
            // 
            // comboBox_arrhy
            // 
            this.comboBox_arrhy.AllowDrop = true;
            this.comboBox_arrhy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_arrhy.Items.AddRange(new object[]
            {
                "PVC\'s",
                "PAC\'s",
                "Atrial Fibrillation",
                "Atrial Flutter",
                "Bradycardia",
                "Tachycardia"
            });
            this.comboBox_arrhy.Location = new System.Drawing.Point(150, 252);
            this.comboBox_arrhy.Name = "comboBox_arrhy";
            this.comboBox_arrhy.Size = new System.Drawing.Size(131, 28);
            this.comboBox_arrhy.TabIndex = 13;
            // 
            // checkBox_Arrhythmias
            // 
            this.checkBox_Arrhythmias.AutoSize = true;
            this.checkBox_Arrhythmias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_Arrhythmias.Location = new System.Drawing.Point(12, 222);
            this.checkBox_Arrhythmias.Name = "checkBox_Arrhythmias";
            this.checkBox_Arrhythmias.Size = new System.Drawing.Size(121, 24);
            this.checkBox_Arrhythmias.TabIndex = 14;
            this.checkBox_Arrhythmias.Text = "Arrhythmias?";
            this.checkBox_Arrhythmias.CheckedChanged += new System.EventHandler(this.checkBox_Arrhythmias_CheckedChanged);
            // 
            // comboBox_arrfreq
            // 
            this.comboBox_arrfreq.AllowDrop = true;
            this.comboBox_arrfreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.comboBox_arrfreq.Items.AddRange(new object[]
            {
                "Frequent",
                "Infrequent"
            });
            this.comboBox_arrfreq.Location = new System.Drawing.Point(9, 252);
            this.comboBox_arrfreq.Name = "comboBox_arrfreq";
            this.comboBox_arrfreq.Size = new System.Drawing.Size(124, 28);
            this.comboBox_arrfreq.TabIndex = 15;
            this.comboBox_arrfreq.SelectedIndexChanged +=
                new System.EventHandler(this.comboBox_arrfreq_SelectedIndexChanged);
            // 
            // checkBox_bruxism
            // 
            this.checkBox_bruxism.AutoSize = true;
            this.checkBox_bruxism.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBox_bruxism.Location = new System.Drawing.Point(12, 118);
            this.checkBox_bruxism.Name = "checkBox_bruxism";
            this.checkBox_bruxism.Size = new System.Drawing.Size(93, 24);
            this.checkBox_bruxism.TabIndex = 16;
            this.checkBox_bruxism.Text = "Bruxism?";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripButton1,
                this.toolStripSeparator1,
                this.toolStripButton2,
                this.toolStripSeparator2,
                this.toolStripButton_getInterp,
                this.toolStripSeparator3
            });
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 26);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.toolStripButton1.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 23);
            this.toolStripButton1.Text = "Open File";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.toolStripButton2.Image = ((System.Drawing.Image) (resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(154, 23);
            this.toolStripButton2.Text = "Manually Enter Data";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButton_getInterp
            // 
            this.toolStripButton_getInterp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_getInterp.Enabled = false;
            this.toolStripButton_getInterp.Font = new System.Drawing.Font("Tahoma", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.toolStripButton_getInterp.Image =
                ((System.Drawing.Image) (resources.GetObject("toolStripButton_getInterp.Image")));
            this.toolStripButton_getInterp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_getInterp.Name = "toolStripButton_getInterp";
            this.toolStripButton_getInterp.Size = new System.Drawing.Size(85, 23);
            this.toolStripButton_getInterp.Text = "Get Interp";
            this.toolStripButton_getInterp.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // checkBoxCarboxy
            // 
            this.checkBoxCarboxy.AutoSize = true;
            this.checkBoxCarboxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxCarboxy.Location = new System.Drawing.Point(12, 148);
            this.checkBoxCarboxy.Name = "checkBoxCarboxy";
            this.checkBoxCarboxy.Size = new System.Drawing.Size(239, 24);
            this.checkBoxCarboxy.TabIndex = 18;
            this.checkBoxCarboxy.Text = "Elevated carboxyhemoglobin?";
            this.checkBoxCarboxy.UseVisualStyleBackColor = true;
            // 
            // checkBoxHypoxemia
            // 
            this.checkBoxHypoxemia.AutoSize = true;
            this.checkBoxHypoxemia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.checkBoxHypoxemia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxHypoxemia.Location = new System.Drawing.Point(12, 184);
            this.checkBoxHypoxemia.Name = "checkBoxHypoxemia";
            this.checkBoxHypoxemia.Size = new System.Drawing.Size(115, 24);
            this.checkBoxHypoxemia.TabIndex = 19;
            this.checkBoxHypoxemia.Text = "Hypoxemia?";
            this.checkBoxHypoxemia.UseVisualStyleBackColor = true;
            // 
            // PrelimInter
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 494);
            this.Controls.Add(this.checkBoxHypoxemia);
            this.Controls.Add(this.checkBoxCarboxy);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox_bruxism);
            this.Controls.Add(this.comboBox_arrfreq);
            this.Controls.Add(this.checkBox_Arrhythmias);
            this.Controls.Add(this.comboBox_arrhy);
            this.Controls.Add(this.checkBox_REM_SWS_rebound);
            this.Controls.Add(this.checkBox_alphaIntrusion);
            this.Controls.Add(this.groupBox_studyType);
            this.Name = "PrelimInter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preliminary Interpretation";
            this.groupBox_studyType.ResumeLayout(false);
            this.groupBox_studyType.PerformLayout();
            this.groupBox_finalTx.ResumeLayout(false);
            this.groupBox_finalTx.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]


        //EVENTS
        private void radioButton_split_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_finalTx.Enabled = true;
            comboBox_finalCpap.Enabled = true;
        }

        private void radioButton_CPAP_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_finalCpap.Visible = true;
        }

        private void radioButton_BiPAP_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_finalCpap.Visible = false;
        }

        private void radioButton_PSG_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_finalTx.Enabled = false;
            radioButton_CPAP.Checked = false;
        }

        private void radioButton_titration_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_finalTx.Enabled = true;
            comboBox_finalCpap.Enabled = true;
        }

        private void GetInterpFromFile_Click(object sender, EventArgs e)
        {
            getDDRfile();
        }

        private void checkBox_Arrhythmias_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_arrfreq.DroppedDown = true;
        }

        private void comboBox_arrfreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_arrhy.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dlg = new about();
            dlg.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            getDDRfile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            manEnterData();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            getInterp();
        }

        private void button_getInterp_Click(object sender, EventArgs e)
        {
            getInterp();
        }

        private void comboBox_finalCpap_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripButton_getInterp.Enabled = true;
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            manEnterData();
        }

        private void getDDRfile()
        {
            dlgOpenFile.InitialDirectory = path;
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                fileName = dlgOpenFile.FileName;
                path = Environment.CurrentDirectory;
                comboBox_finalCpap.Items.Clear();
                fillList();


                for (var i = 0; i < sleepList.Count; i++)
                {
                    if ((string) sleepList[i] == "[TESTLOCATION]")
                    {
                        var str = (string) sleepList[i + 1];
                        if (
                            str.StartsWith("psg") || str.StartsWith("Poly")
                            || (str.StartsWith("PO") || str.StartsWith("Post")
                                || str.StartsWith("PSG")
                                || str.StartsWith("POLY")) && !str.Equals("PSG/CPAP Polysomnogram"))
                        {
                            radioButton_PSG.Checked = true;
                            toolStripButton_getInterp.Enabled = true;
                            break;
                        }
                        if (str.StartsWith("Apnea") || str.StartsWith("PSG/CPAP") || str.StartsWith("PSG/BIPAP"))
                        {
                            radioButton_split.Checked = true;
                            radioButton_CPAP.Checked = true;

                            MessageBox.Show("Choose a final Pressure!!");
                            comboBox_finalCpap.DroppedDown = true;
                            if (comboBox_finalCpap.SelectedText.StartsWith("TX"))
                                toolStripButton_getInterp.Enabled = true;
                            break;
                        }
                        if (str.StartsWith("CPAP"))
                        {
                            radioButton_titration.Checked = true;
                            radioButton_CPAP.Checked = true;
                            MessageBox.Show("Choose a final Pressure!!");
                            comboBox_finalCpap.DroppedDown = true;
                            if (comboBox_finalCpap.SelectedText.StartsWith("TX"))
                                toolStripButton_getInterp.Enabled = true;
                            break;
                        }
                        var dlg = new StudyType();
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            radioButton_PSG.Checked = dlg.radioButton_psg.Checked;
                            radioButton_titration.Checked = dlg.radioButton_tx.Checked;
                            radioButton_split.Checked = dlg.radioButton_split.Checked;
                            if (radioButton_titration.Checked || radioButton_split.Checked)
                            {
                                radioButton_CPAP.Checked = true;
                                MessageBox.Show("Choose a final Pressure!!");
                                comboBox_finalCpap.DroppedDown = true;
                                if (comboBox_finalCpap.SelectedText.StartsWith("TX"))
                                    toolStripButton_getInterp.Enabled = true;
                                break;
                            }

                            toolStripButton_getInterp.Enabled = true;
                        }
                    }
                }

                isFromFile = true;
            }
        }

        private void getInterp()
        {
            if (isFromFile)
            {
                isFromFile = false;
                getSleepParaFromList();
            }


            output = "\r\n-----------------------------------------------------"
                     + "-------------------------";
            output += "\r\nName: " + patient_name + "\r\n";
            output += "DOB: " + patien_dob + "\r\n";
            output += getCommentTSTandPosition();
            output += "\r\n";

            output += getArchitecture();
            getCommentRespirations();


            output += getCommentOnPlm();

            getAbgInfo();

            if (checkBox_Arrhythmias.Checked)
                output += comboBox_arrfreq.Text + " " + comboBox_arrhy.Text
                          + " are seen.\r\n";
            showValues();
            reset();
        }

        private void getCommentRespirations()
        {
            resComment();
        }

        private void resComment()
        {
            var type = "";
            var value = "";
            if (radioButton_PSG.Checked)
            {
                spo2ArtifactCheck(ref psg_lowestSpO2, psg_totalAHI);
                Respirations rd =
                    new RespirationsDiagnostic(
                        psg_sleepTime,
                        psg_supineSleepTime,
                        psg_latSleepTime,
                        psg_remSleepTime,
                        psg_totalAHI,
                        psg_supineAHI,
                        psg_lateralAHI,
                        psg_RemAHI,
                        psg_lowestSpO2
                        );
                output += rd.Result + "\r\n";
            }

            if (radioButton_titration.Checked)
            {
                spo2ArtifactCheck(ref final_lowestSpO2, final_totalAHI);
                value = comboBox_finalCpap.Text.Remove(0, 3);
                if (value.Contains("/"))
                    type = "BIPAP";
                else
                    type = "CPAP";
                Respirations rtx =
                    new RespirationsTitrationFinalTX(
                        final_sleepTime,
                        final_supineSleepTime,
                        final_latSleepTime,
                        final_remSleepTime,
                        final_totalAHI,
                        final_supineAHI,
                        final_lateralAHI,
                        final_RemAHI,
                        final_lowestSpO2,
                        type,
                        value,
                        RespirationsComment.StudyType.Titration
                        );
                output += rtx.Result + "\r\n";
            }

            if (radioButton_split.Checked)
            {
                spo2ArtifactCheck(ref diag_lowestSpO2, diag_totalAHI);
                value = comboBox_finalCpap.Text.Remove(0, 3);
                if (value.Contains("/"))
                    type = "BIPAP";
                else
                    type = "CPAP";
                Respirations rd = new RespirationsDiagnostic(
                    diag_sleepTime,
                    diag_supineSleepTime,
                    diag_latSleepTime,
                    diag_remSleepTime,
                    diag_totalAHI,
                    diag_supineAHI,
                    diag_lateralAHI,
                    diag_RemAHI,
                    diag_lowestSpO2
                    );
                output += rd.Result + "\r\n";

                spo2ArtifactCheck(ref final_lowestSpO2, final_totalAHI);
                Respirations rtx = new RespirationsSplitFinalTX(
                    final_sleepTime,
                    final_supineSleepTime,
                    final_latSleepTime,
                    final_remSleepTime,
                    final_totalAHI,
                    final_supineAHI,
                    final_lateralAHI,
                    final_RemAHI,
                    final_lowestSpO2,
                    type,
                    value,
                    RespirationsComment.StudyType.SplitNight
                    );
                output += rtx.Result + "\r\n";
            }
        }

        private void spo2ArtifactCheck(ref float lowestSpO2, float rdi)
        {
            if ((rdi <= 4.4f) && (lowestSpO2 < 90f))
            {
                var dlg = new SpO2Artifact();
                dlg.textBox_spo2Value.Text = lowestSpO2.ToString();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    lowestSpO2 = float.Parse(dlg.textBox_spo2Value.Text);
                }
            }
        }

        private void getAbgInfo()
        {
            if (checkBoxCarboxy.Checked && checkBoxHypoxemia.Checked)
                output += "ABG's reveal hypoxemia and an elevated carboxyhemoglobin.\r\n";
            if (checkBoxCarboxy.Checked && !checkBoxHypoxemia.Checked)
                output += "ABG's reveal an elevated carboxyhemoglobin.\r\n";
            if (!checkBoxCarboxy.Checked && checkBoxHypoxemia.Checked)
                output += "ABG's reveal hypoxemia.\r\n";
        }

        private void fillList()
        {
            var list = new ArrayList(); //need new list each time to multiple interps.
            var aFile = new FileStream(fileName, FileMode.Open);
            var sr = new StreamReader(aFile);
            string str;
            str = sr.ReadLine();
            list.Add(str);
            while (str != null)
            {
                str = sr.ReadLine();
                list.Add(str);
            }
            sr.Close();
            for (var i = 0; i < list.Count; i++)
            {
                if (((string) list[i] == "-") || ((string) list[i] == " -") ||
                    ((string) list[i] == "  -"))
                    list[i] = "0";
            }
            sleepList = list;
            fillCPAPCombox();
        }

        private void getSleepParaFromList()
        {
            try
            {
                total_wake_PercentOfTST = float.Parse((string) sleepList[17]);
                total_stage1_PercentOfTST = float.Parse((string) sleepList[20]);
                total_stage2_PercentOfTST = float.Parse((string) sleepList[23]);
                total_sws_PercentOfTST = float.Parse((string) sleepList[26]);
                total_rem_PercentOfTST = float.Parse((string) sleepList[29]);
                total_plm_index = float.Parse((string) sleepList[82]);
                total_plm_arousal_index = float.Parse((string) sleepList[85]);
                total_sleepLatency = float.Parse((string) sleepList[39]);

                if (radioButton_PSG.Checked) //this is a PSG only study
                {
                    psg_sleepTime = float.Parse((string) sleepList[108]);
                    psg_supineSleepTime = float.Parse((string) sleepList[159]);
                    psg_latSleepTime = float.Parse((string) sleepList[159]);
                    psg_remSleepTime = float.Parse((string) sleepList[161]);
                    psg_totalAHI = float.Parse((string) sleepList[112]);
                    psg_RemAHI = float.Parse((string) sleepList[113]);
                    psg_supineAHI = float.Parse((string) sleepList[160]);
                    psg_lateralAHI = float.Parse((string) sleepList[162]);
                    psg_lowestSpO2 = float.Parse((string) sleepList[115]);
                    psg_avgSpO2 = float.Parse((string) sleepList[114]);
                }

                if (radioButton_split.Checked) //this is a split night
                {
                    //these are in the same place as in a psg
                    diag_sleepTime = float.Parse((string) sleepList[108]);
                    diag_remSleepTime = float.Parse((string) sleepList[109]);
                    diag_totalAHI = float.Parse((string) sleepList[112]);
                    diag_RemAHI = float.Parse((string) sleepList[113]);
                    diag_lowestSpO2 = float.Parse((string) sleepList[115]);
                    diag_avgSpO2 = float.Parse((string) sleepList[114]);

                    //can start search at last known value: low SpO2 at sleepList[115]
                    for (var i = 115; i < sleepList.Count; i++) //the end of first table
                    {
                        if ((string) sleepList[i] == "TX=0") //the end of the second table
                        {
                            i++;
                            for (; i < sleepList.Count; i++)
                            {
                                if ((string) sleepList[i] == "TX=0")
                                {
                                    diag_supineSleepTime = float.Parse((string) sleepList[i + 1]);
                                    diag_supineAHI = float.Parse((string) sleepList[i + 2]);
                                    diag_latSleepTime = float.Parse((string) sleepList[i + 3]);
                                    diag_lateralAHI = float.Parse((string) sleepList[i + 4]);
                                    i = sleepList.Count; //this will break outer loop
                                }
                            } //end for(;i<...
                        }
                    } //end for(i=115...
                } // end if (radioButton_split....

                if (radioButton_CPAP.Checked)
                {
                    var str = comboBox_finalCpap.Text;

                    for (var i = 0; i < sleepList.Count; i++)
                    {
                        if ((string) sleepList[i] == str)
                        {
                            final_sleepTime = float.Parse((string) sleepList[i + 2]);
                            final_remSleepTime = float.Parse((string) sleepList[i + 3]);
                            final_totalAHI = float.Parse((string) sleepList[i + 6]);
                            final_RemAHI = float.Parse((string) sleepList[i + 7]);
                            final_avgSpO2 = float.Parse((string) sleepList[i + 8]);
                            final_lowestSpO2 = float.Parse((string) sleepList[i + 9]);

                            for (i += 9; i < sleepList.Count; i++) //the end of first table
                            {
                                if ((string) sleepList[i] == str) //the end of the second table
                                {
                                    i++;
                                    for (; i < sleepList.Count; i++)
                                    {
                                        if ((string) sleepList[i] == str)
                                        {
                                            final_supineSleepTime = float.Parse((string) sleepList[i + 1]);
                                            final_supineAHI = float.Parse((string) sleepList[i + 2]);
                                            final_latSleepTime = float.Parse((string) sleepList[i + 3]);
                                            final_lateralAHI = float.Parse((string) sleepList[i + 4]);
                                            i = sleepList.Count; //this will break outer loop
                                        }
                                    } //end for(;i<...
                                }
                            } //end for(i=115...
                        }
                    }
                } // end if (radioButton_CPAP...


                var gotPt = true;
                for (var i = 115; i < sleepList.Count; i++)
                {
                    if ((string) sleepList[i] == "[PATIENT]" && gotPt)
                    {
                        gotPt = false;
                        patient_name = (string) sleepList[i + 1];
                        patient_sdate = (string) sleepList[i + 3];
                        patien_dob = (string) sleepList[i + 7];
                        patient_Age = int.Parse((string) sleepList[i + 15]);

                        try
                        {
                            total_SleepTimeMin = float.Parse((string) sleepList[i + 47]);
                        }
                        catch
                        {
                            total_SleepTimeMin = float.Parse((string) sleepList[i + 49]);
                            i = i + 2;
                        }
                        total_sleepEfficiency = float.Parse((string) sleepList[i + 49]);
                        total_remLatency = float.Parse((string) sleepList[i + 51]);
                        patient_studyType = (string) sleepList[i + 33];
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void fillCPAPCombox()
        {
            var i = 0;
            string str = "", temp = "";

            for (; i < sleepList.Count; i++)
            {
                temp = (string) sleepList[i];
                if (temp != null && temp.StartsWith("TX="))
                {
                    i++;
                    break;
                }
            }

            while (str != temp)
            {
                str = (string) sleepList[i];

                if (str != null && str.StartsWith("TX="))
                {
                    comboBox_finalCpap.Items.Add(str);
                }
                i++;
            }
            comboBox_finalCpap.Items.Remove("TX=0");
        }

        private string getCommentTSTandPosition()
        {
            TSTbodyPos comment;

            if (radioButton_PSG.Checked)
            {
                comment = new TSTbodyPos(psg_sleepTime, psg_supineSleepTime);
                return comment.Result;
            }

            if (radioButton_split.Checked)
            {
                var txType = "";
                var txValue = comboBox_finalCpap.Text.Remove(0, 3);
                if (txValue.Contains("/"))
                    txType = "BIPAP";
                else
                    txType = "CPAP";
                txValue = txValue + " cm H2O";

                comment = new TSTbodyPos(
                    total_SleepTimeMin,
                    diag_sleepTime,
                    diag_supineSleepTime,
                    final_sleepTime,
                    final_supineSleepTime,
                    txType,
                    txValue
                    );
                return comment.Result;
            }

            if (radioButton_titration.Checked)
            {
                var txType = "";
                var txValue = comboBox_finalCpap.Text.Remove(0, 3);
                if (txValue.Contains("/"))
                    txType = "BIPAP";
                else
                    txType = "CPAP";
                txValue = txValue + " cm H2O";

                comment = new TSTbodyPos(
                    total_SleepTimeMin,
                    final_sleepTime,
                    final_supineSleepTime,
                    txType,
                    txValue
                    );
                return comment.Result;
            }

            return "";
        }

        private string getArchitecture()
        {
            string str;

            checkPatientAge();

            var sa =
                new SleepArchitecture(
                    patient_Age,
                    total_stage1_PercentOfTST,
                    total_stage2_PercentOfTST,
                    total_sws_PercentOfTST,
                    total_rem_PercentOfTST
                    );

            str = sa.GetResults();

            return getMiscSleepArchPara(ref str);
        }

        private string getMiscSleepArchPara(ref string str)
        {
            ///Alpha Intrusion
            ///
            if (checkBox_alphaIntrusion.Checked)
            {
                str += " Alpha intrusion is noted.";
                checkBox_alphaIntrusion.Checked = false;
            }
            /// REM/SWS rebound on CPAP
            /// 
            if (checkBox_REM_SWS_rebound.Checked
                && radioButton_CPAP.Checked)
            {
                str += " Slow wave sleep rebound is noted following initiation"
                       + " of treatment.";
                checkBox_REM_SWS_rebound.Checked = false;
            }
            if (checkBox_REM_SWS_rebound.Checked
                && radioButton_CPAP.Checked)
            {
                str += " REM sleep rebound is noted following "
                       + "initiation of treatment.";
                checkBox_REM_SWS_rebound.Checked = false;
            }
            if (str != null)
                str += " ";
            /// sleep latency
            /// 
            if (total_sleepLatency <= 5.0)
                str += "A short sleep latency is noted, indicative of "
                       + "excessive sleepiness. ";
            if (total_sleepLatency <= 1)
                MessageBox.Show("The sleep latency is very short. Check lights out time.");
            /// REM latency
            /// 
            if ((total_remLatency < 60) && (total_rem_PercentOfTST > 0))
                str += "A short REM latency is noted which may be seen"
                       + " in chronic sleep"
                       + " deprivation, narcolepsy and or depression. ";
            /// sleep efficiency
            /// 
            if (total_sleepEfficiency < 60)
                str += "Poor sleep efficiency is noted at "
                       + total_sleepEfficiency.ToString("###")
                       + "%. ";
            if (checkBox_bruxism.Checked)
                str += "Arousals due to possible Bruxism are noted.";
            str += "\r\n";

            return str;
        }

        private void checkPatientAge()
        {
            if (patient_Age == 0)
            {
                var dlg = new Age();
                dlg.textBox1.Text = patient_Age.ToString();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    patient_Age = int.Parse(dlg.textBox1.Text);
                }
            }
        }

        private string getCommentOnPlm()
        {
            if (total_plm_index < 5)
                return "No PLM's are noted.\r\n";
            var percentArousal
                = total_plm_arousal_index/total_plm_index*100;
            if (percentArousal >= 1)
            {
                return "Periodic limb movements are present with "
                       + total_plm_index.ToString("###")
                       + " events per hour of sleep; " + percentArousal.ToString("###")
                       + "% of these are associated with obvious EEG arousals.\r\n";
            }
            return "Periodic limb movements are present with "
                   + total_plm_index.ToString("###")
                   + " events per hour of sleep.";
        }

        private void showValues()
        {
            var dlg = new prelimEditor();

            dlg.richTextBox_interp.Text = output;

            dlg.textBox_remLatency.Text = total_remLatency.ToString();
            dlg.textBox_sleepLatency.Text = total_sleepLatency.ToString();
            dlg.textBox_SleepTimeMin.Text = total_SleepTimeMin.ToString();
            dlg.textBox_plmArousalIndex.Text = total_plm_arousal_index.ToString();
            dlg.textBox_plmIndex.Text = total_plm_index.ToString();
            dlg.textBox_rem_percentOfTST.Text = total_rem_PercentOfTST.ToString();
            dlg.textBox_sleepEfficiency.Text = total_sleepEfficiency.ToString();
            dlg.textBox_stage1_percentOfTST.Text = total_stage1_PercentOfTST.ToString();
            dlg.textBox_stage2_percentOfTST.Text = total_stage2_PercentOfTST.ToString();
            dlg.textBox_sws_percentOfTST.Text = total_sws_PercentOfTST.ToString();
            dlg.textBox_wake_percentOfTST.Text = total_wake_PercentOfTST.ToString();
            dlg.psg_lateralAHI.Text = psg_lateralAHI.ToString();
            dlg.psg_lowestSpO2.Text = psg_lowestSpO2.ToString();
            dlg.psg_RemAHI.Text = psg_RemAHI.ToString();
            dlg.psg_remSleepTime.Text = psg_remSleepTime.ToString();
            dlg.psg_sleepTime.Text = psg_sleepTime.ToString();
            dlg.psg_supineAHI.Text = psg_supineAHI.ToString();
            dlg.psg_supineSleepTime.Text = psg_supineSleepTime.ToString();
            dlg.psg_totalAHI.Text = psg_totalAHI.ToString();

            dlg.diag_lateralAHI.Text = diag_lateralAHI.ToString();
            dlg.diag_lowestSpO2.Text = diag_lowestSpO2.ToString();
            dlg.diag_RemAHI.Text = diag_RemAHI.ToString();
            dlg.diag_remSleepTime.Text = diag_remSleepTime.ToString();
            dlg.diag_sleepTime.Text = diag_sleepTime.ToString();
            dlg.diag_supineAHI.Text = diag_supineAHI.ToString();
            dlg.diag_supineSleepTime.Text = diag_supineSleepTime.ToString();
            dlg.diag_totalAHI.Text = diag_totalAHI.ToString();

            dlg.final_lateralAHI.Text = final_lateralAHI.ToString();
            dlg.final_lowestSpO2.Text = final_lowestSpO2.ToString();
            dlg.final_RemAHI.Text = final_RemAHI.ToString();
            dlg.final_remSleepTime.Text = final_remSleepTime.ToString();
            dlg.final_sleepTime.Text = final_sleepTime.ToString();
            dlg.final_supineAHI.Text = final_supineAHI.ToString();
            dlg.final_supineSleepTime.Text = final_supineSleepTime.ToString();
            dlg.final_totalAHI.Text = final_totalAHI.ToString();


            dlg.textBox_remLatency.ReadOnly = true;
            dlg.textBox_sleepLatency.ReadOnly = true;
            dlg.textBox_SleepTimeMin.ReadOnly = true;
            dlg.textBox_plmArousalIndex.ReadOnly = true;
            dlg.textBox_plmIndex.ReadOnly = true;
            dlg.textBox_rem_percentOfTST.ReadOnly = true;
            dlg.textBox_sleepEfficiency.ReadOnly = true;
            dlg.textBox_stage1_percentOfTST.ReadOnly = true;
            dlg.textBox_stage2_percentOfTST.ReadOnly = true;
            dlg.textBox_sws_percentOfTST.ReadOnly = true;
            dlg.textBox_wake_percentOfTST.ReadOnly = true;
            dlg.psg_lateralAHI.ReadOnly = true;
            dlg.psg_lowestSpO2.ReadOnly = true;
            dlg.psg_RemAHI.ReadOnly = true;
            dlg.psg_remSleepTime.ReadOnly = true;
            dlg.psg_sleepTime.ReadOnly = true;
            dlg.psg_supineAHI.ReadOnly = true;
            dlg.psg_supineSleepTime.ReadOnly = true;
            dlg.psg_totalAHI.ReadOnly = true;
            dlg.diag_lateralAHI.ReadOnly = true;
            dlg.diag_lowestSpO2.ReadOnly = true;
            dlg.diag_RemAHI.ReadOnly = true;
            dlg.diag_remSleepTime.ReadOnly = true;
            dlg.diag_sleepTime.ReadOnly = true;
            dlg.diag_supineAHI.ReadOnly = true;
            dlg.diag_supineSleepTime.ReadOnly = true;
            dlg.diag_totalAHI.ReadOnly = true;

            dlg.final_lateralAHI.ReadOnly = true;
            dlg.final_lowestSpO2.ReadOnly = true;
            dlg.final_RemAHI.ReadOnly = true;
            dlg.final_remSleepTime.ReadOnly = true;
            dlg.final_sleepTime.ReadOnly = true;
            dlg.final_supineAHI.ReadOnly = true;
            dlg.final_supineSleepTime.ReadOnly = true;
            dlg.final_totalAHI.ReadOnly = true;
            dlg.Text = patient_name;
            if (radioButton_PSG.Checked)
                dlg.Text += "     Polysomnogram    " + patient_sdate;
            dlg.ShowDialog();
        }

        private void manEnterData()
        {
            var man = new prelimIntMan();
            if (man.ShowDialog() == DialogResult.OK)
            {
                toolStripButton_getInterp.Enabled = true;
                ;
                try
                {
                    total_SleepTimeMin = float.Parse(man.textBox_TST.Text);
                    total_wake_PercentOfTST = float.Parse(man.textBox_wakeTst.Text);
                    total_stage1_PercentOfTST = float.Parse(man.textBox_s1tst.Text);
                    total_stage2_PercentOfTST = float.Parse(man.textBox_s2Tst.Text);
                    total_sws_PercentOfTST = float.Parse(man.textBox_swsTst.Text);
                    total_rem_PercentOfTST = float.Parse(man.textBox_remTst.Text);
                    total_sleepLatency = float.Parse(man.textBox_slpLat.Text);
                    total_remLatency = float.Parse(man.textBox_remLat.Text);
                    total_sleepEfficiency = float.Parse(man.textBox_sleepEff.Text);
                    total_plm_index = float.Parse(man.textBox_plmIdx.Text);
                    total_plm_arousal_index = float.Parse(man.textBox_plmArrIdx.Text);
                    psg_sleepTime = float.Parse(man.textBox_PsgTST.Text);
                    psg_supineSleepTime = float.Parse(man.textBox_psgSupTime.Text);
                    psg_latSleepTime = float.Parse(man.textBox_PsgLatTime.Text);
                    psg_remSleepTime = float.Parse(man.textBox_psgRem.Text);
                    psg_totalAHI = float.Parse(man.textBox_psgTotRdi.Text);
                    psg_RemAHI = float.Parse(man.textBox_PsgRemRdi.Text);
                    psg_supineAHI = float.Parse(man.textBox_psgSupRdi.Text);
                    psg_lateralAHI = float.Parse(man.textBox_psgLatRdi.Text);
                    psg_lowestSpO2 = float.Parse(man.textBox_psgLowSpo2.Text);
                    psg_avgSpO2 = float.Parse(man.textBox_psgAvgSpo2.Text);
                    diag_sleepTime = float.Parse(man.textBox_diagTst.Text);
                    diag_supineSleepTime = float.Parse(man.textBox_diagSupTime.Text);
                    diag_latSleepTime = float.Parse(man.textBox_diagLatTime.Text);
                    diag_remSleepTime = float.Parse(man.textBox_diagRemTime.Text);
                    diag_totalAHI = float.Parse(man.textBox_diagTotRdi.Text);
                    diag_RemAHI = float.Parse(man.textBox_diagRemRdi.Text);
                    diag_supineAHI = float.Parse(man.textBox_diagSupRdi.Text);
                    diag_lateralAHI = float.Parse(man.textBox_diagLatRdi.Text);
                    diag_lowestSpO2 = float.Parse(man.textBox_diagLowSpo2.Text);
                    diag_avgSpO2 = float.Parse(man.textBox_diagAvgSpo2.Text);
                    final_sleepTime = float.Parse(man.textBox_finalTst.Text);
                    final_supineSleepTime = float.Parse(man.textBox_finalSupTime.Text);
                    final_latSleepTime = float.Parse(man.textBox_finalLatTime.Text);
                    final_remSleepTime = float.Parse(man.textBox_finalRemTime.Text);
                    final_totalAHI = float.Parse(man.textBox_finalTotRdi.Text);
                    final_RemAHI = float.Parse(man.textBox_finalRdi.Text);
                    final_supineAHI = float.Parse(man.textBox_finalSupRdi.Text);
                    final_lateralAHI = float.Parse(man.textBox_finalLatRdi.Text);
                    final_lowestSpO2 = float.Parse(man.textBox_finalLatSpo2.Text);
                    final_avgSpO2 = float.Parse(man.textBox_finalAvgSpo2.Text);
                    patient_Age = int.Parse(man.textBox_PtAge.Text);
                    radioButton_PSG.Checked = man.radioButton_Psgonly.Checked;
                    radioButton_split.Checked = man.radioButton_splitstudy.Checked;
                    radioButton_CPAP.Checked = man.radioButton_titration.Checked;
                    comboBox_finalCpap.Text = "tx=" + man.textBox_FinalTx.Text;
                    radioButton_titration.Checked = man.radioButton_titration.Checked;


                    toolStripButton_getInterp.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Wrong Value Type Entered.");
                }
            }
        }

        private void reset()
        {
            radioButton_CPAP.Checked = false;
            radioButton_PSG.Checked = false;
            radioButton_split.Checked = false;
            radioButton_titration.Checked = false;
            toolStripButton_getInterp.Enabled = false;
            checkBox_alphaIntrusion.Checked = false;
            checkBox_REM_SWS_rebound.Checked = false;
            checkBoxCarboxy.Checked = false;
            checkBoxHypoxemia.Checked = false;
            checkBox_Arrhythmias.Checked = false;
            checkBox_bruxism.Checked = false;
            comboBox_arrfreq.Text = "";
            comboBox_arrhy.Text = "";
            comboBox_finalCpap.Enabled = false;
            comboBox_finalCpap.Text = "";


            total_SleepTimeMin = 0;
            total_wake_PercentOfTST = 0;
            total_stage1_PercentOfTST = 0;
            total_stage2_PercentOfTST = 0;
            total_sws_PercentOfTST = 0;
            total_rem_PercentOfTST = 0;
            total_sleepLatency = 0;
            total_remLatency = 0;
            total_sleepEfficiency = 0;
            total_plm_index = 0;
            total_plm_arousal_index = 0;

            // Diagnostic Parameters
            // If study is a PSG then these values will be used.
            psg_sleepTime = 0;
            psg_supineSleepTime = 0;
            psg_latSleepTime = 0;
            psg_remSleepTime = 0;
            psg_totalAHI = 0;
            psg_RemAHI = 0;
            psg_supineAHI = 0;
            psg_lateralAHI = 0;
            psg_lowestSpO2 = 0;
            psg_avgSpO2 = 0;

            diag_sleepTime = 0;
            diag_supineSleepTime = 0;
            diag_latSleepTime = 0;
            diag_remSleepTime = 0;
            diag_totalAHI = 0;
            diag_RemAHI = 0;
            diag_supineAHI = 0;
            diag_lateralAHI = 0;
            diag_lowestSpO2 = 0;
            diag_avgSpO2 = 0;
            //

            //final TX Parameters
            final_sleepTime = 0;
            final_supineSleepTime = 0;
            final_latSleepTime = 0;
            final_remSleepTime = 0;
            final_totalAHI = 0;
            final_RemAHI = 0;
            final_supineAHI = 0;
            final_lateralAHI = 0;
            final_lowestSpO2 = 0;
            final_avgSpO2 = 0;
        }

        #region

        private OpenFileDialog dlgOpenFile;
        private GroupBox groupBox_studyType;
        private RadioButton radioButton_PSG;
        private RadioButton radioButton_titration;
        private RadioButton radioButton_CPAP;
        private ComboBox comboBox_finalCpap;
        private GroupBox groupBox_finalTx;
        private string path;

        private string fileName = "Untitled";
        private ArrayList sleepList = new ArrayList();
        private bool isFromFile;
        private string output;
        private string patient_studyType;
        private string patient_name;
        private string patient_sdate;
        private int patient_Age;
        private string patien_dob;

        /// Total sleep parameters
        private float total_SleepTimeMin;

        private float total_wake_PercentOfTST;
        private float total_stage1_PercentOfTST;
        private float total_stage2_PercentOfTST;
        private float total_sws_PercentOfTST;
        private float total_rem_PercentOfTST;
        private float total_sleepLatency;
        private float total_remLatency;
        private float total_sleepEfficiency;
        private float total_plm_index;
        private float total_plm_arousal_index;

        // Diagnostic Parameters
        // If study is a PSG then these values will be used.
        private float psg_sleepTime;
        private float psg_supineSleepTime;
        private float psg_latSleepTime;
        private float psg_remSleepTime;
        private float psg_totalAHI;
        private float psg_RemAHI;
        private float psg_supineAHI;
        private float psg_lateralAHI;
        private float psg_lowestSpO2;
        private float psg_avgSpO2;

        private float diag_sleepTime;
        private float diag_supineSleepTime;
        private float diag_latSleepTime;
        private float diag_remSleepTime;
        private float diag_totalAHI;
        private float diag_RemAHI;
        private float diag_supineAHI;
        private float diag_lateralAHI;
        private float diag_lowestSpO2;
        private float diag_avgSpO2;

        #endregion

        //

        #region

        //final TX Parameters
        private float final_sleepTime;
        private float final_supineSleepTime;
        private float final_latSleepTime;
        private float final_remSleepTime;
        private float final_totalAHI;
        private float final_RemAHI;
        private float final_supineAHI;
        private float final_lateralAHI;
        private float final_lowestSpO2;
        private float final_avgSpO2;
        private RadioButton radioButton_split;
        private CheckBox checkBox_alphaIntrusion;
        private CheckBox checkBox_REM_SWS_rebound;
        private ComboBox comboBox_arrhy;
        private CheckBox checkBox_Arrhythmias;
        private ComboBox comboBox_arrfreq;
        private CheckBox checkBox_bruxism;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton_getInterp;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private CheckBox checkBoxCarboxy;
        private CheckBox checkBoxHypoxemia;
        private ToolStripSeparator toolStripSeparator3;
        //
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        #endregion
    }
}