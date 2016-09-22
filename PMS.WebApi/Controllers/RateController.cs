using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/Rate")]
    public class RateController : ApiController, Interfaces.IApiController<RateViewModel,int>
    {
        
        private readonly BLL.Rate _businessLayer = new BLL.Rate();
         [HttpGet]
        [Route("Many")] public IEnumerable<RateViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
      [HttpGet]  public RateViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
       [HttpGet] public IEnumerable<RateViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
          [HttpPost]
        [Route("Many")]   public HttpResponseMessage PostMany(params RateViewModel[] items)
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
       [HttpPost] public HttpResponseMessage Post(RateViewModel item)
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
        [Route("Many")]  public HttpResponseMessage PutMany(params RateViewModel[] items)
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
     [HttpPut]    public HttpResponseMessage Put(RateViewModel item)
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
        [Route("Many")]  public HttpResponseMessage DeleteMany(params RateViewModel[] items)
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
         [HttpDelete] public HttpResponseMessage Delete(RateViewModel item)
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
