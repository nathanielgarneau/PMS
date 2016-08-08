using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class NoteViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}