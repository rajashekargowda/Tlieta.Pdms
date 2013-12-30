using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tlieta.Pdms.Web.Models;
using Kendo.Mvc.Extensions;

namespace Tlieta.Pdms.Web.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult PdmsView()
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
            return Json(list.ToDataSourceResult(request));
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

        [HttpPost]
        public ActionResult Delete([DataSourceRequest] DataSourceRequest request, int id)
        {
            new ContactData().Delete(id);
            return Json(request);
        }
    }
}
