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
    public partial class Measurements : UserControl
    {
        private int _patientid = 0;

        public Measurements(int patientid)
        {
            InitializeComponent();
            _patientid = patientid;
            FillGrid();
        }

        private void FillGrid()
        {
            MeasurementGrid.DataSource = new PatientVitalData().GetPatientVital(_patientid);
            MeasurementGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            MeasurementGrid.ClearSelection();
            MeasurementGrid.Columns[0].IsVisible = false;
            MeasurementGrid.Columns[1].IsVisible = false;
        }

        private void btnAddMeasurement_Click(object sender, EventArgs e)
        {
            PatientVital vital = new PatientVital();
            vital.PatientId = _patientid;
            vital.BPHigh = txtBPHigh.Text;
            vital.BPLow = txtBPLow.Text;
            vital.PulseRate = txtPR.Text;
            vital.RespiratoryRate = txtRR.Text;
            vital.Temperature = txtTemp.Text;
            vital.Height = txtHeight.Text;
            vital.Weight = txtWeight.Text;
            vital.BMI = txtBMI.Text;
            vital.TimeLine = DateTime.Now;

            bool result = new PatientVitalData().AddPatientVital(vital);

            if (result)
                MessageBox.Show("Added Successfully");

            FillGrid();
            RefreshTexts();
        }

        private void RefreshTexts()
        {
            txtBPHigh.Text = "";
            txtBPLow.Text = "";
            txtPR.Text = "";
            txtRR.Text = "";
            txtTemp.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtBMI.Text = "";
        }
    }
}
