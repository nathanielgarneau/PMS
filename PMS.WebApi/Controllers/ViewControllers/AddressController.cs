using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class AddressController : Controller, IViewController<AddressViewModel, int>
    {
        private readonly Address _businessLayer = new Address();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        [Route]
        public ActionResult Create()
        {
            _viewBagHelper.ProvinceSelectList(this);
            _viewBagHelper.CountrySelectList(this);
            _viewBagHelper.CitySelectList(this);
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
            _viewBagHelper.ProvinceSelectList(this);
            _viewBagHelper.CountrySelectList(this);
            _viewBagHelper.CitySelectList(this);
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