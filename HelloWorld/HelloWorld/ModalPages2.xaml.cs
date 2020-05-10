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
    public partial class ModalPages2 : ContentPage
    {
        public ModalPages2()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        // To disable Back Button on Android
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}