﻿using System;
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
using Telerik.WinControls.Enumerations;

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
            lblPatientId.Text = patientId.ToString();

            if (_patientid != 0)
            {
                btnSavePatient.Visible = false;
                lblPatientId.Text = _patientid.ToString();
                btnUpdate.Visible = true;
                btnAdvanced.Visible = true;
                PopulatePatient(_patientid);
            }
            else
            {

                btnSavePatient.Visible = true;
                btnUpdate.Visible = false;
                btnAdvanced.Visible = false;
            }
        }

        private void PopulatePatient(int patientId)
        {
            Patient patient = new PatientData().GetPatientById(patientId);

            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtMiddleName.Text = patient.MiddleName;
            if (patient.Gender.Trim() == "M")
            {
                chkMale.Checked = true; chkFemale.Checked = false;
            }
            else
            {
                chkMale.Checked = false; chkFemale.Checked = true;
            }
            txtMobile.Text = patient.Mobile;
            txtPhone.Text = patient.HomePhone;
            txtAddress.Text = patient.Address;
            txtEmail.Text = patient.Email;
            txtAge.Text = patient.Age.ToString();

            PopulateData.SelectDropDownItem(ddlHospital, patient.HospitalId.ToString().Trim());
            if(patient.Prefix.Trim() != "")
                ddlPrefix.FindItemExact(patient.Prefix.Trim(), false).Selected = true;
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            bool result = true;
            try
            {
                Patient patient = new Patient();
                patient.Prefix = ddlPrefix.SelectedItem.Text;
                patient.FirstName = txtFirstName.Text.Trim();
                patient.MiddleName = txtMiddleName.Text.Trim();
                patient.LastName = txtLastName.Text.Trim();
                patient.Age = GetAgeValue();
                patient.Gender = chkMale.Checked ? "M" : "F";
                patient.Address = txtAddress.Text;
                patient.Mobile = txtMobile.Text.Trim();
                patient.HomePhone = txtPhone.Text.Trim();
                patient.Email = txtEmail.Text;
                patient.HospitalId = Convert.ToInt32(ddlHospital.SelectedValue.ToString());
                patient.CreatedOn = DateTime.Now;
                patient.UpdatedOn = DateTime.Now;
                
                PatientData patientObject = new PatientData();
                _patientid = patientObject.AddPatient(patient);
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

            try
            {
                int patientid = Convert.ToInt32(lblPatientId.Text);
                Patient patient = new PatientData().GetPatientById(patientid);

                patient.Prefix = ddlPrefix.SelectedItem.Text;
                patient.FirstName = txtFirstName.Text.Trim();
                patient.MiddleName = txtMiddleName.Text.Trim();
                patient.LastName = txtLastName.Text.Trim();
                patient.Age = GetAgeValue();
                patient.Gender = chkMale.Checked ? "M" : "F";
                patient.Address = txtAddress.Text;
                patient.Mobile = txtMobile.Text.Trim();
                patient.HomePhone = txtPhone.Text.Trim();
                patient.Email = txtEmail.Text;
                patient.HospitalId = Convert.ToInt32(ddlHospital.SelectedValue.ToString());

                patient.KnownIllness = txtMedicalIssues.Text;
                patient.KnownAllergy = txtAllergies.Text;
                patient.Medications = txtMedication.Text;
                patient.ReferredBy = txtReferredBy.Text;
                patient.FamilyHistory = txtFamilyHistory.Text;
                patient.SocioEconomicStatus = txtSocioStatus.Text;
                patient.Diet = txtDiet.Text;
                patient.IsSmoker = chkSmoker.Checked;
                patient.SmokingInfo = txtSmoker.Text;
                patient.IsAlchoholic = chkAlchoholic.Checked;
                patient.AlchoholInfo = txtAlchoholic.Text;
                patient.MedicalInsurance = txtMeicalInsurance.Text;

                patient.UpdatedOn = DateTime.Now;

                new PatientData().UpdatePatient(patient);
            }
            catch { MessageBox.Show("Error updating patient : Please contact support"); return; }

            //try
            //{
            //    PatientData patientObject = new PatientData();
            //    result = patientObject.UpdatePatient(_patientid, ddlPrefix.SelectedItem.Text, firstname, txtMiddleName.Text, lastname, chkMale.Checked ? "M" : "F", txtAddress.Text,
            //                                        age, mobile, txtPhone.Text,
            //                                        txtEmail.Text, Convert.ToInt32(ddlHospital.SelectedValue.ToString()));
            //}
            //catch { MessageBox.Show("Error updating patient : Please contact support"); return; }

            //if (result)
            //{
            //    MessageBox.Show("Patient successfully updated");

            //    //Open Patient hub
            //}
            //else
            //{
            //    MessageBox.Show("Error updating patient : Please contact support");
            //    return;
            //}
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

        private void btnAdvanced_ToggleStateChanging(object sender, StateChangingEventArgs args)
        {
            if (!(btnAdvanced.ToggleState == ToggleState.On))
            { btnAdvanced.Text = "Hide Advanced Data"; boxAdvanced.Visible = true; } 
            else
            { btnAdvanced.Text = "Show Advanced Data"; boxAdvanced.Visible = false; } 
        }
    }
}
