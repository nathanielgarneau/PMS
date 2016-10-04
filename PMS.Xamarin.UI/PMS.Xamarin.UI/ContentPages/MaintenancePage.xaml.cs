using System;
using System.Collections.Generic;
using PMS.Xam.UI.ContentPages.Maintenance;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages
{
    public partial class MaintenancePage : ContentPage
    {
        private const string Address = "Address";
        private const string City = "City";
        private const string Client = "Client";
        private const string Colour = "Colour";
        private const string Condition = "Condition";
        private const string Country = "Country";
        private const string Facility = "Facility";
        private const string IdentificationType = "Identification Type";
        private const string Location = "Location";
        private const string Note = "Note";
        private const string Pawn = "Pawn";
        private const string Payment = "Payment";
        private const string PaymentType = "Payment Type";
        private const string Product = "Product";
        private const string ProductType = "Product Type";
        private const string Province = "Province";
        private const string Purchase = "Purchase";
        private const string Rate = "Rate";
        private const string Setting = "Setting";
        private const string Tag = "Tag";
        private const string User = "User";
        private const string UserSetting = "UserSetting";

        private const bool Animate = true;
        private readonly ListView NavigationListView = new ListView();

        public MaintenancePage()
        {
            InitializeComponent();
            Title = "Maintenance";
            NavigationListView.ItemsSource = new List<string>
            {
                Address,
                City,
                Client,
                Colour,
                Condition,
                Country,
                Facility,
                IdentificationType,
                Location,
                Note,
                Pawn,
                Payment,
                PaymentType,
                Product,
                ProductType,
                Province,
                Purchase,
                Rate,
                Setting,
                Tag,
                User,
                UserSetting
            };
            NavigationListView.ItemSelected += NavigationListView_ItemSelected;
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {NavigationListView}
            };
            Content = layout;
        }

        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                if (e.SelectedItem == null) return;
                switch (e.SelectedItem.ToString())
                {
                    case Address:
                        Navigation.PushAsync(new AddressPage(), Animate);
                        break;
                    case City:
                        Navigation.PushAsync(new CityPage(), Animate);
                        break;
                    case Client:
                        Navigation.PushAsync(new ClientPage(), Animate);
                        break;
                    case Colour:
                        Navigation.PushAsync(new ColourPage(), Animate);
                        break;
                    case Condition:
                        Navigation.PushAsync(new ConditionPage(), Animate);
                        break;
                    case Country:
                        Navigation.PushAsync(new CountryPage(), Animate);
                        break;
                    case Facility:
                        Navigation.PushAsync(new FacilityPage(), Animate);
                        break;
                    case IdentificationType:
                        Navigation.PushAsync(new IdentificationTypePage(), Animate);
                        break;
                    case Location:
                        Navigation.PushAsync(new LocationPage(), Animate);
                        break;
                    case Note:
                        Navigation.PushAsync(new NotePage(), Animate);
                        break;
                    case Pawn:
                        Navigation.PushAsync(new PawnPage(), Animate);
                        break;
                    case Payment:
                        Navigation.PushAsync(new PaymentPage(), Animate);
                        break;
                    case PaymentType:
                        Navigation.PushAsync(new PaymentTypePage(), Animate);
                        break;
                    case Product:
                        Navigation.PushAsync(new ProductPage(), Animate);
                        break;
                    case ProductType:
                        Navigation.PushAsync(new ProductTypePage(), Animate);
                        break;
                    case Province:
                        Navigation.PushAsync(new ProvincePage(), Animate);
                        break;
                    case Purchase:
                        Navigation.PushAsync(new PurchasePage(), Animate);
                        break;
                    case Rate:
                        Navigation.PushAsync(new RatePage(), Animate);
                        break;
                    case Setting:
                        Navigation.PushAsync(new SettingPage(), Animate);
                        break;
                    case Tag:
                        Navigation.PushAsync(new TagPage(), Animate);
                        break;
                    case User:
                        Navigation.PushAsync(new UserPage(), Animate);
                        break;
                    case UserSetting:
                        Navigation.PushAsync(new UserSettingPage(), Animate);
                        break;
                    default:
                        throw new NotImplementedException();
                }
                NavigationListView.SelectedItem = null;
            }
            catch
            {
            }
        }
    }
}