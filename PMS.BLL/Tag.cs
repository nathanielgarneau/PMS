
using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Tag :GenericBusinessLayer<Xam.DAL.Model.Tag, TagViewModel> 
    {
         public Tag()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Tag>();
        }

        public override Xam.DAL.Model.Tag ConvertToDal(TagViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override TagViewModel ConvertToViewModel(Xam.DAL.Model.Tag model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Tag ToDal(TagViewModel viewModel)
        {
            return new Xam.DAL.Model.Tag
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static TagViewModel ToViewModel(Xam.DAL.Model.Tag model)
        {
            return new TagViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        internal static IEnumerable<TagViewModel> ToViewModel(IEnumerable<Xam.DAL.Model.Tag> models)
        {
           return models.Select(model => ToViewModel(model)).ToList();
        }
         internal static IEnumerable<Xam.DAL.Model.Tag> ToDal(IEnumerable<TagViewModel> models)
        {
           return models.Select(model => ToDal(model)).ToList();
        }
    }
}
