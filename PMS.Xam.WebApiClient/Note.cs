using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Note<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>

    {
        public Note(string apiAddress) : base(apiAddress)
        {
        }
    }
}