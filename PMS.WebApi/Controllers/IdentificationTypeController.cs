using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{ [RoutePrefix("api/IdentificationType")]
    public class IdentificationTypeController : ApiController, Interfaces.IApiController<IdentificationTypeViewModel, int>
    {
        private readonly BLL.IdentificationType _businessLayer = new BLL.IdentificationType();
        [HttpGet]
        [Route("Many")]
        public IEnumerable<IdentificationTypeViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
        [HttpGet]
        public IdentificationTypeViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
        [HttpGet]
        public IEnumerable<IdentificationTypeViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params IdentificationTypeViewModel[] items)
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
        public HttpResponseMessage Post(IdentificationTypeViewModel item)
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
        public HttpResponseMessage PutMany(params IdentificationTypeViewModel[] items)
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
        public HttpResponseMessage Put(IdentificationTypeViewModel item)
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
        public HttpResponseMessage DeleteMany(params IdentificationTypeViewModel[] items)
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
        public HttpResponseMessage Delete(IdentificationTypeViewModel item)
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
