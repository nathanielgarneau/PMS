using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class IdentificationTypePage : ContentPage
    {
        public IdentificationTypePage()
        {
            InitializeComponent();
            Title = "Identification Type";
            IdentificationTypeListView.ItemTemplate = new DataTemplate(typeof (IdentificationTypeViewModel));
            IdentificationTypeListView.ItemsSource = ApiClient.IdentificationType.GetAll();


            IdentificationTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            IdentificationTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {IdentificationTypeListView}
            };
            Content = layout;
        }

        public ListView IdentificationTypeListView { get; set; }
    }
}