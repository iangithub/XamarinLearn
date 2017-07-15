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
    public partial class PM25AppRedData : ContentPage
    {
        public PM25AppRedData()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            PM25DataService service = new PM25DataService();
            var result = await service.GetDataFromOpenDataAsync();
            this.Pm25ItemsList.ItemsSource = result.FindAll(x => decimal.Parse(x.PM25) >= decimal.Parse("7")).ToList();
        }
    }
}