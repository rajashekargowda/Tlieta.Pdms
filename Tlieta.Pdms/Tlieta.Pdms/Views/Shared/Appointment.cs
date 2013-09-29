using System;
using System.Data;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;
using Telerik.WinControls.Themes;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class Appointment : UserControl
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
            DateTime starttime = (DateTime)(radTimeStart.Value);
            DateTime appointment = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

            int result = new AppointmentData().AddSchedule(
                                            appointment,
                                            txtName.Text,
                                            txtPatientId.Text,
                                            txtMobile.Text,
                                            txtEmail.Text);
            if (result == -1)
                MessageBox.Show("Added Successfully");

            RefreshTexts();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            string id = txtAppointmentId.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("Select(double click) an appointment to update");
                return;
            }
            DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
            DateTime starttime = (DateTime)(radTimeStart.Value);
            DateTime appointment = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

            int result = new AppointmentData().UpdateSchedule(
                                            Convert.ToInt32(id),
                                            appointment,
                                            txtName.Text,
                                            txtPatientId.Text,
                                            txtMobile.Text,
                                            txtEmail.Text);
            if (result == -1)
                MessageBox.Show("Updated Successfully");

            FillGrid();
            RefreshTexts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtAppointmentId.Text.Trim();
            if (id == "")
            {
                MessageBox.Show("Select(double click) a contact to delete");
                return;
            }

            int result = new AppointmentData().DeleteSchedule(
                                            Convert.ToInt32(id));
            if (result == -1)
                MessageBox.Show("Deleted Successfully");

            FillGrid();
            RefreshTexts();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrid();
            }
            catch { }

        }

        private void FillGrid()
        {
            DateTime from = GetDateFromControl(FromDate);
            DateTime to = GetDateFromControl(ToDate);

            DataTable dt = new AppointmentData().GetAppointments(from, to);

            AppointmentsGrid.DataSource = dt;
            AppointmentsGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            AppointmentsGrid.ClearSelection();

            //SearchGrid.Columns[0].Width = 170;
            //SearchGrid.Columns[1].Width = 120;
            //SearchGrid.Columns[2].Width = 50;
            //SearchGrid.Columns[3].Width = 50;

            AppointmentsGrid.Columns["AppointmentId"].IsVisible = false;
            //SearchGrid.Columns[1].Width = 120;

            AppointmentsGrid.Columns[0].AllowFiltering = false;
            AppointmentsGrid.Columns[1].AllowFiltering = false;
            AppointmentsGrid.Columns[2].AllowFiltering = false;
            AppointmentsGrid.Columns[3].AllowFiltering = false;
            AppointmentsGrid.Columns[4].AllowFiltering = false;
            AppointmentsGrid.Columns[5].AllowFiltering = false;
        }

        private DateTime GetDateFromControl(Telerik.WinControls.UI.RadDateTimePicker date)
        {
            try
            {
                return (DateTime)(date.DateTimePickerElement.Value);
            }
            catch { return DateTime.Now; }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.AppointmentsGrid.Print(true, this.radPrintDocument1);
        }

        private void AppointmentsGrid_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                txtAppointmentId.Text = e.Row.Cells["AppointmentId"].Value.ToString();
                txtName.Text = e.Row.Cells["Name"].Value.ToString();
                txtEmail.Text = e.Row.Cells["Email"].Value.ToString();
                txtPatientId.Text = e.Row.Cells["PatientId"].Value.ToString();
                txtMobile.Text = e.Row.Cells["Mobile"].Value.ToString();

                DateTime appointment = Convert.ToDateTime(e.Row.Cells["AppointmentDate"].Value.ToString());
                radDateStart.Value = appointment;
                radTimeStart.Value = appointment;
            }
            catch { }
        }

        private void RefreshTexts()
        {
            txtAppointmentId.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtPatientId.Text = "";
            txtEmail.Text = "";
        }
    }
}
