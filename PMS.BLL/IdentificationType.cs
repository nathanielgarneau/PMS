using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class IdentificationType :GenericBusinessLayer<Xam.DAL.Model.IdentificationType, IdentificationTypeViewModel> 
    {
         public IdentificationType()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.IdentificationType>();
        }

        public override Xam.DAL.Model.IdentificationType ConvertToDal(IdentificationTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override IdentificationTypeViewModel ConvertToViewModel(Xam.DAL.Model.IdentificationType model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.IdentificationType ToDal(IdentificationTypeViewModel viewModel)
        {
            return new Xam.DAL.Model.IdentificationType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static IdentificationTypeViewModel ToViewModel(Xam.DAL.Model.IdentificationType model)
        {
            return new IdentificationTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
