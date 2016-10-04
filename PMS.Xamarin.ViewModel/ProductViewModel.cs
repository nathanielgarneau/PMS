using System.Collections.Generic;
using System.Linq;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class ProductViewModel : IEntity<int>, IPostBindable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductTypeViewModel ProductType { get; set; }

        public int Year { get; set; }
        public ICollection<ConditionViewModel> Conditions { get; set; }
        public ICollection<int> ConditionInts { get; set; }
        public ColourViewModel Colour { get; set; }

        public ICollection<TagViewModel> Tags { get; set; }
        public ICollection<int> TagInts { get; set; }
        public int Id { get; set; }

        /// <summary>
        ///     IPostBindable is implemented to allow for multiselect dropdownlists
        /// </summary>
        public void OnPostBind()
        {
            if (Conditions == null) Conditions = new List<ConditionViewModel>();
            if (ConditionInts != null && ConditionInts.Any())
            {
                foreach (var id in ConditionInts.Where(id => Conditions.All(x => x.Id != id)))
                {
                    Conditions.Add(new ConditionViewModel {Id = id});
                }
            }
            if (Tags == null) Tags = new List<TagViewModel>();
            if (TagInts != null && TagInts.Any())
            {
                foreach (var id in TagInts.Where(id => Tags.All(x => x.Id != id)))
                {
                    Tags.Add(new TagViewModel {Id = id});
                }
            }
        }
    }
}