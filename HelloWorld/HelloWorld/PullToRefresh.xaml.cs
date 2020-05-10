using HelloWorld.Models;
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
    public partial class PullToRefresh : ContentPage
    {

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact> {
                    new Contact {Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100/people/1" }
                ,   new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status="Hey, let's talk" }
            };

            if(String.IsNullOrWhiteSpace(searchText))
            {
                return contacts;
            }
            else
            {
                return contacts.Where(c => c.Name.StartsWith(searchText));
            }
        }

        public PullToRefresh()
        {
            InitializeComponent();
            listView.ItemsSource = GetContacts();
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            //listView.IsRefreshing = false;
            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }
    }
}