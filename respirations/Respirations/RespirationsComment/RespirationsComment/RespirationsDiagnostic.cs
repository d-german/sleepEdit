
namespace RespirationsComment
{
    public class RespirationsDiagnostic : Respirations
    {
        
        public RespirationsDiagnostic(
            float TotalSleepTime,
            float SupineSleepTime,
            float LateralSleepTime,
            float RemSleepTime,
            float TotalRdi,
            float SupineRdi,
            float LateralRdi,
            float RemRdi,
            float LowestSao2)
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
            InitializeData();
            commentOnSeverity();
            commentOnEffects();
            commentOnDurations();
        }


        protected override void initializeNormalSeverityValues()
        {
            normalSeverityResults = new string[6];

            normalSeverityResults[0] =
                "Overall respirations are within normal limits. ";


            normalSeverityResults[1] =
                "Overall respirations are within normal limits"
                 + " with 1 or more events per hour of sleep. ";

            normalSeverityResults[2] =
                "Overall respirations are within normal limits with "
            + toStr(totalRdi) + " events per hour of sleep. ";

            normalSeverityResults[3] =
                "Respirations are within normal limits. ";

            normalSeverityResults[4] =
                "Respirations are within normal limits"
            + " with 1 or less events per hour of sleep. ";

            normalSeverityResults[5] =
                "Respirations are within normal limits with " +
                toStr(totalRdi) + " events per hour of sleep. ";
        }

        protected override void initializeAbnormalSeverityValues()
        {
            string str = toStr(totalRdi);
            abnormalSeverityResults = new string[5];

            abnormalSeverityResults[(int)Severity.Mild]
            = "Mild sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.Moderate]
            = "Moderate sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.ModerateSevere]
            = "Moderate severe sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            abnormalSeverityResults[(int)Severity.Severe]
            = "Severe sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";
        }

        protected override void initializeDurationResults()
        {
            durationResults = new string[18];
            durationResults[0] =
                "Due to the limited amount of sleep, the absence of supine and REM sleep "
            + "this may be underestimated. ";

            durationResults[1] =
                "Due to the limited amount of sleep, the absence of supine sleep and the "
            + "limited amount of REM sleep this may be underestimated. ";

            durationResults[2] =
                "Due to the limited amount of sleep and the absence of supine sleep "
            + "this may be underestimated.";

            durationResults[3] =
                "Due to the limited amount of sleep, the limited amount of supine sleep "
            + "and the absence of REM sleep this may be underestimated.";

            durationResults[4] =
                "Due to the limited amount of total sleep, supine sleep "
            + "and the limited amount of REM sleep this may be underestimated.";

            durationResults[5] =
                "Due to the limited amount of total and supine sleep this may be underestimated.";

            durationResults[6] =
                "Due to the limited amount of total sleep and the absence of REM sleep "
            + "this may be underestimated.";

            durationResults[7] =
                "Due to the limited amount of total sleep and the limited amount of REM sleep "
            + "this may be underestimated.";

            durationResults[8] =
                "Due to the limited amount of sleep this may be underestimated.";

            durationResults[9] =
                "Due to the absence of supine and REM sleep this may be underestimated.";

            durationResults[10] =
                "Due to the absence of supine sleep and the limited amount of REM sleep "
            + "this may be underestimated.";

            durationResults[11] =
                "Due to the absence of supine sleep this may be underestimated.";

            durationResults[12] =
                "Due to the limited amount of supine sleep and the absence of REM "
            + " sleep this may be underestimated.";

            durationResults[13] =
                "Due to the limited amount of supine and REM sleep this may be underestimated.";

            durationResults[14] =
                "Due to the limited amount of supine sleep this may be underestimated.";

            durationResults[15] =
                "Due to the absence of REM sleep this may be underestimated.";

            durationResults[16] =
                "Due to the limited amount of REM sleep this may be underestimated.";

            durationResults[17] =
                "";
        }

    }
}
