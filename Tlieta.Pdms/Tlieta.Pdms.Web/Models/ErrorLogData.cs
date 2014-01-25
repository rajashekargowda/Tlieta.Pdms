using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tlieta.Pdms.Web.Models
{
    public class ErrorLogData
    {
        PDMSDatabaseEntities entities = new PDMSDatabaseEntities();

        public List<ErrorLog> GetErrorLog()
        {
            List<ErrorLog> errors = new List<ErrorLog>();
            try
            {
                errors = (from c in entities.ErrorLogs select c).ToList();
            }
            catch { }
            return errors;
        }

        public bool Add(ErrorLog model)
        {
            try
            {
                entities.ErrorLogs.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}