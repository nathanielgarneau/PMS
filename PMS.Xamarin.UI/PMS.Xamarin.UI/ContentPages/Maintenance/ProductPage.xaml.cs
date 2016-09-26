using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
             Title = "Product Page";
            ProductListView.ItemTemplate = new DataTemplate(typeof(ProductViewModel));
            ProductListView.ItemsSource = WebApiClient.ApiClient.Product.GetAll();
           
         
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
