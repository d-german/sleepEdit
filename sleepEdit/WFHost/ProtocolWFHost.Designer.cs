namespace WFHost
{
    partial class ProtocolWFHost
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
            this.ui_WPFHostPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ui_WPFHostPanel
            // 
            this.ui_WPFHostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_WPFHostPanel.Location = new System.Drawing.Point(0, 0);
            this.ui_WPFHostPanel.Name = "ui_WPFHostPanel";
            this.ui_WPFHostPanel.Size = new System.Drawing.Size(813, 698);
            this.ui_WPFHostPanel.TabIndex = 0;
            // 
            // ProtocolWFHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 698);
            this.Controls.Add(this.ui_WPFHostPanel);
            this.Name = "ProtocolWFHost";
            this.Text = "ProtocolWFHost";
            this.Load += new System.EventHandler(this.ProtocolWFHost_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ui_WPFHostPanel;
    }
}

