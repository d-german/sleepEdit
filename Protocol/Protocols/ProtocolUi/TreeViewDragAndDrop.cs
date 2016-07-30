/*
User Interfaces in C#: Windows Forms and Custom Controls
by Matthew MacDonald

Publisher: Apress
ISBN: 1590590457
*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TreeViewDragAndDrop
{
    /// <summary>
    /// Summary description for TreeViewDragAndDrop.
    /// </summary>
    public class TreeViewDragAndDrop : System.Windows.Forms.Form
    {
        internal System.Windows.Forms.TreeView treeTwo;
        internal System.Windows.Forms.Splitter Splitter1;
        internal System.Windows.Forms.TreeView treeOne;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public TreeViewDragAndDrop()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeTwo = new System.Windows.Forms.TreeView();
            this.Splitter1 = new System.Windows.Forms.Splitter();
            this.treeOne = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeTwo
            // 
            this.treeTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTwo.HideSelection = false;
            this.treeTwo.ImageIndex = -1;
            this.treeTwo.Location = new System.Drawing.Point(239, 0);
            this.treeTwo.Name = "treeTwo";
            this.treeTwo.SelectedImageIndex = -1;
            this.treeTwo.Size = new System.Drawing.Size(281, 366);
            this.treeTwo.TabIndex = 6;
            this.treeTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            this.treeTwo.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.treeTwo.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            // 
            // Splitter1
            // 
            this.Splitter1.Location = new System.Drawing.Point(236, 0);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(3, 366);
            this.Splitter1.TabIndex = 5;
            this.Splitter1.TabStop = false;
            // 
            // treeOne
            // 
            this.treeOne.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeOne.HideSelection = false;
            this.treeOne.ImageIndex = -1;
            this.treeOne.Name = "treeOne";
            this.treeOne.SelectedImageIndex = -1;
            this.treeOne.Size = new System.Drawing.Size(236, 366);
            this.treeOne.TabIndex = 4;
            this.treeOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tree_MouseDown);
            this.treeOne.DragOver += new System.Windows.Forms.DragEventHandler(this.tree_DragOver);
            this.treeOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.tree_DragDrop);
            // 
            // TreeViewDragAndDrop
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(520, 366);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this.treeTwo,
                                                                          this.Splitter1,
                                                                          this.treeOne});
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.Name = "TreeViewDragAndDrop";
            this.Text = "TreeView Drag-And-Drop";
            this.Load += new System.EventHandler(this.TreeViewDragAndDrop_Load);
            this.ResumeLayout(false);

        }
        #endregion

//         /// <summary>
//         /// The main entry point for the application.
//         /// </summary>
//         [STAThread]
//         static void Main()
//         {
//             Application.Run(new TreeViewDragAndDrop());
//         }

        private void TreeViewDragAndDrop_Load(object sender, System.EventArgs e)
        {
            TreeNode node = treeOne.Nodes.Add("Fruits");
            node.Nodes.Add("Apple");
            node.Nodes.Add("Peach");
            node.Expand();

            node = treeTwo.Nodes.Add("Vegetables");
            node.Nodes.Add("Tomato");
            node.Nodes.Add("Eggplant");
            node.Expand();

            treeTwo.AllowDrop = true;
            treeOne.AllowDrop = true;
        }

        private void tree_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Get the node underneath the mouse.
            TreeNode node = tree.GetNodeAt(e.X, e.Y);
            tree.SelectedNode = node;

            // Start the drag-and-drop operation with a cloned copy of the node.
            if (node != null)
            {
                tree.DoDragDrop(node.Clone(), DragDropEffects.Copy);
            }
        }
        private void tree_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // Get the tree.
            TreeView tree = (TreeView)sender;

            // Drag and drop denied by default.
            e.Effect = DragDropEffects.None;

            // Is it a valid format?
            if (e.Data.GetData(typeof(TreeNode)) != null)
            {
                // Get the screen point.
                Point pt = new Point(e.X, e.Y);

                // Convert to a point in the TreeView's coordinate system.
                pt = tree.PointToClient(pt);

                // Is the mouse over a valid node?
                TreeNode node = tree.GetNodeAt(pt);
                if (node != null)
                {
                    e.Effect = DragDropEffects.Copy;
                    tree.SelectedNode = node;
                }
            }
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
            TreeNode node = tree.GetNodeAt(pt);

            // Add a child node.
            node.Nodes.Add((TreeNode)e.Data.GetData(typeof(TreeNode)));

            // Show the newly added node if it is not already visible.
            node.Expand();
        }

    }
}

