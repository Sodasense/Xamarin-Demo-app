using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Myapp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		int cnt = 0;
		String msg = "";
		public async void DisplayAlert(object obj,EventArgs eventArgs)
        {
			cnt++;
            if (cnt == 1)
            {
				msg = "You pressed the button " + cnt + " time!";
            }
            else
            {
				msg = "You pressed the button " + cnt + " times!";
			}
			await DisplayAlert("Alert", msg, "Ok");
        }
	}
}
