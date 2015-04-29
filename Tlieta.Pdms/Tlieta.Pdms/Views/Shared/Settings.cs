using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tlieta.Pdms.DB;
using Tlieta.Pdms.Properties;

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
                    MessageBox.Show("Operation added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add operation : contact Admin");
                }
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            string name = txtDiagnosisName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter diagnosis name");
                return;
            }
            else
            {
                Diagnosis diagnosis = new Diagnosis() { DiagnosisName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddDiagnosis(diagnosis);
                if (result)
                {
                    txtDiagnosisName.Text = "";
                    MessageBox.Show("Diagnosis added successfully");
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
                Employee employee = new Employee() { FirstName = name, RoleId = role, CreatedOn = DateTime.Now };
                employee.Password = Encryption.Encrypt(Resources.EncryptionKey, Resources.DefaultPassword);
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

        private void btnAddInvestigation_Click(object sender, EventArgs e)
        {
            string name = txtInvestigationName.Text.Trim();
            string value = txtInvestigationValue.Text.Trim();

            if (name == "" || value == "")
            {
                MessageBox.Show("Enter name and value");
                return;
            }
            else
            {
                LabInvestigation labinvestigation = new LabInvestigation () { LabInvestigationName = name, NormalValue = value, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddLabInvestigation(labinvestigation);
                if (result)
                {
                    txtInvestigationName.Text = "";
                    txtInvestigationValue.Text = "";
                    MessageBox.Show("Lab Investigation added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add Lab Investigation : contact Admin");
                }
            }
        }

        private void btnAddDosageFrequency_Click(object sender, EventArgs e)
        {
            string name = txtDosageFrequency.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter dosage frequency");
                return;
            }
            else
            {
                DosageFrequency dosagefrequency = new DosageFrequency() { DosageFrequencyName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddDosageFrequency(dosagefrequency);
                if (result)
                {
                    txtDosageFrequency.Text = "";
                    MessageBox.Show("Dosage frequency added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add dosage frequency : contact Admin");
                }
            }
        }

        private void btnAddDosageDuration_Click(object sender, EventArgs e)
        {
            string name = txtDosageDuration.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter dosage duration");
                return;
            }
            else
            {
                DosageDuration dosageduration = new DosageDuration() { DosageDurationName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddDosageDuration(dosageduration);
                if (result)
                {
                    txtDosageDuration.Text = "";
                    MessageBox.Show("Dosage duration added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add dosage duration : contact Admin");
                }
            }
        }

        private void btnAddOtherAdvise_Click(object sender, EventArgs e)
        {
            string name = txtOtherAdvise.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter advise");
                return;
            }
            else
            {
                OtherAdvise otheradvise = new OtherAdvise() { OtherAdviseName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddOtherAdvise(otheradvise);
                if (result)
                {
                    txtOtherAdvise.Text = "";
                    MessageBox.Show("Advise added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add advise : contact Admin");
                }
            }
        }

        private void btnAddImaging_Click(object sender, EventArgs e)
        {
            string name = txtImagingName.Text.Trim();

            if (name == "")
            {
                MessageBox.Show("Enter imaging");
                return;
            }
            else
            {
                Imaging imaging = new Imaging() { ImagingName = name, CreatedOn = DateTime.Now };
                bool result = new MasterData().AddImaging(imaging);
                if (result)
                {
                    txtImagingName.Text = "";
                    MessageBox.Show("Imaging added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add imaging : contact Admin");
                }
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            string brandname = txtBrandName.Text.Trim();

            if (brandname == "")
            {
                MessageBox.Show("Enter Brand Name");
                return;
            }
            else
            {
                Drug drug = new Drug() { 
                    BrandName = brandname, 
                    Company = txtCompany.Text.Trim(),
                    DrugContent = txtContents.Text.Trim(),
                    Formulation = txtFormulation.Text.Trim(),
                    Instructions = txtInstructions.Text.Trim(),
                    CreatedOn = DateTime.Now 
                };
                bool result = new DrugData().Add(drug);
                if (result)
                {
                    txtBrandName.Text = "";
                    txtImagingName.Text = "";
                    txtCompany.Text = "";
                    txtContents.Text = "";
                    txtFormulation.Text = "";
                    txtInstructions.Text = "";
                    MessageBox.Show("Drug added successfully");
                }
                else
                {
                    MessageBox.Show("Cannot add drug : contact Admin");
                }
            }

        }
    }
}
