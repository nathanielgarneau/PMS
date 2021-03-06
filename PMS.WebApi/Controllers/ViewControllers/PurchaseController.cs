﻿using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class PurchaseController : Controller, IViewController<PurchaseViewModel, int>
    {
        private readonly Purchase _businessLayer = new Purchase();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        public ActionResult Create()
        {
            _viewBagHelper.LocationSelectList(this);
            _viewBagHelper.ClientSelectList(this);
            return View(new PurchaseViewModel());
        }

        public ActionResult Delete(int id)
        {
            var item = _businessLayer.Get(id);
            return View(item);
        }

        public ActionResult Details(int id)
        {
            var item = _businessLayer.Get(id);
            return View(item);
        }

        public ActionResult Edit(int id)
        {
            _viewBagHelper.LocationSelectList(this);
            _viewBagHelper.ClientSelectList(this);
            var item = _businessLayer.Get(id);
            return View(item);
        }

        public ActionResult Index()
        {
            var items = _businessLayer.GetAll();
            return View(items);
        }
    }
}