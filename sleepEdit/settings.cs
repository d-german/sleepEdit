using System;
using System.IO;
using System.Runtime.Serialization;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;


namespace sleepEditPro
{
	/// <summary>
	/// Summary description for settings.
	/// </summary>
	/// 
	[Serializable]
	public class settings
	{
		public string medListFileName ="";
		public string prelimIntFileName ="";
		public string workDirPath = "";
        public string protocolTitle = ""; //99999
        public string protocalPath = "";
        public string sleepEditDataPath = "";
		public ArrayList techList = new ArrayList(); 
		public ArrayList maskType = new ArrayList();
		public ArrayList maskSize = new ArrayList();

		
		public settings()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
