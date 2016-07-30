namespace SleepArch
{
    public class SleepStageAnalysisChild : SleepStageAnalysis
    {
        private readonly SleepAnalysisResults TheResults;

        public SleepStageAnalysisChild(
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
            Stage1High = 3.41;

            Stage2Low = 29.5;
            Stage2High = 30.41;

            StageSWSlow = 34.5;
            StageSWSHigh = 55.41;

            StageREMlow = 19.5;
            StageREMhigh = 25.41;
        }
    }
}