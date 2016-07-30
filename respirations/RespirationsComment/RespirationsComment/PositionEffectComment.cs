using System.Collections.Generic;
using PrelimInterDataManager;

namespace RespirationsComment
{
    public class PositionEffectComment
    {
        private readonly float mLateralRdi;
        private readonly float mLateralSleepTime;
        private string mPath;
        private readonly float mSupineRdi;

        public PositionEffectComment(float lateralRdi, float supineRdi, float lateralSleepTime)
        {
            mLateralRdi = lateralRdi;
            mSupineRdi = supineRdi;
            mLateralSleepTime = lateralSleepTime;
            initializePosEffect();
        }

        public Effect PositionEffect { get; private set; }

        public string PosEffectComment { get; private set; }

        private void initializePosEffect()
        {
            if (isAbnormalSupineRdi() && isEffect() && isEnoughLateralSleep())
            {
                PositionEffect = Effect.True;
            }
            getPosEffect();
        }

        private bool isEnoughLateralSleep()
        {
            return mLateralSleepTime >= DurationComment.MinimumLateralDuration;
        }

        private bool isEffect()
        {
            return mSupineRdi >= 2*mLateralRdi;
        }

        private bool isAbnormalSupineRdi()
        {
            return Respirations.getSeverity(mSupineRdi) != Severity.Normal;
        }

        private void getPosEffect()
        {
            if (PositionEffect == Effect.True)
            {
                if (Respirations.getSeverity(mLateralRdi) == Severity.Normal)
                {
                    try
                    {
                        mPath = "position_effect_normal_lateral_comment.xml";
                        PosEffectComment = getResult();
                        PosEffectComment = PosEffectComment.Replace("[supine_RDI]", mSupineRdi.ToString("####"));
                        PosEffectComment += " ";
                    }
                    catch
                    {
                        PosEffectComment =
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
                        PosEffectComment = getResult();
                        PosEffectComment = PosEffectComment.Replace("[supine_RDI]", mSupineRdi.ToString("####"));
                        PosEffectComment = PosEffectComment.Replace("[lateral_RDI]", mLateralRdi.ToString("####"));
                        PosEffectComment += " ";
                    }
                    catch
                    {
                        PosEffectComment =
                            "A position effect is noted with "
                            + mSupineRdi.ToString("####") + " events per hour of sleep supine versus "
                            + mLateralRdi.ToString("####") + " events per hour of sleep laterally. ";
                    }
                }
            }
        }

        private string getResult()
        {
            var list = new List<string>();
            DataReader.readData(mPath, ref list);
            return list[0];
        }
    }
}