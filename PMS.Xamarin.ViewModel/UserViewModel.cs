using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class UserViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        
        public int Pin { get; set; }
        public string Password { get; set; }

        public UserSettingsViewModel UserSettings
        {
            get;
            set;
        }
    }
}
