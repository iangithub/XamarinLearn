using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearn
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PM25AppMainPage : ContentPage
	{
		public PM25AppMainPage ()
		{
			InitializeComponent ();
		}

	    private async void Pm25_TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new PM25AppDataList());
        }

	    private async void Pm25Red_TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
            await Navigation.PushAsync(new PM25AppRedData());
        }
	}
}