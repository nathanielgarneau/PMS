using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class AddressViewModel : IEntity<int>
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public CityViewModel City { get; set; }
        public ProvinceViewModel Province { get; set; }
        public string PostalCode { get; set; }
        public CountryViewModel Country { get; set; }
        public int Id { get; set; }
    }
}