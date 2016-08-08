using PMS.Xamarin.Model.Interfaces;

namespace PMS.ViewModel
{
    public class AddressViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public CityViewModel City { get; set; }
        public ProvinceViewModel Province { get; set; }
        public string PostalCode { get; set; }
        public CountryViewModel Country { get; set; }
    }
}