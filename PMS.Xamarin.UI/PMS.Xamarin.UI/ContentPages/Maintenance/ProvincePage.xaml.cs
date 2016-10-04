using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ProvincePage : ContentPage
    {
        public ProvincePage()
        {
            InitializeComponent();
            Title = "Province";
            ProvinceListView.ItemTemplate = new DataTemplate(typeof (ProvinceViewModel));
            ProvinceListView.ItemsSource = ApiClient.Province.GetAll();


            ProvinceListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ProvinceListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ProvinceListView}
            };
            Content = layout;
        }

        public ListView ProvinceListView { get; set; }
    }
}