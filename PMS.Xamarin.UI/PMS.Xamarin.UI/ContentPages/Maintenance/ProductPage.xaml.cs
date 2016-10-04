using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
            Title = "Product Page";
            ProductListView.ItemTemplate = new DataTemplate(typeof (ProductViewModel));
            ProductListView.ItemsSource = ApiClient.Product.GetAll();


            ProductListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ProductListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ProductListView}
            };
            Content = layout;
        }

        public ListView ProductListView { get; set; }
    }
}