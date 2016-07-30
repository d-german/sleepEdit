using System.Collections.Generic;
using PrelimInterDataManager; 

namespace RespirationsComment
{
    public class PositionEffectComment
    {
        string mPath = null;
        public PositionEffectComment(float lateralRdi, float supineRdi, float lateralSleepTime)
        {
            mLateralRdi = lateralRdi;
            mSupineRdi = supineRdi;
            mLateralSleepTime = lateralSleepTime;
            initializePosEffect();
        }

        private float mLateralRdi;
        private float mSupineRdi;
        private float mLateralSleepTime;
        private Effect mPositionEffect;
        public RespirationsComment.Effect PositionEffect
        {
            get { return mPositionEffect; }

        }
        private string mPosEffectResult;
        public string PosEffectComment
        {
            get { return mPosEffectResult; }
        }

        private void initializePosEffect()
        {
            if (isAbnormalSupineRdi() && isEffect() && isEnoughLateralSleep())
            {
                mPositionEffect = Effect.True;
            }
            getPosEffect();
        }

        private bool isEnoughLateralSleep()
        {
            return mLateralSleepTime >= DurationComment.MinimumLateralDuration;
        }

        private bool isEffect()
        {
            return mSupineRdi >= (2 * mLateralRdi);
        }

        private bool isAbnormalSupineRdi()
        {
            return Respirations.getSeverity(mSupineRdi) != Severity.Normal;
        }

        private void getPosEffect()
        {

            if (mPositionEffect == Effect.True)
            {
                if (Respirations.getSeverity(mLateralRdi) == Severity.Normal)
                {

                    try
                    {
                        mPath = "position_effect_normal_lateral_comment.xml";
                        mPosEffectResult = getResult();
                        mPosEffectResult = mPosEffectResult.Replace("[supine_RDI]", mSupineRdi.ToString("####"));
                        mPosEffectResult += " ";

                    }
                    catch
                    {
                        mPosEffectResult =
                            "A position effect is noted with "
                            + mSupineRdi.ToString("####") + " events per hour of sleep supine versus "
                            + "normal respirations laterally. ";
                    }
                }
                else
                {
                    try
                    {
                        mPath = "position_effect_abnormal_lateral_comment.xml";
                        mPosEffectResult = getResult();
                        mPosEffectResult = mPosEffectResult.Replace("[supine_RDI]", mSupineRdi.ToString("####"));
                        mPosEffectResult = mPosEffectResult.Replace("[lateral_RDI]", mLateralRdi.ToString("####"));
                        mPosEffectResult += " ";
                    }
                    catch
                    {
                        mPosEffectResult =
                            "A position effect is noted with "
                            + mSupineRdi.ToString("####") + " events per hour of sleep supine versus "
                            + mLateralRdi.ToString("####") + " events per hour of sleep laterally. ";
                    }
                }
            }
        }

        private string getResult()
        {
            List<string> list = new List<string>();
            DataReader.readData(mPath, ref list);
            return list[0];
        }
    }
}
