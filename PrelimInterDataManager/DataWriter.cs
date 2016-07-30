using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PrelimInterDataManager
{
    public class DataWriter
    {

        private DataWriter() { }
        public static void writeData(List<PrelimInterDataElement> list, string path)
        {
            XmlTextWriter writer = new XmlTextWriter(path, null);

            writer.WriteStartDocument();
            writer.WriteStartElement("Default");



            foreach (PrelimInterDataElement e in list)
            {
                writer.WriteStartElement("Result");

                foreach (Tag tag in e.Tags)
                {
                    writer.WriteAttributeString(tag.Name, tag.Value);
                }


                writer.WriteValue(e.Result);

                writer.WriteEndElement(); //"Result"
            }



            writer.WriteEndElement();//"Default"
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }
    }
}
