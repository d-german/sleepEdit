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
    public partial class ProtocolEditUi : Form
    {
        const int ROOT_IMG = 1;
        const int SECT_IMG = 21;
        private ProtocolNode mProtocolNode = new ProtocolNode();
        ProtocolNode mCurNode = null;
        ProtocolNode mSourceNode = null;
        private DragDropEffects _dragMode = DragDropEffects.Move;

        UndoManager mManager = new UndoManager();

        public ProtocolEditUi()
        {
            InitializeComponent();
            ProtocolManager.load(mProtocolNode);
            this.mProtocolTreeView.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/ProtocolNode[] { mProtocolNode });
            mProtocolTreeView.Nodes[0].ImageIndex = ROOT_IMG;
            mProtocolTreeView.Nodes[0].SelectedImageIndex = ROOT_IMG;
            mProtocolTreeView.Nodes[0].Expand();  
         
            foreach (ProtocolNode node in getSectionNodes())
            {
                node.SelectedImageIndex = SECT_IMG;
                node.ImageIndex = SECT_IMG;
            }

        }

        private TreeNodeCollection getSectionNodes()
        {
            return mProtocolTreeView.Nodes[0].Nodes;
        }

        private void _addNode(ProtocolNode parent, ProtocolNode childNode)
        {
            AddCmd cmd = new AddCmd(parent, childNode);
            cmd.Execute();
        }

        private void _RemoveNode(ProtocolNode parent, ProtocolNode childNode)
        {
            RemoveCmd cmd = new RemoveCmd(parent, childNode);
            cmd.Execute();
        }
        private void _move(ProtocolNode node, ProtocolNode newNode)
        {
            MoveCmd cmd = new MoveCmd(mSourceNode, node, newNode);
            cmd.Execute();
        }
        private ProtocolNode getSelNode()
        {
            ProtocolNode node;
            node = (ProtocolNode)mProtocolTreeView.SelectedNode;
            return node;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProtocolManager.save(mProtocolNode);
        }

        private void mProtocolTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mCurNode = getSelNode();
            mDocument.Text = mCurNode.Element.Text;
        }

        private void mDocument_TextChanged(object sender, EventArgs e)
        {
            mCurNode.Element.Text = mDocument.Text;
            mCurNode.Text = mDocument.Text;
        }



        private void Tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Get the node underneath the mouse.
            ProtocolNode selectedNode = (ProtocolNode)mProtocolTreeView.SelectedNode;
            tree.SelectedNode = selectedNode;

            // Start the drag-and-drop operation with a cloned copy of the node.
            if (selectedNode != null)
            {
                tree.DoDragDrop((ProtocolNode)selectedNode.Clone(), DragDropEffects.Move);

            }

        }


        private void tree_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Drag and drop denied by default.
            e.Effect = DragDropEffects.None;

            // Is it a valid format?
            ProtocolNode dragedNode = (ProtocolNode)e.Data.GetData(typeof(ProtocolNode));
            if (dragedNode != null)
            {
                // Get the screen point.
                Point pt = new Point(e.X, e.Y);

                // Convert to a point in the TreeView's coordinate system.
                pt = tree.PointToClient(pt);

                // Is the mouse over a valid node?
                ProtocolNode target = (ProtocolNode)tree.GetNodeAt(pt);
                if (isValidDragDrop(target))
                {
                    e.Effect = DragDropEffects.Move;
                    tree.SelectedNode = target;
                }
            }
        }

        private void Tree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = this._dragMode;
        }

        private void tree_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Get the screen point.
            Point pt = new Point(e.X, e.Y);

            // Convert to a point in the TreeView's coordinate system.
            pt = tree.PointToClient(pt);

            // Get the node underneath the mouse.
            ProtocolNode newParentNode = (ProtocolNode)tree.GetNodeAt(pt);
            ProtocolNode newChildNode = (ProtocolNode)e.Data.GetData(typeof(ProtocolNode));

            _move(newParentNode, newChildNode);

        }

        private bool isValidDragDrop(ProtocolNode target)
        {
            if (
                mSourceNode.IsSection && target != mProtocolTreeView.TopNode ||
                mSourceNode.Equals(target) ||
                target.Equals(mSourceNode.Parent) ||
                mSourceNode.Nodes.Contains(target) ||
                contains(mSourceNode, target))
            {
                mIsFound = false;
                return false;
            }
            return true;
        }
        private bool mIsFound = false;
        private bool contains(ProtocolNode parent, ProtocolNode child)
        {

            foreach (ProtocolNode node in parent.Nodes)
            {
                if (node.Nodes.Contains(child))
                {
                    mIsFound = true;
                }
                contains(node, child);
            }
            return mIsFound;
        }

        private void mProtocolTreeView_MouseDown(object sender, MouseEventArgs e)
        {

            ProtocolNode selectedNode = (ProtocolNode)mProtocolTreeView.GetNodeAt(e.X, e.Y);
            mProtocolTreeView.SelectedNode = (TreeNode)selectedNode;

            mSourceNode = (ProtocolNode)selectedNode;
        }

        private void mProtocolTreeView_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void undoMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UndoCmd().Execute();
        }

        private void redoMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RedoCmd().Execute();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new UndoCmd().Execute();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new RedoCmd().Execute();
        }

        private void addChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addChild();
        }

        private void addChild()
        {
            ProtocolNode node = getSelNode();
            if (node.IsProtocol)
            {
                return;
            }
            ProtocolNode childNode = new ProtocolNode("New Node");
            _addNode(node, childNode);
            node.Expand();
        }

        private void removeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProtocolNode parent = (ProtocolNode)mProtocolTreeView.SelectedNode.Parent;
            ProtocolNode child = (ProtocolNode)mProtocolTreeView.SelectedNode;
            _RemoveNode(parent, child);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _nudgeNodeUp();
        }

        private void _nudgeNodeUp()
        {
            ProtocolNode cur = getSelNode();
            NudgeUpCmd cmd = new NudgeUpCmd(cur);
            cmd.Execute();
            mProtocolTreeView.SelectedNode = cur;
        }

        private void _nudgeNodeDown()
        {
            ProtocolNode cur = getSelNode();
            NudgeDownCmd cmd = new NudgeDownCmd(cur);
            cmd.Execute(); 
            mProtocolTreeView.SelectedNode = cur;
        }
        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _nudgeNodeUp();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            _nudgeNodeDown();
        }

        private void mSaveToolStripButton_Click(object sender, EventArgs e)
        {
            ProtocolManager.save(mProtocolNode);
        }

        private void mAddSectionToolStripButton_Click(object sender, EventArgs e)
        {
            addSection();
        }

        private void addSection()
        {
            ProtocolNode newSectionNode = new ProtocolNode("New Section");
            newSectionNode.ImageIndex = SECT_IMG;
            newSectionNode.SelectedImageIndex = SECT_IMG;
            newSectionNode.IsSection = true;
            _addNode( (ProtocolNode) mProtocolTreeView.Nodes[0], newSectionNode);
        }

        private void mAddChildToolStripButton_Click(object sender, EventArgs e)
        {
            addChild();
        }






    }
}