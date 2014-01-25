using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tlieta.Pdms.Web.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View("Error");
        }

        public ActionResult SessionTimeout()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult SessionTimeout()
        //{
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
