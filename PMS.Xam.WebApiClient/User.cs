using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class User<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public User(string apiAddress) : base(apiAddress)
        {
        }
    }
}