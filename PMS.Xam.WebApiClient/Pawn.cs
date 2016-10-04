using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient
{
    public class Pawn<T, TX> : BasicHttpClient<T, TX> where T : IEntity<TX>
    {
        public Pawn(string apiAddress) : base(apiAddress)
        {
        }
    }
}