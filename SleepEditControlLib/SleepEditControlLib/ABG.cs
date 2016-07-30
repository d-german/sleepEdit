using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SleepEditControlLib
{
    public partial class ABG : UserControl
    {
        public ABG()
        {
            InitializeComponent();
        }

        private void radioButton_abgYes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_abgNo.Checked)
                this.groupBox_WhyNoAbg.Visible = true;
            else if (!this.radioButton_abgNo.Checked)
                this.groupBox_WhyNoAbg.Visible = false;
        }

        private void radioButton_abgNo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton_COHbYes.Checked)
                this.groupBox_NRB.Visible = true;
            else if (!this.radioButton_COHbYes.Checked)
                this.groupBox_NRB.Visible = false;
        }
    }
}
