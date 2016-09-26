using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class ConditionPage : ContentPage
    {
        public ConditionPage()
        {
            InitializeComponent();
             Title = "Condition";
            ConditionListView.ItemTemplate = new DataTemplate(typeof(ConditionViewModel));
            ConditionListView.ItemsSource = WebApiClient.ApiClient.Condition.GetAll();
           
         
            ConditionListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            ConditionListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {ConditionListView}
            };
            Content = layout;
        }

        public ListView ConditionListView { get; set; }
        
    }
}
