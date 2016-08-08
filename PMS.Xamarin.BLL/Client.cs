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
    public class Client :GenericBusinessLayer<DAL.Model.Client, ClientViewModel> 
    {
         public Client()
        {
            Repository = new GenericDataRepository<DAL.Model.Client>();
        }

        public override DAL.Model.Client ConvertToDal(ClientViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ClientViewModel ConvertToViewModel(DAL.Model.Client model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Client ToDal(ClientViewModel viewModel)
        {
            return new DAL.Model.Client
            {
                Id = viewModel.Id,
                Address = Address.ToDal(viewModel.Address),
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                IdentificationType = IdentificationType.ToDal(viewModel.IdentificationType),
                LicenseNumber = viewModel.LicenseNumber,
                OtherIdentificationNumber = viewModel.OtherIdentificationNumber
            };
        }
        public static ClientViewModel ToViewModel(DAL.Model.Client model)
        {
            return new ClientViewModel
            {
                 Id = model.Id,
                Address = Address.ToViewModel(model.Address),
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdentificationType = IdentificationType.ToViewModel(model.IdentificationType),
                LicenseNumber = model.LicenseNumber,
                OtherIdentificationNumber = model.OtherIdentificationNumber
            };
        }
    }
}
