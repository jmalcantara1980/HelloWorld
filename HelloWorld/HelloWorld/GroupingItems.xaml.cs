using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupingItems : ContentPage
    {
        

        public GroupingItems()
        {
            InitializeComponent();

            _contacts = new List<ContactGroup>
            {
                new ContactGroup("M","M")
                {
                    new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                },
                new ContactGroup("J", "J")
                {
                    new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }
                }
            };

            listView.ItemsSource = _contacts;
                

        
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
            listView.SelectedItem = null;

        }


        private List<ContactGroup> _contacts;

        void Call_Clicked(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactGroup;
            _contacts.Remove(contact);

        }
    }


}

