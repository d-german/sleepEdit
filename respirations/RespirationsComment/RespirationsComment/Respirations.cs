using System;
using System.Collections.Generic;
using PrelimInterDataManager;

namespace RespirationsComment
{
   public delegate void GetResultsDelegate();
    #region Common Enums
    public enum Severity
    {
        Normal,
        Mild,
        Moderate,
        ModerateSevere,
        Severe
    }

    public enum Duration
    {
        Absent,
        Limited,
        Normal
    }

    public enum Effect
    {
        False,
        True
    }

    public enum Plurality
    {
        Zero,
        Singular,
        Multiple
    }

    public enum StudyType
    {
        Diagnostic,
        SplitNight,
        Titration,
    }
    #endregion

    public abstract class Respirations
    {
        #region Member Variables
        // Respiratory index rating
        private PositionEffectComment mPositionEffectComment;
        private RemEffectComment mRemEffectComment;
        private Sao2Comment mSao2Comment;
        protected DurationComment mDurationComment;
        protected Effect mEffect;
        protected GetResultsDelegate mAbnormalResultsDelegate;
        protected GetResultsDelegate mNormalResultsDelegate;
        protected Plurality mLateralRdiPlurality;
        protected Plurality mRdiPlurality;
        protected Severity mLateralSeverity;
        protected Severity mRdiSeverity;
        protected Severity mRemSeverity;
        protected Severity mSupineSeverity;
        protected StudyType mStudyType = StudyType.Diagnostic;
        protected const float MILD = 14.4f;
        protected const float MODERATE = 25.4f;
        protected const float MOD_SEVERE = 35.4f;
        protected const float SEVERE = 35.5f;
        protected const float ZERO = 0.0f;       
        protected float mLateralRdi = 0.0f;
        protected float mLateralSleepTime = 0.0f;
        protected float mLowestSao2 = 0.0f;
        protected float mRemRdi = 0.0f;
        protected float mRemSleepTime = 0.0f;
        protected float mSupineRdi = 0.0f;
        protected float mSupineSleepTime = 0.0f;
        protected float mTotalRdi = 0.0f;
        protected float mTotalSleepTime = 0.0f;
        protected static int[,] normalSeverityTable;
        protected static readonly float NORMAL = 4.4f;
        protected string mSeverityResult;
        protected string mTxType; // i.e CPAP or BIPAP
        protected string mTxValue; // i.e 10
        protected string[] mAbnormalSeverityResults = new string[5];
        protected string[] mNormalSeverityResults = new string[6];

        public string Result
        {
            get { return getResult(); }

        }
        #endregion

        protected void initializeData()
        {            
            InitializeLateralSeverity();
            InitializePlurality(mLateralRdi, out mLateralRdiPlurality);
            InitializePlurality(mTotalRdi, out mRdiPlurality);
            InitializePosEffect();
            InitializeRdiSeverity();
            InitializeRemEffect();
            InitializeEffect();
            InitializeRemSeverity();
            InitializeSao2Comment();
            InitializeSupineSeverity();
            initializeDurationResult();
            initializeNormalSeverityTable();
        }

        protected void initializeCommon(
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
            mTotalSleepTime = TotalSleepTime;
            mSupineSleepTime = SupineSleepTime;
            mLateralSleepTime = LateralSleepTime;
            mRemSleepTime = RemSleepTime;
            mTotalRdi = TotalRdi;
            mSupineRdi = SupineRdi;
            mLateralRdi = LateralRdi;
            mRemRdi = RemRdi;
            mLowestSao2 = LowestSao2;
            mNormalResultsDelegate = new GetResultsDelegate(loadNormalDefaultValues);
            mAbnormalResultsDelegate = new GetResultsDelegate(loadAbnormalDefaultValues);
        }

        private void InitializeRdiSeverity()
        {
            if (mTotalRdi <= NORMAL)
                mRdiSeverity = Severity.Normal;
            else
                if (mTotalRdi <= MILD)
                    mRdiSeverity = Severity.Mild;
                else
                    if (mTotalRdi <= MODERATE)
                        mRdiSeverity = Severity.Moderate;
                    else
                        if (mTotalRdi <= MOD_SEVERE)
                            mRdiSeverity = Severity.ModerateSevere;
                        else
                            if (mTotalRdi > SEVERE)
                                mRdiSeverity = Severity.Severe;
                            else
                                System.Diagnostics.Debug.Assert(
                                 false, "No value found in InitializeRdiSeverity().");
        }
        private void InitializeSupineSeverity()
        {
            if (mSupineRdi > NORMAL)
                mSupineSeverity = Severity.Mild;
            //actually could be more than mild
        }
        private void InitializeLateralSeverity()
        {
            if (mLateralRdi > NORMAL)
                mLateralSeverity = Severity.Mild;
        }
        private void InitializeRemSeverity()
        {
            if (mRemRdi > NORMAL)
                mRemSeverity = Severity.Mild;
        }
        private void InitializeEffect()
        {
            if ((mPositionEffectComment.PositionEffect == Effect.True) || (mRemEffectComment.RemEffect == Effect.True))
                mEffect = Effect.True;
        }
        private void InitializeRemEffect()
        {
            mRemEffectComment = new RemEffectComment(mRemRdi, mTotalRdi);
        }
        private void InitializePosEffect()
        {
            mPositionEffectComment = new PositionEffectComment(mLateralRdi, mSupineRdi, mLateralSleepTime);
        }
        private void InitializePlurality(float num, out Plurality val)
        {
            if (num <= 0.4f)
                val = Plurality.Zero;
            else
                if (num <= 1.4f)
                    val = Plurality.Singular;
                else
                    val = Plurality.Multiple;
        }

        protected abstract void loadNormalSeverityValues();
        protected abstract void loadAbnormalSeverityValues();
        protected abstract void loadNormalDefaultValues();
        protected abstract void loadAbnormalDefaultValues();


        private void initializeDurationResult()
        {
            mDurationComment = new DurationComment(mTotalSleepTime, mSupineSleepTime, mRemSleepTime, mStudyType);
        }


        private void InitializeSao2Comment()
        {
            mSao2Comment = new Sao2Comment(mLowestSao2);
        }

        private static void initializeNormalSeverityTable()
        {
            normalSeverityTable = new int[2, 3];
            //     Position or REM Effect,        totalRdi
            normalSeverityTable[(int)Effect.True, (int)Plurality.Zero] = 0;
            normalSeverityTable[(int)Effect.True, (int)Plurality.Singular] = 1;
            normalSeverityTable[(int)Effect.True, (int)Plurality.Multiple] = 2;

            normalSeverityTable[(int)Effect.False, (int)Plurality.Zero] = 3;
            normalSeverityTable[(int)Effect.False, (int)Plurality.Singular] = 4;
            normalSeverityTable[(int)Effect.False, (int)Plurality.Multiple] = 5;
        }

        protected void loadResults(string path, ref List<string> list)
        {            
            DataReader.readData(path, ref list);
        }

        protected void commentOnSeverity()
        {
            if (mRdiSeverity == Severity.Normal)
            {
                int index = normalSeverityTable[(int)mEffect, (int)mRdiPlurality];
                loadNormalSeverityValues();
                mSeverityResult = mNormalSeverityResults[index];
                insertSeverityTagValues();
            }
            else
                if (mRdiSeverity != Severity.Normal)
                {
                    loadAbnormalSeverityValues();
                    mSeverityResult = mAbnormalSeverityResults[(int)mRdiSeverity];
                    insertSeverityTagValues();
                }
        }

        public static Severity getSeverity(float rdi)
        {
            if (rdi > NORMAL)
            {
                return Severity.Mild;
            }
            else
                return Severity.Normal;
        }

        private string getResult()
        {
            return
                mSeverityResult +
                mRemEffectComment.RemEffectResult +
                mPositionEffectComment.PosEffectComment +
                mSao2Comment.Sao2Result +
                mDurationComment.DurationResult;
        }

        public string toStr(float val)
        {
            return val.ToString("####");
        }

        private void insertSeverityTagValues()
        {
            mSeverityResult = mSeverityResult.Replace("[RDI]", toStr(mTotalRdi));
            mSeverityResult = mSeverityResult.Replace("[TX_TYPE]", mTxType);
            mSeverityResult = mSeverityResult.Replace("[TX]", mTxValue);
        }

        protected void load_Results(string path, ref string[] results, GetResultsDelegate defaultResults)
        {
            List<string> list = new List<string>();
            try
            {
                loadResults(path, ref list);

                for (int i = 0; i < list.Count; i++)
                {
                    results[i] = list[i];
                }
            }
            catch
            {
                defaultResults();
            }
        }
    }
}
