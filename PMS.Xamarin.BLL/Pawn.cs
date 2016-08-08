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
    public class Pawn :GenericBusinessLayer<DAL.Model.Pawn, PawnViewModel> 
    {
         public Pawn()
        {
            Repository = new GenericDataRepository<DAL.Model.Pawn>();
        }

        public override DAL.Model.Pawn ConvertToDal(PawnViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override PawnViewModel ConvertToViewModel(DAL.Model.Pawn model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Pawn ToDal(PawnViewModel viewModel)
        {
            return new DAL.Model.Pawn
            {
                Id = viewModel.Id,
                Client = Client.ToDal(viewModel.Client),
                ClosedDate = viewModel.ClosedDate,
                EstimatedValueHigh = viewModel.EstimatedValueHigh,
                EstimatedValueLow = viewModel.EstimatedValueLow,
                ExpiryDate = viewModel.ExpiryDate,
                ExtendedToDate = viewModel.ExtendedToDate,
                Items = Product.ToDal(viewModel.Items),
                Notes = Note.ToDal(viewModel.Notes),
                PawnValue = viewModel.PawnValue,
                PickupPrice = viewModel.PickupPrice,
                Payments = Payment.ToDal(viewModel.Payments),
                Rate = Rate.ToDal(viewModel.Rate),
                StorageLocations = Location.ToDal(viewModel.StorageLocations)
            };
        }
        public static PawnViewModel ToViewModel(DAL.Model.Pawn model)
        {
            return new PawnViewModel
            {
                Id = model.Id,
                Client = Client.ToViewModel(model.Client),
                ClosedDate = model.ClosedDate,
                EstimatedValueHigh = model.EstimatedValueHigh,
                EstimatedValueLow = model.EstimatedValueLow,
                ExpiryDate = model.ExpiryDate,
                ExtendedToDate = model.ExtendedToDate,
                Items = Product.ToViewModel(model.Items),
                Notes = Note.ToViewModel(model.Notes),
                PawnValue = model.PawnValue,
                PickupPrice = model.PickupPrice,
                Payments = Payment.ToViewModel(model.Payments),
                Rate = Rate.ToViewModel(model.Rate),
                StorageLocations = Location.ToViewModel(model.StorageLocations)
            };
        }
    }
}
