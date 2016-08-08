using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PMS.DAL.Model.Interfaces;

namespace PMS.DAL.Repositories.Interfaces
{
    public interface IGenericDataRepository<T> where T : class
    {
        T Insert<T>(T model);
        T Update<T>(T model);
        IEnumerable<T> Insert<T>(IEnumerable<T> model);
        IEnumerable<T> Update<T>(IEnumerable<T> model);
        bool Delete<T>(T model);
        T Select<T>(int pk) where T :  new();
        IEnumerable<T> SelectAll<T>() where T :  new();
        //List<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        //List<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //void Add(params T[] items);
        //void Update(params T[] items);
        //void Remove(params T[] items);
    }
}
