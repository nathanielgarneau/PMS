
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Condition :GenericBusinessLayer<DAL.Model.Condition, ConditionViewModel> 
    {
         public Condition()
        {
            Repository = new GenericDataRepository<DAL.Model.Condition>();
        }

        public override DAL.Model.Condition ConvertToDal(ConditionViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ConditionViewModel ConvertToViewModel(DAL.Model.Condition model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Condition ToDal(ConditionViewModel viewModel)
        {
            return new DAL.Model.Condition
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static ConditionViewModel ToViewModel(DAL.Model.Condition model)
        {
            return new ConditionViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
