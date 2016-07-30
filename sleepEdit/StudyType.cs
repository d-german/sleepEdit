using System.ComponentModel;
using System.Windows.Forms;

namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for StudyType.
    /// </summary>
    public class StudyType : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container components = null;

        private Button okButton;
        public RadioButton radioButton_psg;
        public RadioButton radioButton_split;
        public RadioButton radioButton_tx;

        public StudyType()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            AcceptButton = okButton;

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
            this.radioButton_psg = new System.Windows.Forms.RadioButton();
            this.radioButton_split = new System.Windows.Forms.RadioButton();
            this.radioButton_tx = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButton_psg
            // 
            this.radioButton_psg.Location = new System.Drawing.Point(24, 48);
            this.radioButton_psg.Name = "radioButton_psg";
            this.radioButton_psg.Size = new System.Drawing.Size(144, 24);
            this.radioButton_psg.TabIndex = 0;
            this.radioButton_psg.Text = "PSG/ PO-PSG";
            // 
            // radioButton_split
            // 
            this.radioButton_split.Location = new System.Drawing.Point(24, 88);
            this.radioButton_split.Name = "radioButton_split";
            this.radioButton_split.TabIndex = 1;
            this.radioButton_split.Text = "Split";
            // 
            // radioButton_tx
            // 
            this.radioButton_tx.Location = new System.Drawing.Point(24, 128);
            this.radioButton_tx.Name = "radioButton_tx";
            this.radioButton_tx.TabIndex = 2;
            this.radioButton_tx.Text = "Titration";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(136, 160);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(128, 64);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            // 
            // StudyType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(292, 252);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.radioButton_tx);
            this.Controls.Add(this.radioButton_split);
            this.Controls.Add(this.radioButton_psg);
            this.Name = "StudyType";
            this.Text = "StudyType";
            this.ResumeLayout(false);
        }

        #endregion
    }
}