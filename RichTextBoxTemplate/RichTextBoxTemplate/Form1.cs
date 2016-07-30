using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SuspendLayout();
             this.richTextBox1.LoadFile("Sleep Lab.rtf");
             string str = "[@100]";
            
            richTextBox1.Rtf = richTextBox1.Rtf.Replace(str, "Damon German");


            



             this.ResumeLayout();
            


        }
    }
}