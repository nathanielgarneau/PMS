
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Colour :GenericBusinessLayer<DAL.Model.Colour, ColourViewModel> 
    {
         public Colour()
        {
            Repository = new GenericDataRepository<DAL.Model.Colour>();
        }

        public override DAL.Model.Colour ConvertToDal(ColourViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ColourViewModel ConvertToViewModel(DAL.Model.Colour model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Colour ToDal(ColourViewModel viewModel)
        {
            return new DAL.Model.Colour
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Code = viewModel.Code
            };
        }
        public static ColourViewModel ToViewModel(DAL.Model.Colour model)
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
