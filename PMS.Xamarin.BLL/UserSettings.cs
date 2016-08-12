
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class UserSettings :GenericBusinessLayer<DAL.Model.UserSettings, UserSettingsViewModel> 
    {
         public UserSettings()
        {
            Repository = new GenericDataRepository<DAL.Model.UserSettings>();
        }

        public override DAL.Model.UserSettings ConvertToDal(UserSettingsViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override UserSettingsViewModel ConvertToViewModel(DAL.Model.UserSettings model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.UserSettings ToDal(UserSettingsViewModel viewModel)
        {
            return new DAL.Model.UserSettings
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static UserSettingsViewModel ToViewModel(DAL.Model.UserSettings model)
        {
            return new UserSettingsViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Value = model.Value
            };
        }
    }
}
