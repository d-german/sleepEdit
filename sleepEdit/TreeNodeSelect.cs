using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Protocols;

namespace sleepEdit
{
    public partial class TreeNodeSelect : Form
    {

        private ProtocolNode mSelectedNode = null;

        
        public TreeNodeSelect(ProtocolNode node, ProtocolNode selectedNode)
        {   
                   
            InitializeComponent();
            this.mTreeView.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/ProtocolNode[] { node });          
            mSelectedNode = selectedNode;
            findNode(node);
        }

        private void findNode(ProtocolNode node)
        {
            foreach (ProtocolNode curNode in node.Nodes)
            {
                if (curNode.Id == mSelectedNode.Id)
                {
                    curNode.ExpandAll();
                    mTreeView.SelectedNode = curNode;
                }
                findNode(curNode);
            }
        }
    }
}