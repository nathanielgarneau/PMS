using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();
             Title = "Payment";
          PaymentListView.ItemTemplate = new DataTemplate(typeof(PaymentViewModel));
            PaymentListView.ItemsSource = WebApiClient.ApiClient.Payment.GetAll();
           
         
            PaymentListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            PaymentListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {PaymentListView}
            };
            Content = layout;
        }

        public ListView PaymentListView { get; set; }
    }
}
