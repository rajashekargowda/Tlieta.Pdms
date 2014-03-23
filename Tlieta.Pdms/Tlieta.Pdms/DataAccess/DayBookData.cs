using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class DayBookData : BaseData
    {
        public List<DayBook> GetDayBook(DateTime from, DateTime to)
        {
            List<DayBook> daybook = new List<DayBook>();
            DateTime searchto = new DateTime(to.Year, to.Month, to.Day);
            searchto = searchto.Add(new TimeSpan(1, 0, 0, 0));
            DateTime searchfrom = new DateTime(from.Year, from.Month, from.Day);
            try
            {
                daybook = (from a in entities.DayBooks select a).ToList();
                if (daybook.Count > 0)
                {
                    return daybook.Where(i => i.BillingDate > searchfrom && i.BillingDate < searchto).ToList();
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
            return daybook;
        }

        public bool AddDayBook(DayBook model)
        {
            try
            {
                entities.DayBooks.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return false;
            }
        }

        public bool UpdateDayBook(DayBook model)
        {
            try
            {
                DayBook daybook = entities.DayBooks.Where(x => x.DayBookId == model.DayBookId).SingleOrDefault();
                if (daybook != null)
                {
                    entities.Entry(daybook).CurrentValues.SetValues(model);
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

        public bool DeleteDayBook(int id)
        {
            try
            {
                DayBook daybook = entities.DayBooks.Where(x => x.DayBookId == id).SingleOrDefault();
                if (daybook != null)
                {
                    entities.DayBooks.Remove(daybook);
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
