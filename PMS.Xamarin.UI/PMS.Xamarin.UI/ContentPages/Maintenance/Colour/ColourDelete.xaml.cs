using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance.Colour
{
    public partial class ColourDelete : ContentPage
    {
        public ColourDelete(Xam.ViewModel.ColourViewModel colour)
        {
            InitializeComponent();
             BindingContext = colour;
             var deleteView = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Spacing = 15
            };
            var prompt = new Label() {Text = "Are you sure you want to delete this record?"};
            deleteView.Children.Add(prompt);
            deleteView.Children.Add(ConfirmButton());
            deleteView.Children.Add(CancelButton());
            Content = deleteView;
        }
        private Button ConfirmButton()
        {
            var confirm = new Button
            {
                Text = "Confirm"
            };
            confirm.Clicked += OnConfirm;
            return confirm;
        }

        private void OnConfirm(object sender, EventArgs e)
        {
            //TODO: Delete the bindingContext object and redirect to the parent maintenance page. 
            throw new NotImplementedException();
        }

        private Button CancelButton()
        {
            var edit = new Button
            {
                Text = "Cancel"
            };
            edit.Clicked += OnCancel;
            return edit;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PopAsync(true);
        }
    }
}
