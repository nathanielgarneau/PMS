using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class ProductType<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public ProductType(string apiAddress) : base(apiAddress)
        {
        }
    }
}