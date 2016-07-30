using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace FindControlByName
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox txtControlName;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.Container components = null;
		public Form1()
		{			
			InitializeComponent();
		}
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.txtControlName = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(40, 24);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "textBox1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(256, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(16, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(224, 224);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(16, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(184, 160);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
			this.pictureBox1.Location = new System.Drawing.Point(40, 56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(48, 16);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(280, 168);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(192, 24);
			this.button2.TabIndex = 4;
			this.button2.Text = "FIND A CONTROL!";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtControlName
			// 
			this.txtControlName.Location = new System.Drawing.Point(376, 200);
			this.txtControlName.Name = "txtControlName";
			this.txtControlName.TabIndex = 5;
			this.txtControlName.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.linkLabel1);
			this.groupBox3.Location = new System.Drawing.Point(24, 96);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(136, 48);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(24, 24);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(72, 16);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(278, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Control\'s Name:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 273);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtControlName);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Find Control By Name";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
       System.Collections.Hashtable htFrm=new System.Collections.Hashtable();
		private Control FindControlByName(string ctrlName)
		{			 
			Form frm = this.FindForm();
			if(htFrm.Count ==0)
			AddControlToHashTable(frm.Name ,frm);					 
			return  (Control)htFrm[ctrlName];
		}
		private void AddControlToHashTable(string ctrlName, Control Ctrl)
		{
          htFrm.Add(ctrlName,Ctrl);
		  htFrm[ctrlName]=Ctrl;
			if(Ctrl.HasChildren)
			{
				foreach(Control ctrl2 in Ctrl.Controls )
				// recursive call adds all controls and any children
				AddControlToHashTable(ctrl2.Name,ctrl2);
			}
		}
		private void button2_Click(object sender, System.EventArgs e)
		{
			if(txtControlName.Text==""){ MessageBox.Show("Enter a control Name, Captain!"); return;}
			Control c = FindControlByName(txtControlName.Text);
			c.BackColor=Color.AntiqueWhite ;
		}
	}
}
