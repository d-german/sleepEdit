using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Protocols
{


    public class ProtocolReader
    {
        private ProtocolNode mProtocolNode;
        private XmlReader mReader;
        private XmlReader mSubReader;
        XmlReaderSettings mSettings = new XmlReaderSettings();
        private string mPath;

        public ProtocolReader(ProtocolNode node, string path)
        {
            mProtocolNode = node;
            mPath = path;
            ReadTree();
        }

        private void ReadTree()
        {
            mSettings.IgnoreWhitespace = true;
            mSettings.IgnoreComments = true;
            mReader = XmlReader.Create(mPath, mSettings);
            mSubReader = XmlReader.Create(mPath, mSettings);
            ProtocolNode sectionNode;

            mProtocolNode.IsProtocol = true;
            mSubReader.ReadToFollowing("text");
            readTextNode(mSubReader, mProtocolNode);

            while (mReader.Read())
            {
                if (isSection(mReader))
                {
                    XmlReader secReader = mReader.ReadSubtree();

                    sectionNode = getNode();
                    sectionNode.IsSection = true;

                    // printNode(mReader);

                    mProtocolNode.Nodes.Add(sectionNode);
                    ReadNode(mSubReader, sectionNode);
                    _processSubNodes(secReader, mSubReader, mProtocolNode, sectionNode);
                }
            }

            mReader.Close();
            mSubReader.Close();
        }

        private void _processSubNodes(XmlReader reader, XmlReader dataReader, ProtocolNode parentNode, ProtocolNode childNode)
        {
            if (reader.ReadToDescendant("SubSection"))
            {
                // printNode(reader);
                ProtocolNode descendantNode = getNode();
                ReadNode(dataReader, descendantNode);
                childNode.Nodes.Add(descendantNode);
                _processSubNodes(reader, dataReader, childNode, descendantNode);
            }
            if (reader.ReadToNextSibling("SubSection"))
            {
                //printNode(reader);
                ProtocolNode siblingNode = getNode();
                ReadNode(dataReader, siblingNode);
                parentNode.Nodes.Add(siblingNode);
                _processSubNodes(reader, dataReader, parentNode, siblingNode);
            }
        }

        private void ReadNode(XmlReader reader, ProtocolNode node)
        {
            reader.ReadToFollowing("Id");

            if (reader.LocalName.Equals("Id"))
            {
	            int id = int.Parse(reader.ReadString());
                if (id == -1)
                {
                    id = UniqueId.GetId();
                    node.Id = id;
                } else {
                    node.Id = id;
                }
                
	            reader.Read();
            }

            if (reader.LocalName.Equals("LinkId"))
            {
                node.LinkId = int.Parse(reader.ReadString());
                reader.Read();
            }

            if (reader.LocalName.Equals("LinkText"))
            {
                node.LinkText = reader.ReadString();
                reader.Read();
            }
            
            readTextNode(reader, node);

            if (reader.LocalName.Equals("SubText"))
            {
                node.Element.SubTextList.Add(reader.ReadString());
                reader.Read();
                while (reader.LocalName.Equals("SubText"))
                {
                    node.Element.SubTextList.Add(reader.ReadString());
                    reader.Read();
                }
            }

        }

        private static void readTextNode(XmlReader reader, ProtocolNode node)
        {
            if (reader.LocalName.Equals("text"))
            {
                node.Element.Text = reader.ReadString();
                node.Text = node.Element.Text.Length > 32 ? node.Element.Text.Remove(32) + "...." : node.Element.Text;
                reader.Read();
            }
        }
        private bool isSection(XmlReader reader)
        {
            return reader.NodeType == XmlNodeType.Element && reader.LocalName.Equals("Section");
        }

        private ProtocolNode getNode()
        {
            ProtocolNode node = new ProtocolNode();
            return node;
        }

        private void PrintNode(XmlReader reader)
        {
            string str = "";
            for (int i = 0; i < reader.Depth; i++)
            {
                str += "\t";
            }
            System.Console.WriteLine(
                str +
                reader.NodeType.ToString()
                + " "
                + reader.LocalName.ToString()
                + " "
                + reader.Value.ToString()
                + " Depth: "
                + mReader.Depth.ToString()
                );
        }
    };
}
