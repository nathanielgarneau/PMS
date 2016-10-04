using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class ProductType : GenericBusinessLayer<Xam.DAL.Model.ProductType, ProductTypeViewModel>
    {
        public ProductType()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.ProductType>();
        }

        public override Xam.DAL.Model.ProductType ConvertToDal(ProductTypeViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override ProductTypeViewModel ConvertToViewModel(Xam.DAL.Model.ProductType model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.ProductType ToDal(ProductTypeViewModel viewModel)
        {
            return new Xam.DAL.Model.ProductType
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }

        public static ProductTypeViewModel ToViewModel(Xam.DAL.Model.ProductType model)
        {
            return new ProductTypeViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
    }
}