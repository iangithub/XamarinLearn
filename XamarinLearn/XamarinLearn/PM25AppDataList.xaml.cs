using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLearn.Lib;

namespace XamarinLearn
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PM25AppDataList : ContentPage
	{
        public List<PM25Data> Items { get; set; }

        public PM25AppDataList ()
		{
			InitializeComponent ();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            PM25DataService service = new PM25DataService();
            this.Pm25ItemsList.ItemsSource = await service.GetDataFromOpenDataAsync();
        }

	    private void Pm25ItemsList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
            var item = e.SelectedItem as PM25Data;

            var itempage = new PM25AppDataItem();

            itempage.BindingContext = item;

            Navigation.PushAsync(itempage);
        }
	}
}