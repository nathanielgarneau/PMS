using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PMS.Xam.UI.ContentPages.Maintenance.Colour;
using PMS.Xam.UI.Views.ViewCells;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ColourPage : ContentPage
    {
        ListView ColourListView = new ListView();
        public ColourPage()
        {
            InitializeComponent();
             Title = "Colour";
            ColourListView.ItemTemplate = new DataTemplate(typeof(ColourViewCell));
            ColourListView.ItemsSource =  WebApiClient.ApiClient.Colour.GetAll();
            ColourListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ColourListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ColourListView}
            };
            Content = layout;
        }

     
    }
}
