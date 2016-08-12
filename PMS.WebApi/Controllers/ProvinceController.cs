using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/Province")]
    public class ProvinceController : ApiController, Interfaces.IApiController<ProvinceViewModel,int>
    {
        private readonly BLL.Province _businessLayer = new BLL.Province();
        [HttpGet]
        [Route("Many")]  public IEnumerable<ProvinceViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
        [HttpGet] public ProvinceViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
         [HttpGet]public IEnumerable<ProvinceViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
           [HttpPost]
        [Route("Many")] public HttpResponseMessage PostMany(params ProvinceViewModel[] items)
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
       [HttpPost] public HttpResponseMessage Post(ProvinceViewModel item)
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
        [Route("Many")] public HttpResponseMessage PutMany(params ProvinceViewModel[] items)
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
      
        [HttpPut]  public HttpResponseMessage Put(ProvinceViewModel item)
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
        [Route("Many")]  public HttpResponseMessage DeleteMany(params ProvinceViewModel[] items)
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
       [HttpDelete] public HttpResponseMessage Delete(ProvinceViewModel item)
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
