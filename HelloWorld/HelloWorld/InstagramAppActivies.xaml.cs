using HelloWorld.Models;
using HelloWorld.Services;
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
    public partial class InstagramAppActivies : ContentPage
    {
        ActivityService _activityService = new ActivityService();
        UserService _userService = new UserService();

        public InstagramAppActivies()
        {
            InitializeComponent();

            listView.ItemsSource = _activityService.GetActivities();

        }

        void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }

            var activity = e.SelectedItem as Activity;
            
            listView.SelectedItem = null;

            Navigation.PushAsync(new InstagramAppContactDetail(activity.UserId));
            
        }
    }
}