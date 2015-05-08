using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Tlieta.Web.Template.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Start()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            HttpContext.Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }

    }
}
