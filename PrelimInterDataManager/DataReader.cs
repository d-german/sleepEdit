using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace PrelimInterDataManager
{
    public class DataReader
    {

        private DataReader() { }

        public static void readData(string dataFileName, ref List<string> results)
        {
            XmlReader reader = getReader(dataFileName);

            while (reader.Read())
            {
                if (reader.LocalName.Equals("Result"))
                {
                    reader.Read(); // Read the start tag.
                    string value = reader.ReadString().Trim() + " ";
                    results.Add(value);
                }
            }
        }

        private static XmlReader getReader(string dataFileName)
        {
            XmlReader reader;
            XmlReaderSettings settings = new XmlReaderSettings();
            string path = Application.StartupPath + @"\preliminary_interpretation_xml_data\" + dataFileName;   
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            try
            {
                reader = XmlReader.Create(path, settings);
            }
            catch
            {
                MessageBox.Show(path + " not found, will uses system default instead");
                throw new FileNotFoundException();
            }
            return reader;
        }     


        public static void readData(string dataFileName, ref List<PrelimInterDataElement> list)
        {
            XmlReader reader = getReader(dataFileName);           
            List<Tag> tags = null;            
            reader.ReadToFollowing("Default");
            reader.MoveToElement();

            while (reader.Read())
            {
                if (reader.HasAttributes)
                {
                    tags = new List<Tag>();
                    while (reader.MoveToNextAttribute())
                    {                        
                        tags.Add(new Tag(reader.Name, reader.Value));
                    }

                    // Move the reader back to the element node.
                    reader.MoveToElement();
                }

                if (reader.LocalName.Equals("Result"))
                {
                    reader.Read(); // Read the start tag.
                    list.Add(new PrelimInterDataElement(tags, reader.ReadString().Trim() + " "));
                }
                
                if (tags != null)
                {
	                tags.Clear();
	                tags = null;
                }
            }
        }
    }
}
