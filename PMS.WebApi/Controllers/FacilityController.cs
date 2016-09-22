using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{ [RoutePrefix("api/Facility")]
    public class FacilityController : ApiController, Interfaces.IApiController<FacilityViewModel,int>
    {
        private readonly BLL.Facility _businessLayer = new BLL.Facility();
             [HttpGet]
        [Route("Many")] public IEnumerable<FacilityViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
            [HttpGet]   public FacilityViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
             [HttpGet]  public IEnumerable<FacilityViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
        [HttpPost]
        [Route("Many")]   public HttpResponseMessage PostMany(params FacilityViewModel[] items)
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
         [HttpPost]  public HttpResponseMessage Post(FacilityViewModel item)
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
        [Route("Many")]  public HttpResponseMessage PutMany(params FacilityViewModel[] items)
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
        [HttpPut]  public HttpResponseMessage Put(FacilityViewModel item)
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
        [Route("Many")]   public HttpResponseMessage DeleteMany(params FacilityViewModel[] items)
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
            [HttpDelete]   public HttpResponseMessage Delete(FacilityViewModel item)
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
