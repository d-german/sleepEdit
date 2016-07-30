namespace SleepEditControlLib
{
    partial class ProtocolStatementUi
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
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mDepthLabel = new System.Windows.Forms.Label();
            this.mCheckBox = new System.Windows.Forms.CheckBox();
            this.mComboBoxSubText = new System.Windows.Forms.ComboBox();
            this.MContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAtSameLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFlowLayoutPanel.SuspendLayout();
            this.MContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.AutoSize = true;
            this.mFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mFlowLayoutPanel.Controls.Add(this.mDepthLabel);
            this.mFlowLayoutPanel.Controls.Add(this.mCheckBox);
            this.mFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(16, 14);
            this.mFlowLayoutPanel.TabIndex = 0;
            // 
            // mDepthLabel
            // 
            this.mDepthLabel.Location = new System.Drawing.Point(0, 0);
            this.mDepthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.mDepthLabel.MinimumSize = new System.Drawing.Size(1, 0);
            this.mDepthLabel.Name = "mDepthLabel";
            this.mDepthLabel.Size = new System.Drawing.Size(1, 13);
            this.mDepthLabel.TabIndex = 0;
            // 
            // mCheckBox
            // 
            this.mCheckBox.AutoSize = true;
            this.mCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCheckBox.Location = new System.Drawing.Point(1, 0);
            this.mCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.mCheckBox.Name = "mCheckBox";
            this.mCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mCheckBox.TabIndex = 1;
            this.mCheckBox.UseVisualStyleBackColor = true;
            // 
            // mComboBoxSubText
            // 
            this.mComboBoxSubText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mComboBoxSubText.FormattingEnabled = true;
            this.mComboBoxSubText.Location = new System.Drawing.Point(44, 0);
            this.mComboBoxSubText.Margin = new System.Windows.Forms.Padding(0);
            this.mComboBoxSubText.Name = "mComboBoxSubText";
            this.mComboBoxSubText.Size = new System.Drawing.Size(201, 21);
            this.mComboBoxSubText.TabIndex = 2;
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
            // ProtocolStatementUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ContextMenuStrip = this.MContextMenu;
            this.Controls.Add(this.mFlowLayoutPanel);
            this.Name = "ProtocolStatementUi";
            this.Size = new System.Drawing.Size(16, 14);
            this.mFlowLayoutPanel.ResumeLayout(false);
            this.mFlowLayoutPanel.PerformLayout();
            this.MContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
        private System.Windows.Forms.Label mDepthLabel;
        private System.Windows.Forms.CheckBox mCheckBox;
        private System.Windows.Forms.ComboBox mComboBoxSubText;
/*        private System.Windows.Forms.FlowLayoutPanel mflowLayoutPanelGotoLabels;*/
        private System.Windows.Forms.ContextMenuStrip MContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAtSameLevelToolStripMenuItem;
    }
}
