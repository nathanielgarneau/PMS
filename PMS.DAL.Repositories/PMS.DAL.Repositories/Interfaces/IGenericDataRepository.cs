using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.DAL.Repositories.Interfaces
{
    public interface IGenericDataRepository<T> where T : class, new()
    {
        void MarkUnchanged(IEntity<int> model, List<string> referencesToMarkUnchanged,
            List<string> collectionsToMarkUnchanged);

        T Insert(T model);
        T Update(T model);
        IEnumerable<T> Insert(IEnumerable<T> model);
        IEnumerable<T> Update(IEnumerable<T> model);
        bool Delete(T model);
        T Select(int pk);
        IEnumerable<T> SelectAll();
        //void Remove(params T[] items);
        //void Update(params T[] items);
        //void Add(params T[] items);
        //T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //List<T> GetList(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
        //List<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
    }
}