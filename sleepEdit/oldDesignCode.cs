/*
 
        private void minutesToTime(out float minutes, out float hours, float tst)
        {
            minutes = tst;
            hours = 0;
            // Be sure to initialize to 0

            // If our variable is greater than 60
            while (minutes > 60)
            {
                // Remove 60 from our variable
                minutes -= 60;

                // Add 1 to our hours [as 60 minutes is equivalent to one hour]
                hours++;
            }
        }

        private void chechCpapBipapStr(ref string str)
        {

            if (this.comboBox_finalCpap.Text.Contains("/"))
            {
                str = str.Replace("CPAP", "BIPAP");
            }
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



private string oldGetCommentTSTandPosition()
        {
            string str = "";

            if (this.radioButton_PSG.Checked)
            {
                return this.getPsg_CommentTSTandPosition();
            }

            if (this.radioButton_split.Checked)
            {
                str = this.getTST_CommentTSTandPosition() + "; "
                    + this.getDiagnostic_CommentTSTandPosition()
                    + " and " + this.getTxTimes();
                chechCpapBipapStr(ref str);
                return str;
            }//end (this.radioButton_split.Checked)


            if (this.radioButton_titration.Checked)
            {
                str = this.getTST_CommentTSTandPosition()
                    + " while titrating CPAP; " + this.getTxTimes();
                chechCpapBipapStr(ref str);
                return str;

            }//end if (this.radioButton_titration.Checked)

            chechCpapBipapStr(ref str);

            return str;
        }//end getCommentTSTandPosition


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

			bool A = TSTmore60, B = TSTmore120, C = supineIs0,
			D = supineMore60, E = supineMore120;
			///fixed if sup = total
			if (!A && !B && !C && !D && !E)
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

			if (!A && !B && C && !D && !E)
			{
				/// The pt slept ___ minutes; none supine.
				/// 
				string psgMinStr = psgMins.ToString("###");

				return "The patient slept " + psgMinStr
					+ " minutes; none supine.";
			}

			if (A && !B && !C && !D && !E)
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

			if (A && !B && !C && D && !E)
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

			if (A && !B && C && !D && !E)
			{
				/// The pt slept 1 hour and ___ minutes; none supine.
				/// 
				string psgMinStr = psgMins.ToString("###");

				return "The patient slept 1 hour and " + psgMinStr
					+ " minutes; none supine.";
			}

			if (A && B && !C && !D && !E)
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

			if (A && B && !C && D && !E)
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

			if (A && B && !C && D && E)
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

			if (A && B && C && !D && !E)
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


private string getDiagnostic_CommentTSTandPosition()
		{
			bool TSTmore60 = this.diag_sleepTime > 60;
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

*/