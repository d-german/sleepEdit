using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class ClinicalData
    {
        public ClinicalData(){}

        #region memberVariables
        SleepData mSleepData = null;
        RespitoryData mRespitoryData = null;
        OximetryData mOximetryData = null;
        PLMData mPlmData = null;
        #endregion
        #region gettersSetters
        public PrelimInterDataManager.SleepData SleepData
        {
            get { return mSleepData; }
            set { mSleepData = value; }
        }
        
        public PrelimInterDataManager.RespitoryData RespitoryData
        {
            get { return mRespitoryData; }
            set { mRespitoryData = value; }
        }
       
        public PrelimInterDataManager.OximetryData OximetryData
        {
            get { return mOximetryData; }
            set { mOximetryData = value; }
        }
        
        public PrelimInterDataManager.PLMData PlmData
        {
            get { return mPlmData; }
            set { mPlmData = value; }
        }
        #endregion
    }

}
