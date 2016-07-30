using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Data;

namespace sleepEditPro
{
    /// <summary>
    /// Summary description for medList.
    /// </summary>
    public class medList : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ComboBox comboBox_medlList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox document;
        private System.Windows.Forms.Button button2;
        private ArrayList list = new ArrayList();
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_removeMed;
        public System.Windows.Forms.GroupBox groupBox_removeMed;
        public System.Windows.Forms.GroupBox groupBox_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        public static bool isOpen;
        private string mPath = "";
        private System.IO.StreamReader sr;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public medList()
        {
            init();
        }
        public medList(string path)
        {
            mPath = path;
            init();
        }
        private void init()
        {
            InitializeComponent();


            isOpen = true;
            if (this.getPath())
                this.LoadMedList();
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            SaveMedList();
            isOpen = false;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_medlList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.document = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_removeMed = new System.Windows.Forms.TextBox();
            this.groupBox_removeMed = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_main = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox_removeMed.SuspendLayout();
            this.groupBox_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_medlList
            // 
            this.comboBox_medlList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_medlList.Location = new System.Drawing.Point(13, 21);
            this.comboBox_medlList.Name = "comboBox_medlList";
            this.comboBox_medlList.Size = new System.Drawing.Size(280, 25);
            this.comboBox_medlList.TabIndex = 0;
            this.comboBox_medlList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_medlList_KeyPress);
            this.comboBox_medlList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_medlList_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Copy all to ClipBoard";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // document
            // 
            this.document.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.document.Location = new System.Drawing.Point(13, 55);
            this.document.Multiline = true;
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(267, 104);
            this.document.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 76);
            this.label1.TabIndex = 4;
            this.label1.Text = "If the medication entered is not in the list it will be flagged with a * until ve" +
                "rified.";
            // 
            // textBox_removeMed
            // 
            this.textBox_removeMed.Location = new System.Drawing.Point(13, 76);
            this.textBox_removeMed.Name = "textBox_removeMed";
            this.textBox_removeMed.Size = new System.Drawing.Size(240, 23);
            this.textBox_removeMed.TabIndex = 5;
            // 
            // groupBox_removeMed
            // 
            this.groupBox_removeMed.Controls.Add(this.button3);
            this.groupBox_removeMed.Controls.Add(this.label2);
            this.groupBox_removeMed.Controls.Add(this.textBox_removeMed);
            this.groupBox_removeMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_removeMed.Location = new System.Drawing.Point(13, 21);
            this.groupBox_removeMed.Name = "groupBox_removeMed";
            this.groupBox_removeMed.Size = new System.Drawing.Size(280, 187);
            this.groupBox_removeMed.TabIndex = 6;
            this.groupBox_removeMed.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "REMOVE";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Med to remove";
            // 
            // groupBox_main
            // 
            this.groupBox_main.Controls.Add(this.document);
            this.groupBox_main.Controls.Add(this.button2);
            this.groupBox_main.Controls.Add(this.label1);
            this.groupBox_main.Controls.Add(this.comboBox_medlList);
            this.groupBox_main.Controls.Add(this.button1);
            this.groupBox_main.Location = new System.Drawing.Point(47, 14);
            this.groupBox_main.Name = "groupBox_main";
            this.groupBox_main.Size = new System.Drawing.Size(306, 319);
            this.groupBox_main.TabIndex = 7;
            this.groupBox_main.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "medlist.txt could not be found. Please locate.";
            this.openFileDialog1.ValidateNames = false;
            // 
            // medList
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(462, 430);
            this.Controls.Add(this.groupBox_removeMed);
            this.Controls.Add(this.groupBox_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "medList";
            this.Text = "medList";
            this.groupBox_removeMed.ResumeLayout(false);
            this.groupBox_removeMed.PerformLayout();
            this.groupBox_main.ResumeLayout(false);
            this.groupBox_main.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private bool getPath()
        {
            try
            {
                mPath = sleepEdit.medPath;
                sr = new System.IO.StreamReader(mPath);
                return true;
            }
            catch
            {
                return GetMedList();
            }

        }

        private bool GetMedList()
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mPath = this.openFileDialog1.FileName;
                sr = new System.IO.StreamReader(mPath);
                sleepEdit.medPath = mPath;
                if (mPath == "")
                {
                    return false;
                }
                return true;
            }
            else
                return false;
        }


        private bool LoadMedList()
        {
            try
            {
                string input;

                // Read as long as there are more lines
                do
                {
                    input = sr.ReadLine();
                    list.Add(input);

                } while (sr.Peek() != -1);
                // Peek returns -1 if at the end of the stream
                // Close the stream
                sr.Close();
                list.Sort();
                string temp;
                string tempStr;

                foreach (string str in list)
                {
                    temp = str.Substring(0, 1);
                    temp = temp.ToUpper();
                    tempStr = str.Remove(0, 1);
                    tempStr = temp + tempStr;
                    this.comboBox_medlList.Items.Add(tempStr);
                }
            }
            catch
            {
                GetMedList();
            }
            return false;
        }

        private void SaveMedList()
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(mPath);
                foreach (string item in this.comboBox_medlList.Items)
                    sw.WriteLine(item); // Write the item to the file
                sw.Flush();
                sw.Close();
            }
            catch (System.Exception)
            {
                MessageBox.Show("File not found or moved!");
            }
        }



        private void comboBox_medlList_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;

            if (e.KeyChar == (char)13)
            {
                if (document.Text == "")
                    document.Text = this.comboBox_medlList.Text + ", ";
                else
                    document.Text += this.comboBox_medlList.Text + ", ";
            }
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            document.SelectAll();
            document.Copy();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            document.Clear();

        }

        private void comboBox_medlList_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                this.comboBox_medlList.DroppedDown = true;
            int index = 0;
            ComboBox cbo = (ComboBox)sender;
            index = cbo.FindStringExact(cbo.Text);

            // We only want to do something if the enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // FindStringExact searches for the string and is not
                // case-sensitive, which
                // is exactly what we need, as Programmer and programmer is the same.
                // If we find a match we'll move the selection in the ComboBox to
                // that item.
                index = cbo.FindString(cbo.Text, 0);
                if (index < 0) // FindStringExact return -1 if nothing was found.
                {
                    if (list.BinarySearch(cbo.Text) < 0)
                    {
                        cbo.Text += "*";
                    }
                    cbo.Items.Add(cbo.Text);
                }
                else
                    cbo.SelectedIndex = index;

                // Signal that we've handled the key down event
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {

            string str = this.textBox_removeMed.Text;
            this.textBox_removeMed.Text = "";
            MedListUtil theMed = new MedListUtil();
            theMed.removeMedDelegate(str);
        }

    }
}
