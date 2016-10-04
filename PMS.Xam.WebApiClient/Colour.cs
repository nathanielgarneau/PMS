using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Colour<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Colour(string apiAddress) : base(apiAddress)
        {
        }
    }
}