using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class ColourViewModel:IEntity<int>
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}