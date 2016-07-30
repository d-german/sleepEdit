using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
   public  class Protocol
    {
       protected string mTitle = "";
       protected Guid mId = Guid.NewGuid();
       protected Guid mGotoId;

       private List<Section> mSections = new List<Section>();

        
    }
}
