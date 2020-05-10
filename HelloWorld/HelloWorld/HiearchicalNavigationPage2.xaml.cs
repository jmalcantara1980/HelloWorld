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
    public partial class HiearchicalNavigationPage2 : ContentPage
    {
        public HiearchicalNavigationPage2()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


        // To disable the back button functionality on Androdid
        protected override bool OnBackButtonPressed() {

            return true;

            
        }

    }
}