using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class PaymentTypePage : ContentPage
    {
        public PaymentTypePage()
        {
            InitializeComponent();
             Title = "Payment Type";
            PaymentTypeListView.ItemTemplate = new DataTemplate(typeof(PaymentTypeViewModel));
            PaymentTypeListView.ItemsSource = WebApiClient.ApiClient.PaymentType.GetAll();
           
         
            PaymentTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            PaymentTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {PaymentTypeListView}
            };
            Content = layout;
        }

        public ListView PaymentTypeListView { get; set; }
    }
}
