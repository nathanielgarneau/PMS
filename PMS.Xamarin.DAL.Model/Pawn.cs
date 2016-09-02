using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Pawn : IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<Product> Items { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Location> StorageLocations { get; set; }
        public double PawnValue { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public virtual Rate Rate { get; set; }
        public DateTime ExpiryDate { get; set; }
        //public bool Extended { get; set; }//TODO: add to viewmodel
        public DateTime? ExtendedToDate { get; set; }
        public double PickupPrice { get; set; }
        //public double PickupPriceRemaining{get;}//TODO: add to viewmodel
        public virtual ICollection<Payment> Payments { get; set; }
        //public bool PickedUp//TODO:Add to viewmodel
        public DateTime? ClosedDate { get; set; }
        //public bool Closed { get; set; }//TODO: add to viewmodel
        //public double PurchaseCost{get;set;}//TODO: add to viewmodel
            #region IDispose Region
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //Context.Dispose();
                }
            }
            this.disposed = true;

        }
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
        #endregion
    }
}
