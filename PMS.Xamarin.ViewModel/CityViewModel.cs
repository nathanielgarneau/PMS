using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class CityViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public ProvinceViewModel Province { get; set; }
        public int Id { get; set; }
    }
}