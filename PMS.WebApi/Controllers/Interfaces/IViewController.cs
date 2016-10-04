using System.Web.Mvc;
using PMS.Xam.Model.Interfaces;

namespace PMS.WebApi.Controllers.Interfaces
{
    public interface IViewController<T, in TX>
        where T : IEntity<TX>
    {
        ActionResult Index();
        ActionResult Details(TX id);
        ActionResult Create();
        ActionResult Edit(TX id);
        ActionResult Delete(TX id);
    }
}