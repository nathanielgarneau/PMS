using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PawnViewModel:IEntity<int>
    {
        public int Id { get; set; }
        public IEnumerable<ProductViewModel> Items { get; set; }
        public IEnumerable<NoteViewModel> Notes { get; set; }
        public IEnumerable<LocationViewModel> StorageLocations { get; set; }
        public double PawnValue { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public RateViewModel Rate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //public bool Extended { get; set; }//TODO: add to viewmodel
        public DateTime? ExtendedToDate { get; set; }
        public double PickupPrice { get; set; }
        //public double PickupPriceRemaining{get;}//TODO: add to viewmodel
        public IEnumerable<PaymentViewModel> Payments { get; set; }
        //public bool PickedUp//TODO:Add to viewmodel
        public DateTime? ClosedDate { get; set; }
        public ClientViewModel Client { get; set; }

        //public bool Closed { get; set; }//TODO: add to viewmodel
        //public double PurchaseCost{get;set;}//TODO: add to viewmodel
    }
}
