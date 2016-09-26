using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class UserSettingsPage : ContentPage
    {
        public UserSettingsPage()
        {
            InitializeComponent();
            Title = "User Settings";
            UserSettingsListView.ItemTemplate = new DataTemplate(typeof(UserSettingsViewModel));
            UserSettingsListView.ItemsSource = WebApiClient.ApiClient.UserSettings.GetAll();
           
         
            UserSettingsListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            UserSettingsListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {UserSettingsListView}
            };
            Content = layout;
        }

        public ListView UserSettingsListView { get; set; }
    }
}
