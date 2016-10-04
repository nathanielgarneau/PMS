using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class IdentificationType<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public IdentificationType(string apiAddress) : base(apiAddress)
        {
        }
    }
}