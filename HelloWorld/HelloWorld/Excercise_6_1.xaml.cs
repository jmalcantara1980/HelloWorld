using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Excercise_6_1 : ContentPage
    {

        int currentImage;
        UriImageSource source;
        string baseUri = "http://lorempixel.com/1920/1080/city/";

        public Excercise_6_1()
        {
            InitializeComponent();
            
            // Load the first image
            currentImage = 1;
            source = new UriImageSource
            {
                CachingEnabled = false
            };
            image.Source = source;
            setImage();
        }

        private void setImage()
        {
            source.Uri = new Uri(baseUri + currentImage.ToString());
        }

        private void btn_Left_Clicked(object sender, EventArgs e)
        {

            currentImage--;
            if (currentImage < 1)
            {
                currentImage = 1;
            }
            setImage();
                
        }

        private void btn_right_Clicked(object sender, EventArgs e)
        {
            currentImage++;
            if (currentImage > 10)
            {
                currentImage = 1;
            }
            setImage();
        }
    }
}