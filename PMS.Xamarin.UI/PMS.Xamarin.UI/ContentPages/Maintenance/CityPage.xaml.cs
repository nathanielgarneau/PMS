using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class CityPage : ContentPage
    {
        private readonly ListView CityListView = new ListView();

        public CityPage()
        {
            InitializeComponent();
            Title = "City";
            CityListView.ItemTemplate = new DataTemplate(typeof (CityViewModel));
            CityListView.ItemsSource = ApiClient.City.GetAll();


            CityListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            CityListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {CityListView}
            };
            Content = layout;
        }
    }
}