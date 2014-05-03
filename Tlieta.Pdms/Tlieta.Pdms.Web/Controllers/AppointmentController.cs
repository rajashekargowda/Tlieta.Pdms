
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tlieta.Pdms.DB;
using Tlieta.Utility;
using Tlieta.Pdms.Web.Resources;
using System.Globalization;

namespace Tlieta.Pdms.Web.Controllers
{
    public class AppointmentController : Controller
    {
        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request, string startdate, string enddate)
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                list = new AppointmentData().GetAppointments(DateTime.ParseExact(startdate, @"M/d/yyyy", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(enddate, @"M/d/yyyy", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            { }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Appointment appointment)
        {
            try
            {
                if (appointment.AppointmentId > 0)
                    new AppointmentData().Update(appointment);
                else
                    new AppointmentData().Add(appointment);
            }
            catch (Exception x)
            {
            }
            return Json(appointment, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete([DataSourceRequest] DataSourceRequest request, int id)
        {
            new AppointmentData().Delete(id);
            return Json(request);
        }
    }
}
