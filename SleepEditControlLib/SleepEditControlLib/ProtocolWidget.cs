using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Protocols;

namespace SleepEditControlLib
{
    public partial class ProtocolWidget : UserControl
    {
        private ProtocolTreeNode mNode;
        private CheckBox mCheckBox = new CheckBox();
        private Label mDepthLabel = new Label();
        private ComboBox mComboBoxSubText = new ComboBox();

        public ProtocolWidget(ProtocolTreeNode node)
        {            
            InitializeComponent();

            mNode = node; 

            int depth = node.mElement.mDepth;
            if (depth > 0)
            {
                string str = "";
                for (int i = 0; i < depth; i++ )
                {
                    str += "    ";                     
                }
                mDepthLabel.Text = str;
                mFlowLayoutPanel.Controls.Add(mDepthLabel);
            }

            mCheckBox.Text = mNode.mElement.mText;

            mFlowLayoutPanel.Controls.Add(mCheckBox);
            
            if (node.mElement.mSubTextList.Count > 0)
            {
                mComboBoxSubText.DataSource = node.mElement.mSubTextList;
                mFlowLayoutPanel.Controls.Add(mComboBoxSubText);
            }

            this.Controls.Add(this.mFlowLayoutPanel);
           

            

            
        }
    }
}
