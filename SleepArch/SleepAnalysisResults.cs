
namespace SleepArch
{
    public abstract class SleepAnalysisResults /*: SleepStageAnalysis*/
    {
       //This is used to get different types of results through inheritance    


        public abstract string GetResults(
            Stage1 s1, 
            SWS slowWaveSleep, 
            REM REMsleep);
        public abstract string GetResults(
            Stage1 s1, 
            Stage2 s2, 
            SWS slowWaveSleep, 
            REM REMsleep);    
        
    }

     
}
