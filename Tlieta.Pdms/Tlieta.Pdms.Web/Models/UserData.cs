using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tlieta.Pdms.DB;
using Tlieta.Utility;

namespace Tlieta.Pdms.Web.Models
{
    public class UserData : BaseData
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                employees = (from e in entities.Employees select e).ToList();
            }
            catch { }
            return employees;
        }

        public List<Role> GetRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                roles = (from e in entities.Roles select e).ToList();
            }
            catch { }
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
            catch { }
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
            catch { return false; }
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
            catch { return false; }
        }

        public bool Delete(int Id)
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
    }
}