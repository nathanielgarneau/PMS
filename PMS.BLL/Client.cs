using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Client : GenericBusinessLayer<Xam.DAL.Model.Client, ClientViewModel>
    {
        public Client()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Client>();
        }

        public override Xam.DAL.Model.Client ConvertToDal(ClientViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override ClientViewModel ConvertToViewModel(Xam.DAL.Model.Client model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Client ToDal(ClientViewModel viewModel)
        {
            return new Xam.DAL.Model.Client
            {
                Id = viewModel.Id,
                Address = Address.ToDal(viewModel.Address),
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                IdentificationType = IdentificationType.ToDal(viewModel.IdentificationType),
                IdentificationNumber = viewModel.IdentificationNumber,
                OtherIdentificationNumber = viewModel.OtherIdentificationNumber,
                OtherIdentificationType = IdentificationType.ToDal(viewModel.OtherIdentificationType)
            };
        }

        public static ClientViewModel ToViewModel(Xam.DAL.Model.Client model)
        {
            return new ClientViewModel
            {
                Id = model.Id,
                Address = Address.ToViewModel(model.Address),
                FirstName = model.FirstName,
                LastName = model.LastName,
                IdentificationType = IdentificationType.ToViewModel(model.IdentificationType),
                IdentificationNumber = model.IdentificationNumber,
                OtherIdentificationNumber = model.OtherIdentificationNumber,
                OtherIdentificationType = IdentificationType.ToViewModel(model.OtherIdentificationType)
            };
        }
    }
}