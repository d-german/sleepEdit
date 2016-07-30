using System.Collections.Generic;
using PrelimInterDataManager;
namespace RespirationsComment
{
    public class Sao2Comment
    {
        public Sao2Comment(float lowestSao2)
        {
            mLowestSao2 = lowestSao2;
            initializeSao2Severity();

        }
        private const float SAO2_NORMAL_LOW = 90.0f;
        private string mSao2Results;
        private Severity mSao2Severity;
        private readonly float mLowestSao2;
        private string mFileName;

        public string Sao2Result
        {
            get { return mSao2Results; }
        }


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
                    mSao2Results = getResult();
                }
                catch
                {
                    mSao2Results = "Arterial oxygen saturation remains above "
                    + mLowestSao2.ToString("####") + "%. ";
                }

            }
            else
            {
                mFileName = "abnormal_spo2_comment.xml";
                try
                {
                    mSao2Results = getResult();
                }
                catch
                {
                    mSao2Results = "Arterial oxygen desaturation to "
                    + mLowestSao2.ToString("####") + "% is observed. ";
                }

            }
        }

        private string getResult()
        {
            List<string> list = new List<string>();
            DataReader.readData(mFileName, ref list);
            return list[0].Replace("[lowest_spo2]", mLowestSao2.ToString("####")) + " ";
        }

    }
}
