using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Themes;
using Tlieta.Pdms.DataAccess;
using Telerik.WinControls.UI;
using System.IO;
using System.Configuration;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class EditPatient : UserControl
    {
        private int _patientid = 0;

        public EditPatient(int patientId)
        {
            InitializeComponent();
            btnSavePatient.Visible = true;
            PopulateData.PopulateHospital(ddlHospital);

            new TelerikMetroTheme();

            _patientid = patientId;
            if (_patientid != 0)
            {
                btnSavePatient.Visible = false;
                btnUpdate.Visible = true;
                PopulatePatient(_patientid);
            }
            else
            {

                btnSavePatient.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void PopulatePatient(int patientId)
        {
            DataTable dt = new PatientData().GetPatientById(patientId);

            txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dt.Rows[0]["LastName"].ToString();
            txtMiddleName.Text = dt.Rows[0]["MiddleName"].ToString();
            if (dt.Rows[0]["Gender"].ToString().Trim() == "M")
            {
                chkMale.Checked = true; chkFemale.Checked = false;
            }
            else
            {
                chkMale.Checked = false; chkFemale.Checked = true;
            }
            txtMobile.Text = dt.Rows[0]["Mobile"].ToString();
            txtPhone.Text = dt.Rows[0]["HomePhone"].ToString();
            txtAddress.Text = dt.Rows[0]["Address"].ToString();
            txtEmail.Text = dt.Rows[0]["Email"].ToString();
            txtAge.Text = dt.Rows[0]["Age"].ToString();

            PopulateData.SelectDropDownItem(ddlHospital, dt.Rows[0]["HospitalId"].ToString().Trim());
            if(dt.Rows[0]["Prefix"].ToString().Trim() != "")
                ddlPrefix.FindItemExact(dt.Rows[0]["Prefix"].ToString().Trim(), false).Selected = true;
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = true;
                string firstname = txtFirstName.Text.Trim();
                string lastname = txtLastName.Text.Trim();
                string mobile = txtMobile.Text.Trim();
                int age = GetAgeValue();
                string prefix = ddlPrefix.SelectedItem == null ? "" : ddlPrefix.SelectedItem.Text;

                try
                {
                    PatientData patientObject = new PatientData();
                    _patientid = patientObject.InsertPatient(prefix, firstname, txtMiddleName.Text, lastname, chkMale.Checked ? "M" : "F", txtAddress.Text,
                                                        age, mobile, txtPhone.Text,
                                                        txtEmail.Text, Convert.ToInt32(ddlHospital.SelectedValue.ToString()));
                }
                catch { result = false; }

                if (result)
                {
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtMiddleName.Text = "";
                    txtMobile.Text = "";
                    txtPhone.Text = "";
                    txtAddress.Text = "";
                    txtEmail.Text = "";

                    //Make Dirctories
                    DataFolder.CreatePatientDataFolders(_patientid);

                    //Open Patient hub
                    new PatientForm(_patientid).ShowDialog();
                }
                else
                {
                    btnSavePatient.Visible = true;
                    MessageBox.Show("Error adding a patient : Please contact support");
                    return;
                }
            }
            catch { MessageBox.Show("Error in system : Please contact support"); return; }
        }

        private int GetAgeValue()
        {
            int age = 0;
            try
            {
                age = Convert.ToInt32(txtAge.Text.Trim());
            }
            catch { }
            return age;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool result = true;
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            int age = GetAgeValue();

            try
            {
                PatientData patientObject = new PatientData();
                result = patientObject.UpdatePatient(_patientid, ddlPrefix.SelectedItem.Text, firstname, txtMiddleName.Text, lastname, chkMale.Checked ? "M" : "F", txtAddress.Text,
                                                    age, mobile, txtPhone.Text,
                                                    txtEmail.Text, Convert.ToInt32(ddlHospital.SelectedValue.ToString()));
            }
            catch { MessageBox.Show("Error updating patient : Please contact support"); return; }

            if (result)
            {
                MessageBox.Show("Patient successfully updated");

                //Open Patient hub
            }
            else
            {
                MessageBox.Show("Error updating patient : Please contact support");
                return;
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName.Text = AutoCapitalize(txtFirstName.Text);
        }

        private void txtMiddleName_Leave(object sender, EventArgs e)
        {
            txtMiddleName.Text = AutoCapitalize(txtMiddleName.Text);
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName.Text = AutoCapitalize(txtLastName.Text);
        }

        private string AutoCapitalize(string p)
        {
            if (p.Trim() != "")
            {
                string result = "";
                char[] name = p.ToCharArray();
                name.SetValue((char)name.GetValue(0).ToString().ToUpper().ToCharArray().GetValue(0), 0);
                foreach (char c in name)
                {
                    result = result + c.ToString();
                }
                return result;
            }
            else
                return "";

        }
    }
}
