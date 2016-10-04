using PMS.Xam.ViewModel;
using PMS.Xam.WebApiClient;
using Xamarin.Forms;

namespace PMS.Xam.UI.ContentPages.Maintenance
{
    public partial class NotePage : ContentPage
    {
        public NotePage()
        {
            InitializeComponent();
            Title = "Note";
            NoteListView.ItemTemplate = new DataTemplate(typeof (NoteViewModel));
            NoteListView.ItemsSource = ApiClient.Note.GetAll();


            NoteListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            NoteListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Code");
            var layout = new StackLayout
            {
                Spacing = 10,
                VerticalOptions = LayoutOptions.End,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Start,
                Children = {NoteListView}
            };
            Content = layout;
        }

        public ListView NoteListView { get; set; }
    }
}