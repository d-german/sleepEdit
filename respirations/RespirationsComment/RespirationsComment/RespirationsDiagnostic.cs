using System;
using System.Windows.Forms;
using System.Collections.Generic;

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
            initializeCommon(
                TotalSleepTime,
                SupineSleepTime,
                LateralSleepTime,
                RemSleepTime,
                TotalRdi,
                SupineRdi,
                LateralRdi,
                RemRdi,
                LowestSao2);

            initializeData();            
            commentOnSeverity();            
        }

       

        protected override void loadNormalSeverityValues()
        {
           load_Results("diagnostic_normal_respirations_with_positional_or_rem_effect.xml", ref mNormalSeverityResults, mNormalResultsDelegate);
        }


      
        protected override void loadNormalDefaultValues()
        {
            mNormalSeverityResults[0] =
            "Overall respirations are within normal limits. ";

            mNormalSeverityResults[1] =
                "Overall respirations are within normal limits with 1 or more events per hour of sleep. ";

            mNormalSeverityResults[2] =
               "Overall respirations are within normal limits with [RDI] events per hour of sleep. ";

            mNormalSeverityResults[3] =
                "Respirations are within normal limits. ";

            mNormalSeverityResults[4] =
                "Respirations are within normal limits with 1 or less events per hour of sleep. ";

            mNormalSeverityResults[5] =
                "Respirations are within normal limits with [RDI] events per hour of sleep. ";
        }


        protected override void loadAbnormalSeverityValues()
        {           
            load_Results("diagnostic_abnormal_respirations.xml", ref mAbnormalSeverityResults, mAbnormalResultsDelegate);
        }

       
        protected override void loadAbnormalDefaultValues()
        {
            string str = toStr(mTotalRdi);           

            mAbnormalSeverityResults[(int)Severity.Normal] // not used
            = ""; 
        
            mAbnormalSeverityResults[(int)Severity.Mild]
            = "Mild sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            mAbnormalSeverityResults[(int)Severity.Moderate]
            = "Moderate sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            mAbnormalSeverityResults[(int)Severity.ModerateSevere]
            = "Moderate severe sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";

            mAbnormalSeverityResults[(int)Severity.Severe]
            = "Severe sleep apnea/hypopnea is present with "
            + str + " events per hour of sleep. ";
        }
    }
}
