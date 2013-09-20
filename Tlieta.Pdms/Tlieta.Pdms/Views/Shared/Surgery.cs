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
using Telerik.WinControls.UI;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Surgery : UserControl
    {
        private int _patientid = 0;
        public Surgery(int patientid)
        {
            InitializeComponent();
            _patientid = patientid;
            panelACL.Visible = false;
            btnAddSurgery.Visible = true;
            btnUpdate.Visible = false;
        }

        private void Surgery_Load(object sender, EventArgs e)
        {
            PopulateSurgery();
            PopulateData.PopulateHospital(ddlHospital);
            PopulateData.PopulateOperations(ddlOpertaion);
            PopulateImplants();
            PopulateData.PopulateACLSubType(ddlACLSubType);
            PopulateData.PopulateGraftSize(ddlGraftSize);
        }

        private void PopulateImplants()
        {
            listImplants.Items.Clear();

            DataTable dt = new MasterData().GetImplants();

            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Value = r["ImplantId"].ToString();
                    item.Text = r["ImplantName"].ToString();
                    listImplants.Items.Add(item);
                }
            }
        }

        private void PopulateSurgery()
        {
            listSurgery.Items.Clear();

            DataTable dt = new SurgeryData().GetSurgeriesForPatient(_patientid);

            if (dt != null)
            {
                DataRow dr = dt.NewRow(); dr[0] = "0"; dr[1] = "New"; dt.Rows.InsertAt(dr,0);

                foreach (DataRow r in dt.Rows)
                {
                    RadListDataItem item = new RadListDataItem();
                    item.Value = r[0].ToString();
                    item.Text = r[1].ToString();
                    listSurgery.Items.Add(item);
                }

                listSurgery.SelectedValue = "0";
                btnAddSurgery.Visible = true;
                btnUpdate.Visible = false;
            }
        }

        private void btnAddSurgery_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = true;
                DateTime dos = (DateTime)(datetimeSurgery.DateTimePickerElement.Value);
                int operation = Convert.ToInt32(ddlOpertaion.SelectedValue.ToString().Trim());
                int hospital = Convert.ToInt32(ddlHospital.SelectedValue.ToString().Trim());

                if (dos == DateTime.MinValue || operation == 0 || hospital == 0)
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }

                //int implant = Convert.ToInt32(ddlImplant.SelectedValue.ToString().Trim());
                int aclsubtype = Convert.ToInt32(ddlACLSubType.SelectedValue.ToString().Trim());
                int graftsize = Convert.ToInt32(ddlGraftSize.SelectedValue.ToString().Trim());

                try
                {
                    SurgeryData data = new SurgeryData();
                    int surgeryid = data.AddSurgery(_patientid, dos, operation, aclsubtype, graftsize, hospital, 0, txtIPNumber.Text.Trim(), txtNotes.Text.Trim());
                    foreach (RadListDataItem item in listImplants.SelectedItems)
                    {
                        data.AddSurgeryImplants(surgeryid, Convert.ToInt32(item.Value.ToString()));
                    }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool result = true;
                RadListDataItem item = listSurgery.SelectedItem;
                int surgeryid = Convert.ToInt32(item.Value.ToString().Trim());
                DateTime dos = (DateTime)(datetimeSurgery.DateTimePickerElement.Value);
                int operation = Convert.ToInt32(ddlOpertaion.SelectedValue.ToString().Trim());
                int hospital = Convert.ToInt32(ddlHospital.SelectedValue.ToString().Trim());

                if (dos == DateTime.MinValue || operation == 0 || hospital == 0)
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }

                //int implant = Convert.ToInt32(ddlImplant.SelectedValue.ToString().Trim());
                int aclsubtype = Convert.ToInt32(ddlACLSubType.SelectedValue.ToString().Trim());
                int graftsize = Convert.ToInt32(ddlGraftSize.SelectedValue.ToString().Trim());

                try
                {
                    SurgeryData data = new SurgeryData();
                    data.UpdateSurgery(surgeryid, _patientid, dos, operation, aclsubtype, graftsize, hospital, 0, txtIPNumber.Text.Trim(), txtNotes.Text.Trim());
                    foreach (RadListDataItem implantitem in listImplants.SelectedItems)
                    {
                        data.AddSurgeryImplants(surgeryid, Convert.ToInt32(implantitem.Value.ToString()));
                    }
                }
                catch { result = false; }

                if (result)
                {
                    //PopulateSurgery();
                    //RefreshControls();
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

        private void ddlOpertaion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RadListDataItem item = ddlOpertaion.SelectedItem;
            if (item.Text.StartsWith("ACL"))
                panelACL.Visible = true;
            else
                panelACL.Visible = false;
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
                DataSet ds = new SurgeryData().GetSurgeriesById(surgeryid);
                if (ds != null)
                {
                    DataTable dt = ds.Tables[0];
                    datetimeSurgery.Value = Convert.ToDateTime(dt.Rows[0]["SurgeryDate"].ToString());
                    txtIPNumber.Text = dt.Rows[0]["IPNumber"].ToString();
                    txtNotes.Text = dt.Rows[0]["Notes"].ToString();
                    PopulateData.SelectDropDownItem(ddlHospital, dt.Rows[0]["HospitalId"].ToString().Trim());
                    PopulateData.SelectDropDownItem(ddlOpertaion, dt.Rows[0]["OperationId"].ToString().Trim());
                    PopulateData.SelectDropDownItem(ddlACLSubType, dt.Rows[0]["ACLSubTypeId"].ToString().Trim());
                    PopulateData.SelectDropDownItem(ddlGraftSize, dt.Rows[0]["GraftSizeId"].ToString().Trim());

                    RadListDataItem item = ddlOpertaion.SelectedItem;
                    if (item.Text.StartsWith("ACL"))
                        panelACL.Visible = true;
                    else
                        panelACL.Visible = false;

                    SelectImplants(ds.Tables[1]);
                }
            }
            catch
            {
                MessageBox.Show("Error while fetching surgery details : contact admin");
                return;
            }
        }

        private void SelectImplants(DataTable dt)
        {
            try
            {
                PopulateImplants();

                int i = 0;
                string[] values = new string[dt.Rows.Count];
                foreach (DataRow row in dt.Rows)
                {
                    values.SetValue(row[0].ToString(), i);
                    i++;
                }
                PopulateData.SelectListItem(listImplants, values);
            }
            catch { }
        }

        private void RefreshControls()
        {
            try
            {
                panelACL.Visible = false;
                btnAddSurgery.Visible = true;
                btnUpdate.Visible = false;

                txtIPNumber.Text = "";
                txtNotes.Text = "";

                ddlHospital.SelectedIndex = ddlHospital.FindString("Select");
                ddlOpertaion.SelectedIndex = ddlOpertaion.FindString("Select");

                PopulateImplants();

                txtIPNumber.Text = "";
                txtNotes.Text = "";
            }
            catch { }
        }
    }
}
