using System.Windows.Forms;
using Protocols;

namespace sleepEdit
{
    public partial class TreeNodeSelect : Form
    {
        private readonly ProtocolNode mSelectedNode;


        public TreeNodeSelect(ProtocolNode node, ProtocolNode selectedNode)
        {
            InitializeComponent();
            mTreeView.Nodes.AddRange(new /*System.Windows.Forms.TreeNode*/[] {node});
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