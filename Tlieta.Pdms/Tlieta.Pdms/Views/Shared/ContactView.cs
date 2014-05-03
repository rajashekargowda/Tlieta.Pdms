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
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class ContactView : UserControl
    {
        public ContactView()
        {
            InitializeComponent();
            try
            {
                FillGrid();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        private void FillGrid()
        {
            ContactsGrid.DataSource = new ContactData().GetContacts();
            ContactsGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            ContactsGrid.ClearSelection();
        }

        private void ContactsGrid_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                txtContactId.Text = e.Row.Cells[0].Value.ToString();
                txtName.Text = e.Row.Cells[1].Value.ToString();
                txtAddress.Text = e.Row.Cells[2].Value.ToString();
                txtMobile.Text = e.Row.Cells[3].Value.ToString();
                txtEmail.Text = e.Row.Cells[4].Value.ToString();
                txtCompany.Text = e.Row.Cells[5].Value.ToString();
                txtDesignation.Text = e.Row.Cells[6].Value.ToString();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        private void RefreshTexts()
        {
            txtContactId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtCompany.Text = "";
            txtDesignation.Text = "";
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                if (name == "")
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }

                bool result = new ContactData().AddContact(new Contact()
                {
                    ContactName = name,
                    Address = txtAddress.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Company = txtCompany.Text,
                    Designation = txtDesignation.Text,
                    UpdatedOn = DateTime.Now
                });

                if (result)
                    MessageBox.Show("Added Successfully");

                FillGrid();
                RefreshTexts();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string id = txtContactId.Text.Trim();

                if (id == "")
                {
                    MessageBox.Show("Select(double click) a contact to update");
                    return;
                }
                else if (name == "")
                {
                    MessageBox.Show("Enter all mandatory values");
                    return;
                }

                bool result = new ContactData().UpdateContact(new Contact()
                {
                    ContactId = Convert.ToInt32(id),
                    ContactName = name,
                    Address = txtAddress.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    Company = txtCompany.Text,
                    Designation = txtDesignation.Text,
                    UpdatedOn = DateTime.Now
                });

                if (result)
                    MessageBox.Show("Updated Successfully");

                FillGrid();
                RefreshTexts();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }
    }
}
