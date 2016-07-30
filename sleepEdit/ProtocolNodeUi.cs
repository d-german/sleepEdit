using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Protocols;

namespace sleepEdit
{
   
    public partial class ProtocolNodeUi : UserControl
    {

        public void checkMe(bool isChecked)
        {
            if (mChecked == false)
            {
                mCheckBox.Checked = isChecked;
                mChecked = isChecked;
            }
        }

        private int mDepth = 0;
        private int mId = 0;
        private bool mChecked = false;
        private bool mIsSection;
        public bool IsSection
        {
            get { return mProtocolNode.IsSection; }
           
        }
        public bool Checked
        {
            get { return mChecked; }
            set { mChecked = value; }
        }
        public int Id
        {
            get { return mId; }            
        }
        public int Depth
        {
            get { return mDepth; }           
        }
       
        public override string Text
        {
            get { return getText(); }           
        }

        public System.Windows.Forms.CheckBox CheckBox
        {
            get { return mCheckBox; }
            set { mCheckBox = value; }
        }
        public System.Windows.Forms.LinkLabel LinkLabel
        {
            get { return mLinkLabel; }
            set { mLinkLabel = value; }
        }

        private string getText()
        {
            return mProtocolNode.Element.Text + " " + mComboBox.Text + " " + mProtocolNode.LinkText; 
        }
        private ProtocolNode mProtocolNode = null;
        public Protocols.ProtocolNode ProtocolNode
        {
            get { return mProtocolNode; }            
        }
        public ProtocolNodeUi(ProtocolNode node)
        {
            mProtocolNode = node;
            InitializeComponent();
            mId = mProtocolNode.Id;
            mDepth = mProtocolNode.Level;
            mDepthlabel.Width = mProtocolNode.Level * 30;
            if (mProtocolNode.Element.Text.Length > 0)
            {
                mCheckBox.Text = mProtocolNode.Element.Text;
            }
            else if (mProtocolNode.LinkText.Length > 0)
            {
                mCheckBox.Text = "    ";

            }
            
            if (mProtocolNode.LinkText.Length > 0)
            {
	            mLinkLabel.Text = mProtocolNode.LinkText;
                mLinkLabel.Tag = mProtocolNode.LinkId;
            } 
            else
            {
                mLinkLabel.Visible = false;
            }
            if (mProtocolNode.Element.SubTextList.Count > 0)
            {
	            foreach (string str in mProtocolNode.Element.SubTextList)
	            {
	                mComboBox.Items.Add(str);
	            }
            } 
            else
            {
                mComboBox.Visible = false;
            }

            mCheckBox.CheckedChanged += new EventHandler(mCheckBox_CheckedChanged);
            mProtocolNode.CheckMeEvent +=new CheckMeEventHandler(checkMe);
            
        }

        void mCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            mChecked = mCheckBox.Checked;
            if (mProtocolNode.Parent != null)
            {
	            ProtocolNode parentNode = (ProtocolNode) mProtocolNode.Parent;
	            parentNode.emitCheckMeEvent(mChecked);
            }
           
        }

    }
}
