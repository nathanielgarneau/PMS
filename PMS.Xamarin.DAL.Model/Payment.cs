using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Payment : IEntity<int>, IDisposable
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Pawn Pawn { get; set; }
        public virtual Purchase Purchase { get; set; }
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