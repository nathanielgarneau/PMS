using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Address:IEntity<int>, IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
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