using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Purchase : IEntity<int>, IDisposable
    {
        public virtual ICollection<Product> Items { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Location> StorageLocations { get; set; }
        public double PurchaseCost { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public DateTime SaleableDate { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual Client Client { get; set; }
        public int Id { get; set; }

        #region IDispose Region

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //Context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}