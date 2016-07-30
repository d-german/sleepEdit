using System.Collections.Generic;
using System.Diagnostics;
using PrelimInterDataManager;

namespace RespirationsComment
{
    public class DurationComment
    {
        protected const float MINIMUM_SUPINE_DURATION = 15.0f;
        protected const float MINIMUM_SLEEP_DURATION = 60.0f;
        protected const float MINIMUM_REM_DURATION = 15.0f;
        private const float ZERO = 0.0f;
        private static int[,,] durationTable;


        private string[] durationResults;

        private Duration mRemDuration;
        private readonly float mRemSleepTime;
        private Duration mSleepDuration;
        private StudyType mStudyType;
        private Duration mSupineDuration;
        private readonly float mSupineSleepTime;
        private readonly float mTotalSleepTime;

        public DurationComment(float totalSleepTime, float supineSleepTime, float remSleepTime, StudyType type)
        {
            mTotalSleepTime = totalSleepTime;
            mSupineSleepTime = supineSleepTime;
            mRemSleepTime = remSleepTime;
            mStudyType = type;
            initializeSleepDuration();
            initializeSupineDuration();
            initializeRemDuration();
            initializeDurationTable();
            switch (type)
            {
                case StudyType.Diagnostic:
                    initializeDiagnosticDurationResults();
                    break;
                case StudyType.SplitNight:
                    initializeSplitFinalDurationResults();
                    break;
                case StudyType.Titration:
                    initializeTitrationFinalTxDurationResults();
                    break;
            }
            getDurationComment();
        }

        public static float MinimumLateralDuration { get; } = 20.0f;

        public string DurationResult { get; private set; }

        private void initializeSupineDuration()
        {
            if (mSupineSleepTime == ZERO)
                mSupineDuration = Duration.Absent;
            else if (mSupineSleepTime <= MINIMUM_SUPINE_DURATION)
                mSupineDuration = Duration.Limited;
            else if (mSupineSleepTime > MINIMUM_SUPINE_DURATION)
                mSupineDuration = Duration.Normal;
            else
                Debug.Assert(false, "No value found.");
        }

        private void initializeRemDuration()
        {
            if (mRemSleepTime == ZERO)
                mRemDuration = Duration.Absent;
            else if (mRemSleepTime <= MINIMUM_REM_DURATION)
                mRemDuration = Duration.Limited;
            else if (mRemSleepTime > MINIMUM_REM_DURATION)
                mRemDuration = Duration.Normal;
            else
                Debug.Assert(false, "No value found.");
        }

        private void initializeSleepDuration()
        {
            if (mTotalSleepTime < MINIMUM_SLEEP_DURATION)
                mSleepDuration = Duration.Limited;
            else
                mSleepDuration = Duration.Normal;
        }


        private static void initializeDurationTable()
        {
            durationTable = new int[3, 3, 3];

            //            TST                        Supine                    REM
            durationTable[(int) Duration.Limited, (int) Duration.Absent, (int) Duration.Absent] = 0;
            durationTable[(int) Duration.Limited, (int) Duration.Absent, (int) Duration.Limited] = 1;
            durationTable[(int) Duration.Limited, (int) Duration.Absent, (int) Duration.Normal] = 2;

            durationTable[(int) Duration.Limited, (int) Duration.Limited, (int) Duration.Absent] = 3;
            durationTable[(int) Duration.Limited, (int) Duration.Limited, (int) Duration.Limited] = 4;
            durationTable[(int) Duration.Limited, (int) Duration.Limited, (int) Duration.Normal] = 5;

            durationTable[(int) Duration.Limited, (int) Duration.Normal, (int) Duration.Absent] = 6;
            durationTable[(int) Duration.Limited, (int) Duration.Normal, (int) Duration.Limited] = 7;
            durationTable[(int) Duration.Limited, (int) Duration.Normal, (int) Duration.Normal] = 8;

            //            TST                       Supine                    REM
            durationTable[(int) Duration.Normal, (int) Duration.Absent, (int) Duration.Absent] = 9;
            durationTable[(int) Duration.Normal, (int) Duration.Absent, (int) Duration.Limited] = 10;
            durationTable[(int) Duration.Normal, (int) Duration.Absent, (int) Duration.Normal] = 11;

            durationTable[(int) Duration.Normal, (int) Duration.Limited, (int) Duration.Absent] = 12;
            durationTable[(int) Duration.Normal, (int) Duration.Limited, (int) Duration.Limited] = 13;
            durationTable[(int) Duration.Normal, (int) Duration.Limited, (int) Duration.Normal] = 14;

            durationTable[(int) Duration.Normal, (int) Duration.Normal, (int) Duration.Absent] = 15;
            durationTable[(int) Duration.Normal, (int) Duration.Normal, (int) Duration.Limited] = 16;
            durationTable[(int) Duration.Normal, (int) Duration.Normal, (int) Duration.Normal] = 17;
        }

        protected void initializeDiagnosticDurationResults()
        {
            durationResults = new string[18];
            try
            {
                getResults("diagnostic_durations_comment.xml");
            }
            catch
            {
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

        private void getResults(string path)
        {
            var list = new List<string>();
            DataReader.readData(path, ref list);
            for (var i = 0; i < durationResults.Length; i++)
            {
                durationResults[i] = list[i];
            }
        }

        protected void initializeTitrationFinalTxDurationResults()
        {
            durationResults = new string[18];
            try
            {
                getResults("final_tx_durations_comment.xml");
            }
            catch
            {
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

        protected void initializeSplitFinalDurationResults()
        {
            initializeTitrationFinalTxDurationResults();

            #region

            /*
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
              */

            #endregion
        }

        private void getDurationComment()
        {
            var index = durationTable[(int) mSleepDuration, (int) mSupineDuration, (int) mRemDuration];
            DurationResult = durationResults[index];
        }
    }
}