using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Country<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Country(string apiAddress) : base(apiAddress)
        {
        }
    }
}