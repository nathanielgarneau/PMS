using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Address :GenericBusinessLayer<Xam.DAL.Model.Address, AddressViewModel> 
    {
         public Address()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Address>();
        }

        public override Xam.DAL.Model.Address ConvertToDal(AddressViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override AddressViewModel ConvertToViewModel(Xam.DAL.Model.Address model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Address ToDal(AddressViewModel viewModel)
        {
            return new Xam.DAL.Model.Address
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
        public static AddressViewModel ToViewModel(Xam.DAL.Model.Address model)
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
