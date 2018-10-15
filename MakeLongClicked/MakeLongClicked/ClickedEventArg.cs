using System;
using System.Collections.Generic;
using System.Text;

namespace MakeLongClicked
{
  public  class ClickedEventArg: EventArgs
    {
        public string type = "click";
       public ClickedEventArg(string type)
        {
            this.type = type;
        }
    }
}
