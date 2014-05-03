using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tlieta.Pdms.DB
{
    public class UserData : BaseData
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                employees = (from e in entities.Employees select e).OrderBy(x => x.EmployeeName).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return employees;
        }

        public List<Employee> GetEmployeesByRole(int roleid)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                employees = (from e in entities.Employees select e).Where(r => r.RoleId == roleid).OrderBy(x => x.EmployeeName).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return employees;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                roles = (from e in entities.Roles select e).ToList();
            }
            catch (Exception x)
            {
                throw x;
            }
            return roles;
        }

        public Employee Authenticate(Employee model)
        {
            model.RoleId = 0;
            try
            {
                Employee employee = entities.Employees.Where(x => x.UserId == model.UserId).SingleOrDefault();
                if (employee != null)
                {
                    if(employee.Password == model.Password)
                        return employee;
                }
            }
            catch (Exception x)
            {
                throw x;
            }
            return model;
        }

        public bool Add(Employee model)
        {
            try
            {
                entities.Employees.Add(model);
                entities.SaveChanges();
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        public bool Update(Employee model)
        {
            try
            {
                Employee employee = entities.Employees.Where(x => x.EmployeeId == model.EmployeeId).SingleOrDefault();
                if (employee != null)
                {
                    entities.Entry(employee).CurrentValues.SetValues(model);
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
                throw x;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                var result = entities.Employees.Where(x => x.EmployeeId == Id);
                if (result.Count() > 0)
                {
                    Employee employee = result.First();
                    entities.Employees.Remove(employee);
                    entities.SaveChanges();
                }
                return true;
            }
            catch (Exception x)
            {
                throw x;
            }
        }
    }
}