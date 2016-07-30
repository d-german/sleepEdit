using System.Collections.Generic;

namespace PrelimInterDataManager
{
    public class TreatmentData
    {
        private List<ClinicalData> mTXData;

        public string TreatmentType { get; set; } = null;

        public string Unit { get; set; } = null;

        public List<ClinicalData> getTxData()
        {
            if (mTXData == null)
            {
                mTXData = new List<ClinicalData>();
            }

            return mTXData;
        }
    }
}