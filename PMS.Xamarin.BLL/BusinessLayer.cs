using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.Xam.BLL
{
    public class BusinessLayer
    {
        public BusinessLayer()
        {
        }
        private Product _setting { get; set; }
        public  Product Setting => _setting ?? (_setting = new Product());

        private User _user { get; set; }
        public  User User => _user ?? (_user = new User());

        private UserSettings _userSettings { get; set; }
        public  UserSettings UserSettings => _userSettings ?? (_userSettings = new UserSettings());








    }
}
