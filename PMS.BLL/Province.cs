using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Province :GenericBusinessLayer<Xam.DAL.Model.Province, ProvinceViewModel> 
    {
         public Province()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Province>();
        }

        public override Xam.DAL.Model.Province ConvertToDal(ProvinceViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ProvinceViewModel ConvertToViewModel(Xam.DAL.Model.Province model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Province ToDal(ProvinceViewModel viewModel)
        {
            return new Xam.DAL.Model.Province
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Abbreviation = viewModel.Abbreviation,
                Country = Country.ToDal(viewModel.Country)
            };
        }
        public static ProvinceViewModel ToViewModel(Xam.DAL.Model.Province model)
        {
            return new ProvinceViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Abbreviation = model.Abbreviation,
                Country = Country.ToViewModel(model.Country)
            };
        }
    }
}
