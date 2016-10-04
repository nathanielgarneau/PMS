using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class UserSetting : GenericBusinessLayer<Xam.DAL.Model.UserSetting, UserSettingViewModel>
    {
        public UserSetting()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.UserSetting>();
        }

        public override Xam.DAL.Model.UserSetting ConvertToDal(UserSettingViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override UserSettingViewModel ConvertToViewModel(Xam.DAL.Model.UserSetting model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.UserSetting ToDal(UserSettingViewModel viewModel)
        {
            return new Xam.DAL.Model.UserSetting
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }

        public static UserSettingViewModel ToViewModel(Xam.DAL.Model.UserSetting model)
        {
            return new UserSettingViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Value = model.Value
            };
        }

        internal static ICollection<UserSettingViewModel> ToViewModel(ICollection<Xam.DAL.Model.UserSetting> models)
        {
            return models.Select(model => ToViewModel(model)).ToList();
        }

        internal static ICollection<Xam.DAL.Model.UserSetting> ToDal(ICollection<UserSettingViewModel> models)
        {
            return models.Select(model => ToDal(model)).ToList();
        }
    }
}