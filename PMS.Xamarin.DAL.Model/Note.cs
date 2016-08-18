using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Note:IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public string Value { get; set; }
           public virtual ICollection<Pawn> Pawns { get; set; }
         public virtual ICollection<Purchase> Purchases { get; set; }
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