using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{ [RoutePrefix("api/User")]
    public class UserController : ApiController, Interfaces.IApiController<UserViewModel,int>
    {
        private readonly BLL.User _businessLayer = new BLL.User();
          [HttpGet]
        [Route("Many")] public IEnumerable<UserViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
          [HttpGet]  public UserViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
           [HttpGet] public IEnumerable<UserViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
          [HttpPost]
        [Route("Many")]   public HttpResponseMessage PostMany(params UserViewModel[] items)
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
         [HttpPost] public HttpResponseMessage Post(UserViewModel item)
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
        [Route("Many")]  public HttpResponseMessage PutMany(params UserViewModel[] items)
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
         [HttpPut]  public HttpResponseMessage Put(UserViewModel item)
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
        [Route("Many")] public HttpResponseMessage DeleteMany(params UserViewModel[] items)
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
        [HttpDelete]  public HttpResponseMessage Delete(UserViewModel item)
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
