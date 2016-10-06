using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.Xam.ViewModel;
using WebGrease.Css.Extensions;

namespace PMS.WebApi.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController, IApiController<ProductViewModel, int>,
        IHasRelatedEntities<ProductViewModel>
    {
        private readonly Product _businessLayer = new Product();
        private readonly BusinessLayer BusinessLayer = new BusinessLayer();

        [HttpGet]
        [Route("Many")]
        public IEnumerable<ProductViewModel> GetMany([FromUri] params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [HttpGet]
        public ProductViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [HttpPost]
        [Route("Many")]
        public HttpResponseMessage PostMany(params ProductViewModel[] items)
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
        public HttpResponseMessage Post(ProductViewModel item)
        {
            try
            {
                item.OnPostBind();
                item = AttachRelations(item);
                _businessLayer.Add(item);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpPut]
        [Route("Many")]
        public HttpResponseMessage PutMany(params ProductViewModel[] items)
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
        public HttpResponseMessage Put(ProductViewModel item)
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
        public HttpResponseMessage DeleteMany(params ProductViewModel[] items)
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
        public HttpResponseMessage Delete(ProductViewModel item)
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

        /// <summary>
        ///     IHasRelatedEntities implementation to fully populate dropdownlist selections in the viewmodel, this is required to
        ///     pass EF validations.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>a modified version of item</returns>
        public ProductViewModel AttachRelations(ProductViewModel item)
        {
            Parallel.Invoke(
                () => { item.Colour = BusinessLayer.Colour.Get(item.Colour.Id); },
                () => { item.Conditions = BusinessLayer.Condition.GetList(item.Conditions.Select(x => x.Id).ToArray()); },
                () => { item.Tags = BusinessLayer.Tag.GetList(item.Tags.Select(x => x.Id).ToArray()); },
                () => { item.ProductType = BusinessLayer.ProductType.Get(item.ProductType.Id); });
            return item;
        }
    }
}