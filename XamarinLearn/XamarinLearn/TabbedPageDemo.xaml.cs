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
    public partial class TabbedPageDemo : TabbedPage
    {
        public TabbedPageDemo ()
        {
            InitializeComponent();
            this.Children.Add(new TContentPage1() { Title = "蘋果日報", Icon = "appicon.png" });
            this.Children.Add(new TContentPage2() { Title = "Mobile01", Icon = "mobile01icon.png" });
            this.Children.Add(new TContentPage3() { Title = "關於APP", Icon = "abouticon.png" });
        }
    }
}