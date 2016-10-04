using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Client<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Client(string apiAddress) : base(apiAddress)
        {
        }
    }
}