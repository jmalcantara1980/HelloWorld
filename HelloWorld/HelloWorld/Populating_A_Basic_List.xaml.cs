using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Populating_A_Basic_List : ContentPage
    {
        public Populating_A_Basic_List()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact> { 
            
                 new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                ,new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }

            };

        }
    }
}