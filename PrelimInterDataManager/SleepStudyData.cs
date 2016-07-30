using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{

    public class SleepStudyData
    {
        public SleepStudyData() { }

        private DemographicData mDemographicData = new DemographicData();
        private ClinicalData mTotalClinicalData = new ClinicalData();
        private TreatmentData mTxData = new TreatmentData();

        public PrelimInterDataManager.DemographicData DemographicData
        {
            get { return mDemographicData; }
            set { mDemographicData = value; }
        }

        public PrelimInterDataManager.ClinicalData TotalClinicalData
        {
            get { return mTotalClinicalData; }
            set { mTotalClinicalData = value; }
        }

        public PrelimInterDataManager.TreatmentData TxData
        {
            get { return mTxData; }
            set { mTxData = value; }
        }
    }
}



