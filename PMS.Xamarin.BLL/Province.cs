using System;
using System.Collections.Generic;

using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Province :GenericBusinessLayer<DAL.Model.Province, ProvinceViewModel> 
    {
         public Province()
        {
            Repository = new GenericDataRepository<DAL.Model.Province>();
        }

        public override DAL.Model.Province ConvertToDal(ProvinceViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ProvinceViewModel ConvertToViewModel(DAL.Model.Province model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Province ToDal(ProvinceViewModel viewModel)
        {
            return new DAL.Model.Province
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static ProvinceViewModel ToViewModel(DAL.Model.Province model)
        {
            return new ProvinceViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
