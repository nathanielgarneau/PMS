using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            Title = "User";
            UserListView.ItemTemplate = new DataTemplate(typeof(UserViewModel));
            UserListView.ItemsSource = WebApiClient.ApiClient.User.GetAll();
           
         
            UserListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            UserListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {UserListView}
            };
            Content = layout;
        }

        public ListView UserListView { get; set; }
    }
}
