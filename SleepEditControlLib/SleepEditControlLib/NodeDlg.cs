using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Protocols;

namespace SleepEditControlLib
{
    public partial class NodeDlg : Form
    {
        private System.Windows.Forms.TextBox mTextBoxNodeText = new TextBox();

        public System.Windows.Forms.TextBox TextBoxNodeText
        {
            get { return mTextBoxNodeText; }
            set { mTextBoxNodeText = value; }
        }
        public System.Windows.Forms.ListBox GotolistBox
        {
            get { return mGotolistBox; }
            set { mGotolistBox = value; }
        }

        private System.Windows.Forms.Label label1;


        private System.Windows.Forms.Button mOkbutton;
        private System.Windows.Forms.Button mCancelButton;


        private System.Windows.Forms.Label label3;

        private ProtocolNode_old mNode = new ProtocolNode_old(new Element());
        public Protocols.ProtocolNode_old Node
        {
            get { return mNode; }
            set { mNode = value; }
        }
	
        public NodeDlg()
        {
            InitializeComponent();
            
        }

        

        
    }
}