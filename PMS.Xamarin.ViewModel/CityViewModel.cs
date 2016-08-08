using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class CityViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}