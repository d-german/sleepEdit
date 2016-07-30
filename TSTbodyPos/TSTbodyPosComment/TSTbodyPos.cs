using System.Collections.Generic;
using PrelimInterDataManager;

namespace TSTbodyPosComment
{
    public class TSTbodyPos
    {
        private readonly string mDiagnosticSleep = "";
        private readonly string mDiagnosticSupine = "";
        private readonly string mFileName;
        private string mFinalTxSleep = "";
        private string mFinalTxSleepSupine = "";

        private readonly HoursAndMinutes mSleepTime = new HoursAndMinutes();
        private string mTotalSleep = ""; // [TotalSleep]
        private readonly string mTotalSleepSupine = "";
        private string mTxType = "";
        private string mTxValue = "";

        public TSTbodyPos(double tst, double psgSup)
        {
            mFileName = "diagnostic_TST_BodyPos_comment.xml";
            try
            {
                Result = getResult();
            }
            catch
            {
                Result = "The patient slept [TotalSleep]; [SupineSleep] supine.";
            }

            totalSleep(tst);
            mTotalSleepSupine = mSleepTime.getSleepTime(psgSup);
            Result = Result.Replace("[SupineSleep]", mTotalSleepSupine);
        }

        public TSTbodyPos(double tst, double diagTst, double diagSup, double finalTxTst, double finalTxSup,
            string txType, string txValue)
        {
            mFileName = "split_night_TST_BodyPos_comment.xml";
            try
            {
                Result = getResult();
            }
            catch
            {
                Result =
                    "The patient slept [TotalSleep]; [diagTotalSleep] while documenting sleep apnea/hypopnea ([DiagSupineSleep] supine) and [finalTxSleep] while using [TX_TYPE] at [TX] ([finalTxSupine] supine).";
            }
            totalSleep(tst);
            tx(finalTxTst, finalTxSup, txType, txValue);

            mDiagnosticSleep = mSleepTime.getSleepTime(diagTst);
            mDiagnosticSupine = mSleepTime.getSleepTime(diagSup);

            Result = Result.Replace("[diagTotalSleep]", mDiagnosticSleep);
            Result = Result.Replace("[DiagSupineSleep]", mDiagnosticSupine);
        }

        public TSTbodyPos(double tst, double finalTxTst, double finalTxSup, string txType, string txValue)
        {
            mFileName = "tx_titration_TST_BodyPos_comment.xml";
            try
            {
                Result = getResult();
            }
            catch
            {
                Result =
                    "The patient slept [TotalSleep] while titrating [TX_TYPE]; [finalTxSleep] while using [TX_TYPE] at [TX] ([finalTxSupine] supine).";
            }
            totalSleep(tst);
            tx(finalTxTst, finalTxSup, txType, txValue);
        }

        public string Result { get; set; } = "";

        private void totalSleep(double tst)
        {
            mTotalSleep = mSleepTime.getSleepTime(tst);
            Result = Result.Replace("[TotalSleep]", mTotalSleep);
        }

        private void tx(double finalTxTst, double finalTxSup, string txType, string txValue)
        {
            mTxType = txType;
            mTxValue = txValue;
            mFinalTxSleep = mSleepTime.getSleepTime(finalTxTst);
            mFinalTxSleepSupine = mSleepTime.getSleepTime(finalTxSup);
            Result = Result.Replace("[TX_TYPE]", mTxType);
            Result = Result.Replace("[TX]", mTxValue);
            Result = Result.Replace("[finalTxSleep]", mFinalTxSleep);
            Result = Result.Replace("[finalTxSupine]", mFinalTxSleepSupine);
        }

        private string getResult()
        {
            var list = new List<string>();
            DataReader.readData(mFileName, ref list);
            return list[0] + " ";
        }
    }
}