namespace PrelimInterDataManager
{
    public class SleepStudyData
    {
        public DemographicData DemographicData { get; set; } = new DemographicData();

        public ClinicalData TotalClinicalData { get; set; } = new ClinicalData();

        public TreatmentData TxData { get; set; } = new TreatmentData();
    }
}