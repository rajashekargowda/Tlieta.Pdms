using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class SurgeryData : BaseData
    {
        public Surgery GetSurgeriesById(int surgeryid)
        {
            try
            {
                Surgery surgery = entities.Surgeries.Find(surgeryid);
                return surgery;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public List<Surgery> GetSurgeriesForPatient(int patientid)
        {
            try
            {
                List<Surgery> surgerylist = entities.Surgeries.Where(s => s.PatientId == patientid).ToList();
                return surgerylist;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public int AddSurgery(Surgery model)
        {
            try
            {
                model.CreatedOn = DateTime.Now;
                entities.Surgeries.Add(model);
                return entities.SaveChanges();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return 0;
            }
        }

        public bool UpdateSurgery(Surgery model)
        {
            try
            {
                Surgery surgery = entities.Surgeries.Where(x => x.SurgeryId == model.SurgeryId).SingleOrDefault();
                if (surgery != null)
                {
                    model.CreatedOn = surgery.CreatedOn;
                    entities.Entry(surgery).CurrentValues.SetValues(model);
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
