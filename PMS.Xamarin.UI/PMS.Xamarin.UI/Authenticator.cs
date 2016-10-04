using System.Linq;
using PMS.Xam.WebApiClient;

namespace PMS.Xam.UI
{
    internal class Authenticator
    {
        internal bool IsUserAdmin { get; private set; }
        internal bool IsUserAuthenticated { get; private set; }


        internal bool Authenticate(string username, string password)
        {
            return ApiClient.User.GetAll().Any(x => x.Password == password && x.Username == username);
        }

        internal bool Authenticate(string username, int pin)
        {
            return ApiClient.User.GetAll().Any(x => x.Pin == pin && x.Username == username);
        }
    }
}