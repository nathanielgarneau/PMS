using System;
using System.Collections.Generic;
using System.Linq;
using CacheManager.Core;
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
            T record = ConvertToDal(item);
            Repository.Insert(record);
        }

        public void Add(params TX[] items)
        {
            List<T> results = items.Select(ConvertToDal).ToList();
            Repository.Insert(results);
        }

        public TX Get(int id)
        {
            //var item = Repository.Select(id);
            //var result = ConvertToViewModel(item);
            TX result =  ConvertToViewModel(Repository.Select(id));
            return result;
        }

        public List<TX> GetAll()
        {
            IEnumerable<T> items = Repository.SelectAll();
            List<TX> results = items.Select(ConvertToViewModel).ToList();
            return results;
        }

       

        public List<TX> GetList(params int[] ids)
        {
            return ids.Select(Get).ToList();
        }

        public void Remove(TX item)
        {
            Repository.Delete(ConvertToDal(item));
        }

        public void Remove(params TX[] items)
        {
            foreach (var item in items)
            {
                Repository.Delete(ConvertToDal(item));
            }
        }

        public void Update(TX item)
        {
            Repository.Update(ConvertToDal(item));
        }

        public void Update(params TX[] items)
        {
            List<T> records = items.Select(ConvertToDal).ToList();
            Repository.Update(records);
        }

        public virtual T ConvertToDal(TX viewModel)
        {
            throw new NotSupportedException(message: @"This Method should be overriden in the derived class");
        }

        public virtual TX ConvertToViewModel(T model)
        {
            throw new NotSupportedException(message: @"This Method should be overriden in the derived class");
        }
    }
}