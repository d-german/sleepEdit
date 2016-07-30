using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class PLMData 
    {
        public PLMData(){}

        double? mIndex = null;
        double? mAarousalIndex = null;

        public double? Index
        {
            get { return mIndex; }
            set { mIndex = value; }
        }        
        public double? AarousalIndex
        {
            get { return mAarousalIndex; }
            set { mAarousalIndex = value; }
        }
    }
}
