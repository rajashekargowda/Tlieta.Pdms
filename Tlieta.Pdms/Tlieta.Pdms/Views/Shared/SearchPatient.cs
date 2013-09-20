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
using Telerik.WinControls.Themes;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class SearchPatient : UserControl
    {
        public SearchPatient()
        {
            InitializeComponent();

            new TelerikMetroTheme();

            PopulateData.PopulateHospital(ddlHospital);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new PatientData().GetSearchResult(txtName.Text, Convert.ToInt32(ddlHospital.SelectedValue.ToString()),0); //ddlOperation.SelectedValue.ToString());

            SearchGrid.DataSource = dt;
            SearchGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            SearchGrid.ClearSelection();
        }

        private void SearchGrid_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                int _patientId = Convert.ToInt32(e.Row.Cells[0].Value.ToString());
                new PatientForm(_patientId).ShowDialog();
            }
            catch { }
        }
    }
}
