using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class BillingData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<Billing> GetBilling(DateTime from, DateTime to)
        {
            List<Billing> billing = new List<Billing>();
            to = to.Add(new TimeSpan(1, 0, 0, 0));
            from = from.Add(new TimeSpan(-1, 0, 0, 0));
            try
            {
                billing = (from a in entities.Billings select a).ToList();
                if (billing.Count > 0)
                {
                    return billing.Where(i => i.BillingDate > from && i.BillingDate < to).ToList();
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); 
            }
            return billing;
        }

        public bool AddBilling(Billing model)
        {
            try
            {
                entities.Billings.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public bool UpdateBilling(Billing model)
        {
            try
            {
                Billing billing = entities.Billings.Where(x => x.BillingId == model.BillingId).SingleOrDefault();
                if (billing != null)
                {
                    entities.Entry(billing).CurrentValues.SetValues(model);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public bool DeleteBilling(int id)
        {
            try
            {
                Billing billing = entities.Billings.Where(x => x.BillingId == id).SingleOrDefault();
                if (billing != null)
                {
                    entities.Billings.Remove(billing);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }
    }
}
