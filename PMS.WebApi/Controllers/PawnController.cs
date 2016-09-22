using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{ [RoutePrefix("api/Pawn")]
    public class PawnController : ApiController, Interfaces.IApiController<PawnViewModel,int>
    {
        private readonly BLL.Pawn _businessLayer = new BLL.Pawn();
         [HttpGet]
        [Route("Many")] public IEnumerable<PawnViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
       [HttpGet]  public PawnViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
        [HttpGet] public IEnumerable<PawnViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
              [HttpPost]
        [Route("Many")]  public HttpResponseMessage PostMany(params PawnViewModel[] items)
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
        [HttpPost]  public HttpResponseMessage Post(PawnViewModel item)
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
        [Route("Many")]   public HttpResponseMessage PutMany(params PawnViewModel[] items)
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
       [HttpPut]  public HttpResponseMessage Put(PawnViewModel item)
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
        [Route("Many")]    public HttpResponseMessage DeleteMany(params PawnViewModel[] items)
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
        [HttpDelete]  public HttpResponseMessage Delete(PawnViewModel item)
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
