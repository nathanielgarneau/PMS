using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class UserViewModel : IEntity<int>
    {
        public string Username { get; set; }

        public int Pin { get; set; }
        public string Password { get; set; }

        public ICollection<UserSettingViewModel> UserSettings { get; set; }

        public int Id { get; set; }
    }
}