using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class PaymentTypePage : ContentPage
    {
        public PaymentTypePage()
        {
            InitializeComponent();
            Title = "Payment Type";
            PaymentTypeListView.ItemTemplate = new DataTemplate(typeof (PaymentTypeViewModel));
            PaymentTypeListView.ItemsSource = ApiClient.PaymentType.GetAll();


            PaymentTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            PaymentTypeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {PaymentTypeListView}
            };
            Content = layout;
        }

        public ListView PaymentTypeListView { get; set; }
    }
}