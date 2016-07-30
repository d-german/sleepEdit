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
    public partial class DragDropTest : Form
    {
        private ProtocolNode mProtocolNode = new ProtocolNode();
        private ProtocolNode _previousNode;
        private ProtocolNode _selectedNode;
        private DragDropEffects _dragMode = DragDropEffects.Move;

        public DragDropTest()
        {
            InitializeComponent();
            ProtocolManager.load(mProtocolNode);
            this.mProtocolTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            mProtocolNode});
            foreach (ProtocolNode node in mProtocolTreeView.Nodes)
            {
                node.ExpandAll();
            }
        }



        private void mProtocolTreeView_DragLeave(object sender, EventArgs e)
        {
            if (this._selectedNode != null)
            {
                this.mProtocolTreeView.SelectedNode = this._selectedNode;
            }
        }

        private void mProtocolTreeView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = this._dragMode;

            // Reset the previous node var
            this._previousNode = null;
            this._selectedNode = null;

        }

        private void mProtocolTreeView_DragOver(object sender, DragEventArgs e)
        {
            // Change any previous node back
            if (this._previousNode != null)
            {
                this._previousNode.BackColor = SystemColors.HighlightText;
                this._previousNode.ForeColor = SystemColors.ControlText;
            }

            // Get the node from the mouse position, color it
            Point pt = ((TreeView)this.mProtocolTreeView).PointToClient(new Point(e.X, e.Y));
            ProtocolNode treeNode = (ProtocolNode)this.mProtocolTreeView.GetNodeAt(pt);


            // Remember the target node, so we can set it back
            this._previousNode = (ProtocolNode)treeNode;

        }

        private void mProtocolTreeView_DragDrop(object sender, DragEventArgs e)
        {
            // Check it's a treenode being dragged
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                TreeNode dragNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                // Get the target node from the mouse coords
                Point pt = ((TreeView)this.mProtocolTreeView).PointToClient(new Point(e.X, e.Y));
                TreeNode targetNode = this.mProtocolTreeView.GetNodeAt(pt);

                // De-color it
                targetNode.BackColor = SystemColors.HighlightText;
                targetNode.ForeColor = SystemColors.ControlText;

                // 1) Check we're not dragging onto ourself
                // 2) Check we're not dragging onto one of our children 
                // (this is the lazy way, will break if there are nodes with the same name,
                // but it's quicker than checking all nodes below is)
                // 3) Check we're not dragging onto our parent
                if (targetNode != dragNode && !targetNode.FullPath.StartsWith(dragNode.FullPath) && dragNode.Parent != targetNode)
                {
                    // Copy the node, add as a child to the destination node
                    ProtocolNode newTreeNode = (ProtocolNode)dragNode.Clone();
                    targetNode.Nodes.Add(newTreeNode);
                    targetNode.Expand();

                    // Remove Original Node, set the dragged node as selected
                    dragNode.Remove();
                    this.mProtocolTreeView.SelectedNode = newTreeNode;
                }
            }

        }

    }
}