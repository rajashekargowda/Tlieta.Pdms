using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Tlieta.Pdms.DB;
using Tlieta.Pdms.Web.Resources;

namespace Tlieta.Pdms.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Authenticate(Employee employee)
        {
            try
            {
                string key = Keys.EncryptionKey;
                employee.Password = Encryption.Encrypt(key, employee.Password);

                employee = new UserData().Authenticate(employee);

                if (employee.RoleId > 0)
                {
                    Session["userid"] = employee.UserId;
                    Session["email"] = employee.EmailId;
                    Session["role"] = employee.RoleId;
                    Session["employeename"] = employee.EmployeeName;
                    Session["employeid"] = employee.EmployeeId;

                    FormsAuthentication.SetAuthCookie(employee.UserId, true);
                }
            }
            catch { }

            return Json(employee, JsonRequestBehavior.AllowGet);
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
