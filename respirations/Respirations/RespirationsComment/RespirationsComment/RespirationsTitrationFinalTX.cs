
namespace RespirationsComment
{
    public class RespirationsTitrationFinalTX : Respirations
    {
        public RespirationsTitrationFinalTX(
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
            object TX)
        {
            totalSleepTime = TotalSleepTime;
            supineSleepTime = SupineSleepTime;
            lateralSleepTime = LateralSleepTime;
            remSleepTime = RemSleepTime;
            totalRdi = TotalRdi;
            supineRdi = SupineRdi;
            lateralRdi = LateralRdi;
            remRdi = RemRdi;
            lowestSao2 = LowestSao2;
            txType = CPAPorBIPAP.ToString();
            txValue = TX.ToString();
            InitializeData();
            commentOnSeverity();
            commentOnEffects();
            commentOnDurations();
        }


        protected override void initializeNormalSeverityValues()
        {
            normalSeverityResults = new string[6];

            normalSeverityResults[0] =
                "Overall <CPAP/BIPAP> at <TX> cm H2O effectively controls the patient’s previously documented sleep apnea/hypopnea. ";

            normalSeverityResults[1] =
                "Overall <CPAP/BIPAP> at <TX> cm H2O effectively controls the patient’s previously documented sleep apnea/hypopnea with 1 event per hour of sleep. ";

            normalSeverityResults[2] =
                "Overall <CPAP/BIPAP> at <TX> cm H2O effectively controls the patient’s previously documented sleep apnea/hypopnea with <INDEX> events per hour of sleep. ";

            normalSeverityResults[3] =
                "<CPAP/BIPAP> at <TX> cm H2O controls the patient’s previously documented sleep apnea/hypopnea. ";

            normalSeverityResults[4] =
                "<CPAP/BIPAP> at <TX> cm H2O controls the patient’s previously documented sleep apnea/hypopnea. ";

            normalSeverityResults[5] =
                "<CPAP/BIPAP> at <TX> cm H2O effectively controls the patient’s previously documented sleep apnea/hypopnea with <INDEX> events per hour of sleep. ";
        }

        protected override void initializeAbnormalSeverityValues()
        {
            //string str = toStr(totalRdi);
            abnormalSeverityResults = new string[5];

            abnormalSeverityResults[(int)Severity.Mild]
            = "Despite <CPAP/BIPAP> at <TX> cm H2O mild sleep apnea/hypopnea persists with <INDEX> events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.Moderate]
            = "Despite <CPAP/BIPAP> at <TX> cm H2O moderate sleep apnea/hypopnea persists with <INDEX> events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.ModerateSevere]
            = "Despite <CPAP/BIPAP> at <TX> cm H2O moderate severe sleep apnea/hypopnea persists with <INDEX> events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.Severe]
            = "Despite <CPAP/BIPAP> at <TX> cm H2O severe sleep apnea/hypopnea persists with <INDEX> events per hour of sleep. ";
        }

        protected override void initializeDurationResults()
        {
            durationResults = new string[18];
            durationResults[0] =
                "Due to the limited amount of time at this pressure, the absence of supine and REM sleep the efficacy of the treatment cannot be fully assessed. ";

            durationResults[1] =
                "Due to the limited amount of time at this pressure, the absence of supine sleep and the limited amount of REM sleep the efficacy of the treatment cannot be fully assessed. ";

            durationResults[2] =
                "Due to the limited amount of time at this pressure and the absence of supine sleep the efficacy of the treatment cannot be fully assessed. ";

            durationResults[3] =
                "Due to the limited amount of time at this pressure, the limited amount of supine sleep and the absence of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[4] =
                "Due to the limited amount of time at this pressure, the limited amount of supine sleep and the limited amount of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[5] =
                "Due to the limited amount of time at this pressure and the limited amount of supine sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[6] =
                "Due to the limited amount of time at this pressure and the absence of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[7] =
                "Due to the limited amount of time at this pressure and the limited amount of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[8] =
                "Due to the limited amount of time at this pressure the efficacy of the treatment cannot be fully assessed.";

            durationResults[9] =
                "Due to the absence of supine and REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[10] =
                "Due to the absence of supine sleep and the limited amount of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[11] =
                "Due to the absence of supine sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[12] =
                "Due to the limited amount of supine sleep and the absence of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[13] =
                "Due to the limited amount of supine and REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[14] =
                "Due to the limited amount of supine sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[15] =
                "Due to the absence of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[16] =
                "Due to the limited amount of REM sleep the efficacy of the treatment cannot be fully assessed.";

            durationResults[17] =
                "";
        }
    }
}
