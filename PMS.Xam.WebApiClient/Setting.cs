using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Setting<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Setting(string apiAddress) : base(apiAddress)
        {
        }
    }
}