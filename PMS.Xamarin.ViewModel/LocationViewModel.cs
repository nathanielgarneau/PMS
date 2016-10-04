using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class LocationViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FacilityViewModel Facility { get; set; }
        public int Id { get; set; }
    }
}