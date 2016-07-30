namespace ProtocolUi
{
    partial class DragDropTest
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
            this.mProtocolTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // mProtocolTreeView
            // 
            this.mProtocolTreeView.AllowDrop = true;
            this.mProtocolTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mProtocolTreeView.Location = new System.Drawing.Point(0, 0);
            this.mProtocolTreeView.Name = "mProtocolTreeView";
            this.mProtocolTreeView.Size = new System.Drawing.Size(292, 256);
            this.mProtocolTreeView.TabIndex = 0;
            this.mProtocolTreeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.mProtocolTreeView_DragDrop);
            this.mProtocolTreeView.DragOver += new System.Windows.Forms.DragEventHandler(this.mProtocolTreeView_DragOver);
            this.mProtocolTreeView.DragLeave += new System.EventHandler(this.mProtocolTreeView_DragLeave);
            this.mProtocolTreeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.mProtocolTreeView_DragEnter);
            // 
            // DragDropTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.mProtocolTreeView);
            this.Name = "DragDropTest";
            this.Text = "DragDropTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView mProtocolTreeView;

    }
}