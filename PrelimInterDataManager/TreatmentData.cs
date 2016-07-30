using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class TreatmentData
    {
        public TreatmentData() { }

        String mTreatmentType = null; // CPAP, BIPAP, Oxygen
        String mUnit = null; // cmH2O, lpm O2
        List<ClinicalData> mTXData = null;

        public System.String TreatmentType
        {
            get { return mTreatmentType; }
            set { mTreatmentType = value; }
        }

        public System.String Unit
        {
            get { return mUnit; }
            set { mUnit = value; }
        }
        public List<ClinicalData> getTxData()
        {
            if (mTXData == null){
                mTXData = new List<ClinicalData>();
            }

            return mTXData;
        }
    }

}
