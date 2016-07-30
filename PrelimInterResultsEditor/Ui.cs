using System.Collections.Generic;
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
            var mDataList = new List<PrelimInterDataElement>();
            var pathIn =
                @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\defaultSleepArch.xml";
            //string pathOut = @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\test.xml";
            DataReader.readData(pathIn, ref mDataList);
            foreach (var e in mDataList)
            {
                var text = "";
                foreach (var tag in e.Tags)
                {
                    text += " " + tag.Name + " " + tag.Value;
                }
                var c = new TreeNode(e.Result);
                var tn = new TreeNode(text);

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