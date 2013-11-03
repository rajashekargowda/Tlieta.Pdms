using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DataAccess
{
    public class SurgeryData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public Surgery GetSurgeriesById(int surgeryid)
        {
            try
            {
                Surgery surgery = entities.Surgeries.Find(surgeryid);
                return surgery;
            }
            catch { return null; }
        }

        public List<Surgery> GetSurgeriesForPatient(int patientid)
        {
            try
            {
                List<Surgery> surgerylist = entities.Surgeries.Where(s => s.PatientId == patientid).ToList();
                return surgerylist;
            }
            catch { return null; }
        }

        public int AddSurgery(Surgery model)
        {
            try
            {
                entities.Surgeries.Add(model);
                return entities.SaveChanges();
            }
            catch { return 0; }
        }

        public bool UpdateSurgery(Surgery model)
        {
            try
            {
                Surgery surgery = entities.Surgeries.Where(x => x.SurgeryId == model.SurgeryId).SingleOrDefault();
                if (surgery != null)
                {
                    entities.Entry(surgery).CurrentValues.SetValues(model);
                    entities.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
    }
}
