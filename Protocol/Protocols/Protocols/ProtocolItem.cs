using System;
using System.Collections.Generic;

namespace Protocols
{
    public enum ProtocolItemType
    {
        Text,
        Link,
        Question
    }

    public class ProtocolItem
    {
        public string mText;
        public ProtocolItemType mType;

        public ProtocolItem(string str, ProtocolItemType type)
        {
            mText = str;
            mType = type;
        }
    }

    public class ProtocolItemList
    {
        public List<ProtocolItem> mItemList = new List<ProtocolItem>();
        private readonly string mstring;

        public ProtocolItemList(string str)
        {
            mstring = str;
            parseText();
        }

        public void parseText()
        {
            string[] stringSeparators = {"[", "]"};

            string[] result;

            result = mstring.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var resStr in result)
            {
                if (resStr.Contains("LINK"))
                {
                    string[] stringSep = {"LINK"};
                    stringSep = resStr.Split(stringSep, StringSplitOptions.RemoveEmptyEntries);
                    mItemList.Add(new ProtocolItem(stringSep[0].Trim(), ProtocolItemType.Link));
                }
                else if (resStr.Contains("QUESTION"))
                {
                    string[] stringSep = {"QUESTION"};
                    mItemList.Add(new ProtocolItem(null, ProtocolItemType.Question));
                }
                else
                    mItemList.Add(new ProtocolItem(resStr, ProtocolItemType.Text));
            }
        }
    }
}