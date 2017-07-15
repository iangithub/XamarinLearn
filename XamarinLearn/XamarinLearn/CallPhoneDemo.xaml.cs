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
    public partial class CallPhoneDemo : ContentPage
    {
        public CallPhoneDemo()
        {
            InitializeComponent();
        }

        private void DialPhone_OnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.PhoneNum.Text))
            {
                Device.OpenUri(new Uri("tel://" + this.PhoneNum.Text + ""));
            }
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.PhoneNum.Text))
            {
                Device.OpenUri(new Uri("tel://" + this.PhoneNum.Text + ""));
            }
            else
            {
                DisplayAlert("Alert", "Pls Input Phone Number", "OK");
            }
        }
    }
}