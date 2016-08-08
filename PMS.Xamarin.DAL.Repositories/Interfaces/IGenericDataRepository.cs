using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.DAL.Repositories.Interfaces
{
    public interface IGenericDataRepository<T> where T : class,  new()
    {
        T Insert(T model);
        T Update(T model);
        IEnumerable<T> Insert(IEnumerable<T> model);
        IEnumerable<T> Update(IEnumerable<T> model);
        bool Delete(T model);
        T Select(int pk);
        IEnumerable<T> SelectAll();
        //List<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        //List<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //void Add(params T[] items);
        //void Update(params T[] items);
        //void Remove(params T[] items);
    }
}
