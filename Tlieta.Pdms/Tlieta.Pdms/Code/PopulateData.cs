using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls.UI;
using Tlieta.Pdms.Code;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    static class PopulateData
    {
        public static void PopulateHospital(RadDropDownList ddl)
        {
            try
            {
                List<Hospital> hospitals = new MasterData().GetHospitals();
                hospitals.Insert(0, new Hospital() { HospitalId = 0, HospitalName = "Select Hospital" });

                ddl.DataSource = hospitals;
                ddl.ValueMember = "HospitalId";
                ddl.DisplayMember = "HospitalName";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void PopulateOperations(RadDropDownList ddl)
        {
            try
            {
                List<Operation> operations = new MasterData().GetOperations();
                operations.Insert(0, new Operation() { OperationId = 0, OperationName = "Select Operation" });

                ddl.DataSource = operations;
                ddl.ValueMember = "OperationId";
                ddl.DisplayMember = "OperationName";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void PopulateEmployees(RadDropDownList ddl, Roles role)
        {
            try
            {
                List<Employee> employees = new MasterData().GetEmployees().Where(e => e.RoleId == (int)role).ToList();
                employees.Insert(0, new Employee() { EmployeeId = 0, EmployeeName = "Select" });

                ddl.DataSource = employees;
                ddl.ValueMember = "EmployeeId";
                ddl.DisplayMember = "EmployeeName";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void PopulateRoles(RadDropDownList ddl)
        {
            try
            {
                List<Role> roles = new MasterData().GetRoles();
                roles.Insert(0, new Role() { RoleId = 0, RoleName = "Select" });

                ddl.DataSource = roles;
                ddl.ValueMember = "RoleId";
                ddl.DisplayMember = "RoleName";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void SelectDropDownItem(RadDropDownList ddl, string value)
        {
            try
            {
                foreach (RadListDataItem item in ddl.Items)
                {
                    if (item.Value.ToString() == value)
                    {
                        item.Selected = true; return;
                    }
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void SelectListItem(RadListControl lst, string[] values)
        {
            try
            {
                foreach (RadListDataItem item in lst.Items)
                {
                    if (values.Contains(item.Value.ToString()))
                    {
                        item.Selected = true;
                    }
                }
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void PopulateComplaintTemplate(RadDropDownList ddl)
        {
            try
            {
                List<ComplaintTemplate> complaints = new TemplateData().GetComplaintTemplate();
                complaints.Insert(0, new ComplaintTemplate() { ComplaintTemplateId = 0, ComplaintTemplateText = "New Template" });

                ddl.DataSource = complaints;
                ddl.ValueMember = "ComplaintTemplateId";
                ddl.DisplayMember = "ComplaintTemplateText";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        public static void PopulateExaminationTemplate(RadDropDownList ddl)
        {
            try
            {
                List<ExaminationTemplate> examination = new TemplateData().GetExaminationTemplate();
                examination.Insert(0, new ExaminationTemplate() { ExaminationTemplateId = 0, ExaminationTemplateText = "New Template" });

                ddl.DataSource = examination;
                ddl.ValueMember = "ExaminationTemplateId";
                ddl.DisplayMember = "ExaminationTemplateText";
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }
    }
}
