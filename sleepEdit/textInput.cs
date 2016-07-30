using System.ComponentModel;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for textInput.
    /// </summary>
    public class textInput : Form
    {
        private Button button1;

        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        public TextBox document;

        public textInput()
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
        ///     Clean up any resources being used.
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
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.document = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // document
            // 
            this.document.Location = new System.Drawing.Point(16, 40);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(280, 22);
            this.document.TabIndex = 0;
            this.document.Text = "";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(184, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            // 
            // textInput
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(336, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.document);
            this.MaximizeBox = false;
            this.Name = "textInput";
            //this.Text = "Text Input"; //99999
            this.ResumeLayout(false);
        }

        #endregion
    }
}