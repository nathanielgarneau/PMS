using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class UserSettingPage : ContentPage
    {
        public UserSettingPage()
        {
            InitializeComponent();
            Title = "User Settings";
            UserSettingListView.ItemTemplate = new DataTemplate(typeof (UserSettingViewModel));
            UserSettingListView.ItemsSource = ApiClient.UserSetting.GetAll();


            UserSettingListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            UserSettingListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {UserSettingListView}
            };
            Content = layout;
        }

        public ListView UserSettingListView { get; set; }
    }
}