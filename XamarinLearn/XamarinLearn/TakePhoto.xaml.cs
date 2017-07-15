using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Plugin.Media;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TakePhoto : ContentPage
    {
        //private Plugin.Media.Abstractions.MediaFile file;

        public TakePhoto()
        {
            InitializeComponent();
            //this.PicBtn.Clicked+= async (sender, args) =>
            //{
            //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            //    {
            //        DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
            //        return;
            //    }

            //    file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            //    {
            //        Directory = "Sample",
            //        Name = Guid.NewGuid() + ".jpg"
            //    });


            //    if (file == null)
            //        return;

            //    DisplayAlert("File Location", file.Path, "OK");

            //    this.Photo.Source = ImageSource.FromStream(() =>
            //    {
            //        var stream = file.GetStream();
            //        file.Dispose();
            //        return stream;
            //    });
            //};
        }

        //private async void TakeOnePhoto_OnClicked(object sender, EventArgs e)
        //{
        //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
        //        return;
        //    }

        //    //file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
        //    //{
        //    //    Directory = "Sample",
        //    //    Name = Guid.NewGuid() + ".jpg",
        //    //    SaveToAlbum = true
        //    //});

           
        //}

        //private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        //{
        //    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
        //    {
        //        await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
        //        return;
        //    }
          

        //    //file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
        //    //{
        //    //    Directory = "Sample",
        //    //    Name = Guid.NewGuid() + ".jpg",
        //    //    SaveToAlbum = true
        //    //});

        //    //if (file == null)
        //    //    return;

        //    //this.Photo.Source = ImageSource.FromStream(() =>
        //    //{
        //    //    var stream = file.GetStream();
        //    //    file.Dispose();
        //    //    return stream;
        //    //});
        //}
    }
}