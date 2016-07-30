using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Protocols;

namespace sleepEditPro
{
    /// <summary>
    /// Summary description for SleepProtocol. //99999
    /// </summary>
    public class Protocol : System.Windows.Forms.Form
    {
       
        private ProtocolNode mProtocolNode = new ProtocolNode();
        private static string protocolTitle;
        public static string ProtocolTitle
        {
            get { return protocolTitle; }
            set { protocolTitle = value; }
        }       

        public System.Windows.Forms.RichTextBox document;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_chinStrap;
        private System.Windows.Forms.CheckBox checkBox_humidifer;
        private System.Windows.Forms.ComboBox comboBox_maskSize;
        private System.Windows.Forms.ComboBox comboBox_maskType;
        private System.Windows.Forms.ComboBox comboBox_TechName;
        private System.Windows.Forms.Label label_maskSize;
        private System.Windows.Forms.Label label1_maskType;
        private System.Windows.Forms.CheckBox checkBox_hasCpap;
        private System.Windows.Forms.CheckBox checkBox_noCpapMac;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ahiNotlessThan5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TabPage StudyInfo;
        private System.Windows.Forms.ComboBox comboBox_testordered;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_txChangedTo;
        private System.Windows.Forms.Label label_andChangedTo;
        private System.Windows.Forms.Label label_pressVerified;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBox_noSupRemSleep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_slash1;
        private System.Windows.Forms.Label label_slash2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox_noSupRem;
        private System.Windows.Forms.ComboBox comboBox_cpapNoMinHrFinTx;
        private System.Windows.Forms.CheckBox checkBox_cpapNoMinHrFinTx;
        private System.Windows.Forms.ComboBox comboBox_cpapRDInotLess5;
        private System.Windows.Forms.CheckBox checkBox_cpapRDInotLess5;
        private System.Windows.Forms.ComboBox comboBox_cpapNoSupineRemObtained;
        private System.Windows.Forms.CheckBox checkBox_cpapNoSupineRemObtained;
        private System.Windows.Forms.ComboBox comboBox_cpapAHabolishedAt;
        private System.Windows.Forms.ComboBox comboBox_cpapSnoringAbolished;
        private System.Windows.Forms.ComboBox comboBox_bipapNoSupineRemO;
        private System.Windows.Forms.CheckBox checkBox_bipapNoSupineRemObtained;
        private System.Windows.Forms.ComboBox comboBox_bipapNoMinHrFin;
        private System.Windows.Forms.CheckBox checkBox_bipapNoMinHrFinTx;
        private System.Windows.Forms.ComboBox comboBox_bipapRDInotLess;
        private System.Windows.Forms.CheckBox checkBox_bipapRDInotLess5;
        private System.Windows.Forms.ComboBox comboBox_epapAHAb;
        private System.Windows.Forms.ComboBox comboBox_epapSnorAb;
        private System.Windows.Forms.ComboBox comboBox_ipapAHAb;
        private System.Windows.Forms.ComboBox comboBox_ipapSnorAb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl mTabControl;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox_oralAppNoHrMin;
        private System.Windows.Forms.CheckBox checkBox_oralAppNoHrMin;
        private System.Windows.Forms.ComboBox comboBox_oralAppNoRdiLess5;
        private System.Windows.Forms.CheckBox checkBox_oralAppNoRdiLess5;
        private System.Windows.Forms.CheckedListBox checkedListBox_secXX;
        private System.Windows.Forms.GroupBox groupBox_oxygen;
        private System.Windows.Forms.CheckBox checkBox_ptArrivedOnO2;
        private System.Windows.Forms.ComboBox comboBox_lpm;
        private System.Windows.Forms.ContextMenu contextMenu_techName;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.ContextMenu contextMenu_maskType;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem6;

        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.ContextMenu contextMenu_maskSize;
        private System.Windows.Forms.MenuItem menuItem9;
        private System.Windows.Forms.MenuItem menuItem10;
        private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.CheckBox checkBox_nobringMac;
        private System.Windows.Forms.TextBox textBox_ptName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_txVerifiedAT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox_abgMedDirCalled;
        private System.Windows.Forms.TextBox textBox_abgInstructions;
        private System.Windows.Forms.ComboBox comboBox_why_noabg;
        private System.Windows.Forms.CheckBox checkBox_ptSmokes;
        private System.Windows.Forms.RadioButton radioButton_NRBno;
        private System.Windows.Forms.RadioButton radioButton_NRByes;
        private System.Windows.Forms.RadioButton radioButton_COHbNo;
        private System.Windows.Forms.RadioButton radioButton_COHbYes;
        private System.Windows.Forms.RadioButton radioButton_abgNo;
        private System.Windows.Forms.RadioButton radioButton_abgYes;
        private System.Windows.Forms.GroupBox groupBox_COHB;
        private System.Windows.Forms.GroupBox groupBox_abg;
        private System.Windows.Forms.GroupBox groupBox_WhyNoAbg;
        private System.Windows.Forms.ComboBox comboBox_no15Lpm;
        private System.Windows.Forms.GroupBox groupBox_NRB;
        private string mProtocolPath;
        private MaskedTextBox maskedTextBox1;
        private Button button3;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Protocol()
        {
            //
            // Required for Windows Form Designer support
            //
            try
            {
                ProtocolManager.load(mProtocolNode);
            }
            catch (System.Exception e)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open XML Document";
                dlg.Filter = "XML Files (*.xml)|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    mProtocolPath = dlg.FileName;
                    ProtocolManager.load(mProtocolNode, mProtocolPath);
                }
            }
            InitializeComponent();
            init();
            populateForm();
        }

        private void populateForm()
        {
            foreach (ProtocolNode node in mProtocolNode.Nodes)
            {
                TabPage tabPage = getTabPage(node);
                mTabControl.Controls.Add(tabPage);
                if (node.Nodes.Count > 0)
                {
                    processAllNodes(node, ref tabPage);
                }
            }
        }


        void processAllNodes(ProtocolNode node, ref TabPage tabPage)
        {
            if (node != null)
            {
                this.SuspendLayout();
                FlowLayoutPanel tabControlPanel = null;
                FlowLayoutPanel itemPanel = null;

                if (true/*!node.IsSection*/)
                {
                    tabControlPanel = (FlowLayoutPanel)tabPage.Controls.Find("FlowLayout", false)[0];
                    itemPanel = getFlowPanel(FlowDirection.LeftToRight, DockStyle.None, false);
                    
                    tabControlPanel.SuspendLayout();
                    itemPanel.SuspendLayout();

                    itemPanel.Controls.Add(getDepthLabel(node));
                    itemPanel.Controls.Add(getItemCheckBox(node));

                    if (node.Element.SubTextList.Count>0)
                    {                       
	                    ComboBox cb = new ComboBox();
                        foreach (string str in node.Element.SubTextList)
                        {
                            cb.Items.Add(str);
                        }
                        itemPanel.Controls.Add(cb);
                    }
                    
                    if (node.LinkId > 0)
                    {
	                    LinkLabel lnk = new LinkLabel();
                        lnk.AutoSize = true;
                        lnk.Text = node.LinkText;
                        lnk.Tag = node.LinkId;
                        lnk.Click += new EventHandler(lnk_Click);
                        itemPanel.Controls.Add(lnk);
                    }
                    
                    itemPanel.Tag = node.Id;                                        
                    tabControlPanel.Controls.Add(itemPanel);
                    tabControlPanel.PerformLayout();

                    itemPanel.ResumeLayout(false);
                    tabControlPanel.ResumeLayout(false);
                    this.ResumeLayout(false);
                }

                foreach (ProtocolNode cur in node.Nodes)
                {
                    processAllNodes(cur, ref tabPage);
                }                
            }
        }

        void lnk_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = (LinkLabel)sender;
            string findStr = "checkBox" + (string)linkLabel.Tag.ToString();
            CheckBox c = FindControlByName(findStr) as CheckBox;
            if (c != null)
            {
                int i = 0;
                foreach (TabPage page in mTabControl.Controls)
                {
                    if (page.Controls.Find(c.Name, true).GetLength(0) > 0)
                    {
                        mTabControl.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
                c.BackColor = Color.Gold;
                c.Focus();
            }
        }

        static private FlowLayoutPanel getFlowPanel(FlowDirection direction, DockStyle dock, bool autoScroll)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.SuspendLayout();
            panel.FlowDirection = direction;
            panel.AutoSize = true;
            panel.Dock = dock;
            panel.AutoScroll = autoScroll;
            panel.PerformLayout();
            panel.ResumeLayout(false);
            return panel;            
        }

        private  CheckBox getItemCheckBox(ProtocolNode node)
        {
            CheckBox cb = new CheckBox(); 
            cb.LostFocus += new EventHandler(cb_LostFocus);
            cb.AutoSize = true;
            cb.AutoEllipsis = true;
            cb.Text = node.Element.Text;
            cb.Name = "checkBox" + node.Id.ToString();
            AddControlToHashTable(cb.Name, cb);
            cb.Tag = node.LinkId;
            return cb;
        }

        void cb_LostFocus(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            c.BackColor = Color.Transparent;
        }


        private static Label getDepthLabel(ProtocolNode node)
        {
            Label depthLbl = new Label();
            depthLbl.Margin = new System.Windows.Forms.Padding(0);
            depthLbl.MinimumSize = new System.Drawing.Size(1, 0);
            depthLbl.Size = new System.Drawing.Size(1, 13);
            depthLbl.Width = node.Level * 20;
            return depthLbl;
        }

        private TabPage getTabPage(ProtocolNode node)
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = node.Element.Text;
            tabPage.Tag = node;
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.UseVisualStyleBackColor = true;
            tabPage.AutoScroll = true;
            FlowLayoutPanel panel = getFlowPanel(FlowDirection.TopDown,DockStyle.Fill,true);
            panel.Layout += new LayoutEventHandler(panel_Layout);
            panel.SuspendLayout();
            panel.Name = "FlowLayout";
            tabPage.Controls.Add(panel);
            tabPage.Layout += new LayoutEventHandler(tabPage_Layout);
            tabPage.SuspendLayout();
            return tabPage;
        }

        void tabPage_Layout(object sender, LayoutEventArgs e)
        {
            i++;

        }


        
        static int i = 0;

         void panel_Layout(object sender, LayoutEventArgs e)
        {
            //i++;         
        }

        System.Collections.Hashtable htFrm = new System.Collections.Hashtable();
        private Control FindControlByName(string ctrlName)
        {
            Form frm = this.FindForm();
            if (htFrm.Count == 0)
                AddControlToHashTable(frm.Name, frm);
            return (Control)htFrm[ctrlName];
        }
        private void AddControlToHashTable(string ctrlName, Control Ctrl)
        {
            if (ctrlName == "")
            {
                return;
            }
            htFrm.Add(ctrlName, Ctrl);
            htFrm[ctrlName] = Ctrl;
            if (Ctrl.HasChildren)
            {
                foreach (Control ctrl2 in Ctrl.Controls)
                    // recursive call adds all controls and any children
                    AddControlToHashTable(ctrl2.Name, ctrl2);
            }
        }
        private void init()
        {
            this.comboBox_txChangedTo.Items.AddRange(GetTxValues());

            this.comboBox_txVerifiedAT.Items.AddRange(GetTxValues());
            this.comboBox_cpapAHabolishedAt.Items.AddRange(GetTxValues());
            this.comboBox_cpapSnoringAbolished.Items.AddRange(GetTxValues());

            this.comboBox_epapAHAb.Items.AddRange(GetTxValues());

            this.comboBox_epapSnorAb.Items.AddRange(GetTxValues());
            this.comboBox_ipapAHAb.Items.AddRange(GetTxValues());
            this.comboBox_ipapSnorAb.Items.AddRange(GetTxValues());

            try
            {
                this.groupBox4.Text = protocolTitle.Trim(); //99999
                this.Text = protocolTitle.Trim(); //99999
            }
            catch
            {
                MessageBox.Show(ProtocolTitle);
            }





            for (int i = 0; i < sleepEdit.techList.Count; i++)
            {
                this.comboBox_TechName.Items.Add(sleepEdit.techList[i]);
            }

            for (int i = 0; i < sleepEdit.maskType.Count; i++)
            {
                this.comboBox_maskType.Items.Add((string)sleepEdit.maskType[i]);

            }

            for (int i = 0; i < sleepEdit.maskSize.Count; i++)
            {
                this.comboBox_maskSize.Items.Add((string)sleepEdit.maskSize[i]);

            }
        }
        /// <summary>
        /// Clean up any resources being used.
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


        private void button_OK_Click(object sender, System.EventArgs e)
        {
            document.Text = "  \r\n";
            document.Text += ProtocolTitle; //99999
            document.Text += "Technician: " + this.comboBox_TechName.Text + "\n"
                + "Date of Study: " + this.dateTimePicker1.Text + "\r"
                + "Patient Name: " + this.textBox_ptName.Text + "\r"
                + "Test Ordered: " + this.comboBox_testordered.Text + "\r";

            document.Text += "Technician Documentation\r";

            document.Text += "CPAP/BIPAP Info:\r\n";
            int k = document.Text.Length;

            if (this.checkBox_nobringMac.Checked)
                document.Text += "Pt has machine but did not bring it.\r\n";

            if (this.checkBox_noCpapMac.Checked)
                document.Text += "Patient does not have a CPAP/BIPAP unit.\r\n ";
            else if (this.checkBox_hasCpap.Checked)
            {
                document.Text += "Patient has and brought CPAP/BIPAP unit. ";
                if (this.comboBox_txVerifiedAT.Text != "" && this.comboBox_txChangedTo.Text != "")
                    document.Text += "Pressure verified at " + this.comboBox_txVerifiedAT.Text
                        + " cm H2O and changed to " + this.comboBox_txChangedTo.Text + " cm H2O. ";
            }
            if (this.comboBox_maskType.Text != "" && this.comboBox_maskSize.Text != "")
                document.Text += "Mask Style: " + this.comboBox_maskType.Text + " Mask size: " + this.comboBox_maskSize.Text + ". ";
            if (this.comboBox_maskType.Text != "" && this.comboBox_maskSize.Text == "")
                document.Text += "Mask Style: " + this.comboBox_maskType.Text + ". ";

            if (this.checkBox_chinStrap.Checked)
                document.Text += "A chin strap was used. ";
            if (this.checkBox_humidifer.Checked)
                document.Text += "Heated Humidity was used. \r\n";
            int j = document.Text.Length;
            if (k == j) document.Text += "None.\r\n";
            document.Text += "\r\nABG Info:\r\n";
            k = document.Text.Length;


            if (this.radioButton_abgNo.Checked && this.comboBox_why_noabg.Text != "")
                document.Text += "No ABG obtained due to: " + this.comboBox_why_noabg.Text + "\r";
            else if (this.radioButton_abgYes.Checked)
            {
                document.Text += "ABG Values obtained. ";
                if (this.radioButton_COHbYes.Checked)
                {
                    document.Text += "ABG's reveal an elevated carboxyhemoglobin. ";
                    if (this.radioButton_NRByes.Checked)
                        document.Text += "Patient placed on 15 lpm O2 via NRB mask as per protocol. ";
                    else if (this.radioButton_NRBno.Checked)
                    {
                        document.Text += "Patient was not placed on 15 lpm O2 via NRB mask as per protocol. ";
                        if (!this.comboBox_no15Lpm.Text.Equals("Why not?"))
                            document.Text += "Due to: " + this.comboBox_no15Lpm.Text + ". ";
                    }
                    if (this.checkBox_ptSmokes.Checked)
                        document.Text += "The patient smokes. ";
                }
            }
            if (this.checkBox_abgMedDirCalled.Checked && this.textBox_abgInstructions.Text != "")
                document.Text += "Medical Director contacted regarding ABG's. \r"
                    + "Instructions: " + this.textBox_abgInstructions.Text + "\r";
            else
                if (this.checkBox_abgMedDirCalled.Checked)
                    document.Text += "Medical Director contacted regarding ABG's. \r";

            j = document.Text.Length;

            if (k == j) document.Text += "None.\r\n";

            if (this.checkBox_ptArrivedOnO2.Checked)
                document.Text += "The patient arrived on " + this.comboBox_lpm.Text + ".\r\n";


           // processCheckBoxLists();



        }

//         private void processCheckBoxLists()
//         {
//             if (this.checkedListBox_secI.CheckedItems.Count != 0 || this.checkBox_noSupRemSleep.Checked)
//             {
//                 this.document.Text += "\rDiagnostic Polysomnogram:\r\n";
// 
//                 for (int i = 0; i <= checkedListBox_secI.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secI.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
//                 }
//                 if (this.checkBox_noSupRemSleep.Checked)
//                 {
//                     if (this.comboBox_noSupRem.Text != "")
//                         document.Text += "No supine/REM sleep obtained due to: " + this.comboBox_noSupRem.Text + "\r\n";
//                     else
//                         document.Text += "No supine/REM sleep obtained.\r\n";
//                 }
//             }
// 
// 
//             if (this.checkedListBox_secII.CheckedItems.Count != 0)
//             {
//                 this.document.Text += "\rSplit Night Polysomnogram:\r\n";
// 
//                 for (int i = 0; i <= checkedListBox_secII.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("Monitor SpO2 and EKG"))
//                         tempstr = "Monitor SpO2 and EKG for Emergency Guideline Interventions (if present, document a minimum of 2 hours of sleep and then initiate corrective measures. Document and contact Medical Director).\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
//             }
// 
//             if (this.checkedListBox_secIII.CheckedItems.Count != 0)
//             {
//                 this.document.Text += "\rCPAP Titration Polysomnogram:\r\nInitiate CPAP at 4 cm H2O minimum for initial titration; at patient's current home setting; or the pressure specified by referring physician/Medical Director.  REMOVE O2 IF PaO2 IS > 55 mm Hg\r\n\r\n";
// 
//                 for (int i = 0; i <= checkedListBox_secIII.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "   ";
//                     tempstr = checkedListBox_secIII.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
//                 }
//                 if (this.checkBox_cpapNoSupineRemObtained.Checked)
//                 {
//                     if (this.comboBox_cpapNoSupineRemObtained.Text != "")
//                         document.Text += "No supine/REM sleep obtained due to: "
//                             + this.comboBox_cpapNoSupineRemObtained.Text + ".\r\n";
//                     else
//                         document.Text += "No supine/REM sleep obtained.\r\n";
//                 }
//                 if (this.checkBox_cpapNoMinHrFinTx.Checked)
//                 {
//                     if (this.comboBox_cpapNoMinHrFinTx.Text != "")
//                         document.Text += "A minimum of 1 hour of sleep at final pressure is not documented due to: "
//                             + this.comboBox_cpapNoMinHrFinTx.Text + ".\r\n";
//                     else document.Text += "A minimum of 1 hour of sleep at final pressure is not obtained.\r\n";
//                 }
//                 if (this.checkBox_cpapRDInotLess5.Checked)
//                 {
//                     if (this.comboBox_cpapRDInotLess5.Text != "")
//                         document.Text += "AHI less than 5 events per hour was not achieved due to: "
//                             + this.comboBox_cpapRDInotLess5.Text + ".\r\n";
//                     else
//                         document.Text += "AHI less than 5 events per hour was not achieved.\r\n";
//                 }
//                 if (this.comboBox_cpapAHabolishedAt.Text != "")
//                     document.Text += "Apnea/Hypopnea abolished at " + comboBox_cpapAHabolishedAt.Text
//                         + " cm H2O.\r\n";
//                 if (this.comboBox_cpapSnoringAbolished.Text != "")
//                     document.Text += "Snoring abolished at " + comboBox_cpapSnoringAbolished.Text
//                         + " cm H2O. \r\n";
//             }
// 
//             if (this.checkedListBox_seciv.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rRespiratory Event Determination:\r\n";
//                 for (int i = 0; i <= checkedListBox_seciv.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_seciv.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
//             }
//             if (this.checkedListBox_secV.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rBiPAP Titration Polysomnogram:\r\nInitiate BiPAP at 8/4 cm H2O for initial titration; at patient's current home settings; or pressures specified by referring physician/Medical Director\r\n";
//                 for (int i = 0; i <= checkedListBox_secV.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secV.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
//                 if (this.checkBox_bipapNoSupineRemObtained.Checked)
//                 {
//                     if (this.comboBox_bipapNoSupineRemO.Text != "")
//                         document.Text += "No supine/REM sleep obtained due to: "
//                             + this.comboBox_bipapNoSupineRemO.Text + ".\r\n";
//                     else
//                         document.Text += "No supine/REM sleep obtained.\r\n";
//                 }
//                 if (this.checkBox_bipapNoMinHrFinTx.Checked)
//                 {
//                     if (this.comboBox_bipapNoMinHrFin.Text != "")
//                         document.Text += "A minimum of 1 hour of sleep at final pressure is not documented due to: "
//                             + this.comboBox_bipapNoMinHrFin.Text + ".\r\n";
//                     else document.Text += "A minimum of 1 hour of sleep at final pressure is not obtained.\r\n";
//                 }
//                 if (this.checkBox_bipapRDInotLess5.Checked)
//                 {
//                     if (this.comboBox_bipapRDInotLess.Text != "")
//                         document.Text += "AHI less than 5 events per hour was not achieved due to: "
//                             + this.comboBox_bipapRDInotLess.Text + ".\r\n";
//                     else
//                         document.Text += "AHI less than 5 events per hour was not achieved.\r\n";
//                 }
//                 if (this.comboBox_ipapAHAb.Text != "" && this.comboBox_epapAHAb.Text != "")
//                     document.Text += "Apnea/Hypopnea abolished at "
//                         + comboBox_ipapAHAb.Text + "/" + comboBox_epapAHAb.Text + " cm H2O.\r\n";
//                 if (this.comboBox_ipapSnorAb.Text != "" && this.comboBox_epapSnorAb.Text != "")
//                     document.Text += "Snoring abolished at "
//                         + comboBox_ipapSnorAb.Text + "/" + comboBox_epapSnorAb.Text + " cm H2O.\r\n";
// 
// 
//             }
//             if (this.checkedListBox_secV1.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rPost-Op Polysomnogram:\r\n";
//                 for (int i = 0; i <= checkedListBox_secV1.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secV1.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
// 
//             }
// 
//             if (this.checkedListBox_secVII.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rTreatment Intolerance:\r\n";
//                 for (int i = 0; i <= checkedListBox_secVII.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secVII.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
// 
//             }
//             if (this.checkedListBox_secVIII.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rSupplemental Oxygen:\r\n";
//                 for (int i = 0; i <= checkedListBox_secVIII.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secVIII.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
// 
//             }
// 
//             if (this.checkedListBox_secIX.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rEnd of Study:\r\n";
//                 for (int i = 0; i <= checkedListBox_secIX.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secIX.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
// 
//                 }
// 
//             }
// 
//             if (this.checkedListBox_secXX.CheckedItems.Count != 0)
//             {
//                 document.Text += "\rOral Appliance Protocol:\r\n";
//                 for (int i = 0; i <= checkedListBox_secXX.CheckedItems.Count - 1; i++)
//                 {
//                     //this.document.Text += checkedListBox_secII.CheckedItems[i].ToString() + "\r\n";
//                     string tempstr = "";
//                     tempstr = checkedListBox_secXX.CheckedItems[i].ToString() + "\r\n";
//                     if (tempstr.StartsWith("GOAL"))
//                         tempstr = tempstr.Remove(4, 2);
//                     this.document.Text += tempstr;
//                 }
// 
//                 if (this.checkBox_oralAppNoHrMin.Checked && this.comboBox_oralAppNoHrMin.Text != "")
//                     this.document.Text += "No minimum of one hour of sleep after final adjustment due to: "
//                         + this.comboBox_oralAppNoHrMin.Text + "\r";
//                 if (this.checkBox_oralAppNoRdiLess5.Checked && this.comboBox_oralAppNoHrMin.Text != "")
//                     this.document.Text += "AHI less than 5 events per hour is not achieved due to: "
//                         + this.comboBox_oralAppNoRdiLess5.Text + "\r";
//             }
//         }

        private static string GetProtocolTitle()
        {
            return "Saint Joseph's Hospital Sleep Disorders Center Clinical Polysomnographic Testing\r\n\r\n";
        }



        private void checkBox_abgMedDirCalled_CheckedChanged(object sender, System.EventArgs e)
        {
            this.textBox_abgInstructions.Visible = !this.textBox_abgInstructions.Visible;
        }

        private void textBox_abgInstructions_VisibleChanged(object sender, System.EventArgs e)
        {
            this.textBox_abgInstructions.Text = "";
        }
        private void checkBox_hasCpap_CheckedChanged(object sender, System.EventArgs e)
        {
            this.panel1.Visible = !this.panel1.Visible;
            this.checkBox_noCpapMac.Checked = !this.checkBox_hasCpap.Checked;
        }

        private void checkBox_noCpapMac_CheckedChanged(object sender, System.EventArgs e)
        {
            this.checkBox_hasCpap.Checked = !this.checkBox_noCpapMac.Checked;
        }

        private void checkBox_abgMedDirCalled_CheckedChanged_1(object sender, System.EventArgs e)
        {
            this.textBox_abgInstructions.Visible = !this.textBox_abgInstructions.Visible;
        }

        private void menuItem_studyInfo_Click(object sender, System.EventArgs e)
        {
            this.mTabControl.SelectedIndex = 0;
        }
        private void checkBox_ptArrivedOnO2_CheckedChanged(object sender, System.EventArgs e)
        {
            this.comboBox_lpm.Visible = !this.comboBox_lpm.Visible;
            this.comboBox_lpm.DroppedDown = this.comboBox_lpm.Visible;
        }

        private void radioButton_abgYes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton_abgYes.Checked)
                this.groupBox_COHB.Visible = true;
            else if (!this.radioButton_abgYes.Checked)
                this.groupBox_COHB.Visible = false;

        }

        private void radioButton_abgNo_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton_abgNo.Checked)
                this.groupBox_WhyNoAbg.Visible = true;
            else if (!this.radioButton_abgNo.Checked)
                this.groupBox_WhyNoAbg.Visible = false;

        }

        private void radioButton_COHbYes_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton_COHbYes.Checked)
                this.groupBox_NRB.Visible = true;
            else if (!this.radioButton_COHbYes.Checked)
                this.groupBox_NRB.Visible = false;

        }

        private void radioButton_NRBno_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton_NRBno.Checked)
                this.comboBox_no15Lpm.Visible = true;
            else if (!this.radioButton_NRBno.Checked)
                this.comboBox_no15Lpm.Visible = false;
        }

        private void groupBox_NRB_VisibleChanged(object sender, System.EventArgs e)
        {
            groupBox_NRB_Reset();
        }

        private void groupBox_NRB_Reset()
        {
            if (!this.groupBox_NRB.Visible)
            {
                this.comboBox_no15Lpm.Text = "Why not?";
                this.radioButton_NRBno.Checked = false;
                this.radioButton_NRByes.Checked = false;
            }
        }

        private void groupBox_COHB_VisibleChanged(object sender, System.EventArgs e)
        {
            this.groupBox_COHB_Reset();
            this.groupBox_NRB_Reset();

        }

        private void groupBox_COHB_Reset()
        {
            if (!this.groupBox_COHB.Visible)
            {
                this.radioButton_COHbYes.Checked = false;
                this.radioButton_COHbNo.Checked = false;
                this.textBox_abgInstructions.Text = "Instructions.";
                this.checkBox_abgMedDirCalled.Checked = false;
            }
        }



       
        private void menuItem1_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                int i = this.comboBox_TechName.Items.Add(tx.document.Text);
                sleepEdit.techList.Add((string)tx.document.Text);
                this.comboBox_TechName.SelectedIndex = i;
            }
        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                this.comboBox_TechName.Items.Remove(tx.document.Text);
                sleepEdit.techList.Remove((string)tx.document.Text);
            }

        }

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                int i = this.comboBox_maskType.Items.Add(tx.document.Text);
                sleepEdit.maskType.Add((string)tx.document.Text);
                this.comboBox_maskType.SelectedIndex = i;
            }
        }

        private void menuItem6_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                this.comboBox_maskType.Items.Remove(tx.document.Text);
                sleepEdit.maskType.Remove((string)tx.document.Text);
            }
        }

        private void menuItem11_Click(object sender, System.EventArgs e)
        {
            this.comboBox_maskType.Items.Clear();
            sleepEdit.maskType.Clear();
        }

        private void menuItem12_Click(object sender, System.EventArgs e)
        {
            this.comboBox_TechName.Items.Clear();
            sleepEdit.techList.Clear();

        }

        private void menuItem9_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                int i = this.comboBox_maskSize.Items.Add(tx.document.Text);
                sleepEdit.maskSize.Add((string)tx.document.Text);
                this.comboBox_maskSize.SelectedIndex = i;

            }


        }

        private void menuItem10_Click(object sender, System.EventArgs e)
        {
            textInput tx = new textInput();

            if (tx.ShowDialog() == DialogResult.OK)
            {
                this.comboBox_maskSize.Items.Remove(tx.document.Text);
                sleepEdit.maskSize.Remove((string)tx.document.Text);
            }

        }

        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            this.comboBox_maskSize.Items.Clear();
            sleepEdit.maskSize.Clear();

        }



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Protocol));
            this.mTabControl = new System.Windows.Forms.TabControl();
            this.StudyInfo = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_NRB = new System.Windows.Forms.GroupBox();
            this.comboBox_no15Lpm = new System.Windows.Forms.ComboBox();
            this.radioButton_NRBno = new System.Windows.Forms.RadioButton();
            this.radioButton_NRByes = new System.Windows.Forms.RadioButton();
            this.checkBox_ptSmokes = new System.Windows.Forms.CheckBox();
            this.groupBox_abg = new System.Windows.Forms.GroupBox();
            this.radioButton_abgNo = new System.Windows.Forms.RadioButton();
            this.radioButton_abgYes = new System.Windows.Forms.RadioButton();
            this.groupBox_WhyNoAbg = new System.Windows.Forms.GroupBox();
            this.comboBox_why_noabg = new System.Windows.Forms.ComboBox();
            this.groupBox_COHB = new System.Windows.Forms.GroupBox();
            this.radioButton_COHbNo = new System.Windows.Forms.RadioButton();
            this.radioButton_COHbYes = new System.Windows.Forms.RadioButton();
            this.checkBox_abgMedDirCalled = new System.Windows.Forms.CheckBox();
            this.textBox_abgInstructions = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ptName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox_oxygen = new System.Windows.Forms.GroupBox();
            this.comboBox_lpm = new System.Windows.Forms.ComboBox();
            this.checkBox_ptArrivedOnO2 = new System.Windows.Forms.CheckBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_TechName = new System.Windows.Forms.ComboBox();
            this.contextMenu_techName = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_nobringMac = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_txChangedTo = new System.Windows.Forms.ComboBox();
            this.comboBox_txVerifiedAT = new System.Windows.Forms.ComboBox();
            this.label_andChangedTo = new System.Windows.Forms.Label();
            this.label_pressVerified = new System.Windows.Forms.Label();
            this.checkBox_chinStrap = new System.Windows.Forms.CheckBox();
            this.checkBox_humidifer = new System.Windows.Forms.CheckBox();
            this.comboBox_maskSize = new System.Windows.Forms.ComboBox();
            this.contextMenu_maskSize = new System.Windows.Forms.ContextMenu();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.label_maskSize = new System.Windows.Forms.Label();
            this.label1_maskType = new System.Windows.Forms.Label();
            this.comboBox_maskType = new System.Windows.Forms.ComboBox();
            this.contextMenu_maskType = new System.Windows.Forms.ContextMenu();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.checkBox_hasCpap = new System.Windows.Forms.CheckBox();
            this.checkBox_noCpapMac = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_testordered = new System.Windows.Forms.ComboBox();
            this.document = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_noSupRem = new System.Windows.Forms.ComboBox();
            this.checkBox_noSupRemSleep = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox_cpapNoMinHrFinTx = new System.Windows.Forms.ComboBox();
            this.checkBox_cpapNoMinHrFinTx = new System.Windows.Forms.CheckBox();
            this.comboBox_cpapRDInotLess5 = new System.Windows.Forms.ComboBox();
            this.checkBox_cpapRDInotLess5 = new System.Windows.Forms.CheckBox();
            this.comboBox_cpapNoSupineRemObtained = new System.Windows.Forms.ComboBox();
            this.checkBox_cpapNoSupineRemObtained = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_cpapAHabolishedAt = new System.Windows.Forms.ComboBox();
            this.comboBox_cpapSnoringAbolished = new System.Windows.Forms.ComboBox();
            this.textBox_ahiNotlessThan5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_bipapNoSupineRemObtained = new System.Windows.Forms.CheckBox();
            this.comboBox_bipapNoMinHrFin = new System.Windows.Forms.ComboBox();
            this.checkBox_bipapNoMinHrFinTx = new System.Windows.Forms.CheckBox();
            this.comboBox_bipapRDInotLess = new System.Windows.Forms.ComboBox();
            this.comboBox_bipapNoSupineRemO = new System.Windows.Forms.ComboBox();
            this.checkBox_bipapRDInotLess5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label_slash2 = new System.Windows.Forms.Label();
            this.label_slash1 = new System.Windows.Forms.Label();
            this.comboBox_epapAHAb = new System.Windows.Forms.ComboBox();
            this.comboBox_epapSnorAb = new System.Windows.Forms.ComboBox();
            this.comboBox_ipapAHAb = new System.Windows.Forms.ComboBox();
            this.comboBox_ipapSnorAb = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBox_oralAppNoHrMin = new System.Windows.Forms.ComboBox();
            this.checkBox_oralAppNoHrMin = new System.Windows.Forms.CheckBox();
            this.comboBox_oralAppNoRdiLess5 = new System.Windows.Forms.ComboBox();
            this.checkBox_oralAppNoRdiLess5 = new System.Windows.Forms.CheckBox();
            this.checkedListBox_secXX = new System.Windows.Forms.CheckedListBox();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.mTabControl.SuspendLayout();
            this.StudyInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_NRB.SuspendLayout();
            this.groupBox_abg.SuspendLayout();
            this.groupBox_WhyNoAbg.SuspendLayout();
            this.groupBox_COHB.SuspendLayout();
            this.groupBox_oxygen.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabControl
            // 
            this.mTabControl.AllowDrop = true;
            this.mTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.mTabControl.Controls.Add(this.StudyInfo);
            this.mTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTabControl.Location = new System.Drawing.Point(0, 0);
            this.mTabControl.Multiline = true;
            this.mTabControl.Name = "mTabControl";
            this.mTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTabControl.SelectedIndex = 0;
            this.mTabControl.Size = new System.Drawing.Size(1278, 739);
            this.mTabControl.TabIndex = 0;
            // 
            // StudyInfo
            // 
            this.StudyInfo.AllowDrop = true;
            this.StudyInfo.AutoScroll = true;
            this.StudyInfo.BackColor = System.Drawing.SystemColors.Control;
            this.StudyInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudyInfo.Controls.Add(this.button3);
            this.StudyInfo.Controls.Add(this.groupBox3);
            this.StudyInfo.Controls.Add(this.label11);
            this.StudyInfo.Controls.Add(this.textBox_ptName);
            this.StudyInfo.Controls.Add(this.button1);
            this.StudyInfo.Controls.Add(this.groupBox_oxygen);
            this.StudyInfo.Controls.Add(this.button_OK);
            this.StudyInfo.Controls.Add(this.groupBox4);
            this.StudyInfo.Controls.Add(this.groupBox2);
            this.StudyInfo.Controls.Add(this.groupBox1);
            this.StudyInfo.Controls.Add(this.document);
            this.StudyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyInfo.Location = new System.Drawing.Point(4, 34);
            this.StudyInfo.Name = "StudyInfo";
            this.StudyInfo.Size = new System.Drawing.Size(1270, 701);
            this.StudyInfo.TabIndex = 0;
            this.StudyInfo.Text = "StudyInfo";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.groupBox_NRB);
            this.groupBox3.Controls.Add(this.groupBox_abg);
            this.groupBox3.Controls.Add(this.groupBox_WhyNoAbg);
            this.groupBox3.Controls.Add(this.groupBox_COHB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 229);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ABG\'s";
            // 
            // groupBox_NRB
            // 
            this.groupBox_NRB.AutoSize = true;
            this.groupBox_NRB.Controls.Add(this.comboBox_no15Lpm);
            this.groupBox_NRB.Controls.Add(this.radioButton_NRBno);
            this.groupBox_NRB.Controls.Add(this.radioButton_NRByes);
            this.groupBox_NRB.Controls.Add(this.checkBox_ptSmokes);
            this.groupBox_NRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_NRB.Location = new System.Drawing.Point(233, 26);
            this.groupBox_NRB.Name = "groupBox_NRB";
            this.groupBox_NRB.Size = new System.Drawing.Size(308, 117);
            this.groupBox_NRB.TabIndex = 13;
            this.groupBox_NRB.TabStop = false;
            this.groupBox_NRB.Text = "Patient placed on 15 lpm O2 via NRB mask?";
            this.groupBox_NRB.Visible = false;
            this.groupBox_NRB.VisibleChanged += new System.EventHandler(this.groupBox_NRB_VisibleChanged);
            // 
            // comboBox_no15Lpm
            // 
            this.comboBox_no15Lpm.AllowDrop = true;
            this.comboBox_no15Lpm.Items.AddRange(new object[] {
            "No ABG results prior to lights out",
            "PCO2 > 45"});
            this.comboBox_no15Lpm.Location = new System.Drawing.Point(7, 70);
            this.comboBox_no15Lpm.Name = "comboBox_no15Lpm";
            this.comboBox_no15Lpm.Size = new System.Drawing.Size(280, 25);
            this.comboBox_no15Lpm.TabIndex = 3;
            this.comboBox_no15Lpm.Text = "Why Not?";
            this.comboBox_no15Lpm.Visible = false;
            // 
            // radioButton_NRBno
            // 
            this.radioButton_NRBno.Location = new System.Drawing.Point(84, 38);
            this.radioButton_NRBno.Name = "radioButton_NRBno";
            this.radioButton_NRBno.Size = new System.Drawing.Size(70, 26);
            this.radioButton_NRBno.TabIndex = 2;
            this.radioButton_NRBno.Text = "NO";
            this.radioButton_NRBno.CheckedChanged += new System.EventHandler(this.radioButton_NRBno_CheckedChanged);
            // 
            // radioButton_NRByes
            // 
            this.radioButton_NRByes.Location = new System.Drawing.Point(7, 38);
            this.radioButton_NRByes.Name = "radioButton_NRByes";
            this.radioButton_NRByes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_NRByes.TabIndex = 1;
            this.radioButton_NRByes.Text = "YES";
            // 
            // checkBox_ptSmokes
            // 
            this.checkBox_ptSmokes.AutoSize = true;
            this.checkBox_ptSmokes.Location = new System.Drawing.Point(166, 42);
            this.checkBox_ptSmokes.Name = "checkBox_ptSmokes";
            this.checkBox_ptSmokes.Size = new System.Drawing.Size(102, 21);
            this.checkBox_ptSmokes.TabIndex = 14;
            this.checkBox_ptSmokes.Text = "Pt Smokes?";
            // 
            // groupBox_abg
            // 
            this.groupBox_abg.AutoSize = true;
            this.groupBox_abg.Controls.Add(this.radioButton_abgNo);
            this.groupBox_abg.Controls.Add(this.radioButton_abgYes);
            this.groupBox_abg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_abg.Location = new System.Drawing.Point(7, 26);
            this.groupBox_abg.Name = "groupBox_abg";
            this.groupBox_abg.Size = new System.Drawing.Size(91, 92);
            this.groupBox_abg.TabIndex = 11;
            this.groupBox_abg.TabStop = false;
            this.groupBox_abg.Text = "Obtained?";
            // 
            // radioButton_abgNo
            // 
            this.radioButton_abgNo.Location = new System.Drawing.Point(7, 45);
            this.radioButton_abgNo.Name = "radioButton_abgNo";
            this.radioButton_abgNo.Size = new System.Drawing.Size(70, 25);
            this.radioButton_abgNo.TabIndex = 1;
            this.radioButton_abgNo.Text = "NO";
            this.radioButton_abgNo.CheckedChanged += new System.EventHandler(this.radioButton_abgNo_CheckedChanged);
            // 
            // radioButton_abgYes
            // 
            this.radioButton_abgYes.Location = new System.Drawing.Point(7, 19);
            this.radioButton_abgYes.Name = "radioButton_abgYes";
            this.radioButton_abgYes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_abgYes.TabIndex = 0;
            this.radioButton_abgYes.Text = "YES";
            this.radioButton_abgYes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton_abgYes.CheckedChanged += new System.EventHandler(this.radioButton_abgYes_CheckedChanged);
            // 
            // groupBox_WhyNoAbg
            // 
            this.groupBox_WhyNoAbg.AutoSize = true;
            this.groupBox_WhyNoAbg.Controls.Add(this.comboBox_why_noabg);
            this.groupBox_WhyNoAbg.Location = new System.Drawing.Point(7, 134);
            this.groupBox_WhyNoAbg.Name = "groupBox_WhyNoAbg";
            this.groupBox_WhyNoAbg.Size = new System.Drawing.Size(189, 73);
            this.groupBox_WhyNoAbg.TabIndex = 15;
            this.groupBox_WhyNoAbg.TabStop = false;
            this.groupBox_WhyNoAbg.Text = "Why Not?";
            this.groupBox_WhyNoAbg.Visible = false;
            // 
            // comboBox_why_noabg
            // 
            this.comboBox_why_noabg.Items.AddRange(new object[] {
            "The patient refused.",
            "The patient is a minor.",
            "Per doctor\'s orders.",
            "Patient has recent results.",
            "Unable to obtain."});
            this.comboBox_why_noabg.Location = new System.Drawing.Point(7, 26);
            this.comboBox_why_noabg.Name = "comboBox_why_noabg";
            this.comboBox_why_noabg.Size = new System.Drawing.Size(173, 25);
            this.comboBox_why_noabg.TabIndex = 5;
            // 
            // groupBox_COHB
            // 
            this.groupBox_COHB.AutoSize = true;
            this.groupBox_COHB.Controls.Add(this.radioButton_COHbNo);
            this.groupBox_COHB.Controls.Add(this.radioButton_COHbYes);
            this.groupBox_COHB.Controls.Add(this.checkBox_abgMedDirCalled);
            this.groupBox_COHB.Controls.Add(this.textBox_abgInstructions);
            this.groupBox_COHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_COHB.Location = new System.Drawing.Point(107, 30);
            this.groupBox_COHB.Name = "groupBox_COHB";
            this.groupBox_COHB.Size = new System.Drawing.Size(440, 171);
            this.groupBox_COHB.TabIndex = 12;
            this.groupBox_COHB.TabStop = false;
            this.groupBox_COHB.Text = "COHb > 3?";
            this.groupBox_COHB.Visible = false;
            this.groupBox_COHB.VisibleChanged += new System.EventHandler(this.groupBox_COHB_VisibleChanged);
            // 
            // radioButton_COHbNo
            // 
            this.radioButton_COHbNo.Location = new System.Drawing.Point(14, 45);
            this.radioButton_COHbNo.Name = "radioButton_COHbNo";
            this.radioButton_COHbNo.Size = new System.Drawing.Size(70, 25);
            this.radioButton_COHbNo.TabIndex = 3;
            this.radioButton_COHbNo.Text = "NO";
            // 
            // radioButton_COHbYes
            // 
            this.radioButton_COHbYes.Location = new System.Drawing.Point(14, 16);
            this.radioButton_COHbYes.Name = "radioButton_COHbYes";
            this.radioButton_COHbYes.Size = new System.Drawing.Size(70, 26);
            this.radioButton_COHbYes.TabIndex = 2;
            this.radioButton_COHbYes.Text = "YES";
            this.radioButton_COHbYes.CheckedChanged += new System.EventHandler(this.radioButton_COHbYes_CheckedChanged);
            // 
            // checkBox_abgMedDirCalled
            // 
            this.checkBox_abgMedDirCalled.Location = new System.Drawing.Point(14, 70);
            this.checkBox_abgMedDirCalled.Name = "checkBox_abgMedDirCalled";
            this.checkBox_abgMedDirCalled.Size = new System.Drawing.Size(287, 39);
            this.checkBox_abgMedDirCalled.TabIndex = 7;
            this.checkBox_abgMedDirCalled.Text = "Medical Director contacted regarding?";
            // 
            // textBox_abgInstructions
            // 
            this.textBox_abgInstructions.AllowDrop = true;
            this.textBox_abgInstructions.Location = new System.Drawing.Point(77, 123);
            this.textBox_abgInstructions.Multiline = true;
            this.textBox_abgInstructions.Name = "textBox_abgInstructions";
            this.textBox_abgInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_abgInstructions.Size = new System.Drawing.Size(357, 26);
            this.textBox_abgInstructions.TabIndex = 8;
            this.textBox_abgInstructions.Text = "Instructions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(385, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Patient Name";
            // 
            // textBox_ptName
            // 
            this.textBox_ptName.Location = new System.Drawing.Point(385, 51);
            this.textBox_ptName.Name = "textBox_ptName";
            this.textBox_ptName.Size = new System.Drawing.Size(224, 23);
            this.textBox_ptName.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(623, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 84);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox_oxygen
            // 
            this.groupBox_oxygen.AutoSize = true;
            this.groupBox_oxygen.Controls.Add(this.comboBox_lpm);
            this.groupBox_oxygen.Controls.Add(this.checkBox_ptArrivedOnO2);
            this.groupBox_oxygen.Location = new System.Drawing.Point(14, 401);
            this.groupBox_oxygen.Name = "groupBox_oxygen";
            this.groupBox_oxygen.Size = new System.Drawing.Size(336, 109);
            this.groupBox_oxygen.TabIndex = 11;
            this.groupBox_oxygen.TabStop = false;
            this.groupBox_oxygen.Text = "Oxygen Info";
            // 
            // comboBox_lpm
            // 
            this.comboBox_lpm.Items.AddRange(new object[] {
            "1 lpm O2",
            "1.5 lpm O2",
            "2 lpm O2",
            "2.5 lpm O2",
            "3 lpm O2",
            "3.5 lpm O2",
            "4 lpm O2",
            "other"});
            this.comboBox_lpm.Location = new System.Drawing.Point(14, 58);
            this.comboBox_lpm.Name = "comboBox_lpm";
            this.comboBox_lpm.Size = new System.Drawing.Size(106, 25);
            this.comboBox_lpm.TabIndex = 1;
            this.comboBox_lpm.Text = "2 lpm O2";
            this.comboBox_lpm.Visible = false;
            // 
            // checkBox_ptArrivedOnO2
            // 
            this.checkBox_ptArrivedOnO2.AutoSize = true;
            this.checkBox_ptArrivedOnO2.Location = new System.Drawing.Point(14, 26);
            this.checkBox_ptArrivedOnO2.Name = "checkBox_ptArrivedOnO2";
            this.checkBox_ptArrivedOnO2.Size = new System.Drawing.Size(140, 21);
            this.checkBox_ptArrivedOnO2.TabIndex = 0;
            this.checkBox_ptArrivedOnO2.Text = "Pt Arrived on O2?";
            this.checkBox_ptArrivedOnO2.CheckedChanged += new System.EventHandler(this.checkBox_ptArrivedOnO2_CheckedChanged);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(840, 390);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(161, 84);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.maskedTextBox1);
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.comboBox_TechName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(14, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 128);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(218, 48);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(8, 23);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(105, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBox_TechName
            // 
            this.comboBox_TechName.AllowDrop = true;
            this.comboBox_TechName.ContextMenu = this.contextMenu_techName;
            this.comboBox_TechName.Location = new System.Drawing.Point(126, 16);
            this.comboBox_TechName.Name = "comboBox_TechName";
            this.comboBox_TechName.Size = new System.Drawing.Size(175, 25);
            this.comboBox_TechName.Sorted = true;
            this.comboBox_TechName.TabIndex = 13;
            // 
            // contextMenu_techName
            // 
            this.contextMenu_techName.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.menuItem12});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Add Name";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Remove Name";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 2;
            this.menuItem12.Text = "Clear List";
            this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date of Study:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Technician:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.checkBox_nobringMac);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.checkBox_chinStrap);
            this.groupBox2.Controls.Add(this.checkBox_humidifer);
            this.groupBox2.Controls.Add(this.comboBox_maskSize);
            this.groupBox2.Controls.Add(this.label_maskSize);
            this.groupBox2.Controls.Add(this.label1_maskType);
            this.groupBox2.Controls.Add(this.comboBox_maskType);
            this.groupBox2.Controls.Add(this.checkBox_hasCpap);
            this.groupBox2.Controls.Add(this.checkBox_noCpapMac);
            this.groupBox2.Location = new System.Drawing.Point(599, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 247);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPAP/BiPAP Info";
            // 
            // checkBox_nobringMac
            // 
            this.checkBox_nobringMac.AutoSize = true;
            this.checkBox_nobringMac.Location = new System.Drawing.Point(308, 19);
            this.checkBox_nobringMac.Name = "checkBox_nobringMac";
            this.checkBox_nobringMac.Size = new System.Drawing.Size(246, 21);
            this.checkBox_nobringMac.TabIndex = 70;
            this.checkBox_nobringMac.Text = "Pt has machine but did not bring it.";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.comboBox_txChangedTo);
            this.panel1.Controls.Add(this.comboBox_txVerifiedAT);
            this.panel1.Controls.Add(this.label_andChangedTo);
            this.panel1.Controls.Add(this.label_pressVerified);
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 39);
            this.panel1.TabIndex = 69;
            this.panel1.Visible = false;
            // 
            // comboBox_txChangedTo
            // 
            this.comboBox_txChangedTo.Location = new System.Drawing.Point(329, 6);
            this.comboBox_txChangedTo.Name = "comboBox_txChangedTo";
            this.comboBox_txChangedTo.Size = new System.Drawing.Size(63, 25);
            this.comboBox_txChangedTo.TabIndex = 66;
            // 
            // comboBox_txVerifiedAT
            // 
            this.comboBox_txVerifiedAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_txVerifiedAT.ItemHeight = 17;
            this.comboBox_txVerifiedAT.Location = new System.Drawing.Point(147, 6);
            this.comboBox_txVerifiedAT.Name = "comboBox_txVerifiedAT";
            this.comboBox_txVerifiedAT.Size = new System.Drawing.Size(56, 25);
            this.comboBox_txVerifiedAT.TabIndex = 65;
            // 
            // label_andChangedTo
            // 
            this.label_andChangedTo.Location = new System.Drawing.Point(217, 6);
            this.label_andChangedTo.Name = "label_andChangedTo";
            this.label_andChangedTo.Size = new System.Drawing.Size(112, 19);
            this.label_andChangedTo.TabIndex = 64;
            this.label_andChangedTo.Text = "and changed to";
            // 
            // label_pressVerified
            // 
            this.label_pressVerified.Location = new System.Drawing.Point(7, 6);
            this.label_pressVerified.Name = "label_pressVerified";
            this.label_pressVerified.Size = new System.Drawing.Size(140, 19);
            this.label_pressVerified.TabIndex = 63;
            this.label_pressVerified.Text = "Pressure verified at";
            // 
            // checkBox_chinStrap
            // 
            this.checkBox_chinStrap.AutoSize = true;
            this.checkBox_chinStrap.Location = new System.Drawing.Point(200, 197);
            this.checkBox_chinStrap.Name = "checkBox_chinStrap";
            this.checkBox_chinStrap.Size = new System.Drawing.Size(101, 21);
            this.checkBox_chinStrap.TabIndex = 68;
            this.checkBox_chinStrap.Text = "Chin Strap?";
            // 
            // checkBox_humidifer
            // 
            this.checkBox_humidifer.AutoSize = true;
            this.checkBox_humidifer.Location = new System.Drawing.Point(18, 197);
            this.checkBox_humidifer.Name = "checkBox_humidifer";
            this.checkBox_humidifer.Size = new System.Drawing.Size(140, 21);
            this.checkBox_humidifer.TabIndex = 67;
            this.checkBox_humidifer.Text = "Heated Humidifier";
            // 
            // comboBox_maskSize
            // 
            this.comboBox_maskSize.ContextMenu = this.contextMenu_maskSize;
            this.comboBox_maskSize.Location = new System.Drawing.Point(245, 160);
            this.comboBox_maskSize.Name = "comboBox_maskSize";
            this.comboBox_maskSize.Size = new System.Drawing.Size(147, 25);
            this.comboBox_maskSize.TabIndex = 66;
            // 
            // contextMenu_maskSize
            // 
            this.contextMenu_maskSize.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.menuItem13});
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "Add Size";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "Remove Size";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 2;
            this.menuItem13.Text = "Clear List";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // label_maskSize
            // 
            this.label_maskSize.AutoSize = true;
            this.label_maskSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_maskSize.Location = new System.Drawing.Point(245, 136);
            this.label_maskSize.Name = "label_maskSize";
            this.label_maskSize.Size = new System.Drawing.Size(72, 17);
            this.label_maskSize.TabIndex = 65;
            this.label_maskSize.Text = "Mask Size";
            // 
            // label1_maskType
            // 
            this.label1_maskType.AutoSize = true;
            this.label1_maskType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_maskType.Location = new System.Drawing.Point(10, 137);
            this.label1_maskType.Name = "label1_maskType";
            this.label1_maskType.Size = new System.Drawing.Size(76, 16);
            this.label1_maskType.TabIndex = 64;
            this.label1_maskType.Text = "Mask Style";
            // 
            // comboBox_maskType
            // 
            this.comboBox_maskType.ContextMenu = this.contextMenu_maskType;
            this.comboBox_maskType.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_maskType.Location = new System.Drawing.Point(14, 160);
            this.comboBox_maskType.Name = "comboBox_maskType";
            this.comboBox_maskType.Size = new System.Drawing.Size(217, 24);
            this.comboBox_maskType.Sorted = true;
            this.comboBox_maskType.TabIndex = 63;
            // 
            // contextMenu_maskType
            // 
            this.contextMenu_maskType.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem6,
            this.menuItem11});
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Add Mask";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.Text = "Remove Mask";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "Clear List";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // checkBox_hasCpap
            // 
            this.checkBox_hasCpap.AutoSize = true;
            this.checkBox_hasCpap.Location = new System.Drawing.Point(14, 58);
            this.checkBox_hasCpap.Name = "checkBox_hasCpap";
            this.checkBox_hasCpap.Size = new System.Drawing.Size(247, 21);
            this.checkBox_hasCpap.TabIndex = 58;
            this.checkBox_hasCpap.Text = "Pt has and brought a CPAP/BiPAP.";
            this.checkBox_hasCpap.CheckedChanged += new System.EventHandler(this.checkBox_hasCpap_CheckedChanged);
            // 
            // checkBox_noCpapMac
            // 
            this.checkBox_noCpapMac.AutoSize = true;
            this.checkBox_noCpapMac.Location = new System.Drawing.Point(14, 26);
            this.checkBox_noCpapMac.Name = "checkBox_noCpapMac";
            this.checkBox_noCpapMac.Size = new System.Drawing.Size(260, 21);
            this.checkBox_noCpapMac.TabIndex = 57;
            this.checkBox_noCpapMac.Text = "Pt does not have a CPAP/BiPAP unit.";
            this.checkBox_noCpapMac.CheckedChanged += new System.EventHandler(this.checkBox_noCpapMac_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBox_testordered);
            this.groupBox1.Location = new System.Drawing.Point(637, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Ordered (Please Indicate and start at specified section)";
            // 
            // comboBox_testordered
            // 
            this.comboBox_testordered.AllowDrop = true;
            this.comboBox_testordered.Items.AddRange(new object[] {
            "PSG",
            "Split Study",
            "CPAP Study",
            "BIPAP Study",
            "Post-Op Study",
            "Oral Appliance"});
            this.comboBox_testordered.Location = new System.Drawing.Point(14, 32);
            this.comboBox_testordered.Name = "comboBox_testordered";
            this.comboBox_testordered.Size = new System.Drawing.Size(217, 25);
            this.comboBox_testordered.TabIndex = 0;
            // 
            // document
            // 
            this.document.Location = new System.Drawing.Point(392, 109);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(133, 38);
            this.document.TabIndex = 1;
            this.document.Text = "";
            this.document.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.comboBox_noSupRem);
            this.panel3.Controls.Add(this.checkBox_noSupRemSleep);
            this.panel3.Location = new System.Drawing.Point(14, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 102);
            this.panel3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(14, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "WHY?";
            // 
            // comboBox_noSupRem
            // 
            this.comboBox_noSupRem.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_noSupRem.Location = new System.Drawing.Point(14, 70);
            this.comboBox_noSupRem.Name = "comboBox_noSupRem";
            this.comboBox_noSupRem.Size = new System.Drawing.Size(217, 21);
            this.comboBox_noSupRem.TabIndex = 1;
            // 
            // checkBox_noSupRemSleep
            // 
            this.checkBox_noSupRemSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_noSupRemSleep.Location = new System.Drawing.Point(0, 0);
            this.checkBox_noSupRemSleep.Name = "checkBox_noSupRemSleep";
            this.checkBox_noSupRemSleep.Size = new System.Drawing.Size(280, 26);
            this.checkBox_noSupRemSleep.TabIndex = 0;
            this.checkBox_noSupRemSleep.Text = "No Supine/REM Sleep";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1270, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diagnostic Polysomnogram";
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1270, 26);
            this.label16.TabIndex = 0;
            this.label16.Text = "Split Night Polysomnogram";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBox_cpapNoMinHrFinTx);
            this.groupBox6.Controls.Add(this.checkBox_cpapNoMinHrFinTx);
            this.groupBox6.Controls.Add(this.comboBox_cpapRDInotLess5);
            this.groupBox6.Controls.Add(this.checkBox_cpapRDInotLess5);
            this.groupBox6.Controls.Add(this.comboBox_cpapNoSupineRemObtained);
            this.groupBox6.Controls.Add(this.checkBox_cpapNoSupineRemObtained);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.comboBox_cpapAHabolishedAt);
            this.groupBox6.Controls.Add(this.comboBox_cpapSnoringAbolished);
            this.groupBox6.Location = new System.Drawing.Point(7, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(987, 224);
            this.groupBox6.TabIndex = 97;
            this.groupBox6.TabStop = false;
            // 
            // comboBox_cpapNoMinHrFinTx
            // 
            this.comboBox_cpapNoMinHrFinTx.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_cpapNoMinHrFinTx.Location = new System.Drawing.Point(693, 134);
            this.comboBox_cpapNoMinHrFinTx.Name = "comboBox_cpapNoMinHrFinTx";
            this.comboBox_cpapNoMinHrFinTx.Size = new System.Drawing.Size(182, 21);
            this.comboBox_cpapNoMinHrFinTx.TabIndex = 55;
            // 
            // checkBox_cpapNoMinHrFinTx
            // 
            this.checkBox_cpapNoMinHrFinTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cpapNoMinHrFinTx.Location = new System.Drawing.Point(350, 122);
            this.checkBox_cpapNoMinHrFinTx.Name = "checkBox_cpapNoMinHrFinTx";
            this.checkBox_cpapNoMinHrFinTx.Size = new System.Drawing.Size(336, 44);
            this.checkBox_cpapNoMinHrFinTx.TabIndex = 54;
            this.checkBox_cpapNoMinHrFinTx.Text = "No hour minimum documented at final pressure, Why?";
            // 
            // comboBox_cpapRDInotLess5
            // 
            this.comboBox_cpapRDInotLess5.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_cpapRDInotLess5.Location = new System.Drawing.Point(693, 77);
            this.comboBox_cpapRDInotLess5.Name = "comboBox_cpapRDInotLess5";
            this.comboBox_cpapRDInotLess5.Size = new System.Drawing.Size(182, 21);
            this.comboBox_cpapRDInotLess5.TabIndex = 53;
            // 
            // checkBox_cpapRDInotLess5
            // 
            this.checkBox_cpapRDInotLess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cpapRDInotLess5.Location = new System.Drawing.Point(350, 64);
            this.checkBox_cpapRDInotLess5.Name = "checkBox_cpapRDInotLess5";
            this.checkBox_cpapRDInotLess5.Size = new System.Drawing.Size(336, 45);
            this.checkBox_cpapRDInotLess5.TabIndex = 52;
            this.checkBox_cpapRDInotLess5.Text = "AHI Not less than 5 events per hour, Why?";
            // 
            // comboBox_cpapNoSupineRemObtained
            // 
            this.comboBox_cpapNoSupineRemObtained.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_cpapNoSupineRemObtained.Location = new System.Drawing.Point(693, 32);
            this.comboBox_cpapNoSupineRemObtained.Name = "comboBox_cpapNoSupineRemObtained";
            this.comboBox_cpapNoSupineRemObtained.Size = new System.Drawing.Size(182, 21);
            this.comboBox_cpapNoSupineRemObtained.TabIndex = 51;
            // 
            // checkBox_cpapNoSupineRemObtained
            // 
            this.checkBox_cpapNoSupineRemObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_cpapNoSupineRemObtained.Location = new System.Drawing.Point(350, 32);
            this.checkBox_cpapNoSupineRemObtained.Name = "checkBox_cpapNoSupineRemObtained";
            this.checkBox_cpapNoSupineRemObtained.Size = new System.Drawing.Size(336, 26);
            this.checkBox_cpapNoSupineRemObtained.TabIndex = 50;
            this.checkBox_cpapNoSupineRemObtained.Text = "No Supine Sleep Obtained, Why?";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "A/H Abolished at:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(217, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "Snoring Abolished at:";
            // 
            // comboBox_cpapAHabolishedAt
            // 
            this.comboBox_cpapAHabolishedAt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cpapAHabolishedAt.Location = new System.Drawing.Point(266, 70);
            this.comboBox_cpapAHabolishedAt.MaxDropDownItems = 5;
            this.comboBox_cpapAHabolishedAt.Name = "comboBox_cpapAHabolishedAt";
            this.comboBox_cpapAHabolishedAt.Size = new System.Drawing.Size(56, 25);
            this.comboBox_cpapAHabolishedAt.TabIndex = 30;
            // 
            // comboBox_cpapSnoringAbolished
            // 
            this.comboBox_cpapSnoringAbolished.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_cpapSnoringAbolished.Location = new System.Drawing.Point(266, 32);
            this.comboBox_cpapSnoringAbolished.MaxDropDownItems = 5;
            this.comboBox_cpapSnoringAbolished.Name = "comboBox_cpapSnoringAbolished";
            this.comboBox_cpapSnoringAbolished.Size = new System.Drawing.Size(56, 25);
            this.comboBox_cpapSnoringAbolished.TabIndex = 29;
            // 
            // textBox_ahiNotlessThan5
            // 
            this.textBox_ahiNotlessThan5.AllowDrop = true;
            this.textBox_ahiNotlessThan5.Location = new System.Drawing.Point(483, 333);
            this.textBox_ahiNotlessThan5.Multiline = true;
            this.textBox_ahiNotlessThan5.Name = "textBox_ahiNotlessThan5";
            this.textBox_ahiNotlessThan5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ahiNotlessThan5.Size = new System.Drawing.Size(140, 25);
            this.textBox_ahiNotlessThan5.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1270, 51);
            this.label5.TabIndex = 0;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label33
            // 
            this.label33.Dock = System.Windows.Forms.DockStyle.Top;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(1270, 45);
            this.label33.TabIndex = 1;
            this.label33.Text = "Section IV – Respiratory Event Determination: continue through determinations unt" +
                "il Section III (CPAP)/Section V (BiPAP) goals are achieved.";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.checkBox_bipapNoSupineRemObtained);
            this.groupBox5.Controls.Add(this.comboBox_bipapNoMinHrFin);
            this.groupBox5.Controls.Add(this.checkBox_bipapNoMinHrFinTx);
            this.groupBox5.Controls.Add(this.comboBox_bipapRDInotLess);
            this.groupBox5.Controls.Add(this.comboBox_bipapNoSupineRemO);
            this.groupBox5.Controls.Add(this.checkBox_bipapRDInotLess5);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.label_slash2);
            this.groupBox5.Controls.Add(this.label_slash1);
            this.groupBox5.Controls.Add(this.comboBox_epapAHAb);
            this.groupBox5.Controls.Add(this.comboBox_epapSnorAb);
            this.groupBox5.Controls.Add(this.comboBox_ipapAHAb);
            this.groupBox5.Controls.Add(this.comboBox_ipapSnorAb);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(14, 339);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(973, 205);
            this.groupBox5.TabIndex = 96;
            this.groupBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "A/H Abolished at:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 32);
            this.label7.TabIndex = 61;
            this.label7.Text = "Snoring Abolished at:";
            // 
            // checkBox_bipapNoSupineRemObtained
            // 
            this.checkBox_bipapNoSupineRemObtained.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bipapNoSupineRemObtained.Location = new System.Drawing.Point(385, 19);
            this.checkBox_bipapNoSupineRemObtained.Name = "checkBox_bipapNoSupineRemObtained";
            this.checkBox_bipapNoSupineRemObtained.Size = new System.Drawing.Size(336, 26);
            this.checkBox_bipapNoSupineRemObtained.TabIndex = 60;
            this.checkBox_bipapNoSupineRemObtained.Text = "No Supine Sleep Obtained, Why?";
            // 
            // comboBox_bipapNoMinHrFin
            // 
            this.comboBox_bipapNoMinHrFin.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_bipapNoMinHrFin.Location = new System.Drawing.Point(728, 134);
            this.comboBox_bipapNoMinHrFin.Name = "comboBox_bipapNoMinHrFin";
            this.comboBox_bipapNoMinHrFin.Size = new System.Drawing.Size(182, 21);
            this.comboBox_bipapNoMinHrFin.TabIndex = 59;
            // 
            // checkBox_bipapNoMinHrFinTx
            // 
            this.checkBox_bipapNoMinHrFinTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bipapNoMinHrFinTx.Location = new System.Drawing.Point(385, 122);
            this.checkBox_bipapNoMinHrFinTx.Name = "checkBox_bipapNoMinHrFinTx";
            this.checkBox_bipapNoMinHrFinTx.Size = new System.Drawing.Size(336, 44);
            this.checkBox_bipapNoMinHrFinTx.TabIndex = 58;
            this.checkBox_bipapNoMinHrFinTx.Text = "No hour minimum documented at final pressure, Why?";
            // 
            // comboBox_bipapRDInotLess
            // 
            this.comboBox_bipapRDInotLess.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_bipapRDInotLess.Location = new System.Drawing.Point(728, 77);
            this.comboBox_bipapRDInotLess.Name = "comboBox_bipapRDInotLess";
            this.comboBox_bipapRDInotLess.Size = new System.Drawing.Size(182, 21);
            this.comboBox_bipapRDInotLess.TabIndex = 57;
            // 
            // comboBox_bipapNoSupineRemO
            // 
            this.comboBox_bipapNoSupineRemO.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_bipapNoSupineRemO.Location = new System.Drawing.Point(728, 19);
            this.comboBox_bipapNoSupineRemO.Name = "comboBox_bipapNoSupineRemO";
            this.comboBox_bipapNoSupineRemO.Size = new System.Drawing.Size(182, 21);
            this.comboBox_bipapNoSupineRemO.TabIndex = 49;
            // 
            // checkBox_bipapRDInotLess5
            // 
            this.checkBox_bipapRDInotLess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_bipapRDInotLess5.Location = new System.Drawing.Point(385, 64);
            this.checkBox_bipapRDInotLess5.Name = "checkBox_bipapRDInotLess5";
            this.checkBox_bipapRDInotLess5.Size = new System.Drawing.Size(336, 45);
            this.checkBox_bipapRDInotLess5.TabIndex = 48;
            this.checkBox_bipapRDInotLess5.Text = "AHI Not less than 5 events per hour, Why?";
            // 
            // checkBox3
            // 
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(385, -176);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(336, 50);
            this.checkBox3.TabIndex = 46;
            this.checkBox3.Text = "No Supine Sleep Obtained, Why?";
            // 
            // label_slash2
            // 
            this.label_slash2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slash2.Location = new System.Drawing.Point(301, 77);
            this.label_slash2.Name = "label_slash2";
            this.label_slash2.Size = new System.Drawing.Size(7, 19);
            this.label_slash2.TabIndex = 43;
            this.label_slash2.Text = "/";
            this.label_slash2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_slash1
            // 
            this.label_slash1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slash1.Location = new System.Drawing.Point(301, 38);
            this.label_slash1.Name = "label_slash1";
            this.label_slash1.Size = new System.Drawing.Size(7, 20);
            this.label_slash1.TabIndex = 42;
            this.label_slash1.Text = "/";
            this.label_slash1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_epapAHAb
            // 
            this.comboBox_epapAHAb.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_epapAHAb.Location = new System.Drawing.Point(315, 77);
            this.comboBox_epapAHAb.MaxDropDownItems = 25;
            this.comboBox_epapAHAb.Name = "comboBox_epapAHAb";
            this.comboBox_epapAHAb.Size = new System.Drawing.Size(56, 25);
            this.comboBox_epapAHAb.TabIndex = 41;
            // 
            // comboBox_epapSnorAb
            // 
            this.comboBox_epapSnorAb.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_epapSnorAb.Location = new System.Drawing.Point(315, 32);
            this.comboBox_epapSnorAb.MaxDropDownItems = 25;
            this.comboBox_epapSnorAb.Name = "comboBox_epapSnorAb";
            this.comboBox_epapSnorAb.Size = new System.Drawing.Size(56, 25);
            this.comboBox_epapSnorAb.TabIndex = 40;
            // 
            // comboBox_ipapAHAb
            // 
            this.comboBox_ipapAHAb.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ipapAHAb.Location = new System.Drawing.Point(245, 77);
            this.comboBox_ipapAHAb.MaxDropDownItems = 25;
            this.comboBox_ipapAHAb.Name = "comboBox_ipapAHAb";
            this.comboBox_ipapAHAb.Size = new System.Drawing.Size(56, 25);
            this.comboBox_ipapAHAb.TabIndex = 39;
            // 
            // comboBox_ipapSnorAb
            // 
            this.comboBox_ipapSnorAb.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ipapSnorAb.Location = new System.Drawing.Point(245, 32);
            this.comboBox_ipapSnorAb.MaxDropDownItems = 25;
            this.comboBox_ipapSnorAb.Name = "comboBox_ipapSnorAb";
            this.comboBox_ipapSnorAb.Size = new System.Drawing.Size(56, 25);
            this.comboBox_ipapSnorAb.TabIndex = 38;
            // 
            // label32
            // 
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(1270, 45);
            this.label32.TabIndex = 94;
            this.label32.Text = "Section V      BiPAP Titration Polysomnogram:  Initiate BiPAP at 8/4 cm H2O for i" +
                "nitial titration; at patient’s current home settings; or pressures specified by " +
                "referring physician/Medical Director";
            // 
            // label37
            // 
            this.label37.Dock = System.Windows.Forms.DockStyle.Top;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(1270, 19);
            this.label37.TabIndex = 0;
            this.label37.Text = "Supplemental Oxygen";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 83);
            this.button2.TabIndex = 11;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label36
            // 
            this.label36.Dock = System.Windows.Forms.DockStyle.Top;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1270, 32);
            this.label36.TabIndex = 0;
            this.label36.Text = "CPAP/BiPAP Failure";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(329, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 96);
            this.label2.TabIndex = 0;
            this.label2.Text = "Obtain and complete vent protocol (separate sheet)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBox_oralAppNoHrMin);
            this.groupBox7.Controls.Add(this.checkBox_oralAppNoHrMin);
            this.groupBox7.Controls.Add(this.comboBox_oralAppNoRdiLess5);
            this.groupBox7.Controls.Add(this.checkBox_oralAppNoRdiLess5);
            this.groupBox7.Location = new System.Drawing.Point(14, 250);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(987, 224);
            this.groupBox7.TabIndex = 98;
            this.groupBox7.TabStop = false;
            // 
            // comboBox_oralAppNoHrMin
            // 
            this.comboBox_oralAppNoHrMin.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_oralAppNoHrMin.Location = new System.Drawing.Point(371, 109);
            this.comboBox_oralAppNoHrMin.Name = "comboBox_oralAppNoHrMin";
            this.comboBox_oralAppNoHrMin.Size = new System.Drawing.Size(182, 21);
            this.comboBox_oralAppNoHrMin.TabIndex = 55;
            // 
            // checkBox_oralAppNoHrMin
            // 
            this.checkBox_oralAppNoHrMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_oralAppNoHrMin.Location = new System.Drawing.Point(28, 96);
            this.checkBox_oralAppNoHrMin.Name = "checkBox_oralAppNoHrMin";
            this.checkBox_oralAppNoHrMin.Size = new System.Drawing.Size(336, 45);
            this.checkBox_oralAppNoHrMin.TabIndex = 54;
            this.checkBox_oralAppNoHrMin.Text = "No hour minimum documented at final adjustment,  Why?";
            // 
            // comboBox_oralAppNoRdiLess5
            // 
            this.comboBox_oralAppNoRdiLess5.Items.AddRange(new object[] {
            "Other"});
            this.comboBox_oralAppNoRdiLess5.Location = new System.Drawing.Point(371, 51);
            this.comboBox_oralAppNoRdiLess5.Name = "comboBox_oralAppNoRdiLess5";
            this.comboBox_oralAppNoRdiLess5.Size = new System.Drawing.Size(182, 21);
            this.comboBox_oralAppNoRdiLess5.TabIndex = 53;
            // 
            // checkBox_oralAppNoRdiLess5
            // 
            this.checkBox_oralAppNoRdiLess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_oralAppNoRdiLess5.Location = new System.Drawing.Point(28, 38);
            this.checkBox_oralAppNoRdiLess5.Name = "checkBox_oralAppNoRdiLess5";
            this.checkBox_oralAppNoRdiLess5.Size = new System.Drawing.Size(336, 45);
            this.checkBox_oralAppNoRdiLess5.TabIndex = 52;
            this.checkBox_oralAppNoRdiLess5.Text = "AHI Not less than 5 events per hour, Why?";
            // 
            // checkedListBox_secXX
            // 
            this.checkedListBox_secXX.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_secXX.CheckOnClick = true;
            this.checkedListBox_secXX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_secXX.Items.AddRange(new object[] {
            "If non-adjustable device -GOTO Split Night Protocol.",
            "If adjustable device, monitor for 30 minutes of SLEEP.\t",
            "If AHI is greater than 5:",
            "\tWake patient and request they make 2 TURNS of the screw.",
            "\tIf 3 TURNS have been performed or patient begins to complain of pain -GOTO CPAP " +
                "Titration.",
            "GOAL 1: Minimum of 1 hour of sleep documented at final adjustment.",
            "GOAL 2: AHI less than 5 events per hour achieved.",
            "GOAL 3: SaO2 baseline is maintained above 90%.",
            "GOAL 4: All goals complete -GOTO End of Study."});
            this.checkedListBox_secXX.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox_secXX.Name = "checkedListBox_secXX";
            this.checkedListBox_secXX.Size = new System.Drawing.Size(1270, 668);
            this.checkedListBox_secXX.TabIndex = 0;
            // 
            // menuItem7
            // 
            this.menuItem7.Index = -1;
            this.menuItem7.Text = "Add Mask";
            // 
            // menuItem8
            // 
            this.menuItem8.Index = -1;
            this.menuItem8.Text = "Remove Mask";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Protocol
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
            this.ClientSize = new System.Drawing.Size(1278, 739);
            this.Controls.Add(this.mTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Protocol";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mTabControl.ResumeLayout(false);
            this.StudyInfo.ResumeLayout(false);
            this.StudyInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_NRB.ResumeLayout(false);
            this.groupBox_NRB.PerformLayout();
            this.groupBox_abg.ResumeLayout(false);
            this.groupBox_WhyNoAbg.ResumeLayout(false);
            this.groupBox_COHB.ResumeLayout(false);
            this.groupBox_COHB.PerformLayout();
            this.groupBox_oxygen.ResumeLayout(false);
            this.groupBox_oxygen.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private static object[] GetTxValues() //99999
        {
            return new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"};
        }
        #endregion

//         private void mTabControl_SelectedIndexChanged(object sender, EventArgs e)
//         {
//             TabControl tc = (TabControl)sender;
//             TabPage tp = (TabPage) tc.Controls[tc.SelectedIndex];
//             if (tp.Controls.Count>0)
//             {
//                 FlowLayoutPanel panel = (FlowLayoutPanel)tp.Controls.Find("FlowLayout", false)[0];
//                 this.SuspendLayout();
//                 panel.SuspendLayout();
//                 panel.PerformLayout();
//                 panel.ResumeLayout(false);
//                 this.ResumeLayout(false);
//             }
//             
//         }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(i.ToString());
        }

    }
}
