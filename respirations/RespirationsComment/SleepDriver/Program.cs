using RespirationsComment;
using System.IO;
using System.Xml;
using System;


namespace SleepDriver
{
    class Program
    {
        public void main()
        {
        	
        	Program.testRespirations();
//            string[] results = new string[6];
//
//            int resultCount = 0;
//            XmlReaderSettings settings = new XmlReaderSettings();
//            NameTable nt = new NameTable();
//            
//            object value = nt.Add("value");
//            settings.NameTable = nt;
//            settings.IgnoreWhitespace = true;
//            settings.IgnoreComments = true;
//            string file = @"C:\Documents and Settings\Damon German\Desktop\Respirations\RespirationsComment\RespirationsComment\bin\Release\normalSeveritrDiag.xml";
//            using (XmlReader reader = XmlReader.Create(file, settings))
//            {
//                while (reader.Read())
//                {
//                    
//                    if (reader.NodeType == XmlNodeType.Element
//                            && value.Equals(reader.LocalName))
//                    {
//                        results[resultCount] = (string)reader.ReadElementContentAsString();
//                        resultCount++;
//                    }
//                }
//
//                foreach (string str in results)
//                {
//                    System.Console.WriteLine(str);
//                }
//            }
        }
        static void Main(string[] args)
        {
           // testRespirations();
            Program pro = new Program();
            pro.main();
            
        }

        private static void testRespirations()
        {
            TextWriter tw = new StreamWriter("Out.doc");
            Random num = new Random();
            string str = "";
            float totalSleepTime = 0.0f;
            float supineSleepTime = 0.0f;
            float lateralSleepTime = 0.0f;
            float remSleepTime = 0.0f;

            float totalRdi = 0.0f;
            float supineRdi = 0.0f;
            float lateralRdi = 0.0f;
            float remRdi = 0.0f;

            float lowestSao2 = 0.0f;

            int txInt;

            string type = "CPAP";

            for (int i = 0; i < 5; i++)
            {
                totalSleepTime = num.Next(50, 500);
                supineSleepTime = num.Next(0, 100);
                lateralSleepTime = 10;//num.Next(0, 100);
                remSleepTime = num.Next(0, 100);

                totalRdi = num.Next(0, 10);
                supineRdi = 50;//num.Next(0, 25);
                lateralRdi = 15;//num.Next(0, 5);
                remRdi = num.Next(0, 25);
                lowestSao2 = num.Next(85, 95);
                txInt = num.Next(5, 35);
                str = "TST: " + totalSleepTime.ToString() + "\r\n"
                + "Supine Time: " + supineSleepTime.ToString() + "\r\n"
                + "Lateral Time: " + lateralSleepTime.ToString() + "\r\n"
                + "REM Time: " + remSleepTime.ToString() + "\r\n"
                + "Total RDI: " + totalRdi.ToString() + "\r\n"
                + "Supine RDI: " + supineRdi.ToString() + "\r\n"
                + "Lateral RDI: " + lateralRdi.ToString() + "\r\n"
                + "REM RDI: " + remRdi.ToString() + "\r\n"
                + "SAO2: " + lowestSao2.ToString() + "\r\n"
                + "Tx:= " + txInt.ToString() + "\r\n";
                testDiagnostic(
                    tw,
                    str,
                    totalSleepTime,
                    supineSleepTime,
                    lateralSleepTime,
                    remSleepTime,
                    totalRdi,
                    supineRdi,
                    lateralRdi,
                    remRdi,
                    lowestSao2);

                testSplitFinalTX(
                   tw,
                   str,
                   totalSleepTime,
                   supineSleepTime,
                   lateralSleepTime,
                   remSleepTime,
                   totalRdi,
                   supineRdi,
                   lateralRdi,
                   remRdi,
                   lowestSao2,
                   type,
                   txInt);
            }
            tw.Close();
        }

       
        private static void testDiagnostic(

            TextWriter tw,
            string str,
            float totalSleepTime,
            float supineSleepTime,
            float lateralSleepTime,
            float remSleepTime,
            float totalRdi,
            float supineRdi,
            float lateralRdi,
            float remRdi,
            float lowestSao2)
        {
            Respirations rd = new RespirationsDiagnostic(
                totalSleepTime,
                supineSleepTime,
                lateralSleepTime,
                remSleepTime,
                totalRdi,
                supineRdi,
                lateralRdi,
                remRdi,
                lowestSao2);

            tw.WriteLine(str);
            tw.WriteLine(rd.Result);
            tw.WriteLine("");
        }

        private static void testSplitFinalTX(
          TextWriter tw,
          string str,
          float totalSleepTime,
          float supineSleepTime,
          float lateralSleepTime,
          float remSleepTime,
          float totalRdi,
          float supineRdi,
          float lateralRdi,
          float remRdi,
          float lowestSao2,
          string type,
          int txInt)
        {
            Respirations rd = new RespirationsTitrationFinalTX(
                totalSleepTime,
                supineSleepTime,
                lateralSleepTime,
                remSleepTime,
                totalRdi,
                supineRdi,
                lateralRdi,
                remRdi,
                lowestSao2,
                type,
                txInt);

            tw.WriteLine(str);
            tw.WriteLine(rd.Result);
            tw.WriteLine("");
        }
    }
}
