namespace SleepEditControlLib
{
    partial class ProtocolNodeUi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAtSameLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MContextMenu
            // 
            this.MContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem,
            this.editNodeToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addAtSameLevelToolStripMenuItem});
            this.MContextMenu.Name = "MContextMenu";
            this.MContextMenu.Size = new System.Drawing.Size(227, 100);
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.addNodeToolStripMenuItem.Text = "Add node";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.addNodeToolStripMenuItem_Click);
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.editNodeToolStripMenuItem.Text = "Edit Node";
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addAtSameLevelToolStripMenuItem
            // 
            this.addAtSameLevelToolStripMenuItem.Name = "addAtSameLevelToolStripMenuItem";
            this.addAtSameLevelToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.addAtSameLevelToolStripMenuItem.Text = "Add at Same Level";
            this.addAtSameLevelToolStripMenuItem.Click += new System.EventHandler(this.addAtSameLevelToolStripMenuItem_Click);
            // 
            // ProtocolNodeUi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ContextMenuStrip = this.MContextMenu;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(775, 31);
            this.Name = "ProtocolNodeUi";
            this.Size = new System.Drawing.Size(775, 31);
            this.MContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAtSameLevelToolStripMenuItem;
    }
}
