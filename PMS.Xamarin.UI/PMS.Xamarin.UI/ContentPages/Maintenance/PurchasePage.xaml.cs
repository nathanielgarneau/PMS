using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class PurchasePage : ContentPage
    {
        public PurchasePage()
        {
            InitializeComponent();
            Title = "Purchase";
            PurchaseListView.ItemTemplate = new DataTemplate(typeof(PurchaseViewModel));
            PurchaseListView.ItemsSource = WebApiClient.ApiClient.Purchase.GetAll();
           
         
            PurchaseListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            PurchaseListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {PurchaseListView}
            };
            Content = layout;
        }

        public ListView PurchaseListView { get; set; }
    }
}
