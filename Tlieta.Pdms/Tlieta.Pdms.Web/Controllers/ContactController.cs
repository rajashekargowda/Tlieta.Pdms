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
    }
}
