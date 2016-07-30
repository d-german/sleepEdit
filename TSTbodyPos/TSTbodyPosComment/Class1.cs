using System;
using System.Collections.Generic;
using System.Text;

namespace TSTbodyPosComment
{
    public class Class1
    {
        private string getPsg_CommentTSTandPosition()
        {

            bool TSTmore60 = this.psg_sleepTime > 60;
            bool TSTmore120 = this.psg_sleepTime > 120;
            bool supineIs0 = this.psg_supineSleepTime == 0.0;
            bool supineMore60 = this.psg_supineSleepTime > 60;
            bool supineMore120 = this.psg_supineSleepTime > 120;
            float psgHrs, psgMins, supHrs, supMins;
            this.minutesToTime(out psgMins, out psgHrs, this.psg_sleepTime);
            this.minutesToTime(out supMins, out supHrs, this.psg_supineSleepTime);

            bool TSTmore60 = TSTmore60, TSTmore120 = TSTmore120, supineIs0 = supineIs0,
            supineMore60 = supineMore60, supineMore120 = supineMore120;
            ///fixed if sup = total
            if (!TSTmore60 && !TSTmore120 && !supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept ___ minutes; ___ minutes supine.
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept " + psgMinStr + " minutes; (all supine).\r\n";
                return "The patient slept " + psgMinStr + " minutes; "
                    + supMinStr + " minutes supine.\r\n";
            }

            if (!TSTmore60 && !TSTmore120 && supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept ___ minutes; none supine.
                /// 
                string psgMinStr = psgMins.ToString("###");

                return "The patient slept " + psgMinStr
                    + " minutes; none supine.";
            }

            if (TSTmore60 && !TSTmore120 && !supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept 1 hour and ___ minutes; ___ minutes supine.
                ///

                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept 1 hour and "
                        + psgMinStr + " minutes; (all supine).\r\n";
                return "The patient slept 1 hour and "
                    + psgMinStr + " minutes; " + supMinStr
                    + " minutes supine.\r\n";
            }

            if (TSTmore60 && !TSTmore120 && !supineIs0 && supineMore60 && !supineMore120)
            {
                /// The pt slept 1 hour and ___ minutes;
                /// 1 hour and ___ minutes supine.
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept 1 hour and " + psgMinStr
                        + "minutes; (all supine).\r\n";
                return "The patient slept 1 hour and " + psgMinStr
                    + "minutes; 1 hour and " + supMinStr
                    + " minutes supine.\r\n";
            }

            if (TSTmore60 && !TSTmore120 && supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept 1 hour and ___ minutes; none supine.
                /// 
                string psgMinStr = psgMins.ToString("###");

                return "The patient slept 1 hour and " + psgMinStr
                    + " minutes; none supine.";
            }

            if (TSTmore60 && TSTmore120 && !supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept ___ hours and ___ minutes;
                /// 1 hour and ___ minutes supine.
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept " + psgHrStr + " hours and "
                        + psgMinStr + " minutes; (all supine).\r\n";

                return "The patient slept " + psgHrStr + " hours and "
                    + psgMinStr + " minutes; "
                    + supMinStr + " minutes supine.\r\n";
            }

            if (TSTmore60 && TSTmore120 && !supineIs0 && supineMore60 && !supineMore120)
            {
                /// The pt slept ___ hours and ___ minutes;
                /// 1 hour and ___ minutes supine.
                ///
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept " + psgHrStr + " hours and "
                        + psgMinStr + " minutes; (all supine).\r\n";
                return "The patient slept " + psgHrStr + " hours and "
                    + psgMinStr + " minutes;"
                    + " 1 hour and " + supMinStr + " minutes supine.\r\n";
            }

            if (TSTmore60 && TSTmore120 && !supineIs0 && supineMore60 && supineMore120)
            {
                /// The pt slept ___ hours and ___ minutes;
                /// ___ hours and ___ minutes supine.
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supHrStr = supHrs.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "The patient slept " + psgHrStr + " hours and "
                        + psgMinStr + " minutes; (all supine).\r\n";

                return "The patient slept " + psgHrStr + " hours and "
                    + psgMinStr + " minutes; "
                    + supHrStr + " hours and " + supMinStr + " minutes supine.\r\n";
            }

            if (TSTmore60 && TSTmore120 && supineIs0 && !supineMore60 && !supineMore120)
            {
                /// The pt slept ___ hours and ___ minutes; none supine.
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");

                return "The patient slept " + psgHrStr + " hours and "
                    + psgMinStr + " minutes; "
                    + " none supine.\r\n";
            }

            return "";
        }

        private string getDiagnostic_CommentTSTandPosition(bool TSTmore60)
        {

            bool TSTmore120 = this.diag_sleepTime > 120;
            bool supineIs0 = this.diag_supineSleepTime == 0.0;
            bool supineMore60 = this.diag_supineSleepTime > 60;
            bool supineMore120 = this.diag_supineSleepTime > 120;
            float psgHrs, psgMins, supHrs, supMins;
            this.minutesToTime(out psgMins, out psgHrs, this.diag_sleepTime);
            this.minutesToTime(out supMins, out supHrs, this.diag_supineSleepTime);

            bool A = TSTmore60, B = TSTmore120, C = supineIs0,
            D = supineMore60, E = supineMore120;

            if (!A && !B && !C && !D && !E)
            {
                /// ___ minutes while documenting sleep
                /// apnea/hypopnea (___ minutes supine)
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgMinStr + " minutes while documenting sleep apnea/hypopnea (all supine)";

                return psgMinStr + " minutes while documenting sleep apnea/hypopnea ("
                    + supMinStr + " minutes supine)";
            }

            if (!A && !B && C && !D && !E)
            {
                /// ___minutes while documenting sleep
                /// apnea/hypopnea (none supine)
                /// 
                string psgMinStr = psgMins.ToString("###");

                return psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea (none supine)";
            }

            if (A && !B && !C && !D && !E)
            {
                /// 1 hour and ___ minutes while documenting sleep
                /// apnea/hypopnea (___minutes supine)
                ///

                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "1 hour and " + psgMinStr
                        + " minutes while documenting sleep apnea/hypopnea (all supine)";
                return "1 hour and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea "
                    + "(" + supMinStr + " minutes supine)";
            }

            if (A && !B && !C && D && !E)
            {
                /// 1 hour and ___ minutes while documenting sleep
                /// apnea/hypopnea (1 hour and ___ minutes supine)
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "1 hour and " + psgMinStr
                        + " minutes while documenting sleep apnea/hypopnea (all supine)";

                return "1 hour and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea (1 hour and "
                    + supMinStr + " minutes supine)";
            }

            if (A && !B && C && !D && !E)
            {
                /// 1 hour and ___ minutes while documenting
                /// sleep apnea/hypopnea (none supine)
                /// 
                string psgMinStr = psgMins.ToString("###");

                return "1 hour and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea (none supine)";
            }

            if (A && B && !C && !D && !E)
            {
                ///  ___ hours and ___ minutes while documenting
                ///  sleep apnea/hypopnea (___ minutes supine)
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while documenting sleep apnea/hypopnea (all supine)";

                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea ("
                    + supMinStr + " minutes supine)";
            }

            if (A && B && !C && D && !E)
            {
                /// ___ hours and ___ minutes while documenting
                /// sleep apnea/hypopnea (1 hour and ___ minutes supine)
                ///
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while documenting sleep apnea/hypopnea (all supine)";

                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea ("
                    + "1 hour and " + supMinStr + " minutes supine)";
            }

            if (A && B && !C && D && E)
            {
                /// ___ hours and ___ minutes while documenting
                /// sleep apnea/hypopnea ( ___ hours and ___ minutes supine)
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supHrStr = supHrs.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while documenting sleep apnea/hypopnea (all supine)";


                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea ("
                    + supHrStr + " hours and " + supMinStr + " minutes supine)";
            }

            if (A && B && C && !D && !E)
            {
                /// ___ hours and ___ minutes while documenting
                /// sleep apnea/hypopnea (none supine).
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");

                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while documenting sleep apnea/hypopnea (none supine)";
            }

            return "";

        }

        private string getTxTimes()
        {
            bool TSTmore60 = this.final_sleepTime > 60;
            bool TSTmore120 = this.final_sleepTime > 120;
            bool supineIs0 = this.final_supineSleepTime == 0.0;
            bool supineMore60 = this.final_supineSleepTime > 60;
            bool supineMore120 = this.final_supineSleepTime > 120;
            string str = this.comboBox_finalCpap.Text.Remove(0, 3);
            float psgHrs, psgMins, supHrs, supMins;
            this.minutesToTime(out psgMins, out psgHrs, this.final_sleepTime);
            this.minutesToTime(out supMins, out supHrs, this.final_supineSleepTime);

            bool A = TSTmore60, B = TSTmore120, C = supineIs0,
            D = supineMore60, E = supineMore120;

            if (!A && !B && !C && !D && !E)
            {
                /// ___ minutes while using CPAP at str H2O (___ minutes supine)
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgMinStr + " minutes while using CPAP at " + str + " cm H2O (all supine).\r\n";

                return psgMinStr + " minutes while using CPAP at " + str + " cm H2O ("
                    + supMinStr + " minutes supine).\r\n";
            }

            if (!A && !B && C && !D && !E)
            {
                /// ___minutes while using CPAP at str H2O (none supine)
                /// 
                string psgMinStr = psgMins.ToString("###");

                return psgMinStr + " minutes while using CPAP at "
                    + str + " cm H2O (none supine).\r\n";
            }

            if (A && !B && !C && !D && !E)
            {
                /// 1 hour and ___ minutes while using CPAP at str H2O (___minutes supine)
                ///

                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "1 hour and " + psgMinStr
                        + " minutes while using CPAP at " + str + " cm H2O "
                        + "(all supine).\r\n";

                return "1 hour and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O "
                    + "(" + supMinStr + " minutes supine).\r\n";
            }

            if (A && !B && !C && D && !E)
            {
                /// 1 hour and ___ minutes while using CPAP at str H2O (1 hour and ___ minutes supine)
                /// 
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return "1 hour and " + psgMinStr
                        + " minutes while using CPAP at " + str + " cm H2O (all supine).\r\n";

                return "1 hour and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O (1 hour and "
                    + supMinStr + " minutes supine).\r\n";
            }

            if (A && !B && C && !D && !E)
            {
                /// 1 hour and ___ minutes while using CPAP at str H2O (none supine)
                /// 
                string psgMinStr = psgMins.ToString("###");

                return "1 hour and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O (none supine).\r\n";
            }

            if (A && B && !C && !D && !E)
            {
                ///  ___ hours and ___ minutes while using CPAP at str H2O (___ minutes supine)
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while using CPAP at " + str + " cm H2O (all supine).\r\n";


                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O ("
                    + supMinStr + " minutes supine).\r\n";
            }

            if (A && B && !C && D && !E)
            {
                /// ___ hours and ___ minutes while using CPAP at str H2O (1 hour and ___ minutes supine)
                ///
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while using CPAP at " + str + " cm H2O (all supine).\r\n";

                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O ("
                    + "1 hour and " + supMinStr + " minutes supine).\r\n";
            }

            if (A && B && !C && D && E)
            {
                /// ___ hours and ___ minutes while using CPAP at str H2O ( ___ hours and ___ minutes supine)
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                string supHrStr = supHrs.ToString("###");
                string supMinStr = supMins.ToString("###");
                if (psgMins == supMins)
                    return psgHrStr + " hours and " + psgMinStr
                        + " minutes while using CPAP at " + str + " cm H2O (all supine).\r\n";


                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O ("
                    + supHrStr + " hours and " + supMinStr + " minutes supine).\r\n";
            }

            if (A && B && C && !D && !E)
            {
                /// ___ hours and ___ minutes while using CPAP at str H2O (none supine).
                /// 
                string psgHrStr = psgHrs.ToString("###");
                string psgMinStr = psgMins.ToString("###");
                return psgHrStr + " hours and " + psgMinStr
                    + " minutes while using CPAP at " + str + " cm H2O (none supine).\r\n";
            }
            return "";
        }

        private string getTST_CommentTSTandPosition()
        {

            bool TSTmore60 = this.total_SleepTimeMin > 60;
            bool TSTmore120 = this.total_SleepTimeMin > 120;
            float TSThrs, TSTmins;
            this.minutesToTime(out TSTmins, out TSThrs, this.total_SleepTimeMin);


            bool A = TSTmore60, B = TSTmore120;

            if (!A && !B)
            {
                /// The pt slept ___ minutes
                /// 
                string TSTminStr = TSTmins.ToString("###");
                string TSThrStr = TSThrs.ToString("###");
                return "The patient slept " + TSTminStr + " minutes";
            }

            if (A && B)
            {
                /// The pt slept ___ hours and ___ minutes
                /// 
                string TSTminStr = TSTmins.ToString("###");
                string TSThrStr = TSThrs.ToString("###");
                return "The patient slept " + TSThrStr
                    + " hours and " + TSTminStr + " minutes";
            }

            if (!A && B)
            {
                /// The pt slept 1 hour and ___ minutes
                /// 
                string TSTminStr = TSTmins.ToString("###");
                string TSThrStr = TSThrs.ToString("###");
                return "The patient slept 1 hour and " + TSTminStr + " minutes";
            }

            return null;


        }
    }
}
