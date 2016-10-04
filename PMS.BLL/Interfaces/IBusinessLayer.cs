using System.Collections.Generic;
using PMS.Xam.Model.Interfaces;

namespace PMS.BLL.Interfaces
{
    public interface IBusinessLayer<T, in TX>
        where T : IEntity<TX>
    {
        List<T> GetList(params TX[] ids);

        T Get(int id);

        List<T> GetAll();

        void Add(params T[] items);
        void Add(T item);
        void Update(params T[] items);
        void Update(T item);
        void Remove(params T[] items);
        void Remove(T item);
    }
}