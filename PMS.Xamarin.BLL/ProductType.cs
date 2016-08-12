
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class ProductType :GenericBusinessLayer<DAL.Model.ProductType, ProductTypeViewModel> 
    {
         public ProductType()
        {
            Repository = new GenericDataRepository<DAL.Model.ProductType>();
        }

        public override DAL.Model.ProductType ConvertToDal(ProductTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ProductTypeViewModel ConvertToViewModel(DAL.Model.ProductType model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.ProductType ToDal(ProductTypeViewModel viewModel)
        {
            return new DAL.Model.ProductType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static ProductTypeViewModel ToViewModel(DAL.Model.ProductType model)
        {
            return new ProductTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}
