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
    public partial class Excercise_1 : ContentPage
    {

        string[] quotes = {
                "Make love not War",
                "Love is the answer",
                "All you need is Love"
            };


        private int currentIndex = 0;

        public Excercise_1()
        {
            InitializeComponent();

            slider.Value = 16;
            
            ChangeQuote();
            
        }

        private void ChangeQuote()
        {
            lblQuote.Text = quotes[currentIndex];
        }

        private void btnNext_Clicked(object sender, EventArgs e)
        {
            if(currentIndex < quotes.Length-1)  {
                currentIndex++;
            } else { currentIndex = 0; }
            
            ChangeQuote();
        }
    }
}