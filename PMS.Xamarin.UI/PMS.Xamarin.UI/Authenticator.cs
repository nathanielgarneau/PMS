using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PMS.Xam.UI
{
    internal class Authenticator
    {
        internal bool IsUserAdmin { get; private set; }
        internal bool IsUserAuthenticated { get; private set; }

        
        internal bool Authenticate(string username, string password)
        {
            return WebApiClient.ApiClient.User.GetAll().Any(x => x.Password == password && x.Username == username);
        }

        internal bool Authenticate(string username, int pin)
        {
            return WebApiClient.ApiClient.User.GetAll().Any(x => x.Pin == pin && x.Username == username);
        }
    }
}
