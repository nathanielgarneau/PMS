using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class LocationViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FacilityViewModel Facility { get; set; }
    }
}