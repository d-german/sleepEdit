using System;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
    public delegate void CheckMeEventHandler(bool isChecked);

    public class ProtocolNode : System.Windows.Forms.TreeNode
    {
        public event CheckMeEventHandler CheckMeEvent;

        public void emitCheckMeEvent(bool isChecked)
        {
            CheckMeEventHandler handler = CheckMeEvent;
            if (handler != null)
            {
                handler(isChecked);
            }

        }

        public ProtocolNode(string text)
            : base(text)
        {
            this.Text = text.Length > 64 ? text.Remove(32) : text;
            mElement.Text = text;
        }
        public ProtocolNode()
        {

        }

        private int mId = -1;
        private int mLinkId = -1;
        private string mLinkText = "";
        public string LinkText
        {
            get { return mLinkText; }
            set { mLinkText = value; }
        }
        private Element mElement = new Element();
        private bool mIsSection = false;
        private bool mIsProtocol = false;
        public int Id
        {
            get { return mId; }
            set { mId = value; }
        }
        public int LinkId
        {
            get { return mLinkId; }
            set { mLinkId = value; }
        }
        public bool IsProtocol
        {
            get { return mIsProtocol; }
            set { mIsProtocol = value; }
        }

        public bool IsSection
        {
            get { return mIsSection; }
            set { mIsSection = value; }
        }
        public Protocols.Element Element
        {
            get { return mElement; }
            set { mElement = value; }
        }

        public void _print(ProtocolNode node)
        {
            foreach (ProtocolNode n in node.Nodes)
            {
                print(n);
                _print(n);
            }
        }

        private void print(ProtocolNode node)
        {

            string tab = "";

            for (int i = 0; i < node.Level; i++)
            {
                tab += "\t";
            }
            System.Console.WriteLine(tab + node.Element.Text);

            foreach (string subString in node.Element.SubTextList)
            {
                System.Console.WriteLine(tab + subString);
            }
        }

        public override object Clone()
        {
            ProtocolNode cloneNode = new ProtocolNode();

            if (this.Nodes.Count > 0)
            {
                foreach (ProtocolNode node in this.Nodes)
                {
                    cloneNode.Nodes.Add(node.Clone() as ProtocolNode);
                }
            }
            cloneNode.Text = this.Text;
            cloneNode.IsSection = this.IsSection;
            cloneNode.Element = this.Element;
            cloneNode.Tag = this.Tag;
            cloneNode.mId = this.mId;
            cloneNode.mLinkId = this.mLinkId;
            cloneNode.mLinkText = this.mLinkText;

            return cloneNode;

        }
    };

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Element
    {
        private List<string> mSubTextList = new List<string>();

        private string mText = " ";
        public string Text
        {
            get { return mText; }
            set { mText = value; }
        }
        public List<string> SubTextList
        {
            get { return mSubTextList; }
            set { mSubTextList = value; }
        }
    };
}
