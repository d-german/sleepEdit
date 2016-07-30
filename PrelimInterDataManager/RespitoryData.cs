using System;
using System.Collections.Generic;
using System.Text;

namespace PrelimInterDataManager
{
    public class RespitoryData
    {
        public RespitoryData() { }

        #region memberVariables
        double? mRdiTst = null;
        double? mRdiLateral = null;
        double? mRdiREM = null;
        double? mRdiSupine = null;
        #endregion
        #region getters_setters
        public double? RdiTst
        {
            get { return mRdiTst; }
            set { mRdiTst = value; }
        }

        public double? RdiREM
        {
            get { return mRdiREM; }
            set { mRdiREM = value; }
        }

        public double? RdiSupine
        {
            get { return mRdiSupine; }
            set { mRdiSupine = value; }
        }

        public double? RdiLateral
        {
            get { return mRdiLateral; }
            set { mRdiLateral = value; }
        }
        #endregion

    }
}
