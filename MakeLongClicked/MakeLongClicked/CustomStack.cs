using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MakeLongClicked
{
    class CustomStack: StackLayout
    {
       public event EventHandler<ClickedEventArg> LongPressActivated;
       
        public virtual void OnLongPressActivated( ClickedEventArg e)
        {
            LongPressActivated.Invoke(this, e);
           
        }

    }
}
