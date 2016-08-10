using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL;
using PMS.Xam.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PMS.Xam.UI.ContentPages.Maintenance.Colour
{
    public partial class ColourEdit : ContentPage
    {
        private BusinessLayer BusinessLayer = new BusinessLayer();
        private Picker _picker = new Picker();

        private BoxView _boxView = new BoxView()
        {
            WidthRequest = 150,
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        public ColourEdit(Xam.ViewModel.ColourViewModel colour)
        {
            InitializeComponent();
            BindingContext = colour;

            var editView = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 15
            };
            var idLabel = new Label {Text = "Id: " + colour.Id};
            var nameEntry = new Entry {Placeholder = "Name"};
            nameEntry.SetBinding(Entry.TextProperty, "Name");
        
            var codeEntry = new Entry {Placeholder = "Code"};
            codeEntry.SetBinding(Entry.TextProperty, "Code");
            _boxView.SetBinding(BoxView.ColorProperty, "Code");
            codeEntry.TextChanged += (sender, args) =>
            {
                try
                {
                    var colorTest = Color.FromHex(codeEntry.Text);
                    if (colorTest != null)
                    {
                        _boxView.Color = colorTest;
                    }
                }
                catch
                {
                }
            };

            editView.Children.Add(idLabel);
            editView.Children.Add(nameEntry);
            editView.Children.Add(codeEntry);
            editView.Children.Add(_boxView);
            Content = editView;
        }
    }
}
