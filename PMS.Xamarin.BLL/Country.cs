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
    public class Country :GenericBusinessLayer<DAL.Model.Country, CountryViewModel> 
    {
         public Country()
        {
            Repository = new GenericDataRepository<DAL.Model.Country>();
        }

        public override DAL.Model.Country ConvertToDal(CountryViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override CountryViewModel ConvertToViewModel(DAL.Model.Country model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Country ToDal(CountryViewModel viewModel)
        {
            return new DAL.Model.Country
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static CountryViewModel ToViewModel(DAL.Model.Country model)
        {
            return new CountryViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
