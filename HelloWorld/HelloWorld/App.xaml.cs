using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HierarchicalNavigation();
            
            // To implement navigation
           // MainPage = new NavigationPage (new HierarchicalNavigation());


            // To impmement Modal Pages
            //MainPage = new NavigationPage(new ModalPages());

            // To implement Master Detail
            //MainPage = new TabPage();

            //MainPage = new NavigationPage(new ContactsPageMaster());

            //MainPage = new NavigationPage(new TabbedPage1());

            //MainPage = new NavigationPage(new Carrousel_1());

            //MainPage = new ConfirmationBox_1();

            //MainPage = new NavigationPage(new ToolBar_1());

            MainPage = new NavigationPage(new InstagramApp());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
