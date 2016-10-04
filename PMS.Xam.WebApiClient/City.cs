using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class City<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public City(string apiAddress) : base(apiAddress)
        {
        }
    }
}