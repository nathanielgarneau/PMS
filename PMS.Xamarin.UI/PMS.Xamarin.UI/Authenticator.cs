using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL;

namespace PMS.Xam.UI
{
    internal class Authenticator
    {
        internal bool IsUserAdmin { get; private set; }
        internal bool IsUserAuthenticated { get; private set; }

        private readonly PMS.Xam.BLL.User UserBusinessLayer = new PMS.Xam.BLL.User();

        internal bool Authenticate(string username, string password)
        {
            return UserBusinessLayer.GetAll().Any(x => x.Password == password && x.Username == username);
        }

        internal bool Authenticate(string username, int pin)
        {
            return UserBusinessLayer.GetAll().Any(x => x.Pin == pin && x.Username == username);
        }
    }
}
