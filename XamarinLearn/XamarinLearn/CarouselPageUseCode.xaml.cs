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
    public partial class CarouselPageUseCode : CarouselPage
    {
        public CarouselPageUseCode()
        {
            InitializeComponent();
            RenderContent();
        }

        public void RenderContent()
        {
            var p1 = new ContentPage()
            {
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Image()
                        {
                            Source = "Beauty1.jpg",
                            Aspect = Aspect.AspectFill
                        }
                    },
                    Margin = new Thickness(20)
                }
            };

            var p2 = new ContentPage()
            {
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Image()
                        {
                            Source = "Beauty2.jpg",
                            Aspect = Aspect.AspectFill
                        }
                    },
                    Margin = new Thickness(20)
                }
            };

            var p3 = new ContentPage()
            {
                Content = new StackLayout()
                {
                    Children =
                    {
                        new Image()
                        {
                            Source = "Beauty3.jpg",
                            Aspect = Aspect.AspectFill
                        }
                    },
                    Margin = new Thickness(20)
                }
            };

            this.Children.Add(p1);
            this.Children.Add(p2);
            this.Children.Add(p3);
        }
    }
}