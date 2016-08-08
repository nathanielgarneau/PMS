using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class FacilityViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AddressViewModel Address { get; set; }
    }
}