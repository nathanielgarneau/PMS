using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Location<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Location(string apiAddress) : base(apiAddress)
        {
        }
    }
}