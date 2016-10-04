using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Payment<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Payment(string apiAddress) : base(apiAddress)
        {
        }
    }
}