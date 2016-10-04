using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Product : IEntity<int>, IDisposable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ProductType ProductType { get; set; }

        public int Year { get; set; }
        public virtual ICollection<Condition> Conditions { get; set; }

        public virtual Colour Colour { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<Pawn> Pawns { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
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