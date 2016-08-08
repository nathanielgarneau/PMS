﻿using System;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Location:IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Facility Facility { get; set; }
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