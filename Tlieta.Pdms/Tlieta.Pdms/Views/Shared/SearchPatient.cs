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
using Telerik.WinControls.Themes;
using Tlieta.Pdms.Code;

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
            List<Patient> patients = new PatientData().GetSearchResult(txtName.Text, Convert.ToInt32(ddlHospital.SelectedValue.ToString()));
            var result = from p in patients
                         select new {
                             Id = p.PatientId,
                             Name = p.FirstName + " " + p.LastName,
                             Age = Utility.GetAgeFromDob(p.DOB),
                             Gender = p.Gender,
                             Mobile = p.Mobile,
                             HomePhone = p.HomePhone,
                             Email = p.Email
                         };


            SearchGrid.DataSource = result;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateData.PopulateHospital(ddlHospital);
        }
    }
}
