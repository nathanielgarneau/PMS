using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL.Interfaces;
using PMS.Xam.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class User :GenericBusinessLayer<DAL.Model.User, UserViewModel> 
    {
       public User()
        {
            Repository = new GenericDataRepository<DAL.Model.User>();
        }
           public override DAL.Model.User ConvertToDal(UserViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override UserViewModel ConvertToViewModel(DAL.Model.User model)
        {
            return ToViewModel(model);
        }
         public static DAL.Model.User ToDal(UserViewModel viewModel)
        {
            var record = new DAL.Model.User
            {
                Id = viewModel.Id,
                Username = viewModel.Username,
                Password = viewModel.Password,
                Pin = viewModel.Pin,
                UserSettings = UserSettings.ToDal(viewModel.UserSettings)
            };
            return record;
        }
        public static UserViewModel ToViewModel(DAL.Model.User model)
        {
             var record = new UserViewModel
            {
                Id = model.Id,
                Username = model.Username,
                Password = model.Password,
                Pin = model.Pin,
                UserSettings = UserSettings.ToViewModel(model.UserSettings)
            };
            return record;
        }
    }
}
