using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class ColourViewModel:IEntity<int>
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}