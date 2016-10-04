using System;
using System.Collections.Generic;
using System.Linq;
using PMS.BLL.Interfaces;
using PMS.DAL.Repositories.Interfaces;
using PMS.Xam.Model.Interfaces;

// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace PMS.BLL
{
    public class GenericBusinessLayer<T, TX> : IBusinessLayer<TX, int>, IViewModelConvertToDalModel<T, TX>
        where T : class, IEntity<int>, new() where TX : class, IEntity<int>
    {
        internal IGenericDataRepository<T> Repository;

        public virtual void Add(TX item)
        {
            var record = ConvertToDal(item);
            Repository.Insert(record);
        }

        public void Add(params TX[] items)
        {
            var settings = items.Select(item => ConvertToDal(item)).ToList();
            //Parallel.ForEach(items, item =>
            //{
            //    T record = ConvertToDal(item);
            //    lock (settings)
            //    {
            //        settings.Add(record);
            //    }
            //});
            Repository.Insert(settings);
        }

        public TX Get(int id)
        {
            var item = Repository.Select(id);
            var result = ConvertToViewModel(item);
            return result;
        }

        public List<TX> GetAll()
        {
            var items = Repository.SelectAll();
            //Parallel.ForEach(items, item =>
            //{
            //    TX result = ConvertToViewModel(item);
            //    lock (results)
            //    {
            //        results.Add(result);
            //    }
            //});
            return items.Select(item => ConvertToViewModel(item)).ToList();
        }

        public List<TX> GetList(params int[] ids)
        {
            //Parallel.ForEach(ids, id =>
            //{
            //    TX item = Get(id);
            //    lock (results)
            //    {
            //        results.Add(item);
            //    }
            //});
            return ids.Select(id => Get(id)).ToList();
        }

        public void Remove(TX item)
        {
            var record = ConvertToDal(item);
            Repository.Delete(record);
        }

        public void Remove(params TX[] items)
        {
            //Parallel.ForEach(items, item =>
            //{
            //    T record = ConvertToDal(item);
            //    lock (Repository)
            //    {
            //        Repository.Delete(record);
            //    }
            //});
            foreach (var item in items)
            {
                var record = ConvertToDal(item);
                Repository.Delete(record);
            }
        }

        public void Update(TX item)
        {
            var record = ConvertToDal(item);
            Repository.Update(record);
        }

        public void Update(params TX[] items)
        {
            var records = items.Select(item => ConvertToDal(item)).ToList();
            //Parallel.ForEach(items, item =>
            //{
            //    T record = ConvertToDal(item);
            //    lock (records)
            //    {
            //        records.Add(record);
            //    }
            //});
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