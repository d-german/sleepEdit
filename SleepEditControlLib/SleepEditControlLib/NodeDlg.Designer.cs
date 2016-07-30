namespace SleepEditControlLib
{
    partial class NodeDlg
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
            this.mTextBoxNodeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mOkbutton = new System.Windows.Forms.Button();
            this.mCancelButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mGotolistBox = new System.Windows.Forms.ListBox();
            this.mQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOTOLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTextBoxNodeText
            // 
            this.mTextBoxNodeText.AllowDrop = true;
            this.mTextBoxNodeText.Location = new System.Drawing.Point(12, 64);
            this.mTextBoxNodeText.Multiline = true;
            this.mTextBoxNodeText.Name = "mTextBoxNodeText";
            this.mTextBoxNodeText.Size = new System.Drawing.Size(297, 159);
            this.mTextBoxNodeText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // mOkbutton
            // 
            this.mOkbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mOkbutton.Location = new System.Drawing.Point(607, 360);
            this.mOkbutton.Name = "mOkbutton";
            this.mOkbutton.Size = new System.Drawing.Size(75, 23);
            this.mOkbutton.TabIndex = 4;
            this.mOkbutton.Text = "OK";
            this.mOkbutton.UseVisualStyleBackColor = true;
            // 
            // mCancelButton
            // 
            this.mCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mCancelButton.Location = new System.Drawing.Point(512, 360);
            this.mCancelButton.Name = "mCancelButton";
            this.mCancelButton.Size = new System.Drawing.Size(75, 23);
            this.mCancelButton.TabIndex = 5;
            this.mCancelButton.Text = "Cancel";
            this.mCancelButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Question List:";
            // 
            // mGotolistBox
            // 
            this.mGotolistBox.FormattingEnabled = true;
            this.mGotolistBox.Location = new System.Drawing.Point(315, 64);
            this.mGotolistBox.Name = "mGotolistBox";
            this.mGotolistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.mGotolistBox.Size = new System.Drawing.Size(324, 95);
            this.mGotolistBox.TabIndex = 8;
            // 
            // mQuestionComboBox
            // 
            this.mQuestionComboBox.FormattingEnabled = true;
            this.mQuestionComboBox.Location = new System.Drawing.Point(12, 275);
            this.mQuestionComboBox.Name = "mQuestionComboBox";
            this.mQuestionComboBox.Size = new System.Drawing.Size(297, 21);
            this.mQuestionComboBox.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOTOLinkToolStripMenuItem,
            this.questionToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // gOTOLinkToolStripMenuItem
            // 
            this.gOTOLinkToolStripMenuItem.Name = "gOTOLinkToolStripMenuItem";
            this.gOTOLinkToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.gOTOLinkToolStripMenuItem.Text = "GOTO Link";
            
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.questionToolStripMenuItem.Text = "Question";
            // 
            // NodeDlg
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(699, 395);
            this.Controls.Add(this.mQuestionComboBox);
            this.Controls.Add(this.mGotolistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mCancelButton);
            this.Controls.Add(this.mOkbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTextBoxNodeText);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NodeDlg";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mGotolistBox = new System.Windows.Forms.ListBox();
        private System.Windows.Forms.ComboBox mQuestionComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gOTOLinkToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem GOTOLinkToolStripMenuItem
        {
            get { return gOTOLinkToolStripMenuItem; }
            set { gOTOLinkToolStripMenuItem = value; }
        }
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;

        

       
    }
}