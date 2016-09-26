using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class PawnPage : ContentPage
    {
        public PawnPage()
        {
            InitializeComponent();
             Title = "Pawn";
            PawnListView.ItemTemplate = new DataTemplate(typeof(PawnViewModel));
            PawnListView.ItemsSource = WebApiClient.ApiClient.Pawn.GetAll();
           
         
            PawnListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            PawnListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {PawnListView}
            };
            Content = layout;
        }

        public ListView PawnListView { get; set; }
    }
}
