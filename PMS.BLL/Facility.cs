using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Facility :GenericBusinessLayer<Xam.DAL.Model.Facility, FacilityViewModel> 
    {
         public Facility()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Facility>();
        }

        public override Xam.DAL.Model.Facility ConvertToDal(FacilityViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override FacilityViewModel ConvertToViewModel(Xam.DAL.Model.Facility model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Facility ToDal(FacilityViewModel viewModel)
        {
            return new Xam.DAL.Model.Facility
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Address = Address.ToDal(viewModel.Address)
            };
        }
        public static FacilityViewModel ToViewModel(Xam.DAL.Model.Facility model)
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
