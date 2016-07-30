using System;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
    public class StatementGroup : Protocol
    {

        public StatementGroup()
        {
            
        }

        List<Statement> statementList = new List<Statement>();

        public List<Statement> StatementList
        {
            get { return statementList; }
            set { statementList = value; }
        }
    }
}
