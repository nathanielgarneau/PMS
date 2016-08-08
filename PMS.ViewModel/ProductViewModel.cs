using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xamarin.Model.Interfaces;
namespace PMS.ViewModel
{
    public class ProductViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductTypeViewModel ProductType { get; set; }

        public int Year { get; set; }
        public ConditionViewModel Condition { get; set; }

        public ColourViewModel Colour { get; set; }

        public IEnumerable<TagViewModel> Tags { get; set; }


    }
}
