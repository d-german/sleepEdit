using System;
using System.IO;

namespace SleepArch
{
    internal class Tester
    {
        public static void tester()
        {
            var rnd = new Random();
            double stage1;
            double stage2;
            double sws;
            double rem;
            int age;
            int max;

            var str = "";


            for (var i = 0; i < 100; i++)
            {
                stage1 = rnd.Next(0, 50) + rnd.NextDouble();
                max = 100 - (int) stage1;


                stage2 = rnd.Next(0, max) + rnd.NextDouble();

                max = (int) (100 - (stage1 + stage2));

                sws = rnd.Next(14, 16) + rnd.NextDouble();

                rem = 100 - (stage1 + stage2 + sws);

                age = rnd.Next(0, 100);

                str = "Age: " + age + "\r\nStage1: " + stage1.ToString("###.#")
                      + "\r\nStage2: " + stage2.ToString("###.#") + "\r\nSWS: " + sws.ToString("###.#") + "\r\nRem: "
                      + rem.ToString("###.#");
                //SleepArchitecture sa = new SleepArchitecture(age, stage1, stage2, sws, rem);
                TextWriter tw = new StreamWriter("OutPut.txt", true);
                tw.WriteLine(str);
                //tw.WriteLine(sa.GetResults()+"\r\n");
                tw.Close();
            }
        }
    }
}