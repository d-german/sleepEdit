using System;
using System.Windows.Forms;
using Protocols;

namespace sleepEdit
{
    public partial class ProtocolNodeUi : UserControl
    {
        private bool mIsSection;

        public ProtocolNodeUi(ProtocolNode node)
        {
            ProtocolNode = node;
            InitializeComponent();
            Id = ProtocolNode.Id;
            Depth = ProtocolNode.Level;
            mDepthlabel.Width = ProtocolNode.Level*30;
            if (ProtocolNode.Element.Text.Length > 0)
            {
                CheckBox.Text = ProtocolNode.Element.Text;
            }
            else if (ProtocolNode.LinkText.Length > 0)
            {
                CheckBox.Text = "    ";
            }

            if (ProtocolNode.LinkText.Length > 0)
            {
                LinkLabel.Text = ProtocolNode.LinkText;
                LinkLabel.Tag = ProtocolNode.LinkId;
            }
            else
            {
                LinkLabel.Visible = false;
            }
            if (ProtocolNode.Element.SubTextList.Count > 0)
            {
                foreach (var str in ProtocolNode.Element.SubTextList)
                {
                    mComboBox.Items.Add(str);
                }
            }
            else
            {
                mComboBox.Visible = false;
            }

            CheckBox.CheckedChanged += mCheckBox_CheckedChanged;
            ProtocolNode.CheckMeEvent += checkMe;
        }

        public bool IsSection
        {
            get { return ProtocolNode.IsSection; }
        }

        public bool Checked { get; set; }

        public int Id { get; }

        public int Depth { get; }

        public override string Text
        {
            get { return getText(); }
        }

        public CheckBox CheckBox { get; set; }

        public LinkLabel LinkLabel { get; set; }

        public ProtocolNode ProtocolNode { get; }

        public void checkMe(bool isChecked)
        {
            if (Checked == false)
            {
                CheckBox.Checked = isChecked;
                Checked = isChecked;
            }
        }

        private string getText()
        {
            return ProtocolNode.Element.Text + " " + mComboBox.Text + " " + ProtocolNode.LinkText;
        }

        private void mCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Checked = CheckBox.Checked;
            if (ProtocolNode.Parent != null)
            {
                var parentNode = (ProtocolNode) ProtocolNode.Parent;
                parentNode.emitCheckMeEvent(Checked);
            }
        }
    }
}