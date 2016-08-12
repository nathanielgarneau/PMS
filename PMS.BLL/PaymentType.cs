using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class PaymentType :GenericBusinessLayer<Xam.DAL.Model.PaymentType, PaymentTypeViewModel> 
    {
         public PaymentType()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.PaymentType>();
        }

        public override Xam.DAL.Model.PaymentType ConvertToDal(PaymentTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override PaymentTypeViewModel ConvertToViewModel(Xam.DAL.Model.PaymentType model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.PaymentType ToDal(PaymentTypeViewModel viewModel)
        {
            return new Xam.DAL.Model.PaymentType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static PaymentTypeViewModel ToViewModel(Xam.DAL.Model.PaymentType model)
        {
            return new PaymentTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
