using System;
using System.Collections.Generic;

using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Location :GenericBusinessLayer<DAL.Model.Location, LocationViewModel> 
    {
         public Location()
        {
            Repository = new GenericDataRepository<DAL.Model.Location>();
        }

        public override DAL.Model.Location ConvertToDal(LocationViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override LocationViewModel ConvertToViewModel(DAL.Model.Location model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Location ToDal(LocationViewModel viewModel)
        {
            return new DAL.Model.Location
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description,
                Facility = Facility.ToDal(viewModel.Facility)
            };
        }
        public static LocationViewModel ToViewModel(DAL.Model.Location model)
        {
            return new LocationViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Facility = Facility.ToViewModel(model.Facility)
            };
        }

        internal static IEnumerable<DAL.Model.Location> ToDal(IEnumerable<LocationViewModel> storageLocations)
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<LocationViewModel> ToViewModel(IEnumerable<DAL.Model.Location> storageLocations)
        {
            throw new NotImplementedException();
        }
    }
}
