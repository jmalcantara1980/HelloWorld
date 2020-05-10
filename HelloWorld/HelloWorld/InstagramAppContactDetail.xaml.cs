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
    public partial class InstagramAppContactDetail : ContentPage
    {

        private UserService _userService = new UserService();

        public InstagramAppContactDetail(int userId)
        {
                        
            BindingContext = _userService.GetUser(userId); 

            InitializeComponent();
        }
    }
}