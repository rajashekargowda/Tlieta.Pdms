using System;
using System.Collections.Generic;
using System.Linq;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.DataAccess
{
    public class PatientData : BaseData
    {
        public PatientData()
        {
        }

        public int AddPatient(Patient model )
        {
            try
            {
                entities.Patients.Add(model);
                return entities.SaveChanges();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return 0;
            }
        }

        public bool UpdatePatient(Patient model)
        {
            try
            {
                Patient patient =  entities.Patients.Where(x => x.PatientId == model.PatientId).SingleOrDefault();
                if (patient != null)
                {
                    entities.Entry(patient).CurrentValues.SetValues(model);
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

        public List<Patient> GetSearchResult(string name, int hospitalId)
        {
            try
            {
                List<Patient> result = (from p in entities.Patients
                                        select p).ToList();

                if (! String.IsNullOrEmpty(name))
                {
                    result = (from p in result
                              where (p.FirstName.Contains(name) || p.LastName.Contains(name))
                              select p).ToList();
                }

                if (result !=null && result.Count > 0 && hospitalId > 0)
                {
                    result = result.Where(p => p.HospitalId == hospitalId).ToList();
                }

                return result;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }

        public Patient GetPatientById(int patientId)
        {
            try
            {
                Patient patient = entities.Patients.Find(patientId);
                return patient;
            }
            catch (Exception x)
            {
                FileLogger.LogError(x); return null;
            }
        }
    }
}
