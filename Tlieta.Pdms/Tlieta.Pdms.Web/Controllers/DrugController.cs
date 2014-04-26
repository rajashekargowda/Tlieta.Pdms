using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tlieta.Pdms.Web.Models;
using Tlieta.Pdms.DB;

namespace Tlieta.Pdms.Web.Controllers
{
    public class DrugController : Controller
    {
        public ActionResult Manage()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            List<Drug> list = new List<Drug>();
            try
            {
                list = new DrugData().GetDrugs();
            }
            catch (Exception ex)
            { }
            return Json(list.ToDataSourceResult(request), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Save(Drug drug)
        {
            try
            {
                if (drug.BrandId > 0)
                    new DrugData().Update(drug);
                else
                    new DrugData().Add(drug);
            }
            catch (Exception x)
            {
            }
            return Json(drug, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete([DataSourceRequest] DataSourceRequest request, int id)
        {
            new DrugData().Delete(id);
            return Json(request);
        }
    }
}
