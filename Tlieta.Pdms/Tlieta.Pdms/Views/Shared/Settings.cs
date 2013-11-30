using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Settings : UserControl
    {
        public Settings(string serialkey)
        {
            InitializeComponent();

            lblProductKey.Text = serialkey;

            PopulateData.PopulateRoles(ddlRole);
        }

        private void btnAddHospital_Click(object sender, EventArgs e)
        {
            string name = txtHospitalName.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (name == "" || location == "")
            {
                MessageBox.Show("Enter name and location");
                return;
            }
            else
            {
                Hospital hospital = new Hospital() { HospitalName = name, Location = location, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddHospital(hospital);
                if (result)
                {
                    txtHospitalName.Text = "";
                    txtLocation.Text = "";
                    MessageBox.Show("Hospital added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add hospital : contact Admin");
                }
            }
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            string name = txtOperationName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter operation name");
                return;
            }
            else
            {
                Operation operation = new Operation() { OperationName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddOperation(operation);
                if (result)
                {
                    txtOperationName.Text = "";
                    MessageBox.Show("Operation name added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add operation : contact Admin");
                }
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEmployee.Text.Trim();
            int role = Convert.ToInt32(ddlRole.SelectedValue);

            if (name == "")
            {
                MessageBox.Show("Enter employee name");
                return;
            }
            else if (role == 0)
            {
                MessageBox.Show("Select role");
                return;
            }
            else
            {
                Employee employee = new Employee() { EmployeeName = name, RoleId = role, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddEmployee(employee);

                if (result)
                {
                    txtEmployee.Text = "";
                    ddlRole.SelectedIndex = ddlRole.FindString("Select");
                    MessageBox.Show("Employee added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add employee : contact Admin");
                }
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            //string name = txtRole.Text.Trim();

            //if (name == "")
            //{
            //    MessageBox.Show("Enter role name");
            //    return;
            //}
            //else
            //{
            //    Role role = new Role() { RoleName = name };
            //    bool result = new MasterData().AddRole(role);
            //    if (result)
            //    {
            //        txtRole.Text = "";
            //        MessageBox.Show("Role added successfully");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Cannot add role : contact Admin");
            //    }
            //}
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string name = txtServiceName.Text.Trim();
            double cost = 0;

            if (name == "")
            {
                MessageBox.Show("Enter service name");
                return;
            }
            else
            {
                try
                {
                    cost = Convert.ToDouble(txtCharges.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Enter valid charge value");
                    return;
                }

                Service service = new Service() { ServiceName = name, Cost = cost, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddService(service);
                if (result)
                {
                    txtServiceName.Text = "";
                    txtCharges.Text = "";
                    MessageBox.Show("Service added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add service : contact Admin");
                }
            }
        }

        private void btnAddPrefix_Click(object sender, EventArgs e)
        {

        }

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDosageFrequency_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDosageDuration_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOtherAdvise_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {

        }
    }
}
