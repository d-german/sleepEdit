namespace RespirationsComment
{
    public class RespirationsSplitFinalTX : Respirations
    {
        public RespirationsSplitFinalTX(
            float TotalSleepTime,
            float SupineSleepTime,
            float LateralSleepTime,
            float RemSleepTime,
            float TotalRdi,
            float SupineRdi,
            float LateralRdi,
            float RemRdi,
            float LowestSao2,
            object CPAPorBIPAP,
            object TX,
            StudyType studyType)
        {
            initializeCommon(
                TotalSleepTime,
                SupineSleepTime,
                LateralSleepTime,
                RemSleepTime,
                TotalRdi,
                SupineRdi,
                LateralRdi,
                RemRdi,
                LowestSao2);

            mTxType = CPAPorBIPAP.ToString();
            mTxValue = TX.ToString();
            mStudyType = studyType;
            initializeData();
            commentOnSeverity();
        }

        protected override void loadNormalSeverityValues()
        {
            load_Results("split_final_tx_normal_respirations_with_positional_or_rem_effect.xml",
                ref mNormalSeverityResults, mNormalResultsDelegate);
        }


        protected override void loadAbnormalSeverityValues()
        {
            load_Results("split_abnormal_respirations.xml", ref mAbnormalSeverityResults, mAbnormalResultsDelegate);
        }

        protected override void loadNormalDefaultValues()
        {
            mNormalSeverityResults[0] =
                "Overall [TX_TYPE] at [TX] cm H2O effectively controls the patient’s documented sleep apnea/hypopnea. ";

            mNormalSeverityResults[1] =
                "Overall [TX_TYPE] at [TX] cm H2O effectively controls the patient’s documented sleep apnea/hypopnea with 1 event per hour of sleep. ";

            mNormalSeverityResults[2] =
                "Overall [TX_TYPE] at [TX] cm H2O effectively controls the patient’s documented sleep apnea/hypopnea with [RDI] events per hour of sleep. ";

            mNormalSeverityResults[3] =
                "[TX_TYPE] at [TX] cm H2O controls the patient’s documented sleep apnea/hypopnea. ";

            mNormalSeverityResults[4] =
                "[TX_TYPE] at [TX] cm H2O controls the patient’s documented sleep apnea/hypopnea. ";

            mNormalSeverityResults[5] =
                "[TX_TYPE] at [TX] cm H2O effectively controls the patient’s documented sleep apnea/hypopnea with [RDI] events per hour of sleep. ";
        }

        protected override void loadAbnormalDefaultValues()
        {
            mAbnormalSeverityResults[(int) Severity.Normal] // not used
                = "";

            mAbnormalSeverityResults[(int) Severity.Mild]
                =
                "Despite [TX_TYPE] at [TX] cm H2O mild sleep apnea/hypopnea persists with [RDI] events per hour of sleep. ";

            mAbnormalSeverityResults[(int) Severity.Moderate]
                =
                "Despite [TX_TYPE] at [TX] cm H2O moderate sleep apnea/hypopnea persists with [RDI] events per hour of sleep. ";

            mAbnormalSeverityResults[(int) Severity.ModerateSevere]
                =
                "Despite [TX_TYPE] at [TX] cm H2O moderate severe sleep apnea/hypopnea persists with [RDI] events per hour of sleep. ";

            mAbnormalSeverityResults[(int) Severity.Severe]
                =
                "Despite [TX_TYPE] at [TX] cm H2O severe sleep apnea/hypopnea persists with [RDI] events per hour of sleep. ";
        }
    }
}