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
    public class Address :GenericBusinessLayer<DAL.Model.Address, AddressViewModel> 
    {
         public Address()
        {
            Repository = new GenericDataRepository<DAL.Model.Address>();
        }

        public override DAL.Model.Address ConvertToDal(AddressViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override AddressViewModel ConvertToViewModel(DAL.Model.Address model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Address ToDal(AddressViewModel viewModel)
        {
            return new DAL.Model.Address
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                City = City.ToDal( viewModel.City),
                Country = Country.ToDal(viewModel.Country),
                PostalCode = viewModel.PostalCode,
                Province = Province.ToDal(viewModel.Province),
                Street = viewModel.Street
            };
        }
        public static AddressViewModel ToViewModel(DAL.Model.Address model)
        {
            return new AddressViewModel
            {
                 Id = model.Id,
                Name = model.Name,
                City = City.ToViewModel( model.City),
                Country = Country.ToViewModel(model.Country),
                PostalCode = model.PostalCode,
                Province = Province.ToViewModel(model.Province),
                Street = model.Street
            };
        }
    }
}
