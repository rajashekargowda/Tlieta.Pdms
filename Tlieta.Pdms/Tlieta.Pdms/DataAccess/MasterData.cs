using System.Collections.Generic;
using System.Linq;

namespace Tlieta.Pdms.DataAccess
{
    public class MasterData
    {
        PDMSDataEntities entities = new PDMSDataEntities();

        public List<Hospital> GetHospitals()
        {
            try
            {
                return (from h in entities.Hospitals select h).ToList();
            }
            catch { return null; }
        }

        public bool AddHospital(Hospital hospital)
        {
            try
            {
                entities.Hospitals.Add(hospital);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Operation> GetOperations()
        {
            try
            {
                return (from o in entities.Operations select o).ToList();
            }
            catch { return null; }
        }

        public bool AddOperation(Operation operation)
        {
            try
            {
                entities.Operations.Add(operation);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                return (from e in entities.Employees select e).ToList();
            }
            catch { return null; }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                entities.Employees.Add(employee);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Role> GetRoles()
        {
            try
            {
                return (from r in entities.Roles select r).ToList();
            }
            catch { return null; }
        }

        public bool AddRole(Role role)
        {
            try
            {
                entities.Roles.Add(role);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }

        public List<Service> GetServices()
        {
            try
            {
                return (from e in entities.Services select e).ToList();
            }
            catch { return null; }
        }

        public bool AddService(Service service)
        {
            try
            {
                entities.Services.Add(service);
                entities.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
