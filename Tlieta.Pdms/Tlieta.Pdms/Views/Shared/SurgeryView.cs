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
using Telerik.WinControls.UI;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class SurgeryView : UserControl
    {
        private int _patientid = 0;
        public SurgeryView(int patientid)
        {
            InitializeComponent();
            _patientid = patientid;
            btnAddSurgery.Visible = true;
            btnUpdate.Visible = false;
        }

        private void Surgery_Load(object sender, EventArgs e)
        {
            PopulateSurgery();
            PopulateLookUpData();
        }

        private void PopulateSurgery()
        {
            listSurgery.Items.Clear();
            listSurgery.Items.Add(new RadListDataItem() { Value = "0", Text = "New" });

            List<Surgery> surgeries = new SurgeryData().GetSurgeriesForPatient(_patientid);

            if (surgeries != null)
            {
                foreach (Surgery s in surgeries)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Value = s.SurgeryId;
                    item.Text = s.SurgeryDate.ToString();
                    listSurgery.Items.Add(item);
                }

                listSurgery.SelectedValue = "0";
                btnAddSurgery.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void btnAddSurgery_Click(object sender, EventArgs e)
        {
            bool result = true;
            try
            {
                Surgery surgery = GetSurgeryModel();

                if (surgery.SurgeryDate == DateTime.MinValue || surgery.OperationId == 0 || surgery.HospitalId == 0)
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }

                try
                {
                    int surgeryid = new SurgeryData().AddSurgery(surgery);
                    if (surgeryid == 0) { result = false; }
                }
                catch { result = false; }

                if (result)
                {
                    PopulateSurgery();
                    RefreshControls();
                    MessageBox.Show("Surgery data added successfully");
                    return;
                }
                else
                {
                    MessageBox.Show("Error while adding surgery : contact admin");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error while adding surgery : contact admin");
                return;
            }
        }

        private Surgery GetSurgeryModel()
        {
            Surgery surgery = new Surgery();
            RadListDataItem item = listSurgery.SelectedItem;
            surgery.SurgeryId = Convert.ToInt32(item.Value.ToString().Trim());
            surgery.PatientId = _patientid;
            surgery.SurgeryDate = (DateTime)(datetimeSurgery.DateTimePickerElement.Value);
            surgery.OperationId = Convert.ToInt32(ddlOpertaion.SelectedValue.ToString().Trim());
            surgery.HospitalId = Convert.ToInt32(ddlHospital.SelectedValue.ToString().Trim());
            surgery.Notes = txtNotes.Text.Trim();
            surgery.IPNumber = txtIPNumber.Text.Trim();
            surgery.PreOpDiagnosis = txtPreOpDiagnosis.Text.Trim();
            surgery.PostOpDiagnosis = txtPostOpDiagnosis.Text.Trim();
            surgery.ReferredBy = txtReferredBy.Text.Trim();
            surgery.SurgeonId = Convert.ToInt32(ddlSurgeon.SelectedValue.ToString().Trim());
            surgery.AssistantSurgeonId = Convert.ToInt32(ddlAsstSurgeon.SelectedValue.ToString().Trim());
            surgery.AnaesthetistId = Convert.ToInt32(ddlAnaesthetist.SelectedValue.ToString().Trim());
            surgery.ScrubNurseId = Convert.ToInt32(ddlScrubNurse.SelectedValue.ToString().Trim());
            return surgery;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = true;
                Surgery surgery = GetSurgeryModel();

                if (surgery.SurgeryDate == DateTime.MinValue || surgery.OperationId == 0 || surgery.HospitalId == 0)
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }
                
                try
                {
                    result = new SurgeryData().UpdateSurgery(surgery);
                }
                catch { result = false; }

                if (result)
                {
                    MessageBox.Show("Surgery data updated successfully");
                    return;
                }
                else
                {
                    MessageBox.Show("Error while updated surgery : contact admin");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error while updated surgery : contact admin");
                return;
            }            
        }

        private void listSurgery_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listSurgery.SelectedIndex != -1)
            {
                RadListDataItem item = listSurgery.SelectedItem;
                if (item.Value.ToString() == "0")
                {
                    RefreshControls();
                }
                else
                {
                    btnAddSurgery.Visible = false;
                    btnUpdate.Visible = true;

                    LoadControls(Convert.ToInt32(item.Value.ToString()));
                }
            }
        }

        private void LoadControls(int surgeryid)
        {
            try{
                Surgery surgery = new SurgeryData().GetSurgeriesById(surgeryid);
                if (surgery != null)
                {
                    datetimeSurgery.Value = (DateTime)surgery.SurgeryDate;
                    txtIPNumber.Text = surgery.IPNumber;
                    txtNotes.Text = surgery.Notes;
                    txtPreOpDiagnosis.Text = surgery.PreOpDiagnosis;
                    txtPostOpDiagnosis.Text = surgery.PostOpDiagnosis;
                    txtReferredBy.Text = surgery.ReferredBy;
                    PopulateData.SelectDropDownItem(ddlHospital, surgery.HospitalId.ToString());
                    PopulateData.SelectDropDownItem(ddlOpertaion, surgery.OperationId.ToString());
                    PopulateData.SelectDropDownItem(ddlSurgeon, surgery.SurgeonId.ToString());
                    PopulateData.SelectDropDownItem(ddlAsstSurgeon, surgery.AssistantSurgeonId.ToString());
                    PopulateData.SelectDropDownItem(ddlAnaesthetist, surgery.AnaesthetistId.ToString());
                    PopulateData.SelectDropDownItem(ddlScrubNurse, surgery.ScrubNurseId.ToString());

                }
            }
            catch
            {
                MessageBox.Show("Error while fetching surgery details : contact admin");
                return;
            }
        }

        private void RefreshControls()
        {
            try
            {
                btnAddSurgery.Visible = true;
                btnUpdate.Visible = false;

                txtIPNumber.Text = "";
                txtNotes.Text = "";

                ddlHospital.SelectedIndex = ddlHospital.FindString("Select");
                ddlOpertaion.SelectedIndex = ddlOpertaion.FindString("Select");
                ddlSurgeon.SelectedIndex = ddlSurgeon.FindString("Select");
                ddlAsstSurgeon.SelectedIndex = ddlAsstSurgeon.FindString("Select");
                ddlAnaesthetist.SelectedIndex = ddlAnaesthetist.FindString("Select");
                ddlScrubNurse.SelectedIndex = ddlScrubNurse.FindString("Select");
                
                txtIPNumber.Text = "";
                txtNotes.Text = "";
                txtPreOpDiagnosis.Text = "";
                txtPostOpDiagnosis.Text = "";
                txtReferredBy.Text = "";
            }
            catch { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateLookUpData();
        }

        private void PopulateLookUpData()
        {
            PopulateData.PopulateHospital(ddlHospital);
            PopulateData.PopulateOperations(ddlOpertaion);
            PopulateData.PopulateEmployees(ddlSurgeon, Roles.Surgeon);
            PopulateData.PopulateEmployees(ddlAsstSurgeon, Roles.Surgeon);
            PopulateData.PopulateEmployees(ddlAnaesthetist, Roles.Anaesthetist);
            PopulateData.PopulateEmployees(ddlScrubNurse, Roles.ScrubNurse);
        }
    }
}
