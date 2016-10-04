using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Purchase<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Purchase(string apiAddress) : base(apiAddress)
        {
        }
    }
}