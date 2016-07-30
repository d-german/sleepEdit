namespace sleepEdit
{
    partial class TreeNodeSelect
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
            this.mTreeView = new System.Windows.Forms.TreeView();
            this.mOkbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mTreeView
            // 
            this.mTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mTreeView.Location = new System.Drawing.Point(12, -3);
            this.mTreeView.Name = "mTreeView";
            this.mTreeView.Size = new System.Drawing.Size(560, 411);
            this.mTreeView.TabIndex = 0;
            // 
            // mOkbutton
            // 
            this.mOkbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mOkbutton.AutoSize = true;
            this.mOkbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mOkbutton.Location = new System.Drawing.Point(455, 415);
            this.mOkbutton.Name = "mOkbutton";
            this.mOkbutton.Size = new System.Drawing.Size(75, 23);
            this.mOkbutton.TabIndex = 1;
            this.mOkbutton.Text = "OK";
            this.mOkbutton.UseVisualStyleBackColor = true;
            // 
            // TreeNodeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.mOkbutton);
            this.Controls.Add(this.mTreeView);
            this.Name = "TreeNodeSelect";
            this.Text = "TreeNodeSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView mTreeView;
        public System.Windows.Forms.TreeView TreeView
        {
            get { return mTreeView; }
            
        }
        private System.Windows.Forms.Button mOkbutton;
    }
}