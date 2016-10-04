using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Rate : GenericBusinessLayer<Xam.DAL.Model.Rate, RateViewModel>
    {
        public Rate()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Rate>();
        }

        public override Xam.DAL.Model.Rate ConvertToDal(RateViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override RateViewModel ConvertToViewModel(Xam.DAL.Model.Rate model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Rate ToDal(RateViewModel viewModel)
        {
            return new Xam.DAL.Model.Rate
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Value = viewModel.Value
            };
        }

        public static RateViewModel ToViewModel(Xam.DAL.Model.Rate model)
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