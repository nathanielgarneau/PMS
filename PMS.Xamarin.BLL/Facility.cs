
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Facility :GenericBusinessLayer<DAL.Model.Facility, FacilityViewModel> 
    {
         public Facility()
        {
            Repository = new GenericDataRepository<DAL.Model.Facility>();
        }

        public override DAL.Model.Facility ConvertToDal(FacilityViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override FacilityViewModel ConvertToViewModel(DAL.Model.Facility model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Facility ToDal(FacilityViewModel viewModel)
        {
            return new DAL.Model.Facility
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Address = Address.ToDal(viewModel.Address)
            };
        }
        public static FacilityViewModel ToViewModel(DAL.Model.Facility model)
        {
            return new FacilityViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Address = Address.ToViewModel(model.Address)
            };
        }
    }
}
