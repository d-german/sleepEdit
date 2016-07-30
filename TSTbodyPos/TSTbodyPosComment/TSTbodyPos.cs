using System;
using System.Collections.Generic;
using PrelimInterDataManager;

namespace TSTbodyPosComment
{
    public class TSTbodyPos
    {
        private string mFileName;
        public TSTbodyPos(double tst, double psgSup) 
        {
            mFileName = "diagnostic_TST_BodyPos_comment.xml";
            try
            {
                mResult = getResult();
            }
            catch 
            {
                mResult = "The patient slept [TotalSleep]; [SupineSleep] supine.";	
            }
           
            totalSleep(tst);
            mTotalSleepSupine = mSleepTime.getSleepTime(psgSup);
            mResult = mResult.Replace("[SupineSleep]", mTotalSleepSupine);
        }

        public TSTbodyPos(double tst, double diagTst, double diagSup, double finalTxTst, double finalTxSup, string txType, string txValue) 
        {    
            mFileName = "split_night_TST_BodyPos_comment.xml";
            try
            {
                mResult = getResult();
            }
            catch
            {
                mResult = "The patient slept [TotalSleep]; [diagTotalSleep] while documenting sleep apnea/hypopnea ([DiagSupineSleep] supine) and [finalTxSleep] while using [TX_TYPE] at [TX] ([finalTxSupine] supine).";
            }
            totalSleep(tst);
            tx(finalTxTst, finalTxSup, txType, txValue);

            mDiagnosticSleep = mSleepTime.getSleepTime(diagTst);
            mDiagnosticSupine = mSleepTime.getSleepTime(diagSup);

            mResult = mResult.Replace("[diagTotalSleep]", mDiagnosticSleep);
            mResult = mResult.Replace("[DiagSupineSleep]", mDiagnosticSupine);            
        }
        
        public TSTbodyPos(double tst, double finalTxTst, double finalTxSup, string txType, string txValue) 
        {            
            mFileName = "tx_titration_TST_BodyPos_comment.xml";
            try
            {
                mResult = getResult();
            }
            catch
            {
                mResult = "The patient slept [TotalSleep] while titrating [TX_TYPE]; [finalTxSleep] while using [TX_TYPE] at [TX] ([finalTxSupine] supine).";
            }
            totalSleep(tst);
            tx(finalTxTst, finalTxSup, txType, txValue);
        }     
        
        private HoursAndMinutes mSleepTime = new HoursAndMinutes();
        private string mTxType = "";
        private string mTxValue = "";
        private string mTotalSleep = ""; // [TotalSleep]
        private string mTotalSleepSupine = "";
        private string mDiagnosticSleep = "";
        private string mDiagnosticSupine = "";
        private string mFinalTxSleep = "";
        private string mFinalTxSleepSupine = "";
        private string mResult = "";
        public string Result
        {
            get { return mResult; }
            set { mResult = value; }
        }
        private void totalSleep(double tst)
        {
            mTotalSleep = mSleepTime.getSleepTime(tst);
            mResult = mResult.Replace("[TotalSleep]", mTotalSleep);
        }
        private void tx(double finalTxTst, double finalTxSup, string txType, string txValue)
        {
            mTxType = txType;
            mTxValue = txValue;
            mFinalTxSleep = mSleepTime.getSleepTime(finalTxTst);
            mFinalTxSleepSupine = mSleepTime.getSleepTime(finalTxSup);
            mResult = mResult.Replace("[TX_TYPE]", mTxType);
            mResult = mResult.Replace("[TX]", mTxValue);
            mResult = mResult.Replace("[finalTxSleep]", mFinalTxSleep);
            mResult = mResult.Replace("[finalTxSupine]", mFinalTxSleepSupine);
        }

        private string getResult()
        {
            List<string> list = new List<string>();
            DataReader.readData(mFileName, ref list);
            return list[0] + " ";
            
        }
    }
}
