using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PMS.DAL.Repositories
{
   //public class GenericDataRepository<T> : Interfaces.IGenericDataRepository<T> where T :class, IEntity<int>
   // {
   //     private readonly DbContext _context;
   //     private readonly ILog _logger = LogManager.GetLogger("MicroQC.DAL.Repositories.GenericDataRepository");
   //     public GenericDataRepository(DbContext context)
   //     {
   //         _context = context;
   //     }
   //     public virtual List<T> GetAll(params Expression<Func<T, object>>[] navigationProperties)
   //     {
   //         try
   //         {
   //             IQueryable<T> dbQuery = _context.Set<T>();
   //             //Apply eager loading
   //             dbQuery = navigationProperties.Aggregate(dbQuery,
   //                 (current, navigationProperty) => current.Include<T, object>(navigationProperty));

   //             var list = dbQuery
   //                 .AsNoTracking()
   //                 .ToList<T>();

   //             return list;
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.GetAll failed", exception);
   //             throw;
   //         }
   //     }

   //     public virtual List<T> GetList(Func<T, bool> where,
   //          params Expression<Func<T, object>>[] navigationProperties)
   //     {
   //         try
   //         {
   //             IQueryable<T> dbQuery = _context.Set<T>();

   //             //Apply eager loading
   //             dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include<T, object>(navigationProperty));

   //             var list = dbQuery
   //                     .AsNoTracking()
   //                     .Where(@where)
   //                     .ToList<T>();

   //             return list;
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.GetList failed", exception);
   //             throw;
   //         }
   //     }

   //     public virtual T GetSingle(Func<T, bool> where,
   //          params Expression<Func<T, object>>[] navigationProperties)
   //     {
   //         try
   //         {
   //             IQueryable<T> dbQuery = _context.Set<T>();

   //             //Apply eager loading
   //             dbQuery = navigationProperties.Aggregate(dbQuery, (current, navigationProperty) => current.Include<T, object>(navigationProperty));

   //             var item = dbQuery
   //                     .AsNoTracking() //Don't track any changes for the selected item
   //                     .FirstOrDefault(@where);

   //             return item;
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.GetSingle failed", exception);
   //             throw;
   //         }
   //     }
   //     public void Add(params T[] items)
   //     {
   //         try
   //         {
   //             foreach (var item in items)
   //             {
   //                 _context.Entry(item).State = EntityState.Added;
   //             }
   //             _context.SaveChanges();
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.Add failed", exception);
   //             throw;
   //         }
   //     }

   //     public void Update(params T[] items)
   //     {
   //         try
   //         {
   //             foreach (var item in items)
   //             {
   //                 _context.Set<T>().AddOrUpdate(item);
   //             }
   //             _context.SaveChanges();
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.Update failed", exception);
   //             throw;
   //         }
   //     }

       

   //     public void Remove(params T[] items) 
   //     {
   //         try
   //         {
   //             foreach (var item in items)
   //             {
   //                 try
   //                 {
   //                     bool isDetached = _context.Entry(item).State == EntityState.Detached;
   //                     if (isDetached)
   //                     {
   //                         //var found = this.GetSingle(x => x.Id == item.Id);
   //                         var found =_context.Set<T>().Find(item.Id);
   //                         if (found == null)
   //                         {
   //                             _context.Set<T>().Attach(item);
   //                             _context.Set<T>().Remove(item);
   //                         }
   //                         else
   //                         {
   //                              _context.Set<T>().Remove(found);
   //                         }
   //                     }
   //                     //_context.Entry(item).State = EntityState.Deleted;
   //                 }
   //                 catch (Exception e)
   //                 {
   //                     _logger.Error("Remove failed", e);
   //                     //skip this exception if attaching fails.
   //                 }
   //             }
   //             _context.SaveChanges();
   //         }
   //         catch (Exception exception)
   //         {
   //             _logger.Error("GenericDataRepository.Remove failed", exception);
   //             throw;
   //         }
   //     }
   // }
}
