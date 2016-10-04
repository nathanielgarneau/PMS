using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ClientPage : ContentPage
    {
        public ClientPage()
        {
            InitializeComponent();
            Title = "Client";
            ClientListView.ItemTemplate = new DataTemplate(typeof (ClientViewModel));
            ClientListView.ItemsSource = ApiClient.Client.GetAll();


            ClientListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ClientListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ClientListView}
            };
            Content = layout;
        }

        public ListView ClientListView { get; set; }
    }
}