using System;
using System.Collections;
//using System.Runtime.Serialization.Formatters.Soap;


namespace sleepEditPro
{
    /// <summary>
    ///     Summary description for settings.
    /// </summary>
    [Serializable]
    public class settings
    {
        public ArrayList maskSize = new ArrayList();
        public ArrayList maskType = new ArrayList();
        public string medListFileName = "";
        public string prelimIntFileName = "";
        public string protocalPath = "";
        public string protocolTitle = ""; //99999
        public string sleepEditDataPath = "";
        public ArrayList techList = new ArrayList();
        public string workDirPath = "";
    }
}