using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/PaymentType")]
    public class PaymentTypeController : ApiController, Interfaces.IApiController<PaymentTypeViewModel,int>
    {
        private readonly BLL.PaymentType _businessLayer = new BLL.PaymentType();
        [HttpGet]
        [Route("Many")]  public IEnumerable<PaymentTypeViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
            [HttpGet] public PaymentTypeViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
            [HttpGet] public IEnumerable<PaymentTypeViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
          [HttpPost]
        [Route("Many")]  public HttpResponseMessage PostMany(params PaymentTypeViewModel[] items)
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
        [HttpPost] public HttpResponseMessage Post(PaymentTypeViewModel item)
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
        [Route("Many")] public HttpResponseMessage PutMany(params PaymentTypeViewModel[] items)
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
      
        [HttpPut]  public HttpResponseMessage Put(PaymentTypeViewModel item)
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
        [Route("Many")]  public HttpResponseMessage DeleteMany(params PaymentTypeViewModel[] items)
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
        [HttpDelete]  public HttpResponseMessage Delete(PaymentTypeViewModel item)
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
