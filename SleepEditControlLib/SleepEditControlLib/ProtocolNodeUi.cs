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
    public partial class ProtocolNodeUi : UserControl
    {

        private ProtocolNode mNode;
        private Protocol mProtocol = null;
        private CheckBox mCheckBox;
        private Label mDepthLabel;
        private ComboBox mComboBoxSubText;
        private LinkLabel mGotoLabel;	
        private FlowLayoutPanel mFlowLayoutPanel = new FlowLayoutPanel();
        



        public System.Windows.Forms.LinkLabel GotoLabel
        {
            get { return mGotoLabel; }
        }

        public Protocols.ProtocolNode Node
        {
            get { return mNode; }
        }

        public ProtocolNodeUi(Protocol protocol, ProtocolNode node)
        {
            InitializeComponent();
            
            mProtocol = protocol;
            mNode = node;
           
            mFlowLayoutPanel.Dock = DockStyle.Fill;          

            mDepthLabel = getDepthLabel(mNode);
            mFlowLayoutPanel.Controls.Add(mDepthLabel);

            mCheckBox = getCheckBox(mNode);
            mFlowLayoutPanel.Controls.Add(mCheckBox);
            



            if (mNode.Element.SubTextList.Count > 0)
            {
	            mComboBoxSubText = getSubTextBox(mNode);	
	            mFlowLayoutPanel.Controls.Add(mComboBoxSubText);
            }

            if (mProtocol.getSectionIndex(mNode.Element.GotoList.Count) > 0)
            {
	            mGotoLabel = getLinkLabel(mNode);
	            mFlowLayoutPanel.Controls.Add(mGotoLabel);
            }

            this.Controls.Add(this.mFlowLayoutPanel);           
        }


        private  ComboBox getSubTextBox(ProtocolNode node)
        {
            ComboBox cbb = new ComboBox();
            cbb.DataSource = node.Element.SubTextList;
            cbb.AutoSize = true;
            return cbb;
        }

        private Label getDepthLabel(ProtocolNode node)
        {
            Label lbl = new Label();
            int depth = node.Depth;
            if(depth > 0)
            {
                depth = depth - 1;
            }
            lbl.Width = depth * 20;
            return lbl;
        }

        private CheckBox getCheckBox(ProtocolNode node)
        {          
            CheckBox cb = new CheckBox();
            cb.AutoSize = true;
            cb.AutoEllipsis = true;
            cb.Text = node.Element.Text;          
            return cb;
        }

        private LinkLabel getLinkLabel(ProtocolNode node)
        {
            LinkLabel lbl = new LinkLabel();
            lbl.AutoSize = true;
            string str = mNode.Element.GotoSection;
            lbl.Tag = mProtocol.getSectionIndex(str);
            lbl.Text = str;
            return lbl;
        }



//         private static int PixelLength(string text, Font thisFont)
//         {
// 
//             Label lbl = new Label();           // Create a new label
// 
//             Graphics g = lbl.CreateGraphics();    // Create the graphics for this label
// 
//             if (thisFont == null)
//             {
// 
//                 thisFont = lbl.Font;
// 
//             }
// 
//             return (int)g.MeasureString(text, thisFont).Width;
// 
//         }


        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeDlg dlg = new NodeDlg();
            DialogResult result = initializeDlg(dlg);
            if (result == DialogResult.OK)
            {

                mProtocol.insertChild(mNode, dlg.TextBoxNodeText.Text,dlg.ComboBoxGotoSection.Text, null);           
            }
           mProtocol.emitSave();
        }

        private DialogResult initializeDlg(NodeDlg dlg)
        {
            dlg.Node = mNode;
            dlg.Text = "Add Node";
            dlg.ComboBoxGotoSection.DataSource = mProtocol.sectionList();
            DialogResult result = dlg.ShowDialog();
            return result;
        }

        private void editNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeDlg dlg = new NodeDlg();

            dlg.ComboBoxGotoSection.SelectedText = mNode.Element.GotoSection;
            dlg.TextBoxNodeText.Text = mNode.Element.Text;
            
            foreach (ProtocolNode node in mProtocol.Node.NodeList)
            {
                dlg.ComboBoxGotoSection.Items.Add(node.Element.Text);

            }
            dlg.ComboBoxGotoSection.SelectedIndex = dlg.ComboBoxGotoSection.FindString(mNode.Element.GotoSection);
 
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                mNode.Element.Text = dlg.TextBoxNodeText.Text;
                mNode.Element.GotoSection = dlg.ComboBoxGotoSection.Text;                
            }

            mProtocol.emitSave();
                     

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mProtocol.deleteNode(mNode);
            mProtocol.emitSave();
        }

        private void addAtSameLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodeDlg dlg = new NodeDlg();
            DialogResult result = initializeDlg(dlg);
            if (result == DialogResult.OK)
            {

                mProtocol.insertSibling(mNode, dlg.TextBoxNodeText.Text, dlg.ComboBoxGotoSection.Text, null);
            }
            mProtocol.emitSave();
        }
    }
}



 
