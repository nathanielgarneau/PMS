using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/Location")]
    public class LocationController : ApiController, IApiController<LocationViewModel, int>
    {
        private readonly Location _businessLayer = new Location();

        [HttpGet]
        [Route("Many")]
        public IEnumerable<LocationViewModel> GetMany([FromUri] params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [HttpGet]
        public LocationViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [HttpGet]
        public IEnumerable<LocationViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params LocationViewModel[] items)
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
        public HttpResponseMessage Post(LocationViewModel item)
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
        public HttpResponseMessage PutMany(params LocationViewModel[] items)
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
        public HttpResponseMessage Put(LocationViewModel item)
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
        public HttpResponseMessage DeleteMany(params LocationViewModel[] items)
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
        public HttpResponseMessage Delete(LocationViewModel item)
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