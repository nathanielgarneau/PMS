﻿using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class ProvinceController : Controller, IViewController<ProvinceViewModel, int>
    {
        private readonly Province _businessLayer = new Province();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        public ActionResult Create()
        {
            _viewBagHelper.CountrySelectList(this);
            return View(new ProvinceViewModel());
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
            _viewBagHelper.CountrySelectList(this);
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