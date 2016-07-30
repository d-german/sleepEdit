using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class SleepData
    {
        public SleepData() { }

        #region memberVariables
        double? mTotal = null;
        double? mEfficiency = null;
        double? mSleepLatency = null;
        double? mREMLatency = null;
        double? mTotalRecordingTime = null;
        double? mSupineTime = null;
        double? mLateralTime = null;


        double? mPercentW = null;
        double? mPercentN1 = null;
        double? mPercentN2 = null;
        double? mPercentN3 = null;
        double? mPercentREM = null;

        double? mTotalSleepTimeW = null;
        double? mTotalSleepTimeN1 = null;
        double? mTotalSleepTimeN2 = null;
        double? mTotalSleepTimeN3 = null;
        double? mTotalSleepTimeREM = null;
        #endregion
        #region getter_setter

        public double? TotalRecordingTime
        {
            get { return mTotalRecordingTime; }
            set { mTotalRecordingTime = value; }
        }

        public double? Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }
        public double? Efficiency
        {
            get { return mEfficiency; }
            set { mEfficiency = value; }
        }
        public double? SleepLatency
        {
            get { return mSleepLatency; }
            set { mSleepLatency = value; }
        }
        public double? REMLatency
        {
            get { return mREMLatency; }
            set { mREMLatency = value; }
        }
        public double? PercentW
        {
            get { return mPercentW; }
            set { mPercentW = value; }
        }
        public double? PercentN1
        {
            get { return mPercentN1; }
            set { mPercentN1 = value; }
        }
        public double? PercentN2
        {
            get { return mPercentN2; }
            set { mPercentN2 = value; }
        }
        public double? PercentN3
        {
            get { return mPercentN3; }
            set { mPercentN3 = value; }
        }
        public double? PercentREM
        {
            get { return mPercentREM; }
            set { mPercentREM = value; }
        }
        public double? TotalSleepTimeW
        {
            get { return mTotalSleepTimeW; }
            set { mTotalSleepTimeW = value; }
        }
        public double? TotalSleepTimeN1
        {
            get { return mTotalSleepTimeN1; }
            set { mTotalSleepTimeN1 = value; }
        }
        public double? TotalSleepTimeN2
        {
            get { return mTotalSleepTimeN2; }
            set { mTotalSleepTimeN2 = value; }
        }
        public double? TotalSleepTimeN3
        {
            get { return mTotalSleepTimeN3; }
            set { mTotalSleepTimeN3 = value; }
        }
        public double? TotalSleepTimeREM
        {
            get { return mTotalSleepTimeREM; }
            set { mTotalSleepTimeREM = value; }
        }

        public double? SupineTime
        {
            get { return mSupineTime; }
            set { mSupineTime = value; }
        }

        public double? LateralTime
        {
            get { return mLateralTime; }
            set { mLateralTime = value; }
        }
        #endregion
    }
}
