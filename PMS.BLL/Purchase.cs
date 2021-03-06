﻿using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Purchase : GenericBusinessLayer<Xam.DAL.Model.Purchase, PurchaseViewModel>
    {
        public Purchase()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Purchase>();
        }

        public override Xam.DAL.Model.Purchase ConvertToDal(PurchaseViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override PurchaseViewModel ConvertToViewModel(Xam.DAL.Model.Purchase model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Purchase ToDal(PurchaseViewModel viewModel)
        {
            return new Xam.DAL.Model.Purchase
            {
                Id = viewModel.Id,
                Client = Client.ToDal(viewModel.Client),
                EstimatedValueHigh = viewModel.EstimatedValueHigh,
                EstimatedValueLow = viewModel.EstimatedValueLow,
                Items = Product.ToDal(viewModel.Items),
                Notes = Note.ToDal(viewModel.Notes),
                Payments = Payment.ToDal(viewModel.Payments),
                StorageLocations = Location.ToDal(viewModel.StorageLocations),
                PurchaseCost = viewModel.PurchaseCost,
                SaleableDate = viewModel.SaleableDate
            };
        }

        public static PurchaseViewModel ToViewModel(Xam.DAL.Model.Purchase model)
        {
            return new PurchaseViewModel
            {
                Id = model.Id,
                Client = Client.ToViewModel(model.Client),
                EstimatedValueHigh = model.EstimatedValueHigh,
                EstimatedValueLow = model.EstimatedValueLow,
                Items = Product.ToViewModel(model.Items),
                Notes = Note.ToViewModel(model.Notes),
                Payments = Payment.ToViewModel(model.Payments),
                StorageLocations = Location.ToViewModel(model.StorageLocations),
                PurchaseCost = model.PurchaseCost,
                SaleableDate = model.SaleableDate
            };
        }
    }
}