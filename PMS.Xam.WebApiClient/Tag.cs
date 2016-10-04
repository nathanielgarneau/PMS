using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Tag<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Tag(string apiAddress) : base(apiAddress)
        {
        }
    }
}