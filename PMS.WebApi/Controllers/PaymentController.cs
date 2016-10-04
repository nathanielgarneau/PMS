using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/Payment")]
    public class PaymentController : ApiController, IApiController<PaymentViewModel, int>
    {
        private readonly Payment _businessLayer = new Payment();

        [HttpGet]
        [Route("Many")]
        public IEnumerable<PaymentViewModel> GetMany([FromUri] params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [HttpGet]
        public PaymentViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [HttpGet]
        public IEnumerable<PaymentViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params PaymentViewModel[] items)
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
        public HttpResponseMessage Post(PaymentViewModel item)
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
        public HttpResponseMessage PutMany(params PaymentViewModel[] items)
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
        public HttpResponseMessage Put(PaymentViewModel item)
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
        public HttpResponseMessage DeleteMany(params PaymentViewModel[] items)
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
        public HttpResponseMessage Delete(PaymentViewModel item)
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