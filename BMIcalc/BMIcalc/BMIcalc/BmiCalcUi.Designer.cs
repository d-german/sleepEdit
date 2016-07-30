namespace BMIcalc
{
    partial class BmiCalcUi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BmiCalcUi));
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonIn = new System.Windows.Forms.RadioButton();
            this.radioButtonCm = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonKg = new System.Windows.Forms.RadioButton();
            this.radioButtonLbs = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.richTextBoxInterp = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(19, 49);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(121, 38);
            this.textBoxHeight.TabIndex = 0;
            this.textBoxHeight.Text = "0";
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(251, 49);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(121, 38);
            this.textBoxWeight.TabIndex = 1;
            this.textBoxWeight.Text = "0";
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight";
            // 
            // radioButtonIn
            // 
            this.radioButtonIn.AutoSize = true;
            this.radioButtonIn.Checked = true;
            this.radioButtonIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonIn.Location = new System.Drawing.Point(3, 3);
            this.radioButtonIn.Name = "radioButtonIn";
            this.radioButtonIn.Size = new System.Drawing.Size(36, 20);
            this.radioButtonIn.TabIndex = 6;
            this.radioButtonIn.TabStop = true;
            this.radioButtonIn.Text = "in";
            this.radioButtonIn.UseVisualStyleBackColor = true;
            this.radioButtonIn.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButtonCm
            // 
            this.radioButtonCm.AutoSize = true;
            this.radioButtonCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCm.Location = new System.Drawing.Point(3, 24);
            this.radioButtonCm.Name = "radioButtonCm";
            this.radioButtonCm.Size = new System.Drawing.Size(44, 20);
            this.radioButtonCm.TabIndex = 0;
            this.radioButtonCm.Text = "cm";
            this.radioButtonCm.UseVisualStyleBackColor = true;
            this.radioButtonCm.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.radioButtonCm);
            this.panel1.Controls.Add(this.radioButtonIn);
            this.panel1.Location = new System.Drawing.Point(143, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 47);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.radioButtonKg);
            this.panel2.Controls.Add(this.radioButtonLbs);
            this.panel2.Location = new System.Drawing.Point(375, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 47);
            this.panel2.TabIndex = 11;
            // 
            // radioButtonKg
            // 
            this.radioButtonKg.AutoSize = true;
            this.radioButtonKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKg.Location = new System.Drawing.Point(3, 24);
            this.radioButtonKg.Name = "radioButtonKg";
            this.radioButtonKg.Size = new System.Drawing.Size(41, 20);
            this.radioButtonKg.TabIndex = 8;
            this.radioButtonKg.Text = "kg";
            this.radioButtonKg.UseVisualStyleBackColor = true;
            this.radioButtonKg.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // radioButtonLbs
            // 
            this.radioButtonLbs.AutoSize = true;
            this.radioButtonLbs.Checked = true;
            this.radioButtonLbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLbs.Location = new System.Drawing.Point(3, 3);
            this.radioButtonLbs.Name = "radioButtonLbs";
            this.radioButtonLbs.Size = new System.Drawing.Size(44, 20);
            this.radioButtonLbs.TabIndex = 6;
            this.radioButtonLbs.TabStop = true;
            this.radioButtonLbs.Text = "lbs";
            this.radioButtonLbs.UseVisualStyleBackColor = true;
            this.radioButtonLbs.CheckedChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "BMI:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.AllowDrop = true;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResult.ForeColor = System.Drawing.Color.Black;
            this.textBoxResult.Location = new System.Drawing.Point(89, 120);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxResult.Size = new System.Drawing.Size(117, 37);
            this.textBoxResult.TabIndex = 12;
            this.textBoxResult.TabStop = false;
            this.textBoxResult.Text = "0";
            // 
            // richTextBoxInterp
            // 
            this.richTextBoxInterp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInterp.DetectUrls = false;
            this.richTextBoxInterp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInterp.Location = new System.Drawing.Point(251, 123);
            this.richTextBoxInterp.Name = "richTextBoxInterp";
            this.richTextBoxInterp.ReadOnly = true;
            this.richTextBoxInterp.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxInterp.Size = new System.Drawing.Size(205, 34);
            this.richTextBoxInterp.TabIndex = 15;
            this.richTextBoxInterp.TabStop = false;
            this.richTextBoxInterp.Text = "";
            // 
            // BmiCalcUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(475, 174);
            this.Controls.Add(this.richTextBoxInterp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BmiCalcUi";
            this.Text = "BMI Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonIn;
        private System.Windows.Forms.RadioButton radioButtonCm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonKg;
        private System.Windows.Forms.RadioButton radioButtonLbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxInterp;
    }
}

