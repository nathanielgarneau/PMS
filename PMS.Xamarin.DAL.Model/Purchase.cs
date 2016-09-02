using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
   public  class Purchase : IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public virtual ICollection<Product> Items { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Location> StorageLocations { get; set; }
        public double PurchaseCost { get; set; }
        public double? EstimatedValueLow { get; set; }
        public double? EstimatedValueHigh { get; set; }
        public DateTime SaleableDate { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
       public virtual Client Client { get; set; }

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
