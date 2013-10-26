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
                Hospital hospital = new Hospital() { HospitalName = name, Location = location };
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

            if (name == "" )
            {
                MessageBox.Show("Enter operation name");
                return;
            }
            else
            {
                Operation operation = new Operation() { OperationName = name };
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

        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string name = txtRole.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter role name");
                return;
            }
            else
            {
                Role role = new Role() { RoleName = name };
                bool result = new MasterData().AddRole(role);
                if (result)
                {
                    txtRole.Text = "";
                    MessageBox.Show("Role added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add role : contact Admin");
                }
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

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
