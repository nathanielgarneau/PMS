
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class IdentificationType :GenericBusinessLayer<DAL.Model.IdentificationType, IdentificationTypeViewModel> 
    {
         public IdentificationType()
        {
            Repository = new GenericDataRepository<DAL.Model.IdentificationType>();
        }

        public override DAL.Model.IdentificationType ConvertToDal(IdentificationTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override IdentificationTypeViewModel ConvertToViewModel(DAL.Model.IdentificationType model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.IdentificationType ToDal(IdentificationTypeViewModel viewModel)
        {
            return new DAL.Model.IdentificationType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static IdentificationTypeViewModel ToViewModel(DAL.Model.IdentificationType model)
        {
            return new IdentificationTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
