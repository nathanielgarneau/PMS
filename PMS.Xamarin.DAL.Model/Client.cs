using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Client : IEntity<int>, IDisposable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Address Address { get; set; }

        public string IdentificationNumber { get; set; }

        public virtual IdentificationType IdentificationType { get; set; }
        public string OtherIdentificationNumber { get; set; }
        public virtual IdentificationType OtherIdentificationType { get; set; }
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