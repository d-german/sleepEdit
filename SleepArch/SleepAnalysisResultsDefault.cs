using System;
using System.Collections.Generic;
using System.Diagnostics;
using PrelimInterDataManager;

namespace SleepArch
{
    public class SleepAnalysisResultsDefault : SleepAnalysisResults
    {
        private const int numStage1 = 2; // Number of possible values for stage 1
        private const int numStageSWS = 4; // Number of possible values for slow wave sleep.
        private const int numStageREM = 4; // Number of values for REM sleep.
        private const int numResults = 32; // 2*4*4 = 32


        private static readonly int[,,] resultsTable = new int[numStage1, numStageSWS, numStageREM];
        private static readonly string[] results = new string[numResults];
        private static readonly string[] Labels = new string[numResults];

        public SleepAnalysisResultsDefault()
        {
            initializeResultsTable();
            initializeResults();
        }

        private static void initializeResultsTable()
        {
            resultsTable[(int) Stage1.Normal, (int) SWS.Absent, (int) REM.Absent] = 0;
            resultsTable[(int) Stage1.Normal, (int) SWS.Absent, (int) REM.Normal] = 1;
            resultsTable[(int) Stage1.Normal, (int) SWS.Absent, (int) REM.Increased] = 2;
            resultsTable[(int) Stage1.Normal, (int) SWS.Absent, (int) REM.Decreased] = 3;

            resultsTable[(int) Stage1.Normal, (int) SWS.Normal, (int) REM.Absent] = 4;
            resultsTable[(int) Stage1.Normal, (int) SWS.Normal, (int) REM.Normal] = 5;
            resultsTable[(int) Stage1.Normal, (int) SWS.Normal, (int) REM.Increased] = 6;
            resultsTable[(int) Stage1.Normal, (int) SWS.Normal, (int) REM.Decreased] = 7;

            resultsTable[(int) Stage1.Normal, (int) SWS.Increased, (int) REM.Absent] = 8;
            resultsTable[(int) Stage1.Normal, (int) SWS.Increased, (int) REM.Normal] = 9;
            resultsTable[(int) Stage1.Normal, (int) SWS.Increased, (int) REM.Increased] = 10;
            resultsTable[(int) Stage1.Normal, (int) SWS.Increased, (int) REM.Decreased] = 11;

            resultsTable[(int) Stage1.Normal, (int) SWS.Decreased, (int) REM.Absent] = 12;
            resultsTable[(int) Stage1.Normal, (int) SWS.Decreased, (int) REM.Normal] = 13;
            resultsTable[(int) Stage1.Normal, (int) SWS.Decreased, (int) REM.Increased] = 14;
            resultsTable[(int) Stage1.Normal, (int) SWS.Decreased, (int) REM.Decreased] = 15;

            resultsTable[(int) Stage1.Increased, (int) SWS.Absent, (int) REM.Absent] = 16;
            resultsTable[(int) Stage1.Increased, (int) SWS.Absent, (int) REM.Normal] = 17;
            resultsTable[(int) Stage1.Increased, (int) SWS.Absent, (int) REM.Increased] = 18;
            resultsTable[(int) Stage1.Increased, (int) SWS.Absent, (int) REM.Decreased] = 19;

            resultsTable[(int) Stage1.Increased, (int) SWS.Normal, (int) REM.Absent] = 20;
            resultsTable[(int) Stage1.Increased, (int) SWS.Normal, (int) REM.Normal] = 21;
            resultsTable[(int) Stage1.Increased, (int) SWS.Normal, (int) REM.Increased] = 22;
            resultsTable[(int) Stage1.Increased, (int) SWS.Normal, (int) REM.Decreased] = 23;

            resultsTable[(int) Stage1.Increased, (int) SWS.Increased, (int) REM.Absent] = 24;
            resultsTable[(int) Stage1.Increased, (int) SWS.Increased, (int) REM.Normal] = 25;
            resultsTable[(int) Stage1.Increased, (int) SWS.Increased, (int) REM.Increased] = 26;
            resultsTable[(int) Stage1.Increased, (int) SWS.Increased, (int) REM.Decreased] = 27;

            resultsTable[(int) Stage1.Increased, (int) SWS.Decreased, (int) REM.Absent] = 28;
            resultsTable[(int) Stage1.Increased, (int) SWS.Decreased, (int) REM.Normal] = 29;
            resultsTable[(int) Stage1.Increased, (int) SWS.Decreased, (int) REM.Increased] = 30;
            resultsTable[(int) Stage1.Increased, (int) SWS.Decreased, (int) REM.Decreased] = 31;
        }

        private static void initializeResults()
        {
            try
            {
                var list = new List<string>();
                DataReader.readData("defaultSleepArch.xml", ref list);
                for (var i = 0; i < results.Length; i++)
                {
                    results[i] = list[i];
                }
            }
            catch
            {
                results[0] = "Sleep architecture demonstrates an absence of REM and slow wave sleep.";

                results[1] = "Sleep architecture demonstrates an absence of slow wave sleep.";

                results[2] = "Sleep architecture demonstrates an absence of slow wave sleep"
                             + " and an increase in REM sleep.";

                results[3] = "Sleep architecture demonstrates an absence of slow wave sleep"
                             + " and a decrease in REM sleep.";

                results[4] = "Sleep architecture demonstrates an absence of REM sleep.";

                results[5] = "Sleep architecture is within normal limits.";

                results[6] = "Sleep architecture demonstrates an increase in REM sleep.";

                results[7] = "Sleep architecture demonstrates a decrease in REM sleep.";

                results[8] = "Sleep architecture demonstrates an absence of REM sleep.";

                results[9] = "Sleep architecture is within normal limits.";

                results[10] = "Sleep architecture demonstrates an increase in REM sleep.";

                results[11] = "Sleep architecture demonstrates a decrease in REM sleep.";

                results[12] = "Sleep architecture demonstrates a decrease in"
                              + " slow wave sleep and an absence of REM sleep.";

                results[13] = "Sleep architecture demonstrates a decrease in slow wave sleep.";

                results[14] = "Sleep architecture demonstrates an increase in REM sleep.";

                results[15] = "Sleep architecture demonstrates a decrease in REM sleep.";

                results[16] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and an absence"
                              + " of slow wave and REM sleep.";

                results[17] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and an absence of slow wave sleep.";

                results[18] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and an absence of slow wave sleep."
                              + " An increase in REM sleep is observed.";

                results[19] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep, an absence of slow wave sleep,"
                              + " and a decrease in REM sleep.";

                results[20] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and an absence of REM sleep.";

                results[21] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep.";

                results[22] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep.  An increase in REM sleep is observed.";

                results[23] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and a decrease in REM sleep.";

                results[24] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and an absence of REM sleep.";

                results[25] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep.";

                results[26] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep.  An increase in REM sleep is observed.";

                results[27] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and a decrease in REM sleep.";

                results[28] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep, a decrease in REM sleep,"
                              + " and an absence of REM sleep.";

                results[29] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and a decrease in slow wave sleep.";

                results[30] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and a decrease"
                              + " in slow wave sleep.  An increase in REM sleep is observed.";

                results[31] = "Sleep architecture is fragmented with an increase"
                              + " in light (stage 1) sleep and a decrease in slow wave and REM sleep.";
            }
        }

        private static void initializeLabels()
        {
            Labels[0] = " Normal  Absent  Absent";
            Labels[1] = " Normal  Absent  Normal";
            Labels[2] = " Normal  Absent  Increased";
            Labels[3] = " Normal  Absent  Decreased";
            Labels[4] = " Normal  Normal  Absent";
            Labels[5] = " Normal  Normal  Normal";
        }

        public override string GetResults(Stage1 stage1, SWS slowWaveSleep, REM REMsleep)
        {
            var index = resultsTable[(int) stage1, (int) slowWaveSleep, (int) REMsleep];
            return results[index];
        }

        public override string GetResults(Stage1 stage1, Stage2 s2, SWS sws, REM rem)
        {
            Debug.Assert(false, "This is not used for default");
            return "";
        }

        public void printDefaultResults()
        {
            for (var n1 = 0; n1 < numStage1; n1++)
            {
                for (var n3 = 0; n3 < numStageSWS; n3++)
                {
                    for (var rem = 0; rem < numStageREM; rem++)
                    {
                        Console.WriteLine(results[resultsTable[n1, n3, rem]]);
                    }
                }
            }
        }
    }
}