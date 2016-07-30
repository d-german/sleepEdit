using System;

namespace PrelimInterDataManager
{
    public class DemographicData
    {
        public string PatientName { get; set; } = null;

        public string PhysicianName { get; set; } = null;

        public DateTime? Dob { get; set; } = null;

        public int? Age { get; set; } = null;

        public int? HeightIn { get; set; } = null;

        public int? WeightLbs { get; set; } = null;
    }
}