using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
     [RoutePrefix("api/ProductType")]
    public class ProductTypeController : ApiController, Interfaces.IApiController<ProductTypeViewModel, int>
    {
        private readonly BLL.ProductType _businessLayer = new BLL.ProductType();
        [HttpGet]
        [Route("Many")]
        public IEnumerable<ProductTypeViewModel> GetMany([FromUri]params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }
        [HttpGet]
        public ProductTypeViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }
        [HttpGet]
        public IEnumerable<ProductTypeViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }
        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params ProductTypeViewModel[] items)
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
        public HttpResponseMessage Post(ProductTypeViewModel item)
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
        public HttpResponseMessage PutMany(params ProductTypeViewModel[] items)
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
        public HttpResponseMessage Put(ProductTypeViewModel item)
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
        public HttpResponseMessage DeleteMany(params ProductTypeViewModel[] items)
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
        public HttpResponseMessage Delete(ProductTypeViewModel item)
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
