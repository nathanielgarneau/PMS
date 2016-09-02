using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class AddressController : Controller, Interfaces.IViewController<AddressViewModel, int>
    {
        private readonly BLL.Address _businessLayer = new BLL.Address();

        [Route]
        public ActionResult Create()
        {
            return View(new AddressViewModel());
        }
        [Route]
        public ActionResult Delete(int id)
        {
            var item = _businessLayer.Get(id);
            return View(item);
        }
        [Route]
        public ActionResult Details(int id)
        {
            var item = _businessLayer.Get(id);
            return View(item);
        }
        [Route]
        public ActionResult Edit(int id)
        {
            var item = _businessLayer.Get(id);
            return View(item);
        }
        [Route]
        public ActionResult Index()
        {
            var items = _businessLayer.GetAll();
            return View(items);
        }
    }
}