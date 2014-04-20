using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tlieta.Pdms.DB;

namespace Tlieta.Pdms.Web.Models
{
    public class PatientData : BaseData
    {
        public int Add(Patient model)
        {
            try
            {
                entities.Patients.Add(model);
                entities.SaveChanges();
                return model.PatientId;
            }
            catch { return 0; }
        }

        public bool Update(Patient model)
        {
            try
            {
                Patient patient = entities.Patients.Where(x => x.PatientId == model.PatientId).SingleOrDefault();
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
            catch { return false; }
        }

        public bool Delete(int Id)
        {
            var result = entities.Contacts.Where(x => x.ContactId == Id);
            if (result.Count() > 0)
            {
                Contact contact = result.First();
                entities.Contacts.Remove(contact);
                entities.SaveChanges();
            }
            return true;
        }

        public List<Patient> Search(string search)
        {
            try
            {
                List<Patient> result = (from p in entities.Patients
                                        select p).ToList();

                if (!String.IsNullOrEmpty(search))
                {
                    result = (from p in result
                              where (p.FirstName.Contains(search) || p.LastName.Contains(search))
                              select p).ToList();
                }

                return result;
            }
            catch { return null; }
        }

        public Patient GetPatient(int patientId)
        {
            try
            {
                Patient patient = entities.Patients.Find(patientId);
                return patient;
            }
            catch { return null; }
        }
    }
}