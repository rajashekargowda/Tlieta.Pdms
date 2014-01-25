using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Tlieta.Pdms.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard(string user)
        {
            Session["userid"] = user;
            return View();
        }

        public ActionResult SessionTimeout()
        {
            return View();
        }
        
        public ActionResult Logout()
        {
            ModelState.AddModelError("LoginException", "Successfully logged out !");
            FormsAuthentication.SignOut();
            HttpContext.Session.RemoveAll();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult ChangePassword()
        {
            return View();
        }
    }
}
