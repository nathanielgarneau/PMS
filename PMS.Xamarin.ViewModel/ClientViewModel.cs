using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class ClientViewModel:IEntity<int>
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressViewModel Address { get; set; }

        public string LicenseNumber { get; set; }
        
        public IdentificationTypeViewModel IdentificationType { get; set; }
        public string OtherIdentificationNumber { get; set; }
        public IdentificationTypeViewModel OtherIdentificationType { get; set; }
    }
}