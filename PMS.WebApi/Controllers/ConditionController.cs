using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/Condition")]
    public class ConditionController : ApiController, Interfaces.IApiController<ConditionViewModel, int>
    {
        private readonly BLL.Condition _businessLayer = new BLL.Condition();
        [HttpGet]
        [Route("Many")]
        public IEnumerable<ConditionViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
        [HttpGet]
        public ConditionViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
        [HttpGet]
        public IEnumerable<ConditionViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params ConditionViewModel[] items)
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
        public HttpResponseMessage Post(ConditionViewModel item)
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
        public HttpResponseMessage PutMany(params ConditionViewModel[] items)
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
        public HttpResponseMessage Put(ConditionViewModel item)
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
        public HttpResponseMessage DeleteMany(params ConditionViewModel[] items)
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
        public HttpResponseMessage Delete(ConditionViewModel item)
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
