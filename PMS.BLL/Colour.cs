using System;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Colour :GenericBusinessLayer<PMS.Xam.DAL.Model.Colour, ColourViewModel> 
    {
         public Colour()
        {
            Repository = new GenericDataRepository<PMS.Xam.DAL.Model.Colour>();
        }

        public override PMS.Xam.DAL.Model.Colour ConvertToDal(ColourViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ColourViewModel ConvertToViewModel(PMS.Xam.DAL.Model.Colour model)
        {
            return ToViewModel(model);
        }
        public static PMS.Xam.DAL.Model.Colour ToDal(ColourViewModel viewModel)
        {
            return new PMS.Xam.DAL.Model.Colour
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Code = viewModel.Code
            };
        }
        public static ColourViewModel ToViewModel(PMS.Xam.DAL.Model.Colour model)
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
