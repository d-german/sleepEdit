namespace RespirationsComment
{
    internal class RemEffectComment
    {
        private readonly float mRemRdi;
        private readonly float mTotalRdi;

        public RemEffectComment(float remRdi, float totalRdi)
        {
            mRemRdi = remRdi;
            mTotalRdi = totalRdi;
            initializeRemEffect();
        }

        public Effect RemEffect { get; private set; }

        public string RemEffectResult { get; private set; }

        private void initializeRemEffect()
        {
            if (isAbnormalRdi() && isEffect())
            {
                RemEffect = Effect.True;
            }
            getRemEffect();
        }

        private bool isEffect()
        {
            return mRemRdi >= 2*mTotalRdi;
        }

        private bool isAbnormalRdi()
        {
            return Respirations.getSeverity(mRemRdi) != Severity.Normal;
        }

        public void getRemEffect()
        {
            if (RemEffect == Effect.True)
                RemEffectResult = "These events increase in frequency during REM sleep with "
                                  + mRemRdi.ToString("####") + " events per hour of REM sleep. ";
            else
                RemEffectResult = "";
        }
    }
}