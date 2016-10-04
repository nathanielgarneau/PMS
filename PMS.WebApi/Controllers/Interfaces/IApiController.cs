using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.Model.Interfaces;

namespace PMS.WebApi.Controllers.Interfaces
{
    //This interface has attributes set as a guideline for additional implementations, these attributes will not be migrated by implementing this interface, and need to be set by the developer.
    public interface IApiController<T, in TX>
        where T : IEntity<TX>
    {
        [HttpGet]
        [Route("Many")]
        IEnumerable<T> GetMany(params TX[] ids);

        [HttpGet]
        T GetById(int id);

        [HttpGet]
        [Route("All")]
        IEnumerable<T> GetAll();

        [HttpPost]
        [Route("Many")]
        HttpResponseMessage PostMany(params T[] items);

        [HttpPost]
        HttpResponseMessage Post(T item);

        [HttpPut]
        [Route("Many")]
        HttpResponseMessage PutMany(params T[] items);

        [HttpPut]
        HttpResponseMessage Put(T item);

        [HttpDelete]
        [Route("Many")]
        HttpResponseMessage DeleteMany(params T[] items);

        [HttpDelete]
        HttpResponseMessage Delete(T item);
    }
}