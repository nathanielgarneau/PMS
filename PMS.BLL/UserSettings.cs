using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class UserSettings :GenericBusinessLayer<Xam.DAL.Model.UserSettings, UserSettingsViewModel> 
    {
         public UserSettings()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.UserSettings>();
        }

        public override Xam.DAL.Model.UserSettings ConvertToDal(UserSettingsViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override UserSettingsViewModel ConvertToViewModel(Xam.DAL.Model.UserSettings model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.UserSettings ToDal(UserSettingsViewModel viewModel)
        {
            return new Xam.DAL.Model.UserSettings
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static UserSettingsViewModel ToViewModel(Xam.DAL.Model.UserSettings model)
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
