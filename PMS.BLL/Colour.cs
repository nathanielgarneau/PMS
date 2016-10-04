using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Colour : GenericBusinessLayer<Xam.DAL.Model.Colour, ColourViewModel>
    {
        public Colour()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Colour>();
        }

        public override Xam.DAL.Model.Colour ConvertToDal(ColourViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override ColourViewModel ConvertToViewModel(Xam.DAL.Model.Colour model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Colour ToDal(ColourViewModel viewModel)
        {
            return new Xam.DAL.Model.Colour
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Code = viewModel.Code
            };
        }

        public static ColourViewModel ToViewModel(Xam.DAL.Model.Colour model)
        {
            return new ColourViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Code = model.Code
            };
        }
    }
}