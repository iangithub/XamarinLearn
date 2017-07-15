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
    public partial class PassDataMainPage : ContentPage
    {
        public PassDataMainPage()
        {
            InitializeComponent();
           
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PassDataPage1(this.UserName.Text));

        }
    }
}