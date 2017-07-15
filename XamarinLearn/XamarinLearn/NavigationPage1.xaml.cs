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
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage2());
        }

        private async void ModalPageBtn_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage2());
        }
    }
}