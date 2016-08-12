
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class City :GenericBusinessLayer<Xam.DAL.Model.City, CityViewModel> 
    {
         public City()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.City>();
        }

        public override Xam.DAL.Model.City ConvertToDal(CityViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override CityViewModel ConvertToViewModel(Xam.DAL.Model.City model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.City ToDal(CityViewModel viewModel)
        {
            return new Xam.DAL.Model.City
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static CityViewModel ToViewModel(Xam.DAL.Model.City model)
        {
            return new CityViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
