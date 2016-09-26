using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class TagPage : ContentPage
    {
        public TagPage()
        {
            InitializeComponent();
            Title = "Tag";
            TagListView.ItemTemplate = new DataTemplate(typeof(TagViewModel));
            TagListView.ItemsSource = WebApiClient.ApiClient.Tag.GetAll();
           
         
            TagListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            TagListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {TagListView}
            };
            Content = layout;
        }

        public ListView TagListView { get; set; }
    }
}
