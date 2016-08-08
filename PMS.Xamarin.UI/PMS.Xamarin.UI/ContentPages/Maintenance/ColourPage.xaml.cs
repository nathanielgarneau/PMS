using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PMS.Xam.UI.ContentPages.Maintenance.Colour;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ColourPage : ContentPage
    {
        public ColourPage()
        {
            InitializeComponent();
        }
        private async void OnDelete(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColourDelete((ViewModel.ColourViewModel)ColourListView.SelectedItem));
        }

        private async void OnEdit(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new ColourEdit((ViewModel.ColourViewModel)ColourListView.SelectedItem));
        }
    }
}
