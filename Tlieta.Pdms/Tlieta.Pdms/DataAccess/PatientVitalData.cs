using System;
using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DataAccess
{
    public class PatientVitalData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public bool AddPatientVital(PatientVital model)
        {
            try
            {
                entities.PatientVitals.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<PatientVital> GetPatientVital(int patientid)
        {
            try
            {
                List<PatientVital> result = (from p in entities.PatientVitals
                                        select p).ToList();
                if (patientid > 0)
                {
                    result = (from p in result
                              where p.PatientId == patientid
                              select p).ToList();
                }
                return result;
            }
            catch { return null; }
        }
    }
}
