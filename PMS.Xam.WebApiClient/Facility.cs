using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Facility<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Facility(string apiAddress) : base(apiAddress)
        {
        }
    }
}