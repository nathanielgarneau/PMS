using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Country :GenericBusinessLayer<Xam.DAL.Model.Country, CountryViewModel> 
    {
         public Country()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Country>();
        }

        public override Xam.DAL.Model.Country ConvertToDal(CountryViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override CountryViewModel ConvertToViewModel(Xam.DAL.Model.Country model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Country ToDal(CountryViewModel viewModel)
        {
            return new Xam.DAL.Model.Country
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static CountryViewModel ToViewModel(Xam.DAL.Model.Country model)
        {
            return new CountryViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
