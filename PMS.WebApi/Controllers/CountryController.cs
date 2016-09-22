using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{ [RoutePrefix("api/Country")]
    public class CountryController : ApiController, Interfaces.IApiController<CountryViewModel,int>
    {
        private readonly BLL.Country _businessLayer = new BLL.Country();
          [HttpGet]
        [Route("Many")] public IEnumerable<CountryViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
      [HttpGet]   public CountryViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
       [HttpGet]  public IEnumerable<CountryViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
           [HttpPost]
        [Route("Many")]      public HttpResponseMessage PostMany(params CountryViewModel[] items)
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
        [HttpPost]  public HttpResponseMessage Post(CountryViewModel item)
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
        [Route("Many")]   public HttpResponseMessage PutMany(params CountryViewModel[] items)
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
         [HttpPut]  public HttpResponseMessage Put(CountryViewModel item)
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
        [Route("Many")]   public HttpResponseMessage DeleteMany(params CountryViewModel[] items)
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
       [HttpDelete]  public HttpResponseMessage Delete(CountryViewModel item)
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
