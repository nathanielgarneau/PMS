using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;

namespace PMS.BLL
{
    public class Product : GenericBusinessLayer<Xam.DAL.Model.Product, ProductViewModel>
    {
        public Product()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Product>();
        }

        public override void Add(ProductViewModel item)
        {
            var record = ConvertToDal(item);
            Repository.MarkUnchanged(record, new List<string> {"Colour", "ProductType"},
                new List<string> {"Conditions", "Tags"});

            Repository.Insert(record);
        }

        public override Xam.DAL.Model.Product ConvertToDal(ProductViewModel viewModel)
        {
            return ToDal(viewModel);
        }

        public override ProductViewModel ConvertToViewModel(Xam.DAL.Model.Product model)
        {
            return ToViewModel(model);
        }

        public static Xam.DAL.Model.Product ToDal(ProductViewModel viewModel)
        {
            var record = new Xam.DAL.Model.Product
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Colour = Colour.ToDal(viewModel.Colour),
                Conditions = Condition.ToDal(viewModel.Conditions),
                Description = viewModel.Description,
                Year = viewModel.Year,
                ProductType = ProductType.ToDal(viewModel.ProductType),
                Tags = Tag.ToDal(viewModel.Tags)
            };
            return record;
        }

        public static ICollection<Xam.DAL.Model.Product> ToDal(ICollection<ProductViewModel> viewModels)
        {
            return viewModels.Select(viewModel => ToDal(viewModel)).ToList();
        }

        public static ProductViewModel ToViewModel(Xam.DAL.Model.Product model)
        {
            var result = new ProductViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Colour = Colour.ToViewModel(model.Colour),
                Conditions = Condition.ToViewModel(model.Conditions),
                Description = model.Description,
                Year = model.Year,
                ProductType = ProductType.ToViewModel(model.ProductType),
                Tags = Tag.ToViewModel(model.Tags)
            };
            return result;
        }

        public static ICollection<ProductViewModel> ToViewModel(ICollection<Xam.DAL.Model.Product> models)
        {
            return models.Select(model => ToViewModel(model)).ToList();
        }
    }
}