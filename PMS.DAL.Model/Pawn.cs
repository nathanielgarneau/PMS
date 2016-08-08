using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Model
{
    public class Pawn : IEntity<int>
    {
        public int Id { get; set; }
        public IEnumerable<Product> Items { get; set; }
        public IEnumerable<Note> Notes { get; set; }
        public IEnumerable<Location> StorageLocations { get; set; }
        public double PawnValue { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public Rate Rate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //public bool Extended { get; set; }//TODO: add to viewmodel
        public DateTime? ExtendedToDate { get; set; }
        public double PickupPrice { get; set; }
        //public double PickupPriceRemaining{get;}//TODO: add to viewmodel
        public IEnumerable<Payment> Payments { get; set; }
        //public bool PickedUp//TODO:Add to viewmodel
        public DateTime? ClosedDate { get; set; }
        //public bool Closed { get; set; }//TODO: add to viewmodel
        //public double PurchaseCost{get;set;}//TODO: add to viewmodel
    }
}
