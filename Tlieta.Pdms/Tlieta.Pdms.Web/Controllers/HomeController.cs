using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tlieta.Pdms.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult SessionTimeout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SessionTimeout()
        {
            return RedirectToAction("Index", "Home");
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
