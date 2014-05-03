using System;
using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DB
{
    public class PatientVitalData : BaseData
    {
        public bool AddPatientVital(PatientVital model)
        {
            try
            {
                entities.PatientVitals.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
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
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}
