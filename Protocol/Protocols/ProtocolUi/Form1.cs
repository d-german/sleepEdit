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
    public partial class ProtocolUi : Form
    {

        private Protocol mProtocol = new Protocol();

        private ProtocolNode mProtocolNode;
        public ProtocolUi()
        {
            InitializeComponent();
            mTabControl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            populateForm();            
        }

        private void populateForm()
        {
            mProtocolNode = mProtocol.Node;
            foreach (ProtocolNode node in mProtocolNode.NodeList)
            {
                TabPage tabPage = getTabPage(node);

                mTabControl.Controls.Add(tabPage);

                if (node.NodeList.Count > 0)
                {
                    processAllNodes(node, ref tabPage);
                }
            }
        }


        private static TabPage getTabPage(ProtocolNode node)
        {
            TabPage tabPage = new TabPage();            
            tabPage.Text = node.Element.Text;
            tabPage.Tag = node;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.UseVisualStyleBackColor = true;
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Dock = DockStyle.Fill;
            panel.Name = "FlowLayout";
            panel.FlowDirection = FlowDirection.TopDown;
            tabPage.Controls.Add(panel);
            return tabPage;
        }

        void processAllNodes(ProtocolNode node, ref TabPage page)
        {
            if (node != null)
            {
                if (!node.IsSection)
                {                    
                    FlowLayoutPanel panel = (FlowLayoutPanel)page.Controls.Find("FlowLayout", false)[0];
                    panel.Controls.Add(getNodeUi(node));
                }

                foreach (ProtocolNode cur in node.NodeList)
                {
                    processAllNodes(cur, ref page);
                }
            }

        }

        private SleepEditControlLib.ProtocolNodeUi getNodeUi(ProtocolNode node)
        {
            SleepEditControlLib.ProtocolNodeUi widget = new SleepEditControlLib.ProtocolNodeUi(mProtocol,node);
            if (widget.GotoLabel != null)
            {
                widget.GotoLabel.Click += new EventHandler(GotoLabel_Click);
            }
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
            mTabControl.Controls.Clear();
            mProtocol.save();
            mProtocol = null;
            mProtocol = new Protocol();
            mTabControl.SuspendLayout();
            populateForm();
            mTabControl.ResumeLayout();
            mTabControl.Refresh();
            this.Refresh();

            
        }


    }
}