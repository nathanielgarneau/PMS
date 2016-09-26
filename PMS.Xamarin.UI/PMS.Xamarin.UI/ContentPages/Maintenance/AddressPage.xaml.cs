﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class AddressPage : ContentPage
    {
        public AddressPage()
        {
            InitializeComponent();
             Title = "Address";
            AddressListView.ItemTemplate = new DataTemplate(typeof(AddressViewModel));
            AddressListView.ItemsSource = WebApiClient.ApiClient.Address.GetAll();
           
         
            AddressListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            AddressListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {AddressListView}
            };
            Content = layout;
        }

        public ListView AddressListView { get; set; }
    }
}
