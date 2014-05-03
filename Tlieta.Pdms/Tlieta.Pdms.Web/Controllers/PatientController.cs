using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tlieta.Pdms.Web.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Info(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
