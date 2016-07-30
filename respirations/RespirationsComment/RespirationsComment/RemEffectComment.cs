using System;
using System.Collections.Generic;
using System.Text;

namespace RespirationsComment
{
    class RemEffectComment
    {
        public RemEffectComment(float remRdi, float totalRdi)
        {
            mRemRdi = remRdi;
            mTotalRdi = totalRdi;
            initializeRemEffect();
        }

        private float mRemRdi;
        private Effect mRemEffect;
        public RespirationsComment.Effect RemEffect
        {
            get { return mRemEffect; }
        }
        private float mTotalRdi;

        private string mRemEffectComment;
        public string RemEffectResult
        {
            get { return mRemEffectComment; }
        }

        private void initializeRemEffect()
        {
            if (isAbnormalRdi() && isEffect())
            {
                mRemEffect = Effect.True;
            }
            getRemEffect();
        }

        private bool isEffect()
        {
            return mRemRdi >= (2 * mTotalRdi);
        }

        private bool isAbnormalRdi()
        {
            return Respirations.getSeverity(mRemRdi) != Severity.Normal;
        }

        public void getRemEffect()
        {
            if (mRemEffect == Effect.True)
                mRemEffectComment = "These events increase in frequency during REM sleep with "
                    + mRemRdi.ToString("####") + " events per hour of REM sleep. ";
            else
                mRemEffectComment = "";

        }
    }
}
