using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
   public  class Purchase : IEntity<int>
    {
        public int Id { get; set; }
        public IEnumerable<Product> Items { get; set; }
        public IEnumerable<Note> Notes { get; set; }
        public IEnumerable<Location> StorageLocations { get; set; }
        public double PurchaseCost { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public DateTime SaleableDate { get; set; }
        public IEnumerable<Payment> Payments { get; set; }

    }
}
