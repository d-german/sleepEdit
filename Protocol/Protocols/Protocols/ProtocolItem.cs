using System;
using System.Collections.Generic;
using System.Text;

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
        public ProtocolItem(string str, ProtocolItemType type)
        {
            mText = str;
            mType = type;
        }
        
        public string mText;
        public ProtocolItemType mType;
    }

    public class ProtocolItemList
    {
        public ProtocolItemList(string str)
        {
            mstring = str;
            parseText();
        }
        private string mstring;
        public List<ProtocolItem> mItemList = new List<ProtocolItem>();

        public void parseText()
        {
            string[] stringSeparators = new string[] { "[", "]"};

            string[] result;

            result = mstring.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string resStr in result)
            {
                if(resStr.Contains("LINK"))
                {
                    string[] stringSep = new string[] { "LINK" };
                    stringSep = resStr.Split(stringSep, StringSplitOptions.RemoveEmptyEntries);
                    mItemList.Add(new ProtocolItem(stringSep[0].Trim(), ProtocolItemType.Link));
                }
                else
                if (resStr.Contains("QUESTION"))
                {
                    string[] stringSep = new string[] { "QUESTION" };                    
                    mItemList.Add(new ProtocolItem(null, ProtocolItemType.Question));
                }
                else
                    mItemList.Add(new ProtocolItem(resStr, ProtocolItemType.Text));

            }
        }
    };



}
