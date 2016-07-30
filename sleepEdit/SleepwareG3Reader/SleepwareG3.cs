#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("SleepEditTest")]

#endregion

namespace SleepwareG3Reader
{
    public class G3Data
    {
        public string Value { get; set; }
        public string Context { get; set; }
    }

    public class SleepwareG3
    {
        private readonly Dictionary<int, G3Data> _data = new Dictionary<int, G3Data>();
        public string PatientAge { get; private set; }
        public string SleepLatency { get; private set; }
        public string REMLatency { get; private set; }
        public string SleepEfficiency { get; private set; }
        public string PercentWkTIB { get; private set; }
        public string PercentREM { get; private set; }
        public string PercentN1 { get; private set; }
        public string PercentN2 { get; private set; }
        public string PercentN3 { get; private set; }
        public string PLMIndex { get; set; }
        public string PLMArousalIndex { get; set; }


        public SleepwareG3(string path)
        {
            LoadFile(path);
            LoadData();
        }

        private void LoadData()
        {
            PatientAge = Get(G3.PatientAge).Value;
            SleepLatency = Get(G3.SleepLatency).Value;
            REMLatency = Get(G3.REMLatency).Value;
            SleepEfficiency = Get(G3.SleepEfficiency).Value;
            PercentWkTIB = Get(G3.PercentWkTIB).Value;
            PercentREM = Get(G3.PercentREM).Value;
            PercentN1 = Get(G3.PercentN1).Value;
            PercentN2 = Get(G3.PercentN2).Value;
            PercentN3 = Get(G3.PercentN3).Value;
            PLMIndex = Get(G3.PLMIndex).Value;
            PLMArousalIndex = Get(G3.PLMArousalIndex).Value;
        }


        internal G3Data Get(G3 g3)
        {
            G3Data data;
            return _data.TryGetValue((int) g3, out data)
                ? data
                : new G3Data {Value = string.Empty, Context = string.Empty};
        }

        private void LoadFile(string path)
        {
            var file = new StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                var items = line.Split(',');
                var key = items[0].Trim();
                var value = items[1].Trim();
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
                {
                    _data.Add(Convert.ToInt32(key), new G3Data {Value = value, Context = items[2]});
                }
            }
            file.Close();
        }
    }
}