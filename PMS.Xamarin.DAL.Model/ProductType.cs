using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class ProductType : IEntity<int>, IDisposable
    {
        public string Name { get; set; }
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