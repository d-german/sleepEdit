using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class OximetryData
    {
        public OximetryData() { }

        double? mLowest = null;
        public double? Lowest
        {
            get { return mLowest; }
            set { mLowest = value; }
        }
        double? mAverage = null;
        public double? Average
        {
            get { return mAverage; }
            set { mAverage = value; }
        }
    }
}
