using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Setting :GenericBusinessLayer<Xam.DAL.Model.Setting, SettingViewModel> 
    {
         public Setting()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Setting>();
        }

        public override Xam.DAL.Model.Setting ConvertToDal(SettingViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override SettingViewModel ConvertToViewModel(Xam.DAL.Model.Setting model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Setting ToDal(SettingViewModel viewModel)
        {
            return new Xam.DAL.Model.Setting
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static SettingViewModel ToViewModel(Xam.DAL.Model.Setting model)
        {
            return new SettingViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Value = model.Value
            };
        }
    }
}
