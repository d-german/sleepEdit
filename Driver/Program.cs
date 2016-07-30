using System.Configuration;

namespace Driver
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 155.4);
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 155.5, 29.5, 62.5, 11.1, "BIPAP", "10/5 cm H2O");
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 62.5, 11.1, "oxygen", "2.0 lpm O2");
            // 
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 155.4);
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 155.5, 29.5, 62.5, 11.1, "BIPAP", "10/5 cm H2O");
            //             TSTbodyPos comment = new TSTbodyPos(389.5, 62.5, 11.1, "oxygen", "2.0 lpm O2");
//             Random randObj = new Random();
//             double tst, supine;
//             StreamWriter writer = new StreamWriter(@"C:\Documents and Settings\Administrator\Desktop\out.txt", true);
//             for (int i = 0; i < 5000; i++)
//             {
//                 tst = randObj.Next(30, 1000) + randObj.NextDouble();
//                 supine = randObj.Next(0, (int)tst) + randObj.NextDouble();
//                 TSTbodyPos comment = new TSTbodyPos(tst, supine);
//                 // TSTbodyPos comment = new TSTbodyPos(389.5, 155.5, 29.5, 62.5, 11.1, "BIPAP", "10/5 cm H2O");
//                 // TSTbodyPos comment = new TSTbodyPos(389.5, 62.5, 11.1, "oxygen", "2.0 lpm O2");
// 
//                 writer.WriteLine(tst.ToString("###.##"));
//                 writer.WriteLine(supine.ToString("###.##"));
//                 writer.WriteLine(comment.Result);
//                 writer.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
//             }
//             writer.Close();


//             SleepAnalysisResultsDefault dd = new SleepAnalysisResultsDefault();
//             dd.printDefaultResults();

// 
//             List<PrelimInterDataElement> mDataList = new List<PrelimInterDataElement>();
//             string pathIn = @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\defaultSleepArch.xml";
//             string pathOut = @"H:\old_disk\sleepEdit_\sleepEdit\bin\Debug\preliminary_interpretation_xml_data\test.xml";
//             DataReader.readData(pathIn, ref mDataList);
//             DataWriter.writeData(mDataList, pathOut); 

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("Address", "3711 Fremont");
            config.Save();
        }
    }
}