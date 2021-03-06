﻿using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class PawnController : Controller, IViewController<PawnViewModel, int>
    {
        private readonly Pawn _businessLayer = new Pawn();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        public ActionResult Create()
        {
            _viewBagHelper.ProductList(this);
            _viewBagHelper.LocationSelectList(this);
            _viewBagHelper.RateSelectList(this);
            _viewBagHelper.ClientList(this);
            return View(new PawnViewModel());
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
            _viewBagHelper.ProductList(this);
            _viewBagHelper.LocationSelectList(this);
            _viewBagHelper.RateSelectList(this);
            _viewBagHelper.ClientList(this);
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