using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MakeLongClicked
{
	public partial class MainPage : ContentPage
	{
        CustomStack downloader = DependencyService.Get<CustomStack>();
        Label label;
        public MainPage()
		{
			InitializeComponent();
            CustomStack customStack = new CustomStack() { BackgroundColor=Color.Black};
            customStack.LongPressActivated += CustomStack_LongPressActivated;
             label = new Label() { Text = "Test Long And clicked Stacklayout",TextColor=Color.White };
            customStack.Children.Add(label);
            Test_clicked_layout.Children.Add(customStack);
         

        }

        private void CustomStack_LongPressActivated(object sender, ClickedEventArg e)
        {
            if (e.type.Equals("click"))
            {
                label.Text = "click event";
            }
            else {
                label.Text = "Long click event";

            }

        }
    }
}
