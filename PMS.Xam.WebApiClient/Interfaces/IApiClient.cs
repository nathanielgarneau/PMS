using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.Xam.WebApiClient.Interfaces
{
      public interface IApiClient<T, in TX>
        where T : IEntity<TX>
    {
        List<T> GetList(params TX[] ids);
        T GetSingle(TX id);
        List<T> GetAll();
        void Add(params T[] items);
        void Add(T item);
        void Update(params T[] items);
        void Update(T item);
        void Remove(params T[] items);
        void Remove(T item);
    }
}
