using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BMIcalc
{
    public partial class BmiCalcUi : Form
    {
        public BmiCalcUi()
        {
            InitializeComponent();
        }

        private double height = 0.0;
        private double weight = 0.0;
        private double result = 0.0;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                height = float.Parse(textBoxHeight.Text);
                weight = float.Parse(textBoxWeight.Text);

                ConvertMetricToStandard();

                CaculateBmi();

                DisplayResult();

                DisplayInterp();
                
            }
            catch
            {
                SetResultToZero();
                
            }
        }

private void SetResultToZero()
{
	textBoxResult.Text = "0";
}
        private void ConvertMetricToStandard()
        {
            if (radioButtonCm.Checked)
            {
                ConvertCmToIn();
            }
            if (radioButtonKg.Checked)
            {
                ConvertKgtoLbs();
            }
        }
        private void DisplayInterp()
        {
            //BMI  	Weight Status
            //Below 18.5 	Underweight
            //18.5 - 24.9 	Normal
            //25.0 - 29.9 	Overweight
            //30.0 and Above 	Obese

            while (true)
            {
                if ( isNull() )
                {
                    richTextBoxInterp.Text = "";
                    SetResultToZero();
                    break;
                }
                if (result == -1)
                {
                    richTextBoxInterp.Text = "Error!";
                    richTextBoxInterp.ForeColor = Color.PaleVioletRed;
                    textBoxResult.Text = "";
                    break;
                }
                if (result < 18.5)
                {
                    richTextBoxInterp.Text = "Under Weight";
                    richTextBoxInterp.ForeColor = Color.Plum;
                    break;
                }

                if (result < 24.9)
                {
                    richTextBoxInterp.Text = "Normal";
                    richTextBoxInterp.ForeColor = Color.Green;
                    break;
                }

                if (result < 29.9)
                {
                    richTextBoxInterp.Text = "Over Weight";
                    richTextBoxInterp.ForeColor = Color.Tomato;
                    break;
                }

                if (result > 29.9)
                {
                    richTextBoxInterp.Text = "Obese";
                    richTextBoxInterp.ForeColor = Color.Red;
                    break;
                }

                break;
            }
        }
        private bool isNull()
        {
            return weight == 0 || height == 0 || textBoxWeight.Text == "" || textBoxWeight.Text == "";
        }
        private void DisplayResult()
        {
            if (result > 100 || result < 1)
                result = -1;
            else
                textBoxResult.Text = result.ToString("###.##");
        }
        private void CaculateBmi()
        {
            result = (weight / (height * height)) * 703;
        }
        private void ConvertKgtoLbs()
        {
            weight = weight / 0.45359237;
        }
        private void ConvertCmToIn()
        {
            height = height / 2.54;
        }
    }
}