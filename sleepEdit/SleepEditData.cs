using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace sleepEditPro
{
    public class SleepEditData
    {
        public SleepEditData()
        { }


        private List<string> mTechNames = new List<string>();
        public List<string> TechNames
        {
            get { return mTechNames; }
            set { mTechNames = value; }
        }
        private List<string> mMaskTypes = new List<string>();
        public List<string> MaskStyles
        {
            get { return mMaskTypes; }
            set { mMaskTypes = value; }
        }
        private List<string> mMaskSizes = new List<string>();
        public List<string> MaskSizes
        {
            get { return mMaskSizes; }
            set { mMaskSizes = value; }
        }

    }

    public class SleepEditDataManager
    {

        /// <summary>
        /// Default constructor that uses Application.StartupPath + @"\data files\sleepEditData.xml"
        /// </summary>
        /// <returns></returns>
        public SleepEditDataManager()
        {           
            getData();            
        }


        static public string mPath = System.Windows.Forms.Application.StartupPath + @"\data files\sleepEditData.xml";

        private void testData()
        {
            mData.TechNames.Add("Damon German, BS, RPSGT");
            mData.TechNames.Add("Rosanna German. RPSGT");

            mData.MaskSizes.Add("small");
            mData.MaskSizes.Add("medium");
            mData.MaskSizes.Add("large");

            mData.MaskStyles.Add("Respironics Comfort Select");
            mData.MaskStyles.Add("F&P Flexifit HC407");

           
        }


        public static bool isValidPath(string path)
        {
            TextReader streamReader = null;
            try
            {
                using (streamReader = new StreamReader(path))
                {
                    streamReader.Close();
                    return true;
                }

            }
            catch
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                return false;

            }
        }

        private SleepEditData mData = new SleepEditData();
        public SleepEditData Data
        {
            get { return mData; }
        }

        public void saveData()
        {
            writeData();
        }


        private void getData()
        {
        Here:
            try
            {
                SleepEditDataReader reader = new SleepEditDataReader(mPath, mData);
            }
            catch 
            {
                saveData();
                goto Here;
            }

        }

        private void writeData()
        {
            SleepEditDataWriter writer = new SleepEditDataWriter(mPath, mData);
        }
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class SleepEditDataWriter
    {
        private XmlTextWriter mWriter;
        private SleepEditData mData;
        public SleepEditDataWriter(string path, SleepEditData data)
        {           
            mWriter = new XmlTextWriter(path, null);
            mData = data;


            mWriter.WriteStartDocument();

            mWriter.WriteStartElement("sleepEditData");


            mWriter.WriteStartElement("TechNames");
            foreach (string techName in mData.TechNames)
            {
                mWriter.WriteStartElement("name");
                mWriter.WriteValue(techName);
                mWriter.WriteEndElement();
            }
            mWriter.WriteEndElement();


            mWriter.WriteStartElement("MaskStyles");
            foreach (string maskStyle in mData.MaskStyles)
            {
                mWriter.WriteStartElement("maskStyle");
                mWriter.WriteValue(maskStyle);
                mWriter.WriteEndElement();
            }
            mWriter.WriteEndElement();


            mWriter.WriteStartElement("MaskSizes");
            foreach (string maskSize in mData.MaskSizes)
            {
                mWriter.WriteStartElement("maskSize");
                mWriter.WriteValue(maskSize);
                mWriter.WriteEndElement();
            }
            mWriter.WriteEndElement();

            mWriter.WriteEndElement();
            mWriter.WriteEndDocument();
            mWriter.Flush();
            mWriter.Close();
        }
    }


    /// <summary>
    /// ////////////////////////////////////////////////////////////////////
    /// </summary>
    public class SleepEditDataReader
    {
        XmlReaderSettings mSettings = new XmlReaderSettings();
        private XmlReader reader;

        public SleepEditDataReader(string path, SleepEditData data)
        {
            mSettings.IgnoreWhitespace = true;
            mSettings.IgnoreComments = true;
            reader = XmlReader.Create(path, mSettings);


            reader.ReadToFollowing("name");
            if (reader.LocalName.Equals("name"))
            {
                data.TechNames.Add(reader.ReadString());
                reader.Read();
                while (reader.LocalName.Equals("name"))
                {
                    data.TechNames.Add(reader.ReadString());
                    reader.Read();
                }
            }

            reader.ReadToFollowing("maskStyle");
            if (reader.LocalName.Equals("maskStyle"))
            {
                data.MaskStyles.Add(reader.ReadString());
                reader.Read();
                while (reader.LocalName.Equals("maskStyle"))
                {
                    data.MaskStyles.Add(reader.ReadString());
                    reader.Read();
                }
            }

            reader.ReadToFollowing("maskSize");
            if (reader.LocalName.Equals("maskSize"))
            {
                data.MaskSizes.Add(reader.ReadString());
                reader.Read();
                while (reader.LocalName.Equals("maskSize"))
                {
                    data.MaskSizes.Add(reader.ReadString());
                    reader.Read();
                }
            }

            reader.Close();            

        }

    }

}
