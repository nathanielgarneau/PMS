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
    public class Setting :GenericBusinessLayer<DAL.Model.Setting, SettingViewModel> 
    {
         public Setting()
        {
            Repository = new GenericDataRepository<DAL.Model.Setting>();
        }

        public override DAL.Model.Setting ConvertToDal(SettingViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override SettingViewModel ConvertToViewModel(DAL.Model.Setting model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Setting ToDal(SettingViewModel viewModel)
        {
            return new DAL.Model.Setting
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static SettingViewModel ToViewModel(DAL.Model.Setting model)
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
