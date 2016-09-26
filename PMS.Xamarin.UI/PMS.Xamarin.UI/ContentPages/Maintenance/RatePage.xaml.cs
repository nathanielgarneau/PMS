using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class RatePage : ContentPage
    {
        public RatePage()
        {
            InitializeComponent();
            Title = "Rate";
            RateListView.ItemTemplate = new DataTemplate(typeof(RateViewModel));
            RateListView.ItemsSource = WebApiClient.ApiClient.Rate.GetAll();
           
         
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
