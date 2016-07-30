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
    public partial class ProtocolStatementUi : UserControl
    {
        private ProtocolNode_old mNode;
        private Protocol_old mProtocol = null;
        private bool mIsChecked = false;
        private NodeDlg mNodeDlg = new NodeDlg();
/*        private int mCurTextindex;*/

        public bool IsChecked
        {
            get { return mIsChecked; }
            set { mIsChecked = value; }
        }

        public ProtocolStatementUi(Protocol_old protocol, ProtocolNode_old node)
        {
            InitializeComponent();
            mNodeDlg.GotolistBox.MouseDown += new MouseEventHandler(GotolistBox_MouseDown);
            mNodeDlg.TextBoxNodeText.DragEnter += new DragEventHandler(mNodeDlg_DragEnter);
            mNodeDlg.TextBoxNodeText.DragDrop += new DragEventHandler(TextBoxNodeText_DragDrop);
            mNodeDlg.GotolistBox.MouseDoubleClick += new MouseEventHandler(GotolistBox_MouseDoubleClick);

            mProtocol = protocol;
            mNode = node;
            foreach (string str in mProtocol.sectionList())
            {
                mNodeDlg.GOTOLinkToolStripMenuItem.DropDownItems.Add(str);
            }

            
            initDepthLabel(mNode);
            // mTextLabel.Text = ""/*mNode.Element.Text*/;

            if (mNode.Element.SubTextList.Count > 0)
            {
                mComboBoxSubText.DataSource = mNode.Element.SubTextList;
            }
            else
            {
                mComboBoxSubText.Visible = false;
            }
            ProtocolItemList pl = new ProtocolItemList(mNode.Element.Text);

            foreach (ProtocolItem item in pl.mItemList)
            {
                switch (item.mType)
                {
                    case ProtocolItemType.Text:
                        {
                            Label lbl = new Label();
                            lbl.Click += new EventHandler(lbl_Click);
                            lbl.Text = item.mText;
                            lbl.AutoSize = true;
                            lbl.Margin = new System.Windows.Forms.Padding(0);

                            mFlowLayoutPanel.Controls.Add(lbl);
                            break;

                        }
                    case ProtocolItemType.Link:
                        {
                            LinkLabel lbl = new LinkLabel();
                            lbl.Text = item.mText;
                            lbl.AutoSize = true;
                            lbl.Margin = new System.Windows.Forms.Padding(0);
                            mFlowLayoutPanel.Controls.Add(lbl);
                            break;

                        }
                    case ProtocolItemType.Question:
                        {
                            mComboBoxSubText.DataSource = mNode.Element.SubTextList;
                            mFlowLayoutPanel.Controls.Add(mComboBoxSubText);
                            break;
                        }
                    default:
                        break;
                }

            }
        }

        void lbl_Click(object sender, EventArgs e)
        {
            mCheckBox.Checked = !mCheckBox.Checked;
            mNode.Checked = !mNode.Checked;
        }

        void GotolistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string data = mNodeDlg.GotolistBox.SelectedItem.ToString();
            data = "[LINK " + data + "]";
            mNodeDlg.TextBoxNodeText.Text = mNodeDlg.TextBoxNodeText.Text.Insert(mNodeDlg.TextBoxNodeText.SelectionStart, data);

        }



        void TextBoxNodeText_DragDrop(object sender, DragEventArgs e)
        {
            string dragData = (string)e.Data.GetData(typeof(string));
            dragData = "[LINK " + dragData + "]";
            mNodeDlg.TextBoxNodeText.Text = mNodeDlg.TextBoxNodeText.Text.Insert(mNodeDlg.TextBoxNodeText.SelectionStart,dragData);
        }

        void mNodeDlg_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        void GotolistBox_MouseDown(object sender, MouseEventArgs e)
        {
            mNodeDlg.DoDragDrop(mNodeDlg.GotolistBox.SelectedItem.ToString(), DragDropEffects.Copy);
        }



        public Protocols.ProtocolNode_old Node
        {
            get { return mNode; }
        }

        private void initDepthLabel(ProtocolNode_old node)
        {

            int depth = node.Depth;
            if (depth > 0)
            {
                depth = depth - 2;
            }
            this.mDepthLabel.Width = depth * 20;

        }


        private void addNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = initializeDlg(mNodeDlg);
            if (result == DialogResult.OK)
            {
                string text = mNodeDlg.TextBoxNodeText.Text;

                mProtocol.insertChild(mNode, text, null, null);
            }
            mProtocol.emitSave();
        }

        private DialogResult initializeDlg(NodeDlg dlg)
        {
            dlg.Node = mNode;
            dlg.Text = "Add Node";
/*            dlg.ComboBoxGotoSection.DataSource = mProtocol.sectionList();*/
            dlg.GotolistBox.DataSource = mProtocol.sectionList();
            DialogResult result = dlg.ShowDialog();
            return result;
        }

        private void editNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {


/*            mNodeDlg.ComboBoxGotoSection.SelectedText = mNode.Element.GotoSection;*/
            mNodeDlg.TextBoxNodeText.Text = mNode.Element.Text;
/*            mNodeDlg.ComboBoxGotoSection.SelectedIndex = mNodeDlg.ComboBoxGotoSection.FindString(mNode.Element.GotoSection);*/

            string[] myList = new string[mProtocol.sectionList().Count];
            for (int i = 0; i < mProtocol.sectionList().Count; i++)
            {
                myList[i] = mProtocol.sectionList()[i];
            }
            mNodeDlg.GotolistBox.Items.AddRange(myList);


            DialogResult result = mNodeDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                string text = mNodeDlg.TextBoxNodeText.Text;
               
                mNode.Element.Text = text;
/*                mNode.Element.GotoSection = mNodeDlg.ComboBoxGotoSection.Text;*/
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

            DialogResult result = initializeDlg(mNodeDlg);
            if (result == DialogResult.OK)
            {

                mProtocol.insertSibling(mNode, mNodeDlg.TextBoxNodeText.Text, null, null);
            }
            mProtocol.emitSave();
        }

        private void mTextLabel_Click(object sender, EventArgs e)
        {
            mCheckBox.Checked = !mCheckBox.Checked;
            mIsChecked = mCheckBox.Checked;

        }
    }
}
