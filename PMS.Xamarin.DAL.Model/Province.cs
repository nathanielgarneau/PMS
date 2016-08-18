using System;
using System.Collections;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Province:IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
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