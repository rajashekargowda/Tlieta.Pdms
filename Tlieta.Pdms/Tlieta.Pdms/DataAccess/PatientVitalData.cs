using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
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
                FileLogger.LogError(x); return false;
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
                FileLogger.LogError(x); return null;
            }
        }
    }
}
