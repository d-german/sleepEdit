namespace SleepEditControlLib
{
    partial class ABG
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_NRB = new System.Windows.Forms.GroupBox();
            this.comboBox_no15Lpm = new System.Windows.Forms.ComboBox();
            this.radioButton_NRBno = new System.Windows.Forms.RadioButton();
            this.radioButton_NRByes = new System.Windows.Forms.RadioButton();
            this.checkBox_ptSmokes = new System.Windows.Forms.CheckBox();
            this.groupBox_abg = new System.Windows.Forms.GroupBox();
            this.radioButton_abgNo = new System.Windows.Forms.RadioButton();
            this.radioButton_abgYes = new System.Windows.Forms.RadioButton();
            this.groupBox_WhyNoAbg = new System.Windows.Forms.GroupBox();
            this.comboBox_why_noabg = new System.Windows.Forms.ComboBox();
            this.groupBox_COHB = new System.Windows.Forms.GroupBox();
            this.radioButton_COHbNo = new System.Windows.Forms.RadioButton();
            this.radioButton_COHbYes = new System.Windows.Forms.RadioButton();
            this.checkBox_abgMedDirCalled = new System.Windows.Forms.CheckBox();
            this.textBox_abgInstructions = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox_NRB.SuspendLayout();
            this.groupBox_abg.SuspendLayout();
            this.groupBox_WhyNoAbg.SuspendLayout();
            this.groupBox_COHB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.groupBox_NRB);
            this.groupBox3.Controls.Add(this.groupBox_abg);
            this.groupBox3.Controls.Add(this.groupBox_WhyNoAbg);
            this.groupBox3.Controls.Add(this.groupBox_COHB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 229);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ABG\'s";
            // 
            // groupBox_NRB
            // 
            this.groupBox_NRB.AutoSize = true;
            this.groupBox_NRB.Controls.Add(this.comboBox_no15Lpm);
            this.groupBox_NRB.Controls.Add(this.radioButton_NRBno);
            this.groupBox_NRB.Controls.Add(this.radioButton_NRByes);
            this.groupBox_NRB.Controls.Add(this.checkBox_ptSmokes);
            this.groupBox_NRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NRB.Location = new System.Drawing.Point(233, 26);
            this.groupBox_NRB.Name = "groupBox_NRB";
            this.groupBox_NRB.Size = new System.Drawing.Size(308, 117);
            this.groupBox_NRB.TabIndex = 13;
            this.groupBox_NRB.TabStop = false;
            this.groupBox_NRB.Text = "Patient placed on 15 lpm O2 via NRB mask?";
            this.groupBox_NRB.Visible = false;
            // 
            // comboBox_no15Lpm
            // 
            this.comboBox_no15Lpm.AllowDrop = true;
            this.comboBox_no15Lpm.Items.AddRange(new object[] {
            "No ABG results prior to lights out",
            "PCO2 > 45"});
            this.comboBox_no15Lpm.Location = new System.Drawing.Point(7, 70);
            this.comboBox_no15Lpm.Name = "comboBox_no15Lpm";
            this.comboBox_no15Lpm.Size = new System.Drawing.Size(280, 25);
            this.comboBox_no15Lpm.TabIndex = 3;
            this.comboBox_no15Lpm.Text = "Why Not?";
            this.comboBox_no15Lpm.Visible = false;
            // 
            // radioButton_NRBno
            // 
            this.radioButton_NRBno.Location = new System.Drawing.Point(84, 38);
            this.radioButton_NRBno.Name = "radioButton_NRBno";
            this.radioButton_NRBno.Size = new System.Drawing.Size(70, 26);
            this.radioButton_NRBno.TabIndex = 2;
            this.radioButton_NRBno.Text = "NO";
            // 
            // radioButton_NRByes
            // 
            this.radioButton_NRByes.Location = new System.Drawing.Point(7, 38);
            this.radioButton_NRByes.Name = "radioButton_NRByes";
            this.radioButton_NRByes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_NRByes.TabIndex = 1;
            this.radioButton_NRByes.Text = "YES";
            // 
            // checkBox_ptSmokes
            // 
            this.checkBox_ptSmokes.AutoSize = true;
            this.checkBox_ptSmokes.Location = new System.Drawing.Point(166, 42);
            this.checkBox_ptSmokes.Name = "checkBox_ptSmokes";
            this.checkBox_ptSmokes.Size = new System.Drawing.Size(102, 21);
            this.checkBox_ptSmokes.TabIndex = 14;
            this.checkBox_ptSmokes.Text = "Pt Smokes?";
            // 
            // groupBox_abg
            // 
            this.groupBox_abg.AutoSize = true;
            this.groupBox_abg.Controls.Add(this.radioButton_abgNo);
            this.groupBox_abg.Controls.Add(this.radioButton_abgYes);
            this.groupBox_abg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_abg.Location = new System.Drawing.Point(7, 26);
            this.groupBox_abg.Name = "groupBox_abg";
            this.groupBox_abg.Size = new System.Drawing.Size(91, 92);
            this.groupBox_abg.TabIndex = 11;
            this.groupBox_abg.TabStop = false;
            this.groupBox_abg.Text = "Obtained?";
            // 
            // radioButton_abgNo
            // 
            this.radioButton_abgNo.Location = new System.Drawing.Point(7, 45);
            this.radioButton_abgNo.Name = "radioButton_abgNo";
            this.radioButton_abgNo.Size = new System.Drawing.Size(70, 25);
            this.radioButton_abgNo.TabIndex = 1;
            this.radioButton_abgNo.Text = "NO";
            this.radioButton_abgNo.CheckedChanged += new System.EventHandler(this.radioButton_abgNo_CheckedChanged);
            // 
            // radioButton_abgYes
            // 
            this.radioButton_abgYes.Location = new System.Drawing.Point(7, 19);
            this.radioButton_abgYes.Name = "radioButton_abgYes";
            this.radioButton_abgYes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_abgYes.TabIndex = 0;
            this.radioButton_abgYes.Text = "YES";
            this.radioButton_abgYes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton_abgYes.CheckedChanged += new System.EventHandler(this.radioButton_abgYes_CheckedChanged);
            // 
            // groupBox_WhyNoAbg
            // 
            this.groupBox_WhyNoAbg.AutoSize = true;
            this.groupBox_WhyNoAbg.Controls.Add(this.comboBox_why_noabg);
            this.groupBox_WhyNoAbg.Location = new System.Drawing.Point(7, 134);
            this.groupBox_WhyNoAbg.Name = "groupBox_WhyNoAbg";
            this.groupBox_WhyNoAbg.Size = new System.Drawing.Size(189, 73);
            this.groupBox_WhyNoAbg.TabIndex = 15;
            this.groupBox_WhyNoAbg.TabStop = false;
            this.groupBox_WhyNoAbg.Text = "Why Not?";
            this.groupBox_WhyNoAbg.Visible = false;
            // 
            // comboBox_why_noabg
            // 
            this.comboBox_why_noabg.Items.AddRange(new object[] {
            "The patient refused.",
            "The patient is a minor.",
            "Per doctor\'s orders.",
            "Patient has recent results.",
            "Unable to obtain."});
            this.comboBox_why_noabg.Location = new System.Drawing.Point(7, 26);
            this.comboBox_why_noabg.Name = "comboBox_why_noabg";
            this.comboBox_why_noabg.Size = new System.Drawing.Size(173, 25);
            this.comboBox_why_noabg.TabIndex = 5;
            // 
            // groupBox_COHB
            // 
            this.groupBox_COHB.AutoSize = true;
            this.groupBox_COHB.Controls.Add(this.radioButton_COHbNo);
            this.groupBox_COHB.Controls.Add(this.radioButton_COHbYes);
            this.groupBox_COHB.Controls.Add(this.checkBox_abgMedDirCalled);
            this.groupBox_COHB.Controls.Add(this.textBox_abgInstructions);
            this.groupBox_COHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_COHB.Location = new System.Drawing.Point(107, 30);
            this.groupBox_COHB.Name = "groupBox_COHB";
            this.groupBox_COHB.Size = new System.Drawing.Size(440, 171);
            this.groupBox_COHB.TabIndex = 12;
            this.groupBox_COHB.TabStop = false;
            this.groupBox_COHB.Text = "COHb > 3?";
            this.groupBox_COHB.Visible = false;
            // 
            // radioButton_COHbNo
            // 
            this.radioButton_COHbNo.Location = new System.Drawing.Point(14, 45);
            this.radioButton_COHbNo.Name = "radioButton_COHbNo";
            this.radioButton_COHbNo.Size = new System.Drawing.Size(70, 25);
            this.radioButton_COHbNo.TabIndex = 3;
            this.radioButton_COHbNo.Text = "NO";
            // 
            // radioButton_COHbYes
            // 
            this.radioButton_COHbYes.Location = new System.Drawing.Point(14, 16);
            this.radioButton_COHbYes.Name = "radioButton_COHbYes";
            this.radioButton_COHbYes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_COHbYes.TabIndex = 2;
            this.radioButton_COHbYes.Text = "YES";
            // 
            // checkBox_abgMedDirCalled
            // 
            this.checkBox_abgMedDirCalled.Location = new System.Drawing.Point(14, 70);
            this.checkBox_abgMedDirCalled.Name = "checkBox_abgMedDirCalled";
            this.checkBox_abgMedDirCalled.Size = new System.Drawing.Size(287, 39);
            this.checkBox_abgMedDirCalled.TabIndex = 7;
            this.checkBox_abgMedDirCalled.Text = "Medical Director contacted regarding?";
            // 
            // textBox_abgInstructions
            // 
            this.textBox_abgInstructions.AllowDrop = true;
            this.textBox_abgInstructions.Location = new System.Drawing.Point(77, 123);
            this.textBox_abgInstructions.Multiline = true;
            this.textBox_abgInstructions.Name = "textBox_abgInstructions";
            this.textBox_abgInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_abgInstructions.Size = new System.Drawing.Size(357, 26);
            this.textBox_abgInstructions.TabIndex = 8;
            this.textBox_abgInstructions.Text = "Instructions";
            // 
            // ABG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Name = "ABG";
            this.Size = new System.Drawing.Size(557, 232);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_NRB.ResumeLayout(false);
            this.groupBox_NRB.PerformLayout();
            this.groupBox_abg.ResumeLayout(false);
            this.groupBox_WhyNoAbg.ResumeLayout(false);
            this.groupBox_COHB.ResumeLayout(false);
            this.groupBox_COHB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_NRB;
        private System.Windows.Forms.ComboBox comboBox_no15Lpm;
        private System.Windows.Forms.RadioButton radioButton_NRBno;
        private System.Windows.Forms.RadioButton radioButton_NRByes;
        private System.Windows.Forms.CheckBox checkBox_ptSmokes;
        private System.Windows.Forms.GroupBox groupBox_abg;
        private System.Windows.Forms.RadioButton radioButton_abgNo;
        private System.Windows.Forms.RadioButton radioButton_abgYes;
        private System.Windows.Forms.GroupBox groupBox_WhyNoAbg;
        private System.Windows.Forms.ComboBox comboBox_why_noabg;
        private System.Windows.Forms.GroupBox groupBox_COHB;
        private System.Windows.Forms.RadioButton radioButton_COHbNo;
        private System.Windows.Forms.RadioButton radioButton_COHbYes;
        private System.Windows.Forms.CheckBox checkBox_abgMedDirCalled;
        private System.Windows.Forms.TextBox textBox_abgInstructions;
    }
}
