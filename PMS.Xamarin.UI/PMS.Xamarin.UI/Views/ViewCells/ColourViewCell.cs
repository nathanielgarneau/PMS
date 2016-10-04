using System;
using PMS.Xam.UI.ContentPages.Maintenance.Colour;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.Views.ViewCells
{
    internal class ColourViewCell : ViewCell
    {
        public ColourViewCell()
        {
            var viewLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {CreateLayout()}
            };
            ContextActions.Add(EditMenuItem());
            ContextActions.Add(DeleteMenuItem());
            View = viewLayout;
        }

        private MenuItem EditMenuItem()
        {
            var edit = new MenuItem
            {
                Text = "Edit"
            };
            edit.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            edit.Clicked += OnEdit;
            return edit;
        }

        private MenuItem DeleteMenuItem()
        {
            var delete = new MenuItem
            {
                Text = "Delete"
            };
            delete.SetBinding(MenuItem.CommandParameterProperty, new Binding("."));
            delete.Clicked += OnDelete;
            return delete;
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            await
                Application.Current.MainPage.Navigation.PushAsync(
                    new ColourDelete((ColourViewModel) ((MenuItem) sender).CommandParameter));
        }

        private async void OnEdit(object sender, EventArgs e)
        {
            await
                Application.Current.MainPage.Navigation.PushAsync(
                    new ColourEdit((ColourViewModel) ((MenuItem) sender).CommandParameter));
        }

        private static StackLayout CreateLayout()
        {
            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");
            nameLabel.SetBinding(Label.TextColorProperty, "Code");

            var nameLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = {nameLabel}
            };
            return nameLayout;
        }
    }
}