namespace SleepArch
{
    internal class SleepStageAnalysisAdult : SleepStageAnalysis
    {
        private readonly SleepAnalysisResults TheResults;

        public SleepStageAnalysisAdult(
            double AmountStage1,
            double AmountStage2,
            double AmountSWS,
            double AmountREM)
        {
            initializeStageValues();
            StageOneAnalysis(AmountStage1);
            StageTwoAnalysis(AmountStage2);
            StageSWSAnalysis(AmountSWS);
            StageREMAnalysis(AmountREM);
            TheResults = new SleepAnalysisResultsDefault();
            Results = getResults();
        }

        private string getResults()
        {
            return TheResults.GetResults(STAGE1, SlowWaveSleep, REMsleep);
        }

        private void initializeStageValues()
        {
            Stage1Low = 0.0;
            Stage1High = 9.5;

            Stage2Low = 49.5;
            Stage2High = 70.4;

            StageSWSlow = 1.5;
            StageSWSHigh = 15.4;

            StageREMlow = 17.5;
            StageREMhigh = 22.4;
        }
    }
}