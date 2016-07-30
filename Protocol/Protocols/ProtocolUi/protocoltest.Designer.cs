namespace ProtocolUi
{
    partial class protocoltest
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mSectionTitleLabel = new System.Windows.Forms.Label();
            this.mFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mStatementCheckBox = new System.Windows.Forms.CheckBox();
            this.mSpacerLabel = new System.Windows.Forms.Label();
            this.mTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabControl
            // 
            this.mTabControl.Controls.Add(this.tabPage1);
            this.mTabControl.Controls.Add(this.tabPage2);
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControl.Location = new System.Drawing.Point(0, 0);
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(977, 603);
            this.mTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mFlowLayoutPanel);
            this.tabPage1.Controls.Add(this.mSectionTitleLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mSectionTitleLabel
            // 
            this.mSectionTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mSectionTitleLabel.AutoSize = true;
            this.mSectionTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.mSectionTitleLabel.Name = "mSectionTitleLabel";
            this.mSectionTitleLabel.Size = new System.Drawing.Size(71, 13);
            this.mSectionTitleLabel.TabIndex = 0;
            this.mSectionTitleLabel.Text = "label1fdfdfdfd";
            // 
            // mFlowLayoutPanel
            // 
            this.mFlowLayoutPanel.AutoScroll = true;
            this.mFlowLayoutPanel.Controls.Add(this.mSpacerLabel);
            this.mFlowLayoutPanel.Controls.Add(this.mStatementCheckBox);
            this.mFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mFlowLayoutPanel.Location = new System.Drawing.Point(3, 19);
            this.mFlowLayoutPanel.Name = "mFlowLayoutPanel";
            this.mFlowLayoutPanel.Size = new System.Drawing.Size(963, 555);
            this.mFlowLayoutPanel.TabIndex = 1;
            // 
            // mStatementCheckBox
            // 
            this.mStatementCheckBox.AutoSize = true;
            this.mStatementCheckBox.Location = new System.Drawing.Point(50, 3);
            this.mStatementCheckBox.Name = "mStatementCheckBox";
            this.mStatementCheckBox.Size = new System.Drawing.Size(15, 14);
            this.mStatementCheckBox.TabIndex = 0;
            this.mStatementCheckBox.UseVisualStyleBackColor = true;
            // 
            // mSpacerLabel
            // 
            this.mSpacerLabel.AutoSize = true;
            this.mSpacerLabel.Location = new System.Drawing.Point(3, 0);
            this.mSpacerLabel.Name = "mSpacerLabel";
            this.mSpacerLabel.Size = new System.Drawing.Size(41, 13);
            this.mSpacerLabel.TabIndex = 1;
            this.mSpacerLabel.Text = "Spacer";
            // 
            // protocoltest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 603);
            this.Controls.Add(this.mTabControl);
            this.Name = "protocoltest";
            this.Text = "protocoltest";
            this.mTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.mFlowLayoutPanel.ResumeLayout(false);
            this.mFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label mSectionTitleLabel;
        private System.Windows.Forms.FlowLayoutPanel mFlowLayoutPanel;
        private System.Windows.Forms.Label mSpacerLabel;
        private System.Windows.Forms.CheckBox mStatementCheckBox;
    }
}