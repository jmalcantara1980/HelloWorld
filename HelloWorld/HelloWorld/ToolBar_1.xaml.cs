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
    public partial class ToolBar_1 : ContentPage
    {
        public ToolBar_1()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated", "OK");
        }
    }
}