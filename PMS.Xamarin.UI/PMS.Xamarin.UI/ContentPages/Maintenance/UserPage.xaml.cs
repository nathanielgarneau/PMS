using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            Title = "User";
            UserListView.ItemTemplate = new DataTemplate(typeof (UserViewModel));
            UserListView.ItemsSource = ApiClient.User.GetAll();


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