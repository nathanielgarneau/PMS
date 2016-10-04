using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class NoteViewModel : IEntity<int>
    {
        public string Value { get; set; }
        public int Id { get; set; }
    }
}