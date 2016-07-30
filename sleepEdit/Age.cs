using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sleepEditPro
{
	/// <summary>
	/// Summary description for Age.
	/// </summary>
	public class Age : System.Windows.Forms.Form
	{
		public System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Age()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.AcceptButton = this.okButton;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.okButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(16, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(95, 27);
			this.textBox1.TabIndex = 0;
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.okButton.Location = new System.Drawing.Point(28, 160);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(163, 49);
			this.okButton.TabIndex = 1;
			this.okButton.Text = "OK";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Current age is not valid!! Please enter a new one.";
			// 
			// Age
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 20);
			this.ClientSize = new System.Drawing.Size(292, 252);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.textBox1);
			this.Name = "Age";
			this.Text = "Age";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion

		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string pattern = @"^[1-9][0-9]?$";
			string input = this.textBox1.Text;
			
			bool isMatched = Regex.IsMatch(input,pattern);
			if(!isMatched)
			{
				MessageBox.Show("Please enter a valid number between 1 and 99", "Error");
				e.Cancel=true;
			}
		}
	}
}
