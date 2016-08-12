
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class City :GenericBusinessLayer<DAL.Model.City, CityViewModel> 
    {
         public City()
        {
            Repository = new GenericDataRepository<DAL.Model.City>();
        }

        public override DAL.Model.City ConvertToDal(CityViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override CityViewModel ConvertToViewModel(DAL.Model.City model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.City ToDal(CityViewModel viewModel)
        {
            return new DAL.Model.City
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static CityViewModel ToViewModel(DAL.Model.City model)
        {
            return new CityViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
