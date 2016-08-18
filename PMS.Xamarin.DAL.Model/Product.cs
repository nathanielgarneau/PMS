﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Model
{
    public class Product :IEntity<int>,IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }

        public int Year { get; set; }
        public ICollection<Condition> Conditions { get; set; }

        public Colour Colour { get; set; }

        public ICollection<Tag> Tags { get; set; }

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
