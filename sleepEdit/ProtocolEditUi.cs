using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Protocols;
using sleepEdit;

namespace ProtocolUi
{
    public partial class ProtocolEditUi : Form
    {
        private const int ROOT_IMG = 1;
        private const int SECT_IMG = 21;
        private readonly DragDropEffects _dragMode = DragDropEffects.Move;
        private ProtocolNode mCurNode;
        private bool mIsFound;
        private UndoManager mManager = new UndoManager();
        private string mPath;
        private readonly ProtocolNode mProtocolNode = new ProtocolNode();
        private ProtocolNode mSourceNode;

        public ProtocolEditUi()
        {
            InitializeComponent();
            try
            {
                ProtocolManager.Load(mProtocolNode);
                Text = ProtocolManager.DefaultPath;
                mPath = Text;
            }
            catch
            {
                var dlg = new OpenFileDialog();
                dlg.Title = "Open XML Document";
                dlg.Filter = "XML Files (*.xml)|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    mPath = dlg.FileName;
                    Text = dlg.FileName;
                    ProtocolManager.Load(mProtocolNode, mPath);
                }
            }
            populateTree();
        }

        private void populateTree()
        {
            mProtocolTreeView.Nodes.Clear();
            mProtocolTreeView.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/[] {mProtocolNode});
            mProtocolTreeView.Nodes[0].ImageIndex = ROOT_IMG;
            mProtocolTreeView.Nodes[0].SelectedImageIndex = ROOT_IMG;
            mProtocolTreeView.Nodes[0].Expand();
            mProtocolTreeView.Nodes[0].Name = "ROOT";

            foreach (ProtocolNode node in getSectionNodes())
            {
                node.SelectedImageIndex = SECT_IMG;
                node.ImageIndex = SECT_IMG;
            }
        }


        private void mProtocolTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            mCurNode = getSelNode();
            mDocument.Text = mCurNode.Element.Text;
            mIdLabelValue.Text = mCurNode.Id.ToString();
            mLinkLabelText.Text = mCurNode.LinkId.ToString();
            mLinkTextBox.Text = mCurNode.LinkText;
            mQuestionListComboBox.Items.Clear();
            mQuestionListComboBox.Text = "";

            if (mCurNode.Element.SubTextList.Count > 0)
            {
                foreach (var str in mCurNode.Element.SubTextList)
                {
                    mQuestionListComboBox.Items.Add(str);
                }

                mQuestionListComboBox.Text = mQuestionListComboBox.Items[0] as string;
            }
        }

        private TreeNodeCollection getSectionNodes()
        {
            return mProtocolTreeView.Nodes[0].Nodes;
        }

        private void _addNode(ProtocolNode parent, ProtocolNode childNode)
        {
            var cmd = new AddCmd(parent, childNode);
            cmd.Execute();
        }

        private void _RemoveNode(ProtocolNode parent, ProtocolNode childNode)
        {
            List<ProtocolNode> list = null;
            getNodesThatLinkToNodeId_(mProtocolNode, ref list, childNode.Id);
            var cmd = new RemoveCmd(parent, childNode, list);
            cmd.Execute();
        }

        private void _nudgeNodeUp()
        {
            var cur = getSelNode();
            if (cur != null)
            {
                var cmd = new NudgeUpCmd(cur);
                cmd.Execute();
                mProtocolTreeView.SelectedNode = cur;
            }
        }

        private void _nudgeNodeDown()
        {
            var cur = getSelNode();
            if (cur != null)
            {
                var cmd = new NudgeDownCmd(cur);
                cmd.Execute();
                mProtocolTreeView.SelectedNode = cur;
            }
        }

        private void _move(ProtocolNode node, ProtocolNode newNode)
        {
            var cmd = new MoveCmd(mSourceNode, node, newNode);
            cmd.Execute();
        }

        private void getNodesThatLinkToNodeId_(ProtocolNode rootNode, ref List<ProtocolNode> list, int id)
        {
            foreach (ProtocolNode curNode in rootNode.Nodes)
            {
                if (curNode.LinkId == id)
                {
                    if (list == null)
                    {
                        list = new List<ProtocolNode>();
                    }
                    list.Add(curNode);
                }
                getNodesThatLinkToNodeId_(curNode, ref list, id);
            }
        }

        private ProtocolNode getSelNode()
        {
            ProtocolNode node;
            node = (ProtocolNode) mProtocolTreeView.SelectedNode;
            return node;
        }


        private void mDocument_TextChanged(object sender, EventArgs e)
        {
            mCurNode.Element.Text = mDocument.Text;
            mCurNode.Text = mDocument.Text;
        }

        private void mLinkTextBox_TextChanged(object sender, EventArgs e)
        {
            mCurNode.LinkText = mLinkTextBox.Text;
        }

        private void Tree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Get the tree.
            var tree = (TreeView) sender;

            // Get the node underneath the mouse.
            var selectedNode = (ProtocolNode) mProtocolTreeView.SelectedNode;
            tree.SelectedNode = selectedNode;

            // Start the drag-and-drop operation with a cloned copy of the node.
            if (selectedNode != null)
            {
                tree.DoDragDrop((ProtocolNode) selectedNode.Clone(), DragDropEffects.Move);
            }
        }


        private void tree_DragOver(object sender, DragEventArgs e)
        {
            // Get the tree.
            var tree = (TreeView) sender;

            // Drag and drop denied by default.
            e.Effect = DragDropEffects.None;

            // Is it a valid format?
            var dragedNode = (ProtocolNode) e.Data.GetData(typeof(ProtocolNode));
            if (dragedNode != null)
            {
                // Get the screen point.
                var pt = new Point(e.X, e.Y);

                // Convert to a point in the TreeView's coordinate system.
                pt = tree.PointToClient(pt);

                // Is the mouse over a valid node?
                var target = (ProtocolNode) tree.GetNodeAt(pt);
                if (isValidDragDrop(target))
                {
                    e.Effect = DragDropEffects.Move;
                    tree.SelectedNode = target;
                }
            }
        }

        private void Tree_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = _dragMode;
        }

        private void tree_DragDrop(object sender, DragEventArgs e)
        {
            // Get the tree.
            var tree = (TreeView) sender;

            // Get the screen point.
            var pt = new Point(e.X, e.Y);

            // Convert to a point in the TreeView's coordinate system.
            pt = tree.PointToClient(pt);

            // Get the node underneath the mouse.
            var newParentNode = (ProtocolNode) tree.GetNodeAt(pt);
            var newChildNode = (ProtocolNode) e.Data.GetData(typeof(ProtocolNode));

            _move(newParentNode, newChildNode);
        }

        private bool isValidDragDrop(ProtocolNode target)
        {
            if (target == null ||
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
            var selectedNode = (ProtocolNode) mProtocolTreeView.GetNodeAt(e.X, e.Y);
            mProtocolTreeView.SelectedNode = selectedNode;
            mSourceNode = selectedNode;
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
            var node = getSelNode();
            if (node != null)
            {
                if (node.IsProtocol)
                {
                    return;
                }
                var childNode = new ProtocolNode("New Node");
                _addNode(node, childNode);
                node.Expand();
            }
        }

        private void removeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeNode();
        }

        private void removeNode()
        {
            if (getSelNode().Name != "ROOT")
            {
                var parent = (ProtocolNode) mProtocolTreeView.SelectedNode.Parent;
                var child = (ProtocolNode) mProtocolTreeView.SelectedNode;
                _RemoveNode(parent, child);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            _nudgeNodeUp();
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
            if (mPath == null)
            {
                var dlg = new SaveFileDialog();
                dlg.Title = "Save XML Document";
                dlg.Filter = "XML Files (*.xml)|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Text = dlg.FileName;
                    mPath = dlg.FileName;
                    ProtocolManager.Save(mProtocolNode, mPath);
                }
            }
            else
            {
                ProtocolManager.Save(mProtocolNode, mPath);
            }
        }

        private void mAddSectionToolStripButton_Click(object sender, EventArgs e)
        {
            addSection();
        }

        private void addSection()
        {
            var newSectionNode = new ProtocolNode("New Section");
            newSectionNode.ImageIndex = SECT_IMG;
            newSectionNode.SelectedImageIndex = SECT_IMG;
            newSectionNode.IsSection = true;
            _addNode((ProtocolNode) mProtocolTreeView.Nodes[0], newSectionNode);
        }

        private void mAddChildToolStripButton_Click(object sender, EventArgs e)
        {
            addChild();
        }

        private void setLinkIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new TreeNodeSelect((ProtocolNode) mProtocolNode.Clone(), (ProtocolNode) getSelNode().Clone());

            dlg.Text = "Select Link node";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var node = (ProtocolNode) dlg.TreeView.SelectedNode;
                if (node != null)
                {
                    var curNode = getSelNode();
                    curNode.LinkId = node.Id;
                    mLinkLabelText.Text = node.Id.ToString();
                    mLinkTextBox.Text = node.Text;
                }

                // to do: add undo-redo support               
            }
        }

        private void AddSubTextItemButton_Click(object sender, EventArgs e)
        {
            if (mQuestionListComboBox.Text.Length > 0)
            {
                getSelNode().Element.SubTextList.Add(mQuestionListComboBox.Text);
                mQuestionListComboBox.Items.Add(mQuestionListComboBox.Text);
                // to do: add undo-redo support
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (mQuestionListComboBox.Text.Length > 0)
            {
                getSelNode().Element.SubTextList.Remove(mQuestionListComboBox.Text);
                mQuestionListComboBox.Items.Remove(mQuestionListComboBox.Text);
                mQuestionListComboBox.Text = "";
                // to do: add undo-redo support
            }
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            removeNode();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Title = "Open XML Document";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                clearAllFields();
                Text = dlg.FileName;
                mPath = dlg.FileName;
                /*mProtocolNode.Nodes.Clear();*/
                ProtocolManager.Load(mProtocolNode, mPath);
                populateTree();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            clearAllFields();
            var newSectionNode = new ProtocolNode("New Section");
            newSectionNode.ImageIndex = SECT_IMG;
            newSectionNode.SelectedImageIndex = SECT_IMG;
            newSectionNode.IsSection = true;
            mProtocolNode.Element.Text = "New Protocol";
            mProtocolNode.Text = "New Protocol";
            Text = "new Protocol";
            mProtocolNode.Element.SubTextList.Clear();
            mProtocolNode.IsProtocol = true;
            mProtocolNode.Id = 0;
            mProtocolNode.LinkId = -1;
            mProtocolNode.LinkText = "";
            mProtocolNode.Nodes.Add(newSectionNode);
            mProtocolTreeView.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/[] {mProtocolNode});
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            dlg.Title = "Save XML Document As";
            dlg.Filter = "XML Files (*.xml)|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Text = dlg.FileName;
                mPath = dlg.FileName;
                ProtocolManager.Save(mProtocolNode, mPath);
                Text = mPath;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAllFields();
        }

        private void clearAllFields()
        {
            mProtocolNode.Nodes.Clear();
            mProtocolTreeView.Nodes.Clear();
            mPath = null;
            mDocument.Text = "";
            mLinkTextBox.Text = "";
            mLinkLabelText.Text = "";
            mIdLabel.Text = "";
            mIdLabelValue.Text = "";
            mQuestionListComboBox.Items.Clear();
            mQuestionListComboBox.Text = "";
            Text = "";
        }
    }
}