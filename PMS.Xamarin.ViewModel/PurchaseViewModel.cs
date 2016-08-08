using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;
namespace PMS.Xam.ViewModel
{
   public  class PurchaseViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public IEnumerable<ProductViewModel> Items { get; set; }
        public IEnumerable<NoteViewModel> Notes { get; set; }
        public IEnumerable<LocationViewModel> StorageLocations { get; set; }
        public double PurchaseCost { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public DateTime SaleableDate { get; set; }
        public IEnumerable<PaymentViewModel> Payments { get; set; }
       public ClientViewModel Client { get; set; }
    }
}
