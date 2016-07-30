using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class DemographicData
    {
        public DemographicData(){}

        DateTime? mDob = null;
        int? mAge = null;
        int? mHeightIn = null;
        int? mWeightLbs = null;
        String mPatientName = null;
        String mPhysicianName = null;

        public System.String PatientName
        {
            get { return mPatientName; }
            set { mPatientName = value; }
        }
        
        public System.String PhysicianName
        {
            get { return mPhysicianName; }
            set { mPhysicianName = value; }
        }

        public DateTime? Dob
        {
            get { return mDob; }
            set { mDob = value; }
        }
        
        public int? Age
        {
            get { return mAge; }
            set { mAge = value; }
        }
       
        public int? HeightIn
        {
            get { return mHeightIn; }
            set { mHeightIn = value; }
        }
       
        public int? WeightLbs
        {
            get { return mWeightLbs; }
            set { mWeightLbs = value; }
        }
    }
}
