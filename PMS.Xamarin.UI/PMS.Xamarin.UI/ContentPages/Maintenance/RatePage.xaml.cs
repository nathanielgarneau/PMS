using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class RatePage : ContentPage
    {
        public RatePage()
        {
            InitializeComponent();
            Title = "Rate";
            RateListView.ItemTemplate = new DataTemplate(typeof (RateViewModel));
            RateListView.ItemsSource = ApiClient.Rate.GetAll();


            RateListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            RateListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {RateListView}
            };
            Content = layout;
        }

        public ListView RateListView { get; set; }
    }
}