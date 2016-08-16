using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class UserSettings :GenericBusinessLayer<Xam.DAL.Model.UserSetting, UserSettingsViewModel> 
    {
         public UserSettings()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.UserSetting>();
        }

        public override Xam.DAL.Model.UserSetting ConvertToDal(UserSettingsViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override UserSettingsViewModel ConvertToViewModel(Xam.DAL.Model.UserSetting model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.UserSetting ToDal(UserSettingsViewModel viewModel)
        {
            return new Xam.DAL.Model.UserSetting
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static UserSettingsViewModel ToViewModel(Xam.DAL.Model.UserSetting model)
        {
            return new UserSettingsViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Value = model.Value
            };
        }
             internal static ICollection<UserSettingsViewModel> ToViewModel(ICollection<Xam.DAL.Model.UserSetting> models)
        {
           return models.Select(model => ToViewModel(model)).ToList();
        }
         internal static ICollection<Xam.DAL.Model.UserSetting> ToDal(ICollection<UserSettingsViewModel> models)
        {
           return models.Select(model => ToDal(model)).ToList();
        }
    }
}
