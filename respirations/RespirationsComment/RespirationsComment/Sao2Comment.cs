using System.Collections.Generic;
using PrelimInterDataManager;

namespace RespirationsComment
{
    public class Sao2Comment
    {
        private const float SAO2_NORMAL_LOW = 90.0f;
        private readonly float mLowestSao2;
        private string mFileName;
        private Severity mSao2Severity;

        public Sao2Comment(float lowestSao2)
        {
            mLowestSao2 = lowestSao2;
            initializeSao2Severity();
        }

        public string Sao2Result { get; private set; }


        private void initializeSao2Severity()
        {
            if (mLowestSao2 < SAO2_NORMAL_LOW)
            {
                mSao2Severity = Severity.Mild;
            }
            else
            {
                mSao2Severity = Severity.Normal;
            }
            commentOnSao2();
        }

        private void commentOnSao2()
        {
            if (mSao2Severity == Severity.Normal)
            {
                mFileName = "normal_spo2_comment.xml";
                try
                {
                    Sao2Result = getResult();
                }
                catch
                {
                    Sao2Result = "Arterial oxygen saturation remains above "
                                 + mLowestSao2.ToString("####") + "%. ";
                }
            }
            else
            {
                mFileName = "abnormal_spo2_comment.xml";
                try
                {
                    Sao2Result = getResult();
                }
                catch
                {
                    Sao2Result = "Arterial oxygen desaturation to "
                                 + mLowestSao2.ToString("####") + "% is observed. ";
                }
            }
        }

        private string getResult()
        {
            var list = new List<string>();
            DataReader.readData(mFileName, ref list);
            return list[0].Replace("[lowest_spo2]", mLowestSao2.ToString("####")) + " ";
        }
    }
}