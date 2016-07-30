using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace sleepEditPro
{
    public class SleepEditData
    {
        public List<string> TechNames { get; set; } = new List<string>();

        public List<string> MaskStyles { get; set; } = new List<string>();

        public List<string> MaskSizes { get; set; } = new List<string>();
    }

    public class SleepEditDataManager
    {
        public static string mPath = Application.StartupPath + @"\data files\sleepEditData.xml";

        /// <summary>
        ///     Default constructor that uses Application.StartupPath + @"\data files\sleepEditData.xml"
        /// </summary>
        /// <returns></returns>
        public SleepEditDataManager()
        {
            getData();
        }

        public SleepEditData Data { get; } = new SleepEditData();

        private void testData()
        {
            Data.TechNames.Add("Damon German, BS, RPSGT");
            Data.TechNames.Add("Rosanna German. RPSGT");

            Data.MaskSizes.Add("small");
            Data.MaskSizes.Add("medium");
            Data.MaskSizes.Add("large");

            Data.MaskStyles.Add("Respironics Comfort Select");
            Data.MaskStyles.Add("F&P Flexifit HC407");
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

        public void saveData()
        {
            writeData();
        }


        private void getData()
        {
            Here:
            try
            {
                var reader = new SleepEditDataReader(mPath, Data);
            }
            catch
            {
                saveData();
                goto Here;
            }
        }

        private void writeData()
        {
            var writer = new SleepEditDataWriter(mPath, Data);
        }
    }

    /// <summary>
    ///     ////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    public class SleepEditDataWriter
    {
        private readonly SleepEditData mData;
        private readonly XmlTextWriter mWriter;

        public SleepEditDataWriter(string path, SleepEditData data)
        {
            mWriter = new XmlTextWriter(path, null);
            mData = data;


            mWriter.WriteStartDocument();

            mWriter.WriteStartElement("sleepEditData");


            mWriter.WriteStartElement("TechNames");
            foreach (var techName in mData.TechNames)
            {
                mWriter.WriteStartElement("name");
                mWriter.WriteValue(techName);
                mWriter.WriteEndElement();
            }
            mWriter.WriteEndElement();


            mWriter.WriteStartElement("MaskStyles");
            foreach (var maskStyle in mData.MaskStyles)
            {
                mWriter.WriteStartElement("maskStyle");
                mWriter.WriteValue(maskStyle);
                mWriter.WriteEndElement();
            }
            mWriter.WriteEndElement();


            mWriter.WriteStartElement("MaskSizes");
            foreach (var maskSize in mData.MaskSizes)
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
    ///     ////////////////////////////////////////////////////////////////////
    /// </summary>
    public class SleepEditDataReader
    {
        private readonly XmlReaderSettings mSettings = new XmlReaderSettings();
        private readonly XmlReader reader;

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