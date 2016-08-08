using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class NoteViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}