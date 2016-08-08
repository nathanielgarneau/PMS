using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace PMS.DAL.Repositories
{
    public class GenericDataRepository<T> : Interfaces.IGenericDataRepository<T> where T : class, Model.Interfaces.IEntity<int>, IDisposable
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
        public T Insert<T>(T model)
        {
            int iRes = Context.Insert(model);
            return model;
        }

        public IEnumerable<T> Insert<T>(IEnumerable<T> models)
        {
            int iRes = Context.InsertAll(models);
            return models;
        } 

        public T Update<T>(T model)
        {
            int iRes = Context.Update(model);
            return model;
        }
          public  IEnumerable<T>  Update<T>(IEnumerable<T>  models)
          {
              int iRes = Context.UpdateAll(models);
              return models;
          }

        public bool Delete<T>(T model)
        {
            int iRes = Context.Delete(model);
            return iRes.Equals(1);
        }

        public T Select<T>(int pk) where T : new()
        {
            var map = Context.GetMapping(typeof(T));
            return Context.Query<T>(map.GetByPrimaryKeySql, pk).First();
        }

     

        public IEnumerable<T> SelectAll<T>() where T : new()
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
