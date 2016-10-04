using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class LocationPage : ContentPage
    {
        public LocationPage()
        {
            InitializeComponent();
            Title = "Location";
            LocationListView.ItemTemplate = new DataTemplate(typeof (LocationViewModel));
            LocationListView.ItemsSource = ApiClient.Location.GetAll();


            LocationListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            LocationListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {LocationListView}
            };
            Content = layout;
        }

        public ListView LocationListView { get; set; }
    }
}