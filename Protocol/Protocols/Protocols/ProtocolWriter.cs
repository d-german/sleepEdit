using System.Xml;

namespace Protocols
{
    public class ProtocolWriter
    {
        private readonly ProtocolNode mTreeNode;

        private readonly XmlTextWriter mWriter;


        public ProtocolWriter(ProtocolNode node, string path)
        {
            mTreeNode = node;

            mWriter = new XmlTextWriter( /*@"F:\protocol_idtest.xml"*/path, null);
            writeProtocol();
        }

        private void writeProtocol()
        {
            mWriter.WriteStartDocument();
            mWriter.WriteStartElement("Protocol");

            writeNode(mTreeNode);

            foreach (ProtocolNode node in mTreeNode.Nodes)
            {
                mWriter.WriteStartElement("Section");

                if (node.Nodes.Count > 0)
                {
                    _writeNode(node);
                }
                else
                {
                    writeNode(node);
                }

                mWriter.WriteEndElement(); //section
            }

            mWriter.WriteEndElement(); //"Protocol"
            mWriter.WriteEndDocument();
            mWriter.Flush();
            mWriter.Close();
        }

        private void _writeNode(ProtocolNode node)
        {
            if (node != null)
            {
                writeNode(node);

                if (node.Nodes.Count > 0)
                {
                    foreach (ProtocolNode cur in node.Nodes)
                    {
                        mWriter.WriteStartElement("SubSection");
                        _writeNode(cur);
                        mWriter.WriteEndElement();
                    }
                }
            }
        }

        private void writeNode(ProtocolNode node)
        {
            mWriter.WriteStartElement("Id");
            mWriter.WriteValue(node.Id);
            mWriter.WriteEndElement();

            mWriter.WriteStartElement("LinkId");
            mWriter.WriteValue(node.LinkId);
            mWriter.WriteEndElement();

            mWriter.WriteStartElement("LinkText");
            mWriter.WriteValue(node.LinkText);
            mWriter.WriteEndElement();

            mWriter.WriteStartElement("text");
            mWriter.WriteValue(node.Element.Text != null ? node.Element.Text : "empty");
            mWriter.WriteEndElement();

            if (node.Element.SubTextList.Count > 0)
            {
                foreach (var str in node.Element.SubTextList)
                {
                    mWriter.WriteStartElement("SubText");
                    mWriter.WriteValue(str);
                    mWriter.WriteEndElement();
                }
            }
        }
    }
}