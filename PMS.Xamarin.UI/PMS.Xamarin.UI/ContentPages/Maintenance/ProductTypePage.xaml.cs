using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ProductTypePage : ContentPage
    {
        public ProductTypePage()
        {
            InitializeComponent();
            Title = "Product Type";
            ProductTypeListView.ItemTemplate = new DataTemplate(typeof (ProductTypeViewModel));
            ProductTypeListView.ItemsSource = ApiClient.ProductType.GetAll();


            ProductTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ProductTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ProductTypeListView}
            };
            Content = layout;
        }

        public ListView ProductTypeListView { get; set; }
    }
}