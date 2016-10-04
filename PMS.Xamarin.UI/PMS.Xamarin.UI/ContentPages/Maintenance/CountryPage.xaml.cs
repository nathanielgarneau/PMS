using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class CountryPage : ContentPage
    {
        public CountryPage()
        {
            InitializeComponent();
            Title = "Country";
            CountryListView.ItemTemplate = new DataTemplate(typeof (CountryViewModel));
            CountryListView.ItemsSource = ApiClient.Country.GetAll();


            CountryListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            CountryListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {CountryListView}
            };
            Content = layout;
        }

        public ListView CountryListView { get; set; }
    }
}