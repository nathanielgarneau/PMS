using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PawnViewModel : IEntity<int>
    {
        public ICollection<ProductViewModel> Items { get; set; }
        public ICollection<NoteViewModel> Notes { get; set; }
        public ICollection<LocationViewModel> StorageLocations { get; set; }
        public double PawnValue { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public RateViewModel Rate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //public bool Extended { get; set; }//TODO: add to viewmodel
        public DateTime? ExtendedToDate { get; set; }
        public double PickupPrice { get; set; }
        //public double PickupPriceRemaining{get;}//TODO: add to viewmodel
        public ICollection<PaymentViewModel> Payments { get; set; }
        //public bool PickedUp//TODO:Add to viewmodel
        public DateTime? ClosedDate { get; set; }
        public ClientViewModel Client { get; set; }
        public int Id { get; set; }
        //public double PurchaseCost{get;set;}//TODO: add to viewmodel

        //public bool Closed { get; set; }//TODO: add to viewmodel
    }
}