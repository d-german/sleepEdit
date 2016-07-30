using System;
using System.Collections.Generic;
using System.Text;

namespace SleepArch
{

    public class SleepStageAnalysis
    {


        protected double Stage1Low;
        protected double Stage1High;

        protected double Stage2Low;
        protected double Stage2High;

        protected double StageSWSlow;
        protected double StageSWSHigh;

        protected double StageREMlow;
        protected double StageREMhigh;

        protected Stage1 STAGE1;
        protected Stage2 STAGE2;
        protected SWS SlowWaveSleep;
        protected REM REMsleep;

        protected void StageOneAnalysis(double AmountStage1)
        {
            if (AmountStage1 > Stage1High)
                STAGE1 = Stage1.Increased;
            else
                STAGE1 = Stage1.Normal;
        }


        protected void StageTwoAnalysis(double AmountStage2)
        {
            if (AmountStage2 == 0)
                STAGE2 = Stage2.Absent;
            else
                if (AmountStage2 < Stage2Low)
                    STAGE2 = Stage2.Decreased;
                else
                    if (AmountStage2 > Stage2High)
                        STAGE2 = Stage2.Increased;
                    else STAGE2 = Stage2.Normal;
        }

        protected void StageSWSAnalysis(double AmountSWS)
        {
            if (AmountSWS == 0.0)
                SlowWaveSleep = SWS.Absent;
            else
                if (AmountSWS < StageSWSlow)
                    SlowWaveSleep = SWS.Decreased;
                else
                    if (AmountSWS > StageSWSHigh)
                        SlowWaveSleep = SWS.Increased;
                    else
                        SlowWaveSleep = SWS.Normal;
        }

        protected void StageREMAnalysis(double AmountREM)
        {

            if (AmountREM == 0.0)
                REMsleep = REM.Absent;
            else
                if (AmountREM < StageREMlow)
                    REMsleep = REM.Decreased;
                else
                    if (AmountREM > StageREMhigh)
                        REMsleep = REM.Increased;
                    else
                        REMsleep = REM.Normal;
        }


        private string results;

        public string Results
        {
            get { return results; }
            set { results = value; }
        }
	
        
    }
}
