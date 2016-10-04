using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/Note")]
    public class NoteController : ApiController, IApiController<NoteViewModel, int>
    {
        private readonly Note _businessLayer = new Note();

        [HttpGet]
        [Route("Many")]
        public IEnumerable<NoteViewModel> GetMany([FromUri] params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [HttpGet]
        public NoteViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [HttpGet]
        public IEnumerable<NoteViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params NoteViewModel[] items)
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
        public HttpResponseMessage Post(NoteViewModel item)
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
        public HttpResponseMessage PutMany(params NoteViewModel[] items)
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
        public HttpResponseMessage Put(NoteViewModel item)
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
        public HttpResponseMessage DeleteMany(params NoteViewModel[] items)
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
        public HttpResponseMessage Delete(NoteViewModel item)
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