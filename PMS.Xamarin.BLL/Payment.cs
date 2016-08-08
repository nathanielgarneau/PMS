using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL.Interfaces;
using PMS.Xam.DAL.Model;
using PMS.Xam.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Payment :GenericBusinessLayer<DAL.Model.Payment, PaymentViewModel> 
    {
         public Payment()
        {
            Repository = new GenericDataRepository<DAL.Model.Payment>();
        }

        public override DAL.Model.Payment ConvertToDal(PaymentViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override PaymentViewModel ConvertToViewModel(DAL.Model.Payment model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Payment ToDal(PaymentViewModel viewModel)
        {
            return new DAL.Model.Payment
            {
                Id = viewModel.Id,
                Date = viewModel.Date,
                PaymentType = PaymentType.ToDal(viewModel.PaymentType),
                Value = viewModel.Value
            };
        }
        public static PaymentViewModel ToViewModel(DAL.Model.Payment model)
        {
            return new PaymentViewModel
            {
                  Id = model.Id,
                Date = model.Date,
                PaymentType = PaymentType.ToViewModel(model.PaymentType),
                Value = model.Value
            };
        }

        internal static IEnumerable<DAL.Model.Payment> ToDal(IEnumerable<PaymentViewModel> viewModels)
        {
              return viewModels.Select(model => ToDal(model)).ToList();
        }

        internal static IEnumerable<PaymentViewModel> ToViewModel(IEnumerable<DAL.Model.Payment> models)
        {
              return models.Select(model => ToViewModel(model)).ToList();
        }
    }
}
