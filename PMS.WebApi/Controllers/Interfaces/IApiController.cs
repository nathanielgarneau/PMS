using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PMS.Xam.Model.Interfaces;

namespace PMS.WebApi.Controllers.Interfaces
{
    //This interface has attributes set as a guideline for additional implementations, these attributes will not be migrated by implementing this interface, and need to be set by the developer.
    public interface IApiController<T, in TX>
        where T : IEntity<TX>
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Many")]
        IEnumerable<T> GetMany(params TX[] ids);
          [System.Web.Http.HttpGet]
        T GetById(int id);
            [System.Web.Http.HttpGet]
        [System.Web.Http.Route("All")]
        IEnumerable<T> GetAll();
            [System.Web.Http.HttpPost]
        [System.Web.Http.Route("Many")]
        HttpResponseMessage PostMany(params T[] items);

        [System.Web.Http.HttpPost]
        HttpResponseMessage Post(T item);
             [System.Web.Http.HttpPut]
        [System.Web.Http.Route("Many")]
        HttpResponseMessage PutMany(params T[] items);
          [System.Web.Http.HttpPut]
        HttpResponseMessage Put(T item);
           [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("Many")]
        HttpResponseMessage DeleteMany(params T[] items);
             [System.Web.Http.HttpDelete]
        HttpResponseMessage Delete(T item);
    }
}
