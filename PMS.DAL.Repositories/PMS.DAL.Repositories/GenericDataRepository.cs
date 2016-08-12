﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using log4net;
using PMS.DAL.Repositories.Interfaces;


namespace PMS.DAL.Repositories
{
    public class GenericDataRepository<T> : Interfaces.IGenericDataRepository<T> where T : class, Xam.Model.Interfaces.IEntity<int>, IDisposable, new()
    {
        #region Context Property
        //protected SQLiteConnection Context { get; set; }
        private System.Data.Entity.DbContext _context { get; set; }
        #endregion
        private readonly ILog _logger = LogManager.GetLogger("MicroQC.DAL.Repositories.GenericDataRepository");
        #region Constructor
        public GenericDataRepository()
        {
            _context = (System.Data.Entity.DbContext)DbContext.Instance;
        }
        #endregion
         #region Generic Repository EF Version
        public T Insert(T model)
        {
             try
            {
             
                    _context.Entry(model).State = EntityState.Added;
                
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.Add failed", exception);
                throw;
            }
            return model;
        }

        public T Update(T model)
        {
              try
            {
            
                    _context.Set<T>().AddOrUpdate(model);
                
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.Update failed", exception);
                throw;
            }
            return model;
        }

        public IEnumerable<T> Insert(IEnumerable<T> model)
        {
            try
            {
                foreach (var item in model)
                {
                    _context.Entry(item).State = EntityState.Added;
                }
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.Add failed", exception);
                throw;
            }
            return model;
        }

        public IEnumerable<T> Update(IEnumerable<T> model)
        {
             try
            {
                foreach (var item in model)
                {
                    _context.Set<T>().AddOrUpdate(item);
                }
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.Update failed", exception);
                throw;
            }
            return model;
        }

        public bool Delete(T model)
        {
            try
            {
                    try
                    {
                        bool isDetached = _context.Entry(model).State == EntityState.Detached;
                        if (isDetached)
                        {
                            //var found = this.GetSingle(x => x.Id == item.Id);
                            var found =_context.Set<T>().Find(model.Id);
                            if (found == null)
                            {
                                _context.Set<T>().Attach(model);
                                _context.Set<T>().Remove(model);
                            }
                            else
                            {
                                 _context.Set<T>().Remove(found);
                            }
                        }
                        //_context.Entry(item).State = EntityState.Deleted;
                    }
                    catch (Exception e)
                    {
                        _logger.Error("Remove failed", e);
                        //skip this exception if attaching fails.
                    }
                _context.SaveChanges();
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.Remove failed", exception);
                throw;
            }
            return true;
        }

        public T Select(int pk)
        {
            try
            {
                IQueryable<T> dbQuery = _context.Set<T>();

                //Apply eager loading
                //dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include<T, object>(navigationProperty));

                var item = dbQuery
                        .AsNoTracking() //Don't track any changes for the selected item
                        .FirstOrDefault(x=>x.Id == pk);

                return item;
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.GetSingle failed", exception);
                throw;
            }
        }

        public IEnumerable<T> SelectAll()
        {
             try
            {
                IQueryable<T> dbQuery = _context.Set<T>();
                //Apply eager loading
                //dbQuery = navigationProperties.Aggregate(dbQuery,
                //    (current, navigationProperty) => current.Include<T, object>(navigationProperty));

                var list = dbQuery
                    .AsNoTracking()
                    .ToList<T>();

                return list;
            }
            catch (Exception exception)
            {
                _logger.Error("GenericDataRepository.GetAll failed", exception);
                throw;
            }
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
                    _context.Dispose();
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