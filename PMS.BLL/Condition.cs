using System.Collections.Generic;
using System.Linq;
using PMS.DAL.Repositories;
using PMS.Xam.ViewModel;


namespace PMS.BLL
{
    public class Condition : GenericBusinessLayer<Xam.DAL.Model.Condition, ConditionViewModel>
    {
        public Condition()
        {
            Repository = new GenericDataRepository<Xam.DAL.Model.Condition>();
        }

        public override Xam.DAL.Model.Condition ConvertToDal(ConditionViewModel viewModel)
        {
            return ToDal(viewModel);
        }
        public override ConditionViewModel ConvertToViewModel(Xam.DAL.Model.Condition model)
        {
            return ToViewModel(model);
        }
        public static Xam.DAL.Model.Condition ToDal(ConditionViewModel viewModel)
        {
            return new Xam.DAL.Model.Condition
            {
                Id = viewModel.Id,
                Name = viewModel.Name
            };
        }
        public static ConditionViewModel ToViewModel(Xam.DAL.Model.Condition model)
        {
            return new ConditionViewModel
            {
                Id = model.Id,
                Name = model.Name
            };
        }
        internal static ICollection<ConditionViewModel> ToViewModel(ICollection<Xam.DAL.Model.Condition> models)
        {
            return models.Select(model => ToViewModel(model)).ToList();
        }
        internal static ICollection<Xam.DAL.Model.Condition> ToDal(ICollection<ConditionViewModel> models)
        {
            return models.Select(model => ToDal(model)).ToList();
        }
    }
}
