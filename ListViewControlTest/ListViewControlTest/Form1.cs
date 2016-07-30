using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ListViewControlTest
{
    public partial class Form1 : Form
    {
        ListViewEmbeddedControls.ListViewEx listView1;
        public Form1()
        {
            

            
            InitializeComponent();
            CreateMyListView();
            Button btn = GetButton();
            listView1.AddEmbeddedControl(btn, 3, 0);
            btn.Click += new EventHandler(btn_Click);

            for (int row = 0; row < 3; row++ )
            {
                for (int col = 0; col <3; col++)
                {
                   
                    ComboBox cmb = GetComboBox();

                    TextBox tb = new TextBox();

                    switch (col)
                    {
                        case 0:
                           // listView1.AddEmbeddedControl(btn, col, row);
                            break;
                        case 1:
                            listView1.AddEmbeddedControl(cmb, col, row);
                            break;
                        case 2:
                            listView1.AddEmbeddedControl(tb, col, row);
                            break;
                        default:
                            break;
                    }
                }               

            }

            

           
        }

        void btn_Click(object sender, EventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
            TextBox tb = listView1.GetEmbeddedControl(2, 0) as TextBox; 
            string str = tb.Text;
            MessageBox.Show(str);
        }

        private ComboBox GetComboBox()
        {
            ComboBox cmb = new ComboBox();
            cmb.Font = this.Font;
            cmb.Items.Add("Hello 1");
            return cmb;
        }
        private Button GetButton()
        {
            Button btn = new Button();
            btn.Text = "Hello World ";
            btn.Font = this.Font;
            return btn;
        }

        private void CreateMyListView()
        {
            // Create a new ListView control.
            listView1 = new ListViewEmbeddedControls.ListViewEx();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listView1.Dock = DockStyle.Fill;
            

            
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            // listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            //listView1.AllowColumnReorder = true;
            // Display check boxes.
             listView1.CheckBoxes = true;
            // Select the item and sub items when selection is made.
            // listView1.FullRowSelect = true;
            // Display grid lines.
           // listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            // listView1.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("");
            // Place a check mark next to the item.
            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems.Add("");
            item1.SubItems.Add("");
            ListViewItem item2 = new ListViewItem("");
            item2.SubItems.Add("");
            item2.SubItems.Add("");
            item2.SubItems.Add("");
            ListViewItem item3 = new ListViewItem("");
            // Place a check mark next to the item.

            item3.SubItems.Add("");
            item3.SubItems.Add("");
            item3.SubItems.Add("");

            // Create columns for the items and sub items.
            listView1.Columns.Add("", -1, HorizontalAlignment.Left);
            listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns.Add("", -2, HorizontalAlignment.Left);
            listView1.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns.Add("3", -2, HorizontalAlignment.Left);
            listView1.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns.Add("", -2, HorizontalAlignment.Center);
            listView1.Columns[3].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            

            //Add the items to the ListView.
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });



            // Add the ListView to the control collection.
            this.Controls.Add(listView1);
        }




    }
}