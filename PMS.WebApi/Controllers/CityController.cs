using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/City")]
    public class CityController : ApiController, Interfaces.IApiController<CityViewModel, int>
    {
        private readonly BLL.City _businessLayer = new BLL.City();
        [HttpGet]
        [Route("Many")]
        public IEnumerable<CityViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
        [HttpGet]
        public CityViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
        [HttpGet]
        public IEnumerable<CityViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params CityViewModel[] items)
        {
            try
            {
                _businessLayer.Add(items);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        public HttpResponseMessage Post(CityViewModel item)
        {
            try
            {
                _businessLayer.Add(item);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpPut]
        [Route("Many")]
        public HttpResponseMessage PutMany(params CityViewModel[] items)
        {
            try
            {
                _businessLayer.Update(items);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpPut]
        public HttpResponseMessage Put(CityViewModel item)
        {
            try
            {
                _businessLayer.Update(item);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpDelete]
        [Route("Many")]
        public HttpResponseMessage DeleteMany(params CityViewModel[] items)
        {
            try
            {
                _businessLayer.Remove(items);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
        [HttpDelete]
        public HttpResponseMessage Delete(CityViewModel item)
        {
            try
            {
                _businessLayer.Remove(item);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}
