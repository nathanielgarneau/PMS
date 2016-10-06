using System.Linq;
using System.Web.Mvc;
using PMS.BLL;
using PMS.WebApi.Controllers.ViewControllers;

namespace PMS.WebApi.Helpers
{
    public class ViewBagHelper
    {
        private readonly BusinessLayer _businessLayer = new BusinessLayer();

        public void AddressSelectList(Controller controller)
        {
            controller.ViewBag.AddressSelectList = _businessLayer.Address.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void CitySelectList(Controller controller)
        {
            controller.ViewBag.CitySelectList = _businessLayer.City.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void ClientSelectList(Controller controller)
        {
            controller.ViewBag.ClientSelectList = _businessLayer.Client.GetAll().Select(s => new
            {
                s.Id,
                FullName = string.Format("{0} {1}", s.FirstName, s.LastName)
            }).Select(x =>
                new SelectListItem {Text = x.FullName, Value = x.Id.ToString()});
        }

        public void ColourSelectList(Controller controller)
        {
            controller.ViewBag.ColourSelectList = _businessLayer.Colour.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void ConditionSelectList(Controller controller)
        {
            controller.ViewBag.ConditionSelectList = _businessLayer.Condition.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void CountrySelectList(Controller controller)
        {
            controller.ViewBag.CountrySelectList = _businessLayer.Country.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void FacilitySelectList(Controller controller)
        {
            controller.ViewBag.FacilitySelectList = _businessLayer.Facility.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void IdentificationTypeSelectList(Controller controller)
        {
            controller.ViewBag.IdentificationTypeSelectList = _businessLayer.IdentificationType.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void LocationSelectList(Controller controller)
        {
            controller.ViewBag.LocationSelectList = _businessLayer.Location.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void NoteSelectList(Controller controller)
        {
            controller.ViewBag.NoteSelectList = _businessLayer.Note.GetAll().Select(x =>
                new SelectListItem {Text = x.Value, Value = x.Id.ToString()});
        }

        public void PawnSelectList(Controller controller)
        {
            controller.ViewBag.PawnSelectList = _businessLayer.Pawn.GetAll().Select(x =>
                new SelectListItem {Text = x.Id.ToString(), Value = x.Id.ToString()});
        }

        public void PaymentSelectList(Controller controller)
        {
            controller.ViewBag.PaymentSelectList = _businessLayer.Payment.GetAll().Select(x =>
                new SelectListItem {Text = x.Id.ToString(), Value = x.Id.ToString()});
        }

        public void PaymentTypeSelectList(Controller controller)
        {
            controller.ViewBag.PaymentTypeSelectList = _businessLayer.PaymentType.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void ProductSelectList(Controller controller)
        {
            controller.ViewBag.ProductSelectList = _businessLayer.Product.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void ProductTypeSelectList(Controller controller)
        {
            controller.ViewBag.ProductTypeSelectList = _businessLayer.ProductType.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void ProvinceSelectList(Controller controller)
        {
            controller.ViewBag.ProvinceSelectList = _businessLayer.Province.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void PurchaseSelectList(Controller controller)
        {
            controller.ViewBag.PurchaseSelectList = _businessLayer.Purchase.GetAll().Select(x =>
                new SelectListItem {Text = x.Id.ToString(), Value = x.Id.ToString()});
        }

        public void RateSelectList(Controller controller)
        {
            controller.ViewBag.RateSelectList = _businessLayer.Rate.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void SettingSelectList(Controller controller)
        {
            controller.ViewBag.SettingSelectList = _businessLayer.Setting.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void TagSelectList(Controller controller)
        {
            controller.ViewBag.TagSelectList = _businessLayer.Tag.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void UserSelectList(Controller controller)
        {
            controller.ViewBag.UserSelectList = _businessLayer.User.GetAll().Select(x =>
                new SelectListItem {Text = x.Username, Value = x.Id.ToString()});
        }

        public void UserSettingSelectList(Controller controller)
        {
            controller.ViewBag.UserSettingSelectList = _businessLayer.UserSetting.GetAll().Select(x =>
                new SelectListItem {Text = x.Name, Value = x.Id.ToString()});
        }

        public void AddressMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Address.GetAll();
            controller.ViewBag.AddressMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void CityMultiSelectList(Controller controller)
        {
            var items = _businessLayer.City.GetAll();
            controller.ViewBag.CityMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void ClientMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Client.GetAll().Select(s => new
            {
                s.Id,
                FullName = string.Format("{0} {1}", s.FirstName, s.LastName)
            });
            controller.ViewBag.ClientMultiSelectList = new MultiSelectList(items, "Id", "FullName");
        }

        public void ColourMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Colour.GetAll();
            controller.ViewBag.ColourMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void ConditionMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Condition.GetAll();
            controller.ViewBag.ConditionMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void CountryMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Country.GetAll();
            controller.ViewBag.CountryMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void FacilityMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Facility.GetAll();
            controller.ViewBag.FacilityMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void IdentificationTypeMultiSelectList(Controller controller)
        {
            var items = _businessLayer.IdentificationType.GetAll();
            controller.ViewBag.IdentificationTypeMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void LocationMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Location.GetAll();
            controller.ViewBag.LocationMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void NoteMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Note.GetAll();
            controller.ViewBag.NoteMultiSelectList = new MultiSelectList(items, "Id", "Value");
        }

        public void PawnMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Pawn.GetAll();
            controller.ViewBag.PawnMultiSelectList = new MultiSelectList(items, "Id", "Id");
        }

        public void PaymentMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Payment.GetAll();
            controller.ViewBag.PaymentMultiSelectList = new MultiSelectList(items, "Id", "Id");
        }

        public void PaymentTypeMultiSelectList(Controller controller)
        {
            var items = _businessLayer.PaymentType.GetAll();
            controller.ViewBag.PaymentTypeMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void ProductMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Product.GetAll();
            controller.ViewBag.ProductMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void ProductTypeMultiSelectList(Controller controller)
        {
            var items = _businessLayer.ProductType.GetAll();
            controller.ViewBag.ProductTypeMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void ProvinceMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Province.GetAll();
            controller.ViewBag.ProvinceMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void PurchaseMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Purchase.GetAll();
            controller.ViewBag.PurchaseMultiSelectList = new MultiSelectList(items, "Id", "Id");
        }

        public void RateMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Rate.GetAll();
            controller.ViewBag.RateMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void SettingMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Setting.GetAll();
            controller.ViewBag.SettingMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void TagMultiSelectList(Controller controller)
        {
            var items = _businessLayer.Tag.GetAll();
            controller.ViewBag.TagMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void UserMultiSelectList(Controller controller)
        {
            var items = _businessLayer.User.GetAll();
            controller.ViewBag.UserMultiSelectList = new MultiSelectList(items, "Id", "Username");
        }

        public void UserSettingMultiSelectList(Controller controller)
        {
            var items = _businessLayer.UserSetting.GetAll();
            controller.ViewBag.UserSettingMultiSelectList = new MultiSelectList(items, "Id", "Name");
        }

        public void AddressList(Controller controller)
        {
             var items = _businessLayer.UserSetting.GetAll();
            controller.ViewBag.AddressList = items;
        }
        public void CityList(Controller controller)
        {
            var items = _businessLayer.City.GetAll();
            controller.ViewBag.CityList = items;
        }

        public void ClientList(Controller controller)
        {
            var items = _businessLayer.Client.GetAll().Select(s => new
            {
                s.Id,
                FullName = string.Format("{0} {1}", s.FirstName, s.LastName)
            });
            controller.ViewBag.ClientList = items;
        }

        public void ColourList(Controller controller)
        {
            var items = _businessLayer.Colour.GetAll();
            controller.ViewBag.ColourList = items;
        }

        public void ConditionList(Controller controller)
        {
            var items = _businessLayer.Condition.GetAll();
            controller.ViewBag.ConditionList = items;
        }

        public void CountryList(Controller controller)
        {
            var items = _businessLayer.Country.GetAll();
            controller.ViewBag.CountryList =items;
        }

        public void FacilityList(Controller controller)
        {
            var items = _businessLayer.Facility.GetAll();
            controller.ViewBag.FacilityList = items;
        }

        public void IdentificationTypeList(Controller controller)
        {
            var items = _businessLayer.IdentificationType.GetAll();
            controller.ViewBag.IdentificationTypeList = items;
        }

        public void LocationList(Controller controller)
        {
            var items = _businessLayer.Location.GetAll();
            controller.ViewBag.LocationList = items;
        }

        public void NoteList(Controller controller)
        {
            var items = _businessLayer.Note.GetAll();
            controller.ViewBag.NoteList = items;
        }

        public void PawnList(Controller controller)
        {
            var items = _businessLayer.Pawn.GetAll();
            controller.ViewBag.PawnList = items;
        }

        public void PaymentList(Controller controller)
        {
            var items = _businessLayer.Payment.GetAll();
            controller.ViewBag.PaymentList = items;
        }

        public void PaymentTypeList(Controller controller)
        {
            var items = _businessLayer.PaymentType.GetAll();
            controller.ViewBag.PaymentTypeList = items;
        }

        public void ProductList(Controller controller)
        {
            var items = _businessLayer.Product.GetAll();
            controller.ViewBag.ProductList = items;
        }

        public void ProductTypeList(Controller controller)
        {
            var items = _businessLayer.ProductType.GetAll();
            controller.ViewBag.ProductTypeList = items;
        }

        public void ProvinceList(Controller controller)
        {
            var items = _businessLayer.Province.GetAll();
            controller.ViewBag.ProvinceList = items;
        }

        public void PurchaseList(Controller controller)
        {
            var items = _businessLayer.Purchase.GetAll();
            controller.ViewBag.PurchaseList = items;
        }

        public void RateList(Controller controller)
        {
            var items = _businessLayer.Rate.GetAll();
            controller.ViewBag.RateList = items;
        }

        public void SettingList(Controller controller)
        {
            var items = _businessLayer.Setting.GetAll();
            controller.ViewBag.SettingList = items;
        }

        public void TagList(Controller controller)
        {
            var items = _businessLayer.Tag.GetAll();
            controller.ViewBag.TagList = items;
        }

        public void UserList(Controller controller)
        {
            var items = _businessLayer.User.GetAll();
            controller.ViewBag.UserList = items;
        }

        public void UserSettingList(Controller controller)
        {
            var items = _businessLayer.UserSetting.GetAll();
            controller.ViewBag.UserSettingList = items;
        }
    }
}