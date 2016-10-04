using PMS.Xam.UI.Views.ViewCells;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ColourPage : ContentPage
    {
        private readonly ListView ColourListView = new ListView();

        public ColourPage()
        {
            InitializeComponent();
            Title = "Colour";
            ColourListView.ItemTemplate = new DataTemplate(typeof (ColourViewCell));
            ColourListView.ItemsSource = ApiClient.Colour.GetAll();
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