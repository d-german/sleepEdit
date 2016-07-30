

namespace RespirationsComment
{
    public abstract class Respirations
    {

        // Respitory index rating
        protected const float NORMAL = 4.4f;
        protected const float MILD = 14.4f;
        protected const float MODERATE = 25.4f;
        protected const float MOD_SEVERE = 35.4f;
        protected const float SEVERE = 35.5f;

        protected const float SAO2_NORMAL_LOW = 90.0f;

        protected const float MINIMUM_SUPINE_DURATION = 15.0f;
        protected const float MINIMUM_SLEEP_DURATION = 60.0f;
        protected const float MINIMUM_REM_DURATION = 15.0f;
        protected const float MINIMUM_LATERAL_DURATION = 20.0f; //used for position effect 

        protected const float ZERO = 0.0f;

        public string Result
        {
            get { return getResult(); }

        }

        protected string severityResult;
        protected string posEffectResult;
        protected string remEffectResult;
        protected string durationResult;
        protected string sao2Results;
        protected string txValue; // i.e 10
        protected string txType; // i.e CPAP or BIPAP

        protected string[] normalSeverityResults;
        protected string[] abnormalSeverityResults;
        protected string[] durationResults;


        protected static int[,] normalSeverityTable;
        protected static int[, ,] durationTable;

        protected float totalSleepTime = 0.0f;
        protected float supineSleepTime = 0.0f;
        protected float lateralSleepTime = 0.0f;
        protected float remSleepTime = 0.0f;

        protected float totalRdi = 0.0f;
        protected float supineRdi = 0.0f;
        protected float lateralRdi = 0.0f;
        protected float remRdi = 0.0f;

        protected float lowestSao2 = 0.0f;

        public enum Severity
        {
            Normal,
            Mild,
            Moderate,
            ModerateSevere,
            Severe
        }

        public enum Duration
        {
            Absent,
            Limited,
            Normal
        }

        public enum Effect
        {
            False,
            True
        }

        public enum Plurality
        {
            Zero,
            Singular,
            Multiple
        }

        protected Severity rdiSeverity;
        protected Severity lateralSeverity;
        protected Severity remSeverity;
        protected Severity supineSeverity;
        protected Severity sao2Severity;

        protected Duration sleepDuration;
        protected Duration supineDuration;
        protected Duration remDuration;

        protected Effect positionEffect;
        protected Effect remEffect;
        protected Effect effect;

        protected Plurality lateralRdiPlurality;
        protected Plurality rdiPlurality;

        protected void InitializeData()
        {
            InitializeRdiSeverity();

            InitializeSupineSeverity();

            InitializeRemSeverity();

            InitializeLateralSeverity();

            InitializeSao2Severity();

            InitializeSleepDuration();

            InitializeSupineDuration();

            InitializeRemDuration();

            InitializePosEffect();

            InitializeRemEffect();

            InitializeEffect();

            InitializePlurality(totalRdi, out rdiPlurality);

            InitializePlurality(lateralRdi, out lateralRdiPlurality);

            InitializeNormalSeverityTable();

            InitializeDurationTable();

            getPosRemEffect();
            commentOnSao2();
        }

        private void InitializeRdiSeverity()
        {
            if (totalRdi <= NORMAL)
                rdiSeverity = Severity.Normal;
            else
                if (totalRdi <= MILD)
                    rdiSeverity = Severity.Mild;
                else
                    if (totalRdi <= MODERATE)
                        rdiSeverity = Severity.Moderate;
                    else
                        if (totalRdi <= MOD_SEVERE)
                            rdiSeverity = Severity.ModerateSevere;
                        else
                            if (totalRdi > SEVERE)
                                rdiSeverity = Severity.Severe;
                            else
                                System.Diagnostics.Debug.Assert(
                                 false, "No value found in InitializeRdiSeverity().");
        }
        private void InitializeSupineSeverity()
        {
            if (supineRdi > NORMAL)
                supineSeverity = Severity.Mild;
            //actualy could be more than mild
        }
        private void InitializeLateralSeverity()
        {
            if (lateralRdi > NORMAL)
                lateralSeverity = Severity.Mild;
        }
        private void InitializeRemSeverity()
        {
            if (remRdi > NORMAL)
                remSeverity = Severity.Mild;
        }
        private void InitializeSao2Severity()
        {
            if (lowestSao2 < SAO2_NORMAL_LOW)
                sao2Severity = Severity.Mild;
            else
                sao2Severity = Severity.Normal;
        }

        private void InitializeSupineDuration()
        {
            if (supineSleepTime == ZERO)
                supineDuration = Duration.Absent;
            else
                if (supineSleepTime <= MINIMUM_SUPINE_DURATION)
                    supineDuration = Duration.Limited;
                else
                    if (supineSleepTime > MINIMUM_SUPINE_DURATION)
                        supineDuration = Duration.Normal;
                    else
                        System.Diagnostics.Debug.Assert(
                                                        false, "No value found.");
        }
        private void InitializeRemDuration()
        {
            if (remSleepTime == ZERO)
                remDuration = Duration.Absent;
            else
                if (remSleepTime <= MINIMUM_REM_DURATION)
                    remDuration = Duration.Limited;
                else
                    if (remSleepTime > MINIMUM_REM_DURATION)
                        remDuration = Duration.Normal;
                    else
                        System.Diagnostics.Debug.Assert(
                                                        false, "No value found.");
        }
        private void InitializeSleepDuration()
        {

            if (totalSleepTime < MINIMUM_SLEEP_DURATION)
                sleepDuration = Duration.Limited;
            else
                sleepDuration = Duration.Normal;
        }


        private void InitializeEffect()
        {
            if ((positionEffect == Effect.True) || (remEffect == Effect.True))
                effect = Effect.True;
        }
        private void InitializeRemEffect()
        {
            if (
                (remSeverity != Severity.Normal)
                && //AND
                (remRdi >= (2 * totalRdi)))
                remEffect = Effect.True;
        }
        private void InitializePosEffect()
        {
        	if (
        	    (supineSeverity != Severity.Normal)
        	    && //AND
        	    (supineRdi >= (2 * lateralRdi)
        	     &&
        	     (lateralSleepTime >= MINIMUM_LATERAL_DURATION)))
        		positionEffect = Effect.True;
        }


        private void InitializePlurality(float num, out Plurality val)
        {
            if (num <= 0.4f)
                val = Plurality.Zero;
            else
                if (num <= 1.4f)
                    val = Plurality.Singular;
                else
                    val = Plurality.Multiple;
        }

        private void getPosRemEffect()
        {

            if (positionEffect == Effect.True)
            {
                if (lateralSeverity == Severity.Normal)
                    posEffectResult =
                        "A position effect is noted with "
                        + toStr(supineRdi) + " events per hour of sleep supine versus "
                        + "normal respirations laterally. ";
                else
                    posEffectResult =
                        "A position effect is noted with "
                        + toStr(supineRdi) + " events per hour of sleep supine versus "
                        + toStr(lateralRdi) + " events per hour of sleep laterally. ";
            }
            if (remEffect == Effect.True)
                remEffectResult =
                    "These events increase in frequency during REM sleep with "
                    + toStr(remRdi) + " events per hour of REM sleep. ";

        }

        protected void commentOnSeverity()
        {
            if (rdiSeverity == Severity.Normal)
            {
                int index = normalSeverityTable[(int)effect, (int)rdiPlurality];
                initializeNormalSeverityValues();
                severityResult = normalSeverityResults[index];
                insertSeverityTagValues();
            }
            else
                if (rdiSeverity != Severity.Normal)
                {
                    initializeAbnormalSeverityValues();
                    severityResult = abnormalSeverityResults[(int)rdiSeverity];
                    insertSeverityTagValues();
                }
        }
        protected void commentOnEffects()
        {
            getPosRemEffect();
        }
        protected void commentOnDurations()
        {
            initializeDurationResults();
            int index = durationTable[(int)sleepDuration, (int)supineDuration, (int)remDuration];
            durationResult = durationResults[index];
        }
        protected void commentOnSao2()
        {
            if (sao2Severity == Severity.Normal)
                sao2Results = "Arterial oxygen saturation remains above "
                    + toStr(lowestSao2) + "%. ";
            else
                sao2Results = "Arterial oxygen desaturation to "
                    + toStr(lowestSao2) + "% is observed. ";
        }

        protected abstract void initializeNormalSeverityValues();
        protected abstract void initializeAbnormalSeverityValues();
        protected abstract void initializeDurationResults();


        private string getResult()
        {
            return severityResult + remEffectResult + posEffectResult + sao2Results + durationResult;
        }

        protected string toStr(float val)
        {
            return val.ToString("####");
        }
        private void insertSeverityTagValues()
        {
            severityResult = severityResult.Replace("<INDEX>", toStr(totalRdi));
            severityResult = severityResult.Replace("<CPAP/BIPAP>", txType);
            severityResult = severityResult.Replace("<TX>", txValue);
        }

        private static void InitializeNormalSeverityTable()
        {
            normalSeverityTable = new int[2, 3];
            //                  Position or REM Effect,        totalRdi
            normalSeverityTable[(int)Effect.True, (int)Plurality.Zero] = 0;
            normalSeverityTable[(int)Effect.True, (int)Plurality.Singular] = 1;
            normalSeverityTable[(int)Effect.True, (int)Plurality.Multiple] = 2;

            normalSeverityTable[(int)Effect.False, (int)Plurality.Zero] = 3;
            normalSeverityTable[(int)Effect.False, (int)Plurality.Singular] = 4;
            normalSeverityTable[(int)Effect.False, (int)Plurality.Multiple] = 5;
        }

        private static void InitializeDurationTable()
        {
            durationTable = new int[3, 3, 3];

            //            TST                        Supine                    REM
            durationTable[(int)Duration.Limited, (int)Duration.Absent, (int)Duration.Absent] = 0;
            durationTable[(int)Duration.Limited, (int)Duration.Absent, (int)Duration.Limited] = 1;
            durationTable[(int)Duration.Limited, (int)Duration.Absent, (int)Duration.Normal] = 2;

            durationTable[(int)Duration.Limited, (int)Duration.Limited, (int)Duration.Absent] = 3;
            durationTable[(int)Duration.Limited, (int)Duration.Limited, (int)Duration.Limited] = 4;
            durationTable[(int)Duration.Limited, (int)Duration.Limited, (int)Duration.Normal] = 5;

            durationTable[(int)Duration.Limited, (int)Duration.Normal, (int)Duration.Absent] = 6;
            durationTable[(int)Duration.Limited, (int)Duration.Normal, (int)Duration.Limited] = 7;
            durationTable[(int)Duration.Limited, (int)Duration.Normal, (int)Duration.Normal] = 8;

            //            TST                       Supine                    REM
            durationTable[(int)Duration.Normal, (int)Duration.Absent, (int)Duration.Absent] = 9;
            durationTable[(int)Duration.Normal, (int)Duration.Absent, (int)Duration.Limited] = 10;
            durationTable[(int)Duration.Normal, (int)Duration.Absent, (int)Duration.Normal] = 11;

            durationTable[(int)Duration.Normal, (int)Duration.Limited, (int)Duration.Absent] = 12;
            durationTable[(int)Duration.Normal, (int)Duration.Limited, (int)Duration.Limited] = 13;
            durationTable[(int)Duration.Normal, (int)Duration.Limited, (int)Duration.Normal] = 14;

            durationTable[(int)Duration.Normal, (int)Duration.Normal, (int)Duration.Absent] = 15;
            durationTable[(int)Duration.Normal, (int)Duration.Normal, (int)Duration.Limited] = 16;
            durationTable[(int)Duration.Normal, (int)Duration.Normal, (int)Duration.Normal] = 17;

        }

    }
}
