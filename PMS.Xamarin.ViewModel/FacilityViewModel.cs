using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class FacilityViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public AddressViewModel Address { get; set; }
        public int Id { get; set; }
    }
}