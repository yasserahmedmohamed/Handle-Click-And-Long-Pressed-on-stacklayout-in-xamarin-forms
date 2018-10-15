using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MakeLongClicked;
using MakeLongClicked.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomStack), typeof(ClickedStackAndroid))]

namespace MakeLongClicked.Droid
{
    class ClickedStackAndroid : ViewRenderer
    {
        public event EventHandler<ClickedEventArg> onClickedStack;
        CustomStack view;

#pragma warning disable CS0618 // Type or member is obsolete
        public ClickedStackAndroid()
        {
            this.LongClick += (sender, args) => {
             Toast.MakeText(Context, view.Children.Count+" ", ToastLength.Short).Show();

                view.OnLongPressActivated(new ClickedEventArg("long"));// = new ClickedEventArg("click");
            };
            Click += (sender, args) => {
                 Toast.MakeText(Context, "clicked", ToastLength.Short).Show();

                view.OnLongPressActivated(new ClickedEventArg("click"));// = new ClickedEventArg("click");


            };
        }
#pragma warning restore CS0618 // Type or member is obsolete

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                view = e.NewElement as CustomStack;
            }
        }

    }
}