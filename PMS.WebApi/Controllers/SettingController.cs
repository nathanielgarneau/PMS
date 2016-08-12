using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/Setting")]
    public class SettingController : ApiController, Interfaces.IApiController<SettingViewModel,int>
    {

        private readonly BLL.Setting _businessLayer = new BLL.Setting();
       [HttpGet]
        [Route("Many")]  public IEnumerable<SettingViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
         [HttpGet] public SettingViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
         [HttpGet] public IEnumerable<SettingViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
          [HttpPost]
        [Route("Many")]   public HttpResponseMessage PostMany(params SettingViewModel[] items)
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
        [HttpPost] public HttpResponseMessage Post(SettingViewModel item)
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
        [Route("Many")] public HttpResponseMessage PutMany(params SettingViewModel[] items)
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
         [HttpPut] public HttpResponseMessage Put(SettingViewModel item)
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
        [Route("Many")]  public HttpResponseMessage DeleteMany(params SettingViewModel[] items)
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
          [HttpDelete] public HttpResponseMessage Delete(SettingViewModel item)
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
