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
    public class Tag :GenericBusinessLayer<DAL.Model.Tag, TagViewModel> 
    {
         public Tag()
        {
            Repository = new GenericDataRepository<DAL.Model.Tag>();
        }

        public override DAL.Model.Tag ConvertToDal(TagViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override TagViewModel ConvertToViewModel(DAL.Model.Tag model)
        {
            return ToViewModel(model);
        }
        public static DAL.Model.Tag ToDal(TagViewModel viewModel)
        {
            return new DAL.Model.Tag
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static TagViewModel ToViewModel(DAL.Model.Tag model)
        {
            return new TagViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }

        internal static IEnumerable<TagViewModel> ToViewModel(IEnumerable<DAL.Model.Tag> models)
        {
           return models.Select(model => ToViewModel(model)).ToList();
        }
         internal static IEnumerable<DAL.Model.Tag> ToDal(IEnumerable<TagViewModel> models)
        {
           return models.Select(model => ToDal(model)).ToList();
        }
    }
}
