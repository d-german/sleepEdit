using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace sleepEditPro
{
	/// <summary>
	/// Summary description for SpO2Artifact.
	/// </summary>
	public class SpO2Artifact : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox_spo2Value;
		private System.Windows.Forms.Button okButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SpO2Artifact()
		{
			InitializeComponent();			
			this.AcceptButton = this.okButton;
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
			this.textBox_spo2Value = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox_spo2Value
			// 
			this.textBox_spo2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox_spo2Value.Location = new System.Drawing.Point(32, 112);
			this.textBox_spo2Value.Name = "textBox_spo2Value";
			this.textBox_spo2Value.Size = new System.Drawing.Size(72, 30);
			this.textBox_spo2Value.TabIndex = 0;
			this.textBox_spo2Value.Text = "";
			this.textBox_spo2Value.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_spo2Value_Validating);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 64);
			this.label2.TabIndex = 2;
			this.label2.Text = "The current SpO2 value may be artifact!!! You may enter a new value.";
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.okButton.Location = new System.Drawing.Point(136, 184);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(128, 48);
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			// 
			// SpO2Artifact
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(292, 252);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_spo2Value);
			this.Name = "SpO2Artifact";
			this.Text = "SpO2Artifact";
			this.ResumeLayout(false);

		}
		#endregion

		private void textBox_spo2Value_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string pattern = @"^[1-9][0-9](\.[0-9])?$";
			string input = this.textBox_spo2Value.Text;
			
			bool isMatched = Regex.IsMatch(input,pattern);
			if(!isMatched)
			{
				MessageBox.Show("Please enter a valid number between 10 and 99", "Error");
				e.Cancel=true;
			}
		}
	}
}
