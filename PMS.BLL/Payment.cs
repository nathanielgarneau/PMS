using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Payment : GenericBusinessLayer<Xam.DAL.Model.Payment, PaymentViewModel>
    {
        public Payment()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Payment>();
        }

        public override Xam.DAL.Model.Payment ConvertToDal(PaymentViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override PaymentViewModel ConvertToViewModel(Xam.DAL.Model.Payment model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Payment ToDal(PaymentViewModel viewModel)
        {
            return new Xam.DAL.Model.Payment
            {
                Id = viewModel.Id,
                Date = viewModel.Date,
                PaymentType = PaymentType.ToDal(viewModel.PaymentType),
                Value = viewModel.Value
            };
        }

        public static PaymentViewModel ToViewModel(Xam.DAL.Model.Payment model)
        {
            return new PaymentViewModel
            {
                Id = model.Id,
                Date = model.Date,
                PaymentType = PaymentType.ToViewModel(model.PaymentType),
                Value = model.Value
            };
        }

        internal static ICollection<Xam.DAL.Model.Payment> ToDal(ICollection<PaymentViewModel> viewModels)
        {
            return viewModels.Select(model => ToDal(model)).ToList();
        }

        internal static ICollection<PaymentViewModel> ToViewModel(ICollection<Xam.DAL.Model.Payment> models)
        {
            return models.Select(model => ToViewModel(model)).ToList();
        }
    }
}