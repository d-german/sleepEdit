namespace SleepEditControlLib
{
    partial class ProtocolWidget
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
            this.mContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mContextMenu
            // 
            this.mContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLineToolStripMenuItem});
            this.mContextMenu.Name = "mContextMenu";
            this.mContextMenu.Size = new System.Drawing.Size(158, 28);
            // 
            // addLineToolStripMenuItem
            // 
            this.addLineToolStripMenuItem.Name = "addLineToolStripMenuItem";
            this.addLineToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.addLineToolStripMenuItem.Text = "Add Line";
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(733, 23);
            this.mFlowLayoutPanel.TabIndex = 1;
            // 
            // ProtocolWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ContextMenuStrip = this.mContextMenu;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProtocolWidget";
            this.Size = new System.Drawing.Size(733, 23);
            this.mContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip mContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addLineToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
    }
}
