using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;
namespace PMS.Xam.ViewModel
{
    public class ProductViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductTypeViewModel ProductType { get; set; }

        public int Year { get; set; }
        public ICollection<ConditionViewModel> Conditions { get; set; }

        public ColourViewModel Colour { get; set; }

        public ICollection<TagViewModel> Tags { get; set; }


    }
}
