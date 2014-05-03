using System;
using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DB
{
    public class MasterData : BaseData
    {
        public List<Hospital> GetHospitals()
        {
            try
            {
                return (from h in entities.Hospitals select h).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddHospital(Hospital hospital)
        {
            try
            {
                entities.Hospitals.Add(hospital);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Operation> GetOperations()
        {
            try
            {
                return (from o in entities.Operations select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddOperation(Operation operation)
        {
            try
            {
                entities.Operations.Add(operation);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Diagnosis> GetDiagnoses()
        {
            try
            {
                return (from o in entities.Diagnoses select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddDiagnosis(Diagnosis diagnosis)
        {
            try
            {
                entities.Diagnoses.Add(diagnosis);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                return (from e in entities.Employees select e).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Role> GetRoles()
        {
            try
            {
                return (from r in entities.Roles select r).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddRole(Role role)
        {
            try
            {
                entities.Roles.Add(role);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Service> GetServices()
        {
            try
            {
                return (from e in entities.Services select e).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddService(Service service)
        {
            try
            {
                entities.Services.Add(service);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<LabInvestigation> GetLabInvestigations()
        {
            try
            {
                return (from o in entities.LabInvestigations select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddLabInvestigation(LabInvestigation labinvestigation)
        {
            try
            {
                entities.LabInvestigations.Add(labinvestigation);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<DosageFrequency> GetDosageFrequencies()
        {
            try
            {
                return (from o in entities.DosageFrequencies select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddDosageFrequency(DosageFrequency dosagefrequency)
        {
            try
            {
                entities.DosageFrequencies.Add(dosagefrequency);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<DosageDuration> GetDosageDurations()
        {
            try
            {
                return (from o in entities.DosageDurations select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddDosageDuration(DosageDuration dosageduration)
        {
            try
            {
                entities.DosageDurations.Add(dosageduration);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<Imaging> GetImagings()
        {
            try
            {
                return (from o in entities.Imagings select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddImaging(Imaging imaging)
        {
            try
            {
                entities.Imagings.Add(imaging);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public List<OtherAdvise> GetOtherAdvises()
        {
            try
            {
                return (from o in entities.OtherAdvises select o).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool AddOtherAdvise(OtherAdvise otheradvise)
        {
            try
            {
                entities.OtherAdvises.Add(otheradvise);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}
