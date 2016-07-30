using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Protocols
{
    public delegate void CheckMeEventHandler(bool isChecked);

    public class ProtocolNode : TreeNode
    {
        public ProtocolNode(string text)
            : base(text)
        {
            Text = text.Length > 64 ? text.Remove(32) : text;
            Element.Text = text;
        }

        public ProtocolNode()
        {
        }

        public string LinkText { get; set; } = "";

        public int Id { get; set; } = -1;

        public int LinkId { get; set; } = -1;

        public bool IsProtocol { get; set; } = false;

        public bool IsSection { get; set; }

        public Element Element { get; set; } = new Element();

        public event CheckMeEventHandler CheckMeEvent;

        public void emitCheckMeEvent(bool isChecked)
        {
            var handler = CheckMeEvent;
            if (handler != null)
            {
                handler(isChecked);
            }
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
            var tab = "";

            for (var i = 0; i < node.Level; i++)
            {
                tab += "\t";
            }
            Console.WriteLine(tab + node.Element.Text);

            foreach (var subString in node.Element.SubTextList)
            {
                Console.WriteLine(tab + subString);
            }
        }

        public override object Clone()
        {
            var cloneNode = new ProtocolNode();

            if (Nodes.Count > 0)
            {
                foreach (ProtocolNode node in Nodes)
                {
                    cloneNode.Nodes.Add(node.Clone() as ProtocolNode);
                }
            }
            cloneNode.Text = Text;
            cloneNode.IsSection = IsSection;
            cloneNode.Element = Element;
            cloneNode.Tag = Tag;
            cloneNode.Id = Id;
            cloneNode.LinkId = LinkId;
            cloneNode.LinkText = LinkText;

            return cloneNode;
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public class Element
    {
        public string Text { get; set; } = " ";

        public List<string> SubTextList { get; set; } = new List<string>();
    }
}