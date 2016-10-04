using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Product<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Product(string apiAddress) : base(apiAddress)
        {
        }
    }
}