using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.ViewModel;

namespace PMS.Xam.WebApiClient
{
    public static class ApiClient
    {
        public static Address<AddressViewModel, int> Address = new Address<AddressViewModel, int>(UriAddresses.Address);
        public static City<CityViewModel, int> City =new City<CityViewModel, int>(UriAddresses.City);
        public static Client<ClientViewModel, int> Client =new Client<ClientViewModel, int>(UriAddresses.Client);
        public static Colour<ColourViewModel, int> Colour =new Colour<ColourViewModel, int>(UriAddresses.Colour);
        public static Condition<ConditionViewModel, int> Condition =new Condition<ConditionViewModel, int>(UriAddresses.Condition);
        public static Country<CountryViewModel, int> Country =new Country<CountryViewModel, int>(UriAddresses.Country);
        public static Facility<FacilityViewModel, int> Facility =new Facility<FacilityViewModel, int>(UriAddresses.Facility);
        public static IdentificationType<IdentificationTypeViewModel, int> IdentificationType =new IdentificationType<IdentificationTypeViewModel, int>(UriAddresses.IdentificationType);
        public static Location<LocationViewModel, int> Location =new Location<LocationViewModel, int>(UriAddresses.Location);
        public static Note<NoteViewModel, int> Note =new Note<NoteViewModel, int>(UriAddresses.Note);
        public static Pawn<PawnViewModel, int> Pawn =new Pawn<PawnViewModel, int>(UriAddresses.Pawn);
        public static Payment<PaymentViewModel, int> Payment =new Payment<PaymentViewModel, int>(UriAddresses.Payment);
        public static PaymentType<PaymentTypeViewModel, int> PaymentType =new PaymentType<PaymentTypeViewModel, int>(UriAddresses.PaymentType);
        public static Product<ProductViewModel, int> Product =new Product<ProductViewModel, int>(UriAddresses.Product);
        public static ProductType<ProductTypeViewModel, int> ProductType =new ProductType<ProductTypeViewModel, int>(UriAddresses.ProductType);
        public static Province<ProvinceViewModel, int> Province =new Province<ProvinceViewModel, int>(UriAddresses.Province);
        public static Purchase<PurchaseViewModel, int> Purchase =new Purchase<PurchaseViewModel, int>(UriAddresses.Purchase);
        public static Rate<RateViewModel, int> Rate =new Rate<RateViewModel, int>(UriAddresses.Rate);
        public static Setting<SettingViewModel, int> Setting =new Setting<SettingViewModel, int>(UriAddresses.Setting);
        public static Tag<TagViewModel, int> Tag =new Tag<TagViewModel, int>(UriAddresses.Tag);
        public static User<UserViewModel, int> User =new User<UserViewModel, int>(UriAddresses.User);
        public static UserSettings<UserSettingsViewModel, int> UserSettings =new UserSettings<UserSettingsViewModel, int>(UriAddresses.UserSettings);

    }
}
