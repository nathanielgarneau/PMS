using System;
using System.Collections.Generic;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Location : GenericBusinessLayer<Xam.DAL.Model.Location, LocationViewModel>
    {
        public Location()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Location>();
        }

        public override Xam.DAL.Model.Location ConvertToDal(LocationViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override LocationViewModel ConvertToViewModel(Xam.DAL.Model.Location model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Location ToDal(LocationViewModel viewModel)
        {
            return new Xam.DAL.Model.Location
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Facility = Facility.ToDal(viewModel.Facility)
            };
        }

        public static LocationViewModel ToViewModel(Xam.DAL.Model.Location model)
        {
            return new LocationViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Facility = Facility.ToViewModel(model.Facility)
            };
        }

        internal static ICollection<Xam.DAL.Model.Location> ToDal(ICollection<LocationViewModel> storageLocations)
        {
            throw new NotImplementedException();
        }

        internal static ICollection<LocationViewModel> ToViewModel(ICollection<Xam.DAL.Model.Location> storageLocations)
        {
            throw new NotImplementedException();
        }
    }
}