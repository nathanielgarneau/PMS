using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Address<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        internal Address(string apiAddress) : base(apiAddress)
        {
        }
    }
}