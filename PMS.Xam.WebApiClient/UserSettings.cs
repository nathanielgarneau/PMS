using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class UserSettings<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public UserSettings(string apiAddress) : base(apiAddress)
        {
        }
    }
}