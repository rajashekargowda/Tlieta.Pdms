using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tlieta.Pdms.DB;


namespace Tlieta.Pdms.Web.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            List<Contact> list = new List<Contact>();
            try
            {
                list = new ContactData().GetContacts();
            }
            catch (Exception ex)
            { }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Contact contact)
        {
            try
            {
                if (contact.ContactId > 0)
                    new ContactData().Update(contact);
                else
                    new ContactData().Add(contact);
            }
            catch (Exception x)
            {
            }
            return Json(contact, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete([DataSourceRequest] DataSourceRequest request, int id)
        {
            new ContactData().Delete(id);
            return Json(request);
        }
    }
}
