using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tlieta.Pdms.Web.Models;

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

        public JsonResult Load(int patientid)
        {
            Patient patient = new Patient();
            try
            {
                patient = new PatientData().GetPatient(patientid);
            }
            catch (Exception x)
            {
            }
            return Json(patient, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Patient patient)
        {
            patient.UpdatedOn = DateTime.Now;
            try
            {
                if (patient.PatientId > 0)
                    new PatientData().Update(patient);
                else
                {
                    patient.CreatedOn = DateTime.Now;
                    patient.PatientId = new PatientData().Add(patient);
                }
            }
            catch (Exception x)
            {
            }
            return Json(patient, JsonRequestBehavior.AllowGet);
        }
    }
}
