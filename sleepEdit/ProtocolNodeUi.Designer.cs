namespace sleepEdit
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
            this.mCheckBox = new System.Windows.Forms.CheckBox();
            this.mComboBox = new System.Windows.Forms.ComboBox();
            this.mLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mDepthlabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mCheckBox
            // 
            this.mCheckBox.AutoSize = true;
            this.mCheckBox.Location = new System.Drawing.Point(44, 3);
            this.mCheckBox.Name = "mCheckBox";
            this.mCheckBox.Size = new System.Drawing.Size(106, 24);
            this.mCheckBox.TabIndex = 1;
            this.mCheckBox.Text = "checkBox1";
            this.mCheckBox.UseVisualStyleBackColor = true;
            // 
            // mComboBox
            // 
            this.mComboBox.FormattingEnabled = true;
            this.mComboBox.Location = new System.Drawing.Point(156, 3);
            this.mComboBox.Name = "mComboBox";
            this.mComboBox.Size = new System.Drawing.Size(121, 28);
            this.mComboBox.TabIndex = 2;
            // 
            // mLinkLabel
            // 
            this.mLinkLabel.AutoSize = true;
            this.mLinkLabel.Location = new System.Drawing.Point(283, 0);
            this.mLinkLabel.Name = "mLinkLabel";
            this.mLinkLabel.Size = new System.Drawing.Size(90, 20);
            this.mLinkLabel.TabIndex = 0;
            this.mLinkLabel.TabStop = true;
            this.mLinkLabel.Text = "mLinkLabel";
            // 
            // mDepthlabel
            // 
            this.mDepthlabel.Location = new System.Drawing.Point(3, 0);
            this.mDepthlabel.Name = "mDepthlabel";
            this.mDepthlabel.Size = new System.Drawing.Size(35, 13);
            this.mDepthlabel.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.mDepthlabel);
            this.flowLayoutPanel1.Controls.Add(this.mCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.mComboBox);
            this.flowLayoutPanel1.Controls.Add(this.mLinkLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(376, 34);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // ProtocolNodeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProtocolNodeUi";
            this.Size = new System.Drawing.Size(376, 34);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mCheckBox;
        private System.Windows.Forms.ComboBox mComboBox;
        private System.Windows.Forms.LinkLabel mLinkLabel;
        private System.Windows.Forms.Label mDepthlabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
