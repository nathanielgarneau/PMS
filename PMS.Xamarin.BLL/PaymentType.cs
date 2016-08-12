
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class PaymentType :GenericBusinessLayer<DAL.Model.PaymentType, PaymentTypeViewModel> 
    {
         public PaymentType()
        {
            Repository = new GenericDataRepository<DAL.Model.PaymentType>();
        }

        public override DAL.Model.PaymentType ConvertToDal(PaymentTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override PaymentTypeViewModel ConvertToViewModel(DAL.Model.PaymentType model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.PaymentType ToDal(PaymentTypeViewModel viewModel)
        {
            return new DAL.Model.PaymentType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static PaymentTypeViewModel ToViewModel(DAL.Model.PaymentType model)
        {
            return new PaymentTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
