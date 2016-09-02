using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers
{
    [System.Web.Http.RoutePrefix("api/Address")]
    public class AddressController : ApiController, Interfaces.IApiController<AddressViewModel, int>
    {
        private readonly BLL.Address _businessLayer = new BLL.Address();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Many")]
        public IEnumerable<AddressViewModel> GetMany(params int[] ids)
        {
            return _businessLayer.GetList(ids);
        }

        [System.Web.Http.HttpGet]
        public AddressViewModel GetById(int id)
        {
            return _businessLayer.Get(id);
        }

        [System.Web.Http.HttpGet]
        public IEnumerable<AddressViewModel> GetAll()
        {
            return _businessLayer.GetAll();
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("Many")]
        public HttpResponseMessage PostMany(params AddressViewModel[] items)
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

        [System.Web.Http.HttpPost]
        public HttpResponseMessage Post(AddressViewModel item)
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

        [System.Web.Http.HttpPut]
        [System.Web.Http.Route("Many")]
        public HttpResponseMessage PutMany(params AddressViewModel[] items)
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

        [System.Web.Http.HttpPut]
        public HttpResponseMessage Put(AddressViewModel item)
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

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("Many")]
        public HttpResponseMessage DeleteMany(params AddressViewModel[] items)
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

        [System.Web.Http.HttpDelete]
        public HttpResponseMessage Delete(AddressViewModel item)
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