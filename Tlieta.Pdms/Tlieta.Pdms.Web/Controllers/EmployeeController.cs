
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tlieta.Pdms.DB;
using Tlieta.Pdms.Web.Resources;

namespace Tlieta.Pdms.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            List<Employee> list = new List<Employee>();
            try
            {
                list = new UserData().GetEmployees();
            }
            catch (Exception ex)
            { }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Employee employee)
        {
            try
            {
                if (employee.EmployeeId > 0)
                    new UserData().Update(employee);
                else
                {
                    employee.Password = Encryption.Encrypt(Keys.EncryptionKey, Keys.DefaultPassword);
                    new UserData().Add(employee);
                }
            }
            catch (Exception x)
            {
            }
            return Json(employee, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete([DataSourceRequest] DataSourceRequest request, int id)
        {
            new UserData().Delete(id);
            return Json(request);
        }

        public ActionResult ReadRoles([DataSourceRequest] DataSourceRequest request)
        {
            List<Role> list = new List<Role>();
            try
            {
                list = new UserData().GetRoles();
            }
            catch (Exception ex)
            { }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult ReadEmployeeByRole()
        {
            List<Employee> list = new List<Employee>();
            try
            {
                list = new UserData().GetEmployeesByRole((int)Enums.Role.Doctor);
            }
            catch (Exception ex)
            { }
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}
