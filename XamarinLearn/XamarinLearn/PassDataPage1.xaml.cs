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
    public partial class PassDataPage1 : ContentPage
    {
        public PassDataPage1(string arg)
        {
            InitializeComponent();
            this.UserName.Text = arg;
        }
    }
}