using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PrelimInterDataManager;

namespace PrelimInterResultsEditor
{
    public partial class Ui : Form
    {
        public Ui()
        {
            InitializeComponent();

            populatePanel();
        }

        private void populatePanel()
        {
            List<PrelimInterDataElement> mDataList = new List<PrelimInterDataElement>();
            string pathIn = @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\defaultSleepArch.xml";
            //string pathOut = @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\test.xml";
            DataReader.readData(pathIn, ref mDataList);
            foreach (PrelimInterDataElement e in mDataList)
            {
                

                string text ="";
                foreach (Tag tag in e.Tags)
                {
                    text += " " + tag.Name + " " + tag.Value;
                }
                TreeNode c = new TreeNode(e.Result);
                TreeNode tn = new TreeNode(text);
                
                tn.Nodes.Add(c);
                mTreeView.Nodes.Add(tn);

            }
        }

        private void mTreeView_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (mTreeView.SelectedNode.Text.Contains("value"))
            {
                mTreeView.LabelEdit = false;
            }
            else
            {
                mTreeView.LabelEdit = true;
            }
        }
    }
}