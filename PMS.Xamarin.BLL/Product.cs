using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.BLL.Interfaces;
using PMS.Xam.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.Xam.BLL
{
    public class Product :GenericBusinessLayer<DAL.Model.Product, ProductViewModel> 
    {
        public Product()
        {
            Repository = new GenericDataRepository<DAL.Model.Product>();
        }

        public override DAL.Model.Product ConvertToDal(ProductViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ProductViewModel ConvertToViewModel(DAL.Model.Product model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Product ToDal(ProductViewModel viewModel)
        {
            var record = new DAL.Model.Product
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Colour = Colour.ToDal(viewModel.Colour),
                Condition = Condition.ToDal(viewModel.Condition),
                Description = viewModel.Description,
                ProductType = ProductType.ToDal(viewModel.ProductType),
                Tags = Tag.ToDal(viewModel.Tags)
            };
            return record;
        }

        public static IEnumerable<DAL.Model.Product> ToDal(IEnumerable<ProductViewModel> viewModels)
        {
            return viewModels.Select(viewModel => ToDal(viewModel)).ToList();
        }

        public static ProductViewModel ToViewModel(DAL.Model.Product model)
        {
            var result = new ProductViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Colour = Colour.ToViewModel(model.Colour),
                Condition = Condition.ToViewModel(model.Condition),
                Description = model.Description,
                ProductType = ProductType.ToViewModel(model.ProductType),
                Tags = Tag.ToViewModel(model.Tags)
            };
            return result;
        }
           public static IEnumerable<ProductViewModel> ToViewModel(IEnumerable<DAL.Model.Product> models)
           {
               return models.Select(model => ToViewModel(model)).ToList();
           }
    }
}
