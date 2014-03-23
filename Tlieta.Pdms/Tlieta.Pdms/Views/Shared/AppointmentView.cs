using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tlieta.Pdms.DataAccess;
using Telerik.WinControls.Themes;
using Tlieta.Pdms.Code;

namespace Tlieta.Pdms.Views.Shared
{
    public partial class AppointmentView : UserControl
    {
        public AppointmentView()
        {
            InitializeComponent();

            radDateStart.Value = DateTime.Now;
            FromDate.Value = DateTime.Now;
            ToDate.Value = DateTime.Now;
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
                DateTime starttime = (DateTime)(radTimeStart.Value);
                DateTime appointment = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

                bool result = new AppointmentData().AddSchedule(new Appointment()
                {
                    AppointmentDate = appointment,
                    Name = txtName.Text,
                    PatientId = txtPatientId.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
                    UpdatedOn = DateTime.Now
                });

                if (result)
                    MessageBox.Show("Added Successfully");

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
                string id = txtAppointmentId.Text.Trim();
                if (id == "")
                {
                    MessageBox.Show("Select(double click) an appointment to update");
                    return;
                }
                DateTime startdate = (DateTime)(radDateStart.DateTimePickerElement.Value);
                DateTime starttime = (DateTime)(radTimeStart.Value);
                DateTime appointment = new DateTime(startdate.Year, startdate.Month, startdate.Day, starttime.Hour, starttime.Minute, starttime.Second);

                bool result = new AppointmentData().UpdateSchedule(new Appointment()
                {
                    AppointmentId = Convert.ToInt32(id),
                    AppointmentDate = appointment,
                    Name = txtName.Text,
                    PatientId = txtPatientId.Text,
                    Mobile = txtMobile.Text,
                    Email = txtEmail.Text,
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtAppointmentId.Text.Trim();
                if (id == "")
                {
                    MessageBox.Show("Select(double click) a contact to delete");
                    return;
                }

                bool result = new AppointmentData().DeleteSchedule(
                                                Convert.ToInt32(id));
                if (result)
                    MessageBox.Show("Deleted Successfully");

                FillGrid();
                RefreshTexts();
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            DateTime from = GetDateFromControl(FromDate);
            DateTime to = GetDateFromControl(ToDate);

            //DataTable dt = new AppointmentData().GetAppointments(from, to);
            List<Appointment> appointments = new AppointmentData().GetAppointments(from, to);

            AppointmentsGrid.DataSource = appointments;
            AppointmentsGrid.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            AppointmentsGrid.ClearSelection();

            AppointmentsGrid.Columns["AppointmentId"].IsVisible = false;
            AppointmentsGrid.Columns["UpdatedOn"].IsVisible = false;
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
            try
            {
                this.AppointmentsGrid.Print(true, this.radPrintDocument1);
            }
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
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
            catch (Exception x)
            {
                FileLogger.LogError(x);
            }
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
