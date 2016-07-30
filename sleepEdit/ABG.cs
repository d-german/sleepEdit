using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for ABG.
    /// </summary>
    public class ABG : Form
    {
        private Button button_getInterp;


        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private TextBox document;
        private float HCO3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private float PCO2;
        private float PH;
        private float PO2;
        private TextBox textBox_hco3;
        private TextBox textBox_pao2;
        private TextBox textBox_pco2;
        private TextBox textBox_ph;

        public ABG()
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
            this.textBox_pao2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_pco2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ph = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_hco3 = new System.Windows.Forms.TextBox();
            this.document = new System.Windows.Forms.TextBox();
            this.button_getInterp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_pao2
            // 
            this.textBox_pao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.textBox_pao2.Location = new System.Drawing.Point(152, 72);
            this.textBox_pao2.Name = "textBox_pao2";
            this.textBox_pao2.TabIndex = 0;
            this.textBox_pao2.Text = "0.0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.TabIndex = 2;
            this.label1.Text = "PaO2";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.TabIndex = 4;
            this.label2.Text = "PCO2";
            // 
            // textBox_pco2
            // 
            this.textBox_pco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.textBox_pco2.Location = new System.Drawing.Point(152, 112);
            this.textBox_pco2.Name = "textBox_pco2";
            this.textBox_pco2.TabIndex = 3;
            this.textBox_pco2.Text = "0.0";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.label3.Location = new System.Drawing.Point(32, 152);
            this.label3.Name = "label3";
            this.label3.TabIndex = 6;
            this.label3.Text = "PH";
            // 
            // textBox_ph
            // 
            this.textBox_ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.textBox_ph.Location = new System.Drawing.Point(152, 152);
            this.textBox_ph.Name = "textBox_ph";
            this.textBox_ph.TabIndex = 5;
            this.textBox_ph.Text = "0.0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.label4.Location = new System.Drawing.Point(32, 192);
            this.label4.Name = "label4";
            this.label4.TabIndex = 8;
            this.label4.Text = "HCO3";
            // 
            // textBox_hco3
            // 
            this.textBox_hco3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.textBox_hco3.Location = new System.Drawing.Point(152, 192);
            this.textBox_hco3.Name = "textBox_hco3";
            this.textBox_hco3.TabIndex = 7;
            this.textBox_hco3.Text = "0.0";
            // 
            // document
            // 
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.document.Location = new System.Drawing.Point(32, 264);
            this.document.Multiline = true;
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(272, 112);
            this.document.TabIndex = 9;
            this.document.Text = "";
            // 
            // button_getInterp
            // 
            this.button_getInterp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte) (0)));
            this.button_getInterp.Location = new System.Drawing.Point(312, 72);
            this.button_getInterp.Name = "button_getInterp";
            this.button_getInterp.Size = new System.Drawing.Size(104, 40);
            this.button_getInterp.TabIndex = 10;
            this.button_getInterp.Text = "Decode";
            this.button_getInterp.Click += new System.EventHandler(this.button_getInterp_Click);
            // 
            // ABG
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(536, 416);
            this.Controls.Add(this.button_getInterp);
            this.Controls.Add(this.document);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hco3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ph);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_pco2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pao2);
            this.Name = "ABG";
            this.Text = "ABG Decoder";
            this.ResumeLayout(false);
        }

        #endregion

        private void getValues()
        {
            try
            {
                PO2 = float.Parse(textBox_pao2.Text);
                PCO2 = float.Parse(textBox_pco2.Text);
                HCO3 = float.Parse(textBox_hco3.Text);
                PH = float.Parse(textBox_ph.Text);
                getInterp();
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Value Type!");
            }
        }

        private void getInterp()
        {
            var output = "";
            var hypoxemia = PO2 < 80;
            var abnormalCO2 = PCO2 <= 35 && PCO2 >= 45;
            var abnormalHCO3 = HCO3 <= 22 && HCO3 >= 26;
            var ph_alkalosis = PH > 7.40;
            var ph_acidosis = PH < 7.40;
            var co2_alkalosis = PCO2 < 35;
            var co2_acidosis = PCO2 > 45;
            var hco3_alkalosis = HCO3 > 26;
            var hco3_acidosis = HCO3 < 22;
            var partComp = PH > 7.45 && PH < 7.35;
            var normalPh = PH >= 7.35 && PH <= 7.45;

            if (hypoxemia)
                output += "Hypoxemia is present. ";
            if (ph_alkalosis)
            {
                if (hco3_alkalosis) //ak ak ac
                {
                    if (normalPh)
                        output += "Fully compensated metabolic alkalosis.";
                    else if (partComp)
                        output += "Partialy compensated metabolic alkalosis.";
                    else
                        output += "Metabolic alkalosis.";
                }
                if (co2_alkalosis) //ak ac ak
                {
                    if (normalPh)
                        output += "Fully compensated respiratory alkalosis.";
                    else if (partComp)
                        output += "Partialy compensated respiratory alkalosis.";
                    else
                        output += "Respiratory alkalosis.";
                }
            }
            if (ph_acidosis)
            {
                if (hco3_acidosis) //ac ac ak
                {
                    if (normalPh)
                        output += "Fully compensated metabolic acidosis.";
                    else if (partComp)
                        output += "Partialy compensated metabolic acidosis.";
                    else
                        output += "Metabolic acidosis.";
                }
                if (co2_acidosis) //ak ac ak
                {
                    if (normalPh)
                        output += "Fully compensated respiratory acidosis.";
                    else if (partComp)
                        output += "Partialy compensated respiratory acidosis.";
                    else
                        output += "Respiratory acidosis.";
                }
            }


            document.Text = output;
        }

        private void button_getInterp_Click(object sender, EventArgs e)
        {
            getValues();
        }
    }
}