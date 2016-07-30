using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SleepEditControlLib
{
    public partial class CPAP : UserControl
    {
        public CPAP()
        {
            InitializeComponent();
        }

        public string getCpapValue()
        {
            return this.comboBoxCpap.Text;
        }
    }
}
