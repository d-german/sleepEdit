using System;
using System.Collections.Generic;
using System.Text;

namespace Protocols
{
  public  interface IProtocolNodeCmd
    {
      void Execute();
      void UndoExecute();
    }
}
