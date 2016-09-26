using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
            Title = "Settings";
            SettingListView.ItemTemplate = new DataTemplate(typeof(SettingViewModel));
            SettingListView.ItemsSource = WebApiClient.ApiClient.Setting.GetAll();
           
         
            SettingListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            SettingListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {SettingListView}
            };
            Content = layout;
        }

        public ListView SettingListView { get; set; }
    }
}
