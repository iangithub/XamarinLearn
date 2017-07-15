using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLearn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new XamarinLearn.MainPage();
            //MainPage = new XamarinLearn.GridDemoComputer();
            //MainPage = new XamarinLearn.CarouselPageDemo();
            //MainPage = new XamarinLearn.CarouselPageUseCode();
            //MainPage = new XamarinLearn.ControlLevelRes();
            //MainPage = new XamarinLearn.ApplicationLevelRes();
            //MainPage = new XamarinLearn.ControlLeaveRes2();
            //MainPage = new XamarinLearn.TabbedPageDemo();
            //MainPage = new XamarinLearn.CallPhoneDemo();
            //MainPage = new NavigationPage(new XamarinLearn.NavigationMainPage());
            //MainPage = new NavigationPage(new XamarinLearn.PassDataMainPage());
            //MainPage = new NavigationPage(new XamarinLearn.TakePhoto());
            MainPage = new NavigationPage(new XamarinLearn.PM25AppMainPage());


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
