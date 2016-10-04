using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class PaymentType<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public PaymentType(string apiAddress) : base(apiAddress)
        {
        }
    }
}