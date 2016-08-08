using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class CityViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}