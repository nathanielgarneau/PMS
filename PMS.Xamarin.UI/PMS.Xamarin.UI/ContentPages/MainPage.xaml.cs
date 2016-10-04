using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages
{
    public partial class MainPage : ContentPage
    {
        private const string Pawn = "Pawn";
        private const string Pickup = "Pick-up";
        private const string MakePayment = "Make a Payment";
        private const string Sell = "Sell";
        private const string Purchase = "Purchase";
        private const string Scan = "Scan";
        private const string Maintenance = "Maintenance";
        private const bool Animate = true;
        private readonly ListView NavigationListView = new ListView();

        public MainPage()
        {
            InitializeComponent();
            Title = "Pawn Management";
            NavigationListView.ItemsSource = new List<string>
            {
                Pawn,
                Pickup,
                MakePayment,
                Sell,
                Purchase,
                Scan,
                Maintenance
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
                    case Maintenance:
                        Navigation.PushAsync(new MaintenancePage(), Animate);
                        break;
                    case Pawn:
                        Navigation.PushAsync(new PawnPage(), Animate);
                        break;
                    case Pickup:
                        Navigation.PushAsync(new PickupPage(), Animate);
                        break;
                    case MakePayment:
                        Navigation.PushAsync(new MakePaymentPage(), Animate);
                        break;
                    case Purchase:
                        Navigation.PushAsync(new PurchasePage(), Animate);
                        break;
                    case Scan:
                        Navigation.PushAsync(new ScanPage(), Animate);
                        break;
                    case Sell:
                        Navigation.PushAsync(new SellPage(), Animate);
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