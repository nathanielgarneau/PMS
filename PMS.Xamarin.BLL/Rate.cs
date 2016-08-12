
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Rate :GenericBusinessLayer<DAL.Model.Rate, RateViewModel> 
    {
         public Rate()
        {
            Repository = new GenericDataRepository<DAL.Model.Rate>();
        }

        public override DAL.Model.Rate ConvertToDal(RateViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override RateViewModel ConvertToViewModel(DAL.Model.Rate model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Rate ToDal(RateViewModel viewModel)
        {
            return new DAL.Model.Rate
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }
        public static RateViewModel ToViewModel(DAL.Model.Rate model)
        {
            return new RateViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Value = model.Value
            };
        }
    }
}
