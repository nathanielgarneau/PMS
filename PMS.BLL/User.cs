using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class User : GenericBusinessLayer<Xam.DAL.Model.User, UserViewModel>
    {
        public User()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.User>();
        }

        public override Xam.DAL.Model.User ConvertToDal(UserViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override UserViewModel ConvertToViewModel(Xam.DAL.Model.User model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.User ToDal(UserViewModel viewModel)
        {
            var record = new Xam.DAL.Model.User
            {
                Id = viewModel.Id,
                Username = viewModel.Username,
                Password = viewModel.Password,
                Pin = viewModel.Pin,
                UserSetting = UserSetting.ToDal(viewModel.UserSettings)
            };
            return record;
        }

        public static UserViewModel ToViewModel(Xam.DAL.Model.User model)
        {
            var record = new UserViewModel
            {
                Id = model.Id,
                Username = model.Username,
                Password = model.Password,
                Pin = model.Pin,
                UserSettings = UserSetting.ToViewModel(model.UserSetting)
            };
            return record;
        }
    }
}