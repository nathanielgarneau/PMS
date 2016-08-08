using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.DAL.Repositories.Interfaces;
using SQLite;

namespace PMS.Xam.DAL.Repositories
{
    public class GenericDataRepository<T> : Interfaces.IGenericDataRepository<T> where T : class, Xam.Model.Interfaces.IEntity<int>, IDisposable, new()
    {
        #region Context Property
        protected SQLiteConnection Context { get; set; }
        #endregion

        #region Constructor
        public GenericDataRepository()
        {
            Context = DbContext.Instance;
        }
        #endregion

        #region Generic Repository
       
        public IEnumerable<T> Insert(IEnumerable<T> models)
        {
            int iRes = Context.InsertAll(models);
            return models;
        }

        public T Insert(T model)
        {
             int iRes = Context.Insert(model);
            return model;
        }

        public T Update(T model)
        {
            int iRes = Context.Update(model);
            return model;
        }
          public  IEnumerable<T>  Update(IEnumerable<T>  models)
          {
              int iRes = Context.UpdateAll(models);
              return models;
          }

        public bool Delete(T model)
        {
            int iRes = Context.Delete(model);
            return iRes.Equals(1);
        }

        public T Select(int pk)
        {
            var map = Context.GetMapping(typeof(T));
            return Context.Query<T>(map.GetByPrimaryKeySql, pk).First();
        }

        public IEnumerable<T> SelectAll()
        {
            return new TableQuery<T>(Context);
        }

        #endregion

        #region IDispose Region
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
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
