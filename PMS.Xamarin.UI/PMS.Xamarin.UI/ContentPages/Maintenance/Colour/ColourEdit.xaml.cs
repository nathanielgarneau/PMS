using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace PMS.Xam.UI.ContentPages.Maintenance.Colour
{
    public partial class ColourEdit : ContentPage
    {
        private BusinessLayer BusinessLayer = new BusinessLayer();
        public ColourEdit(Xam.ViewModel.ColourViewModel colour)
        {
            InitializeComponent();
            InitializePicker(colour);
        }
         // Dictionary to get Color from color name.
        private List<Xam.ViewModel.ColourViewModel> Colours { get; set; }

        private void InitializePicker(Xam.ViewModel.ColourViewModel boundColour)
        {
            Colours = BusinessLayer.Colour.GetAll();
            foreach (var colour in Colours)
            {
                Picker.Items.Add(colour.Name);
            }
            Picker.SelectedIndex = Colours.IndexOf(boundColour);
            Picker.SelectedIndexChanged += (sender, args) =>
            {
                var colourName = Picker.Items[Picker.SelectedIndex];
                var color = Color.FromHex(Colours.First(x => x.Name == colourName).Code);
                BoxView.Color = color;
            };
        }

    }
}
