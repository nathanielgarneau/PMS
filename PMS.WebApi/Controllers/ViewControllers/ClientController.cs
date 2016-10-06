﻿using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class ClientController : Controller, IViewController<ClientViewModel, int>
    {
        private readonly Client _businessLayer = new Client();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        public ActionResult Create()
        {
            _viewBagHelper.AddressList(this);
            _viewBagHelper.IdentificationTypeSelectList(this);
            return View(new ClientViewModel());
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
            _viewBagHelper.AddressList(this);
            _viewBagHelper.IdentificationTypeSelectList(this);
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