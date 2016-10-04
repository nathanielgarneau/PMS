using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.Interfaces;
using PMS.WebApi.Helpers;
using PMS.Xam.ViewModel;

namespace PMS.WebApi.Controllers.ViewControllers
{
    public class ProductController : Controller, IViewController<ProductViewModel, int>
    {
        private readonly Product _businessLayer = new Product();
        private readonly ViewBagHelper _viewBagHelper = new ViewBagHelper();

        public ActionResult Create()
        {
            _viewBagHelper.ProductTypeSelectList(this);
            _viewBagHelper.ColourSelectList(this);
            _viewBagHelper.ConditionMultiSelectList(this);
            _viewBagHelper.TagMultiSelectList(this);
            return View(new ProductViewModel());
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
            _viewBagHelper.ProductTypeSelectList(this);
            _viewBagHelper.ColourSelectList(this);
            _viewBagHelper.ConditionMultiSelectList(this);
            _viewBagHelper.TagMultiSelectList(this);
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