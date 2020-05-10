
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HelloWorld.Models;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{

		public ContactDetailPage(Contact contact)
		{
			
			if (contact == null)
				throw new ArgumentNullException();

			BindingContext = contact; 
			
			InitializeComponent();
		}
	}
}

