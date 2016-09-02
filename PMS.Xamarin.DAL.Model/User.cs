using System;
using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class User : IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public int Pin { get; set; }
        public string Password { get; set; }

        public virtual  ICollection<UserSetting> UserSettings
        {
            get;
            set;
        }
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