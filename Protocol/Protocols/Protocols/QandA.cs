using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Protocols
{
   public class QandA : Statement
    {
        private List<String> answerList = new List<string>();

       private int answerListCount;

       public int AnswerCount
       {
           get { return answerList.Count; }
       }

        public List<String> AnswerList
        {
            get { return answerList; }
            set { answerList = value; }
        }


    }
}
