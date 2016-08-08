using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Product :IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }

        public int Year { get; set; }
        public Condition Condition { get; set; }

        public Colour Colour { get; set; }

        public IEnumerable<Tag> Tags { get; set; }


    }
}
