using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Setting : IEntity<int> , IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
     
        public Setting() { }

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
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
