using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Protocols;

namespace ProtocolUi
{
    public partial class SleepProtocolUi : Form
    {

        private Protocol_old mProtocol = new Protocol_old();
        private ProtocolNode_old mProtocolNode;
        private static int INDEX = 0;

        public SleepProtocolUi()
        {
            InitializeComponent();


            resetDeleteSectionToolStripItems();

           mTabControl.Font = new Font(
               "Microsoft Sans Serif",
               12F, FontStyle.Regular,
               GraphicsUnit.Point,
               ((byte)(0))
               );

            mProtocol.Save +=new Protocol_old.saveProtocol(saveAndReset);

            populateForm();
           
        }

        private void populateForm()
        {
            mProtocolNode = mProtocol.Node;

            foreach (ProtocolNode_old node in mProtocolNode.NodeList)
            {

                TabPage tabPage = getTabPage(node);

                mTabControl.Controls.Add(tabPage);

                if (node.NodeList.Count > 0)
                {
                    processAllNodes(node, ref tabPage);
                }
            }
            if (INDEX == -1)
            {
                INDEX = 0;
            }
            mTabControl.SelectedIndex = INDEX;
        }


        void processAllNodes(ProtocolNode_old node, ref TabPage page)
        {
            if (node != null)
            {
                if (!node.IsSection)
                {
                    FlowLayoutPanel panel = (FlowLayoutPanel)page.Controls.Find("FlowLayout", false)[0];
                    panel.Controls.Add(getNodeUi(node));
                }

                foreach (ProtocolNode_old cur in node.NodeList)
                {
                    processAllNodes(cur, ref page);
                }
            }

        }

        private static TabPage getTabPage(ProtocolNode_old node)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = node.Element.Text;
            tabPage.Tag = node;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.UseVisualStyleBackColor = true;
            tabPage.AutoScroll = true;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.Name = "FlowLayout";
            panel.FlowDirection = FlowDirection.TopDown;
            Label lbl = new Label();
            lbl.Text = node.Element.Text;
            lbl.AutoSize = true;
            panel.Controls.Add(lbl);
            Label lbl2 = new Label();
            lbl2.Text = "-------------------------";
            panel.Controls.Add(lbl2);
            tabPage.Controls.Add(panel);
            return tabPage;
        }

        private void resetDeleteSectionToolStripItems()
        {
            this.mToolStripItemDeleteSection.DropDownItems.Clear();
            foreach (string str in mProtocol.sectionList())
            {
                this.mToolStripItemDeleteSection.DropDownItems.Add(str);
            }
            foreach (ToolStripDropDownItem item in this.mToolStripItemDeleteSection.DropDownItems)
            {
                item.Click += new EventHandler(deleteSectionItem_Click);
            }
            mProtocol.Save +=new Protocol_old.saveProtocol(saveAndReset);
        }

        void deleteSectionItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
            string sectionText = item.Text;
            mProtocol.removeSection(sectionText);
            saveAndReset();
        }       


        private SleepEditControlLib.ProtocolStatementUi getNodeUi(ProtocolNode_old node)
        {
            SleepEditControlLib.ProtocolStatementUi widget = new SleepEditControlLib.ProtocolStatementUi(mProtocol, node);
//             if (widget.GotoLabel != null)
//             {
//                 widget.GotoLabel.Click += new EventHandler(GotoLabel_Click);
//             }
//             
            return widget;
        }

        void GotoLabel_Click(object sender, EventArgs e)
        {
            LinkLabel lbl = (LinkLabel)sender;
            int index = (int)lbl.Tag;
            mTabControl.SelectedIndex = index;

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {

            saveAndReset();
        }

        private void saveAndReset()
        {
            INDEX = mTabControl.SelectedIndex;
            TabPage tabPage = new TabPage();
            tabPage = (TabPage)mTabControl.Controls[0];
            mTabControl.Controls.Clear();

            mProtocol.save();
            mProtocol = null;
            mProtocol = new Protocol_old();
            mTabControl.SuspendLayout();

            mTabControl.Controls.Add(tabPage);
            resetDeleteSectionToolStripItems();
            populateForm();
            mTabControl.ResumeLayout();
            mTabControl.Refresh();
            this.Refresh();
        }

       

        private void addSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textInput tx = new textInput();
            tx.Text = "Enter new Section Name";

            if (tx.ShowDialog() == DialogResult.OK)
            {
                mProtocol.addSection(tx.document.Text);
                saveAndReset();
                INDEX = mTabControl.TabCount; // not working fix later                
            }
            
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAndReset();
        }



       
    }





}