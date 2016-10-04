using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/Tag")]
    public class TagController : ApiController, IApiController<TagViewModel, int>
    {
        private readonly Tag _businessLayer = new Tag();

        [HttpGet]
        [Route("Many")]
        public IEnumerable<TagViewModel> GetMany([FromUri] params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [HttpGet]
        public TagViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [HttpGet]
        public IEnumerable<TagViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params TagViewModel[] items)
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
        public HttpResponseMessage Post(TagViewModel item)
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
        public HttpResponseMessage PutMany(params TagViewModel[] items)
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
        public HttpResponseMessage Put(TagViewModel item)
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
        public HttpResponseMessage DeleteMany(params TagViewModel[] items)
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
        public HttpResponseMessage Delete(TagViewModel item)
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