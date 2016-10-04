using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Rate<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Rate(string apiAddress) : base(apiAddress)
        {
        }
    }
}