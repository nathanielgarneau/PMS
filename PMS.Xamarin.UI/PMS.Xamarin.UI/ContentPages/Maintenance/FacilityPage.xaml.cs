using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class FacilityPage : ContentPage
    {
        public FacilityPage()
        {
            InitializeComponent();
             Title = "Facility";
            FacilityListView.ItemTemplate = new DataTemplate(typeof(FacilityViewModel));
            FacilityListView.ItemsSource = WebApiClient.ApiClient.Facility.GetAll();
           
         
            FacilityListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            FacilityListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {FacilityListView}
            };
            Content = layout;
        }

        public ListView FacilityListView { get; set; }
    }
}
