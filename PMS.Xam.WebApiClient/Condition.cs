using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Condition<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Condition(string apiAddress) : base(apiAddress)
        {
        }
    }
}