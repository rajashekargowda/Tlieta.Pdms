using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    static class PopulateData
    {
        public static void PopulateHospital(RadDropDownList ddl)
        {
            List<Hospital> hospitals = new MasterData().GetHospitals();
            hospitals.Insert(0, new Hospital() { HospitalId = 0, HospitalName = "Select Hospital" });

            ddl.DataSource = hospitals;
            ddl.ValueMember = "HospitalId";
            ddl.DisplayMember = "HospitalName";
        }

        public static void PopulateOperations(RadDropDownList ddl)
        {
            List<Operation> operations = new MasterData().GetOperations();
            operations.Insert(0, new Operation() { OperationId = 0, OperationName = "Select Operation" });

            ddl.DataSource = operations;
            ddl.ValueMember = "OperationId";
            ddl.DisplayMember = "OperationName";
        }

        public static void PopulateEmployees(RadDropDownList ddl, Roles role)
        {
            List<Employee> employees = new MasterData().GetEmployees().Where(e => e.RoleId == (int)role).ToList();
            employees.Insert(0, new Employee() { EmployeeId = 0, EmployeeName = "Select" });

            ddl.DataSource = employees;
            ddl.ValueMember = "EmployeeId";
            ddl.DisplayMember = "EmployeeName";
        }

        public static void SelectDropDownItem(RadDropDownList ddl, string value)
        {
            foreach (RadListDataItem item in ddl.Items)
            {
                if (item.Value.ToString() == value)
                {
                    item.Selected = true; return;
                }
            }
        }

        public static void SelectListItem(RadListControl lst, string[] values)
        {
            foreach (RadListDataItem item in lst.Items)
            {
                if(values.Contains(item.Value.ToString()))
                {
                    item.Selected = true;
                }
            }
        }
    }
}
