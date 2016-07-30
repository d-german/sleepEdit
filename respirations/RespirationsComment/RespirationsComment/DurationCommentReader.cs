using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;


namespace RespirationsComment
{
    public class DurationCommentReader
    {
        private readonly List<String> mResults = new List<string>();

        public List<String> Results
        {
            get { return mResults; }
        }

        private XmlReader mReader;
        XmlReaderSettings mSettings = new XmlReaderSettings();
        private string mPath; // Application.StartupPath + @"\preliminary_interpretation_xml_data\defaultSleepArch.xml";


        public DurationCommentReader(String path)
        {
            mPath = path;

            mSettings.IgnoreWhitespace = true;
            mSettings.IgnoreComments = true;
            mReader = XmlReader.Create(mPath, mSettings);
            int index = 0;

            while (mReader.Read())
            {
                if (mReader.IsStartElement())
                {
                    mReader.Read(); // Read the start tag.
                    string value = mReader.ReadString().Trim();
                    mResults.Insert(index, value);
                    index++;
                }
            }

        }
    }
}
