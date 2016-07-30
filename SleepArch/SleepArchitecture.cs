
namespace SleepArch
{
    public enum Stage1
    {
        Normal,
        Increased,
    }

    public enum Stage2
    {
        Absent,
        Normal,
        Increased,
        Decreased
    }

    public enum SWS
    {
        Absent,
        Normal,
        Increased,
        Decreased
    }
    public enum REM
    {
        Absent,
        Normal,
        Increased,
        Decreased
    }
    public class SleepArchitecture
    {
        protected SleepStageAnalysis TheAnalysis;
        public SleepArchitecture(
                int AgeInYears,
                double Stage1percent,
                double Stage2percent,
                double SWSpercent,
                double REMpercent)
        {

            getAnalysis(AgeInYears, Stage1percent, Stage2percent, SWSpercent, REMpercent);
        }

        private void getAnalysis(
            int AgeInYears,
            double Stage1percent,
            double Stage2percent,
            double SWSpercent,
            double REMpercent)
        {
            if (AgeInYears < 18)
            {
                this.TheAnalysis =
                    new SleepStageAnalysisChild(
                    Stage1percent,
                    Stage2percent,
                    SWSpercent,
                    REMpercent);
            }
            else
            {
                this.TheAnalysis =
                    new SleepStageAnalysisAdult(
                    Stage1percent,
                    Stage2percent,
                    SWSpercent,
                    REMpercent);
            }
        }

        public string GetResults()
        {
            return this.TheAnalysis.Results;

        }


    }
}

