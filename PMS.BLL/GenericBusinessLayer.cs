using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PMS.DAL.Repositories.Interfaces;
using PMS.Xam.Model.Interfaces;

// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace PMS.BLL
{
    public class GenericBusinessLayer<T, TX> : PMS.BLL.Interfaces.IBusinessLayer<TX, int>, PMS.BLL.Interfaces.IViewModelConvertToDalModel<T, TX>
        where T : class, IEntity<int>, new() where TX : class, IEntity<int>
    {
        internal IGenericDataRepository<T> Repository;

        public void Add(TX item)
        {
            T record = ConvertToDal(item);
            Repository.Insert(record);
        }

        public void Add(params TX[] items)
        {
            List<T> settings = new List<T>();
            Parallel.ForEach(items, item =>
            {
                T record = ConvertToDal(item);
                lock (settings)
                {
                    settings.Add(record);
                }
            });
            Repository.Insert(settings);
        }

        public TX Get(int id)
        {
            T item = Repository.Select(id);
            TX result = ConvertToViewModel(item);
            return result;
        }

        public List<TX> GetAll()
        {
            IEnumerable<T> items = Repository.SelectAll();
            List<TX> results = new List<TX>();
            Parallel.ForEach(items, item =>
            {
                TX result = ConvertToViewModel(item);
                lock (results)
                {
                    results.Add(result);
                }
            });
            return results;
        }

        public List<TX> GetList(params int[] ids)
        {
            List<TX> results = new List<TX>();
            Parallel.ForEach(ids, id =>
            {
                TX item = Get(id);
                lock (results)
                {
                    results.Add(item);
                }
            });
            return results;
        }

        public void Remove(TX item)
        {
            T record = ConvertToDal(item);
            Repository.Delete(record);
        }

        public void Remove(params TX[] items)
        {
            Parallel.ForEach(items, item =>
            {
                T record = ConvertToDal(item);
                lock (Repository)
                {
                    Repository.Delete(record);
                }
            });
        }

        public void Update(TX item)
        {
            T record = ConvertToDal(item);
            Repository.Update(record);
        }

        public void Update(params TX[] items)
        {
            List<T> records = new List<T>();
            Parallel.ForEach(items, item =>
            {
                T record = ConvertToDal(item);
                lock (records)
                {
                    records.Add(record);
                }
            });
            Repository.Update(records);
        }

        public virtual T ConvertToDal(TX viewModel)
        {
            throw new NotSupportedException("This Method should be overriden in the derived class");
        }

        public virtual TX ConvertToViewModel(T model)
        {
            throw new NotSupportedException("This Method should be overriden in the derived class");
        }
    }
}
