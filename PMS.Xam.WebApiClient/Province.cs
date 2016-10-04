using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Province<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Province(string apiAddress) : base(apiAddress)
        {
        }
    }
}