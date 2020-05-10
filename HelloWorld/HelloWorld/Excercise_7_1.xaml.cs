using HelloWorld.Models;
using HelloWorld.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Excercise_7_1 : ContentPage
    {

        private SearchService _searchService;
        private List<SearchGroup> _searchGroups;

        public Excercise_7_1()   {

            _searchService = new SearchService();

            InitializeComponent();

            PopulateListView(_searchService.GetRecentSearches());
        }
        
        private void PopulateListView(IEnumerable<Search> searches)
        {
            _searchGroups = new List<SearchGroup>
            {
                new SearchGroup("Recent Searches", searches)
            };

            listView.ItemsSource = _searchGroups;
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(e.NewTextValue));
        }

        private void OnRefreshing(object sender, EventArgs e)
        {
            PopulateListView(_searchService.GetRecentSearches(searchBar.Text));
            listView.EndRefresh();
        }

        private void OnSearchSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Selected", search.Location, "OK");
        }

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;

            _searchGroups[0].Remove(search);

            _searchService.DeleteSearch(search.Id);
        }
    }
}