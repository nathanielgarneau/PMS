using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.ViewModel
{
    public class PurchaseViewModel : IEntity<int>
    {
        public ICollection<ProductViewModel> Items { get; set; }
        public ICollection<NoteViewModel> Notes { get; set; }
        public ICollection<LocationViewModel> StorageLocations { get; set; }
        public double PurchaseCost { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public DateTime SaleableDate { get; set; }
        public ICollection<PaymentViewModel> Payments { get; set; }
        public ClientViewModel Client { get; set; }
        public int Id { get; set; }
    }
}